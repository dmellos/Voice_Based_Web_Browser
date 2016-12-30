'///////////////////////////////////////////
'Form to facilitate settings in the application.
'I am using built in vs 2005 settings for 
'most of the settings in the application
'other than search providers and feeds.
'///////////////////////////////////////////
Imports System.Enum
Imports System.Data.OleDb

Public Class frmSettings

    Private Sub frmSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadBlockedSites()
        LoadPhishingSites()
        LoadSearchProviders()
        LoadPopUpSettings()
        LoadPopAllowed()
        LoadAdditional()
    End Sub

#Region " Popup Blocker Settings "



    Private Sub LoadPopUpSettings()
        chkAllowPop.Checked = My.Settings.PopUpBlockerEnabled
        chkPopSound.Checked = My.Settings.PopSound
        chkPopInfo.Checked = My.Settings.PopInfoBar
    End Sub

    Private Sub LoadPopAllowed()
        lbPop.Items.Clear()
        Dim li As ListItem
        Dim s As String
        For Each s In My.Settings.AllowedPopSites
            li = New ListItem
            li.Text = s
            lbPop.Items.Add(li)
        Next
    End Sub

    Private Sub chkAllowPop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAllowPop.CheckedChanged
        My.Settings.PopUpBlockerEnabled = chkAllowPop.Checked
    End Sub

    Private Sub chkPopSound_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPopSound.CheckedChanged
        My.Settings.PopSound = chkPopSound.Checked
    End Sub

    Private Sub chkPopInfo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPopInfo.CheckedChanged
        My.Settings.PopInfoBar = chkPopInfo.Checked
    End Sub

    Private Sub btnPopAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPopAdd.Click
        If txtPop.Text = "" Then
            'Do nothing
        Else
            My.Settings.AllowedPopSites.Add(AppManager.FixURL(txtPop.Text))
            txtPop.Text = String.Empty
            LoadPopAllowed()
        End If
    End Sub

    Private Sub btnPopRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPopRemove.Click
        Dim li As ListItem
        If lbPop.SelectedItems.Count > 0 Then
            For Each li In lbPop.SelectedItems
                My.Settings.AllowedPopSites.Remove(li.Text)
            Next
            LoadPopAllowed()
        End If
    End Sub

    Private Sub btnPopRemoveAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPopRemoveAll.Click
        My.Settings.AllowedPopSites.Clear()
        lbPop.Items.Clear()
    End Sub

#End Region

#Region " Blocked Sites "

    Private Sub LoadBlockedSites()
        lbBlocked.Items.Clear()
        Dim s As String
        For Each s In My.Settings.BlockedSites
            lbBlocked.Items.Add(s)
        Next
    End Sub

    Private Sub btnAddBlock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddBlock.Click
        If txtBlock.Text = "" Then
            'Do nothing
        Else
            My.Settings.BlockedSites.Add(AppManager.FixURL(txtBlock.Text))
            LoadBlockedSites()
            txtBlock.Text = String.Empty
        End If
    End Sub

    Private Sub btnBlockRemoveAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBlockRemoveAll.Click
        Dim s As String
        For Each s In My.Settings.BlockedSites
            My.Settings.BlockedSites.Remove(s)
        Next
        LoadBlockedSites()
    End Sub

    Private Sub btnRemoveBlock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveBlock.Click
        If lbBlocked.SelectedIndices.Count > 0 Then
            My.Settings.BlockedSites.Remove(lbBlocked.SelectedItem)
            LoadBlockedSites()
        End If
    End Sub

#End Region

