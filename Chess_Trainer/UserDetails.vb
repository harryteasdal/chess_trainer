Public Class UserDetails
    Public dbConn As SqlConnection
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblUser.Click

    End Sub

    Private Sub UserDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'The combobox on the forms uses the data in the datatable'
            cmbUser.DataSource = Utils.GetUsers(dbConn)
            Dim isValidated As Boolean = False
            'Display member is what is shown in the combobox an .valuemember is waht is sent back to the database 
            cmbUser.ValueMember = "user_id"
            cmbUser.DisplayMember = "secondname"

            'Allows the user to click the add button when the text boxes have been validated'
            If isValidated = True Then
                '#Btn_AddUser.Enabled = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class