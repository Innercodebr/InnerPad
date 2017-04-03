Imports Microsoft.VisualBasic.FileIO
Imports InnerLibs.SQLExplorer
Imports InnerLibs
Imports System.IO

Public Class FileExplorer


    Private Sub commandbox_KeyUp(sender As Object, e As KeyEventArgs) Handles commandbox.KeyUp
        Select Case e.KeyCode
            Case Keys.Enter
                ListView1.SmallImageList = ImageList1
                ListView1.LargeImageList = ImageList1
                ListView1.Clear()
                ListView1.BeginUpdate()
                For Each result As FileSystemInfo In New SQLExplorer.FileSystemSQL(commandbox.Text)
                    Dim item As ListViewItem
                    item = New ListViewItem(result.Name, 1)
                    item.ToolTipText = result.FullName
                    Dim ext = result.Extension
                    If ext.IsBlank() Then ext = "DIR"
                    If Not (ImageList1.Images.ContainsKey(ext)) Then
                        Try
                            ImageList1.Images.Add(ext, Icon.ExtractAssociatedIcon(result.FullName))
                        Catch ex As Exception
                            ImageList1.Images.Add(ext, OpenFolderIcon)
                        End Try
                    End If
                    item.ImageKey = ext
                    ListView1.Items.Add(item)
                Next
                ListView1.EndUpdate()
        End Select
    End Sub
End Class