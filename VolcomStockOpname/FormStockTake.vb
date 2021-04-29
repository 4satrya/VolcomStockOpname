Imports MySql.Data.MySqlClient
Public Class FormStockTake
    Public is_pre As String = "2"

    Private is_login_store As String = "2"

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        Cursor = Cursors.WaitCursor
        FormStockTakeNew.is_reject = "2"
        FormStockTakeNew.is_no_tag = "2"
        FormStockTakeNew.is_un_reg = "2"
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

            Dim is_notif_ia As String = execute_query("
                SELECT first_ia_notif
                FROM tb_st_opt
            ", 0, True, "", "", "", "")

            If Not is_notif_ia = "" Then
                BtnStopStockTake.Visible = True
            End If

            Dim is_stop_scan As String = execute_query("
                SELECT COUNT(*) AS total FROM tb_st_stop_scan_log
            ", 0, True, "", "", "", "")

            If Not is_stop_scan = "0" Then
                SBOpenFile.Visible = True
            End If
        End If

        'check login store
        Try
            is_login_store = execute_query("SELECT is_login_store FROM tb_opt", 0, False, app_host, app_username, app_password, "db_opt")
        Catch ex As Exception
            is_login_store = "2"
        End Try

        If is_login_store = "1" Then
            BtnNew.Visible = False

            GVScan.Columns("remark").Caption = "Lokasi"
            GVNoTag.Columns("remark").Caption = "Lokasi"
            GVUnReg.Columns("remark").Caption = "Lokasi"

            SBImportForCombine.Visible = True
            SBExportForCombine.Visible = True
        Else
            SBAddStore.Visible = False
            SBNoTagStore.Visible = False
            SBRejectStore.Visible = False
            SBUnreg.Visible = False

            XTPNoTag.PageVisible = False
            XTPUnReg.PageVisible = False

            SBImportForCombine.Visible = False
            SBExportForCombine.Visible = False
        End If

        If id_role_login = "1" Then
            XTPNoTag.PageVisible = True
            XTPUnReg.PageVisible = True
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
        If XTCProduct.SelectedTabPage.Name = "XTPScanList" Then
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
        ElseIf XTCProduct.SelectedTabPage.Name = "XTPNoTag" Then
            'user view
            Dim cond_user As String = ""
            If LEViewUser.EditValue.ToString = "1" Then
                cond_user = "AND st.no_tag_by='" + id_user + "' "
            End If

            Dim stake As New ClassStockTake()
            Dim query As String = stake.queryTransMainNT(cond_user, "2")
            Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
            GCNoTag.DataSource = data
            GVNoTag.FocusedRowHandle = 0
            noEditNT()
        ElseIf XTCProduct.SelectedTabPage.Name = "XTPUnReg" Then
            'user view
            Dim cond_user As String = ""
            If LEViewUser.EditValue.ToString = "1" Then
                cond_user = "AND st.un_reg_by='" + id_user + "' "
            End If

            Dim stake As New ClassStockTake()
            Dim query As String = stake.queryTransMainUN(cond_user, "2")
            Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
            GCUnReg.DataSource = data
            GVUnReg.FocusedRowHandle = 0
            noEditUN()
        End If
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

    Sub noEditNT()
        If GVNoTag.RowCount > 0 Then
            Dim alloc_cek As String = GVNoTag.GetFocusedRowCellValue("id_report_status").ToString
            If alloc_cek = "5" Then
                GVNoTag.Columns("is_select").OptionsColumn.AllowEdit = False
            Else
                GVNoTag.Columns("is_select").OptionsColumn.AllowEdit = True
            End If
        End If
    End Sub

    Sub noEditUN()
        If GVUnReg.RowCount > 0 Then
            Dim alloc_cek As String = GVUnReg.GetFocusedRowCellValue("id_report_status").ToString
            If alloc_cek = "5" Then
                GVUnReg.Columns("is_select").OptionsColumn.AllowEdit = False
            Else
                GVUnReg.Columns("is_select").OptionsColumn.AllowEdit = True
            End If
        End If
    End Sub

    Private Sub GVScan_DoubleClick(sender As Object, e As EventArgs) Handles GVScan.DoubleClick
        If GVScan.RowCount > 0 And GVScan.FocusedRowHandle >= 0 Then
            If is_login_store = "1" Then
                FormStockTakeDet.is_reject = GVScan.GetFocusedRowCellValue("is_reject").ToString
                FormStockTakeDet.is_no_edit = "1"
            End If

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
                            mb.ExportInfo.AddCreateDatabase = True
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

        Dim open_folder As ProcessStartInfo = New ProcessStartInfo()
        open_folder.WindowStyle = ProcessWindowStyle.Maximized
        open_folder.FileName = "explorer.exe"
        open_folder.Arguments = path_root
        Process.Start(open_folder)
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
                Dim qv As String = "SELECT * FROM tb_st_trans_" + code_user_restore + " WHERE CONCAT(st_trans_number, '-', app_id) NOT IN (SELECT CONCAT(st_trans_number, '-', app_id) FROM tb_st_trans)"
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
                'no tag
                Dim table_no_tag As DataTable = execute_query("SHOW TABLES LIKE 'tb_st_no_tag_" + code_user_restore + "';", -1, True, "", "", "", "")
                If table_no_tag.Rows.Count > 0 Then
                    Dim qn As String = "SELECT * FROM tb_st_no_tag_" + code_user_restore + " WHERE no_tag_number NOT IN (SELECT no_tag_number FROM tb_st_no_tag)"
                    Dim dn As DataTable = execute_query(qn, -1, True, "", "", "", "")
                    Dim kn As Integer = dn.Rows.Count
                    For k As Integer = 0 To dn.Rows.Count - 1
                        FormMain.SplashScreenManager1.SetWaitFormDescription("Copying data no tag " + (k + 1).ToString + " of " + kn.ToString + " ...")
                        Dim query_ins As String = "INSERT INTO tb_st_no_tag(id_wh_drawer, no_tag_number, remark, no_tag_date, no_tag_by, no_tag_updated_date, no_tag_updated_by, id_report_status) 
                        SELECT id_wh_drawer, no_tag_number, remark, no_tag_date, no_tag_by, no_tag_updated_date, no_tag_updated_by, id_report_status FROM tb_st_no_tag_" + code_user_restore.ToLower + " WHERE id_st_no_tag=" + dn.Rows(k)("id_st_no_tag").ToString + "; SELECT LAST_INSERT_ID(); "
                        Dim id_st_new As String = execute_query(query_ins, 0, True, "", "", "", "")
                        Dim query_ins_det As String = "INSERT INTO tb_st_no_tag_det(id_st_no_tag, code, name, size, note) 
                        SELECT '" + id_st_new + "', code, name, size, note FROM tb_st_no_tag_det_" + code_user_restore.ToLower + " WHERE id_st_no_tag=" + dn.Rows(k)("id_st_no_tag").ToString + ";"
                        execute_non_query(query_ins_det, True, "", "", "", "")
                    Next
                End If
                'un reg
                Dim table_un_reg As DataTable = execute_query("SHOW TABLES LIKE 'tb_st_un_reg_" + code_user_restore + "';", -1, True, "", "", "", "")
                If table_un_reg.Rows.Count > 0 Then
                    Dim qn As String = "SELECT * FROM tb_st_un_reg_" + code_user_restore + " WHERE un_reg_number NOT IN (SELECT un_reg_number FROM tb_st_un_reg)"
                    Dim dn As DataTable = execute_query(qn, -1, True, "", "", "", "")
                    Dim kn As Integer = dn.Rows.Count
                    For k As Integer = 0 To dn.Rows.Count - 1
                        FormMain.SplashScreenManager1.SetWaitFormDescription("Copying data un_reg " + (k + 1).ToString + " of " + kn.ToString + " ...")
                        Dim query_ins As String = "INSERT INTO tb_st_un_reg(id_wh_drawer, un_reg_number, remark, un_reg_date, un_reg_by, un_reg_updated_date, un_reg_updated_by, id_report_status) 
                        SELECT id_wh_drawer, un_reg_number, remark, un_reg_date, un_reg_by, un_reg_updated_date, un_reg_updated_by, id_report_status FROM tb_st_un_reg_" + code_user_restore.ToLower + " WHERE id_st_un_reg=" + dn.Rows(k)("id_st_un_reg").ToString + "; SELECT LAST_INSERT_ID(); "
                        Dim id_st_new As String = execute_query(query_ins, 0, True, "", "", "", "")
                        Dim query_ins_det As String = "INSERT INTO tb_st_un_reg_det(id_st_un_reg, code, name, size, note) 
                        SELECT '" + id_st_new + "', code, name, size, note FROM tb_st_un_reg_det_" + code_user_restore.ToLower + " WHERE id_st_un_reg=" + dn.Rows(k)("id_st_un_reg").ToString + ";"
                        execute_non_query(query_ins_det, True, "", "", "", "")
                    Next
                End If
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
        Dim cek As String = CheckEdit1.EditValue.ToString
        If GVScan.RowCount > 0 Then
            For i As Integer = 0 To ((GVScan.RowCount - 1) - GetGroupRowCount(GVScan))
                Dim id_report_status As String = GVScan.GetRowCellValue(i, "id_report_status").ToString
                If cek And id_report_status <> "5" Then
                    GVScan.SetRowCellValue(i, "is_select", "Yes")
                Else
                    GVScan.SetRowCellValue(i, "is_select", "No")
                End If
            Next
        End If
        If GVNoTag.RowCount > 0 Then
            For i As Integer = 0 To ((GVNoTag.RowCount - 1) - GetGroupRowCount(GVNoTag))
                Dim id_report_status As String = GVNoTag.GetRowCellValue(i, "id_report_status").ToString
                If cek And id_report_status <> "5" Then
                    GVNoTag.SetRowCellValue(i, "is_select", "Yes")
                Else
                    GVNoTag.SetRowCellValue(i, "is_select", "No")
                End If
            Next
        End If
        If GVUnReg.RowCount > 0 Then
            For i As Integer = 0 To ((GVUnReg.RowCount - 1) - GetGroupRowCount(GVUnReg))
                Dim id_report_status As String = GVUnReg.GetRowCellValue(i, "id_report_status").ToString
                If cek And id_report_status <> "5" Then
                    GVUnReg.SetRowCellValue(i, "is_select", "Yes")
                Else
                    GVUnReg.SetRowCellValue(i, "is_select", "No")
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
        If XTCProduct.SelectedTabPage.Name = "XTPScanList" Then
            print_raw(GCScan, "")
        ElseIf XTCProduct.SelectedTabPage.Name = "XTPNoTag" Then
            print_raw(GCNoTag, "")
        ElseIf XTCProduct.SelectedTabPage.Name = "XTPUnReg" Then
            print_raw(GCUnReg, "")
        End If
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
        If XTCProduct.SelectedTabPage.Name = "XTPScanList" Then
            FormStockTakeList.ShowDialog()
        ElseIf XTCProduct.SelectedTabPage.Name = "XTPNoTag" Then
            FormStockTakeListNoTag.ShowDialog()
        ElseIf XTCProduct.SelectedTabPage.Name = "XTPUnReg" Then
            FormStockTakeListUnReg.ShowDialog()
        End If
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
        'If check_ia_notif() Then
        Dim data_continue As DataTable = execute_query("
            SELECT *
            FROM (
                SELECT COUNT(*) AS total_stop
            FROM tb_st_stop_scan_log
            ) AS total_stop, (
                SELECT first_ia_notif FROM tb_st_opt LIMIT 1
            ) AS first_ia_notif
        ", -1, True, "", "", "", "")

        'If (data_continue.Rows(0)("total_stop").ToString = "0") Or (Not data_continue.Rows(0)("total_stop").ToString = "0" And Not data_continue.Rows(0)("first_ia_notif").ToString = "") Then
        '    export_store()
        'End If

        export_store()

        If Not data_continue.Rows(0)("total_stop").ToString = "0" And Not data_continue.Rows(0)("first_ia_notif").ToString = "" Then
            BtnStopStockTake.Visible = True
        End If

        Dim is_stop_scan As String = execute_query("
                SELECT COUNT(*) AS total FROM tb_st_stop_scan_log
            ", 0, True, "", "", "", "")

        If Not is_stop_scan = "0" Then
            SBOpenFile.Visible = True
        End If
        'Else
        'stopCustom("Cannot export, because scan time's up.")
        'End If
    End Sub

    Private Sub BtnStopStockTake_Click(sender As Object, e As EventArgs) Handles BtnStopStockTake.Click
        Dim confirm As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("Apakah anda yakin akan selesai stock take?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)

        If confirm = DialogResult.Yes Then
            execute_non_query("
                UPDATE tb_st_opt SET is_active_db = '2'
            ", True, "", "", "", "")

            End
        End If
    End Sub

    Sub export_store()
        Dim confirm As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("Apakah anda yakin akan selesai scan?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If confirm = DialogResult.Yes Then
            'reload gv
            LEViewUser.EditValue = "2"

            XTCProduct.SelectedTabPage = XTPScanList

            viewScan()

            XTCProduct.SelectedTabPage = XTPNoTag

            viewScan()

            XTCProduct.SelectedTabPage = XTPUnReg

            viewScan()

            'filter
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

            'filter no tag
            makeSafeGV(GVNoTag)

            GVNoTag.ActiveFilterString = ""

            For i = 0 To GVNoTag.RowCount - 1
                If GVNoTag.IsValidRowHandle(i) Then
                    If Not GVNoTag.GetRowCellValue(i, "id_report_status").ToString = "5" Then
                        GVNoTag.SetRowCellValue(i, "is_select", "Yes")
                    End If
                End If
            Next

            'export no tag
            GVNoTag.ActiveFilterString = "[is_select]='Yes' "

            'filter un reg
            makeSafeGV(GVUnReg)

            GVUnReg.ActiveFilterString = ""

            For i = 0 To GVUnReg.RowCount - 1
                If GVUnReg.IsValidRowHandle(i) Then
                    If Not GVUnReg.GetRowCellValue(i, "id_report_status").ToString = "5" Then
                        GVUnReg.SetRowCellValue(i, "is_select", "Yes")
                    End If
                End If
            Next

            'export no tag
            GVUnReg.ActiveFilterString = "[is_select]='Yes' "

            If GVScan.RowCount > 0 Or GVNoTag.RowCount > 0 Or GVUnReg.RowCount > 0 Then
                Try
                    FormMain.SplashScreenManager1.ShowWaitForm()
                    '
                    Dim id_st_trans As String = ""
                    For i As Integer = 0 To ((GVScan.RowCount - 1) - GetGroupRowCount(GVScan))
                        If GVScan.GetRowCellValue(i, "is_select").ToString = "Yes" Then
                            If i > 0 Then
                                id_st_trans += "OR "
                            End If
                            id_st_trans += "id_st_trans='" + GVScan.GetRowCellValue(i, "id_st_trans").ToString + "' "
                        End If
                    Next
                    If id_st_trans = "" Then
                        id_st_trans = "id_st_trans='' "
                    End If

                    '
                    Dim id_st_no_tag As String = ""
                    For i As Integer = 0 To ((GVNoTag.RowCount - 1) - GetGroupRowCount(GVNoTag))
                        If GVNoTag.GetRowCellValue(i, "is_select").ToString = "Yes" Then
                            If i > 0 Then
                                id_st_no_tag += "OR "
                            End If
                            id_st_no_tag += "id_st_no_tag='" + GVNoTag.GetRowCellValue(i, "id_st_no_tag").ToString + "' "
                        End If
                    Next
                    If id_st_no_tag = "" Then
                        id_st_no_tag = "id_st_no_tag='' "
                    End If

                    '
                    Dim id_st_un_reg As String = ""
                    For i As Integer = 0 To ((GVUnReg.RowCount - 1) - GetGroupRowCount(GVUnReg))
                        If GVUnReg.GetRowCellValue(i, "is_select").ToString = "Yes" Then
                            If i > 0 Then
                                id_st_un_reg += "OR "
                            End If
                            id_st_un_reg += "id_st_un_reg='" + GVUnReg.GetRowCellValue(i, "id_st_un_reg").ToString + "' "
                        End If
                    Next
                    If id_st_un_reg = "" Then
                        id_st_un_reg = "id_st_un_reg='' "
                    End If

                    'create table copy
                    Dim query_copy_trans As String = "DROP TABLE IF EXISTS tb_st_trans_" + st_user_code + "; CREATE TABLE IF NOT EXISTS tb_st_trans_" + st_user_code + " SELECT * FROM tb_st_trans WHERE id_st_trans>0 AND (" + id_st_trans + "); 
                truncate table tb_st_trans_" + st_user_code + "; 
                INSERT tb_st_trans_" + st_user_code + " SELECT * FROM tb_st_trans WHERE id_st_trans>0 AND (" + id_st_trans + "); "
                    execute_non_query(query_copy_trans, True, "", "", "", "")
                    Dim query_copy_trans_det As String = "DROP TABLE IF EXISTS tb_st_trans_det_" + st_user_code + "; CREATE TABLE IF NOT EXISTS tb_st_trans_det_" + st_user_code + " SELECT * FROM tb_st_trans_det WHERE id_st_trans>0 AND (" + id_st_trans + "); 
            truncate table tb_st_trans_det_" + st_user_code + "; 
            INSERT tb_st_trans_det_" + st_user_code + " SELECT * FROM tb_st_trans_det WHERE id_st_trans>0 AND (" + id_st_trans + "); "
                    execute_non_query(query_copy_trans_det, True, "", "", "", "")

                    'create table copy no tag
                    Dim query_copy_trans_nt As String = "DROP TABLE IF EXISTS tb_st_no_tag_" + st_user_code + "; CREATE TABLE IF NOT EXISTS tb_st_no_tag_" + st_user_code + " SELECT * FROM tb_st_no_tag WHERE id_st_no_tag>0 AND (" + id_st_no_tag + "); 
                truncate table tb_st_no_tag_" + st_user_code + "; 
                INSERT tb_st_no_tag_" + st_user_code + " SELECT * FROM tb_st_no_tag WHERE id_st_no_tag>0 AND (" + id_st_no_tag + "); "
                    execute_non_query(query_copy_trans_nt, True, "", "", "", "")
                    Dim query_copy_trans_det_nt As String = "DROP TABLE IF EXISTS tb_st_no_tag_det_" + st_user_code + "; CREATE TABLE IF NOT EXISTS tb_st_no_tag_det_" + st_user_code + " SELECT * FROM tb_st_no_tag_det WHERE id_st_no_tag>0 AND (" + id_st_no_tag + "); 
            truncate table tb_st_no_tag_det_" + st_user_code + "; 
            INSERT tb_st_no_tag_det_" + st_user_code + " SELECT * FROM tb_st_no_tag_det WHERE id_st_no_tag>0 AND (" + id_st_no_tag + "); "
                    execute_non_query(query_copy_trans_det_nt, True, "", "", "", "")

                    'create table copy un reg
                    Dim query_copy_trans_un As String = "DROP TABLE IF EXISTS tb_st_un_reg_" + st_user_code + "; CREATE TABLE IF NOT EXISTS tb_st_un_reg_" + st_user_code + " SELECT * FROM tb_st_un_reg WHERE id_st_un_reg>0 AND (" + id_st_un_reg + "); 
                truncate table tb_st_un_reg_" + st_user_code + "; 
                INSERT tb_st_un_reg_" + st_user_code + " SELECT * FROM tb_st_un_reg WHERE id_st_un_reg>0 AND (" + id_st_un_reg + "); "
                    execute_non_query(query_copy_trans_un, True, "", "", "", "")
                    Dim query_copy_trans_det_un As String = "DROP TABLE IF EXISTS tb_st_un_reg_det_" + st_user_code + "; CREATE TABLE IF NOT EXISTS tb_st_un_reg_det_" + st_user_code + " SELECT * FROM tb_st_un_reg_det WHERE id_st_un_reg>0 AND (" + id_st_un_reg + "); 
            truncate table tb_st_un_reg_det_" + st_user_code + "; 
            INSERT tb_st_un_reg_det_" + st_user_code + " SELECT * FROM tb_st_un_reg_det WHERE id_st_un_reg>0 AND (" + id_st_un_reg + "); "
                    execute_non_query(query_copy_trans_det_un, True, "", "", "", "")

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
                    dic.Add("tb_st_no_tag_" + st_user_code.ToLower, "SELECT * FROM tb_st_no_tag_" + st_user_code.ToLower)
                    dic.Add("tb_st_no_tag_det_" + st_user_code.ToLower, "SELECT * FROM tb_st_no_tag_det_" + st_user_code.ToLower)
                    dic.Add("tb_st_un_reg_" + st_user_code.ToLower, "SELECT * FROM tb_st_un_reg_" + st_user_code.ToLower)
                    dic.Add("tb_st_un_reg_det_" + st_user_code.ToLower, "SELECT * FROM tb_st_un_reg_det_" + st_user_code.ToLower)

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

                    'create readme
                    Dim path_readme As String = IO.Path.Combine(path_root, "BACA SAYA.txt")

                    Dim fs_readme As IO.FileStream = IO.File.Create(path_readme)

                    Dim readme_txt As String = "Mohon file " + fileName + " dikirimkan ke Internal Audit Volcom Indonesia dengan cara sebagai berikut:

1. Buka program email di komputer Anda
2. Lampirkan file tersebut di atas : """ + fileName + """ dengan cara ""di-Select attahcment"" atau ""di-copy lalu paste""
3. Setelah file tersebut terlampir di program email Anda, kirimkan ke alamat email agung@volcom.co.id
4. Check sent item dan konfirmasikan telah diterima oleh Internal Audit Volcom Indonesia"

                    Dim info_readme As Byte() = New System.Text.UTF8Encoding(True).GetBytes(readme_txt)

                    fs_readme.Write(info_readme, 0, info_readme.Length)

                    fs_readme.Close()

                    'store log
                    FormMain.SplashScreenManager1.SetWaitFormDescription("Save log")
                    execute_non_query("
                        INSERT INTO tb_st_stop_scan_log (created_by, created_date) VALUES ('" + id_user + "', NOW())
                    ", True, "", "", "", "")

                    FormMain.SplashScreenManager1.CloseWaitForm()
                    openFile("\" + name_dir)

                    infoCustom("Export completed.")
                Catch ex As Exception
                    stopCustom(ex.ToString)
                End Try
            Else
                stopCustom("No scan data selected.")
            End If

            GVScan.ActiveFilterString = ""
            GVNoTag.ActiveFilterString = ""
        End If
    End Sub

    Private Sub BtnCreateNewAllowRecordUniqueNotFound_Click(sender As Object, e As EventArgs)
        Cursor = Cursors.WaitCursor
        XTCProduct.SelectedTabPage = XTPScanList
        FormStockTakeNew.is_allow_record_unique_code = "1"
        FormStockTakeNew.ShowDialog()
        Cursor = Cursors.Default
    End Sub

    Private Sub SBAddStore_Click(sender As Object, e As EventArgs) Handles SBAddStore.Click
        Cursor = Cursors.WaitCursor
        If check_ia_notif() Then
            Dim data_continue As DataTable = execute_query("
                SELECT *
                FROM (
                    SELECT COUNT(*) AS total_stop
                FROM tb_st_stop_scan_log
                ) AS total_stop, (
                    SELECT first_ia_notif FROM tb_st_opt LIMIT 1
                ) AS first_ia_notif
            ", -1, True, "", "", "", "")

            If (data_continue.Rows(0)("total_stop").ToString = "0") Or (Not data_continue.Rows(0)("total_stop").ToString = "0" And Not data_continue.Rows(0)("first_ia_notif").ToString = "") Then
                XTCProduct.SelectedTabPage = XTPScanList
                FormStockTakeNew.is_no_tag = "2"
                FormStockTakeNew.is_reject = "2"
                FormStockTakeNew.is_un_reg = "2"
                FormStockTakeNew.ShowDialog()
            End If

            If Not data_continue.Rows(0)("total_stop").ToString = "0" And Not data_continue.Rows(0)("first_ia_notif").ToString = "" Then
                BtnStopStockTake.Visible = True
            End If
        Else
            stopCustom("Cannot create, because scan time's up.")
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub SBNoTagStore_Click(sender As Object, e As EventArgs) Handles SBNoTagStore.Click
        Cursor = Cursors.WaitCursor
        If check_ia_notif() Then
            Dim data_continue As DataTable = execute_query("
                SELECT *
                FROM (
                    SELECT COUNT(*) AS total_stop
                FROM tb_st_stop_scan_log
                ) AS total_stop, (
                    SELECT first_ia_notif FROM tb_st_opt LIMIT 1
                ) AS first_ia_notif
            ", -1, True, "", "", "", "")

            If (data_continue.Rows(0)("total_stop").ToString = "0") Or (Not data_continue.Rows(0)("total_stop").ToString = "0" And Not data_continue.Rows(0)("first_ia_notif").ToString = "") Then
                XTCProduct.SelectedTabPage = XTPNoTag
                FormStockTakeNew.is_no_tag = "1"
                FormStockTakeNew.is_reject = "2"
                FormStockTakeNew.is_un_reg = "2"
                FormStockTakeNew.ShowDialog()
            End If

            If Not data_continue.Rows(0)("total_stop").ToString = "0" And Not data_continue.Rows(0)("first_ia_notif").ToString = "" Then
                BtnStopStockTake.Visible = True
            End If
        Else
            stopCustom("Cannot create, because scan time's up.")
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub SBRejectStore_Click(sender As Object, e As EventArgs) Handles SBRejectStore.Click
        Cursor = Cursors.WaitCursor
        If check_ia_notif() Then
            Dim data_continue As DataTable = execute_query("
                SELECT *
                FROM (
                    SELECT COUNT(*) AS total_stop
                FROM tb_st_stop_scan_log
                ) AS total_stop, (
                    SELECT first_ia_notif FROM tb_st_opt LIMIT 1
                ) AS first_ia_notif
            ", -1, True, "", "", "", "")

            If (data_continue.Rows(0)("total_stop").ToString = "0") Or (Not data_continue.Rows(0)("total_stop").ToString = "0" And Not data_continue.Rows(0)("first_ia_notif").ToString = "") Then
                XTCProduct.SelectedTabPage = XTPScanList
                FormStockTakeNew.is_no_tag = "2"
                FormStockTakeNew.is_reject = "1"
                FormStockTakeNew.is_un_reg = "2"
                FormStockTakeNew.ShowDialog()
            End If

            If Not data_continue.Rows(0)("total_stop").ToString = "0" And Not data_continue.Rows(0)("first_ia_notif").ToString = "" Then
                BtnStopStockTake.Visible = True
            End If
        Else
            stopCustom("Cannot create, because scan time's up.")
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub GVNoTag_DoubleClick(sender As Object, e As EventArgs) Handles GVNoTag.DoubleClick
        If GVNoTag.RowCount > 0 And GVNoTag.FocusedRowHandle >= 0 Then
            FormStockTakeNoTag.id_st_no_tag = GVNoTag.GetFocusedRowCellValue("id_st_no_tag").ToString

            If is_login_store = "1" Then
                FormStockTakeNoTag.is_no_edit = "1"
            End If

            FormStockTakeNoTag.ShowDialog()
        End If
    End Sub

    Private Sub GVUnReg_DoubleClick(sender As Object, e As EventArgs) Handles GVUnReg.DoubleClick
        If GVUnReg.RowCount > 0 And GVUnReg.FocusedRowHandle >= 0 Then
            FormStockTakeUnReg.id_st_un_reg = GVUnReg.GetFocusedRowCellValue("id_st_un_reg").ToString

            If is_login_store = "1" Then
                FormStockTakeUnReg.is_no_edit = "1"
            End If

            FormStockTakeUnReg.ShowDialog()
        End If
    End Sub

    Private Sub GVScan_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GVScan.RowCellStyle
        If is_login_store = "1" Then
            If GVScan.GetRowCellValue(e.RowHandle, "is_reject").ToString = "1" Then
                e.Appearance.BackColor = Color.LightYellow
            ElseIf GVScan.GetRowCellValue(e.RowHandle, "is_reject").ToString = "2" Then
                e.Appearance.BackColor = Color.LightGreen
            End If
        End If
    End Sub

    Private Sub XTCProduct_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XTCProduct.SelectedPageChanged
        viewScan()
    End Sub

    Private Sub GVNoTag_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GVNoTag.RowCellStyle
        If is_login_store = "1" Then
            If Not GVNoTag.GetRowCellValue(e.RowHandle, "qty").ToString = "0" Then
                e.Appearance.BackColor = Color.LightBlue
            End If
        End If
    End Sub

    Private Sub GVNoTag_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GVNoTag.FocusedRowChanged
        noEditNT()
    End Sub

    Private Sub GVUnReg_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GVUnReg.RowCellStyle
        If is_login_store = "1" Then
            If Not GVUnReg.GetRowCellValue(e.RowHandle, "qty").ToString = "0" Then
                e.Appearance.BackColor = Color.LightPink
            End If
        End If
    End Sub

    Private Sub GVUnReg_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GVUnReg.FocusedRowChanged
        noEditUN()
    End Sub

    Function check_ia_notif() As String
        Dim out As Boolean = True

        Dim query As String = "
            SELECT *
            FROM (
	            SELECT first_ia_notif
	            FROM tb_st_opt
            ) AS first_ia_notif, (
	            SELECT COUNT(*) AS total_stop
	            FROM tb_st_stop_scan_log
            ) AS total_stop, (
                SELECT IF(st_scan_time >= TIMESTAMPDIFF(MINUTE, IFNULL(first_ia_notif, NOW()), NOW()), 2, 1) AS is_stop
                FROM tb_st_opt
            ) is_stop, (
                SELECT IFNULL((
                    SELECT IF(TIMESTAMPDIFF(MONTH, created_date, NOW()) > 0, 1, 2)
                    FROM tb_st_stop_scan_log
                    ORDER BY created_date ASC
                    LIMIT 1
                ), 2) AS is_one_month
            ) is_one_month
        "

        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")

        'input first ia notif date
        If Not data.Rows(0)("total_stop").ToString = "0" And data.Rows(0)("first_ia_notif").ToString = "" Then
            FormInputDateNotif.ShowDialog()

            data = execute_query(query, -1, True, "", "", "", "")
        End If

        If data.Rows(0)("is_stop").ToString = "1" Then
            out = False
        End If

        If data.Rows(0)("is_one_month").ToString = "1" Then
            out = False
        End If

        Return out
    End Function

    Private Sub SBOpenFile_Click(sender As Object, e As EventArgs) Handles SBOpenFile.Click
        Dim dbc_str As String() = Split(app_database, "_")
        Dim header_number_x As String = combine_header_number("", Integer.Parse(get_setup_field("file_inc")) - 1, 0)
        Dim name_dir = dbc_str(1) + "_" + dbc_str(2) + "_" + st_user_code + "_" + header_number_x

        openFile("\" + name_dir)
    End Sub

    Private Sub BtnCombineAllScan_Click(sender As Object, e As EventArgs) Handles BtnCombineAllScan.Click
        Dim confirm As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure you want to combine all scan?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)

        If confirm = DialogResult.Yes Then
            Dim id_combine_in As String = execute_query("SELECT IFNULL(GROUP_CONCAT(DISTINCT s.id_st_trans),0) AS `id_combine_in` 
            FROM tb_st_trans s WHERE s.is_combine=1 AND s.id_report_status!=5 ", 0, True, "", "", "", "")
            If id_combine_in <> "0" Then
                Dim qry As String = "UPDATE tb_st_trans SET id_report_status ='5', st_trans_updated_by=" + id_user + ", acknowledge_by=" + id_user + ", approved_by='" + id_user + "', report_status_note='replace with new combine' WHERE id_st_trans IN (" + id_combine_in + "); 
                UPDATE tb_st_trans SET id_combine=NULL WHERE id_combine IN(" + id_combine_in + "); "
                execute_non_query(qry, True, "", "", "", "")
            End If
            FormStockTakeCombine.is_combine_all = True
            FormStockTakeCombine.ShowDialog()
        End If
    End Sub

    Private Sub SBUnreg_Click(sender As Object, e As EventArgs) Handles SBUnreg.Click
        Cursor = Cursors.WaitCursor
        If check_ia_notif() Then
            Dim data_continue As DataTable = execute_query("
                SELECT *
                FROM (
                    SELECT COUNT(*) AS total_stop
                FROM tb_st_stop_scan_log
                ) AS total_stop, (
                    SELECT first_ia_notif FROM tb_st_opt LIMIT 1
                ) AS first_ia_notif
            ", -1, True, "", "", "", "")

            If (data_continue.Rows(0)("total_stop").ToString = "0") Or (Not data_continue.Rows(0)("total_stop").ToString = "0" And Not data_continue.Rows(0)("first_ia_notif").ToString = "") Then
                XTCProduct.SelectedTabPage = XTPUnReg
                FormStockTakeNew.is_no_tag = "2"
                FormStockTakeNew.is_reject = "2"
                FormStockTakeNew.is_un_reg = "1"
                FormStockTakeNew.ShowDialog()
            End If

            If Not data_continue.Rows(0)("total_stop").ToString = "0" And Not data_continue.Rows(0)("first_ia_notif").ToString = "" Then
                BtnStopStockTake.Visible = True
            End If
        Else
            stopCustom("Cannot create, because scan time's up.")
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub FormStockTake_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()

        If is_login_store = "1" Then
            Dim connection_string As String = String.Format("Data Source={0};User Id={1};Password={2};Convert Zero Datetime=True", app_host, app_username, app_password)

            Dim connection As New MySql.Data.MySqlClient.MySqlConnection(connection_string)
            connection.Open()
            Dim data As New DataTable
            Dim adapter As New MySql.Data.MySqlClient.MySqlDataAdapter("SHOW DATABASES", connection)
            adapter.Fill(data)
            adapter.Dispose()
            data.Dispose()
            connection.Close()
            connection.Dispose()

            data.Columns.Add("is_active", GetType(String))

            For i = 0 To data.Rows.Count - 1
                data.Rows(i)("is_active") = 2

                Try
                    data.Rows(i)("is_active") = execute_query("SELECT is_active_db FROM tb_st_opt LIMIT 1", 0, False, app_host, app_username, app_password, data.Rows(i)("Database").ToString)

                    'check scan time
                    If data.Rows(i)("is_active").ToString = "1" Then
                        Dim is_stop As String = execute_query("
                            SELECT IF(TIMESTAMPDIFF(MONTH, created_date, NOW()) > 0, 1, 2) AS is_stop
                            FROM tb_st_stop_scan_log
                            ORDER BY created_date ASC
                            LIMIT 1
                        ", 0, False, app_host, app_username, app_password, data.Rows(i)("Database").ToString)

                        If is_stop = "1" Then
                            execute_non_query("UPDATE tb_st_opt SET is_active_db = 2", False, app_host, app_username, app_password, data.Rows(i)("Database").ToString)

                            data.Rows(i)("is_active") = 2
                        End If
                    End If
                Catch ex As Exception
                End Try
            Next

            Dim total_active As Integer = 0

            For i = 0 To data.Rows.Count - 1
                If data.Rows(i)("is_active").ToString = "1" Then
                    total_active = total_active + 1
                End If
            Next

            If total_active > 1 Then
                FormDatabaseStore.is_from_close = "1"
                FormDatabaseStore.ShowDialog()
            End If
        End If
    End Sub

    Private Sub SBImportForCombine_Click(sender As Object, e As EventArgs) Handles SBImportForCombine.Click
        Dim url_import As String = ""

        Dim fdlg As OpenFileDialog = New OpenFileDialog()

        fdlg.Title = "Select sql file To import"
        fdlg.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        fdlg.Filter = "SQL File | *.sql;"
        fdlg.FilterIndex = 0
        fdlg.RestoreDirectory = True

        If fdlg.ShowDialog() = DialogResult.OK Then
            Try
                FormMain.SplashScreenManager1.ShowWaitForm()

                url_import = fdlg.FileName.ToString

                Dim file_read As String = My.Computer.FileSystem.ReadAllText(url_import)

                Dim b As Byte() = Convert.FromBase64String(file_read)

                file_read = System.Text.Encoding.UTF8.GetString(b)

                Dim data_read As IO.StringReader = New IO.StringReader(file_read)

                Dim xml_data As DataSet = New DataSet

                xml_data.ReadXml(data_read)

                Dim data_report As DataTable = New DataTable

                data_report.Columns.Add("st_trans_number", GetType(String))
                data_report.Columns.Add("remark", GetType(String))
                data_report.Columns.Add("code", GetType(String))
                data_report.Columns.Add("name", GetType(String))
                data_report.Columns.Add("size", GetType(String))
                data_report.Columns.Add("id_design_price", GetType(String))
                data_report.Columns.Add("is_reject", GetType(String))
                data_report.Columns.Add("design_price", GetType(String))
                data_report.Columns.Add("status", GetType(String))

                Dim table_db As DataTable = xml_data.Tables("db")
                Dim table_header As DataTable = xml_data.Tables("tb_st_trans")
                Dim table_detail As DataTable = xml_data.Tables("tb_st_trans_det")

                If table_db.Rows(0)("name").ToString = app_database Then
                    Dim list_detail_duplicate As List(Of String) = New List(Of String)

                    Dim already_header_data As DataTable = execute_query("SELECT st_trans_number FROM tb_st_trans", -1, True, "", "", "", "")
                    Dim already_detail_data As DataTable = execute_query("SELECT id_st_trans_det, id_st_trans_det_ref, id_st_trans, is_ok, is_no_stock, is_no_master, is_sale, is_reject, is_unique_not_found, is_no_tag, id_product, code, name, size, qty, id_design_price, design_price, note FROM tb_st_trans_det", -1, True, "", "", "", "")

                    For i = 0 To table_detail.Rows.Count - 1
                        For j = 0 To already_detail_data.Rows.Count - 1
                            If table_detail.Rows(i)("code").ToString.Length = 16 Then
                                If table_detail.Rows(i)("code").ToString = already_detail_data.Rows(j)("code").ToString Then
                                    list_detail_duplicate.Add(table_detail.Rows(i)("code").ToString)
                                End If
                            End If
                        Next
                    Next

                    'insert
                    For i = 0 To table_header.Rows.Count - 1
                        If Not table_header.Rows(i)("app_id").ToString = app_id Then
                            Dim id_wh_drawer As String = table_header.Rows(i)("id_wh_drawer").ToString
                            Dim st_trans_number As String = table_header.Rows(i)("st_trans_number").ToString
                            Dim remark As String = table_header.Rows(i)("remark").ToString
                            Dim st_trans_date As String = Date.Parse(table_header.Rows(i)("st_trans_date").ToString).ToString("yyyy-MM-dd HH:mm:ss")
                            Dim st_trans_by As String = table_header.Rows(i)("st_trans_by").ToString
                            Dim st_trans_updated As String = Date.Parse(table_header.Rows(i)("st_trans_updated").ToString).ToString("yyyy-MM-dd HH:mm:ss")
                            Dim st_trans_updated_by As String = table_header.Rows(i)("st_trans_updated_by").ToString
                            Dim is_combine As String = table_header.Rows(i)("is_combine").ToString
                            Dim id_report_status As String = table_header.Rows(i)("id_report_status").ToString
                            Dim report_status_note As String = If(table_header.Rows(i)("report_status_note").ToString = "", "NULL", "'" + table_header.Rows(i)("report_status_note").ToString + "'")
                            Dim id_combine As String = If(table_header.Rows(i)("id_combine").ToString = "", "NULL", "'" + table_header.Rows(i)("id_combine").ToString + "'")
                            Dim acknowledge_by As String = If(table_header.Rows(i)("acknowledge_by").ToString = "", "NULL", "'" + table_header.Rows(i)("acknowledge_by").ToString + "'")
                            Dim approved_by As String = If(table_header.Rows(i)("approved_by").ToString = "", "NULL", "'" + table_header.Rows(i)("approved_by").ToString + "'")
                            Dim is_pre As String = table_header.Rows(i)("is_pre").ToString
                            Dim app_id_from As String = table_header.Rows(i)("app_id").ToString

                            Dim query As String = "INSERT INTO tb_st_trans (id_wh_drawer, st_trans_number, remark, st_trans_date, st_trans_by, st_trans_updated, st_trans_updated_by, is_combine, id_report_status, report_status_note, id_combine, acknowledge_by, approved_by, is_pre, app_id) VALUES ('" + id_wh_drawer + "', '" + st_trans_number + "', '" + remark + "', '" + st_trans_date + "', '" + st_trans_by + "', '" + st_trans_updated + "', '" + st_trans_updated_by + "', '" + is_combine + "', '" + id_report_status + "', " + report_status_note + ", " + id_combine + ", " + acknowledge_by + ", " + approved_by + ", '" + is_pre + "', '" + app_id_from + "'); SELECT LAST_INSERT_ID();"

                            Dim id_st_trans As String = execute_query(query, 0, True, "", "", "", "")

                            Dim inserted As Integer = 0

                            For j = 0 To table_detail.Rows.Count - 1
                                If table_header.Rows(i)("id_st_trans").ToString = table_detail.Rows(j)("id_st_trans").ToString Then
                                    If Not list_detail_duplicate.Contains(table_detail.Rows(j)("code").ToString) Then
                                        inserted += 1

                                        Dim id_st_trans_det_ref As String = table_detail.Rows(j)("id_st_trans_det_ref").ToString
                                        Dim is_ok As String = table_detail.Rows(j)("is_ok").ToString
                                        Dim is_no_stock As String = table_detail.Rows(j)("is_no_stock").ToString
                                        Dim is_no_master As String = table_detail.Rows(j)("is_no_master").ToString
                                        Dim is_sale As String = table_detail.Rows(j)("is_sale").ToString
                                        Dim is_reject As String = table_detail.Rows(j)("is_reject").ToString
                                        Dim is_unique_not_found As String = table_detail.Rows(j)("is_unique_not_found").ToString
                                        Dim is_no_tag As String = table_detail.Rows(j)("is_no_tag").ToString
                                        Dim id_product As String = table_detail.Rows(j)("id_product").ToString
                                        Dim code As String = table_detail.Rows(j)("code").ToString
                                        Dim name As String = table_detail.Rows(j)("name").ToString
                                        Dim size As String = table_detail.Rows(j)("size").ToString
                                        Dim qty As String = table_detail.Rows(j)("qty").ToString
                                        Dim id_design_price As String = table_detail.Rows(j)("id_design_price").ToString
                                        Dim design_price As String = table_detail.Rows(j)("design_price").ToString
                                        Dim note As String = table_detail.Rows(j)("note").ToString

                                        execute_non_query("INSERT tb_st_trans_det (id_st_trans_det_ref, id_st_trans, is_ok, is_no_stock, is_no_master, is_sale, is_reject, is_unique_not_found, is_no_tag, id_product, code, name, size, qty, id_design_price, design_price, note) VALUES ('" + id_st_trans_det_ref + "', '" + id_st_trans + "', '" + is_ok + "', '" + is_no_stock + "', '" + is_no_master + "', '" + is_sale + "', '" + is_reject + "', '" + is_unique_not_found + "', '" + is_no_tag + "', '" + id_product + "', '" + code + "', '" + name + "', '" + size + "', '" + qty + "', '" + id_design_price + "', '" + design_price + "', '" + note + "')", True, "", "", "", "")
                                    Else
                                        'insert report
                                        data_report.Rows.Add(
                                            table_header.Rows(i)("st_trans_number").ToString,
                                            table_header.Rows(i)("remark").ToString,
                                            table_detail.Rows(j)("code").ToString,
                                            table_detail.Rows(j)("name").ToString,
                                            table_detail.Rows(j)("size").ToString,
                                            table_detail.Rows(j)("id_design_price").ToString,
                                            table_detail.Rows(j)("is_reject").ToString,
                                            table_detail.Rows(j)("design_price").ToString,
                                            "Code Already exist"
                                        )
                                    End If
                                End If
                            Next

                            'delete zero
                            If inserted = 0 Then
                                execute_non_query("DELETE FROM tb_st_trans WHERE id_st_trans = '" + id_st_trans + "'", True, "", "", "", "")
                            End If
                        Else
                            'insert report
                            For j = 0 To table_detail.Rows.Count - 1
                                If table_header.Rows(i)("id_st_trans").ToString = table_detail.Rows(j)("id_st_trans").ToString Then
                                    data_report.Rows.Add(
                                        table_header.Rows(i)("st_trans_number").ToString,
                                        table_header.Rows(i)("remark").ToString,
                                        table_detail.Rows(j)("code").ToString,
                                        table_detail.Rows(j)("name").ToString,
                                        table_detail.Rows(j)("size").ToString,
                                        table_detail.Rows(j)("id_design_price").ToString,
                                        table_detail.Rows(j)("is_reject").ToString,
                                        table_detail.Rows(j)("design_price").ToString,
                                        "Same application id"
                                    )
                                End If
                            Next
                        End If
                    Next

                    'insert report
                    For i = 0 To data_report.Rows.Count - 1
                        Dim query As String = "INSERT INTO tb_st_import_report (st_trans_number, remark, code, name, size, id_design_price, is_reject, design_price, `status`, created_at) VALUES ('" + data_report.Rows(i)("st_trans_number").ToString + "', '" + data_report.Rows(i)("remark").ToString + "', '" + data_report.Rows(i)("code").ToString + "', '" + data_report.Rows(i)("name").ToString + "', '" + data_report.Rows(i)("size").ToString + "', '" + data_report.Rows(i)("id_design_price").ToString + "', '" + data_report.Rows(i)("is_reject").ToString + "', '" + data_report.Rows(i)("design_price").ToString + "', '" + data_report.Rows(i)("status").ToString + "', NOW())"

                        execute_non_query(query, True, "", "", "", "")
                    Next

                    LEViewUser.EditValue = "2"

                    viewScan()

                    FormMain.SplashScreenManager1.CloseWaitForm()

                    infoCustom("File imported.")

                    If data_report.Rows.Count > 0 Then
                        warningCustom("Some data cannot imported.")

                        FormStockTakeList.XTCStockTake.SelectedTabPage = FormStockTakeList.XTPErrorImport

                        FormStockTakeList.ShowDialog()
                    End If
                Else
                    FormMain.SplashScreenManager1.CloseWaitForm()

                    stopCustom("File import not matched.")
                End If
            Catch ex As Exception
                FormMain.SplashScreenManager1.CloseWaitForm()

                stopCustom("Import error." + Environment.NewLine + ex.ToString)
            End Try
        End If
    End Sub

    Private Sub SBExportForCombine_Click(sender As Object, e As EventArgs) Handles SBExportForCombine.Click
        Dim exported As String = ""

        FormMain.SplashScreenManager1.ShowWaitForm()

        Dim query_head As String = "SELECT id_st_trans, id_wh_drawer, st_trans_number, remark, st_trans_date, st_trans_by, st_trans_updated, st_trans_updated_by, is_combine, id_report_status, report_status_note, id_combine, acknowledge_by, approved_by, is_pre, app_id FROM tb_st_trans"
        Dim data_head As DataTable = execute_query(query_head, -1, True, "", "", "", "")

        Dim query_detail As String = "SELECT id_st_trans_det, id_st_trans_det_ref, id_st_trans, is_ok, is_no_stock, is_no_master, is_sale, is_reject, is_unique_not_found, is_no_tag, id_product, code, name, size, qty, id_design_price, design_price, note FROM tb_st_trans_det"
        Dim data_detail As DataTable = execute_query(query_detail, -1, True, "", "", "", "")

        'header
        exported += "<?xml version=""1.0"" encoding=""UTF-8""?><root><db><name>" + app_database + "</name></db>"

        For i = 0 To data_head.Rows.Count - 1
            Dim id_st_trans As String = data_head.Rows(i)("id_st_trans").ToString
            Dim id_wh_drawer As String = data_head.Rows(i)("id_wh_drawer").ToString
            Dim st_trans_number As String = data_head.Rows(i)("st_trans_number").ToString
            Dim remark As String = data_head.Rows(i)("remark").ToString
            Dim st_trans_date As String = data_head.Rows(i)("st_trans_date").ToString
            Dim st_trans_by As String = data_head.Rows(i)("st_trans_by").ToString
            Dim st_trans_updated As String = data_head.Rows(i)("st_trans_updated").ToString
            Dim st_trans_updated_by As String = data_head.Rows(i)("st_trans_updated_by").ToString
            Dim is_combine As String = data_head.Rows(i)("is_combine").ToString
            Dim id_report_status As String = data_head.Rows(i)("id_report_status").ToString
            Dim report_status_note As String = data_head.Rows(i)("report_status_note").ToString
            Dim id_combine As String = data_head.Rows(i)("id_combine").ToString
            Dim acknowledge_by As String = data_head.Rows(i)("acknowledge_by").ToString
            Dim approved_by As String = data_head.Rows(i)("approved_by").ToString
            Dim is_pre As String = data_head.Rows(i)("is_pre").ToString
            Dim app_id_from As String = data_head.Rows(i)("app_id").ToString

            exported += "<tb_st_trans><id_st_trans>" + id_st_trans + "</id_st_trans><id_wh_drawer>" + id_wh_drawer + "</id_wh_drawer><st_trans_number>" + st_trans_number + "</st_trans_number><remark>" + remark + "</remark><st_trans_date>" + st_trans_date + "</st_trans_date><st_trans_by>" + st_trans_by + "</st_trans_by><st_trans_updated>" + st_trans_updated + "</st_trans_updated><st_trans_updated_by>" + st_trans_updated_by + "</st_trans_updated_by><is_combine>" + is_combine + "</is_combine><id_report_status>" + id_report_status + "</id_report_status><report_status_note>" + report_status_note + "</report_status_note><id_combine>" + id_combine + "</id_combine><acknowledge_by>" + acknowledge_by + "</acknowledge_by><approved_by>" + approved_by + "</approved_by><is_pre>" + is_pre + "</is_pre><app_id>" + app_id_from + "</app_id></tb_st_trans>"
        Next

        'detail
        For i = 0 To data_detail.Rows.Count - 1
            Dim id_st_trans_det As String = data_detail.Rows(i)("id_st_trans_det").ToString
            Dim id_st_trans_det_ref As String = data_detail.Rows(i)("id_st_trans_det_ref").ToString
            Dim id_st_trans As String = data_detail.Rows(i)("id_st_trans").ToString
            Dim is_ok As String = data_detail.Rows(i)("is_ok").ToString
            Dim is_no_stock As String = data_detail.Rows(i)("is_no_stock").ToString
            Dim is_no_master As String = data_detail.Rows(i)("is_no_master").ToString
            Dim is_sale As String = data_detail.Rows(i)("is_sale").ToString
            Dim is_reject As String = data_detail.Rows(i)("is_reject").ToString
            Dim is_unique_not_found As String = data_detail.Rows(i)("is_unique_not_found").ToString
            Dim is_no_tag As String = data_detail.Rows(i)("is_no_tag").ToString
            Dim id_product As String = data_detail.Rows(i)("id_product").ToString
            Dim code As String = data_detail.Rows(i)("code").ToString
            Dim name As String = data_detail.Rows(i)("name").ToString
            Dim size As String = data_detail.Rows(i)("size").ToString
            Dim qty As String = data_detail.Rows(i)("qty").ToString
            Dim id_design_price As String = data_detail.Rows(i)("id_design_price").ToString
            Dim design_price As String = data_detail.Rows(i)("design_price").ToString
            Dim note As String = data_detail.Rows(i)("note").ToString

            exported += "<tb_st_trans_det><id_st_trans_det>" + id_st_trans_det + "</id_st_trans_det><id_st_trans_det_ref>" + id_st_trans_det_ref + "</id_st_trans_det_ref><id_st_trans>" + id_st_trans + "</id_st_trans><is_ok>" + is_ok + "</is_ok><is_no_stock>" + is_no_stock + "</is_no_stock><is_no_master>" + is_no_master + "</is_no_master><is_sale>" + is_sale + "</is_sale><is_reject>" + is_reject + "</is_reject><is_unique_not_found>" + is_unique_not_found + "</is_unique_not_found><is_no_tag>" + is_no_tag + "</is_no_tag><id_product>" + id_product + "</id_product><code>" + code + "</code><name>" + name + "</name><size>" + size + "</size><qty>" + qty + "</qty><id_design_price>" + id_design_price + "</id_design_price><design_price>" + design_price + "</design_price><note>" + note + "</note></tb_st_trans_det>"
        Next

        exported += "</root>"

        'save file
        Dim folder_date As String = DateTime.Now.ToString("yyyy-MM-dd HHmmss")

        Dim path_root As String = Application.StartupPath + "\download\export\" + folder_date

        If Not IO.Directory.Exists(path_root) Then
            System.IO.Directory.CreateDirectory(path_root)
        End If

        Dim path_exported As String = IO.Path.Combine(path_root, "FILE_IMPORT_" + st_user_code + ".sql")

        Dim fs_exported As IO.FileStream = IO.File.Create(path_exported)

        Dim info_exported As Byte() = New System.Text.UTF8Encoding(True).GetBytes(System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(exported)))

        fs_exported.Write(info_exported, 0, info_exported.Length)

        fs_exported.Close()

        'open
        Dim open_folder As ProcessStartInfo = New ProcessStartInfo()

        open_folder.WindowStyle = ProcessWindowStyle.Maximized
        open_folder.FileName = "explorer.exe"
        open_folder.Arguments = path_root

        FormMain.SplashScreenManager1.CloseWaitForm()

        infoCustom("File exported.")

        Process.Start(open_folder)
    End Sub
End Class