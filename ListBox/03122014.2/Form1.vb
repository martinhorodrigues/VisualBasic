' Name:         List Box
' Purpose:      Adds input to list box, which can be moved to another list box as well as deleted from either list box
' Programmer:   Jamie Solus on 03122014

Public Class Form1

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click

        lstBox1.Items.Clear()
        lstBox2.Items.Clear()

    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click

        Dim Input As String

        Input = txtInput.Text
        lstBox1.Items.Add(Input)

    End Sub

    Private Sub lstBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstBox1.SelectedIndexChanged

        lblSelected.Text = lstBox1.SelectedItem

    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click

        lstBox1.Items.Remove(lstBox1.SelectedItem)
        lstBox2.Items.Remove(lstBox2.SelectedItem)

    End Sub

    Private Sub btnRight_Click(sender As System.Object, e As System.EventArgs) Handles btnRight.Click

        Try
            If lstBox1.SelectedIndex <> -1 Then
                lstBox2.Items.Add(lstBox1.SelectedItem)
            End If

        Catch ex As Exception
            MessageBox.Show("Please Make A Selection")

        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click

        Try

            If lstBox2.SelectedIndex <> -1 Then
                lstBox1.Items.Add(lstBox2.SelectedItem)
            End If

        Catch ex As Exception
            MessageBox.Show("Please Make A Selection")

        End Try

    End Sub

    Private Sub lstBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBox2.SelectedIndexChanged

        lblSelected.Text = lstBox2.SelectedItem

    End Sub
End Class
