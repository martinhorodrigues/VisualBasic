' Name:         Mouse Manipulation
' Purpose:      Draws line with color & brush size options
' Programmer:   Jamie Solus on 04092014

Public Class Form1
    Public Pixel As Integer
    Public G As System.Drawing.Graphics
    Public DownX As Integer
    Public DownY As Integer
    Public UpX As Integer
    Public UpY As Integer

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        DownX = e.X
        DownY = e.Y
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        DownX = e.X
        DownY = e.Y
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseUp
        lblXCoordinate.Text = e.X
        lblYCoordinate.Text = e.Y
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnDraw_Click(sender As System.Object, e As System.EventArgs) Handles btnDraw.Click
        G = Panel1.CreateGraphics

        If radRed.Checked = True Then
            Dim P As New System.Drawing.Pen(Brushes.Red, Pixel)
            G.DrawLine(P, DownX, DownY, UpX, UpY)
        ElseIf radBlue.Checked = True Then
            Dim P As New System.Drawing.Pen(Brushes.Blue, Pixel)
            G.DrawLine(P, DownX, DownY, UpX, UpY)
        ElseIf radYellow.Checked = True Then
            Dim P As New System.Drawing.Pen(Brushes.Yellow, Pixel)
            G.DrawLine(P, DownX, DownY, UpX, UpY)
        End If

        If ComboBox1.SelectedIndex = 0 Then
            Pixel = 2
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Pixel = 12
        ElseIf ComboBox1.SelectedIndex = 2 Then
            Pixel = 22
        End If

    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub PenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PenToolStripMenuItem.Click
        Pixel = 2
    End Sub

    Private Sub BrushToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BrushToolStripMenuItem.Click
        Pixel = 12
    End Sub

    Private Sub SprayToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SprayToolStripMenuItem.Click
        Pixel = 22
    End Sub
End Class
