Public Class FormDatabasePeriodeDet
    Private Sub FormDatabasePeriodeDet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtPeriode.Text = FormDatabaseUI.GVPeriode.GetFocusedRowCellValue("description").ToString
        Dim query As String = "SHOW DATABASES;"
        Dim data As DataTable = execute_query(query, -1, False, app_host, app_username, app_password, "db_opt")
        GCData.DataSource = data
        getAccount()
    End Sub

    Sub getAccount()
        If GVData.RowCount > 0 And GVData.FocusedRowHandle Then
            Cursor = Cursors.WaitCursor
            Try
                Dim db As String = GVData.GetFocusedRowCellValue("Database").ToString
                Dim qc As String = "SELECT * FROM " + db + ".tb_m_comp LIMIT 1; "
                Dim dc As DataTable = execute_query(qc, -1, False, app_host, app_username, app_password, db)
                If dc.Rows.Count > 0 Then
                    TxtAccount.Text = dc.Rows(0)("comp_number").ToString
                    TxtAccountDesc.Text = dc.Rows(0)("comp_name").ToString
                Else
                    TxtAccount.Text = ""
                    TxtAccountDesc.Text = ""
                End If
            Catch ex As Exception
                TxtAccount.Text = ""
                TxtAccountDesc.Text = ""
            End Try
            Cursor = Cursors.Default
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Close()
    End Sub

    Private Sub FormDatabasePeriodeDet_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub GVData_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GVData.FocusedRowChanged
        getAccount()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Cursor = Cursors.WaitCursor
        Dim query As String = "INSERT INTO tb_periode_det(id_periode, account, account_desc, db_name) 
        VALUES('" + FormDatabaseUI.GVPeriode.GetFocusedRowCellValue("id_periode").ToString + "','" + addSlashes(TxtAccount.Text) + "', '" + addSlashes(TxtAccountDesc.Text) + "', '" + GVData.GetFocusedRowCellValue("Database").ToString + "') "
        execute_non_query(query, False, app_host, app_username, app_password, "db_opt")
        FormDatabaseUI.view_detail()
        Close()
        Cursor = Cursors.Default
    End Sub
End Class