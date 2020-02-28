Public Class ReportRpt
    Public Shared dt As DataTable

    Private Sub ReportRpt_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles MyBase.BeforePrint
        GCRpt.DataSource = dt
    End Sub

    Private Sub GVRpt_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GVRpt.CustomColumnDisplayText

    End Sub

    Private Sub BGVRpt_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles BGVRpt.CustomColumnDisplayText
        If e.Column.FieldName = "no" Then
            e.DisplayText = (e.ListSourceRowIndex + 1).ToString()
        ElseIf e.Column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric Then
            Dim qty As Decimal = Convert.ToDecimal(e.Value)
            If qty = 0 Then
                e.DisplayText = "-"
            End If
        End If
    End Sub
End Class