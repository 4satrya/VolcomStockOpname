Imports DevExpress.XtraPrinting
Imports MySql.Data.MySqlClient

Public Class FormFGBackupStockDet
    Public id_st_period As String = "-1"
    Public action As String = "ins"

    Private Sub FormFGBackupStockDet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActiveControl = DEStock
        If app_host_main = "" Then
            initialServerCentre()
        End If
        actionLoad()
    End Sub

    Sub actionLoad()
        If action = "ins" Then
            Dim dt As DataTable = execute_query("SELECT DATE(NOW()) AS `date_now` ", -1, False, app_host_main, app_username_main, app_password_main, app_database_main)
            DEStock.EditValue = dt.Rows(0)("date_now")
        ElseIf action = "upd" Then
            BtnOpenFileLoc.Visible = True

            'header
            Dim st As New ClassStockTake()
            Dim query As String = st.queryMain("AND st.id_st_period=" + id_st_period + " ", "1")
            Dim data As DataTable = execute_query(query, -1, False, app_host_main, app_username_main, app_password_main, app_database_main)
            DEStock.EditValue = data.Rows(0)("st_period_date")

            'detail
            viewComp()
        End If
    End Sub

    Sub viewComp()
        Dim date_until_selected As String = "1997-01-01"
        Try
            date_until_selected = DateTime.Parse(DEStock.EditValue.ToString).ToString("yyyy-MM-dd")
        Catch ex As Exception
        End Try
        Dim query As String = "SELECT c.id_comp, c.comp_number, c.comp_name, ('No') AS `is_select`,
        IFNULL(stc.qty,0) As `qty_soh` , c.id_drawer_def, c.id_comp_cat, cat.comp_cat_name AS `comp_cat`
        FROM tb_m_comp c 
        LEFT JOIN (
	        SELECT f.id_wh_drawer,
	        SUM(IF(f.id_stock_status=1, (IF(f.id_storage_category=2, CONCAT('-', f.storage_product_qty), f.storage_product_qty)),0)) AS qty
	        FROM tb_storage_fg f 
	        WHERE DATE(f.storage_product_datetime)<=DATE('" + date_until_selected + "')
	        GROUP BY f.id_wh_drawer
        ) stc ON stc.id_wh_drawer = c.id_drawer_def 
        INNER JOIN tb_m_comp_cat cat ON cat.id_comp_cat = c.id_comp_cat 
        WHERE (c.id_comp_cat=5 Or c.id_comp_cat=6)
        ORDER BY c.comp_number  "
        Dim data As DataTable = execute_query(query, -1, False, app_host_main, app_username_main, app_password_main, app_database_main)
        GCData.DataSource = data
    End Sub

    Private Sub DEStock_EditValueChanged(sender As Object, e As EventArgs) Handles DEStock.EditValueChanged
        Try
            viewComp()
        Catch ex As Exception
            GCData.DataSource = Nothing
        End Try
    End Sub

    Private Sub CESelectAll_CheckedChanged(sender As Object, e As EventArgs) Handles CESelectAll.CheckedChanged
        If GVData.RowCount > 0 Then
            Dim cek As String = CESelectAll.EditValue.ToString
            For i As Integer = 0 To ((GVData.RowCount - 1) - GetGroupRowCount(GVData))
                If cek Then
                    GVData.SetRowCellValue(i, "is_select", "Yes")
                Else
                    GVData.SetRowCellValue(i, "is_select", "No")
                End If
            Next
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim confirm As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure you want to generate database for these data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If confirm = DialogResult.Yes Then
            FormMain.SplashScreenManager1.ShowWaitForm()
            'insert detail
            Dim jum_i As Integer = 0
            Dim comp As String = ""
            Dim comp_u As String = ""
            Dim is_wh As Boolean = False
            For i As Integer = 0 To ((GVData.RowCount - 1) - GetGroupRowCount(GVData))
                If GVData.GetRowCellValue(i, "is_select").ToString = "Yes" Then
                    If jum_i > 0 Then
                        comp += "OR "
                        comp_u += "OR "
                    End If
                    comp += "c.id_drawer_def='" + GVData.GetRowCellValue(i, "id_drawer_def").ToString + "' "
                    comp_u += "f.id_comp='" + GVData.GetRowCellValue(i, "id_comp").ToString + "' "
                    jum_i += 1

                    If GVData.GetRowCellValue(i, "id_comp_cat").ToString = "5" Then
                        is_wh = True
                    End If
                End If
            Next

            'connection string
            Dim date_stock_DB = DateTime.Parse(DEStock.EditValue.ToString).ToString("yyyy-MM-dd")
            Dim date_stock = DateTime.Parse(DEStock.EditValue.ToString).ToString("yyyyMMdd") + "_" + getIdSt()
            Dim constring As String = "server=" + app_host_main + ";user=" + app_username_main + ";pwd=" + app_password_main + ";database=" + app_database_main + ";allow zero datetime=yes;"
            Dim path_root As String = Application.StartupPath + "\download\database\" + date_stock
            'create directory if not exist
            If Not IO.Directory.Exists(path_root) Then
                System.IO.Directory.CreateDirectory(path_root)
            End If


            Dim fileName As String = date_stock + ".sql"
            Dim file As String = IO.Path.Combine(path_root, fileName)
            '-- company/store/wh
            FormMain.SplashScreenManager1.SetWaitFormDescription("Backup master store/wh")
            Dim dic As New Dictionary(Of String, String)()
            dic.Add("tb_m_comp", "SELECT * FROM tb_m_comp c WHERE (" + comp + ") ")
            dic.Add("tb_lookup_store_type", "SELECT * FROM tb_lookup_store_type")
            dic.Add("tb_lookup_wh_type", "SELECT * FROM tb_lookup_wh_type")
            '-- code
            FormMain.SplashScreenManager1.SetWaitFormDescription("Backup master code")
            dic.Add("tb_m_code", "SELECT c.* FROM tb_m_code c 
            INNER JOIN tb_template_code_det tc ON tc.id_code = c.id_code AND (tc.id_template_code=7 OR tc.id_template_code=8 OR tc.id_template_code=12 OR tc.id_template_code=13)
            GROUP BY c.id_code ORDER BY c.id_code ASC")
            dic.Add("tb_m_code_detail", "SELECT cd.* 
            FROM tb_m_code c 
            INNER JOIN tb_template_code_det tc ON tc.id_code = c.id_code AND (tc.id_template_code=7 OR tc.id_template_code=8 OR tc.id_template_code=12 OR tc.id_template_code=13)
            INNER JOIN tb_m_code_detail cd ON cd.id_code = c.id_code
            GROUP BY cd.id_code_detail ORDER BY cd.id_code_detail ASC ")
            '-- range & season
            FormMain.SplashScreenManager1.SetWaitFormDescription("Backup master season")
            dic.Add("tb_range", "SELECT r.* FROM tb_range r ORDER BY r.id_range ASC ")
            dic.Add("tb_season", "SELECT * FROM tb_season s ORDER BY s.id_season ASC ")
            '-- product
            FormMain.SplashScreenManager1.SetWaitFormDescription("Backup master product")
            dic.Add("tb_m_design", "SELECT * FROM tb_m_design")
            dic.Add("tb_m_design_code", "SELECT * FROM tb_m_design_code")
            dic.Add("tb_m_product", "SELECT * FROM tb_m_product")
            dic.Add("tb_m_product_code", "SELECT * FROM tb_m_product_code")
            '-- price
            FormMain.SplashScreenManager1.SetWaitFormDescription("Backup master price")
            dic.Add("tb_lookup_design_cat", "SELECT * FROM tb_lookup_design_cat")
            dic.Add("tb_lookup_design_price_type", "SELECT * FROM tb_lookup_design_price_type")
            dic.Add("tb_m_design_price", "SELECT * FROM tb_m_design_price")
            dic.Add("tb_m_design_first_del", "SELECT * FROM tb_m_design_first_del f WHERE (" + comp_u + ") ")
            '-- user
            FormMain.SplashScreenManager1.SetWaitFormDescription("Backup user data")
            dic.Add("tb_m_user", "SELECT u.* FROM tb_m_user u INNER JOIN tb_st_user s ON s.id_user = u.id_user ")
            dic.Add("tb_m_employee", "SELECT e.* FROM tb_m_user u INNER JOIN tb_st_user s ON s.id_user = u.id_user 
            INNER JOIN tb_m_employee e ON e.id_employee = u.id_employee ")
            dic.Add("tb_st_user", "SELECT s.* FROM tb_st_user s ")
            '-- report status
            FormMain.SplashScreenManager1.SetWaitFormDescription("Backup report status")
            dic.Add("tb_lookup_report_status", "SELECT * FROM tb_lookup_report_status ")
            '-- tb_st_opt
            FormMain.SplashScreenManager1.SetWaitFormDescription("Backup option table")
            dic.Add("tb_st_opt", "SELECT * FROM tb_st_opt ")
            '-- transaction
            FormMain.SplashScreenManager1.SetWaitFormDescription("Creating transaction table")
            dic.Add("tb_st_trans", "SELECT * FROM tb_st_trans ")
            dic.Add("tb_st_trans_det", "SELECT * FROM tb_st_trans_det ")
            dic.Add("tb_st_cat", "SELECT * FROM tb_st_cat ")
            '-- stock
            FormMain.SplashScreenManager1.SetWaitFormDescription("Backup stock")
            execute_non_query("TRUNCATE `tb_st_stock`", False, app_host_main, app_username_main, app_password_main, app_database_main)
            Dim query_ins As String = "
            INSERT INTO tb_st_stock (id_wh_drawer, id_product, qty, id_design_price, design_price)
            SELECT f.id_wh_drawer, f.id_product, 
            SUM(IF(f.id_stock_status=1, (IF(f.id_storage_category=2, CONCAT('-', f.storage_product_qty), f.storage_product_qty)),0)) AS qty, prc.id_design_price,prc.design_price
            FROM tb_storage_fg f 
            INNER JOIN tb_m_comp c ON c.id_drawer_def = f.id_wh_drawer AND (" + comp + ")
            INNER JOIN tb_m_product p ON p.id_product = f.id_product
            LEFT JOIN (
	            SELECT * FROM (
	            SELECT price.id_design, price.id_design_price, price.design_price, price_type.id_design_cat,dc.design_cat
	            FROM tb_m_design_price price 
	            INNER JOIN tb_lookup_design_price_type price_type 
	            ON price.id_design_price_type = price_type.id_design_price_type
	            INNER JOIN  tb_lookup_design_cat dc ON dc.id_design_cat = price_type.id_design_cat
	            INNER JOIN tb_lookup_currency curr ON curr.id_currency = price.id_currency 
	            INNER JOIN tb_m_user `user` ON user.id_user = price.id_user 
	            INNER JOIN tb_m_employee emp ON emp.id_employee = user.id_employee 
	            WHERE price.is_active_wh=1 AND price.design_price_start_date <= DATE('" + date_stock_DB + "')
	            ORDER BY price.design_price_start_date DESC, price.id_design_price DESC ) a
	            GROUP BY a.id_design
            ) prc ON prc.id_design = p.id_design
            WHERE DATE(f.storage_product_datetime)<=DATE('" + date_stock_DB + "')
            GROUP BY f.id_wh_drawer, f.id_product 
            HAVING qty>0"
            execute_non_query(query_ins, False, app_host_main, app_username_main, app_password_main, app_database_main)
            dic.Add("tb_st_stock", "SELECT * FROM tb_st_stock")
            '-- unique
            execute_non_query("TRUNCATE `tb_st_unique`", False, app_host_main, app_username_main, app_password_main, app_database_main)
            Dim query_ins_unique As String = " INSERT INTO tb_st_unique (id_product,id_comp, unique_code) 
            SELECT a.id_product, b.id_comp,(a.product_code_unique) AS product_full_code
            FROM(
	            SELECT a.id_pl_prod_order_rec_det_unique, a.id_product, d.product_full_code,CONCAT(d.product_full_code, a.pl_prod_order_rec_det_counting) AS product_code_unique, 
	            (a.pl_prod_order_rec_det_counting) AS product_counting_code,
	            COUNT(CONCAT(d.product_full_code, a.pl_prod_order_rec_det_counting)) AS jum_rec, a.bom_unit_price
	            FROM tb_pl_prod_order_rec_det_counting a
	            INNER JOIN tb_pl_prod_order_rec_det b ON a.id_pl_prod_order_rec_det = b.id_pl_prod_order_rec_det
	            INNER JOIN tb_pl_prod_order_rec c ON c.id_pl_prod_order_rec = b.id_pl_prod_order_rec
	            INNER JOIN tb_m_product d ON d.id_product = a.id_product
	            INNER JOIN tb_m_design dsg ON dsg.id_design = d.id_design
	            WHERE c.id_report_status = 6
	            AND dsg.is_old_design = 2
	            GROUP BY CONCAT(d.product_full_code, a.pl_prod_order_rec_det_counting)
            ) a
            LEFT JOIN (
	            SELECT a.id_pl_prod_order_rec_det_unique, b.id_product, d.product_full_code, CONCAT(d.product_full_code, a.pl_sales_order_del_det_counting) AS product_code_unique,
	            (a.pl_sales_order_del_det_counting) AS product_counting_code,
	            COUNT(CONCAT(d.product_full_code, a.pl_sales_order_del_det_counting)) AS jum_del, c.id_report_status, f.id_comp
	            FROM tb_pl_sales_order_del_det_counting a
	            INNER JOIN tb_pl_sales_order_del_det b ON a.id_pl_sales_order_del_det = b.id_pl_sales_order_del_det
	            INNER JOIN tb_pl_sales_order_del c ON c.id_pl_sales_order_del = b.id_pl_sales_order_del
	            INNER JOIN tb_m_product d ON d.id_product = b.id_product
	            INNER JOIN tb_m_design dsg ON dsg.id_design = d.id_design
	            INNER JOIN tb_m_comp_contact e ON e.id_comp_contact = c.id_store_contact_to
	            INNER JOIN tb_m_comp f ON f.id_comp = e.id_comp 
	            WHERE c.id_report_status !=5
	            AND (" + comp_u + ")
	            AND dsg.is_old_design = 2
	            GROUP BY CONCAT(d.product_full_code, a.pl_sales_order_del_det_counting)
            ) b ON a.id_pl_prod_order_rec_det_unique = b.id_pl_prod_order_rec_det_unique
            LEFT JOIN (
	            SELECT a.id_pl_prod_order_rec_det_unique, b.id_product, d.product_full_code, CONCAT(d.product_full_code, a.sales_return_det_counting) AS product_code_unique,
	            (a.sales_return_det_counting) AS product_counting_code,
	            COUNT(CONCAT(d.product_full_code, a.sales_return_det_counting)) AS jum_ret, f.id_comp
	            FROM tb_sales_return_det_counting a
	            INNER JOIN tb_sales_return_det b ON a.id_sales_return_det = b.id_sales_return_det
	            INNER JOIN tb_sales_return c ON c.id_sales_return = b.id_sales_return
	            INNER JOIN tb_m_product d ON d.id_product = b.id_product
	            INNER JOIN tb_m_design dsg ON dsg.id_design = d.id_design
	            INNER JOIN tb_m_comp_contact e ON e.id_comp_contact = c.id_store_contact_from
	            INNER JOIN tb_m_comp f ON f.id_comp = e.id_comp 
	            WHERE c.id_report_status !=5
	            AND  (" + comp_u + ")
	            AND dsg.is_old_design = 2
	            GROUP BY CONCAT(d.product_full_code, a.sales_return_det_counting)
            )c ON a.id_pl_prod_order_rec_det_unique = c.id_pl_prod_order_rec_det_unique
            WHERE (a.jum_rec + ( CONCAT('-', COALESCE(b.jum_del, 0)) + COALESCE(c.jum_ret, 0) )) = 0 "
            If is_wh Then
                query_ins_unique += "UNION ALL 
                SELECT a.id_product, null as `id_comp`,(a.product_code_unique) AS product_full_code
                FROM(
	                SELECT a.id_pl_prod_order_rec_det_unique, a.id_product, d.product_full_code,CONCAT(d.product_full_code, a.pl_prod_order_rec_det_counting) AS product_code_unique, 
	                (a.pl_prod_order_rec_det_counting) AS product_counting_code,
	                COUNT(CONCAT(d.product_full_code, a.pl_prod_order_rec_det_counting)) AS jum_rec, 
	                a.bom_unit_price
	                FROM tb_pl_prod_order_rec_det_counting a
	                INNER JOIN tb_pl_prod_order_rec_det b ON a.id_pl_prod_order_rec_det = b.id_pl_prod_order_rec_det
	                INNER JOIN tb_pl_prod_order_rec c ON c.id_pl_prod_order_rec = b.id_pl_prod_order_rec
	                INNER JOIN tb_m_product d ON d.id_product = a.id_product
	                INNER JOIN tb_m_design dsg ON dsg.id_design = d.id_design
	                WHERE c.id_report_status = '6' AND (a.id_product>0 )
	                AND dsg.is_old_design = '2'
	                GROUP BY a.id_pl_prod_order_rec_det_unique
                ) a
                LEFT JOIN (
	                SELECT a.id_pl_prod_order_rec_det_unique, b.id_product, d.product_full_code, CONCAT(d.product_full_code, a.pl_sales_order_del_det_counting) AS product_code_unique,
	                (a.pl_sales_order_del_det_counting) AS product_counting_code,
	                COUNT(CONCAT(d.product_full_code, a.pl_sales_order_del_det_counting)) AS jum_del
	                FROM tb_pl_sales_order_del_det_counting a
	                INNER JOIN tb_pl_sales_order_del_det b ON a.id_pl_sales_order_del_det = b.id_pl_sales_order_del_det
	                INNER JOIN tb_pl_sales_order_del c ON c.id_pl_sales_order_del = b.id_pl_sales_order_del
	                INNER JOIN tb_m_product d ON d.id_product = b.id_product
	                INNER JOIN tb_m_design dsg ON dsg.id_design = d.id_design
	                WHERE c.id_report_status !='5' AND (b.id_product>0 )
	                AND dsg.is_old_design = '2'
	                GROUP BY a.id_pl_prod_order_rec_det_unique
                ) b ON a.id_pl_prod_order_rec_det_unique = b.id_pl_prod_order_rec_det_unique
                LEFT JOIN (
	                SELECT a.id_pl_prod_order_rec_det_unique, b.id_product, d.product_full_code, CONCAT(d.product_full_code, a.sales_return_det_counting) AS product_code_unique,
	                (a.sales_return_det_counting) AS product_counting_code,
	                COUNT(CONCAT(d.product_full_code, a.sales_return_det_counting)) AS jum_ret
	                FROM tb_sales_return_det_counting a
	                INNER JOIN tb_sales_return_det b ON a.id_sales_return_det = b.id_sales_return_det
	                INNER JOIN tb_sales_return c ON c.id_sales_return = b.id_sales_return
	                INNER JOIN tb_m_product d ON d.id_product = b.id_product
	                INNER JOIN tb_m_design dsg ON dsg.id_design = d.id_design
	                WHERE c.id_report_status !='5' AND (b.id_product>0 )
	                AND dsg.is_old_design = '2'
	                GROUP BY a.id_pl_prod_order_rec_det_unique
                )c ON a.id_pl_prod_order_rec_det_unique = c.id_pl_prod_order_rec_det_unique
                LEFT JOIN (
	                SELECT a.id_pl_prod_order_rec_det_unique, b.id_product, d.product_full_code, CONCAT(d.product_full_code, a.fg_woff_det_counting) AS product_code_unique,
	                (a.fg_woff_det_counting) AS product_counting_code,
	                COUNT(CONCAT(d.product_full_code, a.fg_woff_det_counting)) AS jum_woff
	                FROM tb_fg_woff_det_counting a
	                INNER JOIN tb_fg_woff_det b ON a.id_fg_woff_det = b.id_fg_woff_det
	                INNER JOIN tb_fg_woff c ON c.id_fg_woff = b.id_fg_woff
	                INNER JOIN tb_m_product d ON d.id_product = b.id_product
	                INNER JOIN tb_m_design dsg ON dsg.id_design = d.id_design
	                WHERE c.id_report_status !='5' AND (b.id_product>0 )
	                AND dsg.is_old_design = '2'
	                GROUP BY a.id_pl_prod_order_rec_det_unique
                )d ON a.id_pl_prod_order_rec_det_unique = d.id_pl_prod_order_rec_det_unique
                LEFT JOIN (
	                SELECT a.id_pl_prod_order_rec_det_unique, a.id_product, d.product_full_code, CONCAT(d.product_full_code, a.fg_repair_det_counting) AS product_code_unique,
	                (a.fg_repair_det_counting) AS product_counting_code,
	                COUNT(CONCAT(d.product_full_code, a.fg_repair_det_counting)) AS jum_repair
	                FROM tb_fg_repair_det a
	                INNER JOIN tb_fg_repair b ON b.id_fg_repair = a.id_fg_repair
	                INNER JOIN tb_m_product d ON d.id_product = a.id_product
	                INNER JOIN tb_m_design dsg ON dsg.id_design = d.id_design
	                WHERE 
	                b.id_report_status !='5' 
	                AND (a.id_product>0 )
	                AND dsg.is_old_design = '2'
	                GROUP BY a.id_pl_prod_order_rec_det_unique
                )e ON a.id_pl_prod_order_rec_det_unique = e.id_pl_prod_order_rec_det_unique
                LEFT JOIN (
	                SELECT a.id_pl_prod_order_rec_det_unique, a.id_product, d.product_full_code, CONCAT(d.product_full_code, a.fg_repair_return_rec_det_counting) AS product_code_unique,
	                (a.fg_repair_return_rec_det_counting) AS product_counting_code,
	                COUNT(CONCAT(d.product_full_code, a.fg_repair_return_rec_det_counting)) AS jum_rec_repair
	                FROM tb_fg_repair_return_rec_det a
	                INNER JOIN tb_fg_repair_return_rec b ON b.id_fg_repair_return_rec = a.id_fg_repair_return_rec
	                INNER JOIN tb_m_product d ON d.id_product = a.id_product
	                INNER JOIN tb_m_design dsg ON dsg.id_design = d.id_design
	                WHERE 
	                b.id_report_status ='6' 
	                AND (a.id_product>0 )
	                AND dsg.is_old_design = '2'
	                GROUP BY a.id_pl_prod_order_rec_det_unique
                )f ON a.id_pl_prod_order_rec_det_unique = f.id_pl_prod_order_rec_det_unique
                LEFT JOIN (
	                SELECT a.id_pl_prod_order_rec_det_unique, a.id_product, d.product_full_code, CONCAT(d.product_full_code, a.counting_code) AS product_code_unique,
	                (a.counting_code) AS product_counting_code,
	                COUNT(CONCAT(d.product_full_code, a.counting_code)) AS jum_prob, a.report_mark_type
	                FROM tb_fg_unique_problem a
	                INNER JOIN tb_m_product d ON d.id_product = a.id_product
	                INNER JOIN tb_m_design dsg ON dsg.id_design = d.id_design
	                WHERE 1=1
	                AND (a.id_product>0 )
	                AND dsg.is_old_design = '2'
	                GROUP BY a.id_pl_prod_order_rec_det_unique
                )p ON a.id_pl_prod_order_rec_det_unique = p.id_pl_prod_order_rec_det_unique
                WHERE (a.jum_rec + ( CONCAT('-', COALESCE(b.jum_del, 0)) + COALESCE(c.jum_ret, 0) ) - COALESCE(d.jum_woff, 0) - COALESCE(e.jum_repair, 0)+ COALESCE(f.jum_rec_repair, 0) + (COALESCE(IF(p.report_mark_type=37 OR p.report_mark_type=46 OR p.report_mark_type=94, CONCAT('+',p.jum_prob), CONCAT('-',p.jum_prob)), 0)) ) = '1' "
            End If
            execute_non_query(query_ins_unique, False, app_host_main, app_username_main, app_password_main, app_database_main)
            dic.Add("tb_st_unique", "SELECT * FROM tb_st_unique")

            'dump
            FormMain.SplashScreenManager1.SetWaitFormDescription("Creating dump")
            Using conn As New MySqlConnection(constring)
                Using cmd As New MySqlCommand()
                    Using mb As New MySqlBackup(cmd)
                        cmd.Connection = conn
                        conn.Open()
                        mb.ExportInfo.AddCreateDatabase = False
                        mb.ExportInfo.ExportTableStructure = True
                        mb.ExportInfo.ExportRows = True
                        mb.ExportInfo.TablesToBeExportedDic = dic
                        mb.ExportInfo.ExportProcedures = False
                        mb.ExportInfo.ExportFunctions = False
                        mb.ExportInfo.ExportTriggers = False
                        mb.ExportInfo.ExportEvents = False
                        mb.ExportInfo.ExportViews = False
                        mb.ExportInfo.EnableEncryption = True
                        mb.ExportInfo.EncryptionPassword = "csmtafc"
                        mb.ExportToFile(file)
                    End Using
                End Using
            End Using

            'create pdf
            FormMain.SplashScreenManager1.SetWaitFormDescription("Creating pdf report")
            Dim fileNamePdf As String = date_stock + ".pdf"
            Dim reportPath As String = IO.Path.Combine(path_root, fileNamePdf)
            ReportFGBackupStock.comp = comp
            Using report As New ReportFGBackupStock()

                ' Specify PDF-specific export options.
                Dim pdfOptions As PdfExportOptions = report.ExportOptions.Pdf

                ' Specify the pages to be exported.
                'pdfOptions.PageRange = "1, 3-5"

                ' Specify the quality of exported images.
                pdfOptions.ConvertImagesToJpeg = False
                pdfOptions.ImageQuality = PdfJpegImageQuality.Medium

                ' Specify the PDF/A-compatibility.
                pdfOptions.PdfACompatibility = PdfACompatibility.PdfA2b

                ' The following options are not compatible with PDF/A.
                ' The use of these options will result in errors on PDF validation.
                'pdfOptions.NeverEmbeddedFonts = "Tahoma;Courier New";
                'pdfOptions.ShowPrintDialogOnOpen = true;

                ' If required, you can specify the security and signature options. 
                'pdfOptions.PasswordSecurityOptions
                'pdfOptions.SignatureOptions

                ' If required, specify necessary metadata and attachments
                ' (e.g., to produce a ZUGFeRD-compatible PDF).
                'pdfOptions.AdditionalMetadata
                'pdfOptions.Attachments

                ' Specify the document options.
                pdfOptions.DocumentOptions.Application = "Volcom ERP"
                pdfOptions.DocumentOptions.Author = "PT Volcom Indonesia"
                pdfOptions.DocumentOptions.Keywords = "SOH, Stock Take, PDF"
                'pdfOptions.DocumentOptions.Producer = Environment.UserName.ToString()
                pdfOptions.DocumentOptions.Subject = "Data SOH Stock Take : " + date_stock
                pdfOptions.DocumentOptions.Title = "SOH Stock Take : " + date_stock

                ' Checks the validity of PDF export options 
                ' and return a list of any detected inconsistencies.
                'Dim result As IList(Of String) = pdfOptions.Validate()
                'If result.Count > 0 Then
                '    Console.WriteLine(String.Join(Environment.NewLine, result))
                'Else
                '    report.ExportToPdf(reportPath, pdfOptions)
                'End If
                report.ExportToPdf(reportPath, pdfOptions)
            End Using

            'create xls
            FormMain.SplashScreenManager1.SetWaitFormDescription("Creating xls report")
            Dim fileNameXls As String = date_stock + ".xls"
            Dim reportPathXls As String = IO.Path.Combine(path_root, fileNameXls)
            ReportFGBackupStock.comp = comp
            Dim reportxls As New ReportFGBackupStock()
            'Specify XLS-specific export options.
            Dim xlsOptions As XlsExportOptions = reportxls.ExportOptions.Xls
            xlsOptions.ExportHyperlinks = False
            xlsOptions.ExportMode = XlsExportMode.SingleFile
            reportxls.ExportToXls(reportPathXls, xlsOptions)

            FormMain.SplashScreenManager1.CloseWaitForm()
            openFile("\" + date_stock)
        End If
    End Sub

    Private Sub XTCDetail_Click(sender As Object, e As EventArgs) Handles XTCDetail.Click

    End Sub

    Private Sub BtnOpenFileLoc_Click(sender As Object, e As EventArgs) Handles BtnOpenFileLoc.Click
        openFile("")
    End Sub

    Sub openFile(ByVal additional As String)
        Cursor = Cursors.WaitCursor
        Dim path_root As String = Application.StartupPath + "\download\database" + additional
        Process.Start(path_root)
        Cursor = Cursors.Default
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Cursor = Cursors.WaitCursor
        FormDatabase.showx = True
        FormDatabase.ShowDialog()
        Cursor = Cursors.Default
    End Sub
End Class