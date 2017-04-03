Imports WeifenLuo.WinFormsUI.Docking

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Console
    Inherits DockContent

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ConsoleBox = New System.Windows.Forms.RichTextBox()
        Me.CommandBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ConsoleBox
        '
        Me.ConsoleBox.BackColor = System.Drawing.Color.Black
        Me.ConsoleBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ConsoleBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ConsoleBox.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConsoleBox.ForeColor = System.Drawing.Color.White
        Me.ConsoleBox.Location = New System.Drawing.Point(0, 0)
        Me.ConsoleBox.Name = "ConsoleBox"
        Me.ConsoleBox.ReadOnly = True
        Me.ConsoleBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.ConsoleBox.ShowSelectionMargin = True
        Me.ConsoleBox.Size = New System.Drawing.Size(964, 367)
        Me.ConsoleBox.TabIndex = 0
        Me.ConsoleBox.Text = ""
        '
        'CommandBox
        '
        Me.CommandBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CommandBox.BackColor = System.Drawing.Color.Black
        Me.CommandBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CommandBox.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommandBox.ForeColor = System.Drawing.Color.White
        Me.CommandBox.Location = New System.Drawing.Point(50, 344)
        Me.CommandBox.Name = "CommandBox"
        Me.CommandBox.Size = New System.Drawing.Size(914, 23)
        Me.CommandBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(4, 344)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "IC>"
        '
        'Console
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 367)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CommandBox)
        Me.Controls.Add(Me.ConsoleBox)
        Me.DockAreas = CType(((WeifenLuo.WinFormsUI.Docking.DockAreas.Float Or WeifenLuo.WinFormsUI.Docking.DockAreas.DockTop) _
            Or WeifenLuo.WinFormsUI.Docking.DockAreas.DockBottom), WeifenLuo.WinFormsUI.Docking.DockAreas)
        Me.HideOnClose = True
        Me.Name = "Console"
        Me.Text = "Console"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ConsoleBox As RichTextBox
    Friend WithEvents CommandBox As TextBox
    Friend WithEvents Label1 As Label
End Class
