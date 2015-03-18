Public Class Form1

    Private Sub btnGo_Click(sender As System.Object, e As System.EventArgs) Handles btnGo.Click
        WebBrowser1.Navigate(txtWebAddress.Text)
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtWebAddress.Text = "www.google.com"
        GoTo txtWebAddress.Text
    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        WebBrowser1.GoBack()
    End Sub

End Class
