Public Class frmBillsReport

    Private Sub frmBillsReport_Load(sender As Object, e As EventArgs) Handles Me.Load
        chtBills.Series("Bills").Points.Clear()

        For index As Integer = 0 To frmBillsAndBudgetMain.dgvBills.RowCount - 1
            Dim nextDate As Date
            nextDate = CDate(frmBillsAndBudgetMain.dgvBills.Rows(index).Cells("Due_Date").Value)
            cldrBills.AddBoldedDate(nextDate)
        Next
        ' took me 30-50 minutes to figure out why the dates didn't bold........
        cldrBills.UpdateBoldedDates()

        chtBills.Series("Bills").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie

        For index = 0 To frmBillsAndBudgetMain.dgvBills.Rows.Count - 1
            If frmBillsAndBudgetMain.dgvBills.Rows.Count >= 1 Then
                chtBills.Series("Bills").Points.AddXY(frmBillsAndBudgetMain.dgvBills.Rows(index).Cells(1).Value, frmBillsAndBudgetMain.dgvBills.Rows(index).Cells(3).Value)
            Else
                Exit For
            End If
        Next

        chtBills.UpdateAnnotations()
    End Sub
End Class