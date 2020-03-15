Public Class FormRpt
    Public id_pop_up As String = "-1"

    Private Sub FormRpt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewData()
    End Sub

    Private Sub FormRpt_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Sub viewData()
        Cursor = Cursors.WaitCursor
        Dim rpt As New ClassRpt()
        Dim query As String = rpt.queryMain("-1", "2")
        Dim data As DataTable = execute_query(query, -1, False, app_host, app_username, app_password, "db_opt")
        GCData.DataSource = data
        GVData.BestFitColumns()
        Cursor = Cursors.Default
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        viewData()
    End Sub

    Private Sub BtnAddReport_Click(sender As Object, e As EventArgs) Handles BtnAddReport.Click
        Cursor = Cursors.WaitCursor
        FormRptNew.ShowDialog()
        Cursor = Cursors.Default
    End Sub

    Private Sub BtnUse_Click(sender As Object, e As EventArgs) Handles BtnUse.Click
        If GVData.RowCount > 0 And GVData.FocusedRowHandle >= 0 Then
            Dim confirm As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure you want to add stocktake result to this report number ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            If confirm = DialogResult.Yes Then
                Dim gv As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
                Dim id_rpt As String = GVData.GetFocusedRowCellValue("id_rpt").ToString
                If id_pop_up = "1" Then
                    'cek existing
                    Dim qry_cek As String = "SELECT * FROM tb_rpt_det rd WHERE rd.db_name='" + app_database + "'AND rd.combine_no='" + FormStockTakeDet.TxtNumber.Text + "' AND rd.combine_type=1 "
                    Dim data_cek As DataTable = execute_query(qry_cek, -1, False, app_host, app_username, app_password, "db_opt")
                    If data_cek.Rows.Count > 0 Then
                        stopCustom("This number already added to this report")
                        Cursor = Cursors.Default
                        Exit Sub
                    End If

                    'stocktake toko/pre stocktake
                    SplashScreenManager1.ShowWaitForm()

                    gv = FormStockTakeDet.BGVCompare
                    makeSafeGV(gv)
                    For i As Integer = 0 To gv.RowCount - 1
                        SplashScreenManager1.SetWaitFormDescription("Processing row " + i.ToString + " of " + gv.RowCount.ToString)
                        Dim db_name As String = app_database
                        Dim combine_no As String = FormStockTakeDet.TxtNumber.Text
                        Dim combine_type As String = "1"
                        Dim comp_number As String = FormStockTakeDet.comp_number
                        Dim comp_name As String = FormStockTakeDet.comp_name
                        Dim prod_code As String = gv.GetRowCellValue(i, "barcode").ToString
                        Dim prod_code_main As String = gv.GetRowCellValue(i, "code").ToString
                        Dim prod_name As String = addSlashes(gv.GetRowCellValue(i, "name").ToString)
                        Dim size As String = gv.GetRowCellValue(i, "size").ToString
                        Dim prod_status As String = gv.GetRowCellValue(i, "design_cat").ToString
                        Dim unit_price As String = decimalSQL(gv.GetRowCellValue(i, "design_price").ToString)
                        Dim soh_qty As String = decimalSQL(gv.GetRowCellValue(i, "qty_soh").ToString)
                        Dim soh_value As String = decimalSQL(gv.GetRowCellValue(i, "val_soh").ToString)
                        Dim scan_qty As String = decimalSQL(gv.GetRowCellValue(i, "qty_scan").ToString)
                        Dim scan_value As String = decimalSQL(gv.GetRowCellValue(i, "val_scan").ToString)
                        Dim diff_qty As String = decimalSQL(gv.GetRowCellValue(i, "qty_diff").ToString)
                        Dim diff_value As String = decimalSQL(gv.GetRowCellValue(i, "val_diff").ToString)
                        Dim note As String = addSlashes(gv.GetRowCellValue(i, "note").ToString)
                        Dim store_remark As String = addSlashes(gv.GetRowCellValue(i, "store_remark").ToString)

                        'If i > 0 Then
                        '    qry += ", "
                        'End If
                        Dim qry As String = "INSERT INTO tb_rpt_det(id_rpt, db_name, combine_no, combine_type, comp_number, comp_name, prod_code, prod_code_main, 
                        prod_name, size, prod_status, unit_price, soh_qty, soh_value, scan_qty, scan_value, diff_qty, diff_value, note, store_remark) VALUES "
                        qry += "('" + id_rpt + "', '" + db_name + "', '" + combine_no + "', '1', '" + comp_number + "', '" + comp_name + "', '" + prod_code + "', '" + prod_code_main + "',
                        '" + prod_name + "', '" + size + "', '" + prod_status + "', '" + unit_price + "', '" + soh_qty + "', '" + soh_value + "', '" + scan_qty + "', '" + scan_value + "', '" + diff_qty + "', '" + diff_value + "', '" + note + "', '" + store_remark + "') "
                        execute_non_query(qry, False, app_host, app_username, app_password, "db_opt")
                    Next
                    'SplashScreenManager1.SetWaitFormDescription("Adding to report")
                    SplashScreenManager1.CloseWaitForm()
                    infoCustom("Success")
                ElseIf id_pop_up = "2" Then
                    'ver stocktake
                    'cek existing
                    Dim qry_cek As String = "SELECT * FROM tb_rpt_det rd WHERE rd.db_name='" + app_database + "'AND rd.combine_no='" + FormVerStockTakeDet.TxtNumber.Text + "' AND rd.combine_type=2 "
                    Dim data_cek As DataTable = execute_query(qry_cek, -1, False, app_host, app_username, app_password, "db_opt")
                    If data_cek.Rows.Count > 0 Then
                        stopCustom("This number already added to this report")
                        Cursor = Cursors.Default
                        Exit Sub
                    End If

                    'stocktake toko/pre stocktake
                    SplashScreenManager1.ShowWaitForm()
                    gv = FormVerStockTakeDet.BGVCompare
                    makeSafeGV(gv)
                    For i As Integer = 0 To gv.RowCount - 1
                        SplashScreenManager1.SetWaitFormDescription("Processing row " + i.ToString + " of " + gv.RowCount.ToString)
                        Dim db_name As String = app_database
                        Dim combine_no As String = FormVerStockTakeDet.TxtNumber.Text
                        Dim combine_type As String = "1"
                        Dim comp_number As String = FormVerStockTakeDet.comp_number
                        Dim comp_name As String = FormVerStockTakeDet.comp_name
                        Dim prod_code As String = gv.GetRowCellValue(i, "barcode").ToString
                        Dim prod_code_main As String = gv.GetRowCellValue(i, "code").ToString
                        Dim prod_name As String = addSlashes(gv.GetRowCellValue(i, "name").ToString)
                        Dim size As String = gv.GetRowCellValue(i, "size").ToString
                        Dim prod_status As String = gv.GetRowCellValue(i, "design_cat").ToString
                        Dim unit_price As String = decimalSQL(gv.GetRowCellValue(i, "design_price").ToString)
                        Dim soh_qty As String = decimalSQL(gv.GetRowCellValue(i, "qty_soh").ToString)
                        Dim soh_value As String = decimalSQL(gv.GetRowCellValue(i, "val_soh").ToString)
                        Dim scan_qty As String = decimalSQL(gv.GetRowCellValue(i, "qty_scan").ToString)
                        Dim scan_value As String = decimalSQL(gv.GetRowCellValue(i, "val_scan").ToString)
                        Dim diff_qty As String = decimalSQL(gv.GetRowCellValue(i, "qty_diff").ToString)
                        Dim diff_value As String = decimalSQL(gv.GetRowCellValue(i, "val_diff").ToString)
                        Dim note As String = addSlashes(gv.GetRowCellValue(i, "note").ToString)

                        'If i > 0 Then
                        '    qry += ", "
                        'End If
                        Dim qry As String = "INSERT INTO tb_rpt_det(id_rpt, db_name, combine_no, combine_type, comp_number, comp_name, prod_code, prod_code_main, 
                        prod_name, size, prod_status, unit_price, soh_qty, soh_value, scan_qty, scan_value, diff_qty, diff_value, note) VALUES "
                        qry += "('" + id_rpt + "', '" + db_name + "', '" + combine_no + "', '2', '" + comp_number + "', '" + comp_name + "', '" + prod_code + "', '" + prod_code_main + "',
                        '" + prod_name + "', '" + size + "', '" + prod_status + "', '" + unit_price + "', '" + soh_qty + "', '" + soh_value + "', '" + scan_qty + "', '" + scan_value + "', '" + diff_qty + "', '" + diff_value + "', '" + note + "') "
                        execute_non_query(qry, False, app_host, app_username, app_password, "db_opt")
                    Next
                    'SplashScreenManager1.SetWaitFormDescription("Adding to report")
                    SplashScreenManager1.CloseWaitForm()
                    infoCustom("Success")
                End If
                Close()
            End If
        End If
    End Sub

    Private Sub GVData_DoubleClick(sender As Object, e As EventArgs) Handles GVData.DoubleClick
        If GVData.RowCount > 0 And GVData.FocusedRowHandle >= 0 Then
            FormRptDet.id = GVData.GetFocusedRowCellValue("id_rpt").ToString
            FormRptDet.ShowDialog()
        End If
    End Sub
End Class