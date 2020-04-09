<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_home
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NewUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PredictToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PredictToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerformanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HomeFooter = New System.Windows.Forms.StatusStrip()
        Me.DbStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.HomeFooter.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewUserToolStripMenuItem, Me.PredictToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(853, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NewUserToolStripMenuItem
        '
        Me.NewUserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddUserToolStripMenuItem, Me.DeleteUserToolStripMenuItem, Me.ChangePasswordToolStripMenuItem, Me.GetUserToolStripMenuItem})
        Me.NewUserToolStripMenuItem.Name = "NewUserToolStripMenuItem"
        Me.NewUserToolStripMenuItem.Size = New System.Drawing.Size(47, 22)
        Me.NewUserToolStripMenuItem.Text = "Users"
        '
        'AddUserToolStripMenuItem
        '
        Me.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem"
        Me.AddUserToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AddUserToolStripMenuItem.Text = "Add User"
        '
        'DeleteUserToolStripMenuItem
        '
        Me.DeleteUserToolStripMenuItem.Name = "DeleteUserToolStripMenuItem"
        Me.DeleteUserToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DeleteUserToolStripMenuItem.Text = "Delete User"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'GetUserToolStripMenuItem
        '
        Me.GetUserToolStripMenuItem.Name = "GetUserToolStripMenuItem"
        Me.GetUserToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GetUserToolStripMenuItem.Text = "Get User"
        '
        'PredictToolStripMenuItem
        '
        Me.PredictToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PredictToolStripMenuItem1, Me.PerformanceToolStripMenuItem})
        Me.PredictToolStripMenuItem.Name = "PredictToolStripMenuItem"
        Me.PredictToolStripMenuItem.Size = New System.Drawing.Size(70, 22)
        Me.PredictToolStripMenuItem.Text = "Analytics "
        '
        'PredictToolStripMenuItem1
        '
        Me.PredictToolStripMenuItem1.Name = "PredictToolStripMenuItem1"
        Me.PredictToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.PredictToolStripMenuItem1.Text = "Predict "
        '
        'PerformanceToolStripMenuItem
        '
        Me.PerformanceToolStripMenuItem.Name = "PerformanceToolStripMenuItem"
        Me.PerformanceToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PerformanceToolStripMenuItem.Text = "Performance "
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(40, 22)
        Me.ExitToolStripMenuItem.Text = "Exit "
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'HomeFooter
        '
        Me.HomeFooter.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.HomeFooter.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DbStatus})
        Me.HomeFooter.Location = New System.Drawing.Point(0, 270)
        Me.HomeFooter.Name = "HomeFooter"
        Me.HomeFooter.Padding = New System.Windows.Forms.Padding(1, 0, 9, 0)
        Me.HomeFooter.Size = New System.Drawing.Size(853, 22)
        Me.HomeFooter.TabIndex = 1
        Me.HomeFooter.Text = "StatusStrip1"
        '
        'DbStatus
        '
        Me.DbStatus.Name = "DbStatus"
        Me.DbStatus.Size = New System.Drawing.Size(120, 17)
        Me.DbStatus.Text = "ToolStripStatusLabel1"
        '
        'Frm_home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Chess_Trainer.My.Resources.Resources.Main
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(853, 292)
        Me.Controls.Add(Me.HomeFooter)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chess Trainer"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.HomeFooter.ResumeLayout(False)
        Me.HomeFooter.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NewUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PredictToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PredictToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PerformanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents AddUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HomeFooter As StatusStrip
    Friend WithEvents DbStatus As ToolStripStatusLabel
    Friend WithEvents GetUserToolStripMenuItem As ToolStripMenuItem
End Class
