Imports Chess_Trainer.DatabaseAccess
Imports System.Data.SqlClient
Public Class frm_test
    Private Sub test_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim db As New DatabaseAccess
        Dim result As Boolean
        Dim mycon = db.Open_Connection()
        Dim strStatement As String = "Insert into dbo.player_rank (rank_number, user_id) values (99,22)"
        result = db.ExecuteStatement(mycon, strStatement)

        If (result) Then
            db.Close_Connection(mycon)
        End If

    End Sub
End Class