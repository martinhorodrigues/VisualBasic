'Name:          DJTom
'Purpose:       Display a message
'Programmer:    Jamie Solus on 10092014


Option Explicit On
Option Strict On
Option Infer Off

Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        'display the user's input in a message

        Dim strBride, strGroom, strWedDate, strEmail, strSong As String

        strBride = txtBride.Text.Trim
        strGroom = txtGroom.Text.Trim
        strWedDate = calWedding.SelectedDate.ToShortDateString
        strEmail = txtEmail.Text.Trim
        strSong = ddlSongs.SelectedItem.ToString

        lblMsg.Text = "Thank you " & strBride & " and " & strGroom & " for visiting my Web site. " &
            "<br /> <br />Wedding date: " & strWedDate & "<br/>Email address: " & strEmail &
            "<br />Song: " & strSong

    End Sub
End Class




