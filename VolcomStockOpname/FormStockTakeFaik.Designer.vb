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
        Me.PanelControlBottom = New DevExpress.XtraEditors.PanelControl()
        Me.BtnOk = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.TxtDescription = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtSize = New DevExpress.XtraEditors.TextEdit()
        Me.TxtCode = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtPrice = New DevExpress.XtraEditors.TextEdit()
        CType(Me.PanelControlBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControlBottom.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.TxtDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControlBottom
        '
        Me.PanelControlBottom.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControlBottom.Controls.Add(Me.BtnOk)
        Me.PanelControlBottom.Controls.Add(Me.BtnSave)
        Me.PanelControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControlBottom.Location = New System.Drawing.Point(0, 119)
        Me.PanelControlBottom.Name = "PanelControlBottom"
        Me.PanelControlBottom.Size = New System.Drawing.Size(357, 35)
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
        Me.BtnOk.Location = New System.Drawing.Point(134, 0)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(102, 35)
        Me.BtnOk.TabIndex = 0
        Me.BtnOk.Text = "Close (Esc)"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.TxtPrice)
        Me.GroupControl1.Controls.Add(Me.TxtDescription)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.TxtCode)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.TxtSize)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(357, 119)
        Me.GroupControl1.TabIndex = 1
        '
        'TxtDescription
        '
        Me.TxtDescription.EditValue = ""
        Me.TxtDescription.Location = New System.Drawing.Point(72, 53)
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescription.Properties.Appearance.Options.UseFont = True
        Me.TxtDescription.Size = New System.Drawing.Size(276, 20)
        Me.TxtDescription.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Size"
        '
        'TxtSize
        '
        Me.TxtSize.Location = New System.Drawing.Point(72, 79)
        Me.TxtSize.Name = "TxtSize"
        Me.TxtSize.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSize.Properties.Appearance.Options.UseFont = True
        Me.TxtSize.Size = New System.Drawing.Size(60, 20)
        Me.TxtSize.TabIndex = 5
        '
        'TxtCode
        '
        Me.TxtCode.EditValue = ""
        Me.TxtCode.Location = New System.Drawing.Point(72, 27)
        Me.TxtCode.Name = "TxtCode"
        Me.TxtCode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCode.Properties.Appearance.Options.UseFont = True
        Me.TxtCode.Size = New System.Drawing.Size(276, 20)
        Me.TxtCode.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Code"
        '
        'BtnSave
        '
        Me.BtnSave.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnSave.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Appearance.Options.UseBackColor = True
        Me.BtnSave.Appearance.Options.UseFont = True
        Me.BtnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(236, 0)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(121, 35)
        Me.BtnSave.TabIndex = 2
        Me.BtnSave.Text = "Save Data (F5)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(138, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Price"
        '
        'TxtPrice
        '
        Me.TxtPrice.Location = New System.Drawing.Point(174, 79)
        Me.TxtPrice.Name = "TxtPrice"
        Me.TxtPrice.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrice.Properties.Appearance.Options.UseFont = True
        Me.TxtPrice.Properties.DisplayFormat.FormatString = "n0"
        Me.TxtPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrice.Properties.Mask.EditMask = "n0"
        Me.TxtPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TxtPrice.Size = New System.Drawing.Size(170, 20)
        Me.TxtPrice.TabIndex = 10
        '
        'FormStockTakeFaik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 154)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.PanelControlBottom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormStockTakeFaik"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Unidentified Product"
        CType(Me.PanelControlBottom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControlBottom.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.TxtDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControlBottom As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BtnOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TxtDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtSize As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtPrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As Label
End Class
