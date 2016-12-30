'Main browser form

Imports System.IO
Imports System.Net
Imports System.Drawing
Imports System.Drawing.Drawing2D

'We need to set com visible to true so the form can be the browsers scripting object.
<System.Runtime.InteropServices.ComVisibleAttribute(True)> _
Public Class frmBrowser

    Public WithEvents oDoc As HtmlDocument
    Private oElement As HtmlElement
    Private TempPopAllowed As Boolean = False
    Private popURL As String
    Private LastDomain As String
    'Public PageImage As New PictureBox
    Public NumFeeds As Integer = 0

#Region " Form "

    Private Sub frmBrowser_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        oDoc = Nothing
        wb.Dispose()
        'May implement this in a future version...
        'If Not IsNothing(PageImage) Then
        '    PageImage.Dispose()
        'End If
    End Sub

    Private Sub frmBrowser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AppManager.CurrentBrowser = Me.wb
        wb.ObjectForScripting = Me
        'IE 7 does not seem to like the send to desktop code... so.
        If wb.Version.Major = "7" Then
            mnuPageToDesktop.Visible = False
        End If
        'set which context menu to use.
        Me.wb.IsWebBrowserContextMenuEnabled = Not (My.Settings.UseInternalMenu)
    End Sub

#End Region

#Region " Handleing Document Script Calls "
    'Since we are using the browser control, we have to handle javascript and other events raised by
    'the html document that target window.external such as add to favorites, organize favorites etc. 
    'We could implement this in the extended control itself, 
    'but for purposes of this demo, we will handle a couple common ones
    'in this region.
    '// Security note on Javascript handleing, you will probably want to check to make
    '//sure that the event was raised by a user click or show dialogs, not allow automatic running of
    '//these routines by using dialogs or other methods.
    '//Make sure your signatures match the common calls from the page.
    Public Sub AddSearchProvider(ByVal value As String)
        ' See: http://www.opensearch.org/ for more information.
        '     Dim ofrm As New frmAddSearchProvider
        '    ofrm.strXML = value
        '   ofrm.Show()
    End Sub

    Public Sub AddFavorite(ByVal strURL As String, ByVal strTitle As String)
        wb.AddToFavorites(Trim(strURL), Trim(strTitle))
    End Sub

    Public Sub OrganizeFavorites()
        wb.ShowOrganizeFavorites()
    End Sub

    Public Sub ShowCalc()
        Process.Start("Calc.exe")
    End Sub

    Public Sub ShowSettings()
        Dim ofrm As New frmSettings
        ofrm.ShowDialog(AppManager.MainForm)
    End Sub

#End Region

