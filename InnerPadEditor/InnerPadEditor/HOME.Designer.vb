<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HOME
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HOME))
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.DockPanel1 = New WeifenLuo.WinFormsUI.Docking.DockPanel()
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.s_close_bt = New System.Windows.Forms.ToolStripButton()
        Me.s_max_bt = New System.Windows.Forms.ToolStripButton()
        Me.s_min_bt = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.new_bt = New System.Windows.Forms.ToolStripMenuItem()
        Me.open_bt = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.save_bt = New System.Windows.Forms.ToolStripMenuItem()
        Me.saveas_bt = New System.Windows.Forms.ToolStripMenuItem()
        Me.exportpdf_bt = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.exit_bt = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton4 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.undo_bt = New System.Windows.Forms.ToolStripMenuItem()
        Me.redo_bt = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator17 = New System.Windows.Forms.ToolStripSeparator()
        Me.cut_bt = New System.Windows.Forms.ToolStripMenuItem()
        Me.copy_bt = New System.Windows.Forms.ToolStripMenuItem()
        Me.paste_bt = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator18 = New System.Windows.Forms.ToolStripSeparator()
        Me.selectall_bt = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton3 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.emkt_bt = New System.Windows.Forms.ToolStripMenuItem()
        Me.compile_bt = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.sendtest_bt = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
        Me.options_bt = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.newbrowser_bt = New System.Windows.Forms.ToolStripMenuItem()
        Me.folderexplorer_bt = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.closeall_bt = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DockPanel1
        '
        Me.DockPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DockPanel1.DockBackColor = System.Drawing.SystemColors.Control
        Me.DockPanel1.Location = New System.Drawing.Point(0, 32)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Size = New System.Drawing.Size(632, 421)
        Me.DockPanel1.TabIndex = 9
        '
        'BottomToolStripPanel
        '
        Me.BottomToolStripPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, 428)
        Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
        Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.BottomToolStripPanel.Size = New System.Drawing.Size(632, 0)
        '
        'TopToolStripPanel
        '
        Me.TopToolStripPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopToolStripPanel.Name = "TopToolStripPanel"
        Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.TopToolStripPanel.Size = New System.Drawing.Size(632, 49)
        '
        'RightToolStripPanel
        '
        Me.RightToolStripPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightToolStripPanel.Location = New System.Drawing.Point(632, 49)
        Me.RightToolStripPanel.Name = "RightToolStripPanel"
        Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 379)
        '
        'LeftToolStripPanel
        '
        Me.LeftToolStripPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftToolStripPanel.Location = New System.Drawing.Point(0, 49)
        Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
        Me.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.LeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.LeftToolStripPanel.Size = New System.Drawing.Size(0, 379)
        '
        'ContentPanel
        '
        Me.ContentPanel.Size = New System.Drawing.Size(632, 379)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.s_close_bt, Me.s_max_bt, Me.s_min_bt, Me.ToolStripDropDownButton1, Me.ToolStripDropDownButton4, Me.ToolStripDropDownButton3, Me.ToolStripDropDownButton2})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(632, 32)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        's_close_bt
        '
        Me.s_close_bt.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.s_close_bt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.s_close_bt.Image = CType(resources.GetObject("s_close_bt.Image"), System.Drawing.Image)
        Me.s_close_bt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.s_close_bt.Name = "s_close_bt"
        Me.s_close_bt.Size = New System.Drawing.Size(23, 25)
        '
        's_max_bt
        '
        Me.s_max_bt.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.s_max_bt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.s_max_bt.Image = CType(resources.GetObject("s_max_bt.Image"), System.Drawing.Image)
        Me.s_max_bt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.s_max_bt.Name = "s_max_bt"
        Me.s_max_bt.Size = New System.Drawing.Size(23, 25)
        '
        's_min_bt
        '
        Me.s_min_bt.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.s_min_bt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.s_min_bt.Image = CType(resources.GetObject("s_min_bt.Image"), System.Drawing.Image)
        Me.s_min_bt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.s_min_bt.Name = "s_min_bt"
        Me.s_min_bt.Size = New System.Drawing.Size(23, 25)
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.new_bt, Me.open_bt, Me.ToolStripSeparator1, Me.save_bt, Me.saveas_bt, Me.exportpdf_bt, Me.ToolStripSeparator8, Me.exit_bt})
        Me.ToolStripDropDownButton1.ForeColor = System.Drawing.Color.Orange
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.ShowDropDownArrow = False
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(41, 25)
        Me.ToolStripDropDownButton1.Text = "&File"
        '
        'new_bt
        '
        Me.new_bt.Image = CType(resources.GetObject("new_bt.Image"), System.Drawing.Image)
        Me.new_bt.ImageTransparentColor = System.Drawing.Color.Black
        Me.new_bt.Name = "new_bt"
        Me.new_bt.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.new_bt.Size = New System.Drawing.Size(243, 26)
        Me.new_bt.Text = "&New"
        '
        'open_bt
        '
        Me.open_bt.Image = CType(resources.GetObject("open_bt.Image"), System.Drawing.Image)
        Me.open_bt.ImageTransparentColor = System.Drawing.Color.Black
        Me.open_bt.Name = "open_bt"
        Me.open_bt.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.open_bt.Size = New System.Drawing.Size(243, 26)
        Me.open_bt.Text = "&Open"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(240, 6)
        '
        'save_bt
        '
        Me.save_bt.Image = CType(resources.GetObject("save_bt.Image"), System.Drawing.Image)
        Me.save_bt.ImageTransparentColor = System.Drawing.Color.Black
        Me.save_bt.Name = "save_bt"
        Me.save_bt.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.save_bt.Size = New System.Drawing.Size(243, 26)
        Me.save_bt.Text = "&Save"
        '
        'saveas_bt
        '
        Me.saveas_bt.Name = "saveas_bt"
        Me.saveas_bt.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.saveas_bt.Size = New System.Drawing.Size(243, 26)
        Me.saveas_bt.Text = "Save &As"
        '
        'exportpdf_bt
        '
        Me.exportpdf_bt.Name = "exportpdf_bt"
        Me.exportpdf_bt.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.exportpdf_bt.Size = New System.Drawing.Size(243, 26)
        Me.exportpdf_bt.Text = "Export PDF"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(240, 6)
        '
        'exit_bt
        '
        Me.exit_bt.Name = "exit_bt"
        Me.exit_bt.Size = New System.Drawing.Size(243, 26)
        Me.exit_bt.Text = "E&xit"
        '
        'ToolStripDropDownButton4
        '
        Me.ToolStripDropDownButton4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.undo_bt, Me.redo_bt, Me.ToolStripSeparator17, Me.cut_bt, Me.copy_bt, Me.paste_bt, Me.ToolStripSeparator18, Me.selectall_bt})
        Me.ToolStripDropDownButton4.ForeColor = System.Drawing.Color.Orange
        Me.ToolStripDropDownButton4.Name = "ToolStripDropDownButton4"
        Me.ToolStripDropDownButton4.ShowDropDownArrow = False
        Me.ToolStripDropDownButton4.Size = New System.Drawing.Size(46, 25)
        Me.ToolStripDropDownButton4.Text = "&Edit"
        '
        'undo_bt
        '
        Me.undo_bt.Image = CType(resources.GetObject("undo_bt.Image"), System.Drawing.Image)
        Me.undo_bt.ImageTransparentColor = System.Drawing.Color.Black
        Me.undo_bt.Name = "undo_bt"
        Me.undo_bt.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.undo_bt.Size = New System.Drawing.Size(211, 26)
        Me.undo_bt.Text = "&Undo"
        '
        'redo_bt
        '
        Me.redo_bt.Image = CType(resources.GetObject("redo_bt.Image"), System.Drawing.Image)
        Me.redo_bt.ImageTransparentColor = System.Drawing.Color.Black
        Me.redo_bt.Name = "redo_bt"
        Me.redo_bt.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.redo_bt.Size = New System.Drawing.Size(211, 26)
        Me.redo_bt.Text = "&Redo"
        '
        'ToolStripSeparator17
        '
        Me.ToolStripSeparator17.Name = "ToolStripSeparator17"
        Me.ToolStripSeparator17.Size = New System.Drawing.Size(208, 6)
        '
        'cut_bt
        '
        Me.cut_bt.Image = CType(resources.GetObject("cut_bt.Image"), System.Drawing.Image)
        Me.cut_bt.ImageTransparentColor = System.Drawing.Color.Black
        Me.cut_bt.Name = "cut_bt"
        Me.cut_bt.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.cut_bt.Size = New System.Drawing.Size(211, 26)
        Me.cut_bt.Text = "Cu&t"
        '
        'copy_bt
        '
        Me.copy_bt.Image = CType(resources.GetObject("copy_bt.Image"), System.Drawing.Image)
        Me.copy_bt.ImageTransparentColor = System.Drawing.Color.Black
        Me.copy_bt.Name = "copy_bt"
        Me.copy_bt.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.copy_bt.Size = New System.Drawing.Size(211, 26)
        Me.copy_bt.Text = "&Copy"
        '
        'paste_bt
        '
        Me.paste_bt.Image = CType(resources.GetObject("paste_bt.Image"), System.Drawing.Image)
        Me.paste_bt.ImageTransparentColor = System.Drawing.Color.Black
        Me.paste_bt.Name = "paste_bt"
        Me.paste_bt.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.paste_bt.Size = New System.Drawing.Size(211, 26)
        Me.paste_bt.Text = "&Paste"
        '
        'ToolStripSeparator18
        '
        Me.ToolStripSeparator18.Name = "ToolStripSeparator18"
        Me.ToolStripSeparator18.Size = New System.Drawing.Size(208, 6)
        '
        'selectall_bt
        '
        Me.selectall_bt.Name = "selectall_bt"
        Me.selectall_bt.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.selectall_bt.Size = New System.Drawing.Size(211, 26)
        Me.selectall_bt.Text = "Select &All"
        '
        'ToolStripDropDownButton3
        '
        Me.ToolStripDropDownButton3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.emkt_bt, Me.ToolStripSeparator16, Me.options_bt})
        Me.ToolStripDropDownButton3.ForeColor = System.Drawing.Color.Orange
        Me.ToolStripDropDownButton3.Name = "ToolStripDropDownButton3"
        Me.ToolStripDropDownButton3.ShowDropDownArrow = False
        Me.ToolStripDropDownButton3.Size = New System.Drawing.Size(54, 25)
        Me.ToolStripDropDownButton3.Text = "&Tools"
        '
        'emkt_bt
        '
        Me.emkt_bt.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.compile_bt, Me.ToolStripSeparator15, Me.sendtest_bt})
        Me.emkt_bt.Name = "emkt_bt"
        Me.emkt_bt.Size = New System.Drawing.Size(212, 26)
        Me.emkt_bt.Text = "&Email Marketing"
        '
        'compile_bt
        '
        Me.compile_bt.Name = "compile_bt"
        Me.compile_bt.Size = New System.Drawing.Size(199, 26)
        Me.compile_bt.Text = "Compile HTML"
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(196, 6)
        '
        'sendtest_bt
        '
        Me.sendtest_bt.Name = "sendtest_bt"
        Me.sendtest_bt.Size = New System.Drawing.Size(199, 26)
        Me.sendtest_bt.Text = "Send Test"
        '
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        Me.ToolStripSeparator16.Size = New System.Drawing.Size(209, 6)
        '
        'options_bt
        '
        Me.options_bt.Name = "options_bt"
        Me.options_bt.Size = New System.Drawing.Size(212, 26)
        Me.options_bt.Text = "&Options"
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newbrowser_bt, Me.folderexplorer_bt, Me.ToolStripSeparator13, Me.closeall_bt, Me.ToolStripSeparator14})
        Me.ToolStripDropDownButton2.ForeColor = System.Drawing.Color.Orange
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.ShowDropDownArrow = False
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(87, 25)
        Me.ToolStripDropDownButton2.Text = "&Windows"
        '
        'newbrowser_bt
        '
        Me.newbrowser_bt.Name = "newbrowser_bt"
        Me.newbrowser_bt.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.newbrowser_bt.Size = New System.Drawing.Size(311, 26)
        Me.newbrowser_bt.Text = "New &Browser Window"
        '
        'folderexplorer_bt
        '
        Me.folderexplorer_bt.CheckOnClick = True
        Me.folderexplorer_bt.Name = "folderexplorer_bt"
        Me.folderexplorer_bt.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.folderexplorer_bt.Size = New System.Drawing.Size(311, 26)
        Me.folderexplorer_bt.Text = "&Folder Explorer"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(308, 6)
        '
        'closeall_bt
        '
        Me.closeall_bt.Name = "closeall_bt"
        Me.closeall_bt.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.closeall_bt.Size = New System.Drawing.Size(311, 26)
        Me.closeall_bt.Text = "C&lose All"
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(308, 6)
        '
        'HOME
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.DockPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "HOME"
        Me.Text = "InnerPad - A Quick Text Editor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents DockPanel1 As WeifenLuo.WinFormsUI.Docking.DockPanel
    Friend WithEvents BottomToolStripPanel As ToolStripPanel
    Friend WithEvents TopToolStripPanel As ToolStripPanel
    Friend WithEvents RightToolStripPanel As ToolStripPanel
    Friend WithEvents LeftToolStripPanel As ToolStripPanel
    Friend WithEvents ContentPanel As ToolStripContentPanel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents s_close_bt As ToolStripButton
    Friend WithEvents s_max_bt As ToolStripButton
    Friend WithEvents s_min_bt As ToolStripButton
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents new_bt As ToolStripMenuItem
    Friend WithEvents open_bt As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents save_bt As ToolStripMenuItem
    Friend WithEvents saveas_bt As ToolStripMenuItem
    Friend WithEvents exportpdf_bt As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents exit_bt As ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton2 As ToolStripDropDownButton
    Friend WithEvents newbrowser_bt As ToolStripMenuItem
    Friend WithEvents folderexplorer_bt As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator13 As ToolStripSeparator
    Friend WithEvents closeall_bt As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator14 As ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton3 As ToolStripDropDownButton
    Friend WithEvents emkt_bt As ToolStripMenuItem
    Friend WithEvents compile_bt As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator15 As ToolStripSeparator
    Friend WithEvents sendtest_bt As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator16 As ToolStripSeparator
    Friend WithEvents options_bt As ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton4 As ToolStripDropDownButton
    Friend WithEvents undo_bt As ToolStripMenuItem
    Friend WithEvents redo_bt As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator17 As ToolStripSeparator
    Friend WithEvents cut_bt As ToolStripMenuItem
    Friend WithEvents copy_bt As ToolStripMenuItem
    Friend WithEvents paste_bt As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator18 As ToolStripSeparator
    Friend WithEvents selectall_bt As ToolStripMenuItem
End Class
