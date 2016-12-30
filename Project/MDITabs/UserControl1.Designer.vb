<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.pnlBottom = New System.Windows.Forms.Panel
        Me.WinMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.pnlTabs = New System.Windows.Forms.Panel
        Me.DropButton = New JarvisExplorer.ControlButton
        Me.pnlTop = New System.Windows.Forms.Panel
        Me.pnlControls = New System.Windows.Forms.Panel
        Me.CloseButton = New JarvisExplorer.ControlButton
        Me.TabToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlTop.SuspendLayout()
        Me.pnlControls.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBottom
        '
        Me.pnlBottom.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlBottom.Location = New System.Drawing.Point(2, 33)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(262, 100)
        Me.pnlBottom.TabIndex = 9
        '
        'WinMenu
        '
        Me.WinMenu.Name = "WinMenu"
        Me.WinMenu.Size = New System.Drawing.Size(61, 4)
        '
        'pnlTabs
        '
        Me.pnlTabs.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlTabs.BackColor = System.Drawing.Color.Transparent
        Me.pnlTabs.Location = New System.Drawing.Point(0, 3)
        Me.pnlTabs.Name = "pnlTabs"
        Me.pnlTabs.Size = New System.Drawing.Size(262, 28)
        Me.pnlTabs.TabIndex = 0
        '
        'DropButton
        '
        Me.DropButton.BackColor = System.Drawing.Color.Transparent
        Me.DropButton.Location = New System.Drawing.Point(4, 8)
        Me.DropButton.Name = "DropButton"
        Me.DropButton.Size = New System.Drawing.Size(81, 15)
        Me.DropButton.Style = JarvisExplorer.ControlButton.ButtonStyle.Drop
        Me.DropButton.TabIndex = 0
        '
        'pnlTop
        '
        Me.pnlTop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlTop.BackColor = System.Drawing.Color.Transparent
        Me.pnlTop.Controls.Add(Me.pnlControls)
        Me.pnlTop.Controls.Add(Me.pnlTabs)
        Me.pnlTop.Location = New System.Drawing.Point(2, 2)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(262, 31)
        Me.pnlTop.TabIndex = 8
        '
        'pnlControls
        '
        Me.pnlControls.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlControls.Controls.Add(Me.DropButton)
        Me.pnlControls.Controls.Add(Me.CloseButton)
        Me.pnlControls.Location = New System.Drawing.Point(237, 0)
        Me.pnlControls.Name = "pnlControls"
        Me.pnlControls.Size = New System.Drawing.Size(89, 30)
        Me.pnlControls.TabIndex = 1
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.BackColor = System.Drawing.Color.Transparent
        Me.CloseButton.Location = New System.Drawing.Point(68, 8)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(81, 15)
        Me.CloseButton.Style = JarvisExplorer.ControlButton.ButtonStyle.Close
        Me.CloseButton.TabIndex = 0
        Me.CloseButton.Visible = False
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.pnlTop)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(267, 136)
        Me.pnlTop.ResumeLayout(False)
        Me.pnlControls.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents WinMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents pnlTabs As System.Windows.Forms.Panel
    Friend WithEvents DropButton As JarvisExplorer.ControlButton
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents pnlControls As System.Windows.Forms.Panel
    Friend WithEvents CloseButton As JarvisExplorer.ControlButton
    Friend WithEvents TabToolTip As System.Windows.Forms.ToolTip

End Class
