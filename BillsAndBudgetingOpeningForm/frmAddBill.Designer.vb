<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddBill
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddBill))
        Me.btnAddBillDone = New System.Windows.Forms.Button()
        Me.dtpAddBillDay = New System.Windows.Forms.DateTimePicker()
        Me.btnAddBillFinished = New System.Windows.Forms.Button()
        Me.lblAddIncomeDate = New System.Windows.Forms.Label()
        Me.lblAddIncomeAmount = New System.Windows.Forms.Label()
        Me.txtBillAmount = New System.Windows.Forms.TextBox()
        Me.txtBillName = New System.Windows.Forms.TextBox()
        Me.lblAddBillName = New System.Windows.Forms.Label()
        Me.cbxBillType = New System.Windows.Forms.ComboBox()
        Me.lblBillType = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAddBillDone
        '
        Me.btnAddBillDone.Location = New System.Drawing.Point(168, 170)
        Me.btnAddBillDone.Name = "btnAddBillDone"
        Me.btnAddBillDone.Size = New System.Drawing.Size(105, 33)
        Me.btnAddBillDone.TabIndex = 16
        Me.btnAddBillDone.Text = "Done"
        Me.btnAddBillDone.UseVisualStyleBackColor = True
        '
        'dtpAddBillDay
        '
        Me.dtpAddBillDay.Location = New System.Drawing.Point(58, 99)
        Me.dtpAddBillDay.MaxDate = New Date(2017, 1, 1, 0, 0, 0, 0)
        Me.dtpAddBillDay.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.dtpAddBillDay.Name = "dtpAddBillDay"
        Me.dtpAddBillDay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpAddBillDay.Size = New System.Drawing.Size(200, 20)
        Me.dtpAddBillDay.TabIndex = 15
        Me.dtpAddBillDay.Value = New Date(2015, 1, 31, 18, 57, 56, 0)
        '
        'btnAddBillFinished
        '
        Me.btnAddBillFinished.Location = New System.Drawing.Point(168, 131)
        Me.btnAddBillFinished.Name = "btnAddBillFinished"
        Me.btnAddBillFinished.Size = New System.Drawing.Size(105, 33)
        Me.btnAddBillFinished.TabIndex = 14
        Me.btnAddBillFinished.Text = "Add Bill"
        Me.btnAddBillFinished.UseVisualStyleBackColor = True
        '
        'lblAddIncomeDate
        '
        Me.lblAddIncomeDate.AutoSize = True
        Me.lblAddIncomeDate.Location = New System.Drawing.Point(7, 105)
        Me.lblAddIncomeDate.Name = "lblAddIncomeDate"
        Me.lblAddIncomeDate.Size = New System.Drawing.Size(47, 13)
        Me.lblAddIncomeDate.TabIndex = 13
        Me.lblAddIncomeDate.Text = "Dueday:"
        '
        'lblAddIncomeAmount
        '
        Me.lblAddIncomeAmount.AutoSize = True
        Me.lblAddIncomeAmount.Location = New System.Drawing.Point(6, 47)
        Me.lblAddIncomeAmount.Name = "lblAddIncomeAmount"
        Me.lblAddIncomeAmount.Size = New System.Drawing.Size(46, 13)
        Me.lblAddIncomeAmount.TabIndex = 12
        Me.lblAddIncomeAmount.Text = "Amount:"
        '
        'txtBillAmount
        '
        Me.txtBillAmount.Location = New System.Drawing.Point(52, 44)
        Me.txtBillAmount.Name = "txtBillAmount"
        Me.txtBillAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtBillAmount.TabIndex = 11
        '
        'txtBillName
        '
        Me.txtBillName.Location = New System.Drawing.Point(52, 12)
        Me.txtBillName.Name = "txtBillName"
        Me.txtBillName.Size = New System.Drawing.Size(100, 20)
        Me.txtBillName.TabIndex = 10
        '
        'lblAddBillName
        '
        Me.lblAddBillName.AutoSize = True
        Me.lblAddBillName.Location = New System.Drawing.Point(7, 15)
        Me.lblAddBillName.Name = "lblAddBillName"
        Me.lblAddBillName.Size = New System.Drawing.Size(38, 13)
        Me.lblAddBillName.TabIndex = 9
        Me.lblAddBillName.Text = "Name:"
        '
        'cbxBillType
        '
        Me.cbxBillType.FormattingEnabled = True
        Me.cbxBillType.Location = New System.Drawing.Point(52, 72)
        Me.cbxBillType.Name = "cbxBillType"
        Me.cbxBillType.Size = New System.Drawing.Size(121, 21)
        Me.cbxBillType.TabIndex = 17
        '
        'lblBillType
        '
        Me.lblBillType.AutoSize = True
        Me.lblBillType.Location = New System.Drawing.Point(6, 75)
        Me.lblBillType.Name = "lblBillType"
        Me.lblBillType.Size = New System.Drawing.Size(34, 13)
        Me.lblBillType.TabIndex = 18
        Me.lblBillType.Text = "Type:"
        '
        'frmAddBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 215)
        Me.Controls.Add(Me.lblBillType)
        Me.Controls.Add(Me.cbxBillType)
        Me.Controls.Add(Me.btnAddBillDone)
        Me.Controls.Add(Me.dtpAddBillDay)
        Me.Controls.Add(Me.btnAddBillFinished)
        Me.Controls.Add(Me.lblAddIncomeDate)
        Me.Controls.Add(Me.lblAddIncomeAmount)
        Me.Controls.Add(Me.txtBillAmount)
        Me.Controls.Add(Me.txtBillName)
        Me.Controls.Add(Me.lblAddBillName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddBill"
        Me.Text = "Bills"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddBillDone As System.Windows.Forms.Button
    Friend WithEvents dtpAddBillDay As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnAddBillFinished As System.Windows.Forms.Button
    Friend WithEvents lblAddIncomeDate As System.Windows.Forms.Label
    Friend WithEvents lblAddIncomeAmount As System.Windows.Forms.Label
    Friend WithEvents txtBillAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtBillName As System.Windows.Forms.TextBox
    Friend WithEvents lblAddBillName As System.Windows.Forms.Label
    Friend WithEvents cbxBillType As System.Windows.Forms.ComboBox
    Friend WithEvents lblBillType As System.Windows.Forms.Label
End Class
