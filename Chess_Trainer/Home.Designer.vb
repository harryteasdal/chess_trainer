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
        Me.PredictToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PredictToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerformanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewUserToolStripMenuItem, Me.PredictToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NewUserToolStripMenuItem
        '
        Me.NewUserToolStripMenuItem.Name = "NewUserToolStripMenuItem"
        Me.NewUserToolStripMenuItem.Size = New System.Drawing.Size(108, 29)
        Me.NewUserToolStripMenuItem.Text = "New User "
        '
        'PredictToolStripMenuItem
        '
        Me.PredictToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PredictToolStripMenuItem1, Me.PerformanceToolStripMenuItem})
        Me.PredictToolStripMenuItem.Name = "PredictToolStripMenuItem"
        Me.PredictToolStripMenuItem.Size = New System.Drawing.Size(103, 29)
        Me.PredictToolStripMenuItem.Text = "Analytics "
        '
        'PredictToolStripMenuItem1
        '
        Me.PredictToolStripMenuItem1.Name = "PredictToolStripMenuItem1"
        Me.PredictToolStripMenuItem1.Size = New System.Drawing.Size(218, 34)
        Me.PredictToolStripMenuItem1.Text = "Predict "
        '
        'PerformanceToolStripMenuItem
        '
        Me.PerformanceToolStripMenuItem.Name = "PerformanceToolStripMenuItem"
        Me.PerformanceToolStripMenuItem.Size = New System.Drawing.Size(218, 34)
        Me.PerformanceToolStripMenuItem.Text = "Performance "
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(60, 29)
        Me.ExitToolStripMenuItem.Text = "Exit "
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(336, 189)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(241, 144)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Frm_home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Frm_home"
        Me.Text = "Home"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
    Friend WithEvents Button1 As Button
End Class
