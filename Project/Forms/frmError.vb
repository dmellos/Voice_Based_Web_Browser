Public Class frmError
    Public err As Exception

    Private Sub frmError_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblErr.Text = "Error Message: " & err.Message.ToString & vbCrLf & _
        "Stack Trace: " & err.StackTrace.ToString
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        MessageBox.Show("You could send the error info to a webservice, or an html form that takes the error data" & _
        vbCrLf & "and sends an email, stores to a data source or both." & vbCrLf & vbCrLf & _
        "This form is only one example of what to do with errors.", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class