Imports System.IO
Imports InnerLibs
Imports WeifenLuo.WinFormsUI.Docking

Public Class FolderExplorer

    Public Property ProjectFolder As DirectoryInfo = Nothing

    Private Sub FolderExplorer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Openfolder()
        CreateExtensionsMenu(filemenu)
        IDETheme.ApplyTo(ToolStrip1)
        IDETheme.ApplyTo(ContextMenuStrip1)
        IDETheme.ApplyTo(ContextMenuStrip2)
    End Sub

    Sub CreateExtensionsMenu(Toolstripmenu As ToolStripMenuItem)
        For Each ext In SupportedExtensions.Extensions
            Dim menu As New ToolStripMenuItem
            menu.Text = ext
            AddHandler menu.Click, AddressOf AddFileClick
        Next
    End Sub

    Sub AddFileClick(sender As Object, e As EventArgs)
        AddFile(FileList.SelectedNode.ToolTipText, sender.text)
    End Sub

    Sub AddFile(filepath As String, extension As String)
        Dim filename = Prompt("New file", "NewFile." & extension)
        If filename.IsNotBlank Then
            If filepath.IsDirectory Then
                filepath = New DirectoryInfo(filepath).FullName & "\" & filename
            Else
                filepath = New FileInfo(filepath).Directory.FullName & "\" & filename
            End If
            If File.Exists(filepath) Then
                If Confirm("Overwrite file " & filename.Quote & "?") = False Then
                    Exit Sub
                End If
            End If
            File.Create(filepath).Dispose()
            LoadFolder(filepath)
        End If
    End Sub

    Sub Openfolder()
        Dim Folder As New FolderBrowserDialog
        If Folder.ShowDialog = DialogResult.OK Then
            ProjectFolder = Folder.SelectedPath.ToDirectory
            LoadFolder()
        Else
            If IsNothing(ProjectFolder) Then
                Me.Close()
            End If
        End If
    End Sub

    Sub LoadFolder(Optional PathFocus As String = "")
        FileList.Nodes.Clear()
        Dim n As New TreeNode
        n.Text = ProjectFolder.Name
        n.ToolTipText = ProjectFolder.FullName
        PopulateTreeView(ProjectFolder, n)
        FileList.Nodes.Add(n)
        If PathFocus.IsNotBlank Then
            For Each node As TreeNode In FileList.GetAllNodes
                If PathFocus = node.ToolTipText Then FileList.SelectedNode = node
            Next
        End If
    End Sub

    Sub OpenFile()
        Dim file = New FileInfo(FileList.SelectedNode.ToolTipText)
        If file.Exists Then
            For Each d In Me.ParentForm.MdiChildren
                If d.GetType = GetType(DocumentForm) Then
                    Dim cd = CType(d, DocumentForm)
                    If Not IsNothing(cd.FileName) AndAlso cd.FileName.FullName = file.FullName Then
                        cd.Show(Me.ParentForm.GetAllControls(Of DockPanel).First, DockState.Document)
                        Exit Sub
                    End If
                End If
            Next
            Dim document As New DocumentForm
            document.OpenFile(file.FullName)
            document.Show(Me.ParentForm.GetAllControls(Of DockPanel).First, DockState.Document)
            document.Text = file.Name
        End If

    End Sub

    Private Sub PopulateTreeView(ByVal dir As DirectoryInfo, ByRef parentNode As TreeNode)
        For Each f In dir.GetDirectories("*", SearchOption.TopDirectoryOnly)
            Dim childNode As New TreeNode
            childNode.Text = f.Name
            childNode.ToolTipText = f.FullName
            PopulateTreeView(f, childNode)
            childNode.ContextMenuStrip = ContextMenuStrip2
            parentNode.Nodes.Add(childNode)
        Next


        For Each f In SupportedExtensions.SearchFiles(dir, SearchOption.TopDirectoryOnly)
            Dim childNode As New TreeNode
            childNode.Text = f.Name
            childNode.ToolTipText = f.FullName
            childNode.ContextMenuStrip = ContextMenuStrip1
            AddHandler Me.FileList.NodeMouseDoubleClick, AddressOf OpenFile
            parentNode.Nodes.Add(childNode)
        Next


    End Sub


    Private Sub CreateZip(FolderPath As DirectoryInfo)
        FolderPath.ToZipFile(FolderPath.FullName & "\" & FolderPath.Name & ".zip")
    End Sub


    Private Sub FileView_AfterLabelEdit(sender As Object, e As NodeLabelEditEventArgs) Handles FileList.AfterLabelEdit
        If e.Label.IsNotBlank Then
            My.Computer.FileSystem.RenameFile(e.Node.ToolTipText, e.Label)
            LoadFolder()
        End If

    End Sub

    Private Sub FileView_KeyDown(sender As Object, e As KeyEventArgs) Handles FileList.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                ToolStripMenuItem1.PerformClick()
            Case Keys.Delete
                ToolStripMenuItem2.PerformClick()
            Case Keys.Enter
                OpenFileToolstrip.PerformClick()
        End Select
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        FileList.LabelEdit = True
        FileList.SelectedNode.BeginEdit()
    End Sub



    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click, ToolStripMenuItem4.Click
        If Confirm("Really want to delete " & FileList.SelectedNode.ToolTipText.Quote & "?") Then
            File.Delete(FileList.SelectedNode.ToolTipText)
            LoadFolder()
        End If
    End Sub

    Private Sub OpenToolStripButton_Click(sender As Object, e As EventArgs) Handles OpenToolStripButton.Click
        Openfolder()
    End Sub

    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles NewToolStripButton.Click
        AddFile(FileList.SelectedNode.ToolTipText, "txt")
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        CreateZip(FileList.SelectedNode.ToolTipText.ToDirectory)
    End Sub

    Private Sub CreateZIPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileToolstrip.Click
        OpenFile()
    End Sub
End Class