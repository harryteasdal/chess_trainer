Imports Microsoft.VisualBasic

Imports System.data.SqlCLient


Public Class DatabaseAccess

    Dim conn As sqlconnection = New sqlconnection("Data Source=HARRY-PAVILION\SQLEXPRESS;Initial Catalog=Chess_Trainer;Integrated Security=True")

    Public Function ExecuteStatement(ByVal conn As sqlconnection, strStatement As String)
        Dim db_command As New sqlcommand(strStatement, conn)
        Return db_command
    End Function

    Sub Open_Connection(ByVal conn As sqlconnection)
        conn.Open_Connection()
    End Sub

    Sub Close_Connection(ByVal conn As sqlconnection)

    End Sub


End Class
