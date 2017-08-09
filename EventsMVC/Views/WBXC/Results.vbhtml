@ModelType IEnumerable(Of EventsMVC.Results)
@Code
    ViewData("Title") = "wbtiming.pl | Wyniki na żywo"
    Layout = "~/Views/Shared/_LayoutWBXC.vbhtml"
End Code

<br />
<h3>Wersja podglądowa, dane w tabelce jeszcze się zmienią!</h3>
<div class="fresh-table toolb1ar-color-red">

    <div class="toolbar">
        @Html.ActionLink("Odśwież", "Results", "WBXC", New With {.area = ""}, New With {.class = "btn btn-default"})
    </div>

    <table id="fresh-table" class="table">
        <thead>
            <th data-field="open">Open</th>
            <th data-field="name">Imie nazwisko</th>
            <th data-field="number">Nr</th>
            <th data-field="club">Klub</th>
            <th data-field="city">Miejscowość</th>
            <th data-field="yob">Rok ur.</th>
            <th data-field="category">Kat.</th>
            <th data-field="lap1">Okr. 1</th>
            <th data-field="lap2">Okr. 2</th>
            <th data-field="lap3">Okr. 3</th>
            <th data-field="lap4">Okr. 4</th>
            <th data-field="lap5">Okr. 5</th>
           @*<th data-field="actions" data-formatter="operateFormatter" data-events="operateEvents">Actions</th>*@
        </thead>

        <tbody>
            @For Each item In Model
                @<tr>
                    <td>@Html.DisplayFor(Function(modelItem) item.Miejsce_open)</td>
                    <td>@Html.DisplayFor(Function(modelItem) item.Imię_nazwisko)</td>
                    <td>@Html.DisplayFor(Function(modelItem) item.Nr_startowy)</td>
                    <td>@Html.DisplayFor(Function(modelItem) item.Klub)</td>
                    <td>@Html.DisplayFor(Function(modelItem) item.Miejscowość)</td>
                    <td>@Html.DisplayFor(Function(modelItem) item.Rocznik)</td>
                    <td>@Html.DisplayFor(Function(modelItem) item.Kategoria)</td>
                    <td><b>@Html.DisplayFor(Function(modelItem) item.Lap_1)</b></td>
                    <td><b>@Html.DisplayFor(Function(modelItem) item.Lap_2)</b></td>
                    <td><b>@Html.DisplayFor(Function(modelItem) item.Lap_3)</b></td>
                    <td><b>@Html.DisplayFor(Function(modelItem) item.Lap_4)</b></td>
                    <td><b>@Html.DisplayFor(Function(modelItem) item.Lap_5)</b></td>
                </tr>
            Next
        </tbody>

    </table>

</div>
