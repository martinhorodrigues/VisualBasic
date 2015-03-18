' Purpose:      Form 3 - displays if user selects family plan options to get total price

Public Class frmFamilyPlan

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim NumberPhones As Integer
        Dim Subtotal4, Tax4, Total4, Options4, Package4, MonthlyCharge4 As Decimal

        NumberPhones = CInt(txtNumberPhones.Text)

        If radModel100.Checked = True Then
            Subtotal4 = 29.95D * NumberPhones
        ElseIf radModel110.Checked = True Then
            Subtotal4 = 49.95D * NumberPhones
        ElseIf radModel200.Checked = True Then
            Subtotal4 = 99.95D * NumberPhones
        End If

        If rad800Minutes.Checked = True Then
            Package4 = 45D
        ElseIf rad1500Minutes.Checked = True Then
            Package4 = 65D
        ElseIf radUnlimitedMinutes.Checked = True Then
            Package4 = 99D
        End If

        If chkEmail.Checked = True Then
            Options4 = 25D
        ElseIf chkText.Checked = True Then
            Options4 = 10D
        ElseIf chkEmail.Checked = True And chkText.Checked = True Then
            Options4 = 35D
        End If

        Tax4 = Subtotal4 * Tax
        Total4 = Subtotal4 + Tax4
        MonthlyCharge4 = Total4 + Options4 + Package4

        lblSubtotal4.Text = CStr(Subtotal4)
        lblTax4.Text = CStr(Tax4)
        lblTotal4.Text = CStr(Total4)
        lblOptions4.Text = CStr(Options4)
        lblPackage4.Text = CStr(Package4)
        lblMonthlyCharge4.Text = CStr(MonthlyCharge4)
    End Sub
End Class