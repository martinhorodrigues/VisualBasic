' Name:         Chocolate Project
' Purpose:      Display the contents of an array
' Programmer:   Jamie Solus on 09172014

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    ' declare class-level array
    Private dblPounds() As Double = {35.6, 15, 67.9, 78.8, 2.5, 7}

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click

        lstPounds.Items.Clear()

        ' display the array's contents
        Dim A As Integer = dblPounds.GetUpperBound(0)
        For B As Integer = 0 To A
            lstPounds.Items.Add(dblPounds(B))
        Next B

    End Sub

    Private Sub btnForEachNext_Click(sender As Object, e As EventArgs) Handles btnForEachNext.Click

        lstPounds.Items.Clear()

        ' display the array's contents
        For Each X As String In dblPounds
            lstPounds.Items.Add(X)
        Next X

    End Sub

    Private Sub btnDoLoop_Click(sender As Object, e As EventArgs) Handles btnDoLoop.Click

        lstPounds.Items.Clear()

        ' display the array's contents
        Dim A As Integer = dblPounds.Length - 1
        Dim B As Integer
        Do While B <= A
            lstPounds.Items.Add(dblPounds(B))
            B = B + 1
        Loop

    End Sub

    Private Sub btnAscending_Click(sender As Object, e As EventArgs) Handles btnAscending.Click

        lstPounds.Items.Clear()

        ' sort the array values in ascending order
        Array.Sort(dblPounds)
        Dim B As Integer = dblPounds.GetUpperBound(0)
        For A As Integer = 0 To B
            lstPounds.Items.Add(dblPounds(A))
        Next A

    End Sub

    Private Sub btnDescending_Click(sender As Object, e As EventArgs) Handles btnDescending.Click

        lstPounds.Items.Clear()

        ' sort the array values in descending order
        Array.Sort(dblPounds)
        Array.Reverse(dblPounds)
        Dim B As Integer = dblPounds.GetUpperBound(0)
        For A As Integer = 0 To B
            lstPounds.Items.Add(dblPounds(A))
        Next A

    End Sub

End Class
