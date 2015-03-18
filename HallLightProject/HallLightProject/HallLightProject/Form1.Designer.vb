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
        Me.btnSwitchOn = New System.Windows.Forms.Button()
        Me.btnSwitchOff = New System.Windows.Forms.Button()
        Me.picLightOff = New System.Windows.Forms.PictureBox()
        Me.picLightOn = New System.Windows.Forms.PictureBox()
        CType(Me.picLightOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLightOn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSwitchOn
        '
        Me.btnSwitchOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnSwitchOn.Location = New System.Drawing.Point(126, 275)
        Me.btnSwitchOn.Name = "btnSwitchOn"
        Me.btnSwitchOn.Size = New System.Drawing.Size(75, 32)
        Me.btnSwitchOn.TabIndex = 2
        Me.btnSwitchOn.Text = "ON"
        Me.btnSwitchOn.UseVisualStyleBackColor = True
        '
        'btnSwitchOff
        '
        Me.btnSwitchOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnSwitchOff.Location = New System.Drawing.Point(275, 274)
        Me.btnSwitchOff.Name = "btnSwitchOff"
        Me.btnSwitchOff.Size = New System.Drawing.Size(75, 33)
        Me.btnSwitchOff.TabIndex = 3
        Me.btnSwitchOff.Text = "OFF"
        Me.btnSwitchOff.UseVisualStyleBackColor = True
        '
        'picLightOff
        '
        Me.picLightOff.Image = Global.HallLightProject.My.Resources.Resources.Off
        Me.picLightOff.Location = New System.Drawing.Point(165, 67)
        Me.picLightOff.Name = "picLightOff"
        Me.picLightOff.Size = New System.Drawing.Size(141, 137)
        Me.picLightOff.TabIndex = 5
        Me.picLightOff.TabStop = False
        '
        'picLightOn
        '
        Me.picLightOn.Image = Global.HallLightProject.My.Resources.Resources._On
        Me.picLightOn.Location = New System.Drawing.Point(165, 67)
        Me.picLightOn.Name = "picLightOn"
        Me.picLightOn.Size = New System.Drawing.Size(141, 137)
        Me.picLightOn.TabIndex = 4
        Me.picLightOn.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 378)
        Me.Controls.Add(Me.picLightOn)
        Me.Controls.Add(Me.btnSwitchOff)
        Me.Controls.Add(Me.btnSwitchOn)
        Me.Controls.Add(Me.picLightOff)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picLightOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLightOn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSwitchOn As System.Windows.Forms.Button
    Friend WithEvents btnSwitchOff As System.Windows.Forms.Button
    Friend WithEvents picLightOn As System.Windows.Forms.PictureBox
    Friend WithEvents picLightOff As System.Windows.Forms.PictureBox

End Class
