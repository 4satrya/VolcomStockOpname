Public Class FormRpt
    Public id_pop_up As String = "-1"

    Private Sub FormRpt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewData()
    End Sub

    Private Sub FormRpt_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Sub viewData()
        Cursor = Cursors.WaitCursor
        Dim rpt As New ClassRpt()
        Dim query As String = rpt.queryMain("-1", "2")
        Dim data As DataTable = execute_query(query, -1, False, app_host, app_username, app_password, "db_opt")
        GCData.DataSource = data
        GVData.BestFitColumns()
        Cursor = Cursors.Default
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        viewData()
    End Sub

    Private Sub BtnAddReport_Click(sender As Object, e As EventArgs) Handles BtnAddReport.Click
        Cursor = Cursors.WaitCursor
        FormRptNew.ShowDialog()
        Cursor = Cursors.Default
    End Sub

    Private Sub BtnUse_Click(sender As Object, e As EventArgs) Handles BtnUse.Click
        If id_pop_up = "1" Then
            'stocktake toko/pre stocktake

        ElseIf id_pop_up = "2" Then
            'ver stocktake

        End If
    End Sub
End Class