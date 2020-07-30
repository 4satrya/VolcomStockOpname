Public Class FormStockTakeNew
    Public is_allow_record_unique_code As String = "2"

    Public is_reject As String = "2"
    Public is_no_tag As String = "2"

    Private Sub FormStockTakeNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'check login store
        Dim is_login_store As String = "2"

        Try
            is_login_store = execute_query("SELECT is_login_store FROM tb_opt", 0, False, app_host, app_username, app_password, "db_opt")
        Catch ex As Exception
            is_login_store = "2"
        End Try

        If is_login_store = "1" Then
            LookAndFeel.UseDefaultLookAndFeel = False

            If is_reject = "1" Then
                LookAndFeel.SkinMaskColor = Color.LightYellow
                Text = "Reject"
            ElseIf is_no_tag = "1" Then
                LookAndFeel.SkinMaskColor = Color.LightPink
                Text = "No Tag"
            Else
                LookAndFeel.SkinMaskColor = Color.LightGreen
                Text = "Create New"
            End If
        End If

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
        If is_no_tag = "2" Then
            Dim query As String = "INSERT INTO tb_st_trans (id_wh_drawer, st_trans_number, remark, st_trans_date, st_trans_by, is_combine,is_pre) 
            VALUES ('" + SLEWHStockSum.EditValue.ToString + "', '', '" + addSlashes(MERemark.Text.ToString) + "', NOW(), '" + id_user + "', 2," + FormStockTake.is_pre + "); SELECT LAST_INSERT_ID(); "
            Dim id_new As String = execute_query(query, 0, True, "", "", "", "")

            'update number
            Dim trans_number As String = getTransNumber(id_new)
            Dim query_numb As String = "UPDATE tb_st_trans SET st_trans_number='" + trans_number + "' WHERE id_st_trans='" + id_new + "' "
            execute_non_query(query_numb, True, "", "", "", "")

            FormStockTake.viewScan()
            FormStockTakeDet.is_allow_record_unique_code = is_allow_record_unique_code
            FormStockTakeDet.action = "upd"
            FormStockTakeDet.id_st_trans = id_new
            If is_reject = "1" Then
                FormStockTakeDet.is_reject = "1"
            End If
            FormStockTakeDet.ShowDialog()
            Close()
        Else
            Dim query As String = "INSERT INTO tb_st_no_tag (id_wh_drawer, no_tag_number, remark, no_tag_date, no_tag_by) VALUES ('" + SLEWHStockSum.EditValue.ToString + "', '', '" + addSlashes(MERemark.Text.ToString) + "', NOW(), '" + id_user + "'); SELECT LAST_INSERT_ID();"

            Dim id_new As String = execute_query(query, 0, True, "", "", "", "")

            'update number
            Dim trans_number As String = getTransNumber(id_new)
            Dim query_numb As String = "UPDATE tb_st_no_tag SET no_tag_number='" + trans_number + "' WHERE id_st_no_tag='" + id_new + "' "
            execute_non_query(query_numb, True, "", "", "", "")

            FormStockTakeNoTag.id_st_no_tag = id_new
            FormStockTakeNoTag.ShowDialog()
            Close()
        End If
        Cursor = Cursors.Default
    End Sub

    Function getTransNumber(ByVal id_report As String)
        If is_no_tag = "2" Then
            If FormStockTake.is_pre = "1" Then 'wh pre stock take
                Return header_number("4", id_report)
            Else 'stock take
                Return header_number("1", id_report)
            End If
        Else
            Return header_number("8", id_report)
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