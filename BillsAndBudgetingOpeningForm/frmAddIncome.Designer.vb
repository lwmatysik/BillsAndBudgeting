<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddIncome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddIncome))
        Me.lblAddIncomeName = New System.Windows.Forms.Label()
        Me.txtIncomeName = New System.Windows.Forms.TextBox()
        Me.txtIncomeAmount = New System.Windows.Forms.TextBox()
        Me.lblAddIncomeAmount = New System.Windows.Forms.Label()
        Me.lblAddIncomeDate = New System.Windows.Forms.Label()
        Me.btnAddIncomeFinished = New System.Windows.Forms.Button()
        Me.dtpAddPayday = New System.Windows.Forms.DateTimePicker()
        Me.btnAddIncomeDone = New System.Windows.Forms.Button()
        Me.cbxIncomeType = New System.Windows.Forms.ComboBox()
        Me.lblIncomeType = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAddIncomeName
        '
        Me.lblAddIncomeName.AutoSize = True
        Me.lblAddIncomeName.Location = New System.Drawing.Point(12, 12)
        Me.lblAddIncomeName.Name = "lblAddIncomeName"
        Me.lblAddIncomeName.Size = New System.Drawing.Size(38, 13)
        Me.lblAddIncomeName.TabIndex = 0
        Me.lblAddIncomeName.Text = "Name:"
        '
        'txtIncomeName
        '
        Me.txtIncomeName.Location = New System.Drawing.Point(57, 9)
        Me.txtIncomeName.Name = "txtIncomeName"
        Me.txtIncomeName.Size = New System.Drawing.Size(100, 20)
        Me.txtIncomeName.TabIndex = 2
        '
        'txtIncomeAmount
        '
        Me.txtIncomeAmount.Location = New System.Drawing.Point(57, 41)
        Me.txtIncomeAmount.Name = "txtIncomeAmount"
        Me.txtIncomeAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtIncomeAmount.TabIndex = 3
        '
        'lblAddIncomeAmount
        '
        Me.lblAddIncomeAmount.AutoSize = True
        Me.lblAddIncomeAmount.Location = New System.Drawing.Point(11, 41)
        Me.lblAddIncomeAmount.Name = "lblAddIncomeAmount"
        Me.lblAddIncomeAmount.Size = New System.Drawing.Size(46, 13)
        Me.lblAddIncomeAmount.TabIndex = 4
        Me.lblAddIncomeAmount.Text = "Amount:"
        '
        'lblAddIncomeDate
        '
        Me.lblAddIncomeDate.AutoSize = True
        Me.lblAddIncomeDate.Location = New System.Drawing.Point(12, 94)
        Me.lblAddIncomeDate.Name = "lblAddIncomeDate"
        Me.lblAddIncomeDate.Size = New System.Drawing.Size(45, 13)
        Me.lblAddIncomeDate.TabIndex = 5
        Me.lblAddIncomeDate.Text = "Payday:"
        '
        'btnAddIncomeFinished
        '
        Me.btnAddIncomeFinished.Location = New System.Drawing.Point(173, 156)
        Me.btnAddIncomeFinished.Name = "btnAddIncomeFinished"
        Me.btnAddIncomeFinished.Size = New System.Drawing.Size(105, 33)
        Me.btnAddIncomeFinished.TabIndex = 6
        Me.btnAddIncomeFinished.Text = "Add Income"
        Me.btnAddIncomeFinished.UseVisualStyleBackColor = True
        '
        'dtpAddPayday
        '
        Me.dtpAddPayday.Location = New System.Drawing.Point(57, 94)
        Me.dtpAddPayday.MaxDate = New Date(2017, 1, 1, 0, 0, 0, 0)
        Me.dtpAddPayday.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.dtpAddPayday.Name = "dtpAddPayday"
        Me.dtpAddPayday.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpAddPayday.Size = New System.Drawing.Size(200, 20)
        Me.dtpAddPayday.TabIndex = 7
        Me.dtpAddPayday.Value = New Date(2015, 1, 31, 18, 57, 56, 0)
        '
        'btnAddIncomeDone
        '
        Me.btnAddIncomeDone.Location = New System.Drawing.Point(173, 195)
        Me.btnAddIncomeDone.Name = "btnAddIncomeDone"
        Me.btnAddIncomeDone.Size = New System.Drawing.Size(105, 33)
        Me.btnAddIncomeDone.TabIndex = 8
        Me.btnAddIncomeDone.Text = "Done"
        Me.btnAddIncomeDone.UseVisualStyleBackColor = True
        '
        'cbxIncomeType
        '
        Me.cbxIncomeType.FormattingEnabled = True
        Me.cbxIncomeType.Location = New System.Drawing.Point(57, 67)
        Me.cbxIncomeType.Name = "cbxIncomeType"
        Me.cbxIncomeType.Size = New System.Drawing.Size(121, 21)
        Me.cbxIncomeType.TabIndex = 9
        '
        'lblIncomeType
        '
        Me.lblIncomeType.AutoSize = True
        Me.lblIncomeType.Location = New System.Drawing.Point(13, 70)
        Me.lblIncomeType.Name = "lblIncomeType"
        Me.lblIncomeType.Size = New System.Drawing.Size(34, 13)
        Me.lblIncomeType.TabIndex = 11
        Me.lblIncomeType.Text = "Type:"
        '
        'frmAddIncome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 240)
        Me.Controls.Add(Me.lblIncomeType)
        Me.Controls.Add(Me.cbxIncomeType)
        Me.Controls.Add(Me.btnAddIncomeDone)
        Me.Controls.Add(Me.dtpAddPayday)
        Me.Controls.Add(Me.btnAddIncomeFinished)
        Me.Controls.Add(Me.lblAddIncomeDate)
        Me.Controls.Add(Me.lblAddIncomeAmount)
        Me.Controls.Add(Me.txtIncomeAmount)
        Me.Controls.Add(Me.txtIncomeName)
        Me.Controls.Add(Me.lblAddIncomeName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddIncome"
        Me.Text = "Income"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAddIncomeName As System.Windows.Forms.Label
    Friend WithEvents txtIncomeName As System.Windows.Forms.TextBox
    Friend WithEvents txtIncomeAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblAddIncomeAmount As System.Windows.Forms.Label
    Friend WithEvents lblAddIncomeDate As System.Windows.Forms.Label
    Friend WithEvents btnAddIncomeFinished As System.Windows.Forms.Button
    Friend WithEvents dtpAddPayday As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnAddIncomeDone As System.Windows.Forms.Button
    Friend WithEvents cbxIncomeType As System.Windows.Forms.ComboBox
    Friend WithEvents lblIncomeType As System.Windows.Forms.Label
End Class
