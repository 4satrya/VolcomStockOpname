Public Class FormHome
    Private Sub FormHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim qcurr As String = "SELECT * FROM tb_periode p WHERE p.is_default=1"
        Dim dcurr As DataTable = execute_query(qcurr, -1, False, app_host, app_username, app_password, "db_opt")
        If dcurr.Rows.Count > 0 Then
            LabelPeriodName.Text = dcurr.Rows(0)("description").ToString
            viewConn(dcurr.Rows(0)("id_periode").ToString)
        End If
    End Sub

    Sub viewConn(ByVal id_periode As String)
        Dim query As String = "SELECT pd.*,CONCAT(pd.account,' - ', account_desc) AS `acc`  FROM tb_periode_det pd WHERE pd.id_periode=" + id_periode + " "
        Dim data As DataTable = execute_query(query, -1, False, app_host, app_username, app_password, "db_opt")
        GCConn.DataSource = data
    End Sub
End Class