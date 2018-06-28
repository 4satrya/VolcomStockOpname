﻿Public Class FormVerStockTakeDet
    Public action As String = ""
    Public id_st_trans_ver As String = "-1"
    Public id_st_trans As String = "-1"
    Dim is_combine As String = "2"
    Dim id_report_status As String = "-1"
    Dim id_comp As String = "-1'"
    Dim id_drawer As String = "-1"
    Dim prepared_by As String = "-1"
    Dim prepared_position As String = ""
    Dim ack_position As String = ""
    Dim address_primary As String = ""
    Dim comp_number As String = ""
    Dim comp_name As String = ""
    Dim soh_period As String = ""
    Dim sales_until_period As String = ""
    Dim is_record_unreg As String = ""

    Private Sub FormVerStockTakeDet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewWHStockSum()
        viewReportStatus()
        viewAck()
        actionLoad()
    End Sub

    Sub viewReportStatus()
        Dim query As String = ""
        If is_combine = "2" Then
            query = "SELECT * FROM tb_lookup_report_status s WHERE s.id_report_status=5 OR  s.id_report_status=1 "
        Else
            query = "SELECT * FROM tb_lookup_report_status s WHERE s.id_report_status=1 OR s.id_report_status=3 OR s.id_report_status=5 OR s.id_report_status=6 "
        End If
        viewLookupQuery(LEStatus, query, 0, "report_status", "id_report_status")
    End Sub

    Sub viewAck()
        Dim query As String = "
        SELECT 0 AS `id_user`, '-' AS `employee_name`
        UNION ALL
        SELECT u.id_user, e.employee_name FROM tb_m_user u
        INNER JOIN tb_m_employee e ON e.id_employee = u.id_employee "
        viewLookupQuery(LEAck, query, 0, "employee_name", "id_user")
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
            Dim query As String = st.queryVerTransMain("AND st.id_st_trans_ver='" + id_st_trans_ver + "' ", "1")
            Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
            id_st_trans = data.Rows(0)("id_st_trans").ToString
            SLEWHStockSum.EditValue = data.Rows(0)("id_wh_drawer").ToString
            TxtNumber.Text = data.Rows(0)("st_trans_ver_number").ToString
            TxtNumbrRef.Text = data.Rows(0)("st_trans_number").ToString
            TxtRemarkRef.Text = data.Rows(0)("remark_ref").ToString
            MERemark.Text = data.Rows(0)("remark").ToString
            DECreated.Text = data.Rows(0)("st_trans_ver_date")
            LEStatus.ItemIndex = LEStatus.Properties.GetDataSourceRowIndex("id_report_status", data.Rows(0)("id_report_status").ToString)
            id_report_status = data.Rows(0)("id_report_status").ToString
            id_comp = data.Rows(0)("id_comp").ToString
            id_drawer = data.Rows(0)("id_wh_drawer").ToString
            is_combine = data.Rows(0)("is_combine").ToString
            'acknowledge_by
            LEAck.ItemIndex = LEAck.Properties.GetDataSourceRowIndex("id_user", data.Rows(0)("acknowledge_by").ToString)
            ack_position = data.Rows(0)("ack_position").ToString
            TxtApp.Text = data.Rows(0)("approved_by").ToString
            prepared_by = data.Rows(0)("prepared_by").ToString
            prepared_position = data.Rows(0)("prepared_position").ToString
            address_primary = data.Rows(0)("address_primary").ToString
            comp_number = data.Rows(0)("comp_number").ToString
            comp_name = data.Rows(0)("comp_name").ToString

            'soh period
            Dim dto As DataTable = execute_query("SELECT * FROM tb_st_opt", -1, True, "", "", "", "")
            soh_period = DateTime.Parse(dto.Rows(0)("soh_period")).ToString("dd\/MM\/yyyy")
            sales_until_period = DateTime.Parse(dto.Rows(0)("sales_until_period")).ToString("dd\/MM\/yyyy")
            is_record_unreg = dto.Rows(0)("is_record_unreg").ToString

            viewDetail()
            allow_status()
        End If
    End Sub

    Sub viewDetail()
        Dim query As String = "SELECT std.id_st_trans_ver_det, std.id_st_trans_ver, 
        std.is_ok, IF(std.is_ok=1,'Yes', 'No') AS `is_ok_v`,std.is_not_match, IF(std.is_not_match=1,'Yes', 'No') AS `is_not_match_v`, std.is_no_stock, IF(std.is_no_stock=1,'Yes', 'No') AS `is_no_stock_v`, std.is_no_master, IF(std.is_no_master=1,'Yes', 'No') AS `is_no_master_v`, std.is_sale, IF(std.is_sale=1,'Yes', 'No') AS `is_sale_v`, std.is_reject, IF(std.is_reject=1,'Yes', 'No') AS `is_reject_v`,std.is_no_tag, IF(std.is_no_tag=1,'Yes', 'No') AS `is_no_tag_v`, std.is_unique_not_found, IF(std.is_unique_not_found=1,'Yes', 'No') AS `is_unique_not_found_v`,
        std.id_product, std.code, std.name, std.size, std.qty, 
        std.id_design_price, std.design_price, d.is_old_design, cat.id_design_cat, cat.design_cat, typ.design_price_type, r.st_trans_ver_number AS `ref_number`, r.remark AS `remark_ref`, p.product_full_code
        FROM tb_st_trans_ver_det std
        INNER JOIN tb_st_trans_ver st ON st.id_st_trans_ver = std.id_st_trans_ver
        LEFT JOIN tb_m_product p ON p.id_product = std.id_product
        LEFT JOIN tb_m_design d ON d.id_design = p.id_design
        LEFT JOIN tb_m_design_price prc ON prc.id_design_price = std.id_design_price
        LEFT JOIN tb_lookup_design_price_type typ ON typ.id_design_price_type = prc.id_design_price_type
        LEFT JOIN tb_lookup_design_cat cat ON cat.id_design_cat = typ.id_design_cat 
        LEFT JOIN tb_st_trans_ver_det rd ON rd.id_st_trans_ver_det = std.id_st_trans_ver_det_ref
        LEFT JOIN tb_st_trans_ver r ON r.id_st_trans_ver = rd.id_st_trans_ver "
        query += "WHERE std.id_st_trans_ver=" + id_st_trans_ver + " ORDER BY std.id_st_trans_ver_det ASC "
        If is_combine = "2" Then
            GridColumnRemark.Visible = False
            GridColumnRefNumber.Visible = False
        End If
        'If is_combine = "2" Then
        '    query += "WHERE std.id_st_trans=" + id_st_trans + " ORDER BY std.id_st_trans_det ASC "
        'ElseIf is_combine = "1" Then
        '    query += "WHERE st.id_combine=" + id_st_trans + " ORDER BY std.id_st_trans_det ASC "
        'End If
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        GCScan.DataSource = data
    End Sub

    Sub allow_status()
        If is_combine = "2" Then
            If id_report_status = "5" Or id_report_status = "6" Then
                LEStatus.Enabled = False
                LEAck.Enabled = False
                TxtApp.Enabled = False
                BtnSetStatus.Enabled = False
                PanelControlNav.Visible = False
                MERemark.Enabled = False
            Else
                LEStatus.Enabled = True
                LEAck.Enabled = True
                TxtApp.Enabled = True
                BtnSetStatus.Enabled = True
                PanelControlNav.Visible = True
                MERemark.Enabled = True
            End If
        Else
            PanelControlNav.Visible = False
            XTPCompare.PageVisible = True
            If id_report_status = "5" Or id_report_status = "6" Then
                LEStatus.Enabled = False
                LEAck.Enabled = False
                TxtApp.Enabled = False
                BtnSetStatus.Enabled = False
                MERemark.Enabled = False
            Else
                LEStatus.Enabled = True
                LEAck.Enabled = True
                TxtApp.Enabled = True
                BtnSetStatus.Enabled = True
                MERemark.Enabled = True
            End If
        End If
    End Sub

    Private Sub BtnSetStatus_Click(sender As Object, e As EventArgs) Handles BtnSetStatus.Click
        Dim confirm As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure you want to " + LEStatus.Text.ToLower + " this transaction ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If confirm = DialogResult.Yes Then
            Dim acknowledge_by As String = "0"
            Try
                acknowledge_by = LEAck.EditValue.ToString
            Catch ex As Exception
            End Try
            If acknowledge_by = "" Or acknowledge_by = "0" Then
                acknowledge_by = "NULL"
            End If
            Dim approved_by As String = addSlashes(TxtApp.Text)
            Dim query As String = "UPDATE tb_st_trans_ver SET id_report_status ='" + LEStatus.EditValue.ToString + "', st_trans_ver_updated_by=" + id_user + ", acknowledge_by=" + acknowledge_by + ", approved_by='" + approved_by + "' WHERE id_st_trans_ver='" + id_st_trans_ver + "' "
            execute_non_query(query, True, "", "", "", "")

            If is_combine = "1" Then
                If LEStatus.EditValue.ToString = "5" Then
                    Dim query_upd As String = "UPDATE tb_st_trans_ver SET id_combine=NULL WHERE id_combine=" + id_st_trans_ver + " "
                    execute_non_query(query_upd, True, "", "", "", "")
                End If
                FormVerStockTake.viewCombine()
                FormVerStockTake.GVCombine.FocusedRowHandle = find_row(FormVerStockTake.GVScan, "id_st_trans_ver", id_st_trans_ver)
            Else
                FormVerStockTake.viewScan()
                FormVerStockTake.GVScan.FocusedRowHandle = find_row(FormVerStockTake.GVScan, "id_st_trans_ver", id_st_trans_ver)
            End If

            XTCStockTake.SelectedTabPageIndex = 0
            action = "upd"
            actionLoad()
        End If
    End Sub

    Sub add()
        TxtScan.Focus()
    End Sub

    Sub del()
        FormStockTakeDel.id_pop_up = "1"
        FormStockTakeDel.ShowDialog()
    End Sub

    Sub print()
        'Cursor = Cursors.WaitCursor
        'If XTCStockTake.SelectedTabPageIndex = 0 Then
        '    Cursor = Cursors.WaitCursor
        '    GVScan.BestFitColumns()
        '    ReportScan.dt = GCScan.DataSource
        '    ReportScan.id_report = id_st_trans
        '    Dim Report As New ReportScan()

        '    ' '... 
        '    ' ' creating and saving the view's layout to a new memory stream 
        '    Dim str As System.IO.Stream
        '    str = New System.IO.MemoryStream()
        '    GVScan.SaveLayoutToStream(str, DevExpress.Utils.OptionsLayoutBase.FullLayout)
        '    str.Seek(0, System.IO.SeekOrigin.Begin)
        '    Report.GVScan.RestoreLayoutFromStream(str, DevExpress.Utils.OptionsLayoutBase.FullLayout)
        '    str.Seek(0, System.IO.SeekOrigin.Begin)

        '    'Grid Detail
        '    ReportStyleGridview(Report.GVScan)

        '    'Parse val
        '    Report.LabelNo.Text = TxtNumber.Text
        '    Report.LabelOutlet.Text = SLEWHStockSum.Text
        '    Report.LabelAlamat.Text = address_primary
        '    Report.LabelCreatedDate.Text = DECreated.Text
        '    Report.LabelSOHPeriode.Text = soh_period
        '    Report.LabelSalesUntil.Text = sales_until_period
        '    Report.LabelPrepare.Text = prepared_by
        '    Report.LabelPreparePosition.Text = prepared_position
        '    Report.LabelAck.Text = LEAck.Text
        '    Report.LabelAckPosition.Text = ack_position
        '    Report.LabelApp.Text = TxtApp.Text
        '    Report.LabelAppPosition.Text = comp_name
        '    Report.LabelRemark.Text = MERemark.Text.ToString

        '    'Show the report's preview. 
        '    Dim Tool As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Report)
        '    Tool.ShowPreviewDialog()
        '    Cursor = Cursors.Default
        'ElseIf XTCStockTake.SelectedTabPageIndex = 1 Then
        '    Cursor = Cursors.WaitCursor
        '    GVSummaryScan.BestFitColumns()
        '    ReportScan.dt = GCSummaryScan.DataSource
        '    ReportScan.id_report = id_st_trans
        '    Dim Report As New ReportScan()

        '    ' '... 
        '    ' ' creating and saving the view's layout to a new memory stream 
        '    Dim str As System.IO.Stream
        '    str = New System.IO.MemoryStream()
        '    GVSummaryScan.SaveLayoutToStream(str, DevExpress.Utils.OptionsLayoutBase.FullLayout)
        '    str.Seek(0, System.IO.SeekOrigin.Begin)
        '    Report.GVScan.RestoreLayoutFromStream(str, DevExpress.Utils.OptionsLayoutBase.FullLayout)
        '    str.Seek(0, System.IO.SeekOrigin.Begin)

        '    'Grid Detail
        '    ReportStyleGridview(Report.GVScan)

        '    'Parse val
        '    Report.LabelNo.Text = TxtNumber.Text
        '    Report.LabelOutlet.Text = SLEWHStockSum.Text
        '    Report.LabelAlamat.Text = address_primary
        '    Report.LabelCreatedDate.Text = DECreated.Text
        '    Report.LabelSOHPeriode.Text = soh_period
        '    Report.LabelSalesUntil.Text = sales_until_period
        '    Report.LabelPrepare.Text = prepared_by
        '    Report.LabelPreparePosition.Text = prepared_position
        '    Report.LabelAck.Text = LEAck.Text
        '    Report.LabelAckPosition.Text = ack_position
        '    Report.LabelApp.Text = TxtApp.Text
        '    Report.LabelAppPosition.Text = comp_name
        '    Report.LabelRemark.Text = MERemark.Text.ToString

        '    'Show the report's preview. 
        '    Dim Tool As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Report)
        '    Tool.ShowPreviewDialog()
        '    Cursor = Cursors.Default
        'ElseIf XTCStockTake.SelectedTabPageIndex = 2 Then
        '    GVCat.BestFitColumns()
        '    print_raw(GCCat, "")
        'ElseIf XTCStockTake.SelectedTabPageIndex = 3 Then
        '    Cursor = Cursors.WaitCursor
        '    'BGVCompare.BestFitColumns()
        '    ReportCompare.dt = GCCompare.DataSource
        '    ReportCompare.id_report = id_st_trans
        '    Dim Report As New ReportCompare()

        '    ' '... 
        '    ' ' creating and saving the view's layout to a new memory stream 
        '    Dim str As System.IO.Stream
        '    str = New System.IO.MemoryStream()
        '    BGVCompare.SaveLayoutToStream(str, DevExpress.Utils.OptionsLayoutBase.FullLayout)
        '    str.Seek(0, System.IO.SeekOrigin.Begin)
        '    Report.BGVCompare.RestoreLayoutFromStream(str, DevExpress.Utils.OptionsLayoutBase.FullLayout)
        '    str.Seek(0, System.IO.SeekOrigin.Begin)

        '    'Grid Detail
        '    'ReportStyleBanded(Report.BGVCompare)
        '    Dim fz As Single = TxtFontSize.EditValue
        '    Report.BGVCompare.OptionsPrint.UsePrintStyles = True
        '    Report.BGVCompare.AppearancePrint.BandPanel.Font = New Font(Report.BGVCompare.Appearance.Row.Font.FontFamily, Report.BGVCompare.Appearance.Row.Font.Size, FontStyle.Bold)


        '    Report.BGVCompare.AppearancePrint.BandPanel.BackColor = Color.Transparent
        '    Report.BGVCompare.AppearancePrint.BandPanel.ForeColor = Color.Black
        '    Report.BGVCompare.AppearancePrint.BandPanel.Font = New Font("Segoe UI", fz, FontStyle.Bold)

        '    Report.BGVCompare.AppearancePrint.FilterPanel.BackColor = Color.Transparent
        '    Report.BGVCompare.AppearancePrint.FilterPanel.ForeColor = Color.Black
        '    Report.BGVCompare.AppearancePrint.FilterPanel.Font = New Font("Segoe UI", fz, FontStyle.Regular)

        '    Report.BGVCompare.AppearancePrint.GroupFooter.BackColor = Color.Transparent
        '    Report.BGVCompare.AppearancePrint.GroupFooter.ForeColor = Color.Black
        '    Report.BGVCompare.AppearancePrint.GroupFooter.Font = New Font("Segoe UI", fz, FontStyle.Bold)

        '    Report.BGVCompare.AppearancePrint.GroupRow.BackColor = Color.Transparent
        '    Report.BGVCompare.AppearancePrint.GroupRow.ForeColor = Color.Black
        '    Report.BGVCompare.AppearancePrint.GroupRow.Font = New Font("Segoe UI", fz, FontStyle.Bold)

        '    Report.BGVCompare.AppearancePrint.HeaderPanel.BackColor = Color.Transparent
        '    Report.BGVCompare.AppearancePrint.HeaderPanel.ForeColor = Color.Black
        '    Report.BGVCompare.AppearancePrint.HeaderPanel.Font = New Font("Segoe UI", fz, FontStyle.Bold)

        '    Report.BGVCompare.AppearancePrint.FooterPanel.BackColor = Color.Transparent
        '    Report.BGVCompare.AppearancePrint.FooterPanel.ForeColor = Color.Black
        '    Report.BGVCompare.AppearancePrint.FooterPanel.Font = New Font("Segoe UI", fz, FontStyle.Bold)

        '    Report.BGVCompare.AppearancePrint.Row.Font = New Font("Segoe UI", fz, FontStyle.Regular)

        '    Report.BGVCompare.OptionsPrint.ExpandAllDetails = True
        '    Report.BGVCompare.OptionsPrint.UsePrintStyles = True
        '    Report.BGVCompare.OptionsPrint.PrintDetails = True
        '    Report.BGVCompare.OptionsPrint.PrintFooter = True

        '    'Parse val
        '    Report.LabelNo.Text = TxtNumber.Text
        '    Report.LabelOutlet.Text = SLEWHStockSum.Text
        '    Report.LabelAlamat.Text = address_primary
        '    Report.LabelCreatedDate.Text = DECreated.Text
        '    Report.LabelSOHPeriode.Text = soh_period
        '    Report.LabelSalesUntil.Text = sales_until_period
        '    Report.LabelPrepare.Text = prepared_by
        '    Report.LabelPreparePosition.Text = prepared_position
        '    Report.LabelAck.Text = LEAck.Text
        '    Report.LabelAckPosition.Text = ack_position
        '    Report.LabelApp.Text = TxtApp.Text
        '    Report.LabelAppPosition.Text = comp_name

        '    'Show the report's preview. 
        '    Dim Tool As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Report)
        '    Tool.ShowPreviewDialog()
        '    Cursor = Cursors.Default
        'End If
        'Cursor = Cursors.Default
    End Sub

    Private Sub FormVerStockTakeDet_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
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

    Private Sub BtnDelAll_Click(sender As Object, e As EventArgs) Handles BtnDelAll.Click
        Dim confirm As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure you want to delete all ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If confirm = DialogResult.Yes Then
            Dim query As String = "DELETE FROM tb_st_trans_ver_det WHERE id_st_trans_ver='" + id_st_trans_ver + "' "
            execute_non_query(query, True, "", "", "", "")
            updatedBy()
            viewDetail()
        End If
    End Sub

    Private Sub DeleteItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteItemToolStripMenuItem.Click
        If GVScan.RowCount > 0 And GVScan.FocusedRowHandle >= 0 Then
            Dim confirm As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure you want to " + LEStatus.Text.ToLower + " this transaction ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            If confirm = DialogResult.Yes Then
                Dim query As String = "DELETE FROM tb_st_trans_ver_det WHERE id_st_trans_ver_det='" + GVScan.GetFocusedRowCellValue("id_st_trans_ver_det").ToString + "' "
                execute_non_query(query, True, "", "", "", "")
                updatedBy()
                viewDetail()
            End If
        End If
    End Sub


    Sub updatedBy()
        Dim query As String = "UPDATE tb_st_trans_ver SET st_trans_ver_updated_by=" + id_user + ", st_trans_ver_updated=NOW() WHERE id_st_trans_ver='" + id_st_trans_ver + "' "
        execute_non_query(query, True, "", "", "", "")
        FormVerStockTake.viewScan()
        FormVerStockTake.GVScan.FocusedRowHandle = find_row(FormVerStockTake.GVScan, "id_st_trans_ver", id_st_trans_ver)
    End Sub



    Private Sub TxtScan_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtScan.KeyDown
        If e.KeyCode = Keys.Enter And TxtScan.Text <> "" Then
            Dim code As String = addSlashes(TxtScan.Text)

            'checedit reject
            Dim is_reject As String = ""
            If CheckEditReject.EditValue.ToString = "True" Then
                is_reject = "1"
            Else
                is_reject = "2"
            End If

            'checkedit no tag
            Dim is_no_tag As String = ""
            If CheckEditNoTag.EditValue.ToString = "True" Then
                is_no_tag = "1"
            Else
                is_no_tag = "2"
            End If

            'cek reference
            Dim qm As String = "SELECT sd.id_product, sd.code, sd.name, sd.size, SUM(sd.qty) AS `qty`, (SUM(sd.qty)-IFNULL(r.qty,0)) AS `avl_qty`,
            sd.id_design_price, sd.design_price,
            sd.is_ok, sd.is_no_stock, sd.is_no_master, sd.is_sale, sd.is_reject, sd.is_unique_not_found, sd.is_no_tag
            FROM tb_st_trans_det sd
            LEFT JOIN (
	            SELECT vd.`code`, SUM(vd.qty) AS `qty` 
	            FROM tb_st_trans_ver_det vd
	            INNER JOIN tb_st_trans_ver v ON v.id_st_trans_ver = vd.id_st_trans_ver
	            WHERE v.id_report_status!=5 
	            GROUP BY vd.`code`
            ) r ON r.`code` = sd.`code`
            WHERE sd.id_st_trans=" + id_st_trans + " AND sd.`code`='" + code + "'
            GROUP BY sd.code "
            Dim dm As DataTable = execute_query(qm, -1, True, "", "", "", "")
            If dm.Rows.Count > 0 Then
                'ketemu
                If dm.Rows(0)("avl_qty") > 0 Then
                    'masuk

                    'pengecekan kondisi
                    Dim is_ok As String = ""
                    Dim is_not_match As String = "2"
                    Dim is_no_stock As String = dm.Rows(0)("is_no_stock").ToString
                    Dim is_no_master As String = dm.Rows(0)("is_no_master").ToString
                    Dim is_sale As String = dm.Rows(0)("is_sale").ToString
                    Dim is_unique_not_found As String = dm.Rows(0)("is_unique_not_found").ToString
                    If is_not_match = "2" And is_no_stock = "2" And is_no_master = "2" And is_sale = "2" And is_reject = "2" And is_unique_not_found = "2" And is_no_tag = "2" Then
                        is_ok = "1"
                    Else
                        is_ok = "2"
                        Dim err_head As String = "PROBLEM PRODUCT : " + System.Environment.NewLine
                        Dim err As String = ""
                        If is_not_match = "1" Then
                            err += "- NOT MATCH " + System.Environment.NewLine
                        End If
                        If is_no_stock = "1" Then
                            err += "- NO STOCK " + System.Environment.NewLine
                        End If
                        If is_no_master = "1" Then
                            err += "- NO MASTER " + System.Environment.NewLine
                        End If
                        If is_sale = "1" And CheckEditSale.EditValue.ToString = "False" Then
                            err += "- PRODUCT SALE " + System.Environment.NewLine
                        End If
                        If is_unique_not_found = "1" Then
                            err += "- UNIQUE CODE NOT FOUND " + System.Environment.NewLine
                        End If
                        If err <> "" Then
                            stopCustomDialog(err_head + err)
                        End If
                    End If

                    'insert 
                    insertDB(is_ok, is_not_match, is_no_stock, is_no_master, is_no_tag, is_sale, is_reject, is_unique_not_found, dm.Rows(0)("id_product").ToString, addSlashes(dm.Rows(0)("code").ToString), addSlashes(dm.Rows(0)("name").ToString), addSlashes(dm.Rows(0)("size").ToString), dm.Rows(0)("id_design_price").ToString, decimalSQL(dm.Rows(0)("design_price").ToString))
                    updatedBy()
                    viewDetail()
                    GVScan.FocusedRowHandle = GVScan.RowCount - 1
                    TxtScan.Text = ""
                    TxtScan.Focus()
                Else
                    If code.Length > 12 Then
                        'jika 16 digit ditolak
                        stopCustomDialog("Duplicate scan, kode unik sudah diverivikasi.")
                        GVScan.FocusedRowHandle = GVScan.RowCount - 1
                        TxtScan.Text = ""
                        TxtScan.Focus()
                        Exit Sub
                    Else
                        'masuk & not match
                        'pengecekan kondisi
                        Dim is_ok As String = "2"
                        Dim is_not_match As String = "1"
                        Dim is_no_stock As String = dm.Rows(0)("is_no_stock").ToString
                        Dim is_no_master As String = dm.Rows(0)("is_no_master").ToString
                        Dim is_sale As String = dm.Rows(0)("is_sale").ToString
                        Dim is_unique_not_found As String = dm.Rows(0)("is_unique_not_found").ToString

                        Dim err_head As String = "PROBLEM PRODUCT : " + System.Environment.NewLine
                        Dim err As String = ""
                        If is_not_match = "1" Then
                            err += "- QTY NOT MATCH " + System.Environment.NewLine
                        End If
                        If is_no_stock = "1" Then
                            err += "- NO STOCK " + System.Environment.NewLine
                        End If
                        If is_no_master = "1" Then
                            err += "- NO MASTER " + System.Environment.NewLine
                        End If
                        If is_sale = "1" And CheckEditSale.EditValue.ToString = "False" Then
                            err += "- PRODUCT SALE " + System.Environment.NewLine
                        End If
                        If is_unique_not_found = "1" Then
                            err += "- UNIQUE CODE NOT FOUND " + System.Environment.NewLine
                        End If
                        If err <> "" Then
                            stopCustomDialog(err_head + err)
                        End If

                        'insert 
                        insertDB(is_ok, is_not_match, is_no_stock, is_no_master, is_no_tag, is_sale, is_reject, is_unique_not_found, dm.Rows(0)("id_product").ToString, addSlashes(dm.Rows(0)("code").ToString), addSlashes(dm.Rows(0)("name").ToString), addSlashes(dm.Rows(0)("size").ToString), dm.Rows(0)("id_design_price").ToString, decimalSQL(dm.Rows(0)("design_price").ToString))
                        updatedBy()
                        viewDetail()
                        GVScan.FocusedRowHandle = GVScan.RowCount - 1
                        TxtScan.Text = ""
                        TxtScan.Focus()
                    End If
                End If
            Else
                'gak ketemu cek stok spt pre
            End If
        End If
    End Sub

    Sub insertDB(ByVal is_ok As String, ByVal is_not_match As String, ByVal is_no_stock As String, ByVal is_no_master As String, ByVal is_no_tag As String, ByVal is_sale As String, ByVal is_reject As String, ByVal is_unique_not_found As String, ByVal id_product As String, ByVal code As String, ByVal name As String, ByVal size As String, ByVal id_design_price As String, ByVal design_price As String)
        Dim query_ins As String = "INSERT INTO tb_st_trans_ver_det(id_st_trans_ver, is_ok, is_not_match, is_no_stock, is_no_master, is_no_tag, is_sale, is_reject, is_unique_not_found, id_product, code, name, size, qty, id_design_price, design_price) 
        VALUES ('" + id_st_trans_ver + "', '" + is_ok + "','" + is_not_match + "', '" + is_no_stock + "', '" + is_no_master + "', '" + is_no_tag + "', '" + is_sale + "','" + is_reject + "', '" + is_unique_not_found + "', '" + id_product + "','" + code + "', '" + name + "','" + size + "', 1, '" + id_design_price + "', '" + design_price + "') "
        execute_non_query(query_ins, True, "", "", "", "")
    End Sub

    Private Sub GVScan_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GVScan.CustomColumnDisplayText
        If e.Column.FieldName = "no" Then
            e.DisplayText = (e.ListSourceRowIndex + 1).ToString()
        End If
    End Sub

    Private Sub XTCStockTake_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XTCStockTake.SelectedPageChanged
        If XTCStockTake.SelectedTabPageIndex = 0 Then
            viewDetail()
            PanelFontSize.Visible = False
            'ElseIf XTCStockTake.SelectedTabPageIndex = 1 Then
            '    viewSummary()
            '    GVScan.ActiveFilterString = ""
            '    PanelFontSize.Visible = False
            'ElseIf XTCStockTake.SelectedTabPageIndex = 2 Then
            '    viewSummaryCat()
            '    GVScan.ActiveFilterString = ""
            '    PanelFontSize.Visible = False
            'ElseIf XTCStockTake.SelectedTabPageIndex = 3 Then
            '    viewCompare()
            '    GVScan.ActiveFilterString = ""
            '    PanelFontSize.Visible = True
        End If
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        print()
    End Sub

    Private Sub FormVerStockTakeDet_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub MERemark_EditValueChanged(sender As Object, e As EventArgs) Handles MERemark.EditValueChanged
        Cursor = Cursors.WaitCursor
        Dim query As String = "UPDATE tb_st_trans_ver SET remark='" + addSlashes(MERemark.Text) + "', st_trans_ver_updated_by='" + id_user + "' WHERE id_st_trans_ver='" + id_st_trans_ver + "' "
        execute_non_query(query, True, "", "", "", "")
        If is_combine = "1" Then
            FormVerStockTake.viewCombine()
            FormVerStockTake.GVCombine.FocusedRowHandle = find_row(FormVerStockTake.GVCombine, "id_st_trans_ver", id_st_trans_ver)
        Else
            FormVerStockTake.viewScan()
            FormVerStockTake.GVScan.FocusedRowHandle = find_row(FormVerStockTake.GVScan, "id_st_trans_ver", id_st_trans_ver)
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub SetQtyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetQtyToolStripMenuItem.Click
        Cursor = Cursors.WaitCursor
        If GVScan.RowCount > 0 And GVScan.FocusedRowHandle >= 0 And GVScan.GetFocusedRowCellValue("design_price") = 0 Then
            FormStockTakeDetQty.id_detail = GVScan.GetFocusedRowCellValue("id_st_trans_ver_det").ToString
            FormStockTakeDetQty.ShowDialog()
            TxtScan.Text = ""
            TxtScan.Focus()
        End If
        Cursor = Cursors.Default
    End Sub
End Class