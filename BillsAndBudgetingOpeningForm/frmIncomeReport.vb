' LANCE W MATYSIK, 2015

Option Explicit On
Option Strict On


Public Class frmIncomeReport

    Private Sub frmIncomeReport_Load(sender As Object, e As EventArgs) Handles Me.Load

        For index As Integer = 0 To frmBillsAndBudgetMain.dgvIncome.RowCount - 1
            Dim nextDate As Date
            nextDate = CDate(frmBillsAndBudgetMain.dgvIncome.Rows(index).Cells("Recieve_Date").Value)
            cldrIncome.AddBoldedDate(nextDate)
        Next
        ' took me 30-50 minutes to figure out why the dates didn't bold........
        cldrIncome.UpdateBoldedDates()

        chtIncome.Series("Income").Points.Clear()
        chtIncome.Series("Income").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie

        For index = 0 To frmBillsAndBudgetMain.dgvIncome.Rows.Count - 1
            If frmBillsAndBudgetMain.dgvIncome.Rows.Count >= 1 Then
                chtIncome.Series("Income").Points.AddY(frmBillsAndBudgetMain.dgvIncome.Rows(index).Cells(1).Value, frmBillsAndBudgetMain.dgvIncome.Rows(index).Cells(3).Value)
            Else
                Exit For
            End If
        Next

    End Sub

End Class