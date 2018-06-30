<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDatabaseUI
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
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GCPeriode = New DevExpress.XtraGrid.GridControl()
        Me.GVPeriode = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GCDetail = New DevExpress.XtraGrid.GridControl()
        Me.GVDetail = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetAsDefaultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridColumnIdPeriode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumndesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnis_default = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnIdPer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnIdDet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnacc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GCPeriode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVPeriode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GroupControl1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GroupControl2)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(865, 505)
        Me.SplitContainerControl1.SplitterPosition = 257
        Me.SplitContainerControl1.TabIndex = 0
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.GCPeriode)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(865, 257)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Periode"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.GCDetail)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(865, 243)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Detail"
        '
        'GCPeriode
        '
        Me.GCPeriode.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GCPeriode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCPeriode.Location = New System.Drawing.Point(2, 20)
        Me.GCPeriode.MainView = Me.GVPeriode
        Me.GCPeriode.Name = "GCPeriode"
        Me.GCPeriode.Size = New System.Drawing.Size(861, 235)
        Me.GCPeriode.TabIndex = 0
        Me.GCPeriode.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVPeriode})
        '
        'GVPeriode
        '
        Me.GVPeriode.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumnIdPeriode, Me.GridColumndesc, Me.GridColumn1, Me.GridColumnis_default})
        Me.GVPeriode.GridControl = Me.GCPeriode
        Me.GVPeriode.Name = "GVPeriode"
        Me.GVPeriode.OptionsBehavior.Editable = False
        Me.GVPeriode.OptionsView.ShowGroupPanel = False
        '
        'GCDetail
        '
        Me.GCDetail.ContextMenuStrip = Me.ContextMenuStrip2
        Me.GCDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCDetail.Location = New System.Drawing.Point(2, 20)
        Me.GCDetail.MainView = Me.GVDetail
        Me.GCDetail.Name = "GCDetail"
        Me.GCDetail.Size = New System.Drawing.Size(861, 221)
        Me.GCDetail.TabIndex = 1
        Me.GCDetail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVDetail})
        '
        'GVDetail
        '
        Me.GVDetail.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumnIdPer, Me.GridColumnIdDet, Me.GridColumnacc, Me.GridColumn2, Me.GridColumn3})
        Me.GVDetail.GridControl = Me.GCDetail
        Me.GVDetail.Name = "GVDetail"
        Me.GVDetail.OptionsBehavior.Editable = False
        Me.GVDetail.OptionsView.ShowGroupPanel = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.SetAsDefaultToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(145, 92)
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem1, Me.EditToolStripMenuItem1, Me.DeleteToolStripMenuItem1})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(108, 70)
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'SetAsDefaultToolStripMenuItem
        '
        Me.SetAsDefaultToolStripMenuItem.Name = "SetAsDefaultToolStripMenuItem"
        Me.SetAsDefaultToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.SetAsDefaultToolStripMenuItem.Text = "Set as default"
        '
        'AddToolStripMenuItem1
        '
        Me.AddToolStripMenuItem1.Name = "AddToolStripMenuItem1"
        Me.AddToolStripMenuItem1.Size = New System.Drawing.Size(107, 22)
        Me.AddToolStripMenuItem1.Text = "Add"
        '
        'EditToolStripMenuItem1
        '
        Me.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1"
        Me.EditToolStripMenuItem1.Size = New System.Drawing.Size(107, 22)
        Me.EditToolStripMenuItem1.Text = "Edit"
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem1.Text = "Delete"
        '
        'GridColumnIdPeriode
        '
        Me.GridColumnIdPeriode.Caption = "Id Periode"
        Me.GridColumnIdPeriode.FieldName = "id_periode"
        Me.GridColumnIdPeriode.Name = "GridColumnIdPeriode"
        '
        'GridColumndesc
        '
        Me.GridColumndesc.Caption = "Description"
        Me.GridColumndesc.FieldName = "description"
        Me.GridColumndesc.Name = "GridColumndesc"
        Me.GridColumndesc.Visible = True
        Me.GridColumndesc.VisibleIndex = 0
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Default"
        Me.GridColumn1.FieldName = "is_default_v"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.UnboundExpression = "Iif([is_default]=1,'Yes','No')"
        Me.GridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        '
        'GridColumnis_default
        '
        Me.GridColumnis_default.Caption = "is_default"
        Me.GridColumnis_default.FieldName = "is_default"
        Me.GridColumnis_default.Name = "GridColumnis_default"
        '
        'GridColumnIdPer
        '
        Me.GridColumnIdPer.Caption = "GridColumn2"
        Me.GridColumnIdPer.FieldName = "id_periode"
        Me.GridColumnIdPer.Name = "GridColumnIdPer"
        '
        'GridColumnIdDet
        '
        Me.GridColumnIdDet.Caption = "GridColumn2"
        Me.GridColumnIdDet.FieldName = "id_periode_det"
        Me.GridColumnIdDet.Name = "GridColumnIdDet"
        '
        'GridColumnacc
        '
        Me.GridColumnacc.Caption = "Account"
        Me.GridColumnacc.FieldName = "account"
        Me.GridColumnacc.Name = "GridColumnacc"
        Me.GridColumnacc.Visible = True
        Me.GridColumnacc.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Account Description"
        Me.GridColumn2.FieldName = "account_desc"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "DB"
        Me.GridColumn3.FieldName = "db_name"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'FormDatabaseUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 505)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.MinimizeBox = False
        Me.Name = "FormDatabaseUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database Setup"
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GCPeriode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVPeriode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GCPeriode As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVPeriode As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GCDetail As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVDetail As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SetAsDefaultToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GridColumnIdPeriode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumndesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnis_default As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnIdPer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnIdDet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnacc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
End Class
