Public Class FormVerStockTakeCombine
    Private Sub FormVerStockTakeCombine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewWHStockSum()
        viewScan()
    End Sub

    Sub viewScan()
        Cursor = Cursors.WaitCursor
        Dim id_wh_drawer As String = "-1"
        Try
            id_wh_drawer = SLEWHStockSum.EditValue.ToString
        Catch ex As Exception
        End Try
        Dim stake As New ClassStockTake()
        Dim query As String = stake.queryVerTransMain("AND st.is_combine=2 AND ISNULL(st.id_combine) AND st.id_report_status!=5 AND st.id_wh_drawer=" + id_wh_drawer + " ", "2")
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        GCCheck.DataSource = data
        GVCheck.FocusedRowHandle = 0
        Cursor = Cursors.Default
    End Sub

    Sub viewWHStockSum()
        Dim query As String = ""
        query += "SELECT e.id_comp,e.id_drawer_def, e.comp_number, e.comp_name, CONCAT_WS(' - ', e.comp_number, e.comp_name) AS comp_name_label FROM tb_st_stock a "
        query += "INNER JOIN tb_m_comp e ON e.id_drawer_def = a.id_wh_drawer "
        query += "GROUP BY e.id_drawer_def "
        viewSearchLookupQuery(SLEWHStockSum, query, "id_drawer_def", "comp_name_label", "id_drawer_def")
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Close()
    End Sub

    Private Sub FormVerStockTakeCombine_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        makeSafeGV(GVCheck)
        GVCheck.ActiveFilterString = "[is_select]='Yes' "
        If GVCheck.RowCount > 0 Then
            Dim confirm As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure you want to continue this process ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            If confirm = DialogResult.Yes Then
                Cursor = Cursors.WaitCursor
                Dim id_st_trans_ver As String = ""
                Dim id_st_trans_ver_det As String = ""
                For i As Integer = 0 To ((GVCheck.RowCount - 1) - GetGroupRowCount(GVCheck))
                    If GVCheck.GetRowCellValue(i, "is_select").ToString = "Yes" Then
                        If i > 0 Then
                            id_st_trans_ver += "OR "
                            id_st_trans_ver_det += "OR "
                        End If
                        id_st_trans_ver += "id_st_trans_ver='" + GVCheck.GetRowCellValue(i, "id_st_trans_ver").ToString + "' "
                        id_st_trans_ver_det += "st.id_st_trans_ver='" + GVCheck.GetRowCellValue(i, "id_st_trans_ver").ToString + "' "
                    End If
                Next

                'insert
                Dim query As String = "INSERT INTO tb_st_trans_ver (id_wh_drawer, st_trans_ver_number, remark, st_trans_ver_date, st_trans_ver_by, is_combine) 
                VALUES ('" + SLEWHStockSum.EditValue.ToString + "', '" + header_number("7") + "', '" + MERemark.Text + "', NOW(), '" + id_user + "', 1); SELECT LAST_INSERT_ID(); "
                Dim id_new As String = execute_query(query, 0, True, "", "", "", "")

                'update
                Dim query_upd As String = "UPDATE tb_st_trans_ver SET id_combine=" + id_new + " WHERE id_st_trans_ver>0 AND (" + id_st_trans_ver + ") "
                execute_non_query(query_upd, True, "", "", "", "")

                'insert detail
                Dim qd As String = "INSERT INTO tb_st_trans_ver_det(id_st_trans_ver, id_st_trans_ver_det_ref, is_not_match,is_ok, is_no_stock, is_no_master, is_sale, is_reject, is_unique_not_found, id_product, code, name, size, qty, id_design_price, design_price) 
                SELECT '" + id_new + "', std.id_st_trans_ver_det, is_not_match, is_ok, is_no_stock, is_no_master, is_sale, is_reject, is_unique_not_found, id_product, code, name, size, qty, id_design_price, design_price 
                FROM tb_st_trans_ver_det std
                INNER JOIN tb_st_trans_ver st ON st.id_st_trans_ver = std.id_st_trans_ver 
                WHERE st.id_st_trans_ver>0 AND (" + id_st_trans_ver_det + ") "
                execute_non_query(qd, True, "", "", "", "")


                FormVerStockTake.viewCombine()
                FormVerStockTakeDet.action = "upd"
                FormVerStockTakeDet.id_st_trans_ver = id_new
                FormVerStockTakeDet.ShowDialog()
                Close()
                Cursor = Cursors.Default
            Else
                makeSafeGV(GVCheck)
            End If
        Else
            stopCustom("Please select data first !")
            makeSafeGV(GVCheck)
        End If
    End Sub

    Private Sub SLEWHStockSum_EditValueChanged(sender As Object, e As EventArgs) Handles SLEWHStockSum.EditValueChanged
        viewScan()
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If GVCheck.RowCount > 0 Then
            Dim cek As String = CheckEdit1.EditValue.ToString
            For i As Integer = 0 To ((GVCheck.RowCount - 1) - GetGroupRowCount(GVCheck))
                If cek Then
                    GVCheck.SetRowCellValue(i, "is_select", "Yes")
                Else
                    GVCheck.SetRowCellValue(i, "is_select", "No")
                End If
            Next
        End If
    End Sub
End Class