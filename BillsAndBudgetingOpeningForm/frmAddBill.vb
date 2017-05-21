' LANCE W MATYSIK, 2015

Option Explicit On
Option Strict On

Imports System.Data.SqlClient

Public Class frmAddBill

    Private Sub frmAddBill_Load(sender As Object, e As EventArgs) Handles Me.Load

        cbxBillType.Items.Add("Car Insurance")
        cbxBillType.Items.Add("Car Payment")
        cbxBillType.Items.Add("Cell Phone")
        cbxBillType.Items.Add("Health Insurance")
        cbxBillType.Items.Add("Loan Payment")
        cbxBillType.Items.Add("Medical")
        cbxBillType.Items.Add("Mortgage")
        cbxBillType.Items.Add("Utilities")
        cbxBillType.Items.Add("Rent")

        ' default date in selector is now.
        dtpAddBillDay.Value = DateAndTime.Now

    End Sub

    Private Sub btnAddBillFinished_Click(sender As Object, e As EventArgs) Handles btnAddBillFinished.Click
        Dim billAmount As Double
        Dim payDay As Date

        Dim isBillNameValid As Boolean
        Dim isBillTypeValid As Boolean
        Dim isBillAmountValid As Boolean
        Dim isPayDayValid As Boolean

        Dim billData As New DataSet()
        Dim billTable As New DataTable()

        isBillNameValid = String.IsNullOrEmpty(txtBillName.Text)
        isBillTypeValid = String.IsNullOrEmpty(cbxBillType.Text)
        isBillAmountValid = Double.TryParse(txtBillAmount.Text, billAmount)
        isPayDayValid = Date.TryParse(dtpAddBillDay.Text, payDay)


        If isBillAmountValid And isPayDayValid And Not isBillNameValid And Not isBillTypeValid Then
            Dim newBill As New Bill()
            newBill.billName = txtBillName.Text.ToString
            newBill.billType = cbxBillType.Text.ToString
            newBill.billAmount = billAmount
            newBill.billPayDate = payDay

            'add user information into database and put into dataset

            Dim dbConnection As SqlConnection = DatabaseUtility.databaseConnect()
            Dim dbAdapter As New SqlDataAdapter("Select * from Bills", dbConnection)

            dbAdapter.FillSchema(billData, SchemaType.Source, "Bills")
            dbAdapter.Fill(billData, "Bills")

            Dim dbBillsInsert As New SqlCommand("Insert into Bills (bill_ID, Name, Type, Amount, Due_Date) values (@bill_ID, @Name, @Type, @Amount, @Due_Date)", dbConnection)

            dbBillsInsert.Parameters.Add("@bill_ID", SqlDbType.Int, 4, "bill_ID")
            dbBillsInsert.Parameters.Add("@Name", SqlDbType.NVarChar, 50, "Name")
            dbBillsInsert.Parameters.Add("@Type", SqlDbType.NVarChar, 50, "Type")
            dbBillsInsert.Parameters.Add("@Amount", SqlDbType.Float, 10, "Amount")
            dbBillsInsert.Parameters.Add("@Due_Date", SqlDbType.Date, 30, "Due_Date")

            dbAdapter.InsertCommand = dbBillsInsert

            billTable = billData.Tables("Bills")
            Dim newRow As DataRow = billTable.NewRow

            Dim rowCount = billData.Tables("Bills").Rows.Count
            Dim lastIndex As Integer

            If rowCount = 0 Then
                lastIndex = 0
            Else
                lastIndex = CInt(billData.Tables("Bills").Rows(rowCount - 1).Item("bill_ID"))
            End If

            newRow.SetField("Bill_ID", lastIndex + 1)
            newRow.SetField("Name", Me.txtBillName.Text)
            newRow.SetField("Type", Me.cbxBillType.Text)
            newRow.SetField("Amount", Me.txtBillAmount.Text)
            newRow.SetField("Due_Date", Me.dtpAddBillDay.Text)

            billTable.Rows.Add(newRow)
            newRow.EndEdit()

            dbAdapter.Update(billData.Tables("Bills"))

            DatabaseUtility.databaseDisconnect(dbConnection)

            frmBillsAndBudgetMain.dgvBills.DataSource = billData 'update the mainscreen so you can see it while adding bills

            ' clear out boxes for new entries
            txtBillAmount.Clear()
            txtBillName.Clear()

            getDifference()

        Else
            MessageBox.Show("Invalid Inputs")
        End If

    End Sub

    Private Sub getDifference()
        Dim getIncomeMath As Double
        Dim getBillsMath As Double
        Dim getTotalDifference As Double
        Dim billsAmountTotal As Double

        For index As Integer = 0 To frmBillsAndBudgetMain.dgvBills.RowCount - 1
            billsAmountTotal += CDbl(frmBillsAndBudgetMain.dgvBills.Rows(index).Cells(3).Value)
        Next

        frmBillsAndBudgetMain.txtBillsGrandTotal.Text = billsAmountTotal.ToString("c")

        If String.IsNullOrEmpty(frmBillsAndBudgetMain.txtIncomeGrandTotal.Text) Then
            frmBillsAndBudgetMain.txtIncomeGrandTotal.Text = "0.00"
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

    Private Sub btnAddBillDone_Click(sender As Object, e As EventArgs) Handles btnAddBillDone.Click
        Me.Close()
    End Sub

End Class