Public Class FormVerStockTakeDet
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
    Public comp_number As String = ""
    Public comp_name As String = ""
    Dim soh_period As String = ""
    Dim sales_until_period As String = ""
    Dim is_record_unreg As String = ""
    Dim after_load As Boolean = False

    Private Sub FormVerStockTakeDet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'hide note
        PCNote.Visible = False
        GroupControlBottom.Height = 49

        viewWHStockSum()
        viewReportStatus()
        viewAck()
        actionLoad()
        after_load = True
    End Sub

    Sub viewReportStatus()
        Dim query As String = ""
        If is_combine = "2" Then
            query = "SELECT * FROM tb_lookup_report_status s WHERE s.id_report_status=5 OR  s.id_report_status=1 OR s.id_report_status=6 "
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
        query += "WHERE std.id_st_trans_ver=" + id_st_trans_ver + " "
        If is_combine = "2" Then
            GridColumnRemark.Visible = False
            GridColumnRefNumber.Visible = False
        End If
        If is_combine = "2" Then
            query += "ORDER BY std.id_st_trans_ver_det ASC "
        ElseIf is_combine = "1" Then
            query += "ORDER BY r.id_st_trans_ver ASC ,std.name ASC "
        End If
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        GCScan.DataSource = data
    End Sub

    Sub viewSummary()
        Cursor = Cursors.WaitCursor
        Dim query As String = "SELECT std.id_product, d.design_code AS `product_code`, p.product_full_code AS `barcode`, std.name, std.size, 
        SUM(std.qty) AS `qty`, std.design_price, prct.design_price_type AS `price_type`
        FROM tb_st_trans_ver_det std
        INNER JOIN tb_st_trans_ver st ON st.id_st_trans_ver = std.id_st_trans_ver
        INNER JOIN tb_m_product p ON p.id_product = std.id_product 
        INNER JOIN tb_m_design d ON d.id_design = p.id_design 
        INNER JOIN tb_m_design_price prc ON prc.id_design_price = std.id_design_price
        INNER JOIN tb_lookup_design_price_type prct ON prct.id_design_price_type = prc.id_design_price_type "
        query += "WHERE std.id_st_trans_ver=" + id_st_trans_ver + " "
        query += "AND !ISNULL(std.id_product) GROUP BY std.id_product 
        UNION ALL 
        SELECT std.id_product, NULL AS `product_code`, std.code AS `barcode`, std.name, std.size, 
        SUM(std.qty) AS `qty`, std.design_price, '-' AS price_type
        FROM tb_st_trans_ver_det std
        INNER JOIN tb_st_trans_ver st ON st.id_st_trans_ver = std.id_st_trans_ver 
        WHERE ISNULL(std.id_product) "
        query += "AND std.id_st_trans_ver=" + id_st_trans_ver + " "
        query += "GROUP BY std.code 
        ORDER BY name ASC "
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        GCSummaryScan.DataSource = data
        Cursor = Cursors.Default
    End Sub

    Sub viewComparePre()
        Dim w1 As String = ""
        Dim w2 As String = ""
        If is_combine = "1" Then
            Dim qr As String = "SELECT v.id_st_trans FROM tb_st_trans_ver v WHERE v.id_combine=" + id_st_trans_ver + "
            GROUP BY v.id_st_trans "
            Dim dr As DataTable = execute_query(qr, -1, True, "", "", "", "")
            For i As Integer = 0 To dr.Rows.Count - 1
                If i > 0 Then
                    w1 += "OR "
                    w2 += "OR "
                End If
                w1 += "v.id_st_trans=" + dr.Rows(i)("id_st_trans").ToString + " "
                w2 += "pd.id_st_trans=" + dr.Rows(i)("id_st_trans").ToString + " "
            Next
            If w1 <> "" Then
                w1 = "(" + w1 + ")"
            Else
                w1 = "v.id_st_trans=-1 "
            End If
            If w2 <> "" Then
                w2 = "(" + w2 + ")"
            Else
                w2 = "pd.id_st_trans=-1 "
            End If
        Else
            w1 = "v.id_st_trans=" + id_st_trans + " "
            w2 = "pd.id_st_trans=" + id_st_trans + " "
        End If
        Dim query As String = "SELECT pd.id_product AS `id_product_pre`, pd.`code` AS `barcode_pre`, pd.`name` AS `name_pre`, pd.size AS `size_pre`, SUM(pd.qty) AS `qty_pre`, pd.design_price AS `price_pre`,
        vd.id_product AS `id_product_ver`, vd.`code` AS `barcode_ver`, vd.`name` AS `name_ver`, vd.size AS `size_ver`, IFNULL(vd.qty,0) AS `qty_ver`, IFNULL(vd.design_price,0) AS `price_ver`
        FROM tb_st_trans_det pd
        LEFT JOIN (
	        SELECT vd.id_product, vd.`code`, vd.`name`, vd.size, SUM(vd.qty) AS `qty`, vd.design_price  
	        FROM tb_st_trans_ver_det vd
	        INNER JOIN tb_st_trans_ver v ON v.id_st_trans_ver = vd.id_st_trans_ver
	        WHERE " + w1 + "  AND v.id_report_status!=5
	        GROUP BY vd.code 
        ) vd ON vd.`code` = pd.`code`
        WHERE " + w2 + "
        GROUP BY pd.`code`
        UNION ALL
        SELECT pd.id_product AS `id_product_pre`, pd.`code` AS `barcode_pre`, pd.`name` AS `name_pre`, pd.size AS `size_pre`, IFNULL(SUM(pd.qty),0) AS `qty_pre`, IFNULL(pd.design_price,0) AS `price_pre`,
        vd.id_product AS `id_product_ver`, vd.`code` AS `barcode_ver`, vd.`name` AS `name_ver`, vd.size AS `size_ver`, (vd.qty) AS `qty_ver`, vd.design_price AS `price_ver`
        FROM tb_st_trans_det pd
        RIGHT JOIN (
	        SELECT vd.id_product, vd.`code`, vd.`name`, vd.size, SUM(vd.qty) AS `qty`, vd.design_price  
	        FROM tb_st_trans_ver_det vd
	        INNER JOIN tb_st_trans_ver v ON v.id_st_trans_ver = vd.id_st_trans_ver
	        WHERE " + w1 + " AND v.id_report_status!=5
	        GROUP BY vd.code 
        ) vd ON vd.`code` = pd.`code` AND " + w2 + "
        WHERE ISNULL(pd.`code`)
        GROUP BY vd.`code`
        ORDER BY name_pre ASC "
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        GCCS.DataSource = data
        GVCS.BestFitColumns()
    End Sub

    Sub viewCompare()
        Cursor = Cursors.WaitCursor
        gridBandStoreQty.Caption = comp_number
        Dim query As String = "SELECT im.id_product, p.product_full_code AS `barcode`, d.design_code AS `code`, d.design_display_name AS `name`, cd.code_detail_name AS `size`, LEFT(prct.design_price_type,1) AS `design_cat`,
        im.id_design_price, im.design_price, im.qty_soh, im.qty_scan
        FROM (
	        SELECT s.id_product, 
            IF(!ISNULL(sc.id_design_price), sc.id_design_price, IF(c.id_store_type=1 OR c.id_wh_type=1, fd.id_design_price,s.id_design_price)) AS `id_design_price`, 
            IF(!ISNULL(sc.design_price), sc.design_price, IF(c.id_store_type=1 OR c.id_wh_type=1, fd.design_price,s.design_price)) AS `design_price`, 
            SUM(s.qty) AS `qty_soh`, IFNULL(sc.qty_scan,0) AS `qty_scan`
	        FROM tb_st_stock s 
	        LEFT JOIN (
		        SELECT std.id_product, SUM(std.qty) AS `qty_scan`, std.id_design_price, std.design_price
		        FROM tb_st_trans_ver_det std
		        INNER JOIN tb_st_trans_ver st ON st.id_st_trans_ver = std.id_st_trans_ver
		        WHERE st.id_st_trans_ver=" + id_st_trans_ver + " AND std.is_no_stock=2 AND std.is_no_master=2
		        GROUP BY std.id_product
	        ) sc ON sc.id_product = s.id_product
            INNER JOIN tb_m_product p ON p.id_product = s.id_product
            INNER JOIN tb_m_design d ON d.id_design = p.id_design
            INNER JOIN tb_m_comp c ON c.id_drawer_def = s.id_wh_drawer
            LEFT JOIN tb_m_design_first_del fd ON fd.id_design = d.id_design AND fd.id_comp = c.id_comp
	        WHERE s.id_wh_drawer=" + id_drawer + "
	        GROUP BY s.id_product
	        UNION ALL 
	        SELECT std.id_product, std.id_design_price, std.design_price, 0 as `qty_soh`, SUM(std.qty) AS `qty_scan`
	        FROM tb_st_trans_ver_det std
	        INNER JOIN tb_st_trans_ver st ON st.id_st_trans_ver = std.id_st_trans_ver
	        WHERE st.id_st_trans_ver=" + id_st_trans_ver + " AND std.is_no_stock=1 
	        GROUP BY std.id_product
        ) im
        INNER JOIN tb_m_product p ON p.id_product = im.id_product
        INNER JOIN tb_m_product_code pc ON pc.id_product = p.id_product
        INNER JOIN tb_m_code_detail cd ON cd.id_code_detail = pc.id_code_detail
        INNER JOIN tb_m_design d ON d.id_design = p.id_design
        INNER JOIN tb_m_design_price prc ON prc.id_design_price = im.id_design_price
        INNER JOIN tb_lookup_design_price_type prct ON prct.id_design_price_type = prc.id_design_price_type
        INNER JOIN tb_lookup_design_cat dc ON dc.id_design_cat = prct.id_design_cat
        UNION ALL
        SELECT std.id_product, std.code AS `barcode`, std.code, std.name, std.size, '-' AS `design_cat`,std.id_design_price, std.design_price,  0 AS `qty_soh`,SUM(std.qty) AS `qty_scan`
        FROM tb_st_trans_ver_det std
        INNER JOIN tb_st_trans_ver st ON st.id_st_trans_ver = std.id_st_trans_ver
        WHERE st.id_st_trans_ver=" + id_st_trans_ver + " AND std.is_no_master=1 
        GROUP BY std.code
        ORDER BY name ASC "
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        GCCompare.DataSource = data
        TxtFontSize.EditValue = 6.3
        Cursor = Cursors.Default
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
        If PCNote.Visible And TextEditNote.Text = "" Then
            stopCustom("Please fill note.")
        Else
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
                Dim cancel_note As String = If(TextEditNote.Text = "", "NULL", "'" + addSlashes(TextEditNote.Text) + "'")
                Dim approved_by As String = addSlashes(TxtApp.Text)
                Dim query As String = "UPDATE tb_st_trans_ver SET id_report_status ='" + LEStatus.EditValue.ToString + "', st_trans_ver_updated_by=" + id_user + ", acknowledge_by=" + acknowledge_by + ", approved_by='" + approved_by + "', report_status_note=" + cancel_note + " WHERE id_st_trans_ver='" + id_st_trans_ver + "' "
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
        Cursor = Cursors.WaitCursor
        If XTCStockTake.SelectedTabPageIndex = 0 Then
            If id_report_status = "1" And is_combine = "2" Then
                stopCustom("Can't print, please finalize status first")
                Cursor = Cursors.Default
                Exit Sub
            End If

            Cursor = Cursors.WaitCursor
            GVScan.BestFitColumns()
            ReportScanVerStockTakeSlip.dt = GCScan.DataSource
            ReportScanVerStockTakeSlip.id_report = id_st_trans
            Dim Report As New ReportScanVerStockTakeSlip()

            ' '... 
            ' ' creating and saving the view's layout to a new memory stream 
            Dim str As System.IO.Stream
            str = New System.IO.MemoryStream()
            GVScan.SaveLayoutToStream(str, DevExpress.Utils.OptionsLayoutBase.FullLayout)
            str.Seek(0, System.IO.SeekOrigin.Begin)
            Report.GVScan.RestoreLayoutFromStream(str, DevExpress.Utils.OptionsLayoutBase.FullLayout)
            str.Seek(0, System.IO.SeekOrigin.Begin)

            'Grid Detail
            ReportStyleGridview(Report.GVScan)

            'Parse val
            Report.LabelTitle.Text = "WH STOCKTAKE - SCAN PRODUCT LIST  "
            Report.LabelNo.Text = TxtNumber.Text
            Report.LabelAccount.Text = SLEWHStockSum.Text
            Report.LabelRemark.Text = TxtNumber.Text
            Report.LabelDate.Text = DECreated.Text
            Report.LabelPrepare.Text = prepared_by
            Report.LabelRemark.Text = MERemark.Text.ToString
            Report.LabelRefNo.Text = TxtNumbrRef.Text
            Report.LabelRef.Text = TxtRemarkRef.Text

            'Show the report's preview. 
            Dim Tool As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Report)
            Tool.ShowPreviewDialog()
            Cursor = Cursors.Default
        ElseIf XTCStockTake.SelectedTabPageIndex = 1 Then
            If id_report_status = "1" Then
                stopCustom("Can't print, please finalize status first")
                Cursor = Cursors.Default
                Exit Sub
            End If

            Cursor = Cursors.WaitCursor
            GVSummaryScan.BestFitColumns()
            ReportScanVerStockTakeSlip.dt = GCSummaryScan.DataSource
            ReportScanVerStockTakeSlip.id_report = id_st_trans
            Dim Report As New ReportScanVerStockTakeSlip()

            ' '... 
            ' ' creating and saving the view's layout to a new memory stream 
            Dim str As System.IO.Stream
            str = New System.IO.MemoryStream()
            GVSummaryScan.SaveLayoutToStream(str, DevExpress.Utils.OptionsLayoutBase.FullLayout)
            str.Seek(0, System.IO.SeekOrigin.Begin)
            Report.GVScan.RestoreLayoutFromStream(str, DevExpress.Utils.OptionsLayoutBase.FullLayout)
            str.Seek(0, System.IO.SeekOrigin.Begin)

            'Grid Detail
            ReportStyleGridview(Report.GVScan)

            'Parse val
            Report.LabelTitle.Text = "WH STOCKTAKE SLIP"
            Report.LabelNo.Text = TxtNumber.Text
            Report.LabelAccount.Text = SLEWHStockSum.Text
            Report.LabelRemark.Text = TxtNumber.Text
            Report.LabelDate.Text = DECreated.Text
            Report.LabelPrepare.Text = prepared_by
            Report.LabelRemark.Text = MERemark.Text.ToString
            Report.LabelRefNo.Text = TxtNumbrRef.Text
            Report.LabelRef.Text = TxtRemarkRef.Text

            'Show the report's preview. 
            Dim Tool As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Report)
            Tool.ShowPreviewDialog()
            Cursor = Cursors.Default
        ElseIf XTCStockTake.SelectedTabPageIndex = 2 Then
            GVCS.BestFitColumns()
            print_raw(GCCS, "")
        ElseIf XTCStockTake.SelectedTabPageIndex = 3 Then

        ElseIf XTCStockTake.SelectedTabPageIndex = 4 Then
            If CEA4.EditValue = True Then
                Cursor = Cursors.WaitCursor
                'BGVCompare.BestFitColumns()
                ReportCompare.dt = GCCompare.DataSource
                ReportCompare.id_report = id_st_trans
                Dim Report As New ReportCompare()

                ' '... 
                ' ' creating and saving the view's layout to a new memory stream 
                Dim str As System.IO.Stream
                str = New System.IO.MemoryStream()
                BGVCompare.SaveLayoutToStream(str, DevExpress.Utils.OptionsLayoutBase.FullLayout)
                str.Seek(0, System.IO.SeekOrigin.Begin)
                Report.BGVCompare.RestoreLayoutFromStream(str, DevExpress.Utils.OptionsLayoutBase.FullLayout)
                str.Seek(0, System.IO.SeekOrigin.Begin)

                'Grid Detail
                'ReportStyleBanded(Report.BGVCompare)
                Dim fz As Single = TxtFontSize.EditValue
                Report.BGVCompare.OptionsPrint.UsePrintStyles = True
                Report.BGVCompare.AppearancePrint.BandPanel.Font = New Font(Report.BGVCompare.Appearance.Row.Font.FontFamily, Report.BGVCompare.Appearance.Row.Font.Size, FontStyle.Bold)


                Report.BGVCompare.AppearancePrint.BandPanel.BackColor = Color.Transparent
                Report.BGVCompare.AppearancePrint.BandPanel.ForeColor = Color.Black
                Report.BGVCompare.AppearancePrint.BandPanel.Font = New Font("Segoe UI", fz, FontStyle.Bold)

                Report.BGVCompare.AppearancePrint.FilterPanel.BackColor = Color.Transparent
                Report.BGVCompare.AppearancePrint.FilterPanel.ForeColor = Color.Black
                Report.BGVCompare.AppearancePrint.FilterPanel.Font = New Font("Segoe UI", fz, FontStyle.Regular)

                Report.BGVCompare.AppearancePrint.GroupFooter.BackColor = Color.Transparent
                Report.BGVCompare.AppearancePrint.GroupFooter.ForeColor = Color.Black
                Report.BGVCompare.AppearancePrint.GroupFooter.Font = New Font("Segoe UI", fz, FontStyle.Bold)

                Report.BGVCompare.AppearancePrint.GroupRow.BackColor = Color.Transparent
                Report.BGVCompare.AppearancePrint.GroupRow.ForeColor = Color.Black
                Report.BGVCompare.AppearancePrint.GroupRow.Font = New Font("Segoe UI", fz, FontStyle.Bold)

                Report.BGVCompare.AppearancePrint.HeaderPanel.BackColor = Color.Transparent
                Report.BGVCompare.AppearancePrint.HeaderPanel.ForeColor = Color.Black
                Report.BGVCompare.AppearancePrint.HeaderPanel.Font = New Font("Segoe UI", fz, FontStyle.Bold)

                Report.BGVCompare.AppearancePrint.FooterPanel.BackColor = Color.Transparent
                Report.BGVCompare.AppearancePrint.FooterPanel.ForeColor = Color.Black
                Report.BGVCompare.AppearancePrint.FooterPanel.Font = New Font("Segoe UI", fz, FontStyle.Bold)

                Report.BGVCompare.AppearancePrint.Row.Font = New Font("Segoe UI", fz, FontStyle.Regular)

                Report.BGVCompare.OptionsPrint.ExpandAllDetails = True
                Report.BGVCompare.OptionsPrint.UsePrintStyles = True
                Report.BGVCompare.OptionsPrint.PrintDetails = True
                Report.BGVCompare.OptionsPrint.PrintFooter = True

                'Parse val
                Report.LabelNo.Text = TxtNumber.Text
                Report.LabelOutlet.Text = SLEWHStockSum.Text
                Report.LabelAlamat.Text = address_primary
                Report.LabelCreatedDate.Text = DECreated.Text
                Report.LabelSOHPeriode.Text = soh_period
                Report.LabelSalesUntil.Text = sales_until_period
                Report.LabelPrepare.Text = prepared_by
                Report.LabelPreparePosition.Text = prepared_position
                Report.LabelAck.Text = LEAck.Text
                Report.LabelAckPosition.Text = ack_position
                Report.LabelApp.Text = TxtApp.Text
                Report.LabelAppPosition.Text = comp_name

                'Show the report's preview. 
                Dim Tool As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Report)
                Tool.ShowPreviewDialog()
                Cursor = Cursors.Default
            Else
                Cursor = Cursors.WaitCursor
                BGVCompare.BestFitColumns()
                ReportScanVerStockTakeSlip.dt = GCCompare.DataSource
                ReportScanVerStockTakeSlip.id_report = id_st_trans
                Dim Report As New ReportScanVerStockTakeSlip()
                Report.GCScan.MainView = Report.BGVScan
                ' '... 
                ' ' creating and saving the view's layout to a new memory stream 
                Dim str As System.IO.Stream
                str = New System.IO.MemoryStream()
                BGVCompare.SaveLayoutToStream(str, DevExpress.Utils.OptionsLayoutBase.FullLayout)
                str.Seek(0, System.IO.SeekOrigin.Begin)
                Report.BGVScan.RestoreLayoutFromStream(str, DevExpress.Utils.OptionsLayoutBase.FullLayout)
                str.Seek(0, System.IO.SeekOrigin.Begin)

                'Grid Detail
                ReportStyleBanded(Report.BGVScan)

                'Parse val
                Report.LabelTitle.Text = "STOCKTAKE SLIP - COMPARE STOCK"
                Report.LabelNo.Text = TxtNumber.Text
                Report.LabelAccount.Text = SLEWHStockSum.Text
                Report.LabelRemark.Text = TxtNumber.Text
                Report.LabelDate.Text = DECreated.Text
                Report.LabelPrepare.Text = prepared_by
                Report.LabelRemark.Text = MERemark.Text.ToString
                Report.LabelRefNo.Text = "-"
                Report.LabelRef.Text = "-"
                Report.XrTable1.Visible = False
                Report.LabelApp.Text = LEAck.Text.ToString
                Report.LabelApp2.Text = TxtApp.Text

                'Show the report's preview. 
                Dim Tool As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Report)
                Tool.ShowPreviewDialog()
                Cursor = Cursors.Default
            End If
        End If
        Cursor = Cursors.Default
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
            Dim qm As String = "SELECT IFNULL(sd.id_product,0) AS `id_product`, sd.code, sd.name, sd.size, SUM(sd.qty) AS `qty`, (SUM(sd.qty)-IFNULL(r.qty,0)) AS `avl_qty`,
            IFNULL(sd.id_design_price,0) AS `id_design_price`, sd.design_price,
            sd.is_ok, sd.is_no_stock, sd.is_no_master, sd.is_sale, sd.is_reject, sd.is_unique_not_found, sd.is_no_tag
            FROM tb_st_trans_det sd
            LEFT JOIN (
	            SELECT vd.`code`, SUM(vd.qty) AS `qty` 
	            FROM tb_st_trans_ver_det vd
	            INNER JOIN tb_st_trans_ver v ON v.id_st_trans_ver = vd.id_st_trans_ver
	            WHERE v.id_report_status!=5 AND v.id_st_trans=" + id_st_trans + "
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
                        If err <> "" And CEHideAllNotice.EditValue = False Then
                            stopCustomDialog(err_head + err)
                        End If
                    End If

                    'insert 
                    insertDB(is_ok, is_not_match, is_no_stock, is_no_master, is_no_tag, is_sale, is_reject, is_unique_not_found, dm.Rows(0)("id_product").ToString, addSlashes(code), addSlashes(dm.Rows(0)("name").ToString), addSlashes(dm.Rows(0)("size").ToString), dm.Rows(0)("id_design_price").ToString, decimalSQL(dm.Rows(0)("design_price").ToString))
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
                        'update 12 maret 2020
                        If CheckEditAllow.EditValue.ToString = "False" Then
                            stopCustomDialog("Qty not match")
                            TxtScan.Text = ""
                            TxtScan.Focus()
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
                            If err <> "" And CEHideAllNotice.EditValue = False Then
                                stopCustomDialog(err_head + err)
                            End If

                            'insert 
                            insertDB(is_ok, is_not_match, is_no_stock, is_no_master, is_no_tag, is_sale, is_reject, is_unique_not_found, dm.Rows(0)("id_product").ToString, addSlashes(code), addSlashes(dm.Rows(0)("name").ToString), addSlashes(dm.Rows(0)("size").ToString), dm.Rows(0)("id_design_price").ToString, decimalSQL(dm.Rows(0)("design_price").ToString))
                            updatedBy()
                            viewDetail()
                            GVScan.FocusedRowHandle = GVScan.RowCount - 1
                            TxtScan.Text = ""
                            TxtScan.Focus()
                        End If
                    End If
                End If
            Else
                'gak ketemu cek stok spt pre
                If CheckEditAllow.EditValue.ToString = "False" Then
                    stopCustomDialog("Product not found in Pre Stocktake list")
                    TxtScan.Text = ""
                    TxtScan.Focus()
                Else
                    Dim code_check As String = ""
                    If code.Length = 16 Then
                        code_check = code.Substring(0, 12)
                    Else
                        code_check = code
                    End If
                    'check di master
                    Dim query_check As String = "SELECT p.id_product, p.product_full_code AS `code`, d.design_code, d.design_display_name AS `name`, cd.code_detail_name AS `size`, d.is_old_design, IFNULL(st.qty,0) AS `qty`,
                    comp.id_comp_cat,IF(comp.id_comp_cat=5,wtyp.id_wh_type, styp.id_store_type) AS `id_acc_type` , prc.id_design_price, IF((IF(comp.id_comp_cat=5,wtyp.id_wh_type, styp.id_store_type))=1,IFNULL(fd.design_price,0),IFNULL(prc.design_price,0)) AS `design_price`, prc.id_design_cat, prc.design_cat,
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
                    LEFT JOIN tb_m_design_first_del fd ON fd.id_design = d.id_design AND fd.id_comp = comp.id_comp
                    WHERE p.product_full_code='" + code_check + "' "
                    Dim dt_check As DataTable = execute_query(query_check, -1, True, "", "", "", "")
                    If dt_check.Rows.Count > 0 Then
                        'ketemu
                        Dim code_saved As String = ""
                        Dim is_unique_not_found As String = "2"
                        Dim is_12_digit As String = "2"
                        If dt_check.Rows(0)("is_old_design") = "2" Then 'unique code
                            code_saved = code
                            Dim query_u As String = "SELECT IF(COUNT(*)>0,'2','1') AS `is_found` 
                        FROM tb_st_unique u
                        INNER JOIN tb_m_comp c ON c.id_comp = u.id_comp AND c.id_drawer_def=" + id_drawer + "
                        WHERE u.unique_code='" + code + "' "
                            is_unique_not_found = execute_query(query_u, 0, True, "", "", "", "")

                            'jika ada unik tdk sesuai
                            If is_unique_not_found = "1" And CERecordUniqueNotFound.EditValue = False Then
                                stopCustomDialog("Unique code not found !")
                                makeSafeGV(GVScan)
                                GVScan.FocusedRowHandle = GVScan.RowCount - 1
                                TxtScan.Text = ""
                                TxtScan.Focus()
                                Exit Sub
                            End If

                            If code.Length = 16 Then
                                'CHECK DUPLICATE
                                makeSafeGV(GVScan)
                                GVScan.ActiveFilterString = "[code]='" + code + "' "
                                If GVScan.RowCount > 0 Then
                                    stopCustomDialog("Duplicate scan !")
                                    makeSafeGV(GVScan)
                                    GVScan.FocusedRowHandle = GVScan.RowCount - 1
                                    TxtScan.Text = ""
                                    TxtScan.Focus()
                                    Exit Sub
                                Else
                                    makeSafeGV(GVScan)
                                End If
                            End If
                        ElseIf dt_check.Rows(0)("is_old_design") = "3" Then 'unique code peralihan
                            code_saved = code
                        Else '
                            code_saved = code
                            If code.Length > 12 Then 'jika tidak 12 digit dicek duplikat
                                is_12_digit = "2"
                                makeSafeGV(GVScan)
                                GVScan.ActiveFilterString = "[code]='" + code + "' "
                                If GVScan.RowCount > 0 Then
                                    stopCustomDialog("Duplicate scan !")
                                    makeSafeGV(GVScan)
                                    GVScan.FocusedRowHandle = GVScan.RowCount - 1
                                    TxtScan.Text = ""
                                    TxtScan.Focus()
                                    Exit Sub
                                Else
                                    makeSafeGV(GVScan)
                                End If
                            Else
                                is_12_digit = "1"
                            End If
                        End If

                        'temporary krn pake BOF
                        If is_12_digit = "1" And (CEHideNotice12digit.EditValue = False) Then
                            If CEHideAllNotice.EditValue = False Then
                                stopCustomDialog("SCAN BARCODE 12 DIGIT ")
                            End If
                        End If

                        'check status
                        Dim is_ok As String = "2"
                        Dim err_head As String = "PROBLEM PRODUCT : " + System.Environment.NewLine
                        Dim err As String = ""
                        err += "- PRODUCT NOT MATCH " + System.Environment.NewLine
                        If dt_check.Rows(0)("is_no_stock").ToString = "1" Then
                            err += "- NO STOCK " + System.Environment.NewLine
                        End If
                        If dt_check.Rows(0)("is_sale").ToString = "1" And CheckEditSale.EditValue.ToString = "False" Then
                            err += "- PRODUCT SALE " + System.Environment.NewLine
                        End If
                        If is_unique_not_found = "1" Then
                            err += "- UNIQUE CODE NOT FOUND " + System.Environment.NewLine
                        End If
                        If err <> "" And CEHideAllNotice.EditValue = False Then
                            stopCustomDialog(err_head + err)
                        End If

                        'insert 
                        insertDB(is_ok, "1", dt_check.Rows(0)("is_no_stock").ToString, "2", is_no_tag, dt_check.Rows(0)("is_sale").ToString, is_reject, is_unique_not_found, dt_check.Rows(0)("id_product").ToString, addSlashes(code_saved), addSlashes(dt_check.Rows(0)("name").ToString), addSlashes(dt_check.Rows(0)("size").ToString), dt_check.Rows(0)("id_design_price").ToString, decimalSQL(dt_check.Rows(0)("design_price").ToString))
                        updatedBy()
                        viewDetail()
                        GVScan.FocusedRowHandle = GVScan.RowCount - 1
                        TxtScan.Text = ""
                        TxtScan.Focus()
                    Else
                        If is_record_unreg = "2" Then
                            stopCustomDialog("PRODUCT NOT FOUND IN MASTER LIST !")
                            TxtScan.Text = ""
                            TxtScan.Focus()
                        Else
                            stopCustomDialog("PRODUCT NOT FOUND IN MASTER LIST !")
                            FormStockTakeFaik.id_pop_up = "1"
                            FormStockTakeFaik.ShowDialog()
                            TxtScan.Text = ""
                            TxtScan.Focus()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Sub insertDB(ByVal is_ok As String, ByVal is_not_match As String, ByVal is_no_stock As String, ByVal is_no_master As String, ByVal is_no_tag As String, ByVal is_sale As String, ByVal is_reject As String, ByVal is_unique_not_found As String, ByVal id_product As String, ByVal code As String, ByVal name As String, ByVal size As String, ByVal id_design_price As String, ByVal design_price As String)
        If id_product = "0" Then
            id_product = "NULL"
        End If
        If id_design_price = "0" Then
            id_design_price = "NULL"
        End If
        Dim query_ins As String = "INSERT INTO tb_st_trans_ver_det(id_st_trans_ver, is_ok, is_not_match, is_no_stock, is_no_master, is_no_tag, is_sale, is_reject, is_unique_not_found, id_product, code, name, size, qty, id_design_price, design_price) 
        VALUES ('" + id_st_trans_ver + "', '" + is_ok + "','" + is_not_match + "', '" + is_no_stock + "', '" + is_no_master + "', '" + is_no_tag + "', '" + is_sale + "','" + is_reject + "', '" + is_unique_not_found + "', " + id_product + ",'" + code + "', '" + name + "','" + size + "', 1, " + id_design_price + ", '" + design_price + "') "
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
        ElseIf XTCStockTake.SelectedTabPageIndex = 1 Then
            viewSummary()
            GVScan.ActiveFilterString = ""
            PanelFontSize.Visible = False
        ElseIf XTCStockTake.SelectedTabPageIndex = 2 Then
            viewComparePre()
            GVScan.ActiveFilterString = ""
            PanelFontSize.Visible = False
        ElseIf XTCStockTake.SelectedTabPageIndex = 3 Then
            '    viewSummaryCat()
            '    GVScan.ActiveFilterString = ""
            '    PanelFontSize.Visible = False
        ElseIf XTCStockTake.SelectedTabPageIndex = 4 Then
            viewCompare()
            GVScan.ActiveFilterString = ""
            PanelFontSize.Visible = True
        End If
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        print()
    End Sub

    Private Sub FormVerStockTakeDet_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub MERemark_EditValueChanged(sender As Object, e As EventArgs) Handles MERemark.EditValueChanged
        If after_load Then
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
        End If
    End Sub

    Private Sub SetQtyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetQtyToolStripMenuItem.Click
        Cursor = Cursors.WaitCursor
        If GVScan.RowCount > 0 And GVScan.FocusedRowHandle >= 0 And GVScan.GetFocusedRowCellValue("design_price") = 0 Then
            FormStockTakeDetQty.id_pop_up = "1"
            FormStockTakeDetQty.id_detail = GVScan.GetFocusedRowCellValue("id_st_trans_ver_det").ToString
            FormStockTakeDetQty.ShowDialog()
            TxtScan.Text = ""
            TxtScan.Focus()
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub GVSummaryScan_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GVSummaryScan.CustomColumnDisplayText
        If e.Column.FieldName = "no" Then
            e.DisplayText = (e.ListSourceRowIndex + 1).ToString()
        End If
    End Sub

    Private Sub GVCS_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GVCS.CustomColumnDisplayText
        If e.Column.FieldName = "no" Then
            e.DisplayText = (e.ListSourceRowIndex + 1).ToString()
        End If
    End Sub

    Private Sub BGVCompare_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles BGVCompare.CustomColumnDisplayText
        If e.Column.FieldName = "no" Then
            e.DisplayText = (e.ListSourceRowIndex + 1).ToString()
        ElseIf (e.Column.FieldName = "qty_soh" Or e.Column.FieldName = "qty_scan" Or e.Column.FieldName = "val_soh" Or e.Column.FieldName = "val_scan" Or e.Column.FieldName = "qty_diff" Or e.Column.FieldName = "val_diff") Then
            Dim qty As Decimal = Convert.ToDecimal(e.Value)
            If qty = 0 Then
                e.DisplayText = "-"
            End If
        End If
    End Sub

    Private Sub BtnAddToRpt_Click(sender As Object, e As EventArgs) Handles BtnAddToRpt.Click
        Cursor = Cursors.WaitCursor
        FormRpt.BtnUse.Visible = True
        FormRpt.id_pop_up = "2"
        FormRpt.ShowDialog()
        Cursor = Cursors.Default
    End Sub

    Private Sub LEStatus_EditValueChanged(sender As Object, e As EventArgs) Handles LEStatus.EditValueChanged
        If LEStatus.EditValue.ToString = "5" Then
            PCNote.Visible = True
            GroupControlBottom.Height = 94
        Else
            PCNote.Visible = False
            GroupControlBottom.Height = 49
        End If
    End Sub
End Class