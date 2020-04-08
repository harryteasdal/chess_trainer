<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PredictionGenerator
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbPlayer1 = New System.Windows.Forms.ComboBox()
        Me.cmbPlayer2 = New System.Windows.Forms.ComboBox()
        Me.lblPlayer1 = New System.Windows.Forms.Label()
        Me.lblPlayer2 = New System.Windows.Forms.Label()
        Me.btnGetPrediction = New System.Windows.Forms.Button()
        Me.btnSavePrediction = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.Chess_Trainer.My.Resources.Resources.UserGroup2
        Me.GroupBox1.Controls.Add(Me.lblPlayer2)
        Me.GroupBox1.Controls.Add(Me.lblPlayer1)
        Me.GroupBox1.Controls.Add(Me.cmbPlayer2)
        Me.GroupBox1.Controls.Add(Me.cmbPlayer1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1115, 242)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Details"
        '
        'cmbPlayer1
        '
        Me.cmbPlayer1.FormattingEnabled = True
        Me.cmbPlayer1.Location = New System.Drawing.Point(112, 57)
        Me.cmbPlayer1.Name = "cmbPlayer1"
        Me.cmbPlayer1.Size = New System.Drawing.Size(257, 28)
        Me.cmbPlayer1.TabIndex = 0
        '
        'cmbPlayer2
        '
        Me.cmbPlayer2.FormattingEnabled = True
        Me.cmbPlayer2.Location = New System.Drawing.Point(112, 102)
        Me.cmbPlayer2.Name = "cmbPlayer2"
        Me.cmbPlayer2.Size = New System.Drawing.Size(257, 28)
        Me.cmbPlayer2.TabIndex = 1
        '
        'lblPlayer1
        '
        Me.lblPlayer1.AutoSize = True
        Me.lblPlayer1.Location = New System.Drawing.Point(24, 60)
        Me.lblPlayer1.Name = "lblPlayer1"
        Me.lblPlayer1.Size = New System.Drawing.Size(65, 20)
        Me.lblPlayer1.TabIndex = 2
        Me.lblPlayer1.Text = "Player 1"
        '
        'lblPlayer2
        '
        Me.lblPlayer2.AutoSize = True
        Me.lblPlayer2.Location = New System.Drawing.Point(24, 105)
        Me.lblPlayer2.Name = "lblPlayer2"
        Me.lblPlayer2.Size = New System.Drawing.Size(65, 20)
        Me.lblPlayer2.TabIndex = 3
        Me.lblPlayer2.Text = "Player 2"
        '
        'btnGetPrediction
        '
        Me.btnGetPrediction.Location = New System.Drawing.Point(734, 449)
        Me.btnGetPrediction.Name = "btnGetPrediction"
        Me.btnGetPrediction.Size = New System.Drawing.Size(162, 54)
        Me.btnGetPrediction.TabIndex = 1
        Me.btnGetPrediction.Text = "Get Prediction"
        Me.btnGetPrediction.UseVisualStyleBackColor = True
        '
        'btnSavePrediction
        '
        Me.btnSavePrediction.Location = New System.Drawing.Point(960, 449)
        Me.btnSavePrediction.Name = "btnSavePrediction"
        Me.btnSavePrediction.Size = New System.Drawing.Size(178, 54)
        Me.btnSavePrediction.TabIndex = 2
        Me.btnSavePrediction.Text = "Save Prediction"
        Me.btnSavePrediction.UseVisualStyleBackColor = True
        '
        'PredictionGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Chess_Trainer.My.Resources.Resources.Predictions
        Me.ClientSize = New System.Drawing.Size(1166, 525)
        Me.Controls.Add(Me.btnSavePrediction)
        Me.Controls.Add(Me.btnGetPrediction)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PredictionGenerator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PredictionGenerator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblPlayer1 As Label
    Friend WithEvents cmbPlayer2 As ComboBox
    Friend WithEvents cmbPlayer1 As ComboBox
    Friend WithEvents lblPlayer2 As Label
    Friend WithEvents btnGetPrediction As Button
    Friend WithEvents btnSavePrediction As Button
End Class
