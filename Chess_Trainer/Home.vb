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
End Class