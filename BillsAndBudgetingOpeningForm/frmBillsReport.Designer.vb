<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBillsReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBillsReport))
        Me.chtBills = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.cldrBills = New System.Windows.Forms.MonthCalendar()
        Me.lblBillBreakdown = New System.Windows.Forms.Label()
        Me.lblDueDates = New System.Windows.Forms.Label()
        CType(Me.chtBills, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chtBills
        '
        ChartArea1.Name = "ChartArea1"
        Me.chtBills.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chtBills.Legends.Add(Legend1)
        Me.chtBills.Location = New System.Drawing.Point(12, 41)
        Me.chtBills.Name = "chtBills"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Bills"
        Me.chtBills.Series.Add(Series1)
        Me.chtBills.Size = New System.Drawing.Size(300, 300)
        Me.chtBills.TabIndex = 0
        Me.chtBills.Text = "Chart1"
        '
        'cldrBills
        '
        Me.cldrBills.Location = New System.Drawing.Point(324, 41)
        Me.cldrBills.Name = "cldrBills"
        Me.cldrBills.TabIndex = 1
        '
        'lblBillBreakdown
        '
        Me.lblBillBreakdown.AutoSize = True
        Me.lblBillBreakdown.Location = New System.Drawing.Point(12, 25)
        Me.lblBillBreakdown.Name = "lblBillBreakdown"
        Me.lblBillBreakdown.Size = New System.Drawing.Size(80, 13)
        Me.lblBillBreakdown.TabIndex = 2
        Me.lblBillBreakdown.Text = "Bill Breakdown:"
        '
        'lblDueDates
        '
        Me.lblDueDates.AutoSize = True
        Me.lblDueDates.Location = New System.Drawing.Point(321, 25)
        Me.lblDueDates.Name = "lblDueDates"
        Me.lblDueDates.Size = New System.Drawing.Size(61, 13)
        Me.lblDueDates.TabIndex = 3
        Me.lblDueDates.Text = "Due Dates:"
        '
        'frmBillsReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 353)
        Me.Controls.Add(Me.lblDueDates)
        Me.Controls.Add(Me.lblBillBreakdown)
        Me.Controls.Add(Me.cldrBills)
        Me.Controls.Add(Me.chtBills)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBillsReport"
        Me.Text = "Bill Reports"
        CType(Me.chtBills, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chtBills As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents cldrBills As System.Windows.Forms.MonthCalendar
    Friend WithEvents lblBillBreakdown As System.Windows.Forms.Label
    Friend WithEvents lblDueDates As System.Windows.Forms.Label
End Class
