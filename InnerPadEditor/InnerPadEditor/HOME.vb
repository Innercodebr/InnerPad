Imports System.Reflection
Imports System.Windows.Forms
Imports WeifenLuo.WinFormsUI.Docking
Imports InnerLibs
Imports CefSharp.WinForms
Imports CefSharp
Imports System.IO

Public Class HOME




    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles new_bt.Click
        Dim ChildForm As New DocumentForm
        ChildForm.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles open_bt.Click
        Dim OpenFileDialog As New OpenFileDialog
        SupportedExtensions.ApplyDialogFilter(OpenFileDialog)
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            Dim ChildForm As New DocumentForm
            ChildForm.Show(DockPanel1, DockState.Document)
            ChildForm.OpenFile(FileName)
            ChildForm.Show(Me.DockPanel1, DockState.Document)
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles save_bt.Click
        Dim SaveFileDialog As New SaveFileDialog
        SupportedExtensions.ApplyDialogFilter(SaveFileDialog)
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName

        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles exit_bt.Click, s_close_bt.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cut_bt.Click
        If Not IsNothing(Me.ActiveMdiChild) AndAlso Me.ActiveMdiChild.GetType() = GetType(DocumentForm) Then
            Me.ActiveMdiChild.GetAllControls(Of FastColoredTextBoxNS.FastColoredTextBox).First.Cut()
        End If
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles copy_bt.Click
        If Not IsNothing(Me.ActiveMdiChild) AndAlso Me.ActiveMdiChild.GetType() = GetType(DocumentForm) Then
            Me.ActiveMdiChild.GetAllControls(Of FastColoredTextBoxNS.FastColoredTextBox).First.Copy()
        End If
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles paste_bt.Click
        If Not IsNothing(Me.ActiveMdiChild) AndAlso Me.ActiveMdiChild.GetType() = GetType(DocumentForm) Then
            Me.ActiveMdiChild.GetAllControls(Of FastColoredTextBoxNS.FastColoredTextBox).First.Paste()
        End If
    End Sub



    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles closeall_bt.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub



    Private Sub FolderExplorerToolStripMenuItem_CheckedChanged(sender As Object, e As EventArgs) Handles folderexplorer_bt.Click
        If folderexplorer_bt.Checked Then
            FolderExplorer.Show(DockPanel1, DockState.DockRight)
        Else
            FolderExplorer.Hide()
        End If
    End Sub

    Private Sub HOME_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Themeloader()

        DockPanel1.Theme = IDETheme


        IDETheme.ApplyTo(MenuStrip1)



        Me.Text = "InnerPad - Smart coding for smart developers"

        LoadIcons()

        GitHubCss = Assembly.GetExecutingAssembly.GetResourceFileText("InnerPad.GitHub.css")
    End Sub

    Sub LoadIcons()
        Me.Icon = New FontAwesome.Properties(FontAwesome.Type.PencilSquare) With {.ForeColor = Color.Orange}.AsIcon
        s_min_bt.Image = MinimizeIcon
        s_max_bt.Image = RestoreIcon
        s_close_bt.Image = CloseIcon
        copy_bt.Image = CopyIcon
        paste_bt.Image = PasteIcon
        cut_bt.Image = CutIcon
        undo_bt.Image = UndoIcon
        redo_bt.Image = RedoIcon
        options_bt.Image = OptionsIcon
        new_bt.Image = NewFileIcon
        open_bt.Image = OpenFolderIcon
        save_bt.Image = SaveIcon
        emkt_bt.Image = EmailIcon
        sendtest_bt.Image = SendIcon
        compile_bt.Image = Html5Icon

    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles undo_bt.Click
        If Not IsNothing(Me.ActiveMdiChild) AndAlso Me.ActiveMdiChild.GetType() = GetType(DocumentForm) Then
            Me.ActiveMdiChild.GetAllControls(Of FastColoredTextBoxNS.FastColoredTextBox).First.Undo()
        End If
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles redo_bt.Click
        If Not IsNothing(Me.ActiveMdiChild) AndAlso Me.ActiveMdiChild.GetType() = GetType(DocumentForm) Then
            Me.ActiveMdiChild.GetAllControls(Of FastColoredTextBoxNS.FastColoredTextBox).First.Redo()
        End If
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles selectall_bt.Click
        If Not IsNothing(Me.ActiveMdiChild) AndAlso Me.ActiveMdiChild.GetType() = GetType(DocumentForm) Then
            Me.ActiveMdiChild.GetAllControls(Of FastColoredTextBoxNS.FastColoredTextBox).First.SelectAll()
        End If
    End Sub

    Private Sub CompileHTMLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles compile_bt.Click
        If Not IsNothing(Me.ActiveMdiChild) AndAlso Me.ActiveMdiChild.GetType() = GetType(DocumentForm) Then
            CompileHtmlMKT(Me.ActiveMdiChild.GetAllControls(Of FastColoredTextBoxNS.FastColoredTextBox).First)
        End If
    End Sub

    Private Sub BrowserWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles newbrowser_bt.Click
        Dim ChildForm As New WebBrowserForm
        ChildForm.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub ExportPDFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles exportpdf_bt.Click
        Dim noti As New NotificationForm()
        If IsNothing(Me.ActiveMdiChild) Then Exit Sub
        For Each b In Me.ActiveMdiChild.GetAllControls(Of ChromiumWebBrowser)
            Dim Dialog As New SaveFileDialog
            Dialog.Filter = New FileType(".pdf").ToFilterString
            Dialog.Title = "Export PDF"
            Dialog.FileName = Me.ActiveMdiChild.Text & ".pdf"
            If Dialog.ShowDialog = DialogResult.OK Then
                Dim f As FileInfo = New FileInfo(Dialog.FileName)
                noti.Text = "Exporting PDF..."
                noti.Show(-1)
                Try
                    While Not b.PrintToPdfAsync(f.FullName).IsCompleted
                        ''espera exportar
                    End While
                Catch ex As Exception
                    noti.Text = ex.Message
                    noti.Show(20)
                    Exit Sub
                End Try

                noti.Text = f.Name.Quote & " succefully exported!"
                noti.Show(10)
            End If
            Exit Sub
        Next
        noti.Text = "Could not find content to export. Select a document or WebBrowser Page and try again."
        noti.Show(10)
    End Sub



    Private Sub s_max_bt_Click(sender As Object, e As EventArgs) Handles s_max_bt.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
            s_max_bt.Image = MaximizeIcon
        Else
            Me.WindowState = FormWindowState.Maximized
            s_max_bt.Image = RestoreIcon
        End If
    End Sub

    Private Sub s_min_bt_Click(sender As Object, e As EventArgs) Handles s_min_bt.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

#Region "FormMove"


    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    <System.Runtime.InteropServices.DllImportAttribute("user32.dll")>
    Public Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function
    <System.Runtime.InteropServices.DllImportAttribute("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function

    Private Sub Form1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles MenuStrip1.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            s_max_bt.Image = MaximizeIcon
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub AJAXConsoleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AJAXConsoleToolStripMenuItem.Click
        Console.Show(DockPanel1, DockState.DockBottom)
    End Sub





#End Region


End Class
