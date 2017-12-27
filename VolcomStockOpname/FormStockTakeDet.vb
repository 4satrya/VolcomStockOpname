Public Class FormStockTakeDet
    Public id_st_trans As String = "-1"
    Public action As String = ""
    Public is_combine As String = "2"
    Dim id_report_status As String = "-1"

    Private Sub FormStockTakeDet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewWHStockSum()
        viewReportStatus()
        actionLoad()
    End Sub

    Sub viewReportStatus()
        Dim query As String = "SELECT * FROM tb_lookup_report_status "
        viewLookupQuery(LEStatus, query, 0, "report_status", "id_report_status")
    End Sub

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

    Sub actionLoad()
        If action = "ins" Then
            BtnPrint.Enabled = False
            LEStatus.Enabled = False
            BtnSetStatus.Enabled = False
        ElseIf action = "upd" Then
            BtnPrint.Enabled = True
            SLEWHStockSum.Enabled = False

            'main
            Dim st As New ClassStockTake
            Dim query As String = st.queryTransMain("AND st.id_st_trans='" + id_st_trans + "' ", "1")
            Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
            SLEWHStockSum.EditValue = data.Rows(0)("id_wh_drawer").ToString
            TxtNumber.Text = data.Rows(0)("st_trans_number").ToString
            DECreated.Text = data.Rows(0)("st_trans_date")

            viewDetail
            allow_status()
        End If
    End Sub

    Sub viewDetail()

    End Sub

    Sub allow_status()

        If id_report_status = "5" Or id_report_status = "6" Then
            LEStatus.Enabled = False
            BtnSetStatus.Enabled = False
            PanelControlNav.Visible = False
            BtnSave.Enabled = False
        Else
            LEStatus.Enabled = True
            BtnSetStatus.Enabled = True
            PanelControlNav.Visible = True
            BtnSave.Enabled = True
        End If
    End Sub
End Class