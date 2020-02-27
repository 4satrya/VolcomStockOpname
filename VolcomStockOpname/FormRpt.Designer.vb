<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRpt
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRpt))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.BtnRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnUse = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnAddReport = New DevExpress.XtraEditors.SimpleButton()
        Me.GCData = New DevExpress.XtraGrid.GridControl()
        Me.GVData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumnid_rpt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnrpt_created_by = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnrpt_created_date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnrpt_number = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnrpt_note = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GCData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.BtnRefresh)
        Me.PanelControl1.Controls.Add(Me.BtnUse)
        Me.PanelControl1.Controls.Add(Me.BtnAddReport)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(717, 47)
        Me.PanelControl1.TabIndex = 0
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnRefresh.Image = CType(resources.GetObject("BtnRefresh.Image"), System.Drawing.Image)
        Me.BtnRefresh.Location = New System.Drawing.Point(468, 2)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(103, 43)
        Me.BtnRefresh.TabIndex = 3
        Me.BtnRefresh.Text = "Refresh"
        '
        'BtnUse
        '
        Me.BtnUse.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnUse.Image = CType(resources.GetObject("BtnUse.Image"), System.Drawing.Image)
        Me.BtnUse.Location = New System.Drawing.Point(2, 2)
        Me.BtnUse.Name = "BtnUse"
        Me.BtnUse.Size = New System.Drawing.Size(130, 43)
        Me.BtnUse.TabIndex = 2
        Me.BtnUse.Text = "Use this Report"
        Me.BtnUse.Visible = False
        '
        'BtnAddReport
        '
        Me.BtnAddReport.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnAddReport.Image = CType(resources.GetObject("BtnAddReport.Image"), System.Drawing.Image)
        Me.BtnAddReport.Location = New System.Drawing.Point(571, 2)
        Me.BtnAddReport.Name = "BtnAddReport"
        Me.BtnAddReport.Size = New System.Drawing.Size(144, 43)
        Me.BtnAddReport.TabIndex = 1
        Me.BtnAddReport.Text = "Create New Report"
        '
        'GCData
        '
        Me.GCData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCData.Location = New System.Drawing.Point(0, 47)
        Me.GCData.MainView = Me.GVData
        Me.GCData.Name = "GCData"
        Me.GCData.Size = New System.Drawing.Size(717, 393)
        Me.GCData.TabIndex = 1
        Me.GCData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVData})
        '
        'GVData
        '
        Me.GVData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumnid_rpt, Me.GridColumnrpt_created_by, Me.GridColumnrpt_created_date, Me.GridColumnrpt_number, Me.GridColumnrpt_note})
        Me.GVData.GridControl = Me.GCData
        Me.GVData.Name = "GVData"
        Me.GVData.OptionsBehavior.ReadOnly = True
        Me.GVData.OptionsFind.AlwaysVisible = True
        Me.GVData.OptionsView.ColumnAutoWidth = False
        Me.GVData.OptionsView.ShowGroupPanel = False
        '
        'GridColumnid_rpt
        '
        Me.GridColumnid_rpt.Caption = "id_rpt"
        Me.GridColumnid_rpt.FieldName = "id_rpt"
        Me.GridColumnid_rpt.Name = "GridColumnid_rpt"
        '
        'GridColumnrpt_created_by
        '
        Me.GridColumnrpt_created_by.Caption = "Created By"
        Me.GridColumnrpt_created_by.FieldName = "rpt_created_by"
        Me.GridColumnrpt_created_by.Name = "GridColumnrpt_created_by"
        Me.GridColumnrpt_created_by.Visible = True
        Me.GridColumnrpt_created_by.VisibleIndex = 0
        '
        'GridColumnrpt_created_date
        '
        Me.GridColumnrpt_created_date.Caption = "Created Date"
        Me.GridColumnrpt_created_date.DisplayFormat.FormatString = "dd MMMM yyyy HH:mm"
        Me.GridColumnrpt_created_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumnrpt_created_date.FieldName = "rpt_created_date"
        Me.GridColumnrpt_created_date.Name = "GridColumnrpt_created_date"
        Me.GridColumnrpt_created_date.Visible = True
        Me.GridColumnrpt_created_date.VisibleIndex = 1
        '
        'GridColumnrpt_number
        '
        Me.GridColumnrpt_number.Caption = "Number"
        Me.GridColumnrpt_number.FieldName = "rpt_number"
        Me.GridColumnrpt_number.Name = "GridColumnrpt_number"
        Me.GridColumnrpt_number.Visible = True
        Me.GridColumnrpt_number.VisibleIndex = 2
        '
        'GridColumnrpt_note
        '
        Me.GridColumnrpt_note.Caption = "Note"
        Me.GridColumnrpt_note.FieldName = "rpt_note"
        Me.GridColumnrpt_note.Name = "GridColumnrpt_note"
        Me.GridColumnrpt_note.Visible = True
        Me.GridColumnrpt_note.VisibleIndex = 3
        '
        'FormRpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 440)
        Me.Controls.Add(Me.GCData)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "FormRpt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Take Report"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GCData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BtnUse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnAddReport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GCData As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumnid_rpt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnrpt_created_by As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnrpt_created_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnrpt_number As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnrpt_note As DevExpress.XtraGrid.Columns.GridColumn
End Class
