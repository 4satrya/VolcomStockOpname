Public Class FormRptDet
    Public id As String = "-1"
    Private Sub FormRptDet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewReportStatus()
        actionLoad()
    End Sub

    Sub viewReportStatus()
        Dim query As String = "SELECT 'Submitted' AS `report_status` UNION ALL SELECT 'Cancelled' AS `report_status` "
        viewLookupQuery(LEStatus, query, 0, "report_status", "report_status")
    End Sub

    Sub actionLoad()
        Cursor = Cursors.WaitCursor
        Dim rpt As New ClassRpt()
        Dim query As String = rpt.queryMain("AND r.id_rpt='" + id + "' ", "1")
        Dim data As DataTable = execute_query(query, -1, False, app_host, app_username, app_password, "db_opt")
        TxtNumber.Text = data.Rows(0)("rpt_number").ToString
        MENote.Text = data.Rows(0)("rpt_note").ToString
        DECreatedDate.EditValue = data.Rows(0)("rpt_created_date")
        TxtCreatedBy.Text = data.Rows(0)("rpt_created_by").ToString
        LEStatus.ItemIndex = LEStatus.Properties.GetDataSourceRowIndex("report_status", data.Rows(0)("report_status").ToString)
        TxtStatusNote.Text = data.Rows(0)("report_status_note").ToString
        If data.Rows(0)("report_status").ToString = "Cancelled" Then
            BtnSaveChanges.Visible = False
            MENote.Enabled = False
            LEStatus.Enabled = False
            TxtStatusNote.Enabled = False
        End If

        viewCombineList()
        Cursor = Cursors.Default
    End Sub

    Sub viewCombineList()
        Cursor = Cursors.WaitCursor
        Dim query As String = "SELECT d.combine_no, d.db_name, d.comp_number, d.comp_name, SUM(d.soh_qty) AS `soh_qty`, SUM(d.scan_qty) AS `scan_qty`
        FROM tb_rpt_det d
        WHERE d.id_rpt=" + id + "
        GROUP BY d.combine_no 
        ORDER BY comp_number ASC "
        Dim data As DataTable = execute_query(query, -1, False, app_host, app_username, app_password, "db_opt")
        GCAccount.DataSource = data
        GVAccount.BestFitColumns()
        Cursor = Cursors.Default
    End Sub

    Sub viewDetailReport()
        Cursor = Cursors.WaitCursor

        'delete band acc
        For b As Integer = BGVRpt.Bands.Count - 1 To 0 Step -1
            If BGVRpt.Bands(b).Name.ToString.Contains("gridBandAcc_") Then
                BGVRpt.Bands(b).Dispose()
            End If
        Next

        'get account
        Dim qacc As String = "SELECT d.comp_number FROM tb_rpt_det d
        WHERE d.id_rpt=" + id + "
        GROUP BY d.comp_number
        ORDER BY comp_number ASC "
        Dim dacc As DataTable = execute_query(qacc, -1, False, app_host, app_username, app_password, "db_opt")
        Dim col_prc As String = ""
        Dim col_soh As String = ""
        Dim col_soh_value As String = ""
        Dim col_scan As String = ""
        Dim col_scan_value As String = ""
        Dim col_diff As String = ""
        Dim col_diff_value As String = ""
        Dim col_note As String = ""
        For a As Integer = 0 To dacc.Rows.Count - 1
            Dim band_new As DevExpress.XtraGrid.Views.BandedGrid.GridBand = BGVRpt.Bands.AddBand(dacc.Rows(a)("comp_number").ToString)
            band_new.AppearanceHeader.Font = New Font(BGVRpt.Appearance.Row.Font.FontFamily, BGVRpt.Appearance.Row.Font.Size, FontStyle.Bold)
            band_new.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            band_new.Name = "gridBandAcc_" + dacc.Rows(a)("comp_number").ToString

            'add to band
            band_new.Columns.Add(BGVRpt.Columns.AddVisible("" + dacc.Rows(a)("comp_number").ToString + "#Price", "Price"))
            band_new.Columns.Add(BGVRpt.Columns.AddVisible("" + dacc.Rows(a)("comp_number").ToString + "#SOH", "SOH"))
            band_new.Columns.Add(BGVRpt.Columns.AddVisible("" + dacc.Rows(a)("comp_number").ToString + "#SOHValue", "Value"))
            band_new.Columns.Add(BGVRpt.Columns.AddVisible("" + dacc.Rows(a)("comp_number").ToString + "#Scan", "FISIK"))
            band_new.Columns.Add(BGVRpt.Columns.AddVisible("" + dacc.Rows(a)("comp_number").ToString + "#ScanValue", "Value"))
            band_new.Columns.Add(BGVRpt.Columns.AddVisible("" + dacc.Rows(a)("comp_number").ToString + "#Diff", "SELISIH"))
            band_new.Columns.Add(BGVRpt.Columns.AddVisible("" + dacc.Rows(a)("comp_number").ToString + "#DiffValue", "Value"))
            'column propertis
            BGVRpt.Columns("" + dacc.Rows(a)("comp_number").ToString + "#Price").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            BGVRpt.Columns("" + dacc.Rows(a)("comp_number").ToString + "#Price").DisplayFormat.FormatString = "{0:n0}"
            BGVRpt.Columns("" + dacc.Rows(a)("comp_number").ToString + "#SOH").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            BGVRpt.Columns("" + dacc.Rows(a)("comp_number").ToString + "#SOH").DisplayFormat.FormatString = "{0:n0}"
            BGVRpt.Columns("" + dacc.Rows(a)("comp_number").ToString + "#SOH").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            BGVRpt.Columns("" + dacc.Rows(a)("comp_number").ToString + "#SOH").SummaryItem.DisplayFormat = "{0:n0}"
            BGVRpt.Columns("" + dacc.Rows(a)("comp_number").ToString + "#SOHValue").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            BGVRpt.Columns("" + dacc.Rows(a)("comp_number").ToString + "#SOHValue").DisplayFormat.FormatString = "{0:n0}"
            BGVRpt.Columns("" + dacc.Rows(a)("comp_number").ToString + "#SOHValue").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            BGVRpt.Columns("" + dacc.Rows(a)("comp_number").ToString + "#SOHValue").SummaryItem.DisplayFormat = "{0:n0}"
            BGVRpt.Columns("" + dacc.Rows(a)("comp_number").ToString + "#Scan").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            BGVRpt.Columns("" + dacc.Rows(a)("comp_number").ToString + "#Scan").DisplayFormat.FormatString = "{0:n0}"
            BGVRpt.Columns("" + dacc.Rows(a)("comp_number").ToString + "#Scan").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            BGVRpt.Columns("" + dacc.Rows(a)("comp_number").ToString + "#Scan").SummaryItem.DisplayFormat = "{0:n0}"
            BGVRpt.Columns("" + dacc.Rows(a)("comp_number").ToString + "#ScanValue").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            BGVRpt.Columns("" + dacc.Rows(a)("comp_number").ToString + "#ScanValue").DisplayFormat.FormatString = "{0:n0}"
            BGVRpt.Columns("" + dacc.Rows(a)("comp_number").ToString + "#ScanValue").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            BGVRpt.Columns("" + dacc.Rows(a)("comp_number").ToString + "#ScanValue").SummaryItem.DisplayFormat = "{0:n0}"
            BGVRpt.Columns("" + dacc.Rows(a)("comp_number").ToString + "#Diff").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            BGVRpt.Columns("" + dacc.Rows(a)("comp_number").ToString + "#Diff").DisplayFormat.FormatString = "{0:n0}"
            BGVRpt.Columns("" + dacc.Rows(a)("comp_number").ToString + "#Diff").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            BGVRpt.Columns("" + dacc.Rows(a)("comp_number").ToString + "#Diff").SummaryItem.DisplayFormat = "{0:n0}"
            BGVRpt.Columns("" + dacc.Rows(a)("comp_number").ToString + "#DiffValue").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            BGVRpt.Columns("" + dacc.Rows(a)("comp_number").ToString + "#DiffValue").DisplayFormat.FormatString = "{0:n0}"
            BGVRpt.Columns("" + dacc.Rows(a)("comp_number").ToString + "#DiffValue").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            BGVRpt.Columns("" + dacc.Rows(a)("comp_number").ToString + "#DiffValue").SummaryItem.DisplayFormat = "{0:n0}"

            'col str
            col_prc += "IFNULL((CASE WHEN d.comp_number='" + dacc.Rows(a)("comp_number").ToString + "' THEN d.unit_price END),0) AS `" + dacc.Rows(a)("comp_number").ToString + "#Price`, "
            col_soh += "IFNULL(SUM(CASE WHEN d.comp_number='" + dacc.Rows(a)("comp_number").ToString + "' THEN d.soh_qty END),0) AS `" + dacc.Rows(a)("comp_number").ToString + "#SOH`, "
            col_soh_value += "IFNULL(SUM(CASE WHEN d.comp_number='" + dacc.Rows(a)("comp_number").ToString + "' THEN d.soh_value END),0) AS `" + dacc.Rows(a)("comp_number").ToString + "#SOHValue`, "
            col_scan += "IFNULL(SUM(CASE WHEN d.comp_number='" + dacc.Rows(a)("comp_number").ToString + "' THEN d.scan_qty END),0) AS `" + dacc.Rows(a)("comp_number").ToString + "#Scan`, "
            col_scan_value += "IFNULL(SUM(CASE WHEN d.comp_number='" + dacc.Rows(a)("comp_number").ToString + "' THEN d.scan_value END),0) AS `" + dacc.Rows(a)("comp_number").ToString + "#ScanValue`, "
            col_diff += "IFNULL(SUM(CASE WHEN d.comp_number='" + dacc.Rows(a)("comp_number").ToString + "' THEN d.diff_qty END),0) AS `" + dacc.Rows(a)("comp_number").ToString + "#Diff`, "
            col_diff_value += "IFNULL(SUM(CASE WHEN d.comp_number='" + dacc.Rows(a)("comp_number").ToString + "' THEN d.diff_value END),0) AS `" + dacc.Rows(a)("comp_number").ToString + "#DiffValue`, "

            'col note
            If a > 0 Then
                col_note += ","
            End If
            col_note += "IF((IFNULL(SUM(CASE WHEN d.comp_number='" + dacc.Rows(a)("comp_number").ToString + "' THEN d.diff_qty END),0))!=0, '" + dacc.Rows(a)("comp_number").ToString + ";','') "
        Next

        'data
        Dim query As String = "SELECT d.prod_code AS `Barcode`, d.prod_code_main AS `SKU`, d.prod_name AS `Description`, d.size AS `Size`,
        " + col_prc + "
        " + col_soh + "
        " + col_soh_value + "
        " + col_scan + "
        " + col_scan_value + "
        " + col_diff + "
        " + col_diff_value + "
        SUM(d.soh_qty) AS `Total SOH`, SUM(d.soh_value) AS `Value SOH`, SUM(d.scan_qty) AS `Total Scan`, SUM(d.scan_value) AS `Value Scan`,
        SUM(d.diff_qty) AS `Total Diff`, SUM(d.diff_value) AS `Value Diff`,
        IF(SUM(d.diff_qty)<0, 'Over Fisik', IF(SUM(d.diff_qty)>0,'Missing','')) AS `note`,
        CONCAT(" + col_note + ") AS `Account Diff`
        FROM tb_rpt_det d
        GROUP BY d.prod_code
        ORDER BY Description ASC "
        Dim data As DataTable = execute_query(query, -1, False, app_host, app_username, app_password, "db_opt")
        GCRpt.DataSource = data

        'set view opt
        BGVRpt.BestFitColumns()
        BGVRpt.Bands.MoveTo(1, gridBandDescription)
        BGVRpt.Bands.MoveTo(200, gridBandGlobal)
        Cursor = Cursors.Default
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub FormRptDet_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub BtnSaveChanges_Click(sender As Object, e As EventArgs) Handles BtnSaveChanges.Click
        If LEStatus.Text = "Cancelled" And TxtStatusNote.Text = "" Then
            stopCustom("Please fill reason cancellation")
            Exit Sub
        End If

        Dim confirm As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure you want to save changes this transaction ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If confirm = DialogResult.Yes Then
            Cursor = Cursors.WaitCursor
            Dim query As String = "UPDATE tb_rpt SET rpt_note='" + addSlashes(MENote.Text) + "', report_status='" + addSlashes(LEStatus.Text) + "', report_status_note='" + addSlashes(TxtStatusNote.Text) + "' WHERE id_rpt='" + id + "' "
            execute_non_query(query, False, app_host, app_username, app_password, "db_opt")
            FormRpt.viewData()
            FormRpt.GVData.FocusedRowHandle = find_row(FormRpt.GVData, "id_rpt", id)
            actionLoad()
            Cursor = Cursors.Default
        End If
    End Sub

    Private Sub XTCReport_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XTCReport.SelectedPageChanged
        If XTCReport.SelectedTabPageIndex = 0 Then
            viewCombineList()
        ElseIf XTCReport.SelectedTabPageIndex = 1 Then
            viewDetailReport()
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BGVRpt_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles BGVRpt.CustomColumnDisplayText
        If e.Column.FieldName = "no" Then
            e.DisplayText = (e.ListSourceRowIndex + 1).ToString()
        ElseIf e.Column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric Then
            Dim qty As Decimal = Convert.ToDecimal(e.Value)
            If qty = 0 Then
                e.DisplayText = "-"
            End If
        End If
    End Sub

    Public Sub custom_cell(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        Dim View As DevExpress.XtraGrid.Views.Grid.GridView = sender

        If CEShowHighlights.EditValue = True And (e.Column.FieldName.ToString.Contains("#Diff") Or e.Column.FieldName.ToString.Contains("#DiffValue")) Then
            Dim val As Decimal = e.CellValue

            If val <> 0 Then
                e.Appearance.BackColor = Color.Yellow
            Else
                e.Appearance.BackColor = Color.Empty
            End If
        Else
            e.Appearance.BackColor = Color.Empty
        End If
    End Sub

    Private Sub CEShowHighlights_CheckedChanged(sender As Object, e As EventArgs) Handles CEShowHighlights.CheckedChanged
        AddHandler BGVRpt.RowCellStyle, AddressOf custom_cell
        GCRpt.Focus()
    End Sub

    Private Sub BtnPrintDetail_Click(sender As Object, e As EventArgs) Handles BtnPrintDetail.Click
        Cursor = Cursors.WaitCursor
        BGVRpt.BestFitColumns()
        ReportRpt.dt = GCRpt.DataSource
        Dim Report As New ReportRpt()

        ' '... 
        ' ' creating and saving the view's layout to a new memory stream 
        Dim str As System.IO.Stream
        str = New System.IO.MemoryStream()
        BGVRpt.SaveLayoutToStream(str, DevExpress.Utils.OptionsLayoutBase.FullLayout)
        str.Seek(0, System.IO.SeekOrigin.Begin)
        Report.BGVRpt.RestoreLayoutFromStream(str, DevExpress.Utils.OptionsLayoutBase.FullLayout)
        str.Seek(0, System.IO.SeekOrigin.Begin)

        'Grid Detail
        ReportStyleBanded(Report.BGVRpt)

        'Parse val
        Report.LabelNo.Text = TxtNumber.Text
        Report.LabelRemark.Text = TxtNumber.Text
        Report.LabelCreatedDate.Text = DECreatedDate.Text
        Report.LabelCreatedBy.Text = TxtCreatedBy.Text
        Report.LabelRemark.Text = MENote.Text.ToString

        'Show the report's preview. 
        Dim Tool As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Report)
        Tool.ShowPreviewDialog()
        Cursor = Cursors.Default
    End Sub

    Private Sub BtnExportToXLSX_Click(sender As Object, e As EventArgs) Handles BtnExportToXLSX.Click
        If BGVRpt.RowCount > 0 Then
            Cursor = Cursors.WaitCursor

            Dim path As String = Application.StartupPath & "\download\"
            'create directory if not exist
            If Not IO.Directory.Exists(path) Then
                System.IO.Directory.CreateDirectory(path)
            End If
            Dim uTime As Integer = (DateTime.UtcNow - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds
            path = path + "stocktake_report_" + uTime.ToString + ".xlsx"
            exportToXLS(path, "rpt", GCRpt)
            Cursor = Cursors.Default
        End If
    End Sub

    Sub exportToXLS(ByVal path_par As String, ByVal sheet_name_par As String, ByVal gc_par As DevExpress.XtraGrid.GridControl)
        Cursor = Cursors.WaitCursor
        Dim path As String = path_par

        ' Customize export options 
        CType(gc_par.MainView, DevExpress.XtraGrid.Views.Grid.GridView).OptionsPrint.PrintHeader = True
        CType(gc_par.MainView, DevExpress.XtraGrid.Views.Grid.GridView).OptionsPrint.AllowMultilineHeaders = True
        Dim advOptions As DevExpress.XtraPrinting.XlsxExportOptionsEx = New DevExpress.XtraPrinting.XlsxExportOptionsEx()
        advOptions.AllowSortingAndFiltering = DevExpress.Utils.DefaultBoolean.False
        advOptions.ShowGridLines = DevExpress.Utils.DefaultBoolean.False
        advOptions.AllowGrouping = DevExpress.Utils.DefaultBoolean.False
        advOptions.ShowTotalSummaries = DevExpress.Utils.DefaultBoolean.False
        advOptions.SheetName = sheet_name_par
        advOptions.ExportType = DevExpress.Export.ExportType.WYSIWYG

        Try
            gc_par.ExportToXlsx(path, advOptions)
            Process.Start(path)
            ' Open the created XLSX file with the default application. 
        Catch ex As Exception
            stopCustom(ex.ToString)
        End Try
        Cursor = Cursors.Default
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Cursor = Cursors.WaitCursor
        print_raw(GCAccount, "")
        Cursor = Cursors.Default
    End Sub
End Class