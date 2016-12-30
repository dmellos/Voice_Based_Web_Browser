'///////////////////////////////////////////
'This form is just and example of 1 thing you 
'might choose to do in the event of a file download.
'There are many good examples of file downloading
'and download managers all over online if you
'choose to implement a download manager.
'///////////////////////////////////////////
Public Class frmDownload
    Public DLURL As String

    Private Sub frmDownload_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblInfo.Text = "Confirm download of file: " & _
        DLURL
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub
End Class