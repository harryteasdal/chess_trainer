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
        Me.lblMobile = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.lblForename = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.cmbUser = New System.Windows.Forms.ComboBox()
        Me.UserList = New System.Windows.Forms.StatusStrip()
        Me.UserCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.grpUserDetails.SuspendLayout()
        Me.UserList.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpUserDetails
        '
        Me.grpUserDetails.BackgroundImage = Global.Chess_Trainer.My.Resources.Resources.UserDetailsGroup
        Me.grpUserDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.grpUserDetails.Controls.Add(Me.lblMobile)
        Me.grpUserDetails.Controls.Add(Me.lblEmail)
        Me.grpUserDetails.Controls.Add(Me.lblSurname)
        Me.grpUserDetails.Controls.Add(Me.lblForename)
        Me.grpUserDetails.Controls.Add(Me.lblUser)
        Me.grpUserDetails.Controls.Add(Me.cmbUser)
        Me.grpUserDetails.Location = New System.Drawing.Point(31, 33)
        Me.grpUserDetails.Name = "grpUserDetails"
        Me.grpUserDetails.Size = New System.Drawing.Size(725, 352)
        Me.grpUserDetails.TabIndex = 0
        Me.grpUserDetails.TabStop = False
        Me.grpUserDetails.Text = "User"
        '
        'lblMobile
        '
        Me.lblMobile.AutoSize = True
        Me.lblMobile.Location = New System.Drawing.Point(188, 285)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.Size = New System.Drawing.Size(55, 20)
        Me.lblMobile.TabIndex = 5
        Me.lblMobile.Text = "Mobile"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(188, 221)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(48, 20)
        Me.lblEmail.TabIndex = 4
        Me.lblEmail.Text = "Email"
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Location = New System.Drawing.Point(188, 163)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(74, 20)
        Me.lblSurname.TabIndex = 3
        Me.lblSurname.Text = "Surname"
        '
        'lblForename
        '
        Me.lblForename.AutoSize = True
        Me.lblForename.Location = New System.Drawing.Point(192, 92)
        Me.lblForename.Name = "lblForename"
        Me.lblForename.Size = New System.Drawing.Size(82, 20)
        Me.lblForename.TabIndex = 2
        Me.lblForename.Text = "Forename"
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
        'cmbUser
        '
        Me.cmbUser.FormattingEnabled = True
        Me.cmbUser.Location = New System.Drawing.Point(192, 25)
        Me.cmbUser.Name = "cmbUser"
        Me.cmbUser.Size = New System.Drawing.Size(290, 28)
        Me.cmbUser.TabIndex = 0
        '
        'UserList
        '
        Me.UserList.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.UserList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserCount})
        Me.UserList.Location = New System.Drawing.Point(0, 499)
        Me.UserList.Name = "UserList"
        Me.UserList.Size = New System.Drawing.Size(1184, 32)
        Me.UserList.TabIndex = 1
        Me.UserList.Text = "StatusStrip1"
        '
        'UserCount
        '
        Me.UserCount.Name = "UserCount"
        Me.UserCount.Size = New System.Drawing.Size(180, 25)
        Me.UserCount.Text = "ToolStripStatusLabel1"
        '
        'UserDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Chess_Trainer.My.Resources.Resources.UserDetails
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1184, 531)
        Me.Controls.Add(Me.UserList)
        Me.Controls.Add(Me.grpUserDetails)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UserDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.grpUserDetails.ResumeLayout(False)
        Me.grpUserDetails.PerformLayout()
        Me.UserList.ResumeLayout(False)
        Me.UserList.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpUserDetails As GroupBox
    Friend WithEvents lblUser As Label
    Friend WithEvents cmbUser As ComboBox
    Friend WithEvents lblForename As Label
    Friend WithEvents lblSurname As Label
    Friend WithEvents lblMobile As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents UserList As StatusStrip
    Friend WithEvents UserCount As ToolStripStatusLabel
End Class
