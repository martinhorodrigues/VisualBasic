Module Module1
    Public Input, Output, Length As String
    Input = txtInput.Text

    ListBox1.Items.Add(txtInput.Text)

    Sub Input(ByRef I As String)

        Input(I) = txtInput.Text
        ListBox.Items.Add(I)

    End Sub
End Module
