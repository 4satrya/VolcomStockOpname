﻿Public Class FormStockTakeListUnReg
    Private is_login_store As String = "2"

    Private Sub FormStockTakeListUnReg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            is_login_store = execute_query("SELECT is_login_store FROM tb_opt", 0, False, app_host, app_username, app_password, "db_opt")
        Catch ex As Exception
        End Try

        Dim query As String = "
            SELECT 0 AS number, nt.un_reg_number, nt.remark, nt_det.code, nt_det.name, nt_det.size, 1 AS qty
            FROM tb_st_un_reg_det AS nt_det
            LEFT JOIN tb_st_un_reg AS nt ON nt_det.id_st_un_reg = nt.id_st_un_reg
            WHERE nt.id_report_status != 5
        "

        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")

        GCScan.DataSource = data

        GVScan.BestFitColumns()

        If is_login_store = "1" Then
            GVScan.Columns("remark").Caption = "Lokasi"
        End If
    End Sub

    Private Sub GVScan_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GVScan.CustomColumnDisplayText
        If e.Column.FieldName = "number" Then
            e.DisplayText = (e.ListSourceRowIndex + 1).ToString()
        End If
    End Sub

    Private Sub GVScan_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GVScan.RowCellStyle
        If is_login_store = "1" Then
            e.Appearance.BackColor = Color.LightPink
        End If
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        print()
    End Sub

    Private Sub FormStockTakeListUnReg_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F4 Then
            print()
        End If
    End Sub

    Sub print()
        Dim data As DataTable = execute_query("
            SELECT comp_number, comp_display_name, address_primary
            FROM tb_m_comp
        ", -1, True, "", "", "", "")

        GVScan.BestFitColumns()
        ReportStockTakeListNoTag.dt = GCScan.DataSource
        Dim Report As New ReportStockTakeListNoTag()

        Report.XrLabel1.Text = "Un-Reg"

        Report.LabelOutlet.Text = data.Rows(0)("comp_number").ToString + " - " + data.Rows(0)("comp_display_name").ToString
        Report.LabelAlamat.Text = data.Rows(0)("address_primary").ToString

        ' '... 
        ' ' creating and saving the view's layout to a new memory stream 
        Dim str As System.IO.Stream
        str = New System.IO.MemoryStream()
        GVScan.SaveLayoutToStream(str, DevExpress.Utils.OptionsLayoutBase.FullLayout)
        str.Seek(0, System.IO.SeekOrigin.Begin)
        Report.GVScan.RestoreLayoutFromStream(str, DevExpress.Utils.OptionsLayoutBase.FullLayout)
        str.Seek(0, System.IO.SeekOrigin.Begin)

        'Grid Detail
        ReportStyleGridview(Report.GVScan)

        'Show the report's preview. 
        Dim Tool As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Report)
        Tool.ShowPreviewDialog()
    End Sub
End Class