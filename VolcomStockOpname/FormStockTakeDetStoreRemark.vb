Public Class FormStockTakeDetStoreRemark
    Public id_st_trans As String = "-1"
    Public id_product As String = "-1"
    Public code As String = ""
    Public id_pop_up = "-1"

    Private Sub FormStockTakeDetStoreRemark_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FormStockTakeDetStoreRemark_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Close()
    End Sub

    Private Sub FormStockTakeDetStoreRemark_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub MemoEdit1_KeyDown(sender As Object, e As KeyEventArgs) Handles MERemark.KeyDown
        If e.KeyCode = Keys.Enter Then
            If id_pop_up = "-1" Then
                If id_product = "" Then
                    id_product = "NULL"
                End If
                Dim remark As String = addSlashes(MERemark.Text.ToString)
                Dim qry As String = "DELETE FROM tb_st_store_remark WHERE id_st_trans='" + id_st_trans + "' "
                If id_product = "NULL" Then
                    qry += "AND ISNULL(id_product) "
                Else
                    qry += "AND id_product='" + id_product + "' "
                End If
                qry += "AND code='" + code + "';
                INSERT INTO tb_st_store_remark(id_st_trans, id_product, code, remark) VALUES 
                ('" + id_st_trans + "', " + id_product + ", '" + code + "', '" + remark + "'); "
                execute_non_query(qry, True, "", "", "", "")
                FormStockTakeDet.updatedBy()
                FormStockTakeDet.viewCompare()
                FormStockTakeDet.BGVCompare.FocusedRowHandle = find_row(FormStockTakeDet.BGVCompare, "barcode", code)
                Close()
            Else

            End If
        End If
    End Sub
End Class