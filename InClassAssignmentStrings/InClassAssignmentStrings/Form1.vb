' Name:         Strings
' Purpose:      Turn character input to output & displays goodbye on exit
' Programmer:   Jamie Solus on 03262014
Public Class Form1

    Private Sub btnGo_Click(sender As System.Object, e As System.EventArgs) Handles btnGo.Click
        Dim Input, Output As String
        Dim Ch As Char
        Dim Length, N As Short
        Input = txtInput.Text

        Length = Input.Length - 1

        For Each Ch In Input
            If Char.IsLetter(Ch) Then
                Output = Output & Ch
            End If
        Next

        lblOutput.Text = Output

    End Sub

    Sub ExitProgram()
        MsgBox("Goodbye!", MsgBoxStyle.Information)
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        ExitProgram()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        ExitProgram()
    End Sub
End Class
