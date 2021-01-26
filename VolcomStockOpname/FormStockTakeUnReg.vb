Public Class FormStockTakeUnReg
    Public id_st_un_reg As String = "-1"

    Private is_login_store As String = "2"

    Public is_no_edit As String = "2"

    Private id_drawer As String = "-1"

    'scan variable item code
    Private cforKeyDown As Char = vbNullChar
    Private cforKeyDownVcr As Char = vbNullChar
    Private _lastKeystroke As DateTime = DateTime.Now
    Private _lastKeystrokeVcr As DateTime = DateTime.Now
    Private UseKeyboard As String = "-1"
    Private speed_barcode_read As Integer = 0
    Private speed_barcode_read_timer As Integer = 0

    Private Sub FormStockTakeUnReg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'opt
        Dim data_opt As DataTable = getOptMain()
        UseKeyboard = data_opt.Rows(0)("is_use_keyboard").ToString
        speed_barcode_read = data_opt.Rows(0)("speed_barcode_read")
        speed_barcode_read_timer = data_opt.Rows(0)("speed_barcode_read_timer")
        Timer1.Interval = speed_barcode_read_timer

        'hide note
        PCNote.Visible = False
        GroupControlBottom.Height = 49

        'check login store
        Try
            is_login_store = execute_query("SELECT is_login_store FROM tb_opt", 0, False, app_host, app_username, app_password, "db_opt")
        Catch ex As Exception
            is_login_store = "2"
        End Try

        If is_login_store = "1" Then
            LookAndFeel.UseDefaultLookAndFeel = False

            If is_no_edit = "1" Then
                GroupControl2.Visible = False

                If GVScan.RowCount > 0 Then
                    LookAndFeel.SkinMaskColor = Color.LightPink
                End If
            Else
                LookAndFeel.SkinMaskColor = Color.LightPink
            End If
        End If

        viewWHStockSum()
        viewReportStatus()
        viewAck()

        form_load()

        TxtScan.Focus()
    End Sub

    Private Sub FormStockTakeUnReg_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub TxtScan_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtScan.KeyDown
        cforKeyDown = ChrW(e.KeyCode)
    End Sub

    Private Sub SBAdd_Click(sender As Object, e As EventArgs) Handles SBAdd.Click
        add()
    End Sub

    Sub add()
        TxtScan.Focus()
    End Sub

    Private Sub TxtScan_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtScan.KeyUp
        If UseKeyboard = "2" Then
            'If open_scan Then
            'barcode scanner
            If Len(TxtScan.Text) > 1 Then
                If cforKeyDown <> ChrW(e.KeyCode) OrElse cforKeyDown = vbNullChar Then
                    cforKeyDown = vbNullChar
                    TxtScan.Text = ""
                    Return
                End If


                Dim elapsed As TimeSpan = DateTime.Now - _lastKeystroke
                '(DateTime.Now.Millisecond - _lastKeystroke)
                If elapsed.TotalMilliseconds > speed_barcode_read Then TxtScan.Text = ""

                'If e.KeyCode <> Keys.[Return] Then
                '    TxtItemCode.Text += ChrW(e.KeyData)
                'End If

                If e.KeyCode = Keys.[Return] AndAlso TxtScan.Text.Count > 0 Then
                    checkCode()
                End If
            End If
            'End If
            _lastKeystroke = DateTime.Now
        Else
            'keyboard
            If e.KeyCode = Keys.[Return] AndAlso TxtScan.Text.Count > 0 Then
                checkCode()
            End If
        End If
    End Sub

    Private Sub TxtScan_TextChanged(sender As Object, e As EventArgs) Handles TxtScan.TextChanged
        If UseKeyboard = "2" Then
            Timer1.Stop()
            Timer1.Start()
        End If
    End Sub

    Sub checkCode()
        Dim nxt As Boolean = True

        If is_login_store = "1" Then
            nxt = FormStockTake.check_ia_notif()
        End If

        If nxt Then
            Dim code As String = addSlashes(TxtScan.Text)
            Dim code_check As String = ""
            If code.Length = 16 Then
                code_check = code.Substring(0, 12)
            Else
                code_check = code
            End If

            'check duplicate
            Dim messages As String = ""

            If code.Length = 16 Then
                Dim q_dup1 As String = "
                    SELECT s.st_trans_number AS `number`, d.code
                    FROM tb_st_trans_det AS d
                    LEFT JOIN tb_st_trans AS s ON s.id_st_trans = d.id_st_trans
                    WHERE s.id_report_status <> 5 AND d.code = '" + code + "'

                    UNION ALL

                    SELECT s.un_reg_number AS `number`, d.code
                    FROM tb_st_un_reg_det AS d
                    LEFT JOIN tb_st_un_reg AS s ON s.id_st_un_reg = d.id_st_un_reg
                    WHERE s.id_report_status <> 5 AND d.code = '" + code + "'
                "

                Dim d_dup1 As DataTable = execute_query(q_dup1, -1, True, "", "", "", "")

                If d_dup1.Rows.Count > 0 Then
                    messages = "Already scanned in transaction number : " + d_dup1.Rows(0)("number").ToString
                End If
            End If

            If messages = "" Then
                'check di master
                Dim query_check As String = "SELECT p.id_product, p.product_full_code AS `code`, d.design_code, d.design_display_name AS `name`, cd.code_detail_name AS `size`, d.is_old_design, IFNULL(st.qty,0) AS `qty`, comp.id_comp_cat,IF(comp.id_comp_cat=5,wtyp.id_wh_type, styp.id_store_type) AS `id_acc_type` , prc.id_design_price, IF((IF(comp.id_comp_cat=5,wtyp.id_wh_type, styp.id_store_type))=1,IFNULL(fd.design_price,0),IFNULL(prc.design_price,0)) AS `design_price`, prc.id_design_cat, prc.design_cat,
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
                    Dim name As String = dt_check.Rows(0)("name").ToString
                    Dim size As String = dt_check.Rows(0)("size").ToString

                    execute_non_query("INSERT INTO tb_st_un_reg_det (id_st_un_reg, code, name, size) VALUES (" + id_st_un_reg + ", '" + addSlashes(code) + "', '" + addSlashes(name) + "', '" + addSlashes(size) + "')", True, "", "", "", "")

                    updatedBy()
                Else
                    FormStockTakeUnRegDet.TECode.EditValue = code
                    FormStockTakeUnRegDet.TEName.Focus()
                    FormStockTakeUnRegDet.ShowDialog()
                End If

                viewDetail()
            Else
                stopCustomDialog(messages)
            End If

            TxtScan.EditValue = ""
        End If
    End Sub

    Sub updatedBy()
        Dim query As String = "UPDATE tb_st_trans SET st_trans_updated_by=" + id_user + ", st_trans_updated=NOW() WHERE id_st_trans='" + id_st_un_reg + "' "
        execute_non_query(query, True, "", "", "", "")
        FormStockTake.viewScan()
        FormStockTake.GVScan.FocusedRowHandle = find_row(FormStockTake.GVScan, "id_st_trans", id_st_un_reg)
    End Sub

    Sub viewDetail()
        Dim data_detail As DataTable = execute_query("
            SELECT id_st_un_reg_det, 0 AS no, code, name, size, 1 AS qty, note
            FROM tb_st_un_reg_det
            WHERE id_st_un_reg = " + id_st_un_reg + "
        ", -1, True, "", "", "", "")

        GCScan.DataSource = data_detail

        GVScan.BestFitColumns()
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

    Sub viewReportStatus()
        Dim query As String = "SELECT * FROM tb_lookup_report_status s WHERE s.id_report_status=5 OR  s.id_report_status=1 OR s.id_report_status=6"
        viewLookupQuery(LEStatus, query, 0, "report_status", "id_report_status")
    End Sub

    Sub viewAck()
        Dim query As String = "
        SELECT 0 AS `id_user`, '-' AS `employee_name`
        UNION ALL
        SELECT u.id_user, IF(u.is_external_user = 1, u.name_external, e.employee_name) AS employee_name FROM tb_m_user u
        LEFT JOIN tb_m_employee e ON e.id_employee = u.id_employee "
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

    Sub form_load()
        If Not id_st_un_reg = "-1" Then
            Dim data As DataTable = execute_query("
                SELECT id_st_un_reg, id_wh_drawer, un_reg_number, remark, un_reg_date, un_reg_by, un_reg_updated_date, un_reg_updated_by, id_report_status, report_status_note, acknowledge_by, approved_by 
                FROM tb_st_un_reg
                WHERE id_st_un_reg = '" + id_st_un_reg + "'
            ", -1, True, "", "", "", "")

            SLEWHStockSum.EditValue = data.Rows(0)("id_wh_drawer").ToString
            MERemark.EditValue = data.Rows(0)("remark").ToString
            TxtNumber.EditValue = data.Rows(0)("un_reg_number").ToString
            DECreated.EditValue = data.Rows(0)("un_reg_date")
            LEStatus.EditValue = data.Rows(0)("id_report_status").ToString
            LEAck.EditValue = data.Rows(0)("acknowledge_by").ToString
            TxtApp.EditValue = data.Rows(0)("approved_by").ToString

            If data.Rows(0)("id_report_status").ToString = "5" Or data.Rows(0)("id_report_status").ToString = "6" Then
                LEStatus.Enabled = False
                LEAck.Enabled = False
                TxtApp.Enabled = False
                BtnSetStatus.Enabled = False
                MERemark.Enabled = False
                TextEditNote.Enabled = False
                SBAdd.Enabled = False
            Else
                LEStatus.Enabled = True
                LEAck.Enabled = True
                TxtApp.Enabled = True
                BtnSetStatus.Enabled = True
                MERemark.Enabled = True
                TextEditNote.Enabled = True
                SBAdd.Enabled = True
            End If

            viewDetail()
        End If
    End Sub

    Private Sub FormStockTakeUnReg_Keydown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            add()
        ElseIf e.KeyCode = Keys.F4 Then
            print()
        End If
    End Sub

    Sub print()
        Dim st As New ClassStockTake
        Dim query As String = st.queryTransMainUN("AND st.id_st_un_reg='" + id_st_un_reg + "' ", "1")
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")

        Dim data_opt As DataTable = execute_query("SELECT * FROM tb_st_opt", -1, True, "", "", "", "")

        If data.Rows(0)("id_report_status").ToString = "1" Then
            stopCustom("Can't print, please finalize status first")
            Cursor = Cursors.Default
            Exit Sub
        End If

        Cursor = Cursors.WaitCursor
        GVScan.BestFitColumns()
        ReportScanNoTag.dt = GCScan.DataSource
        ReportScanNoTag.id_report = id_st_un_reg
        Dim Report As New ReportScanNoTag()

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
        Report.LabelNo.Text = TxtNumber.Text
        Report.LabelOutlet.Text = SLEWHStockSum.Text
        Report.LabelAlamat.Text = data.Rows(0)("address_primary").ToString
        Report.LabelCreatedDate.Text = DECreated.Text
        Report.LabelSOHPeriode.Text = DateTime.Parse(data_opt.Rows(0)("soh_period")).ToString("dd\/MM\/yyyy")
        Report.LabelSalesUntil.Text = DateTime.Parse(data_opt.Rows(0)("sales_until_period")).ToString("dd\/MM\/yyyy")
        Report.LabelPrepare.Text = data.Rows(0)("prepared_by").ToString
        Report.LabelPreparePosition.Text = data.Rows(0)("prepared_position").ToString
        Report.LabelAck.Text = LEAck.Text
        Report.LabelAckPosition.Text = data.Rows(0)("ack_position").ToString
        Report.LabelApp.Text = TxtApp.Text
        Report.LabelAppPosition.Text = data.Rows(0)("comp_name").ToString
        Report.LabelRemark.Text = MERemark.Text.ToString

        'Show the report's preview. 
        Dim Tool As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Report)
        Tool.ShowPreviewDialog()
        Cursor = Cursors.Default
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        print()
    End Sub

    Private Sub GVScan_RowCountChanged(sender As Object, e As EventArgs) Handles GVScan.RowCountChanged
        For i = 0 To GVScan.RowCount - 1
            If GVScan.IsValidRowHandle(i) Then
                GVScan.SetRowCellValue(i, "no", i + 1)
            End If
        Next
    End Sub
End Class