
Imports InnerLibs

Public Class Console
    Private Sub Console_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CommandBox.Select()
    End Sub

    Private Sub CommandBox_KeyDown(sender As Object, e As KeyEventArgs) Handles CommandBox.KeyUp
        If e.KeyCode = Keys.Enter Then
            ProccessCommand(CommandBox.Text)
            CommandBox.Clear()
            CommandBox.Select()
        End If
    End Sub

    Sub Write(Text As String)
        ConsoleBox.AppendText(Text)
    End Sub

    Sub WriteLine(Text As String)
        ConsoleBox.AppendText(Text & Environment.NewLine)
    End Sub

    Private Sub CommandBox_TextChanged(sender As Object, e As EventArgs) Handles CommandBox.TextChanged

    End Sub
    Sub ProccessCommand(cmd As String)
        Select Case True
            Case cmd.ToLower = "install-package"
            Case cmd.ToLower = "clear"
                ConsoleBox.Clear()
            Case cmd.ToLower.StartsWith("get ")
                Dim parts As String() = cmd.Split(" ")
                Try
                    Dim D As New DocumentForm()
                    D.GetAllControls(Of FastColoredTextBoxNS.FastColoredTextBox).First.Text = AJAX.GET(Of String)(parts(1))
                    D.Show(Me.ParentForm.GetAllControls(Of WeifenLuo.WinFormsUI.Docking.DockPanel).First, WeifenLuo.WinFormsUI.Docking.DockState.Document)
                Catch ex As Exception
                    Me.WriteLine("Invalid URL")
                End Try
            Case Else
                Me.WriteLine("Invalid Command")
        End Select
    End Sub

End Class



