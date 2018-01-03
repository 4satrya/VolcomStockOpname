Public Class FormStockTakeDet
    Public id_st_trans As String = "-1"
    Public action As String = ""
    Public is_combine As String = "2"
    Dim id_report_status As String = "-1"
    Dim id_comp As String = "-1'"
    Dim id_drawer As String = "-1"

    Private Sub FormStockTakeDet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewWHStockSum()
        viewReportStatus()
        actionLoad()
    End Sub

    Sub viewReportStatus()
        Dim query As String = "SELECT * FROM tb_lookup_report_status s WHERE s.id_report_status=1 OR s.id_report_status=3 OR s.id_report_status=5 OR s.id_report_status=6 "
        viewLookupQuery(LEStatus, query, 0, "report_status", "id_report_status")
    End Sub

    Sub viewWHStockSum()
        Dim query As String = getQueryWHDrawer()
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        SLEWHStockSum.Properties.DataSource = Nothing
        SLEWHStockSum.Properties.DataSource = data
        SLEWHStockSum.Properties.DisplayMember = "comp_name_label"
        SLEWHStockSum.Properties.ValueMember = "id_drawer_def"
        If data.Rows.Count.ToString >= 1 Then
            SLEWHStockSum.EditValue = "0"
        Else
            SLEWHStockSum.EditValue = Nothing
        End If
    End Sub

    Sub actionLoad()
        If action = "ins" Then
            BtnPrint.Enabled = False
            LEStatus.Enabled = False
            BtnSetStatus.Enabled = False
        ElseIf action = "upd" Then
            BtnPrint.Enabled = True
            SLEWHStockSum.Enabled = False

            'main
            Dim st As New ClassStockTake
            Dim query As String = st.queryTransMain("AND st.id_st_trans='" + id_st_trans + "' ", "1")
            Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
            SLEWHStockSum.EditValue = data.Rows(0)("id_wh_drawer").ToString
            TxtNumber.Text = data.Rows(0)("st_trans_number").ToString
            DECreated.Text = data.Rows(0)("st_trans_date")
            LEStatus.ItemIndex = LEStatus.Properties.GetDataSourceRowIndex("id_report_status", data.Rows(0)("id_report_status").ToString)
            id_report_status = data.Rows(0)("id_report_status").ToString
            id_comp = data.Rows(0)("id_comp").ToString
            id_drawer = data.Rows(0)("id_wh_drawer").ToString

            viewDetail()
            allow_status()
        End If
    End Sub

    Sub viewDetail()
        Dim query As String = "SELECT std.id_st_trans_det, std.id_st_trans, 
        std.is_ok, IF(std.is_ok=1,'Yes', 'No') AS `is_ok_v`,std.is_no_stock, IF(std.is_no_stock=1,'Yes', 'No') AS `is_no_stock_v`, std.is_no_master, IF(std.is_no_master=1,'Yes', 'No') AS `is_no_master_v`, std.is_sale, IF(std.is_sale=1,'Yes', 'No') AS `is_sale_v`, std.is_reject, IF(std.is_reject=1,'Yes', 'No') AS `is_reject_v`, std.is_unique_not_found, IF(std.is_unique_not_found=1,'Yes', 'No') AS `is_unique_not_found_v`,
        std.id_product, std.code, std.name, std.size, std.qty, 
        std.id_design_price, std.design_price, d.is_old_design, cat.id_design_cat, cat.design_cat
        FROM tb_st_trans_det std
        LEFT JOIN tb_m_product p ON p.id_product = std.id_product
        LEFT JOIN tb_m_design d ON d.id_design = p.id_design
        LEFT JOIN tb_m_design_price prc ON prc.id_design_price = std.id_design_price
        LEFT JOIN tb_lookup_design_price_type typ ON typ.id_design_price_type = prc.id_design_price_type
        LEFT JOIN tb_lookup_design_cat cat ON cat.id_design_cat = typ.id_design_cat
        WHERE std.id_st_trans=" + id_st_trans + " ORDER BY std.id_st_trans_det ASC "
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        GCScan.DataSource = data
    End Sub

    Sub viewSummary()
        Cursor = Cursors.WaitCursor
        Dim query As String = "SELECT Std.id_product, p.product_full_code AS `product_code`, std.code AS `scanned_code`, std.name, std.size, 
        SUM(std.qty) AS `qty`, std.design_price
        FROM tb_st_trans_det std
        LEFT JOIN tb_m_product p ON p.id_product = std.id_product
        WHERE std.id_st_trans=" + id_st_trans + "
        GROUP BY std.id_product "
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        GCSummaryScan.DataSource = data
        Cursor = Cursors.Default
    End Sub

    Sub allow_status()

        If id_report_status = "5" Or id_report_status = "6" Then
            LEStatus.Enabled = False
            BtnSetStatus.Enabled = False
            PanelControlNav.Visible = False
            'BtnSave.Enabled = False
        Else
            LEStatus.Enabled = True
            BtnSetStatus.Enabled = True
            PanelControlNav.Visible = True
            'BtnSave.Enabled = True
        End If
    End Sub

    Private Sub BtnSetStatus_Click(sender As Object, e As EventArgs) Handles BtnSetStatus.Click
        Dim confirm As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure you want to " + LEStatus.Text.ToLower + " this transaction ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If confirm = DialogResult.Yes Then
            Dim query As String = "UPDATE tb_st_trans SET id_report_status ='" + LEStatus.EditValue.ToString + "' WHERE id_st_trans='" + id_st_trans + "' "
            execute_non_query(query, True, "", "", "", "")
            FormStockTake.viewScan()
            FormStockTake.GVScan.FocusedRowHandle = find_row(FormStockTake.GVScan, "id_st_trans", id_st_trans)
            action = "upd"
            actionLoad()
        End If
    End Sub

    Sub add()
        TxtScan.Focus()
    End Sub

    Sub del()
        FormStockTakeDel.ShowDialog()
    End Sub

    Sub print()

    End Sub

    Private Sub FormStockTakeDet_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.F2 Then
            add()
        ElseIf e.KeyCode = Keys.F3 Then
            del()
        ElseIf e.KeyCode = Keys.F4 Then
            print()
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        add()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        del()
    End Sub

    Private Sub DeleteItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteItemToolStripMenuItem.Click
        If GVScan.RowCount > 0 And GVScan.FocusedRowHandle >= 0 Then
            Dim confirm As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure you want to " + LEStatus.Text.ToLower + " this transaction ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            If confirm = DialogResult.Yes Then
                Dim query As String = "DELETE FROM tb_st_trans_det WHERE id_st_trans_det='" + GVScan.GetFocusedRowCellValue("id_st_trans_det").ToString + "' "
                execute_non_query(query, True, "", "", "", "")
                viewDetail()
            End If
        End If
    End Sub

    Private Sub TxtScan_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtScan.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim code As String = addSlashes(TxtScan.Text)
            Dim code_check As String = ""
            If code.Length > 12 Then
                code_check = code.Substring(0, 12)
            Else
                code_check = code
            End If

            'checedit reject
            Dim is_reject As String = ""
            If CheckEditReject.EditValue.ToString = "True" Then
                is_reject = "1"
            Else
                is_reject = "2"
            End If

            'check di master
            Dim query_check As String = "SELECT p.id_product, p.product_full_code AS `code`, d.design_code, d.design_display_name AS `name`, cd.code_detail_name AS `size`, d.is_old_design, IFNULL(st.qty,0) AS `qty`,
            comp.id_comp_cat,IF(comp.id_comp_cat=5,wtyp.id_wh_type, styp.id_store_type) AS `id_acc_type` , prc.id_design_price, IFNULL(prc.design_price,0) AS `design_price`, prc.id_design_cat, prc.design_cat,
            IF(IFNULL(st.qty,0)<=0,'1','2') AS `is_no_stock`, IF((IF(comp.id_comp_cat=5,wtyp.id_wh_type, styp.id_store_type))=1 AND prc.id_design_cat<>1 AND !ISNULL(prc.id_design_price),1,2) AS `is_sale`, '2' AS `is_no_master`
            FROM tb_m_product p 
            INNER JOIN tb_m_product_code pc ON pc.id_product = p.id_product
            INNER JOIN tb_m_code_detail cd ON cd.id_code_detail = pc.id_code_detail
            INNER JOIN tb_m_design d ON d.id_design = p.id_design
            LEFT JOIN tb_st_stock st ON st.id_product = p.id_product AND st.id_wh_drawer=" + id_drawer + "
            LEFT JOIN tb_m_comp comp ON comp.id_drawer_def = st.id_wh_drawer
            LEFT JOIN tb_lookup_store_type styp ON styp.id_store_type = comp.id_store_type
            LEFT JOIN tb_lookup_wh_type wtyp ON wtyp.id_wh_type = comp.id_wh_type
            LEFT JOIN (
	            SELECT id_design, id_design_price, design_price, id_design_cat, design_cat
	            FROM (
		            SELECT p.id_design, p.id_design_price, p.design_price, pt.design_price_type, cat.id_design_cat, cat.design_cat   
		            FROM tb_m_design_price p
		            INNER JOIN tb_lookup_design_price_type pt ON pt.id_design_price_type = p.id_design_price_type 
		            INNER JOIN tb_lookup_design_cat cat ON cat.id_design_cat = pt.id_design_cat
		            WHERE p.design_price_start_date<=DATE(NOW()) AND p.is_active_wh = '1' AND p.is_design_cost='0'
		            ORDER BY p.design_price_start_date DESC, p.id_design_price DESC
	            ) prc
	            GROUP BY id_design
            ) prc ON prc.id_design = d.id_design
            WHERE p.product_full_code='" + code_check + "' "
            Dim dt_check As DataTable = execute_query(query_check, -1, True, "", "", "", "")
            If dt_check.Rows.Count > 0 Then
                'ketemu
                Dim code_saved As String = ""
                Dim is_unique_not_found As String = "2"
                If dt_check.Rows(0)("is_old_design") = "2" Then 'unique code
                    code_saved = code
                    Dim query_u As String = "SELECT IF(COUNT(*)>0,'2','1') AS `is_found` 
                    FROM tb_st_unique u
                    INNER JOIN tb_m_comp c ON c.id_comp = u.id_comp AND c.id_drawer_def=" + id_drawer + "
                    WHERE u.unique_code='" + code + "' "
                    is_unique_not_found = execute_query(query_u, 0, True, "", "", "", "")

                    'CHECK DUPLICATE
                    makeSafeGV(GVScan)
                    GVScan.ActiveFilterString = "[code]='" + code + "' "
                    If GVScan.RowCount > 0 Then
                        stopCustom("Duplicate scan !")
                        makeSafeGV(GVScan)
                        GVScan.FocusedRowHandle = GVScan.RowCount - 1
                        TxtScan.Text = ""
                        TxtScan.Focus()
                        Exit Sub
                    Else
                        makeSafeGV(GVScan)
                    End If
                ElseIf dt_check.Rows(0)("is_old_design") = "3" Then 'unique code peralihan
                    code_saved = code
                Else
                    code_saved = code_check
                End If

                'check status
                Dim is_ok As String = ""
                If dt_check.Rows(0)("is_no_stock").ToString = "2" And dt_check.Rows(0)("is_no_master").ToString = "2" And dt_check.Rows(0)("is_sale").ToString = "2" And is_reject = "2" And is_unique_not_found = "2" Then
                    is_ok = "1"
                Else
                    is_ok = "2"
                    Dim err As String = "PROBLEM PRODUCT : " + System.Environment.NewLine
                    If dt_check.Rows(0)("is_no_stock").ToString = "1" Then
                        err += "- NO STOCK "
                    End If
                    If dt_check.Rows(0)("is_sale").ToString = "1" Then
                        err += "- PRODUCT SALE " + System.Environment.NewLine
                    End If
                    If is_unique_not_found = "1" Then
                        err += "- UNIQUE CODE NOT FOUND " + System.Environment.NewLine
                    End If
                    stopCustom(err)
                End If

                'insert 
                Dim query_ins As String = "INSERT INTO tb_st_trans_det(id_st_trans, is_ok, is_no_stock, is_no_master, is_sale, is_reject, is_unique_not_found, id_product, code, name, size, qty, id_design_price, design_price) 
                VALUES ('" + id_st_trans + "', '" + is_ok + "', '" + dt_check.Rows(0)("is_no_stock").ToString + "', '" + dt_check.Rows(0)("is_no_master").ToString + "', '" + dt_check.Rows(0)("is_sale").ToString + "','" + is_reject + "', '" + is_unique_not_found + "', '" + dt_check.Rows(0)("id_product").ToString + "','" + code_saved + "', '" + dt_check.Rows(0)("name").ToString + "','" + dt_check.Rows(0)("size").ToString + "', 1, '" + dt_check.Rows(0)("id_design_price").ToString + "', '" + decimalSQL(dt_check.Rows(0)("design_price").ToString) + "') "
                execute_non_query(query_ins, True, "", "", "", "")
                viewDetail()
                GVScan.FocusedRowHandle = GVScan.RowCount - 1
                TxtScan.Text = ""
                TxtScan.Focus()
            Else
                Dim confirm As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("PRODUCT NOT FOUND IN MASTER LIST !" + System.Environment.NewLine + "DO YOU WANT TO RECORD THIS PRODUCT ?", "SCAN FAILED", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button3)
                If confirm = DialogResult.Yes Then
                    FormStockTakeFaik.ShowDialog()
                    TxtScan.Text = ""
                    TxtScan.Focus()
                Else
                    TxtScan.Text = ""
                    TxtScan.Focus()
                End If
            End If
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

    Private Sub XTCStockTake_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XTCStockTake.SelectedPageChanged
        If XTCStockTake.SelectedTabPageIndex = 0 Then
        ElseIf XTCStockTake.SelectedTabPageIndex = 1 Then
            viewSummary()
        End If
    End Sub
End Class