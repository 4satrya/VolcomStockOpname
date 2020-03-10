Public Class FormScanGlobal
    Dim id_periode As String = "-1"

    Private Sub FormScanGlobal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim qcurr As String = "SELECT * FROM tb_periode p WHERE p.is_default=1"
        Dim dcurr As DataTable = execute_query(qcurr, -1, False, app_host, app_username, app_password, "db_opt")
        id_periode = dcurr.Rows(0)("id_periode").ToString
    End Sub

    Private Sub BtnViewPre_Click(sender As Object, e As EventArgs) Handles BtnViewPre.Click
        If XTCGlobal.SelectedTabPageIndex = 0 Then
            Cursor = Cursors.WaitCursor
            Dim query As String = "SELECT * FROM tb_periode_det d WHERE d.id_periode=" + id_periode + " "
            Dim data As DataTable = execute_query(query, -1, False, app_host, app_username, app_password, "db_opt")
            Dim qd As String = ""
            For i As Integer = 0 To data.Rows.Count - 1
                Dim dbn As String = data.Rows(i)("db_name").ToString
                If i > 0 Then
                    qd += "UNION ALL "
                End If
                qd += "SELECT std.id_st_trans_det, std.id_st_trans, 
                std.is_ok, IF(std.is_ok=1,'Yes', 'No') AS `is_ok_v`,std.is_no_stock, IF(std.is_no_stock=1,'Yes', 'No') AS `is_no_stock_v`, std.is_no_master, IF(std.is_no_master=1,'Yes', 'No') AS `is_no_master_v`, std.is_sale, IF(std.is_sale=1,'Yes', 'No') AS `is_sale_v`, std.is_reject, IF(std.is_reject=1,'Yes', 'No') AS `is_reject_v`,std.is_no_tag, IF(std.is_no_tag=1,'Yes', 'No') AS `is_no_tag_v`, std.is_unique_not_found, IF(std.is_unique_not_found=1,'Yes', 'No') AS `is_unique_not_found_v`,
                std.id_product, std.code, std.name, std.size, std.qty, 
                std.id_design_price, std.design_price, d.is_old_design, cat.id_design_cat, cat.design_cat, typ.design_price_type, st.st_trans_number, st.remark, p.product_full_code
                FROM " + dbn + ".tb_st_trans_det std
                INNER JOIN " + dbn + ".tb_st_trans st ON st.id_st_trans = std.id_st_trans
                LEFT JOIN " + dbn + ".tb_m_product p ON p.id_product = std.id_product
                LEFT JOIN " + dbn + ".tb_m_design d ON d.id_design = p.id_design
                LEFT JOIN " + dbn + ".tb_m_design_price prc ON prc.id_design_price = std.id_design_price
                LEFT JOIN " + dbn + ".tb_lookup_design_price_type typ ON typ.id_design_price_type = prc.id_design_price_type
                LEFT JOIN " + dbn + ".tb_lookup_design_cat cat ON cat.id_design_cat = typ.id_design_cat  "
                qd += "WHERE st.id_report_status!=5 AND st.is_combine=2 AND st.is_pre=1 ORDER BY std.id_st_trans ASC, std.name ASC, RIGHT(p.product_full_code,3) ASC "
            Next
            Dim dd As DataTable = execute_query(qd, -1, True, "", "", "", "")
            GCScan.DataSource = dd
            Cursor = Cursors.Default
        End If
    End Sub

    Private Sub BtnColEx_Click(sender As Object, e As EventArgs) Handles BtnCollapse.Click
        If XTCGlobal.SelectedTabPageIndex = 0 Then
            Cursor = Cursors.WaitCursor
            GVScan.CollapseAllGroups()
            Cursor = Cursors.Default
        End If
    End Sub
End Class