<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStockTake
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormStockTake))
        Me.XTCStockTake = New DevExpress.XtraTab.XtraTabControl()
        Me.XTPScan = New DevExpress.XtraTab.XtraTabPage()
        Me.GCScan = New DevExpress.XtraGrid.GridControl()
        Me.GVScan = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumnId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnNumberScan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnCreatedScan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnPreparedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnLastUpdate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnUpdatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnComp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnqty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.BtnRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnExport = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnImport = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnNew = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.GCCombine = New DevExpress.XtraGrid.GridControl()
        Me.GVCombine = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.GridColumnIsSelect = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridColumnIdReportStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.XTCStockTake, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTCStockTake.SuspendLayout()
        Me.XTPScan.SuspendLayout()
        CType(Me.GCScan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVScan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GCCombine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVCombine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XTCStockTake
        '
        Me.XTCStockTake.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XTCStockTake.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom
        Me.XTCStockTake.Location = New System.Drawing.Point(0, 0)
        Me.XTCStockTake.Name = "XTCStockTake"
        Me.XTCStockTake.SelectedTabPage = Me.XTPScan
        Me.XTCStockTake.Size = New System.Drawing.Size(843, 522)
        Me.XTCStockTake.TabIndex = 0
        Me.XTCStockTake.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XTPScan, Me.XtraTabPage2})
        '
        'XTPScan
        '
        Me.XTPScan.Controls.Add(Me.GCScan)
        Me.XTPScan.Controls.Add(Me.PanelControl1)
        Me.XTPScan.Name = "XTPScan"
        Me.XTPScan.Size = New System.Drawing.Size(837, 494)
        Me.XTPScan.Text = "Scan"
        '
        'GCScan
        '
        Me.GCScan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCScan.Location = New System.Drawing.Point(0, 42)
        Me.GCScan.MainView = Me.GVScan
        Me.GCScan.Name = "GCScan"
        Me.GCScan.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.GCScan.Size = New System.Drawing.Size(837, 452)
        Me.GCScan.TabIndex = 0
        Me.GCScan.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVScan})
        '
        'GVScan
        '
        Me.GVScan.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumnId, Me.GridColumnNumberScan, Me.GridColumnCreatedScan, Me.GridColumnPreparedBy, Me.GridColumnLastUpdate, Me.GridColumnUpdatedBy, Me.GridColumn1, Me.GridColumnComp, Me.GridColumnqty, Me.GridColumnIsSelect, Me.GridColumnIdReportStatus})
        Me.GVScan.GridControl = Me.GCScan
        Me.GVScan.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qty", Me.GridColumnqty, "{0:n0}")})
        Me.GVScan.Name = "GVScan"
        Me.GVScan.OptionsBehavior.AutoExpandAllGroups = True
        Me.GVScan.OptionsView.ShowFooter = True
        Me.GVScan.OptionsView.ShowGroupedColumns = True
        Me.GVScan.OptionsView.ShowGroupPanel = False
        '
        'GridColumnId
        '
        Me.GridColumnId.Caption = "Id"
        Me.GridColumnId.FieldName = "id_st_trans"
        Me.GridColumnId.Name = "GridColumnId"
        Me.GridColumnId.OptionsColumn.AllowEdit = False
        '
        'GridColumnNumberScan
        '
        Me.GridColumnNumberScan.Caption = "Number"
        Me.GridColumnNumberScan.FieldName = "st_trans_number"
        Me.GridColumnNumberScan.Name = "GridColumnNumberScan"
        Me.GridColumnNumberScan.OptionsColumn.AllowEdit = False
        Me.GridColumnNumberScan.Visible = True
        Me.GridColumnNumberScan.VisibleIndex = 0
        Me.GridColumnNumberScan.Width = 121
        '
        'GridColumnCreatedScan
        '
        Me.GridColumnCreatedScan.Caption = "Created Date"
        Me.GridColumnCreatedScan.DisplayFormat.FormatString = "dd MMMM yyyy hh:mm tt"
        Me.GridColumnCreatedScan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumnCreatedScan.FieldName = "st_trans_date"
        Me.GridColumnCreatedScan.Name = "GridColumnCreatedScan"
        Me.GridColumnCreatedScan.OptionsColumn.AllowEdit = False
        Me.GridColumnCreatedScan.Visible = True
        Me.GridColumnCreatedScan.VisibleIndex = 3
        Me.GridColumnCreatedScan.Width = 305
        '
        'GridColumnPreparedBy
        '
        Me.GridColumnPreparedBy.Caption = "Prepared by"
        Me.GridColumnPreparedBy.FieldName = "prepared_by"
        Me.GridColumnPreparedBy.Name = "GridColumnPreparedBy"
        Me.GridColumnPreparedBy.OptionsColumn.AllowEdit = False
        Me.GridColumnPreparedBy.Visible = True
        Me.GridColumnPreparedBy.VisibleIndex = 4
        Me.GridColumnPreparedBy.Width = 183
        '
        'GridColumnLastUpdate
        '
        Me.GridColumnLastUpdate.Caption = "Last Updated"
        Me.GridColumnLastUpdate.DisplayFormat.FormatString = "dd MMMM yyyy hh:mm tt"
        Me.GridColumnLastUpdate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumnLastUpdate.FieldName = "st_trans_updated"
        Me.GridColumnLastUpdate.Name = "GridColumnLastUpdate"
        Me.GridColumnLastUpdate.OptionsColumn.AllowEdit = False
        Me.GridColumnLastUpdate.Visible = True
        Me.GridColumnLastUpdate.VisibleIndex = 5
        Me.GridColumnLastUpdate.Width = 296
        '
        'GridColumnUpdatedBy
        '
        Me.GridColumnUpdatedBy.Caption = "Updated By"
        Me.GridColumnUpdatedBy.FieldName = "employee_name"
        Me.GridColumnUpdatedBy.Name = "GridColumnUpdatedBy"
        Me.GridColumnUpdatedBy.OptionsColumn.AllowEdit = False
        Me.GridColumnUpdatedBy.Visible = True
        Me.GridColumnUpdatedBy.VisibleIndex = 6
        Me.GridColumnUpdatedBy.Width = 139
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Status"
        Me.GridColumn1.FieldName = "report_status"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 7
        Me.GridColumn1.Width = 225
        '
        'GridColumnComp
        '
        Me.GridColumnComp.Caption = "Account"
        Me.GridColumnComp.FieldName = "comp"
        Me.GridColumnComp.Name = "GridColumnComp"
        Me.GridColumnComp.OptionsColumn.AllowEdit = False
        Me.GridColumnComp.Visible = True
        Me.GridColumnComp.VisibleIndex = 1
        Me.GridColumnComp.Width = 213
        '
        'GridColumnqty
        '
        Me.GridColumnqty.Caption = "Qty"
        Me.GridColumnqty.DisplayFormat.FormatString = "N0"
        Me.GridColumnqty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumnqty.FieldName = "qty"
        Me.GridColumnqty.Name = "GridColumnqty"
        Me.GridColumnqty.OptionsColumn.AllowEdit = False
        Me.GridColumnqty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qty", "{0:N0}")})
        Me.GridColumnqty.Visible = True
        Me.GridColumnqty.VisibleIndex = 2
        Me.GridColumnqty.Width = 68
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.CheckEdit1)
        Me.PanelControl1.Controls.Add(Me.BtnRefresh)
        Me.PanelControl1.Controls.Add(Me.BtnExport)
        Me.PanelControl1.Controls.Add(Me.BtnImport)
        Me.PanelControl1.Controls.Add(Me.BtnNew)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(837, 42)
        Me.PanelControl1.TabIndex = 1
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnRefresh.Image = CType(resources.GetObject("BtnRefresh.Image"), System.Drawing.Image)
        Me.BtnRefresh.Location = New System.Drawing.Point(629, 2)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(97, 38)
        Me.BtnRefresh.TabIndex = 2
        Me.BtnRefresh.Text = "Refresh"
        '
        'BtnExport
        '
        Me.BtnExport.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnExport.Image = CType(resources.GetObject("BtnExport.Image"), System.Drawing.Image)
        Me.BtnExport.Location = New System.Drawing.Point(111, 2)
        Me.BtnExport.Name = "BtnExport"
        Me.BtnExport.Size = New System.Drawing.Size(108, 38)
        Me.BtnExport.TabIndex = 1
        Me.BtnExport.Text = "Export Data"
        '
        'BtnImport
        '
        Me.BtnImport.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnImport.Image = CType(resources.GetObject("BtnImport.Image"), System.Drawing.Image)
        Me.BtnImport.Location = New System.Drawing.Point(2, 2)
        Me.BtnImport.Name = "BtnImport"
        Me.BtnImport.Size = New System.Drawing.Size(109, 38)
        Me.BtnImport.TabIndex = 0
        Me.BtnImport.Text = "Import Data"
        '
        'BtnNew
        '
        Me.BtnNew.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnNew.Image = CType(resources.GetObject("BtnNew.Image"), System.Drawing.Image)
        Me.BtnNew.Location = New System.Drawing.Point(726, 2)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(109, 38)
        Me.BtnNew.TabIndex = 3
        Me.BtnNew.Text = "Create New "
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GCCombine)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(837, 494)
        Me.XtraTabPage2.Text = "Combine"
        '
        'GCCombine
        '
        Me.GCCombine.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCCombine.Location = New System.Drawing.Point(0, 0)
        Me.GCCombine.MainView = Me.GVCombine
        Me.GCCombine.Name = "GCCombine"
        Me.GCCombine.Size = New System.Drawing.Size(837, 494)
        Me.GCCombine.TabIndex = 1
        Me.GCCombine.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVCombine})
        '
        'GVCombine
        '
        Me.GVCombine.GridControl = Me.GCCombine
        Me.GVCombine.Name = "GVCombine"
        Me.GVCombine.OptionsBehavior.AutoExpandAllGroups = True
        Me.GVCombine.OptionsBehavior.Editable = False
        Me.GVCombine.OptionsView.ShowFooter = True
        Me.GVCombine.OptionsView.ShowGroupedColumns = True
        Me.GVCombine.OptionsView.ShowGroupPanel = False
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(225, 11)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Select All"
        Me.CheckEdit1.Size = New System.Drawing.Size(75, 19)
        Me.CheckEdit1.TabIndex = 4
        '
        'GridColumnIsSelect
        '
        Me.GridColumnIsSelect.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumnIsSelect.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumnIsSelect.Caption = "Select"
        Me.GridColumnIsSelect.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GridColumnIsSelect.FieldName = "is_select"
        Me.GridColumnIsSelect.Name = "GridColumnIsSelect"
        Me.GridColumnIsSelect.Visible = True
        Me.GridColumnIsSelect.VisibleIndex = 8
        Me.GridColumnIsSelect.Width = 66
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.ValueChecked = "Yes"
        Me.RepositoryItemCheckEdit1.ValueUnchecked = "No"
        '
        'GridColumnIdReportStatus
        '
        Me.GridColumnIdReportStatus.Caption = "Id Report Status"
        Me.GridColumnIdReportStatus.FieldName = "id_report_status"
        Me.GridColumnIdReportStatus.Name = "GridColumnIdReportStatus"
        '
        'FormStockTake
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 522)
        Me.Controls.Add(Me.XTCStockTake)
        Me.Name = "FormStockTake"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Take"
        CType(Me.XTCStockTake, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTCStockTake.ResumeLayout(False)
        Me.XTPScan.ResumeLayout(False)
        CType(Me.GCScan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVScan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GCCombine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVCombine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents XTCStockTake As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XTPScan As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GCScan As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVScan As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GCCombine As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVCombine As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BtnImport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumnId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnNumberScan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnCreatedScan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnLastUpdate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnUpdatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnPreparedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnComp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnqty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GridColumnIsSelect As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridColumnIdReportStatus As DevExpress.XtraGrid.Columns.GridColumn
End Class
