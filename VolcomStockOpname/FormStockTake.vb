Imports MySql.Data.MySqlClient

Public Class FormStockTake
    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        Cursor = Cursors.WaitCursor
        FormStockTakeNew.ShowDialog()
        Cursor = Cursors.Default
    End Sub

    Private Sub FormStockTake_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewScan()
        viewCombine()
    End Sub

    Sub viewScan()
        Dim stake As New ClassStockTake()
        Dim query As String = stake.queryTransMain("AND st.is_combine=2 ", "2")
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        GCScan.DataSource = data
        GVScan.FocusedRowHandle = 0
        noEdit()
    End Sub

    Sub viewCombine()
        Dim stake As New ClassStockTake()
        Dim query As String = stake.queryTransMain("AND st.is_combine=1 ", "2")
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        GCCombine.DataSource = data
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        viewScan()
    End Sub


    Sub noEdit()
        If GVScan.RowCount > 0 Then
            Dim alloc_cek As String = GVScan.GetFocusedRowCellValue("id_report_status").ToString
            If alloc_cek <> "6" Then
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
                Dim query_copy_trans As String = "CREATE TABLE IF NOT EXISTS tb_st_trans_" + st_user_code + " SELECT * FROM tb_st_trans WHERE id_st_trans>0 AND (" + id_st_trans + "); 
                truncate table tb_st_trans_" + st_user_code + "; 
                INSERT tb_st_trans_" + st_user_code + " SELECT * FROM tb_st_trans WHERE id_st_trans>0 AND (" + id_st_trans + "); "
                execute_non_query(query_copy_trans, True, "", "", "", "")
                Dim query_copy_trans_det As String = "CREATE TABLE IF NOT EXISTS tb_st_trans_det_" + st_user_code + " SELECT * FROM tb_st_trans_det WHERE id_st_trans>0 AND (" + id_st_trans + "); 
                truncate table tb_st_trans_det_" + st_user_code + "; 
                INSERT tb_st_trans_det_" + st_user_code + " SELECT * FROM tb_st_trans_det WHERE id_st_trans>0 AND (" + id_st_trans + "); "
                execute_non_query(query_copy_trans_det, True, "", "", "", "")

                'connection string
                FormMain.SplashScreenManager1.SetWaitFormDescription("Check connection ...")
                Dim dbc_str As String() = Split(app_database, "_")
                Dim name_dir = dbc_str(1) + "_" + dbc_str(2) + "_" + st_user_code
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
        Process.Start(path_root)
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
                    Dim query_ins As String = "INSERT INTO tb_st_trans(id_wh_drawer, st_trans_number, st_trans_date, st_trans_by, st_trans_updated, st_trans_updated_by, is_combine, id_report_status) 
                    SELECT id_wh_drawer, st_trans_number, st_trans_date, st_trans_by, st_trans_updated, st_trans_updated_by, is_combine, id_report_status FROM tb_st_trans_" + code_user_restore.ToLower + " WHERE id_st_trans=" + dv.Rows(j)("id_st_trans").ToString + "; SELECT LAST_INSERT_ID(); "
                    Dim id_st_new As String = execute_query(query_ins, 0, True, "", "", "", "")
                    Dim query_ins_det As String = "INSERT INTO tb_st_trans_det(id_st_trans, is_ok, is_no_stock, is_no_master, is_sale, is_reject, is_unique_not_found, id_product, code, name, size, qty, id_design_price, design_price) 
                    SELECT '" + id_st_new + "', is_ok, is_no_stock, is_no_master, is_sale, is_reject, is_unique_not_found, id_product, code, name, size, qty, id_design_price, design_price FROM tb_st_trans_det_" + code_user_restore.ToLower + " WHERE id_st_trans=" + dv.Rows(j)("id_st_trans").ToString + ";"
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
            For i As Integer = ((GVScan.RowCount - 1) - GetGroupRowCount(GVScan)) To 0 Step -1
                Dim id_report_status As String = GVScan.GetRowCellValue(i, "id_report_status").ToString
                If cek And id_report_status = "6" Then
                    GVScan.SetRowCellValue(i, "is_select", "Yes")
                Else
                    GVScan.SetRowCellValue(i, "is_select", "No")
                End If
            Next
        End If
    End Sub
End Class