Public Class FormStock
    Dim id_design_rsv As String = "-1"
    Public id_drw_rsv As String = "-1"

    Sub viewWHStockSum()
        Dim query As String = getQueryWHDrawer()
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        SLEWHStockSum.Properties.DataSource = Nothing
        SLEWHStockSum.Properties.DataSource = data
        SLEWHStockSum.Properties.DisplayMember = "comp_name_label"
        SLEWHStockSum.Properties.ValueMember = "id_drawer_def"
        If data.Rows.Count.ToString >= 1 Then
            SLEWHStockSum.EditValue = "0"
        Else
            SLEWHStockSum.EditValue = Nothing
        End If
    End Sub

    Private Sub CheckEditAllDsgRsv_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEditAllDsgRsv.CheckedChanged
        GCRsv.DataSource = Nothing
        TxtCodeDsgRsv.Text = ""
        TxtNameDsgRsv.Text = ""
        If CheckEditAllDsgRsv.EditValue = True Then
            id_design_rsv = "0"
            TxtCodeDsgRsv.Properties.ReadOnly = True
            SLEWHStockSum.Focus()
            SLEWHStockSum.ShowPopup()
        Else
            id_design_rsv = "-1"
            TxtCodeDsgRsv.Properties.ReadOnly = False
            TxtCodeDsgRsv.Focus()
        End If
    End Sub

    Private Sub TxtCodeDsgRsv_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCodeDsgRsv.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cursor = Cursors.WaitCursor
            Dim code As String = addSlashes(TxtCodeDsgRsv.Text)
            Dim dsg As New ClassDesign()
            Dim data As DataTable = dsg.getDesign("AND d.design_code='" + code + "' ")
            If data.Rows.Count = 0 Or code = "" Then
                stopCustom("Design not found !")
                id_design_rsv = "-1"
                TxtCodeDsgRsv.Text = ""
                TxtNameDsgRsv.Text = ""
                TxtCodeDsgRsv.Focus()
            Else
                id_design_rsv = data.Rows(0)("id_design").ToString.ToUpper
                TxtNameDsgRsv.Text = data.Rows(0)("design_display_name").ToString.ToUpper
                SLEWHStockSum.Focus()
                SLEWHStockSum.ShowPopup()
            End If
            GCRsv.DataSource = Nothing
            Cursor = Cursors.Default
        Else
            id_design_rsv = "-1"
            TxtNameDsgRsv.Text = ""
            GCRsv.DataSource = Nothing
        End If
    End Sub


    Private Sub BtnViewRsv_Click(sender As Object, e As EventArgs) Handles BtnViewRsv.Click
        If CheckEditAllDsgRsv.EditValue = True Then
            viewRsv()
        Else
            If id_design_rsv = "-1" Then
                stopCustom("Design can't blank")
            Else
                viewRsv()
            End If
        End If
    End Sub

    Sub viewRsv()
        Cursor = Cursors.WaitCursor
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
        query += "SUM(s.qty) AS `total_qty` , IF(c.id_store_type=1, fd.design_price,s.design_price) AS `design_price`, c.comp_name, c.comp_number
        FROM tb_st_stock s
        INNER JOIN tb_m_product p ON p.id_product = s.id_product
        INNER JOIN tb_m_product_code pc ON pc.id_product = p.id_product
        INNER JOIN tb_m_code_detail cd ON cd.id_code_detail = pc.id_code_detail
        INNER JOIN tb_m_design d ON d.id_design = p.id_design
        INNER JOIN tb_m_comp c ON c.id_drawer_def = s.id_wh_drawer
        LEFT JOIN tb_m_design_first_del fd ON fd.id_design = d.id_design AND fd.id_comp = c.id_comp
        WHERE 1=1 "
        If SLEWHStockSum.EditValue.ToString <> "0" Then
            query += "AND s.id_wh_drawer='" + SLEWHStockSum.EditValue.ToString + "' "
        End If
        If id_design_rsv <> "0" Then
            query += "AND p.id_design='" + id_design_rsv + "' "
        End If
        query += "GROUP BY p.id_design, SUBSTRING(p.product_full_code, 10, 1) "
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
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
        Cursor = Cursors.Default
    End Sub

    Private Sub FormStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewWHStockSum()
        ActiveControl = TxtCodeDsgRsv
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        Cursor = Cursors.WaitCursor
        print_raw(GCRsv, "")
        Cursor = Cursors.Default
    End Sub

    Private Sub SLEWHStockSum_KeyDown(sender As Object, e As KeyEventArgs) Handles SLEWHStockSum.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnViewRsv.Focus()
        End If
    End Sub
End Class