' Name:         HR Sales Project
' Purpose:      Displays the records stored in a dataset
'               Allows the user to add records to a dataset
' Programmer:   Jamie Solus on 11/06/2014

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SalesDataSet.tblSales' table. You can move, or remove it, as needed.
        Me.TblSalesTableAdapter.Fill(Me.SalesDataSet.tblSales)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtMonth_Enter(sender As Object, e As EventArgs) Handles txtMonth.Enter
        txtMonth.SelectAll()
    End Sub

    Private Sub txtRecord_Enter(sender As Object, e As EventArgs) Handles txtRecord.Enter
        txtRecord.SelectAll()
    End Sub

    Private Sub txtSales_Enter(sender As Object, e As EventArgs) Handles txtSales.Enter
        txtSales.SelectAll()
    End Sub

    Private Sub txtYear_Enter(sender As Object, e As EventArgs) Handles txtYear.Enter
        txtYear.SelectAll()
    End Sub

    Private Sub txtRecord_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRecord.KeyPress, txtMonth.KeyPress, txtYear.KeyPress, txtSales.KeyPress
        ' allows the text box to accept only numbers and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim Month As Integer
        Dim Record As Integer
        Dim Sales As Integer
        Dim Year As Integer
        Integer.TryParse(txtMonth.Text, Month)
        Integer.TryParse(txtRecord.Text, Record)
        Integer.TryParse(txtSales.Text, Sales)
        Integer.TryParse(txtYear.Text, Year)

        SalesDataSet.tblSales.AddtblSalesRow(Record, Year, Month, Sales)

        TblSalesBindingSource.Sort = "RecordNum"

        Try
            TblSalesTableAdapter.Update(SalesDataSet.tblSales)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Add Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class
