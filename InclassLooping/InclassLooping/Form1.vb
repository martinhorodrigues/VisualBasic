' Name:         Loop
' Purpose:      Gets number input to outputs multiplication table
' Programmer:   Jamie Solus on 02272014
Public Class Form1

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        Dim intX As Integer
        Dim intMult As Integer

        intX = TextBox1.Text

        For intX = 1 To 12
            intMult *= intX

            RichTextBox1.AppendText("The multiplication table is " & intMult.ToString())

            RichTextBox1.AppendText(TextBox1.Text * 0)
            RichTextBox1.AppendText(TextBox1.Text * 1)
            RichTextBox1.AppendText(TextBox1.Text * 2)
            RichTextBox1.AppendText(TextBox1.Text * 3)
            RichTextBox1.AppendText(TextBox1.Text * 4)
            RichTextBox1.AppendText(TextBox1.Text * 5)
            RichTextBox1.AppendText(TextBox1.Text * 6)
            RichTextBox1.AppendText(TextBox1.Text * 7)
            RichTextBox1.AppendText(TextBox1.Text * 8)
            RichTextBox1.AppendText(TextBox1.Text * 9)
            RichTextBox1.AppendText(TextBox1.Text * 10)
            RichTextBox1.AppendText(TextBox1.Text * 11)
            RichTextBox1.AppendText(TextBox1.Text * 12)
            Exit For
        Next

        If TextBox1.Text < 1 Or TextBox1.Text > 12 Then
            Label1.Text = "ERROR! Please Enter A New Number."
        Else : Label1.Text = " "
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        RichTextBox1.Clear()
    End Sub

End Class
