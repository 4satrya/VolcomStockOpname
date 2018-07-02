Public Class FormStockTakeNew
    Private Sub LabelControl1_Click(sender As Object, e As EventArgs) Handles LabelControl1.Click

    End Sub

    Private Sub FormStockTakeNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewWHStockSum()
    End Sub

    Sub viewWHStockSum()
        Dim query As String = ""
        query += "SELECT e.id_comp,e.id_drawer_def, e.comp_number, e.comp_name, CONCAT_WS(' - ', e.comp_number, e.comp_name) AS comp_name_label FROM tb_st_stock a "
        query += "INNER JOIN tb_m_comp e ON e.id_drawer_def = a.id_wh_drawer "
        query += "GROUP BY e.id_drawer_def "
        viewSearchLookupQuery(SLEWHStockSum, query, "id_drawer_def", "comp_name_label", "id_drawer_def")
    End Sub

    Private Sub SLEWHStockSum_KeyDown(sender As Object, e As KeyEventArgs) Handles SLEWHStockSum.KeyDown
        If e.KeyCode = Keys.Enter Then
            MERemark.Focus()
        End If
    End Sub

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        Cursor = Cursors.WaitCursor
        Dim query As String = "INSERT INTO tb_st_trans (id_wh_drawer, st_trans_number, remark, st_trans_date, st_trans_by, is_combine,is_pre) 
        VALUES ('" + SLEWHStockSum.EditValue.ToString + "', '" + getTransNumber() + "', '" + addSlashes(MERemark.Text.ToString) + "', NOW(), '" + id_user + "', 2," + FormStockTake.is_pre + "); SELECT LAST_INSERT_ID(); "
        Dim id_new As String = execute_query(query, 0, True, "", "", "", "")
        FormStockTake.viewScan()
        FormStockTakeDet.action = "upd"
        FormStockTakeDet.id_st_trans = id_new
        FormStockTakeDet.ShowDialog()
        Close()
        Cursor = Cursors.Default
    End Sub

    Function getTransNumber()
        If FormStockTake.is_pre = "1" Then 'wh pre stock take
            Return header_number("4")
        Else 'stock take
            Return header_number("1")
        End If
    End Function

    Private Sub FormStockTakeNew_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub MERemark_KeyDown(sender As Object, e As KeyEventArgs) Handles MERemark.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnCreate.Focus()
        End If
    End Sub
End Class