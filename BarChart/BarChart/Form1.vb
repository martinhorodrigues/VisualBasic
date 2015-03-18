' Name:         Bar Chart
' Purpose:      Display the data in a list box
' Programmer:   Jamie Solus on 03192014
Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        Dim Stores As Integer
        Dim Sales As Integer
        Dim Asterisk As String = "*"
        Dim SalesData As String
        Dim Line As String = ""

        For Stores = 1 To 5
            SalesData = InputBox("Enter sales data for store " & Stores.ToString(), "Sales Data Entry")
            If SalesData <> "" Then
                Sales = CInt(SalesData)
                Line = "Store " & Stores.ToString & ": " & New String("*", (Sales / 100))
            End If
            lstChart.Items.Add(Line)
        Next

    End Sub

End Class
