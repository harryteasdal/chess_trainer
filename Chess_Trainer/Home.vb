'Purpose: Launch Form of the Application
'Created: Harry Teasdale
'Comments:
'Version: 1.0
Imports System.Data.SqlClient
Public Class Frm_home
    'Purpose: Holds Database access library reference
    '         and the Connection that is passed to other forms
    'Created: Harry Teasdale
    'Comments: Returns the Id of the user
    Dim dbAccess As DatabaseAccess
    Dim conn As SqlConnection
    'Purpose: Launches application
    'Created: Harry Teasdale
    'Comments: Retrieves and tests database connection
    'Version: 1.0
    Private Sub Frm_home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbAccess = New DatabaseAccess
        Try
            conn = dbAccess.Open_Connection()
            If (conn.State <> ConnectionState.Open) Then
                DbStatus.Text = "Not Connected"
            Else
                DbStatus.Text = "Connected"
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    'Purpose: Checks that the database connection is open
    'Created: Harry Teasdale
    'Comments: Shows message box if connection is not open
    'Version: 1.0
    Private Sub GetUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetUserToolStripMenuItem.Click
        Try
            If (conn.State = ConnectionState.Open) Then
                UserDetails.dbConn = conn
                UserDetails.Show()
            Else
                MessageBox.Show(
                    "Lost Database Connection",
                    "Chess Trainer Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AddUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUserToolStripMenuItem.Click
        'Purpose: Checks that the database connection is open
        'Created: Harry Teasdale
        'Comments: Shows message box if connection is not open
        'Version: 1.0
        If (conn.State = ConnectionState.Open) Then
            Frm_Register.dbConn = conn
            Frm_Register.Show()
        Else
            MessageBox.Show(
                "Lost Database Connection",
                "Chess Trainer Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub PredictToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PredictToolStripMenuItem1.Click
        PredictionGenerator.dbConn = conn
        PredictionGenerator.Show()
    End Sub
End Class