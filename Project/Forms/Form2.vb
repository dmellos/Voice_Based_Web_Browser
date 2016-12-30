Imports System.Data.OleDb
Imports SpeechLib
Imports System.Xml
Public Class Form2

    
    Dim WithEvents RecoContext As SpSharedRecoContext      'The Main Recognition Object Used throughout the whole program. -- Shared Object: More Info on this later.
    Dim Grammar As ISpeechRecoGrammar                      'The Grammar Object so the program knows what is going on. -- Instanced Object: More Info on this later.
    Dim CharCount As Integer                                'This is used to count the amount of chars that are in the text box.
    Public i As Integer
    Dim Browsercollection As ArrayList

    

         


    Private Sub OnReco(ByVal StreamNumber As Integer, ByVal StreamPosition As Object, ByVal RecognitionType As SpeechRecognitionType, ByVal Result As ISpeechRecoResult) Handles RecoContext.Recognition


        Dim recoResult As String = Result.PhraseInfo.GetText(0, -1, True) 'Create a new string, and assign the recognized text to it.
        Dim strNumber As String = Result.PhraseInfo.Rule.Name ' which property in the rule was matched

        'This block will print to the textbox built into the program
        'If you would prefer to use the SendKeys method, Comment out this entire block. And Uncomment the SendKeys Line.

        cboURL.Text = ""
        cboURL.SelectionStart = CharCount
        CharCount = CharCount + 1 + Len(recoResult)
        '    cboURL.SelectedText = "http://www." & recoResult & ".com"


        Dim SQL As String
        Dim reader As OleDbDataReader
        Dim objCmd As New OleDbCommand


        Dim Con = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\database.mdb")
        Con.open()
        SQL = "select URL from voicemark where tag='" & recoResult & "'"
        objCmd = New OleDbCommand(SQL, Con)
        reader = objCmd.ExecuteReader
        Do While (reader.Read())
            cboURL.Text = reader.Item("URL")
        Loop
        reader.Close()
        Con.Close()

        '      WebBrowser1.Navigate(cboURL.Text)




    End Sub

    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Form1.Stop()
        Form1.Dispose()
        Form1.Close()
    End Sub


    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        'voice_active()
        TabControl1.TabPages.Clear()
        Me.ActivateToolStripMenuItem.Enabled = False
        Me.DeactivateToolStripMenuItem.Enabled = True
        
    End Sub

    Private Sub mnuViewMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuViewMenu.Click
        If mnuViewMenu.Checked Then
            MainMenu.Show()
        Else
            MainMenu.Hide()
        End If
    End Sub

    Private Sub mnuViewMenuBar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuViewMenuBar.Click
        If mnuViewMenuBar.Checked Then
            MainMenu.Show()
        Else
            MainMenu.Hide()
        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'WebBrowser1.GoBack()
        'cboURL.Text = WebBrowser1.GoBack
    End Sub

    Private Sub btnForward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForward.Click
        ' WebBrowser1.GoForward()
        '  cboURL.Text = WebBrowser1.GoForward.ToString()
    End Sub

    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click
        '   WebBrowser1.GoHome()
    End Sub

    Private Sub VoicemarkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VoicemarkToolStripMenuItem.Click
        voice_deactive()

        Dim SQL, SQL1 As String
        Dim extract As OleDbDataReader

        Dim objCmd, objCmd1 As New OleDbCommand

        Dim Con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\database.mdb")

        Dim url, tag As String
        Dim i, count As Integer

        Con.Open()
        SQL1 = "SELECT MAX(id) FROM voicemark"
        objCmd1 = New OleDbCommand(SQL1, Con)
        i = objCmd1.ExecuteScalar()
        If (i <> 0) Then
            i = i + 1
        Else
            i = 1
        End If

        url = cboURL.Text
        If url = "" Then
            MessageBox.Show("Please enter a valid url !!! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            tag = InputBox("URL = " & cboURL.Text, "Enter Voice Tag")

            SQL = "INSERT INTO voicemark VALUES ('" & i & "','" & url & "','" & tag & "')"
            objCmd = New OleDbCommand(SQL, Con)
            objCmd.ExecuteNonQuery()

            SQL1 = "SELECT COUNT(tag) FROM voicemark"
            objCmd1 = New OleDbCommand(SQL1, Con)
            count = objCmd1.ExecuteScalar()

            SQL = "SELECT tag FROM voicemark"
            objCmd = New OleDbCommand(SQL, Con)
            extract = objCmd.ExecuteReader

            Dim myXmlWriter As New XmlTextWriter("C:\test.xml", Nothing)
            myXmlWriter.Formatting = Formatting.Indented
            myXmlWriter.Indentation = 4

            ' *** Uncomment to use XmlWriter for extra settings if necessary. Comment the 3 lines above
            'Dim myXmlSettings As New XmlWriterSettings
            'myXmlSettings.Indent = True
            'Dim myXmlWriter As XmlWriter = XmlWriter.Create(server.MapPath("test.xml"), myXmlSettings)

            myXmlWriter.WriteComment("Grammar DICTATION")
            myXmlWriter.WriteStartElement("GRAMMAR") ' <Products>
            myXmlWriter.WriteStartElement("RULE")
            myXmlWriter.WriteAttributeString("ID", 1)
            myXmlWriter.WriteAttributeString("Name", "number")
            myXmlWriter.WriteAttributeString("TOPLEVEL", "ACTIVE")
            myXmlWriter.WriteStartElement("L")
            myXmlWriter.WriteAttributeString("PROPNAME", "number")

            Dim j As Integer
            For j = 1 To count
                While (extract.Read())
                    myXmlWriter.WriteElementString("p", extract("tag").ToString) ' <Product id="">
                End While
            Next
            myXmlWriter.WriteEndElement() ' </Products>
            myXmlWriter.Close()
            extract.Close()
            Con.Close()
        End If
    End Sub

    Public Function voice_active()
        If (RecoContext Is Nothing) Then

            Debug.Print("Initializing SAPI reco context object...")
            RecoContext = New SpSharedRecoContext
            Grammar = RecoContext.CreateGrammar(1)
            Grammar.CmdLoadFromFile("C:\test.xml", SpeechLoadOption.SLODynamic)
        End If

        Grammar.DictationSetState(SpeechRuleState.SGDSInactive)
        Grammar.CmdSetRuleIdState(1, SpeechRuleState.SGDSActive)

        '       SpeechLibrary_StartSpeechRecognition()
        cboURL.Text = ""
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
            Grammar.CmdLoadFromFile("C:\test.xml", SpeechLoadOption.SLODynamic)
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

    Private Sub ActivateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActivateToolStripMenuItem.Click
        voice_active()
        Me.ActivateToolStripMenuItem.Enabled = False
        Me.DeactivateToolStripMenuItem.Enabled = True
    End Sub

    Private Sub DeactivateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeactivateToolStripMenuItem.Click
        voice_deactive()
        Me.DeactivateToolStripMenuItem.Enabled = False
        Me.ActivateToolStripMenuItem.Enabled = True
    End Sub

    Private Sub ddbtnTools_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddbtnTools.Click

    End Sub

    Private Sub CloseTabToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseTabToolStripMenuItem.Click
        Dim j As Integer
        j = TabControl1.SelectedIndex.ToString()
        j = j + 1
        TabControl1.SelectedTab.Dispose()
        'TabControl()
    End Sub

    Private Sub mnulNewTab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnulNewTab.Click
        
        Dim Browse As New WebBrowser
        TabControl1.Width = 100
        TabControl1.TabPages.Add(1, "New Tab")
        TabControl1.SelectTab(i)
        Browse.Name = "wb"
        Browse.Dock = DockStyle.Fill
        TabControl1.SelectedTab.Controls.Add(Browse)

        i = i + 1

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(cboURL.Text)

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub cboURL_Click(sender As Object, e As EventArgs) Handles cboURL.Click

    End Sub
End Class