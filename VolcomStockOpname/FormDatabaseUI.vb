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
End Class