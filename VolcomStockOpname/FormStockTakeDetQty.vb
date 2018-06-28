Public Class FormStockTakeDetQty
    Public id_detail As String = "-1"
    Public id_pop_up As String = "-1"
    Private Sub FormStockTakeDetQty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtQty.EditValue = 1
    End Sub

    Private Sub TxtQty_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtQty.KeyDown
        If e.KeyCode = Keys.Enter Then
            If id_pop_up = "-1" Then
                Dim qry As String = "UPDATE tb_st_trans_det SET qty='" + decimalSQL(TxtQty.EditValue) + "' WHERE id_st_trans_det='" + id_detail + "' "
                execute_non_query(qry, True, "", "", "", "")
                FormStockTakeDet.updatedBy()
                FormStockTakeDet.viewDetail()
                FormStockTakeDet.GVScan.FocusedRowHandle = FormStockTakeDet.GVScan.RowCount - 1
                FormStockTakeDet.TxtScan.Text = ""
                FormStockTakeDet.TxtScan.Focus()
                Close()
            Else
                Dim qry As String = "UPDATE tb_st_trans_ver_det SET qty='" + decimalSQL(TxtQty.EditValue) + "' WHERE id_st_trans_ver_det='" + id_detail + "' "
                execute_non_query(qry, True, "", "", "", "")
                FormVerStockTakeDet.updatedBy()
                FormVerStockTakeDet.viewDetail()
                FormVerStockTakeDet.GVScan.FocusedRowHandle = FormVerStockTakeDet.GVScan.RowCount - 1
                FormVerStockTakeDet.TxtScan.Text = ""
                FormVerStockTakeDet.TxtScan.Focus()
                Close()
            End If
        End If
    End Sub

    Private Sub FormStockTakeDetQty_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub FormStockTakeDetQty_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub
End Class