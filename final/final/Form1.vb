Public Class Form1

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim A As New Form2
        A.ShowDialog()
    End Sub

    Private Sub btnFormat_Click(sender As System.Object, e As System.EventArgs) Handles btnFormat.Click
        Dim Ch As Char
        Dim Length, N As Short

        Length = Input.Length - 1

        For Each Ch In Input()
            If Char.IsLetter(Ch) Then
                Output = Output & Ch
            End If
        Next

    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        ListBox1.Items.Clear()
    End Sub
End Class
