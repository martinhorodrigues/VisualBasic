' Name:         Joes Automotive Form
' Purpose:      User chooses service options & gets price
' Programmer:   Jamie Solus on 04022014

Public Class Form1

    Const Tax As Decimal = 0.06D
    Const Oil As Decimal = 26D
    Const Lube As Decimal = 18D
    Const Radiator As Decimal = 30D
    Const Transmission As Decimal = 80D
    Const Inspection As Decimal = 15D
    Const Muffler As Decimal = 100D
    Const Tire As Decimal = 20D

    Public Function OilLubeCharges() As Decimal
        Dim OilLube As Decimal

        If chkOil.Checked = True And chkLube.Checked Then
            OilLube = Oil + Lube
        ElseIf chkOil.Checked = True Then
            OilLube = Oil
        ElseIf chkLube.Checked = True Then
            OilLube = Lube
        End If
        Return OilLube
    End Function

    Public Function FlushCharges() As Decimal
        Dim Flushes As Decimal

        If chkRadiator.Checked = True And chkTransmission.Checked = True Then
            Flushes = Radiator + Transmission
        ElseIf chkRadiator.Checked = True Then
            Flushes = Radiator
        ElseIf chkTransmission.Checked = True Then
            Flushes = Transmission
        End If
        Return Flushes
    End Function

    Public Function MiscCharges() As Decimal
        Dim Misc As Decimal

        If chkInspection.Checked = True And chkMuffler.Checked = True And chkTire.Checked = True Then
            Misc = Inspection + Muffler + Tire
        ElseIf chkInspection.Checked = True And chkMuffler.Checked = True Then
            Misc = Inspection + Muffler
        ElseIf chkInspection.Checked = True And chkTire.Checked = True Then
            Misc = Inspection + Tire
        ElseIf chkMuffler.Checked = True And chkTire.Checked = True Then
            Misc = Muffler + Tire
        ElseIf chkInspection.Checked = True Then
            Misc = Inspection
        ElseIf chkMuffler.Checked = True Then
            Misc = Muffler
        ElseIf chkTire.Checked = True Then
            Misc = Tire
        End If
        Return Misc
    End Function

    Public Function OtherCharges() As Decimal
        Dim Other, Parts, Labor As Decimal

        If Parts > 0 Then
            Other = Parts
        ElseIf Labor > 0 Then
            Other = Labor
        ElseIf Parts > 0 And Labor > 0 Then
            Other = Parts + Labor
        End If
        Return Other
    End Function

    Public Function TaxCharges() As Decimal
        Dim Tax, Parts As Decimal

        If Parts > 0 Then
            Tax = Parts * Tax
        End If
        TaxCharges = Tax
        Return Tax
    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim OilLube, Flushes, Misc, Other As Decimal
        Dim ServiceCharges As Decimal = OilLubeCharges() + FlushCharges() + MiscCharges()
        Dim TaxCharges As Decimal = CDec(txtParts.Text) * Tax
        Dim TotalCharges As Decimal = ServiceCharges + CDec(txtParts.Text) + TaxCharges

        lblServiceCharges.Text = ServiceCharges.ToString("c")
        lblPartsCharges.Text = txtParts.Text.ToString
        lblTaxCharges.Text = TaxCharges.ToString("c")
        lblTotalCharges.Text = TotalCharges.ToString("c")

        TotalCharges = OilLube + Flushes + Misc + Other + Tax + CDec(txtParts.Text)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        For Each X In grpOilLube.Controls
            If chkOil.Checked = True Then
                chkOil.Checked = False
            ElseIf chkLube.Checked = True Then
                chkLube.Checked = False
            End If
        Next
        For Each X In grpFlushes.Controls
            If chkRadiator.Checked Then
                chkRadiator.Checked = False
            ElseIf chkTransmission.Checked = True Then
                chkTransmission.Checked = False
            End If
        Next
        For Each X In grpMisc.Controls
            If chkInspection.Checked Then
                chkInspection.Checked = False
            ElseIf chkMuffler.Checked = True Then
                chkMuffler.Checked = False
            ElseIf chkTire.Checked = True Then
                chkTire.Checked = False
            End If
        Next
        For Each X In grpOther.Controls
            txtParts.Text = String.Empty
            txtLabor.Text = String.Empty
        Next

        For Each x In grpFees.Controls
            lblServiceCharges.Text = String.Empty
            lblPartsCharges.Text = String.Empty
            lblTaxCharges.Text = String.Empty
            lblTotalCharges.Text = String.Empty
        Next

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
