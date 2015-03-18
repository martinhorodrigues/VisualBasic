' Name:         Subroutines and Functions
' Purpose:      Form 1 - Subroutines for calculator
' Programmer:   Jamie Solus on 04162014

Public Class Form1
    Dim Display As New Calculator()

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Display.OperationToPerform = "+"
        Display.NumberToDisplay = lblAnswer.Text
        lblAnswer.Text = ""
    End Sub

    Private Sub btnSubtract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubtract.Click
        Display.OperationToPerform = "-"
        Display.NumberToDisplay = lblAnswer.Text
        lblAnswer.Text = ""
    End Sub

    Private Sub btnMultiply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMultiply.Click
        Display.OperationToPerform = "*"
        Display.NumberToDisplay = lblAnswer.Text
        lblAnswer.Text = ""
    End Sub

    Private Sub btnDivide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDivide.Click
        Display.OperationToPerform = "/"
        Display.NumberToDisplay = lblAnswer.Text
        lblAnswer.Text = ""
    End Sub

    Private Sub btnEqual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEqual.Click
        lblAnswer.Text = Display.Result(lblAnswer.Text)
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        If (lblAnswer.Text = "0") Then
            lblAnswer.Text = 1
        Else
            lblAnswer.Text = lblAnswer.Text & "1"
        End If
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        If (lblAnswer.Text = "0") Then
            lblAnswer.Text = 2
        Else
            lblAnswer.Text = lblAnswer.Text & "2"
        End If
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        If (lblAnswer.Text = "0") Then
            lblAnswer.Text = 3
        Else
            lblAnswer.Text = lblAnswer.Text & "3"
        End If
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        If (lblAnswer.Text = "0") Then
            lblAnswer.Text = 4
        Else
            lblAnswer.Text = lblAnswer.Text & "4"
        End If
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        If (lblAnswer.Text = "0") Then
            lblAnswer.Text = 5
        Else
            lblAnswer.Text = lblAnswer.Text & "5"
        End If
    End Sub

    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        If (lblAnswer.Text = "0") Then
            lblAnswer.Text = 6
        Else
            lblAnswer.Text = lblAnswer.Text & "6"
        End If
    End Sub

    Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click
        If (lblAnswer.Text = "0") Then
            lblAnswer.Text = 7
        Else
            lblAnswer.Text = lblAnswer.Text & "7"
        End If
    End Sub

    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
        If (lblAnswer.Text = "0") Then
            lblAnswer.Text = 8
        Else
            lblAnswer.Text = lblAnswer.Text & "8"
        End If
    End Sub

    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
        If (lblAnswer.Text = "0") Then
            lblAnswer.Text = 9
        Else
            lblAnswer.Text = lblAnswer.Text & "9"
        End If
    End Sub

    Private Sub btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click
        If (lblAnswer.Text = "0") Then
            lblAnswer.Text = 0
        Else
            lblAnswer.Text = lblAnswer.Text & "0"
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblAnswer.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

