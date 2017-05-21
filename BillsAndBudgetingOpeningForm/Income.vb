' LANCE W MATYSIK, 2015

Option Explicit On
Option Strict On

Public Class Income
    Dim mIncome As String
    Dim mType As String
    Dim mAmount As Double
    Dim mPayDate As String

    Public Property incomeName() As String
        Get
            Return mIncome
        End Get
        Set(value As String)
            mIncome = value
        End Set
    End Property

    Public Property incomeType() As String
        Get
            Return mType
        End Get
        Set(value As String)
            mType = value
        End Set
    End Property

    Public Property incomeAmount() As Double
        Get
            Return mAmount
        End Get
        Set(value As Double)
            mAmount = value
        End Set
    End Property

    Public Property incomePayDate() As Date
        Get
            Return CDate(mPayDate)
        End Get
        Set(value As Date)
            mPayDate = CStr(value)
        End Set
    End Property
End Class
