<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRptDet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRptDet))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtCreatedBy = New DevExpress.XtraEditors.TextEdit()
        Me.DECreatedDate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.MENote = New DevExpress.XtraEditors.MemoEdit()
        Me.TxtNumber = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.BtnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnSaveChanges = New DevExpress.XtraEditors.SimpleButton()
        Me.XTCReport = New DevExpress.XtraTab.XtraTabControl()
        Me.XTPAccount = New DevExpress.XtraTab.XtraTabPage()
        Me.GCAccount = New DevExpress.XtraGrid.GridControl()
        Me.GVAccount = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumncombine_no = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumndb_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumncomp_number = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumncomp_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnsoh_qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnscan_qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XTPReport = New DevExpress.XtraTab.XtraTabPage()
        Me.GCRpt = New DevExpress.XtraGrid.GridControl()
        Me.BGVRpt = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.BandedGridColumnBarcode = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumnSKU = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumnDescription = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumnSize = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumnTotalSOH = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumnValueSOH = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumnTotalScan = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumnValueScan = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GVRpt = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BandedGridColumnTotalDiff = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumnValueDiff = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBandDescription = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gridBandGlobal = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.TxtCreatedBy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DECreatedDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DECreatedDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MENote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.XTCReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTCReport.SuspendLayout()
        Me.XTPAccount.SuspendLayout()
        CType(Me.GCAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTPReport.SuspendLayout()
        CType(Me.GCRpt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BGVRpt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVRpt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.TxtCreatedBy)
        Me.PanelControl1.Controls.Add(Me.DECreatedDate)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.MENote)
        Me.PanelControl1.Controls.Add(Me.TxtNumber)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(784, 103)
        Me.PanelControl1.TabIndex = 0
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(498, 39)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl4.TabIndex = 7
        Me.LabelControl4.Text = "Created By"
        '
        'TxtCreatedBy
        '
        Me.TxtCreatedBy.Enabled = False
        Me.TxtCreatedBy.Location = New System.Drawing.Point(578, 36)
        Me.TxtCreatedBy.Name = "TxtCreatedBy"
        Me.TxtCreatedBy.Size = New System.Drawing.Size(194, 20)
        Me.TxtCreatedBy.TabIndex = 6
        '
        'DECreatedDate
        '
        Me.DECreatedDate.EditValue = Nothing
        Me.DECreatedDate.Enabled = False
        Me.DECreatedDate.Location = New System.Drawing.Point(578, 11)
        Me.DECreatedDate.Name = "DECreatedDate"
        Me.DECreatedDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DECreatedDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DECreatedDate.Size = New System.Drawing.Size(194, 20)
        Me.DECreatedDate.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(498, 14)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "Created Date"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(19, 39)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Note"
        '
        'MENote
        '
        Me.MENote.Location = New System.Drawing.Point(71, 37)
        Me.MENote.Name = "MENote"
        Me.MENote.Size = New System.Drawing.Size(214, 51)
        Me.MENote.TabIndex = 4
        '
        'TxtNumber
        '
        Me.TxtNumber.Enabled = False
        Me.TxtNumber.Location = New System.Drawing.Point(71, 11)
        Me.TxtNumber.Name = "TxtNumber"
        Me.TxtNumber.Size = New System.Drawing.Size(214, 20)
        Me.TxtNumber.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(19, 14)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Number"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.BtnClose)
        Me.PanelControl2.Controls.Add(Me.BtnSaveChanges)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 513)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(784, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'BtnClose
        '
        Me.BtnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(568, 2)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(92, 44)
        Me.BtnClose.TabIndex = 1
        Me.BtnClose.Text = "Close"
        '
        'BtnSaveChanges
        '
        Me.BtnSaveChanges.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnSaveChanges.Image = CType(resources.GetObject("BtnSaveChanges.Image"), System.Drawing.Image)
        Me.BtnSaveChanges.Location = New System.Drawing.Point(660, 2)
        Me.BtnSaveChanges.Name = "BtnSaveChanges"
        Me.BtnSaveChanges.Size = New System.Drawing.Size(122, 44)
        Me.BtnSaveChanges.TabIndex = 0
        Me.BtnSaveChanges.Text = "Save Changes"
        '
        'XTCReport
        '
        Me.XTCReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XTCReport.Location = New System.Drawing.Point(0, 103)
        Me.XTCReport.Name = "XTCReport"
        Me.XTCReport.SelectedTabPage = Me.XTPAccount
        Me.XTCReport.Size = New System.Drawing.Size(784, 410)
        Me.XTCReport.TabIndex = 2
        Me.XTCReport.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XTPAccount, Me.XTPReport})
        '
        'XTPAccount
        '
        Me.XTPAccount.Controls.Add(Me.GCAccount)
        Me.XTPAccount.Name = "XTPAccount"
        Me.XTPAccount.Size = New System.Drawing.Size(778, 382)
        Me.XTPAccount.Text = "Combine List"
        '
        'GCAccount
        '
        Me.GCAccount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCAccount.Location = New System.Drawing.Point(0, 0)
        Me.GCAccount.MainView = Me.GVAccount
        Me.GCAccount.Name = "GCAccount"
        Me.GCAccount.Size = New System.Drawing.Size(778, 382)
        Me.GCAccount.TabIndex = 0
        Me.GCAccount.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVAccount})
        '
        'GVAccount
        '
        Me.GVAccount.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumncombine_no, Me.GridColumndb_name, Me.GridColumncomp_number, Me.GridColumncomp_name, Me.GridColumnsoh_qty, Me.GridColumnscan_qty})
        Me.GVAccount.GridControl = Me.GCAccount
        Me.GVAccount.Name = "GVAccount"
        Me.GVAccount.OptionsBehavior.AutoExpandAllGroups = True
        Me.GVAccount.OptionsBehavior.ReadOnly = True
        Me.GVAccount.OptionsView.ColumnAutoWidth = False
        Me.GVAccount.OptionsView.ShowFooter = True
        Me.GVAccount.OptionsView.ShowGroupPanel = False
        '
        'GridColumncombine_no
        '
        Me.GridColumncombine_no.Caption = "Combine No."
        Me.GridColumncombine_no.FieldName = "combine_no"
        Me.GridColumncombine_no.Name = "GridColumncombine_no"
        Me.GridColumncombine_no.Visible = True
        Me.GridColumncombine_no.VisibleIndex = 2
        '
        'GridColumndb_name
        '
        Me.GridColumndb_name.Caption = "DB"
        Me.GridColumndb_name.FieldName = "db_name"
        Me.GridColumndb_name.Name = "GridColumndb_name"
        '
        'GridColumncomp_number
        '
        Me.GridColumncomp_number.Caption = "Account No"
        Me.GridColumncomp_number.FieldName = "comp_number"
        Me.GridColumncomp_number.Name = "GridColumncomp_number"
        Me.GridColumncomp_number.Visible = True
        Me.GridColumncomp_number.VisibleIndex = 0
        '
        'GridColumncomp_name
        '
        Me.GridColumncomp_name.Caption = "Account"
        Me.GridColumncomp_name.FieldName = "comp_name"
        Me.GridColumncomp_name.Name = "GridColumncomp_name"
        Me.GridColumncomp_name.Visible = True
        Me.GridColumncomp_name.VisibleIndex = 1
        '
        'GridColumnsoh_qty
        '
        Me.GridColumnsoh_qty.Caption = "SOH"
        Me.GridColumnsoh_qty.DisplayFormat.FormatString = "N0"
        Me.GridColumnsoh_qty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumnsoh_qty.FieldName = "soh_qty"
        Me.GridColumnsoh_qty.Name = "GridColumnsoh_qty"
        Me.GridColumnsoh_qty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "soh_qty", "{0:N0}")})
        Me.GridColumnsoh_qty.Visible = True
        Me.GridColumnsoh_qty.VisibleIndex = 3
        '
        'GridColumnscan_qty
        '
        Me.GridColumnscan_qty.Caption = "Scan"
        Me.GridColumnscan_qty.DisplayFormat.FormatString = "N0"
        Me.GridColumnscan_qty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumnscan_qty.FieldName = "scan_qty"
        Me.GridColumnscan_qty.Name = "GridColumnscan_qty"
        Me.GridColumnscan_qty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "scan_qty", "{0:N0}")})
        Me.GridColumnscan_qty.Visible = True
        Me.GridColumnscan_qty.VisibleIndex = 4
        '
        'XTPReport
        '
        Me.XTPReport.Controls.Add(Me.GCRpt)
        Me.XTPReport.Name = "XTPReport"
        Me.XTPReport.Size = New System.Drawing.Size(778, 382)
        Me.XTPReport.Text = "Detail Report"
        '
        'GCRpt
        '
        Me.GCRpt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCRpt.Location = New System.Drawing.Point(0, 0)
        Me.GCRpt.MainView = Me.BGVRpt
        Me.GCRpt.Name = "GCRpt"
        Me.GCRpt.Size = New System.Drawing.Size(778, 382)
        Me.GCRpt.TabIndex = 0
        Me.GCRpt.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BGVRpt, Me.GVRpt})
        '
        'BGVRpt
        '
        Me.BGVRpt.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BGVRpt.Appearance.HeaderPanel.Options.UseFont = True
        Me.BGVRpt.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBandDescription, Me.gridBandGlobal})
        Me.BGVRpt.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.BandedGridColumnBarcode, Me.BandedGridColumnSKU, Me.BandedGridColumnDescription, Me.BandedGridColumnSize, Me.BandedGridColumnTotalSOH, Me.BandedGridColumnValueSOH, Me.BandedGridColumnTotalScan, Me.BandedGridColumnValueScan, Me.BandedGridColumnTotalDiff, Me.BandedGridColumnValueDiff})
        Me.BGVRpt.GridControl = Me.GCRpt
        Me.BGVRpt.Name = "BGVRpt"
        Me.BGVRpt.OptionsBehavior.ReadOnly = True
        Me.BGVRpt.OptionsFind.AlwaysVisible = True
        Me.BGVRpt.OptionsView.ColumnAutoWidth = False
        Me.BGVRpt.OptionsView.ShowFooter = True
        Me.BGVRpt.OptionsView.ShowGroupPanel = False
        '
        'BandedGridColumnBarcode
        '
        Me.BandedGridColumnBarcode.Caption = "Barcode"
        Me.BandedGridColumnBarcode.FieldName = "Barcode"
        Me.BandedGridColumnBarcode.Name = "BandedGridColumnBarcode"
        Me.BandedGridColumnBarcode.Visible = True
        '
        'BandedGridColumnSKU
        '
        Me.BandedGridColumnSKU.Caption = "SKU"
        Me.BandedGridColumnSKU.FieldName = "SKU"
        Me.BandedGridColumnSKU.Name = "BandedGridColumnSKU"
        Me.BandedGridColumnSKU.Visible = True
        '
        'BandedGridColumnDescription
        '
        Me.BandedGridColumnDescription.Caption = "Description"
        Me.BandedGridColumnDescription.FieldName = "Description"
        Me.BandedGridColumnDescription.Name = "BandedGridColumnDescription"
        Me.BandedGridColumnDescription.Visible = True
        '
        'BandedGridColumnSize
        '
        Me.BandedGridColumnSize.Caption = "Size"
        Me.BandedGridColumnSize.FieldName = "Size"
        Me.BandedGridColumnSize.Name = "BandedGridColumnSize"
        Me.BandedGridColumnSize.Visible = True
        '
        'BandedGridColumnTotalSOH
        '
        Me.BandedGridColumnTotalSOH.Caption = "Total SOH"
        Me.BandedGridColumnTotalSOH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumnTotalSOH.FieldName = "Total SOH"
        Me.BandedGridColumnTotalSOH.Name = "BandedGridColumnTotalSOH"
        Me.BandedGridColumnTotalSOH.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total SOH", "{0:N0}")})
        Me.BandedGridColumnTotalSOH.Visible = True
        '
        'BandedGridColumnValueSOH
        '
        Me.BandedGridColumnValueSOH.Caption = "Value"
        Me.BandedGridColumnValueSOH.DisplayFormat.FormatString = "N0"
        Me.BandedGridColumnValueSOH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumnValueSOH.FieldName = "Value SOH"
        Me.BandedGridColumnValueSOH.Name = "BandedGridColumnValueSOH"
        Me.BandedGridColumnValueSOH.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Value SOH", "{0:N0}")})
        Me.BandedGridColumnValueSOH.Visible = True
        '
        'BandedGridColumnTotalScan
        '
        Me.BandedGridColumnTotalScan.Caption = "Total Scan"
        Me.BandedGridColumnTotalScan.DisplayFormat.FormatString = "N0"
        Me.BandedGridColumnTotalScan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumnTotalScan.FieldName = "Total Scan"
        Me.BandedGridColumnTotalScan.Name = "BandedGridColumnTotalScan"
        Me.BandedGridColumnTotalScan.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total Scan", "{0:N0}")})
        Me.BandedGridColumnTotalScan.Visible = True
        '
        'BandedGridColumnValueScan
        '
        Me.BandedGridColumnValueScan.Caption = "Value"
        Me.BandedGridColumnValueScan.DisplayFormat.FormatString = "N0"
        Me.BandedGridColumnValueScan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumnValueScan.FieldName = "Value Scan"
        Me.BandedGridColumnValueScan.Name = "BandedGridColumnValueScan"
        Me.BandedGridColumnValueScan.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Value Scan", "{0:N0}")})
        Me.BandedGridColumnValueScan.Visible = True
        '
        'GVRpt
        '
        Me.GVRpt.GridControl = Me.GCRpt
        Me.GVRpt.Name = "GVRpt"
        '
        'BandedGridColumnTotalDiff
        '
        Me.BandedGridColumnTotalDiff.Caption = "Total Selisih"
        Me.BandedGridColumnTotalDiff.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumnTotalDiff.FieldName = "Total Diff"
        Me.BandedGridColumnTotalDiff.Name = "BandedGridColumnTotalDiff"
        Me.BandedGridColumnTotalDiff.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total Diff", "{0:N0}")})
        Me.BandedGridColumnTotalDiff.Visible = True
        Me.BandedGridColumnTotalDiff.Width = 100
        '
        'BandedGridColumnValueDiff
        '
        Me.BandedGridColumnValueDiff.Caption = "Value"
        Me.BandedGridColumnValueDiff.DisplayFormat.FormatString = "N0"
        Me.BandedGridColumnValueDiff.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumnValueDiff.FieldName = "Value Diff"
        Me.BandedGridColumnValueDiff.Name = "BandedGridColumnValueDiff"
        Me.BandedGridColumnValueDiff.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Value Diff", "{0:N0}")})
        Me.BandedGridColumnValueDiff.Visible = True
        '
        'gridBandDescription
        '
        Me.gridBandDescription.Columns.Add(Me.BandedGridColumnBarcode)
        Me.gridBandDescription.Columns.Add(Me.BandedGridColumnSKU)
        Me.gridBandDescription.Columns.Add(Me.BandedGridColumnDescription)
        Me.gridBandDescription.Columns.Add(Me.BandedGridColumnSize)
        Me.gridBandDescription.Name = "gridBandDescription"
        Me.gridBandDescription.VisibleIndex = 0
        Me.gridBandDescription.Width = 300
        '
        'gridBandGlobal
        '
        Me.gridBandGlobal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gridBandGlobal.AppearanceHeader.Options.UseFont = True
        Me.gridBandGlobal.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBandGlobal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBandGlobal.Caption = "Selisih Global"
        Me.gridBandGlobal.Columns.Add(Me.BandedGridColumnTotalSOH)
        Me.gridBandGlobal.Columns.Add(Me.BandedGridColumnValueSOH)
        Me.gridBandGlobal.Columns.Add(Me.BandedGridColumnTotalScan)
        Me.gridBandGlobal.Columns.Add(Me.BandedGridColumnValueScan)
        Me.gridBandGlobal.Columns.Add(Me.BandedGridColumnTotalDiff)
        Me.gridBandGlobal.Columns.Add(Me.BandedGridColumnValueDiff)
        Me.gridBandGlobal.Name = "gridBandGlobal"
        Me.gridBandGlobal.VisibleIndex = 1
        Me.gridBandGlobal.Width = 475
        '
        'FormRptDet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.XTCReport)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.MinimizeBox = False
        Me.Name = "FormRptDet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Take Report"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.TxtCreatedBy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DECreatedDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DECreatedDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MENote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.XTCReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTCReport.ResumeLayout(False)
        Me.XTPAccount.ResumeLayout(False)
        CType(Me.GCAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVAccount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTPReport.ResumeLayout(False)
        CType(Me.GCRpt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BGVRpt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVRpt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DECreatedDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MENote As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents TxtNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BtnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnSaveChanges As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XTCReport As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XTPAccount As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XTPReport As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GCAccount As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVAccount As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumncombine_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumndb_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumncomp_number As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumncomp_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnsoh_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnscan_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtCreatedBy As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GCRpt As DevExpress.XtraGrid.GridControl
    Friend WithEvents BGVRpt As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GVRpt As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BandedGridColumnBarcode As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumnSKU As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumnDescription As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumnSize As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumnTotalSOH As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumnValueSOH As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumnTotalScan As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumnValueScan As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBandDescription As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBandGlobal As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents BandedGridColumnTotalDiff As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumnValueDiff As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
End Class
