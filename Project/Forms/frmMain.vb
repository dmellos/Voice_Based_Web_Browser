Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Drawing
Imports System.Text
Imports System.Data.OleDb
Imports SpeechLib
Imports System.Xml

Public Class frmMain

    Dim WithEvents RecoContext As SpSharedRecoContext      'The Main Recognition Object Used throughout the whole program. -- Shared Object: More Info on this later.
    Dim Grammar As ISpeechRecoGrammar                      'The Grammar Object so the program knows what is going on. -- Instanced Object: More Info on this later.
    Dim CharCount As Integer                                'This is used to count the amount of chars that are in the text box.


#Region " API "
    'This is an API call to get the icon of a favorite.
    Private Structure SHFILEINFO
        Public hIcon As IntPtr            ' : icon
        Public iIcon As Integer           ' : icondex
        Public dwAttributes As Integer    ' : SFGAO_ flags
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=260)> _
        Public szDisplayName As String
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=80)> _
        Public szTypeName As String
    End Structure

    Private Declare Auto Function SHGetFileInfo Lib "shell32.dll" _
            (ByVal pszPath As String, _
             ByVal dwFileAttributes As Integer, _
             ByRef psfi As SHFILEINFO, _
             ByVal cbFileInfo As Integer, _
             ByVal uFlags As Integer) As IntPtr

    Private Const SHGFI_ICON = &H100
    Private Const SHGFI_SMALLICON = &H1
    Private Const SHGFI_LARGEICON = &H0    ' Large icon
    Private nIndex
#End Region

    Private CurSearchURL As String
    Private CurSearchTitle
    Private fitm As ToolStripMenuItem

#Region " FORM "

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not IsNothing(AppManager.CurrentBrowser) Then
            AppManager.CurrentBrowser.Dispose()
        End If

        Dim oControl As Control
        For Each oControl In Me.Controls
            oControl.Dispose()
        Next
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AppManager.MainForm = Me
        Dim ofrm As New frmBrowser
        Dim oTab As New JarvisExplorer.TabPage(ofrm)
        Me.tc1.TabPages.Add(oTab.Form)

        'Set the 1st tab to non closeable, just like ie 7
        tc1.TabPages(0).CloseButtonVisible = False
        If AppManager.StartURL = "" Then
            'Do we show the start page or have the browser go home?
            If My.Settings.UseStartPage = True Then
                ofrm.wb.DocumentText = My.Resources.StartPage
            Else
                ofrm.wb.GoHome()
            End If
        Else
            ofrm.wb.Navigate(AppManager.StartURL)
        End If

        LoadFavorites()
        LoadSearchProviders()

        voice_active()
        Me.VoiceActivateToolStripMenuItem.Enabled = False
        Me.VoiceDeactivateToolStripMenuItem.Enabled = True
    End Sub

    Private Sub LoadHistory()
        '
    End Sub

#End Region

