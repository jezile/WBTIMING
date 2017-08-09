@ModelType IEnumerable(Of EventsMVC.Athlete)
@Code
    ViewData("Title") = "wbtiming.pl | List startowa I. WBXC - Strzemięcin"
    Layout = "~/Views/Shared/_LayoutWBXC.vbhtml"
End Code


<br><br>
<p>Osoby zarejestrowane w systemie.</p>

 @*&nbsp;<a class="btn btn-default" href="http://time.wbmtb.pl/WBXC/athlete?event=1000" target="_self"><i class="glyphicon fa fa-refresh"></i></a>*@

    <input type="text" id="myInput" onkeyup="myFunction()" placeholder="Wyszukaj osobę...">

    <table id="myTable">
        <tr class="header">
            <th>Lp.</th>
            <th>Imię i nazwisko</th>
            <th>Miejscowość</th>
            <th>Klub</th>
            <th>Płeć</th>
            <th>Kategoria</th>
            <th>Nr start.</th>
            <th>Data rejestracji</th>
        </tr>

        @For Each item In Model
            @<tr>
                 <td>@Html.DisplayFor(Function(modelItem) item.lp)</td>
                 <td>@Html.DisplayFor(Function(modelItem) item.AthleteName) @Html.DisplayFor(Function(modelItem) item.AthleteSurname)</td>
                 <td>@Html.DisplayFor(Function(modelItem) item.AthleteAddress)</td>
                 <td>@Html.DisplayFor(Function(modelItem) item.ClubName)</td>
                 <td>@Html.DisplayFor(Function(modelItem) item.Genre)</td>
                 <td>@Html.DisplayFor(Function(modelItem) item.CategoryName)</td>
                 <td>@Html.DisplayFor(Function(modelItem) item.StartNumber)</td>
                 <td>@Html.DisplayFor(Function(modelItem) item.CreateDateTime)</td>
            </tr>
        Next

    </table>






<script>
    function myFunction() {
        // Declare variables
        var input, filter, table, tr, td, i;
        input = document.getElementById("myInput");
        filter = input.value.toUpperCase();
        table = document.getElementById("myTable");
        tr = table.getElementsByTagName("tr");

        // Loop through all table rows, and hide those who don't match the search query
        for (i = 0; i < tr.length; i++) {
            td = tr[i].getElementsByTagName("td")[1];
            if (td) {
                if (td.innerHTML.toUpperCase().indexOf(filter) > -1) {
                    tr[i].style.display = "";
                } else {
                    tr[i].style.display = "none";
                }
            }
        }
    }
</script>


