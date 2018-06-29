<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVerStockTakeCombine
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormVerStockTakeCombine))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.SLEWHStockSum = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView14 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.BtnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnOK = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.MERemark = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.GCCheck = New DevExpress.XtraGrid.GridControl()
        Me.GVCheck = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumnNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnResult = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridColumnId = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SLEWHStockSum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.MERemark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.CheckEdit1)
        Me.PanelControl1.Controls.Add(Me.SLEWHStockSum)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(484, 42)
        Me.PanelControl1.TabIndex = 2
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(391, 13)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Select All"
        Me.CheckEdit1.Size = New System.Drawing.Size(75, 19)
        Me.CheckEdit1.TabIndex = 8906
        '
        'SLEWHStockSum
        '
        Me.SLEWHStockSum.Location = New System.Drawing.Point(89, 12)
        Me.SLEWHStockSum.Name = "SLEWHStockSum"
        Me.SLEWHStockSum.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SLEWHStockSum.Properties.Appearance.Options.UseFont = True
        Me.SLEWHStockSum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SLEWHStockSum.Properties.View = Me.GridView14
        Me.SLEWHStockSum.Size = New System.Drawing.Size(296, 20)
        Me.SLEWHStockSum.TabIndex = 8905
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
        Me.LabelControl1.Location = New System.Drawing.Point(12, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl1.TabIndex = 8904
        Me.LabelControl1.Text = "Select Account"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.BtnCancel)
        Me.PanelControl2.Controls.Add(Me.BtnOK)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 336)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(484, 39)
        Me.PanelControl2.TabIndex = 3
        '
        'BtnCancel
        '
        Me.BtnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(318, 2)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(89, 35)
        Me.BtnCancel.TabIndex = 1
        Me.BtnCancel.Text = "Cancel"
        '
        'BtnOK
        '
        Me.BtnOK.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnOK.Image = CType(resources.GetObject("BtnOK.Image"), System.Drawing.Image)
        Me.BtnOK.Location = New System.Drawing.Point(407, 2)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(75, 35)
        Me.BtnOK.TabIndex = 0
        Me.BtnOK.Text = "OK"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.MERemark)
        Me.PanelControl3.Controls.Add(Me.LabelControl2)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl3.Location = New System.Drawing.Point(0, 281)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(484, 55)
        Me.PanelControl3.TabIndex = 5
        '
        'MERemark
        '
        Me.MERemark.Location = New System.Drawing.Point(68, 10)
        Me.MERemark.Name = "MERemark"
        Me.MERemark.Size = New System.Drawing.Size(398, 34)
        Me.MERemark.TabIndex = 8908
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl2.TabIndex = 8907
        Me.LabelControl2.Text = "Remark"
        '
        'GCCheck
        '
        Me.GCCheck.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCCheck.Location = New System.Drawing.Point(0, 42)
        Me.GCCheck.MainView = Me.GVCheck
        Me.GCCheck.Name = "GCCheck"
        Me.GCCheck.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.GCCheck.Size = New System.Drawing.Size(484, 239)
        Me.GCCheck.TabIndex = 6
        Me.GCCheck.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVCheck})
        '
        'GVCheck
        '
        Me.GVCheck.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumnNumber, Me.GridColumnQty, Me.GridColumnResult, Me.GridColumnId})
        Me.GVCheck.GridControl = Me.GCCheck
        Me.GVCheck.Name = "GVCheck"
        Me.GVCheck.OptionsView.ShowFooter = True
        Me.GVCheck.OptionsView.ShowGroupPanel = False
        '
        'GridColumnNumber
        '
        Me.GridColumnNumber.Caption = "Number"
        Me.GridColumnNumber.FieldName = "st_trans_number"
        Me.GridColumnNumber.Name = "GridColumnNumber"
        Me.GridColumnNumber.OptionsColumn.AllowEdit = False
        Me.GridColumnNumber.Visible = True
        Me.GridColumnNumber.VisibleIndex = 0
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
        Me.GridColumnQty.VisibleIndex = 1
        '
        'GridColumnResult
        '
        Me.GridColumnResult.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumnResult.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumnResult.Caption = "Select"
        Me.GridColumnResult.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GridColumnResult.FieldName = "is_select"
        Me.GridColumnResult.Name = "GridColumnResult"
        Me.GridColumnResult.Visible = True
        Me.GridColumnResult.VisibleIndex = 2
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.ValueChecked = "Yes"
        Me.RepositoryItemCheckEdit1.ValueUnchecked = "No"
        '
        'GridColumnId
        '
        Me.GridColumnId.Caption = "Id"
        Me.GridColumnId.FieldName = "id_st_trans"
        Me.GridColumnId.Name = "GridColumnId"
        Me.GridColumnId.OptionsColumn.AllowEdit = False
        '
        'FormVerStockTakeCombine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 375)
        Me.Controls.Add(Me.GCCheck)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormVerStockTakeCombine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create Combine Stock Take"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SLEWHStockSum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.MERemark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCCheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVCheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SLEWHStockSum As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView14 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BtnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents MERemark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GCCheck As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVCheck As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumnNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnResult As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridColumnId As DevExpress.XtraGrid.Columns.GridColumn
End Class
