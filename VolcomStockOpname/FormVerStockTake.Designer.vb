﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVerStockTake
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormVerStockTake))
        Me.XTCStockTake = New DevExpress.XtraTab.XtraTabControl()
        Me.XTPScan = New DevExpress.XtraTab.XtraTabPage()
        Me.GCScan = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripCancel = New System.Windows.Forms.ToolStripMenuItem()
        Me.GVScan = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumnId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnNumberScan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnCreatedScan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnPreparedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnLastUpdate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnUpdatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnComp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnqty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnIsSelect = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridColumnIdReportStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnRemark = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnRemarkRef = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.LEViewUser = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.BtnImport = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnExport = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnList = New DevExpress.XtraEditors.SimpleButton()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.BtnPrint = New DevExpress.XtraEditors.SimpleButton()
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
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnRmk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.BtnRefCom = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnPrintCom = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnCreateCom = New DevExpress.XtraEditors.SimpleButton()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.XTCStockTake, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTCStockTake.SuspendLayout()
        Me.XTPScan.SuspendLayout()
        CType(Me.GCScan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip.SuspendLayout()
        CType(Me.GVScan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.LEViewUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.XTCStockTake.Size = New System.Drawing.Size(1050, 518)
        Me.XTCStockTake.TabIndex = 1
        Me.XTCStockTake.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XTPScan, Me.XtraTabPage2})
        '
        'XTPScan
        '
        Me.XTPScan.Controls.Add(Me.GCScan)
        Me.XTPScan.Controls.Add(Me.PanelControl1)
        Me.XTPScan.Name = "XTPScan"
        Me.XTPScan.Size = New System.Drawing.Size(1044, 490)
        Me.XTPScan.Text = "Scan"
        '
        'GCScan
        '
        Me.GCScan.ContextMenuStrip = Me.ContextMenuStrip
        Me.GCScan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCScan.Location = New System.Drawing.Point(0, 42)
        Me.GCScan.MainView = Me.GVScan
        Me.GCScan.Name = "GCScan"
        Me.GCScan.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.GCScan.Size = New System.Drawing.Size(1044, 448)
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
        Me.GVScan.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumnId, Me.GridColumnNumberScan, Me.GridColumn11, Me.GridColumnCreatedScan, Me.GridColumnPreparedBy, Me.GridColumnLastUpdate, Me.GridColumnUpdatedBy, Me.GridColumn1, Me.GridColumn13, Me.GridColumnComp, Me.GridColumnqty, Me.GridColumnIsSelect, Me.GridColumnIdReportStatus, Me.GridColumnRemark, Me.GridColumnRemarkRef})
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
        Me.GridColumnNumberScan.FieldName = "st_trans_ver_number"
        Me.GridColumnNumberScan.Name = "GridColumnNumberScan"
        Me.GridColumnNumberScan.OptionsColumn.AllowEdit = False
        Me.GridColumnNumberScan.Visible = True
        Me.GridColumnNumberScan.VisibleIndex = 0
        Me.GridColumnNumberScan.Width = 63
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Ref. No."
        Me.GridColumn11.FieldName = "st_trans_number"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 1
        Me.GridColumn11.Width = 65
        '
        'GridColumnCreatedScan
        '
        Me.GridColumnCreatedScan.Caption = "Created Date"
        Me.GridColumnCreatedScan.DisplayFormat.FormatString = "dd MMMM yyyy hh:mm tt"
        Me.GridColumnCreatedScan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumnCreatedScan.FieldName = "st_trans_ver_date"
        Me.GridColumnCreatedScan.Name = "GridColumnCreatedScan"
        Me.GridColumnCreatedScan.OptionsColumn.AllowEdit = False
        Me.GridColumnCreatedScan.Visible = True
        Me.GridColumnCreatedScan.VisibleIndex = 6
        Me.GridColumnCreatedScan.Width = 141
        '
        'GridColumnPreparedBy
        '
        Me.GridColumnPreparedBy.Caption = "Prepared by"
        Me.GridColumnPreparedBy.FieldName = "prepared_by"
        Me.GridColumnPreparedBy.Name = "GridColumnPreparedBy"
        Me.GridColumnPreparedBy.OptionsColumn.AllowEdit = False
        Me.GridColumnPreparedBy.Visible = True
        Me.GridColumnPreparedBy.VisibleIndex = 7
        Me.GridColumnPreparedBy.Width = 83
        '
        'GridColumnLastUpdate
        '
        Me.GridColumnLastUpdate.Caption = "Last Updated"
        Me.GridColumnLastUpdate.DisplayFormat.FormatString = "dd MMMM yyyy hh:mm tt"
        Me.GridColumnLastUpdate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumnLastUpdate.FieldName = "st_trans_ver_updated"
        Me.GridColumnLastUpdate.Name = "GridColumnLastUpdate"
        Me.GridColumnLastUpdate.OptionsColumn.AllowEdit = False
        Me.GridColumnLastUpdate.Visible = True
        Me.GridColumnLastUpdate.VisibleIndex = 8
        Me.GridColumnLastUpdate.Width = 137
        '
        'GridColumnUpdatedBy
        '
        Me.GridColumnUpdatedBy.Caption = "Updated By"
        Me.GridColumnUpdatedBy.FieldName = "employee_name"
        Me.GridColumnUpdatedBy.Name = "GridColumnUpdatedBy"
        Me.GridColumnUpdatedBy.OptionsColumn.AllowEdit = False
        Me.GridColumnUpdatedBy.Visible = True
        Me.GridColumnUpdatedBy.VisibleIndex = 9
        Me.GridColumnUpdatedBy.Width = 62
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Status"
        Me.GridColumn1.FieldName = "report_status"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 10
        Me.GridColumn1.Width = 104
        '
        'GridColumnComp
        '
        Me.GridColumnComp.Caption = "Account"
        Me.GridColumnComp.FieldName = "comp"
        Me.GridColumnComp.Name = "GridColumnComp"
        Me.GridColumnComp.OptionsColumn.AllowEdit = False
        Me.GridColumnComp.Visible = True
        Me.GridColumnComp.VisibleIndex = 3
        Me.GridColumnComp.Width = 107
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
        Me.GridColumnqty.VisibleIndex = 5
        Me.GridColumnqty.Width = 29
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
        Me.GridColumnIsSelect.VisibleIndex = 12
        Me.GridColumnIsSelect.Width = 49
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
        Me.GridColumnIdReportStatus.OptionsColumn.AllowEdit = False
        '
        'GridColumnRemark
        '
        Me.GridColumnRemark.Caption = "Remark"
        Me.GridColumnRemark.FieldName = "remark"
        Me.GridColumnRemark.Name = "GridColumnRemark"
        Me.GridColumnRemark.OptionsColumn.AllowEdit = False
        Me.GridColumnRemark.Visible = True
        Me.GridColumnRemark.VisibleIndex = 4
        Me.GridColumnRemark.Width = 88
        '
        'GridColumnRemarkRef
        '
        Me.GridColumnRemarkRef.Caption = "Ref."
        Me.GridColumnRemarkRef.FieldName = "remark_ref"
        Me.GridColumnRemarkRef.Name = "GridColumnRemarkRef"
        Me.GridColumnRemarkRef.OptionsColumn.AllowEdit = False
        Me.GridColumnRemarkRef.Visible = True
        Me.GridColumnRemarkRef.VisibleIndex = 2
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Controls.Add(Me.BtnImport)
        Me.PanelControl1.Controls.Add(Me.BtnExport)
        Me.PanelControl1.Controls.Add(Me.BtnRefresh)
        Me.PanelControl1.Controls.Add(Me.BtnList)
        Me.PanelControl1.Controls.Add(Me.CheckEdit1)
        Me.PanelControl1.Controls.Add(Me.BtnPrint)
        Me.PanelControl1.Controls.Add(Me.BtnNew)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1044, 42)
        Me.PanelControl1.TabIndex = 1
        '
        'PanelControl3
        '
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.LEViewUser)
        Me.PanelControl3.Controls.Add(Me.LabelControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelControl3.Location = New System.Drawing.Point(239, 2)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(204, 38)
        Me.PanelControl3.TabIndex = 10
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
        'BtnImport
        '
        Me.BtnImport.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnImport.Image = CType(resources.GetObject("BtnImport.Image"), System.Drawing.Image)
        Me.BtnImport.Location = New System.Drawing.Point(443, 2)
        Me.BtnImport.Name = "BtnImport"
        Me.BtnImport.Size = New System.Drawing.Size(109, 38)
        Me.BtnImport.TabIndex = 0
        Me.BtnImport.Text = "Import Data"
        Me.BtnImport.Visible = False
        '
        'BtnExport
        '
        Me.BtnExport.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnExport.Image = CType(resources.GetObject("BtnExport.Image"), System.Drawing.Image)
        Me.BtnExport.Location = New System.Drawing.Point(552, 2)
        Me.BtnExport.Name = "BtnExport"
        Me.BtnExport.Size = New System.Drawing.Size(108, 38)
        Me.BtnExport.TabIndex = 1
        Me.BtnExport.Text = "Export Data"
        Me.BtnExport.Visible = False
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnRefresh.Image = CType(resources.GetObject("BtnRefresh.Image"), System.Drawing.Image)
        Me.BtnRefresh.Location = New System.Drawing.Point(660, 2)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(97, 38)
        Me.BtnRefresh.TabIndex = 2
        Me.BtnRefresh.Text = "Refresh"
        '
        'BtnList
        '
        Me.BtnList.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnList.Image = CType(resources.GetObject("BtnList.Image"), System.Drawing.Image)
        Me.BtnList.Location = New System.Drawing.Point(757, 2)
        Me.BtnList.Name = "BtnList"
        Me.BtnList.Size = New System.Drawing.Size(88, 38)
        Me.BtnList.TabIndex = 6
        Me.BtnList.Text = "List"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(12, 12)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Select All"
        Me.CheckEdit1.Size = New System.Drawing.Size(75, 19)
        Me.CheckEdit1.TabIndex = 4
        '
        'BtnPrint
        '
        Me.BtnPrint.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.Location = New System.Drawing.Point(845, 2)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(88, 38)
        Me.BtnPrint.TabIndex = 5
        Me.BtnPrint.Text = "Print"
        '
        'BtnNew
        '
        Me.BtnNew.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnNew.Image = CType(resources.GetObject("BtnNew.Image"), System.Drawing.Image)
        Me.BtnNew.Location = New System.Drawing.Point(933, 2)
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
        Me.XtraTabPage2.Size = New System.Drawing.Size(1044, 490)
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
        Me.GCCombine.Size = New System.Drawing.Size(1044, 448)
        Me.GCCombine.TabIndex = 1
        Me.GCCombine.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVCombine})
        '
        'GVCombine
        '
        Me.GVCombine.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn14, Me.GridColumn9, Me.GridColumn10, Me.GridColumn12, Me.GridColumnRmk})
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
        Me.GridColumn2.FieldName = "id_st_trans_ver"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Number"
        Me.GridColumn3.FieldName = "st_trans_ver_number"
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
        Me.GridColumn4.FieldName = "st_trans_ver_date"
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
        Me.GridColumn6.FieldName = "st_trans_ver_updated"
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
        Me.PanelControl2.Size = New System.Drawing.Size(1044, 42)
        Me.PanelControl2.TabIndex = 2
        '
        'BtnRefCom
        '
        Me.BtnRefCom.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnRefCom.Image = CType(resources.GetObject("BtnRefCom.Image"), System.Drawing.Image)
        Me.BtnRefCom.Location = New System.Drawing.Point(745, 2)
        Me.BtnRefCom.Name = "BtnRefCom"
        Me.BtnRefCom.Size = New System.Drawing.Size(97, 38)
        Me.BtnRefCom.TabIndex = 2
        Me.BtnRefCom.Text = "Refresh"
        '
        'BtnPrintCom
        '
        Me.BtnPrintCom.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnPrintCom.Image = CType(resources.GetObject("BtnPrintCom.Image"), System.Drawing.Image)
        Me.BtnPrintCom.Location = New System.Drawing.Point(842, 2)
        Me.BtnPrintCom.Name = "BtnPrintCom"
        Me.BtnPrintCom.Size = New System.Drawing.Size(91, 38)
        Me.BtnPrintCom.TabIndex = 4
        Me.BtnPrintCom.Text = "Print"
        '
        'BtnCreateCom
        '
        Me.BtnCreateCom.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnCreateCom.Image = CType(resources.GetObject("BtnCreateCom.Image"), System.Drawing.Image)
        Me.BtnCreateCom.Location = New System.Drawing.Point(933, 2)
        Me.BtnCreateCom.Name = "BtnCreateCom"
        Me.BtnCreateCom.Size = New System.Drawing.Size(109, 38)
        Me.BtnCreateCom.TabIndex = 3
        Me.BtnCreateCom.Text = "Create New "
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Status Note"
        Me.GridColumn13.FieldName = "report_status_note"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.AllowEdit = False
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 11
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Status Note"
        Me.GridColumn14.FieldName = "report_status_note"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.AllowEdit = False
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 9
        '
        'FormVerStockTake
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 518)
        Me.Controls.Add(Me.XTCStockTake)
        Me.MinimizeBox = False
        Me.Name = "FormVerStockTake"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Take"
        CType(Me.XTCStockTake, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTCStockTake.ResumeLayout(False)
        Me.XTPScan.ResumeLayout(False)
        CType(Me.GCScan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip.ResumeLayout(False)
        CType(Me.GVScan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.LEViewUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GCScan As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVScan As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumnId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnNumberScan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnCreatedScan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnPreparedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnLastUpdate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnUpdatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnComp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnqty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnIsSelect As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridColumnIdReportStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnRemark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BtnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnList As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents BtnExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnImport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
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
    Friend WithEvents GridColumnRmk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BtnRefCom As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnPrintCom As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnCreateCom As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnRemarkRef As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LEViewUser As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ContextMenuStrip As ContextMenuStrip
    Friend WithEvents ToolStripCancel As ToolStripMenuItem
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
End Class
