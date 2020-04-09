Imports System.Data.SqlClient
'Purpose: Allows Viewing User Details
'Created: Harry Teasdale
'Comments:
'Version: 1.0
Public Class UserDetails
    Public dbConn As SqlConnection
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

    Private Sub cmbUser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUser.SelectedIndexChanged
        'Get the User Id of the Selected User
        Dim selectedUser As Integer = cmbUser.SelectedIndex
        Dim userDetails As DataTable = New DataTable()

        userDetails = Utils.GetUserById(dbConn, selectedUser)

        If (userDetails.Rows.Count = 1) Then
            lblForename.Text = "firstname"
        Else
            UserCount.Text = "Warning: No Users Details"
        End If

    End Sub
End Class