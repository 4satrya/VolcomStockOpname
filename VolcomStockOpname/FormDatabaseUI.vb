Public Class FormDatabaseUI
    Private Sub FormDatabaseUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        view_periode()
        view_detail()
    End Sub

    Sub view_periode()
        Dim query As String = "SELECT * FROM tb_periode ORDER BY id_periode ASC"
        Dim data As DataTable = execute_query(query, -1, False, app_host, app_username, app_password, "db_opt")
        GCPeriode.DataSource = data
    End Sub

    Sub view_detail()
        Dim id_periode As String = "-1"
        Try
            id_periode = GVPeriode.GetFocusedRowCellValue("id_periode").ToString
        Catch ex As Exception
        End Try
        Dim query As String = "SELECT * FROM tb_periode_det WHERE id_periode='" + id_periode + "' ORDER BY id_periode_det ASC"
        Dim data As DataTable = execute_query(query, -1, False, app_host, app_username, app_password, "db_opt")
        GCDetail.DataSource = data
    End Sub

    Private Sub FormDatabaseUI_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub GVPeriode_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GVPeriode.FocusedRowChanged
        view_detail()
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        Cursor = Cursors.WaitCursor
        FormDatabasePeriode.action = "ins"
        FormDatabasePeriode.ShowDialog()
        Cursor = Cursors.Default
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        If GVPeriode.RowCount > 0 And GVPeriode.FocusedRowHandle >= 0 Then
            Cursor = Cursors.WaitCursor
            FormDatabasePeriode.action = "upd"
            FormDatabasePeriode.id = GVPeriode.GetFocusedRowCellValue("id_periode").ToString
            FormDatabasePeriode.ShowDialog()
            Cursor = Cursors.Default
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Cursor = Cursors.WaitCursor
        If GVPeriode.RowCount > 0 And GVPeriode.FocusedRowHandle >= 0 Then
            Dim confirm As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure you want to delete this period?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            If confirm = DialogResult.Yes Then
                Dim query As String = "DELETE FROM tb_periode WHERE id_periode='" + GVPeriode.GetFocusedRowCellValue("id_periode").ToString + "'"
                execute_non_query(query, False, app_host, app_username, app_password, "db_opt")
                view_periode()
            End If
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub SetAsDefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetAsDefaultToolStripMenuItem.Click
        Cursor = Cursors.WaitCursor
        If GVPeriode.RowCount > 0 And GVPeriode.FocusedRowHandle >= 0 Then
            Dim confirm As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure you want to set as default for this period?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            If confirm = DialogResult.Yes Then
                Dim query As String = "UPDATE tb_periode SET is_default=2 "
                execute_non_query(query, False, app_host, app_username, app_password, "db_opt")

                'actiovre
                Dim queryupd As String = "UPDATE tb_periode SET is_default=1 WHERE id_periode='" + GVPeriode.GetFocusedRowCellValue("id_periode").ToString + "' "
                execute_non_query(queryupd, False, app_host, app_username, app_password, "db_opt")
                view_periode()
            End If
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub AddToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem1.Click
        Cursor = Cursors.WaitCursor
        FormDatabasePeriodeDet.ShowDialog()
        Cursor = Cursors.Default
    End Sub

    Private Sub DeleteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem1.Click
        Cursor = Cursors.WaitCursor
        If GVDetail.RowCount > 0 And GVDetail.FocusedRowHandle >= 0 Then
            Dim confirm As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure you want to delete this detail?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            If confirm = DialogResult.Yes Then
                Dim query As String = "DELETE FROM tb_periode_det WHERE id_periode_det='" + GVDetail.GetFocusedRowCellValue("id_periode_det").ToString + "'"
                execute_non_query(query, False, app_host, app_username, app_password, "db_opt")
                view_detail()
            End If
        End If
    End Sub
End Class