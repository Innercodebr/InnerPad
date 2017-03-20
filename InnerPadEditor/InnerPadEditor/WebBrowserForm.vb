Imports System.Text
Imports CefSharp
Imports CefSharp.WinForms
Imports CefSharp.WinForms.Internals
Imports ColorCode.Formatting
Imports FontAwesomeExtensions
Imports InnerLibs

Public Class WebBrowserForm

    Dim browser As New ChromiumWebBrowser("http://google.com")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Controls.Add(browser)
        browser.Dock = DockStyle.Fill
        AddHandler browser.TitleChanged, AddressOf OnBrowserTitleChanged
        AddHandler browser.LoadingStateChanged, AddressOf ChangeIcon
        ToolStrip1.SendToBack()
        LoadIcons()
        IDETheme.ApplyTo(ToolStrip1)
        Me.Icon = New FontAwesome.Properties(FontAwesome.Type.Globe) With {.ForeColor = Color.Orange}.AsIcon

        ToolStripTextBox1.Anchor = AnchorStyles.Right
        ToolStripTextBox1.Select()
    End Sub

    Private Sub ChangeIcon(sender As Object, e As LoadingStateChangedEventArgs)
        If e.IsLoading Then
            reloadbt.Image = StopIcon
        Else
            reloadbt.Image = ReloadIcon
        End If
    End Sub

    Private Sub OnBrowserTitleChanged(sender As Object, args As TitleChangedEventArgs)
        Me.InvokeOnUiThreadIfRequired(Function() InlineAssignHelper(Me.Text, args.Title))
    End Sub

    Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, ByVal value As T) As T
        target = value
        Return value
    End Function

    Private Sub ToolStripTextBox1_Click(sender As Object, e As KeyEventArgs) Handles ToolStripTextBox1.KeyUp
        Select Case e.KeyCode
            Case Keys.Enter
                Dim u = ToolStripTextBox1.Text
                Try
                    browser.Load(u)
                Catch ex As Exception
                    u = "https://www.google.com.br/search?q=" & u
                    browser.Load(u)
                End Try
        End Select
    End Sub

    Sub LoadIcons()
        back_bt.Image = BackArrowIcon
        foward_bt.Image = FowardArrowIcon
        devtools_bt.Image = DevToolsIcon
        reloadbt.Image = ReloadIcon
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles devtools_bt.CheckedChanged
        If devtools_bt.Checked Then
            browser.ShowDevTools
        Else
            browser.CloseDevTools
        End If

    End Sub

    Private Sub foward_bt_Click(sender As Object, e As EventArgs) Handles foward_bt.Click
        If browser.CanGoForward Then browser.Forward
    End Sub

    Private Sub back_bt_Click(sender As Object, e As EventArgs) Handles back_bt.Click
        If browser.CanGoBack Then browser.Back
    End Sub

    Private Sub reloadbt_Click(sender As Object, e As EventArgs) Handles reloadbt.Click
        If browser.IsLoading Then
            browser.Stop
        Else
            browser.Reload
        End If
    End Sub
End Class