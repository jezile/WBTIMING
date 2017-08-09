@Code
    ViewData("Title") = "wbtiming.pl | II. Owocowy Przełaj Kolarski"
    Layout = "~/Views/Shared/_LayoutOwocowyPrzelaj.vbhtml"
End Code

    <div class="jumbotron">
        <h1><i class="fa fa-bicycle" aria-hidden="true"></i><i class="fa fa-flag-checkered" aria-hidden="true"></i><i class="fa fa-trophy" aria-hidden="true"></i><br>
        II. Owocowy Przełaj Kolarski</h1>
        <h2>TBC (jesień 2017)</h2>
        <p class="lead">
            Wyścig w Laskowicach to kolejna edycja bardzo udanego wyścigu, który odbył się w 5 lutego br. (artykuł <a href="http://www.czasswiecia.pl/czas_swiecia/1,113943,21385534,przelaj-po-sadzie-dabrowskiego.html" target="_blank">Czas Świecia</a>).<br><br>
            
            II. edycja odbędzie się z profesjonalnym pomiarem czasu oraz wynikami na <b>żywo</b>! Koledzy z <a href='http://wbmtb.pl' target="_blank">Wheel Brothers</a> intensywnie pracują aby sprzęt jak również system był w 100% gotowości do dnia zawodów! 🤗<br><br>
            Serdecznie zapraszam!<br><br>
            
            <i>Jarosław Dąbrowski</i><br>
            Organizator
        </p>
        <p>
            @IconActionLink(Html, "fa fa-clock-o", "Wyniki na żywo!", "Results", "OwocowyPrzelaj", New With {.area = ""}, New With {.Class = "btn btn-default btn-lg btn-fill disabled"})
        </p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Zapisy</h2>
            <p>
                Rejestracja online będzie dostępna do dnia wyścigu.
            </p>
            <p><a class="btn btn-default btn-fill disabled" href="https://jezile.typeform.com/to/mIAUoX" target="_blank"><i class="fa fa-pencil-square-o" aria-hidden="true"></i> Zapisz się teraz! &raquo;</a></p>
            <p><a class="btn btn-default btn-fill disabled" href="http://wbtiming.pl/wbxc/athlete?event=1100"><i class="fa fa-users" aria-hidden="true"></i> Zarejestrowani &raquo;</a></p>
        </div>
        <div class="col-md-4">
            <h2>Regulamin</h2>
            <p>
                Regulamin zawodów
            </p>
            <p>
                <button type="button" class="btn btn-danger btn-fill" data-toggle="modal" data-target="#myModal"><i class="fa fa-book" aria-hidden="true"></i> Regulamin &raquo;</button>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Profil trasy</h2>
            <p>Profil trasy już wkrótce...</p>
            <p><a class="btn btn-default btn-fill disabled" href="https://ridewithgps.com/routes/23601085" target="_blank"><i class="fa fa-road" aria-hidden="true"></i> Trasa &raquo;</a></p>
        </div>
    </div>


<!-- Modal -->
<div id="myModal" class="modal fade" role="dialog">
    <div class="modal-dialog">

        <!-- Modal content-->
        <div class="modal-content">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal">&times;</button>
                <h4 class="modal-title">Regulamin II. Owocowego Przełaju Kolarskiego</h4>
            </div>
            <div class="modal-body">
                <ul>
                    <li> Już wkrótce...
                </ul>
            </div>
            <div class="modal-footer">
                <a class="btn btn-danger btn-fill" data-dismiss="modal">Zamknij &raquo;</a>
            </div>
        </div>

    </div>
</div>