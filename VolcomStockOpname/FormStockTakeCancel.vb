Public Class FormStockTakeCancel
    Private Sub FormStockTakeCancel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Close()
    End Sub

    Private Sub ButtonApply_Click(sender As Object, e As EventArgs) Handles ButtonApply.Click
        Cursor = Cursors.WaitCursor

        Dim id_st_trans As String = ""
        Dim table As String = ""
        Dim column As String = ""

        If FormMain.XtraTabbedMdiManager1.SelectedPage.MdiChild.Name = "FormStockTake" Then
            If FormStockTake.XTCStockTake.SelectedTabPageIndex = 0 Then
                id_st_trans = FormStockTake.GVScan.GetFocusedRowCellValue("id_st_trans").ToString
                table = "tb_st_trans"
                column = "id_st_trans"
            ElseIf FormStockTake.XTCStockTake.SelectedTabPageIndex = 1 Then
                id_st_trans = FormStockTake.GVCombine.GetFocusedRowCellValue("id_st_trans").ToString
                table = "tb_st_trans"
                column = "id_st_trans"
            End If
        ElseIf FormMain.XtraTabbedMdiManager1.SelectedPage.MdiChild.Name = "FormVerStockTake" Then
            If FormVerStockTake.XTCStockTake.SelectedTabPageIndex = 0 Then
                id_st_trans = FormVerStockTake.GVScan.GetFocusedRowCellValue("id_st_trans_ver").ToString
                table = "tb_st_trans_ver"
                column = "id_st_trans_ver"
            ElseIf FormVerStockTake.XTCStockTake.SelectedTabPageIndex = 1 Then
                id_st_trans = FormVerStockTake.GVCombine.GetFocusedRowCellValue("id_st_trans_ver").ToString
                table = "tb_st_trans_ver"
                column = "id_st_trans_ver"
            End If
        End If

        execute_non_query("UPDATE " + table + " SET id_report_status = 5, report_status_note = '" + addSlashes(MemoNote.Text) + "' WHERE " + column + " = " + id_st_trans, True, "", "", "", "")

        If FormMain.XtraTabbedMdiManager1.SelectedPage.MdiChild.Name = "FormStockTake" Then
            If FormStockTake.XTCStockTake.SelectedTabPageIndex = 0 Then
                FormStockTake.viewScan()
            ElseIf FormStockTake.XTCStockTake.SelectedTabPageIndex = 1 Then
                FormStockTake.viewCombine()
            End If
        ElseIf FormMain.XtraTabbedMdiManager1.SelectedPage.MdiChild.Name = "FormVerStockTake" Then
            If FormVerStockTake.XTCStockTake.SelectedTabPageIndex = 0 Then
                FormVerStockTake.viewScan()
            ElseIf FormVerStockTake.XTCStockTake.SelectedTabPageIndex = 1 Then
                FormVerStockTake.viewCombine()
            End If
        End If

        Cursor = Cursors.Default

        Close()
    End Sub

    Private Sub FormStockTakeCancel_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub
End Class