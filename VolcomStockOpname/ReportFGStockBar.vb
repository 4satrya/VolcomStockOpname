Public Class ReportFGStockBar
    Public Shared comp As String = ""
    Public Shared is_bof As Boolean = False

    Private Sub ReportFGStockBar_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles MyBase.BeforePrint
        Dim query As String = ""
        If Not is_bof Then
            query = "SELECT p.product_full_code AS `barcode`,d.design_code AS `code`, d.design_display_name AS `name`, cd.code_detail_name AS `size`, 
            s.qty, IF(c.id_store_type=1, fd.design_price,s.design_price) AS `design_price`, c.comp_name, c.comp_number
            FROM tb_st_stock s
            INNER JOIN tb_m_product p ON p.id_product = s.id_product
            INNER JOIN tb_m_product_code pc ON pc.id_product = p.id_product
            INNER JOIN tb_m_code_detail cd ON cd.id_code_detail = pc.id_code_detail
            INNER JOIN tb_m_design d ON d.id_design = p.id_design
            INNER JOIN tb_m_comp c ON c.id_drawer_def = s.id_wh_drawer
            LEFT JOIN tb_m_design_first_del fd ON fd.id_design = d.id_design AND fd.id_comp = c.id_comp
            WHERE (" + comp + ") ORDER BY s.id_product ASC "
        Else
            query = "SELECT p.product_full_code AS `barcode`,d.design_code AS `code`, d.design_display_name AS `name`, cd.code_detail_name AS `size`, 
            s.qty, IF(c.id_store_type=1, fd.design_price,s.design_price) AS `design_price`, c.comp_name, c.comp_number
            FROM tb_st_stock s
            INNER JOIN tb_m_product_bof p ON p.id_product = s.id_product
            INNER JOIN tb_m_product_code_bof pc ON pc.id_product = p.id_product
            INNER JOIN tb_m_code_detail cd ON cd.id_code_detail = pc.id_code_detail
            INNER JOIN tb_m_design_bof d ON d.id_design = p.id_design
            INNER JOIN tb_m_comp c ON c.id_drawer_def = s.id_wh_drawer
            LEFT JOIN tb_m_design_first_del_bof fd ON fd.id_design = d.id_design AND fd.id_comp = c.id_comp
            WHERE (" + comp + ") ORDER BY s.id_product ASC "
        End If
        Dim data As DataTable = execute_query(query, -1, False, app_host_main, app_username_main, app_password_main, app_database_main)
        GCRsvBar.DataSource = data
    End Sub
End Class