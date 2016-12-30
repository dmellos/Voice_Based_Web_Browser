Imports System.IO
Public Class frmAbout

    Private Sub frmAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If File.Exists("C:\Program Files\Common Files\Microsoft Shared\MSInfo\msinfo32.exe") Then
            btnSysInfo.Visible = True
        Else
            btnSysInfo.Visible = False
        End If
        ''lblVersion.Text = Application.ProductVersion.ToString
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

    Private Sub btnSysInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSysInfo.Click
        If File.Exists("C:\Program Files\Common Files\Microsoft Shared\MSInfo\msinfo32.exe") Then
            Process.Start("C:\Program Files\Common Files\Microsoft Shared\MSInfo\msinfo32.exe")
            Me.Close()
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class