<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormVerStockTakeList
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormVerStockTakeList))
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.BtnPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.XTCStockTake = New DevExpress.XtraTab.XtraTabControl()
        Me.XTPScan = New DevExpress.XtraTab.XtraTabPage()
        Me.GCScan = New DevExpress.XtraGrid.GridControl()
        Me.GVScan = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumnNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnSize = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnNoStock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridColumnNoMaster = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnIdPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnIdProduct = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnIsUniqueCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnIdTransDet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnOK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnReject = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnproductStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnIniqueNotFound = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnNoTag = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnPrcType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnRemark = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnRefNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnNotMatch = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnRefNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnRef = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XTPSummary = New DevExpress.XtraTab.XtraTabPage()
        Me.GCSummaryScan = New DevExpress.XtraGrid.GridControl()
        Me.GVSummaryScan = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumnNoSmr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnIdProductSmr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnProductCodeSmr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumnScannedCodeSMR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnNameSMR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnSizeSMR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnQtySMR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnpriceSMR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnAmountSMR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnNumberSmr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnRemarkSmr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XTPCondition = New DevExpress.XtraTab.XtraTabPage()
        Me.GCCat = New DevExpress.XtraGrid.GridControl()
        Me.GVCat = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.XTPCompare = New DevExpress.XtraTab.XtraTabPage()
        Me.GCCS = New DevExpress.XtraGrid.GridControl()
        Me.GVCS = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.BandedGridColumnCSNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumnBarcodePre = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumnNamePre = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumnSizePre = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumnQtyPre = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumnPricePre = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumnAmountPre = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumnBarcodeVer = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumnNameVer = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumnPriceVer = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumnQtyVer = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumnSizeVer = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumnAmountVer = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumnQtyDiff = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumnAmountDiff = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumnNoteCS = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumnst_trans_number = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumnremark = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBandInfoNo = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.GridBandPre = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gridBandStockTake = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gridBanddiff = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.XTCStockTake, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTCStockTake.SuspendLayout()
        Me.XTPScan.SuspendLayout()
        CType(Me.GCScan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVScan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTPSummary.SuspendLayout()
        CType(Me.GCSummaryScan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVSummaryScan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTPCondition.SuspendLayout()
        CType(Me.GCCat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVCat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTPCompare.SuspendLayout()
        CType(Me.GCCS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVCS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl2
        '
        Me.GroupControl2.CaptionLocation = DevExpress.Utils.Locations.Left
        Me.GroupControl2.Controls.Add(Me.BtnPrint)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl2.Location = New System.Drawing.Point(0, 499)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1106, 45)
        Me.GroupControl2.TabIndex = 3
        '
        'BtnPrint
        '
        Me.BtnPrint.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.Location = New System.Drawing.Point(1000, 2)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(104, 41)
        Me.BtnPrint.TabIndex = 1
        Me.BtnPrint.Text = "Print (F4)"
        '
        'XTCStockTake
        '
        Me.XTCStockTake.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XTCStockTake.Location = New System.Drawing.Point(0, 0)
        Me.XTCStockTake.Name = "XTCStockTake"
        Me.XTCStockTake.SelectedTabPage = Me.XTPScan
        Me.XTCStockTake.Size = New System.Drawing.Size(1106, 499)
        Me.XTCStockTake.TabIndex = 4
        Me.XTCStockTake.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XTPScan, Me.XTPSummary, Me.XTPCondition, Me.XTPCompare})
        '
        'XTPScan
        '
        Me.XTPScan.Controls.Add(Me.GCScan)
        Me.XTPScan.Name = "XTPScan"
        Me.XTPScan.Size = New System.Drawing.Size(1100, 471)
        Me.XTPScan.Text = "Scan Result"
        '
        'GCScan
        '
        Me.GCScan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCScan.Location = New System.Drawing.Point(0, 0)
        Me.GCScan.MainView = Me.GVScan
        Me.GCScan.Name = "GCScan"
        Me.GCScan.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.GCScan.Size = New System.Drawing.Size(1100, 471)
        Me.GCScan.TabIndex = 1
        Me.GCScan.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVScan})
        '
        'GVScan
        '
        Me.GVScan.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumnNo, Me.GridColumnCode, Me.GridColumnDescription, Me.GridColumnSize, Me.GridColumnQty, Me.GridColumnPrice, Me.GridColumnAmount, Me.GridColumnNoStock, Me.GridColumnNoMaster, Me.GridColumnSale, Me.GridColumnIdPrice, Me.GridColumnIdProduct, Me.GridColumnIsUniqueCode, Me.GridColumnIdTransDet, Me.GridColumnOK, Me.GridColumnReject, Me.GridColumnproductStatus, Me.GridColumnIniqueNotFound, Me.GridColumnNoTag, Me.GridColumnPrcType, Me.GridColumnRemark, Me.GridColumnRefNumber, Me.GridColumnNotMatch, Me.GridColumnRefNo, Me.GridColumnRef})
        Me.GVScan.GridControl = Me.GCScan
        Me.GVScan.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qty", Me.GridColumnQty, "{0:N0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "amount", Me.GridColumnAmount, "{0:n0}")})
        Me.GVScan.Name = "GVScan"
        Me.GVScan.OptionsBehavior.AutoExpandAllGroups = True
        Me.GVScan.OptionsBehavior.Editable = False
        Me.GVScan.OptionsView.ShowFooter = True
        Me.GVScan.OptionsView.ShowGroupedColumns = True
        Me.GVScan.OptionsView.ShowGroupPanel = False
        '
        'GridColumnNo
        '
        Me.GridColumnNo.Caption = "No"
        Me.GridColumnNo.FieldName = "no"
        Me.GridColumnNo.Name = "GridColumnNo"
        Me.GridColumnNo.OptionsColumn.AllowEdit = False
        Me.GridColumnNo.Visible = True
        Me.GridColumnNo.VisibleIndex = 0
        Me.GridColumnNo.Width = 44
        '
        'GridColumnCode
        '
        Me.GridColumnCode.Caption = "Scanned Code"
        Me.GridColumnCode.FieldName = "code"
        Me.GridColumnCode.Name = "GridColumnCode"
        Me.GridColumnCode.OptionsColumn.AllowEdit = False
        Me.GridColumnCode.Visible = True
        Me.GridColumnCode.VisibleIndex = 5
        Me.GridColumnCode.Width = 170
        '
        'GridColumnDescription
        '
        Me.GridColumnDescription.Caption = "Description"
        Me.GridColumnDescription.FieldName = "name"
        Me.GridColumnDescription.Name = "GridColumnDescription"
        Me.GridColumnDescription.OptionsColumn.AllowEdit = False
        Me.GridColumnDescription.Visible = True
        Me.GridColumnDescription.VisibleIndex = 6
        Me.GridColumnDescription.Width = 338
        '
        'GridColumnSize
        '
        Me.GridColumnSize.Caption = "Size"
        Me.GridColumnSize.FieldName = "size"
        Me.GridColumnSize.Name = "GridColumnSize"
        Me.GridColumnSize.OptionsColumn.AllowEdit = False
        Me.GridColumnSize.Visible = True
        Me.GridColumnSize.VisibleIndex = 7
        Me.GridColumnSize.Width = 70
        '
        'GridColumnQty
        '
        Me.GridColumnQty.Caption = "Qty"
        Me.GridColumnQty.DisplayFormat.FormatString = "N0"
        Me.GridColumnQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumnQty.FieldName = "qty"
        Me.GridColumnQty.Name = "GridColumnQty"
        Me.GridColumnQty.OptionsColumn.AllowEdit = False
        Me.GridColumnQty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qty", "{0:N0}")})
        Me.GridColumnQty.Visible = True
        Me.GridColumnQty.VisibleIndex = 10
        Me.GridColumnQty.Width = 69
        '
        'GridColumnPrice
        '
        Me.GridColumnPrice.Caption = "Price"
        Me.GridColumnPrice.DisplayFormat.FormatString = "N0"
        Me.GridColumnPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumnPrice.FieldName = "design_price"
        Me.GridColumnPrice.Name = "GridColumnPrice"
        Me.GridColumnPrice.Visible = True
        Me.GridColumnPrice.VisibleIndex = 11
        Me.GridColumnPrice.Width = 149
        '
        'GridColumnAmount
        '
        Me.GridColumnAmount.Caption = "Amount"
        Me.GridColumnAmount.DisplayFormat.FormatString = "n0"
        Me.GridColumnAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumnAmount.FieldName = "amount"
        Me.GridColumnAmount.Name = "GridColumnAmount"
        Me.GridColumnAmount.OptionsColumn.AllowEdit = False
        Me.GridColumnAmount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "amount", "{0:n0}")})
        Me.GridColumnAmount.UnboundExpression = "[design_price] * [qty]"
        Me.GridColumnAmount.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.GridColumnAmount.Visible = True
        Me.GridColumnAmount.VisibleIndex = 12
        Me.GridColumnAmount.Width = 239
        '
        'GridColumnNoStock
        '
        Me.GridColumnNoStock.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumnNoStock.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumnNoStock.Caption = "No Stock"
        Me.GridColumnNoStock.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GridColumnNoStock.FieldName = "is_no_stock_v"
        Me.GridColumnNoStock.Name = "GridColumnNoStock"
        Me.GridColumnNoStock.OptionsColumn.AllowEdit = False
        Me.GridColumnNoStock.Visible = True
        Me.GridColumnNoStock.VisibleIndex = 15
        Me.GridColumnNoStock.Width = 78
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.ValueChecked = "Yes"
        Me.RepositoryItemCheckEdit1.ValueUnchecked = "No"
        '
        'GridColumnNoMaster
        '
        Me.GridColumnNoMaster.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumnNoMaster.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumnNoMaster.Caption = "No master"
        Me.GridColumnNoMaster.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GridColumnNoMaster.FieldName = "is_no_master_v"
        Me.GridColumnNoMaster.Name = "GridColumnNoMaster"
        Me.GridColumnNoMaster.OptionsColumn.AllowEdit = False
        Me.GridColumnNoMaster.Visible = True
        Me.GridColumnNoMaster.VisibleIndex = 20
        Me.GridColumnNoMaster.Width = 67
        '
        'GridColumnSale
        '
        Me.GridColumnSale.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumnSale.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumnSale.Caption = "Sale"
        Me.GridColumnSale.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GridColumnSale.FieldName = "is_sale_v"
        Me.GridColumnSale.Name = "GridColumnSale"
        Me.GridColumnSale.OptionsColumn.AllowEdit = False
        Me.GridColumnSale.Visible = True
        Me.GridColumnSale.VisibleIndex = 16
        Me.GridColumnSale.Width = 54
        '
        'GridColumnIdPrice
        '
        Me.GridColumnIdPrice.Caption = "Id Price"
        Me.GridColumnIdPrice.FieldName = "id_design_price"
        Me.GridColumnIdPrice.Name = "GridColumnIdPrice"
        Me.GridColumnIdPrice.OptionsColumn.AllowEdit = False
        Me.GridColumnIdPrice.Width = 159
        '
        'GridColumnIdProduct
        '
        Me.GridColumnIdProduct.Caption = "Id Product"
        Me.GridColumnIdProduct.FieldName = "id_product"
        Me.GridColumnIdProduct.Name = "GridColumnIdProduct"
        Me.GridColumnIdProduct.OptionsColumn.AllowEdit = False
        Me.GridColumnIdProduct.Width = 194
        '
        'GridColumnIsUniqueCode
        '
        Me.GridColumnIsUniqueCode.Caption = "Is Old Design"
        Me.GridColumnIsUniqueCode.FieldName = "is_old_design"
        Me.GridColumnIsUniqueCode.Name = "GridColumnIsUniqueCode"
        Me.GridColumnIsUniqueCode.OptionsColumn.AllowEdit = False
        '
        'GridColumnIdTransDet
        '
        Me.GridColumnIdTransDet.Caption = "Id Det"
        Me.GridColumnIdTransDet.FieldName = "id_st_trans_det"
        Me.GridColumnIdTransDet.Name = "GridColumnIdTransDet"
        Me.GridColumnIdTransDet.OptionsColumn.AllowEdit = False
        '
        'GridColumnOK
        '
        Me.GridColumnOK.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumnOK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumnOK.Caption = "OK"
        Me.GridColumnOK.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GridColumnOK.FieldName = "is_ok_v"
        Me.GridColumnOK.Name = "GridColumnOK"
        Me.GridColumnOK.Visible = True
        Me.GridColumnOK.VisibleIndex = 13
        Me.GridColumnOK.Width = 63
        '
        'GridColumnReject
        '
        Me.GridColumnReject.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumnReject.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumnReject.Caption = "Reject"
        Me.GridColumnReject.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GridColumnReject.FieldName = "is_reject_v"
        Me.GridColumnReject.Name = "GridColumnReject"
        Me.GridColumnReject.Visible = True
        Me.GridColumnReject.VisibleIndex = 17
        Me.GridColumnReject.Width = 62
        '
        'GridColumnproductStatus
        '
        Me.GridColumnproductStatus.Caption = "Product Status"
        Me.GridColumnproductStatus.FieldName = "design_cat"
        Me.GridColumnproductStatus.Name = "GridColumnproductStatus"
        Me.GridColumnproductStatus.Visible = True
        Me.GridColumnproductStatus.VisibleIndex = 9
        Me.GridColumnproductStatus.Width = 90
        '
        'GridColumnIniqueNotFound
        '
        Me.GridColumnIniqueNotFound.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumnIniqueNotFound.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumnIniqueNotFound.Caption = "Unique Not Found"
        Me.GridColumnIniqueNotFound.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GridColumnIniqueNotFound.FieldName = "is_unique_not_found_v"
        Me.GridColumnIniqueNotFound.Name = "GridColumnIniqueNotFound"
        Me.GridColumnIniqueNotFound.Visible = True
        Me.GridColumnIniqueNotFound.VisibleIndex = 19
        Me.GridColumnIniqueNotFound.Width = 122
        '
        'GridColumnNoTag
        '
        Me.GridColumnNoTag.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumnNoTag.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumnNoTag.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumnNoTag.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumnNoTag.Caption = "No Tag"
        Me.GridColumnNoTag.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GridColumnNoTag.FieldName = "is_no_tag_v"
        Me.GridColumnNoTag.Name = "GridColumnNoTag"
        Me.GridColumnNoTag.Visible = True
        Me.GridColumnNoTag.VisibleIndex = 18
        Me.GridColumnNoTag.Width = 74
        '
        'GridColumnPrcType
        '
        Me.GridColumnPrcType.Caption = "Price Type"
        Me.GridColumnPrcType.FieldName = "design_price_type"
        Me.GridColumnPrcType.Name = "GridColumnPrcType"
        Me.GridColumnPrcType.Visible = True
        Me.GridColumnPrcType.VisibleIndex = 8
        Me.GridColumnPrcType.Width = 76
        '
        'GridColumnRemark
        '
        Me.GridColumnRemark.Caption = "Remark"
        Me.GridColumnRemark.FieldName = "remark"
        Me.GridColumnRemark.Name = "GridColumnRemark"
        Me.GridColumnRemark.OptionsColumn.AllowEdit = False
        Me.GridColumnRemark.Visible = True
        Me.GridColumnRemark.VisibleIndex = 2
        Me.GridColumnRemark.Width = 93
        '
        'GridColumnRefNumber
        '
        Me.GridColumnRefNumber.Caption = "Number"
        Me.GridColumnRefNumber.FieldName = "st_trans_ver_number"
        Me.GridColumnRefNumber.Name = "GridColumnRefNumber"
        Me.GridColumnRefNumber.Visible = True
        Me.GridColumnRefNumber.VisibleIndex = 1
        Me.GridColumnRefNumber.Width = 82
        '
        'GridColumnNotMatch
        '
        Me.GridColumnNotMatch.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumnNotMatch.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumnNotMatch.Caption = "Not Match"
        Me.GridColumnNotMatch.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GridColumnNotMatch.FieldName = "is_not_match_v"
        Me.GridColumnNotMatch.Name = "GridColumnNotMatch"
        Me.GridColumnNotMatch.Visible = True
        Me.GridColumnNotMatch.VisibleIndex = 14
        '
        'GridColumnRefNo
        '
        Me.GridColumnRefNo.Caption = "Ref. No"
        Me.GridColumnRefNo.FieldName = "st_trans_number"
        Me.GridColumnRefNo.Name = "GridColumnRefNo"
        Me.GridColumnRefNo.Visible = True
        Me.GridColumnRefNo.VisibleIndex = 3
        '
        'GridColumnRef
        '
        Me.GridColumnRef.Caption = "Ref."
        Me.GridColumnRef.FieldName = "remark_ref"
        Me.GridColumnRef.Name = "GridColumnRef"
        Me.GridColumnRef.Visible = True
        Me.GridColumnRef.VisibleIndex = 4
        '
        'XTPSummary
        '
        Me.XTPSummary.Controls.Add(Me.GCSummaryScan)
        Me.XTPSummary.Name = "XTPSummary"
        Me.XTPSummary.Size = New System.Drawing.Size(1100, 471)
        Me.XTPSummary.Text = "Summary By Product"
        '
        'GCSummaryScan
        '
        Me.GCSummaryScan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCSummaryScan.Location = New System.Drawing.Point(0, 0)
        Me.GCSummaryScan.MainView = Me.GVSummaryScan
        Me.GCSummaryScan.Name = "GCSummaryScan"
        Me.GCSummaryScan.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.GCSummaryScan.Size = New System.Drawing.Size(1100, 471)
        Me.GCSummaryScan.TabIndex = 1
        Me.GCSummaryScan.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVSummaryScan})
        '
        'GVSummaryScan
        '
        Me.GVSummaryScan.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumnNoSmr, Me.GridColumnIdProductSmr, Me.GridColumnProductCodeSmr, Me.GridColumnScannedCodeSMR, Me.GridColumnNameSMR, Me.GridColumnSizeSMR, Me.GridColumnQtySMR, Me.GridColumnpriceSMR, Me.GridColumnAmountSMR, Me.GridColumnNumberSmr, Me.GridColumnRemarkSmr, Me.GridColumnType})
        Me.GVSummaryScan.GridControl = Me.GCSummaryScan
        Me.GVSummaryScan.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qty", Me.GridColumnQtySMR, "{0:N0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "amount", Me.GridColumnAmountSMR, "{0:N0}")})
        Me.GVSummaryScan.Name = "GVSummaryScan"
        Me.GVSummaryScan.OptionsBehavior.AutoExpandAllGroups = True
        Me.GVSummaryScan.OptionsBehavior.Editable = False
        Me.GVSummaryScan.OptionsView.ShowFooter = True
        Me.GVSummaryScan.OptionsView.ShowGroupedColumns = True
        Me.GVSummaryScan.OptionsView.ShowGroupPanel = False
        '
        'GridColumnNoSmr
        '
        Me.GridColumnNoSmr.Caption = "No"
        Me.GridColumnNoSmr.FieldName = "no"
        Me.GridColumnNoSmr.Name = "GridColumnNoSmr"
        Me.GridColumnNoSmr.Visible = True
        Me.GridColumnNoSmr.VisibleIndex = 0
        Me.GridColumnNoSmr.Width = 44
        '
        'GridColumnIdProductSmr
        '
        Me.GridColumnIdProductSmr.Caption = "Id Product"
        Me.GridColumnIdProductSmr.FieldName = "id_product"
        Me.GridColumnIdProductSmr.Name = "GridColumnIdProductSmr"
        '
        'GridColumnProductCodeSmr
        '
        Me.GridColumnProductCodeSmr.Caption = "Code"
        Me.GridColumnProductCodeSmr.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumnProductCodeSmr.FieldName = "product_code"
        Me.GridColumnProductCodeSmr.Name = "GridColumnProductCodeSmr"
        Me.GridColumnProductCodeSmr.Visible = True
        Me.GridColumnProductCodeSmr.VisibleIndex = 3
        Me.GridColumnProductCodeSmr.Width = 210
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.RepositoryItemTextEdit1.NullText = "-"
        '
        'GridColumnScannedCodeSMR
        '
        Me.GridColumnScannedCodeSMR.Caption = "Barcode"
        Me.GridColumnScannedCodeSMR.FieldName = "barcode"
        Me.GridColumnScannedCodeSMR.Name = "GridColumnScannedCodeSMR"
        Me.GridColumnScannedCodeSMR.Visible = True
        Me.GridColumnScannedCodeSMR.VisibleIndex = 4
        Me.GridColumnScannedCodeSMR.Width = 206
        '
        'GridColumnNameSMR
        '
        Me.GridColumnNameSMR.Caption = "Description"
        Me.GridColumnNameSMR.FieldName = "name"
        Me.GridColumnNameSMR.Name = "GridColumnNameSMR"
        Me.GridColumnNameSMR.Visible = True
        Me.GridColumnNameSMR.VisibleIndex = 5
        Me.GridColumnNameSMR.Width = 394
        '
        'GridColumnSizeSMR
        '
        Me.GridColumnSizeSMR.Caption = "Size"
        Me.GridColumnSizeSMR.FieldName = "size"
        Me.GridColumnSizeSMR.Name = "GridColumnSizeSMR"
        Me.GridColumnSizeSMR.Visible = True
        Me.GridColumnSizeSMR.VisibleIndex = 6
        Me.GridColumnSizeSMR.Width = 47
        '
        'GridColumnQtySMR
        '
        Me.GridColumnQtySMR.Caption = "Qty"
        Me.GridColumnQtySMR.DisplayFormat.FormatString = "N0"
        Me.GridColumnQtySMR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumnQtySMR.FieldName = "qty"
        Me.GridColumnQtySMR.Name = "GridColumnQtySMR"
        Me.GridColumnQtySMR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qty", "{0:N0}")})
        Me.GridColumnQtySMR.Visible = True
        Me.GridColumnQtySMR.VisibleIndex = 8
        Me.GridColumnQtySMR.Width = 76
        '
        'GridColumnpriceSMR
        '
        Me.GridColumnpriceSMR.Caption = "Price"
        Me.GridColumnpriceSMR.DisplayFormat.FormatString = "N0"
        Me.GridColumnpriceSMR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumnpriceSMR.FieldName = "design_price"
        Me.GridColumnpriceSMR.Name = "GridColumnpriceSMR"
        Me.GridColumnpriceSMR.Visible = True
        Me.GridColumnpriceSMR.VisibleIndex = 9
        Me.GridColumnpriceSMR.Width = 102
        '
        'GridColumnAmountSMR
        '
        Me.GridColumnAmountSMR.Caption = "Amount"
        Me.GridColumnAmountSMR.DisplayFormat.FormatString = "N0"
        Me.GridColumnAmountSMR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumnAmountSMR.FieldName = "amount"
        Me.GridColumnAmountSMR.Name = "GridColumnAmountSMR"
        Me.GridColumnAmountSMR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "amount", "{0:N0}")})
        Me.GridColumnAmountSMR.UnboundExpression = "[qty] * [design_price]"
        Me.GridColumnAmountSMR.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.GridColumnAmountSMR.Visible = True
        Me.GridColumnAmountSMR.VisibleIndex = 10
        Me.GridColumnAmountSMR.Width = 390
        '
        'GridColumnNumberSmr
        '
        Me.GridColumnNumberSmr.Caption = "Number"
        Me.GridColumnNumberSmr.FieldName = "st_trans_ver_number"
        Me.GridColumnNumberSmr.Name = "GridColumnNumberSmr"
        Me.GridColumnNumberSmr.Visible = True
        Me.GridColumnNumberSmr.VisibleIndex = 1
        Me.GridColumnNumberSmr.Width = 96
        '
        'GridColumnRemarkSmr
        '
        Me.GridColumnRemarkSmr.Caption = "Remark"
        Me.GridColumnRemarkSmr.FieldName = "remark"
        Me.GridColumnRemarkSmr.Name = "GridColumnRemarkSmr"
        Me.GridColumnRemarkSmr.Visible = True
        Me.GridColumnRemarkSmr.VisibleIndex = 2
        Me.GridColumnRemarkSmr.Width = 67
        '
        'GridColumnType
        '
        Me.GridColumnType.Caption = "Type"
        Me.GridColumnType.FieldName = "price_type"
        Me.GridColumnType.Name = "GridColumnType"
        Me.GridColumnType.Visible = True
        Me.GridColumnType.VisibleIndex = 7
        '
        'XTPCondition
        '
        Me.XTPCondition.Controls.Add(Me.GCCat)
        Me.XTPCondition.Name = "XTPCondition"
        Me.XTPCondition.Size = New System.Drawing.Size(1100, 471)
        Me.XTPCondition.Text = "Summary By Category"
        '
        'GCCat
        '
        Me.GCCat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCCat.Location = New System.Drawing.Point(0, 0)
        Me.GCCat.MainView = Me.GVCat
        Me.GCCat.Name = "GCCat"
        Me.GCCat.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3})
        Me.GCCat.Size = New System.Drawing.Size(1100, 471)
        Me.GCCat.TabIndex = 2
        Me.GCCat.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVCat})
        '
        'GVCat
        '
        Me.GVCat.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3})
        Me.GVCat.GridControl = Me.GCCat
        Me.GVCat.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qty", Nothing, "{0:N0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "amount", Nothing, "{0:N2}")})
        Me.GVCat.Name = "GVCat"
        Me.GVCat.OptionsBehavior.AutoExpandAllGroups = True
        Me.GVCat.OptionsBehavior.Editable = False
        Me.GVCat.OptionsView.ShowFooter = True
        Me.GVCat.OptionsView.ShowGroupedColumns = True
        Me.GVCat.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "No"
        Me.GridColumn1.FieldName = "no"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 83
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Category"
        Me.GridColumn2.FieldName = "cat"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 768
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Qty"
        Me.GridColumn3.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.GridColumn3.FieldName = "cat_val"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 765
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        Me.RepositoryItemTextEdit3.NullText = "-"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        Me.RepositoryItemTextEdit2.NullText = "-"
        '
        'XTPCompare
        '
        Me.XTPCompare.Controls.Add(Me.GCCS)
        Me.XTPCompare.Name = "XTPCompare"
        Me.XTPCompare.Size = New System.Drawing.Size(1100, 471)
        Me.XTPCompare.Text = "Compare Pre-Stock Take"
        '
        'GCCS
        '
        Me.GCCS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCCS.Location = New System.Drawing.Point(0, 0)
        Me.GCCS.MainView = Me.GVCS
        Me.GCCS.Name = "GCCS"
        Me.GCCS.Size = New System.Drawing.Size(1100, 471)
        Me.GCCS.TabIndex = 1
        Me.GCCS.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVCS})
        '
        'GVCS
        '
        Me.GVCS.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBandInfoNo, Me.GridBandPre, Me.gridBandStockTake, Me.gridBanddiff})
        Me.GVCS.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.BandedGridColumnBarcodePre, Me.BandedGridColumnNamePre, Me.BandedGridColumnSizePre, Me.BandedGridColumnPricePre, Me.BandedGridColumnQtyPre, Me.BandedGridColumnAmountPre, Me.BandedGridColumnBarcodeVer, Me.BandedGridColumnNameVer, Me.BandedGridColumnSizeVer, Me.BandedGridColumnPriceVer, Me.BandedGridColumnQtyVer, Me.BandedGridColumnAmountVer, Me.BandedGridColumnQtyDiff, Me.BandedGridColumnAmountDiff, Me.BandedGridColumnCSNo, Me.BandedGridColumnNoteCS, Me.BandedGridColumnst_trans_number, Me.BandedGridColumnremark})
        Me.GVCS.GridControl = Me.GCCS
        Me.GVCS.GroupCount = 1
        Me.GVCS.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qty_pre", Me.BandedGridColumnQtyPre, "{0:N0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "amount_pre", Me.BandedGridColumnAmountPre, "{0:N0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qty_ver", Me.BandedGridColumnQtyVer, "{0:N0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "amount_ver", Me.BandedGridColumnAmountVer, "{0:N0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qty_diff", Me.BandedGridColumnQtyDiff, "{0:N0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "amount_diff", Me.BandedGridColumnAmountDiff, "{0:N0}")})
        Me.GVCS.Name = "GVCS"
        Me.GVCS.OptionsBehavior.AutoExpandAllGroups = True
        Me.GVCS.OptionsBehavior.Editable = False
        Me.GVCS.OptionsFind.AlwaysVisible = True
        Me.GVCS.OptionsView.ColumnAutoWidth = False
        Me.GVCS.OptionsView.ShowFooter = True
        Me.GVCS.OptionsView.ShowGroupPanel = False
        Me.GVCS.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.BandedGridColumnst_trans_number, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'BandedGridColumnCSNo
        '
        Me.BandedGridColumnCSNo.Caption = "No"
        Me.BandedGridColumnCSNo.FieldName = "no"
        Me.BandedGridColumnCSNo.Name = "BandedGridColumnCSNo"
        Me.BandedGridColumnCSNo.Visible = True
        Me.BandedGridColumnCSNo.Width = 41
        '
        'BandedGridColumnBarcodePre
        '
        Me.BandedGridColumnBarcodePre.Caption = "Barcode"
        Me.BandedGridColumnBarcodePre.FieldName = "barcode_pre"
        Me.BandedGridColumnBarcodePre.Name = "BandedGridColumnBarcodePre"
        Me.BandedGridColumnBarcodePre.Visible = True
        '
        'BandedGridColumnNamePre
        '
        Me.BandedGridColumnNamePre.Caption = "Description"
        Me.BandedGridColumnNamePre.FieldName = "name_pre"
        Me.BandedGridColumnNamePre.Name = "BandedGridColumnNamePre"
        Me.BandedGridColumnNamePre.Visible = True
        Me.BandedGridColumnNamePre.Width = 90
        '
        'BandedGridColumnSizePre
        '
        Me.BandedGridColumnSizePre.Caption = "Size"
        Me.BandedGridColumnSizePre.FieldName = "size_pre"
        Me.BandedGridColumnSizePre.Name = "BandedGridColumnSizePre"
        Me.BandedGridColumnSizePre.Visible = True
        '
        'BandedGridColumnQtyPre
        '
        Me.BandedGridColumnQtyPre.Caption = "Qty"
        Me.BandedGridColumnQtyPre.DisplayFormat.FormatString = "N0"
        Me.BandedGridColumnQtyPre.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumnQtyPre.FieldName = "qty_pre"
        Me.BandedGridColumnQtyPre.Name = "BandedGridColumnQtyPre"
        Me.BandedGridColumnQtyPre.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qty_pre", "{0:N0}")})
        Me.BandedGridColumnQtyPre.Visible = True
        '
        'BandedGridColumnPricePre
        '
        Me.BandedGridColumnPricePre.Caption = "Price"
        Me.BandedGridColumnPricePre.DisplayFormat.FormatString = "N0"
        Me.BandedGridColumnPricePre.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumnPricePre.FieldName = "price_pre"
        Me.BandedGridColumnPricePre.Name = "BandedGridColumnPricePre"
        Me.BandedGridColumnPricePre.Visible = True
        '
        'BandedGridColumnAmountPre
        '
        Me.BandedGridColumnAmountPre.Caption = "Amount"
        Me.BandedGridColumnAmountPre.DisplayFormat.FormatString = "N0"
        Me.BandedGridColumnAmountPre.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumnAmountPre.FieldName = "amount_pre"
        Me.BandedGridColumnAmountPre.Name = "BandedGridColumnAmountPre"
        Me.BandedGridColumnAmountPre.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "amount_pre", "{0:N0}")})
        Me.BandedGridColumnAmountPre.UnboundExpression = "[qty_pre] * [price_pre]"
        Me.BandedGridColumnAmountPre.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.BandedGridColumnAmountPre.Visible = True
        '
        'BandedGridColumnBarcodeVer
        '
        Me.BandedGridColumnBarcodeVer.Caption = "Barcode"
        Me.BandedGridColumnBarcodeVer.FieldName = "barcode_ver"
        Me.BandedGridColumnBarcodeVer.Name = "BandedGridColumnBarcodeVer"
        Me.BandedGridColumnBarcodeVer.Visible = True
        '
        'BandedGridColumnNameVer
        '
        Me.BandedGridColumnNameVer.Caption = "Description"
        Me.BandedGridColumnNameVer.FieldName = "name_ver"
        Me.BandedGridColumnNameVer.Name = "BandedGridColumnNameVer"
        Me.BandedGridColumnNameVer.Visible = True
        '
        'BandedGridColumnPriceVer
        '
        Me.BandedGridColumnPriceVer.Caption = "Price"
        Me.BandedGridColumnPriceVer.DisplayFormat.FormatString = "N0"
        Me.BandedGridColumnPriceVer.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumnPriceVer.FieldName = "price_ver"
        Me.BandedGridColumnPriceVer.Name = "BandedGridColumnPriceVer"
        Me.BandedGridColumnPriceVer.Visible = True
        '
        'BandedGridColumnQtyVer
        '
        Me.BandedGridColumnQtyVer.Caption = "Qty"
        Me.BandedGridColumnQtyVer.DisplayFormat.FormatString = "N0"
        Me.BandedGridColumnQtyVer.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumnQtyVer.FieldName = "qty_ver"
        Me.BandedGridColumnQtyVer.Name = "BandedGridColumnQtyVer"
        Me.BandedGridColumnQtyVer.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qty_ver", "{0:N0}")})
        Me.BandedGridColumnQtyVer.Visible = True
        '
        'BandedGridColumnSizeVer
        '
        Me.BandedGridColumnSizeVer.Caption = "Size"
        Me.BandedGridColumnSizeVer.FieldName = "size_ver"
        Me.BandedGridColumnSizeVer.Name = "BandedGridColumnSizeVer"
        Me.BandedGridColumnSizeVer.Visible = True
        '
        'BandedGridColumnAmountVer
        '
        Me.BandedGridColumnAmountVer.Caption = "Amount"
        Me.BandedGridColumnAmountVer.DisplayFormat.FormatString = "N0"
        Me.BandedGridColumnAmountVer.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumnAmountVer.FieldName = "amount_ver"
        Me.BandedGridColumnAmountVer.Name = "BandedGridColumnAmountVer"
        Me.BandedGridColumnAmountVer.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "amount_ver", "{0:N0}")})
        Me.BandedGridColumnAmountVer.UnboundExpression = "[qty_ver] * [price_ver]"
        Me.BandedGridColumnAmountVer.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.BandedGridColumnAmountVer.Visible = True
        '
        'BandedGridColumnQtyDiff
        '
        Me.BandedGridColumnQtyDiff.Caption = "Qty"
        Me.BandedGridColumnQtyDiff.DisplayFormat.FormatString = "N0"
        Me.BandedGridColumnQtyDiff.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumnQtyDiff.FieldName = "qty_diff"
        Me.BandedGridColumnQtyDiff.Name = "BandedGridColumnQtyDiff"
        Me.BandedGridColumnQtyDiff.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qty_diff", "{0:N0}")})
        Me.BandedGridColumnQtyDiff.UnboundExpression = "[qty_ver]-[qty_pre]"
        Me.BandedGridColumnQtyDiff.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.BandedGridColumnQtyDiff.Visible = True
        '
        'BandedGridColumnAmountDiff
        '
        Me.BandedGridColumnAmountDiff.Caption = "Amount"
        Me.BandedGridColumnAmountDiff.DisplayFormat.FormatString = "N0"
        Me.BandedGridColumnAmountDiff.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumnAmountDiff.FieldName = "amount_diff"
        Me.BandedGridColumnAmountDiff.Name = "BandedGridColumnAmountDiff"
        Me.BandedGridColumnAmountDiff.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "amount_diff", "{0:N0}")})
        Me.BandedGridColumnAmountDiff.UnboundExpression = "[amount_ver]-[amount_pre]"
        Me.BandedGridColumnAmountDiff.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.BandedGridColumnAmountDiff.Visible = True
        '
        'BandedGridColumnNoteCS
        '
        Me.BandedGridColumnNoteCS.Caption = "Note"
        Me.BandedGridColumnNoteCS.FieldName = "note"
        Me.BandedGridColumnNoteCS.Name = "BandedGridColumnNoteCS"
        Me.BandedGridColumnNoteCS.UnboundExpression = "Iif([qty_diff]=0,'',Iif([qty_diff]>0,'Over','Selisih'))"
        Me.BandedGridColumnNoteCS.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.BandedGridColumnNoteCS.Visible = True
        '
        'BandedGridColumnst_trans_number
        '
        Me.BandedGridColumnst_trans_number.Caption = "Number"
        Me.BandedGridColumnst_trans_number.FieldName = "st_trans_number"
        Me.BandedGridColumnst_trans_number.Name = "BandedGridColumnst_trans_number"
        Me.BandedGridColumnst_trans_number.Visible = True
        '
        'BandedGridColumnremark
        '
        Me.BandedGridColumnremark.Caption = "Remark"
        Me.BandedGridColumnremark.FieldName = "remark"
        Me.BandedGridColumnremark.Name = "BandedGridColumnremark"
        Me.BandedGridColumnremark.Visible = True
        '
        'gridBandInfoNo
        '
        Me.gridBandInfoNo.Columns.Add(Me.BandedGridColumnCSNo)
        Me.gridBandInfoNo.Name = "gridBandInfoNo"
        Me.gridBandInfoNo.VisibleIndex = 0
        Me.gridBandInfoNo.Width = 41
        '
        'GridBandPre
        '
        Me.GridBandPre.Caption = "PRE STOCKTAKE"
        Me.GridBandPre.Columns.Add(Me.BandedGridColumnst_trans_number)
        Me.GridBandPre.Columns.Add(Me.BandedGridColumnremark)
        Me.GridBandPre.Columns.Add(Me.BandedGridColumnBarcodePre)
        Me.GridBandPre.Columns.Add(Me.BandedGridColumnNamePre)
        Me.GridBandPre.Columns.Add(Me.BandedGridColumnSizePre)
        Me.GridBandPre.Columns.Add(Me.BandedGridColumnQtyPre)
        Me.GridBandPre.Columns.Add(Me.BandedGridColumnPricePre)
        Me.GridBandPre.Columns.Add(Me.BandedGridColumnAmountPre)
        Me.GridBandPre.Name = "GridBandPre"
        Me.GridBandPre.VisibleIndex = 1
        Me.GridBandPre.Width = 615
        '
        'gridBandStockTake
        '
        Me.gridBandStockTake.Caption = "STOCKTAKE"
        Me.gridBandStockTake.Columns.Add(Me.BandedGridColumnBarcodeVer)
        Me.gridBandStockTake.Columns.Add(Me.BandedGridColumnNameVer)
        Me.gridBandStockTake.Columns.Add(Me.BandedGridColumnPriceVer)
        Me.gridBandStockTake.Columns.Add(Me.BandedGridColumnQtyVer)
        Me.gridBandStockTake.Columns.Add(Me.BandedGridColumnSizeVer)
        Me.gridBandStockTake.Columns.Add(Me.BandedGridColumnAmountVer)
        Me.gridBandStockTake.Name = "gridBandStockTake"
        Me.gridBandStockTake.VisibleIndex = 2
        Me.gridBandStockTake.Width = 450
        '
        'gridBanddiff
        '
        Me.gridBanddiff.Caption = "DIFF"
        Me.gridBanddiff.Columns.Add(Me.BandedGridColumnQtyDiff)
        Me.gridBanddiff.Columns.Add(Me.BandedGridColumnAmountDiff)
        Me.gridBanddiff.Columns.Add(Me.BandedGridColumnNoteCS)
        Me.gridBanddiff.Name = "gridBanddiff"
        Me.gridBanddiff.VisibleIndex = 3
        Me.gridBanddiff.Width = 225
        '
        'FormVerStockTakeList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1106, 544)
        Me.Controls.Add(Me.XTCStockTake)
        Me.Controls.Add(Me.GroupControl2)
        Me.MinimizeBox = False
        Me.Name = "FormVerStockTakeList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List"
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.XTCStockTake, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTCStockTake.ResumeLayout(False)
        Me.XTPScan.ResumeLayout(False)
        CType(Me.GCScan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVScan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTPSummary.ResumeLayout(False)
        CType(Me.GCSummaryScan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVSummaryScan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTPCondition.ResumeLayout(False)
        CType(Me.GCCat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVCat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTPCompare.ResumeLayout(False)
        CType(Me.GCCS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVCS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BtnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XTCStockTake As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XTPScan As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GCScan As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVScan As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumnNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnSize As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnNoStock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridColumnNoMaster As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnIdPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnIdProduct As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnIsUniqueCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnIdTransDet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnOK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnReject As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnproductStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnIniqueNotFound As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnNoTag As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnPrcType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnRemark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnRefNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XTPSummary As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GCSummaryScan As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVSummaryScan As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumnNoSmr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnIdProductSmr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnProductCodeSmr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumnScannedCodeSMR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnNameSMR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnSizeSMR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnQtySMR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnpriceSMR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnAmountSMR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnNumberSmr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnRemarkSmr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XTPCondition As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GCCat As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVCat As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumnNotMatch As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnRefNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnRef As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XTPCompare As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GCCS As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVCS As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents BandedGridColumnCSNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumnBarcodePre As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumnNamePre As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumnSizePre As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumnQtyPre As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumnPricePre As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumnAmountPre As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumnBarcodeVer As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumnNameVer As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumnPriceVer As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumnQtyVer As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumnSizeVer As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumnAmountVer As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumnQtyDiff As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumnAmountDiff As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumnNoteCS As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBandInfoNo As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBandPre As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents BandedGridColumnst_trans_number As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumnremark As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBandStockTake As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBanddiff As DevExpress.XtraGrid.Views.BandedGrid.GridBand
End Class
