Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
'Purpose: Main class for interacting with database
'Created: Harry Teasdale
'Comments:
'Version: 1.0
Public Class DatabaseAccess
    Private Const connectionString = "Data Source=HARRY-PAVILION\SQLEXPRESS;Initial Catalog=Chess_Trainer;Integrated Security=True"
    Dim conn As SqlConnection
    'Purpose: Executes Basic Create, Update and Delete on Database
    'Created: Harry Teasdale
    'Comments:
    Public Function ExecuteStatement(ByVal conn As SqlConnection, strStatement As String)
        Dim outcome As Boolean
        Dim rows As Integer
        Dim db_command As New SqlCommand(strStatement, conn)

        outcome = False
        Try
            rows = db_command.ExecuteNonQuery()
            If (rows > 0) Then
                outcome = True
            Else
                outcome = False
            End If
            Return (outcome, rows)
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    'Purpose: Returns data from the database
    'Created: Harry Teasdale
    'Comments:
    Public Function Get_Data(ByVal conn As SqlConnection, strStatement As String)
        Using sql_adapter As SqlDataAdapter = New SqlDataAdapter(strStatement, conn)
            Dim sql_table As DataTable = New DataTable()
            sql_adapter.Fill(sql_table)
            Return sql_table
        End Using
    End Function
    'Purpose: Opens a database connection
    'Created: Harry Teasdale
    'Comments:
    Public Function Open_Connection()
        Try
            conn = New SqlConnection(connectionString)
            conn.Open()
            Return conn
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    'Purpose: Closes Database Connection
    'Created: Harry Teasdale
    'Comments:
    Public Function Close_Connection(ByVal conn As SqlConnection)
        conn.Close()
        Return conn
    End Function
    'Purpose: Tests if Connection is still open
    'Created: Harry Teasdale
    'Comments:
    Public Function IsConnectionOpen(ByVal conn As SqlConnection)
        If conn.State = ConnectionState.Open Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
