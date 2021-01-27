Public Class FormStockTakeUnRegDet
    Private Sub FormStockTakeUnRegDet_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub SBClose_Click(sender As Object, e As EventArgs) Handles SBClose.Click
        Close()
    End Sub

    Private Sub SBSave_Click(sender As Object, e As EventArgs) Handles SBSave.Click
        If TEName.Text = "" Or TECode.Text = "" Then
            stopCustom("Please check your input.")
        Else
            execute_non_query("INSERT INTO tb_st_un_reg_det (id_st_un_reg, code, name, size) VALUES (" + FormStockTakeUnReg.id_st_un_reg + ", '" + addSlashes(TECode.EditValue.ToString) + "', '" + addSlashes(TEName.EditValue.ToString) + "', '" + addSlashes(TESize.EditValue.ToString) + "')", True, "", "", "", "")

            FormStockTakeUnReg.updatedBy()

            Close()
        End If
    End Sub

    Private Sub FormStockTakeUnRegDet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'check login store
        Dim is_login_store As String = "2"

        Try
            is_login_store = execute_query("SELECT is_login_store FROM tb_opt", 0, False, app_host, app_username, app_password, "db_opt")
        Catch ex As Exception
            is_login_store = "2"
        End Try

        If is_login_store = "1" Then
            LookAndFeel.SkinMaskColor = Color.LightPink
            LookAndFeel.UseDefaultLookAndFeel = False
        End If
    End Sub
End Class