' Name:         Grade Book
' Purpose:      Averages student scores & displays letter grade
' Programmer:   Jamie Solus on 04202014
' Note: This code has errors

Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculateGrade_Click(sender As Object, e As EventArgs) Handles btnCalculateGrade.Click
        Dim Student1, Student2, Student3, Student4, Student5 As String
        Dim Grade1, Grade2, Grade3, Grade4, Grade5 As String
        Dim Score1, Score2, Score3, Score4, Score5, Score6, Score7, Score8, Score9, Score10, Score11, Score12, Score13, Score14, Score15, Score16, Score17, Score18, Score19, Score20 As Decimal

        Student1 = txtStudent1.Text
        Student2 = txtStudent2.Text
        Student3 = txtStudent3.Text
        Student4 = txtStudent4.Text
        Student5 = txtStudent5.Text
        Score1 = CDec(txtScore1.Text)
        Score2 = CDec(txtScore2.Text)
        Score3 = CDec(txtScore3.Text)
        Score4 = CDec(txtScore4.Text)
        Score5 = CDec(txtScore5.Text)
        Score6 = CDec(txtScore6.Text)
        Score7 = CDec(txtScore7.Text)
        Score8 = CDec(txtScore8.Text)
        Score9 = CDec(txtScore9.Text)
        Score10 = CDec(txtScore10.Text)
        Score11 = CDec(txtScore11.Text)
        Score12 = CDec(txtScore12.Text)
        Score13 = CDec(txtScore13.Text)
        Score14 = CDec(txtScore14.Text)
        Score15 = CDec(txtScore15.Text)
        Score16 = CDec(txtScore16.Text)
        Score17 = CDec(txtScore17.Text)
        Score18 = CDec(txtScore18.Text)
        Score19 = CDec(txtScore19.Text)
        Score10 = CDec(txtScore20.Text)

        If (Score1 + Score2 + Score3 + Score4 / 4) > 89.0 And (Score1 + Score2 + Score3 + Score4 / 4) < 101.0 Then
            Grade1 = "A"
        ElseIf (Score1 + Score2 + Score3 + Score4 / 4) > 79.0 And (Score1 + Score2 + Score3 + Score4 / 4) < 90.0 Then
            Grade1 = "B"
        ElseIf (Score1 + Score2 + Score3 + Score4 / 4) > 69.0 And (Score1 + Score2 + Score3 + Score4 / 4) < 80.0 Then
            Grade1 = "C"
        ElseIf (Score1 + Score2 + Score3 + Score4 / 4) > 59.0 And (Score1 + Score2 + Score3 + Score4 / 4) < 70.0 Then
            Grade1 = "D"
        ElseIf (Score1 + Score2 + Score3 + Score4 / 4) >= 0.0 And (Score1 + Score2 + Score3 + Score4 / 4) < 60.0 Then
        Else
            'Grade1 = "Invalid Score"
        End If

        If (Score5 + Score6 + Score7 + Score8 / 4) > 89.0 And (Score5 + Score6 + Score7 + Score8 / 4) < 101.0 Then
            Grade2 = "A"
        ElseIf (Score5 + Score6 + Score7 + Score8 / 4) > 79.0 And (Score5 + Score6 + Score7 + Score8 / 4) < 90.0 Then
            Grade2 = "B"
        ElseIf (Score5 + Score6 + Score7 + Score8 / 4) > 69.0 And (Score5 + Score6 + Score7 + Score8 / 4) < 80.0 Then
            Grade2 = "C"
        ElseIf (Score5 + Score6 + Score7 + Score8 / 4) > 59.0 And (Score5 + Score6 + Score7 + Score8 / 4) < 70.0 Then
            Grade2 = "D"
        ElseIf (Score5 + Score6 + Score7 + Score8 / 4) >= 0.0 And (Score5 + Score6 + Score7 + Score8 / 4) < 60.0 Then
        Else
            'Grade2 = "Invalid Score"
        End If

        If (Score9 + Score10 + Score11 + Score12 / 4) > 89.0 And (Score9 + Score10 + Score11 + Score12 / 4) < 101.0 Then
            Grade3 = "A"
        ElseIf (Score9 + Score10 + Score11 + Score12 / 4) > 79.0 And (Score9 + Score10 + Score11 + Score12 / 4) < 90.0 Then
            Grade3 = "B"
        ElseIf (Score9 + Score10 + Score11 + Score12 / 4) > 69.0 And (Score9 + Score10 + Score11 + Score12 / 4) < 80.0 Then
            Grade3 = "C"
        ElseIf (Score9 + Score10 + Score11 + Score12 / 4) > 59.0 And (Score9 + Score10 + Score11 + Score12 / 4) < 70.0 Then
            Grade3 = "D"
        ElseIf (Score9 + Score10 + Score11 + Score12 / 4) >= 0.0 And (Score9 + Score10 + Score11 + Score12 / 4) < 60.0 Then
        Else
            'Grade3 = "Invalid Score"
        End If

        If (Score13 + Score14 + Score15 + Score16 / 4) > 89.0 And (Score13 + Score14 + Score15 + Score16 / 4) < 101.0 Then
            Grade4 = "A"
        ElseIf (Score13 + Score14 + Score15 + Score16 / 4) > 79.0 And (Score13 + Score14 + Score15 + Score16 / 4) < 90.0 Then
            Grade4 = "B"
        ElseIf (Score13 + Score14 + Score15 + Score16 / 4) > 69.0 And (Score13 + Score14 + Score15 + Score16 / 4) < 80.0 Then
            Grade4 = "C"
        ElseIf (Score13 + Score14 + Score15 + Score16 / 4) > 59.0 And (Score13 + Score14 + Score15 + Score16 / 4) < 70.0 Then
            Grade4 = "D"
        ElseIf (Score13 + Score14 + Score15 + Score16 / 4) >= 0.0 And (Score13 + Score14 + Score15 + Score16 / 4) < 60.0 Then
        Else
            'Grade4 = "Invalid Score"
        End If

        If (Score17 + Score18 + Score19 + Score20 / 4) > 89.0 And (Score17 + Score18 + Score19 + Score20 / 4) < 101.0 Then
            Grade5 = "A"
        ElseIf (Score17 + Score18 + Score19 + Score20 / 4) > 79.0 And (Score17 + Score18 + Score19 + Score20 / 4) < 90.0 Then
            Grade5 = "B"
        ElseIf (Score17 + Score18 + Score19 + Score20 / 4) > 69.0 And (Score17 + Score18 + Score19 + Score20 / 4) < 80.0 Then
            Grade5 = "C"
        ElseIf (Score17 + Score18 + Score19 + Score20 / 4) > 59.0 And (Score17 + Score18 + Score19 + Score20 / 4) < 70.0 Then
            Grade5 = "D"
        ElseIf (Score17 + Score18 + Score19 + Score20 / 4) >= 0.0 And (Score17 + Score18 + Score19 + Score20 / 4) < 60.0 Then
        Else
            'Grade5 = "Invalid Score"
        End If

        Dim Students() As String = {Student1, Grade1, CStr((Score1 + Score2 + Score3 + Score4) / 4), Student2, Grade2, CStr((Score5 + Score6 + Score7 + Score8) / 4), Student3, Grade3, CStr((Score9 + Score10 + Score11 + Score12) / 4), Student4, Grade4, CStr((Score13 + Score14 + Score15 + Score16) / 4), Student5, Grade5, CStr((Score17 + Score18 + Score19 + Score20) / 4)}
        For i = 0 To Students.Length - 1
            Dim strTemp() As String = Students(i).Split(CChar(","))
            MsgBox(strTemp(0))
        Next

    End Sub

End Class
