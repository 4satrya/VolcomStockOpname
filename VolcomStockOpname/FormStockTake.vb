Public Class FormStockTake
    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        Cursor = Cursors.WaitCursor
        FormStockTakeNew.ShowDialog()
        Cursor = Cursors.Default
    End Sub

    Private Sub FormStockTake_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewScan()
        viewCombine()
    End Sub

    Sub viewScan()
        Dim stake As New ClassStockTake()
        Dim query As String = stake.queryTransMain("AND st.is_combine=2 ", "2")
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        GCScan.DataSource = data
    End Sub

    Sub viewCombine()
        Dim stake As New ClassStockTake()
        Dim query As String = stake.queryTransMain("AND st.is_combine=1 ", "2")
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        GCCombine.DataSource = data
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        viewScan()
    End Sub

    Private Sub GVScan_DoubleClick(sender As Object, e As EventArgs) Handles GVScan.DoubleClick
        If GVScan.RowCount > 0 And GVScan.FocusedRowHandle >= 0 Then
            FormStockTakeDet.action = "upd"
            FormStockTakeDet.id_st_trans = GVScan.GetFocusedRowCellValue("id_st_trans").ToString
            FormStockTakeDet.ShowDialog()
        End If
    End Sub
End Class