'///////////////////////////////////////////////////////////
'This form provided from an article found at:
'http://www.freevbcode.com/ShowCode.asp?ID=6702

'The code is a little "quirky" and I did not take time to
'Clean it up, it is provided as a means of showing
'dealing with the history and cache files.
'///////////////////////////////////////////////////////////
Public Class frmHistory

    Enum LoadModes
        History = 2097153
        Cache = 0
    End Enum

    Public LoadMode As LoadModes = LoadModes.History 'Default

    Public Sub fillday2()
        Dim i As Object
        On Error GoTo rt

        Dim sdate As Date
        sdate = DateAdd(DateInterval.Day, -1, Today)

        For i = 0 To 30

            sdate = DateAdd(DateInterval.Day, -i, Today)
            cmbDay.Items.Add(CStr(sdate))
        Next i



        Exit Sub
rt:
        MsgBox(ErrorToString())
        Resume rte
rte:

    End Sub

    Private Sub frmHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mtdate As Object
        Dim xk As Object
        Dim fdate As Object
        fillday2()
        fdate = cmbDay.Text

        If IsDate(fdate) = False Then GoTo mm
        xk = Weekday(fdate, FirstDayOfWeek.Sunday)
        Select Case xk
            Case 1

                mtdate = "Monday"
            Case 2

                mtdate = "Sunday"
            Case 3

                mtdate = "Tuesday"
            Case 4

                mtdate = "Wenesday"
            Case 5

                mtdate = "Thursday"
            Case 6

                mtdate = "Friday"
            Case 7

                mtdate = "Saturday"
        End Select
mm:

        ListView1.Columns.Add("Item name", 350, HorizontalAlignment.Left)
        ListView1.Columns.Add("Last access date", 150, HorizontalAlignment.Left)
        ListView1.Columns.Add("hitrate", 50, HorizontalAlignment.Left)
        ListView1.Columns.Add("last modiefied date", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("last syntime", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("usecount", 50, HorizontalAlignment.Left)
        ListView1.Columns.Add("local file name", 300, HorizontalAlignment.Left)
        ListView1.Columns.Add("File extension", 150, HorizontalAlignment.Left)
        ListView1.Columns.Add("Fiel header info", 150, HorizontalAlignment.Left)
        ListView1.Columns.Add("File type", 100, HorizontalAlignment.Left)
        cmbDay.SelectedIndex = 0
        getcachentry(LoadMode)
    End Sub

    Private Sub getcachentry(ByVal type As String)
        Dim x As Object
        Dim sdate As Date

        If IsDate(cmbDay.Text) Then
            sdate = DateValue(cmbDay.Text)
        Else
            MsgBox("No valid date choosen)")
        End If
        sdate = Format(sdate, "short date")
        x = GetURLCache(ListView1, sdate, type)
    End Sub

    Private Sub cmbDay_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDay.SelectedIndexChanged
        Dim mtdate As Object
        Dim xk As Object
        Dim fdate As Object
        Dim sdate As Date

        fdate = cmbDay.Text

        If IsDate(fdate) = False Then Exit Sub
        xk = Weekday(fdate, FirstDayOfWeek.Sunday)
        Select Case xk
            Case 1

                mtdate = "Monday"
            Case 2

                mtdate = "Sunday"
            Case 3

                mtdate = "Tuesday"
            Case 4

                mtdate = "Wenesday"
            Case 5

                mtdate = "Thursday"
            Case 6

                mtdate = "Friday"
            Case 7

                mtdate = "Saturday"
        End Select

        sdate = DateValue(cmbDay.Text)

        getcachentry(LoadMode)
    End Sub

    Private Sub cmbDay_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDay.TextChanged

    End Sub

    Private Sub cmbDay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDay.Click

    End Sub

    Private Sub ListView1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseDoubleClick
        Dim strURL As String
        If ListView1.SelectedIndices.Count > 0 Then
            Dim li As ListViewItem = ListView1.SelectedItems(0)
            Select Case Me.LoadMode
                Case LoadModes.Cache
                    strURL = li.Text
                Case LoadModes.History
                    Dim s() As String = Split(li.Text, "@")
                    strURL = s(1)
            End Select

            Dim ofrm As frmBrowser
            Dim i As Integer
            For i = 0 To AppManager.MainForm.tc1.TabPages.Count - 1
                If TypeOf AppManager.MainForm.tc1.TabPages(i).Form Is frmBrowser Then
                    ofrm = AppManager.MainForm.tc1.TabPages(i).Form
                    If ofrm.wb Is AppManager.CurrentBrowser Then
                        AppManager.CurrentBrowser.Navigate(strURL)
                        AppManager.MainForm.tc1.TabPages(i).Select()
                        Exit Sub
                    End If
                End If
            Next
        End If
    End Sub
End Class