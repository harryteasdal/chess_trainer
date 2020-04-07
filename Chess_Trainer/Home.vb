
Imports System.Data.SqlClient
Public Class Frm_home
    Dim dbAccess As DatabaseAccess
    Dim conn As SqlConnection
    Private Sub NewUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewUserToolStripMenuItem.Click
        If (conn.State = ConnectionState.Open) Then
            Frm_Register.dbConn = conn
            Frm_Register.Show()
        Else
            MessageBox.Show(
                "Lost Database Connection",
                "Chess Trainer Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1)
        End If

    End Sub

    Private Sub PredictToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PredictToolStripMenuItem1.Click
        Frm_Prediction.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub


    Private Sub Frm_home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbAccess = New DatabaseAccess
        Try
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

    Private Sub AddUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUserToolStripMenuItem.Click

    End Sub
End Class