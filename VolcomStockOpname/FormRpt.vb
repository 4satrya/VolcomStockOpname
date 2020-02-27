Public Class FormRpt
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
End Class