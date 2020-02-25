Public Class FormMain
    Private Sub NBExport_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NBExport.LinkClicked
        Cursor = Cursors.WaitCursor
        Try
            FormFGBackupStockDet.MdiParent = Me
            FormFGBackupStockDet.Show()
            FormFGBackupStockDet.WindowState = FormWindowState.Maximized
            FormFGBackupStockDet.Focus()
        Catch ex As Exception
            errorConnection()
        End Try
        Cursor = Cursors.Default
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actionLoad()
    End Sub

    Sub userPriv()
        If id_role_login = "1" Then
            'super admin
            NBExport.Visible = True
            NBImport.Visible = True
            NBStockTake.Visible = True
            NBOpt.Visible = True
            NBWHPreST.Visible = True
            NBWHST.Visible = True
        ElseIf id_role_login = "2" Then
            'IA
            NBExport.Visible = True
            NBImport.Visible = True
            NBStockTake.Visible = True
            NBOpt.Visible = True
            NBWHPreST.Visible = False
            NBWHST.Visible = True
        ElseIf id_role_login = "3" Then
            'WH ADMIN
            NBExport.Visible = True
            NBImport.Visible = True
            NBStockTake.Visible = False
            NBOpt.Visible = False
            NBWHPreST.Visible = True
            NBWHST.Visible = False
        ElseIf id_role_login = "4" Then
            'WH
            NBExport.Visible = False
            NBImport.Visible = False
            NBStockTake.Visible = False
            NBOpt.Visible = False
            NBWHPreST.Visible = True
            NBWHST.Visible = False
        Else
            NBExport.Visible = False
            NBImport.Visible = False
            NBStockTake.Visible = False
            NBOpt.Visible = False
            NBWHPreST.Visible = False
            NBWHST.Visible = False
        End If
    End Sub

    Sub restoreMenu()
        NBExport.Visible = True
        NBImport.Visible = True
        NBStockTake.Visible = True
        NBOpt.Visible = True
        NBWHPreST.Visible = True
        NBWHST.Visible = True
    End Sub

    Sub actionLoad()
        LabelControl1.Text += " (" + "ver. " + getVersion() + ")"
        Try
            apply_skin()
            read_database_configuration()
            check_connection(True, "", "", "", "")
            If id_user = "" And app_database <> "db_opt" Then
                FormLogin.ShowDialog()

                'current db
                setInfoDb()

                'open dashboard
                Try
                    FormHome.MdiParent = Me
                    FormHome.Show()
                    FormHome.WindowState = FormWindowState.Maximized
                    FormHome.Focus()
                Catch ex As Exception
                    errorConnection()
                End Try
                Cursor = Cursors.Default
            Else
                'initial server centre
                initialServerCentre()
                FormLogin.id_menu = "1"
                FormLogin.is_first = "1"
                FormLogin.ShowDialog()
            End If
        Catch ex As Exception
            FormDatabase.ShowDialog()
        End Try
    End Sub

    Sub optionMenu()

    End Sub

    Private Sub NBImport_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NBImport.LinkClicked
        Cursor = Cursors.WaitCursor
        'close all
        Try
            For Each frm In MdiChildren
                If frm.Name <> "FormMain" Then
                    frm.Close()
                End If
            Next
        Catch ex As Exception
        End Try

        FormDatabase.showx = True
        FormDatabase.ShowDialog()

        'open dashboard
        Try
            FormHome.MdiParent = Me
            FormHome.Show()
            FormHome.WindowState = FormWindowState.Maximized
            FormHome.Focus()
        Catch ex As Exception
            errorConnection()
        End Try

        Cursor = Cursors.Default
    End Sub

    Private Sub NBStock_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NBStock.LinkClicked
        Cursor = Cursors.WaitCursor
        Try
            FormStock.MdiParent = Me
            FormStock.Show()
            FormStock.WindowState = FormWindowState.Maximized
            FormStock.Focus()
        Catch ex As Exception
            errorConnection()
        End Try
        Cursor = Cursors.Default
    End Sub

    Private Sub NBStockTake_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NBStockTake.LinkClicked
        Cursor = Cursors.WaitCursor
        Try
            'jika telah terbuka
            FormStockTake.Close()
            FormStockTake.Dispose()
        Catch ex As Exception
        End Try

        Try
            FormStockTake.MdiParent = Me
            FormStockTake.Show()
            FormStockTake.WindowState = FormWindowState.Maximized
            FormStockTake.Focus()
        Catch ex As Exception
            errorConnection()
        End Try
        Cursor = Cursors.Default
    End Sub

    Sub logOutCmd()
        Cursor = Cursors.WaitCursor
        Try
            'close all form
            For Each frm In MdiChildren
                If frm.Name <> "FormMain" Then
                    frm.Close()
                End If
            Next

            id_user = Nothing
            id_role_login = Nothing
            username_user = Nothing
            name_user = Nothing
            position_user = Nothing
            is_change_pass_user = Nothing
            restoreMenu()
            Opacity = 0
            FormLogin.ShowDialog()
        Catch ex As Exception
            stopCustom(ex.ToString)
        End Try
        Cursor = Cursors.Default
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim confirm As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure to logout this system?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If confirm = DialogResult.Yes Then
            logOutCmd()
        End If
    End Sub

    Private Sub NBOpt_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NBOpt.LinkClicked
        Cursor = Cursors.WaitCursor
        Try
            FormOpt.ShowDialog()
        Catch ex As Exception
            errorConnection()
        End Try
        Cursor = Cursors.Default
    End Sub

    Private Sub NBWHPreST_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NBWHPreST.LinkClicked
        Cursor = Cursors.WaitCursor
        Try
            'jika telah terbuka
            FormStockTake.Close()
            FormStockTake.Dispose()
        Catch ex As Exception
        End Try

        Try
            FormStockTake.MdiParent = Me
            FormStockTake.is_pre = "1"
            FormStockTake.Show()
            FormStockTake.WindowState = FormWindowState.Maximized
            FormStockTake.Focus()
        Catch ex As Exception
            errorConnection()
        End Try
        Cursor = Cursors.Default
    End Sub

    Private Sub NBWHST_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NBWHST.LinkClicked
        Try
            FormVerStockTake.MdiParent = Me
            FormVerStockTake.Show()
            FormVerStockTake.WindowState = FormWindowState.Maximized
            FormVerStockTake.Focus()
        Catch ex As Exception
            errorConnection()
        End Try
        Cursor = Cursors.Default
    End Sub

    Private Sub NBDashboard_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NBDashboard.LinkClicked
        Try
            FormHome.MdiParent = Me
            FormHome.Show()
            FormHome.WindowState = FormWindowState.Maximized
            FormHome.Focus()
        Catch ex As Exception
            errorConnection()
        End Try
        Cursor = Cursors.Default
    End Sub
End Class