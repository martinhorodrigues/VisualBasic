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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grpColors = New System.Windows.Forms.GroupBox()
        Me.radYellow = New System.Windows.Forms.RadioButton()
        Me.radBlue = New System.Windows.Forms.RadioButton()
        Me.radRed = New System.Windows.Forms.RadioButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblX = New System.Windows.Forms.Label()
        Me.lblY = New System.Windows.Forms.Label()
        Me.lblXCoordinate = New System.Windows.Forms.Label()
        Me.lblYCoordinate = New System.Windows.Forms.Label()
        Me.lblCoordinates = New System.Windows.Forms.Label()
        Me.btnDraw = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ColorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YellowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LinesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrushToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SprayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpColors.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(13, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(401, 358)
        Me.Panel1.TabIndex = 0
        '
        'grpColors
        '
        Me.grpColors.Controls.Add(Me.radYellow)
        Me.grpColors.Controls.Add(Me.radBlue)
        Me.grpColors.Controls.Add(Me.radRed)
        Me.grpColors.Location = New System.Drawing.Point(426, 49)
        Me.grpColors.Name = "grpColors"
        Me.grpColors.Size = New System.Drawing.Size(134, 161)
        Me.grpColors.TabIndex = 1
        Me.grpColors.TabStop = False
        Me.grpColors.Text = "Colors"
        '
        'radYellow
        '
        Me.radYellow.AutoSize = True
        Me.radYellow.ForeColor = System.Drawing.Color.Yellow
        Me.radYellow.Location = New System.Drawing.Point(10, 120)
        Me.radYellow.Name = "radYellow"
        Me.radYellow.Size = New System.Drawing.Size(73, 24)
        Me.radYellow.TabIndex = 2
        Me.radYellow.TabStop = True
        Me.radYellow.Text = "Yellow"
        Me.radYellow.UseVisualStyleBackColor = True
        '
        'radBlue
        '
        Me.radBlue.AutoSize = True
        Me.radBlue.ForeColor = System.Drawing.Color.Blue
        Me.radBlue.Location = New System.Drawing.Point(10, 80)
        Me.radBlue.Name = "radBlue"
        Me.radBlue.Size = New System.Drawing.Size(59, 24)
        Me.radBlue.TabIndex = 1
        Me.radBlue.TabStop = True
        Me.radBlue.Text = "Blue"
        Me.radBlue.UseVisualStyleBackColor = True
        '
        'radRed
        '
        Me.radRed.AutoSize = True
        Me.radRed.ForeColor = System.Drawing.Color.Red
        Me.radRed.Location = New System.Drawing.Point(10, 40)
        Me.radRed.Name = "radRed"
        Me.radRed.Size = New System.Drawing.Size(57, 24)
        Me.radRed.TabIndex = 0
        Me.radRed.TabStop = True
        Me.radRed.Text = "Red"
        Me.radRed.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Pen", "Brush", "Spray"})
        Me.ComboBox1.Location = New System.Drawing.Point(432, 234)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(84, 28)
        Me.ComboBox1.TabIndex = 2
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(436, 354)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 30)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.Location = New System.Drawing.Point(176, 395)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(24, 20)
        Me.lblX.TabIndex = 4
        Me.lblX.Text = "X:"
        '
        'lblY
        '
        Me.lblY.AutoSize = True
        Me.lblY.Location = New System.Drawing.Point(229, 395)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(24, 20)
        Me.lblY.TabIndex = 5
        Me.lblY.Text = "Y:"
        '
        'lblXCoordinate
        '
        Me.lblXCoordinate.AutoSize = True
        Me.lblXCoordinate.Location = New System.Drawing.Point(197, 395)
        Me.lblXCoordinate.Name = "lblXCoordinate"
        Me.lblXCoordinate.Size = New System.Drawing.Size(18, 20)
        Me.lblXCoordinate.TabIndex = 7
        Me.lblXCoordinate.Text = "?"
        '
        'lblYCoordinate
        '
        Me.lblYCoordinate.AutoSize = True
        Me.lblYCoordinate.Location = New System.Drawing.Point(250, 395)
        Me.lblYCoordinate.Name = "lblYCoordinate"
        Me.lblYCoordinate.Size = New System.Drawing.Size(18, 20)
        Me.lblYCoordinate.TabIndex = 8
        Me.lblYCoordinate.Text = "?"
        '
        'lblCoordinates
        '
        Me.lblCoordinates.AutoSize = True
        Me.lblCoordinates.Location = New System.Drawing.Point(15, 395)
        Me.lblCoordinates.Name = "lblCoordinates"
        Me.lblCoordinates.Size = New System.Drawing.Size(95, 20)
        Me.lblCoordinates.TabIndex = 9
        Me.lblCoordinates.Text = "Coordinates"
        '
        'btnDraw
        '
        Me.btnDraw.Location = New System.Drawing.Point(436, 294)
        Me.btnDraw.Name = "btnDraw"
        Me.btnDraw.Size = New System.Drawing.Size(75, 30)
        Me.btnDraw.TabIndex = 10
        Me.btnDraw.Text = "Draw"
        Me.btnDraw.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColorsToolStripMenuItem, Me.LinesToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(572, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ColorsToolStripMenuItem
        '
        Me.ColorsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RedToolStripMenuItem, Me.BlueToolStripMenuItem, Me.YellowToolStripMenuItem})
        Me.ColorsToolStripMenuItem.Name = "ColorsToolStripMenuItem"
        Me.ColorsToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.ColorsToolStripMenuItem.Text = "Colors"
        '
        'RedToolStripMenuItem
        '
        Me.RedToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.RedToolStripMenuItem.Name = "RedToolStripMenuItem"
        Me.RedToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.RedToolStripMenuItem.Text = "Red"
        '
        'BlueToolStripMenuItem
        '
        Me.BlueToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.BlueToolStripMenuItem.Name = "BlueToolStripMenuItem"
        Me.BlueToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.BlueToolStripMenuItem.Text = "Blue"
        '
        'YellowToolStripMenuItem
        '
        Me.YellowToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow
        Me.YellowToolStripMenuItem.Name = "YellowToolStripMenuItem"
        Me.YellowToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.YellowToolStripMenuItem.Text = "Yellow"
        '
        'LinesToolStripMenuItem
        '
        Me.LinesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenToolStripMenuItem, Me.BrushToolStripMenuItem, Me.SprayToolStripMenuItem})
        Me.LinesToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinesToolStripMenuItem.Name = "LinesToolStripMenuItem"
        Me.LinesToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.LinesToolStripMenuItem.Text = "Lines"
        '
        'PenToolStripMenuItem
        '
        Me.PenToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PenToolStripMenuItem.Name = "PenToolStripMenuItem"
        Me.PenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PenToolStripMenuItem.Text = "Pen"
        '
        'BrushToolStripMenuItem
        '
        Me.BrushToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrushToolStripMenuItem.Name = "BrushToolStripMenuItem"
        Me.BrushToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BrushToolStripMenuItem.Text = "Brush"
        '
        'SprayToolStripMenuItem
        '
        Me.SprayToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SprayToolStripMenuItem.Name = "SprayToolStripMenuItem"
        Me.SprayToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SprayToolStripMenuItem.Text = "Spray"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 420)
        Me.Controls.Add(Me.btnDraw)
        Me.Controls.Add(Me.lblCoordinates)
        Me.Controls.Add(Me.lblYCoordinate)
        Me.Controls.Add(Me.lblXCoordinate)
        Me.Controls.Add(Me.lblY)
        Me.Controls.Add(Me.lblX)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.grpColors)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Mouse Manipulation"
        Me.grpColors.ResumeLayout(False)
        Me.grpColors.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grpColors As System.Windows.Forms.GroupBox
    Friend WithEvents radYellow As System.Windows.Forms.RadioButton
    Friend WithEvents radBlue As System.Windows.Forms.RadioButton
    Friend WithEvents radRed As System.Windows.Forms.RadioButton
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblX As System.Windows.Forms.Label
    Friend WithEvents lblY As System.Windows.Forms.Label
    Friend WithEvents lblXCoordinate As System.Windows.Forms.Label
    Friend WithEvents lblYCoordinate As System.Windows.Forms.Label
    Friend WithEvents lblCoordinates As System.Windows.Forms.Label
    Friend WithEvents btnDraw As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ColorsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YellowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LinesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BrushToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SprayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
