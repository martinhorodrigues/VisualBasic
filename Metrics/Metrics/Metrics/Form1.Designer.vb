﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btnGo = New System.Windows.Forms.Button()
        Me.txtKilograms = New System.Windows.Forms.TextBox()
        Me.txtCentimeters = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPounds = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblInches = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblFeet = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnGo.Location = New System.Drawing.Point(174, 356)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(108, 44)
        Me.btnGo.TabIndex = 0
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'txtKilograms
        '
        Me.txtKilograms.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtKilograms.Location = New System.Drawing.Point(243, 57)
        Me.txtKilograms.Name = "txtKilograms"
        Me.txtKilograms.Size = New System.Drawing.Size(100, 26)
        Me.txtKilograms.TabIndex = 1
        '
        'txtCentimeters
        '
        Me.txtCentimeters.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtCentimeters.Location = New System.Drawing.Point(243, 138)
        Me.txtCentimeters.Name = "txtCentimeters"
        Me.txtCentimeters.Size = New System.Drawing.Size(100, 26)
        Me.txtCentimeters.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(89, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Kilograms"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(89, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Centimeters"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(89, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Pounds"
        '
        'lblPounds
        '
        Me.lblPounds.AutoSize = True
        Me.lblPounds.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblPounds.Location = New System.Drawing.Point(247, 206)
        Me.lblPounds.Name = "lblPounds"
        Me.lblPounds.Size = New System.Drawing.Size(18, 20)
        Me.lblPounds.TabIndex = 6
        Me.lblPounds.Text = "?"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(89, 299)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Inches"
        '
        'lblInches
        '
        Me.lblInches.AutoSize = True
        Me.lblInches.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblInches.Location = New System.Drawing.Point(247, 299)
        Me.lblInches.Name = "lblInches"
        Me.lblInches.Size = New System.Drawing.Size(18, 20)
        Me.lblInches.TabIndex = 8
        Me.lblInches.Text = "?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(93, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Feet"
        '
        'lblFeet
        '
        Me.lblFeet.AutoSize = True
        Me.lblFeet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblFeet.Location = New System.Drawing.Point(247, 255)
        Me.lblFeet.Name = "lblFeet"
        Me.lblFeet.Size = New System.Drawing.Size(18, 20)
        Me.lblFeet.TabIndex = 10
        Me.lblFeet.Text = "?"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 427)
        Me.Controls.Add(Me.lblFeet)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblInches)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblPounds)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCentimeters)
        Me.Controls.Add(Me.txtKilograms)
        Me.Controls.Add(Me.btnGo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents txtKilograms As System.Windows.Forms.TextBox
    Friend WithEvents txtCentimeters As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblPounds As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblInches As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblFeet As System.Windows.Forms.Label

End Class
