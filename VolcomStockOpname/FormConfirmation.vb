Public Class FormConfirmation
    Private Sub FormConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SimpleButtonConfirm_Click(sender As Object, e As EventArgs) Handles SimpleButtonConfirm.Click
        Dim id_usr As String = execute_query("SELECT IFNULL((SELECT id_user FROM tb_m_user WHERE username = '" + addSlashes(TxtUsername.Text) + "' AND password = MD5('" + addSlashes(TextEditPassword.Text) + "')), 0) AS id_user", 0, True, "", "", "", "")

        If id_usr = "0" Then
            stopCustom("Username & password not matched.")
        Else
            If FormMain.XtraTabbedMdiManager1.SelectedPage.MdiChild.Name = "FormStockTake" Then
                Dim already As String = execute_query("SELECT IFNULL((SELECT id_user FROM db_opt_cancel WHERE id_user = " + id_usr + " AND type = " + FormStockTake.is_pre + "), 0)", 0, False, "192.168.1.244", "external_user", "demo_volcom", "db_opt")

                If already = "0" Then
                    stopCustom("Username & password not matched.")
                Else
                    FormStockTakeCancel.ShowDialog()

                    Close()
                End If
            ElseIf FormMain.XtraTabbedMdiManager1.SelectedPage.MdiChild.Name = "FormVerStockTake" Then
                Dim already As String = execute_query("SELECT IFNULL((SELECT id_user FROM db_opt_cancel WHERE id_user = " + id_usr + " AND type = 3), 0)", 0, False, "192.168.1.244", "external_user", "demo_volcom", "db_opt")

                If already = "0" Then
                    stopCustom("Username & password not matched.")
                Else
                    FormStockTakeCancel.ShowDialog()

                    Close()
                End If
            End If
        End If
    End Sub

    Private Sub SimpleButtonCancel_Click(sender As Object, e As EventArgs) Handles SimpleButtonCancel.Click
        Close()
    End Sub

    Private Sub FormConfirmation_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub TextEditPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles TextEditPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            SimpleButtonConfirm_Click(SimpleButtonConfirm, New EventArgs)
        End If
    End Sub
End Class