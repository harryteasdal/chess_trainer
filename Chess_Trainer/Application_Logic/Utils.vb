Imports System.Data.SqlClient
NotInheritable Class Utils
    Private Sub New()

    End Sub

    Public Shared Function GetCountries(dbConn As SqlConnection)
        Dim countries As String = "SELECT country_id, country FROM country ORDER BY country"
        Dim countriesTable As New DataTable()
        Dim countriesReader As SqlDataReader
        Dim countriesCommand As SqlCommand
        Dim db As New DatabaseAccess()

        Try
            countriesCommand = db.ExecuteStatement(dbConn, countries)
            'Reads data from database and stores data in the countries table'
            countriesReader = countriesCommand.ExecuteReader()
            countriesTable.Load(countriesReader)

            Return countriesTable
        Catch ex As Exception
            Throw ex
        End Try

    End Function
End Class
