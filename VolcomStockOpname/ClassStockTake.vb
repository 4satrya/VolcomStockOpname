Public Class ClassStockTake
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
        Dim query As String = "SELECT st.id_st_period, st.st_period_date, st.st_period_created_date, st.st_period_created_date, 
        st.st_period_update_date, st.st_period_update_by, e.employee_name, st.st_period_description 
        FROM tb_st_period st 
        INNER JOIN tb_m_user u ON u.id_user = st.st_period_update_by
        INNER JOIN tb_m_employee e ON e.id_employee = u.id_employee
        WHERE st.id_st_period>0 "
        query += condition + " "
        query += "ORDER BY st.id_st_period " + order_type
        Return query
    End Function

    Public Function queryTransMain(ByVal condition As String, ByVal order_type As String) As String
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
        Dim query As String = "SELECT st.id_st_trans, st.st_trans_number, st.st_trans_date, 
        st.st_trans_updated_by, e.employee_code, e.employee_name, 
        st.st_trans_updated, st.is_combine, st.id_report_status, rs.report_status
        FROM tb_st_trans st
        INNER JOIN tb_lookup_report_status rs ON rs.id_report_status = st.id_report_status
        INNER JOIN tb_m_user u ON u.id_user = st.st_trans_updated_by
        INNER JOIN tb_m_employee e ON e.id_employee = u.id_employee "
        query += condition + " "
        query += "ORDER BY st.id_st_trans " + order_type
        Return query
    End Function
End Class
