Public Class FormStockTakeNoTag
    Public id_st_no_tag As String = "-1"

    Private is_login_store As String = "2"

    Public is_no_edit As String = "2"

    Private Sub FormStockTakeNoTag_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'check login store
        Try
            is_login_store = execute_query("SELECT is_login_store FROM tb_opt", 0, False, app_host, app_username, app_password, "db_opt")
        Catch ex As Exception
            is_login_store = "2"
        End Try

        viewWHStockSum()
        viewReportStatus()
        viewAck()

        form_load()

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
    End Sub

    Private Sub FormStockTakeNoTag_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormStockTake.viewScan()

        Dispose()
    End Sub

    Private Sub SBAdd_Click(sender As Object, e As EventArgs) Handles SBAdd.Click
        FormStockTakeNoTagDet.id_st_no_tag = id_st_no_tag
        FormStockTakeNoTagDet.ShowDialog()
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

    Private Sub LEStatus_EditValueChanged(sender As Object, e As EventArgs) Handles LEStatus.EditValueChanged
        If LEStatus.EditValue.ToString = "5" Then
            PCNote.Visible = True
            GroupControlBottom.Height = 94
        Else
            PCNote.Visible = False
            GroupControlBottom.Height = 49
        End If
    End Sub

    Sub form_load()
        If Not id_st_no_tag = "-1" Then
            Dim data As DataTable = execute_query("
                SELECT id_st_no_tag, id_wh_drawer, no_tag_number, remark, no_tag_date, no_tag_by, no_tag_updated_date, no_tag_updated_by, id_report_status, report_status_note, acknowledge_by, approved_by 
                FROM tb_st_no_tag 
                WHERE id_st_no_tag = '" + id_st_no_tag + "'
            ", -1, True, "", "", "", "")

            SLEWHStockSum.EditValue = data.Rows(0)("id_wh_drawer").ToString
            MERemark.EditValue = data.Rows(0)("remark").ToString
            TxtNumber.EditValue = data.Rows(0)("no_tag_number").ToString
            DECreated.EditValue = data.Rows(0)("no_tag_date")
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

            Dim data_detail As DataTable = execute_query("
                SELECT id_st_no_tag_det, 0 AS no, code, name, size, 1 AS qty, note
                FROM tb_st_no_tag_det
                WHERE id_st_no_tag = " + id_st_no_tag + "
            ", -1, True, "", "", "", "")

            GCScan.DataSource = data_detail

            GVScan.BestFitColumns()
        End If
    End Sub

    Private Sub GVScan_RowCountChanged(sender As Object, e As EventArgs) Handles GVScan.RowCountChanged
        For i = 0 To GVScan.RowCount - 1
            If GVScan.IsValidRowHandle(i) Then
                GVScan.SetRowCellValue(i, "no", i + 1)
            End If
        Next
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
                Dim query As String = "UPDATE tb_st_no_tag SET id_report_status ='" + LEStatus.EditValue.ToString + "', no_tag_updated_by=" + id_user + ", acknowledge_by=" + acknowledge_by + ", approved_by='" + approved_by + "', report_status_note=" + cancel_note + " WHERE id_st_no_tag='" + id_st_no_tag + "' "
                execute_non_query(query, True, "", "", "", "")

                form_load()
            End If
        End If
    End Sub

    Private Sub SetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetToolStripMenuItem.Click
        Cursor = Cursors.WaitCursor
        If GVScan.RowCount > 0 And GVScan.FocusedRowHandle >= 0 Then
            FormStockTakeDetNote.is_no_tag = "1"
            FormStockTakeDetNote.id_detail = GVScan.GetFocusedRowCellValue("id_st_no_tag_det").ToString
            FormStockTakeDetNote.MENote.Text = GVScan.GetFocusedRowCellValue("note").ToString
            FormStockTakeDetNote.ShowDialog()
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        print()
    End Sub

    Sub print()
        Dim st As New ClassStockTake
        Dim query As String = st.queryTransMainNT("AND st.id_st_no_tag='" + id_st_no_tag + "' ", "1")
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
        ReportScanNoTag.id_report = id_st_no_tag
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

    Private Sub FormStockTakeNoTag_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F4 Then
            print()
        ElseIf e.KeyCode = Keys.F2 Then
            SBAdd_Click(SBAdd, New EventArgs)
        End If
    End Sub
End Class