' LANCE W MATYSIK, 2015

Option Explicit On
Option Strict On

Public Class Bill
    Dim mBill As String
    Dim mType As String
    Dim mAmount As Double
    Dim mPayDate As String

    Public Property billName() As String
        Get
            Return mBill
        End Get
        Set(value As String)
            mBill = value
        End Set
    End Property

    Public Property billType() As String
        Get
            Return mType
        End Get
        Set(value As String)
            mType = value
        End Set
    End Property

    Public Property billAmount() As Double
        Get
            Return mAmount
        End Get
        Set(value As Double)
            mAmount = value
        End Set
    End Property

    Public Property billPayDate() As Date
        Get
            Return CDate(mPayDate)
        End Get
        Set(value As Date)
            mPayDate = CStr(value)
        End Set
    End Property
End Class
