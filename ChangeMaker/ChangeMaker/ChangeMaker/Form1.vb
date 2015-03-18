' Name:         Change Maker
' Purpose:      Display number of coins
' Programmer:   Jamie Solus on 02032014

Public Class Form1

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click

        Const TotalQuarters As Integer = 25
        Const TotalDimes As Integer = 10
        Const TotalNickels As Integer = 5
        Const TotalPennies As Integer = 1

        Dim NumberOfCents, Change, Quarters, Dimes, Nickels, Pennies As Integer

        NumberOfCents = CInt(txtNumberOfCents.Text)
        Change = NumberOfCents

        Quarters = CInt(NumberOfCents / TotalQuarters)
        Dimes = CInt(NumberOfCents / TotalDimes)
        Nickels = CInt(NumberOfCents / TotalNickels)
        Pennies = CInt(NumberOfCents / TotalPennies)

        lblQuarters.Text = CStr(Quarters)
        lblDimes.Text = CStr(Dimes)
        lblNickels.Text = CStr(Nickels)
        lblPennies.Text = CStr(Pennies)

    End Sub
End Class
