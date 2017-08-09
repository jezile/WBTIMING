@Code
    ViewData("Title") = "wbtiming.pl | Pomiar czasu"
End Code

    <div class="jumbotron">
        @*<h1>WBtiming.pl</h1>*@
        <h1><i class="fa fa-clock-o" aria-hidden="true"></i><i class="fa fa-flag-checkered" aria-hidden="true"></i>
        <br>Jesteśmy na czasie!</h1>
        <p class="lead">
            Profesionalny pomiar czasu, premii górskich, czasówek, przygotowanie i znakowanie trasy, biura-miasteczka zawodów, sceny - czyli <u>kompleksowa obsługa zawodów</u>!<br>
            Oferujemy numery startowe, chipy, wyniki na <b>żywo</b>, wyniki SMS. <br><br>Zapraszamy do kontaktu!
        </p>
        <br>
        <p>
            <a class="btn btn-danger btn-lg btn-fill" href="mailto:kontakt@wbmtb.pl"><i class="fa fa-envelope-o" aria-hidden="true"></i> Napisz do nas &raquo;</a>
        </p>
    </div>

    <div class="row">
        <div class="col-md-12">
            <h2>Kalendarz:</h2>
            <ul class="fa-ul">
                <li><i class="fa-li fa fa-calendar"></i>17/09/2017 - Pomiar czasu na @Html.ActionLink("I. WBXC Strzemięcin", "Index", "WBXC", New With {.area = ""}, New With {.class = ""})
                <li><i class="fa-li fa fa-calendar"></i>(TBC) 24/09/2017 - Pomiar premii górskiej na IV Amatorskiej Lidze Kolarskiej w Małym Rudniku
                <li><i class="fa-li fa fa-calendar"></i>(TBC) - Pomiar czasu na @Html.ActionLink("II. Owocowym Przełaju Kolarskim w Laskowicach", "Index", "OwocowyPrzelaj", New With {.area = ""}, New With {.class = ""})
            </ul>
            @*<p><a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301867">Learn more &raquo;</a></p>*@
        </div>
        @*<div class="col-md-4">
            <h2>Profil trasy</h2>
            <p>Profil trasy z serwisu Endomondo.com</p>
            <p><a class="btn btn-primary btn-fill" href="http://www.endomondo.com/embed/routes?id=805296951&width=900&height=600">Sprawdź &raquo;</a></p>
        </div>*@
    </div>
