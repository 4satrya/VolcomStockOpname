<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStockTakeCancel
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.MemoNote = New DevExpress.XtraEditors.MemoEdit()
        Me.ButtonApply = New DevExpress.XtraEditors.SimpleButton()
        Me.ButtonCancel = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.MemoNote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Note:"
        '
        'MemoNote
        '
        Me.MemoNote.Location = New System.Drawing.Point(12, 31)
        Me.MemoNote.Name = "MemoNote"
        Me.MemoNote.Size = New System.Drawing.Size(260, 89)
        Me.MemoNote.TabIndex = 1
        '
        'ButtonApply
        '
        Me.ButtonApply.Location = New System.Drawing.Point(197, 128)
        Me.ButtonApply.Name = "ButtonApply"
        Me.ButtonApply.Size = New System.Drawing.Size(75, 23)
        Me.ButtonApply.TabIndex = 2
        Me.ButtonApply.Text = "Apply"
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(116, 128)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 3
        Me.ButtonCancel.Text = "Cancel"
        '
        'FormStockTakeCancel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 161)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonApply)
        Me.Controls.Add(Me.MemoNote)
        Me.Controls.Add(Me.LabelControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormStockTakeCancel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Note"
        CType(Me.MemoNote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MemoNote As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents ButtonApply As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ButtonCancel As DevExpress.XtraEditors.SimpleButton
End Class
