' Name:         Incomplete Loops
' Purpose:      Appends input to rich text box 
' Programmer:   Jamie Solus on 03122014

Public Class Form1

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click

        RichTextBox1.Clear()

    End Sub

    Private Sub btnGo_Click(sender As System.Object, e As System.EventArgs) Handles btnGo.Click

        Dim Size, N, Line, Output As Integer

        Size = txtSize.Text

        For Line = 1 To Size
            For N = 1 To Size
                Output = Line * N
                RichTextBox1.AppendText(Output & " ")
                If Output < 10 Then
                    RichTextBox1.AppendText(" ")
                End If
                If Output < 100 Then
                    RichTextBox1.AppendText(" ")
                End If
            Next N
            RichTextBox1.AppendText(vbNewLine)
        Next Line

    End Sub

    Private Sub btnGo2_Click(sender As System.Object, e As System.EventArgs) Handles btnGo2.Click

        Dim Size, N, Line, As Integer

        Size = txtSize.Text

        Line = 1
        While Line <= Size
            N = 1
            While N <= Size
                RichTextBox1.AppendText(N & " ")
                N = N + 1
            End While
            RichTextBox1.AppendText(vbNewLine)
            Line = Line + 1
        End While

    End Sub

End Class
