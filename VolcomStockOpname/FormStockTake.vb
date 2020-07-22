Imports MySql.Data.MySqlClient
Public Class FormStockTake
    Public is_pre As String = "2"

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        Cursor = Cursors.WaitCursor
        FormStockTakeNew.ShowDialog()
        Cursor = Cursors.Default
    End Sub

    Private Sub FormStockTake_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'detail properties
        If is_pre = "1" Then
            Text = "Pre Stocktake"
        Else
            Text = "Stocktake"
        End If
        viewUserType()
        viewScan()
        viewCombine()

        If id_role_login = "5" Then
            XtraTabPage2.PageVisible = False

            BtnImport.Visible = False
            BtnExport.Visible = False
            PCSelectAll.Visible = False

            BtnExportStop.Visible = True
            BtnCreateNewAllowRecordUniqueNotFound.Visible = True

            Dim is_stop_scan As String = execute_query("SELECT is_stop_scan FROM tb_m_user WHERE id_user = '" + id_user + "'", 0, True, "", "", "", "")

            If is_stop_scan = "1" Then
                stopCustom("Access denied.")

                BeginInvoke(New MethodInvoker(AddressOf Close))
            End If
        End If
    End Sub

    Sub viewUserType()
        Cursor = Cursors.WaitCursor
        Dim query As String = "SELECT '1' AS `id_user_type`, 'User Login' AS `type_user`
        UNION 
        SELECT '2' AS `id_user_type`, 'All User' AS `type_user` "
        viewLookupQuery(LEViewUser, query, 0, "type_user", "id_user_type")
        Cursor = Cursors.Default
    End Sub

    Sub viewScan()
        Cursor = Cursors.WaitCursor

        'user view
        Dim cond_user As String = ""
        If LEViewUser.EditValue.ToString = "1" Then
            cond_user = "AND st.st_trans_by='" + id_user + "' "
        End If

        Dim stake As New ClassStockTake()
        Dim query As String = stake.queryTransMain("AND st.is_combine=2 AND st.is_pre=" + is_pre + " " + cond_user + " ", "2")
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        GCScan.DataSource = data
        GVScan.FocusedRowHandle = 0
        noEdit()
        Cursor = Cursors.Default
    End Sub

    Sub viewCombine()
        Cursor = Cursors.WaitCursor
        Dim stake As New ClassStockTake()
        Dim query As String = stake.queryTransMain("AND st.is_combine=1 AND st.is_pre=" + is_pre + " ", "2")
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        GCCombine.DataSource = data
        Cursor = Cursors.Default
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        viewScan()
    End Sub


    Sub noEdit()
        If GVScan.RowCount > 0 Then
            Dim alloc_cek As String = GVScan.GetFocusedRowCellValue("id_report_status").ToString
            If alloc_cek = "5" Then
                GVScan.Columns("is_select").OptionsColumn.AllowEdit = False
            Else
                GVScan.Columns("is_select").OptionsColumn.AllowEdit = True
            End If
        End If
    End Sub

    Private Sub GVScan_DoubleClick(sender As Object, e As EventArgs) Handles GVScan.DoubleClick
        If GVScan.RowCount > 0 And GVScan.FocusedRowHandle >= 0 Then
            FormStockTakeDet.action = "upd"
            FormStockTakeDet.id_st_trans = GVScan.GetFocusedRowCellValue("id_st_trans").ToString
            FormStockTakeDet.ShowDialog()
        End If
    End Sub

    Private Sub BtnExport_Click(sender As Object, e As EventArgs) Handles BtnExport.Click
        makeSafeGV(GVScan)
        GVScan.ActiveFilterString = "[is_select]='Yes' "
        If GVScan.RowCount > 0 Then
            Dim confirm As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure you want to export stock take data as .sql file?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            If confirm = DialogResult.Yes Then
                FormMain.SplashScreenManager1.ShowWaitForm()
                Dim id_st_trans As String = ""
                For i As Integer = 0 To ((GVScan.RowCount - 1) - GetGroupRowCount(GVScan))
                    If GVScan.GetRowCellValue(i, "is_select").ToString = "Yes" Then
                        If i > 0 Then
                            id_st_trans += "OR "
                        End If
                        id_st_trans += "id_st_trans='" + GVScan.GetRowCellValue(i, "id_st_trans").ToString + "' "
                    End If
                Next

                'create table copy
                Dim query_copy_trans As String = "DROP TABLE IF EXISTS tb_st_trans_" + st_user_code + "; CREATE TABLE IF NOT EXISTS tb_st_trans_" + st_user_code + " SELECT * FROM tb_st_trans WHERE id_st_trans>0 AND (" + id_st_trans + "); 
                truncate table tb_st_trans_" + st_user_code + "; 
                INSERT tb_st_trans_" + st_user_code + " SELECT * FROM tb_st_trans WHERE id_st_trans>0 AND (" + id_st_trans + "); "
                execute_non_query(query_copy_trans, True, "", "", "", "")
                Dim query_copy_trans_det As String = "DROP TABLE IF EXISTS tb_st_trans_det_" + st_user_code + "; CREATE TABLE IF NOT EXISTS tb_st_trans_det_" + st_user_code + " SELECT * FROM tb_st_trans_det WHERE id_st_trans>0 AND (" + id_st_trans + "); 
                truncate table tb_st_trans_det_" + st_user_code + "; 
                INSERT tb_st_trans_det_" + st_user_code + " SELECT * FROM tb_st_trans_det WHERE id_st_trans>0 AND (" + id_st_trans + "); "
                execute_non_query(query_copy_trans_det, True, "", "", "", "")

                'connection string
                FormMain.SplashScreenManager1.SetWaitFormDescription("Check connection ...")
                Dim dbc_str As String() = Split(app_database, "_")
                Dim name_dir = dbc_str(1) + "_" + dbc_str(2) + "_" + st_user_code + "_" + header_number("3", "0")
                Dim constring As String = "server=" + app_host + ";user=" + app_username + ";pwd=" + app_password + ";database=" + app_database + ";allow zero datetime=yes;"
                Dim path_root As String = Application.StartupPath + "\download\scan\" + name_dir
                'create directory if not exist
                If Not IO.Directory.Exists(path_root) Then
                    System.IO.Directory.CreateDirectory(path_root)
                End If
                Dim fileName As String = name_dir + ".sql"
                Dim file As String = IO.Path.Combine(path_root, fileName)

                '-- scan data
                FormMain.SplashScreenManager1.SetWaitFormDescription("Backup scan data")
                Dim dic As New Dictionary(Of String, String)()
                dic.Add("tb_st_trans_" + st_user_code.ToLower, "SELECT * FROM tb_st_trans_" + st_user_code.ToLower)
                dic.Add("tb_st_trans_det_" + st_user_code.ToLower, "SELECT * FROM tb_st_trans_det_" + st_user_code.ToLower)

                'dump
                FormMain.SplashScreenManager1.SetWaitFormDescription("Creating dump")
                Using conn As New MySqlConnection(constring)
                    Using cmd As New MySqlCommand()
                        Using mb As New MySqlBackup(cmd)
                            cmd.Connection = conn
                            conn.Open()
                            mb.ExportInfo.AddCreateDatabase = False
                            mb.ExportInfo.ExportTableStructure = True
                            mb.ExportInfo.ExportRows = True
                            mb.ExportInfo.TablesToBeExportedDic = dic
                            mb.ExportInfo.ExportProcedures = False
                            mb.ExportInfo.ExportFunctions = False
                            mb.ExportInfo.ExportTriggers = False
                            mb.ExportInfo.ExportEvents = False
                            mb.ExportInfo.ExportViews = False
                            mb.ExportInfo.EnableEncryption = True
                            mb.ExportInfo.EncryptionPassword = "csmtafc"
                            mb.ExportToFile(file)
                        End Using
                    End Using
                End Using

                FormMain.SplashScreenManager1.CloseWaitForm()
                openFile("\" + name_dir)
            End If
            makeSafeGV(GVScan)
        Else
            stopCustom("Please select data first !")
            makeSafeGV(GVScan)
        End If
    End Sub

    Sub openFile(ByVal additional As String)
        Cursor = Cursors.WaitCursor
        Dim path_root As String = Application.StartupPath + "\download\scan" + additional
        Process.Start("explorer.exe", path_root)
        Cursor = Cursors.Default
    End Sub

    Private Sub BtnImport_Click(sender As Object, e As EventArgs) Handles BtnImport.Click
        Me.Cursor = Cursors.WaitCursor
        Dim url_import As String = ""
        Dim fdlg As OpenFileDialog = New OpenFileDialog()
        fdlg.Title = "Select sql file To import"
        fdlg.InitialDirectory = Application.StartupPath + "\download\scan"
        fdlg.Filter = "SQL File|*.sql;"
        fdlg.FilterIndex = 0
        fdlg.RestoreDirectory = True
        Cursor = Cursors.Default
        If fdlg.ShowDialog() = DialogResult.OK Then
            FormMain.SplashScreenManager1.ShowWaitForm()
            url_import = fdlg.FileName.ToString
            Dim FileInfo As New IO.FileInfo(url_import)
            Dim arr_file_name As String() = Split(FileInfo.Name.ToString, ".")
            Dim arr_code_user_restore As String() = Split(arr_file_name(0), "_")
            Dim code_user_restore As String = arr_code_user_restore(2)
            Try
                'restore db
                FormMain.SplashScreenManager1.SetWaitFormDescription("Restoring data ...")
                Dim constring As String = "server=" + app_host + ";user=" + app_username + ";pwd=" + app_password + ";database=" + app_database + ";"
                Using conn As New MySqlConnection(constring)
                    Using cmd As New MySqlCommand()
                        Using mb As New MySqlBackup(cmd)
                            cmd.Connection = conn
                            conn.Open()
                            mb.ImportInfo.TargetDatabase = app_database
                            mb.ImportInfo.EnableEncryption = True
                            mb.ImportInfo.EncryptionPassword = "csmtafc"
                            mb.ImportFromFile(url_import)
                            conn.Close()
                        End Using
                    End Using
                End Using

                'copying data
                Dim qv As String = "SELECT * FROM tb_st_trans_" + code_user_restore
                Dim dv As DataTable = execute_query(qv, -1, True, "", "", "", "")
                Dim jv As Integer = dv.Rows.Count
                For j As Integer = 0 To dv.Rows.Count - 1
                    FormMain.SplashScreenManager1.SetWaitFormDescription("Copying data " + (j + 1).ToString + " of " + jv.ToString + " ...")
                    Dim query_ins As String = "INSERT INTO tb_st_trans(id_wh_drawer, st_trans_number, remark, st_trans_date, st_trans_by, st_trans_updated, st_trans_updated_by, is_combine, id_report_status) 
                    SELECT id_wh_drawer, st_trans_number, remark, st_trans_date, st_trans_by, st_trans_updated, st_trans_updated_by, is_combine, id_report_status FROM tb_st_trans_" + code_user_restore.ToLower + " WHERE id_st_trans=" + dv.Rows(j)("id_st_trans").ToString + "; SELECT LAST_INSERT_ID(); "
                    Dim id_st_new As String = execute_query(query_ins, 0, True, "", "", "", "")
                    Dim query_ins_det As String = "INSERT INTO tb_st_trans_det(id_st_trans, is_ok, is_no_stock, is_no_master, is_sale, is_reject, is_unique_not_found, is_no_tag, id_product, code, name, size, qty, id_design_price, design_price, note) 
                    SELECT '" + id_st_new + "', is_ok, is_no_stock, is_no_master, is_sale, is_reject, is_unique_not_found, is_no_tag, id_product, code, name, size, qty, id_design_price, design_price, note FROM tb_st_trans_det_" + code_user_restore.ToLower + " WHERE id_st_trans=" + dv.Rows(j)("id_st_trans").ToString + ";"
                    execute_non_query(query_ins_det, True, "", "", "", "")
                Next
                viewScan()
                FormMain.SplashScreenManager1.CloseWaitForm()
            Catch ex As Exception
                FormMain.SplashScreenManager1.CloseWaitForm()
                errorCustom(ex.ToString)
            End Try
        End If
        fdlg.Dispose()
    End Sub

    Private Sub GVScan_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GVScan.FocusedRowChanged
        noEdit()
    End Sub

    Private Sub GVScan_ColumnFilterChanged(sender As Object, e As EventArgs) Handles GVScan.ColumnFilterChanged
        noEdit()
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If GVScan.RowCount > 0 Then
            Dim cek As String = CheckEdit1.EditValue.ToString
            For i As Integer = 0 To ((GVScan.RowCount - 1) - GetGroupRowCount(GVScan))
                Dim id_report_status As String = GVScan.GetRowCellValue(i, "id_report_status").ToString
                If cek And id_report_status = "1" Then
                    GVScan.SetRowCellValue(i, "is_select", "Yes")
                Else
                    GVScan.SetRowCellValue(i, "is_select", "No")
                End If
            Next
        End If
    End Sub

    Private Sub BtnCombine_Click(sender As Object, e As EventArgs)
        makeSafeGV(GVScan)
        GVScan.ActiveFilterString = "[is_select]='Yes' "
        If GVScan.RowCount > 0 Then
            FormStockTakeCombine.ShowDialog()
            makeSafeGV(GVScan)
        Else
            stopCustom("Please select data first !")
            makeSafeGV(GVScan)
        End If
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        Cursor = Cursors.WaitCursor
        print_raw(GCScan, "")
        Cursor = Cursors.Default
    End Sub

    Private Sub BtnRefCom_Click(sender As Object, e As EventArgs) Handles BtnRefCom.Click
        viewCombine()
    End Sub

    Private Sub BtnPrintCom_Click(sender As Object, e As EventArgs) Handles BtnPrintCom.Click
        Cursor = Cursors.WaitCursor
        print_raw(GCCombine, "")
        Cursor = Cursors.Default
    End Sub

    Private Sub BtnCreateCom_Click(sender As Object, e As EventArgs) Handles BtnCreateCom.Click
        Cursor = Cursors.WaitCursor
        FormStockTakeCombine.ShowDialog()
        Cursor = Cursors.Default
    End Sub

    Private Sub GVCombine_DoubleClick(sender As Object, e As EventArgs) Handles GVCombine.DoubleClick
        If GVCombine.RowCount > 0 And GVCombine.FocusedRowHandle >= 0 Then
            FormStockTakeDet.action = "upd"
            FormStockTakeDet.id_st_trans = GVCombine.GetFocusedRowCellValue("id_st_trans").ToString
            FormStockTakeDet.ShowDialog()
        End If
    End Sub

    Private Sub BtnList_Click(sender As Object, e As EventArgs) Handles BtnList.Click
        Cursor = Cursors.WaitCursor
        FormStockTakeList.ShowDialog()
        Cursor = Cursors.Default
    End Sub

    Private Sub LEViewUser_EditValueChanged(sender As Object, e As EventArgs) Handles LEViewUser.EditValueChanged
        GCScan.DataSource = Nothing
    End Sub

    Private Sub ToolStripCancel_Click(sender As Object, e As EventArgs) Handles ToolStripCancel.Click
        FormConfirmation.ShowDialog()
    End Sub

    Private Sub GVScan_PopupMenuShowing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles GVScan.PopupMenuShowing
        If GVScan.GetFocusedRowCellValue("id_report_status").ToString = "6" Then
            ToolStripCancel.Visible = True
        Else
            ToolStripCancel.Visible = False
        End If
    End Sub

    Private Sub GVCombine_PopupMenuShowing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles GVCombine.PopupMenuShowing
        If GVCombine.GetFocusedRowCellValue("id_report_status").ToString = "6" Then
            ToolStripCancel.Visible = True
        Else
            ToolStripCancel.Visible = False
        End If
    End Sub

    Private Sub BtnExportStop_Click(sender As Object, e As EventArgs) Handles BtnExportStop.Click
        Dim confirm As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure you want to export to .sql file and stop scan?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If confirm = DialogResult.Yes Then
            makeSafeGV(GVScan)

            GVScan.ActiveFilterString = ""

            For i = 0 To GVScan.RowCount - 1
                If GVScan.IsValidRowHandle(i) Then
                    If Not GVScan.GetRowCellValue(i, "id_report_status").ToString = "5" Then
                        GVScan.SetRowCellValue(i, "is_select", "Yes")
                    End If
                End If
            Next

            'export
            GVScan.ActiveFilterString = "[is_select]='Yes' "

            If GVScan.RowCount > 0 Then
                FormMain.SplashScreenManager1.ShowWaitForm()
                Dim id_st_trans As String = ""
                For i As Integer = 0 To ((GVScan.RowCount - 1) - GetGroupRowCount(GVScan))
                    If GVScan.GetRowCellValue(i, "is_select").ToString = "Yes" Then
                        If i > 0 Then
                            id_st_trans += "OR "
                        End If
                        id_st_trans += "id_st_trans='" + GVScan.GetRowCellValue(i, "id_st_trans").ToString + "' "
                    End If
                Next

                'create table copy
                Dim query_copy_trans As String = "DROP TABLE IF EXISTS tb_st_trans_" + st_user_code + "; CREATE TABLE IF NOT EXISTS tb_st_trans_" + st_user_code + " SELECT * FROM tb_st_trans WHERE id_st_trans>0 AND (" + id_st_trans + "); 
                truncate table tb_st_trans_" + st_user_code + "; 
                INSERT tb_st_trans_" + st_user_code + " SELECT * FROM tb_st_trans WHERE id_st_trans>0 AND (" + id_st_trans + "); "
                execute_non_query(query_copy_trans, True, "", "", "", "")
                Dim query_copy_trans_det As String = "DROP TABLE IF EXISTS tb_st_trans_det_" + st_user_code + "; CREATE TABLE IF NOT EXISTS tb_st_trans_det_" + st_user_code + " SELECT * FROM tb_st_trans_det WHERE id_st_trans>0 AND (" + id_st_trans + "); 
                truncate table tb_st_trans_det_" + st_user_code + "; 
                INSERT tb_st_trans_det_" + st_user_code + " SELECT * FROM tb_st_trans_det WHERE id_st_trans>0 AND (" + id_st_trans + "); "
                execute_non_query(query_copy_trans_det, True, "", "", "", "")

                'connection string
                FormMain.SplashScreenManager1.SetWaitFormDescription("Check connection ...")
                Dim dbc_str As String() = Split(app_database, "_")
                Dim name_dir = dbc_str(1) + "_" + dbc_str(2) + "_" + st_user_code + "_" + header_number("3", "0")
                Dim constring As String = "server=" + app_host + ";user=" + app_username + ";pwd=" + app_password + ";database=" + app_database + ";allow zero datetime=yes;"
                Dim path_root As String = Application.StartupPath + "\download\scan\" + name_dir
                'create directory if not exist
                If Not IO.Directory.Exists(path_root) Then
                    System.IO.Directory.CreateDirectory(path_root)
                End If
                Dim fileName As String = name_dir + ".sql"
                Dim file As String = IO.Path.Combine(path_root, fileName)

                'disable scan
                FormMain.SplashScreenManager1.SetWaitFormDescription("Disable scan ...")
                execute_non_query("UPDATE tb_m_user SET is_stop_scan = 1 WHERE id_user = '" + id_user + "'", True, "", "", "", "")

                '-- scan data
                FormMain.SplashScreenManager1.SetWaitFormDescription("Backup scan data")
                Dim dic As New Dictionary(Of String, String)()
                dic.Add("tb_st_trans_" + st_user_code.ToLower, "SELECT * FROM tb_st_trans_" + st_user_code.ToLower)
                dic.Add("tb_st_trans_det_" + st_user_code.ToLower, "SELECT * FROM tb_st_trans_det_" + st_user_code.ToLower)

                'dump
                FormMain.SplashScreenManager1.SetWaitFormDescription("Creating dump")
                Using conn As New MySqlConnection(constring)
                    Using cmd As New MySqlCommand()
                        Using mb As New MySqlBackup(cmd)
                            cmd.Connection = conn
                            conn.Open()
                            mb.ExportInfo.AddCreateDatabase = False
                            mb.ExportInfo.ExportTableStructure = True
                            mb.ExportInfo.ExportRows = True
                            mb.ExportInfo.TablesToBeExportedDic = dic
                            mb.ExportInfo.ExportProcedures = False
                            mb.ExportInfo.ExportFunctions = False
                            mb.ExportInfo.ExportTriggers = False
                            mb.ExportInfo.ExportEvents = False
                            mb.ExportInfo.ExportViews = False
                            mb.ExportInfo.EnableEncryption = True
                            mb.ExportInfo.EncryptionPassword = "csmtafc"
                            mb.ExportToFile(file)
                        End Using
                    End Using
                End Using

                FormMain.SplashScreenManager1.CloseWaitForm()
                openFile("\" + name_dir)

                Close()
            Else
                stopCustom("No scan data selected.")
            End If

            GVScan.ActiveFilterString = ""
        End If
    End Sub

    Private Sub BtnCreateNewAllowRecordUniqueNotFound_Click(sender As Object, e As EventArgs) Handles BtnCreateNewAllowRecordUniqueNotFound.Click
        Cursor = Cursors.WaitCursor
        FormStockTakeNew.is_allow_record_unique_code = "1"
        FormStockTakeNew.ShowDialog()
        Cursor = Cursors.Default
    End Sub
End Class