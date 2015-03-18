' Name:         Theater Revenue Form
' Purpose:      Gets price & tickets sold per adult & child tickets & caculates revenue
' Programmer:   Jamie Solus on 02282014

Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Const Net As Decimal = 0.2
        lblStatus.Text = String.Empty
        Try
            lblGrossAdult.Text = CDec(txtAdultPrice.Text) * CDec(txtAdultTickets.Text)
            lblGrossChild.Text = CDec(txtChildPrice.Text) * CDec(txtChildTickets.Text)
            lblTotalGross.Text = CDec(lblGrossAdult.Text) + CDec(lblGrossChild.Text)
            lblNetAdult.Text = CDec(lblGrossAdult.Text) * Net
            lblNetChild.Text = CDec(lblGrossChild.Text) * Net
            lblTotalNet.Text = CDec(lblNetAdult.Text) + CDec(lblNetChild.Text)
        Catch
            lblStatus.Text = ("All input must be valid numeric values.")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAdultPrice.Clear()
        txtAdultTickets.Clear()
        txtChildPrice.Clear()
        txtChildTickets.Clear()
        lblGrossAdult.Text = String.Empty
        lblGrossChild.Text = String.Empty
        lblTotalGross.Text = String.Empty
        lblNetAdult.Text = String.Empty
        lblNetChild.Text = String.Empty
        lblTotalNet.Text = String.Empty
        txtAdultPrice.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
