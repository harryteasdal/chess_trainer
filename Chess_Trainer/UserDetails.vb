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
    Private Sub cmbUser_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbUser.SelectedValueChanged
        'Get the User Id of the Selected User
        Dim selectedUserId As String = 11 'cmbUser.SelectedValue.ToString

        Dim userDetails As DataTable = New DataTable()

        UserDetails = Utils.GetUserById(dbConn, selectedUserId)

        If (userDetails.Rows.Count = 1) Then
            'There should only ever be on row
            Dim userRow As DataRow = userDetails.Rows.Item(0)
            lblForename.Text = userRow(1)
            lblSurname.Text = userRow(2)
            lblEmail.Text = userRow(3)
            lblMobile.Text = userRow(4)
        Else
            UserCount.Text = "Warning: No Users Details"
        End If
    End Sub
End Class