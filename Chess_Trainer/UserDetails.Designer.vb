<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpUserDetails = New System.Windows.Forms.GroupBox()
        Me.cmbUser = New System.Windows.Forms.ComboBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.grpUserDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpUserDetails
        '
        Me.grpUserDetails.BackgroundImage = Global.Chess_Trainer.My.Resources.Resources.UserDetailsGroup
        Me.grpUserDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.grpUserDetails.Controls.Add(Me.lblUser)
        Me.grpUserDetails.Controls.Add(Me.cmbUser)
        Me.grpUserDetails.Location = New System.Drawing.Point(31, 33)
        Me.grpUserDetails.Name = "grpUserDetails"
        Me.grpUserDetails.Size = New System.Drawing.Size(508, 352)
        Me.grpUserDetails.TabIndex = 0
        Me.grpUserDetails.TabStop = False
        Me.grpUserDetails.Text = "User"
        '
        'cmbUser
        '
        Me.cmbUser.FormattingEnabled = True
        Me.cmbUser.Location = New System.Drawing.Point(192, 25)
        Me.cmbUser.Name = "cmbUser"
        Me.cmbUser.Size = New System.Drawing.Size(290, 28)
        Me.cmbUser.TabIndex = 0
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(34, 33)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(43, 20)
        Me.lblUser.TabIndex = 1
        Me.lblUser.Text = "User"
        '
        'UserDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Chess_Trainer.My.Resources.Resources.UserDetails
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(977, 450)
        Me.Controls.Add(Me.grpUserDetails)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UserDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Details"
        Me.grpUserDetails.ResumeLayout(False)
        Me.grpUserDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpUserDetails As GroupBox
    Friend WithEvents lblUser As Label
    Friend WithEvents cmbUser As ComboBox
End Class
