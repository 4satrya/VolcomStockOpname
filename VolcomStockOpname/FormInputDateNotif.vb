Public Class FormInputDateNotif
    Public is_save As Boolean = False

    Private Sub FormInputDateNotif_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateEdit.EditValue = Now
    End Sub

    Private Sub SimpleButton_Click(sender As Object, e As EventArgs) Handles SimpleButton.Click
        Dim confirm As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("Apakah anda yakin akan menyimpan tanggal & jam?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)

        If confirm = DialogResult.Yes Then
            execute_non_query("
                UPDATE tb_st_opt SET first_ia_notif = '" + Date.Parse(DateEdit.EditValue.ToString).ToString("yyyy-MM-dd HH:mm:ss") + "'
            ", True, "", "", "", "")
        End If

        is_save = True

        Close()
    End Sub

    Private Sub FormInputDateNotif_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub
End Class