Public Class ClassRpt
    Public Function queryMain(ByVal condition As String, ByVal order_type As String) As String
        If order_type = "1" Then
            order_type = "ASC "
        ElseIf order_type = "2" Then
            order_type = "DESC "
        End If

        If condition <> "-1" Then
            condition = condition
        Else
            condition = ""
        End If
        Dim query As String = "SELECT r.id_rpt, r.rpt_created_by, r.rpt_created_date, r.rpt_number, r.rpt_note,
        r.report_status, r.report_status_note
        FROM tb_rpt r
        WHERE r.id_rpt>0 "
        query += condition + " "
        query += "ORDER BY r.id_rpt " + order_type
        Return query
    End Function
End Class
