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
                               
                
                <a href="@Url.Action("Index", "WBXC", New With {.area = ""})" class="navbar-brand">
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
                    <li><a href="https://jezile.typeform.com/to/mIAUoX" target="_blank"><i class="fa fa-pencil-square-o" aria-hidden="true"></i> Zapisz się teraz!</a></li>
                    @*<li>@Html.ActionLink("👥 Zarejestrowani", "Athlete", "WBXC", New With {.event = "1000"}, Nothing)</li>*@
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

<script type="text/javascript">
    var $table = $('#fresh-table'),
        $alertBtn = $('#alertBtn'),
        full_screen = false;

    $().ready(function () {
        $table.bootstrapTable({
            toolbar: ".toolbar",

            showRefresh: false,
            search: true,
            showToggle: false,
            showColumns: false,
            pagination: true,
            striped: true,
            sortable: true,
            pageSize: 25,
            pageList: [10, 25, 50, 100],

            formatShowingRows: function (pageFrom, pageTo, totalRows) {
                //do nothing here, we don't want to show the text "showing x of y from..."
            },
            formatRecordsPerPage: function (pageNumber) {
                return pageNumber + " widoczne wiersze";
            },
            icons: {
                refresh: 'fa fa-refresh',
                toggle: 'fa fa-th-list',
                columns: 'fa fa-columns',
                detailOpen: 'fa fa-plus-circle',
                detailClose: 'fa fa-minus-circle'
            }
        });
    });

    //$(function () {
    //    $alertBtn.click(function () {
    //        alert("You pressed on Alert");
    //    });
    //});


    function operateFormatter(value, row, index) {
        return [
            '<a rel="tooltip" title="Like" class="table-action like" href="javascript:void(0)" title="Like">',
            '<i class="fa fa-heart"></i>',
            '</a>',
            '<a rel="tooltip" title="Edit" class="table-action edit" href="javascript:void(0)" title="Edit">',
            '<i class="fa fa-edit"></i>',
            '</a>',
            '<a rel="tooltip" title="Remove" class="table-action remove" href="javascript:void(0)" title="Remove">',
            '<i class="fa fa-remove"></i>',
            '</a>'
        ].join('');
    }

        //window.operateEvents = {
        //    'click .like': function (e, value, row, index) {
        //        alert('You click like icon, row: ' + JSON.stringify(row));
        //        console.log(value, row, index);
        //    },
        //    'click .edit': function (e, value, row, index) {
        //        console.log(value, row, index);
        //    },
        //    'click .remove': function (e, value, row, index) {
        //        alert('You click remove icon, row: ' + JSON.stringify(row));
        //        console.log(value, row, index);
        //    }
        //};

</script>



</html>
