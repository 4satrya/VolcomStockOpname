<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStockTakeDet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormStockTakeDet))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.MERemark = New DevExpress.XtraEditors.MemoEdit()
        Me.PanelControlTopLeft = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.DECreated = New DevExpress.XtraEditors.DateEdit()
        Me.TxtNumber = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.SLEWHStockSum = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView14 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.TxtApp = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LEAck = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.BtnSetStatus = New DevExpress.XtraEditors.SimpleButton()
        Me.LEStatus = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.BtnPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.XTCStockTake = New DevExpress.XtraTab.XtraTabControl()
        Me.XTPScan = New DevExpress.XtraTab.XtraTabPage()
        Me.GCScan = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SetQtyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.PanelControlNav = New DevExpress.XtraEditors.PanelControl()
        Me.CheckEditNoTag = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEditReject = New DevExpress.XtraEditors.CheckEdit()
        Me.TxtScan = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
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
        Me.XTPCompare = New DevExpress.XtraTab.XtraTabPage()
        Me.GCCompare = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStripCompare = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewDetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BGVCompare = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.gridBandInfo = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BandedGridColumnNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumnBarcode = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumnCode = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumnName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumnSize = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumnType = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumnPrice = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBandVolcomQty = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BandedGridColumnSOHQty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumnSOHValue = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBandStoreQty = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BandedGridColumnScanQty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumnScanValue = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBandKet = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BandedGridColumnDiffQty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumnDiffValue = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumnNote = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.MERemark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControlTopLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControlTopLeft.SuspendLayout()
        CType(Me.DECreated.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DECreated.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SLEWHStockSum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.TxtApp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LEAck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LEStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.XTCStockTake, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTCStockTake.SuspendLayout()
        Me.XTPScan.SuspendLayout()
        CType(Me.GCScan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GVScan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControlNav, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControlNav.SuspendLayout()
        CType(Me.CheckEditNoTag.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEditReject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtScan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTPSummary.SuspendLayout()
        CType(Me.GCSummaryScan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVSummaryScan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTPCondition.SuspendLayout()
        CType(Me.GCCat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVCat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTPCompare.SuspendLayout()
        CType(Me.GCCompare, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripCompare.SuspendLayout()
        CType(Me.BGVCompare, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.CaptionLocation = DevExpress.Utils.Locations.Left
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.MERemark)
        Me.GroupControl1.Controls.Add(Me.PanelControlTopLeft)
        Me.GroupControl1.Controls.Add(Me.SLEWHStockSum)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1042, 97)
        Me.GroupControl1.TabIndex = 0
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(36, 42)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl6.TabIndex = 8905
        Me.LabelControl6.Text = "Remark"
        '
        'MERemark
        '
        Me.MERemark.Location = New System.Drawing.Point(92, 39)
        Me.MERemark.Name = "MERemark"
        Me.MERemark.Size = New System.Drawing.Size(279, 41)
        Me.MERemark.TabIndex = 8904
        '
        'PanelControlTopLeft
        '
        Me.PanelControlTopLeft.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControlTopLeft.Controls.Add(Me.LabelControl3)
        Me.PanelControlTopLeft.Controls.Add(Me.DECreated)
        Me.PanelControlTopLeft.Controls.Add(Me.TxtNumber)
        Me.PanelControlTopLeft.Controls.Add(Me.LabelControl2)
        Me.PanelControlTopLeft.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelControlTopLeft.Location = New System.Drawing.Point(755, 2)
        Me.PanelControlTopLeft.Name = "PanelControlTopLeft"
        Me.PanelControlTopLeft.Size = New System.Drawing.Size(285, 93)
        Me.PanelControlTopLeft.TabIndex = 8903
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(14, 40)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl3.TabIndex = 8905
        Me.LabelControl3.Text = "Created Date"
        '
        'DECreated
        '
        Me.DECreated.EditValue = Nothing
        Me.DECreated.Enabled = False
        Me.DECreated.Location = New System.Drawing.Point(97, 37)
        Me.DECreated.Name = "DECreated"
        Me.DECreated.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DECreated.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DECreated.Size = New System.Drawing.Size(173, 20)
        Me.DECreated.TabIndex = 8903
        '
        'TxtNumber
        '
        Me.TxtNumber.Enabled = False
        Me.TxtNumber.Location = New System.Drawing.Point(97, 11)
        Me.TxtNumber.Name = "TxtNumber"
        Me.TxtNumber.Size = New System.Drawing.Size(173, 20)
        Me.TxtNumber.TabIndex = 8904
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(14, 14)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl2.TabIndex = 8902
        Me.LabelControl2.Text = "Number"
        '
        'SLEWHStockSum
        '
        Me.SLEWHStockSum.Location = New System.Drawing.Point(92, 13)
        Me.SLEWHStockSum.Name = "SLEWHStockSum"
        Me.SLEWHStockSum.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SLEWHStockSum.Properties.Appearance.Options.UseFont = True
        Me.SLEWHStockSum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SLEWHStockSum.Properties.View = Me.GridView14
        Me.SLEWHStockSum.Size = New System.Drawing.Size(279, 20)
        Me.SLEWHStockSum.TabIndex = 8901
        '
        'GridView14
        '
        Me.GridView14.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView14.Name = "GridView14"
        Me.GridView14.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView14.OptionsView.ShowGroupPanel = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(36, 16)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Account"
        '
        'GroupControl2
        '
        Me.GroupControl2.CaptionLocation = DevExpress.Utils.Locations.Left
        Me.GroupControl2.Controls.Add(Me.TxtApp)
        Me.GroupControl2.Controls.Add(Me.LabelControl8)
        Me.GroupControl2.Controls.Add(Me.LEAck)
        Me.GroupControl2.Controls.Add(Me.LabelControl7)
        Me.GroupControl2.Controls.Add(Me.BtnSetStatus)
        Me.GroupControl2.Controls.Add(Me.LEStatus)
        Me.GroupControl2.Controls.Add(Me.LabelControl5)
        Me.GroupControl2.Controls.Add(Me.BtnPrint)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl2.Location = New System.Drawing.Point(0, 538)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1042, 45)
        Me.GroupControl2.TabIndex = 1
        '
        'TxtApp
        '
        Me.TxtApp.Location = New System.Drawing.Point(523, 13)
        Me.TxtApp.Name = "TxtApp"
        Me.TxtApp.Size = New System.Drawing.Size(174, 20)
        Me.TxtApp.TabIndex = 8910
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(455, 16)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl8.TabIndex = 8909
        Me.LabelControl8.Text = "Approved By"
        '
        'LEAck
        '
        Me.LEAck.Location = New System.Drawing.Point(275, 13)
        Me.LEAck.Name = "LEAck"
        Me.LEAck.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LEAck.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_user", "Id", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("employee_name", "Name")})
        Me.LEAck.Properties.NullText = "-Select-"
        Me.LEAck.Size = New System.Drawing.Size(174, 20)
        Me.LEAck.TabIndex = 8908
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(191, 16)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl7.TabIndex = 8907
        Me.LabelControl7.Text = "Acknowledge By"
        '
        'BtnSetStatus
        '
        Me.BtnSetStatus.Location = New System.Drawing.Point(703, 13)
        Me.BtnSetStatus.Name = "BtnSetStatus"
        Me.BtnSetStatus.Size = New System.Drawing.Size(53, 20)
        Me.BtnSetStatus.TabIndex = 8906
        Me.BtnSetStatus.Text = "Apply"
        '
        'LEStatus
        '
        Me.LEStatus.Location = New System.Drawing.Point(73, 13)
        Me.LEStatus.Name = "LEStatus"
        Me.LEStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LEStatus.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_report_status", "Id", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("report_status", "Status")})
        Me.LEStatus.Size = New System.Drawing.Size(112, 20)
        Me.LEStatus.TabIndex = 8905
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(36, 16)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl5.TabIndex = 8904
        Me.LabelControl5.Text = "Status"
        '
        'BtnPrint
        '
        Me.BtnPrint.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.Location = New System.Drawing.Point(936, 2)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(104, 41)
        Me.BtnPrint.TabIndex = 1
        Me.BtnPrint.Text = "Print (F4)"
        '
        'GroupControl3
        '
        Me.GroupControl3.CaptionLocation = DevExpress.Utils.Locations.Left
        Me.GroupControl3.Controls.Add(Me.XTCStockTake)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(0, 97)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(1042, 441)
        Me.GroupControl3.TabIndex = 2
        '
        'XTCStockTake
        '
        Me.XTCStockTake.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XTCStockTake.Location = New System.Drawing.Point(20, 2)
        Me.XTCStockTake.Name = "XTCStockTake"
        Me.XTCStockTake.SelectedTabPage = Me.XTPScan
        Me.XTCStockTake.Size = New System.Drawing.Size(1020, 437)
        Me.XTCStockTake.TabIndex = 0
        Me.XTCStockTake.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XTPScan, Me.XTPSummary, Me.XTPCondition, Me.XTPCompare})
        '
        'XTPScan
        '
        Me.XTPScan.Controls.Add(Me.GCScan)
        Me.XTPScan.Controls.Add(Me.PanelControlNav)
        Me.XTPScan.Name = "XTPScan"
        Me.XTPScan.Size = New System.Drawing.Size(1014, 409)
        Me.XTPScan.Text = "Scan Result"
        '
        'GCScan
        '
        Me.GCScan.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GCScan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCScan.Location = New System.Drawing.Point(0, 46)
        Me.GCScan.MainView = Me.GVScan
        Me.GCScan.Name = "GCScan"
        Me.GCScan.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.GCScan.Size = New System.Drawing.Size(1014, 363)
        Me.GCScan.TabIndex = 1
        Me.GCScan.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVScan})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetQtyToolStripMenuItem, Me.DeleteItemToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(135, 48)
        '
        'SetQtyToolStripMenuItem
        '
        Me.SetQtyToolStripMenuItem.Name = "SetQtyToolStripMenuItem"
        Me.SetQtyToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.SetQtyToolStripMenuItem.Text = "Set Qty"
        '
        'DeleteItemToolStripMenuItem
        '
        Me.DeleteItemToolStripMenuItem.Name = "DeleteItemToolStripMenuItem"
        Me.DeleteItemToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.DeleteItemToolStripMenuItem.Text = "Delete Item"
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
        Me.GridColumnCode.VisibleIndex = 1
        Me.GridColumnCode.Width = 170
        '
        'GridColumnDescription
        '
        Me.GridColumnDescription.Caption = "Description"
        Me.GridColumnDescription.FieldName = "name"
        Me.GridColumnDescription.Name = "GridColumnDescription"
        Me.GridColumnDescription.OptionsColumn.AllowEdit = False
        Me.GridColumnDescription.Visible = True
        Me.GridColumnDescription.VisibleIndex = 2
        Me.GridColumnDescription.Width = 338
        '
        'GridColumnSize
        '
        Me.GridColumnSize.Caption = "Size"
        Me.GridColumnSize.FieldName = "size"
        Me.GridColumnSize.Name = "GridColumnSize"
        Me.GridColumnSize.OptionsColumn.AllowEdit = False
        Me.GridColumnSize.Visible = True
        Me.GridColumnSize.VisibleIndex = 3
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
        Me.GridColumnQty.VisibleIndex = 6
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
        Me.GridColumnPrice.VisibleIndex = 7
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
        Me.GridColumnAmount.VisibleIndex = 8
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
        Me.GridColumnNoStock.VisibleIndex = 10
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
        Me.GridColumnNoMaster.VisibleIndex = 15
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
        Me.GridColumnSale.VisibleIndex = 11
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
        Me.GridColumnOK.VisibleIndex = 9
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
        Me.GridColumnReject.VisibleIndex = 12
        Me.GridColumnReject.Width = 62
        '
        'GridColumnproductStatus
        '
        Me.GridColumnproductStatus.Caption = "Product Status"
        Me.GridColumnproductStatus.FieldName = "design_cat"
        Me.GridColumnproductStatus.Name = "GridColumnproductStatus"
        Me.GridColumnproductStatus.Visible = True
        Me.GridColumnproductStatus.VisibleIndex = 5
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
        Me.GridColumnIniqueNotFound.VisibleIndex = 14
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
        Me.GridColumnNoTag.VisibleIndex = 13
        Me.GridColumnNoTag.Width = 74
        '
        'GridColumnPrcType
        '
        Me.GridColumnPrcType.Caption = "Price Type"
        Me.GridColumnPrcType.FieldName = "design_price_type"
        Me.GridColumnPrcType.Name = "GridColumnPrcType"
        Me.GridColumnPrcType.Visible = True
        Me.GridColumnPrcType.VisibleIndex = 4
        Me.GridColumnPrcType.Width = 76
        '
        'GridColumnRemark
        '
        Me.GridColumnRemark.Caption = "Remark"
        Me.GridColumnRemark.FieldName = "remark_ref"
        Me.GridColumnRemark.Name = "GridColumnRemark"
        Me.GridColumnRemark.OptionsColumn.AllowEdit = False
        Me.GridColumnRemark.Visible = True
        Me.GridColumnRemark.VisibleIndex = 17
        Me.GridColumnRemark.Width = 93
        '
        'GridColumnRefNumber
        '
        Me.GridColumnRefNumber.Caption = "Ref#"
        Me.GridColumnRefNumber.FieldName = "ref_number"
        Me.GridColumnRefNumber.Name = "GridColumnRefNumber"
        Me.GridColumnRefNumber.Visible = True
        Me.GridColumnRefNumber.VisibleIndex = 16
        Me.GridColumnRefNumber.Width = 82
        '
        'PanelControlNav
        '
        Me.PanelControlNav.Controls.Add(Me.CheckEditNoTag)
        Me.PanelControlNav.Controls.Add(Me.CheckEditReject)
        Me.PanelControlNav.Controls.Add(Me.TxtScan)
        Me.PanelControlNav.Controls.Add(Me.LabelControl4)
        Me.PanelControlNav.Controls.Add(Me.SimpleButton3)
        Me.PanelControlNav.Controls.Add(Me.SimpleButton2)
        Me.PanelControlNav.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControlNav.Location = New System.Drawing.Point(0, 0)
        Me.PanelControlNav.Name = "PanelControlNav"
        Me.PanelControlNav.Size = New System.Drawing.Size(1014, 46)
        Me.PanelControlNav.TabIndex = 0
        '
        'CheckEditNoTag
        '
        Me.CheckEditNoTag.Location = New System.Drawing.Point(401, 14)
        Me.CheckEditNoTag.Name = "CheckEditNoTag"
        Me.CheckEditNoTag.Properties.Caption = "No Tag"
        Me.CheckEditNoTag.Size = New System.Drawing.Size(60, 19)
        Me.CheckEditNoTag.TabIndex = 8907
        '
        'CheckEditReject
        '
        Me.CheckEditReject.Location = New System.Drawing.Point(308, 14)
        Me.CheckEditReject.Name = "CheckEditReject"
        Me.CheckEditReject.Properties.Caption = "Reject Product"
        Me.CheckEditReject.Size = New System.Drawing.Size(98, 19)
        Me.CheckEditReject.TabIndex = 8906
        '
        'TxtScan
        '
        Me.TxtScan.Location = New System.Drawing.Point(101, 13)
        Me.TxtScan.Name = "TxtScan"
        Me.TxtScan.Size = New System.Drawing.Size(201, 20)
        Me.TxtScan.TabIndex = 8905
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(15, 16)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl4.TabIndex = 8904
        Me.LabelControl4.Text = "Scanned Code"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Dock = System.Windows.Forms.DockStyle.Right
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(789, 2)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(126, 42)
        Me.SimpleButton3.TabIndex = 2
        Me.SimpleButton3.Text = "Delete Scan (F3)"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Dock = System.Windows.Forms.DockStyle.Right
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(915, 2)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(97, 42)
        Me.SimpleButton2.TabIndex = 1
        Me.SimpleButton2.Text = "Add (F2)"
        '
        'XTPSummary
        '
        Me.XTPSummary.Controls.Add(Me.GCSummaryScan)
        Me.XTPSummary.Name = "XTPSummary"
        Me.XTPSummary.Size = New System.Drawing.Size(1014, 409)
        Me.XTPSummary.Text = "Summary By Product"
        '
        'GCSummaryScan
        '
        Me.GCSummaryScan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCSummaryScan.Location = New System.Drawing.Point(0, 0)
        Me.GCSummaryScan.MainView = Me.GVSummaryScan
        Me.GCSummaryScan.Name = "GCSummaryScan"
        Me.GCSummaryScan.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.GCSummaryScan.Size = New System.Drawing.Size(1014, 409)
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
        Me.XTPCondition.Size = New System.Drawing.Size(1014, 409)
        Me.XTPCondition.Text = "Summary By Category"
        '
        'GCCat
        '
        Me.GCCat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCCat.Location = New System.Drawing.Point(0, 0)
        Me.GCCat.MainView = Me.GVCat
        Me.GCCat.Name = "GCCat"
        Me.GCCat.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit2})
        Me.GCCat.Size = New System.Drawing.Size(1014, 409)
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
        Me.GridColumn3.ColumnEdit = Me.RepositoryItemTextEdit2
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
        'XTPCompare
        '
        Me.XTPCompare.Controls.Add(Me.GCCompare)
        Me.XTPCompare.Name = "XTPCompare"
        Me.XTPCompare.PageVisible = False
        Me.XTPCompare.Size = New System.Drawing.Size(1014, 409)
        Me.XTPCompare.Text = "Compare Stock"
        '
        'GCCompare
        '
        Me.GCCompare.ContextMenuStrip = Me.ContextMenuStripCompare
        Me.GCCompare.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCCompare.Location = New System.Drawing.Point(0, 0)
        Me.GCCompare.MainView = Me.BGVCompare
        Me.GCCompare.Name = "GCCompare"
        Me.GCCompare.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit3})
        Me.GCCompare.Size = New System.Drawing.Size(1014, 409)
        Me.GCCompare.TabIndex = 0
        Me.GCCompare.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BGVCompare})
        '
        'ContextMenuStripCompare
        '
        Me.ContextMenuStripCompare.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewDetailToolStripMenuItem})
        Me.ContextMenuStripCompare.Name = "ContextMenuStripCompare"
        Me.ContextMenuStripCompare.Size = New System.Drawing.Size(133, 26)
        '
        'ViewDetailToolStripMenuItem
        '
        Me.ViewDetailToolStripMenuItem.Name = "ViewDetailToolStripMenuItem"
        Me.ViewDetailToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ViewDetailToolStripMenuItem.Text = "View Detail"
        '
        'BGVCompare
        '
        Me.BGVCompare.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBandInfo, Me.gridBandVolcomQty, Me.gridBandStoreQty, Me.gridBandKet})
        Me.BGVCompare.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.BandedGridColumnNo, Me.BandedGridColumnBarcode, Me.BandedGridColumnCode, Me.BandedGridColumnName, Me.BandedGridColumnSize, Me.BandedGridColumnType, Me.BandedGridColumnPrice, Me.BandedGridColumnSOHQty, Me.BandedGridColumnScanQty, Me.BandedGridColumnSOHValue, Me.BandedGridColumnScanValue, Me.BandedGridColumnDiffQty, Me.BandedGridColumnDiffValue, Me.BandedGridColumnNote})
        Me.BGVCompare.GridControl = Me.GCCompare
        Me.BGVCompare.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qty_soh", Me.BandedGridColumnSOHQty, "{0:N0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qty_scan", Me.BandedGridColumnScanQty, "{0:N0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qty_diff", Me.BandedGridColumnDiffQty, "{0:N0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "val_soh", Me.BandedGridColumnSOHValue, "{0:N0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "val_scan", Me.BandedGridColumnScanValue, "{0:N0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "val_diff", Me.BandedGridColumnDiffValue, "{0:N0}")})
        Me.BGVCompare.Name = "BGVCompare"
        Me.BGVCompare.OptionsBehavior.AutoExpandAllGroups = True
        Me.BGVCompare.OptionsView.ColumnAutoWidth = False
        Me.BGVCompare.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[True]
        Me.BGVCompare.OptionsView.ShowFooter = True
        Me.BGVCompare.OptionsView.ShowGroupPanel = False
        '
        'gridBandInfo
        '
        Me.gridBandInfo.Caption = "  "
        Me.gridBandInfo.Columns.Add(Me.BandedGridColumnNo)
        Me.gridBandInfo.Columns.Add(Me.BandedGridColumnBarcode)
        Me.gridBandInfo.Columns.Add(Me.BandedGridColumnCode)
        Me.gridBandInfo.Columns.Add(Me.BandedGridColumnName)
        Me.gridBandInfo.Columns.Add(Me.BandedGridColumnSize)
        Me.gridBandInfo.Columns.Add(Me.BandedGridColumnType)
        Me.gridBandInfo.Columns.Add(Me.BandedGridColumnPrice)
        Me.gridBandInfo.Name = "gridBandInfo"
        Me.gridBandInfo.VisibleIndex = 0
        Me.gridBandInfo.Width = 794
        '
        'BandedGridColumnNo
        '
        Me.BandedGridColumnNo.Caption = "No"
        Me.BandedGridColumnNo.FieldName = "no"
        Me.BandedGridColumnNo.Name = "BandedGridColumnNo"
        Me.BandedGridColumnNo.Visible = True
        Me.BandedGridColumnNo.Width = 40
        '
        'BandedGridColumnBarcode
        '
        Me.BandedGridColumnBarcode.Caption = "Barcode"
        Me.BandedGridColumnBarcode.FieldName = "barcode"
        Me.BandedGridColumnBarcode.Name = "BandedGridColumnBarcode"
        Me.BandedGridColumnBarcode.Visible = True
        Me.BandedGridColumnBarcode.Width = 143
        '
        'BandedGridColumnCode
        '
        Me.BandedGridColumnCode.Caption = "Code"
        Me.BandedGridColumnCode.FieldName = "code"
        Me.BandedGridColumnCode.Name = "BandedGridColumnCode"
        Me.BandedGridColumnCode.Visible = True
        Me.BandedGridColumnCode.Width = 108
        '
        'BandedGridColumnName
        '
        Me.BandedGridColumnName.AppearanceCell.Options.UseTextOptions = True
        Me.BandedGridColumnName.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BandedGridColumnName.Caption = "Description"
        Me.BandedGridColumnName.FieldName = "name"
        Me.BandedGridColumnName.Name = "BandedGridColumnName"
        Me.BandedGridColumnName.Visible = True
        Me.BandedGridColumnName.Width = 304
        '
        'BandedGridColumnSize
        '
        Me.BandedGridColumnSize.Caption = "Size"
        Me.BandedGridColumnSize.FieldName = "size"
        Me.BandedGridColumnSize.Name = "BandedGridColumnSize"
        Me.BandedGridColumnSize.Visible = True
        Me.BandedGridColumnSize.Width = 38
        '
        'BandedGridColumnType
        '
        Me.BandedGridColumnType.Caption = "Type"
        Me.BandedGridColumnType.FieldName = "design_cat"
        Me.BandedGridColumnType.Name = "BandedGridColumnType"
        Me.BandedGridColumnType.Visible = True
        Me.BandedGridColumnType.Width = 51
        '
        'BandedGridColumnPrice
        '
        Me.BandedGridColumnPrice.Caption = "Price"
        Me.BandedGridColumnPrice.DisplayFormat.FormatString = "N0"
        Me.BandedGridColumnPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumnPrice.FieldName = "design_price"
        Me.BandedGridColumnPrice.Name = "BandedGridColumnPrice"
        Me.BandedGridColumnPrice.Visible = True
        Me.BandedGridColumnPrice.Width = 110
        '
        'gridBandVolcomQty
        '
        Me.gridBandVolcomQty.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBandVolcomQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBandVolcomQty.Caption = "VOLCOM"
        Me.gridBandVolcomQty.Columns.Add(Me.BandedGridColumnSOHQty)
        Me.gridBandVolcomQty.Columns.Add(Me.BandedGridColumnSOHValue)
        Me.gridBandVolcomQty.Name = "gridBandVolcomQty"
        Me.gridBandVolcomQty.VisibleIndex = 1
        Me.gridBandVolcomQty.Width = 236
        '
        'BandedGridColumnSOHQty
        '
        Me.BandedGridColumnSOHQty.AutoFillDown = True
        Me.BandedGridColumnSOHQty.Caption = "SOH"
        Me.BandedGridColumnSOHQty.DisplayFormat.FormatString = "N0"
        Me.BandedGridColumnSOHQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumnSOHQty.FieldName = "qty_soh"
        Me.BandedGridColumnSOHQty.Name = "BandedGridColumnSOHQty"
        Me.BandedGridColumnSOHQty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qty_soh", "{0:N0}")})
        Me.BandedGridColumnSOHQty.Visible = True
        Me.BandedGridColumnSOHQty.Width = 90
        '
        'BandedGridColumnSOHValue
        '
        Me.BandedGridColumnSOHValue.Caption = "Value"
        Me.BandedGridColumnSOHValue.DisplayFormat.FormatString = "N0"
        Me.BandedGridColumnSOHValue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumnSOHValue.FieldName = "val_soh"
        Me.BandedGridColumnSOHValue.Name = "BandedGridColumnSOHValue"
        Me.BandedGridColumnSOHValue.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "val_soh", "{0:N0}")})
        Me.BandedGridColumnSOHValue.UnboundExpression = "[design_price] * [qty_soh]"
        Me.BandedGridColumnSOHValue.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.BandedGridColumnSOHValue.Visible = True
        Me.BandedGridColumnSOHValue.Width = 146
        '
        'gridBandStoreQty
        '
        Me.gridBandStoreQty.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBandStoreQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBandStoreQty.Caption = "STORE"
        Me.gridBandStoreQty.Columns.Add(Me.BandedGridColumnScanQty)
        Me.gridBandStoreQty.Columns.Add(Me.BandedGridColumnScanValue)
        Me.gridBandStoreQty.Name = "gridBandStoreQty"
        Me.gridBandStoreQty.VisibleIndex = 2
        Me.gridBandStoreQty.Width = 236
        '
        'BandedGridColumnScanQty
        '
        Me.BandedGridColumnScanQty.Caption = "Scan"
        Me.BandedGridColumnScanQty.DisplayFormat.FormatString = "N0"
        Me.BandedGridColumnScanQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumnScanQty.FieldName = "qty_scan"
        Me.BandedGridColumnScanQty.Name = "BandedGridColumnScanQty"
        Me.BandedGridColumnScanQty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qty_scan", "{0:N0}")})
        Me.BandedGridColumnScanQty.Visible = True
        Me.BandedGridColumnScanQty.Width = 90
        '
        'BandedGridColumnScanValue
        '
        Me.BandedGridColumnScanValue.Caption = "Value"
        Me.BandedGridColumnScanValue.DisplayFormat.FormatString = "N0"
        Me.BandedGridColumnScanValue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumnScanValue.FieldName = "val_scan"
        Me.BandedGridColumnScanValue.Name = "BandedGridColumnScanValue"
        Me.BandedGridColumnScanValue.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "val_scan", "{0:N0}")})
        Me.BandedGridColumnScanValue.UnboundExpression = "[design_price] * [qty_scan]"
        Me.BandedGridColumnScanValue.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.BandedGridColumnScanValue.Visible = True
        Me.BandedGridColumnScanValue.Width = 146
        '
        'gridBandKet
        '
        Me.gridBandKet.Caption = "  "
        Me.gridBandKet.Columns.Add(Me.BandedGridColumnDiffQty)
        Me.gridBandKet.Columns.Add(Me.BandedGridColumnDiffValue)
        Me.gridBandKet.Columns.Add(Me.BandedGridColumnNote)
        Me.gridBandKet.Name = "gridBandKet"
        Me.gridBandKet.VisibleIndex = 3
        Me.gridBandKet.Width = 354
        '
        'BandedGridColumnDiffQty
        '
        Me.BandedGridColumnDiffQty.Caption = "Diff Qty"
        Me.BandedGridColumnDiffQty.DisplayFormat.FormatString = "N0"
        Me.BandedGridColumnDiffQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumnDiffQty.FieldName = "qty_diff"
        Me.BandedGridColumnDiffQty.Name = "BandedGridColumnDiffQty"
        Me.BandedGridColumnDiffQty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qty_diff", "{0:N0}")})
        Me.BandedGridColumnDiffQty.UnboundExpression = "[qty_soh]-[qty_scan]"
        Me.BandedGridColumnDiffQty.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.BandedGridColumnDiffQty.Visible = True
        Me.BandedGridColumnDiffQty.Width = 101
        '
        'BandedGridColumnDiffValue
        '
        Me.BandedGridColumnDiffValue.Caption = "Diff Value"
        Me.BandedGridColumnDiffValue.DisplayFormat.FormatString = "N0"
        Me.BandedGridColumnDiffValue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumnDiffValue.FieldName = "val_diff"
        Me.BandedGridColumnDiffValue.Name = "BandedGridColumnDiffValue"
        Me.BandedGridColumnDiffValue.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "val_diff", "{0:N0}")})
        Me.BandedGridColumnDiffValue.UnboundExpression = "[design_price] * [qty_diff]"
        Me.BandedGridColumnDiffValue.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.BandedGridColumnDiffValue.Visible = True
        Me.BandedGridColumnDiffValue.Width = 150
        '
        'BandedGridColumnNote
        '
        Me.BandedGridColumnNote.AppearanceCell.Options.UseTextOptions = True
        Me.BandedGridColumnNote.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BandedGridColumnNote.Caption = "Note"
        Me.BandedGridColumnNote.FieldName = "note"
        Me.BandedGridColumnNote.Name = "BandedGridColumnNote"
        Me.BandedGridColumnNote.UnboundExpression = "Iif([qty_scan] > [qty_soh], 'Over Fisik', Iif([qty_scan] < [qty_soh], 'Selisih', " &
    "''))"
        Me.BandedGridColumnNote.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.BandedGridColumnNote.Visible = True
        Me.BandedGridColumnNote.Width = 103
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        Me.RepositoryItemTextEdit3.NullText = "-"
        '
        'FormStockTakeDet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1042, 583)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.Name = "FormStockTakeDet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Take "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.MERemark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControlTopLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControlTopLeft.ResumeLayout(False)
        Me.PanelControlTopLeft.PerformLayout()
        CType(Me.DECreated.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DECreated.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SLEWHStockSum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.TxtApp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LEAck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LEStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.XTCStockTake, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTCStockTake.ResumeLayout(False)
        Me.XTPScan.ResumeLayout(False)
        CType(Me.GCScan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GVScan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControlNav, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControlNav.ResumeLayout(False)
        Me.PanelControlNav.PerformLayout()
        CType(Me.CheckEditNoTag.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEditReject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtScan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTPSummary.ResumeLayout(False)
        CType(Me.GCSummaryScan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVSummaryScan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTPCondition.ResumeLayout(False)
        CType(Me.GCCat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVCat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTPCompare.ResumeLayout(False)
        CType(Me.GCCompare, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripCompare.ResumeLayout(False)
        CType(Me.BGVCompare, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BtnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents XTCStockTake As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XTPScan As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XTPSummary As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SLEWHStockSum As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView14 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControlTopLeft As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DECreated As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TxtNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControlNav As DevExpress.XtraEditors.PanelControl
    Friend WithEvents TxtScan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GCScan As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVScan As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GCSummaryScan As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVSummaryScan As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BtnSetStatus As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LEStatus As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridColumnNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnSize As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnNoStock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnNoMaster As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnIdPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnIdProduct As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridColumnIsUniqueCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DeleteItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GridColumnIdTransDet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnOK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnReject As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnproductStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnIniqueNotFound As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckEditReject As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GridColumnNoSmr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnIdProductSmr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnProductCodeSmr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnScannedCodeSMR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnNameSMR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnSizeSMR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnQtySMR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnpriceSMR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnAmountSMR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents XTPCondition As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XTPCompare As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GCCat As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVCat As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GCCompare As DevExpress.XtraGrid.GridControl
    Friend WithEvents BGVCompare As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents BandedGridColumnBarcode As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumnCode As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumnName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumnSize As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumnType As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumnPrice As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumnSOHQty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumnSOHValue As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumnScanQty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumnScanValue As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumnDiffQty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumnDiffValue As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumnNote As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MERemark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents CheckEditNoTag As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GridColumnNoTag As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnPrcType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnRemark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnRefNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LEAck As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtApp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ContextMenuStripCompare As ContextMenuStrip
    Friend WithEvents ViewDetailToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SetQtyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents gridBandInfo As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents BandedGridColumnNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBandVolcomQty As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBandStoreQty As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBandKet As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
