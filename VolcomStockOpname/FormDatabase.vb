Imports DevExpress.XtraEditors

Public Class FormDatabase
    Private connect_state As Boolean = False
    Public id_type As String = "-1"
    Public show As Boolean = False

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
        If show Then
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
        TxtDB.Text = GVData.GetFocusedRowCellValue("Database").ToString
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Cursor = Cursors.WaitCursor

        Try
            write_database_configuration(TxtHost.Text, TxtUsername.Text, TxtPass.Text, GVData.GetFocusedRowCellDisplayText("Database").ToString)
            read_database_configuration()
            FormMain.actionLoad()
            'FormMain.LoginToolStripMenuItem.Visible = True
        Catch ex As Exception
            XtraMessageBox.Show("Connection failed : " + ex.ToString + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Cursor = Cursors.Default

        If id_type = "1" Then
            'jika logout
        Else
            Close()
        End If
    End Sub

    Private Sub FormDatabase_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
        FormMain.actionLoad()
    End Sub
End Class