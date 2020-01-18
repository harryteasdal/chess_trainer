<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
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
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Txt_FirstName
        '
        Me.Txt_FirstName.Location = New System.Drawing.Point(200, 99)
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
        Me.Lbl_Firstname.Location = New System.Drawing.Point(14, 99)
        Me.Lbl_Firstname.Name = "Lbl_Firstname"
        Me.Lbl_Firstname.Size = New System.Drawing.Size(80, 20)
        Me.Lbl_Firstname.TabIndex = 2
        Me.Lbl_Firstname.Text = "Firstname"
        '
        'Txt_Surname
        '
        Me.Txt_Surname.Location = New System.Drawing.Point(200, 157)
        Me.Txt_Surname.Name = "Txt_Surname"
        Me.Txt_Surname.Size = New System.Drawing.Size(189, 26)
        Me.Txt_Surname.TabIndex = 3
        '
        'lbl_Surname
        '
        Me.lbl_Surname.AutoSize = True
        Me.lbl_Surname.Location = New System.Drawing.Point(14, 163)
        Me.lbl_Surname.Name = "lbl_Surname"
        Me.lbl_Surname.Size = New System.Drawing.Size(74, 20)
        Me.lbl_Surname.TabIndex = 4
        Me.lbl_Surname.Text = "Surname"
        '
        'lbl_Rank
        '
        Me.lbl_Rank.AutoSize = True
        Me.lbl_Rank.Location = New System.Drawing.Point(429, 163)
        Me.lbl_Rank.Name = "lbl_Rank"
        Me.lbl_Rank.Size = New System.Drawing.Size(47, 20)
        Me.lbl_Rank.TabIndex = 5
        Me.lbl_Rank.Text = "Rank"
        '
        'Txt_Rank
        '
        Me.Txt_Rank.Location = New System.Drawing.Point(538, 160)
        Me.Txt_Rank.Name = "Txt_Rank"
        Me.Txt_Rank.Size = New System.Drawing.Size(189, 26)
        Me.Txt_Rank.TabIndex = 6
        '
        'Lbl_MobileNumber
        '
        Me.Lbl_MobileNumber.AutoSize = True
        Me.Lbl_MobileNumber.Location = New System.Drawing.Point(14, 233)
        Me.Lbl_MobileNumber.Name = "Lbl_MobileNumber"
        Me.Lbl_MobileNumber.Size = New System.Drawing.Size(115, 20)
        Me.Lbl_MobileNumber.TabIndex = 7
        Me.Lbl_MobileNumber.Text = "Mobile Number"
        '
        'Txt_Mobile_Number
        '
        Me.Txt_Mobile_Number.Location = New System.Drawing.Point(200, 227)
        Me.Txt_Mobile_Number.Name = "Txt_Mobile_Number"
        Me.Txt_Mobile_Number.Size = New System.Drawing.Size(189, 26)
        Me.Txt_Mobile_Number.TabIndex = 8
        '
        'Lbl_Email
        '
        Me.Lbl_Email.AutoSize = True
        Me.Lbl_Email.Location = New System.Drawing.Point(429, 233)
        Me.Lbl_Email.Name = "Lbl_Email"
        Me.Lbl_Email.Size = New System.Drawing.Size(48, 20)
        Me.Lbl_Email.TabIndex = 9
        Me.Lbl_Email.Text = "Email"
        '
        'Txt_Email
        '
        Me.Txt_Email.Location = New System.Drawing.Point(538, 230)
        Me.Txt_Email.Name = "Txt_Email"
        Me.Txt_Email.Size = New System.Drawing.Size(189, 26)
        Me.Txt_Email.TabIndex = 10
        '
        'lbl_Country
        '
        Me.lbl_Country.AutoSize = True
        Me.lbl_Country.Location = New System.Drawing.Point(429, 102)
        Me.lbl_Country.Name = "lbl_Country"
        Me.lbl_Country.Size = New System.Drawing.Size(64, 20)
        Me.lbl_Country.TabIndex = 11
        Me.lbl_Country.Text = "Country"
        '
        'cmb_country
        '
        Me.cmb_country.FormattingEnabled = True
        Me.cmb_country.Location = New System.Drawing.Point(538, 99)
        Me.cmb_country.Name = "cmb_country"
        Me.cmb_country.Size = New System.Drawing.Size(189, 28)
        Me.cmb_country.TabIndex = 12
        '
        'Btn_AddUser
        '
        Me.Btn_AddUser.Location = New System.Drawing.Point(12, 394)
        Me.Btn_AddUser.Name = "Btn_AddUser"
        Me.Btn_AddUser.Size = New System.Drawing.Size(126, 79)
        Me.Btn_AddUser.TabIndex = 13
        Me.Btn_AddUser.Text = "Add"
        Me.Btn_AddUser.UseVisualStyleBackColor = True
        '
        'Btn_Delete
        '
        Me.Btn_Delete.Location = New System.Drawing.Point(144, 394)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.Size = New System.Drawing.Size(126, 79)
        Me.Btn_Delete.TabIndex = 14
        Me.Btn_Delete.Text = "Delete"
        Me.Btn_Delete.UseVisualStyleBackColor = True
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(1052, 33)
        Me.BindingNavigator1.TabIndex = 15
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(54, 28)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 33)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 33)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 33)
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1052, 485)
        Me.Controls.Add(Me.BindingNavigator1)
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
        Me.Name = "Register"
        Me.Text = "Registration"
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
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
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
End Class
