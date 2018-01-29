<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormStock))
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.BtnPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.SLEWHStockSum = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView14 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BtnViewRsv = New DevExpress.XtraEditors.SimpleButton()
        Me.CheckEditAllDsgRsv = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtCodeDsgRsv = New DevExpress.XtraEditors.TextEdit()
        Me.TxtNameDsgRsv = New DevExpress.XtraEditors.TextEdit()
        Me.GCRsv = New DevExpress.XtraGrid.GridControl()
        Me.GVRsv = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn27 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn28 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn29 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn30 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnACC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnAccName = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.SLEWHStockSum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEditAllDsgRsv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCodeDsgRsv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNameDsgRsv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCRsv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVRsv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.BtnPrint)
        Me.GroupControl3.Controls.Add(Me.SLEWHStockSum)
        Me.GroupControl3.Controls.Add(Me.BtnViewRsv)
        Me.GroupControl3.Controls.Add(Me.CheckEditAllDsgRsv)
        Me.GroupControl3.Controls.Add(Me.LabelControl11)
        Me.GroupControl3.Controls.Add(Me.LabelControl28)
        Me.GroupControl3.Controls.Add(Me.TxtCodeDsgRsv)
        Me.GroupControl3.Controls.Add(Me.TxtNameDsgRsv)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl3.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(1242, 60)
        Me.GroupControl3.TabIndex = 3
        Me.GroupControl3.Text = "Filter"
        '
        'BtnPrint
        '
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.Location = New System.Drawing.Point(790, 29)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(63, 20)
        Me.BtnPrint.TabIndex = 8901
        Me.BtnPrint.Text = "Print"
        '
        'SLEWHStockSum
        '
        Me.SLEWHStockSum.Location = New System.Drawing.Point(514, 29)
        Me.SLEWHStockSum.Name = "SLEWHStockSum"
        Me.SLEWHStockSum.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SLEWHStockSum.Properties.Appearance.Options.UseFont = True
        Me.SLEWHStockSum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SLEWHStockSum.Properties.View = Me.GridView14
        Me.SLEWHStockSum.Size = New System.Drawing.Size(201, 20)
        Me.SLEWHStockSum.TabIndex = 8900
        '
        'GridView14
        '
        Me.GridView14.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView14.Name = "GridView14"
        Me.GridView14.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView14.OptionsView.ShowGroupPanel = False
        '
        'BtnViewRsv
        '
        Me.BtnViewRsv.Image = CType(resources.GetObject("BtnViewRsv.Image"), System.Drawing.Image)
        Me.BtnViewRsv.Location = New System.Drawing.Point(721, 29)
        Me.BtnViewRsv.Name = "BtnViewRsv"
        Me.BtnViewRsv.Size = New System.Drawing.Size(63, 20)
        Me.BtnViewRsv.TabIndex = 2
        Me.BtnViewRsv.Text = "View"
        '
        'CheckEditAllDsgRsv
        '
        Me.CheckEditAllDsgRsv.Location = New System.Drawing.Point(12, 28)
        Me.CheckEditAllDsgRsv.Name = "CheckEditAllDsgRsv"
        Me.CheckEditAllDsgRsv.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEditAllDsgRsv.Properties.Appearance.Options.UseFont = True
        Me.CheckEditAllDsgRsv.Properties.Caption = "All Design | "
        Me.CheckEditAllDsgRsv.Size = New System.Drawing.Size(83, 19)
        Me.CheckEditAllDsgRsv.TabIndex = 8897
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(469, 32)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl11.TabIndex = 8899
        Me.LabelControl11.Text = "Account"
        '
        'LabelControl28
        '
        Me.LabelControl28.Location = New System.Drawing.Point(101, 32)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl28.TabIndex = 8898
        Me.LabelControl28.Text = "Design"
        '
        'TxtCodeDsgRsv
        '
        Me.TxtCodeDsgRsv.Location = New System.Drawing.Point(137, 29)
        Me.TxtCodeDsgRsv.Name = "TxtCodeDsgRsv"
        Me.TxtCodeDsgRsv.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtCodeDsgRsv.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtCodeDsgRsv.Size = New System.Drawing.Size(98, 20)
        Me.TxtCodeDsgRsv.TabIndex = 8895
        '
        'TxtNameDsgRsv
        '
        Me.TxtNameDsgRsv.Location = New System.Drawing.Point(238, 29)
        Me.TxtNameDsgRsv.Name = "TxtNameDsgRsv"
        Me.TxtNameDsgRsv.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtNameDsgRsv.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtNameDsgRsv.Properties.ReadOnly = True
        Me.TxtNameDsgRsv.Size = New System.Drawing.Size(224, 20)
        Me.TxtNameDsgRsv.TabIndex = 8896
        '
        'GCRsv
        '
        Me.GCRsv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCRsv.Location = New System.Drawing.Point(0, 60)
        Me.GCRsv.MainView = Me.GVRsv
        Me.GCRsv.Name = "GCRsv"
        Me.GCRsv.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit2})
        Me.GCRsv.Size = New System.Drawing.Size(1242, 424)
        Me.GCRsv.TabIndex = 4
        Me.GCRsv.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVRsv})
        '
        'GVRsv
        '
        Me.GVRsv.ColumnPanelRowHeight = 40
        Me.GVRsv.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn8, Me.GridColumn14, Me.GridColumn20, Me.GridColumn21, Me.GridColumn22, Me.GridColumn23, Me.GridColumn24, Me.GridColumn25, Me.GridColumn26, Me.GridColumn27, Me.GridColumn28, Me.GridColumn29, Me.GridColumn30, Me.GridColumnPrice, Me.GridColumnAmount, Me.GridColumnACC, Me.GridColumnAccName})
        Me.GVRsv.GridControl = Me.GCRsv
        Me.GVRsv.GroupCount = 1
        Me.GVRsv.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "1", Me.GridColumn20, "{0:N0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "2", Me.GridColumn21, "{0:N0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "3", Me.GridColumn22, "{0:N0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "4", Me.GridColumn23, "{0:N0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "5", Me.GridColumn24, "{0:N0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "6", Me.GridColumn25, "{0:N0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "7", Me.GridColumn26, "{0:N0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "8", Me.GridColumn27, "{0:N0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "9", Me.GridColumn28, "{0:N0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "0", Me.GridColumn29, "{0:N0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total_qty", Me.GridColumn30, "{0:N0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "amount", Me.GridColumnAmount, "{0:N2}")})
        Me.GVRsv.Name = "GVRsv"
        Me.GVRsv.OptionsBehavior.AutoExpandAllGroups = True
        Me.GVRsv.OptionsPrint.AllowMultilineHeaders = True
        Me.GVRsv.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[True]
        Me.GVRsv.OptionsView.ShowFooter = True
        Me.GVRsv.OptionsView.ShowGroupedColumns = True
        Me.GVRsv.OptionsView.ShowGroupPanel = False
        Me.GVRsv.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumnACC, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "CODE"
        Me.GridColumn2.FieldName = "code"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        Me.GridColumn2.Width = 141
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "STYLE"
        Me.GridColumn8.FieldName = "name"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 3
        Me.GridColumn8.Width = 196
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "SIZETYPE"
        Me.GridColumn14.FieldName = "sizetype"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 4
        Me.GridColumn14.Width = 67
        '
        'GridColumn20
        '
        Me.GridColumn20.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn20.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn20.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn20.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn20.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.GridColumn20.DisplayFormat.FormatString = "N0"
        Me.GridColumn20.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn20.FieldName = "1"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "1", "{0:N0}")})
        Me.GridColumn20.Visible = True
        Me.GridColumn20.VisibleIndex = 5
        Me.GridColumn20.Width = 41
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        Me.RepositoryItemTextEdit2.NullText = "-"
        '
        'GridColumn21
        '
        Me.GridColumn21.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn21.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn21.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn21.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn21.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.GridColumn21.DisplayFormat.FormatString = "N0"
        Me.GridColumn21.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn21.FieldName = "2"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "2", "{0:N0}")})
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 6
        Me.GridColumn21.Width = 36
        '
        'GridColumn22
        '
        Me.GridColumn22.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn22.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn22.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn22.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn22.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.GridColumn22.DisplayFormat.FormatString = "N0"
        Me.GridColumn22.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn22.FieldName = "3"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "3", "{0:N0}")})
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 7
        Me.GridColumn22.Width = 35
        '
        'GridColumn23
        '
        Me.GridColumn23.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn23.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn23.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn23.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn23.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.GridColumn23.DisplayFormat.FormatString = "N0"
        Me.GridColumn23.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn23.FieldName = "4"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "4", "{0:N0}")})
        Me.GridColumn23.Visible = True
        Me.GridColumn23.VisibleIndex = 8
        Me.GridColumn23.Width = 33
        '
        'GridColumn24
        '
        Me.GridColumn24.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn24.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn24.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn24.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn24.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.GridColumn24.DisplayFormat.FormatString = "N0"
        Me.GridColumn24.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn24.FieldName = "5"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "5", "{0:N0}")})
        Me.GridColumn24.Visible = True
        Me.GridColumn24.VisibleIndex = 9
        Me.GridColumn24.Width = 39
        '
        'GridColumn25
        '
        Me.GridColumn25.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn25.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn25.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn25.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn25.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.GridColumn25.DisplayFormat.FormatString = "N0"
        Me.GridColumn25.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn25.FieldName = "6"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "6", "{0:N0}")})
        Me.GridColumn25.Visible = True
        Me.GridColumn25.VisibleIndex = 10
        Me.GridColumn25.Width = 45
        '
        'GridColumn26
        '
        Me.GridColumn26.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn26.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn26.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn26.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn26.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.GridColumn26.DisplayFormat.FormatString = "N0"
        Me.GridColumn26.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn26.FieldName = "7"
        Me.GridColumn26.Name = "GridColumn26"
        Me.GridColumn26.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "7", "{0:N0}")})
        Me.GridColumn26.Visible = True
        Me.GridColumn26.VisibleIndex = 11
        Me.GridColumn26.Width = 48
        '
        'GridColumn27
        '
        Me.GridColumn27.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn27.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn27.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn27.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn27.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.GridColumn27.DisplayFormat.FormatString = "N0"
        Me.GridColumn27.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn27.FieldName = "8"
        Me.GridColumn27.Name = "GridColumn27"
        Me.GridColumn27.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "8", "{0:N0}")})
        Me.GridColumn27.Visible = True
        Me.GridColumn27.VisibleIndex = 12
        Me.GridColumn27.Width = 43
        '
        'GridColumn28
        '
        Me.GridColumn28.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn28.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn28.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn28.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn28.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.GridColumn28.DisplayFormat.FormatString = "N0"
        Me.GridColumn28.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn28.FieldName = "9"
        Me.GridColumn28.Name = "GridColumn28"
        Me.GridColumn28.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "9", "{0:N0}")})
        Me.GridColumn28.Visible = True
        Me.GridColumn28.VisibleIndex = 13
        Me.GridColumn28.Width = 44
        '
        'GridColumn29
        '
        Me.GridColumn29.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn29.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn29.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn29.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn29.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.GridColumn29.DisplayFormat.FormatString = "N0"
        Me.GridColumn29.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn29.FieldName = "0"
        Me.GridColumn29.Name = "GridColumn29"
        Me.GridColumn29.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "0", "{0:N0}")})
        Me.GridColumn29.Visible = True
        Me.GridColumn29.VisibleIndex = 14
        Me.GridColumn29.Width = 43
        '
        'GridColumn30
        '
        Me.GridColumn30.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn30.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn30.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn30.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn30.Caption = "TTL"
        Me.GridColumn30.DisplayFormat.FormatString = "N0"
        Me.GridColumn30.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn30.FieldName = "total_qty"
        Me.GridColumn30.Name = "GridColumn30"
        Me.GridColumn30.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total_qty", "{0:N0}")})
        Me.GridColumn30.Visible = True
        Me.GridColumn30.VisibleIndex = 15
        Me.GridColumn30.Width = 57
        '
        'GridColumnPrice
        '
        Me.GridColumnPrice.Caption = "PRICE"
        Me.GridColumnPrice.DisplayFormat.FormatString = "N2"
        Me.GridColumnPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumnPrice.FieldName = "design_price"
        Me.GridColumnPrice.Name = "GridColumnPrice"
        Me.GridColumnPrice.Visible = True
        Me.GridColumnPrice.VisibleIndex = 16
        Me.GridColumnPrice.Width = 138
        '
        'GridColumnAmount
        '
        Me.GridColumnAmount.Caption = "AMOUNT"
        Me.GridColumnAmount.DisplayFormat.FormatString = "N2"
        Me.GridColumnAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumnAmount.FieldName = "amount"
        Me.GridColumnAmount.Name = "GridColumnAmount"
        Me.GridColumnAmount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "amount", "{0:N2}")})
        Me.GridColumnAmount.UnboundExpression = "[total_qty] * [design_price]"
        Me.GridColumnAmount.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.GridColumnAmount.Visible = True
        Me.GridColumnAmount.VisibleIndex = 17
        Me.GridColumnAmount.Width = 317
        '
        'GridColumnACC
        '
        Me.GridColumnACC.Caption = "ACCOUNT"
        Me.GridColumnACC.FieldName = "comp_number"
        Me.GridColumnACC.Name = "GridColumnACC"
        Me.GridColumnACC.Visible = True
        Me.GridColumnACC.VisibleIndex = 0
        Me.GridColumnACC.Width = 68
        '
        'GridColumnAccName
        '
        Me.GridColumnAccName.Caption = "ACCOUNT NAME"
        Me.GridColumnAccName.FieldName = "comp_name"
        Me.GridColumnAccName.Name = "GridColumnAccName"
        Me.GridColumnAccName.Visible = True
        Me.GridColumnAccName.VisibleIndex = 1
        Me.GridColumnAccName.Width = 225
        '
        'FormStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1242, 484)
        Me.Controls.Add(Me.GCRsv)
        Me.Controls.Add(Me.GroupControl3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock"
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.SLEWHStockSum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEditAllDsgRsv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCodeDsgRsv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNameDsgRsv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCRsv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVRsv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BtnViewRsv As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CheckEditAllDsgRsv As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtCodeDsgRsv As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtNameDsgRsv As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GCRsv As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVRsv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn27 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn28 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn29 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn30 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SLEWHStockSum As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView14 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BtnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumnPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnACC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnAccName As DevExpress.XtraGrid.Columns.GridColumn
End Class
