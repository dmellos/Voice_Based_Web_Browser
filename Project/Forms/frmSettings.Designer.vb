<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.chkAllowPop = New System.Windows.Forms.CheckBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.btnPopRemoveAll = New System.Windows.Forms.Button
        Me.btnPopRemove = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lbPop = New System.Windows.Forms.ListBox
        Me.btnPopAdd = New System.Windows.Forms.Button
        Me.txtPop = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.chkPopInfo = New System.Windows.Forms.CheckBox
        Me.chkPopSound = New System.Windows.Forms.CheckBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.chkStart = New System.Windows.Forms.CheckBox
        Me.chkShowTags = New System.Windows.Forms.CheckBox
        Me.chkSupress = New System.Windows.Forms.CheckBox
        Me.chkInternal = New System.Windows.Forms.CheckBox
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnBlockRemoveAll = New System.Windows.Forms.Button
        Me.btnRemoveBlock = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lbBlocked = New System.Windows.Forms.ListBox
        Me.btnAddBlock = New System.Windows.Forms.Button
        Me.txtBlock = New System.Windows.Forms.TextBox
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.RadioButton5 = New System.Windows.Forms.RadioButton
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.CheckBox4 = New System.Windows.Forms.CheckBox
        Me.chkDLMng = New System.Windows.Forms.GroupBox
        Me.chkUseDLManager = New System.Windows.Forms.CheckBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtDLPath = New System.Windows.Forms.TextBox
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button10 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Button11 = New System.Windows.Forms.Button
        Me.txtExt = New System.Windows.Forms.TextBox
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkSearchDefault = New System.Windows.Forms.CheckBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtSearchTitle = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.lvSearchProviders = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.cmSearch = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmSearchRemove = New System.Windows.Forms.ToolStripMenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnAddProvider = New System.Windows.Forms.Button
        Me.txtSearchURL = New System.Windows.Forms.TextBox
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.Label10 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnOK = New System.Windows.Forms.Button
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        Me.TabPage7 = New System.Windows.Forms.TabPage
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.btnRemoveAllPhish = New System.Windows.Forms.Button
        Me.btnRemovePhish = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.lbPhishing = New System.Windows.Forms.ListBox
        Me.btnAddPhish = New System.Windows.Forms.Button
        Me.txtPhishing = New System.Windows.Forms.TextBox
        Me.chkPhishing = New System.Windows.Forms.CheckBox
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.chkDLMng.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.cmSearch.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(395, 418)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.chkAllowPop)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.ImageIndex = 0
        Me.TabPage1.Location = New System.Drawing.Point(4, 40)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(387, 374)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Popup Blocker"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'chkAllowPop
        '
        Me.chkAllowPop.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.chkAllowPop, "Enables or disables the popup blocker feature.")
        Me.chkAllowPop.Location = New System.Drawing.Point(11, 7)
        Me.chkAllowPop.Name = "chkAllowPop"
        Me.HelpProvider1.SetShowHelp(Me.chkAllowPop, True)
        Me.chkAllowPop.Size = New System.Drawing.Size(128, 17)
        Me.chkAllowPop.TabIndex = 7
        Me.chkAllowPop.Text = "Enable popup blocker"
        Me.chkAllowPop.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnPopRemoveAll)
        Me.GroupBox4.Controls.Add(Me.btnPopRemove)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.lbPop)
        Me.GroupBox4.Controls.Add(Me.btnPopAdd)
        Me.GroupBox4.Controls.Add(Me.txtPop)
        Me.GroupBox4.Location = New System.Drawing.Point(5, 30)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(376, 262)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Exceptions"
        '
        'btnPopRemoveAll
        '
        Me.btnPopRemoveAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPopRemoveAll.Location = New System.Drawing.Point(294, 122)
        Me.btnPopRemoveAll.Name = "btnPopRemoveAll"
        Me.btnPopRemoveAll.Size = New System.Drawing.Size(74, 23)
        Me.btnPopRemoveAll.TabIndex = 6
        Me.btnPopRemoveAll.Text = "Remove ALL"
        Me.btnPopRemoveAll.UseVisualStyleBackColor = True
        '
        'btnPopRemove
        '
        Me.btnPopRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPopRemove.Location = New System.Drawing.Point(294, 93)
        Me.btnPopRemove.Name = "btnPopRemove"
        Me.btnPopRemove.Size = New System.Drawing.Size(74, 23)
        Me.btnPopRemove.TabIndex = 5
        Me.btnPopRemove.Text = "Remove"
        Me.btnPopRemove.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(6, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Allowed Sites"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(7, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(363, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Address of website to allow"
        '
        'lbPop
        '
        Me.lbPop.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.lbPop, "This is a list of sites where popups are allowed. You can use shift + click to al" & _
                "low a popup at anytime.")
        Me.lbPop.Location = New System.Drawing.Point(6, 74)
        Me.lbPop.Name = "lbPop"
        Me.HelpProvider1.SetShowHelp(Me.lbPop, True)
        Me.lbPop.Size = New System.Drawing.Size(283, 173)
        Me.lbPop.TabIndex = 2
        '
        'btnPopAdd
        '
        Me.btnPopAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPopAdd.Location = New System.Drawing.Point(293, 51)
        Me.btnPopAdd.Name = "btnPopAdd"
        Me.btnPopAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnPopAdd.TabIndex = 1
        Me.btnPopAdd.Text = "Add"
        Me.btnPopAdd.UseVisualStyleBackColor = True
        '
        'txtPop
        '
        Me.HelpProvider1.SetHelpString(Me.txtPop, "URL of site you want to add to allowed list (http://www.microsoft.com)")
        Me.txtPop.Location = New System.Drawing.Point(6, 31)
        Me.txtPop.Name = "txtPop"
        Me.HelpProvider1.SetShowHelp(Me.txtPop, True)
        Me.txtPop.Size = New System.Drawing.Size(283, 21)
        Me.txtPop.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkPopInfo)
        Me.GroupBox3.Controls.Add(Me.chkPopSound)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 298)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(376, 70)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Default action"
        '
        'chkPopInfo
        '
        Me.chkPopInfo.AutoSize = True
        Me.chkPopInfo.Location = New System.Drawing.Point(10, 43)
        Me.chkPopInfo.Name = "chkPopInfo"
        Me.chkPopInfo.Size = New System.Drawing.Size(218, 17)
        Me.chkPopInfo.TabIndex = 4
        Me.chkPopInfo.Text = "Show Info bar when a popup is blocked."
        Me.chkPopInfo.UseVisualStyleBackColor = True
        '
        'chkPopSound
        '
        Me.chkPopSound.AutoSize = True
        Me.chkPopSound.Location = New System.Drawing.Point(10, 20)
        Me.chkPopSound.Name = "chkPopSound"
        Me.chkPopSound.Size = New System.Drawing.Size(203, 17)
        Me.chkPopSound.TabIndex = 3
        Me.chkPopSound.Text = "Play Sound when a popup is blocked."
        Me.chkPopSound.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.chkStart)
        Me.TabPage2.Controls.Add(Me.chkShowTags)
        Me.TabPage2.Controls.Add(Me.chkSupress)
        Me.TabPage2.Controls.Add(Me.chkInternal)
        Me.TabPage2.Location = New System.Drawing.Point(4, 40)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(387, 374)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Additional Settings"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'chkStart
        '
        Me.chkStart.AutoSize = True
        Me.chkStart.Location = New System.Drawing.Point(30, 94)
        Me.chkStart.Name = "chkStart"
        Me.chkStart.Size = New System.Drawing.Size(147, 17)
        Me.chkStart.TabIndex = 3
        Me.chkStart.Text = "Go to Start Page on Load"
        Me.chkStart.UseVisualStyleBackColor = True
        '
        'chkShowTags
        '
        Me.chkShowTags.AutoSize = True
        Me.chkShowTags.Location = New System.Drawing.Point(30, 71)
        Me.chkShowTags.Name = "chkShowTags"
        Me.chkShowTags.Size = New System.Drawing.Size(183, 17)
        Me.chkShowTags.TabIndex = 2
        Me.chkShowTags.Text = "Show Element Tags in Status Bar"
        Me.chkShowTags.UseVisualStyleBackColor = True
        '
        'chkSupress
        '
        Me.chkSupress.AutoSize = True
        Me.chkSupress.Location = New System.Drawing.Point(30, 48)
        Me.chkSupress.Name = "chkSupress"
        Me.chkSupress.Size = New System.Drawing.Size(148, 17)
        Me.chkSupress.TabIndex = 1
        Me.chkSupress.Text = "Supress Javascript Errors"
        Me.chkSupress.UseVisualStyleBackColor = True
        '
        'chkInternal
        '
        Me.chkInternal.AutoSize = True
        Me.chkInternal.Location = New System.Drawing.Point(30, 25)
        Me.chkInternal.Name = "chkInternal"
        Me.chkInternal.Size = New System.Drawing.Size(114, 17)
        Me.chkInternal.TabIndex = 0
        Me.chkInternal.Text = "Use Internal Menu"
        Me.chkInternal.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 40)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(387, 374)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Blocked Sites"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnBlockRemoveAll)
        Me.GroupBox2.Controls.Add(Me.btnRemoveBlock)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lbBlocked)
        Me.GroupBox2.Controls.Add(Me.btnAddBlock)
        Me.GroupBox2.Controls.Add(Me.txtBlock)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(387, 374)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Blocked Sites Manager"
        '
        'btnBlockRemoveAll
        '
        Me.btnBlockRemoveAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBlockRemoveAll.Location = New System.Drawing.Point(305, 110)
        Me.btnBlockRemoveAll.Name = "btnBlockRemoveAll"
        Me.btnBlockRemoveAll.Size = New System.Drawing.Size(74, 23)
        Me.btnBlockRemoveAll.TabIndex = 6
        Me.btnBlockRemoveAll.Text = "Remove ALL"
        Me.btnBlockRemoveAll.UseVisualStyleBackColor = True
        '
        'btnRemoveBlock
        '
        Me.btnRemoveBlock.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemoveBlock.Location = New System.Drawing.Point(305, 81)
        Me.btnRemoveBlock.Name = "btnRemoveBlock"
        Me.btnRemoveBlock.Size = New System.Drawing.Size(74, 23)
        Me.btnRemoveBlock.TabIndex = 5
        Me.btnRemoveBlock.Text = "Remove"
        Me.btnRemoveBlock.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(294, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Blocked Sites"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(7, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(363, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Address of website to block"
        '
        'lbBlocked
        '
        Me.lbBlocked.FormattingEnabled = True
        Me.lbBlocked.Location = New System.Drawing.Point(6, 74)
        Me.lbBlocked.Name = "lbBlocked"
        Me.lbBlocked.Size = New System.Drawing.Size(292, 290)
        Me.lbBlocked.TabIndex = 2
        '
        'btnAddBlock
        '
        Me.btnAddBlock.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddBlock.Location = New System.Drawing.Point(305, 30)
        Me.btnAddBlock.Name = "btnAddBlock"
        Me.btnAddBlock.Size = New System.Drawing.Size(75, 23)
        Me.btnAddBlock.TabIndex = 1
        Me.btnAddBlock.Text = "Add"
        Me.btnAddBlock.UseVisualStyleBackColor = True
        '
        'txtBlock
        '
        Me.txtBlock.Location = New System.Drawing.Point(6, 31)
        Me.txtBlock.Name = "txtBlock"
        Me.txtBlock.Size = New System.Drawing.Size(292, 21)
        Me.txtBlock.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox5)
        Me.TabPage4.Controls.Add(Me.chkDLMng)
        Me.TabPage4.Location = New System.Drawing.Point(4, 40)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(5)
        Me.TabPage4.Size = New System.Drawing.Size(387, 374)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Downloading"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.RadioButton5)
        Me.GroupBox5.Controls.Add(Me.RadioButton4)
        Me.GroupBox5.Controls.Add(Me.CheckBox4)
        Me.GroupBox5.Location = New System.Drawing.Point(0, 272)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(386, 97)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Options"
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Checked = True
        Me.RadioButton5.Location = New System.Drawing.Point(6, 66)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(186, 17)
        Me.RadioButton5.TabIndex = 2
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Prompt me before each download"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(5, 43)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(227, 17)
        Me.RadioButton4.TabIndex = 1
        Me.RadioButton4.Text = "Automatically download in the background"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Checked = True
        Me.CheckBox4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox4.Location = New System.Drawing.Point(6, 20)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(105, 17)
        Me.CheckBox4.TabIndex = 0
        Me.CheckBox4.Text = "Allow downloads"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'chkDLMng
        '
        Me.chkDLMng.Controls.Add(Me.chkUseDLManager)
        Me.chkDLMng.Controls.Add(Me.Button1)
        Me.chkDLMng.Controls.Add(Me.txtDLPath)
        Me.chkDLMng.Controls.Add(Me.ListView1)
        Me.chkDLMng.Controls.Add(Me.Button9)
        Me.chkDLMng.Controls.Add(Me.Button10)
        Me.chkDLMng.Controls.Add(Me.Label2)
        Me.chkDLMng.Controls.Add(Me.Label9)
        Me.chkDLMng.Controls.Add(Me.Button11)
        Me.chkDLMng.Controls.Add(Me.txtExt)
        Me.chkDLMng.Location = New System.Drawing.Point(0, 5)
        Me.chkDLMng.Name = "chkDLMng"
        Me.chkDLMng.Size = New System.Drawing.Size(386, 261)
        Me.chkDLMng.TabIndex = 5
        Me.chkDLMng.TabStop = False
        Me.chkDLMng.Text = "Files"
        '
        'chkUseDLManager
        '
        Me.chkUseDLManager.AutoSize = True
        Me.chkUseDLManager.Checked = True
        Me.chkUseDLManager.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkUseDLManager.Location = New System.Drawing.Point(10, 20)
        Me.chkUseDLManager.Name = "chkUseDLManager"
        Me.chkUseDLManager.Size = New System.Drawing.Size(139, 17)
        Me.chkUseDLManager.TabIndex = 3
        Me.chkUseDLManager.Text = "Use Download Manager"
        Me.chkUseDLManager.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(262, 55)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtDLPath
        '
        Me.txtDLPath.Location = New System.Drawing.Point(85, 55)
        Me.txtDLPath.Name = "txtDLPath"
        Me.txtDLPath.Size = New System.Drawing.Size(171, 21)
        Me.txtDLPath.TabIndex = 8
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(6, 95)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(373, 131)
        Me.ListView1.TabIndex = 7
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Extension"
        Me.ColumnHeader3.Width = 68
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Download Directory"
        Me.ColumnHeader4.Width = 301
        '
        'Button9
        '
        Me.Button9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button9.Location = New System.Drawing.Point(305, 232)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(74, 23)
        Me.Button9.TabIndex = 6
        Me.Button9.Text = "Remove ALL"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button10.Location = New System.Drawing.Point(223, 232)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(74, 23)
        Me.Button10.TabIndex = 5
        Me.Button10.Text = "Remove"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(7, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(363, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Registered Extensions"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(7, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(363, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Extension of file to add ie: .zip, .exe"
        '
        'Button11
        '
        Me.Button11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button11.Location = New System.Drawing.Point(303, 55)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(76, 23)
        Me.Button11.TabIndex = 1
        Me.Button11.Text = "Add"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'txtExt
        '
        Me.txtExt.Location = New System.Drawing.Point(6, 55)
        Me.txtExt.Name = "txtExt"
        Me.txtExt.Size = New System.Drawing.Size(73, 21)
        Me.txtExt.TabIndex = 0
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.GroupBox1)
        Me.TabPage5.Location = New System.Drawing.Point(4, 40)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(387, 374)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Search Providers"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkSearchDefault)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtSearchTitle)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lvSearchProviders)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnAddProvider)
        Me.GroupBox1.Controls.Add(Me.txtSearchURL)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(387, 374)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Providers"
        '
        'chkSearchDefault
        '
        Me.chkSearchDefault.AutoSize = True
        Me.chkSearchDefault.Location = New System.Drawing.Point(57, 74)
        Me.chkSearchDefault.Name = "chkSearchDefault"
        Me.chkSearchDefault.Size = New System.Drawing.Size(89, 17)
        Me.chkSearchDefault.TabIndex = 11
        Me.chkSearchDefault.Text = "Make Default"
        Me.chkSearchDefault.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(2, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 18)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Title:"
        '
        'txtSearchTitle
        '
        Me.HelpProvider1.SetHelpString(Me.txtSearchTitle, "Display Name of search provider")
        Me.txtSearchTitle.Location = New System.Drawing.Point(57, 20)
        Me.txtSearchTitle.Name = "txtSearchTitle"
        Me.HelpProvider1.SetShowHelp(Me.txtSearchTitle, True)
        Me.txtSearchTitle.Size = New System.Drawing.Size(257, 21)
        Me.txtSearchTitle.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(2, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 18)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "URL:"
        '
        'lvSearchProviders
        '
        Me.lvSearchProviders.CheckBoxes = True
        Me.lvSearchProviders.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvSearchProviders.ContextMenuStrip = Me.cmSearch
        Me.lvSearchProviders.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lvSearchProviders.FullRowSelect = True
        Me.lvSearchProviders.GridLines = True
        Me.lvSearchProviders.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.HelpProvider1.SetHelpString(Me.lvSearchProviders, "List of current search providers.")
        Me.lvSearchProviders.HideSelection = False
        Me.lvSearchProviders.Location = New System.Drawing.Point(3, 114)
        Me.lvSearchProviders.MultiSelect = False
        Me.lvSearchProviders.Name = "lvSearchProviders"
        Me.HelpProvider1.SetShowHelp(Me.lvSearchProviders, True)
        Me.lvSearchProviders.Size = New System.Drawing.Size(381, 257)
        Me.lvSearchProviders.TabIndex = 7
        Me.lvSearchProviders.UseCompatibleStateImageBehavior = False
        Me.lvSearchProviders.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Provider"
        Me.ColumnHeader1.Width = 115
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "URL"
        Me.ColumnHeader2.Width = 261
        '
        'cmSearch
        '
        Me.cmSearch.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmSearchRemove})
        Me.cmSearch.Name = "cmSearch"
        Me.cmSearch.Size = New System.Drawing.Size(125, 26)
        '
        'cmSearchRemove
        '
        Me.cmSearchRemove.Name = "cmSearchRemove"
        Me.cmSearchRemove.Size = New System.Drawing.Size(124, 22)
        Me.cmSearchRemove.Text = "Remove"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(3, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Providers"
        '
        'btnAddProvider
        '
        Me.btnAddProvider.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddProvider.Location = New System.Drawing.Point(320, 44)
        Me.btnAddProvider.Name = "btnAddProvider"
        Me.btnAddProvider.Size = New System.Drawing.Size(60, 23)
        Me.btnAddProvider.TabIndex = 1
        Me.btnAddProvider.Text = "Add"
        Me.btnAddProvider.UseVisualStyleBackColor = True
        '
        'txtSearchURL
        '
        Me.HelpProvider1.SetHelpString(Me.txtSearchURL, "URL of search provider.")
        Me.txtSearchURL.Location = New System.Drawing.Point(57, 47)
        Me.txtSearchURL.Name = "txtSearchURL"
        Me.HelpProvider1.SetShowHelp(Me.txtSearchURL, True)
        Me.txtSearchURL.Size = New System.Drawing.Size(257, 21)
        Me.txtSearchURL.TabIndex = 0
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.Label10)
        Me.TabPage6.Location = New System.Drawing.Point(4, 40)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(387, 374)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "RSS"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Location = New System.Drawing.Point(8, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(371, 352)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "This tab is just a place holder." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Only a rough RSS viewer is used" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in this exampl" & _
            "e application. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fill in the blanks, create whatever " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "settings you need!"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnOK)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 418)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(395, 32)
        Me.Panel1.TabIndex = 1
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(302, 2)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 27)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.GroupBox6)
        Me.TabPage7.Location = New System.Drawing.Point(4, 40)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(387, 374)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "Phishing"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.chkPhishing)
        Me.GroupBox6.Controls.Add(Me.btnRemoveAllPhish)
        Me.GroupBox6.Controls.Add(Me.btnRemovePhish)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.lbPhishing)
        Me.GroupBox6.Controls.Add(Me.btnAddPhish)
        Me.GroupBox6.Controls.Add(Me.txtPhishing)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox6.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(381, 368)
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Phishing Manager"
        '
        'btnRemoveAllPhish
        '
        Me.btnRemoveAllPhish.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemoveAllPhish.Location = New System.Drawing.Point(299, 129)
        Me.btnRemoveAllPhish.Name = "btnRemoveAllPhish"
        Me.btnRemoveAllPhish.Size = New System.Drawing.Size(74, 23)
        Me.btnRemoveAllPhish.TabIndex = 6
        Me.btnRemoveAllPhish.Text = "Remove ALL"
        Me.btnRemoveAllPhish.UseVisualStyleBackColor = True
        '
        'btnRemovePhish
        '
        Me.btnRemovePhish.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemovePhish.Location = New System.Drawing.Point(299, 100)
        Me.btnRemovePhish.Name = "btnRemovePhish"
        Me.btnRemovePhish.Size = New System.Drawing.Size(74, 23)
        Me.btnRemovePhish.TabIndex = 5
        Me.btnRemovePhish.Text = "Remove"
        Me.btnRemovePhish.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(5, 78)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(294, 16)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Phishing Sites"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(6, 39)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(363, 13)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Address of phishing website"
        '
        'lbPhishing
        '
        Me.lbPhishing.FormattingEnabled = True
        Me.lbPhishing.Location = New System.Drawing.Point(6, 100)
        Me.lbPhishing.Name = "lbPhishing"
        Me.lbPhishing.Size = New System.Drawing.Size(292, 264)
        Me.lbPhishing.TabIndex = 2
        '
        'btnAddPhish
        '
        Me.btnAddPhish.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddPhish.Location = New System.Drawing.Point(298, 52)
        Me.btnAddPhish.Name = "btnAddPhish"
        Me.btnAddPhish.Size = New System.Drawing.Size(75, 23)
        Me.btnAddPhish.TabIndex = 1
        Me.btnAddPhish.Text = "Add"
        Me.btnAddPhish.UseVisualStyleBackColor = True
        '
        'txtPhishing
        '
        Me.txtPhishing.Location = New System.Drawing.Point(5, 54)
        Me.txtPhishing.Name = "txtPhishing"
        Me.txtPhishing.Size = New System.Drawing.Size(292, 21)
        Me.txtPhishing.TabIndex = 0
        '
        'chkPhishing
        '
        Me.chkPhishing.AutoSize = True
        Me.chkPhishing.Location = New System.Drawing.Point(9, 20)
        Me.chkPhishing.Name = "chkPhishing"
        Me.chkPhishing.Size = New System.Drawing.Size(127, 17)
        Me.chkPhishing.TabIndex = 7
        Me.chkPhishing.Text = "Enable Phishing Filter"
        Me.chkPhishing.UseVisualStyleBackColor = True
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.chkDLMng.ResumeLayout(False)
        Me.chkDLMng.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.cmSearch.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TabPage7.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBlockRemoveAll As System.Windows.Forms.Button
    Friend WithEvents btnRemoveBlock As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbBlocked As System.Windows.Forms.ListBox
    Friend WithEvents btnAddBlock As System.Windows.Forms.Button
    Friend WithEvents txtBlock As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lvSearchProviders As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAddProvider As System.Windows.Forms.Button
    Friend WithEvents txtSearchURL As System.Windows.Forms.TextBox
    Friend WithEvents chkAllowPop As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnPopRemoveAll As System.Windows.Forms.Button
    Friend WithEvents btnPopRemove As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbPop As System.Windows.Forms.ListBox
    Friend WithEvents btnPopAdd As System.Windows.Forms.Button
    Friend WithEvents txtPop As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkPopInfo As System.Windows.Forms.CheckBox
    Friend WithEvents chkPopSound As System.Windows.Forms.CheckBox
    Friend WithEvents cmSearch As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmSearchRemove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSearchTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents chkDLMng As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtDLPath As System.Windows.Forms.TextBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents txtExt As System.Windows.Forms.TextBox
    Friend WithEvents chkInternal As System.Windows.Forms.CheckBox
    Friend WithEvents chkSupress As System.Windows.Forms.CheckBox
    Friend WithEvents chkShowTags As System.Windows.Forms.CheckBox
    Friend WithEvents chkUseDLManager As System.Windows.Forms.CheckBox
    Friend WithEvents chkSearchDefault As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents chkStart As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRemoveAllPhish As System.Windows.Forms.Button
    Friend WithEvents btnRemovePhish As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lbPhishing As System.Windows.Forms.ListBox
    Friend WithEvents btnAddPhish As System.Windows.Forms.Button
    Friend WithEvents txtPhishing As System.Windows.Forms.TextBox
    Friend WithEvents chkPhishing As System.Windows.Forms.CheckBox
End Class
