' Name:         Metrics
' Purpose:      Converts kilograms & centimeters to pounds, feet, & inches
' Programmer:   Jamie Solus on 02062014

Public Class Form1

    Private Sub btnGo_Click(sender As System.Object, e As System.EventArgs) Handles btnGo.Click

        Const PoundsInKilogram As Single = 2.2
        Const InchesInFeet As Single = 12
        Const CentimeterInInch As Single = 2.54

        Dim Kilograms, Centimeters, Pounds, Feet, Inches As Integer

        Kilograms = txtKilograms.Text
        Centimeters = txtCentimeters.Text

        Pounds = txtKilograms.Text / PoundsInKilogram
        Feet = txtCentimeters.Text / InchesInFeet
        Inches = txtCentimeters.Text / CentimeterInInch

        lblPounds.Text = Pounds
        lblFeet.Text = Feet
        lblInches.Text = Inches

    End Sub


End Class
