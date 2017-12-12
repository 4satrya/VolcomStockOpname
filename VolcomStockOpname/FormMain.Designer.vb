<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.NBMain = New DevExpress.XtraNavBar.NavBarControl()
        Me.NBGGeneral = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NBExport = New DevExpress.XtraNavBar.NavBarItem()
        Me.NBImport = New DevExpress.XtraNavBar.NavBarItem()
        Me.PCLeft = New DevExpress.XtraEditors.PanelControl()
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.SplashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.VolcomStockOpname.WaitForm1), True, True)
        Me.NBStock = New DevExpress.XtraNavBar.NavBarItem()
        CType(Me.NBMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PCLeft.SuspendLayout()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NBMain
        '
        Me.NBMain.ActiveGroup = Me.NBGGeneral
        Me.NBMain.Appearance.GroupBackground.BackColor2 = System.Drawing.Color.Black
        Me.NBMain.Appearance.Item.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NBMain.Appearance.Item.ForeColor = System.Drawing.Color.White
        Me.NBMain.Appearance.Item.Options.UseFont = True
        Me.NBMain.Appearance.Item.Options.UseForeColor = True
        Me.NBMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NBMain.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NBGGeneral})
        Me.NBMain.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.NBExport, Me.NBImport, Me.NBStock})
        Me.NBMain.Location = New System.Drawing.Point(0, 0)
        Me.NBMain.LookAndFeel.SkinName = "DevExpress Dark Style"
        Me.NBMain.LookAndFeel.UseDefaultLookAndFeel = False
        Me.NBMain.Name = "NBMain"
        Me.NBMain.OptionsNavPane.ExpandedWidth = 221
        Me.NBMain.Size = New System.Drawing.Size(221, 573)
        Me.NBMain.TabIndex = 1
        Me.NBMain.Text = "NavBarControl1"
        Me.NBMain.View = New DevExpress.XtraNavBar.ViewInfo.SkinNavigationPaneViewInfoRegistrator()
        '
        'NBGGeneral
        '
        Me.NBGGeneral.Caption = "Main Menu"
        Me.NBGGeneral.Expanded = True
        Me.NBGGeneral.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NBExport), New DevExpress.XtraNavBar.NavBarItemLink(Me.NBImport), New DevExpress.XtraNavBar.NavBarItemLink(Me.NBStock)})
        Me.NBGGeneral.Name = "NBGGeneral"
        '
        'NBExport
        '
        Me.NBExport.Caption = "Export Data"
        Me.NBExport.Name = "NBExport"
        Me.NBExport.SmallImage = CType(resources.GetObject("NBExport.SmallImage"), System.Drawing.Image)
        '
        'NBImport
        '
        Me.NBImport.Caption = "Setup Database"
        Me.NBImport.Name = "NBImport"
        Me.NBImport.SmallImage = CType(resources.GetObject("NBImport.SmallImage"), System.Drawing.Image)
        '
        'PCLeft
        '
        Me.PCLeft.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PCLeft.Controls.Add(Me.NBMain)
        Me.PCLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.PCLeft.Location = New System.Drawing.Point(0, 0)
        Me.PCLeft.Name = "PCLeft"
        Me.PCLeft.Size = New System.Drawing.Size(221, 573)
        Me.PCLeft.TabIndex = 2
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.MdiParent = Me
        '
        'SplashScreenManager1
        '
        Me.SplashScreenManager1.ClosingDelay = 500
        '
        'NBStock
        '
        Me.NBStock.Caption = "Stock on Hand"
        Me.NBStock.Name = "NBStock"
        Me.NBStock.SmallImage = CType(resources.GetObject("NBStock.SmallImage"), System.Drawing.Image)
        '
        'FormMain
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseBorderColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1085, 573)
        Me.Controls.Add(Me.PCLeft)
        Me.IsMdiContainer = True
        Me.MinimizeBox = False
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Volcom Stock Take"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.NBMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PCLeft.ResumeLayout(False)
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NBMain As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents NBGGeneral As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NBExport As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NBImport As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents PCLeft As DevExpress.XtraEditors.PanelControl
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents NBStock As DevExpress.XtraNavBar.NavBarItem
End Class
