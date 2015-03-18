<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.grpLight = New System.Windows.Forms.GroupBox()
        Me.radGreen = New System.Windows.Forms.RadioButton()
        Me.radYellow = New System.Windows.Forms.RadioButton()
        Me.radRed = New System.Windows.Forms.RadioButton()
        Me.grpAdvice = New System.Windows.Forms.GroupBox()
        Me.chkPolice = New System.Windows.Forms.CheckBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lblAdvice = New System.Windows.Forms.Label()
        Me.btnAdvice = New System.Windows.Forms.Button()
        Me.grpLight.SuspendLayout()
        Me.grpAdvice.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpLight
        '
        Me.grpLight.Controls.Add(Me.chkPolice)
        Me.grpLight.Controls.Add(Me.radGreen)
        Me.grpLight.Controls.Add(Me.radYellow)
        Me.grpLight.Controls.Add(Me.radRed)
        Me.grpLight.Location = New System.Drawing.Point(38, 12)
        Me.grpLight.Name = "grpLight"
        Me.grpLight.Size = New System.Drawing.Size(385, 184)
        Me.grpLight.TabIndex = 0
        Me.grpLight.TabStop = False
        Me.grpLight.Text = "Light"
        '
        'radGreen
        '
        Me.radGreen.AutoSize = True
        Me.radGreen.ForeColor = System.Drawing.Color.Lime
        Me.radGreen.Location = New System.Drawing.Point(36, 123)
        Me.radGreen.Name = "radGreen"
        Me.radGreen.Size = New System.Drawing.Size(72, 24)
        Me.radGreen.TabIndex = 2
        Me.radGreen.TabStop = True
        Me.radGreen.Text = "Green"
        Me.radGreen.UseVisualStyleBackColor = True
        '
        'radYellow
        '
        Me.radYellow.AutoSize = True
        Me.radYellow.ForeColor = System.Drawing.Color.Yellow
        Me.radYellow.Location = New System.Drawing.Point(36, 82)
        Me.radYellow.Name = "radYellow"
        Me.radYellow.Size = New System.Drawing.Size(73, 24)
        Me.radYellow.TabIndex = 1
        Me.radYellow.TabStop = True
        Me.radYellow.Text = "Yellow"
        Me.radYellow.UseVisualStyleBackColor = True
        '
        'radRed
        '
        Me.radRed.AutoSize = True
        Me.radRed.ForeColor = System.Drawing.Color.Red
        Me.radRed.Location = New System.Drawing.Point(36, 38)
        Me.radRed.Name = "radRed"
        Me.radRed.Size = New System.Drawing.Size(57, 24)
        Me.radRed.TabIndex = 0
        Me.radRed.TabStop = True
        Me.radRed.Text = "Red"
        Me.radRed.UseVisualStyleBackColor = True
        '
        'grpAdvice
        '
        Me.grpAdvice.Controls.Add(Me.lblOutput)
        Me.grpAdvice.Controls.Add(Me.lblAdvice)
        Me.grpAdvice.Location = New System.Drawing.Point(38, 218)
        Me.grpAdvice.Name = "grpAdvice"
        Me.grpAdvice.Size = New System.Drawing.Size(232, 200)
        Me.grpAdvice.TabIndex = 1
        Me.grpAdvice.TabStop = False
        Me.grpAdvice.Text = "Advice"
        '
        'chkPolice
        '
        Me.chkPolice.AutoSize = True
        Me.chkPolice.Location = New System.Drawing.Point(281, 83)
        Me.chkPolice.Name = "chkPolice"
        Me.chkPolice.Size = New System.Drawing.Size(79, 24)
        Me.chkPolice.TabIndex = 3
        Me.chkPolice.Text = "Police?"
        Me.chkPolice.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(92, 92)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(18, 20)
        Me.lblOutput.TabIndex = 1
        Me.lblOutput.Text = "?"
        '
        'lblAdvice
        '
        Me.lblAdvice.AutoSize = True
        Me.lblAdvice.Location = New System.Drawing.Point(26, 92)
        Me.lblAdvice.Name = "lblAdvice"
        Me.lblAdvice.Size = New System.Drawing.Size(60, 20)
        Me.lblAdvice.TabIndex = 0
        Me.lblAdvice.Text = "Advice:"
        '
        'btnAdvice
        '
        Me.btnAdvice.Location = New System.Drawing.Point(319, 307)
        Me.btnAdvice.Name = "btnAdvice"
        Me.btnAdvice.Size = New System.Drawing.Size(75, 36)
        Me.btnAdvice.TabIndex = 4
        Me.btnAdvice.Text = "Advice"
        Me.btnAdvice.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 490)
        Me.Controls.Add(Me.btnAdvice)
        Me.Controls.Add(Me.grpAdvice)
        Me.Controls.Add(Me.grpLight)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Spotlight Algorithm"
        Me.grpLight.ResumeLayout(False)
        Me.grpLight.PerformLayout()
        Me.grpAdvice.ResumeLayout(False)
        Me.grpAdvice.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpLight As System.Windows.Forms.GroupBox
    Friend WithEvents radGreen As System.Windows.Forms.RadioButton
    Friend WithEvents radYellow As System.Windows.Forms.RadioButton
    Friend WithEvents radRed As System.Windows.Forms.RadioButton
    Friend WithEvents grpAdvice As System.Windows.Forms.GroupBox
    Friend WithEvents chkPolice As System.Windows.Forms.CheckBox
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents lblAdvice As System.Windows.Forms.Label
    Friend WithEvents btnAdvice As System.Windows.Forms.Button

End Class
