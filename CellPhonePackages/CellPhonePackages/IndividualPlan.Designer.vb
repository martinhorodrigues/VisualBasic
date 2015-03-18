<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIndividualPlan
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
        Me.grpPhone = New System.Windows.Forms.GroupBox()
        Me.radModel200 = New System.Windows.Forms.RadioButton()
        Me.radModel110 = New System.Windows.Forms.RadioButton()
        Me.radModel100 = New System.Windows.Forms.RadioButton()
        Me.grpPackage = New System.Windows.Forms.GroupBox()
        Me.radUnlimitedMinutes = New System.Windows.Forms.RadioButton()
        Me.rad1500Minutes = New System.Windows.Forms.RadioButton()
        Me.rad800Minutes = New System.Windows.Forms.RadioButton()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.chkText = New System.Windows.Forms.CheckBox()
        Me.chkEmail = New System.Windows.Forms.CheckBox()
        Me.grpTotals = New System.Windows.Forms.GroupBox()
        Me.lblMonthlyCharge2 = New System.Windows.Forms.Label()
        Me.lblPackage2 = New System.Windows.Forms.Label()
        Me.lblOptions2 = New System.Windows.Forms.Label()
        Me.lblTotal2 = New System.Windows.Forms.Label()
        Me.lblTax2 = New System.Windows.Forms.Label()
        Me.lblSubtotal2 = New System.Windows.Forms.Label()
        Me.lblMonthlyCharge1 = New System.Windows.Forms.Label()
        Me.lblPackage1 = New System.Windows.Forms.Label()
        Me.lblOptions1 = New System.Windows.Forms.Label()
        Me.lblTotal1 = New System.Windows.Forms.Label()
        Me.lblTax1 = New System.Windows.Forms.Label()
        Me.lblSubtotal1 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.grpPhone.SuspendLayout()
        Me.grpPackage.SuspendLayout()
        Me.grpOptions.SuspendLayout()
        Me.grpTotals.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpPhone
        '
        Me.grpPhone.Controls.Add(Me.radModel200)
        Me.grpPhone.Controls.Add(Me.radModel110)
        Me.grpPhone.Controls.Add(Me.radModel100)
        Me.grpPhone.Location = New System.Drawing.Point(12, 12)
        Me.grpPhone.Name = "grpPhone"
        Me.grpPhone.Size = New System.Drawing.Size(167, 125)
        Me.grpPhone.TabIndex = 0
        Me.grpPhone.TabStop = False
        Me.grpPhone.Text = "Select a Phone"
        '
        'radModel200
        '
        Me.radModel200.AutoSize = True
        Me.radModel200.Location = New System.Drawing.Point(7, 88)
        Me.radModel200.Name = "radModel200"
        Me.radModel200.Size = New System.Drawing.Size(101, 24)
        Me.radModel200.TabIndex = 2
        Me.radModel200.TabStop = True
        Me.radModel200.Text = "Model 200"
        Me.radModel200.UseVisualStyleBackColor = True
        '
        'radModel110
        '
        Me.radModel110.AutoSize = True
        Me.radModel110.Location = New System.Drawing.Point(7, 57)
        Me.radModel110.Name = "radModel110"
        Me.radModel110.Size = New System.Drawing.Size(101, 24)
        Me.radModel110.TabIndex = 1
        Me.radModel110.TabStop = True
        Me.radModel110.Text = "Model 110"
        Me.radModel110.UseVisualStyleBackColor = True
        '
        'radModel100
        '
        Me.radModel100.AutoSize = True
        Me.radModel100.Location = New System.Drawing.Point(7, 26)
        Me.radModel100.Name = "radModel100"
        Me.radModel100.Size = New System.Drawing.Size(101, 24)
        Me.radModel100.TabIndex = 0
        Me.radModel100.TabStop = True
        Me.radModel100.Text = "Model 100"
        Me.radModel100.UseVisualStyleBackColor = True
        '
        'grpPackage
        '
        Me.grpPackage.Controls.Add(Me.radUnlimitedMinutes)
        Me.grpPackage.Controls.Add(Me.rad1500Minutes)
        Me.grpPackage.Controls.Add(Me.rad800Minutes)
        Me.grpPackage.Location = New System.Drawing.Point(185, 12)
        Me.grpPackage.Name = "grpPackage"
        Me.grpPackage.Size = New System.Drawing.Size(229, 125)
        Me.grpPackage.TabIndex = 1
        Me.grpPackage.TabStop = False
        Me.grpPackage.Text = "Select a Package"
        '
        'radUnlimitedMinutes
        '
        Me.radUnlimitedMinutes.AutoSize = True
        Me.radUnlimitedMinutes.Location = New System.Drawing.Point(7, 94)
        Me.radUnlimitedMinutes.Name = "radUnlimitedMinutes"
        Me.radUnlimitedMinutes.Size = New System.Drawing.Size(153, 24)
        Me.radUnlimitedMinutes.TabIndex = 2
        Me.radUnlimitedMinutes.TabStop = True
        Me.radUnlimitedMinutes.Text = "Unlimited Minutes"
        Me.radUnlimitedMinutes.UseVisualStyleBackColor = True
        '
        'rad1500Minutes
        '
        Me.rad1500Minutes.AutoSize = True
        Me.rad1500Minutes.Location = New System.Drawing.Point(7, 63)
        Me.rad1500Minutes.Name = "rad1500Minutes"
        Me.rad1500Minutes.Size = New System.Drawing.Size(172, 24)
        Me.rad1500Minutes.TabIndex = 1
        Me.rad1500Minutes.TabStop = True
        Me.rad1500Minutes.Text = "1500 Minutes/Month"
        Me.rad1500Minutes.UseVisualStyleBackColor = True
        '
        'rad800Minutes
        '
        Me.rad800Minutes.AutoSize = True
        Me.rad800Minutes.Location = New System.Drawing.Point(7, 32)
        Me.rad800Minutes.Name = "rad800Minutes"
        Me.rad800Minutes.Size = New System.Drawing.Size(163, 24)
        Me.rad800Minutes.TabIndex = 0
        Me.rad800Minutes.TabStop = True
        Me.rad800Minutes.Text = "800 Minutes/Month"
        Me.rad800Minutes.UseVisualStyleBackColor = True
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.chkText)
        Me.grpOptions.Controls.Add(Me.chkEmail)
        Me.grpOptions.Location = New System.Drawing.Point(12, 163)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(167, 125)
        Me.grpOptions.TabIndex = 2
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Select Options"
        '
        'chkText
        '
        Me.chkText.AutoSize = True
        Me.chkText.Location = New System.Drawing.Point(6, 75)
        Me.chkText.Name = "chkText"
        Me.chkText.Size = New System.Drawing.Size(139, 24)
        Me.chkText.TabIndex = 1
        Me.chkText.Text = "Text Messaging"
        Me.chkText.UseVisualStyleBackColor = True
        '
        'chkEmail
        '
        Me.chkEmail.AutoSize = True
        Me.chkEmail.Location = New System.Drawing.Point(7, 45)
        Me.chkEmail.Name = "chkEmail"
        Me.chkEmail.Size = New System.Drawing.Size(67, 24)
        Me.chkEmail.TabIndex = 0
        Me.chkEmail.Text = "Email"
        Me.chkEmail.UseVisualStyleBackColor = True
        '
        'grpTotals
        '
        Me.grpTotals.Controls.Add(Me.lblMonthlyCharge2)
        Me.grpTotals.Controls.Add(Me.lblPackage2)
        Me.grpTotals.Controls.Add(Me.lblOptions2)
        Me.grpTotals.Controls.Add(Me.lblTotal2)
        Me.grpTotals.Controls.Add(Me.lblTax2)
        Me.grpTotals.Controls.Add(Me.lblSubtotal2)
        Me.grpTotals.Controls.Add(Me.lblMonthlyCharge1)
        Me.grpTotals.Controls.Add(Me.lblPackage1)
        Me.grpTotals.Controls.Add(Me.lblOptions1)
        Me.grpTotals.Controls.Add(Me.lblTotal1)
        Me.grpTotals.Controls.Add(Me.lblTax1)
        Me.grpTotals.Controls.Add(Me.lblSubtotal1)
        Me.grpTotals.Location = New System.Drawing.Point(185, 162)
        Me.grpTotals.Name = "grpTotals"
        Me.grpTotals.Size = New System.Drawing.Size(229, 228)
        Me.grpTotals.TabIndex = 3
        Me.grpTotals.TabStop = False
        Me.grpTotals.Text = "Totals"
        '
        'lblMonthlyCharge2
        '
        Me.lblMonthlyCharge2.AutoSize = True
        Me.lblMonthlyCharge2.Location = New System.Drawing.Point(165, 150)
        Me.lblMonthlyCharge2.Name = "lblMonthlyCharge2"
        Me.lblMonthlyCharge2.Size = New System.Drawing.Size(18, 20)
        Me.lblMonthlyCharge2.TabIndex = 11
        Me.lblMonthlyCharge2.Text = "?"
        '
        'lblPackage2
        '
        Me.lblPackage2.AutoSize = True
        Me.lblPackage2.Location = New System.Drawing.Point(165, 125)
        Me.lblPackage2.Name = "lblPackage2"
        Me.lblPackage2.Size = New System.Drawing.Size(18, 20)
        Me.lblPackage2.TabIndex = 10
        Me.lblPackage2.Text = "?"
        '
        'lblOptions2
        '
        Me.lblOptions2.AutoSize = True
        Me.lblOptions2.Location = New System.Drawing.Point(165, 100)
        Me.lblOptions2.Name = "lblOptions2"
        Me.lblOptions2.Size = New System.Drawing.Size(18, 20)
        Me.lblOptions2.TabIndex = 9
        Me.lblOptions2.Text = "?"
        '
        'lblTotal2
        '
        Me.lblTotal2.AutoSize = True
        Me.lblTotal2.Location = New System.Drawing.Point(165, 75)
        Me.lblTotal2.Name = "lblTotal2"
        Me.lblTotal2.Size = New System.Drawing.Size(18, 20)
        Me.lblTotal2.TabIndex = 8
        Me.lblTotal2.Text = "?"
        '
        'lblTax2
        '
        Me.lblTax2.AutoSize = True
        Me.lblTax2.Location = New System.Drawing.Point(165, 50)
        Me.lblTax2.Name = "lblTax2"
        Me.lblTax2.Size = New System.Drawing.Size(18, 20)
        Me.lblTax2.TabIndex = 7
        Me.lblTax2.Text = "?"
        '
        'lblSubtotal2
        '
        Me.lblSubtotal2.AutoSize = True
        Me.lblSubtotal2.Location = New System.Drawing.Point(165, 25)
        Me.lblSubtotal2.Name = "lblSubtotal2"
        Me.lblSubtotal2.Size = New System.Drawing.Size(18, 20)
        Me.lblSubtotal2.TabIndex = 6
        Me.lblSubtotal2.Text = "?"
        '
        'lblMonthlyCharge1
        '
        Me.lblMonthlyCharge1.AutoSize = True
        Me.lblMonthlyCharge1.Location = New System.Drawing.Point(10, 150)
        Me.lblMonthlyCharge1.Name = "lblMonthlyCharge1"
        Me.lblMonthlyCharge1.Size = New System.Drawing.Size(103, 40)
        Me.lblMonthlyCharge1.TabIndex = 5
        Me.lblMonthlyCharge1.Text = "Total Monthly" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Charge"
        '
        'lblPackage1
        '
        Me.lblPackage1.AutoSize = True
        Me.lblPackage1.Location = New System.Drawing.Point(10, 125)
        Me.lblPackage1.Name = "lblPackage1"
        Me.lblPackage1.Size = New System.Drawing.Size(127, 20)
        Me.lblPackage1.TabIndex = 4
        Me.lblPackage1.Text = "Package Charge"
        '
        'lblOptions1
        '
        Me.lblOptions1.AutoSize = True
        Me.lblOptions1.Location = New System.Drawing.Point(10, 100)
        Me.lblOptions1.Name = "lblOptions1"
        Me.lblOptions1.Size = New System.Drawing.Size(64, 20)
        Me.lblOptions1.TabIndex = 3
        Me.lblOptions1.Text = "Options"
        '
        'lblTotal1
        '
        Me.lblTotal1.AutoSize = True
        Me.lblTotal1.Location = New System.Drawing.Point(10, 75)
        Me.lblTotal1.Name = "lblTotal1"
        Me.lblTotal1.Size = New System.Drawing.Size(94, 20)
        Me.lblTotal1.TabIndex = 2
        Me.lblTotal1.Text = "Phone Total"
        '
        'lblTax1
        '
        Me.lblTax1.AutoSize = True
        Me.lblTax1.Location = New System.Drawing.Point(10, 50)
        Me.lblTax1.Name = "lblTax1"
        Me.lblTax1.Size = New System.Drawing.Size(34, 20)
        Me.lblTax1.TabIndex = 1
        Me.lblTax1.Text = "Tax"
        '
        'lblSubtotal1
        '
        Me.lblSubtotal1.AutoSize = True
        Me.lblSubtotal1.Location = New System.Drawing.Point(10, 25)
        Me.lblSubtotal1.Name = "lblSubtotal1"
        Me.lblSubtotal1.Size = New System.Drawing.Size(119, 20)
        Me.lblSubtotal1.TabIndex = 0
        Me.lblSubtotal1.Text = "Phone Subtotal"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(43, 321)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(85, 25)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(43, 365)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(85, 25)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmIndividualPlan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 402)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpTotals)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.grpPackage)
        Me.Controls.Add(Me.grpPhone)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmIndividualPlan"
        Me.Text = "Individual Plan"
        Me.grpPhone.ResumeLayout(False)
        Me.grpPhone.PerformLayout()
        Me.grpPackage.ResumeLayout(False)
        Me.grpPackage.PerformLayout()
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.grpTotals.ResumeLayout(False)
        Me.grpTotals.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpPhone As System.Windows.Forms.GroupBox
    Friend WithEvents grpPackage As System.Windows.Forms.GroupBox
    Friend WithEvents grpOptions As System.Windows.Forms.GroupBox
    Friend WithEvents grpTotals As System.Windows.Forms.GroupBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents radModel200 As System.Windows.Forms.RadioButton
    Friend WithEvents radModel110 As System.Windows.Forms.RadioButton
    Friend WithEvents radModel100 As System.Windows.Forms.RadioButton
    Friend WithEvents radUnlimitedMinutes As System.Windows.Forms.RadioButton
    Friend WithEvents rad1500Minutes As System.Windows.Forms.RadioButton
    Friend WithEvents rad800Minutes As System.Windows.Forms.RadioButton
    Friend WithEvents chkText As System.Windows.Forms.CheckBox
    Friend WithEvents chkEmail As System.Windows.Forms.CheckBox
    Friend WithEvents lblMonthlyCharge2 As System.Windows.Forms.Label
    Friend WithEvents lblPackage2 As System.Windows.Forms.Label
    Friend WithEvents lblOptions2 As System.Windows.Forms.Label
    Friend WithEvents lblTotal2 As System.Windows.Forms.Label
    Friend WithEvents lblTax2 As System.Windows.Forms.Label
    Friend WithEvents lblSubtotal2 As System.Windows.Forms.Label
    Friend WithEvents lblMonthlyCharge1 As System.Windows.Forms.Label
    Friend WithEvents lblPackage1 As System.Windows.Forms.Label
    Friend WithEvents lblOptions1 As System.Windows.Forms.Label
    Friend WithEvents lblTotal1 As System.Windows.Forms.Label
    Friend WithEvents lblTax1 As System.Windows.Forms.Label
    Friend WithEvents lblSubtotal1 As System.Windows.Forms.Label
End Class
