@Code
    ViewData("Title") = "wbtiming.pl | I. WBXC - Strzemięcin"
    Layout = "~/Views/Shared/_LayoutWBXC.vbhtml"
End Code

<div class="jumbotron">
    <h1><i class="fa fa-bicycle" aria-hidden="true"></i><i class="fa fa-flag-checkered" aria-hidden="true"></i><i class="fa fa-tree" aria-hidden="true"></i><br>
        I. WBXC Strzemięcin</h1>
    <h2>17 września 2017</h2>
    
    <p class="lead">
        Pierwszy trening z <a href="http://wbmtb.pl" target="_blank">Wheel Brothers</a> odbędzie się z profesjonalnym pomiarem czasu oraz wynikami na <b>żywo</b>! Intensywnie pracujemy aby sprzęt, jak również system był w 100% gotowości do dnia treningu! 🤗<br><br>

        <b>Data:</b> Niedziela, 17 września 2017, start godz. 11:00<br>
        <b>Lokalizacja:</b> <a href="https://goo.gl/maps/vqMSGfhZxY22" target="_blank">Lasek Strzemięciński (w pobliżu Śniadeckich 50, Grudziądz)</a><br>
        <b>Opłata:</b> brak
        <br><br>

        Serdecznie zapraszamy!<br>
        <a href="http://wbmtb.pl" target="_blank">wbmtb.pl</a><br>
     </p>

    <p>
        @IconActionLink(Html, "fa fa-clock-o", "Wyniki na żywo!", "Results", "WBXC", New With {.area = ""}, New With {.Class = "btn btn-default btn-lg btn-fill disabled"})
        <br><br>
        <i class="fa fa-thumbs-o-up" aria-hidden="true"></i> Polub nas na <a href="https://www.facebook.com/wbmtb/" target="_blank">facebooku</a>.<br>
        <i class="fa fa-envelope-o" aria-hidden="true"></i> <a href="mailto:kontakt@wbmtb.pl" target="_blank">Napisz</a> do nas.
    </p>

</div>

<div class="row">
    <div class="col-md-4">
        <h2>Zapisy</h2>
        <p>
            Rejestracja online jest dostępna do dnia treningu do godz. <b>10:30</b>.
        </p>
        <p><a class="btn btn-danger btn-fill" href="https://jezile.typeform.com/to/xbh7bc" target="_blank"><i class="fa fa-pencil-square-o" aria-hidden="true"></i> Zapisz się teraz! &raquo;</a></p>
        <p><a class="btn btn-danger btn-fill" href="http://wbtiming.pl/wbxc/athlete?event=1000"><i class="fa fa-users" aria-hidden="true"></i> Zarejestrowani &raquo;</a></p>
        @*<p>@IconActionLink(Html, "fa fa-users", "Zarejestrowani", "Athlete", "WBXC", New With {.event = "1000"}, New With {.Class = "btn btn-danger btn-fill"}) &raquo;</p>*@
    </div>

    <div class="col-md-4">
        <h2>Regulamin</h2>
        <p>
            Regulamin cyklu treningowego WBXC
        </p>
        <p>
            <button type="button" class="btn btn-danger btn-fill" data-toggle="modal" data-target="#myModal"><i class="fa fa-book" aria-hidden="true"></i> Regulamin &raquo;</button>
        </p>
    </div>

    <div class="col-md-4">
        <h2>Profil trasy</h2>
        <p>Podstawowe dane:
            <ul class="fa-ul">
                <li><i class="fa-li fa fa-arrow-circle-right"></i> Długość okrążenia : <b>3,4 km</b>
                <li><i class="fa-li fa fa-arrow-circle-right"></i> Ilość okrążeń : <b>5</b>
                <li><i class="fa-li fa fa-arrow-circle-right"></i> Przewyższenia : <b>58 m/okrążenie</b>
                <li><i class="fa-li fa fa-arrow-circle-right"></i> Śr. czas okrążenia : <b>14 min</b>
            </ul>  
            Profil trasy z serwisu ridewithgpx.com...
        </p>
        <p><a class="btn btn-danger btn-fill" href="https://ridewithgps.com/routes/23601085" target="_blank"><i class="fa fa-road" aria-hidden="true"></i> Trasa &raquo;</a></p>
    </div>
</div>

 <!-- Modal -->
<div id="myModal" class="modal fade" role="dialog">
    <div class="modal-dialog">

        <!-- Modal content-->
        <div class="modal-content">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal">&times;</button>
                <h4 class="modal-title">Regulamin cyklu treningowego WBXC</h4>
            </div>
            <div class="modal-body">
                <ol>
                    <li>Celem treningów WBXC jest:</li>
                        Popularyzacja kolarstwa (w szczególności XC, XCO), propagowanie i rozpowszechnianie sportów rowerowych, w tym rowerowych sportów ekstremalnych oraz wszystkich odmian kolarstwa, poprawienie umiejętności zawodników uprawiających sport, integracja środowiska rowerowego, promowanie regionalnych szlaków, aktywnych sposobów spędzania wolnego czasu, a także upowszechnianie zdrowego, aktywnego trybu życia.
                    <li>Zasada przebiegu treningu.</li>

                        <ul>
                            <li>
                                Trening będzie się odbywał przy nieograniczonym ruchu pieszych (spacerowicze, biegacze itp.)
                            </li>
                            <li>
                                W miejscach szczególnie niebezpiecznych trasa zostanie odpowiednio oznakowana.
                            </li>
                            <li>
                                <b>Osoby muszą zachować szczególną ostrożność mając na uwadze możliwość wejścia pieszego z lasu lub bocznych ścieżek.</b> Nie ponosimy odpowiedzialności za ewentualne kolizje i wypadki na trasie.
                            </li>
                        </ul>

                    <li>Warunki uczestnictwa. Uczestnikiem treningu może być osoba spełniająca następujące warunki:
                                <ul>
                                    <li> Jest osobą pełnolenią (18+)</li>
                                    <li> Dokona rejestracji:</li>

                                    <ul>
                                        <li> na stronie <a href="https://jezile.typeform.com/to/xbh7bc">www</a></li>
                                        <li> bezpośrednio u osób wykonujących pomiar przejazdu w dniu treningu (zgłoszenie udziału w treningu można dokonać najpóźniej na 30 minut przed rozpoczęciem przejazdu treningowego).</li>
                                    </ul>
                                    <li> Przed treningiem uczestnik zobowiązany jest potwierdzić swoją obecność w Biurze Zawodów</li>
                                    <li> Uczestnik wyposażony musi być w sprawny rower przystosowany do jazdy w terenie (preferowany rower górski)</li>
                                    <li> Uczestnik wyposażony będzie w kask rowerowy – zawodnicy bez kasku nie będą mogli uczestniczyć w treningu</li>
                                </ul>
                            </li>
                </ol>
            </div>
            <div class="modal-footer">
                <a class="btn btn-danger btn-fill" data-dismiss="modal">Zamknij &raquo;</a>
            </div>
        </div>

    </div>
</div>