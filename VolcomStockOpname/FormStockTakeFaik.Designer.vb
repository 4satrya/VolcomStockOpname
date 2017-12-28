<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStockTakeFaik
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormStockTakeFaik))
        Me.CheckEditNoStock = New DevExpress.XtraEditors.CheckEdit()
        Me.PanelControlTop = New DevExpress.XtraEditors.PanelControl()
        Me.CheckEditSale = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEditNoMaster = New DevExpress.XtraEditors.CheckEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelControlBottom = New DevExpress.XtraEditors.PanelControl()
        Me.BtnOk = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckEditReject = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEditUniqueNotFound = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.CheckEditNoStock.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControlTop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControlTop.SuspendLayout()
        CType(Me.CheckEditSale.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEditNoMaster.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControlBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControlBottom.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEditReject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEditUniqueNotFound.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckEditNoStock
        '
        Me.CheckEditNoStock.Location = New System.Drawing.Point(15, 28)
        Me.CheckEditNoStock.Name = "CheckEditNoStock"
        Me.CheckEditNoStock.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEditNoStock.Properties.Appearance.Options.UseFont = True
        Me.CheckEditNoStock.Properties.Caption = "No Stock"
        Me.CheckEditNoStock.Size = New System.Drawing.Size(75, 20)
        Me.CheckEditNoStock.TabIndex = 0
        '
        'PanelControlTop
        '
        Me.PanelControlTop.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControlTop.Controls.Add(Me.CheckEditUniqueNotFound)
        Me.PanelControlTop.Controls.Add(Me.CheckEditReject)
        Me.PanelControlTop.Controls.Add(Me.CheckEditSale)
        Me.PanelControlTop.Controls.Add(Me.CheckEditNoMaster)
        Me.PanelControlTop.Controls.Add(Me.Label1)
        Me.PanelControlTop.Controls.Add(Me.CheckEditNoStock)
        Me.PanelControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControlTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelControlTop.Name = "PanelControlTop"
        Me.PanelControlTop.Size = New System.Drawing.Size(405, 86)
        Me.PanelControlTop.TabIndex = 1
        '
        'CheckEditSale
        '
        Me.CheckEditSale.Location = New System.Drawing.Point(241, 28)
        Me.CheckEditSale.Name = "CheckEditSale"
        Me.CheckEditSale.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEditSale.Properties.Appearance.Options.UseFont = True
        Me.CheckEditSale.Properties.Caption = "Sale"
        Me.CheckEditSale.Size = New System.Drawing.Size(64, 20)
        Me.CheckEditSale.TabIndex = 2
        '
        'CheckEditNoMaster
        '
        Me.CheckEditNoMaster.Location = New System.Drawing.Point(96, 28)
        Me.CheckEditNoMaster.Name = "CheckEditNoMaster"
        Me.CheckEditNoMaster.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEditNoMaster.Properties.Appearance.Options.UseFont = True
        Me.CheckEditNoMaster.Properties.Caption = "Tidak Ada di Master"
        Me.CheckEditNoMaster.Size = New System.Drawing.Size(152, 20)
        Me.CheckEditNoMaster.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reason : "
        '
        'PanelControlBottom
        '
        Me.PanelControlBottom.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControlBottom.Controls.Add(Me.BtnOk)
        Me.PanelControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControlBottom.Location = New System.Drawing.Point(0, 227)
        Me.PanelControlBottom.Name = "PanelControlBottom"
        Me.PanelControlBottom.Size = New System.Drawing.Size(405, 35)
        Me.PanelControlBottom.TabIndex = 2
        '
        'BtnOk
        '
        Me.BtnOk.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnOk.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOk.Appearance.Options.UseBackColor = True
        Me.BtnOk.Appearance.Options.UseFont = True
        Me.BtnOk.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnOk.Image = CType(resources.GetObject("BtnOk.Image"), System.Drawing.Image)
        Me.BtnOk.Location = New System.Drawing.Point(330, 0)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(75, 35)
        Me.BtnOk.TabIndex = 0
        Me.BtnOk.Text = "OK"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.TextEdit3)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.TextEdit2)
        Me.GroupControl1.Controls.Add(Me.TextEdit1)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Enabled = False
        Me.GroupControl1.Location = New System.Drawing.Point(0, 86)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(405, 141)
        Me.GroupControl1.TabIndex = 3
        Me.GroupControl1.Text = "Unidentified Product"
        '
        'TextEdit3
        '
        Me.TextEdit3.Location = New System.Drawing.Point(15, 91)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit3.Properties.Appearance.Options.UseFont = True
        Me.TextEdit3.Size = New System.Drawing.Size(373, 22)
        Me.TextEdit3.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(283, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Size"
        '
        'TextEdit2
        '
        Me.TextEdit2.Location = New System.Drawing.Point(286, 47)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit2.Properties.Appearance.Options.UseFont = True
        Me.TextEdit2.Size = New System.Drawing.Size(102, 22)
        Me.TextEdit2.TabIndex = 5
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(15, 47)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit1.Properties.Appearance.Options.UseFont = True
        Me.TextEdit1.Size = New System.Drawing.Size(267, 22)
        Me.TextEdit1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Code"
        '
        'CheckEditReject
        '
        Me.CheckEditReject.Location = New System.Drawing.Point(302, 28)
        Me.CheckEditReject.Name = "CheckEditReject"
        Me.CheckEditReject.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEditReject.Properties.Appearance.Options.UseFont = True
        Me.CheckEditReject.Properties.Caption = "Reject"
        Me.CheckEditReject.Size = New System.Drawing.Size(64, 20)
        Me.CheckEditReject.TabIndex = 3
        '
        'CheckEditUniqueNotFound
        '
        Me.CheckEditUniqueNotFound.Location = New System.Drawing.Point(15, 54)
        Me.CheckEditUniqueNotFound.Name = "CheckEditUniqueNotFound"
        Me.CheckEditUniqueNotFound.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEditUniqueNotFound.Properties.Appearance.Options.UseFont = True
        Me.CheckEditUniqueNotFound.Properties.Caption = "Unique not Found"
        Me.CheckEditUniqueNotFound.Size = New System.Drawing.Size(144, 20)
        Me.CheckEditUniqueNotFound.TabIndex = 4
        '
        'FormStockTakeFaik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 262)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.PanelControlBottom)
        Me.Controls.Add(Me.PanelControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.LookAndFeel.SkinName = "Office 2013 Dark Gray"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormStockTakeFaik"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scan Failed"
        CType(Me.CheckEditNoStock.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControlTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControlTop.ResumeLayout(False)
        Me.PanelControlTop.PerformLayout()
        CType(Me.CheckEditSale.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEditNoMaster.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControlBottom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControlBottom.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEditReject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEditUniqueNotFound.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CheckEditNoStock As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents PanelControlTop As DevExpress.XtraEditors.PanelControl
    Friend WithEvents CheckEditSale As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEditNoMaster As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelControlBottom As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BtnOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckEditReject As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEditUniqueNotFound As DevExpress.XtraEditors.CheckEdit
End Class
