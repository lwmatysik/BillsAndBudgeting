' LANCE W MATYSIK, 2015

Option Explicit On
Option Strict On

Imports System.Data.SqlClient

Public Class frmBillsAndBudgetMain

    Private Property incomeRowIndex As Integer
    Private Property billRowIndex As Integer

    Dim incomeData As New DataSet()
    Dim billData As New DataSet()

    Private Sub btnAddIncome_Click(sender As Object, e As EventArgs) Handles btnAddIncome.Click
        frmAddIncome.Show()
    End Sub

    Private Sub btnAddBill_Click(sender As Object, e As EventArgs) Handles btnAddBill.Click
        frmAddBill.Show()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        frmIncomeReport.Show()
    End Sub

    Private Sub btnBillReport_Click(sender As Object, e As EventArgs) Handles btnBillReport.Click
        frmBillsReport.Show()
    End Sub

    Private Sub BillsAndBudgetMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        populateIncome()
        populateBills()
        populateDifferences()
    End Sub

    Private Sub populateDifferences()
        Dim getTotalDifference As Double

        If String.IsNullOrEmpty(txtIncomeGrandTotal.Text) Then
            txtIncomeGrandTotal.Text = "0.00"
        End If

        If String.IsNullOrEmpty(txtBillsGrandTotal.Text) Then
            txtBillsGrandTotal.Text = "0.00"
        End If

        If String.IsNullOrEmpty(txtDifference.Text) Then
            txtDifference.Text = "0.00"
        End If

        If dgvBills.Rows.Count > 0 Then
            Dim billsAmountTotal As Double
            For index As Integer = 0 To dgvBills.RowCount - 1
                billsAmountTotal += CDbl(dgvBills.Rows(index).Cells(3).Value)
            Next
            txtBillsGrandTotal.Text = billsAmountTotal.ToString("c")
        End If

        If dgvIncome.Rows.Count > 0 Then
            Dim incomeAmountTotal As Double
            For index As Integer = 0 To dgvIncome.RowCount - 1
                incomeAmountTotal += CDbl(dgvIncome.Rows(index).Cells(3).Value)
            Next
            txtIncomeGrandTotal.Text = incomeAmountTotal.ToString("c")
        End If

        getTotalDifference = CDbl(txtIncomeGrandTotal.Text) - CDbl(txtBillsGrandTotal.Text)

        If getTotalDifference >= 0 Then
            txtDifference.ReadOnly = False
            txtDifference.Text = getTotalDifference.ToString("c")
            txtDifference.ForeColor = Color.Black
            txtDifference.BackColor = Control.DefaultBackColor
        Else
            txtDifference.ReadOnly = False
            txtDifference.Text = getTotalDifference.ToString("c")
            txtDifference.ForeColor = Color.Red
            txtDifference.BackColor = Control.DefaultBackColor
            txtDifference.ReadOnly = True
        End If

    End Sub

    Private Sub populateIncome()
        Dim dbConnection As SqlConnection = DatabaseUtility.databaseConnect()
        Dim dbAdapter As New SqlDataAdapter("SELECT * From Income", dbConnection)
        dbAdapter.FillSchema(incomeData, SchemaType.Source, "Income")
        dbAdapter.Fill(incomeData, "Income")
        DatabaseUtility.databaseDisconnect(dbConnection)
        dgvIncome.DataSource = incomeData
        dgvIncome.DataMember = "Income"
        Me.dgvIncome.Columns(3).DefaultCellStyle.Format = "c"
        Me.dgvIncome.Columns(0).Width = 65
    End Sub

    Private Sub populateBills()
        Dim dbConnection As SqlConnection = DatabaseUtility.databaseConnect()
        Dim dbAdapter As New SqlDataAdapter("SELECT * From Bills", dbConnection)
        dbAdapter.FillSchema(billData, SchemaType.Source, "Bills")
        dbAdapter.Fill(billData, "Bills")
        DatabaseUtility.databaseDisconnect(dbConnection)
        dgvBills.DataSource = billData
        dgvBills.DataMember = "Bills"
        Me.dgvBills.Columns(3).DefaultCellStyle.Format = "c"
        Me.dgvBills.Columns(0).Width = 65
    End Sub

    Private Sub DgvIncome_CallMouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvIncome.CellMouseClick
        If dgvIncome.Rows.Count > 1 Then
            If e.Button = Windows.Forms.MouseButtons.Right Then
                Me.dgvIncome.Rows(e.RowIndex).Selected = True
                Me.incomeRowIndex = e.RowIndex
                Me.dgvIncome.CurrentCell = Me.dgvIncome.Rows(e.RowIndex).Cells(4)
                If Not IsDBNull(Me.dgvIncome.CurrentCell.Value) Then 'only show context menu if row is populated.
                    Me.contextMenuStrip1.Show(Me.dgvIncome, e.Location)
                    contextMenuStrip1.Show(Cursor.Position)
                End If
            End If
        End If
    End Sub

    Private Sub IncomeContextMenuStrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles contextMenuStrip1.Click
        If MessageBox.Show("Are you sure you want to delete this entry?", "Delete Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim dbConnection As SqlConnection = DatabaseUtility.databaseConnect()
            Dim dbAdapter As New SqlDataAdapter("SELECT * From Income", dbConnection)
            Dim dbCmdBuilder As New SqlCommandBuilder(dbAdapter)
            incomeData.Tables("Income").Rows(Me.incomeRowIndex).Delete()
            dbCmdBuilder.RefreshSchema()
            dbAdapter.Update(Me.incomeData, "Income")
            DatabaseUtility.databaseDisconnect(dbConnection)
            populateDifferences()
        Else
            contextMenuStrip1.Close()
        End If
    End Sub

    Private Sub DgvBills_CallMouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvBills.CellMouseClick
        If Me.dgvBills.Rows.Count > 1 Then
            If e.Button = Windows.Forms.MouseButtons.Right Then
                Me.dgvBills.Rows(e.RowIndex).Selected = True
                Me.billRowIndex = e.RowIndex
                Me.dgvBills.CurrentCell = Me.dgvBills.Rows(e.RowIndex).Cells(4)
                If Not IsDBNull(Me.dgvBills.CurrentCell.Value) Then 'only show context menu if row is populated.
                    Me.ContextMenuStrip2.Show(Me.dgvBills, e.Location)
                    ContextMenuStrip2.Show(Cursor.Position)
                End If
            End If
        End If
    End Sub

    Private Sub BillsContextMenuStrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContextMenuStrip2.Click
        If MessageBox.Show("Are you sure you want to delete this entry?", "Delete Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim dbConnection As SqlConnection = DatabaseUtility.databaseConnect()
            Dim dbAdapter As New SqlDataAdapter("SELECT * From Bills", dbConnection)
            Dim dbCmdBuilder As New SqlCommandBuilder(dbAdapter)
            billData.Tables("Bills").Rows(Me.billRowIndex).Delete()
            dbCmdBuilder.RefreshSchema()
            dbAdapter.Update(Me.billData, "Bills")
            DatabaseUtility.databaseDisconnect(dbConnection)
            populateDifferences()
        Else
            contextMenuStrip1.Close()
        End If
    End Sub

End Class