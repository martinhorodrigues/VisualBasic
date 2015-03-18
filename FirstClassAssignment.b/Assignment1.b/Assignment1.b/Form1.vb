Public Class Form1

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        If Button1.Top > 150 Then
            Button1.Top = 50
        ElseIf Button1.Top <= 150 Then
            Button1.Top = 300
        End If
    End Sub
End Class
