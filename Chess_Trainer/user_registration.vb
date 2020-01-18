Imports System.Data.SqlClient
Public Class Register
    Dim conn As SqlConnection = New SqlConnection("Data Source=HARRY-PAVILION\SQLEXPRESS;Initial Catalog=Chess_Trainer;Integrated Security=True")
    Dim isValidated = False
    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim command As New SqlCommand("SELECT country_id, country FROM country ORDER BY country", conn)
        Dim countriesTable As New DataTable()
        Dim countriesReader As SqlDataReader

        Btn_AddUser.Enabled = False
        conn.Open()

        countriesReader = command.ExecuteReader()
        countriesTable.Load(countriesReader)

        cmb_country.DataSource = countriesTable
        cmb_country.ValueMember = "country_id"
        cmb_country.DisplayMember = "country"

        If isValidated = True Then
            Btn_AddUser.Enabled = True
        End If
    End Sub

    Private Sub Btn_AddUser_Click(sender As Object, e As EventArgs) Handles Btn_AddUser.Click
        Dim strFirstName = Txt_FirstName.Text
        Dim strSurname = Txt_Surname.Text
        Dim strEmail = Txt_Email.Text
        Dim strMobile = Txt_Mobile_Number.Text
        Dim countryId = cmb_country.SelectedValue


        Dim command As New SqlCommand("Insert into dbo.chess_user values ('" & strFirstName & "','" & strSurname & "','" & strEmail & "'," & strMobile & "," & countryId & ")", conn)

        Try
            If isValidated Then
                command.Connection = conn

                command.ExecuteNonQuery()
                MessageBox.Show("User added successfully")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub Txt_Mobile_Number_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Txt_Mobile_Number.Validating
        Dim strErrorMessage = "Mobile Number must be an integer"
        Dim mobile As Integer

        isValidated = False

        If Integer.TryParse(Txt_Mobile_Number.Text, mobile) Then
            isValidated = True
        Else
            MessageBox.Show(strErrorMessage)
        End If
    End Sub

    Private Sub Txt_Rank_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Txt_Rank.Validating
        Dim strerrormessage = "Rank must be an integer"
        Dim rank As Integer

        isValidated = False
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
End Class
