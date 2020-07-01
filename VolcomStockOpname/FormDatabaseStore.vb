Public Class FormDatabaseStore
    Dim url_import As String = ""

    Private Sub FormDatabaseStore_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

            GCData.DataSource = data
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show("Connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Cursor = Cursors.Default
    End Sub

    Private Sub FormDatabaseStore_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub GVData_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GVData.FocusedRowChanged
        Dim type As String = ""

        Try
            type = execute_query("SELECT IF(id_store_type = 1, 'Normal', IF(id_store_type = 2, 'Sale', '')) AS type FROM tb_m_comp", 0, False, app_host, app_username, app_password, GVData.GetFocusedRowCellValue("Database"))
        Catch ex As Exception
        End Try

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
        write_database_configuration(app_host, app_username, app_password, GVData.GetFocusedRowCellDisplayText("Database").ToString)
        read_database_configuration()

        Dim dataDb As DataTable = execute_query("SELECT * FROM tb_m_comp", -1, False, app_host, app_username, app_password, GVData.GetFocusedRowCellDisplayText("Database").ToString)

        FormMain.LabelInfo.Text = "Active: " + dataDb.Rows(0)("comp_number").ToString + "; " + GVData.GetFocusedRowCellDisplayText("Database").ToString

        Close()

        FormLogin.ShowDialog()
    End Sub
End Class