Public Class FormVerStockTake
    Private Sub FormVerStockTake_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewScan()
        viewCombine()
    End Sub

    Sub viewScan()
        Cursor = Cursors.WaitCursor
        Dim stake As New ClassStockTake()
        Dim query As String = stake.queryVerTransMain("AND st.is_combine=2 ", "2")
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        GCScan.DataSource = data
        GVScan.FocusedRowHandle = 0
        noEdit()
        Cursor = Cursors.Default
    End Sub

    Sub noEdit()
        If GVScan.RowCount > 0 Then
            Dim alloc_cek As String = GVScan.GetFocusedRowCellValue("id_report_status").ToString
            If alloc_cek = "5" Then
                GVScan.Columns("is_select").OptionsColumn.AllowEdit = False
            Else
                GVScan.Columns("is_select").OptionsColumn.AllowEdit = True
            End If
        End If
    End Sub

    Sub viewCombine()
        'Cursor = Cursors.WaitCursor
        'Dim stake As New ClassStockTake()
        'Dim query As String = stake.queryTransMain("AND st.is_combine=1 AND st.is_pre=" + is_pre + " ", "2")
        'Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        'GCCombine.DataSource = data
        'Cursor = Cursors.Default
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        Cursor = Cursors.WaitCursor
        FormVerStockTakeNew.ShowDialog()
        Cursor = Cursors.Default
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        Cursor = Cursors.WaitCursor
        print_raw(GCScan, "")
        Cursor = Cursors.Default
    End Sub

    Private Sub BtnList_Click(sender As Object, e As EventArgs) Handles BtnList.Click
        'Cursor = Cursors.WaitCursor
        'FormStockTakeList.ShowDialog()
        'Cursor = Cursors.Default
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        viewScan()
    End Sub
End Class