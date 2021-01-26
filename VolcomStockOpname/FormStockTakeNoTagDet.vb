Public Class FormStockTakeNoTagDet
    Public id_st_no_tag As String = "-1"

    Private Sub FormStockTakeNoTagDet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'check login store
        Dim is_login_store As String = "2"

        Try
            is_login_store = execute_query("SELECT is_login_store FROM tb_opt", 0, False, app_host, app_username, app_password, "db_opt")
        Catch ex As Exception
            is_login_store = "2"
        End Try

        If is_login_store = "1" Then
            LookAndFeel.SkinMaskColor = Color.LightBlue
            LookAndFeel.UseDefaultLookAndFeel = False
        End If
    End Sub

    Private Sub SBClose_Click(sender As Object, e As EventArgs) Handles SBClose.Click
        Close()
    End Sub

    Private Sub SBSave_Click(sender As Object, e As EventArgs) Handles SBSave.Click
        If TEName.Text = "" Or TECode.Text = "" Then
            stopCustom("Please check your input.")
        Else
            execute_non_query("INSERT INTO tb_st_no_tag_det (id_st_no_tag, code, name, size) VALUES (" + id_st_no_tag + ", '" + addSlashes(TECode.EditValue) + "', '" + addSlashes(TEName.EditValue) + "', '" + addSlashes(TESize.EditValue) + "')", True, "", "", "", "")

            FormStockTakeNoTag.form_load()

            TEName.EditValue = ""
            TECode.EditValue = ""
            TESize.EditValue = ""
        End If
    End Sub

    Private Sub FormStockTakeNoTagDet_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub TEName_KeyDown(sender As Object, e As KeyEventArgs) Handles TEName.KeyDown
        If e.KeyCode = Keys.Enter Then
            SBSave_Click(SBSave, New EventArgs)
        End If
    End Sub

    Private Sub TECode_KeyDown(sender As Object, e As KeyEventArgs) Handles TECode.KeyDown
        If e.KeyCode = Keys.Enter Then
            SBSave_Click(SBSave, New EventArgs)
        End If
    End Sub
End Class