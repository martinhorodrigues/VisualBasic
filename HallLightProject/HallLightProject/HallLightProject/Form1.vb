' Name:         Hall Light
' Purpose:      Turns light off & on
' Programmer:   Jamie Solus on 02062014

Public Class Form1

    Private Sub btnSwitchOn_Click(sender As System.Object, e As System.EventArgs) Handles btnSwitchOn.Click

        If btnSwitchOn.Text = "ON" Then
            btnSwitchOn.Text = "OFF"
        Else
            btnSwitchOn.Text = "ON"
        End If

        If btnSwitchOn.Text = "ON" Then
            picLightOn.Visible = True
        Else
            picLightOn.Visible = False
        End If
    End Sub

    Private Sub btnSwitchOff_Click(sender As System.Object, e As System.EventArgs) Handles btnSwitchOff.Click

        If btnSwitchOff.Text = "ON" Then
            btnSwitchOff.Text = "OFF"
        Else
            btnSwitchOff.Text = "ON"
        End If

        If btnSwitchOn.Text = "ON" Or btnSwitchOff.Text = "ON" And Not btnSwitchOn.Text = "ON" And btnSwitchOff.Text = "ON" Then
            picLightOn.Visible = True
        Else
            picLightOn.Visible = False
        End If
    End Sub

End Class
