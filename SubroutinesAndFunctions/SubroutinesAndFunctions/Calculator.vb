' Purpose:      Form 2 - Functions for calculator

Public Class Calculator
    Private Number As Decimal
    Private NumberEntered As Decimal
    Private Operation As String

    Public Property NumberToDisplay() As Decimal
        Get
            Return Number
        End Get
        Set(ByVal Value As Decimal)
            Number = Value
        End Set
    End Property

    Public Property OperationToPerform() As String
        Get
            Return Operation
        End Get
        Set(ByVal Value As String)
            Operation = Value
        End Set
    End Property

    Public Function Add(ByVal X As Decimal, ByVal Y As Decimal) As Decimal
        Dim Answer As Decimal
        Answer = X + Y
        Return Answer
    End Function

    Public Function Subtract(ByVal X As Decimal, ByVal Y As Decimal) As Decimal
        Dim Answer As Decimal
        Answer = X - Y
        Return Answer
    End Function

    Public Function Multiply(ByVal X As Decimal, ByVal Y As Decimal) As Decimal
        Dim Answer As Decimal
        Answer = X * Y
        Return Answer
    End Function

    Public Function Divide(ByVal X As Decimal, ByVal Y As Decimal) As Decimal
        Dim Answer As Decimal
        Answer = X / Y
        Return Answer
    End Function

    Public Function Result(ByVal Sum As Decimal) As Decimal
        Dim CurrentResult = Number

        If (Operation = "+") Then
            CurrentResult = Add(Number, Sum)
        ElseIf (Operation = "-") Then
            CurrentResult = Subtract(Number, Sum)
        ElseIf (Operation = "*") Then
            CurrentResult = Multiply(Number, Sum)
        ElseIf (Operation = "/") Then
            CurrentResult = Divide(Number, Sum)
        End If
        Return CurrentResult
    End Function
End Class

