Public Class Game
    Private newCards As Cards
    Private Property someNumber As PictureBox

    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Pass perimeters this way, or
        newCards = New Cards()
        ' Pass perimeters or that way
        With newCards
            ._1 = "_1.jpg"
            ._2 = "_2.jpg"
            ._3 = "_3.jpg"
            ._4 = "_4.jpg"
            ._5 = "_5.jpg"
            ._6 = "_6.jpg"
            ._7 = "_7.jpg"
            ._8 = "_8.jpg"
            ._9 = "_9.jpg"
            ._10 = "_10.jpg"
            ._11 = "_11.jpg"
            ._12 = "_12.jpg"
            ._13 = "_13.jpg"
            ._14 = "_14.jpg"
            ._15 = "_15.jpg"
            ._16 = "_16.jpg"
            ._17 = "_17.jpg"
            ._18 = "_18.jpg"
            ._19 = "_19.jpg"
            ._20 = "_20.jpg"
            ._21 = "_21.jpg"
            ._22 = "_22.jpg"
            ._23 = "_23.jpg"
            ._24 = "_24.jpg"
            ._25 = "_25.jpg"
            ._26 = "_26.jpg"
            ._27 = "_27.jpg"
            ._28 = "_28.jpg"
            ._29 = "_29.jpg"
            ._30 = "_30.jpg"
            ._31 = "_31.jpg"
            ._32 = "_32.jpg"
            ._33 = "_33.jpg"
            ._34 = "_34.jpg"
            ._35 = "_35.jpg"
            ._36 = "_36.jpg"
            ._37 = "_37.jpg"
            ._38 = "_38.jpg"
            ._39 = "_39.jpg"
            ._40 = "_40.jpg"
            ._41 = "_41.jpg"
            ._42 = "_42.jpg"
            ._43 = "_43.jpg"
            ._44 = "_44.jpg"
            ._45 = "_45.jpg"
            ._46 = "_46.jpg"
            ._47 = "_47.jpg"
            ._48 = "_48.jpg"
            ._49 = "_49.jpg"
            ._50 = "_50.jpg"
            ._51 = "_51.jpg"
            ._52 = "_52.jpg"
        End With
    End Sub

    Function RandomDeal(a As Integer, b As Integer) As Integer()

        If a = b Then
            Throw New Exception("This Means War! Click Tie Breaker Button.")
        End If

        Dim count As Integer = (a - b)
        Dim randomNumbers(count) As Integer
        Dim rand As New Random()

        If a <= 0 AndAlso b >= 0 Then
            For i As Integer = 0 To count
                randomNumbers(i) = (a - 1)    ' Could also be max + 1
            Next i
        End If

        Dim counter As Integer = 0

        Do Until counter = count + 1
            Dim someNumber As Integer = rand.Next(a, b + 1)
            ' Only add the number if it is not already in the array
            If Not randomNumbers.Contains(someNumber) Then
                randomNumbers(counter) = someNumber
                counter += 1
            End If
        Loop
        Return randomNumbers
        PictureBox1 = someNumber
        PictureBox2 = someNumber
    End Function

    Private Sub btnDeal_Click(sender As Object, e As EventArgs) Handles btnDeal.Click

        Dim Image As Bitmap

        ' Retrieve the image.
        Dim _1 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_1.jpg")
        Dim _2 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_2.jpg")
        Dim _3 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_3.jpg")
        Dim _4 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_4.jpg")
        Dim _5 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_5.jpg")
        Dim _6 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_6.jpg")
        Dim _7 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_7.jpg")
        Dim _8 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_8.jpg")
        Dim _9 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_9.jpg")
        Dim _10 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_10.jpg")
        Dim _11 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_11.jpg")
        Dim _12 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_12.jpg")
        Dim _13 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_13.jpg")
        Dim _14 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_14.jpg")
        Dim _15 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_15.jpg")
        Dim _16 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_16.jpg")
        Dim _17 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_17.jpg")
        Dim _18 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_18.jpg")
        Dim _19 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_19.jpg")
        Dim _20 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_20.jpg")
        Dim _21 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_21.jpg")
        Dim _22 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_22.jpg")
        Dim _23 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_23.jpg")
        Dim _24 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_24.jpg")
        Dim _25 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_25.jpg")
        Dim _26 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_26.jpg")
        Dim _27 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_27.jpg")
        Dim _28 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_28.jpg")
        Dim _29 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_29.jpg")
        Dim _30 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_30.jpg")
        Dim _31 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_31.jpg")
        Dim _32 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_32.jpg")
        Dim _33 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_33.jpg")
        Dim _34 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_34.jpg")
        Dim _35 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_35.jpg")
        Dim _36 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_36.jpg")
        Dim _37 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_37.jpg")
        Dim _38 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_38.jpg")
        Dim _39 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_39.jpg")
        Dim _40 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_40.jpg")
        Dim _41 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_41.jpg")
        Dim _42 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_42.jpg")
        Dim _43 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_43.jpg")
        Dim _44 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_44.jpg")
        Dim _45 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_45.jpg")
        Dim _46 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_46.jpg")
        Dim _47 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_47.jpg")
        Dim _48 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_48.jpg")
        Dim _49 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_49.jpg")
        Dim _50 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_50.jpg")
        Dim _51 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_51.jpg")
        Dim _52 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_52.jpg")

        Dim x, y As Integer
        Image = Nothing

        ' Loop through the images pixels to reset color. 
        For x = 0 To Image.Width - 1
            For y = 0 To Image.Height - 1
                Dim pixelColor As Color = Image.GetPixel(x, y)
                Dim newColor As Color = Color.FromArgb(pixelColor.R, 0, 0)
                Image.SetPixel(x, y, newColor)
            Next
        Next

        ' Set the PictureBox to display the image.
        PictureBox1.Image = Image
        PictureBox2.Image = Image
    End Sub

    Function RandomTieBreaker(a As Integer, b As Integer) As Integer()

        If a = b Then
            Throw New Exception("Miss deal. Click deal again.")
        End If

        Dim count As Integer = (a - b)
        Dim randomNumbers(count) As Integer
        Dim rand As New Random()

        If a <= 0 AndAlso b >= 0 Then
            For i As Integer = 0 To count
                randomNumbers(i) = (a - 1)    ' Could also be max + 1
            Next i
        End If

        Dim counter As Integer = 0

        Do Until counter = count + 1
            Dim someNumber As Integer = rand.Next(a, b + 1)
            ' Only add the number if it is not already in the array
            If Not randomNumbers.Contains(someNumber) Then
                randomNumbers(counter) = someNumber
                counter += 1
            End If
        Loop
        Return randomNumbers
        PictureBox3 = someNumber
        PictureBox4 = someNumber
        PictureBox5 = someNumber
        PictureBox6 = someNumber
        PictureBox7 = someNumber
        PictureBox8 = someNumber
        PictureBox9 = someNumber
        PictureBox10 = someNumber
    End Function

    Private Sub btnTieBreaker_Click(sender As Object, e As EventArgs) Handles btnTieBreaker.Click
        Dim Image As Bitmap

        ' Retrieve the image.
        Dim _1 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_1.jpg")
        Dim _2 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_2.jpg")
        Dim _3 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_3.jpg")
        Dim _4 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_4.jpg")
        Dim _5 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_5.jpg")
        Dim _6 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_6.jpg")
        Dim _7 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_7.jpg")
        Dim _8 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_8.jpg")
        Dim _9 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_9.jpg")
        Dim _10 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_10.jpg")
        Dim _11 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_11.jpg")
        Dim _12 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_12.jpg")
        Dim _13 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_13.jpg")
        Dim _14 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_14.jpg")
        Dim _15 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_15.jpg")
        Dim _16 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_16.jpg")
        Dim _17 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_17.jpg")
        Dim _18 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_18.jpg")
        Dim _19 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_19.jpg")
        Dim _20 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_20.jpg")
        Dim _21 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_21.jpg")
        Dim _22 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_22.jpg")
        Dim _23 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_23.jpg")
        Dim _24 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_24.jpg")
        Dim _25 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_25.jpg")
        Dim _26 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_26.jpg")
        Dim _27 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_27.jpg")
        Dim _28 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_28.jpg")
        Dim _29 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_29.jpg")
        Dim _30 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_30.jpg")
        Dim _31 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_31.jpg")
        Dim _32 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_32.jpg")
        Dim _33 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_33.jpg")
        Dim _34 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_34.jpg")
        Dim _35 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_35.jpg")
        Dim _36 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_36.jpg")
        Dim _37 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_37.jpg")
        Dim _38 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_38.jpg")
        Dim _39 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_39.jpg")
        Dim _40 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_40.jpg")
        Dim _41 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_41.jpg")
        Dim _42 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_42.jpg")
        Dim _43 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_43.jpg")
        Dim _44 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_44.jpg")
        Dim _45 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_45.jpg")
        Dim _46 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_46.jpg")
        Dim _47 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_47.jpg")
        Dim _48 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_48.jpg")
        Dim _49 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_49.jpg")
        Dim _50 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_50.jpg")
        Dim _51 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_51.jpg")
        Dim _52 As Image = Drawing.Image.FromFile("E:\MJC\CSCI 222\Game\Game\Images\_52.jpg")

        Dim x, y As Integer
        Image = Nothing

        ' Loop through the images pixels to reset color. 
        For x = 0 To Image.Width - 1
            For y = 0 To Image.Height - 1
                Dim pixelColor As Color = Image.GetPixel(x, y)
                Dim newColor As Color = Color.FromArgb(pixelColor.R, 0, 0)
                Image.SetPixel(x, y, newColor)
            Next
        Next

        ' Set the PictureBox to display the image.
        PictureBox3.Image = Image
        PictureBox4.Image = Image
        PictureBox5.Image = Image
        PictureBox6.Image = Image
        PictureBox7.Image = Image
        PictureBox8.Image = Image
        PictureBox9.Image = Image
        PictureBox10.Image = Image

    End Sub

    Private Sub txtScore_TextChanged(sender As Object, e As EventArgs) Handles txtScore1.TextChanged
        Dim a, b, c, d As Integer
        Dim Score1, Score2 As Integer
        txtScore1.Text = Score1
        txtScore2.Text = Score2

        If a > b Then
            Score1 = Score1 + 1
        ElseIf a < b Then
            Score2 = Score2 + 1
        ElseIf a = b And c > d Then
            Score1 = Score1 + 1
        ElseIf a = b And c < d Then
            Score2 = Score2 + 1
        End If
    End Sub

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        txtScore1.Clear()
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub

End Class
