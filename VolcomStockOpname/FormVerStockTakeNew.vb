Public Class FormVerStockTakeNew
    Private Sub FormVerStockTakeNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewScan()
    End Sub


    Sub viewScan()
        Cursor = Cursors.WaitCursor
        Dim stake As New ClassStockTake()
        Dim query As String = stake.queryTransMain("AND st.is_combine=2 AND st.is_pre=1 AND st.id_report_status!=5 ", "1")
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        GCScan.DataSource = data
        GVScan.FocusedRowHandle = 0
        Cursor = Cursors.Default
    End Sub

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        If GVScan.RowCount > 0 And GVScan.FocusedRowHandle >= 0 Then
            Cursor = Cursors.WaitCursor

            'check exist
            Dim stake As New ClassStockTake()
            Dim querycek As String = stake.queryVerTransMain("AND st.is_combine=2 AND st.id_st_trans='" + GVScan.GetFocusedRowCellValue("id_st_trans").ToString + "' AND st.id_report_status!=5 ", "1")
            Dim datacek As DataTable = execute_query(querycek, -1, True, "", "", "", "")
            If datacek.Rows.Count > 0 Then
                Cursor = Cursors.Default
                stopCustom("This number already verified")
                Exit Sub
            End If

            Dim query As String = "INSERT INTO tb_st_trans_ver (id_st_trans,id_wh_drawer, st_trans_ver_number, remark, st_trans_ver_date, st_trans_ver_by, is_combine) 
            VALUES ('" + GVScan.GetFocusedRowCellValue("id_st_trans").ToString + "','" + GVScan.GetFocusedRowCellValue("id_wh_drawer").ToString + "', '', '" + addSlashes(TxtRemark.Text.ToString) + "', NOW(), '" + id_user + "', 2); SELECT LAST_INSERT_ID(); "
            Dim id_new As String = execute_query(query, 0, True, "", "", "", "")

            'update number
            Dim trans_number As String = header_number("6", id_new)
            Dim query_numb As String = "UPDATE tb_st_trans_ver SET st_trans_ver_number='" + trans_number + "' WHERE id_st_trans_ver='" + id_new + "' "
            execute_non_query(query_numb, True, "", "", "", "")

            FormVerStockTake.viewScan()
            FormVerStockTakeDet.action = "upd"
            FormVerStockTakeDet.id_st_trans_ver = id_new
            FormVerStockTakeDet.ShowDialog()
            Close()
            Cursor = Cursors.Default
        End If
    End Sub

    Private Sub FormVerStockTakeNew_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub
End Class