' Name:         Cell Phone Packages
' Purpose:      Form 1 - User chooses plan option
' Programmer:   Jamie Solus on 04182014

Public Class frmCellPhonePackages

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnIndividual_Click(sender As Object, e As EventArgs) Handles btnIndividual.Click
        Dim A As New frmIndividualPlan
        A.ShowDialog()
    End Sub

    Private Sub btnFamily_Click(sender As Object, e As EventArgs) Handles btnFamily.Click
        Dim B As New frmFamilyPlan
        B.ShowDialog()
    End Sub
End Class
