<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBillsAndBudgetMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBillsAndBudgetMain))
        Me.lblIncome = New System.Windows.Forms.Label()
        Me.lblBills = New System.Windows.Forms.Label()
        Me.btnAddIncome = New System.Windows.Forms.Button()
        Me.btnAddBill = New System.Windows.Forms.Button()
        Me.lblTotalIncomeAmount = New System.Windows.Forms.Label()
        Me.lblBillTotalAmount = New System.Windows.Forms.Label()
        Me.lblDifference = New System.Windows.Forms.Label()
        Me.txtIncomeGrandTotal = New System.Windows.Forms.TextBox()
        Me.txtBillsGrandTotal = New System.Windows.Forms.TextBox()
        Me.txtDifference = New System.Windows.Forms.TextBox()
        Me.dgvIncome = New System.Windows.Forms.DataGridView()
        Me.dgvBills = New System.Windows.Forms.DataGridView()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.contextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnBillReport = New System.Windows.Forms.Button()
        CType(Me.dgvIncome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBills, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.contextMenuStrip1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblIncome
        '
        Me.lblIncome.AutoSize = True
        Me.lblIncome.Location = New System.Drawing.Point(12, 6)
        Me.lblIncome.Name = "lblIncome"
        Me.lblIncome.Size = New System.Drawing.Size(45, 13)
        Me.lblIncome.TabIndex = 2
        Me.lblIncome.Text = "Income:"
        '
        'lblBills
        '
        Me.lblBills.AutoSize = True
        Me.lblBills.Location = New System.Drawing.Point(12, 221)
        Me.lblBills.Name = "lblBills"
        Me.lblBills.Size = New System.Drawing.Size(28, 13)
        Me.lblBills.TabIndex = 3
        Me.lblBills.Text = "Bills:"
        '
        'btnAddIncome
        '
        Me.btnAddIncome.Location = New System.Drawing.Point(12, 432)
        Me.btnAddIncome.Name = "btnAddIncome"
        Me.btnAddIncome.Size = New System.Drawing.Size(75, 23)
        Me.btnAddIncome.TabIndex = 4
        Me.btnAddIncome.Text = "Add Income"
        Me.btnAddIncome.UseVisualStyleBackColor = True
        '
        'btnAddBill
        '
        Me.btnAddBill.Location = New System.Drawing.Point(12, 461)
        Me.btnAddBill.Name = "btnAddBill"
        Me.btnAddBill.Size = New System.Drawing.Size(75, 23)
        Me.btnAddBill.TabIndex = 5
        Me.btnAddBill.Text = "Add Bill"
        Me.btnAddBill.UseVisualStyleBackColor = True
        '
        'lblTotalIncomeAmount
        '
        Me.lblTotalIncomeAmount.AutoSize = True
        Me.lblTotalIncomeAmount.Location = New System.Drawing.Point(497, 426)
        Me.lblTotalIncomeAmount.Name = "lblTotalIncomeAmount"
        Me.lblTotalIncomeAmount.Size = New System.Drawing.Size(72, 13)
        Me.lblTotalIncomeAmount.TabIndex = 18
        Me.lblTotalIncomeAmount.Text = "Income Total:"
        '
        'lblBillTotalAmount
        '
        Me.lblBillTotalAmount.AutoSize = True
        Me.lblBillTotalAmount.Location = New System.Drawing.Point(519, 452)
        Me.lblBillTotalAmount.Name = "lblBillTotalAmount"
        Me.lblBillTotalAmount.Size = New System.Drawing.Size(50, 13)
        Me.lblBillTotalAmount.TabIndex = 19
        Me.lblBillTotalAmount.Text = "Bill Total:"
        '
        'lblDifference
        '
        Me.lblDifference.AutoSize = True
        Me.lblDifference.Location = New System.Drawing.Point(510, 478)
        Me.lblDifference.Name = "lblDifference"
        Me.lblDifference.Size = New System.Drawing.Size(59, 13)
        Me.lblDifference.TabIndex = 20
        Me.lblDifference.Text = "Difference:"
        '
        'txtIncomeGrandTotal
        '
        Me.txtIncomeGrandTotal.Location = New System.Drawing.Point(575, 423)
        Me.txtIncomeGrandTotal.Name = "txtIncomeGrandTotal"
        Me.txtIncomeGrandTotal.ReadOnly = True
        Me.txtIncomeGrandTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtIncomeGrandTotal.TabIndex = 21
        '
        'txtBillsGrandTotal
        '
        Me.txtBillsGrandTotal.Location = New System.Drawing.Point(575, 449)
        Me.txtBillsGrandTotal.Name = "txtBillsGrandTotal"
        Me.txtBillsGrandTotal.ReadOnly = True
        Me.txtBillsGrandTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtBillsGrandTotal.TabIndex = 22
        '
        'txtDifference
        '
        Me.txtDifference.Location = New System.Drawing.Point(575, 475)
        Me.txtDifference.Name = "txtDifference"
        Me.txtDifference.ReadOnly = True
        Me.txtDifference.Size = New System.Drawing.Size(100, 20)
        Me.txtDifference.TabIndex = 23
        '
        'dgvIncome
        '
        Me.dgvIncome.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIncome.Location = New System.Drawing.Point(15, 22)
        Me.dgvIncome.Name = "dgvIncome"
        Me.dgvIncome.RowHeadersVisible = False
        Me.dgvIncome.Size = New System.Drawing.Size(660, 180)
        Me.dgvIncome.TabIndex = 24
        '
        'dgvBills
        '
        Me.dgvBills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBills.Location = New System.Drawing.Point(15, 237)
        Me.dgvBills.Name = "dgvBills"
        Me.dgvBills.RowHeadersVisible = False
        Me.dgvBills.Size = New System.Drawing.Size(660, 180)
        Me.dgvBills.TabIndex = 25
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(93, 432)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(86, 23)
        Me.btnReport.TabIndex = 26
        Me.btnReport.Text = "Income Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'contextMenuStrip1
        '
        Me.contextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem})
        Me.contextMenuStrip1.Name = "contextMenuStrip"
        Me.contextMenuStrip1.Size = New System.Drawing.Size(108, 26)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.ContextMenuStrip2.Name = "contextMenuStrip"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(108, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(107, 22)
        Me.ToolStripMenuItem1.Text = "Delete"
        '
        'btnBillReport
        '
        Me.btnBillReport.Location = New System.Drawing.Point(93, 461)
        Me.btnBillReport.Name = "btnBillReport"
        Me.btnBillReport.Size = New System.Drawing.Size(86, 23)
        Me.btnBillReport.TabIndex = 27
        Me.btnBillReport.Text = "Bill Report"
        Me.btnBillReport.UseVisualStyleBackColor = True
        '
        'frmBillsAndBudgetMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 502)
        Me.Controls.Add(Me.btnBillReport)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.dgvBills)
        Me.Controls.Add(Me.dgvIncome)
        Me.Controls.Add(Me.txtDifference)
        Me.Controls.Add(Me.txtBillsGrandTotal)
        Me.Controls.Add(Me.txtIncomeGrandTotal)
        Me.Controls.Add(Me.lblDifference)
        Me.Controls.Add(Me.lblBillTotalAmount)
        Me.Controls.Add(Me.lblTotalIncomeAmount)
        Me.Controls.Add(Me.btnAddBill)
        Me.Controls.Add(Me.btnAddIncome)
        Me.Controls.Add(Me.lblBills)
        Me.Controls.Add(Me.lblIncome)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBillsAndBudgetMain"
        Me.Text = "Bills and Budget v.04"
        CType(Me.dgvIncome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBills, System.ComponentModel.ISupportInitialize).EndInit()
        Me.contextMenuStrip1.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIncome As System.Windows.Forms.Label
    Friend WithEvents lblBills As System.Windows.Forms.Label
    Friend WithEvents btnAddIncome As System.Windows.Forms.Button
    Friend WithEvents btnAddBill As System.Windows.Forms.Button
    Friend WithEvents lblTotalIncomeAmount As System.Windows.Forms.Label
    Friend WithEvents lblBillTotalAmount As System.Windows.Forms.Label
    Friend WithEvents lblDifference As System.Windows.Forms.Label
    Friend WithEvents txtIncomeGrandTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtBillsGrandTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtDifference As System.Windows.Forms.TextBox
    Friend WithEvents dgvIncome As System.Windows.Forms.DataGridView
    Friend WithEvents dgvBills As System.Windows.Forms.DataGridView
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents contextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnBillReport As System.Windows.Forms.Button

End Class
