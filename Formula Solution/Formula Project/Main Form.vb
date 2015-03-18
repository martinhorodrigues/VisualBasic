' Name:         Formula Project
' Purpose:      Displays the area of either a parallelogram or a triangle
' Programmer:   Jamie Solus on 09272014

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub CancelKeys(sender As Object, e As KeyPressEventArgs) Handles txtBase.KeyPress, txtHeight.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles radParallelogram.CheckedChanged, radTriangle.CheckedChanged, txtBase.TextChanged, txtHeight.TextChanged
        lblAnswer.Text = String.Empty
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        Dim myTriangle As New Triangle ' Instantiate objects
        Dim myParallelogram As New Parallelogram

        Dim dblArea As Double ' variables to store objects' area
        Dim Area As Double

        Double.TryParse(txtBase.Text, myTriangle.Base) ' Assigns measurements to objects' properties
        Double.TryParse(txtHeight.Text, myTriangle.Height)
        Double.TryParse(txtBase.Text, myParallelogram.Base)
        Double.TryParse(txtHeight.Text, myParallelogram.Height)

        dblArea = myTriangle.GetArea ' Calculates the area
        Area = myParallelogram.GetArea

        If radTriangle.Checked = True Then
            lblAnswer.Text = dblArea.ToString("N1") ' Displays the area
        ElseIf radParallelogram.Checked = True Then
            lblAnswer.Text = Area.ToString("N1")
        End If

    End Sub
End Class
