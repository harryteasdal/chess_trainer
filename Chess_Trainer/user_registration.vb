Imports System.Data.SqlClient
Imports Chess_Trainer.DatabaseAccess
Public Class Frm_Register
    'makes a new sql connection object "conn" and use a connetion statment to connct to the database'
    'Dim conn As SqlConnection = New SqlConnection("Data Source=HARRY-PAVILION\SQLEXPRESS;Initial Catalog=Chess_Trainer;Integrated Security=True")
    Dim db As New DatabaseAccess()
    Dim dbresult As Boolean
    Dim conn = db.Open_Connection()

    'Flag to check the validation of text boxes'
    Dim isValidated = False
    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'SQL statement to pull the country id and country from county table in the database
        Dim countries As String = "SELECT country_id, country FROM country ORDER BY country"
        'Object to store the data from database'
        Dim countriesTable As New DataTable()
        'Object to read the data from database'
        Dim countriesReader As SqlDataReader
        Dim countriesCommand As SqlCommand

        'When the form loads the add user button is disabled as the text boxes have not ben check for validation'
        Btn_AddUser.Enabled = False

        countriesCommand = db.ExecuteStatement(conn, countries)

        'reads data from database and stores data in the countries table'
        countriesReader = countriesCommand.ExecuteReader()
        countriesTable.Load(countriesReader)

        'The combobox on the forms uses the data in the datatable'
        cmb_country.DataSource = countriesTable
        '.diplaymember is what is shown in the combobox an .valuemember is waht is sent back to the database 
        cmb_country.ValueMember = "country_id"
        cmb_country.DisplayMember = "country"

        'Allows the user to click the add button when the text boxes have been validated'
        If isValidated = True Then
            Btn_AddUser.Enabled = True
        End If
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
        'SQL command to add a user to the database'
        Dim command As New SqlCommand("Insert into dbo.chess_user values ('" & strFirstName & "','" & strSurname & "','" & strEmail & "'," & strMobile & "," & countryId & ");SELECT SCOPE_IDENTITY();", conn)

        'Connects to database to add user and closes connection once done if unsuccessful error message displayed'
        Try

            If isValidated Then
                command.Connection = conn
                modified = Convert.ToInt32(command.ExecuteScalar())
                Dim command2 As New SqlCommand("Insert into dbo.player_rank (rank_number, user_id) values (" & rank & "," & modified & ")", conn)
                command2.Connection = conn
                'modified = command.ExecuteNonQuery()
                'command.ExecuteNonQuery()
                command2.ExecuteNonQuery()
                MessageBox.Show("User added successfully")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
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
