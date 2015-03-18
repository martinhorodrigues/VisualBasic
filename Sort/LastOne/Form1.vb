' Name:         Sort
' Purpose:      Sorts input
' Programmer:   Jamie Solus on 04232014

Public Class Form1

    Sub DisplayWXYZ(ByVal W As Integer, ByVal X As Integer, ByVal Y As Integer, ByVal Z As Integer)
        lblOutput.Text = W & ", " & X & ", " & Y & ", " & Z
    End Sub
    Sub GetWXYZ(ByRef W As Integer, ByRef X As Integer, ByRef Y As Integer, ByRef Z As Integer)
        W = txtW.Text
        X = txtX.Text
        Y = txtY.Text
        Z = txtZ.Text
    End Sub

    Private Sub Swap(ByRef A As Integer, ByRef B As Integer)
        Dim C As Integer

        C = A
        A = B
        B = C
    End Sub

    Sub Sort2(ByRef A As Integer, ByRef B As Integer)

        If A > B Then
            Swap(A, B)
        End If
    End Sub

    Private Sub Sort4(ByRef W As Integer, ByRef X As Integer, ByRef Y As Integer, ByRef Z As Integer)
        Sort2(W, X)
        Sort2(W, Y)
        Sort2(W, Z)
        Sort2(X, Y)
        Sort2(X, Z)
        Sort2(Y, Z)
    End Sub

    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click
        Dim W, X, Y, Z As Integer

        GetWXYZ(W, X, Y, Z)
        Sort4(W, X, Y, Z)
        DisplayWXYZ(W, X, Y, Z)

    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class