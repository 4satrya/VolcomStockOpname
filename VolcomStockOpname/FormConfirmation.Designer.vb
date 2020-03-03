<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConfirmation
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
        Me.TextEditPassword = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButtonConfirm = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButtonCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.TxtUsername = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.TextEditPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUsername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextEditPassword
        '
        Me.TextEditPassword.Location = New System.Drawing.Point(12, 76)
        Me.TextEditPassword.Name = "TextEditPassword"
        Me.TextEditPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextEditPassword.Size = New System.Drawing.Size(260, 20)
        Me.TextEditPassword.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 57)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Password"
        '
        'SimpleButtonConfirm
        '
        Me.SimpleButtonConfirm.Location = New System.Drawing.Point(197, 107)
        Me.SimpleButtonConfirm.Name = "SimpleButtonConfirm"
        Me.SimpleButtonConfirm.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButtonConfirm.TabIndex = 2
        Me.SimpleButtonConfirm.Text = "Confirm"
        '
        'SimpleButtonCancel
        '
        Me.SimpleButtonCancel.Location = New System.Drawing.Point(116, 107)
        Me.SimpleButtonCancel.Name = "SimpleButtonCancel"
        Me.SimpleButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButtonCancel.TabIndex = 3
        Me.SimpleButtonCancel.Text = "Cancel"
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(12, 31)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(260, 20)
        Me.TxtUsername.TabIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl2.TabIndex = 8905
        Me.LabelControl2.Text = "Username"
        '
        'FormConfirmation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 146)
        Me.Controls.Add(Me.SimpleButtonCancel)
        Me.Controls.Add(Me.SimpleButtonConfirm)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.TextEditPassword)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.TxtUsername)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormConfirmation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Confirmation"
        CType(Me.TextEditPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUsername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextEditPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButtonConfirm As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButtonCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtUsername As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
End Class
