@Code
    ViewData("Title") = "wbmtb.pl"
End Code

    <div class="jumbotron">
        <h1>VI etap "Grudziądzkiej Ligi Amatorów"➡ 24.09.2017</h1>
        <p class="lead">
            Wyścig w Małym Rudniku to ostatni etap <a href="https://www.facebook.com/search/top/?q=Grudzi%C4%85dzkiej%20Ligi%20Amator%C3%B3w" target="_blank">Grudziądzkiej Ligi Amatorów</a> w sezonie 2017.<br>Zapraszamy!
        </p>
        <p>
            @Html.ActionLink("⏱ Premia Górska na żywo!", "Index", "Athlete", New With {.area = ""}, New With {.class = "btn btn-primary btn-lg btn-fill"})
        </p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Program</h2>

            <ul>
                <li>9:00-10:00 - zapisy
                <li>10:30 - odprawa techniczna
                <li>11:00 - start młodzik i juniorka młodsza
                <li>11:10 - start żak i młodziczka
                <li>12:15 - start junior młodszy i junior
                <li>12:25 - start amator (kobiety 1 okrążenie)
                <li>14:00 - zakończenie i dekoracja zwycięzców wszystkich kategorii
            </ul>
            @*<p><a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301867">Learn more &raquo;</a></p>*@
        </div>
        <div class="col-md-4">
            <h2>Regulamin</h2>
            <p>
                Regulamin zawodów
            </p>
            <p><a class="btn btn-primary btn-fill" href="http://www.alksstal.org/download/regulaminy/RWK%202016%20-%20Maly%20Rudnik%2025.09.2016.pdf" target="_blank">Regulamin &raquo;</a></p>
        </div>
        <div class="col-md-4">
            <h2>Profil trasy</h2>
            <p>Profil trasy z serwisu Endomondo.com</p>
            <p><a class="btn btn-primary btn-fill" href="http://www.endomondo.com/embed/routes?id=805296951&width=900&height=600">Sprawdź &raquo;</a></p>
        </div>
    </div>
