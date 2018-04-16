<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStockTakeList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormStockTakeList))
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
        Me.XTPCondition = New DevExpress.XtraTab.XtraTabPage()
        Me.GCCat = New DevExpress.XtraGrid.GridControl()
        Me.GVCat = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
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
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupControl2.TabIndex = 2
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
        Me.XTCStockTake.TabIndex = 3
        Me.XTCStockTake.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XTPScan, Me.XTPSummary, Me.XTPCondition})
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
        Me.GVScan.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumnNo, Me.GridColumnCode, Me.GridColumnDescription, Me.GridColumnSize, Me.GridColumnQty, Me.GridColumnPrice, Me.GridColumnAmount, Me.GridColumnNoStock, Me.GridColumnNoMaster, Me.GridColumnSale, Me.GridColumnIdPrice, Me.GridColumnIdProduct, Me.GridColumnIsUniqueCode, Me.GridColumnIdTransDet, Me.GridColumnOK, Me.GridColumnReject, Me.GridColumnproductStatus, Me.GridColumnIniqueNotFound, Me.GridColumnNoTag, Me.GridColumnPrcType, Me.GridColumnRemark, Me.GridColumnRefNumber})
        Me.GVScan.GridControl = Me.GCScan
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
        Me.GridColumnCode.VisibleIndex = 3
        Me.GridColumnCode.Width = 170
        '
        'GridColumnDescription
        '
        Me.GridColumnDescription.Caption = "Description"
        Me.GridColumnDescription.FieldName = "name"
        Me.GridColumnDescription.Name = "GridColumnDescription"
        Me.GridColumnDescription.OptionsColumn.AllowEdit = False
        Me.GridColumnDescription.Visible = True
        Me.GridColumnDescription.VisibleIndex = 4
        Me.GridColumnDescription.Width = 338
        '
        'GridColumnSize
        '
        Me.GridColumnSize.Caption = "Size"
        Me.GridColumnSize.FieldName = "size"
        Me.GridColumnSize.Name = "GridColumnSize"
        Me.GridColumnSize.OptionsColumn.AllowEdit = False
        Me.GridColumnSize.Visible = True
        Me.GridColumnSize.VisibleIndex = 5
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
        Me.GridColumnQty.VisibleIndex = 8
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
        Me.GridColumnPrice.VisibleIndex = 9
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
        Me.GridColumnAmount.VisibleIndex = 10
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
        Me.GridColumnNoStock.VisibleIndex = 12
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
        Me.GridColumnNoMaster.VisibleIndex = 17
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
        Me.GridColumnSale.VisibleIndex = 13
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
        Me.GridColumnOK.VisibleIndex = 11
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
        Me.GridColumnReject.VisibleIndex = 14
        Me.GridColumnReject.Width = 62
        '
        'GridColumnproductStatus
        '
        Me.GridColumnproductStatus.Caption = "Product Status"
        Me.GridColumnproductStatus.FieldName = "design_cat"
        Me.GridColumnproductStatus.Name = "GridColumnproductStatus"
        Me.GridColumnproductStatus.Visible = True
        Me.GridColumnproductStatus.VisibleIndex = 7
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
        Me.GridColumnIniqueNotFound.VisibleIndex = 16
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
        Me.GridColumnNoTag.VisibleIndex = 15
        Me.GridColumnNoTag.Width = 74
        '
        'GridColumnPrcType
        '
        Me.GridColumnPrcType.Caption = "Price Type"
        Me.GridColumnPrcType.FieldName = "design_price_type"
        Me.GridColumnPrcType.Name = "GridColumnPrcType"
        Me.GridColumnPrcType.Visible = True
        Me.GridColumnPrcType.VisibleIndex = 6
        Me.GridColumnPrcType.Width = 76
        '
        'GridColumnRemark
        '
        Me.GridColumnRemark.Caption = "Remark"
        Me.GridColumnRemark.FieldName = "remark_ref"
        Me.GridColumnRemark.Name = "GridColumnRemark"
        Me.GridColumnRemark.OptionsColumn.AllowEdit = False
        Me.GridColumnRemark.Visible = True
        Me.GridColumnRemark.VisibleIndex = 2
        Me.GridColumnRemark.Width = 93
        '
        'GridColumnRefNumber
        '
        Me.GridColumnRefNumber.Caption = "Number"
        Me.GridColumnRefNumber.FieldName = "ref_number"
        Me.GridColumnRefNumber.Name = "GridColumnRefNumber"
        Me.GridColumnRefNumber.Visible = True
        Me.GridColumnRefNumber.VisibleIndex = 1
        Me.GridColumnRefNumber.Width = 82
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
        Me.GVSummaryScan.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumnNoSmr, Me.GridColumnIdProductSmr, Me.GridColumnProductCodeSmr, Me.GridColumnScannedCodeSMR, Me.GridColumnNameSMR, Me.GridColumnSizeSMR, Me.GridColumnQtySMR, Me.GridColumnpriceSMR, Me.GridColumnAmountSMR})
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
        Me.GridColumnNoSmr.Width = 61
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
        Me.GridColumnProductCodeSmr.VisibleIndex = 2
        Me.GridColumnProductCodeSmr.Width = 231
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
        Me.GridColumnScannedCodeSMR.VisibleIndex = 1
        Me.GridColumnScannedCodeSMR.Width = 227
        '
        'GridColumnNameSMR
        '
        Me.GridColumnNameSMR.Caption = "Description"
        Me.GridColumnNameSMR.FieldName = "name"
        Me.GridColumnNameSMR.Name = "GridColumnNameSMR"
        Me.GridColumnNameSMR.Visible = True
        Me.GridColumnNameSMR.VisibleIndex = 3
        Me.GridColumnNameSMR.Width = 433
        '
        'GridColumnSizeSMR
        '
        Me.GridColumnSizeSMR.Caption = "Size"
        Me.GridColumnSizeSMR.FieldName = "size"
        Me.GridColumnSizeSMR.Name = "GridColumnSizeSMR"
        Me.GridColumnSizeSMR.Visible = True
        Me.GridColumnSizeSMR.VisibleIndex = 4
        Me.GridColumnSizeSMR.Width = 52
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
        Me.GridColumnQtySMR.VisibleIndex = 5
        Me.GridColumnQtySMR.Width = 85
        '
        'GridColumnpriceSMR
        '
        Me.GridColumnpriceSMR.Caption = "Price"
        Me.GridColumnpriceSMR.DisplayFormat.FormatString = "N0"
        Me.GridColumnpriceSMR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumnpriceSMR.FieldName = "design_price"
        Me.GridColumnpriceSMR.Name = "GridColumnpriceSMR"
        Me.GridColumnpriceSMR.Visible = True
        Me.GridColumnpriceSMR.VisibleIndex = 6
        Me.GridColumnpriceSMR.Width = 113
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
        Me.GridColumnAmountSMR.VisibleIndex = 7
        Me.GridColumnAmountSMR.Width = 414
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
        Me.GCCat.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit2})
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
        Me.GridColumn3.FieldName = "cat_val"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 765
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        Me.RepositoryItemTextEdit2.NullText = "-"
        '
        'FormStockTakeList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1106, 544)
        Me.Controls.Add(Me.XTCStockTake)
        Me.Controls.Add(Me.GroupControl2)
        Me.MinimizeBox = False
        Me.Name = "FormStockTakeList"
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
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents XTPCondition As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GCCat As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVCat As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
