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
        Me.grpOilLube = New System.Windows.Forms.GroupBox()
        Me.lblLube = New System.Windows.Forms.Label()
        Me.lblOil = New System.Windows.Forms.Label()
        Me.chkLube = New System.Windows.Forms.CheckBox()
        Me.chkOil = New System.Windows.Forms.CheckBox()
        Me.grpFlushes = New System.Windows.Forms.GroupBox()
        Me.lblTransmission = New System.Windows.Forms.Label()
        Me.lblRadiator = New System.Windows.Forms.Label()
        Me.chkTransmission = New System.Windows.Forms.CheckBox()
        Me.chkRadiator = New System.Windows.Forms.CheckBox()
        Me.grpMisc = New System.Windows.Forms.GroupBox()
        Me.lblTire = New System.Windows.Forms.Label()
        Me.lblMuffler = New System.Windows.Forms.Label()
        Me.lblInspection = New System.Windows.Forms.Label()
        Me.chkTire = New System.Windows.Forms.CheckBox()
        Me.chkMuffler = New System.Windows.Forms.CheckBox()
        Me.chkInspection = New System.Windows.Forms.CheckBox()
        Me.grpOther = New System.Windows.Forms.GroupBox()
        Me.txtLabor = New System.Windows.Forms.TextBox()
        Me.txtParts = New System.Windows.Forms.TextBox()
        Me.lblLabor = New System.Windows.Forms.Label()
        Me.lblParts = New System.Windows.Forms.Label()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.grpFees = New System.Windows.Forms.GroupBox()
        Me.lblTotalCharges = New System.Windows.Forms.Label()
        Me.lblTaxCharges = New System.Windows.Forms.Label()
        Me.lblPartsCharges = New System.Windows.Forms.Label()
        Me.lblServiceCharges = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblParts2 = New System.Windows.Forms.Label()
        Me.lblServices = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpOilLube.SuspendLayout()
        Me.grpFlushes.SuspendLayout()
        Me.grpMisc.SuspendLayout()
        Me.grpOther.SuspendLayout()
        Me.grpFees.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpOilLube
        '
        Me.grpOilLube.Controls.Add(Me.lblLube)
        Me.grpOilLube.Controls.Add(Me.lblOil)
        Me.grpOilLube.Controls.Add(Me.chkLube)
        Me.grpOilLube.Controls.Add(Me.chkOil)
        Me.grpOilLube.Location = New System.Drawing.Point(50, 30)
        Me.grpOilLube.Name = "grpOilLube"
        Me.grpOilLube.Size = New System.Drawing.Size(275, 100)
        Me.grpOilLube.TabIndex = 0
        Me.grpOilLube.TabStop = False
        Me.grpOilLube.Text = "Oil and Lube"
        '
        'lblLube
        '
        Me.lblLube.AutoSize = True
        Me.lblLube.Location = New System.Drawing.Point(195, 60)
        Me.lblLube.Name = "lblLube"
        Me.lblLube.Size = New System.Drawing.Size(68, 20)
        Me.lblLube.TabIndex = 3
        Me.lblLube.Text = "($18.00)"
        '
        'lblOil
        '
        Me.lblOil.AutoSize = True
        Me.lblOil.Location = New System.Drawing.Point(195, 30)
        Me.lblOil.Name = "lblOil"
        Me.lblOil.Size = New System.Drawing.Size(68, 20)
        Me.lblOil.TabIndex = 2
        Me.lblOil.Text = "($26.00)"
        '
        'chkLube
        '
        Me.chkLube.AutoSize = True
        Me.chkLube.Location = New System.Drawing.Point(25, 60)
        Me.chkLube.Name = "chkLube"
        Me.chkLube.Size = New System.Drawing.Size(94, 24)
        Me.chkLube.TabIndex = 1
        Me.chkLube.Text = "Lube Job"
        Me.chkLube.UseVisualStyleBackColor = True
        '
        'chkOil
        '
        Me.chkOil.AutoSize = True
        Me.chkOil.Location = New System.Drawing.Point(25, 30)
        Me.chkOil.Name = "chkOil"
        Me.chkOil.Size = New System.Drawing.Size(106, 24)
        Me.chkOil.TabIndex = 0
        Me.chkOil.Text = "Oil Change"
        Me.chkOil.UseVisualStyleBackColor = True
        '
        'grpFlushes
        '
        Me.grpFlushes.Controls.Add(Me.lblTransmission)
        Me.grpFlushes.Controls.Add(Me.lblRadiator)
        Me.grpFlushes.Controls.Add(Me.chkTransmission)
        Me.grpFlushes.Controls.Add(Me.chkRadiator)
        Me.grpFlushes.Location = New System.Drawing.Point(350, 30)
        Me.grpFlushes.Name = "grpFlushes"
        Me.grpFlushes.Size = New System.Drawing.Size(275, 100)
        Me.grpFlushes.TabIndex = 1
        Me.grpFlushes.TabStop = False
        Me.grpFlushes.Text = "Flushes"
        '
        'lblTransmission
        '
        Me.lblTransmission.AutoSize = True
        Me.lblTransmission.Location = New System.Drawing.Point(195, 60)
        Me.lblTransmission.Name = "lblTransmission"
        Me.lblTransmission.Size = New System.Drawing.Size(68, 20)
        Me.lblTransmission.TabIndex = 3
        Me.lblTransmission.Text = "($80.00)"
        '
        'lblRadiator
        '
        Me.lblRadiator.AutoSize = True
        Me.lblRadiator.Location = New System.Drawing.Point(195, 30)
        Me.lblRadiator.Name = "lblRadiator"
        Me.lblRadiator.Size = New System.Drawing.Size(68, 20)
        Me.lblRadiator.TabIndex = 2
        Me.lblRadiator.Text = "($30.00)"
        '
        'chkTransmission
        '
        Me.chkTransmission.AutoSize = True
        Me.chkTransmission.Location = New System.Drawing.Point(25, 60)
        Me.chkTransmission.Name = "chkTransmission"
        Me.chkTransmission.Size = New System.Drawing.Size(164, 24)
        Me.chkTransmission.TabIndex = 1
        Me.chkTransmission.Text = "Transmission Flush"
        Me.chkTransmission.UseVisualStyleBackColor = True
        '
        'chkRadiator
        '
        Me.chkRadiator.AutoSize = True
        Me.chkRadiator.Location = New System.Drawing.Point(25, 30)
        Me.chkRadiator.Name = "chkRadiator"
        Me.chkRadiator.Size = New System.Drawing.Size(132, 24)
        Me.chkRadiator.TabIndex = 0
        Me.chkRadiator.Text = "Radiator Flush"
        Me.chkRadiator.UseVisualStyleBackColor = True
        '
        'grpMisc
        '
        Me.grpMisc.Controls.Add(Me.lblTire)
        Me.grpMisc.Controls.Add(Me.lblMuffler)
        Me.grpMisc.Controls.Add(Me.lblInspection)
        Me.grpMisc.Controls.Add(Me.chkTire)
        Me.grpMisc.Controls.Add(Me.chkMuffler)
        Me.grpMisc.Controls.Add(Me.chkInspection)
        Me.grpMisc.Location = New System.Drawing.Point(50, 150)
        Me.grpMisc.Name = "grpMisc"
        Me.grpMisc.Size = New System.Drawing.Size(275, 100)
        Me.grpMisc.TabIndex = 2
        Me.grpMisc.TabStop = False
        Me.grpMisc.Text = "Misc"
        '
        'lblTire
        '
        Me.lblTire.AutoSize = True
        Me.lblTire.Location = New System.Drawing.Point(195, 60)
        Me.lblTire.Name = "lblTire"
        Me.lblTire.Size = New System.Drawing.Size(68, 20)
        Me.lblTire.TabIndex = 5
        Me.lblTire.Text = "($20.00)"
        '
        'lblMuffler
        '
        Me.lblMuffler.AutoSize = True
        Me.lblMuffler.Location = New System.Drawing.Point(195, 40)
        Me.lblMuffler.Name = "lblMuffler"
        Me.lblMuffler.Size = New System.Drawing.Size(77, 20)
        Me.lblMuffler.TabIndex = 4
        Me.lblMuffler.Text = "($100.00)"
        '
        'lblInspection
        '
        Me.lblInspection.AutoSize = True
        Me.lblInspection.Location = New System.Drawing.Point(195, 20)
        Me.lblInspection.Name = "lblInspection"
        Me.lblInspection.Size = New System.Drawing.Size(68, 20)
        Me.lblInspection.TabIndex = 3
        Me.lblInspection.Text = "($15.00)"
        '
        'chkTire
        '
        Me.chkTire.AutoSize = True
        Me.chkTire.Location = New System.Drawing.Point(25, 60)
        Me.chkTire.Name = "chkTire"
        Me.chkTire.Size = New System.Drawing.Size(119, 24)
        Me.chkTire.TabIndex = 2
        Me.chkTire.Text = "Tire Rotation"
        Me.chkTire.UseVisualStyleBackColor = True
        '
        'chkMuffler
        '
        Me.chkMuffler.AutoSize = True
        Me.chkMuffler.Location = New System.Drawing.Point(25, 40)
        Me.chkMuffler.Name = "chkMuffler"
        Me.chkMuffler.Size = New System.Drawing.Size(140, 24)
        Me.chkMuffler.TabIndex = 1
        Me.chkMuffler.Text = "Replace Muffler"
        Me.chkMuffler.UseVisualStyleBackColor = True
        '
        'chkInspection
        '
        Me.chkInspection.AutoSize = True
        Me.chkInspection.Location = New System.Drawing.Point(25, 20)
        Me.chkInspection.Name = "chkInspection"
        Me.chkInspection.Size = New System.Drawing.Size(102, 24)
        Me.chkInspection.TabIndex = 0
        Me.chkInspection.Text = "Inspection"
        Me.chkInspection.UseVisualStyleBackColor = True
        '
        'grpOther
        '
        Me.grpOther.Controls.Add(Me.txtLabor)
        Me.grpOther.Controls.Add(Me.txtParts)
        Me.grpOther.Controls.Add(Me.lblLabor)
        Me.grpOther.Controls.Add(Me.lblParts)
        Me.grpOther.Controls.Add(Me.lblRate)
        Me.grpOther.Location = New System.Drawing.Point(350, 150)
        Me.grpOther.Name = "grpOther"
        Me.grpOther.Size = New System.Drawing.Size(275, 100)
        Me.grpOther.TabIndex = 3
        Me.grpOther.TabStop = False
        Me.grpOther.Text = "Parts and Labor"
        '
        'txtLabor
        '
        Me.txtLabor.Location = New System.Drawing.Point(75, 60)
        Me.txtLabor.Name = "txtLabor"
        Me.txtLabor.Size = New System.Drawing.Size(68, 26)
        Me.txtLabor.TabIndex = 7
        '
        'txtParts
        '
        Me.txtParts.Location = New System.Drawing.Point(75, 30)
        Me.txtParts.Name = "txtParts"
        Me.txtParts.Size = New System.Drawing.Size(68, 26)
        Me.txtParts.TabIndex = 6
        '
        'lblLabor
        '
        Me.lblLabor.AutoSize = True
        Me.lblLabor.Location = New System.Drawing.Point(25, 60)
        Me.lblLabor.Name = "lblLabor"
        Me.lblLabor.Size = New System.Drawing.Size(50, 20)
        Me.lblLabor.TabIndex = 5
        Me.lblLabor.Text = "Labor"
        '
        'lblParts
        '
        Me.lblParts.AutoSize = True
        Me.lblParts.Location = New System.Drawing.Point(25, 30)
        Me.lblParts.Name = "lblParts"
        Me.lblParts.Size = New System.Drawing.Size(46, 20)
        Me.lblParts.TabIndex = 4
        Me.lblParts.Text = "Parts"
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Location = New System.Drawing.Point(143, 60)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(131, 20)
        Me.lblRate.TabIndex = 3
        Me.lblRate.Text = "($20.00 per hour)"
        '
        'grpFees
        '
        Me.grpFees.Controls.Add(Me.lblTotalCharges)
        Me.grpFees.Controls.Add(Me.lblTaxCharges)
        Me.grpFees.Controls.Add(Me.lblPartsCharges)
        Me.grpFees.Controls.Add(Me.lblServiceCharges)
        Me.grpFees.Controls.Add(Me.lblTotal)
        Me.grpFees.Controls.Add(Me.lblTax)
        Me.grpFees.Controls.Add(Me.lblParts2)
        Me.grpFees.Controls.Add(Me.lblServices)
        Me.grpFees.Location = New System.Drawing.Point(50, 264)
        Me.grpFees.Name = "grpFees"
        Me.grpFees.Size = New System.Drawing.Size(574, 133)
        Me.grpFees.TabIndex = 4
        Me.grpFees.TabStop = False
        Me.grpFees.Text = "Summary"
        '
        'lblTotalCharges
        '
        Me.lblTotalCharges.AutoSize = True
        Me.lblTotalCharges.Location = New System.Drawing.Point(300, 100)
        Me.lblTotalCharges.Name = "lblTotalCharges"
        Me.lblTotalCharges.Size = New System.Drawing.Size(18, 20)
        Me.lblTotalCharges.TabIndex = 7
        Me.lblTotalCharges.Text = "?"
        '
        'lblTaxCharges
        '
        Me.lblTaxCharges.AutoSize = True
        Me.lblTaxCharges.Location = New System.Drawing.Point(300, 75)
        Me.lblTaxCharges.Name = "lblTaxCharges"
        Me.lblTaxCharges.Size = New System.Drawing.Size(18, 20)
        Me.lblTaxCharges.TabIndex = 6
        Me.lblTaxCharges.Text = "?"
        '
        'lblPartsCharges
        '
        Me.lblPartsCharges.AutoSize = True
        Me.lblPartsCharges.Location = New System.Drawing.Point(300, 50)
        Me.lblPartsCharges.Name = "lblPartsCharges"
        Me.lblPartsCharges.Size = New System.Drawing.Size(18, 20)
        Me.lblPartsCharges.TabIndex = 5
        Me.lblPartsCharges.Text = "?"
        '
        'lblServiceCharges
        '
        Me.lblServiceCharges.AutoSize = True
        Me.lblServiceCharges.Location = New System.Drawing.Point(300, 25)
        Me.lblServiceCharges.Name = "lblServiceCharges"
        Me.lblServiceCharges.Size = New System.Drawing.Size(18, 20)
        Me.lblServiceCharges.TabIndex = 4
        Me.lblServiceCharges.Text = "?"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(191, 100)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(84, 20)
        Me.lblTotal.TabIndex = 3
        Me.lblTotal.Text = "Total Fees"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(169, 75)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(106, 20)
        Me.lblTax.TabIndex = 2
        Me.lblTax.Text = "Tax (on parts)"
        '
        'lblParts2
        '
        Me.lblParts2.AutoSize = True
        Me.lblParts2.Location = New System.Drawing.Point(229, 50)
        Me.lblParts2.Name = "lblParts2"
        Me.lblParts2.Size = New System.Drawing.Size(46, 20)
        Me.lblParts2.TabIndex = 1
        Me.lblParts2.Text = "Parts"
        '
        'lblServices
        '
        Me.lblServices.AutoSize = True
        Me.lblServices.Location = New System.Drawing.Point(130, 25)
        Me.lblServices.Name = "lblServices"
        Me.lblServices.Size = New System.Drawing.Size(145, 20)
        Me.lblServices.TabIndex = 0
        Me.lblServices.Text = "Services and Labor"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(100, 425)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(130, 50)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate Total"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(292, 425)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 50)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(425, 425)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 50)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 488)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpFees)
        Me.Controls.Add(Me.grpOther)
        Me.Controls.Add(Me.grpMisc)
        Me.Controls.Add(Me.grpFlushes)
        Me.Controls.Add(Me.grpOilLube)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Joe's Automotive"
        Me.grpOilLube.ResumeLayout(False)
        Me.grpOilLube.PerformLayout()
        Me.grpFlushes.ResumeLayout(False)
        Me.grpFlushes.PerformLayout()
        Me.grpMisc.ResumeLayout(False)
        Me.grpMisc.PerformLayout()
        Me.grpOther.ResumeLayout(False)
        Me.grpOther.PerformLayout()
        Me.grpFees.ResumeLayout(False)
        Me.grpFees.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpOilLube As System.Windows.Forms.GroupBox
    Friend WithEvents lblLube As System.Windows.Forms.Label
    Friend WithEvents lblOil As System.Windows.Forms.Label
    Friend WithEvents chkLube As System.Windows.Forms.CheckBox
    Friend WithEvents chkOil As System.Windows.Forms.CheckBox
    Friend WithEvents grpFlushes As System.Windows.Forms.GroupBox
    Friend WithEvents lblTransmission As System.Windows.Forms.Label
    Friend WithEvents lblRadiator As System.Windows.Forms.Label
    Friend WithEvents chkTransmission As System.Windows.Forms.CheckBox
    Friend WithEvents chkRadiator As System.Windows.Forms.CheckBox
    Friend WithEvents grpMisc As System.Windows.Forms.GroupBox
    Friend WithEvents lblTire As System.Windows.Forms.Label
    Friend WithEvents lblMuffler As System.Windows.Forms.Label
    Friend WithEvents lblInspection As System.Windows.Forms.Label
    Friend WithEvents chkTire As System.Windows.Forms.CheckBox
    Friend WithEvents chkMuffler As System.Windows.Forms.CheckBox
    Friend WithEvents chkInspection As System.Windows.Forms.CheckBox
    Friend WithEvents grpOther As System.Windows.Forms.GroupBox
    Friend WithEvents txtLabor As System.Windows.Forms.TextBox
    Friend WithEvents txtParts As System.Windows.Forms.TextBox
    Friend WithEvents lblLabor As System.Windows.Forms.Label
    Friend WithEvents lblParts As System.Windows.Forms.Label
    Friend WithEvents lblRate As System.Windows.Forms.Label
    Friend WithEvents grpFees As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalCharges As System.Windows.Forms.Label
    Friend WithEvents lblTaxCharges As System.Windows.Forms.Label
    Friend WithEvents lblPartsCharges As System.Windows.Forms.Label
    Friend WithEvents lblServiceCharges As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblParts2 As System.Windows.Forms.Label
    Friend WithEvents lblServices As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
