﻿'Purpose: Main business logic class for calculating a prediction
'Created: Harry Teasdale
'Comments:
'Version: 1.0
Public Class PredictionEngine
    'Purpose: Calculates a Prediction
    'Created: Harry Teasdale
    'Comments: Takes the User identifiers and ranks and calculates the predictions
    'Version: 1.0
    Public Function GetPrediction(ByVal user1 As Integer, ByVal user2 As Integer, ByVal rank1 As Integer, ByVal rank2 As Integer)
        Try
            Dim Difference As Integer = rank2 - rank1
            Dim C As Single = (1 + 10) ^ (Difference / 400)
            Dim ExpectedOutcome As Integer = (1 / C) * 100
            Return ExpectedOutcome
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    'Purpose: Saves a prediction
    'Created: Harry Teasdale
    'Comments:
    'Version: 1.0
    Public Function SavePrediction()
        Try

        Catch ex As Exception

        End Try
    End Function
End Class
