Public Class Form1
    Dim decA, decB, decC As Decimal
    Private Sub txtLength_TextChanged(sender As Object, e As EventArgs) Handles txtLength.TextChanged
        txtLength.Text = decA
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtWidth_TextChanged(sender As Object, e As EventArgs) Handles txtWidth.TextChanged
        txtWidth.Text = decB
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnCalcAreaInSquareFeet_Click(sender As Object, e As EventArgs) Handles btnCalcAreaInSquareFeet.Click
        decC = decA * decB
    End Sub

    Private Sub lblAreaInSquareFeet_Click(sender As Object, e As EventArgs) Handles lblAreaInSquareFeet.Click
        lblAreaInSquareFeet = decC
    End Sub
End Class
