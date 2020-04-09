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
        Me.lblPlayer2 = New System.Windows.Forms.Label()
        Me.lblPlayer1 = New System.Windows.Forms.Label()
        Me.cmbPlayer2 = New System.Windows.Forms.ComboBox()
        Me.cmbPlayer1 = New System.Windows.Forms.ComboBox()
        Me.btnGetPrediction = New System.Windows.Forms.Button()
        Me.btnSavePrediction = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.Chess_Trainer.My.Resources.Resources.UserGroup2
        Me.GroupBox1.Controls.Add(Me.lblResult)
        Me.GroupBox1.Controls.Add(Me.lblPlayer2)
        Me.GroupBox1.Controls.Add(Me.lblPlayer1)
        Me.GroupBox1.Controls.Add(Me.cmbPlayer2)
        Me.GroupBox1.Controls.Add(Me.cmbPlayer1)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 21)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(743, 157)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Details"
        '
        'lblPlayer2
        '
        Me.lblPlayer2.AutoSize = True
        Me.lblPlayer2.Location = New System.Drawing.Point(16, 68)
        Me.lblPlayer2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPlayer2.Name = "lblPlayer2"
        Me.lblPlayer2.Size = New System.Drawing.Size(45, 13)
        Me.lblPlayer2.TabIndex = 3
        Me.lblPlayer2.Text = "Player 2"
        '
        'lblPlayer1
        '
        Me.lblPlayer1.AutoSize = True
        Me.lblPlayer1.Location = New System.Drawing.Point(16, 39)
        Me.lblPlayer1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPlayer1.Name = "lblPlayer1"
        Me.lblPlayer1.Size = New System.Drawing.Size(45, 13)
        Me.lblPlayer1.TabIndex = 2
        Me.lblPlayer1.Text = "Player 1"
        '
        'cmbPlayer2
        '
        Me.cmbPlayer2.FormattingEnabled = True
        Me.cmbPlayer2.Location = New System.Drawing.Point(75, 66)
        Me.cmbPlayer2.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbPlayer2.Name = "cmbPlayer2"
        Me.cmbPlayer2.Size = New System.Drawing.Size(173, 21)
        Me.cmbPlayer2.TabIndex = 1
        '
        'cmbPlayer1
        '
        Me.cmbPlayer1.FormattingEnabled = True
        Me.cmbPlayer1.Location = New System.Drawing.Point(75, 37)
        Me.cmbPlayer1.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbPlayer1.Name = "cmbPlayer1"
        Me.cmbPlayer1.Size = New System.Drawing.Size(173, 21)
        Me.cmbPlayer1.TabIndex = 0
        '
        'btnGetPrediction
        '
        Me.btnGetPrediction.Location = New System.Drawing.Point(489, 292)
        Me.btnGetPrediction.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGetPrediction.Name = "btnGetPrediction"
        Me.btnGetPrediction.Size = New System.Drawing.Size(108, 35)
        Me.btnGetPrediction.TabIndex = 1
        Me.btnGetPrediction.Text = "Get Prediction"
        Me.btnGetPrediction.UseVisualStyleBackColor = True
        '
        'btnSavePrediction
        '
        Me.btnSavePrediction.Location = New System.Drawing.Point(640, 292)
        Me.btnSavePrediction.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSavePrediction.Name = "btnSavePrediction"
        Me.btnSavePrediction.Size = New System.Drawing.Size(119, 35)
        Me.btnSavePrediction.TabIndex = 2
        Me.btnSavePrediction.Text = "Save Prediction"
        Me.btnSavePrediction.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(72, 103)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(0, 13)
        Me.lblResult.TabIndex = 4
        '
        'PredictionGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Chess_Trainer.My.Resources.Resources.Predictions
        Me.ClientSize = New System.Drawing.Size(777, 341)
        Me.Controls.Add(Me.btnSavePrediction)
        Me.Controls.Add(Me.btnGetPrediction)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
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
    Friend WithEvents lblResult As Label
End Class
