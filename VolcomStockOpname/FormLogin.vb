﻿Imports System.IO

Public Class FormLogin
    Public is_first As Boolean = False
    Public id_menu As String = ""
    Dim _list_download As Queue(Of String) = New Queue(Of String)()
    Dim url_volcom As String = ""
    Dim url_volcom_un As String = ""

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_form()
    End Sub

    Sub loadDownload()
        Dim line As String = ""
        Try
            ' Open the file using a stream reader.
            Using sr As New StreamReader(Application.StartupPath & "\Location.txt")
                ' Read the stream to a string and write the string to the console.
                line = sr.ReadToEnd()
            End Using
        Catch ex As Exception
        End Try

        If Environment.Is64BitOperatingSystem.ToString Then
            url_volcom = line + ":\Program Files (x86)\Volcom Indonesia\Volcom Stock \Volcom MRP.exe"
            url_volcom_un = line + ":\Program Files (x86)\Volcom Indonesia\Volcom ERP\uninstall_command.bat"
        Else
            url_volcom = line + ":\Program Files\Volcom Indonesia\Volcom ERP\Volcom MRP.exe"
            url_volcom_un = line + ":\Program Files\Volcom Indonesia\Volcom ERP\uninstall_command.bat"
        End If
        load_form()
    End Sub

    Sub load_form()
        Dim myFileVersionInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(Application.StartupPath() + "\VolcomStockOpname.exe")

        Try
            myFileVersionInfo = FileVersionInfo.GetVersionInfo(url_volcom)
        Catch ex As Exception
        End Try

        LabelVersion.Text = "Version " & myFileVersionInfo.FileVersion.ToString

        'PictureEdit1.LoadAsync("http://192.168.1.2/app_upd/launch_img.jpg")


        'Dim update_url As String = "http://192.168.1.2/app_upd/"
        'Dim web As New Net.WebClient
        'Dim LatestVersion As String = web.DownloadString(update_url & "version.txt") 'To download the Lastest Version from a specified URL.

        'Dim LatestVersion_v = New Version(LatestVersion)
        'Dim myFileVersionInfo_v = New Version(myFileVersionInfo.FileVersion.ToString)

        'Dim result = LatestVersion_v.CompareTo(myFileVersionInfo_v)
        'If result > 0 Then
        'Console.WriteLine("LatestVersion_v is greater")
        'ElseIf result < 0 Then
        'Console.WriteLine("myFileVersionInfo_v is greater")
        'Else
        'Console.WriteLine("versions are equal")
        'End If

        'If myFileVersionInfo.FileVersion.ToString < LatestVersion Then
        '    'infoCustom("Latest Version : " & LatestVersion & " of this application is available !")
        '    BLaunch.Text = "Update"
        'Else
        '    BLaunch.Text = "Start"
        'End If
    End Sub

    Private Sub FormLogin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If id_user = Nothing Then
            End
        Else
            Dispose()
        End If
    End Sub

    Sub login()
        ValidateChildren()
        If TxtPass.Text = "" Or TxtUsername.Text = "" Then
            stopCustom("Can't blank")
        Else
            Dim query As String
            Dim username As String = addSlashes(TxtUsername.Text)
            Dim password As String = addSlashes(TxtPass.Text)
            Dim data As DataTable
            Try
                Cursor = Cursors.WaitCursor
                query = String.Format("SELECT * FROM tb_m_user a INNER JOIN tb_m_employee b ON a.id_employee = b.id_employee INNER JOIN tb_st_user s ON s.id_user = a.id_user WHERE a.username = '{0}' AND a.password=MD5('{1}') AND b.id_employee_active=1", username, password)
                If Not is_first Then
                    data = execute_query(query, -1, True, "", "", "", "")
                Else
                    data = execute_query(query, -1, False, app_host_main, app_username_main, app_password_main, app_database_main)
                End If
                If data.Rows.Count > 0 Then
                    id_user = data.Rows(0)("id_user").ToString
                    id_role_login = data.Rows(0)("role").ToString
                    name_user = data.Rows(0)("employee_name").ToString
                    position_user = data.Rows(0)("employee_position").ToString
                    code_user = data.Rows(0)("employee_code").ToString
                    username_user = data.Rows(0)("username").ToString
                    id_employee_user = data.Rows(0)("id_employee").ToString
                    id_departement_user = data.Rows(0)("id_departement").ToString
                    id_departement_sub_user = data.Rows(0)("id_departement_sub").ToString
                    is_change_pass_user = data.Rows(0)("is_change").ToString
                    Dim show_notif As String = data.Rows(0)("show_notif").ToString
                    st_user_code = data.Rows(0)("st_user_code").ToString
                    'checkMenu() 'check menu based on role

                    'log
                    'Dim u As New ClassUser()
                    'u.logLogin("1")

                    Close()
                    If Not is_first Then
                        FormMain.TxtName.Text = name_user.ToUpper
                        FormMain.TxtPosition.Text = position_user.ToUpper
                        FormMain.userPriv()
                        FormMain.Opacity = 100
                        FormMain.BringToFront()
                        FormMain.Focus()
                    Else
                        If id_menu = "1" Then
                            FormFGBackupStockDet.ShowDialog()
                        End If
                    End If
                Else
                    stopCustom("Login failure, please check your input !")
                End If
                Cursor = Cursors.Default
            Catch ex As Exception
                FormDatabase.showx = True
                FormDatabase.ShowDialog()
            End Try
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        login()
    End Sub

    Private Sub TxtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtPass.Focus()
        End If
    End Sub

    Private Sub TxtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            login()
        End If
    End Sub

    Private Sub FormLogin_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        'testing purpose
        If e.KeyCode = Keys.F1 Then
            TxtUsername.Text = "catur"
            TxtPass.Text = "catur"
            BtnLogin.Focus()
        ElseIf e.KeyCode = Keys.F2 Then
            TxtUsername.Text = "sfinance"
            TxtPass.Text = "sfinance"
            BtnLogin.Focus()
        ElseIf e.KeyCode = Keys.F3 Then
            TxtUsername.Text = "director"
            TxtPass.Text = "director"
            BtnLogin.Focus()
        ElseIf e.KeyCode = Keys.F4 Then
            TxtUsername.Text = "smarketing"
            TxtPass.Text = "smarketing"
            BtnLogin.Focus()
        End If

    End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles BtnReset.Click
        Dim confirm As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure you want to reset to default setting ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If confirm = DialogResult.Yes Then
            Cursor = Cursors.WaitCursor
            Try
                write_database_configuration("localhost", "root", "mtvolcom14", "db_opt")
                read_database_configuration()
                Try
                    FormFGBackupStockDet.Close()
                Catch ex As Exception
                End Try
                infoCustom("Setup database success, please open again this application")
                Application.Exit()
                'FormMain.LoginToolStripMenuItem.Visible = True
            Catch ex As Exception
                DevExpress.XtraEditors.XtraMessageBox.Show("Connection failed : " + ex.ToString + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            Cursor = Cursors.Default
        End If
    End Sub
End Class