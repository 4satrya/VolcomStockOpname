Public Class ReportCompare
    Public Shared id_report As String = "-1"
    Public Shared dt As DataTable

    Private Sub ReportCompare_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles MyBase.BeforePrint
        GCCompare.DataSource = dt
    End Sub
End Class