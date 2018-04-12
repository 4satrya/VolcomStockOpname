Public Class FormStockTakeDel
    Private Sub TxtCode_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            makeSafeGV(FormStockTakeDet.GVScan)
            FormStockTakeDet.GVScan.ActiveFilterString = "[code]='" + addSlashes(TxtCode.Text) + "' "
            If FormStockTakeDet.GVScan.RowCount <= 0 Then
                stopCustom("Code not found !")
                FormStockTakeDet.GVScan.ActiveFilterString = ""
                FormStockTakeDet.GVScan.FocusedRowHandle = FormStockTakeDet.GVScan.RowCount - 1
            Else
                Dim query As String = "DELETE FROM tb_st_trans_det WHERE id_st_trans_det='" + FormStockTakeDet.GVScan.GetFocusedRowCellValue("id_st_trans_det").ToString + "' "
                execute_non_query(query, True, "", "", "", "")
                FormStockTakeDet.updatedBy()
                FormStockTakeDet.viewDetail()
                FormStockTakeDet.GVScan.ActiveFilterString = ""
                FormStockTakeDet.GVScan.FocusedRowHandle = FormStockTakeDet.GVScan.RowCount - 1
            End If
            Close()
        End If
    End Sub

    Private Sub FormStockTakeDel_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub FormStockTakeDel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class