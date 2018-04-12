Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient

Public Class FormDatabase
    Private connect_state As Boolean = False
    Public id_type As String = "-1"
    Public showx As Boolean = False
    Dim url_import As String = ""

    Sub view_database(ByVal host As String, ByVal username As String, ByVal password As String)
        Dim data As DataTable = show_databases(False, host, username, password)
        GCData.DataSource = data
        setDB()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles BtnConnect.Click
        Cursor = Cursors.WaitCursor

        Try
            If connect_state = False Then
                Dim host As String = TxtHost.Text
                Dim username As String = TxtUsername.Text
                Dim password As String = TxtPass.Text

                view_database(host, username, password)

                TxtHost.Enabled = False
                TxtUsername.Enabled = False
                TxtPass.Enabled = False
                BtnSave.Enabled = True

                connect_state = True
            Else
                GCData.DataSource = Nothing
                TxtHost.Enabled = True
                TxtUsername.Enabled = True
                TxtPass.Enabled = True
                BtnSave.Enabled = False

                connect_state = False
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Cursor = Cursors.Default
    End Sub

    Private Sub FormDatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActiveControl = TxtHost
        If showx Then
            TxtHost.Enabled = False
            TxtUsername.Enabled = False
            TxtPass.Enabled = False
            TxtHost.Text = app_host
            TxtUsername.Text = app_username
            TxtPass.Text = app_password
            TxtDB.Text = app_database
        End If
    End Sub

    Private Sub GVData_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GVData.FocusedRowChanged
        setDB()
    End Sub

    Sub setDB()
        If GVData.RowCount > 0 Then
            TxtDB.Text = GVData.GetFocusedRowCellValue("Database").ToString
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Cursor = Cursors.WaitCursor

        Try
            write_database_configuration(TxtHost.Text, TxtUsername.Text, TxtPass.Text, GVData.GetFocusedRowCellDisplayText("Database").ToString)
            read_database_configuration()
            Try
                FormFGBackupStockDet.Close()
            Catch ex As Exception
            End Try
            infoCustom("Setup database success, please open again this application")
            Application.Exit()
            'FormMain.LoginToolStripMenuItem.Visible = True
        Catch ex As Exception
            XtraMessageBox.Show("Connection failed : " + ex.ToString + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Cursor = Cursors.Default
    End Sub

    Private Sub FormDatabase_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
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
                Dim connection_string As String = String.Format("Data Source={0};User Id={1};Password={2};Convert Zero Datetime=True", TxtHost.Text, TxtUsername.Text, TxtPass.Text)
                Dim connection As MySqlConnection = New MySqlConnection(connection_string)
                connection.Open()
                Dim command As MySqlCommand = connection.CreateCommand()
                command.CommandText = "CREATE DATABASE `" + db_new + "`"
                command.ExecuteNonQuery()
                command.Dispose()
                connection.Close()
                connection.Dispose()

                'restore db
                FormMain.SplashScreenManager1.SetWaitFormDescription("Restoring data")
                Dim constring As String = "server=" + TxtHost.Text + ";user=" + TxtUsername.Text + ";pwd=" + TxtPass.Text + ";database=" + db_new + ";"
                Using conn As New MySqlConnection(constring)
                    Using cmd As New MySqlCommand()
                        Using mb As New MySqlBackup(cmd)
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

                FormMain.SplashScreenManager1.SetWaitFormDescription("Set default connection")
                write_database_configuration(TxtHost.Text, TxtUsername.Text, TxtPass.Text, db_new)
                read_database_configuration()
                FormMain.SplashScreenManager1.CloseWaitForm()
                infoCustom("Setup database success, please open again this application")
                Application.Exit()
                'FormMain.logOutCmd()
                'Close()
            Catch ex As Exception
                FormMain.SplashScreenManager1.CloseWaitForm()
                errorCustom(ex.ToString)
            End Try
        End If
        fdlg.Dispose()
    End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Cursor = Cursors.WaitCursor
        GCData.DataSource = Nothing
        TxtDB.Text = ""
        TxtDB.Enabled = True
        TxtHost.Text = ""
        TxtHost.Enabled = True
        TxtPass.Text = ""
        TxtPass.Enabled = True
        TxtUsername.Text = ""
        TxtUsername.Enabled = True
        TxtHost.Focus()
        Cursor = Cursors.Default
    End Sub
End Class