Imports InnerLibs
Imports FastColoredTextBoxNS
Imports System.IO
Imports CefSharp.WinForms
Imports CefSharp
Imports System.Text
Imports System.Reflection
Imports System.Text.RegularExpressions
Imports Markdig
Imports ColorCode

Public Class DocumentForm

    Property FileName As FileInfo

    Dim browser As New ChromiumWebBrowser("about:innerpad")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "New File"

        SplitContainer2.Panel2.Controls.Add(browser)

        browser.Dock = DockStyle.Fill

        IDETheme.ApplyTo(ToolStrip1)
        Me.Icon = New FontAwesome.Properties(FontAwesome.Type.FileCodeO) With {.ForeColor = Color.Orange}.AsIcon

    End Sub





    Sub SaveFile()
        If FileName.Extension.IsIn(SupportedExtensions.Extensions) Then
            SourceBox.SaveToFile(FileName.FullName, Encoding.UTF8)
            Me.Text = FileName.Name
        End If
    End Sub

    Sub LoadFile()
        If FileName.Extension.IsIn(SupportedExtensions.Extensions) Then
            SourceBox.OpenFile(FileName.FullName, Encoding.UTF8)
            Me.Text = FileName.Name
        End If
    End Sub

    Public Sub OpenFile(FilePath As String)
        Me.FileName = New FileInfo(FilePath)
        LoadFile()
    End Sub



    Private Sub TextBox1_TextChangedDelayed(sender As Object, e As TextChangedEventArgs) Handles SourceBox.TextChangedDelayed
        Try
            LoadSintax(FileName.Extension)
        Catch ex As Exception
            LoadSintax(".html")
        End Try
    End Sub

    Sub LoadSintax(ext As String)
        Dim content As String = SourceBox.Text
        Select Case ext.ToLower()
            Case ".htm", ".html"
                SourceBox.Language = Language.HTML
            Case ".xml"
                SourceBox.Language = Language.XML
            Case ".js"
                SourceBox.Language = Language.JS
                content = ParseMD(GenerateJSDocument(content))
            Case ".sql"
                SourceBox.Language = Language.SQL
            Case ".md"
                SourceBox.Language = Language.Custom
                content = ParseMD(content)
            Case (".json")
                SourceBox.Language = Language.CSharp

            Case Else
                SourceBox.Language = Language.Custom
        End Select
        browser.LoadHtml(content, "http://innerpad")

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.CheckedChanged
        SplitContainer2.Panel1Collapsed = Not ToolStripButton1.Checked
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.CheckedChanged
        SplitContainer2.Panel2Collapsed = Not ToolStripButton2.Checked
    End Sub
End Class

