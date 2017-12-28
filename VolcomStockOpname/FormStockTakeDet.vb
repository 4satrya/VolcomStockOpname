Public Class FormStockTakeDet
    Public id_st_trans As String = "-1"
    Public action As String = ""
    Public is_combine As String = "2"
    Dim id_report_status As String = "-1"
    Dim id_comp As String = "-1'"

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
        INNER JOIN tb_m_product p ON p.id_product = std.id_product
        INNER JOIN tb_m_design d ON d.id_design = p.id_design
        INNER JOIN tb_m_design_price prc ON prc.id_design_price = std.id_design_price
        INNER JOIN tb_lookup_design_price_type typ ON typ.id_design_price_type = prc.id_design_price_type
        INNER JOIN tb_lookup_design_cat cat ON cat.id_design_cat = typ.id_design_cat
        WHERE std.id_st_trans=" + id_st_trans + " ORDER BY std.id_st_trans_det ASC "
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        GCScan.DataSource = data
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
            MsgBox(code_check)
        End If
    End Sub
End Class