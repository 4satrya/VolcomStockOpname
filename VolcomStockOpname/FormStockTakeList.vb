﻿Public Class FormStockTakeList
    Private is_login_store As String = "2"

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
        query += "WHERE st.id_report_status!=5 AND st.is_combine=2 AND st.is_pre=" + FormStockTake.is_pre + " ORDER BY std.id_st_trans ASC, std.name ASC, RIGHT(p.product_full_code,3) ASC "
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        GCScan.DataSource = data
    End Sub

    Sub viewSummary()
        Cursor = Cursors.WaitCursor
        Dim query As String = "SELECT st.id_st_trans,st.st_trans_number, st.remark,std.id_product, d.design_code AS `product_code`, p.product_full_code AS `barcode`, std.name, std.size, 
        SUM(std.qty) AS `qty`, std.design_price, prct.design_price_type AS `price_type`
        FROM tb_st_trans_det std
        INNER JOIN tb_st_trans st ON st.id_st_trans = std.id_st_trans
        INNER JOIN tb_m_product p ON p.id_product = std.id_product 
        INNER JOIN tb_m_design d ON d.id_design = p.id_design 
        INNER JOIN tb_m_design_price prc ON prc.id_design_price = std.id_design_price
        INNER JOIN tb_lookup_design_price_type prct ON prct.id_design_price_type = prc.id_design_price_type "
        query += "WHERE st.id_report_status!=5 AND st.is_combine=2 AND st.is_pre=" + FormStockTake.is_pre + " "
        query += "AND !ISNULL(std.id_product) GROUP BY std.id_product, std.id_st_trans 
        UNION ALL 
        SELECT st.id_st_trans,st.st_trans_number, st.remark,std.id_product, NULL AS `product_code`, std.code AS `barcode`, std.name, std.size, 
        SUM(std.qty) AS `qty`, std.design_price, '-' AS price_type
        FROM tb_st_trans_det std
        INNER JOIN tb_st_trans st ON st.id_st_trans = std.id_st_trans 
        WHERE ISNULL(std.id_product) "
        query += "AND st.id_report_status!=5 AND st.is_combine=2 AND st.is_pre=" + FormStockTake.is_pre + " "
        query += "GROUP BY std.code, std.id_st_trans  
        ORDER BY id_st_trans ASC,name ASC, RIGHT(barcode,3) ASC  "
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        GCSummaryScan.DataSource = data
        Cursor = Cursors.Default
    End Sub

    Sub viewSummaryCat()
        Dim cond_where As String = ""
        cond_where = "st.id_report_status!=5 AND st.is_combine=2 "
        Dim query As String = "SELECT 'OK' AS `cat`,SUM(std.qty) AS `cat_val`
        FROM tb_st_trans_det std 
        INNER JOIN tb_st_trans st ON st.id_st_trans = std.id_st_trans
        WHERE " + cond_where + " AND std.is_ok=1 AND st.is_pre=" + FormStockTake.is_pre + "
        UNION ALL 
        SELECT 'No Stock' AS `cat`,SUM(std.qty) AS `cat_val`
        FROM tb_st_trans_det std 
        INNER JOIN tb_st_trans st ON st.id_st_trans = std.id_st_trans
        WHERE " + cond_where + " AND std.is_no_stock=1 AND st.is_pre=" + FormStockTake.is_pre + "
        UNION ALL
        SELECT 'Sale' AS `cat`,SUM(std.qty) AS `cat_val`
        FROM tb_st_trans_det std 
        INNER JOIN tb_st_trans st ON st.id_st_trans = std.id_st_trans
        WHERE " + cond_where + " AND std.is_sale=1 AND st.is_pre=" + FormStockTake.is_pre + "
        UNION ALL
        SELECT 'Reject' AS `cat`,SUM(std.qty) AS `cat_val`
        FROM tb_st_trans_det std 
        INNER JOIN tb_st_trans st ON st.id_st_trans = std.id_st_trans
        WHERE " + cond_where + " AND std.is_reject=1 AND st.is_pre=" + FormStockTake.is_pre + "
        UNION ALL
        SELECT 'No Tag' AS `cat`,SUM(std.qty) AS `cat_val`
        FROM tb_st_trans_det std 
        INNER JOIN tb_st_trans st ON st.id_st_trans = std.id_st_trans
        WHERE " + cond_where + " AND std.is_no_tag=1 AND st.is_pre=" + FormStockTake.is_pre + "
        UNION ALL
        SELECT 'Unique not Found' AS `cat`,SUM(std.qty) AS `cat_val`
        FROM tb_st_trans_det std 
        INNER JOIN tb_st_trans st ON st.id_st_trans = std.id_st_trans
        WHERE " + cond_where + " AND std.is_unique_not_found=1 AND st.is_pre=" + FormStockTake.is_pre + " 
        UNION ALL
        SELECT 'No Master' AS `cat`,SUM(std.qty) AS `cat_val`
        FROM tb_st_trans_det std 
        INNER JOIN tb_st_trans st ON st.id_st_trans = std.id_st_trans
        WHERE " + cond_where + " AND std.is_no_master=1 AND st.is_pre=" + FormStockTake.is_pre + " "

        If is_login_store = "1" Then
            query = "
            SELECT 'OK' AS `cat`,SUM(std.qty) AS `cat_val`
            FROM tb_st_trans_det std 
            INNER JOIN tb_st_trans st ON st.id_st_trans = std.id_st_trans
            WHERE " + cond_where + " AND std.is_ok=1 AND st.is_pre=" + FormStockTake.is_pre + "
            UNION ALL 
            SELECT 'Reject' AS `cat`,SUM(std.qty) AS `cat_val`
            FROM tb_st_trans_det std 
            INNER JOIN tb_st_trans st ON st.id_st_trans = std.id_st_trans
            WHERE " + cond_where + " AND std.is_reject=1 AND st.is_pre=" + FormStockTake.is_pre + "
        "
        End If

        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        GCCat.DataSource = data
    End Sub

    Private Sub FormStockTakeList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            is_login_store = execute_query("SELECT is_login_store FROM tb_opt", 0, False, app_host, app_username, app_password, "db_opt")
        Catch ex As Exception
        End Try

        If is_login_store = "1" Then
            GVScan.Columns("is_ok_v").Visible = False
            GVScan.Columns("is_no_stock_v").Visible = False
            GVScan.Columns("is_sale_v").Visible = False
            GVScan.Columns("is_reject_v").Visible = False
            GVScan.Columns("is_no_tag_v").Visible = False
            GVScan.Columns("is_unique_not_found_v").Visible = False
            GVScan.Columns("is_no_master_v").Visible = False

            GVScan.Columns("remark").Caption = "Lokasi"
            GVSummaryScan.Columns("remark").Caption = "Lokasi"

            Try
                view_error_import()
            Catch ex As Exception
            End Try

            XTPErrorImport.PageVisible = True
        End If

        viewDetail()
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        print()
    End Sub

    Sub print()
        Cursor = Cursors.WaitCursor
        If XTCStockTake.SelectedTabPageIndex = 0 Then
            GVScan.BestFitColumns()
            print_raw(GCScan, "")
        ElseIf XTCStockTake.SelectedTabPageIndex = 1 Then
            GVSummaryScan.BestFitColumns()
            print_raw(GCSummaryScan, "")
        ElseIf XTCStockTake.SelectedTabPageIndex = 2 Then
            GVCat.BestFitColumns()
            print_raw(GCCat, "")
        ElseIf XTCStockTake.SelectedTabPageIndex = 3 Then
            GVErrorImport.BestFitColumns()
            print_raw(GCErrorImport, "")
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub XTCStockTake_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XTCStockTake.SelectedPageChanged
        If XTCStockTake.SelectedTabPageIndex = 0 Then
            viewDetail()
        ElseIf XTCStockTake.SelectedTabPageIndex = 1 Then
            viewSummary()
        ElseIf XTCStockTake.SelectedTabPageIndex = 2 Then
            viewSummaryCat()
        End If
    End Sub

    Private Sub GVScan_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GVScan.CustomColumnDisplayText
        If e.Column.FieldName = "no" Then
            e.DisplayText = (e.ListSourceRowIndex + 1).ToString()
        End If
    End Sub

    Private Sub GVSummaryScan_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GVSummaryScan.CustomColumnDisplayText
        If e.Column.FieldName = "no" Then
            e.DisplayText = (e.ListSourceRowIndex + 1).ToString()
        End If
    End Sub

    Private Sub FormStockTakeList_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F4 Then
            print()
        End If
    End Sub

    Private Sub GVCat_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GVCat.CustomColumnDisplayText
        If e.Column.FieldName = "no" Then
            e.DisplayText = (e.ListSourceRowIndex + 1).ToString()
        End If
    End Sub

    Private Sub GVScan_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GVScan.RowCellStyle
        If is_login_store = "1" Then
            e.Appearance.BackColor = Color.LightGreen

            If GVScan.GetRowCellValue(e.RowHandle, "is_reject_v").ToString = "Yes" Then
                e.Appearance.BackColor = Color.LightYellow
            End If
        End If
    End Sub

    Sub view_error_import()
        Dim query As String = "
            SELECT 0 AS `no`, 1 AS qty, `std`.* , cat.design_cat, typ.design_price_type
            FROM tb_st_import_report AS `std`
            LEFT JOIN tb_m_design_price prc ON prc.id_design_price = std.id_design_price
            LEFT JOIN tb_lookup_design_price_type typ ON typ.id_design_price_type = prc.id_design_price_type
            LEFT JOIN tb_lookup_design_cat cat ON cat.id_design_cat = typ.id_design_cat
            ORDER BY `std`.created_at DESC
        "

        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")

        'numbering
        For i = 0 To data.Rows.Count - 1
            data.Rows(i)("no") = i + 1
        Next

        GCErrorImport.DataSource = data

        GVErrorImport.BestFitColumns()
    End Sub

    Private Sub GVErrorImport_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GVErrorImport.RowCellStyle
        e.Appearance.BackColor = Color.LightGreen

        If GVErrorImport.GetRowCellValue(e.RowHandle, "is_reject").ToString = "1" Then
            e.Appearance.BackColor = Color.LightYellow
        End If
    End Sub
End Class