Public Class FormOpt
    Private Sub FormOpt_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub FormOpt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'soh period
        Dim dto As DataTable = execute_query("SELECT * FROM tb_st_opt", -1, True, "", "", "", "")
        'is_record_unreg = dto.Rows(0)("is_record_unreg").ToString
        If dto.Rows(0)("is_record_unreg").ToString = "1" Then
            CheckEdit1.Checked = True
        Else
            CheckEdit1.Checked = False
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim is_record_unreg As String = ""
        If CheckEdit1.Checked = True Then
            is_record_unreg = "1"
        Else
            is_record_unreg = "2"
        End If
        Dim query As String = "UPDATE tb_st_opt SET is_record_unreg='" + is_record_unreg + "' "
        execute_non_query(query, True, "", "", "", "")
        Close()
    End Sub
End Class