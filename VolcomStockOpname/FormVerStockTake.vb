﻿Public Class FormVerStockTake
    Private Sub FormVerStockTake_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewUserType()
        viewScan()
        viewCombine()
    End Sub

    Sub viewUserType()
        Cursor = Cursors.WaitCursor
        Dim query As String = "SELECT '1' AS `id_user_type`, 'User Login' AS `type_user`
        UNION 
        SELECT '2' AS `id_user_type`, 'All User' AS `type_user` "
        viewLookupQuery(LEViewUser, query, 0, "type_user", "id_user_type")
        Cursor = Cursors.Default
    End Sub

    Sub viewScan()
        Cursor = Cursors.WaitCursor

        'user view
        Dim cond_user As String = ""
        If LEViewUser.EditValue.ToString = "1" Then
            cond_user = "AND st.st_trans_ver_by='" + id_user + "' "
        End If

        Dim stake As New ClassStockTake()
        Dim query As String = stake.queryVerTransMain("AND st.is_combine=2 " + cond_user + " ", "2")
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
        Cursor = Cursors.WaitCursor
        Dim stake As New ClassStockTake()
        Dim query As String = stake.queryVerTransMain("AND st.is_combine=1 ", "2")
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        GCCombine.DataSource = data
        Cursor = Cursors.Default
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
        Cursor = Cursors.WaitCursor
        FormVerStockTakeList.ShowDialog()
        Cursor = Cursors.Default
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        viewScan()
    End Sub

    Private Sub GVScan_DoubleClick(sender As Object, e As EventArgs) Handles GVScan.DoubleClick
        If GVScan.RowCount > 0 And GVScan.FocusedRowHandle >= 0 Then
            FormVerStockTakeDet.action = "upd"
            FormVerStockTakeDet.id_st_trans_ver = GVScan.GetFocusedRowCellValue("id_st_trans_ver").ToString
            FormVerStockTakeDet.ShowDialog()
        End If
    End Sub

    Private Sub BtnRefCom_Click(sender As Object, e As EventArgs) Handles BtnRefCom.Click
        viewCombine()
    End Sub

    Private Sub BtnPrintCom_Click(sender As Object, e As EventArgs) Handles BtnPrintCom.Click
        Cursor = Cursors.WaitCursor
        print_raw(GCCombine, "")
        Cursor = Cursors.Default
    End Sub

    Private Sub BtnCreateCom_Click(sender As Object, e As EventArgs) Handles BtnCreateCom.Click
        Cursor = Cursors.WaitCursor
        FormVerStockTakeCombine.ShowDialog()
        Cursor = Cursors.Default
    End Sub

    Private Sub GVCombine_DoubleClick(sender As Object, e As EventArgs) Handles GVCombine.DoubleClick
        If GVCombine.RowCount > 0 And GVCombine.FocusedRowHandle >= 0 Then
            FormVerStockTakeDet.action = "upd"
            FormVerStockTakeDet.id_st_trans_ver = GVCombine.GetFocusedRowCellValue("id_st_trans_ver").ToString
            FormVerStockTakeDet.ShowDialog()
        End If
    End Sub

    Private Sub LEViewUser_EditValueChanged(sender As Object, e As EventArgs) Handles LEViewUser.EditValueChanged
        GCScan.DataSource = Nothing
    End Sub

    Private Sub ToolStripCancel_Click(sender As Object, e As EventArgs) Handles ToolStripCancel.Click
        FormConfirmation.ShowDialog()
    End Sub

    Private Sub GVScan_PopupMenuShowing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles GVScan.PopupMenuShowing
        If GVScan.GetFocusedRowCellValue("id_report_status").ToString = "6" Then
            ToolStripCancel.Visible = True
        Else
            ToolStripCancel.Visible = False
        End If
    End Sub

    Private Sub GVCombine_PopupMenuShowing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles GVCombine.PopupMenuShowing
        If GVCombine.GetFocusedRowCellValue("id_report_status").ToString = "6" Then
            ToolStripCancel.Visible = True
        Else
            ToolStripCancel.Visible = False
        End If
    End Sub
End Class