' Name:         Fence Solution
' Purpose:      Main form that calculates total cost
' Programmer:   Jamie Solus on 09272014

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        Dim Perimeter As New Rectangle ' Initiates Rectangle objects
        Dim dblPerimeter As Double

        Double.TryParse(txtLength.Text, Perimeter.Length) ' assigns values to object's Public properties
        Double.TryParse(txtWidth.Text, Perimeter.Width)

        dblPerimeter = Perimeter.GetPerimeter * txtCost.Text ' Invokes objects Getperimeter method & mutiplies by cost

        lblTtlCalc.Text = dblPerimeter.ToString("C2") ' Displays total cost

    End Sub

End Class
