Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Microsoft.DirectX.DirectSound
Imports System.Threading
Imports System.Collections.Specialized
Imports System.Data.OleDb
Imports SpeechLib
Imports System.Xml

Public Class Form1
    Inherits System.Windows.Forms.Form
    Private mSpk As AgentObjects.IAgentCtlCharacter

    Dim WithEvents RecoContext As SpSharedRecoContext      'The Main Recognition Object Used throughout the whole program. -- Shared Object: More Info on this later.
    Dim Grammar As ISpeechRecoGrammar                      'The Grammar Object so the program knows what is going on. -- Instanced Object: More Info on this later.
    Dim CharCount As Integer                                'This is used to count the amount of chars that are in the text box.
    Dim i As Integer = 1


    'Place this code anywhere on your form code

#Region " ClientAreaMove Handling "
    Const WM_NCHITTEST As Integer = &H84
    Const HTCLIENT As Integer = &H1
    Const HTCAPTION As Integer = &H2
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Select Case m.Msg
            Case WM_NCHITTEST
                MyBase.WndProc(m)
                If m.Result = HTCLIENT Then m.Result = HTCAPTION
                'If m.Result.ToInt32 = HTCLIENT Then m.Result = IntPtr.op_Explicit(HTCAPTION) 'Try this in VS.NET 2002/2003 if the latter line of code doesn't do it... thx to Suhas for the tip.
            Case Else
                'Make sure you pass unhandled messages back to the default message handler.
                MyBase.WndProc(m)
        End Select
    End Sub
