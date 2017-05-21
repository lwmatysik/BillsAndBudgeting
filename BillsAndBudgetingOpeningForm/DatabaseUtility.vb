' LANCE W MATYSIK, 2015

Option Explicit On
Option Strict On

Imports System.Data.SqlClient

Public Class DatabaseUtility

    Public Shared Function databaseConnect() As SqlConnection
        Dim connectionString As String = "Data Source=(localDB)\v11.0;AttachDbFilename=C:\Users\" & utilities.getUserName() & "\Documents\Visual Studio 2013\Projects\BillsAndBudgetingOpeningForm\BillsAndBudgetingOpeningForm\BillsAndIncomeTracker.mdf)"
        Dim dbConnection As New SqlConnection(connectionString)
        dbConnection.Open()
        Return dbConnection
    End Function

    Public Shared Sub databaseDisconnect(dbConnection As SqlConnection)
        dbConnection.Dispose()
    End Sub

End Class
