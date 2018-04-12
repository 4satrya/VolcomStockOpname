Imports System.Media

Public Class FormStockTakeFaik
    Private Sub FormStockTakeFaik_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.KeyCode = Keys.F5 Then
            saveData()
        ElseIf e.KeyCode = Keys.F2 Then
            TxtCode.Focus()
        End If
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        Close()
    End Sub

    Private Sub FormStockTakeFaik_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        saveData()
    End Sub

    Sub saveData()
        Dim code As String = addSlashes(TxtCode.Text.ToString)
        Dim description As String = addSlashes(TxtDescription.Text.ToString)
        Dim size As String = addSlashes(TxtSize.Text.ToString)
        Dim price As String = decimalSQL(TxtPrice.EditValue.ToString)

        If code <> "" And description <> "" And size <> "" Then
            Dim query_ins As String = "INSERT INTO tb_st_trans_det(id_st_trans, is_ok, is_no_stock, is_no_master, is_sale, is_reject, is_unique_not_found, code, name, size, qty, design_price) 
            VALUES ('" + FormStockTakeDet.id_st_trans + "', '2', '2', '1', '2','2', '2','" + code + "', '" + description + "','" + size + "', 1, '" + price + "') "
            execute_non_query(query_ins, True, "", "", "", "")
            FormStockTakeDet.updatedBy()
            FormStockTakeDet.viewDetail()
            FormStockTakeDet.GVScan.FocusedRowHandle = FormStockTakeDet.GVScan.RowCount - 1
            Close()
        Else
            stopCustom("Data can't blank")
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
        TxtCode.Focus()
    End Sub

    Private Sub FormStockTakeFaik_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtPrice.EditValue = 0
        TxtCode.Text = FormStockTakeDet.TxtScan.Text
        TxtCode.Enabled = False
        ActiveControl = TxtDescription
    End Sub

    Private Sub TxtCode_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtDescription.Focus()
        End If
    End Sub

    Private Sub TxtDescription_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtDescription.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtSize.Focus()
        End If
    End Sub

    Private Sub TxtSize_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtSize.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtPrice.Focus()
        End If
    End Sub

    Private Sub TxtPrice_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPrice.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnSave.Focus()
        End If
    End Sub
End Class