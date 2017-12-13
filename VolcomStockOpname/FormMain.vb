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

    Sub actionLoad()
        Try
            read_database_configuration()
            check_connection(True, "", "", "", "")
        Catch ex As Exception
            FormDatabase.ShowDialog()
        End Try
    End Sub

    Private Sub NBImport_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NBImport.LinkClicked
        Cursor = Cursors.WaitCursor
        FormDatabase.showx = True
        FormDatabase.ShowDialog()
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
End Class