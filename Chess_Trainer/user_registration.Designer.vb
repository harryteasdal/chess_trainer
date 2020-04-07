<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Register
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Txt_FirstName = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Lbl_Firstname = New System.Windows.Forms.Label()
        Me.Txt_Surname = New System.Windows.Forms.TextBox()
        Me.lbl_Surname = New System.Windows.Forms.Label()
        Me.lbl_Rank = New System.Windows.Forms.Label()
        Me.Txt_Rank = New System.Windows.Forms.TextBox()
        Me.Lbl_MobileNumber = New System.Windows.Forms.Label()
        Me.Txt_Mobile_Number = New System.Windows.Forms.TextBox()
        Me.Lbl_Email = New System.Windows.Forms.Label()
        Me.Txt_Email = New System.Windows.Forms.TextBox()
        Me.lbl_Country = New System.Windows.Forms.Label()
        Me.cmb_country = New System.Windows.Forms.ComboBox()
        Me.Btn_AddUser = New System.Windows.Forms.Button()
        Me.Btn_Delete = New System.Windows.Forms.Button()
        Me.Btn_Return = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Txt_FirstName
        '
        Me.Txt_FirstName.Location = New System.Drawing.Point(144, 18)
        Me.Txt_FirstName.Name = "Txt_FirstName"
        Me.Txt_FirstName.Size = New System.Drawing.Size(189, 26)
        Me.Txt_FirstName.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Lbl_Firstname
        '
        Me.Lbl_Firstname.AutoSize = True
        Me.Lbl_Firstname.Location = New System.Drawing.Point(14, 18)
        Me.Lbl_Firstname.Name = "Lbl_Firstname"
        Me.Lbl_Firstname.Size = New System.Drawing.Size(80, 20)
        Me.Lbl_Firstname.TabIndex = 2
        Me.Lbl_Firstname.Text = "Firstname"
        '
        'Txt_Surname
        '
        Me.Txt_Surname.Location = New System.Drawing.Point(144, 69)
        Me.Txt_Surname.Name = "Txt_Surname"
        Me.Txt_Surname.Size = New System.Drawing.Size(189, 26)
        Me.Txt_Surname.TabIndex = 1
        '
        'lbl_Surname
        '
        Me.lbl_Surname.AutoSize = True
        Me.lbl_Surname.Location = New System.Drawing.Point(14, 69)
        Me.lbl_Surname.Name = "lbl_Surname"
        Me.lbl_Surname.Size = New System.Drawing.Size(74, 20)
        Me.lbl_Surname.TabIndex = 4
        Me.lbl_Surname.Text = "Surname"
        '
        'lbl_Rank
        '
        Me.lbl_Rank.AutoSize = True
        Me.lbl_Rank.Location = New System.Drawing.Point(390, 69)
        Me.lbl_Rank.Name = "lbl_Rank"
        Me.lbl_Rank.Size = New System.Drawing.Size(47, 20)
        Me.lbl_Rank.TabIndex = 5
        Me.lbl_Rank.Text = "Rank"
        '
        'Txt_Rank
        '
        Me.Txt_Rank.Location = New System.Drawing.Point(485, 69)
        Me.Txt_Rank.Name = "Txt_Rank"
        Me.Txt_Rank.Size = New System.Drawing.Size(189, 26)
        Me.Txt_Rank.TabIndex = 6
        '
        'Lbl_MobileNumber
        '
        Me.Lbl_MobileNumber.AutoSize = True
        Me.Lbl_MobileNumber.Location = New System.Drawing.Point(14, 131)
        Me.Lbl_MobileNumber.Name = "Lbl_MobileNumber"
        Me.Lbl_MobileNumber.Size = New System.Drawing.Size(115, 20)
        Me.Lbl_MobileNumber.TabIndex = 7
        Me.Lbl_MobileNumber.Text = "Mobile Number"
        '
        'Txt_Mobile_Number
        '
        Me.Txt_Mobile_Number.Location = New System.Drawing.Point(144, 125)
        Me.Txt_Mobile_Number.Name = "Txt_Mobile_Number"
        Me.Txt_Mobile_Number.Size = New System.Drawing.Size(189, 26)
        Me.Txt_Mobile_Number.TabIndex = 2
        '
        'Lbl_Email
        '
        Me.Lbl_Email.AutoSize = True
        Me.Lbl_Email.Location = New System.Drawing.Point(390, 131)
        Me.Lbl_Email.Name = "Lbl_Email"
        Me.Lbl_Email.Size = New System.Drawing.Size(48, 20)
        Me.Lbl_Email.TabIndex = 9
        Me.Lbl_Email.Text = "Email"
        '
        'Txt_Email
        '
        Me.Txt_Email.Location = New System.Drawing.Point(485, 125)
        Me.Txt_Email.Name = "Txt_Email"
        Me.Txt_Email.Size = New System.Drawing.Size(189, 26)
        Me.Txt_Email.TabIndex = 10
        '
        'lbl_Country
        '
        Me.lbl_Country.AutoSize = True
        Me.lbl_Country.Location = New System.Drawing.Point(390, 24)
        Me.lbl_Country.Name = "lbl_Country"
        Me.lbl_Country.Size = New System.Drawing.Size(64, 20)
        Me.lbl_Country.TabIndex = 11
        Me.lbl_Country.Text = "Country"
        '
        'cmb_country
        '
        Me.cmb_country.FormattingEnabled = True
        Me.cmb_country.Location = New System.Drawing.Point(485, 18)
        Me.cmb_country.Name = "cmb_country"
        Me.cmb_country.Size = New System.Drawing.Size(189, 28)
        Me.cmb_country.TabIndex = 12
        '
        'Btn_AddUser
        '
        Me.Btn_AddUser.Location = New System.Drawing.Point(18, 206)
        Me.Btn_AddUser.Name = "Btn_AddUser"
        Me.Btn_AddUser.Size = New System.Drawing.Size(126, 79)
        Me.Btn_AddUser.TabIndex = 13
        Me.Btn_AddUser.Text = "Add"
        Me.Btn_AddUser.UseVisualStyleBackColor = True
        '
        'Btn_Delete
        '
        Me.Btn_Delete.Location = New System.Drawing.Point(150, 206)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.Size = New System.Drawing.Size(126, 79)
        Me.Btn_Delete.TabIndex = 14
        Me.Btn_Delete.Text = "Delete"
        Me.Btn_Delete.UseVisualStyleBackColor = True
        '
        'Btn_Return
        '
        Me.Btn_Return.Location = New System.Drawing.Point(282, 206)
        Me.Btn_Return.Name = "Btn_Return"
        Me.Btn_Return.Size = New System.Drawing.Size(126, 79)
        Me.Btn_Return.TabIndex = 15
        Me.Btn_Return.Text = "Return"
        Me.Btn_Return.UseVisualStyleBackColor = True
        '
        'Frm_Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 416)
        Me.Controls.Add(Me.Btn_Return)
        Me.Controls.Add(Me.Btn_Delete)
        Me.Controls.Add(Me.Btn_AddUser)
        Me.Controls.Add(Me.cmb_country)
        Me.Controls.Add(Me.lbl_Country)
        Me.Controls.Add(Me.Txt_Email)
        Me.Controls.Add(Me.Lbl_Email)
        Me.Controls.Add(Me.Txt_Mobile_Number)
        Me.Controls.Add(Me.Lbl_MobileNumber)
        Me.Controls.Add(Me.Txt_Rank)
        Me.Controls.Add(Me.lbl_Rank)
        Me.Controls.Add(Me.lbl_Surname)
        Me.Controls.Add(Me.Txt_Surname)
        Me.Controls.Add(Me.Lbl_Firstname)
        Me.Controls.Add(Me.Txt_FirstName)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Register"
        Me.Text = "Registration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_FirstName As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Lbl_Firstname As Label
    Friend WithEvents Txt_Surname As TextBox
    Friend WithEvents lbl_Surname As Label
    Friend WithEvents lbl_Rank As Label
    Friend WithEvents Txt_Rank As TextBox
    Friend WithEvents Lbl_MobileNumber As Label
    Friend WithEvents Txt_Mobile_Number As TextBox
    Friend WithEvents Lbl_Email As Label
    Friend WithEvents Txt_Email As TextBox
    Friend WithEvents lbl_Country As Label
    Friend WithEvents cmb_country As ComboBox
    Friend WithEvents Btn_AddUser As Button
    Friend WithEvents Btn_Delete As Button
    Friend WithEvents Btn_Return As Button
End Class
