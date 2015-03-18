<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFamilyPlan
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
        Me.LblNumberPhones = New System.Windows.Forms.Label()
        Me.txtNumberPhones = New System.Windows.Forms.TextBox()
        Me.grpPhone = New System.Windows.Forms.GroupBox()
        Me.radModel200 = New System.Windows.Forms.RadioButton()
        Me.radModel110 = New System.Windows.Forms.RadioButton()
        Me.radModel100 = New System.Windows.Forms.RadioButton()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.chkText = New System.Windows.Forms.CheckBox()
        Me.chkEmail = New System.Windows.Forms.CheckBox()
        Me.grpPackage = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMonthlyCharge = New System.Windows.Forms.Label()
        Me.lblPackage = New System.Windows.Forms.Label()
        Me.lblOptions = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.radUnlimitedMinutes = New System.Windows.Forms.RadioButton()
        Me.rad1500Minutes = New System.Windows.Forms.RadioButton()
        Me.rad800Minutes = New System.Windows.Forms.RadioButton()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.grpTotals = New System.Windows.Forms.GroupBox()
        Me.lblMonthlyCharge4 = New System.Windows.Forms.Label()
        Me.lblPackage4 = New System.Windows.Forms.Label()
        Me.lblOptions4 = New System.Windows.Forms.Label()
        Me.lblTotal4 = New System.Windows.Forms.Label()
        Me.lblTax4 = New System.Windows.Forms.Label()
        Me.lblSubtotal4 = New System.Windows.Forms.Label()
        Me.lblMonthlyCharge3 = New System.Windows.Forms.Label()
        Me.lblPackage3 = New System.Windows.Forms.Label()
        Me.lblOptions3 = New System.Windows.Forms.Label()
        Me.lblTotal3 = New System.Windows.Forms.Label()
        Me.lblTax3 = New System.Windows.Forms.Label()
        Me.lblSubtotal3 = New System.Windows.Forms.Label()
        Me.grpPhone.SuspendLayout()
        Me.grpOptions.SuspendLayout()
        Me.grpPackage.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpTotals.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblNumberPhones
        '
        Me.LblNumberPhones.AutoSize = True
        Me.LblNumberPhones.Location = New System.Drawing.Point(12, 12)
        Me.LblNumberPhones.Name = "LblNumberPhones"
        Me.LblNumberPhones.Size = New System.Drawing.Size(141, 20)
        Me.LblNumberPhones.TabIndex = 0
        Me.LblNumberPhones.Text = "Number of Phones"
        '
        'txtNumberPhones
        '
        Me.txtNumberPhones.Location = New System.Drawing.Point(165, 12)
        Me.txtNumberPhones.Name = "txtNumberPhones"
        Me.txtNumberPhones.Size = New System.Drawing.Size(100, 26)
        Me.txtNumberPhones.TabIndex = 1
        '
        'grpPhone
        '
        Me.grpPhone.Controls.Add(Me.radModel200)
        Me.grpPhone.Controls.Add(Me.radModel110)
        Me.grpPhone.Controls.Add(Me.radModel100)
        Me.grpPhone.Location = New System.Drawing.Point(12, 48)
        Me.grpPhone.Name = "grpPhone"
        Me.grpPhone.Size = New System.Drawing.Size(167, 125)
        Me.grpPhone.TabIndex = 2
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
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.chkText)
        Me.grpOptions.Controls.Add(Me.chkEmail)
        Me.grpOptions.Location = New System.Drawing.Point(12, 179)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(167, 125)
        Me.grpOptions.TabIndex = 3
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Select Options"
        '
        'chkText
        '
        Me.chkText.AutoSize = True
        Me.chkText.Location = New System.Drawing.Point(14, 65)
        Me.chkText.Name = "chkText"
        Me.chkText.Size = New System.Drawing.Size(139, 24)
        Me.chkText.TabIndex = 3
        Me.chkText.Text = "Text Messaging"
        Me.chkText.UseVisualStyleBackColor = True
        '
        'chkEmail
        '
        Me.chkEmail.AutoSize = True
        Me.chkEmail.Location = New System.Drawing.Point(15, 35)
        Me.chkEmail.Name = "chkEmail"
        Me.chkEmail.Size = New System.Drawing.Size(67, 24)
        Me.chkEmail.TabIndex = 2
        Me.chkEmail.Text = "Email"
        Me.chkEmail.UseVisualStyleBackColor = True
        '
        'grpPackage
        '
        Me.grpPackage.Controls.Add(Me.GroupBox1)
        Me.grpPackage.Controls.Add(Me.radUnlimitedMinutes)
        Me.grpPackage.Controls.Add(Me.rad1500Minutes)
        Me.grpPackage.Controls.Add(Me.rad800Minutes)
        Me.grpPackage.Location = New System.Drawing.Point(189, 48)
        Me.grpPackage.Name = "grpPackage"
        Me.grpPackage.Size = New System.Drawing.Size(229, 125)
        Me.grpPackage.TabIndex = 3
        Me.grpPackage.TabStop = False
        Me.grpPackage.Text = "Select a Package"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblMonthlyCharge)
        Me.GroupBox1.Controls.Add(Me.lblPackage)
        Me.GroupBox1.Controls.Add(Me.lblOptions)
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.lblTax)
        Me.GroupBox1.Controls.Add(Me.lblSubtotal)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 131)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(229, 215)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Totals"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(165, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "?"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(165, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(165, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(165, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(165, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "?"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(165, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "?"
        '
        'lblMonthlyCharge
        '
        Me.lblMonthlyCharge.AutoSize = True
        Me.lblMonthlyCharge.Location = New System.Drawing.Point(10, 160)
        Me.lblMonthlyCharge.Name = "lblMonthlyCharge"
        Me.lblMonthlyCharge.Size = New System.Drawing.Size(103, 40)
        Me.lblMonthlyCharge.TabIndex = 5
        Me.lblMonthlyCharge.Text = "Total Monthly" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Charge"
        '
        'lblPackage
        '
        Me.lblPackage.AutoSize = True
        Me.lblPackage.Location = New System.Drawing.Point(10, 132)
        Me.lblPackage.Name = "lblPackage"
        Me.lblPackage.Size = New System.Drawing.Size(127, 20)
        Me.lblPackage.TabIndex = 4
        Me.lblPackage.Text = "Package Charge"
        '
        'lblOptions
        '
        Me.lblOptions.AutoSize = True
        Me.lblOptions.Location = New System.Drawing.Point(10, 107)
        Me.lblOptions.Name = "lblOptions"
        Me.lblOptions.Size = New System.Drawing.Size(64, 20)
        Me.lblOptions.TabIndex = 3
        Me.lblOptions.Text = "Options"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(10, 82)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(94, 20)
        Me.lblTotal.TabIndex = 2
        Me.lblTotal.Text = "Phone Total"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(10, 57)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(34, 20)
        Me.lblTax.TabIndex = 1
        Me.lblTax.Text = "Tax"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(10, 35)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(119, 20)
        Me.lblSubtotal.TabIndex = 0
        Me.lblSubtotal.Text = "Phone Subtotal"
        '
        'radUnlimitedMinutes
        '
        Me.radUnlimitedMinutes.AutoSize = True
        Me.radUnlimitedMinutes.Location = New System.Drawing.Point(7, 88)
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
        Me.rad1500Minutes.Location = New System.Drawing.Point(7, 57)
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
        Me.rad800Minutes.Location = New System.Drawing.Point(7, 26)
        Me.rad800Minutes.Name = "rad800Minutes"
        Me.rad800Minutes.Size = New System.Drawing.Size(163, 24)
        Me.rad800Minutes.TabIndex = 0
        Me.rad800Minutes.TabStop = True
        Me.rad800Minutes.Text = "800 Minutes/Month"
        Me.rad800Minutes.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(45, 325)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(85, 25)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(45, 366)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(85, 25)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'grpTotals
        '
        Me.grpTotals.Controls.Add(Me.lblMonthlyCharge4)
        Me.grpTotals.Controls.Add(Me.lblPackage4)
        Me.grpTotals.Controls.Add(Me.lblOptions4)
        Me.grpTotals.Controls.Add(Me.lblTotal4)
        Me.grpTotals.Controls.Add(Me.lblTax4)
        Me.grpTotals.Controls.Add(Me.lblSubtotal4)
        Me.grpTotals.Controls.Add(Me.lblMonthlyCharge3)
        Me.grpTotals.Controls.Add(Me.lblPackage3)
        Me.grpTotals.Controls.Add(Me.lblOptions3)
        Me.grpTotals.Controls.Add(Me.lblTotal3)
        Me.grpTotals.Controls.Add(Me.lblTax3)
        Me.grpTotals.Controls.Add(Me.lblSubtotal3)
        Me.grpTotals.Location = New System.Drawing.Point(189, 179)
        Me.grpTotals.Name = "grpTotals"
        Me.grpTotals.Size = New System.Drawing.Size(229, 212)
        Me.grpTotals.TabIndex = 7
        Me.grpTotals.TabStop = False
        Me.grpTotals.Text = "Totals"
        '
        'lblMonthlyCharge4
        '
        Me.lblMonthlyCharge4.AutoSize = True
        Me.lblMonthlyCharge4.Location = New System.Drawing.Point(165, 150)
        Me.lblMonthlyCharge4.Name = "lblMonthlyCharge4"
        Me.lblMonthlyCharge4.Size = New System.Drawing.Size(18, 20)
        Me.lblMonthlyCharge4.TabIndex = 11
        Me.lblMonthlyCharge4.Text = "?"
        '
        'lblPackage4
        '
        Me.lblPackage4.AutoSize = True
        Me.lblPackage4.Location = New System.Drawing.Point(165, 125)
        Me.lblPackage4.Name = "lblPackage4"
        Me.lblPackage4.Size = New System.Drawing.Size(18, 20)
        Me.lblPackage4.TabIndex = 10
        Me.lblPackage4.Text = "?"
        '
        'lblOptions4
        '
        Me.lblOptions4.AutoSize = True
        Me.lblOptions4.Location = New System.Drawing.Point(165, 100)
        Me.lblOptions4.Name = "lblOptions4"
        Me.lblOptions4.Size = New System.Drawing.Size(18, 20)
        Me.lblOptions4.TabIndex = 9
        Me.lblOptions4.Text = "?"
        '
        'lblTotal4
        '
        Me.lblTotal4.AutoSize = True
        Me.lblTotal4.Location = New System.Drawing.Point(165, 75)
        Me.lblTotal4.Name = "lblTotal4"
        Me.lblTotal4.Size = New System.Drawing.Size(18, 20)
        Me.lblTotal4.TabIndex = 8
        Me.lblTotal4.Text = "?"
        '
        'lblTax4
        '
        Me.lblTax4.AutoSize = True
        Me.lblTax4.Location = New System.Drawing.Point(165, 50)
        Me.lblTax4.Name = "lblTax4"
        Me.lblTax4.Size = New System.Drawing.Size(18, 20)
        Me.lblTax4.TabIndex = 7
        Me.lblTax4.Text = "?"
        '
        'lblSubtotal4
        '
        Me.lblSubtotal4.AutoSize = True
        Me.lblSubtotal4.Location = New System.Drawing.Point(165, 25)
        Me.lblSubtotal4.Name = "lblSubtotal4"
        Me.lblSubtotal4.Size = New System.Drawing.Size(18, 20)
        Me.lblSubtotal4.TabIndex = 6
        Me.lblSubtotal4.Text = "?"
        '
        'lblMonthlyCharge3
        '
        Me.lblMonthlyCharge3.AutoSize = True
        Me.lblMonthlyCharge3.Location = New System.Drawing.Point(10, 150)
        Me.lblMonthlyCharge3.Name = "lblMonthlyCharge3"
        Me.lblMonthlyCharge3.Size = New System.Drawing.Size(103, 40)
        Me.lblMonthlyCharge3.TabIndex = 5
        Me.lblMonthlyCharge3.Text = "Total Monthly" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Charge"
        '
        'lblPackage3
        '
        Me.lblPackage3.AutoSize = True
        Me.lblPackage3.Location = New System.Drawing.Point(10, 125)
        Me.lblPackage3.Name = "lblPackage3"
        Me.lblPackage3.Size = New System.Drawing.Size(127, 20)
        Me.lblPackage3.TabIndex = 4
        Me.lblPackage3.Text = "Package Charge"
        '
        'lblOptions3
        '
        Me.lblOptions3.AutoSize = True
        Me.lblOptions3.Location = New System.Drawing.Point(10, 100)
        Me.lblOptions3.Name = "lblOptions3"
        Me.lblOptions3.Size = New System.Drawing.Size(64, 20)
        Me.lblOptions3.TabIndex = 3
        Me.lblOptions3.Text = "Options"
        '
        'lblTotal3
        '
        Me.lblTotal3.AutoSize = True
        Me.lblTotal3.Location = New System.Drawing.Point(10, 75)
        Me.lblTotal3.Name = "lblTotal3"
        Me.lblTotal3.Size = New System.Drawing.Size(94, 20)
        Me.lblTotal3.TabIndex = 2
        Me.lblTotal3.Text = "Phone Total"
        '
        'lblTax3
        '
        Me.lblTax3.AutoSize = True
        Me.lblTax3.Location = New System.Drawing.Point(10, 50)
        Me.lblTax3.Name = "lblTax3"
        Me.lblTax3.Size = New System.Drawing.Size(34, 20)
        Me.lblTax3.TabIndex = 1
        Me.lblTax3.Text = "Tax"
        '
        'lblSubtotal3
        '
        Me.lblSubtotal3.AutoSize = True
        Me.lblSubtotal3.Location = New System.Drawing.Point(10, 25)
        Me.lblSubtotal3.Name = "lblSubtotal3"
        Me.lblSubtotal3.Size = New System.Drawing.Size(119, 20)
        Me.lblSubtotal3.TabIndex = 0
        Me.lblSubtotal3.Text = "Phone Subtotal"
        '
        'frmFamilyPlan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 402)
        Me.Controls.Add(Me.grpTotals)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpPackage)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.grpPhone)
        Me.Controls.Add(Me.txtNumberPhones)
        Me.Controls.Add(Me.LblNumberPhones)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmFamilyPlan"
        Me.Text = "Family Plan"
        Me.grpPhone.ResumeLayout(False)
        Me.grpPhone.PerformLayout()
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.grpPackage.ResumeLayout(False)
        Me.grpPackage.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpTotals.ResumeLayout(False)
        Me.grpTotals.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblNumberPhones As System.Windows.Forms.Label
    Friend WithEvents txtNumberPhones As System.Windows.Forms.TextBox
    Friend WithEvents grpPhone As System.Windows.Forms.GroupBox
    Friend WithEvents grpOptions As System.Windows.Forms.GroupBox
    Friend WithEvents grpPackage As System.Windows.Forms.GroupBox
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblMonthlyCharge As System.Windows.Forms.Label
    Friend WithEvents lblPackage As System.Windows.Forms.Label
    Friend WithEvents lblOptions As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents grpTotals As System.Windows.Forms.GroupBox
    Friend WithEvents lblMonthlyCharge4 As System.Windows.Forms.Label
    Friend WithEvents lblPackage4 As System.Windows.Forms.Label
    Friend WithEvents lblOptions4 As System.Windows.Forms.Label
    Friend WithEvents lblTotal4 As System.Windows.Forms.Label
    Friend WithEvents lblTax4 As System.Windows.Forms.Label
    Friend WithEvents lblSubtotal4 As System.Windows.Forms.Label
    Friend WithEvents lblMonthlyCharge3 As System.Windows.Forms.Label
    Friend WithEvents lblPackage3 As System.Windows.Forms.Label
    Friend WithEvents lblOptions3 As System.Windows.Forms.Label
    Friend WithEvents lblTotal3 As System.Windows.Forms.Label
    Friend WithEvents lblTax3 As System.Windows.Forms.Label
    Friend WithEvents lblSubtotal3 As System.Windows.Forms.Label
End Class
