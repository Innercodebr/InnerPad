Imports WeifenLuo.WinFormsUI.Docking

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DocumentForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DocumentForm))
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SourceBox = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SourceBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SourceBox)
        Me.SplitContainer2.Size = New System.Drawing.Size(743, 492)
        Me.SplitContainer2.SplitterDistance = 219
        Me.SplitContainer2.TabIndex = 1
        '
        'SourceBox
        '
        Me.SourceBox.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.SourceBox.AutoIndentCharsPatterns = ""
        Me.SourceBox.AutoScrollMinSize = New System.Drawing.Size(27, 14)
        Me.SourceBox.BackBrush = Nothing
        Me.SourceBox.CharHeight = 14
        Me.SourceBox.CharWidth = 8
        Me.SourceBox.CommentPrefix = Nothing
        Me.SourceBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SourceBox.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.SourceBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SourceBox.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.SourceBox.IsReplaceMode = False
        Me.SourceBox.Language = FastColoredTextBoxNS.Language.HTML
        Me.SourceBox.LeftBracket = Global.Microsoft.VisualBasic.ChrW(60)
        Me.SourceBox.LeftBracket2 = Global.Microsoft.VisualBasic.ChrW(40)
        Me.SourceBox.Location = New System.Drawing.Point(0, 0)
        Me.SourceBox.Name = "SourceBox"
        Me.SourceBox.Paddings = New System.Windows.Forms.Padding(0)
        Me.SourceBox.RightBracket = Global.Microsoft.VisualBasic.ChrW(62)
        Me.SourceBox.RightBracket2 = Global.Microsoft.VisualBasic.ChrW(41)
        Me.SourceBox.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SourceBox.ServiceColors = CType(resources.GetObject("SourceBox.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
        Me.SourceBox.Size = New System.Drawing.Size(743, 219)
        Me.SourceBox.TabIndex = 1
        Me.SourceBox.Zoom = 100
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 492)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(743, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.Checked = True
        Me.ToolStripButton1.CheckOnClick = True
        Me.ToolStripButton1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(101, 22)
        Me.ToolStripButton1.Text = "Show/Hide Code"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton2.Checked = True
        Me.ToolStripButton2.CheckOnClick = True
        Me.ToolStripButton2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(115, 22)
        Me.ToolStripButton2.Text = "Show/Hide Browser"
        '
        'DocumentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 517)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "DocumentForm"
        Me.Text = "New Document"
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.SourceBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents SourceBox As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
End Class
