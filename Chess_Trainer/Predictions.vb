Imports System.Data.SqlClient
Imports Chess_Trainer.DatabaseAccess
Public Class Predictions
    Dim user1 As Integer
    Dim user2 As Integer
    Dim prediction_result As Integer

    Function getprediction(ByVal user1 As Integer, ByVal user2 As Integer, ByVal rank1 As Integer, ByVal rank2 As Integer)
        Dim difference As Integer = rank2 - rank1
        Dim C As Single = (1 + 10) ^ (difference / 400)
        Dim ExpectedOutcome As Integer = (1 / C) * 100
        Return ExpectedOutcome
    End Function
    Function saveprediction(ByVal user1 As Integer, ByVal user2 As Integer, ByVal prediction As Integer)
        Dim db As New DatabaseAccess
        Dim conn = db.Open_Connection()
        Dim strStatement As String = "Insert into dbo.prediction values (" & user1 & "," & user2 & "," & prediction & ")"
        Dim outcome As Boolean

        outcome = db.ExecuteStatement(conn, strStatement)

        Return outcome
    End Function
End Class
