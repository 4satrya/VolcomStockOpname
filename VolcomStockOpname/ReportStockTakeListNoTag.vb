Public Class ReportStockTakeListNoTag
    Public Shared dt As DataTable = New DataTable

    Private is_login_store As String = "2"

    Private Sub ReportStockTakeListNoTag_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles MyBase.BeforePrint
        Try
            is_login_store = execute_query("SELECT is_login_store FROM tb_opt", 0, False, app_host, app_username, app_password, "db_opt")
        Catch ex As Exception
        End Try

        GCScan.DataSource = dt
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
End Class