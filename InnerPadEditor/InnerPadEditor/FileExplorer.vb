Imports Microsoft.VisualBasic.FileIO

Public Class FileExplorer
    Public Sub LoadView(dir As IO.DirectoryInfo)

        ' Initialize the ListView, ImageList and Form.
        ListView1 = New ListView()
        ImageList1 = New ImageList()
        ListView1.Location = New Point(37, 12)
        ListView1.Size = New Size(161, 242)
        ListView1.SmallImageList = ImageList1
        ListView1.View = View.SmallIcon
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.ListView1)
        Me.Text = dir.Name

        ' Get the c:\ directory.


        Dim item As ListViewItem
        ListView1.BeginUpdate()
        Dim file As System.IO.FileInfo
        For Each file In SupportedExtensions.SearchFiles(dir, SearchOption.SearchTopLevelOnly)

            ' Set a default icon for the file.
            Dim iconForFile As Icon = SystemIcons.WinLogo

            item = New ListViewItem(file.Name, 1)
            item.ToolTipText = file.FullName

            ' Check to see if the image collection contains an image
            ' for this extension, using the extension as a key.
            If Not (ImageList1.Images.ContainsKey(file.Extension)) Then

                ' If not, add the image to the image list.
                iconForFile = System.Drawing.Icon.ExtractAssociatedIcon(file.FullName)
                ImageList1.Images.Add(file.Extension, iconForFile)
            End If
            item.ImageKey = file.Extension
            ListView1.Items.Add(item)

        Next file
        ListView1.EndUpdate()
    End Sub
End Class