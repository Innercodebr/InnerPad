Imports WeifenLuo.WinFormsUI.Docking
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WebBrowserForm
    Inherits DockContent

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WebBrowserForm))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.back_bt = New System.Windows.Forms.ToolStripButton()
        Me.foward_bt = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.reloadbt = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.devtools_bt = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.back_bt, Me.foward_bt, Me.ToolStripSeparator11, Me.reloadbt, Me.ToolStripTextBox1, Me.devtools_bt})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(732, 25)
        Me.ToolStrip1.TabIndex = 13
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'back_bt
        '
        Me.back_bt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.back_bt.Image = CType(resources.GetObject("back_bt.Image"), System.Drawing.Image)
        Me.back_bt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.back_bt.Name = "back_bt"
        Me.back_bt.Size = New System.Drawing.Size(23, 22)
        Me.back_bt.Text = "ToolStripButton1"
        '
        'foward_bt
        '
        Me.foward_bt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.foward_bt.Image = CType(resources.GetObject("foward_bt.Image"), System.Drawing.Image)
        Me.foward_bt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.foward_bt.Name = "foward_bt"
        Me.foward_bt.Size = New System.Drawing.Size(23, 22)
        Me.foward_bt.Text = "ToolStripButton2"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 25)
        '
        'reloadbt
        '
        Me.reloadbt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.reloadbt.Image = CType(resources.GetObject("reloadbt.Image"), System.Drawing.Image)
        Me.reloadbt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.reloadbt.Name = "reloadbt"
        Me.reloadbt.Size = New System.Drawing.Size(23, 22)
        Me.reloadbt.Text = "ToolStripButton3"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(600, 25)
        '
        'devtools_bt
        '
        Me.devtools_bt.CheckOnClick = True
        Me.devtools_bt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.devtools_bt.Image = CType(resources.GetObject("devtools_bt.Image"), System.Drawing.Image)
        Me.devtools_bt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.devtools_bt.Name = "devtools_bt"
        Me.devtools_bt.Size = New System.Drawing.Size(23, 22)
        Me.devtools_bt.Text = "Developer Tools"
        '
        'WebBrowserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 423)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "WebBrowserForm"
        Me.Text = "WebBrowser"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents back_bt As ToolStripButton
    Friend WithEvents foward_bt As ToolStripButton
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents reloadbt As ToolStripButton
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents devtools_bt As ToolStripButton
End Class
