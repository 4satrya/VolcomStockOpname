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
        Me.XTCProduct = New DevExpress.XtraTab.XtraTabControl()
        Me.XTPScanList = New DevExpress.XtraTab.XtraTabPage()
        Me.GCScan = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip()
        Me.ToolStripCancel = New System.Windows.Forms.ToolStripMenuItem()
        Me.GVScan = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumnId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnNumberScan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnCreatedScan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnPreparedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnLastUpdate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnUpdatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnComp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnqty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnIsSelect = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridColumnIdReportStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnRemark = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn27 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XTPNoTag = New DevExpress.XtraTab.XtraTabPage()
        Me.GCNoTag = New DevExpress.XtraGrid.GridControl()
        Me.GVNoTag = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.BtnExportStop = New DevExpress.XtraEditors.SimpleButton()
        Me.PCSelectAll = New DevExpress.XtraEditors.PanelControl()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.LEViewUser = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.BtnRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnList = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnExport = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnImport = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.SBRejectStore = New DevExpress.XtraEditors.SimpleButton()
        Me.SBNoTagStore = New DevExpress.XtraEditors.SimpleButton()
        Me.SBAddStore = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnNew = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.GCCombine = New DevExpress.XtraGrid.GridControl()
        Me.GVCombine = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnRmk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.BtnRefCom = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnPrintCom = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnCreateCom = New DevExpress.XtraEditors.SimpleButton()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.XTCStockTake, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTCStockTake.SuspendLayout()
        Me.XTPScan.SuspendLayout()
        CType(Me.XTCProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTCProduct.SuspendLayout()
        Me.XTPScanList.SuspendLayout()
        CType(Me.GCScan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip.SuspendLayout()
        CType(Me.GVScan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTPNoTag.SuspendLayout()
        CType(Me.GCNoTag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVNoTag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PCSelectAll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PCSelectAll.SuspendLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.LEViewUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GCCombine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVCombine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'XTCStockTake
        '
        Me.XTCStockTake.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XTCStockTake.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom
        Me.XTCStockTake.Location = New System.Drawing.Point(0, 0)
        Me.XTCStockTake.Name = "XTCStockTake"
        Me.XTCStockTake.SelectedTabPage = Me.XTPScan
        Me.XTCStockTake.Size = New System.Drawing.Size(1530, 522)
        Me.XTCStockTake.TabIndex = 0
        Me.XTCStockTake.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XTPScan, Me.XtraTabPage2})
        '
        'XTPScan
        '
        Me.XTPScan.Controls.Add(Me.XTCProduct)
        Me.XTPScan.Controls.Add(Me.PanelControl1)
        Me.XTPScan.Name = "XTPScan"
        Me.XTPScan.Size = New System.Drawing.Size(1524, 494)
        Me.XTPScan.Text = "Scan"
        '
        'XTCProduct
        '
        Me.XTCProduct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XTCProduct.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left
        Me.XTCProduct.Location = New System.Drawing.Point(0, 42)
        Me.XTCProduct.Name = "XTCProduct"
        Me.XTCProduct.SelectedTabPage = Me.XTPScanList
        Me.XTCProduct.Size = New System.Drawing.Size(1524, 452)
        Me.XTCProduct.TabIndex = 2
        Me.XTCProduct.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XTPScanList, Me.XTPNoTag})
        '
        'XTPScanList
        '
        Me.XTPScanList.Controls.Add(Me.GCScan)
        Me.XTPScanList.Name = "XTPScanList"
        Me.XTPScanList.Size = New System.Drawing.Size(1495, 446)
        Me.XTPScanList.Text = "Scan List"
        '
        'GCScan
        '
        Me.GCScan.ContextMenuStrip = Me.ContextMenuStrip
        Me.GCScan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCScan.Location = New System.Drawing.Point(0, 0)
        Me.GCScan.MainView = Me.GVScan
        Me.GCScan.Name = "GCScan"
        Me.GCScan.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.GCScan.Size = New System.Drawing.Size(1495, 446)
        Me.GCScan.TabIndex = 0
        Me.GCScan.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVScan})
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripCancel})
        Me.ContextMenuStrip.Name = "ContextMenuStrip"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(111, 26)
        '
        'ToolStripCancel
        '
        Me.ToolStripCancel.Name = "ToolStripCancel"
        Me.ToolStripCancel.Size = New System.Drawing.Size(110, 22)
        Me.ToolStripCancel.Text = "Cancel"
        '
        'GVScan
        '
        Me.GVScan.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumnId, Me.GridColumnNumberScan, Me.GridColumnCreatedScan, Me.GridColumnPreparedBy, Me.GridColumnLastUpdate, Me.GridColumnUpdatedBy, Me.GridColumn1, Me.GridColumn11, Me.GridColumnComp, Me.GridColumnqty, Me.GridColumnIsSelect, Me.GridColumnIdReportStatus, Me.GridColumnRemark, Me.GridColumn27})
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
        Me.GridColumnNumberScan.Width = 115
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
        Me.GridColumnCreatedScan.VisibleIndex = 4
        Me.GridColumnCreatedScan.Width = 267
        '
        'GridColumnPreparedBy
        '
        Me.GridColumnPreparedBy.Caption = "Prepared by"
        Me.GridColumnPreparedBy.FieldName = "prepared_by"
        Me.GridColumnPreparedBy.Name = "GridColumnPreparedBy"
        Me.GridColumnPreparedBy.OptionsColumn.AllowEdit = False
        Me.GridColumnPreparedBy.Visible = True
        Me.GridColumnPreparedBy.VisibleIndex = 5
        Me.GridColumnPreparedBy.Width = 159
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
        Me.GridColumnLastUpdate.VisibleIndex = 6
        Me.GridColumnLastUpdate.Width = 259
        '
        'GridColumnUpdatedBy
        '
        Me.GridColumnUpdatedBy.Caption = "Updated By"
        Me.GridColumnUpdatedBy.FieldName = "employee_name"
        Me.GridColumnUpdatedBy.Name = "GridColumnUpdatedBy"
        Me.GridColumnUpdatedBy.OptionsColumn.AllowEdit = False
        Me.GridColumnUpdatedBy.Visible = True
        Me.GridColumnUpdatedBy.VisibleIndex = 7
        Me.GridColumnUpdatedBy.Width = 120
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Status"
        Me.GridColumn1.FieldName = "report_status"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 8
        Me.GridColumn1.Width = 197
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Status Note"
        Me.GridColumn11.FieldName = "report_status_note"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 9
        '
        'GridColumnComp
        '
        Me.GridColumnComp.Caption = "Account"
        Me.GridColumnComp.FieldName = "comp"
        Me.GridColumnComp.Name = "GridColumnComp"
        Me.GridColumnComp.OptionsColumn.AllowEdit = False
        Me.GridColumnComp.Visible = True
        Me.GridColumnComp.VisibleIndex = 1
        Me.GridColumnComp.Width = 203
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
        Me.GridColumnqty.VisibleIndex = 3
        Me.GridColumnqty.Width = 58
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
        Me.GridColumnIsSelect.VisibleIndex = 10
        Me.GridColumnIsSelect.Width = 70
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
        'GridColumnRemark
        '
        Me.GridColumnRemark.Caption = "Remark"
        Me.GridColumnRemark.FieldName = "remark"
        Me.GridColumnRemark.Name = "GridColumnRemark"
        Me.GridColumnRemark.Visible = True
        Me.GridColumnRemark.VisibleIndex = 2
        Me.GridColumnRemark.Width = 168
        '
        'GridColumn27
        '
        Me.GridColumn27.FieldName = "is_reject"
        Me.GridColumn27.Name = "GridColumn27"
        '
        'XTPNoTag
        '
        Me.XTPNoTag.Controls.Add(Me.GCNoTag)
        Me.XTPNoTag.Name = "XTPNoTag"
        Me.XTPNoTag.Size = New System.Drawing.Size(1495, 446)
        Me.XTPNoTag.Text = "No Tag"
        '
        'GCNoTag
        '
        Me.GCNoTag.ContextMenuStrip = Me.ContextMenuStrip
        Me.GCNoTag.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCNoTag.Location = New System.Drawing.Point(0, 0)
        Me.GCNoTag.MainView = Me.GVNoTag
        Me.GCNoTag.Name = "GCNoTag"
        Me.GCNoTag.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit3})
        Me.GCNoTag.Size = New System.Drawing.Size(1495, 446)
        Me.GCNoTag.TabIndex = 1
        Me.GCNoTag.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVNoTag})
        '
        'GVNoTag
        '
        Me.GVNoTag.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19, Me.GridColumn20, Me.GridColumn21, Me.GridColumn22, Me.GridColumn23, Me.GridColumn24, Me.GridColumn25, Me.GridColumn26})
        Me.GVNoTag.GridControl = Me.GCNoTag
        Me.GVNoTag.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qty", Me.GridColumn23, "{0:n0}")})
        Me.GVNoTag.Name = "GVNoTag"
        Me.GVNoTag.OptionsBehavior.AutoExpandAllGroups = True
        Me.GVNoTag.OptionsView.ShowFooter = True
        Me.GVNoTag.OptionsView.ShowGroupedColumns = True
        Me.GVNoTag.OptionsView.ShowGroupPanel = False
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Id"
        Me.GridColumn14.FieldName = "id_st_no_tag"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.AllowEdit = False
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Number"
        Me.GridColumn15.FieldName = "no_tag_number"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.AllowEdit = False
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 0
        Me.GridColumn15.Width = 115
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Created Date"
        Me.GridColumn16.DisplayFormat.FormatString = "dd MMMM yyyy hh:mm tt"
        Me.GridColumn16.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn16.FieldName = "no_tag_date"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.OptionsColumn.AllowEdit = False
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 4
        Me.GridColumn16.Width = 267
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Prepared by"
        Me.GridColumn17.FieldName = "prepared_by"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.OptionsColumn.AllowEdit = False
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 5
        Me.GridColumn17.Width = 159
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Last Updated"
        Me.GridColumn18.DisplayFormat.FormatString = "dd MMMM yyyy hh:mm tt"
        Me.GridColumn18.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn18.FieldName = "no_tag_updated_date"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.OptionsColumn.AllowEdit = False
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 6
        Me.GridColumn18.Width = 259
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "Updated By"
        Me.GridColumn19.FieldName = "employee_name"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.OptionsColumn.AllowEdit = False
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 7
        Me.GridColumn19.Width = 120
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "Status"
        Me.GridColumn20.FieldName = "report_status"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.OptionsColumn.AllowEdit = False
        Me.GridColumn20.Visible = True
        Me.GridColumn20.VisibleIndex = 8
        Me.GridColumn20.Width = 197
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "Status Note"
        Me.GridColumn21.FieldName = "report_status_note"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.OptionsColumn.AllowEdit = False
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 9
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "Account"
        Me.GridColumn22.FieldName = "comp"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.OptionsColumn.AllowEdit = False
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 1
        Me.GridColumn22.Width = 203
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "Qty"
        Me.GridColumn23.DisplayFormat.FormatString = "N0"
        Me.GridColumn23.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn23.FieldName = "qty"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.OptionsColumn.AllowEdit = False
        Me.GridColumn23.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qty", "{0:N0}")})
        Me.GridColumn23.Visible = True
        Me.GridColumn23.VisibleIndex = 3
        Me.GridColumn23.Width = 58
        '
        'GridColumn24
        '
        Me.GridColumn24.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn24.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn24.Caption = "Select"
        Me.GridColumn24.ColumnEdit = Me.RepositoryItemCheckEdit3
        Me.GridColumn24.FieldName = "is_select"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.Visible = True
        Me.GridColumn24.VisibleIndex = 10
        Me.GridColumn24.Width = 70
        '
        'RepositoryItemCheckEdit3
        '
        Me.RepositoryItemCheckEdit3.AutoHeight = False
        Me.RepositoryItemCheckEdit3.Name = "RepositoryItemCheckEdit3"
        Me.RepositoryItemCheckEdit3.ValueChecked = "Yes"
        Me.RepositoryItemCheckEdit3.ValueUnchecked = "No"
        '
        'GridColumn25
        '
        Me.GridColumn25.Caption = "Id Report Status"
        Me.GridColumn25.FieldName = "id_report_status"
        Me.GridColumn25.Name = "GridColumn25"
        '
        'GridColumn26
        '
        Me.GridColumn26.Caption = "Remark"
        Me.GridColumn26.FieldName = "remark"
        Me.GridColumn26.Name = "GridColumn26"
        Me.GridColumn26.Visible = True
        Me.GridColumn26.VisibleIndex = 2
        Me.GridColumn26.Width = 168
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.BtnExportStop)
        Me.PanelControl1.Controls.Add(Me.PCSelectAll)
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Controls.Add(Me.BtnRefresh)
        Me.PanelControl1.Controls.Add(Me.BtnList)
        Me.PanelControl1.Controls.Add(Me.BtnExport)
        Me.PanelControl1.Controls.Add(Me.BtnImport)
        Me.PanelControl1.Controls.Add(Me.BtnPrint)
        Me.PanelControl1.Controls.Add(Me.SBRejectStore)
        Me.PanelControl1.Controls.Add(Me.SBNoTagStore)
        Me.PanelControl1.Controls.Add(Me.SBAddStore)
        Me.PanelControl1.Controls.Add(Me.BtnNew)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1524, 42)
        Me.PanelControl1.TabIndex = 1
        '
        'BtnExportStop
        '
        Me.BtnExportStop.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnExportStop.Image = CType(resources.GetObject("BtnExportStop.Image"), System.Drawing.Image)
        Me.BtnExportStop.Location = New System.Drawing.Point(311, 2)
        Me.BtnExportStop.Name = "BtnExportStop"
        Me.BtnExportStop.Size = New System.Drawing.Size(141, 38)
        Me.BtnExportStop.TabIndex = 10
        Me.BtnExportStop.Text = "Export && Stop Scan"
        Me.BtnExportStop.Visible = False
        '
        'PCSelectAll
        '
        Me.PCSelectAll.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PCSelectAll.Controls.Add(Me.CheckEdit1)
        Me.PCSelectAll.Dock = System.Windows.Forms.DockStyle.Left
        Me.PCSelectAll.Location = New System.Drawing.Point(219, 2)
        Me.PCSelectAll.Name = "PCSelectAll"
        Me.PCSelectAll.Size = New System.Drawing.Size(92, 38)
        Me.PCSelectAll.TabIndex = 11
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(6, 9)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Select All"
        Me.CheckEdit1.Size = New System.Drawing.Size(76, 19)
        Me.CheckEdit1.TabIndex = 4
        '
        'PanelControl3
        '
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.LEViewUser)
        Me.PanelControl3.Controls.Add(Me.LabelControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelControl3.Location = New System.Drawing.Point(633, 2)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(204, 38)
        Me.PanelControl3.TabIndex = 9
        '
        'LEViewUser
        '
        Me.LEViewUser.Location = New System.Drawing.Point(68, 9)
        Me.LEViewUser.Name = "LEViewUser"
        Me.LEViewUser.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LEViewUser.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_user_type", "id_user_type", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("type_user", "Type")})
        Me.LEViewUser.Size = New System.Drawing.Size(131, 20)
        Me.LEViewUser.TabIndex = 7
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(8, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl1.TabIndex = 8
        Me.LabelControl1.Text = "Created By"
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnRefresh.Image = CType(resources.GetObject("BtnRefresh.Image"), System.Drawing.Image)
        Me.BtnRefresh.Location = New System.Drawing.Point(837, 2)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(97, 38)
        Me.BtnRefresh.TabIndex = 2
        Me.BtnRefresh.Text = "Refresh"
        '
        'BtnList
        '
        Me.BtnList.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnList.Image = CType(resources.GetObject("BtnList.Image"), System.Drawing.Image)
        Me.BtnList.Location = New System.Drawing.Point(934, 2)
        Me.BtnList.Name = "BtnList"
        Me.BtnList.Size = New System.Drawing.Size(88, 38)
        Me.BtnList.TabIndex = 6
        Me.BtnList.Text = "List"
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
        'BtnPrint
        '
        Me.BtnPrint.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.Location = New System.Drawing.Point(1022, 2)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(88, 38)
        Me.BtnPrint.TabIndex = 5
        Me.BtnPrint.Text = "Print"
        '
        'SBRejectStore
        '
        Me.SBRejectStore.Dock = System.Windows.Forms.DockStyle.Right
        Me.SBRejectStore.Image = CType(resources.GetObject("SBRejectStore.Image"), System.Drawing.Image)
        Me.SBRejectStore.Location = New System.Drawing.Point(1110, 2)
        Me.SBRejectStore.LookAndFeel.SkinMaskColor = System.Drawing.Color.Yellow
        Me.SBRejectStore.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SBRejectStore.Name = "SBRejectStore"
        Me.SBRejectStore.Size = New System.Drawing.Size(97, 38)
        Me.SBRejectStore.TabIndex = 8916
        Me.SBRejectStore.Text = "Reject"
        '
        'SBNoTagStore
        '
        Me.SBNoTagStore.Dock = System.Windows.Forms.DockStyle.Right
        Me.SBNoTagStore.Image = CType(resources.GetObject("SBNoTagStore.Image"), System.Drawing.Image)
        Me.SBNoTagStore.Location = New System.Drawing.Point(1207, 2)
        Me.SBNoTagStore.LookAndFeel.SkinMaskColor = System.Drawing.Color.Red
        Me.SBNoTagStore.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SBNoTagStore.Name = "SBNoTagStore"
        Me.SBNoTagStore.Size = New System.Drawing.Size(97, 38)
        Me.SBNoTagStore.TabIndex = 8915
        Me.SBNoTagStore.Text = "No Tag"
        '
        'SBAddStore
        '
        Me.SBAddStore.Dock = System.Windows.Forms.DockStyle.Right
        Me.SBAddStore.Image = CType(resources.GetObject("SBAddStore.Image"), System.Drawing.Image)
        Me.SBAddStore.Location = New System.Drawing.Point(1304, 2)
        Me.SBAddStore.LookAndFeel.SkinMaskColor = System.Drawing.Color.Green
        Me.SBAddStore.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SBAddStore.Name = "SBAddStore"
        Me.SBAddStore.Size = New System.Drawing.Size(109, 38)
        Me.SBAddStore.TabIndex = 8914
        Me.SBAddStore.Text = "Create New"
        '
        'BtnNew
        '
        Me.BtnNew.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnNew.Image = CType(resources.GetObject("BtnNew.Image"), System.Drawing.Image)
        Me.BtnNew.Location = New System.Drawing.Point(1413, 2)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(109, 38)
        Me.BtnNew.TabIndex = 3
        Me.BtnNew.Text = "Create New "
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GCCombine)
        Me.XtraTabPage2.Controls.Add(Me.PanelControl2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1524, 494)
        Me.XtraTabPage2.Text = "Combine"
        '
        'GCCombine
        '
        Me.GCCombine.ContextMenuStrip = Me.ContextMenuStrip
        Me.GCCombine.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCCombine.Location = New System.Drawing.Point(0, 42)
        Me.GCCombine.MainView = Me.GVCombine
        Me.GCCombine.Name = "GCCombine"
        Me.GCCombine.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit2})
        Me.GCCombine.Size = New System.Drawing.Size(1524, 452)
        Me.GCCombine.TabIndex = 1
        Me.GCCombine.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVCombine})
        '
        'GVCombine
        '
        Me.GVCombine.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn13, Me.GridColumn9, Me.GridColumn10, Me.GridColumn12, Me.GridColumnRmk})
        Me.GVCombine.GridControl = Me.GCCombine
        Me.GVCombine.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qty", Me.GridColumn10, "{0:n0}")})
        Me.GVCombine.Name = "GVCombine"
        Me.GVCombine.OptionsBehavior.AutoExpandAllGroups = True
        Me.GVCombine.OptionsBehavior.Editable = False
        Me.GVCombine.OptionsView.ShowFooter = True
        Me.GVCombine.OptionsView.ShowGroupedColumns = True
        Me.GVCombine.OptionsView.ShowGroupPanel = False
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Id"
        Me.GridColumn2.FieldName = "id_st_trans"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Number"
        Me.GridColumn3.FieldName = "st_trans_number"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        Me.GridColumn3.Width = 120
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Created Date"
        Me.GridColumn4.DisplayFormat.FormatString = "dd MMMM yyyy hh:mm tt"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn4.FieldName = "st_trans_date"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 4
        Me.GridColumn4.Width = 280
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Prepared by"
        Me.GridColumn5.FieldName = "prepared_by"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 5
        Me.GridColumn5.Width = 166
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Last Updated"
        Me.GridColumn6.DisplayFormat.FormatString = "dd MMMM yyyy hh:mm tt"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn6.FieldName = "st_trans_updated"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 6
        Me.GridColumn6.Width = 271
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Updated By"
        Me.GridColumn7.FieldName = "employee_name"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 7
        Me.GridColumn7.Width = 127
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Status"
        Me.GridColumn8.FieldName = "report_status"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 8
        Me.GridColumn8.Width = 215
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Status Note"
        Me.GridColumn13.FieldName = "report_status_note"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.AllowEdit = False
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 9
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Account"
        Me.GridColumn9.FieldName = "comp"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 1
        Me.GridColumn9.Width = 211
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Qty"
        Me.GridColumn10.DisplayFormat.FormatString = "N0"
        Me.GridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn10.FieldName = "qty"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qty", "{0:N0}")})
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 3
        Me.GridColumn10.Width = 61
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Id Report Status"
        Me.GridColumn12.FieldName = "id_report_status"
        Me.GridColumn12.Name = "GridColumn12"
        '
        'GridColumnRmk
        '
        Me.GridColumnRmk.Caption = "Remark"
        Me.GridColumnRmk.FieldName = "remark"
        Me.GridColumnRmk.Name = "GridColumnRmk"
        Me.GridColumnRmk.Visible = True
        Me.GridColumnRmk.VisibleIndex = 2
        Me.GridColumnRmk.Width = 165
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        Me.RepositoryItemCheckEdit2.ValueChecked = "Yes"
        Me.RepositoryItemCheckEdit2.ValueUnchecked = "No"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.BtnRefCom)
        Me.PanelControl2.Controls.Add(Me.BtnPrintCom)
        Me.PanelControl2.Controls.Add(Me.BtnCreateCom)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1524, 42)
        Me.PanelControl2.TabIndex = 2
        '
        'BtnRefCom
        '
        Me.BtnRefCom.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnRefCom.Image = CType(resources.GetObject("BtnRefCom.Image"), System.Drawing.Image)
        Me.BtnRefCom.Location = New System.Drawing.Point(1225, 2)
        Me.BtnRefCom.Name = "BtnRefCom"
        Me.BtnRefCom.Size = New System.Drawing.Size(97, 38)
        Me.BtnRefCom.TabIndex = 2
        Me.BtnRefCom.Text = "Refresh"
        '
        'BtnPrintCom
        '
        Me.BtnPrintCom.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnPrintCom.Image = CType(resources.GetObject("BtnPrintCom.Image"), System.Drawing.Image)
        Me.BtnPrintCom.Location = New System.Drawing.Point(1322, 2)
        Me.BtnPrintCom.Name = "BtnPrintCom"
        Me.BtnPrintCom.Size = New System.Drawing.Size(91, 38)
        Me.BtnPrintCom.TabIndex = 4
        Me.BtnPrintCom.Text = "Print"
        '
        'BtnCreateCom
        '
        Me.BtnCreateCom.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnCreateCom.Image = CType(resources.GetObject("BtnCreateCom.Image"), System.Drawing.Image)
        Me.BtnCreateCom.Location = New System.Drawing.Point(1413, 2)
        Me.BtnCreateCom.Name = "BtnCreateCom"
        Me.BtnCreateCom.Size = New System.Drawing.Size(109, 38)
        Me.BtnCreateCom.TabIndex = 3
        Me.BtnCreateCom.Text = "Create New "
        '
        'FormStockTake
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1530, 522)
        Me.Controls.Add(Me.XTCStockTake)
        Me.Name = "FormStockTake"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Take"
        CType(Me.XTCStockTake, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTCStockTake.ResumeLayout(False)
        Me.XTPScan.ResumeLayout(False)
        CType(Me.XTCProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTCProduct.ResumeLayout(False)
        Me.XTPScanList.ResumeLayout(False)
        CType(Me.GCScan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip.ResumeLayout(False)
        CType(Me.GVScan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTPNoTag.ResumeLayout(False)
        CType(Me.GCNoTag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVNoTag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PCSelectAll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PCSelectAll.ResumeLayout(False)
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.LEViewUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GCCombine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVCombine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents XTCStockTake As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XTPScan As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GCScan As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVScan As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents GCCombine As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVCombine As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents BtnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BtnRefCom As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnCreateCom As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnPrintCom As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumnRemark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnRmk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnList As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LEViewUser As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents ContextMenuStrip As ContextMenuStrip
    Friend WithEvents ToolStripCancel As ToolStripMenuItem
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnExportStop As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PCSelectAll As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SBRejectStore As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SBNoTagStore As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SBAddStore As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XTCProduct As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XTPScanList As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XTPNoTag As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GCNoTag As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVNoTag As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn27 As DevExpress.XtraGrid.Columns.GridColumn
End Class
