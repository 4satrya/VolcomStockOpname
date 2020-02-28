Public Class FormRptDet
    Public id As String = "-1"
    Private Sub FormRptDet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actionLoad()
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

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    Private Sub FormRptDet_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub BtnSaveChanges_Click(sender As Object, e As EventArgs) Handles BtnSaveChanges.Click

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
End Class