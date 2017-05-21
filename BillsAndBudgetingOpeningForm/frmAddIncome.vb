' LANCE W MATYSIK, 2015

Option Explicit On
Option Strict On

Imports System.Data.SqlClient

Public Class frmAddIncome

    Private Sub frmAddIncome_Load(sender As Object, e As EventArgs) Handles Me.Load

        cbxIncomeType.Items.Add("Interest")
        cbxIncomeType.Items.Add("Misc")
        cbxIncomeType.Items.Add("Payroll")
        cbxIncomeType.Items.Add("Rental Income")
        cbxIncomeType.Items.Add("Retirement")
        cbxIncomeType.Items.Add("Royalties")
        cbxIncomeType.Items.Add("Sales")
        cbxIncomeType.Items.Add("Social Security")
        cbxIncomeType.Items.Add("Stocks")
        cbxIncomeType.Items.Add("Unemployment")

        ' default date in selector is now.
        dtpAddPayday.Value = DateAndTime.Now

    End Sub


    Private Sub btnAddIncomeFinished_Click(sender As Object, e As EventArgs) Handles btnAddIncomeFinished.Click
        Dim incomeAmount As Double
        Dim payDay As Date


        Dim isIncomeNameValid As Boolean
        Dim isIncomeTypeValid As Boolean
        Dim isIncomeAmountValid As Boolean
        Dim isPayDayValid As Boolean

        Dim incomeData As New DataSet()
        Dim incomeTable As New DataTable()

        isIncomeNameValid = String.IsNullOrEmpty(txtIncomeName.Text)
        isIncomeTypeValid = String.IsNullOrEmpty(cbxIncomeType.Text)
        isIncomeAmountValid = Double.TryParse(txtIncomeAmount.Text, incomeAmount)
        isPayDayValid = Date.TryParse(dtpAddPayday.Text, payDay)


        If isIncomeAmountValid And isPayDayValid And Not isIncomeNameValid And Not isIncomeTypeValid Then
            Dim newIncome As New Income()
            newIncome.incomeName = txtIncomeName.Text.ToString
            newIncome.incomeType = cbxIncomeType.Text.ToString
            newIncome.incomeAmount = incomeAmount
            newIncome.incomePayDate = payDay

            Dim dbConnection As SqlConnection = DatabaseUtility.databaseConnect()
            Dim dbAdapter As New SqlDataAdapter("Select * from Income", dbConnection)

            dbAdapter.FillSchema(incomeData, SchemaType.Source, "Income")
            dbAdapter.Fill(incomeData, "Income")

            Dim dbIncomeInsert As New SqlCommand("Insert into Income (Income_ID, Name, Type, Amount, Recieve_date) values (@Income_ID, @Name, @Type, @Amount, @Recieve_Date)", dbConnection)

            dbIncomeInsert.Parameters.Add("@Income_ID", SqlDbType.Int, 4, "Income_ID")
            dbIncomeInsert.Parameters.Add("@Name", SqlDbType.NVarChar, 50, "Name")
            dbIncomeInsert.Parameters.Add("@Type", SqlDbType.NVarChar, 50, "Type")
            dbIncomeInsert.Parameters.Add("@Amount", SqlDbType.Float, 10, "Amount")
            dbIncomeInsert.Parameters.Add("@Recieve_Date", SqlDbType.Date, 30, "Recieve_Date")

            dbAdapter.InsertCommand = dbIncomeInsert

            incomeTable = incomeData.Tables("Income")
            Dim newRow As DataRow = incomeTable.NewRow

            Dim rowCount = incomeData.Tables("Income").Rows.Count
            Dim lastIndex As Integer
            If rowCount = 0 Then
                lastIndex = 0
            Else
                lastIndex = CInt(incomeData.Tables("Income").Rows(rowCount - 1).Item("Income_ID"))
            End If

            newRow.SetField("Income_ID", lastIndex + 1)
            newRow.SetField("Name", Me.txtIncomeName.Text)
            newRow.SetField("Type", Me.cbxIncomeType.Text)
            newRow.SetField("Amount", Me.txtIncomeAmount.Text)
            newRow.SetField("Recieve_Date", Me.dtpAddPayday.Text)

            incomeTable.Rows.Add(newRow)
            newRow.EndEdit()

            dbAdapter.Update(incomeData.Tables("Income"))

            DatabaseUtility.databaseDisconnect(dbConnection)

            frmBillsAndBudgetMain.dgvIncome.DataSource = incomeData

            txtIncomeAmount.Clear()
            txtIncomeName.Clear()

            getDifference()

        Else
            MessageBox.Show("Invalid Inputs")
        End If

    End Sub


    Private Sub getDifference()
        Dim getIncomeMath As Double
        Dim getBillsMath As Double
        Dim getTotalDifference As Double
        Dim incomeAmountTotal As Double

        For index As Integer = 0 To frmBillsAndBudgetMain.dgvIncome.RowCount - 1
            incomeAmountTotal += CDbl(frmBillsAndBudgetMain.dgvIncome.Rows(index).Cells(3).Value)
        Next

        frmBillsAndBudgetMain.txtIncomeGrandTotal.Text = incomeAmountTotal.ToString("c")

        If String.IsNullOrEmpty(frmBillsAndBudgetMain.txtBillsGrandTotal.Text) Then
            frmBillsAndBudgetMain.txtIncomeGrandTotal.Text = "0.00"
            frmBillsAndBudgetMain.txtBillsGrandTotal.Text = "0.00"
            frmBillsAndBudgetMain.txtDifference.Text = "0.00"
            getIncomeMath = CDbl(frmBillsAndBudgetMain.txtIncomeGrandTotal.Text)
            getBillsMath = CDbl(frmBillsAndBudgetMain.txtBillsGrandTotal.Text)
            getTotalDifference = getIncomeMath - getBillsMath
        Else
            getIncomeMath = CDbl(frmBillsAndBudgetMain.txtIncomeGrandTotal.Text)
            getBillsMath = CDbl(frmBillsAndBudgetMain.txtBillsGrandTotal.Text)
            getTotalDifference = getIncomeMath - getBillsMath
        End If

        If getTotalDifference >= 0 Then
            frmBillsAndBudgetMain.txtDifference.ReadOnly = False
            frmBillsAndBudgetMain.txtDifference.Text = getTotalDifference.ToString("c")
            frmBillsAndBudgetMain.txtDifference.ForeColor = Color.Black
            frmBillsAndBudgetMain.txtDifference.BackColor = Control.DefaultBackColor
        Else
            frmBillsAndBudgetMain.txtDifference.ReadOnly = False
            frmBillsAndBudgetMain.txtDifference.Text = getTotalDifference.ToString("c")
            frmBillsAndBudgetMain.txtDifference.ForeColor = Color.Red
            frmBillsAndBudgetMain.txtDifference.BackColor = Control.DefaultBackColor
            frmBillsAndBudgetMain.txtDifference.ReadOnly = True
        End If
    End Sub


    Private Sub btnAddIncomeDone_Click(sender As Object, e As EventArgs) Handles btnAddIncomeDone.Click
        Me.Close()
    End Sub

End Class