#End Region

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Stop()
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Const SAMPLES As Integer = 8
    Private Shared SAMPLE_FORMAT_ARRAY As Integer() = {SAMPLES, 2, 1}
    Public Shared audioDevices As CaptureDevicesCollection
    Private Shared m_deviceNames As StringCollection
    Private deviceName As String = "(none)"
    Private deviceIndex As Integer = -1
    Private buffer As Microsoft.DirectX.DirectSound.CaptureBuffer
    Private liveVolumeThread As System.Threading.Thread
    Private m_sampleDelay As Integer = 100
    Private m_frameDelay As Integer = 10
    Private m_autoStart As Boolean = True
    'Private components As System.ComponentModel.Container = Nothing 
    Public Sub FindDevices()
        Dim audioDevices As New CaptureDevicesCollection
        Dim x As Integer = 0
        While x < audioDevices.Count
            ComboBox1.Items.Add(audioDevices.Item(x).Description)
            x = x + 1
        End While
        ComboBox1.SelectedIndex = 0
    End Sub
    Public Sub Start()
        [Stop]()
        Dim audioDevices As New CaptureDevicesCollection
        deviceIndex = ComboBox1.SelectedIndex
        If deviceIndex <> -1 Then
            ' initialize the capture buffer and start the animation thread 
            Dim cap As New Capture(audioDevices(deviceIndex).DriverGuid)
            Dim desc As New CaptureBufferDescription()
            Dim wf As New WaveFormat()
            wf.BitsPerSample = 16
            wf.SamplesPerSecond = 44100
            wf.Channels = 2
            wf.BlockAlign = CShort(wf.Channels * wf.BitsPerSample / 8)
            wf.AverageBytesPerSecond = wf.BlockAlign * wf.SamplesPerSecond
            wf.FormatTag = WaveFormatTag.Pcm
            desc.Format = wf
            desc.BufferBytes = SAMPLES * wf.BlockAlign
            buffer = New Microsoft.DirectX.DirectSound.CaptureBuffer(desc, cap)
            buffer.Start(True)
            ' Start a seperate thread to read the buffer and update the progress bars 
            liveVolumeThread = New Thread(AddressOf updateProgress) 'Thread starts at updateProgress 
            Control.CheckForIllegalCrossThreadCalls = False ' This is needed otherwise the form will not update 
            liveVolumeThread.Priority = ThreadPriority.Lowest ' Thread works in the background 
            liveVolumeThread.Start()
        End If
    End Sub
    Public Sub [Stop]()
        If liveVolumeThread IsNot Nothing Then
            liveVolumeThread.Abort()
            liveVolumeThread.Join()
            liveVolumeThread = Nothing
        End If
        If buffer IsNot Nothing Then
            If buffer.Capturing Then
                buffer.[Stop]()
            End If
            buffer.Dispose()
            buffer = Nothing
        End If
    End Sub

    Public Sub updateProgress()
        While True
            Dim tempFrameDelay As Integer = m_frameDelay
            Dim tempSampleDelay As Integer = m_sampleDelay
            Dim samples__1 As Array = buffer.Read(0, GetType(Int16), LockFlag.FromWriteCursor, SAMPLE_FORMAT_ARRAY)
            ' for each channel, determine the step size necessary for each iteration 
            Dim leftGoal As Integer = 0
            Dim rightGoal As Integer = 0
            ' Sum the 8 samples 
            For i As Integer = 0 To SAMPLES - 1
                leftGoal += CType(samples__1.GetValue(i, 0, 0), Int16)
                rightGoal += CType(samples__1.GetValue(i, 1, 0), Int16)
            Next
            ' Calculate the average of the 8 samples 
            leftGoal = CInt(Math.Abs(leftGoal \ SAMPLES))
            rightGoal = CInt(Math.Abs(rightGoal \ SAMPLES))
            Dim range1 As Double = leftGoal - ProgressBar1.Value ' calculates the difference between new and the current progress bar value 
            Dim range2 As Double = rightGoal - ProgressBar2.Value
            ' Assign the exact current value to the progress bar 
            Dim exactValue1 As Double = ProgressBar1.Value
            Dim exactValue2 As Double = ProgressBar2.Value
            Dim stepSize1 As Double = range1 / tempSampleDelay * tempFrameDelay
            ' Limit the value range to positive values 
            If Math.Abs(stepSize1) < 0.01 Then
                stepSize1 = Math.Sign(range1) * 0.01
            End If
            Dim absStepSize1 As Double = Math.Abs(stepSize1)
            Dim stepSize2 As Double = range2 / tempSampleDelay * tempFrameDelay
            If Math.Abs(stepSize2) < 0.01 Then
                stepSize2 = Math.Sign(range2) * 0.01
            End If
            Dim absStepSize2 As Double = Math.Abs(stepSize2)
            ' increment/decrement the bars' values until both equal their desired goals, 
            ' sleeping between iterations 
            If (ProgressBar1.Value = leftGoal) AndAlso (ProgressBar2.Value = rightGoal) Then
                Thread.Sleep(tempSampleDelay)
            Else
                Do
                    If ProgressBar1.Value <> leftGoal Then
                        If absStepSize1 < Math.Abs(leftGoal - ProgressBar1.Value) Then
                            exactValue1 += stepSize1
                            ProgressBar1.Value = CInt(Math.Truncate(Math.Round(exactValue1)))
                            'This is the real value 
                            'decibels = 20 * Log10(ProgressBar1.Value / 32768.0)
                        Else
                            ProgressBar1.Value = leftGoal
                        End If
                    End If
                    If ProgressBar2.Value <> rightGoal Then
                        If absStepSize2 < Math.Abs(rightGoal - ProgressBar2.Value) Then
                            exactValue2 += stepSize2
                            ProgressBar2.Value = CInt(Math.Truncate(Math.Round(exactValue2)))
                        Else
                            ProgressBar2.Value = rightGoal
                        End If
                    End If
                    Thread.Sleep(tempFrameDelay)
                    Dim i() As Integer = {4000, 5000, 6000, 7000, 8000, 6500, 600}
                    If ProgressBar1.Value.Equals(i) Then
                        MsgBox("hi")
                    End If
                Loop While (ProgressBar1.Value <> leftGoal) OrElse (ProgressBar2.Value <> rightGoal)
            End If
        End While
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        mSpk.Stop()
        mSpk.MoveTo(Convert.ToInt16(Me.Location.X - 60), _
                   Convert.ToInt16(Me.Location.Y - 60))
    End Sub



    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FindDevices()
        Start()
        voice_active()
        AxAgent1.Characters.Load("Genie", "C:\WINDOWS\msagent\chars\Genie.acs")
        'Set current character to Peedy and show it
        mSpk = AxAgent1.Characters("Genie")

        Dim Enume As IEnumerator = _
          AxAgent1.Characters.Character(mSpk.Name).AnimationNames.GetEnumerator()

        ' While Enume.MoveNext
        ' ComboBox1.Items.Add(Enume.Current)
        ' End While

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Form2.Show()
    End Sub


    Private Sub OnReco(ByVal StreamNumber As Integer, ByVal StreamPosition As Object, ByVal RecognitionType As SpeechRecognitionType, ByVal Result As ISpeechRecoResult) Handles RecoContext.Recognition

        Dim Enume As IEnumerator = _
                  AxAgent1.Characters.Character(mSpk.Name).AnimationNames.GetEnumerator()

        Dim recoResult As String = Result.PhraseInfo.GetText(0, -1, True) 'Create a new string, and assign the recognized text to it.
        Dim strNumber As String = Result.PhraseInfo.Rule.Name ' which property in the rule was matched

        'This block will print to the textbox built into the program
        'If you would prefer to use the SendKeys method, Comment out this entire block. And Uncomment the SendKeys Line.


        CharCount = CharCount + 1 + Len(recoResult)

        mSpk.Show(0)

        If recoResult = "animate" Then
            AgentReact("Animate")
            If i = 1 Then
                mSpk.Play("Congratulate")
                i = i + 1
            ElseIf i = 2 Then
                mSpk.Play("DoMagic2")
                i = i + 1
            ElseIf i = 3 Then
                mSpk.Play("Search")
                i = i + 1
            ElseIf i = 4 Then
                mSpk.Play("Suggest")
                i = 1
            End If

        ElseIf recoResult = "browser" Then
            AgentReact("Browser")
            mSpk.Play("Process")
            System.Threading.Thread.Sleep(5000)
            Me.Hide()
            AxAgent1.Hide()
            voice_deactive()
            frmMain.Show()
        ElseIf recoResult = "skin" Then
            AgentReact("Skin")
            frmMain.Hide()
            Me.Show()
        End If



        '        Dim SQL As String
        '       Dim reader As OleDbDataReader
        '      Dim objCmd As New OleDbCommand


        '     Dim Con = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\database.mdb")
        '    Con.open()
        '   SQL = "select URL from voicemark where tag='" & recoResult & "'"
        '  objCmd = New OleDbCommand(SQL, Con)
        ' reader = objCmd.ExecuteReader
        'Do While (reader.Read())
        'cboURL.Text = reader.Item("URL")
        'Loop
        'reader.Close()
        'Con.Close()

        '    WebBrowser1.Navigate(cboURL.Text)




    End Sub

    Public Function AgentReact(ByVal s As String)
        mSpk.Play("Blink")
        mSpk.Speak("User said: " & s)
    End Function
    Public Function voice_active()
        If (RecoContext Is Nothing) Then

            Debug.Print("Initializing SAPI reco context object...")
            RecoContext = New SpSharedRecoContext
            Grammar = RecoContext.CreateGrammar(1)
            Grammar.CmdLoadFromFile("C:\feature.xml", SpeechLoadOption.SLODynamic)
        End If

        Grammar.DictationSetState(SpeechRuleState.SGDSInactive)
        Grammar.CmdSetRuleIdState(1, SpeechRuleState.SGDSActive)

        '       SpeechLibrary_StartSpeechRecognition()
        'cboURL.Text = ""
        '  btnBack.Enabled = False
        ' btnForward.Enabled = False
        'If WebBrowser1.CanGoBack Then
        'btnBack.Enabled = True
        'Else
        'btnBack.Enabled = False
        ' End If
        '
        '       If WebBrowser1.CanGoForward Then
        'btnForward.Enabled = True
        'Else
        'btnForward.Enabled = False
        'End If



    End Function
    Public Function voice_deactive()
        If (RecoContext Is Nothing) Then

            Debug.Print("Initializing SAPI reco context object...")
            RecoContext = New SpSharedRecoContext
            Grammar = RecoContext.CreateGrammar(1)
            Grammar.CmdLoadFromFile("C:\feature.xml", SpeechLoadOption.SLODynamic)
        End If

        Grammar.DictationSetState(SpeechRuleState.SGDSInactive)
        Grammar.CmdSetRuleIdState(1, SpeechRuleState.SGDSInactive)

        '       SpeechLibrary_StartSpeechRecognition()
        'cboURL.Text = ""
        '  btnBack.Enabled = False
        ' btnForward.Enabled = False
        'If WebBrowser1.CanGoBack Then
        'btnBack.Enabled = True
        'Else
        'btnBack.Enabled = False
        ' End If
        '
        '       If WebBrowser1.CanGoForward Then
        'btnForward.Enabled = True
        'Else
        'btnForward.Enabled = False
        'End If



    End Function
    Private Sub mainAgent_ClickEvent(ByVal sender As Object, ByVal e As AxAgentObjects._AgentEvents_ClickEvent) Handles AxAgent1.ClickEvent

        mSpk.Play("Confused")
        mSpk.Speak("Why are you Poking me ?", "")
        mSpk.Play("ResetPose")
    End Sub

    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
