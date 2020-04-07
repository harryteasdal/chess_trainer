<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Main_Menu
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
        Me.Btn_Register = New System.Windows.Forms.Button()
        Me.Btn_Close = New System.Windows.Forms.Button()
        Me.Btn_Prediction = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_Register
        '
        Me.Btn_Register.Location = New System.Drawing.Point(44, 31)
        Me.Btn_Register.Name = "Btn_Register"
        Me.Btn_Register.Size = New System.Drawing.Size(141, 90)
        Me.Btn_Register.TabIndex = 0
        Me.Btn_Register.Text = "Register "
        Me.Btn_Register.UseVisualStyleBackColor = True
        '
        'Btn_Close
        '
        Me.Btn_Close.Location = New System.Drawing.Point(44, 127)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(141, 90)
        Me.Btn_Close.TabIndex = 1
        Me.Btn_Close.Text = "Exit"
        Me.Btn_Close.UseVisualStyleBackColor = True
        '
        'Btn_Prediction
        '
        Me.Btn_Prediction.Location = New System.Drawing.Point(44, 223)
        Me.Btn_Prediction.Name = "Btn_Prediction"
        Me.Btn_Prediction.Size = New System.Drawing.Size(141, 90)
        Me.Btn_Prediction.TabIndex = 2
        Me.Btn_Prediction.Text = "Predict "
        Me.Btn_Prediction.UseVisualStyleBackColor = True
        '
        'Frm_Main_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btn_Prediction)
        Me.Controls.Add(Me.Btn_Close)
        Me.Controls.Add(Me.Btn_Register)
        Me.Name = "Frm_Main_Menu"
        Me.Text = "Main_Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_Register As Button
    Friend WithEvents Btn_Close As Button
    Friend WithEvents Btn_Prediction As Button
End Class
