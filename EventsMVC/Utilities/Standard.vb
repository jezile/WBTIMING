Public Module Standard

    <Runtime.CompilerServices.Extension>
    Public Function IconActionLink(helper As HtmlHelper, icon As String, text As String, actionName As String, controllerName As String, routeValues As Object,
        htmlAttributes As Object) As MvcHtmlString
        Dim builder = New TagBuilder("i")
        builder.MergeAttribute("class", icon)
        Dim link = helper.ActionLink(Convert.ToString("[replaceme] ") & text, actionName, controllerName, routeValues, htmlAttributes).ToHtmlString()
        Return New MvcHtmlString(link.Replace("[replaceme]", builder.ToString()))
    End Function

End Module
