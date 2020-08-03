Public Class FormDatabaseStore
    Dim url_import As String = ""

    Private Sub FormDatabaseStore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnConnect_Click(BtnConnect, New EventArgs)
    End Sub

    Private Sub BtnConnect_Click(sender As Object, e As EventArgs) Handles BtnConnect.Click
        Cursor = Cursors.WaitCursor

        Try
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
                            SELECT IFNULL((
                                SELECT IF(tb_opt.st_scan_time >= tb_log.st_scan_time, 2, 1) AS is_stop
                                FROM (
                                    SELECT st_scan_time
                                    FROM tb_st_opt
                                    LIMIT 1
                                ) AS tb_opt, (
                                    SELECT TIMESTAMPDIFF(MINUTE, created_date, NOW()) AS st_scan_time
                                    FROM tb_st_stop_scan_log
                                    ORDER BY created_date ASC
                                    LIMIT 1
                                ) AS tb_log
                            ), 2) AS is_stop
                        ", 0, False, app_host, app_username, app_password, data.Rows(i)("Database").ToString)

                        If is_stop = "1" Then
                            execute_non_query("UPDATE tb_st_opt SET is_active_db = 2", False, app_host, app_username, app_password, data.Rows(i)("Database").ToString)

                            data.Rows(i)("is_active") = 2
                        End If
                    End If
                Catch ex As Exception
                End Try
            Next

            GCData.DataSource = data
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show("Connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        GVData.ActiveFilterString = "[is_active] = '1'"

        GVData.FocusedRowHandle = 0

        Cursor = Cursors.Default
    End Sub

    Private Sub FormDatabaseStore_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub GVData_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GVData.FocusedRowChanged
        Dim acc As String = ""
        Dim type As String = ""

        Try
            Dim dt As DataTable = execute_query("SELECT CONCAT(comp_number, ' - ', comp_name) AS acc, IF(id_store_type = 1, 'Normal', IF(id_store_type = 2, 'Sale', '')) AS type FROM tb_m_comp", -1, False, app_host, app_username, app_password, GVData.GetFocusedRowCellValue("Database"))

            acc = dt.Rows(0)("acc").ToString
            type = dt.Rows(0)("type").ToString
        Catch ex As Exception
        End Try

        TxtAcc.EditValue = acc
        TxtDB.EditValue = type
    End Sub

    Private Sub BtnImport_Click(sender As Object, e As EventArgs) Handles BtnImport.Click
        Me.Cursor = Cursors.WaitCursor
        Dim fdlg As OpenFileDialog = New OpenFileDialog()
        fdlg.Title = "Select sql file To import"
        fdlg.InitialDirectory = Application.StartupPath + "\download"
        fdlg.Filter = "SQL File|*.sql;"
        fdlg.FilterIndex = 0
        fdlg.RestoreDirectory = True
        Cursor = Cursors.Default
        If fdlg.ShowDialog() = DialogResult.OK Then
            FormMain.SplashScreenManager1.ShowWaitForm()
            url_import = fdlg.FileName.ToString
            Dim FileInfo As New IO.FileInfo(url_import)
            Dim arr_file_name As String() = Split(FileInfo.Name.ToString, ".")
            Dim db_new As String = "db_" + arr_file_name(0)

            Try
                'create new db
                FormMain.SplashScreenManager1.SetWaitFormDescription("Creating new database")
                Dim connection_string As String = String.Format("Data Source={0};User Id={1};Password={2};Convert Zero Datetime=True", app_host, app_username, app_password)
                Dim connection As MySql.Data.MySqlClient.MySqlConnection = New MySql.Data.MySqlClient.MySqlConnection(connection_string)
                connection.Open()
                Dim command As MySql.Data.MySqlClient.MySqlCommand = connection.CreateCommand()
                command.CommandText = "CREATE DATABASE `" + db_new + "`"
                command.ExecuteNonQuery()
                command.Dispose()
                connection.Close()
                connection.Dispose()

                'restore db
                FormMain.SplashScreenManager1.SetWaitFormDescription("Restoring data")
                Dim constring As String = "server=" + app_host + ";user=" + app_username + ";pwd=" + app_password + ";database=" + db_new + ";default command timeout=1800;"
                Using conn As New MySql.Data.MySqlClient.MySqlConnection(constring)
                    Using cmd As New MySql.Data.MySqlClient.MySqlCommand()
                        Using mb As New MySql.Data.MySqlClient.MySqlBackup(cmd)
                            cmd.Connection = conn
                            conn.Open()
                            mb.ImportInfo.TargetDatabase = db_new
                            mb.ImportInfo.EnableEncryption = True
                            mb.ImportInfo.EncryptionPassword = "csmtafc"
                            mb.ImportFromFile(url_import)
                            conn.Close()
                        End Using
                    End Using
                End Using

                FormMain.SplashScreenManager1.CloseWaitForm()

                infoCustom("Import database success")

                BtnConnect_Click(BtnConnect, New EventArgs)
            Catch ex As Exception
                FormMain.SplashScreenManager1.CloseWaitForm()
                errorCustom(ex.ToString)
            End Try
        End If
        fdlg.Dispose()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If GVData.RowCount > 0 Then
            Try
                write_database_configuration(app_host, app_username, app_password, GVData.GetFocusedRowCellDisplayText("Database").ToString)
                read_database_configuration()

                Dim dataDb As DataTable = execute_query("SELECT * FROM tb_m_comp", -1, False, app_host, app_username, app_password, GVData.GetFocusedRowCellDisplayText("Database").ToString)

                FormMain.LabelInfo.Text = "Active: " + dataDb.Rows(0)("comp_number").ToString + "; " + GVData.GetFocusedRowCellDisplayText("Database").ToString

                Close()

                FormLogin.ShowDialog()
            Catch ex As Exception
                stopCustom("Connection error.")
            End Try
        Else
            stopCustom("Please select database.")
        End If
    End Sub
End Class