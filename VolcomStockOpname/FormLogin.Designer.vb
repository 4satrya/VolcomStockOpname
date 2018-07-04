<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
        Me.TxtUsername = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPass = New DevExpress.XtraEditors.TextEdit()
        Me.BtnLogin = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnReset = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelVersion = New System.Windows.Forms.Label()
        CType(Me.TxtUsername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(24, 39)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsername.Properties.Appearance.Options.UseFont = True
        Me.TxtUsername.Size = New System.Drawing.Size(338, 22)
        Me.TxtUsername.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'TxtPass
        '
        Me.TxtPass.Location = New System.Drawing.Point(24, 93)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPass.Properties.Appearance.Options.UseFont = True
        Me.TxtPass.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPass.Size = New System.Drawing.Size(338, 22)
        Me.TxtPass.TabIndex = 3
        '
        'BtnLogin
        '
        Me.BtnLogin.Appearance.BackColor = System.Drawing.Color.Gray
        Me.BtnLogin.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.Appearance.ForeColor = System.Drawing.Color.White
        Me.BtnLogin.Appearance.Options.UseBackColor = True
        Me.BtnLogin.Appearance.Options.UseFont = True
        Me.BtnLogin.Appearance.Options.UseForeColor = True
        Me.BtnLogin.Location = New System.Drawing.Point(266, 126)
        Me.BtnLogin.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.BtnLogin.LookAndFeel.UseDefaultLookAndFeel = False
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(96, 24)
        Me.BtnLogin.TabIndex = 4
        Me.BtnLogin.Text = "Login"
        '
        'BtnReset
        '
        Me.BtnReset.Appearance.BackColor = System.Drawing.Color.Crimson
        Me.BtnReset.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset.Appearance.ForeColor = System.Drawing.Color.White
        Me.BtnReset.Appearance.Options.UseBackColor = True
        Me.BtnReset.Appearance.Options.UseFont = True
        Me.BtnReset.Appearance.Options.UseForeColor = True
        Me.BtnReset.Location = New System.Drawing.Point(143, 126)
        Me.BtnReset.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.BtnReset.LookAndFeel.UseDefaultLookAndFeel = False
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(120, 24)
        Me.BtnReset.TabIndex = 5
        Me.BtnReset.Text = "Default Setting"
        '
        'LabelVersion
        '
        Me.LabelVersion.AutoSize = True
        Me.LabelVersion.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVersion.Location = New System.Drawing.Point(27, 128)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(65, 12)
        Me.LabelVersion.TabIndex = 6
        Me.LabelVersion.Text = "Version 0.0.0.1"
        Me.LabelVersion.Visible = False
        '
        'FormLogin
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(388, 176)
        Me.Controls.Add(Me.LabelVersion)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.LookAndFeel.SkinName = "Metropolis Dark"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormLogin"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Volcom Stock Take"
        CType(Me.TxtUsername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtUsername As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtPass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BtnLogin As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnReset As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelVersion As Label
End Class
