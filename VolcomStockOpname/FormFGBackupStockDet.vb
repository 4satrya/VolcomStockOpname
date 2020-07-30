Imports System.Data.OleDb
Imports System.IO
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
            DESalesUntil.EditValue = dt.Rows(0)("date_now")
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
        ' kalo uda full erp
        'Dim query As String = "SELECT c.id_comp, c.comp_number, c.comp_name, c.address_primary, ('No') AS `is_select`,
        'IFNULL(stc.qty,0) As `qty_soh` , c.id_drawer_def, c.id_comp_cat, cat.comp_cat_name AS `comp_cat`
        'FROM tb_m_comp c 
        'LEFT JOIN (
        ' SELECT f.id_wh_drawer,
        ' SUM(IF(f.id_stock_status=1, (IF(f.id_storage_category=2, CONCAT('-', f.storage_product_qty), f.storage_product_qty)),0)) AS qty
        ' FROM tb_storage_fg f 
        ' WHERE DATE(f.storage_product_datetime)<=DATE('" + date_until_selected + "')
        ' GROUP BY f.id_wh_drawer
        ') stc ON stc.id_wh_drawer = c.id_drawer_def 
        'INNER JOIN tb_m_comp_cat cat ON cat.id_comp_cat = c.id_comp_cat 
        'WHERE (c.id_comp_cat=5 Or c.id_comp_cat=6)
        'ORDER BY c.comp_number  "
        Dim query As String = "SELECT c.id_comp, c.id_store, c.comp_number, c.comp_name, c.address_primary, ('No') AS `is_select`,
        0 As `qty_soh` , c.id_drawer_def, c.id_comp_cat, cat.comp_cat_name AS `comp_cat`
        FROM tb_m_comp c 
        INNER JOIN tb_m_comp_cat cat ON cat.id_comp_cat = c.id_comp_cat 
        WHERE (c.id_comp_cat=5 Or c.id_comp_cat=6) AND c.is_only_for_alloc=2
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

    'download data
    Sub downloadDB(ByVal is_bof As Boolean)
        makeSafeGV(GVData)
        GVData.ActiveFilterString = "[is_select]='Yes'"
        If GVData.RowCount <= 0 Then
            stopCustom("Please select account first")
            GVData.ActiveFilterString = ""
        Else
            Dim is_mapping_store As Boolean = True

            For i As Integer = 0 To ((GVData.RowCount - 1) - GetGroupRowCount(GVData))
                If GVData.GetRowCellValue(i, "is_select").ToString = "Yes" Then
                    If GVData.GetRowCellValue(i, "id_comp_cat").ToString = "6" And GVData.GetRowCellValue(i, "id_store").ToString = "" Then
                        is_mapping_store = False
                    End If
                End If
            Next

            If is_mapping_store Then
                Dim confirm As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure you want to generate database for these data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
                If confirm = DialogResult.Yes Then
                    FormMain.SplashScreenManager1.ShowWaitForm()
                    'insert detail
                    Dim jum_i As Integer = 0
                    Dim comp As String = ""
                    Dim comp_u As String = ""
                    Dim id_comp_bof As String = ""
                    Dim is_wh As Boolean = False
                    Dim qfd As String = ""
                    Dim comp_in As String = ""
                    Dim id_store As String = ""
                    For i As Integer = 0 To ((GVData.RowCount - 1) - GetGroupRowCount(GVData))
                        If GVData.GetRowCellValue(i, "is_select").ToString = "Yes" Then
                            If jum_i > 0 Then
                                comp += "OR "
                                comp_u += "OR "
                                qfd += "UNION ALL "
                                comp_in += ","
                            End If
                            comp += "c.id_drawer_def='" + GVData.GetRowCellValue(i, "id_drawer_def").ToString + "' "
                            comp_u += "f.id_comp='" + GVData.GetRowCellValue(i, "id_comp").ToString + "' "
                            id_comp_bof = GVData.GetRowCellValue(i, "id_comp").ToString
                            qfd += "SELECT d.id_design, '" + GVData.GetRowCellValue(i, "id_comp").ToString + "' AS `id_comp`, NULL AS `id_pl_sales_order_del`, np.id_design_price, np.design_price,NOW()
                        FROM tb_m_design d
                        LEFT JOIN (
                          SELECT * FROM (
                             SELECT prc.id_design, prc.id_design_price,prc.design_price 
                             FROM tb_m_design_price prc
                             WHERE prc.id_design_price_type=1 AND prc.design_price_start_date<=NOW()
                             ORDER BY prc.design_price_start_date DESC, prc.id_design_price DESC
                          ) p
                          GROUP BY p.id_design
                        ) np ON np.id_design = d.id_design
                        WHERE d.id_lookup_status_order!=2 AND !ISNULL(np.id_design_price) "
                            comp_in += GVData.GetRowCellValue(i, "id_comp").ToString
                            jum_i += 1

                            If GVData.GetRowCellValue(i, "id_comp_cat").ToString = "5" Then
                                is_wh = True
                            End If

                            id_store = GVData.GetRowCellValue(i, "id_store").ToString
                        End If
                    Next

                    'cari gudang induk
                    Dim comp_grp As String = execute_query("SELECT GROUP_CONCAT(DISTINCT c.id_comp) AS `comp` FROM tb_m_comp c WHERE c.id_wh_group=" + comp_in + "", 0, False, app_host_main, app_username_main, app_password_main, app_database_main)
                    If comp_grp <> "" Then
                        comp_in = comp_grp
                    End If
                    Dim id_drawer_def As String = GVData.GetFocusedRowCellValue("id_drawer_def")

                    'connection string
                    Dim date_stock_DB = DateTime.Parse(DEStock.EditValue.ToString).ToString("yyyy-MM-dd")
                    Dim date_sales_DB = DateTime.Parse(DESalesUntil.EditValue.ToString).ToString("yyyy-MM-dd")
                    Dim is_record_unreg As String = ""
                    If CEManualRecord.Checked = True Then
                        is_record_unreg = "1"
                    Else
                        is_record_unreg = "2"
                    End If
                    Dim date_stock = DateTime.Parse(DEStock.EditValue.ToString).ToString("yyyyMMdd") + "_" + getIdSt()
                    Dim constring As String = "server=" + app_host_main + ";user=" + app_username_main + ";pwd=" + app_password_main + ";database=" + app_database_main + ";allow zero datetime=yes;"
                    Dim path_root As String = Application.StartupPath + "\download\database\" + date_stock
                    'create directory if not exist
                    If Not IO.Directory.Exists(path_root) Then
                        System.IO.Directory.CreateDirectory(path_root)
                    End If


                    Dim fileName As String = date_stock + ".sql"
                    Dim file As String = IO.Path.Combine(path_root, fileName)

                    If is_bof Then
                        '-- processing bof xls
                        FormMain.SplashScreenManager1.SetWaitFormDescription("Processing XLS bof")
                        load_excel_data(id_comp_bof)
                        FormMain.SplashScreenManager1.CloseWaitForm()
                        FormMain.SplashScreenManager1.ShowWaitForm()
                    End If


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
                    If Not is_bof Then
                        dic.Add("tb_m_design", "SELECT * FROM tb_m_design")
                        dic.Add("tb_m_design_code", "SELECT * FROM tb_m_design_code")
                        dic.Add("tb_m_product", "SELECT * FROM tb_m_product")
                        dic.Add("tb_m_product_code", "SELECT * FROM tb_m_product_code")
                    Else
                        dic.Add("tb_m_design", "SELECT * FROM tb_m_design_bof")
                        dic.Add("tb_m_product", "SELECT * FROM tb_m_product_bof")
                        dic.Add("tb_m_product_code", "SELECT * FROM tb_m_product_code_bof")
                    End If
                    '-- price
                    FormMain.SplashScreenManager1.SetWaitFormDescription("Backup master price")
                    dic.Add("tb_lookup_design_cat", "SELECT * FROM tb_lookup_design_cat")
                    dic.Add("tb_lookup_design_price_type", "SELECT * FROM tb_lookup_design_price_type")
                    If Not is_bof Then
                        dic.Add("tb_m_design_price", "SELECT * FROM tb_m_design_price")

                        'fist delivery
                        Dim query_fd As String = "TRUNCATE tb_m_design_first_del_erp; INSERT INTO tb_m_design_first_del_erp(id_design, id_comp, id_pl_sales_order_del, id_design_price, design_price, input_date) " + qfd + ";"
                        execute_non_query(query_fd, False, app_host_main, app_username_main, app_password_main, app_database_main)
                        dic.Add("tb_m_design_first_del", "SELECT * FROM tb_m_design_first_del_erp")
                    Else
                        dic.Add("tb_m_design_price", "SELECT * FROM tb_m_design_price_bof")
                        dic.Add("tb_m_design_first_del", "SELECT * FROM tb_m_design_first_del_bof f WHERE (" + comp_u + ") ")
                    End If
                    '-- user
                    FormMain.SplashScreenManager1.SetWaitFormDescription("Backup user data")
                    dic.Add("tb_m_user", "(SELECT u.* FROM tb_m_user u INNER JOIN tb_st_user s ON s.id_user = u.id_user WHERE u.is_external_user = 2) UNION ALL (SELECT u.* FROM tb_m_user u WHERE u.is_external_user = 1 AND u.id_store = '" + id_store + "')")
                    dic.Add("tb_m_employee", "SELECT e.* FROM tb_m_user u INNER JOIN tb_st_user s ON s.id_user = u.id_user 
                INNER JOIN tb_m_employee e ON e.id_employee = u.id_employee ")
                    dic.Add("tb_st_user", "SELECT s.* FROM tb_st_user s ")
                    '-- report status
                    FormMain.SplashScreenManager1.SetWaitFormDescription("Backup report status")
                    dic.Add("tb_lookup_report_status", "SELECT * FROM tb_lookup_report_status ")
                    '-- transaction
                    FormMain.SplashScreenManager1.SetWaitFormDescription("Creating transaction table")
                    dic.Add("tb_st_trans", "SELECT * FROM tb_st_trans ")
                    dic.Add("tb_st_trans_det", "SELECT * FROM tb_st_trans_det ")
                    dic.Add("tb_st_store_remark", "SELECT * FROM tb_st_store_remark")
                    dic.Add("tb_st_trans_ver", "SELECT * FROM tb_st_trans_ver ")
                    dic.Add("tb_st_trans_ver_det", "SELECT * FROM tb_st_trans_ver_det ")
                    dic.Add("tb_st_cat", "SELECT * FROM tb_st_cat ")
                    dic.Add("tb_st_no_tag", "SELECT * FROM tb_st_no_tag ")
                    dic.Add("tb_st_no_tag_det", "SELECT * FROM tb_st_no_tag_det ")
                    dic.Add("tb_st_stop_scan_log", "SELECT * FROM tb_st_stop_scan_log ")
                    '-- stock
                    FormMain.SplashScreenManager1.SetWaitFormDescription("Backup stock")
                    If Not is_bof Then
                        execute_non_query("CALL generate_st('" + comp_in + "', '" + date_stock_DB + "', '" + id_drawer_def + "'); ", False, app_host_main, app_username_main, app_password_main, app_database_main)
                    End If
                    dic.Add("tb_st_stock", "SELECT * FROM tb_st_stock")
                    '-- scan time
                    Dim scan_time As String = execute_query("
                        SELECT scan_time
                        FROM tb_st_stop_opt
                        WHERE soh_amount <= (SELECT SUM(qty) AS qty FROM tb_st_stock)
                        ORDER BY id_st_stop_opt DESC
                        LIMIT 1
                    ", 0, False, app_host_main, app_username_main, app_password_main, app_database_main)

                    '-- tb_st_opt
                    FormMain.SplashScreenManager1.SetWaitFormDescription("Backup option table")
                    execute_non_query("UPDATE tb_st_opt SET soh_period='" + date_stock_DB + "', sales_until_period='" + date_sales_DB + "', is_record_unreg='" + is_record_unreg + "', st_scan_time='" + scan_time + "' ", False, app_host_main, app_username_main, app_password_main, app_database_main)
                    dic.Add("tb_st_opt", "SELECT * FROM tb_st_opt ")
                    If Not is_bof Then
                        '-- unique
                        execute_non_query("CALL generate_st_unique('" + comp_in + "')", False, app_host_main, app_username_main, app_password_main, app_database_main)
                        dic.Add("tb_st_unique", "SELECT * FROM tb_st_unique")
                    End If

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
                    ReportFGStockBar.comp = comp
                    ReportFGStockBar.is_bof = is_bof
                    Using report As New ReportFGStockBar()

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
                    ReportFGStockBar.comp = comp
                    ReportFGStockBar.is_bof = is_bof
                    Dim reportxls As New ReportFGStockBar()
                    'Specify XLS-specific export options.
                    Dim xlsOptions As XlsExportOptions = reportxls.ExportOptions.Xls
                    xlsOptions.ExportHyperlinks = False
                    xlsOptions.ExportMode = XlsExportMode.SingleFile
                    reportxls.ExportToXls(reportPathXls, xlsOptions)

                    'zipping
                    FormMain.SplashScreenManager1.SetWaitFormDescription("Creating zip file")

                    Dim new_path_root As String = Path.Combine(path_root, date_stock)

                    'create directory
                    Directory.CreateDirectory(new_path_root)

                    'copy file
                    FileCopy(file, Path.Combine(new_path_root, fileName))
                    FileCopy(reportPath, Path.Combine(new_path_root, fileNamePdf))
                    FileCopy(reportPathXls, Path.Combine(new_path_root, fileNameXls))

                    'zip directory
                    Dim fileNameZip As String = date_stock + ".zip"

                    Compression.ZipFile.CreateFromDirectory(new_path_root, Path.Combine(path_root, fileNameZip))

                    'remove directory
                    Directory.Delete(new_path_root, True)

                    FormMain.SplashScreenManager1.CloseWaitForm()
                    openFile("\" + date_stock)
                End If
            Else
                stopCustom("Please setup mapping store first.")
            End If
        End If

        GVData.ActiveFilterString = ""
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        downloadDB(False)
    End Sub

    Private Sub XTCDetail_Click(sender As Object, e As EventArgs) Handles XTCDetail.Click

    End Sub

    Private Sub BtnOpenFileLoc_Click(sender As Object, e As EventArgs) Handles BtnOpenFileLoc.Click
        openFile("")
    End Sub

    Sub openFile(ByVal additional As String)
        Cursor = Cursors.WaitCursor
        Dim path_root As String = Application.StartupPath + "\download\database" + additional
        Try
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath + "\test.txt", True)
            file.WriteLine(System.Environment.NewLine)
            file.WriteLine(path_root)
            file.Close()
        Catch ex As Exception
        End Try
        Process.Start("explorer.exe", path_root)
        Cursor = Cursors.Default
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Cursor = Cursors.WaitCursor
        FormDatabase.showx = True
        FormDatabase.ShowDialog()
        Close()
        Cursor = Cursors.Default
    End Sub

    Sub load_excel_data(ByVal id_comp As String)
        Dim oledbconn As New OleDbConnection
        Dim strConn As String
        Dim data_temp As New DataTable
        Dim bof_xls_path As String = Application.StartupPath + "\soh_bof.xlsx"
        Dim bof_xls_temp_path As String = Application.StartupPath + "\soh_bof_temp.xlsx"
        Dim bof_xls_ws As String = "Sheet1$"

        File.Copy(bof_xls_path, bof_xls_temp_path, True)

        strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" & bof_xls_temp_path & "';Extended Properties=""Excel 12.0 XML; IMEX=1;HDR=YES;TypeGuessRows=0;ImportMixedTypes=Text;"""
        oledbconn.ConnectionString = strConn
        Dim MyCommand As OleDbDataAdapter
        Try
            MyCommand = New OleDbDataAdapter("select * from [" & bof_xls_ws & "] WHERE not ([code1]='')", oledbconn)
            MyCommand.Fill(data_temp)
            MyCommand.Dispose()
        Catch ex As Exception
            stopCustom(ex.ToString)
        End Try

        'truncate tb_st_bof & insert
        execute_non_query("TRUNCATE `tb_st_bof`", False, app_host_main, app_username_main, app_password_main, app_database_main)
        Dim qins As String = "INSERT INTO tb_st_bof(`code1`, `code`, `class`,`desc`, `trstyp`, `aging`, `source`, `size`, `qtyt`, `price`, `sale`, `cost`) VALUES "
        For i As Integer = 0 To (data_temp.Rows.Count - 1)
            If i > 0 Then
                qins += ", "
            End If
            qins += "('" + data_temp(i)("code1").ToString + "','" + data_temp(i)("code").ToString + "','" + data_temp(i)("class").ToString + "','" + addSlashes(data_temp(i)("desc").ToString) + "','" + data_temp(i)("trstyp").ToString + "','" + data_temp(i)("aging").ToString + "','" + data_temp(i)("source").ToString + "','" + data_temp(i)("size").ToString + "','" + decimalSQL(data_temp(i)("qtyt").ToString) + "','" + decimalSQL(data_temp(i)("price").ToString) + "','" + decimalSQL(data_temp(i)("sale").ToString) + "','" + decimalSQL(data_temp(i)("cost").ToString) + "') "
        Next
        If data_temp.Rows.Count > 0 Then
            execute_non_query(qins, False, app_host_main, app_username_main, app_password_main, app_database_main)
        End If

        'insert master design
        Dim qd As String = "CALL generate_st_bof(" + id_comp + ")"
        execute_non_query(qd, False, app_host_main, app_username_main, app_password_main, app_database_main)
    End Sub

    Private Sub BtnBOFData_Click(sender As Object, e As EventArgs) Handles BtnBOFData.Click
        downloadDB(True)
    End Sub
End Class