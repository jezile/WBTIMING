<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - Pomiar czasu</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
    <link href="http://maxcdn.bootstrapcdn.com/font-awesome/4.2.0/css/font-awesome.min.css" rel="stylesheet">
    <link href='http://fonts.googleapis.com/css?family=Roboto:400,700,300' rel='stylesheet' type='text/css'>
    <link href="https://fonts.googleapis.com/css?family=Dancing+Script|Lobster" rel="stylesheet">

</head>
<body>
   
    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                               
                
                <a href="@Url.Action("Index", "Home", New With {.area = ""})" class="navbar-brand">
                    @*<i class="glyphicon glyphicon-home"></i>*@
                    @*<span class="sr-only"></span>*@ 
                    <img src="~/Content/Images/wbt_logo.png" height="40" align="middle"/>
                </a>
                @Html.ActionLink("WBtiming.pl", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    @*<li><a href="http://wbmtb.pl" target="_blank">wbmtb.pl</a></li>*@

                    @*<li>@Html.ActionLink("Contact", "Contact", "Home")</li>*@
                    @*<li><a href="https://jezile.typeform.com/to/xbh7bc" target="_blank">📝 Zapisz się teraz!</a></li>
                    <li>@Html.ActionLink("👥 Zarejestrowani", "Athlete", "WBXC", New With {.event = "1000"}, Nothing)</li>*@
                </ul>
            </div>
        </div>
    </div>
    
        <div class="container body-content">
            @RenderBody()
        <hr />
        <footer>
            <p>&copy; @DateTime.Now.Year - <a href="http://wbmtb.pl" target="_blank">wbmtb.pl</a></p>
        </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>

</html>
