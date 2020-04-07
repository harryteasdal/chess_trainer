Imports System.Data.SqlClient
NotInheritable Class Utils
    Private Sub New()

    End Sub

    Public Shared Function GetCountries(dbConn As SqlConnection)
        Dim countries As String = "SELECT country_id, country FROM country ORDER BY country"
        Dim countriesTable As New DataTable()
        Dim db As New DatabaseAccess()
        Try
            countriesTable = db.Get_Data(dbConn, countries)
            Return countriesTable
        Catch ex As Exception
            Throw ex
        End Try

    End Function
End Class
