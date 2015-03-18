' Name:         Select Case
' Purpose:      Gets temperature from user & displays select case label
' Programmer:   Jamie Solus on 02122014

Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles BtnStart.Click
        Dim Input As Short

        Input = txtInput.Text

        Select Case Input
            Case 0 To 19
                Label3.Text = "Subzero!"
            Case 20
                Label3.Text = "Frozen!"
            Case 21 To 30
                Label3.Text = "Freezing!"
            Case 31 To 40
                Label3.Text = "Colder!"
            Case 41 To 50
                Label3.Text = "Cold!"
            Case 51 To 60
                Label3.Text = "Cool!"
            Case 61 To 69
                Label3.Text = "Perfect!"
            Case 70 To 79
                Label3.Text = "Warm!"
            Case 80 To 89
                Label3.Text = "Warmer!"
            Case 90 To 99
                Label3.Text = "Hot!"
            Case Else
                Label3.Text = "Burning!"
        End Select

    End Sub
End Class
