<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Favorites", 0, 0)
        Me.MainToolbar = New System.Windows.Forms.ToolStrip()
        Me.btnBack = New System.Windows.Forms.ToolStripButton()
        Me.btnForward = New System.Windows.Forms.ToolStripButton()
        Me.cboURL = New System.Windows.Forms.ToolStripComboBox()
        Me.btnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.btnStop = New System.Windows.Forms.ToolStripButton()
        Me.btnHome = New System.Windows.Forms.ToolStripButton()
        Me.ddBtnPrint = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPrintPreview = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnPageSetup = New System.Windows.Forms.ToolStripMenuItem()
        Me.ddbtnPage = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem16 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnFind = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem13 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuDocExplorer = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnViewSource = New System.Windows.Forms.ToolStripMenuItem()
        Me.PropertiesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFeeds = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem14 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuLeftToRight = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRightToLeft = New System.Windows.Forms.ToolStripMenuItem()
        Me.ddbtnTools = New System.Windows.Forms.ToolStripDropDownButton()
        Me.mnuViewMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewStatus = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSpacer = New System.Windows.Forms.ToolStripSeparator()
        Me.btnInternetOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnViewCookies = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHistory = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTempFiles = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSearch = New System.Windows.Forms.ToolStripSplitButton()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.btnRSS = New System.Windows.Forms.ToolStripButton()
        Me.btnDocExp = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindOnThisPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuProperties = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProperties2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MainMenu = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNewTab = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem18 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuPageSetup = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrintPreview = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem19 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFProperties = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFind = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuView = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewMenuBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewStatusBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewSource = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFavs = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToFavoritesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrganizeFavoritesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem17 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuTools = New System.Windows.Forms.ToolStripMenuItem()
        Me.MailAndNewsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RSSViewerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCheckFeeds = New System.Windows.Forms.ToolStripMenuItem()
        Me.PopupBlockerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TurnOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PopupBlockerSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InternetOptionsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAddFav2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.DocumentExplorerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InternetOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.sBar = New System.Windows.Forms.StatusStrip()
        Me.lblPhising = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblElement = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.tbLinks = New System.Windows.Forms.MenuStrip()
        Me.btnShowFavs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnulNewTab = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAllWindows = New System.Windows.Forms.ToolStripMenuItem()
        Me.VoiceMarkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VoiceActivateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VoiceDeactivateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tvFavs = New System.Windows.Forms.TreeView()
        Me.ilFavs = New System.Windows.Forms.ImageList(Me.components)
        Me.tbFavs = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.btnFeeds = New System.Windows.Forms.ToolStripButton()
        Me.btnHistory = New System.Windows.Forms.ToolStripButton()
        Me.btnDocFav = New System.Windows.Forms.ToolStripButton()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.gbFavs = New System.Windows.Forms.Panel()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.tc1 = New JarvisExplorer.TabControl()
        Me.btnGoogle = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCP = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmFavs = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem20 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem21 = New System.Windows.Forms.ToolStripSeparator()
        Me.PropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainToolbar.SuspendLayout()
        Me.MainMenu.SuspendLayout()
        Me.sBar.SuspendLayout()
        Me.tbLinks.SuspendLayout()
        Me.tbFavs.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.gbFavs.SuspendLayout()
        Me.cmFavs.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainToolbar
        '
        Me.MainToolbar.AllowItemReorder = True
        Me.MainToolbar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MainToolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MainToolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBack, Me.btnForward, Me.cboURL, Me.btnRefresh, Me.btnStop, Me.btnHome, Me.ddBtnPrint, Me.ddbtnPage, Me.ddbtnTools, Me.btnSearch, Me.txtSearch, Me.btnRSS})
        Me.MainToolbar.Location = New System.Drawing.Point(0, 0)
        Me.MainToolbar.Name = "MainToolbar"
        Me.MainToolbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MainToolbar.Size = New System.Drawing.Size(909, 39)
        Me.MainToolbar.TabIndex = 0
        '
        'btnBack
        '
        Me.btnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnBack.Enabled = False
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(31, 36)
        Me.btnBack.ToolTipText = "Back"
        '
        'btnForward
        '
        Me.btnForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnForward.Image = CType(resources.GetObject("btnForward.Image"), System.Drawing.Image)
        Me.btnForward.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnForward.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnForward.Name = "btnForward"
        Me.btnForward.Size = New System.Drawing.Size(32, 36)
        '
        'cboURL
        '
        Me.cboURL.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboURL.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl
        Me.cboURL.AutoSize = False
        Me.cboURL.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboURL.Name = "cboURL"
        Me.cboURL.Size = New System.Drawing.Size(300, 23)
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Transparent
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnRefresh.ImageTransparentColor = System.Drawing.Color.White
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(3, 1, 0, 2)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(33, 36)
        Me.btnRefresh.ToolTipText = "Refresh"
        '
        'btnStop
        '
        Me.btnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnStop.Image = CType(resources.GetObject("btnStop.Image"), System.Drawing.Image)
        Me.btnStop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnStop.Margin = New System.Windows.Forms.Padding(3, 1, 0, 2)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(32, 36)
        Me.btnStop.ToolTipText = "Stop"
        '
        'btnHome
        '
        Me.btnHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnHome.Image = CType(resources.GetObject("btnHome.Image"), System.Drawing.Image)
        Me.btnHome.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnHome.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnHome.Margin = New System.Windows.Forms.Padding(3, 1, 0, 2)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(31, 36)
        Me.btnHome.Text = "Home"
        '
        'ddBtnPrint
        '
        Me.ddBtnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ddBtnPrint.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnPrintPreview, Me.ToolStripMenuItem11, Me.btnPageSetup})
        Me.ddBtnPrint.Image = CType(resources.GetObject("ddBtnPrint.Image"), System.Drawing.Image)
        Me.ddBtnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ddBtnPrint.Name = "ddBtnPrint"
        Me.ddBtnPrint.Size = New System.Drawing.Size(29, 36)
        Me.ddBtnPrint.ToolTipText = "Print Options"
        '
        'btnPrint
        '
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.btnPrint.Size = New System.Drawing.Size(152, 22)
        Me.btnPrint.Text = "Print..."
        '
        'btnPrintPreview
        '
        Me.btnPrintPreview.Name = "btnPrintPreview"
        Me.btnPrintPreview.Size = New System.Drawing.Size(152, 22)
        Me.btnPrintPreview.Text = "Print Preview..."
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(149, 6)
        '
        'btnPageSetup
        '
        Me.btnPageSetup.Name = "btnPageSetup"
        Me.btnPageSetup.Size = New System.Drawing.Size(152, 22)
        Me.btnPageSetup.Text = "Page Setup..."
        '
        'ddbtnPage
        '
        Me.ddbtnPage.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCut, Me.btnCopy, Me.btnPaste, Me.ToolStripMenuItem12, Me.btnSelectAll, Me.ToolStripMenuItem16, Me.btnFind, Me.ToolStripMenuItem13, Me.mnuDocExplorer, Me.btnViewSource, Me.PropertiesToolStripMenuItem1, Me.mnuFeeds, Me.ToolStripMenuItem14, Me.mnuLeftToRight, Me.mnuRightToLeft})
        Me.ddbtnPage.Image = CType(resources.GetObject("ddbtnPage.Image"), System.Drawing.Image)
        Me.ddbtnPage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ddbtnPage.Name = "ddbtnPage"
        Me.ddbtnPage.Size = New System.Drawing.Size(62, 36)
        Me.ddbtnPage.Text = "Page"
        '
        'btnCut
        '
        Me.btnCut.Image = CType(resources.GetObject("btnCut.Image"), System.Drawing.Image)
        Me.btnCut.Name = "btnCut"
        Me.btnCut.Size = New System.Drawing.Size(175, 22)
        Me.btnCut.Text = "Cut"
        '
        'btnCopy
        '
        Me.btnCopy.Image = CType(resources.GetObject("btnCopy.Image"), System.Drawing.Image)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(175, 22)
        Me.btnCopy.Text = "Copy"
        '
        'btnPaste
        '
        Me.btnPaste.Image = CType(resources.GetObject("btnPaste.Image"), System.Drawing.Image)
        Me.btnPaste.Name = "btnPaste"
        Me.btnPaste.Size = New System.Drawing.Size(175, 22)
        Me.btnPaste.Text = "Paste"
        '
        'ToolStripMenuItem12
        '
        Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        Me.ToolStripMenuItem12.Size = New System.Drawing.Size(172, 6)
        '
        'btnSelectAll
        '
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(175, 22)
        Me.btnSelectAll.Text = "Select All"
        '
        'ToolStripMenuItem16
        '
        Me.ToolStripMenuItem16.Name = "ToolStripMenuItem16"
        Me.ToolStripMenuItem16.Size = New System.Drawing.Size(172, 6)
        '
        'btnFind
        '
        Me.btnFind.Image = CType(resources.GetObject("btnFind.Image"), System.Drawing.Image)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(175, 22)
        Me.btnFind.Text = "Find on this Page..."
        '
        'ToolStripMenuItem13
        '
        Me.ToolStripMenuItem13.Name = "ToolStripMenuItem13"
        Me.ToolStripMenuItem13.Size = New System.Drawing.Size(172, 6)
        '
        'mnuDocExplorer
        '
        Me.mnuDocExplorer.Image = CType(resources.GetObject("mnuDocExplorer.Image"), System.Drawing.Image)
        Me.mnuDocExplorer.Name = "mnuDocExplorer"
        Me.mnuDocExplorer.Size = New System.Drawing.Size(175, 22)
        Me.mnuDocExplorer.Text = "Document Explorer"
        '
        'btnViewSource
        '
        Me.btnViewSource.Name = "btnViewSource"
        Me.btnViewSource.Size = New System.Drawing.Size(175, 22)
        Me.btnViewSource.Text = "View Source"
        '
        'PropertiesToolStripMenuItem1
        '
        Me.PropertiesToolStripMenuItem1.Image = CType(resources.GetObject("PropertiesToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.PropertiesToolStripMenuItem1.Name = "PropertiesToolStripMenuItem1"
        Me.PropertiesToolStripMenuItem1.Size = New System.Drawing.Size(175, 22)
        Me.PropertiesToolStripMenuItem1.Text = "Properties"
        '
        'mnuFeeds
        '
        Me.mnuFeeds.Enabled = False
        Me.mnuFeeds.Image = CType(resources.GetObject("mnuFeeds.Image"), System.Drawing.Image)
        Me.mnuFeeds.Name = "mnuFeeds"
        Me.mnuFeeds.Size = New System.Drawing.Size(175, 22)
        Me.mnuFeeds.Text = "Detected Feeds"
        '
        'ToolStripMenuItem14
        '
        Me.ToolStripMenuItem14.Name = "ToolStripMenuItem14"
        Me.ToolStripMenuItem14.Size = New System.Drawing.Size(172, 6)
        '
        'mnuLeftToRight
        '
        Me.mnuLeftToRight.Checked = True
        Me.mnuLeftToRight.CheckOnClick = True
        Me.mnuLeftToRight.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuLeftToRight.Name = "mnuLeftToRight"
        Me.mnuLeftToRight.Size = New System.Drawing.Size(175, 22)
        Me.mnuLeftToRight.Text = "Left To Right"
        '
        'mnuRightToLeft
        '
        Me.mnuRightToLeft.CheckOnClick = True
        Me.mnuRightToLeft.Name = "mnuRightToLeft"
        Me.mnuRightToLeft.Size = New System.Drawing.Size(175, 22)
        Me.mnuRightToLeft.Text = "Right To Left"
        '
        'ddbtnTools
        '
        Me.ddbtnTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuViewMenu, Me.mnuViewStatus, Me.mnuSpacer, Me.btnInternetOptions, Me.HistoryToolStripMenuItem, Me.mnuSettings, Me.btnViewCookies, Me.mnuHistory, Me.mnuTempFiles})
        Me.ddbtnTools.Image = CType(resources.GetObject("ddbtnTools.Image"), System.Drawing.Image)
        Me.ddbtnTools.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ddbtnTools.Name = "ddbtnTools"
        Me.ddbtnTools.Size = New System.Drawing.Size(65, 36)
        Me.ddbtnTools.Text = "Tools"
        '
        'mnuViewMenu
        '
        Me.mnuViewMenu.CheckOnClick = True
        Me.mnuViewMenu.Name = "mnuViewMenu"
        Me.mnuViewMenu.Size = New System.Drawing.Size(202, 22)
        Me.mnuViewMenu.Text = "Menu Bar"
        '
        'mnuViewStatus
        '
        Me.mnuViewStatus.Checked = True
        Me.mnuViewStatus.CheckOnClick = True
        Me.mnuViewStatus.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuViewStatus.Name = "mnuViewStatus"
        Me.mnuViewStatus.Size = New System.Drawing.Size(202, 22)
        Me.mnuViewStatus.Text = "Status Bar"
        '
        'mnuSpacer
        '
        Me.mnuSpacer.Name = "mnuSpacer"
        Me.mnuSpacer.Size = New System.Drawing.Size(199, 6)
        '
        'btnInternetOptions
        '
        Me.btnInternetOptions.Name = "btnInternetOptions"
        Me.btnInternetOptions.Size = New System.Drawing.Size(202, 22)
        Me.btnInternetOptions.Text = "Internet Options"
        '
        'HistoryToolStripMenuItem
        '
        Me.HistoryToolStripMenuItem.Name = "HistoryToolStripMenuItem"
        Me.HistoryToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.HistoryToolStripMenuItem.Text = "History"
        '
        'mnuSettings
        '
        Me.mnuSettings.Image = CType(resources.GetObject("mnuSettings.Image"), System.Drawing.Image)
        Me.mnuSettings.Name = "mnuSettings"
        Me.mnuSettings.Size = New System.Drawing.Size(202, 22)
        Me.mnuSettings.Text = "Settings"
        '
        'btnViewCookies
        '
        Me.btnViewCookies.Image = CType(resources.GetObject("btnViewCookies.Image"), System.Drawing.Image)
        Me.btnViewCookies.Name = "btnViewCookies"
        Me.btnViewCookies.Size = New System.Drawing.Size(202, 22)
        Me.btnViewCookies.Text = "Cookie Viewer"
        '
        'mnuHistory
        '
        Me.mnuHistory.Image = CType(resources.GetObject("mnuHistory.Image"), System.Drawing.Image)
        Me.mnuHistory.Name = "mnuHistory"
        Me.mnuHistory.Size = New System.Drawing.Size(202, 22)
        Me.mnuHistory.Text = "History Viewer"
        '
        'mnuTempFiles
        '
        Me.mnuTempFiles.Name = "mnuTempFiles"
        Me.mnuTempFiles.Size = New System.Drawing.Size(202, 22)
        Me.mnuTempFiles.Text = "Temporary Internet Files"
        '
        'btnSearch
        '
        Me.btnSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSearch.AutoSize = False
        Me.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSearch.DropDownButtonWidth = 12
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(35, 23)
        '
        'txtSearch
        '
        Me.txtSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtSearch.AutoSize = False
        Me.txtSearch.ForeColor = System.Drawing.Color.Silver
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(150, 39)
        Me.txtSearch.Text = "Google"
        '
        'btnRSS
        '
        Me.btnRSS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnRSS.Image = CType(resources.GetObject("btnRSS.Image"), System.Drawing.Image)
        Me.btnRSS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRSS.Name = "btnRSS"
        Me.btnRSS.Size = New System.Drawing.Size(23, 36)
        Me.btnRSS.ToolTipText = "RSS Viewer"
        '
        'btnDocExp
        '
        Me.btnDocExp.Image = CType(resources.GetObject("btnDocExp.Image"), System.Drawing.Image)
        Me.btnDocExp.Name = "btnDocExp"
        Me.btnDocExp.Size = New System.Drawing.Size(179, 22)
        Me.btnDocExp.Text = "Document Explorer"
        '
        'FindOnThisPageToolStripMenuItem
        '
        Me.FindOnThisPageToolStripMenuItem.Name = "FindOnThisPageToolStripMenuItem"
        Me.FindOnThisPageToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.FindOnThisPageToolStripMenuItem.Text = "Find On this page...."
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(176, 6)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(176, 6)
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(176, 6)
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(176, 6)
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(176, 6)
        '
        'mnuProperties
        '
        Me.mnuProperties.Name = "mnuProperties"
        Me.mnuProperties.Size = New System.Drawing.Size(179, 22)
        Me.mnuProperties.Text = "Properties"
        '
        'mnuProperties2
        '
        Me.mnuProperties2.Name = "mnuProperties2"
        Me.mnuProperties2.Size = New System.Drawing.Size(179, 22)
        Me.mnuProperties2.Text = "Properties 2"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(176, 6)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(157, 6)
        '
        'MainMenu
        '
        Me.MainMenu.AllowItemReorder = True
        Me.MainMenu.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuView, Me.mnuFavs, Me.mnuTools, Me.mnuHelp})
        Me.MainMenu.Location = New System.Drawing.Point(0, 39)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MainMenu.Size = New System.Drawing.Size(909, 24)
        Me.MainMenu.TabIndex = 1
        Me.MainMenu.Text = "MenuStrip1"
        Me.MainMenu.Visible = False
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.mnuOpen, Me.SaveToolStripMenuItem, Me.mnuSaveAs, Me.ToolStripMenuItem18, Me.mnuPageSetup, Me.mnuPrint, Me.mnuPrintPreview, Me.ToolStripMenuItem19, Me.mnuFProperties, Me.mnuClose})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNewTab})
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'mnuNewTab
        '
        Me.mnuNewTab.Image = CType(resources.GetObject("mnuNewTab.Image"), System.Drawing.Image)
        Me.mnuNewTab.Name = "mnuNewTab"
        Me.mnuNewTab.Size = New System.Drawing.Size(94, 22)
        Me.mnuNewTab.Text = "Tab"
        '
        'mnuOpen
        '
        Me.mnuOpen.Image = CType(resources.GetObject("mnuOpen.Image"), System.Drawing.Image)
        Me.mnuOpen.Name = "mnuOpen"
        Me.mnuOpen.Size = New System.Drawing.Size(152, 22)
        Me.mnuOpen.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Enabled = False
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'mnuSaveAs
        '
        Me.mnuSaveAs.Name = "mnuSaveAs"
        Me.mnuSaveAs.Size = New System.Drawing.Size(152, 22)
        Me.mnuSaveAs.Text = "Save As..."
        '
        'ToolStripMenuItem18
        '
        Me.ToolStripMenuItem18.Name = "ToolStripMenuItem18"
        Me.ToolStripMenuItem18.Size = New System.Drawing.Size(149, 6)
        '
        'mnuPageSetup
        '
        Me.mnuPageSetup.Name = "mnuPageSetup"
        Me.mnuPageSetup.Size = New System.Drawing.Size(152, 22)
        Me.mnuPageSetup.Text = "Page Setup..."
        '
        'mnuPrint
        '
        Me.mnuPrint.Image = CType(resources.GetObject("mnuPrint.Image"), System.Drawing.Image)
        Me.mnuPrint.Name = "mnuPrint"
        Me.mnuPrint.Size = New System.Drawing.Size(152, 22)
        Me.mnuPrint.Text = "Print"
        '
        'mnuPrintPreview
        '
        Me.mnuPrintPreview.Name = "mnuPrintPreview"
        Me.mnuPrintPreview.Size = New System.Drawing.Size(152, 22)
        Me.mnuPrintPreview.Text = "Print Preview..."
        '
        'ToolStripMenuItem19
        '
        Me.ToolStripMenuItem19.Name = "ToolStripMenuItem19"
        Me.ToolStripMenuItem19.Size = New System.Drawing.Size(149, 6)
        '
        'mnuFProperties
        '
        Me.mnuFProperties.Image = CType(resources.GetObject("mnuFProperties.Image"), System.Drawing.Image)
        Me.mnuFProperties.Name = "mnuFProperties"
        Me.mnuFProperties.Size = New System.Drawing.Size(152, 22)
        Me.mnuFProperties.Text = "Properties"
        '
        'mnuClose
        '
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(152, 22)
        Me.mnuClose.Text = "Close"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCut, Me.mnuCopy, Me.mnuPaste, Me.ToolStripMenuItem9, Me.mnuSelectAll, Me.ToolStripMenuItem10, Me.mnuFind})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(39, 20)
        Me.mnuEdit.Text = "Edit"
        '
        'mnuCut
        '
        Me.mnuCut.Image = CType(resources.GetObject("mnuCut.Image"), System.Drawing.Image)
        Me.mnuCut.Name = "mnuCut"
        Me.mnuCut.Size = New System.Drawing.Size(176, 22)
        Me.mnuCut.Text = "Cut"
        '
        'mnuCopy
        '
        Me.mnuCopy.Image = CType(resources.GetObject("mnuCopy.Image"), System.Drawing.Image)
        Me.mnuCopy.Name = "mnuCopy"
        Me.mnuCopy.Size = New System.Drawing.Size(176, 22)
        Me.mnuCopy.Text = "Copy"
        '
        'mnuPaste
        '
        Me.mnuPaste.Image = CType(resources.GetObject("mnuPaste.Image"), System.Drawing.Image)
        Me.mnuPaste.Name = "mnuPaste"
        Me.mnuPaste.Size = New System.Drawing.Size(176, 22)
        Me.mnuPaste.Text = "Paste"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(173, 6)
        '
        'mnuSelectAll
        '
        Me.mnuSelectAll.Name = "mnuSelectAll"
        Me.mnuSelectAll.Size = New System.Drawing.Size(176, 22)
        Me.mnuSelectAll.Text = "Select All"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(173, 6)
        '
        'mnuFind
        '
        Me.mnuFind.Image = CType(resources.GetObject("mnuFind.Image"), System.Drawing.Image)
        Me.mnuFind.Name = "mnuFind"
        Me.mnuFind.Size = New System.Drawing.Size(176, 22)
        Me.mnuFind.Text = "Find On this page..."
        '
        'mnuView
        '
        Me.mnuView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuViewMenuBar, Me.mnuViewStatusBar, Me.RefreshToolStripMenuItem, Me.mnuViewSource})
        Me.mnuView.Name = "mnuView"
        Me.mnuView.Size = New System.Drawing.Size(44, 20)
        Me.mnuView.Text = "View"
        '
        'mnuViewMenuBar
        '
        Me.mnuViewMenuBar.Checked = True
        Me.mnuViewMenuBar.CheckOnClick = True
        Me.mnuViewMenuBar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuViewMenuBar.Name = "mnuViewMenuBar"
        Me.mnuViewMenuBar.Size = New System.Drawing.Size(132, 28)
        Me.mnuViewMenuBar.Text = "Menu Bar"
        '
        'mnuViewStatusBar
        '
        Me.mnuViewStatusBar.Checked = True
        Me.mnuViewStatusBar.CheckOnClick = True
        Me.mnuViewStatusBar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuViewStatusBar.Name = "mnuViewStatusBar"
        Me.mnuViewStatusBar.Size = New System.Drawing.Size(132, 28)
        Me.mnuViewStatusBar.Text = "Status Bar"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = CType(resources.GetObject("RefreshToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RefreshToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(132, 28)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'mnuViewSource
        '
        Me.mnuViewSource.Name = "mnuViewSource"
        Me.mnuViewSource.Size = New System.Drawing.Size(132, 28)
        Me.mnuViewSource.Text = "Source"
        '
        'mnuFavs
        '
        Me.mnuFavs.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToFavoritesToolStripMenuItem, Me.OrganizeFavoritesToolStripMenuItem, Me.ToolStripMenuItem17})
        Me.mnuFavs.Name = "mnuFavs"
        Me.mnuFavs.Size = New System.Drawing.Size(66, 20)
        Me.mnuFavs.Text = "Favorites"
        '
        'AddToFavoritesToolStripMenuItem
        '
        Me.AddToFavoritesToolStripMenuItem.Image = CType(resources.GetObject("AddToFavoritesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddToFavoritesToolStripMenuItem.Name = "AddToFavoritesToolStripMenuItem"
        Me.AddToFavoritesToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.AddToFavoritesToolStripMenuItem.Text = "Add to Favorites"
        '
        'OrganizeFavoritesToolStripMenuItem
        '
        Me.OrganizeFavoritesToolStripMenuItem.Name = "OrganizeFavoritesToolStripMenuItem"
        Me.OrganizeFavoritesToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.OrganizeFavoritesToolStripMenuItem.Text = "Organize Favorites"
        '
        'ToolStripMenuItem17
        '
        Me.ToolStripMenuItem17.Name = "ToolStripMenuItem17"
        Me.ToolStripMenuItem17.Size = New System.Drawing.Size(168, 6)
        '
        'mnuTools
        '
        Me.mnuTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MailAndNewsToolStripMenuItem, Me.PopupBlockerToolStripMenuItem, Me.InternetOptionsToolStripMenuItem1, Me.SettingsToolStripMenuItem})
        Me.mnuTools.Name = "mnuTools"
        Me.mnuTools.Size = New System.Drawing.Size(48, 20)
        Me.mnuTools.Text = "Tools"
        '
        'MailAndNewsToolStripMenuItem
        '
        Me.MailAndNewsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RSSViewerToolStripMenuItem, Me.mnuCheckFeeds})
        Me.MailAndNewsToolStripMenuItem.Name = "MailAndNewsToolStripMenuItem"
        Me.MailAndNewsToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.MailAndNewsToolStripMenuItem.Text = "Mail and News"
        '
        'RSSViewerToolStripMenuItem
        '
        Me.RSSViewerToolStripMenuItem.Image = CType(resources.GetObject("RSSViewerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RSSViewerToolStripMenuItem.Name = "RSSViewerToolStripMenuItem"
        Me.RSSViewerToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.RSSViewerToolStripMenuItem.Text = "RSS Viewer"
        '
        'mnuCheckFeeds
        '
        Me.mnuCheckFeeds.Name = "mnuCheckFeeds"
        Me.mnuCheckFeeds.Size = New System.Drawing.Size(156, 22)
        Me.mnuCheckFeeds.Text = "Check for feeds"
        '
        'PopupBlockerToolStripMenuItem
        '
        Me.PopupBlockerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TurnOToolStripMenuItem, Me.PopupBlockerSettingsToolStripMenuItem})
        Me.PopupBlockerToolStripMenuItem.Name = "PopupBlockerToolStripMenuItem"
        Me.PopupBlockerToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.PopupBlockerToolStripMenuItem.Text = "Popup Blocker"
        '
        'TurnOToolStripMenuItem
        '
        Me.TurnOToolStripMenuItem.Name = "TurnOToolStripMenuItem"
        Me.TurnOToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.TurnOToolStripMenuItem.Text = "Turn Off popup blocker"
        '
        'PopupBlockerSettingsToolStripMenuItem
        '
        Me.PopupBlockerSettingsToolStripMenuItem.Name = "PopupBlockerSettingsToolStripMenuItem"
        Me.PopupBlockerSettingsToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.PopupBlockerSettingsToolStripMenuItem.Text = "Popup Blocker Settings"
        '
        'InternetOptionsToolStripMenuItem1
        '
        Me.InternetOptionsToolStripMenuItem1.Name = "InternetOptionsToolStripMenuItem1"
        Me.InternetOptionsToolStripMenuItem1.Size = New System.Drawing.Size(160, 22)
        Me.InternetOptionsToolStripMenuItem1.Text = "Internet Options"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Image = CType(resources.GetObject("SettingsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "Help"
        '
        'mnuAbout
        '
        Me.mnuAbout.Image = CType(resources.GetObject("mnuAbout.Image"), System.Drawing.Image)
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(107, 22)
        Me.mnuAbout.Text = "About"
        '
        'mnuAddFav2
        '
        Me.mnuAddFav2.AutoToolTip = True
        Me.mnuAddFav2.Image = CType(resources.GetObject("mnuAddFav2.Image"), System.Drawing.Image)
        Me.mnuAddFav2.Name = "mnuAddFav2"
        Me.mnuAddFav2.Size = New System.Drawing.Size(28, 20)
        Me.mnuAddFav2.ToolTipText = "Add to favorites"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(173, 6)
        '
        'DocumentExplorerToolStripMenuItem
        '
        Me.DocumentExplorerToolStripMenuItem.Name = "DocumentExplorerToolStripMenuItem"
        Me.DocumentExplorerToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.DocumentExplorerToolStripMenuItem.Text = "Document Explorer"
        '
        'InternetOptionsToolStripMenuItem
        '
        Me.InternetOptionsToolStripMenuItem.Name = "InternetOptionsToolStripMenuItem"
        Me.InternetOptionsToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.InternetOptionsToolStripMenuItem.Text = "Internet Options"
        '
        'sBar
        '
        Me.sBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblPhising, Me.lblStatus, Me.lblElement, Me.pBar})
        Me.sBar.Location = New System.Drawing.Point(0, 486)
        Me.sBar.Name = "sBar"
        Me.sBar.ShowItemToolTips = True
        Me.sBar.Size = New System.Drawing.Size(909, 22)
        Me.sBar.TabIndex = 2
        Me.sBar.Text = "StatusStrip1"
        '
        'lblPhising
        '
        Me.lblPhising.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.lblPhising.Image = CType(resources.GetObject("lblPhising.Image"), System.Drawing.Image)
        Me.lblPhising.Name = "lblPhising"
        Me.lblPhising.Size = New System.Drawing.Size(16, 17)
        Me.lblPhising.Visible = False
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(894, 17)
        Me.lblStatus.Spring = True
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblElement
        '
        Me.lblElement.BorderStyle = System.Windows.Forms.Border3DStyle.Raised
        Me.lblElement.Name = "lblElement"
        Me.lblElement.Size = New System.Drawing.Size(0, 17)
        '
        'pBar
        '
        Me.pBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.pBar.AutoSize = False
        Me.pBar.Name = "pBar"
        Me.pBar.Size = New System.Drawing.Size(250, 16)
        Me.pBar.Visible = False
        '
        'tbLinks
        '
        Me.tbLinks.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbLinks.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnShowFavs, Me.mnuAddFav2, Me.mnulNewTab, Me.mnuAllWindows, Me.VoiceMarkToolStripMenuItem, Me.VoiceActivateToolStripMenuItem, Me.VoiceDeactivateToolStripMenuItem})
        Me.tbLinks.Location = New System.Drawing.Point(0, 39)
        Me.tbLinks.Name = "tbLinks"
        Me.tbLinks.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.tbLinks.ShowItemToolTips = True
        Me.tbLinks.Size = New System.Drawing.Size(909, 24)
        Me.tbLinks.TabIndex = 3
        Me.tbLinks.Text = "MenuStrip2"
        '
        'btnShowFavs
        '
        Me.btnShowFavs.AutoToolTip = True
        Me.btnShowFavs.CheckOnClick = True
        Me.btnShowFavs.Image = CType(resources.GetObject("btnShowFavs.Image"), System.Drawing.Image)
        Me.btnShowFavs.Name = "btnShowFavs"
        Me.btnShowFavs.Size = New System.Drawing.Size(28, 20)
        Me.btnShowFavs.ToolTipText = "Show favorites"
        '
        'mnulNewTab
        '
        Me.mnulNewTab.AutoToolTip = True
        Me.mnulNewTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnulNewTab.Image = CType(resources.GetObject("mnulNewTab.Image"), System.Drawing.Image)
        Me.mnulNewTab.Name = "mnulNewTab"
        Me.mnulNewTab.Size = New System.Drawing.Size(28, 20)
        Me.mnulNewTab.ToolTipText = "New Tab"
        '
        'mnuAllWindows
        '
        Me.mnuAllWindows.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuAllWindows.Image = CType(resources.GetObject("mnuAllWindows.Image"), System.Drawing.Image)
        Me.mnuAllWindows.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuAllWindows.Name = "mnuAllWindows"
        Me.mnuAllWindows.Size = New System.Drawing.Size(33, 24)
        Me.mnuAllWindows.Text = "Show ALL"
        Me.mnuAllWindows.Visible = False
        '
        'VoiceMarkToolStripMenuItem
        '
        Me.VoiceMarkToolStripMenuItem.Name = "VoiceMarkToolStripMenuItem"
        Me.VoiceMarkToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.VoiceMarkToolStripMenuItem.Text = "Voice-Mark"
        '
        'VoiceActivateToolStripMenuItem
        '
        Me.VoiceActivateToolStripMenuItem.Name = "VoiceActivateToolStripMenuItem"
        Me.VoiceActivateToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.VoiceActivateToolStripMenuItem.Text = "Voice-Activate"
        '
        'VoiceDeactivateToolStripMenuItem
        '
        Me.VoiceDeactivateToolStripMenuItem.Name = "VoiceDeactivateToolStripMenuItem"
        Me.VoiceDeactivateToolStripMenuItem.Size = New System.Drawing.Size(108, 20)
        Me.VoiceDeactivateToolStripMenuItem.Text = "Voice-Deactivate"
        '
        'tvFavs
        '
        Me.tvFavs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tvFavs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvFavs.HotTracking = True
        Me.tvFavs.ImageIndex = 0
        Me.tvFavs.ImageList = Me.ilFavs
        Me.tvFavs.Location = New System.Drawing.Point(3, 40)
        Me.tvFavs.Name = "tvFavs"
        TreeNode1.ImageIndex = 0
        TreeNode1.Name = "Node0"
        TreeNode1.SelectedImageIndex = 0
        TreeNode1.Tag = "-1"
        TreeNode1.Text = "Favorites"
        Me.tvFavs.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1})
        Me.tvFavs.SelectedImageIndex = 0
        Me.tvFavs.ShowLines = False
        Me.tvFavs.ShowPlusMinus = False
        Me.tvFavs.ShowRootLines = False
        Me.tvFavs.Size = New System.Drawing.Size(244, 350)
        Me.tvFavs.TabIndex = 1
        '
        'ilFavs
        '
        Me.ilFavs.ImageStream = CType(resources.GetObject("ilFavs.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilFavs.TransparentColor = System.Drawing.Color.Transparent
        Me.ilFavs.Images.SetKeyName(0, "folder3.png")
        Me.ilFavs.Images.SetKeyName(1, "Open.png")
        '
        'tbFavs
        '
        Me.tbFavs.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tbFavs.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.btnFeeds, Me.btnHistory, Me.btnDocFav})
        Me.tbFavs.Location = New System.Drawing.Point(3, 3)
        Me.tbFavs.Name = "tbFavs"
        Me.tbFavs.Padding = New System.Windows.Forms.Padding(3)
        Me.tbFavs.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tbFavs.Size = New System.Drawing.Size(244, 37)
        Me.tbFavs.TabIndex = 4
        Me.tbFavs.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Checked = True
        Me.ToolStripButton1.CheckOnClick = True
        Me.ToolStripButton1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(74, 28)
        Me.ToolStripButton1.Text = "Favorites"
        '
        'btnFeeds
        '
        Me.btnFeeds.CheckOnClick = True
        Me.btnFeeds.Image = CType(resources.GetObject("btnFeeds.Image"), System.Drawing.Image)
        Me.btnFeeds.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFeeds.Name = "btnFeeds"
        Me.btnFeeds.Size = New System.Drawing.Size(57, 28)
        Me.btnFeeds.Text = "Feeds"
        '
        'btnHistory
        '
        Me.btnHistory.Image = CType(resources.GetObject("btnHistory.Image"), System.Drawing.Image)
        Me.btnHistory.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(65, 28)
        Me.btnHistory.Text = "History"
        '
        'btnDocFav
        '
        Me.btnDocFav.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnDocFav.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnDocFav.Image = CType(resources.GetObject("btnDocFav.Image"), System.Drawing.Image)
        Me.btnDocFav.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnDocFav.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDocFav.Name = "btnDocFav"
        Me.btnDocFav.Size = New System.Drawing.Size(30, 28)
        Me.btnDocFav.Tag = "1"
        Me.btnDocFav.Text = "ToolStripButton4"
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.gbFavs)
        Me.pnlMain.Controls.Add(Me.Splitter1)
        Me.pnlMain.Controls.Add(Me.tc1)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 63)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(909, 423)
        Me.pnlMain.TabIndex = 7
        '
        'gbFavs
        '
        Me.gbFavs.Controls.Add(Me.tvFavs)
        Me.gbFavs.Controls.Add(Me.tbFavs)
        Me.gbFavs.Location = New System.Drawing.Point(3, 3)
        Me.gbFavs.Name = "gbFavs"
        Me.gbFavs.Padding = New System.Windows.Forms.Padding(3)
        Me.gbFavs.Size = New System.Drawing.Size(250, 393)
        Me.gbFavs.TabIndex = 8
        Me.gbFavs.Visible = False
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 423)
        Me.Splitter1.TabIndex = 6
        Me.Splitter1.TabStop = False
        Me.Splitter1.Visible = False
        '
        'tc1
        '
        Me.tc1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tc1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tc1.Location = New System.Drawing.Point(0, 0)
        Me.tc1.MenuRenderer = Nothing
        Me.tc1.Name = "tc1"
        Me.tc1.Size = New System.Drawing.Size(909, 423)
        Me.tc1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed
        Me.tc1.TabBorderEnhanced = True
        Me.tc1.TabCloseButtonImage = Nothing
        Me.tc1.TabCloseButtonImageDisabled = Nothing
        Me.tc1.TabCloseButtonImageHot = Nothing
        Me.tc1.TabIndex = 7
        '
        'btnGoogle
        '
        Me.btnGoogle.Checked = True
        Me.btnGoogle.CheckState = System.Windows.Forms.CheckState.Checked
        Me.btnGoogle.Name = "btnGoogle"
        Me.btnGoogle.Size = New System.Drawing.Size(185, 22)
        Me.btnGoogle.Text = "Google"
        '
        'mnuCP
        '
        Me.mnuCP.Image = CType(resources.GetObject("mnuCP.Image"), System.Drawing.Image)
        Me.mnuCP.Name = "mnuCP"
        Me.mnuCP.Size = New System.Drawing.Size(185, 22)
        Me.mnuCP.Text = "Code Project"
        '
        'cmFavs
        '
        Me.cmFavs.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmFavs.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ToolStripMenuItem20, Me.DeleteToolStripMenuItem, Me.RenameToolStripMenuItem, Me.ToolStripMenuItem21, Me.PropertiesToolStripMenuItem})
        Me.cmFavs.Name = "cmFavs"
        Me.cmFavs.Size = New System.Drawing.Size(128, 104)
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'ToolStripMenuItem20
        '
        Me.ToolStripMenuItem20.Name = "ToolStripMenuItem20"
        Me.ToolStripMenuItem20.Size = New System.Drawing.Size(124, 6)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'RenameToolStripMenuItem
        '
        Me.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem"
        Me.RenameToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.RenameToolStripMenuItem.Text = "Rename"
        '
        'ToolStripMenuItem21
        '
        Me.ToolStripMenuItem21.Name = "ToolStripMenuItem21"
        Me.ToolStripMenuItem21.Size = New System.Drawing.Size(124, 6)
        '
        'PropertiesToolStripMenuItem
        '
        Me.PropertiesToolStripMenuItem.Name = "PropertiesToolStripMenuItem"
        Me.PropertiesToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.PropertiesToolStripMenuItem.Text = "Properties"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(909, 508)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.sBar)
        Me.Controls.Add(Me.tbLinks)
        Me.Controls.Add(Me.MainMenu)
        Me.Controls.Add(Me.MainToolbar)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MainMenu
        Me.Name = "frmMain"
        Me.Text = "Jarvis Explorer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MainToolbar.ResumeLayout(False)
        Me.MainToolbar.PerformLayout()
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.sBar.ResumeLayout(False)
        Me.sBar.PerformLayout()
        Me.tbLinks.ResumeLayout(False)
        Me.tbLinks.PerformLayout()
        Me.tbFavs.ResumeLayout(False)
        Me.tbFavs.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.gbFavs.ResumeLayout(False)
        Me.gbFavs.PerformLayout()
        Me.cmFavs.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainToolbar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnBack As System.Windows.Forms.ToolStripButton
    Friend WithEvents MainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sBar As System.Windows.Forms.StatusStrip
    Friend WithEvents tbLinks As System.Windows.Forms.MenuStrip
    Friend WithEvents cboURL As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents btnSearch As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents txtSearch As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents btnStop As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNewTab As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnHome As System.Windows.Forms.ToolStripButton
    Friend WithEvents ddbtnPage As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ddBtnPrint As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPrintPreview As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnPageSetup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ddbtnTools As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents btnCut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPaste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSelectAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnFind As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnViewSource As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnDocExp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFavs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToFavoritesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrganizeFavoritesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuTools As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tvFavs As System.Windows.Forms.TreeView
    Friend WithEvents btnShowFavs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ilFavs As System.Windows.Forms.ImageList
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents btnInternetOptions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAddFav2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents pBar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents mnulNewTab As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuViewMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuViewStatus As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDocExplorer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FindOnThisPageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuProperties As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuProperties2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPaste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSelectAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuFind As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuViewSource As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuViewMenuBar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuViewStatusBar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DocumentExplorerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InternetOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnGoogle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem14 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSpacer As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem16 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem17 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbFavs As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnFeeds As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDocFav As System.Windows.Forms.ToolStripButton
    Friend WithEvents gbFavs As System.Windows.Forms.Panel
    Friend WithEvents mnuSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLeftToRight As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRightToLeft As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblElement As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnRSS As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuSaveAs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem18 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuPageSetup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPrintPreview As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem19 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuFProperties As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MailAndNewsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RSSViewerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PopupBlockerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TurnOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PopupBlockerSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InternetOptionsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PropertiesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnForward As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnHistory As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblPhising As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents cmFavs As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem20 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RenameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem21 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PropertiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCheckFeeds As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAllWindows As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnViewCookies As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHistory As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTempFiles As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFeeds As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VoiceMarkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VoiceActivateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VoiceDeactivateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tc1 As JarvisExplorer.TabControl

End Class
