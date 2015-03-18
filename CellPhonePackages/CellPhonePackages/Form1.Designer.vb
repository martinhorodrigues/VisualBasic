<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCellPhonePackages
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
        Me.grpSelectPlan = New System.Windows.Forms.GroupBox()
        Me.lblIdividual = New System.Windows.Forms.Label()
        Me.lblFamily = New System.Windows.Forms.Label()
        Me.btnIndividual = New System.Windows.Forms.Button()
        Me.btnFamily = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpSelectPlan.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSelectPlan
        '
        Me.grpSelectPlan.Controls.Add(Me.btnFamily)
        Me.grpSelectPlan.Controls.Add(Me.btnIndividual)
        Me.grpSelectPlan.Controls.Add(Me.lblFamily)
        Me.grpSelectPlan.Controls.Add(Me.lblIdividual)
        Me.grpSelectPlan.Location = New System.Drawing.Point(12, 12)
        Me.grpSelectPlan.Name = "grpSelectPlan"
        Me.grpSelectPlan.Size = New System.Drawing.Size(402, 328)
        Me.grpSelectPlan.TabIndex = 0
        Me.grpSelectPlan.TabStop = False
        Me.grpSelectPlan.Text = "Select a Plan"
        '
        'lblIdividual
        '
        Me.lblIdividual.AutoSize = True
        Me.lblIdividual.Location = New System.Drawing.Point(35, 50)
        Me.lblIdividual.Name = "lblIdividual"
        Me.lblIdividual.Size = New System.Drawing.Size(234, 60)
        Me.lblIdividual.TabIndex = 0
        Me.lblIdividual.Text = "The Individual plan provides one" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cell phone and a variety of" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "monthly packages."
        '
        'lblFamily
        '
        Me.lblFamily.AutoSize = True
        Me.lblFamily.Location = New System.Drawing.Point(35, 175)
        Me.lblFamily.Name = "lblFamily"
        Me.lblFamily.Size = New System.Drawing.Size(246, 80)
        Me.lblFamily.TabIndex = 1
        Me.lblFamily.Text = "The Family plan allows you to " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "purchase multiple cell phones of" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the same model," & _
    " with each phone" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sharing one monthly package."
        '
        'btnIndividual
        '
        Me.btnIndividual.Location = New System.Drawing.Point(300, 50)
        Me.btnIndividual.Name = "btnIndividual"
        Me.btnIndividual.Size = New System.Drawing.Size(85, 25)
        Me.btnIndividual.TabIndex = 2
        Me.btnIndividual.Text = "Individual"
        Me.btnIndividual.UseVisualStyleBackColor = True
        '
        'btnFamily
        '
        Me.btnFamily.Location = New System.Drawing.Point(300, 175)
        Me.btnFamily.Name = "btnFamily"
        Me.btnFamily.Size = New System.Drawing.Size(85, 25)
        Me.btnFamily.TabIndex = 3
        Me.btnFamily.Text = "Family"
        Me.btnFamily.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(312, 365)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(85, 25)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmCellPhonePackages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 402)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.grpSelectPlan)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmCellPhonePackages"
        Me.Text = "Cell Phone Packages"
        Me.grpSelectPlan.ResumeLayout(False)
        Me.grpSelectPlan.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpSelectPlan As System.Windows.Forms.GroupBox
    Friend WithEvents btnFamily As System.Windows.Forms.Button
    Friend WithEvents btnIndividual As System.Windows.Forms.Button
    Friend WithEvents lblFamily As System.Windows.Forms.Label
    Friend WithEvents lblIdividual As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
