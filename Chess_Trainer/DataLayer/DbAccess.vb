Imports Microsoft.VisualBasic
Imports System.Data.SqlClient


Public Class DatabaseAccess
    Private Const connectionString = "Data Source=HARRY-PAVILION\SQLEXPRESS;Initial Catalog=Chess_Trainer;Integrated Security=True"
    Dim conn As SqlConnection

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

    Public Function Open_Connection()
        Try
            conn = New SqlConnection(connectionString)
            conn.Open()
            Return conn
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function Close_Connection(ByVal conn As SqlConnection)
        conn.Close()
        Return conn
    End Function

    Public Function IsConnectionOpen(ByVal conn As SqlConnection)
        If conn.State = ConnectionState.Open Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
