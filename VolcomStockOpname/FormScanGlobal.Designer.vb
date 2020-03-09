<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormScanGlobal
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
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.BtnViewPre = New DevExpress.XtraEditors.SimpleButton()
        Me.XTCGlobal = New DevExpress.XtraTab.XtraTabControl()
        Me.XTPPreStockTake = New DevExpress.XtraTab.XtraTabPage()
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
        Me.XTPStockTake = New DevExpress.XtraTab.XtraTabPage()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.XTCGlobal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTCGlobal.SuspendLayout()
        Me.XTPPreStockTake.SuspendLayout()
        CType(Me.GCScan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVScan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.BtnViewPre)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1112, 49)
        Me.PanelControl1.TabIndex = 0
        '
        'BtnViewPre
        '
        Me.BtnViewPre.Location = New System.Drawing.Point(12, 12)
        Me.BtnViewPre.Name = "BtnViewPre"
        Me.BtnViewPre.Size = New System.Drawing.Size(75, 23)
        Me.BtnViewPre.TabIndex = 0
        Me.BtnViewPre.Text = "View Data"
        '
        'XTCGlobal
        '
        Me.XTCGlobal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XTCGlobal.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom
        Me.XTCGlobal.Location = New System.Drawing.Point(0, 49)
        Me.XTCGlobal.Name = "XTCGlobal"
        Me.XTCGlobal.SelectedTabPage = Me.XTPPreStockTake
        Me.XTCGlobal.Size = New System.Drawing.Size(1112, 450)
        Me.XTCGlobal.TabIndex = 1
        Me.XTCGlobal.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XTPPreStockTake, Me.XTPStockTake})
        '
        'XTPPreStockTake
        '
        Me.XTPPreStockTake.Controls.Add(Me.GCScan)
        Me.XTPPreStockTake.Name = "XTPPreStockTake"
        Me.XTPPreStockTake.Size = New System.Drawing.Size(1106, 422)
        Me.XTPPreStockTake.Text = "Pre Stock Take"
        '
        'GCScan
        '
        Me.GCScan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCScan.Location = New System.Drawing.Point(0, 0)
        Me.GCScan.MainView = Me.GVScan
        Me.GCScan.Name = "GCScan"
        Me.GCScan.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.GCScan.Size = New System.Drawing.Size(1106, 422)
        Me.GCScan.TabIndex = 2
        Me.GCScan.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVScan})
        '
        'GVScan
        '
        Me.GVScan.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumnNo, Me.GridColumnCode, Me.GridColumnDescription, Me.GridColumnSize, Me.GridColumnQty, Me.GridColumnPrice, Me.GridColumnAmount, Me.GridColumnNoStock, Me.GridColumnNoMaster, Me.GridColumnSale, Me.GridColumnIdPrice, Me.GridColumnIdProduct, Me.GridColumnIsUniqueCode, Me.GridColumnIdTransDet, Me.GridColumnOK, Me.GridColumnReject, Me.GridColumnproductStatus, Me.GridColumnIniqueNotFound, Me.GridColumnNoTag, Me.GridColumnPrcType, Me.GridColumnRemark, Me.GridColumnRefNumber})
        Me.GVScan.GridControl = Me.GCScan
        Me.GVScan.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qty", Me.GridColumnQty, "{0:N0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "amount", Me.GridColumnAmount, "{0:n0}")})
        Me.GVScan.Name = "GVScan"
        Me.GVScan.OptionsBehavior.AutoExpandAllGroups = True
        Me.GVScan.OptionsBehavior.Editable = False
        Me.GVScan.OptionsMenu.ShowConditionalFormattingItem = True
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
        Me.GridColumnRefNumber.FieldName = "st_trans_number"
        Me.GridColumnRefNumber.Name = "GridColumnRefNumber"
        Me.GridColumnRefNumber.Visible = True
        Me.GridColumnRefNumber.VisibleIndex = 1
        Me.GridColumnRefNumber.Width = 82
        '
        'XTPStockTake
        '
        Me.XTPStockTake.Name = "XTPStockTake"
        Me.XTPStockTake.Size = New System.Drawing.Size(1106, 422)
        Me.XTPStockTake.Text = "Stock Take"
        '
        'FormScanGlobal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1112, 499)
        Me.Controls.Add(Me.XTCGlobal)
        Me.Controls.Add(Me.PanelControl1)
        Me.MinimizeBox = False
        Me.Name = "FormScanGlobal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Global Scan"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.XTCGlobal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTCGlobal.ResumeLayout(False)
        Me.XTPPreStockTake.ResumeLayout(False)
        CType(Me.GCScan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVScan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents XTCGlobal As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XTPPreStockTake As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XTPStockTake As DevExpress.XtraTab.XtraTabPage
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
    Friend WithEvents BtnViewPre As DevExpress.XtraEditors.SimpleButton
End Class
