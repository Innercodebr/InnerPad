Imports ColorCode
Imports Markdig
Imports InnerLibs
Imports System.Text.RegularExpressions
Imports WeifenLuo.WinFormsUI.Docking
Imports FastColoredTextBoxNS
Imports PreMailer.Net
Imports HtmlAgilityPack
Module Publico

    Property IDETheme As VS2015DarkTheme = New VS2015DarkTheme

    Sub Themeloader()
        With IDETheme.ColorPalette
            .CommandBarToolbarDefault.Grip = Color.Orange
            .CommandBarToolbarButtonPressed.Background = Color.Gray
            .CommandBarMenuDefault.Text = Color.Orange
            .MainWindowStatusBarDefault.Text = Color.Orange
            .CommandBarToolbarButtonDefault.Arrow = Color.Orange
            .ToolWindowCaptionActive.Text = Color.Orange

            .CommandBarToolbarButtonPressed.Text = Color.Orange

            .TabSelectedActive.Text = Color.Black
            .TabSelectedActive.Background = Color.Orange
            .TabSelectedActive.Button = Color.Black

        End With
    End Sub

    Property GitHubCss As String


    Property SupportedExtensions As New FileTypeList(
       New FileType(".json"),
       New FileType(".html"),
       New FileType(".xml"),
       New FileType(".css"),
       New FileType(".js"),
       New FileType(".md"),
       New FileType(".bat"),
       New FileType(".txt"),
       New FileType(".textile")
    )


    Function ParseMD(a As String) As String
        Dim pipeline As New MarkdownPipelineBuilder()
        pipeline.UseAdvancedExtensions()
        a = Markdown.ToHtml(a, pipeline.Build)
        Dim doc As String = ""
        Dim tit As String = ""
        doc.Append("<head>")
        doc.Append("<title>")
        Try
            tit = a.GetElementsByTagName("h1").First.Content
            If a = tit Or tit.IsBlank() Then
                tit = "New Document"
            End If
        Catch ex As Exception
            tit = "New Document"
        End Try
        doc.Append(tit)
        doc.Append("</title>")
        doc.Append("<style>" & GitHubCss & Environment.NewLine)
        doc.Append(" </style> ")

        doc.Append("</head>")
        doc.Append("<body style='margin:0 auto;padding:45px;' class=""markdown-body"">" & a & "</body>")


        Colorizer(doc, "language-js", ColorCode.Languages.JavaScript)
        Colorizer(doc, "language-vb", ColorCode.Languages.VbDotNet)
        Colorizer(doc, "language-css", ColorCode.Languages.Css)
        Colorizer(doc, "language-cs", ColorCode.Languages.CSharp)
        Colorizer(doc, "language-html", ColorCode.Languages.Html)
        Colorizer(doc, "language-php", ColorCode.Languages.Php)
        Colorizer(doc, "language-sql", ColorCode.Languages.Sql)

        Return PreMailer.Net.PreMailer.MoveCssInline(doc).Html
    End Function



    Sub Colorizer(ByRef doc As String, lclass As String, lang As ILanguage)
        Try
            Dim document As New HtmlAgilityPack.HtmlDocument
            document.DocumentNode.InnerHtml = doc
            Dim sources = document.DocumentNode.SelectNodes("//code[@class='" + lclass + "']")
            For Each code In sources
                Dim sourcecode = code.InnerHtml
                If sourcecode.IsNotBlank Then
                    Dim colorizedSourceCode = New CodeColorizer().Colorize(sourcecode, lang)
                    code.InnerHtml = colorizedSourceCode.AdjustWhiteSpaces.RemoveNonPrintable.HtmlDecode
                    code.Attributes.Add("style", "font-size:20px")
                End If
            Next
            doc = document.DocumentNode.InnerHtml
        Catch
        End Try
    End Sub




    Function GenerateJSDocument(Document As String) As String
        Dim resposta As String = ""
        If Document.IsNotBlank Then
            Dim regexFunc As New Regex("\@name (.*?) @")
            Dim regexDesc As New Regex("\@description ([\s\S]*?) @")
            Dim regexParametros As New Regex("\@param (.*?) @")
            Dim regexExemplo As New Regex("\@example ([\s\S]*?) @")

            Dim matchingFunction = regexFunc.Matches(Document)
            Dim matchFuncDescription = regexDesc.Matches(Document)
            Dim matchFuncParameters = regexParametros.Matches(Document)
            Dim matchExample = regexExemplo.Matches(Document)

            For index = 0 To matchingFunction.Count - 1
                Dim nome As String = matchingFunction(index).Groups(1).ToString()
                Dim descricao As String = matchFuncDescription(index).Groups(1).ToString().FixText
                Dim parametros As String = matchFuncParameters(index).Groups(1).ToString()
                Dim exemplo As String = matchExample(index).Groups(1).ToString().AdjustWhiteSpaces

                resposta.Append("## " & nome & Environment.NewLine)
                resposta.Append("#### Parameters: " & Environment.NewLine)
                resposta.Append("> " & parametros & Environment.NewLine)
                resposta.Append("#### Description: " & Environment.NewLine)
                resposta.Append("> " & descricao & Environment.NewLine)
                If exemplo.IsNotBlank And exemplo <> "N/A" Then
                    resposta.Append("##### Example:" & Environment.NewLine)
                    resposta.Append("```js" & Environment.NewLine & exemplo & Environment.NewLine)
                    resposta.Append("```" & Environment.NewLine)
                End If
                resposta.Append("-------" & Environment.NewLine)

            Next
        End If

        Return resposta
    End Function

    Function ParseHTML(HTML As String) As String
        Dim a As New ReverseMarkdown.Converter()
        Dim txt = ""
        Try
            txt = HTML.GetElementsByTagName("body").First.Content
        Catch
            txt = HTML
        End Try
        Try
            txt = a.Convert(txt.RemoveAny(GitHubCss))
        Catch

        End Try

        Return txt
    End Function

    Public Sub CompileHtmlMKT(ByRef Box As FastColoredTextBox)
        Dim notification As New NotificationForm
        Select Case Box.Language
            Case Language.HTML
                Dim baseurl = Prompt("Enter the final EMKT URL")
                If baseurl.IsNotBlank And baseurl.IsURL Then
                    notification.Text = "Building HTML..."
                    notification.Show(-1)
                    Dim uri As New Uri(baseurl)
                    Dim result = PreMailer.Net.PreMailer.MoveCssInline(uri, Box.Text, True, removeComments:=True)
                    Dim doc As New HtmlDocument()
                    doc.LoadHtml(result.Html)
                    doc.DocumentNode.SelectSingleNode("//head").Remove()
                    Box.Text = doc.DocumentNode.InnerHtml
                    notification.Close()
                End If
        End Select
    End Sub



End Module
