<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInputDateNotif
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInputDateNotif))
        Me.DateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.SimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.DateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateEdit
        '
        Me.DateEdit.EditValue = Nothing
        Me.DateEdit.Location = New System.Drawing.Point(12, 57)
        Me.DateEdit.Name = "DateEdit"
        Me.DateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.DateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit.Properties.DisplayFormat.FormatString = "dd MMMM yyyy HH:mm"
        Me.DateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateEdit.Properties.EditFormat.FormatString = "dd MMMM yyyy HH:mm"
        Me.DateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateEdit.Properties.Mask.EditMask = "dd MMMM yyyy HH:mm"
        Me.DateEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.DateEdit.Size = New System.Drawing.Size(260, 20)
        Me.DateEdit.TabIndex = 0
        '
        'SimpleButton
        '
        Me.SimpleButton.Image = CType(resources.GetObject("SimpleButton.Image"), System.Drawing.Image)
        Me.SimpleButton.Location = New System.Drawing.Point(196, 84)
        Me.SimpleButton.Name = "SimpleButton"
        Me.SimpleButton.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton.TabIndex = 1
        Me.SimpleButton.Text = "Save"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(252, 34)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Mohon input tanggal && jam konfirmasi " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "email dari Internal Audit Volcom Indonesi" &
    "a"
        '
        'FormInputDateNotif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 123)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.SimpleButton)
        Me.Controls.Add(Me.DateEdit)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormInputDateNotif"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input Tanggal & Jam"
        CType(Me.DateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
