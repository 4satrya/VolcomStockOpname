﻿Imports System.Media

Public Class FormStockTakeFaik
    Public id_pop_up As String = "-1"

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
        'checedit reject
        Dim is_reject As String = ""
        If id_pop_up = "-1" Then
            If FormStockTakeDet.CheckEditReject.EditValue.ToString = "True" Then
                is_reject = "1"
            Else
                is_reject = "2"
            End If
        ElseIf id_pop_up = "1" Then
            If FormVerStockTakeDet.CheckEditReject.EditValue.ToString = "True" Then
                is_reject = "1"
            Else
                is_reject = "2"
            End If
        End If


        'checkedit no tag
        Dim is_no_tag As String = ""
        If id_pop_up = "-1" Then
            If FormStockTakeDet.CheckEditNoTag.EditValue.ToString = "True" Then
                is_no_tag = "1"
            Else
                is_no_tag = "2"
            End If
        ElseIf id_pop_up = "1" Then
            If FormVerStockTakeDet.CheckEditNoTag.EditValue.ToString = "True" Then
                is_no_tag = "1"
            Else
                is_no_tag = "2"
            End If
        End If


        If code <> "" And description <> "" And size <> "" Then
            If id_pop_up = "-1" Then
                Dim query_ins As String = "INSERT INTO tb_st_trans_det(id_st_trans, is_ok, is_no_stock, is_no_master, is_sale, is_reject, is_unique_not_found, is_no_tag, code, name, size, qty, design_price) 
                VALUES ('" + FormStockTakeDet.id_st_trans + "', '2', '2', '1', '2','" + is_reject + "', '2','" + is_no_tag + "','" + code + "', '" + description + "','" + size + "', 1, '" + price + "') "
                execute_non_query(query_ins, True, "", "", "", "")
                FormStockTakeDet.updatedBy()
                FormStockTakeDet.viewDetail()
                FormStockTakeDet.GVScan.FocusedRowHandle = FormStockTakeDet.GVScan.RowCount - 1
            ElseIf id_pop_up = "1" Then
                Dim query_ins As String = "INSERT INTO tb_st_trans_ver_det(id_st_trans_ver, is_not_match, is_ok, is_no_stock, is_no_master, is_sale, is_reject, is_unique_not_found, is_no_tag, code, name, size, qty, design_price) 
                VALUES ('" + FormVerStockTakeDet.id_st_trans_ver + "','1', '2', '2', '1', '2','" + is_reject + "', '2','" + is_no_tag + "','" + code + "', '" + description + "','" + size + "', 1, '" + price + "') "
                execute_non_query(query_ins, True, "", "", "", "")
                FormVerStockTakeDet.updatedBy()
                FormVerStockTakeDet.viewDetail()
                FormVerStockTakeDet.GVScan.FocusedRowHandle = FormVerStockTakeDet.GVScan.RowCount - 1
            End If
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
        If id_pop_up = "-1" Then
            TxtCode.Text = FormStockTakeDet.TxtScan.Text
        ElseIf id_pop_up = "1" Then
            TxtCode.Text = FormVerStockTakeDet.TxtScan.Text
        End If
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