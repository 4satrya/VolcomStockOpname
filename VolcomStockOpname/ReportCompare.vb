Public Class ReportCompare
    Public Shared id_report As String = "-1"
    Public Shared dt As DataTable

    Private Sub ReportCompare_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles MyBase.BeforePrint
        GCCompare.DataSource = dt
    End Sub

    Private Sub BGVCompare_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles BGVCompare.CustomColumnDisplayText
        If e.Column.FieldName = "no" Then
            e.DisplayText = (e.ListSourceRowIndex + 1).ToString()
        ElseIf (e.Column.FieldName = "qty_soh" Or e.Column.FieldName = "qty_scan" Or e.Column.FieldName = "val_soh" Or e.Column.FieldName = "val_scan" Or e.Column.FieldName = "qty_diff" Or e.Column.FieldName = "val_diff") Then
            Dim qty As Decimal = Convert.ToDecimal(e.Value)
            If qty = 0 Then
                e.DisplayText = "-"
            End If
        End If
    End Sub
End Class