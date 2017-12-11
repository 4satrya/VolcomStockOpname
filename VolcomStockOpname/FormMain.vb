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
End Class