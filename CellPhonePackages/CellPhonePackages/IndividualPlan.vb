' Purpose:      Form 2 - displays if user selects individual plan options to get total price

Public Class frmIndividualPlan

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim Subtotal2, Tax2, Total2, Options2, Package2, MonthlyCharge2 As Decimal

        If radModel100.Checked = True Then
            Subtotal2 = 29.95D
        ElseIf radModel110.Checked = True Then
            Subtotal2 = 49.95D
        ElseIf radModel200.Checked = True Then
            Subtotal2 = 99.95D
        End If

        If rad800Minutes.Checked = True Then
            Package2 = 45D
        ElseIf rad1500Minutes.Checked = True Then
            Package2 = 65D
        ElseIf radUnlimitedMinutes.Checked = True Then
            Package2 = 99D
        End If

        If chkEmail.Checked = True Then
            Options2 = 25D
        ElseIf chkText.Checked = True Then
            Options2 = 10D
        ElseIf chkEmail.Checked = True And chkText.Checked = True Then
            Options2 = 35D
        End If

        Tax2 = Subtotal2 * Tax
        Total2 = Subtotal2 + Tax2
        MonthlyCharge2 = Total2 + Options2 + Package2

        lblSubtotal2.Text = CStr(Subtotal2)
        lblTax2.Text = CStr(Tax2)
        lblTotal2.Text = CStr(Total2)
        lblOptions2.Text = CStr(Options2)
        lblPackage2.Text = CStr(Package2)
        lblMonthlyCharge2.Text = CStr(MonthlyCharge2)

    End Sub
End Class