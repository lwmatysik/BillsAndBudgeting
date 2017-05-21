<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIncomeReport
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIncomeReport))
        Me.chtIncome = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblIncome = New System.Windows.Forms.Label()
        Me.cldrIncome = New System.Windows.Forms.MonthCalendar()
        Me.lblPaydates = New System.Windows.Forms.Label()
        CType(Me.chtIncome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chtIncome
        '
        ChartArea1.Name = "ChartArea1"
        Me.chtIncome.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chtIncome.Legends.Add(Legend1)
        Me.chtIncome.Location = New System.Drawing.Point(12, 40)
        Me.chtIncome.Name = "chtIncome"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Income"
        Me.chtIncome.Series.Add(Series1)
        Me.chtIncome.Size = New System.Drawing.Size(300, 300)
        Me.chtIncome.TabIndex = 4
        Me.chtIncome.Text = "Income"
        '
        'lblIncome
        '
        Me.lblIncome.AutoSize = True
        Me.lblIncome.Location = New System.Drawing.Point(12, 22)
        Me.lblIncome.Name = "lblIncome"
        Me.lblIncome.Size = New System.Drawing.Size(102, 13)
        Me.lblIncome.TabIndex = 6
        Me.lblIncome.Text = "Income Breakdown:"
        '
        'cldrIncome
        '
        Me.cldrIncome.BackColor = System.Drawing.SystemColors.Menu
        Me.cldrIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cldrIncome.Location = New System.Drawing.Point(324, 40)
        Me.cldrIncome.Name = "cldrIncome"
        Me.cldrIncome.TabIndex = 7
        Me.cldrIncome.TitleBackColor = System.Drawing.SystemColors.ControlLight
        '
        'lblPaydates
        '
        Me.lblPaydates.AutoSize = True
        Me.lblPaydates.Location = New System.Drawing.Point(321, 22)
        Me.lblPaydates.Name = "lblPaydates"
        Me.lblPaydates.Size = New System.Drawing.Size(54, 13)
        Me.lblPaydates.TabIndex = 8
        Me.lblPaydates.Text = "Paydates:"
        '
        'frmIncomeReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 353)
        Me.Controls.Add(Me.lblPaydates)
        Me.Controls.Add(Me.cldrIncome)
        Me.Controls.Add(Me.lblIncome)
        Me.Controls.Add(Me.chtIncome)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmIncomeReport"
        Me.Text = "Income Reports"
        CType(Me.chtIncome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chtIncome As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents lblIncome As System.Windows.Forms.Label
    Friend WithEvents cldrIncome As System.Windows.Forms.MonthCalendar
    Friend WithEvents lblPaydates As System.Windows.Forms.Label
End Class
