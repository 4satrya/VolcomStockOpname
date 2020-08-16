Public Class FormStockTakeDetNote
    Public id_detail As String = "-1"
    Public id_pop_up As String = "-1"

    Public is_no_tag As String = "2"

    Private Sub FormStockTakeDetNote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If is_no_tag = "1" Then
            LookAndFeel.UseDefaultLookAndFeel = False
            LookAndFeel.SkinMaskColor = Color.LightPink
        End If
    End Sub

    Private Sub FormStockTakeDetNote_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub MENote_KeyDown(sender As Object, e As KeyEventArgs) Handles MENote.KeyDown
        If e.KeyCode = Keys.Enter Then
            If is_no_tag = "2" Then
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
            Else
                Dim qry As String = "UPDATE tb_st_no_tag_det SET note='" + addSlashes(MENote.Text.ToString) + "' WHERE id_st_no_tag_det='" + id_detail + "' "
                execute_non_query(qry, True, "", "", "", "")
                FormStockTakeNoTag.form_load()
                Close()
            End If
        End If
    End Sub

    Private Sub FormStockTakeDetNote_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub
End Class