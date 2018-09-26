Public Class FormStockTakeDetNote
    Public id_detail As String = "-1"
    Public id_pop_up As String = "-1"

    Private Sub FormStockTakeDetNote_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FormStockTakeDetNote_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub MENote_KeyDown(sender As Object, e As KeyEventArgs) Handles MENote.KeyDown
        If e.KeyCode = Keys.Enter Then
            If id_pop_up = "-1" Then
                Dim qry As String = "UPDATE tb_st_trans_det SET note='" + addSlashes(MENote.Text.ToString) + "' WHERE id_st_trans_det='" + id_detail + "' "
                execute_non_query(qry, True, "", "", "", "")
                FormStockTakeDet.updatedBy()
                FormStockTakeDet.viewDetail()
                FormStockTakeDet.GVScan.FocusedRowHandle = find_row(FormStockTakeDet.GVScan, "id_st_trans_det", id_detail)
                FormStockTakeDet.TxtScan.Text = ""
                FormStockTakeDet.TxtScan.Focus()
                Close()
            Else

            End If
        End If
    End Sub

    Private Sub FormStockTakeDetNote_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub
End Class