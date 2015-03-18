' Name:         CD Project
' Purpose:      Adds and deletes list box entries
'               Reads information from a sequential access file
'               Writes information to a sequential access file
' Programmer:   Jamie Solus on 09202014

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    ' declare structure
    Private Structure MyCDs
        Dim strName As String
        Dim strArtist As String
        Dim strPrice As String
        Dim strConcatenatedInfo As String
        Dim dblPrice As Double
    End Structure

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' save the list box information

        ' declare a StreamWriter variable
        Dim outFile As IO.StreamWriter

        ' open the file for output
        outFile = IO.File.CreateText("CDs.txt")

        ' write each line in the list box
        For intIndex As Integer = 0 To lstCds.Items.Count - 1
            outFile.WriteLine(lstCds.Items(intIndex))
        Next intIndex

        ' close the file
        outFile.Close()

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fills the list box with data 
        ' stored in a sequential access file

        ' declare variables
        Dim inFile As IO.StreamReader
        Dim strInfo As String

        'open the file for input
        inFile = IO.File.OpenText("CDs.txt")

        'process loop instructions until end of file
        Do Until inFile.Peek = -1
            strInfo = inFile.ReadLine
            lstCds.Items.Add(strInfo)
        Loop

        'select the first line in the list box
        lstCds.SelectedIndex = 0

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' adds CD information to the list box

        'declares Structure variable
        Dim items As MyCDs

        ' get the CD information
        items.strName = InputBox("CD name:", "CD Collection")
        items.strArtist = InputBox("Artist:", "CD Collection")
        items.strPrice = InputBox("Price:", "CD Collection")

        ' format the price, then concatenate the
        ' input items, using 40 spaces for the 
        ' CD name, 25 spaces for the artist name,
        ' and 5 spaces for the price
        Double.TryParse(items.strPrice, items.dblPrice)
        items.strPrice = items.dblPrice.ToString("N2")

        items.strConcatenatedInfo = items.strName.PadRight(40) & items.strArtist.PadRight(25) & items.strPrice.PadLeft(5)

        ' add the information to the list box
        lstCds.Items.Add(items.strConcatenatedInfo)

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        ' removes the selected line from the list box
        If lstCds.SelectedIndex <> -1 Then
            lstCds.Items.RemoveAt(lstCds.SelectedIndex)
        End If

        ' if a line is selected, remove the line

    End Sub
End Class
