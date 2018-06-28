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
        Me.NBDashboard = New DevExpress.XtraNavBar.NavBarItem()
        Me.NBExport = New DevExpress.XtraNavBar.NavBarItem()
        Me.NBImport = New DevExpress.XtraNavBar.NavBarItem()
        Me.NBStock = New DevExpress.XtraNavBar.NavBarItem()
        Me.NBOpt = New DevExpress.XtraNavBar.NavBarItem()
        Me.NBStockTake = New DevExpress.XtraNavBar.NavBarItem()
        Me.NBWHPreST = New DevExpress.XtraNavBar.NavBarItem()
        Me.NBWHST = New DevExpress.XtraNavBar.NavBarItem()
        Me.PCLeft = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControlInfo = New DevExpress.XtraEditors.PanelControl()
        Me.TxtPosition = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.TxtName = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.SplashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.VolcomStockOpname.WaitForm1), True, True)
        CType(Me.NBMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PCLeft.SuspendLayout()
        CType(Me.PanelControlInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControlInfo.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.NBMain.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.NBExport, Me.NBImport, Me.NBStock, Me.NBStockTake, Me.NBDashboard, Me.NBOpt, Me.NBWHPreST, Me.NBWHST})
        Me.NBMain.Location = New System.Drawing.Point(0, 168)
        Me.NBMain.LookAndFeel.SkinName = "DevExpress Dark Style"
        Me.NBMain.LookAndFeel.UseDefaultLookAndFeel = False
        Me.NBMain.Name = "NBMain"
        Me.NBMain.OptionsNavPane.ExpandedWidth = 241
        Me.NBMain.Size = New System.Drawing.Size(241, 405)
        Me.NBMain.TabIndex = 1
        Me.NBMain.Text = "NavBarControl1"
        Me.NBMain.View = New DevExpress.XtraNavBar.ViewInfo.SkinNavigationPaneViewInfoRegistrator()
        '
        'NBGGeneral
        '
        Me.NBGGeneral.Caption = "Main Menu"
        Me.NBGGeneral.Expanded = True
        Me.NBGGeneral.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NBDashboard), New DevExpress.XtraNavBar.NavBarItemLink(Me.NBExport), New DevExpress.XtraNavBar.NavBarItemLink(Me.NBImport), New DevExpress.XtraNavBar.NavBarItemLink(Me.NBStock), New DevExpress.XtraNavBar.NavBarItemLink(Me.NBOpt), New DevExpress.XtraNavBar.NavBarItemLink(Me.NBStockTake), New DevExpress.XtraNavBar.NavBarItemLink(Me.NBWHPreST), New DevExpress.XtraNavBar.NavBarItemLink(Me.NBWHST)})
        Me.NBGGeneral.Name = "NBGGeneral"
        Me.NBGGeneral.TopVisibleLinkIndex = 2
        '
        'NBDashboard
        '
        Me.NBDashboard.Caption = "Dashboard"
        Me.NBDashboard.Name = "NBDashboard"
        Me.NBDashboard.SmallImage = CType(resources.GetObject("NBDashboard.SmallImage"), System.Drawing.Image)
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
        'NBStock
        '
        Me.NBStock.Caption = "Stock on Hand"
        Me.NBStock.Name = "NBStock"
        Me.NBStock.SmallImage = CType(resources.GetObject("NBStock.SmallImage"), System.Drawing.Image)
        '
        'NBOpt
        '
        Me.NBOpt.Caption = "Options"
        Me.NBOpt.Name = "NBOpt"
        Me.NBOpt.SmallImage = CType(resources.GetObject("NBOpt.SmallImage"), System.Drawing.Image)
        '
        'NBStockTake
        '
        Me.NBStockTake.Caption = "Stocktake"
        Me.NBStockTake.Name = "NBStockTake"
        Me.NBStockTake.SmallImage = CType(resources.GetObject("NBStockTake.SmallImage"), System.Drawing.Image)
        '
        'NBWHPreST
        '
        Me.NBWHPreST.Caption = "WH Pre Stocktake"
        Me.NBWHPreST.Name = "NBWHPreST"
        '
        'NBWHST
        '
        Me.NBWHST.Caption = "WH Stocktake"
        Me.NBWHST.Name = "NBWHST"
        '
        'PCLeft
        '
        Me.PCLeft.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PCLeft.Controls.Add(Me.NBMain)
        Me.PCLeft.Controls.Add(Me.PanelControlInfo)
        Me.PCLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.PCLeft.Location = New System.Drawing.Point(0, 0)
        Me.PCLeft.Name = "PCLeft"
        Me.PCLeft.Size = New System.Drawing.Size(241, 573)
        Me.PCLeft.TabIndex = 2
        '
        'PanelControlInfo
        '
        Me.PanelControlInfo.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PanelControlInfo.Appearance.Options.UseBackColor = True
        Me.PanelControlInfo.Controls.Add(Me.TxtPosition)
        Me.PanelControlInfo.Controls.Add(Me.SimpleButton1)
        Me.PanelControlInfo.Controls.Add(Me.SimpleButton2)
        Me.PanelControlInfo.Controls.Add(Me.TxtName)
        Me.PanelControlInfo.Controls.Add(Me.PictureEdit1)
        Me.PanelControlInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControlInfo.Location = New System.Drawing.Point(0, 0)
        Me.PanelControlInfo.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.PanelControlInfo.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControlInfo.Name = "PanelControlInfo"
        Me.PanelControlInfo.Size = New System.Drawing.Size(241, 168)
        Me.PanelControlInfo.TabIndex = 2
        '
        'TxtPosition
        '
        Me.TxtPosition.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPosition.Appearance.ForeColor = System.Drawing.Color.Black
        Me.TxtPosition.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TxtPosition.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.TxtPosition.Location = New System.Drawing.Point(-1, 90)
        Me.TxtPosition.Name = "TxtPosition"
        Me.TxtPosition.Size = New System.Drawing.Size(240, 18)
        Me.TxtPosition.TabIndex = 6
        Me.TxtPosition.Text = "EMPLOYEE POSITION"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.BackColor = System.Drawing.SystemColors.Highlight
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.ForeColor = System.Drawing.Color.White
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Appearance.Options.UseForeColor = True
        Me.SimpleButton1.Location = New System.Drawing.Point(45, 116)
        Me.SimpleButton1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.SimpleButton1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 5
        Me.SimpleButton1.Text = "Profile"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.BackColor = System.Drawing.Color.Crimson
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.ForeColor = System.Drawing.Color.White
        Me.SimpleButton2.Appearance.Options.UseBackColor = True
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.Appearance.Options.UseForeColor = True
        Me.SimpleButton2.Location = New System.Drawing.Point(123, 116)
        Me.SimpleButton2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.SimpleButton2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton2.TabIndex = 4
        Me.SimpleButton2.Text = "Logout"
        '
        'TxtName
        '
        Me.TxtName.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtName.Appearance.ForeColor = System.Drawing.Color.Black
        Me.TxtName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TxtName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.TxtName.Location = New System.Drawing.Point(0, 72)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(240, 18)
        Me.TxtName.TabIndex = 1
        Me.TxtName.Text = "EMPLOYEE NAME"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(93, 18)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Size = New System.Drawing.Size(52, 49)
        Me.PictureEdit1.TabIndex = 0
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.MdiParent = Me
        '
        'SplashScreenManager1
        '
        Me.SplashScreenManager1.ClosingDelay = 500
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
        Me.Opacity = 0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Volcom Stock Take"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.NBMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PCLeft.ResumeLayout(False)
        CType(Me.PanelControlInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControlInfo.ResumeLayout(False)
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents NBStockTake As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents PanelControlInfo As DevExpress.XtraEditors.PanelControl
    Friend WithEvents TxtName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtPosition As DevExpress.XtraEditors.LabelControl
    Friend WithEvents NBDashboard As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NBOpt As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NBWHPreST As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NBWHST As DevExpress.XtraNavBar.NavBarItem
End Class
