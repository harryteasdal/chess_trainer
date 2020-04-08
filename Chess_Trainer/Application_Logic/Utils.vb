Imports System.Data.SqlClient
'Purpose: Main Business Logic Class
'Created: Harry Teasdale
'Comments: 
'Version: 1.0
NotInheritable Class Utils
    Private Sub New()

    End Sub
    'Purpose: Adds Users to the Database
    'Created: Harry Teasdale
    'Comments: Returns the Id of the user
    Public Shared Function AddUsers(dbConn As SqlConnection, strFirstName As String, strSurname As String, strEmail As String, strMobile As String, countryId As Integer)
        Dim addUsersSql As String = "Insert into dbo.chess_user values ('" & strFirstName & "','" & strSurname & "','" & strEmail & "'," & strMobile & "," & countryId & ");SELECT SCOPE_IDENTITY();"
        Dim db As New DatabaseAccess()
        Try
            Dim e = db.ExecuteStatement(dbConn, addUsersSql)
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    'Purpose: Returns a List of Countries
    'Created: Harry Teasdale
    'Comments:
    'Version: 1.0
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
    'Purpose: Returns a list of Users
    'Created: Harry Teasdale
    'Comments:
    'Version: 1.0
    Public Shared Function GetUsers(dbConn As SqlConnection)
        Dim users As String = "SELECT user_id, firstname, secondname FROM chess_user ORDER BY user_id"
        Dim usersTable As New DataTable()
        Dim db As New DatabaseAccess()
        Try
            usersTable = db.Get_Data(dbConn, users)
            Return usersTable
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    'Purpose: Saves a prediction to the database
    'Created: Harry Teasdale
    'Comments:
    'Version: 1.0
    Public Shared Function SavePrediction(dbConn As SqlConnection, predictionScore As Decimal)
        Try
            Return 0
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    'Purpose: Gets a prediction from the database 
    'Created: Harry Teasdale
    'Comments:
    'Version: 1.0
    Public Shared Function GetPredictionById(dbConn As SqlConnection, predictionId As Integer)
        Try
            Dim getUserPredictionSql As String = String.Format("SELECT * FROM prediction where prediction_id = {0}", predictionId)
            Return 0
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    'Purpose: Sets a rank for a user
    'Created: Harry Teasdale
    'Comments:
    'Version: 1.0
    Public Shared Function SetRankForUser(dbConn As SqlConnection, userId As Integer, rankId As Integer)
        Try
            Return 0
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    'Purpose: Gets a current rank for a user
    'Created: Harry Teasdale
    'Comments:
    'Version: 1.0
    Public Shared Function GetCurrentRankForUser(dbConn As SqlConnection, userId As Integer)
        Try
            Dim currentRankSql As String = String.Format("SELECT * FROM player_rank where user_id = {0}", userId)
            Return 0
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    'Purpose: Gets a historical rank for a user
    'Created: Harry Teasdale
    'Comments:
    'Version: 1.0
    Public Shared Function GetHistoricalRankForUser(dbConn As SqlConnection, userId As Integer)
        Try
            Dim historicalRankSql As String = String.Format("SELECT * FROM historical_rank where user_id = {0}", userId)
            Return 0
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    'Purpose: Saves the outcome for a user
    'Created: Harry Teasdale
    'Comments:
    'Version: 1.0
    Public Shared Function SaveOutcome(dbConn As SqlConnection, predictionId As Integer, outcome As Integer)
        Try
            Return 0
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    'Purpose: Tests that a user is a new user 
    'Created: Harry Teasdale
    'Comments: A new user has a rank of zero
    'Version: 1.0
    Public Shared Function IsNewUser(dbConn As SqlConnection, userId As Integer)
        Try
            Dim currentRankSql As String = String.Format("SELECT rank_number FROM player_rank where user_id = {0}", userId)
            Dim isNewUserOutcome As Boolean = False

            Return isNewUserOutcome
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    'Purpose: Formats user name 
    'Created: Harry Teasdale
    'Comments: Formats a user
    'Version: 1.0
    Public Shared Function FormatUserName(dbConn As SqlConnection, userId As Integer)
        Try
            Dim userSql As String = String.Format("SELECT firstname, secondname FROM chess_user where user_id = {0}", userId)
            Dim formattedUserName As String

            Return formattedUserName
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class

