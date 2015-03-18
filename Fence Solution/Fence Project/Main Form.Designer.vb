<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.lblTtlCost = New System.Windows.Forms.Label()
        Me.lblTtlCalc = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(144, 192)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Location = New System.Drawing.Point(175, 50)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(70, 13)
        Me.lblLength.TabIndex = 1
        Me.lblLength.Text = "Length (feet):"
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Location = New System.Drawing.Point(275, 50)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(65, 13)
        Me.lblWidth.TabIndex = 2
        Me.lblWidth.Text = "Width (feet):"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(375, 50)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(76, 13)
        Me.lblCost.TabIndex = 3
        Me.lblCost.Text = "Cost (per foot):"
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(175, 75)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(67, 20)
        Me.txtLength.TabIndex = 4
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(275, 75)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(67, 20)
        Me.txtWidth.TabIndex = 5
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(375, 75)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(67, 20)
        Me.txtCost.TabIndex = 6
        '
        'lblTtlCost
        '
        Me.lblTtlCost.AutoSize = True
        Me.lblTtlCost.Location = New System.Drawing.Point(250, 125)
        Me.lblTtlCost.Name = "lblTtlCost"
        Me.lblTtlCost.Size = New System.Drawing.Size(58, 13)
        Me.lblTtlCost.TabIndex = 7
        Me.lblTtlCost.Text = "Total Cost:"
        '
        'lblTtlCalc
        '
        Me.lblTtlCalc.AutoSize = True
        Me.lblTtlCalc.Location = New System.Drawing.Point(350, 125)
        Me.lblTtlCalc.Name = "lblTtlCalc"
        Me.lblTtlCalc.Size = New System.Drawing.Size(13, 13)
        Me.lblTtlCalc.TabIndex = 8
        Me.lblTtlCalc.Text = "?"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(211, 168)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 9
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(336, 168)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 212)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblTtlCalc)
        Me.Controls.Add(Me.lblTtlCost)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.txtWidth)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblWidth)
        Me.Controls.Add(Me.lblLength)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmMain"
        Me.Text = "All-Around Fence Company"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblLength As System.Windows.Forms.Label
    Friend WithEvents lblWidth As System.Windows.Forms.Label
    Friend WithEvents lblCost As System.Windows.Forms.Label
    Friend WithEvents txtLength As System.Windows.Forms.TextBox
    Friend WithEvents txtWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents lblTtlCost As System.Windows.Forms.Label
    Friend WithEvents lblTtlCalc As System.Windows.Forms.Label
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
