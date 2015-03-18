' Name:         Color Project
' Purpose:      Displays an item's color 
' Programmer:   Jamie Solus on 09112014

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtItem_TextChanged(sender As Object, e As EventArgs) Handles txtItem.TextChanged
        lblColor.Text = String.Empty
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        Dim strInput As String
        strInput = txtItem.Text

        If strInput.Length = 7 Then
            If strInput.ToUpper Like "???B???" Then
                lblColor.Text = "Blue"
                lblColor.BackColor = Color.Blue
            ElseIf strInput.ToUpper Like "???G???" Then
                lblColor.Text = "Green"
                lblColor.BackColor = Color.Green
            ElseIf strInput.ToUpper Like "???R???" Then
                lblColor.Text = "Red"
                lblColor.BackColor = Color.Red
            ElseIf strInput.ToUpper Like "???W???" Then
                lblColor.Text = "White"
                lblColor.BackColor = Color.White
            End If
        Else : MessageBox.Show("Invalid item number! Seven characters required & fourth character must be B, G, R, or W.")
        End If

    End Sub

End Class
