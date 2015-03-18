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
        Me.lblInstruction = New System.Windows.Forms.Label()
        Me.lblRunner1 = New System.Windows.Forms.Label()
        Me.lblRunner2 = New System.Windows.Forms.Label()
        Me.lblRunner3 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtRunner1 = New System.Windows.Forms.TextBox()
        Me.txtRunner2 = New System.Windows.Forms.TextBox()
        Me.txtRunner3 = New System.Windows.Forms.TextBox()
        Me.txtTime1 = New System.Windows.Forms.TextBox()
        Me.txtTime2 = New System.Windows.Forms.TextBox()
        Me.txtTime3 = New System.Windows.Forms.TextBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.grpRaceResults = New System.Windows.Forms.GroupBox()
        Me.lbl3rdRunner = New System.Windows.Forms.Label()
        Me.lbl2ndRunner = New System.Windows.Forms.Label()
        Me.lbl1stRunner = New System.Windows.Forms.Label()
        Me.lbl3rdPlace = New System.Windows.Forms.Label()
        Me.lbl2ndPlace = New System.Windows.Forms.Label()
        Me.lbl1stPlace = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpRaceResults.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblInstruction
        '
        Me.lblInstruction.AutoSize = True
        Me.lblInstruction.Location = New System.Drawing.Point(4, 13)
        Me.lblInstruction.Name = "lblInstruction"
        Me.lblInstruction.Size = New System.Drawing.Size(392, 20)
        Me.lblInstruction.TabIndex = 0
        Me.lblInstruction.Text = "Enter The Three Runners' Names And Finishing Times"
        '
        'lblRunner1
        '
        Me.lblRunner1.AutoSize = True
        Me.lblRunner1.Location = New System.Drawing.Point(12, 87)
        Me.lblRunner1.Name = "lblRunner1"
        Me.lblRunner1.Size = New System.Drawing.Size(79, 20)
        Me.lblRunner1.TabIndex = 1
        Me.lblRunner1.Text = "Runner 1:"
        '
        'lblRunner2
        '
        Me.lblRunner2.AutoSize = True
        Me.lblRunner2.Location = New System.Drawing.Point(12, 122)
        Me.lblRunner2.Name = "lblRunner2"
        Me.lblRunner2.Size = New System.Drawing.Size(79, 20)
        Me.lblRunner2.TabIndex = 2
        Me.lblRunner2.Text = "Runner 2:"
        '
        'lblRunner3
        '
        Me.lblRunner3.AutoSize = True
        Me.lblRunner3.Location = New System.Drawing.Point(12, 154)
        Me.lblRunner3.Name = "lblRunner3"
        Me.lblRunner3.Size = New System.Drawing.Size(79, 20)
        Me.lblRunner3.TabIndex = 3
        Me.lblRunner3.Text = "Runner 3:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(97, 55)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(51, 20)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Name"
        '
        'txtRunner1
        '
        Me.txtRunner1.Location = New System.Drawing.Point(97, 87)
        Me.txtRunner1.Name = "txtRunner1"
        Me.txtRunner1.Size = New System.Drawing.Size(100, 26)
        Me.txtRunner1.TabIndex = 5
        '
        'txtRunner2
        '
        Me.txtRunner2.Location = New System.Drawing.Point(97, 122)
        Me.txtRunner2.Name = "txtRunner2"
        Me.txtRunner2.Size = New System.Drawing.Size(100, 26)
        Me.txtRunner2.TabIndex = 7
        '
        'txtRunner3
        '
        Me.txtRunner3.Location = New System.Drawing.Point(97, 154)
        Me.txtRunner3.Name = "txtRunner3"
        Me.txtRunner3.Size = New System.Drawing.Size(100, 26)
        Me.txtRunner3.TabIndex = 9
        '
        'txtTime1
        '
        Me.txtTime1.Location = New System.Drawing.Point(277, 87)
        Me.txtTime1.Name = "txtTime1"
        Me.txtTime1.Size = New System.Drawing.Size(100, 26)
        Me.txtTime1.TabIndex = 6
        '
        'txtTime2
        '
        Me.txtTime2.Location = New System.Drawing.Point(277, 122)
        Me.txtTime2.Name = "txtTime2"
        Me.txtTime2.Size = New System.Drawing.Size(100, 26)
        Me.txtTime2.TabIndex = 8
        '
        'txtTime3
        '
        Me.txtTime3.Location = New System.Drawing.Point(277, 154)
        Me.txtTime3.Name = "txtTime3"
        Me.txtTime3.Size = New System.Drawing.Size(100, 26)
        Me.txtTime3.TabIndex = 10
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(277, 61)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(43, 20)
        Me.lblTime.TabIndex = 11
        Me.lblTime.Text = "Time"
        '
        'grpRaceResults
        '
        Me.grpRaceResults.Controls.Add(Me.lbl3rdRunner)
        Me.grpRaceResults.Controls.Add(Me.lbl2ndRunner)
        Me.grpRaceResults.Controls.Add(Me.lbl1stRunner)
        Me.grpRaceResults.Controls.Add(Me.lbl3rdPlace)
        Me.grpRaceResults.Controls.Add(Me.lbl2ndPlace)
        Me.grpRaceResults.Controls.Add(Me.lbl1stPlace)
        Me.grpRaceResults.Location = New System.Drawing.Point(16, 189)
        Me.grpRaceResults.Name = "grpRaceResults"
        Me.grpRaceResults.Size = New System.Drawing.Size(361, 114)
        Me.grpRaceResults.TabIndex = 12
        Me.grpRaceResults.TabStop = False
        Me.grpRaceResults.Text = "Race Results"
        '
        'lbl3rdRunner
        '
        Me.lbl3rdRunner.AutoSize = True
        Me.lbl3rdRunner.Location = New System.Drawing.Point(210, 80)
        Me.lbl3rdRunner.Name = "lbl3rdRunner"
        Me.lbl3rdRunner.Size = New System.Drawing.Size(18, 20)
        Me.lbl3rdRunner.TabIndex = 5
        Me.lbl3rdRunner.Text = "?"
        '
        'lbl2ndRunner
        '
        Me.lbl2ndRunner.AutoSize = True
        Me.lbl2ndRunner.Location = New System.Drawing.Point(210, 55)
        Me.lbl2ndRunner.Name = "lbl2ndRunner"
        Me.lbl2ndRunner.Size = New System.Drawing.Size(18, 20)
        Me.lbl2ndRunner.TabIndex = 4
        Me.lbl2ndRunner.Text = "?"
        '
        'lbl1stRunner
        '
        Me.lbl1stRunner.AutoSize = True
        Me.lbl1stRunner.Location = New System.Drawing.Point(210, 30)
        Me.lbl1stRunner.Name = "lbl1stRunner"
        Me.lbl1stRunner.Size = New System.Drawing.Size(18, 20)
        Me.lbl1stRunner.TabIndex = 3
        Me.lbl1stRunner.Text = "?"
        '
        'lbl3rdPlace
        '
        Me.lbl3rdPlace.AutoSize = True
        Me.lbl3rdPlace.Location = New System.Drawing.Point(80, 80)
        Me.lbl3rdPlace.Name = "lbl3rdPlace"
        Me.lbl3rdPlace.Size = New System.Drawing.Size(79, 20)
        Me.lbl3rdPlace.TabIndex = 2
        Me.lbl3rdPlace.Text = "3rd Place:"
        '
        'lbl2ndPlace
        '
        Me.lbl2ndPlace.AutoSize = True
        Me.lbl2ndPlace.Location = New System.Drawing.Point(80, 55)
        Me.lbl2ndPlace.Name = "lbl2ndPlace"
        Me.lbl2ndPlace.Size = New System.Drawing.Size(83, 20)
        Me.lbl2ndPlace.TabIndex = 1
        Me.lbl2ndPlace.Text = "2nd Place:"
        '
        'lbl1stPlace
        '
        Me.lbl1stPlace.AutoSize = True
        Me.lbl1stPlace.Location = New System.Drawing.Point(80, 30)
        Me.lbl1stPlace.Name = "lbl1stPlace"
        Me.lbl1stPlace.Size = New System.Drawing.Size(78, 20)
        Me.lbl1stPlace.TabIndex = 0
        Me.lbl1stPlace.Text = "1st Place:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(55, 317)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(84, 35)
        Me.btnCalculate.TabIndex = 13
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(160, 317)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 35)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(254, 317)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 34)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 369)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpRaceResults)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.txtTime3)
        Me.Controls.Add(Me.txtTime2)
        Me.Controls.Add(Me.txtTime1)
        Me.Controls.Add(Me.txtRunner3)
        Me.Controls.Add(Me.txtRunner2)
        Me.Controls.Add(Me.txtRunner1)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblRunner3)
        Me.Controls.Add(Me.lblRunner2)
        Me.Controls.Add(Me.lblRunner1)
        Me.Controls.Add(Me.lblInstruction)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Race Results"
        Me.grpRaceResults.ResumeLayout(False)
        Me.grpRaceResults.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInstruction As System.Windows.Forms.Label
    Friend WithEvents lblRunner1 As System.Windows.Forms.Label
    Friend WithEvents lblRunner2 As System.Windows.Forms.Label
    Friend WithEvents lblRunner3 As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtRunner1 As System.Windows.Forms.TextBox
    Friend WithEvents txtRunner2 As System.Windows.Forms.TextBox
    Friend WithEvents txtRunner3 As System.Windows.Forms.TextBox
    Friend WithEvents txtTime1 As System.Windows.Forms.TextBox
    Friend WithEvents txtTime2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTime3 As System.Windows.Forms.TextBox
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents grpRaceResults As System.Windows.Forms.GroupBox
    Friend WithEvents lbl3rdRunner As System.Windows.Forms.Label
    Friend WithEvents lbl2ndRunner As System.Windows.Forms.Label
    Friend WithEvents lbl1stRunner As System.Windows.Forms.Label
    Friend WithEvents lbl3rdPlace As System.Windows.Forms.Label
    Friend WithEvents lbl2ndPlace As System.Windows.Forms.Label
    Friend WithEvents lbl1stPlace As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
