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
        GROUP BY d.combine_no "
        Dim data As DataTable = execute_query(query, -1, False, app_host, app_username, app_password, "db_opt")
        GCAccount.DataSource = data
        GVAccount.BestFitColumns()
        Cursor = Cursors.Default
    End Sub

    Sub viewDetailReport()
        Cursor = Cursors.WaitCursor

        'get account
        Dim qacc As String = "SELECT d.comp_number FROM tb_rpt_det d
        WHERE d.id_rpt=" + id + "
        GROUP BY d.comp_number
        ORDER BY comp_number ASC "
        Dim dacc As DataTable = execute_query(qacc, -1, False, app_host, app_username, app_password, "db_opt")
        For a As Integer = 0 To dacc.Rows.Count - 1
            Dim band_new As DevExpress.XtraGrid.Views.BandedGrid.GridBand = BGVRpt.Bands.AddBand(dacc.Rows(a)("comp_number").ToString)
            band_new.AppearanceHeader.Font = New Font(BGVRpt.Appearance.Row.Font.FontFamily, BGVRpt.Appearance.Row.Font.Size, FontStyle.Bold)
            band_new.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            band_new.Name = "gridBandAcc_" + dacc.Rows(a)("comp_number").ToString
        Next

        'data
        Dim query As String = "SELECT d.prod_code AS `Barcode`, d.prod_code_main AS `SKU`, d.prod_name AS `Description`, d.size AS `Size`,
        SUM(d.soh_qty) AS `Total SOH`, SUM(d.soh_value) AS `Value SOH`, SUM(d.scan_qty) AS `Total Scan`, SUM(d.scan_value) AS `Value Scan`
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

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        'search band
        For b As Integer = 0 To BGVRpt.Bands.Count - 1
            MsgBox(BGVRpt.Bands(b).Name.ToString)
        Next
    End Sub
End Class