#Region " Search Providers "

    Private Sub LoadSearchProviders()
        lvSearchProviders.Items.Clear()
        Dim strSQL As String = _
        "Select ID, ProviderTitle, ProviderURL, IsDefault FROM SearchProviders ORDER BY ProviderTitle"
        Dim oConn As New OleDb.OleDbConnection(AppManager.ConnString)
        Dim oDa As New OleDb.OleDbDataAdapter(strSQL, oConn)
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim li As ListViewItem
        Dim si As ListViewItem.ListViewSubItem

        Try
            oDa.Fill(dt)
            For Each dr In dt.Rows
                li = New ListViewItem


                li.Tag = dr.Item("ID")
                li.SubItems.Add(dr.Item("ProviderURL"))
                si = New ListViewItem.ListViewSubItem
                If dr.Item("IsDefault") = True Then
                    li.Text = dr.Item("ProviderTitle") & " - (Default)"
                    li.Checked = True
                    li.Font = New Font(li.Font.Name, li.Font.Size, FontStyle.Bold, li.Font.Unit)

                Else
                    li.Text = dr.Item("ProviderTitle")
                    li.Checked = False
                End If
                'li.SubItems.Add(si)
                lvSearchProviders.Items.Add(li)
            Next

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally

        End Try
    End Sub

    Private Sub cmSearch_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmSearch.Opening
        If lvSearchProviders.Items.Count = 0 Then
            cmSearchRemove.Enabled = False
        Else
            cmSearchRemove.Enabled = True
        End If
    End Sub

    Private Sub cmSearchRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmSearchRemove.Click
        RemoveSearchProvider()
    End Sub

    Private Sub RemoveSearchProvider()
        Dim strSQL As String = "DELETE FROM SearchProviders WHERE ID=" & _
        CInt(lvSearchProviders.SelectedItems(0).Tag)
        Dim oConn As New OleDb.OleDbConnection(AppManager.ConnString)
        Dim oCmd As New OleDbCommand(strSQL, oConn)

        Try
            oConn.Open()
            oCmd.ExecuteNonQuery()
            oConn.Close()

            LoadSearchProviders()
            AppManager.MainForm.LoadSearchProviders()
        Catch ex As Exception
            Dim ofrm As New frmError
            ofrm.err = ex
            ofrm.ShowDialog(Me)
        End Try
    End Sub

    Private Sub btnAddProvider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddProvider.Click
        If chkSearchDefault.Checked Then
            SetDefault()
        End If
        AddProvider()
    End Sub

    Private Sub AddProvider()
        'In this example application, we do not care if a user adds more than 1
        'of the same provider, so we will not check for that.
        Dim oConn As New OleDbConnection(AppManager.ConnString)
        Dim strSQL As String = _
        "INSERT INTO SearchProviders (ProviderTitle, ProviderURL, IsDefault) VALUES " & _
        "('" & txtSearchTitle.Text & _
        "', '" & txtSearchURL.Text & _
        "', " & chkSearchDefault.Checked & ")"
        Dim oCmd As New OleDbCommand(strSQL, oConn)

        Try
            oConn.Open()
            oCmd.ExecuteNonQuery()
            oConn.Close()
            AppManager.MainForm.LoadSearchProviders()
            LoadSearchProviders()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    Private Sub SetDefault()
        Dim strSQL As String = "Update SearchProviders Set IsDefault=False"
        Dim oConn As New OleDbConnection(AppManager.ConnString)
        Dim oCmd As New OleDbCommand(strSQL, oConn)
        Try
            oConn.Open()
            oCmd.ExecuteNonQuery()
            oConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            oConn.Dispose()
            oCmd.Dispose()
        End Try
    End Sub

#End Region

#Region " Integrations "

    Private Sub LoadAdditional()
        chkInternal.Checked = My.Settings.UseInternalMenu
        chkShowTags.Checked = My.Settings.ShowTags
        chkSupress.Checked = My.Settings.SupressScriptErrs
        chkStart.Checked = My.Settings.UseStartPage
        chkPhishing.Checked = My.Settings.UsePhishingFilter
    End Sub

    Private Sub chkInternal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkInternal.CheckedChanged
        My.Settings.UseInternalMenu = chkInternal.Checked
        Dim ofrm As frmBrowser
        Dim i As Integer
        For i = 0 To AppManager.MainForm.tc1.TabPages.Count - 1
            If TypeOf AppManager.MainForm.tc1.TabPages.Item(i).Form Is frmBrowser Then
                ofrm = AppManager.MainForm.tc1.TabPages.Item(i).Form
                ofrm.wb.IsWebBrowserContextMenuEnabled = Not (chkInternal.Checked)
            End If
        Next
    End Sub

    Private Sub chkShowTags_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowTags.CheckedChanged
        My.Settings.ShowTags = chkShowTags.Checked
    End Sub

    Private Sub chkSupress_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSupress.CheckedChanged
        My.Settings.SupressScriptErrs = chkSupress.Checked
        Dim ofrm As frmBrowser
        Dim i As Integer
        For i = 0 To AppManager.MainForm.tc1.TabPages.Count - 1
            If TypeOf AppManager.MainForm.tc1.TabPages.Item(i).Form Is frmBrowser Then
                ofrm = AppManager.MainForm.tc1.TabPages.Item(i).Form
                ofrm.wb.ScriptErrorsSuppressed = chkInternal.Checked
            End If
        Next
    End Sub

#End Region

#Region " Phishing "
    Private Sub LoadPhishingSites()
        lbPhishing.Items.Clear()
        Dim s As String
        For Each s In My.Settings.PhishingSites
            lbPhishing.Items.Add(s)
        Next
    End Sub
    Private Sub btnAddPhish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddPhish.Click
        If txtPhishing.Text = "" Then
            'Do nothing
        Else
            My.Settings.PhishingSites.Add(AppManager.FixURL(txtPhishing.Text))
            LoadPhishingSites()
            txtPhishing.Text = String.Empty
        End If
    End Sub
 
    Private Sub btnRemovePhish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemovePhish.Click
        If lbPhishing.SelectedIndices.Count > 0 Then
            My.Settings.PhishingSites.Remove(lbPhishing.SelectedItem)
            LoadPhishingSites()
        End If
    End Sub

    Private Sub btnRemoveAllPhish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveAllPhish.Click
        Dim s As String
        For Each s In My.Settings.PhishingSites
            My.Settings.PhishingSites.Remove(s)
        Next
        LoadPhishingSites()
    End Sub

#End Region

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub chkUseDLManager_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkUseDLManager.CheckedChanged
        My.Settings.UseDLManager = chkUseDLManager.Checked
        My.Settings.Save()
    End Sub

    Private Sub chkStart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkStart.CheckedChanged
        My.Settings.UseStartPage = chkStart.Checked
        My.Settings.Save()
    End Sub

    Private Sub chkPhishing_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPhishing.CheckedChanged
        My.Settings.UsePhishingFilter = chkPhishing.Checked
        My.Settings.Save()
    End Sub
End Class