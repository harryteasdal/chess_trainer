Imports System.Data.SqlClient
Imports Chess_Trainer.Predictions
Imports Chess_Trainer.DatabaseAccess


Public Class Frm_Prediction
    Dim db As New DatabaseAccess()
    Dim dbresult As Boolean
    Dim conn = db.Open_Connection()
    Dim user1id, user2id As Integer
    Dim rank1, rank2 As Integer
    Dim returnedoutcome As Integer
    Private Sub Frm_Prediction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'SQL statement to pull the user id,firstname and secondname from chess user table in the database 
        Dim command As New SqlCommand("SELECT user_id, firstname, secondname FROM dbo.chess_user ORDER BY firstname", conn)

        'Object to store the data from database'
        Dim usertable As New DataTable()
        Dim usertable2 As New DataTable()
        'Object to read the data from database'
        Dim userreader As SqlDataReader

        'connects to database'
        'conn.Open()

        'reads data from database and stores data in the usertable'
        userreader = command.ExecuteReader()

        usertable.Load(userreader)
        userreader.Close()
        ' usertable2.Load(userreader)
        'The combobox on the forms uses the data in the datatable to select a user to calculate probability
        Cmb_PlayerA.DataSource = usertable


        '.diplaymember is what is shown in the combobox an .valuemember is what is sent back to the database 
        Cmb_PlayerA.DisplayMember = "secondname"
        Cmb_PlayerA.ValueMember = "user_id"

        userreader = command.ExecuteReader
        usertable2.Load(userreader)
        Cmb_PlayerB.DataSource = usertable2
        Cmb_PlayerB.DisplayMember = "secondname"
        Cmb_PlayerB.ValueMember = "user_id"


    End Sub

    Private Sub btn_predict_Click(sender As Object, e As EventArgs) Handles btn_predict.Click
        Dim newpredictions As New Predictions
        Dim rankcommand As New SqlCommand
        Dim Getrank1, Getrank2 As String
        Dim outcome As Boolean

        user1id = Cmb_PlayerA.SelectedValue
        user2id = Cmb_PlayerB.SelectedValue
        Getrank1 = String.Format("SELECT rank_number FROM dbo.player-rank WHERE user_id = {0}", user1id)
        Getrank2 = String.Format("SELECT rank_number FROM dbo.player-rank WHERE user_id = {0}", user2id)

        returnedoutcome = newpredictions.getprediction(user1id, user2id, rank1, rank2)
        outcome = newpredictions.saveprediction(user1id, user2id, returnedoutcome)

        If outcome Then
            MessageBox.Show(returnedoutcome)
        Else
            MessageBox.Show("Prediction did not save")
        End If


        'newpredictions.saveprediction()
    End Sub
End Class