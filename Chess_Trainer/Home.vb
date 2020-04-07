
Imports System.Data.SqlClient
Public Class Frm_home
    Private Sub NewUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewUserToolStripMenuItem.Click
        Frm_Register.Show()
    End Sub

    Private Sub PredictToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PredictToolStripMenuItem1.Click
        Frm_Prediction.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_test.Show()
    End Sub

    Private Sub Frm_home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dbAccess As DatabaseAccess
        dbAccess = New DatabaseAccess
        Try
            Dim conn As SqlConnection
            conn = dbAccess.Open_Connection()
            If (conn.State = ConnectionState.Open) Then
                MsgBox("Connected to Database")
            Else
                MsgBox("Not Connected to Database")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class