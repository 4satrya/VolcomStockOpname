Public Class ReportFGBackupStock
    Public Shared comp As String = ""

    Private Sub ReportFGBackupStock_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles MyBase.BeforePrint
        Dim query As String = "SELECT d.design_code AS `code`, d.design_display_name AS `name`, SUBSTRING(p.product_full_code, 10, 1) AS `sizetype`, "
        Dim bcounter As Integer = 1
        While bcounter <= 10
            If bcounter = 10 Then
                query += "SUM(CASE WHEN SUBSTRING(cd.code,2,1)='0' THEN s.qty  END) `0`, "
            Else
                query += "SUM(CASE WHEN SUBSTRING(cd.code,2,1)='" + bcounter.ToString + "' THEN s.qty  END) `" + bcounter.ToString + "`, "
            End If
            bcounter += 1
        End While
        query += "SUM(s.qty) AS `total_qty` , s.design_price, c.comp_name, c.comp_number
        FROM tb_st_stock s
        INNER JOIN tb_m_product p ON p.id_product = s.id_product
        INNER JOIN tb_m_product_code pc ON pc.id_product = p.id_product
        INNER JOIN tb_m_code_detail cd ON cd.id_code_detail = pc.id_code_detail
        INNER JOIN tb_m_design d ON d.id_design = p.id_design
        INNER JOIN tb_m_comp c ON c.id_drawer_def = s.id_wh_drawer
        WHERE (" + comp + ") GROUP BY p.id_design, SUBSTRING(p.product_full_code, 10, 1) "
        Dim data As DataTable = execute_query(query, -1, False, app_host_main, app_username_main, app_password_main, app_database_main)
        GCRsv.DataSource = data
        GVRsv.Columns("1").Caption = "1" + System.Environment.NewLine + "XXS"
        GVRsv.Columns("2").Caption = "2" + System.Environment.NewLine + "XS"
        GVRsv.Columns("3").Caption = "3" + System.Environment.NewLine + "S"
        GVRsv.Columns("4").Caption = "4" + System.Environment.NewLine + "M"
        GVRsv.Columns("5").Caption = "5" + System.Environment.NewLine + "ML"
        GVRsv.Columns("6").Caption = "6" + System.Environment.NewLine + "L"
        GVRsv.Columns("7").Caption = "7" + System.Environment.NewLine + "XL"
        GVRsv.Columns("8").Caption = "8" + System.Environment.NewLine + "XXL"
        GVRsv.Columns("9").Caption = "9" + System.Environment.NewLine + "ALL"
        GVRsv.Columns("0").Caption = "0" + System.Environment.NewLine + "SM"
        GVRsv.RefreshData()
    End Sub
End Class