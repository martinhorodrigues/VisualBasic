' Name:         Running The Race
' Purpose:      Gets runner's name & time & displays race results 
' Programmer:   Jamie Solus on 03112014

Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim Runner1, Runner2, Runner3 As String
        Dim Time1, Time2, Time3 As Integer

        Try

            Runner1 = CStr(txtRunner1.Text)
            Runner2 = CStr(txtRunner2.Text)
            Runner3 = CStr(txtRunner3.Text)
            Time1 = CInt(txtTime1.Text)
            Time2 = CInt(txtTime2.Text)
            Time3 = CInt(txtTime3.Text)

            If Time1 < Time2 And Time1 < Time3 And Time2 < Time3 Then
                lbl1stRunner.Text = Runner1
                lbl2ndRunner.Text = Runner2
                lbl3rdRunner.Text = Runner3

            ElseIf Time1 < Time2 And Time1 < Time3 And Time3 < Time2 Then
                lbl1stRunner.Text = Runner1
                lbl3rdRunner.Text = Runner3
                lbl2ndRunner.Text = Runner2

            ElseIf Time2 < Time1 And Time2 < Time3 And Time1 < Time3 Then
                lbl1stRunner.Text = Runner2
                lbl3rdRunner.Text = Runner3
                lbl2ndRunner.Text = Runner1

            ElseIf Time2 < Time1 And Time2 < Time3 And Time3 < Time1 Then
                lbl1stRunner.Text = Runner2
                lbl3rdRunner.Text = Runner3
                lbl2ndRunner.Text = Runner1

            ElseIf Time3 < Time1 And Time3 < Time2 And Time1 < Time2 Then
                lbl1stRunner.Text = Runner3
                lbl3rdRunner.Text = Runner1
                lbl2ndRunner.Text = Runner2

            ElseIf Time3 < Time1 And Time3 < Time2 And Time2 < Time1 Then
                lbl1stRunner.Text = Runner3
                lbl3rdRunner.Text = Runner2
                lbl2ndRunner.Text = Runner1

            End If

        Catch ex As Exception
            MessageBox.Show("Runner Name Cannot Be Blank, And Finishing Times Must Be Both Numeric And Positive.")

        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtRunner1.Clear()
        txtRunner2.Clear()
        txtRunner3.Clear()
        txtTime1.Clear()
        txtTime2.Clear()
        txtTime3.Clear()
        lbl1stRunner.Text = String.Empty
        lbl2ndRunner.Text = String.Empty
        lbl3rdRunner.Text = String.Empty
        txtRunner1.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

End Class
