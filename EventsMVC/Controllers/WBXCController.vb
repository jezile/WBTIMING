
Namespace Controllers
    Public Class WBXCController
        Inherits Controller

        Private db As New DbConnectionWebio

        ' Index (Home)
        Function Index() As ActionResult

            Return View()
        End Function

        ' Results
        Function Results() As ActionResult

            Return View(db.ResultsRead(1000))
        End Function


        Function Athlete() As ActionResult
            Dim param1 As String = Request.QueryString("event")

            Return View(db.AthleteRead(param1))
        End Function

    End Class
End Namespace