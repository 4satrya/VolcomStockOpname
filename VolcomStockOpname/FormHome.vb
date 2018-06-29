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

    Private Sub GVCon_Click(sender As Object, e As EventArgs) Handles GVCon.Click
        If GVCon.RowCount > 0 And GVCon.FocusedRowHandle >= 0 Then
            Dim db_sel As String = GVCon.GetFocusedRowCellValue("db_name").ToString
            'close all form
            For Each frm In FormMain.MdiChildren
                If frm.Name <> "FormMain" And frm.Name <> "FormHome" Then
                    frm.Close()
                End If
            Next

            Try
                write_database_configuration(app_host, app_username, app_password, db_sel)
                read_database_configuration()
                infoCustom("Success" + System.Environment.NewLine + "Current Account : " + GVCon.GetFocusedRowCellValue("acc").ToString + System.Environment.NewLine + "Current DB : " + db_sel)
                setInfoDb()
            Catch ex As Exception
                errorCustom("Error : " + ex.ToString)
            End Try
        End If
    End Sub
End Class