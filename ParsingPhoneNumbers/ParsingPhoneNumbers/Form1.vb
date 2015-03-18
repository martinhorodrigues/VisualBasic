' Name:         Parsing Phone Numbers
' Purpose:      Removes characters & formats phone number 
' Programmer:   Jamie Solus on 03262014

Public Class Form1

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim Input, Output As String
        Dim I As Char
        Dim Length As Short

        Input = txtInput.Text

        Length = Input.Length - 1

        For Each I In Input
            If Char.IsNumber(I) Then
                Output = Output & I
            ElseIf Input.Length < 9 Then
                MessageBox.Show("Error! Please enter at least ten digits.")
                txtInput.Clear()
            End If
        Next

        Output = Output.Insert(0, "(")
        Output = Output.Insert(4, ")")
        Output = Output.Insert(8, "-")
        lblNumber.Text = Output
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
