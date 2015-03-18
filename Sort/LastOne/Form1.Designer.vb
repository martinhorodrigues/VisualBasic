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
        Me.txtZ = New System.Windows.Forms.TextBox()
        Me.txtY = New System.Windows.Forms.TextBox()
        Me.txtX = New System.Windows.Forms.TextBox()
        Me.txtW = New System.Windows.Forms.TextBox()
        Me.lblW = New System.Windows.Forms.Label()
        Me.lblX = New System.Windows.Forms.Label()
        Me.lbly = New System.Windows.Forms.Label()
        Me.lblZ = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtZ
        '
        Me.txtZ.Location = New System.Drawing.Point(237, 190)
        Me.txtZ.Name = "txtZ"
        Me.txtZ.Size = New System.Drawing.Size(100, 26)
        Me.txtZ.TabIndex = 0
        '
        'txtY
        '
        Me.txtY.Location = New System.Drawing.Point(237, 144)
        Me.txtY.Name = "txtY"
        Me.txtY.Size = New System.Drawing.Size(100, 26)
        Me.txtY.TabIndex = 1
        '
        'txtX
        '
        Me.txtX.Location = New System.Drawing.Point(237, 99)
        Me.txtX.Name = "txtX"
        Me.txtX.Size = New System.Drawing.Size(100, 26)
        Me.txtX.TabIndex = 2
        '
        'txtW
        '
        Me.txtW.Location = New System.Drawing.Point(237, 55)
        Me.txtW.Name = "txtW"
        Me.txtW.Size = New System.Drawing.Size(100, 26)
        Me.txtW.TabIndex = 3
        '
        'lblW
        '
        Me.lblW.AutoSize = True
        Me.lblW.Location = New System.Drawing.Point(96, 55)
        Me.lblW.Name = "lblW"
        Me.lblW.Size = New System.Drawing.Size(24, 20)
        Me.lblW.TabIndex = 4
        Me.lblW.Text = "W"
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.Location = New System.Drawing.Point(96, 99)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(20, 20)
        Me.lblX.TabIndex = 5
        Me.lblX.Text = "X"
        '
        'lbly
        '
        Me.lbly.AutoSize = True
        Me.lbly.Location = New System.Drawing.Point(96, 144)
        Me.lbly.Name = "lbly"
        Me.lbly.Size = New System.Drawing.Size(20, 20)
        Me.lbly.TabIndex = 6
        Me.lbly.Text = "Y"
        '
        'lblZ
        '
        Me.lblZ.AutoSize = True
        Me.lblZ.Location = New System.Drawing.Point(96, 190)
        Me.lblZ.Name = "lblZ"
        Me.lblZ.Size = New System.Drawing.Size(19, 20)
        Me.lblZ.TabIndex = 7
        Me.lblZ.Text = "Z"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(96, 267)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Output:"
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(233, 267)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(18, 20)
        Me.lblOutput.TabIndex = 9
        Me.lblOutput.Text = "?"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(96, 326)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 25)
        Me.btnStart.TabIndex = 10
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(233, 325)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 25)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 388)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblZ)
        Me.Controls.Add(Me.lbly)
        Me.Controls.Add(Me.lblX)
        Me.Controls.Add(Me.lblW)
        Me.Controls.Add(Me.txtW)
        Me.Controls.Add(Me.txtX)
        Me.Controls.Add(Me.txtY)
        Me.Controls.Add(Me.txtZ)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtZ As System.Windows.Forms.TextBox
    Friend WithEvents txtY As System.Windows.Forms.TextBox
    Friend WithEvents txtX As System.Windows.Forms.TextBox
    Friend WithEvents txtW As System.Windows.Forms.TextBox
    Friend WithEvents lblW As System.Windows.Forms.Label
    Friend WithEvents lblX As System.Windows.Forms.Label
    Friend WithEvents lbly As System.Windows.Forms.Label
    Friend WithEvents lblZ As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
