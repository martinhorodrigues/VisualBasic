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
        Me.grpAdult = New System.Windows.Forms.GroupBox()
        Me.txtAdultTickets = New System.Windows.Forms.TextBox()
        Me.txtAdultPrice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpChild = New System.Windows.Forms.GroupBox()
        Me.txtChildTickets = New System.Windows.Forms.TextBox()
        Me.txtChildPrice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grpGross = New System.Windows.Forms.GroupBox()
        Me.lblTotalGross = New System.Windows.Forms.Label()
        Me.lblGrossChild = New System.Windows.Forms.Label()
        Me.lblGrossAdult = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.grpNet = New System.Windows.Forms.GroupBox()
        Me.lblTotalNet = New System.Windows.Forms.Label()
        Me.lblNetChild = New System.Windows.Forms.Label()
        Me.lblNetAdult = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.grpAdult.SuspendLayout()
        Me.grpChild.SuspendLayout()
        Me.grpGross.SuspendLayout()
        Me.grpNet.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpAdult
        '
        Me.grpAdult.Controls.Add(Me.txtAdultTickets)
        Me.grpAdult.Controls.Add(Me.txtAdultPrice)
        Me.grpAdult.Controls.Add(Me.Label2)
        Me.grpAdult.Controls.Add(Me.Label1)
        Me.grpAdult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.grpAdult.Location = New System.Drawing.Point(9, 7)
        Me.grpAdult.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpAdult.Name = "grpAdult"
        Me.grpAdult.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpAdult.Size = New System.Drawing.Size(360, 166)
        Me.grpAdult.TabIndex = 0
        Me.grpAdult.TabStop = False
        Me.grpAdult.Text = "Adult Ticket Sales"
        '
        'txtAdultTickets
        '
        Me.txtAdultTickets.Location = New System.Drawing.Point(186, 86)
        Me.txtAdultTickets.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAdultTickets.Name = "txtAdultTickets"
        Me.txtAdultTickets.Size = New System.Drawing.Size(148, 26)
        Me.txtAdultTickets.TabIndex = 3
        '
        'txtAdultPrice
        '
        Me.txtAdultPrice.Location = New System.Drawing.Point(186, 42)
        Me.txtAdultPrice.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAdultPrice.Name = "txtAdultPrice"
        Me.txtAdultPrice.Size = New System.Drawing.Size(148, 26)
        Me.txtAdultPrice.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 92)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tickets Sold:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 48)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Price Per Ticket:"
        '
        'grpChild
        '
        Me.grpChild.Controls.Add(Me.txtChildTickets)
        Me.grpChild.Controls.Add(Me.txtChildPrice)
        Me.grpChild.Controls.Add(Me.Label4)
        Me.grpChild.Controls.Add(Me.Label3)
        Me.grpChild.Location = New System.Drawing.Point(374, 7)
        Me.grpChild.Name = "grpChild"
        Me.grpChild.Size = New System.Drawing.Size(360, 166)
        Me.grpChild.TabIndex = 1
        Me.grpChild.TabStop = False
        Me.grpChild.Text = "Child Ticket Sales"
        '
        'txtChildTickets
        '
        Me.txtChildTickets.Location = New System.Drawing.Point(187, 97)
        Me.txtChildTickets.Name = "txtChildTickets"
        Me.txtChildTickets.Size = New System.Drawing.Size(148, 26)
        Me.txtChildTickets.TabIndex = 3
        '
        'txtChildPrice
        '
        Me.txtChildPrice.Location = New System.Drawing.Point(187, 50)
        Me.txtChildPrice.Name = "txtChildPrice"
        Me.txtChildPrice.Size = New System.Drawing.Size(148, 26)
        Me.txtChildPrice.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(58, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Tickets Sold:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Price Per Ticket:"
        '
        'grpGross
        '
        Me.grpGross.Controls.Add(Me.lblTotalGross)
        Me.grpGross.Controls.Add(Me.lblGrossChild)
        Me.grpGross.Controls.Add(Me.lblGrossAdult)
        Me.grpGross.Controls.Add(Me.Label7)
        Me.grpGross.Controls.Add(Me.Label6)
        Me.grpGross.Controls.Add(Me.Label5)
        Me.grpGross.Location = New System.Drawing.Point(9, 183)
        Me.grpGross.Name = "grpGross"
        Me.grpGross.Size = New System.Drawing.Size(360, 194)
        Me.grpGross.TabIndex = 2
        Me.grpGross.TabStop = False
        Me.grpGross.Text = "Gross Ticket Revenue"
        '
        'lblTotalGross
        '
        Me.lblTotalGross.AutoSize = True
        Me.lblTotalGross.Location = New System.Drawing.Point(186, 122)
        Me.lblTotalGross.Name = "lblTotalGross"
        Me.lblTotalGross.Size = New System.Drawing.Size(18, 20)
        Me.lblTotalGross.TabIndex = 5
        Me.lblTotalGross.Text = "?"
        '
        'lblGrossChild
        '
        Me.lblGrossChild.AutoSize = True
        Me.lblGrossChild.Location = New System.Drawing.Point(186, 81)
        Me.lblGrossChild.Name = "lblGrossChild"
        Me.lblGrossChild.Size = New System.Drawing.Size(18, 20)
        Me.lblGrossChild.TabIndex = 4
        Me.lblGrossChild.Text = "?"
        '
        'lblGrossAdult
        '
        Me.lblGrossAdult.AutoSize = True
        Me.lblGrossAdult.Location = New System.Drawing.Point(186, 42)
        Me.lblGrossAdult.Name = "lblGrossAdult"
        Me.lblGrossAdult.Size = New System.Drawing.Size(18, 20)
        Me.lblGrossAdult.TabIndex = 3
        Me.lblGrossAdult.Text = "?"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(6, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 62)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Total Gross Revenue for Ticket Sales:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Child Ticket Sales:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Adult Ticket Sales:"
        '
        'grpNet
        '
        Me.grpNet.Controls.Add(Me.lblTotalNet)
        Me.grpNet.Controls.Add(Me.lblNetChild)
        Me.grpNet.Controls.Add(Me.lblNetAdult)
        Me.grpNet.Controls.Add(Me.Label13)
        Me.grpNet.Controls.Add(Me.Label12)
        Me.grpNet.Controls.Add(Me.Label11)
        Me.grpNet.Location = New System.Drawing.Point(374, 183)
        Me.grpNet.Name = "grpNet"
        Me.grpNet.Size = New System.Drawing.Size(360, 194)
        Me.grpNet.TabIndex = 3
        Me.grpNet.TabStop = False
        Me.grpNet.Text = "Net Ticket Revenue"
        '
        'lblTotalNet
        '
        Me.lblTotalNet.AutoSize = True
        Me.lblTotalNet.Location = New System.Drawing.Point(183, 122)
        Me.lblTotalNet.Name = "lblTotalNet"
        Me.lblTotalNet.Size = New System.Drawing.Size(18, 20)
        Me.lblTotalNet.TabIndex = 5
        Me.lblTotalNet.Text = "?"
        '
        'lblNetChild
        '
        Me.lblNetChild.AutoSize = True
        Me.lblNetChild.Location = New System.Drawing.Point(183, 81)
        Me.lblNetChild.Name = "lblNetChild"
        Me.lblNetChild.Size = New System.Drawing.Size(18, 20)
        Me.lblNetChild.TabIndex = 4
        Me.lblNetChild.Text = "?"
        '
        'lblNetAdult
        '
        Me.lblNetAdult.AutoSize = True
        Me.lblNetAdult.Location = New System.Drawing.Point(183, 42)
        Me.lblNetAdult.Name = "lblNetAdult"
        Me.lblNetAdult.Size = New System.Drawing.Size(18, 20)
        Me.lblNetAdult.TabIndex = 3
        Me.lblNetAdult.Text = "?"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(16, 122)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(141, 53)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Total Net Revenue for Ticket Sales:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(19, 81)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(138, 20)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Child Ticket Sales:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 42)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(140, 20)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Adult Ticket Sales:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(115, 405)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(228, 34)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate Ticket Revenue"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(374, 405)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 34)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(479, 405)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 34)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 454)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(741, 22)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 476)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpNet)
        Me.Controls.Add(Me.grpGross)
        Me.Controls.Add(Me.grpChild)
        Me.Controls.Add(Me.grpAdult)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Theater Revenue"
        Me.grpAdult.ResumeLayout(False)
        Me.grpAdult.PerformLayout()
        Me.grpChild.ResumeLayout(False)
        Me.grpChild.PerformLayout()
        Me.grpGross.ResumeLayout(False)
        Me.grpGross.PerformLayout()
        Me.grpNet.ResumeLayout(False)
        Me.grpNet.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpAdult As System.Windows.Forms.GroupBox
    Friend WithEvents txtAdultTickets As System.Windows.Forms.TextBox
    Friend WithEvents txtAdultPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpChild As System.Windows.Forms.GroupBox
    Friend WithEvents txtChildTickets As System.Windows.Forms.TextBox
    Friend WithEvents txtChildPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents grpGross As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalGross As System.Windows.Forms.Label
    Friend WithEvents lblGrossChild As System.Windows.Forms.Label
    Friend WithEvents lblGrossAdult As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents grpNet As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalNet As System.Windows.Forms.Label
    Friend WithEvents lblNetChild As System.Windows.Forms.Label
    Friend WithEvents lblNetAdult As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel

End Class
