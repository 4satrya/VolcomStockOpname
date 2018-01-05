Public Class FormLogin
    Public is_first As Boolean = False
    Public id_menu As String = ""

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FormLogin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If id_user = Nothing Then
            End
        Else
            Dispose()
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
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
                    id_role_login = data.Rows(0)("id_role").ToString
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
                errorConnection()
                Close()
            End Try
        End If
    End Sub

    Private Sub TxtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtPass.Focus()
        End If
    End Sub

    Private Sub TxtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnLogin.Focus()
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
End Class