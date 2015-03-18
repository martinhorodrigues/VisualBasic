' Name:         Stop Light Algorithm
' Purpose:      User chooses the light color & police presence to get advise
' Programmer:   Jamie Solus on 03052014

Public Class Form1

    Private Sub btnAdvice_Click(sender As System.Object, e As System.EventArgs) Handles btnAdvice.Click
        Dim Red, Yellow, Green, Police As Boolean
        Dim Advise As String

        Red = radRed.Checked
        Yellow = radYellow.Checked
        Green = radGreen.Checked

        Police = chkPolice.Checked

        If Red Then
            Advise = "Stop The Car!"
        ElseIf Yellow And Police Then
            Advise = "Stop!"
        ElseIf Yellow Then
            Advise = "Speed Up!"
        ElseIf Green Then
            Advise = "Drive Normally!"
        End If

        lblOutput.Text = Advise


    End Sub
End Class
