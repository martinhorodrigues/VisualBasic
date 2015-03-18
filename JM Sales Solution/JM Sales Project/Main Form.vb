﻿' Name:         JM Sales Project
' Purpose:      Displays the records stored in a dataset
'               Allows the user to add and delete records
' Programmer:   Jamie Solus on 11132014

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AnnualSalesDataSet.tblSales' table. You can move, or remove it, as needed.
        Me.TblSalesTableAdapter.Fill(Me.AnnualSalesDataSet.tblSales)
        TblSalesBindingSource.Sort = "YearNum"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtYear_Enter(sender As Object, e As EventArgs) Handles txtYear.Enter
        txtYear.SelectAll()
    End Sub

    Private Sub txtSales_Enter(sender As Object, e As EventArgs) Handles txtSales.Enter
        txtSales.SelectAll()
    End Sub

    Private Sub CancelKeys(sender As Object, e As KeyPressEventArgs) Handles txtYear.KeyPress, txtSales.KeyPress
        ' allows the text box to accept only numbers and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtYear.Text.Trim = String.Empty OrElse
            txtSales.Text.Trim = String.Empty Then
            MessageBox.Show("Please enter all the information.", "JM Sales", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim intYear, intSales As Integer
            Integer.TryParse(txtYear.Text, intYear)
            Integer.TryParse(txtSales.Text, intSales)
            Try
                TblSalesTableAdapter.InsertQuery(intYear, intSales)
                TblSalesTableAdapter.Fill(AnnualSalesDataSet.tblSales)
            Catch ex As Exception
                MessageBox.Show("Duplicate Record", "Add Record",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim dlgButton As DialogResult
        dlgButton = MessageBox.Show("Delete Year from Sales " & lblDeleteYear.Text &
                                    "?", "Confirm Delete",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Exclamation)
        If dlgButton = Windows.Forms.DialogResult.Yes Then
            Dim intYear As Integer
            Integer.TryParse(lblDeleteYear.Text, intYear)
            TblSalesTableAdapter.DeleteQuery(intYear)
            TblSalesTableAdapter.Fill(AnnualSalesDataSet.tblSales)
        End If

    End Sub
End Class
