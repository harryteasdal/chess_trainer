'Purpose: Generates the Prediction
'Created: Harry Teasdale
'Comments:
'Version: 1.0
Imports System.Data.SqlClient

Public Class PredictionGenerator
    Public dbConn As SqlConnection
    Public predict As PredictionEngine

    Private Sub PredictionGenerator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Set up the Engine
            predict = New PredictionEngine
            'The combobox on the forms uses the data in the datatable'
            cmbPlayer1.DataSource = Utils.GetUsers(dbConn)
            cmbPlayer2.DataSource = Utils.GetUsers(dbConn)
            Dim isValidated As Boolean = False

            'Display member is what is shown in the combobox an .valuemember is waht is sent back to the database 
            cmbPlayer1.ValueMember = "user_id"
            cmbPlayer1.DisplayMember = "secondname"

            cmbPlayer2.ValueMember = "user_id"
            cmbPlayer2.DisplayMember = "secondname"

            'Allows the user to click the add button when the text boxes have been validated'
            If isValidated = True Then
                '#Btn_AddUser.Enabled = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    'Purpose: Gets the Prediction
    'Created: Harry Teasdale
    'Comments:
    'Version: 1.0
    Private Sub btnGetPrediction_Click(sender As Object, e As EventArgs) Handles btnGetPrediction.Click
        Try
            Dim player1_Id As Integer = cmbPlayer1.SelectedItem.Row(0)
            Dim player2_Id As Integer = cmbPlayer2.SelectedItem.Row(0)

            Dim player1_Rank As Integer = Utils.GetCurrentRankForUser(dbConn, player1_Id)
            Dim player2_Rank As Integer = Utils.GetCurrentRankForUser(dbConn, player2_Id)
            Dim predictionResult As Integer = predict.GetPrediction(player1_Id, player2_Id, player1_Rank, player2_Rank)
            Dim predictionResult2 As Integer = 100 - predictionResult


            If predictionResult > predictionResult2 Then
                lblResult.Text = String.Format("Player 1 is more likely to win at a percentage of {0}%", predictionResult)
            Else
                lblResult.Text = String.Format("Player 2 is more likely to win at a percentage of {0}%", predictionResult2)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class