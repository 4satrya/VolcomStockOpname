Public Class FormStockTakeList
    Private Sub FormStockTakeList_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Sub viewDetail()
        Dim query As String = "SELECT std.id_st_trans_det, std.id_st_trans, 
        std.is_ok, IF(std.is_ok=1,'Yes', 'No') AS `is_ok_v`,std.is_no_stock, IF(std.is_no_stock=1,'Yes', 'No') AS `is_no_stock_v`, std.is_no_master, IF(std.is_no_master=1,'Yes', 'No') AS `is_no_master_v`, std.is_sale, IF(std.is_sale=1,'Yes', 'No') AS `is_sale_v`, std.is_reject, IF(std.is_reject=1,'Yes', 'No') AS `is_reject_v`,std.is_no_tag, IF(std.is_no_tag=1,'Yes', 'No') AS `is_no_tag_v`, std.is_unique_not_found, IF(std.is_unique_not_found=1,'Yes', 'No') AS `is_unique_not_found_v`,
        std.id_product, std.code, std.name, std.size, std.qty, 
        std.id_design_price, std.design_price, d.is_old_design, cat.id_design_cat, cat.design_cat, typ.design_price_type, st.st_trans_number, st.remark, p.product_full_code
        FROM tb_st_trans_det std
        INNER JOIN tb_st_trans st ON st.id_st_trans = std.id_st_trans
        LEFT JOIN tb_m_product p ON p.id_product = std.id_product
        LEFT JOIN tb_m_design d ON d.id_design = p.id_design
        LEFT JOIN tb_m_design_price prc ON prc.id_design_price = std.id_design_price
        LEFT JOIN tb_lookup_design_price_type typ ON typ.id_design_price_type = prc.id_design_price_type
        LEFT JOIN tb_lookup_design_cat cat ON cat.id_design_cat = typ.id_design_cat  "
        query += "WHERE st.id_report_status!=5 AND st.is_combine=2 ORDER BY std.id_st_trans_det ASC "
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        GCScan.DataSource = data
    End Sub

    Sub viewSummary()
        'Cursor = Cursors.WaitCursor
        'Dim query As String = "SELECT Std.id_product, d.design_code AS `product_code`, p.product_full_code AS `barcode`, std.name, std.size, 
        'SUM(std.qty) AS `qty`, std.design_price
        'FROM tb_st_trans_det std
        'INNER JOIN tb_st_trans st ON st.id_st_trans = std.id_st_trans
        'INNER JOIN tb_m_product p ON p.id_product = std.id_product 
        'INNER JOIN tb_m_design d ON d.id_design = p.id_design "
        'query += "WHERE std.id_st_trans=" + id_st_trans + " "
        'query += "AND !ISNULL(std.id_product) GROUP BY std.id_product 
        'UNION ALL 
        'SELECT Std.id_product, NULL AS `product_code`, std.code AS `barcode`, std.name, std.size, 
        'SUM(std.qty) AS `qty`, std.design_price
        'FROM tb_st_trans_det std
        'INNER JOIN tb_st_trans st ON st.id_st_trans = std.id_st_trans 
        'WHERE ISNULL(std.id_product) "
        'query += "AND std.id_st_trans=" + id_st_trans + " "
        'query += "GROUP BY std.id_st_trans_det "
        'Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        'GCSummaryScan.DataSource = data
        'Cursor = Cursors.Default
    End Sub

    Sub viewSummaryCat()
        'Dim cond_where As String = ""
        'cond_where = "std.id_st_trans=" + id_st_trans + " "
        'Dim query As String = "SELECT 'OK' AS `cat`,COUNT(*) AS `cat_val`
        'FROM tb_st_trans_det std 
        'INNER JOIN tb_st_trans st ON st.id_st_trans = std.id_st_trans
        'WHERE " + cond_where + " AND std.is_ok=1
        'UNION ALL 
        'SELECT 'No Stock' AS `cat`,COUNT(*) AS `cat_val`
        'FROM tb_st_trans_det std 
        'INNER JOIN tb_st_trans st ON st.id_st_trans = std.id_st_trans
        'WHERE " + cond_where + " AND std.is_no_stock=1
        'UNION ALL
        'SELECT 'Sale' AS `cat`,COUNT(*) AS `cat_val`
        'FROM tb_st_trans_det std 
        'INNER JOIN tb_st_trans st ON st.id_st_trans = std.id_st_trans
        'WHERE " + cond_where + " AND std.is_sale=1
        'UNION ALL
        'SELECT 'Reject' AS `cat`,COUNT(*) AS `cat_val`
        'FROM tb_st_trans_det std 
        'INNER JOIN tb_st_trans st ON st.id_st_trans = std.id_st_trans
        'WHERE " + cond_where + " AND std.is_reject=1
        'UNION ALL
        'SELECT 'No Tag' AS `cat`,COUNT(*) AS `cat_val`
        'FROM tb_st_trans_det std 
        'INNER JOIN tb_st_trans st ON st.id_st_trans = std.id_st_trans
        'WHERE " + cond_where + " AND std.is_no_tag=1
        'UNION ALL
        'SELECT 'Unique not Found' AS `cat`,COUNT(*) AS `cat_val`
        'FROM tb_st_trans_det std 
        'INNER JOIN tb_st_trans st ON st.id_st_trans = std.id_st_trans
        'WHERE " + cond_where + " AND std.is_unique_not_found=1 
        'UNION ALL
        'SELECT 'No Master' AS `cat`,COUNT(*) AS `cat_val`
        'FROM tb_st_trans_det std 
        'INNER JOIN tb_st_trans st ON st.id_st_trans = std.id_st_trans
        'WHERE " + cond_where + " AND std.is_no_master=1 "
        'Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        'GCCat.DataSource = data
    End Sub

    Private Sub FormStockTakeList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewDetail()
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        If XTCStockTake.SelectedTabPageIndex = 0 Then
            GVScan.BestFitColumns()
            print_raw(GCScan, "")
        End If
    End Sub
End Class