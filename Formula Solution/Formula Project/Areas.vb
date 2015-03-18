' Class filename:       Areas.vb
' Created/revised by:   Jamie Solus on 09272014

Option Explicit On
Option Strict On
Option Infer Off

Public Class Parallelogram
    Public Property Base As Double
    Public Property Height As Double

    Public Sub New()
        _Base = 0
        _Height = 0
    End Sub

    Public Sub New(ByVal dblB As Double, ByVal dblH As Double)
        Base = dblB
        Height = dblH
    End Sub

    Public Overridable Function GetArea() As Double
        Return _Base * _Height
    End Function
End Class

Public Class Triangle ' Derived class
    Inherits Parallelogram ' Inherits from base class

    Public Sub New() ' Default constructor
        MyBase.New()
    End Sub

    Public Sub New(ByVal dblB As Double, ByVal dblH As Double) ' Parameterized constructor
        MyBase.New(dblB, dblH)
    End Sub

    Public Overrides Function GetArea() As Double
        Return MyBase.GetArea / 2
    End Function
End Class