#Region " Favorites Loading Code "
    'In most custom browser implementations you will probably want to 
    'have your own favorite storage information, storing fav icons in your own cache
    'or in a database. You may also want to implement a custom import / export wizard. 
    'Since favorites are just text files simular to .ini files, for this example
    'we'll just load them the quickest way by loading the path and during the 
    'onclick in the handler open the file and direct the browser to the url. 

    Private Sub LoadFavorites()
        Dim Path As String = Environment.GetFolderPath(Environment.SpecialFolder.Favorites)
        tvFavs.BeginUpdate()
        ' Clear the Favorites list
        tvFavs.Nodes.Clear()
        ' Load favorites from all sub-directories
        LoadFolders(New System.IO.DirectoryInfo(Path), Nothing, Nothing)
        ' Load the favorites from the favorites folder
        LoadPath(Path, Nothing, Nothing)
        'Now lets load the links toobar
        LoadLinkFolders(New System.IO.DirectoryInfo(Path & "\Links\"), Nothing)
        LoadLinksPath(Path & "\Links\", Nothing)
        ' Repaint the TreeView
        tvFavs.EndUpdate()
    End Sub

    Private Sub LoadFolders(ByVal dirInfo As System.IO.DirectoryInfo, _
    ByVal currentNode As TreeNode, ByVal oitm As ToolStripMenuItem)

        Dim objNode As System.Windows.Forms.TreeNode
        Dim fitm As ToolStripMenuItem

        Dim objDir As System.IO.DirectoryInfo

        For Each objDir In dirInfo.GetDirectories()
            If currentNode Is Nothing Then
                objNode = tvFavs.Nodes.Add(objDir.Name, objDir.Name, 0, 1)
                objNode.Tag = String.Empty
                fitm = mnuFavs.DropDownItems.Add(objDir.Name)
                fitm.Image = My.Resources.folder3
            Else
                objNode = currentNode.Nodes.Add(objDir.Name, objDir.Name, 0, 1)
                objNode.Tag = String.Empty
                fitm = oitm.DropDownItems.Add(objDir.Name)
                fitm.Image = My.Resources.folder3
            End If
            ' Set the full path of the folder
            objNode.Tag = objDir.FullName
            fitm.Tag = objDir.FullName

            If objDir.GetDirectories().Length = 0 Then
                ' This node has no further sub-directories
                LoadPath(objDir.FullName, objNode, fitm)
            Else
                ' Add this folder to the current node and continue
                ' processing sub-directories.
                LoadFolders(objDir, objNode, fitm)
                LoadPath(objDir.FullName, objNode, fitm)
            End If
        Next objDir
    End Sub

    Private Sub LoadPath(ByVal strPath As String, _
    ByVal currentNode As TreeNode, ByVal mitm As ToolStripMenuItem)

        Dim oNode As TreeNode
        Dim oitm As ToolStripMenuItem
        Dim name As String
        Dim objDir As New System.IO.DirectoryInfo(strPath)
        Dim SmallIco As IntPtr
        Dim shinfo As SHFILEINFO
        shinfo = New SHFILEINFO
        ' Process each File in the path with a ".url" extension
        Dim objFile As System.IO.FileInfo
        For Each objFile In objDir.GetFiles("*.url")
            oNode = New TreeNode
            oitm = New ToolStripMenuItem
            '///////////////////////////////////////////////////
            'get the icon.
            'Note:
            'Here you could call the appmanager code to get the actual 
            'favorite icon from the site (will slow things down)...
            'If you decide to implement your own custom favorites
            'grab the fav icon and store it in an access db, xml file etc
            'either by path or ole object and save it locally.
            shinfo.szDisplayName = New String(Chr(0), 260)
            shinfo.szTypeName = New String(Chr(0), 80)
            'Get the small icon.
            SmallIco = SHGetFileInfo(objFile.FullName, 0, shinfo, _
                        Marshal.SizeOf(shinfo), _
                        SHGFI_ICON Or SHGFI_SMALLICON)
            '////////////////////////////////////////////////////
            ' Set the Text property to the "Friendly" name
            name = Path.GetFileNameWithoutExtension(objFile.Name)
            Dim oIcon As Icon = System.Drawing.Icon.FromHandle(shinfo.hIcon)
            tvFavs.ImageList.Images.Add(name, oIcon.ToBitmap)
            oNode.Text = name
            oNode.Tag = objFile.FullName
            oNode.ImageKey = name
            oNode.SelectedImageKey = name
            If currentNode Is Nothing Then
                tvFavs.Nodes.Add(oNode)
                oitm.Text = name
                oitm.Image = oIcon.ToBitmap
                oitm.Tag = objFile.FullName
                mnuFavs.DropDownItems.Add(oitm)
                AddHandler oitm.Click, AddressOf HandleFav
                'AddHandler oitm.MouseDown, AddressOf HandleFavMouseDown
            Else
                currentNode.Nodes.Add(oNode)
                oitm.Text = name
                oitm.Image = oIcon.ToBitmap
                oitm.Tag = objFile.FullName
                mitm.DropDownItems.Add(oitm)
                AddHandler oitm.Click, AddressOf HandleFav
                'AddHandler oitm.MouseDown, AddressOf HandleFavMouseDown
            End If
        Next objFile
    End Sub


    Private Sub LoadLinkFolders(ByVal dirInfo As System.IO.DirectoryInfo, _
    ByVal oitm As ToolStripMenuItem)

        Dim fitm As ToolStripMenuItem
        Dim objDir As System.IO.DirectoryInfo

        For Each objDir In dirInfo.GetDirectories()
            fitm = New ToolStripMenuItem
            fitm.Text = objDir.Name
            fitm.Tag = ""
            fitm.Image = My.Resources.folder3
            If oitm Is Nothing Then
                tbLinks.Items.Add(fitm)
            Else
                fitm.Image = My.Resources.folder3
                oitm.DropDownItems.Add(fitm)
            End If

            If objDir.GetDirectories().Length = 0 Then
                ' This node has no further sub-directories
                LoadLinksPath(objDir.FullName, fitm)
            Else
                ' Add this folder to the current node and continue
                ' processing sub-directories.
                LoadLinkFolders(objDir, fitm)
                LoadLinksPath(objDir.FullName, fitm)
            End If
        Next objDir
    End Sub

    Private Sub LoadLinksPath(ByVal strPath As String, _
    ByVal mitm As ToolStripMenuItem)

        Dim oitm As ToolStripMenuItem
        Dim name As String
        Dim objDir As New System.IO.DirectoryInfo(strPath)
        Dim SmallIco As IntPtr
        Dim shinfo As SHFILEINFO
        shinfo = New SHFILEINFO
        ' Process each URL in the path (URL files end with a ".url" extension
        Dim objFile As System.IO.FileInfo
        For Each objFile In objDir.GetFiles("*.url")
            oitm = New ToolStripMenuItem
            'get the icon.
            shinfo.szDisplayName = New String(Chr(0), 260)
            shinfo.szTypeName = New String(Chr(0), 80)
            'Get the small icon.
            SmallIco = SHGetFileInfo(objFile.FullName, 0, shinfo, _
                        Marshal.SizeOf(shinfo), _
                        SHGFI_ICON Or SHGFI_SMALLICON)
            ' Set the Text property to the "Friendly" name
            name = Path.GetFileNameWithoutExtension(objFile.Name)
            Dim oIcon As Icon = System.Drawing.Icon.FromHandle(shinfo.hIcon)

            If mitm Is Nothing Then
                oitm.Text = name
                oitm.Image = oIcon.ToBitmap
                oitm.Tag = objFile.FullName
                tbLinks.Items.Add(oitm)
                'AddHandler oitm.Click, AddressOf HandleFav
                AddHandler oitm.MouseDown, AddressOf HandleFavMouseDown
            Else
                oitm.Text = name
                oitm.Image = oIcon.ToBitmap
                oitm.Tag = objFile.FullName
                mitm.DropDownItems.Add(oitm)
                'AddHandler oitm.Click, AddressOf HandleFav
                AddHandler oitm.MouseDown, AddressOf HandleFavMouseDown
            End If
        Next objFile
    End Sub

#End Region

#Region " Favorite Event Handlers "

    Private Sub HandleFavMouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Select Case e.Button
            Case Windows.Forms.MouseButtons.Left
                Dim fi As ToolStripMenuItem = sender
                Dim obj As New tlxIni(fi.Tag)
                AppManager.CurrentBrowser.Navigate(obj.GetString("INTERNETSHORTCUT", "URL", String.Empty))
            Case Windows.Forms.MouseButtons.Right
                cmFavs.Show(Cursor.Position.X, Cursor.Position.Y)
                fitm = sender
        End Select
    End Sub

    Private Sub HandleFav(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim fi As ToolStripMenuItem = sender
        Dim obj As New tlxIni(fi.Tag)
        AppManager.CurrentBrowser.Navigate(obj.GetString("INTERNETSHORTCUT", "URL", String.Empty))
    End Sub

    Private Sub tvFavs_NodeMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles tvFavs.NodeMouseClick
        If e.Node.Nodes.Count > 0 Then
            e.Node.Expand()
        Else
            If e.Node.ImageIndex = 0 Then
                Exit Sub
            Else
                Dim obj As New tlxIni(e.Node.Tag)
                AppManager.CurrentBrowser.Navigate(obj.GetString("INTERNETSHORTCUT", "URL", String.Empty))
                gbFavs.Visible = False
            End If
        End If
    End Sub

#End Region

#Region " Search Providers / Search Routines "
    'We'll make this public so we can call it from the add provider form
    Public Sub LoadSearchProviders()
        btnSearch.DropDownItems.Clear()
        Dim strSQL As String = _
        "Select ProviderTitle, ProviderURL, IsDefault FROM SearchProviders ORDER BY ProviderTitle"
        Dim oConn As New OleDb.OleDbConnection(AppManager.ConnString)
        Dim oDa As New OleDb.OleDbDataAdapter(strSQL, oConn)
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim oitm As ToolStripMenuItem

        Try
            oDa.Fill(dt)
            For Each dr In dt.Rows
                oitm = New ToolStripMenuItem
                oitm.Tag = dr.Item("ProviderURL")

                If dr.Item("IsDefault") = True Then
                    Dim oFC As New FontConverter
                    oitm.Checked = True
                    oitm.Text = dr.Item("ProviderTitle") & " (Default)"
                    txtSearch.Text = dr.Item("ProviderTitle")
                    oitm.Font = New Font(oitm.Font.Name, oitm.Font.Size, FontStyle.Bold, oitm.Font.Unit)
                    Me.CurSearchURL = dr.Item("ProviderURL")
                    Me.CurSearchTitle = dr.Item("ProviderTitle")
                Else
                    oitm.Text = dr.Item("ProviderTitle")
                End If
                btnSearch.DropDownItems.Add(oitm)
                AddHandler oitm.Click, AddressOf HandleSearch
            Next

            Dim spcr As New ToolStripSeparator
            btnSearch.DropDownItems.Add(spcr)

            'Well just use microsoft's provider page, it would not take
            'much to create our own custom page.
            oitm = New ToolStripMenuItem
            oitm.Text = "Find more providers"
            oitm.Tag = "http://www.microsoft.com/windows/ie/searchguide/en-en/default.mspx#"
            btnSearch.DropDownItems.Add(oitm)
            AddHandler oitm.Click, AddressOf HandleSearch

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    Private Sub HandleSearch(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim oitm As ToolStripMenuItem = sender
        If oitm.Text = "Find more providers" Then
            AppManager.CurrentBrowser.Navigate(oitm.Tag)
        Else
            Me.CurSearchURL = oitm.Tag
            txtSearch.Text = oitm.Text
        End If
    End Sub

    Private Sub txtSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.Click
        txtSearch.Text = String.Empty
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            DoSearch()
        End If
    End Sub

    Private Sub DoSearch()
        Dim sTerm As String = Me.CurSearchURL
        sTerm = sTerm.Replace("{searchTerms}", txtSearch.Text)
        AppManager.CurrentBrowser.Navigate(sTerm)
    End Sub

    Private Sub txtSearch_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.LostFocus
        txtSearch.Text = Me.CurSearchTitle
    End Sub

#End Region

#Region " Menus and toolbars "

    Private Sub btnForward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForward.Click
        If AppManager.CurrentBrowser.CanGoForward Then
            AppManager.CurrentBrowser.GoForward()
        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        If AppManager.CurrentBrowser.CanGoBack Then
            AppManager.CurrentBrowser.GoBack()
        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        AppManager.CurrentBrowser.Refresh()
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        AppManager.CurrentBrowser.Stop()
    End Sub

    Private Sub cboURL_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboURL.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cboURL.Text <> "" Then
                AppManager.CurrentBrowser.Navigate(cboURL.Text)
            End If
        End If
    End Sub

    Private Sub btnForward_DropDownItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)
        AppManager.Navigate(e.ClickedItem.Tag)
    End Sub

    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click
        AppManager.CurrentBrowser.GoHome()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        AppManager.CurrentBrowser.Print()
    End Sub

    Private Sub btnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintPreview.Click
        AppManager.CurrentBrowser.ShowPrintPreviewDialog()
    End Sub

    Private Sub btnPageSetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPageSetup.Click
        AppManager.CurrentBrowser.ShowPageSetupDialog()
    End Sub

    Private Sub btnCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCut.Click
        AppManager.CurrentBrowser.Document.ExecCommand("Cut", False, System.DBNull.Value)
    End Sub

    Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click
        If Not IsNothing(AppManager.CurrentBrowser.Document) Then
            AppManager.CurrentBrowser.Document.ExecCommand("Copy", False, System.DBNull.Value)
        End If
    End Sub

    Private Sub btnPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPaste.Click
        If Not IsNothing(AppManager.CurrentBrowser.Document) Then
            AppManager.CurrentBrowser.Document.ExecCommand("Paste", False, System.DBNull.Value)
        End If
    End Sub

    Private Sub btnSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectAll.Click
        If Not IsNothing(AppManager.CurrentBrowser.Document) Then
            AppManager.CurrentBrowser.Document.Focus()
            AppManager.CurrentBrowser.Document.ExecCommand("SelectAll", False, System.DBNull.Value)
            AppManager.CurrentBrowser.Document.Focus()
        End If
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        AppManager.CurrentBrowser.ShowFindDialog()
    End Sub

    Private Sub btnViewSource_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewSource.Click
        AppManager.CurrentBrowser.ShowSource()
    End Sub

    Private Sub btnShowFavs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowFavs.Click
        gbFavs.Visible = btnShowFavs.Checked
        Splitter1.Visible = btnShowFavs.Checked
    End Sub

    Private Sub btnInternetOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInternetOptions.Click
        AppManager.CurrentBrowser.ShowInternetOptions()
    End Sub

    Private Sub mnuAddFav2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAddFav2.Click
        AppManager.CurrentBrowser.AddToFavorites("", "")
    End Sub

    Private Sub AddToFavoritesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToFavoritesToolStripMenuItem.Click
        AppManager.CurrentBrowser.AddToFavorites(AppManager.CurrentBrowser.Url.ToString, AppManager.CurrentBrowser.DocumentTitle)
    End Sub

    Private Sub OrganizeFavoritesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrganizeFavoritesToolStripMenuItem.Click
        AppManager.CurrentBrowser.ShowOrganizeFavorites()
    End Sub

    Private Sub mnuNewTab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNewTab.Click
        Dim ofrm As New frmBrowser
        Dim oTab As New JarvisExplorer.TabPage(ofrm)
        ofrm.wb.Navigate2(AppManager.CurrentBrowser.CurrentURL)
        tc1.TabPages.Add(oTab.Form)

    End Sub

    Private Sub mnulNewTab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnulNewTab.Click
        Dim ofrm As New frmBrowser
        Dim oTab As New JarvisExplorer.TabPage(ofrm)
        'ofrm.MyTabPage = oTab
        AppManager.AddTab(oTab)
        'tc1.TabPages(1).CloseButtonVisible = False

    End Sub

    Private Sub mnuViewMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuViewMenu.Click
        MainMenu.Visible = mnuViewMenu.Checked
        mnuViewMenuBar.Checked = mnuViewMenu.Checked
    End Sub

    Private Sub mnuViewStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuViewStatus.Click
        sBar.Visible = mnuViewStatus.Checked
        mnuViewStatusBar.Checked = mnuViewStatus.Checked
    End Sub

    Private Sub FindOnThisPageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindOnThisPageToolStripMenuItem.Click
        AppManager.CurrentBrowser.ShowFindDialog()
    End Sub

    Private Sub lblSec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '  Dim ofrm As New frmSecInfo
        ' ofrm.ShowDialog(Me)
    End Sub

    Private Sub mnuProperties_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProperties.Click
        AppManager.CurrentBrowser.ShowPropertiesDialog()
    End Sub

    '  Private Sub mnuProperties2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProperties2.Click
    'Dim ofrm As New frmProperties
    '   ofrm.obj = AppManager.CurrentBrowser.Document
    '  ofrm.ShowDialog(Me)
    'End Sub

    Private Sub mnuSecInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '     Dim ofrm As New frmSecInfo
        '    ofrm.ShowDialog(Me)
    End Sub

    Private Sub mnuAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAbout.Click
        Dim ofrm As New frmAbout
        ofrm.ShowDialog(Me)
    End Sub

    Private Sub mnuViewSource_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuViewSource.Click
        AppManager.CurrentBrowser.ShowSource()
    End Sub

    Private Sub mnuViewMenuBar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuViewMenuBar.Click
        mnuViewMenu.PerformClick()
    End Sub

    Private Sub mnuViewStatusBar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuViewStatusBar.Click
        mnuViewStatus.PerformClick()
    End Sub

    Private Sub HistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistoryToolStripMenuItem.Click
        Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.History))
    End Sub

    Private Sub btnDocFav_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDocFav.Click
        Select Case btnDocFav.Tag
            Case 1
                gbFavs.Dock = DockStyle.Left
                gbFavs.SendToBack()
                btnDocFav.Image = My.Resources.Delete16
                btnDocFav.Tag = 2
            Case 2
                gbFavs.Dock = DockStyle.None
                btnDocFav.Image = My.Resources.favDock
                gbFavs.BringToFront()
                gbFavs.Visible = False
                btnDocFav.Tag = 1
        End Select
    End Sub

    Private Sub mnuSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSettings.Click
        Dim ofrm As New frmSettings
        ofrm.ShowDialog(Me)
    End Sub

    Private Sub btnRSS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRSS.Click
        Dim ofrm As New frmRSS
        tc1.TabPages.Add(ofrm)
    End Sub

    Private Sub mnuPageSetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPageSetup.Click
        AppManager.CurrentBrowser.ShowPageSetupDialog()
    End Sub


    Private Sub mnuPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrint.Click
        AppManager.CurrentBrowser.ShowPrintDialog()
    End Sub

    Private Sub mnuPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrintPreview.Click
        AppManager.CurrentBrowser.ShowPrintPreviewDialog()
    End Sub

    Private Sub mnuFProperties_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFProperties.Click
        AppManager.CurrentBrowser.ShowPropertiesDialog()
    End Sub

    Private Sub mnuSaveAs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSaveAs.Click
        AppManager.CurrentBrowser.ShowSaveAsDialog()
    End Sub

    Private Sub mnuClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuClose.Click
        Me.Close()
    End Sub

    Private Sub mnuOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOpen.Click
        AppManager.CurrentBrowser.ShowOpen()
    End Sub

    Private Sub RSSViewerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RSSViewerToolStripMenuItem.Click
        btnRSS.PerformClick()
    End Sub

    Private Sub InternetOptionsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InternetOptionsToolStripMenuItem1.Click
        AppManager.CurrentBrowser.ShowInternetOptions()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem.Click
        Dim ofrm As New frmSettings
        ofrm.ShowDialog(Me)
    End Sub

    Private Sub PropertiesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PropertiesToolStripMenuItem1.Click
        AppManager.CurrentBrowser.ShowPropertiesDialog()
    End Sub

    Private Sub mnuLeftToRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLeftToRight.Click
        AppManager.CurrentBrowser.Document.RightToLeft = False
        mnuRightToLeft.Checked = False
    End Sub

    Private Sub mnuRightToLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRightToLeft.Click
        AppManager.CurrentBrowser.Document.RightToLeft = True
        mnuLeftToRight.Checked = False
    End Sub

    Private Sub btnFeeds_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFeeds.Click
        Dim ofrm As New frmRSS
        Me.tc1.TabPages.Add(ofrm)
        gbFavs.Visible = False
    End Sub

    Private Sub btnHistory_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ofrm As New frmBrowser
        AppManager.AddTab(ofrm, Environment.GetFolderPath(Environment.SpecialFolder.History))
        gbFavs.Visible = False
    End Sub

#End Region

#Region " Tab Control "
    Private Sub tc1_SelectedTabChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tc1.SelectedTabChanged
        On Error Resume Next
        Dim cForm As Form = tc1.SelectedForm
        If TypeOf cForm Is frmBrowser Then
            Dim ofrm As frmBrowser = cForm
            Me.Text = cForm.Text & " - " & My.Resources.AppName
            cboURL.Text = ofrm.wb.Url.ToString
            AppManager.CurrentBrowser = ofrm.wb
            btnBack.Enabled = AppManager.CurrentBrowser.CanGoBack
            btnForward.Enabled = AppManager.CurrentBrowser.CanGoForward
            If ofrm.NumFeeds = 0 Then
                mnuFeeds.Enabled = False
            Else
                mnuFeeds.Enabled = True
            End If
        Else
            'Nothing to do
        End If

    End Sub

#End Region

    Private Sub mnuGrabImages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '  Dim ofrm As New frmScrapeImages
        ' ofrm.ShowDialog(AppManager.MainForm)
    End Sub

    Private Sub PropertiesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PropertiesToolStripMenuItem.Click
        '     tFileInfo.ShowProp(fitm.Tag)
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to delete " & fitm.Text & "?", "Confirm Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            File.Delete(fitm.Tag)
            tbLinks.Items.Remove(fitm)
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Dim obj As New tlxIni(fitm.Tag)
        AppManager.CurrentBrowser.Navigate(obj.GetString("INTERNETSHORTCUT", "URL", String.Empty))
    End Sub

    Private Sub RenameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RenameToolStripMenuItem.Click
        Dim fInfo As New FileInfo(fitm.Tag)
        Dim NewName As String = InputBox("Rename " & fitm.Text, "Rename Favorite", fitm.Text)
        File.Copy(fitm.Tag, fInfo.Directory.ToString & "\" & NewName & ".url")
        File.Delete(fitm.Tag)
        fitm.Text = NewName
        fitm.Tag = fInfo.Directory.ToString & "\" & NewName & ".url"
    End Sub

    Private Sub mnuCheckFeeds_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCheckFeeds.Click
        Dim ofrm As New frmDetectRSS
        ofrm.ShowDialog(Me)
    End Sub

    Private Sub btnHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHistory.Click
        Dim ofrm As New frmHistory
        ofrm.LoadMode = frmHistory.LoadModes.History
        ofrm.Text = "History Viewer"
        tc1.TabPages.Add(ofrm)
        gbFavs.Visible = False
    End Sub

    Private Sub btnViewCookies_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewCookies.Click
        Dim ofrm As New frmCookieViewer
        tc1.TabPages.Add(ofrm)
        gbFavs.Visible = False
    End Sub

    Private Sub mnuCache_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHistory.Click
        Dim ofrm As New frmHistory
        ofrm.LoadMode = frmHistory.LoadModes.History
        ofrm.Text = "History Viewer"
        tc1.TabPages.Add(ofrm)
        gbFavs.Visible = False
    End Sub

    Private Sub mnuTempFiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTempFiles.Click
        Dim ofrm As New frmHistory
        ofrm.LoadMode = frmHistory.LoadModes.Cache
        ofrm.Text = "Cache Viewer"
        tc1.TabPages.Add(ofrm)
        gbFavs.Visible = False
    End Sub

    Private Sub mnuFeeds_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFeeds.Click
        Dim ofrm As New frmDetectRSS
        ofrm.ShowDialog(Me)
    End Sub

    Private Sub VoiceMarkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VoiceMarkToolStripMenuItem.Click
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

    Private Sub OnReco(ByVal StreamNumber As Integer, ByVal StreamPosition As Object, ByVal RecognitionType As SpeechRecognitionType, ByVal Result As ISpeechRecoResult) Handles RecoContext.Recognition


        Dim recoResult As String = Result.PhraseInfo.GetText(0, -1, True) 'Create a new string, and assign the recognized text to it.
        Dim strNumber As String = Result.PhraseInfo.Rule.Name ' which property in the rule was matched

        'This block will print to the textbox built into the program
        'If you would prefer to use the SendKeys method, Comment out this entire block. And Uncomment the SendKeys Line.

        cboURL.Text = ""
        cboURL.SelectionStart = CharCount
        CharCount = CharCount + 1 + Len(recoResult)
        '    cboURL.SelectedText = "http://www." & recoResult & ".com"

        '  If recoResult = "browse" Then
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

        AppManager.CurrentBrowser.Navigate(cboURL.Text)
        'End If



    End Sub

    Private Sub VoiceActivateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VoiceActivateToolStripMenuItem.Click
        voice_active()
        Me.VoiceActivateToolStripMenuItem.Enabled = False
        Me.VoiceDeactivateToolStripMenuItem.Enabled = True
    End Sub

    Private Sub VoiceDeactivateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VoiceDeactivateToolStripMenuItem.Click
        voice_deactive()
        Me.VoiceDeactivateToolStripMenuItem.Enabled = False
        Me.VoiceActivateToolStripMenuItem.Enabled = True
    End Sub

    Private Sub ExBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs)

    End Sub

    Private Sub tvFavs_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvFavs.AfterSelect

    End Sub
End Class
