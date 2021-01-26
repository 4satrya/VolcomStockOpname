<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStockTakeUnRegDet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormStockTakeUnRegDet))
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.TESize = New DevExpress.XtraEditors.TextEdit()
        Me.SBClose = New DevExpress.XtraEditors.SimpleButton()
        Me.SBSave = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.TEName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.TECode = New DevExpress.XtraEditors.TextEdit()
        CType(Me.TESize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TECode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 117)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl3.TabIndex = 21
        Me.LabelControl3.Text = "Size"
        '
        'TESize
        '
        Me.TESize.EditValue = ""
        Me.TESize.Location = New System.Drawing.Point(12, 136)
        Me.TESize.Name = "TESize"
        Me.TESize.Size = New System.Drawing.Size(260, 20)
        Me.TESize.TabIndex = 17
        '
        'SBClose
        '
        Me.SBClose.Image = CType(resources.GetObject("SBClose.Image"), System.Drawing.Image)
        Me.SBClose.Location = New System.Drawing.Point(128, 172)
        Me.SBClose.Name = "SBClose"
        Me.SBClose.Size = New System.Drawing.Size(66, 23)
        Me.SBClose.TabIndex = 20
        Me.SBClose.Text = "Close"
        '
        'SBSave
        '
        Me.SBSave.Image = CType(resources.GetObject("SBSave.Image"), System.Drawing.Image)
        Me.SBSave.Location = New System.Drawing.Point(200, 172)
        Me.SBSave.Name = "SBSave"
        Me.SBSave.Size = New System.Drawing.Size(72, 23)
        Me.SBSave.TabIndex = 19
        Me.SBSave.Text = "Save"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 62)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl2.TabIndex = 18
        Me.LabelControl2.Text = "Name"
        '
        'TEName
        '
        Me.TEName.EditValue = ""
        Me.TEName.Location = New System.Drawing.Point(12, 81)
        Me.TEName.Name = "TEName"
        Me.TEName.Size = New System.Drawing.Size(260, 20)
        Me.TEName.TabIndex = 16
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl1.TabIndex = 15
        Me.LabelControl1.Text = "Code"
        '
        'TECode
        '
        Me.TECode.Location = New System.Drawing.Point(12, 31)
        Me.TECode.Name = "TECode"
        Me.TECode.Properties.ReadOnly = True
        Me.TECode.Size = New System.Drawing.Size(260, 20)
        Me.TECode.TabIndex = 14
        '
        'FormStockTakeUnRegDet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 207)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.TESize)
        Me.Controls.Add(Me.SBClose)
        Me.Controls.Add(Me.SBSave)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.TEName)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.TECode)
        Me.Name = "FormStockTakeUnRegDet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Un-Reg Detail"
        CType(Me.TESize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TECode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TESize As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SBClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SBSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TEName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TECode As DevExpress.XtraEditors.TextEdit
End Class