#Region " Browser Control  / Document "
    Private Sub wb_CanGoBackChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles wb.CanGoBackChanged
        AppManager.MainForm.btnBack.Enabled = wb.CanGoBack
    End Sub

    Private Sub wb_CanGoForwardChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles wb.CanGoForwardChanged
        AppManager.MainForm.btnForward.Enabled = wb.CanGoForward
    End Sub

    Private Sub wb_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles wb.DocumentCompleted
        oDoc = wb.Document
        Dim s As String
        Dim strDomain() As String
        For Each s In My.Settings.BlockedSites
            strDomain = Split(s, "http://")
            If strDomain(1) = wb.Document.Domain Then
                wb.DocumentText = My.Resources.Blocked
                AppManager.MainForm.pBar.Visible = False
                Exit Sub
            End If
        Next

        Me.Text = wb.DocumentTitle
        'Here you may want to prefetch the icon, or implement a form of caching icons.

        AppManager.MainForm.pBar.Visible = False

        If LastDomain = oDoc.Domain Then
            'We want to leave the popup settings alone.
        Else
            'different domain, reset the popup blocker.
            Me.TempPopAllowed = False
            InfoBar1.PictureBox1.Image = My.Resources.popBlocked
            InfoBar1.Text = " Pop up blocked."
            LastDomain = oDoc.Domain
        End If
        '///////////////////////////////////////////////////////////
        'This is not implemented in this version of the example...
        'PageImage.Image.Dispose()
        'Dim oCap As New ScreenCap
        'Create the new image
        'Dim obm As New Bitmap(oCap.CaptureWindow(Me.wb.Handle))
        'PageImage.Image = obm
        '///////////////////////////////////////////////////////////
        If My.Settings.UsePhishingFilter = True Then
            RunPhishingFilter()
        End If
    End Sub

    Private Sub oDoc_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.HtmlElementEventArgs) Handles oDoc.MouseDown
        'Here is it's an input element? if yes we want to show the normal windows options....
        If My.Settings.UseInternalMenu = True Then
            If e.MouseButtonsPressed = Windows.Forms.MouseButtons.Right And oElement.TagName = "INPUT" Then
                wb.IsWebBrowserContextMenuEnabled = True
            Else
                wb.IsWebBrowserContextMenuEnabled = False
            End If
        End If
        Dim MPoint As New Point(e.MousePosition.X, e.MousePosition.Y)
        oElement = oDoc.GetElementFromPoint(MPoint)
    End Sub

    Private Sub oDoc_MouseMove(ByVal sender As Object, _
    ByVal e As System.Windows.Forms.HtmlElementEventArgs) Handles oDoc.MouseMove
        On Error Resume Next
        Dim MPoint As New Point(e.MousePosition.X, e.MousePosition.Y)
        If My.Settings.ShowTags = True Then
            AppManager.MainForm.lblElement.Text = "<" & oElement.TagName & ">"
        Else
            AppManager.MainForm.lblElement.Text = String.Empty
        End If
        oElement = oDoc.GetElementFromPoint(MPoint)
    End Sub


    Private Sub wb_NavigatingExtended(ByVal sender As Object, ByVal e As exBrowser.WebBrowserNavigatingExtendedEventArgs) Handles wb.NavigatingExtended

        'Is it a download?
        If My.Settings.UseDLManager = True Then
            Dim strFile As String
            For Each strFile In My.Settings.FilesToDL
                If e.Url.EndsWith(strFile) Then
                    e.Cancel = True
                    Dim ofrm As New frmDownload
                    ofrm.DLURL = e.Url.ToString
                    ofrm.ShowDialog(AppManager.MainForm)
                    Exit Sub
                End If
            Next
        End If

        Dim s As String
        For Each s In My.Settings.BlockedSites
            If s = e.Url.ToString Or s & "/" = e.Url.ToString Then
                e.Cancel = True
                wb.DocumentText = My.Resources.Blocked
                AppManager.MainForm.pBar.Visible = False
            Else
                AppManager.MainForm.pBar.Visible = True
            End If
        Next
    End Sub

    Private Sub wb_NewWindow(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles wb.NewWindow
        e.Cancel = True
    End Sub

    Private Sub wb_NewWindowExtended(ByVal sender As Object, _
    ByVal e As exBrowser.WebBrowserNewWindowExtendedEventArgs) Handles wb.NewWindowExtended

        'Here we could implement whatever we want to based on the url
        '1st we will check to see if the url is a file in our download manager list...
        '//////////// DL Checking here //////////////////////
        If My.Settings.UseDLManager = True Then
            Dim strFile As String
            For Each strFile In My.Settings.FilesToDL
                If e.Url.EndsWith(strFile) Then
                    e.Cancel = True
                    Dim ofrm As New frmDownload
                    ofrm.DLURL = e.Url.ToString
                    ofrm.ShowDialog(AppManager.MainForm)
                    Exit Sub
                End If
            Next
        End If
        '//////////// End DL checking ///////////////////////
        'Here we implement something simular to IE 7
        'You might want to allow shit + click or some other override, that's up to you.
        '1st check if site is in allowed list
        Dim s As String
        For Each s In My.Settings.AllowedPopSites
            If s = wb.Document.Domain Then
                'Site is allowed... Show pop in new tab and exit...
                e.Cancel = True
                Dim ofrm As New frmBrowser
                AppManager.AddTab(ofrm, e.Url.ToString)
                Exit Sub
            End If
        Next
        If My.Settings.PopUpBlockerEnabled = True Then
            If Me.TempPopAllowed = True Then
                'Site temporarily allowed... open in new tab, then exit...
                e.Cancel = True
                Dim ofrm As New frmBrowser
                AppManager.AddTab(ofrm, e.Url.ToString)
                Exit Sub
            Else
                'Blocker is enabled and not temp allowed...
                e.Cancel = True
                If My.Settings.PopSound = True Then
                    My.Computer.Audio.Play(My.Resources.Windows_Pop_up_Blocked, AudioPlayMode.Background)
                End If
                If My.Settings.PopInfoBar = True Then
                    Me.InfoBar1.Visible = True
                End If
                popURL = e.Url.ToString
            End If
        Else
            'Blocker is not enabled... open in new tab.
            e.Cancel = True
            Dim ofrm As New frmBrowser
            AppManager.AddTab(ofrm, e.Url.ToString)
        End If

    End Sub

    Private Sub wb_StatusTextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles wb.StatusTextChanged
        If AppManager.CurrentBrowser Is Me.wb Then
            AppManager.MainForm.lblStatus.Text = wb.StatusText
        End If
    End Sub

    Private Function FixURL(ByVal sURL As String) As String
        sURL = sURL.Trim
        If Not sURL.ToLower().StartsWith("http://") _
        Then sURL = "http://" & sURL
        Return sURL
    End Function

    Private Sub wb_DocumentTitleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles wb.DocumentTitleChanged
        Me.Text = wb.DocumentTitle
        AppManager.MainForm.Text = wb.DocumentTitle & " - " & My.Resources.AppName
    End Sub

    Private Sub wb_Navigated(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs) Handles wb.Navigated
        AppManager.MainForm.pBar.Visible = False
        Me.Icon = AppManager.GetFavIcon(wb.Document.Domain & "/favicon.ico")
        AppManager.MainForm.tc1.TabPages(Me).Icon = Me.Icon
        AppManager.MainForm.Text = wb.DocumentTitle & " - " & My.Resources.AppName
        AppManager.MainForm.cboURL.Text = wb.Url.ToString
        DetectFeeds()
    End Sub

    Private Sub RunPhishingFilter()
        '///////////////////////////////////////////////////////////
        'Here you could parse the page for bad links, images etc from
        'a known list of sites...
        'Here we will just use the blocked sites list
        'as an example of what to do
        '///////////////////////////////////////////////////////////
        Dim BadLink As Boolean = False
        Dim oEl As HtmlElement
        Dim s As String
        Dim li As ListItem
        Dim ofrm As New frmPhising
        For Each oEl In oDoc.Links
            For Each s In My.Settings.PhishingSites
                If InStr(oEl.GetAttribute("HREF"), s) Then
                    li = New ListItem
                    li.Text = oEl.GetAttribute("HREF")
                    ofrm.lbPhishing.Items.Add(li)
                    BadLink = True
                End If
            Next
        Next
        If BadLink = True Then
            ofrm.ShowDialog()
        Else
            ofrm.Dispose()
        End If
    End Sub

    Private Sub DetectFeeds()
        Try
            Dim oEl As HtmlElement
            For Each oEl In wb.Document.All
                If oEl.GetAttribute("Type") = "application/rss+xml" Then
                    NumFeeds = NumFeeds + 1
                End If
            Next
            If NumFeeds = 0 Then
                AppManager.MainForm.mnuFeeds.Enabled = False
            Else
                AppManager.MainForm.mnuFeeds.Enabled = True
            End If
        Catch ex As Exception
            NumFeeds = 0
            AppManager.MainForm.mnuFeeds.Enabled = False
        End Try
    End Sub

#End Region

#Region " Context Menu "
    Private Sub mnuImageSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuImageSave.Click
        Dim opb As New PictureBox
        Dim sfd As New SaveFileDialog

        Try
            Dim odir As String = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
            sfd.InitialDirectory = odir.ToString
            Dim ofile() As String = Split(oElement.GetAttribute("src"), "/")
            sfd.Title = "Save web image"
            sfd.FileName = ofile(UBound(ofile)).ToString
            If sfd.ShowDialog() = Windows.Forms.DialogResult.OK Then
                If sfd.FileName = String.Empty Then
                    Exit Sub
                Else
                    AppManager.LoadWebImageToPictureBox(opb, oElement.GetAttribute("src"))
                    opb.Image.Save(sfd.FileName, Imaging.ImageFormat.Gif)
                End If
            End If
        Catch ex As Exception
            Dim ofrm As New frmError
            ofrm.err = ex
            ofrm.ShowDialog()
        Finally
            opb.Dispose()
            sfd.Dispose()
        End Try
    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If Not IsNothing(oElement) Then
            If oElement.TagName = "IMG" Then
                mnuImage.Enabled = True
            Else
                mnuImage.Enabled = False
            End If
            If oElement.TagName = "A" Then
                mnuLink.Enabled = True
            Else
                mnuLink.Enabled = False
            End If

        End If
        mnuBack.Enabled = AppManager.CurrentBrowser.CanGoBack
        mnuForward.Enabled = AppManager.CurrentBrowser.CanGoForward
    End Sub

   
    Private Sub mnuLinkNewTab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLinkNewTab.Click
        Dim ofrm As New frmBrowser
        AppManager.AddTab(ofrm, oElement.GetAttribute("HREF"))
    End Sub

    Private Sub PropertiesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AppManager.CurrentBrowser.ShowPropertiesDialog()
    End Sub

    Private Sub mnuPageSaveAs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPageSaveAs.Click
        AppManager.CurrentBrowser.ShowSaveAsDialog()
    End Sub

    Private Sub mnuPageToDesktop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPageToDesktop.Click
        Try
            AppManager.CurrentBrowser.SendToDesktop()
        Catch ex As Exception
            MessageBox.Show("An error occured saving to desktop" & vbCrLf & _
            "There seems to be an issue if you have Internet Explorer 7 installed.", _
            My.Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AdToFavoritesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdToFavoritesToolStripMenuItem.Click
        AppManager.CurrentBrowser.AddToFavorites()
    End Sub

    Private Sub mnuPagePrintSetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPagePrintSetup.Click
        AppManager.CurrentBrowser.ShowPageSetupDialog()
    End Sub

    Private Sub mnuPagePrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPagePrint.Click
        AppManager.CurrentBrowser.ShowPrintDialog()
    End Sub

    Private Sub mnuPagePrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPagePrintPreview.Click
        AppManager.CurrentBrowser.ShowPrintPreviewDialog()
    End Sub

    Private Sub mnuCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCopy.Click
        AppManager.CurrentBrowser.Document.ExecCommand("Copy", False, System.DBNull.Value)
    End Sub

    Private Sub mnuPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPaste.Click
        AppManager.CurrentBrowser.Document.ExecCommand("Paste", False, System.DBNull.Value)
    End Sub

    Private Sub mnuCopyLink_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCopyLink.Click
        Clipboard.SetText(oElement.GetAttribute("HREF"))
    End Sub

    Private Sub mnuViewImageNewTab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuViewImageNewTab.Click
        Dim ofrm As New frmBrowser
        AppManager.AddTab(ofrm, oElement.GetAttribute("src"))
    End Sub

    Private Sub mnuFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFind.Click
        AppManager.CurrentBrowser.ShowFindDialog()
    End Sub

    Private Sub wb_ProgressChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) Handles wb.ProgressChanged
        If AppManager.CurrentBrowser Is Me.wb Then
            AppManager.MainForm.lblStatus.Text = wb.StatusText
            AppManager.MainForm.pBar.Value = ((e.CurrentProgress / e.MaximumProgress) * 100)
        End If
    End Sub

    Private Sub mnuImageCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuImageCopy.Click
        Dim opb As New PictureBox
        AppManager.LoadWebImageToPictureBox(opb, oElement.GetAttribute("src"))
        Clipboard.SetImage(opb.Image)
        opb.Dispose()
    End Sub

  

    Private Sub mnuLeftToRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLeftToRight.Click
        AppManager.MainForm.mnuLeftToRight.PerformClick()
        mnuRightToLeft.Checked = False
    End Sub

    Private Sub mnuRightToLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRightToLeft.Click
        AppManager.MainForm.mnuRightToLeft.PerformClick()
        mnuLeftToRight.Checked = False
    End Sub

    Private Sub mnuPage_DropDownOpening(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuPage.DropDownOpening
        Select Case wb.Document.RightToLeft
            Case True
                mnuLeftToRight.Checked = False
                mnuRightToLeft.Checked = True
            Case False
                mnuLeftToRight.Checked = True
                mnuRightToLeft.Checked = False
        End Select
    End Sub

    Private Sub mnuPopTempAllow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPopTempAllow.Click
        Me.TempPopAllowed = True
        InfoBar1.Text = "Popups Temporarily allowed."
        InfoBar1.PictureBox1.Image = My.Resources.popallowed
        If Me.popURL = "" Then
            'Nothing to do
        Else
            Dim oFrm As New frmBrowser
            AppManager.AddTab(oFrm, popURL)
            InfoBar1.Visible = False
        End If
    End Sub

    Private Sub mnuPopAllowthissite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPopAllowthissite.Click
        My.Settings.AllowedPopSites.Add(wb.Document.Domain)
    End Sub

    Private Sub mnuPopBlockEnabled_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPopBlockEnabled.Click
        My.Settings.PopUpBlockerEnabled = mnuPopBlockEnabled.Checked
    End Sub

    Private Sub mnuPopShowInfoBar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPopShowInfoBar.Click
        My.Settings.PopInfoBar = mnuPopShowInfoBar.Checked
    End Sub

    Private Sub mnuPopMoreSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPopMoreSettings.Click
        Dim ofrm As New frmSettings
        ofrm.TabControl1.SelectedIndex = 0
        ofrm.ShowDialog(AppManager.MainForm)
    End Sub

    Private Sub cmiInfoBar_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmiInfoBar.Opening
        Select Case My.Settings.PopUpBlockerEnabled
            Case True
                mnuPopBlockEnabled.Text = "Pop up Blocker Enabled."
            Case False
                mnuPopBlockEnabled.Text = "Pop up Blocker Disabled."
        End Select
        mnuPopBlockEnabled.Checked = My.Settings.PopUpBlockerEnabled
        mnuPopShowInfoBar.Checked = My.Settings.PopInfoBar
    End Sub

    Private Sub mnuPageNewTab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPageNewTab.Click
        Dim ofrm As New frmBrowser
        AppManager.AddTab(ofrm, wb.Document.Url.ToString)
    End Sub

    Private Sub SaveAsImageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsImageToolStripMenuItem.Click
        Dim ofrm As New frmImage
        Dim op2i As New Page2Image
        ofrm.pb.Image = op2i.CapturePage(wb.Document)
        ofrm.Show()
    End Sub

#End Region

End Class