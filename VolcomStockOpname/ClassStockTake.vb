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
        Dim query As String = "SELECT st.id_wh_drawer,st.id_st_period, st.st_period_date, st.st_period_created_date, st.st_period_created_date, 
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
        Dim query As String = "SELECT st.id_wh_drawer, st.remark, c.id_comp,c.comp_number, c.comp_name, CONCAT(c.comp_number,' - ', c.comp_name) AS `comp`, c.address_primary,st.id_st_trans, st.st_trans_number, 
        st.st_trans_date, st.st_trans_by, ep.employee_code AS `prepared_by_code`, ep.employee_name AS `prepared_by`, ep.employee_position AS `prepared_position`, 
        st.st_trans_updated_by, e.employee_code, e.employee_name, 
        st.st_trans_updated, st.is_combine, st.id_report_status, rs.report_status, IFNULL(q.qty,0) AS `qty`, 'No' AS `is_select`, IFNULL(st.id_combine,0) AS `id_combine`, st.acknowledge_by, eack.employee_position AS `ack_position`, st.approved_by
        FROM tb_st_trans st
        INNER JOIN tb_lookup_report_status rs ON rs.id_report_status = st.id_report_status
        LEFT JOIN tb_m_user u ON u.id_user = st.st_trans_updated_by
        LEFT JOIN tb_m_employee e ON e.id_employee = u.id_employee 
        INNER JOIN tb_m_user up ON up.id_user = st.st_trans_by
        INNER JOIN tb_m_employee ep ON ep.id_employee = up.id_employee 
        INNER JOIN tb_m_comp c ON c.id_drawer_def = st.id_wh_drawer
        LEFT JOIN tb_m_user uack ON uack.id_user = st.acknowledge_by
        LEFT JOIN tb_m_employee eack ON eack.id_employee = uack.id_employee 
        LEFT JOIN (
            SELECT SUM(qty) AS `qty`, id_st_trans FROM tb_st_trans_det GROUP BY id_st_trans
        ) q ON q.id_st_trans = st.id_st_trans
        WHERE st.id_st_trans>0 "
        query += condition + " "
        query += "ORDER BY st.id_st_trans " + order_type
        Return query
    End Function

    Public Function queryVerTransMain(ByVal condition As String, ByVal order_type As String) As String
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
        Dim query As String = "SELECT st.id_wh_drawer, st.remark, c.id_comp,c.comp_number, c.comp_name, CONCAT(c.comp_number,' - ', c.comp_name) AS `comp`, c.address_primary,st.id_st_trans_ver, st.id_st_trans, st.st_trans_ver_number, stf.st_trans_number, stf.remark AS `remark_ref`,
        st.st_trans_ver_date, st.st_trans_ver_by, ep.employee_code AS `prepared_by_code`, ep.employee_name AS `prepared_by`, ep.employee_position AS `prepared_position`, 
        st.st_trans_ver_updated_by, e.employee_code, e.employee_name, 
        st.st_trans_ver_updated, st.is_combine, st.id_report_status, rs.report_status, IFNULL(q.qty,0) AS `qty`, 'No' AS `is_select`, IFNULL(st.id_combine,0) AS `id_combine`, st.acknowledge_by, eack.employee_position AS `ack_position`, st.approved_by
        FROM tb_st_trans_ver st
        LEFT JOIN tb_st_trans stf ON stf.id_st_trans = st.id_st_trans
        INNER JOIN tb_lookup_report_status rs ON rs.id_report_status = st.id_report_status
        LEFT JOIN tb_m_user u ON u.id_user = st.st_trans_ver_updated_by
        LEFT JOIN tb_m_employee e ON e.id_employee = u.id_employee 
        INNER JOIN tb_m_user up ON up.id_user = st.st_trans_ver_by
        INNER JOIN tb_m_employee ep ON ep.id_employee = up.id_employee 
        INNER JOIN tb_m_comp c ON c.id_drawer_def = st.id_wh_drawer
        LEFT JOIN tb_m_user uack ON uack.id_user = st.acknowledge_by
        LEFT JOIN tb_m_employee eack ON eack.id_employee = uack.id_employee 
        LEFT JOIN (
            SELECT SUM(qty) AS `qty`, id_st_trans_ver FROM tb_st_trans_ver_det GROUP BY id_st_trans_ver
        ) q ON q.id_st_trans_ver = st.id_st_trans_ver
        WHERE st.id_st_trans_ver>0 "
        query += condition + " "
        query += "ORDER BY st.id_st_trans_ver " + order_type
        Return query
    End Function
End Class
