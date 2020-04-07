<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Prediction
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cmb_PlayerA = New System.Windows.Forms.ComboBox()
        Me.Cmb_PlayerB = New System.Windows.Forms.ComboBox()
        Me.btn_predict = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Player Name "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(266, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Player Name "
        '
        'Cmb_PlayerA
        '
        Me.Cmb_PlayerA.FormattingEnabled = True
        Me.Cmb_PlayerA.Location = New System.Drawing.Point(120, 36)
        Me.Cmb_PlayerA.Name = "Cmb_PlayerA"
        Me.Cmb_PlayerA.Size = New System.Drawing.Size(121, 28)
        Me.Cmb_PlayerA.TabIndex = 3
        '
        'Cmb_PlayerB
        '
        Me.Cmb_PlayerB.FormattingEnabled = True
        Me.Cmb_PlayerB.Location = New System.Drawing.Point(374, 36)
        Me.Cmb_PlayerB.Name = "Cmb_PlayerB"
        Me.Cmb_PlayerB.Size = New System.Drawing.Size(121, 28)
        Me.Cmb_PlayerB.TabIndex = 4
        '
        'btn_predict
        '
        Me.btn_predict.Location = New System.Drawing.Point(67, 178)
        Me.btn_predict.Name = "btn_predict"
        Me.btn_predict.Size = New System.Drawing.Size(113, 54)
        Me.btn_predict.TabIndex = 5
        Me.btn_predict.Text = "Predict"
        Me.btn_predict.UseVisualStyleBackColor = True
        '
        'Frm_Prediction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_predict)
        Me.Controls.Add(Me.Cmb_PlayerB)
        Me.Controls.Add(Me.Cmb_PlayerA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frm_Prediction"
        Me.Text = "Prediction"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Cmb_PlayerA As ComboBox
    Friend WithEvents Cmb_PlayerB As ComboBox
    Friend WithEvents btn_predict As Button
End Class
