﻿Public Class FormScanGlobal
    Dim id_periode As String = "-1"

    Private Sub FormScanGlobal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor = Cursors.WaitCursor
        Dim qcurr As String = "SELECT * FROM tb_periode p WHERE p.is_default=1"
        Dim dcurr As DataTable = execute_query(qcurr, -1, False, app_host, app_username, app_password, "db_opt")
        id_periode = dcurr.Rows(0)("id_periode").ToString
        viewAccount()
        Cursor = Cursors.Default
    End Sub

    Sub viewAccount()
        Dim query As String = "SELECT 'All' AS `account_code`, 'All Account' AS `account_desc`, '0' AS `db_name`
        UNION
        SELECT d.account AS `account_code`, d.account_desc AS `account_desc`, d.db_name
        FROM tb_periode_det d WHERE d.id_periode=" + id_periode + " "
        Dim data As DataTable = execute_query(query, -1, False, app_host, app_username, app_password, "db_opt")
        SLEAccount.Properties.DataSource = Nothing
        SLEAccount.Properties.DataSource = data
        SLEAccount.Properties.DisplayMember = "account_code"
        SLEAccount.Properties.ValueMember = "db_name"
        If data.Rows.Count.ToString >= 1 Then
            SLEAccount.EditValue = data.Rows(0)("db_name").ToString
        Else
            SLEAccount.EditValue = Nothing
        End If
    End Sub

    Private Sub BtnViewPre_Click(sender As Object, e As EventArgs) Handles BtnViewPre.Click
        If XTCGlobal.SelectedTabPageIndex = 0 Then
            If XTCStock.SelectedTabPageIndex = 0 Then
                'by code
                Cursor = Cursors.WaitCursor
                FormMain.SplashScreenManager1.ShowWaitForm()
                Dim cond_db As String = ""
                If SLEAccount.EditValue <> "0" Then
                    cond_db = "AND d.db_name='" + SLEAccount.EditValue.ToString + "' "
                End If
                Dim query As String = "SELECT * FROM tb_periode_det d WHERE d.id_periode=" + id_periode + " " + cond_db + " "
                Dim data As DataTable = execute_query(query, -1, False, app_host, app_username, app_password, "db_opt")
                Dim qd As String = ""
                For i As Integer = 0 To data.Rows.Count - 1
                    FormMain.SplashScreenManager1.SetWaitFormDescription("Generate query " + data.Rows(i)("account").ToString)
                    Dim dbn As String = data.Rows(i)("db_name").ToString
                    If i > 0 Then
                        qd += "UNION ALL "
                    End If
                    qd += "SELECT d.design_code AS `code`, d.design_display_name AS `name`, SUBSTRING(p.product_full_code, 10, 1) AS `sizetype`, "
                    Dim bcounter As Integer = 1
                    While bcounter <= 10
                        If bcounter = 10 Then
                            qd += "SUM(CASE WHEN SUBSTRING(cd.code,2,1)='0' THEN s.qty  END) `0`, "
                        Else
                            qd += "SUM(CASE WHEN SUBSTRING(cd.code,2,1)='" + bcounter.ToString + "' THEN s.qty  END) `" + bcounter.ToString + "`, "
                        End If
                        bcounter += 1
                    End While
                    qd += "SUM(s.qty) AS `total_qty` , IF(c.id_store_type=1 OR c.id_wh_type=1, fd.design_price,s.design_price) AS `design_price`, c.comp_name, c.comp_number
                    FROM " + dbn + ".tb_st_stock s
                    INNER JOIN " + dbn + ".tb_m_product p ON p.id_product = s.id_product
                    INNER JOIN " + dbn + ".tb_m_product_code pc ON pc.id_product = p.id_product
                    INNER JOIN " + dbn + ".tb_m_code_detail cd ON cd.id_code_detail = pc.id_code_detail
                    INNER JOIN " + dbn + ".tb_m_design d ON d.id_design = p.id_design
                    INNER JOIN " + dbn + ".tb_m_comp c ON c.id_drawer_def = s.id_wh_drawer
                    LEFT JOIN " + dbn + ".tb_m_design_first_del fd ON fd.id_design = d.id_design AND fd.id_comp = c.id_comp
                    WHERE 1=1 "
                    qd += "GROUP BY p.id_design, SUBSTRING(p.product_full_code, 10, 1) "
                Next
                FormMain.SplashScreenManager1.SetWaitFormDescription("Fetching data")
                Dim dd As DataTable = execute_query(qd, -1, True, "", "", "", "")
                GCRsv.DataSource = dd
                GVRsv.Columns("1").Caption = "1" + System.Environment.NewLine + "XXS"
                GVRsv.Columns("2").Caption = "2" + System.Environment.NewLine + "XS"
                GVRsv.Columns("3").Caption = "3" + System.Environment.NewLine + "S"
                GVRsv.Columns("4").Caption = "4" + System.Environment.NewLine + "M"
                GVRsv.Columns("5").Caption = "5" + System.Environment.NewLine + "ML"
                GVRsv.Columns("6").Caption = "6" + System.Environment.NewLine + "L"
                GVRsv.Columns("7").Caption = "7" + System.Environment.NewLine + "XL"
                GVRsv.Columns("8").Caption = "8" + System.Environment.NewLine + "XXL"
                GVRsv.Columns("9").Caption = "9" + System.Environment.NewLine + "ALL"
                GVRsv.Columns("0").Caption = "0" + System.Environment.NewLine + "SM"
                GVRsv.RefreshData()
                FormMain.SplashScreenManager1.CloseWaitForm()
                Cursor = Cursors.Default
            ElseIf XTCStock.SelectedTabPageIndex = 1 Then
                'by barcode
                Cursor = Cursors.WaitCursor
                FormMain.SplashScreenManager1.ShowWaitForm()
                Dim cond_db As String = ""
                If SLEAccount.EditValue <> "0" Then
                    cond_db = "AND d.db_name='" + SLEAccount.EditValue.ToString + "' "
                End If
                Dim query As String = "SELECT * FROM tb_periode_det d WHERE d.id_periode=" + id_periode + " " + cond_db + " "
                Dim data As DataTable = execute_query(query, -1, False, app_host, app_username, app_password, "db_opt")
                Dim qd As String = ""
                For i As Integer = 0 To data.Rows.Count - 1
                    FormMain.SplashScreenManager1.SetWaitFormDescription("Generate query " + data.Rows(i)("account").ToString)
                    Dim dbn As String = data.Rows(i)("db_name").ToString
                    If i > 0 Then
                        qd += "UNION ALL "
                    End If
                    qd += "SELECT p.id_product,p.product_full_code AS `barcode`,d.design_code AS `code`, d.design_display_name AS `name`, cd.code_detail_name AS `size`, "
                    qd += "s.qty, IF(c.id_store_type=1 OR c.id_wh_type=1, fd.design_price,s.design_price) AS `design_price`, c.comp_name, c.comp_number
                    FROM " + dbn + ".tb_st_stock s
                    INNER JOIN " + dbn + ".tb_m_product p ON p.id_product = s.id_product
                    INNER JOIN " + dbn + ".tb_m_product_code pc ON pc.id_product = p.id_product
                    INNER JOIN " + dbn + ".tb_m_code_detail cd ON cd.id_code_detail = pc.id_code_detail
                    INNER JOIN " + dbn + ".tb_m_design d ON d.id_design = p.id_design
                    INNER JOIN " + dbn + ".tb_m_comp c ON c.id_drawer_def = s.id_wh_drawer
                    LEFT JOIN " + dbn + ".tb_m_design_first_del fd ON fd.id_design = d.id_design AND fd.id_comp = c.id_comp
                    WHERE 1=1 "
                Next
                If qd <> "" Then
                    qd += "ORDER BY id_product ASC "
                End If
                FormMain.SplashScreenManager1.SetWaitFormDescription("Fetching data")
                Dim dd As DataTable = execute_query(qd, -1, True, "", "", "", "")
                GCRsvBar.DataSource = dd
                FormMain.SplashScreenManager1.CloseWaitForm()
                Cursor = Cursors.Default
            End If
        ElseIf XTCGlobal.SelectedTabPageIndex = 1 Then
            Cursor = Cursors.WaitCursor
            FormMain.SplashScreenManager1.ShowWaitForm()
            Dim cond_db As String = ""
            If SLEAccount.EditValue <> "0" Then
                cond_db = "AND d.db_name='" + SLEAccount.EditValue.ToString + "' "
            End If
            Dim query As String = "SELECT * FROM tb_periode_det d WHERE d.id_periode=" + id_periode + " " + cond_db + " "
            Dim data As DataTable = execute_query(query, -1, False, app_host, app_username, app_password, "db_opt")
            Dim qd As String = ""
            For i As Integer = 0 To data.Rows.Count - 1
                FormMain.SplashScreenManager1.SetWaitFormDescription("Generate query " + data.Rows(i)("account").ToString)
                Dim dbn As String = data.Rows(i)("db_name").ToString
                If i > 0 Then
                    qd += "UNION ALL "
                End If
                qd += "SELECT std.id_st_trans_det, std.id_st_trans, 
                std.is_ok, IF(std.is_ok=1,'Yes', 'No') AS `is_ok_v`,std.is_no_stock, IF(std.is_no_stock=1,'Yes', 'No') AS `is_no_stock_v`, std.is_no_master, IF(std.is_no_master=1,'Yes', 'No') AS `is_no_master_v`, std.is_sale, IF(std.is_sale=1,'Yes', 'No') AS `is_sale_v`, std.is_reject, IF(std.is_reject=1,'Yes', 'No') AS `is_reject_v`,std.is_no_tag, IF(std.is_no_tag=1,'Yes', 'No') AS `is_no_tag_v`, std.is_unique_not_found, IF(std.is_unique_not_found=1,'Yes', 'No') AS `is_unique_not_found_v`,
                std.id_product, std.code, std.name, std.size, std.qty, 
                std.id_design_price, std.design_price, d.is_old_design, cat.id_design_cat, cat.design_cat, typ.design_price_type, st.st_trans_date,st.st_trans_number, c.comp_number, c.comp_name, st.remark, p.product_full_code
                FROM " + dbn + ".tb_st_trans_det std
                INNER JOIN " + dbn + ".tb_st_trans st ON st.id_st_trans = std.id_st_trans
                LEFT JOIN " + dbn + ".tb_m_product p ON p.id_product = std.id_product
                LEFT JOIN " + dbn + ".tb_m_design d ON d.id_design = p.id_design
                LEFT JOIN " + dbn + ".tb_m_design_price prc ON prc.id_design_price = std.id_design_price
                LEFT JOIN " + dbn + ".tb_lookup_design_price_type typ ON typ.id_design_price_type = prc.id_design_price_type
                LEFT JOIN " + dbn + ".tb_lookup_design_cat cat ON cat.id_design_cat = typ.id_design_cat  
                INNER JOIN " + dbn + ".tb_m_comp c ON c.id_drawer_def = st.id_wh_drawer "
                qd += "WHERE st.id_report_status!=5 AND st.is_combine=2 AND st.is_pre=1 "
            Next
            If qd <> "" Then
                qd += "ORDER BY comp_number ASC ,id_st_trans ASC, name ASC, RIGHT(product_full_code,3) ASC "
            End If
            FormMain.SplashScreenManager1.SetWaitFormDescription("Fetching data")
            Dim dd As DataTable = execute_query(qd, -1, True, "", "", "", "")
            GCScan.DataSource = dd
            FormMain.SplashScreenManager1.CloseWaitForm()
            Cursor = Cursors.Default
        ElseIf XTCGlobal.SelectedTabPageIndex = 2 Then
            Cursor = Cursors.WaitCursor
            FormMain.SplashScreenManager1.ShowWaitForm()
            Dim cond_db As String = ""
            If SLEAccount.EditValue <> "0" Then
                cond_db = "AND d.db_name='" + SLEAccount.EditValue.ToString + "' "
            End If
            Dim query As String = "SELECT * FROM tb_periode_det d WHERE d.id_periode=" + id_periode + " " + cond_db + " "
            Dim data As DataTable = execute_query(query, -1, False, app_host, app_username, app_password, "db_opt")
            Dim qd As String = ""
            For i As Integer = 0 To data.Rows.Count - 1
                FormMain.SplashScreenManager1.SetWaitFormDescription("Generate query " + data.Rows(i)("account").ToString)
                Dim dbn As String = data.Rows(i)("db_name").ToString
                If i > 0 Then
                    qd += "UNION ALL "
                End If
                qd += "SELECT std.id_st_trans_ver_det, std.id_st_trans_ver, 
                std.is_ok, IF(std.is_ok=1,'Yes', 'No') AS `is_ok_v`, std.is_not_match, IF(std.is_not_match=1,'Yes', 'No') AS `is_not_match_v`,std.is_no_stock, IF(std.is_no_stock=1,'Yes', 'No') AS `is_no_stock_v`, std.is_no_master, IF(std.is_no_master=1,'Yes', 'No') AS `is_no_master_v`, std.is_sale, IF(std.is_sale=1,'Yes', 'No') AS `is_sale_v`, std.is_reject, IF(std.is_reject=1,'Yes', 'No') AS `is_reject_v`,std.is_no_tag, IF(std.is_no_tag=1,'Yes', 'No') AS `is_no_tag_v`, std.is_unique_not_found, IF(std.is_unique_not_found=1,'Yes', 'No') AS `is_unique_not_found_v`,
                std.id_product, std.code, std.name, std.size, std.qty, 
                std.id_design_price, std.design_price, d.is_old_design, cat.id_design_cat, cat.design_cat, typ.design_price_type, st.st_trans_ver_date,st.st_trans_ver_number, stf.st_trans_number, c.comp_number, c.comp_name, st.remark, stf.remark AS `remark_ref`, p.product_full_code
                FROM " + dbn + ".tb_st_trans_ver_det std
                INNER JOIN " + dbn + ".tb_st_trans_ver st ON st.id_st_trans_ver = std.id_st_trans_ver
                LEFT JOIN " + dbn + ".tb_st_trans stf ON stf.id_st_trans = st.id_st_trans
                LEFT JOIN " + dbn + ".tb_m_product p ON p.id_product = std.id_product
                LEFT JOIN " + dbn + ".tb_m_design d ON d.id_design = p.id_design
                LEFT JOIN " + dbn + ".tb_m_design_price prc ON prc.id_design_price = std.id_design_price
                LEFT JOIN " + dbn + ".tb_lookup_design_price_type typ ON typ.id_design_price_type = prc.id_design_price_type
                LEFT JOIN " + dbn + ".tb_lookup_design_cat cat ON cat.id_design_cat = typ.id_design_cat  
                INNER JOIN " + dbn + ".tb_m_comp c ON c.id_drawer_def = st.id_wh_drawer "
                qd += "WHERE st.id_report_status!=5 AND st.is_combine=2 "
                qd += "UNION ALL "
                qd += "SELECT std.id_st_trans_det AS `id_st_trans_ver_det`, std.id_st_trans AS `id_st_trans_ver`, 
                std.is_ok, IF(std.is_ok=1,'Yes', 'No') AS `is_ok_v`, 2 AS is_not_match,'No' AS `is_not_match_v`,std.is_no_stock, IF(std.is_no_stock=1,'Yes', 'No') AS `is_no_stock_v`, std.is_no_master, IF(std.is_no_master=1,'Yes', 'No') AS `is_no_master_v`, std.is_sale, IF(std.is_sale=1,'Yes', 'No') AS `is_sale_v`, std.is_reject, IF(std.is_reject=1,'Yes', 'No') AS `is_reject_v`,std.is_no_tag, IF(std.is_no_tag=1,'Yes', 'No') AS `is_no_tag_v`, std.is_unique_not_found, IF(std.is_unique_not_found=1,'Yes', 'No') AS `is_unique_not_found_v`,
                std.id_product, std.code, std.name, std.size, std.qty, 
                std.id_design_price, std.design_price, d.is_old_design, cat.id_design_cat, cat.design_cat, typ.design_price_type, st.st_trans_date AS `st_trans_ver_date`,st.st_trans_number AS `st_trans_ver_number`, '' AS `st_trans_number`, c.comp_number, c.comp_name, st.remark, '' AS `remark_ref`, p.product_full_code
                FROM " + dbn + ".tb_st_trans_det std
                INNER JOIN " + dbn + ".tb_st_trans st ON st.id_st_trans = std.id_st_trans
                LEFT JOIN " + dbn + ".tb_m_product p ON p.id_product = std.id_product
                LEFT JOIN " + dbn + ".tb_m_design d ON d.id_design = p.id_design
                LEFT JOIN " + dbn + ".tb_m_design_price prc ON prc.id_design_price = std.id_design_price
                LEFT JOIN " + dbn + ".tb_lookup_design_price_type typ ON typ.id_design_price_type = prc.id_design_price_type
                LEFT JOIN " + dbn + ".tb_lookup_design_cat cat ON cat.id_design_cat = typ.id_design_cat  
                INNER JOIN " + dbn + ".tb_m_comp c ON c.id_drawer_def = st.id_wh_drawer "
                qd += "WHERE st.id_report_status!=5 AND st.is_combine=2 AND st.is_pre=2 "
            Next
            If qd <> "" Then
                qd += "ORDER BY comp_number ASC ,id_st_trans_ver ASC, name ASC, RIGHT(product_full_code,3) ASC "
            End If
            FormMain.SplashScreenManager1.SetWaitFormDescription("Fetching data")
            Dim dd As DataTable = execute_query(qd, -1, True, "", "", "", "")
            GCST.DataSource = dd
            FormMain.SplashScreenManager1.CloseWaitForm()
            Cursor = Cursors.Default
        ElseIf XTCGlobal.SelectedTabPageIndex = 3 Then
            Cursor = Cursors.WaitCursor
            FormMain.SplashScreenManager1.ShowWaitForm()
            Dim cond_db As String = ""
            If SLEAccount.EditValue <> "0" Then
                cond_db = "AND d.db_name='" + SLEAccount.EditValue.ToString + "' "
            End If
            Dim query As String = "SELECT * FROM tb_periode_det d WHERE d.id_periode=" + id_periode + " " + cond_db + " "
            Dim data As DataTable = execute_query(query, -1, False, app_host, app_username, app_password, "db_opt")
            Dim qd As String = ""
            For i As Integer = 0 To data.Rows.Count - 1
                FormMain.SplashScreenManager1.SetWaitFormDescription("Generate query " + data.Rows(i)("account").ToString)
                Dim dbn As String = data.Rows(i)("db_name").ToString
                Dim account As String = data.Rows(i)("account").ToString
                Dim account_desc As String = data.Rows(i)("account_desc").ToString
                If i > 0 Then
                    qd += "UNION ALL "
                End If
                qd += "SELECT '" + account + "' AS `account`, '" + account_desc + "' AS `account_desc`, 
                IFNULL(soh.soh_qty,0) AS `soh_qty`, IFNULL(soh.soh_amount,0) AS `soh_amount`, 
                IFNULL(pre.pre_qty,0) AS `pre_qty`, IFNULL(pre.pre_amount,0) AS `pre_amount`,
                (IFNULL(st_store.st_store_qty,0) + IFNULL(st_wh.st_wh_qty,0)) AS `st_qty`, (IFNULL(st_store.st_store_amount,0) + IFNULL(st_wh.st_wh_amount,0)) AS `st_amount`
                FROM (
	                SELECT SUM(s.qty) AS `soh_qty` , 
	                SUM(IF(c.id_store_type=1 OR c.id_wh_type=1, fd.design_price,s.design_price) * s.qty) AS `soh_amount`
	                FROM " + dbn + ".tb_st_stock s
	                INNER JOIN " + dbn + ".tb_m_product p ON p.id_product = s.id_product
	                INNER JOIN " + dbn + ".tb_m_design d ON d.id_design = p.id_design
	                INNER JOIN " + dbn + ".tb_m_comp c ON c.id_drawer_def = s.id_wh_drawer
	                LEFT JOIN " + dbn + ".tb_m_design_first_del fd ON fd.id_design = d.id_design AND fd.id_comp = c.id_comp
                ) soh
                JOIN (
	                SELECT SUM(td.qty) AS `pre_qty` , SUM(td.qty * td.design_price) AS `pre_amount`
	                FROM " + dbn + ".tb_st_trans t
	                INNER JOIN " + dbn + ".tb_st_trans_det td ON td.id_st_trans = t.id_st_trans
	                WHERE t.id_report_status!=5 AND t.is_pre=1 AND t.is_combine=2
                ) pre
                JOIN (
	                SELECT SUM(td.qty) AS `st_store_qty` , SUM(td.qty * td.design_price) AS `st_store_amount`
	                FROM " + dbn + ".tb_st_trans t
	                INNER JOIN " + dbn + ".tb_st_trans_det td ON td.id_st_trans = t.id_st_trans
	                WHERE t.id_report_status!=5 AND t.is_pre=2 AND t.is_combine=2
                ) st_store 
                JOIN (
	                SELECT SUM(td.qty) AS `st_wh_qty` , SUM(td.qty * td.design_price) AS `st_wh_amount`
	                FROM " + dbn + ".tb_st_trans_ver t
	                INNER JOIN " + dbn + ".tb_st_trans_ver_det td ON td.id_st_trans_ver = t.id_st_trans_ver
	                WHERE t.id_report_status!=5 AND t.is_combine=2
                ) st_wh "
            Next
            If qd <> "" Then
                qd += "ORDER BY account ASC "
            End If
            FormMain.SplashScreenManager1.SetWaitFormDescription("Fetching data")
            Dim dd As DataTable = execute_query(qd, -1, True, "", "", "", "")
            GCSummary.DataSource = dd
            GVSummary.BestFitColumns()
            FormMain.SplashScreenManager1.CloseWaitForm()
            Cursor = Cursors.Default
        ElseIf XTCGlobal.SelectedTabPageIndex = 4 Then
            Cursor = Cursors.WaitCursor
            FormMain.SplashScreenManager1.ShowWaitForm()
            Dim cond_db As String = ""
            If SLEAccount.EditValue <> "0" Then
                cond_db = "AND d.db_name='" + SLEAccount.EditValue.ToString + "' "
            End If
            Dim query As String = "SELECT * FROM tb_periode_det d WHERE d.id_periode=" + id_periode + " " + cond_db + " "
            Dim data As DataTable = execute_query(query, -1, False, app_host, app_username, app_password, "db_opt")
            Dim qd As String = ""
            For i As Integer = 0 To data.Rows.Count - 1
                FormMain.SplashScreenManager1.SetWaitFormDescription("Generate query " + data.Rows(i)("account").ToString)
                Dim dbn As String = data.Rows(i)("db_name").ToString
                Dim account As String = data.Rows(i)("account").ToString
                Dim account_desc As String = data.Rows(i)("account_desc").ToString
                If i > 0 Then
                    qd += "UNION ALL "
                End If
                qd += "SELECT '" + account + "' AS `account`, '" + account_desc + "' AS `account_desc`,p.id_st_trans, p.st_trans_number AS `pre_number`,p.remark AS `pre_remark`, 
                SUM(pd.qty) AS `pre_qty`, SUM(pd.qty * pd.design_price) AS `pre_amount`, 
                s.st_number AS `st_number`,s.st_remark AS `st_remark`, IFNULL(s.st_qty,0) AS `st_qty`, IFNULL(s.st_amount,0) AS `st_amount`
                FROM " + dbn + ".tb_st_trans p
                INNER JOIN " + dbn + ".tb_st_trans_det pd ON pd.id_st_trans = p.id_st_trans
                LEFT JOIN (
	                SELECT s.id_st_trans,s.st_trans_ver_number AS `st_number` , s.remark AS `st_remark`, 
	                SUM(sd.qty) AS `st_qty`, SUM(sd.qty * sd.design_price) AS `st_amount`
	                FROM " + dbn + ".tb_st_trans_ver s
	                INNER JOIN " + dbn + ".tb_st_trans_ver_det sd ON sd.id_st_trans_ver = s.id_st_trans_ver
	                WHERE s.id_report_status!=5 AND s.is_combine=2
	                GROUP BY s.id_st_trans
                ) s ON s.id_st_trans = p.id_st_trans
                WHERE p.is_pre=1 AND p.id_report_status!=5 AND p.is_combine=2
                GROUP BY p.id_st_trans "
            Next
            If qd <> "" Then
                'qd += "ORDER BY account ASC "
            End If
            FormMain.SplashScreenManager1.SetWaitFormDescription("Fetching data")
            Dim dd As DataTable = execute_query(qd, -1, True, "", "", "", "")
            GCSummaryPreST.DataSource = dd
            GVSummaryPreST.BestFitColumns()
            FormMain.SplashScreenManager1.CloseWaitForm()
            Cursor = Cursors.Default
        End If
    End Sub

    Private Sub BtnColEx_Click(sender As Object, e As EventArgs) Handles BtnCollapse.Click
        If XTCGlobal.SelectedTabPageIndex = 0 Then
            Cursor = Cursors.WaitCursor
            If XTCStock.SelectedTabPageIndex = 0 Then
                GVRsv.CollapseAllGroups()
            ElseIf XTCStock.SelectedTabPageIndex = 1 Then
                GVRsvBar.CollapseAllGroups()
            End If
            Cursor = Cursors.Default
        ElseIf XTCGlobal.SelectedTabPageIndex = 1 Then

        ElseIf XTCGlobal.SelectedTabPageIndex = 2 Then
            Cursor = Cursors.WaitCursor
            GVST.CollapseAllGroups()
            Cursor = Cursors.Default
        ElseIf XTCGlobal.SelectedTabPageIndex = 3 Then
            Cursor = Cursors.WaitCursor
            GVST.CollapseAllGroups()
            Cursor = Cursors.Default
        ElseIf XTCGlobal.SelectedTabPageIndex = 4 Then
            Cursor = Cursors.WaitCursor
            GVSummaryPreST.CollapseAllGroups()
            Cursor = Cursors.Default
        End If
    End Sub

    Private Sub BtnExpanseAllGroup_Click(sender As Object, e As EventArgs) Handles BtnExpanseAllGroup.Click
        If XTCGlobal.SelectedTabPageIndex = 0 Then
            Cursor = Cursors.WaitCursor
            If XTCStock.SelectedTabPageIndex = 0 Then
                GVRsv.ExpandAllGroups()
            ElseIf XTCStock.SelectedTabPageIndex = 1 Then
                GVRsvBar.ExpandAllGroups()
            End If
            Cursor = Cursors.Default
        ElseIf XTCGlobal.SelectedTabPageIndex = 1 Then
            Cursor = Cursors.WaitCursor
            GVScan.ExpandAllGroups()
            Cursor = Cursors.Default
        ElseIf XTCGlobal.SelectedTabPageIndex = 2 Then
            Cursor = Cursors.WaitCursor
            GVST.ExpandAllGroups()
            Cursor = Cursors.Default
        ElseIf XTCGlobal.SelectedTabPageIndex = 3 Then
            Cursor = Cursors.WaitCursor
            GVST.ExpandAllGroups()
            Cursor = Cursors.Default
        ElseIf XTCGlobal.SelectedTabPageIndex = 4 Then
            Cursor = Cursors.WaitCursor
            GVSummaryPreST.ExpandAllGroups()
            Cursor = Cursors.Default
        End If
    End Sub

    Private Sub GVScan_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GVScan.CustomColumnDisplayText
        If e.Column.FieldName = "no" Then
            Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(sender, DevExpress.XtraGrid.Views.Grid.GridView)
            If view.GroupedColumns.Count <> 0 AndAlso Not e.IsForGroupRow Then
                Dim rowHandle As Integer = view.GetRowHandle(e.ListSourceRowIndex)
                e.DisplayText = (view.GetRowGroupIndexByRowHandle(rowHandle) + 1).ToString()
            End If
        End If
    End Sub

    Private Sub SLEAccount_EditValueChanged(sender As Object, e As EventArgs) Handles SLEAccount.EditValueChanged
        GCRsv.DataSource = Nothing
        GCRsvBar.DataSource = Nothing
        GCScan.DataSource = Nothing
        GCST.DataSource = Nothing
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        Cursor = Cursors.WaitCursor
        If XTCGlobal.SelectedTabPageIndex = 0 Then
            If XTCStock.SelectedTabPageIndex = 0 Then
                print_raw(GCRsv, "")
            ElseIf XTCStock.SelectedTabPageIndex = 1 Then
                print_raw(GCRsvBar, "")
            End If
        ElseIf XTCGlobal.SelectedTabPageIndex = 1 Then
            print_raw(GCScan, "")
        ElseIf XTCGlobal.SelectedTabPageIndex = 2 Then
            print_raw(GCST, "")
        ElseIf XTCGlobal.SelectedTabPageIndex = 3 Then
            print_raw(GCSummary, "")
        ElseIf XTCGlobal.SelectedTabPageIndex = 4 Then
            print_raw(GCSummaryPreST, "")
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub BtnExportXLS_Click(sender As Object, e As EventArgs) Handles BtnExportXLS.Click
        Cursor = Cursors.WaitCursor
        If XTCGlobal.SelectedTabPageIndex = 0 Then
            If XTCStock.SelectedTabPageIndex = 0 Then
                If GVRsv.RowCount > 0 Then
                    Cursor = Cursors.WaitCursor

                    Dim path As String = Application.StartupPath & "\download\"
                    'create directory if not exist
                    If Not IO.Directory.Exists(path) Then
                        System.IO.Directory.CreateDirectory(path)
                    End If
                    Dim uTime As Integer = (DateTime.UtcNow - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds
                    path = path + "soh_global_" + SLEAccount.ToString + "_" + uTime.ToString + ".xlsx"
                    exportToXLSDataAware(path, "soh global", GCRsv)
                    Cursor = Cursors.Default
                End If
            ElseIf XTCStock.SelectedTabPageIndex = 1 Then
                If GVRsvBar.RowCount > 0 Then
                    Cursor = Cursors.WaitCursor

                    Dim path As String = Application.StartupPath & "\download\"
                    'create directory if not exist
                    If Not IO.Directory.Exists(path) Then
                        System.IO.Directory.CreateDirectory(path)
                    End If
                    Dim uTime As Integer = (DateTime.UtcNow - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds
                    path = path + "soh_global_barcode_" + SLEAccount.ToString + "_" + uTime.ToString + ".xlsx"
                    exportToXLSDataAware(path, "soh global barcode", GCRsvBar)
                    Cursor = Cursors.Default
                End If
            End If
        ElseIf XTCGlobal.SelectedTabPageIndex = 1 Then
            If GVScan.RowCount > 0 Then
                Cursor = Cursors.WaitCursor

                Dim path As String = Application.StartupPath & "\download\"
                'create directory if not exist
                If Not IO.Directory.Exists(path) Then
                    System.IO.Directory.CreateDirectory(path)
                End If
                Dim uTime As Integer = (DateTime.UtcNow - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds
                path = path + "scan_global_pre_stocktake_" + SLEAccount.ToString + "_" + uTime.ToString + ".xlsx"
                exportToXLSDataAware(path, "scan global pre", GCScan)
                Cursor = Cursors.Default
            End If
        ElseIf XTCGlobal.SelectedTabPageIndex = 2 Then
            If GVST.RowCount > 0 Then
                Cursor = Cursors.WaitCursor

                Dim path As String = Application.StartupPath & "\download\"
                'create directory if not exist
                If Not IO.Directory.Exists(path) Then
                    System.IO.Directory.CreateDirectory(path)
                End If
                Dim uTime As Integer = (DateTime.UtcNow - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds
                path = path + "scan_global_stocktake_" + SLEAccount.ToString + "_" + uTime.ToString + ".xlsx"
                exportToXLSDataAware(path, "scan global", GCST)
                Cursor = Cursors.Default
            End If
        ElseIf XTCGlobal.SelectedTabPageIndex = 3 Then
            If GVSummary.RowCount > 0 Then
                Cursor = Cursors.WaitCursor

                Dim path As String = Application.StartupPath & "\download\"
                'create directory if not exist
                If Not IO.Directory.Exists(path) Then
                    System.IO.Directory.CreateDirectory(path)
                End If
                Dim uTime As Integer = (DateTime.UtcNow - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds
                path = path + "summary_global_stocktake_" + SLEAccount.ToString + "_" + uTime.ToString + ".xlsx"
                exportToXLSDataAware(path, "summary global", GCSummary)
                Cursor = Cursors.Default
            End If
        ElseIf XTCGlobal.SelectedTabPageIndex = 4 Then
            If GVSummaryPreST.RowCount > 0 Then
                Cursor = Cursors.WaitCursor

                Dim path As String = Application.StartupPath & "\download\"
                'create directory if not exist
                If Not IO.Directory.Exists(path) Then
                    System.IO.Directory.CreateDirectory(path)
                End If
                Dim uTime As Integer = (DateTime.UtcNow - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds
                path = path + "summary_pre_stocktake_" + SLEAccount.ToString + "_" + uTime.ToString + ".xlsx"
                exportToXLSDataAware(path, "summary pre st", GCSummaryPreST)
                Cursor = Cursors.Default
            End If
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub GVST_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GVST.CustomColumnDisplayText
        If e.Column.FieldName = "no" Then
            Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(sender, DevExpress.XtraGrid.Views.Grid.GridView)
            If view.GroupedColumns.Count <> 0 AndAlso Not e.IsForGroupRow Then
                Dim rowHandle As Integer = view.GetRowHandle(e.ListSourceRowIndex)
                e.DisplayText = (view.GetRowGroupIndexByRowHandle(rowHandle) + 1).ToString()
            End If
        End If
    End Sub

    Private Sub GVSummary_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GVSummary.CustomColumnDisplayText
        If e.Column.FieldName = "no" Then
            e.DisplayText = (e.ListSourceRowIndex + 1).ToString()
        End If
    End Sub

    Private Sub GVSummaryPreST_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GVSummaryPreST.CustomColumnDisplayText
        If e.Column.FieldName = "no" Then
            Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(sender, DevExpress.XtraGrid.Views.Grid.GridView)
            If view.GroupedColumns.Count <> 0 AndAlso Not e.IsForGroupRow Then
                Dim rowHandle As Integer = view.GetRowHandle(e.ListSourceRowIndex)
                e.DisplayText = (view.GetRowGroupIndexByRowHandle(rowHandle) + 1).ToString()
            End If
        End If
    End Sub
End Class