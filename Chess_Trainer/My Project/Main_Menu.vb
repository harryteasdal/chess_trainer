Public Class Frm_Main_Menu
    Private Sub Btn_Register_Click(sender As Object, e As EventArgs) Handles Btn_Register.Click
        Me.Hide()
        Frm_Register.Show()
    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub
End Class