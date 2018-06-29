<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHome
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
        Dim TileViewItemElement1 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement2 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelPeriodName = New DevExpress.XtraEditors.LabelControl()
        Me.GCConn = New DevExpress.XtraGrid.GridControl()
        Me.GVCon = New DevExpress.XtraGrid.Views.Tile.TileView()
        Me.TileViewColumnAccount = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TileViewColumnAccountDesc = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TileViewColumnDBName = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TileViewColumnAcc = New DevExpress.XtraGrid.Columns.TileViewColumn()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GCConn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVCon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.LabelPeriodName)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(864, 67)
        Me.PanelControl1.TabIndex = 0
        '
        'LabelPeriodName
        '
        Me.LabelPeriodName.Appearance.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPeriodName.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelPeriodName.Location = New System.Drawing.Point(0, 0)
        Me.LabelPeriodName.Name = "LabelPeriodName"
        Me.LabelPeriodName.Padding = New System.Windows.Forms.Padding(12)
        Me.LabelPeriodName.Size = New System.Drawing.Size(304, 64)
        Me.LabelPeriodName.TabIndex = 1
        Me.LabelPeriodName.Text = "Period is not available"
        '
        'GCConn
        '
        Me.GCConn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCConn.Location = New System.Drawing.Point(0, 67)
        Me.GCConn.MainView = Me.GVCon
        Me.GCConn.Name = "GCConn"
        Me.GCConn.Size = New System.Drawing.Size(864, 481)
        Me.GCConn.TabIndex = 1
        Me.GCConn.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVCon})
        '
        'GVCon
        '
        Me.GVCon.Appearance.ItemNormal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GVCon.Appearance.ItemNormal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GVCon.Appearance.ItemNormal.Options.UseBackColor = True
        Me.GVCon.Appearance.ItemNormal.Options.UseFont = True
        Me.GVCon.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.TileViewColumnAccount, Me.TileViewColumnAccountDesc, Me.TileViewColumnDBName, Me.TileViewColumnAcc})
        Me.GVCon.GridControl = Me.GCConn
        Me.GVCon.Name = "GVCon"
        Me.GVCon.OptionsBehavior.Editable = False
        Me.GVCon.OptionsTiles.ItemSize = New System.Drawing.Size(360, 180)
        TileViewItemElement1.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI Semibold", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileViewItemElement1.Appearance.Normal.ForeColor = System.Drawing.Color.White
        TileViewItemElement1.Appearance.Normal.Options.UseFont = True
        TileViewItemElement1.Appearance.Normal.Options.UseForeColor = True
        TileViewItemElement1.Column = Me.TileViewColumnAccount
        TileViewItemElement1.Text = "TileViewColumnAccount"
        TileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        TileViewItemElement2.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileViewItemElement2.Appearance.Normal.ForeColor = System.Drawing.Color.White
        TileViewItemElement2.Appearance.Normal.Options.UseFont = True
        TileViewItemElement2.Appearance.Normal.Options.UseForeColor = True
        TileViewItemElement2.Column = Me.TileViewColumnAccountDesc
        TileViewItemElement2.Text = "TileViewColumnAccountDesc"
        TileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement2.TextLocation = New System.Drawing.Point(0, 50)
        Me.GVCon.TileTemplate.Add(TileViewItemElement1)
        Me.GVCon.TileTemplate.Add(TileViewItemElement2)
        '
        'TileViewColumnAccount
        '
        Me.TileViewColumnAccount.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.TileViewColumnAccount.AppearanceCell.Options.UseForeColor = True
        Me.TileViewColumnAccount.Caption = "Account Code"
        Me.TileViewColumnAccount.FieldName = "account"
        Me.TileViewColumnAccount.Name = "TileViewColumnAccount"
        Me.TileViewColumnAccount.Visible = True
        Me.TileViewColumnAccount.VisibleIndex = 0
        '
        'TileViewColumnAccountDesc
        '
        Me.TileViewColumnAccountDesc.Caption = "Account Description"
        Me.TileViewColumnAccountDesc.FieldName = "account_desc"
        Me.TileViewColumnAccountDesc.Name = "TileViewColumnAccountDesc"
        Me.TileViewColumnAccountDesc.Visible = True
        Me.TileViewColumnAccountDesc.VisibleIndex = 1
        '
        'TileViewColumnDBName
        '
        Me.TileViewColumnDBName.Caption = "Database"
        Me.TileViewColumnDBName.FieldName = "db_name"
        Me.TileViewColumnDBName.Name = "TileViewColumnDBName"
        Me.TileViewColumnDBName.Visible = True
        Me.TileViewColumnDBName.VisibleIndex = 2
        '
        'TileViewColumnAcc
        '
        Me.TileViewColumnAcc.Caption = "Account"
        Me.TileViewColumnAcc.FieldName = "acc"
        Me.TileViewColumnAcc.Name = "TileViewColumnAcc"
        Me.TileViewColumnAcc.Visible = True
        Me.TileViewColumnAcc.VisibleIndex = 3
        '
        'FormHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 548)
        Me.Controls.Add(Me.GCConn)
        Me.Controls.Add(Me.PanelControl1)
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "FormHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GCConn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVCon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelPeriodName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GCConn As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVCon As DevExpress.XtraGrid.Views.Tile.TileView
    Friend WithEvents TileViewColumnAccount As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TileViewColumnAccountDesc As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TileViewColumnDBName As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TileViewColumnAcc As DevExpress.XtraGrid.Columns.TileViewColumn
End Class
