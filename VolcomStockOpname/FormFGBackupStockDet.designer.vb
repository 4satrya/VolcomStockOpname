﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormFGBackupStockDet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFGBackupStockDet))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.CESelectAll = New DevExpress.XtraEditors.CheckEdit()
        Me.BtnOpenFileLoc = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnBOFData = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.DEStock = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.GCData = New DevExpress.XtraGrid.GridControl()
        Me.GVData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnSOH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridColumnDrawer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnCat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnCompCat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XTCDetail = New DevExpress.XtraTab.XtraTabControl()
        Me.XTPSummary = New DevExpress.XtraTab.XtraTabPage()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.CESelectAll.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.DEStock.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEStock.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XTCDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTCDetail.SuspendLayout()
        Me.XTPSummary.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.SimpleButton1)
        Me.PanelControl1.Controls.Add(Me.CESelectAll)
        Me.PanelControl1.Controls.Add(Me.BtnOpenFileLoc)
        Me.PanelControl1.Controls.Add(Me.BtnBOFData)
        Me.PanelControl1.Controls.Add(Me.BtnSave)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 416)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(778, 40)
        Me.PanelControl1.TabIndex = 2
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Dock = System.Windows.Forms.DockStyle.Right
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(285, 0)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(111, 40)
        Me.SimpleButton1.TabIndex = 3
        Me.SimpleButton1.Text = "Setup Data"
        '
        'CESelectAll
        '
        Me.CESelectAll.Location = New System.Drawing.Point(12, 10)
        Me.CESelectAll.Name = "CESelectAll"
        Me.CESelectAll.Properties.Caption = "Select All"
        Me.CESelectAll.Size = New System.Drawing.Size(75, 19)
        Me.CESelectAll.TabIndex = 2
        '
        'BtnOpenFileLoc
        '
        Me.BtnOpenFileLoc.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnOpenFileLoc.Image = CType(resources.GetObject("BtnOpenFileLoc.Image"), System.Drawing.Image)
        Me.BtnOpenFileLoc.Location = New System.Drawing.Point(396, 0)
        Me.BtnOpenFileLoc.Name = "BtnOpenFileLoc"
        Me.BtnOpenFileLoc.Size = New System.Drawing.Size(136, 40)
        Me.BtnOpenFileLoc.TabIndex = 1
        Me.BtnOpenFileLoc.Text = "Open File Location"
        '
        'BtnBOFData
        '
        Me.BtnBOFData.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnBOFData.Image = CType(resources.GetObject("BtnBOFData.Image"), System.Drawing.Image)
        Me.BtnBOFData.Location = New System.Drawing.Point(532, 0)
        Me.BtnBOFData.Name = "BtnBOFData"
        Me.BtnBOFData.Size = New System.Drawing.Size(123, 40)
        Me.BtnBOFData.TabIndex = 4
        Me.BtnBOFData.Text = "Import SOH BOF"
        '
        'BtnSave
        '
        Me.BtnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(655, 0)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(123, 40)
        Me.BtnSave.TabIndex = 0
        Me.BtnSave.Text = "Download Data"
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.DEStock)
        Me.PanelControl2.Controls.Add(Me.LabelControl2)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(778, 52)
        Me.PanelControl2.TabIndex = 0
        '
        'DEStock
        '
        Me.DEStock.EditValue = Nothing
        Me.DEStock.Location = New System.Drawing.Point(98, 15)
        Me.DEStock.Name = "DEStock"
        Me.DEStock.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.DEStock.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DEStock.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DEStock.Properties.DisplayFormat.FormatString = "dd\/MM\/yyyy"
        Me.DEStock.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DEStock.Properties.Mask.EditMask = "dd\/MM\/yyyy"
        Me.DEStock.Size = New System.Drawing.Size(220, 20)
        Me.DEStock.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(22, 18)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Stock Date"
        '
        'GCData
        '
        Me.GCData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCData.Location = New System.Drawing.Point(0, 0)
        Me.GCData.MainView = Me.GVData
        Me.GCData.Name = "GCData"
        Me.GCData.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.GCData.Size = New System.Drawing.Size(772, 336)
        Me.GCData.TabIndex = 1
        Me.GCData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVData})
        '
        'GVData
        '
        Me.GVData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumnSOH, Me.GridColumn5, Me.GridColumnDrawer, Me.GridColumnCat, Me.GridColumnCompCat})
        Me.GVData.GridControl = Me.GCData
        Me.GVData.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qty_soh", Me.GridColumnSOH, "{0:N0}")})
        Me.GVData.Name = "GVData"
        Me.GVData.OptionsBehavior.AutoExpandAllGroups = True
        Me.GVData.OptionsFind.AlwaysVisible = True
        Me.GVData.OptionsView.ShowFooter = True
        Me.GVData.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Id Comp"
        Me.GridColumn1.FieldName = "id_comp"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Account#"
        Me.GridColumn2.FieldName = "comp_number"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 176
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Account Description"
        Me.GridColumn3.FieldName = "comp_name"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 913
        '
        'GridColumnSOH
        '
        Me.GridColumnSOH.Caption = "SOH"
        Me.GridColumnSOH.DisplayFormat.FormatString = "N0"
        Me.GridColumnSOH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumnSOH.FieldName = "qty_soh"
        Me.GridColumnSOH.Name = "GridColumnSOH"
        Me.GridColumnSOH.OptionsColumn.AllowEdit = False
        Me.GridColumnSOH.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qty_soh", "{0:N0}")})
        Me.GridColumnSOH.Visible = True
        Me.GridColumnSOH.VisibleIndex = 3
        Me.GridColumnSOH.Width = 236
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "Select"
        Me.GridColumn5.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GridColumn5.FieldName = "is_select"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 190
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.ValueChecked = "Yes"
        Me.RepositoryItemCheckEdit1.ValueUnchecked = "No"
        '
        'GridColumnDrawer
        '
        Me.GridColumnDrawer.Caption = "Drawer"
        Me.GridColumnDrawer.FieldName = "id_drawer_def"
        Me.GridColumnDrawer.Name = "GridColumnDrawer"
        '
        'GridColumnCat
        '
        Me.GridColumnCat.Caption = "Cat"
        Me.GridColumnCat.FieldName = "id_comp_cat"
        Me.GridColumnCat.Name = "GridColumnCat"
        '
        'GridColumnCompCat
        '
        Me.GridColumnCompCat.Caption = "Category"
        Me.GridColumnCompCat.FieldName = "comp_cat"
        Me.GridColumnCompCat.Name = "GridColumnCompCat"
        Me.GridColumnCompCat.Visible = True
        Me.GridColumnCompCat.VisibleIndex = 2
        Me.GridColumnCompCat.Width = 101
        '
        'XTCDetail
        '
        Me.XTCDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XTCDetail.Location = New System.Drawing.Point(0, 52)
        Me.XTCDetail.Name = "XTCDetail"
        Me.XTCDetail.SelectedTabPage = Me.XTPSummary
        Me.XTCDetail.Size = New System.Drawing.Size(778, 364)
        Me.XTCDetail.TabIndex = 3
        Me.XTCDetail.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XTPSummary})
        '
        'XTPSummary
        '
        Me.XTPSummary.Controls.Add(Me.GCData)
        Me.XTPSummary.Name = "XTPSummary"
        Me.XTPSummary.Size = New System.Drawing.Size(772, 336)
        Me.XTPSummary.Text = "Summary"
        '
        'FormFGBackupStockDet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 456)
        Me.Controls.Add(Me.XTCDetail)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.MinimizeBox = False
        Me.Name = "FormFGBackupStockDet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detail"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.CESelectAll.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.DEStock.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEStock.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XTCDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTCDetail.ResumeLayout(False)
        Me.XTPSummary.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents DEStock As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GCData As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BtnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnOpenFileLoc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CESelectAll As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnSOH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents XTCDetail As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XTPSummary As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridColumnDrawer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnCat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnCompCat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnBOFData As DevExpress.XtraEditors.SimpleButton
End Class
