Imports System.Data.SqlClient
Imports Chess_Trainer.DatabaseAccess
'Purpose: Registers Users for Application
'Created: Harry Teasdale
'Comments:
'Version: 1.0
Public Class Frm_Register
    'makes a new sql connection object "conn" and use a connetion statment to connct to the database'
    'Dim conn As SqlConnection = New SqlConnection("Data Source=HARRY-PAVILION\SQLEXPRESS;Initial Catalog=Chess_Trainer;Integrated Security=True")
    Dim dbresult As Boolean
    Public dbConn As SqlConnection
    'Flag to check the validation of text boxes'
    Dim isValidated = False
    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'When the form loads the add user button is disabled as the text boxes have not ben check for validation'
        Btn_AddUser.Enabled = False
        Try
            'The combobox on the forms uses the data in the datatable'
            cmb_country.DataSource = Utils.GetCountries(dbConn)

            'Display member is what is shown in the combobox an .valuemember is waht is sent back to the database 
            cmb_country.ValueMember = "country_id"
            cmb_country.DisplayMember = "country"

            'Allows the user to click the add button when the text boxes have been validated'
            If isValidated = True Then
                Btn_AddUser.Enabled = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Btn_AddUser_Click(sender As Object, e As EventArgs) Handles Btn_AddUser.Click
        'Reads text entered into the textboxes'
        Dim strFirstName = Txt_FirstName.Text
        Dim strSurname = Txt_Surname.Text
        Dim strEmail = Txt_Email.Text
        Dim strMobile = Txt_Mobile_Number.Text
        Dim countryId = cmb_country.SelectedValue
        Dim rank = Txt_Rank.Text
        Dim modified As Integer

        'Adds users to the database
        Try
            If isValidated Then
                Utils.AddUsers(dbConn, strFirstName, strSurname, strEmail, strMobile, countryId)
                MessageBox.Show("User added successfully")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Txt_Mobile_Number_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Txt_Mobile_Number.Validating
        'Error message that is displayed'
        Dim strErrorMessage = "Mobile Number must be an integer"
        Dim mobile As Integer

        isValidated = False

        'checks to see if the mobile number and if not an error message is displayed'
        If Integer.TryParse(Txt_Mobile_Number.Text, mobile) Then
            isValidated = True
        Else
            MessageBox.Show(strErrorMessage)
        End If
    End Sub

    Private Sub Txt_Rank_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Txt_Rank.Validating
        'Error message that is displayed'
        Dim strerrormessage = "Rank must be an integer"
        Dim rank As Integer

        isValidated = False
        'checks to see if the mobile number and if not an error message is displayed'
        If Integer.TryParse(Txt_Rank.Text, rank) Then
            isValidated = True
        Else
            MessageBox.Show(strerrormessage)
        End If
    End Sub


    Private Sub Txt_Email_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Txt_Email.Validating
        If isValidated Then
            If String.IsNullOrEmpty(Txt_Email.Text) Then
                isValidated = False
                MessageBox.Show("Please correct validation errors")
            Else
                isValidated = True
                Btn_AddUser.Enabled = True
            End If
        End If
    End Sub

    Private Sub Btn_Return_Click(sender As Object, e As EventArgs) Handles Btn_Return.Click
        Me.Hide()
        Frm_home.Show()
    End Sub
End Class
