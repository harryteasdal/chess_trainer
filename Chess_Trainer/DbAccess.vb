Imports Microsoft.VisualBasic
Imports System.Data.SqlClient


Public Class DatabaseAccess

    Dim conn As SqlConnection = New SqlConnection("Data Source=HARRY-PAVILION\SQLEXPRESS;Initial Catalog=Chess_Trainer;Integrated Security=True")

    Public Function ExecuteStatement(ByVal conn As SqlConnection, strStatement As String)
        Dim outcome As Boolean
        Dim rows As Integer

        outcome = False

        Dim db_command As New SqlCommand(strStatement, conn)
        rows = db_command.ExecuteNonQuery()

        If (rows > 0) Then
            outcome = True
        Else
            Return outcome
        End If

    End Function

    Public Function Open_Connection()
        conn.Open()
        Return conn
    End Function

    Public Function Close_Connection(ByVal conn As SqlConnection)
        conn.Close()
        Return conn
    End Function

    Public Function IsConnectionOpen()
        If conn.State = ConnectionState.Open Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
