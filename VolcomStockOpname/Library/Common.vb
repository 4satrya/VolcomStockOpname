﻿Imports DevExpress.LookAndFeel
Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports System.Reflection
Imports System.IO

Module Common
    Public report_mark_is_bom As String = "-1"
    Public title_print As String
    Public formName As String
    Public id_user As String
    Public id_comp_user As String
    Public id_employee_user As String
    Public id_role_login As String
    Public id_departement_user As String
    Public id_departement_sub_user As String
    Public username_user As String
    Public name_user As String
    Public position_user As String
    Public code_user As String
    Public product_image_path As String = ""
    Public emp_image_path As String = ""
    Public is_change_pass_user As String = ""
    Public again_awb As String = ""
    Public st_user_code As String = ""

    Function getOptMain() As DataTable
        Dim query As String = "SELECT * FROM tb_opt"
        Dim data As DataTable = execute_query(query, -1, False, app_host, app_username, app_password, "db_opt")
        Return data
    End Function

    Function getVersion() As String
        Dim myFileVersionInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(Application.StartupPath() + "\VolcomStockOpname.exe")
        Return myFileVersionInfo.FileVersion.ToString
    End Function

    Sub loadImgPath()
        product_image_path = get_setup_field("pic_path_design") & "\"
        emp_image_path = get_setup_field("pic_path_emp") & "\"
    End Sub

    Sub setInfoDb()
        FormMain.LabelInfo.Text = ""
        Try
            Dim qinfo As String = "SELECT * FROM tb_periode_det pd WHERE pd.db_name='" + app_database + "' "
            Dim dinfo As DataTable = execute_query(qinfo, -1, False, app_host, app_username, app_password, "db_opt")
            If dinfo.Rows.Count > 0 Then
                FormMain.LabelInfo.Text = "Active : " + dinfo.Rows(0)("account").ToString + "; " + dinfo.Rows(0)("db_name").ToString + ""
            End If
        Catch ex As Exception
        End Try
    End Sub


    '============ = OPT CODE HEAD ======================================
    Function get_setup_field(ByVal field As String)
        'opt as var choose field
        Dim ret_var, query As String
        ret_var = ""

        Try
            query = "SELECT " & field & " FROM tb_st_opt LIMIT 1"
            ret_var = execute_query(query, 0, True, "", "", "", "")
        Catch ex As Exception
            ret_var = ""
        End Try

        Return ret_var
    End Function
    Function combine_header_number(ByVal header As String, ByVal increment As Integer, ByVal digit As Integer)
        Dim header_number, zero_number As String
        header_number = ""
        zero_number = ""
        If header <> "" Or increment > 0 Or digit > 0 Then
            If digit > increment.ToString.Length Then
                For i As Integer = 1 To digit - increment.ToString.Length
                    zero_number += "0"
                Next
                header_number = header + "" + zero_number + "" + increment.ToString
            Else
                header_number = header + "" + increment.ToString
            End If
        Else
            header_number = ""
        End If

        Return header_number
    End Function
    '=>=========== opt code header general =====================
    Function get_opt_general_field(ByVal field As String)
        'opt as var choose field
        Dim ret_var, query As String
        ret_var = ""

        Try
            query = "SELECT " & field & " FROM tb_opt_general LIMIT 1"
            ret_var = execute_query(query, 0, True, "", "", "", "")
        Catch ex As Exception
            ret_var = ""
        End Try

        Return ret_var
    End Function
    Function header_number_general(ByVal opt As String)
        'opt
        '1 = awbill

        Dim header_number_x As String
        header_number_x = ""

        If opt = "1" Then
            header_number_x = combine_header_number(get_opt_general_field("awbill_code_head"), Integer.Parse(get_opt_general_field("awbill_code_inc")), Integer.Parse(get_opt_general_field("awbill_code_digit")))
        End If

        Return header_number_x
    End Function
    Sub increase_inc_general(ByVal opt As String)
        'opt
        '1 = awbill

        Dim query As String
        query = ""

        If opt = "1" Then
            query = "UPDATE tb_opt_general SET awbill_code_inc=(tb_opt_general.awbill_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        End If
    End Sub
    '=>=========== opt code header sample =====================
    Function header_number(ByVal opt As String)
        'opt
        '1 = purc sample
        '2 = rec sample
        '3 = pl sample
        '4 = pr sample
        '5 = receipt sample
        '6 = Return Out Sample
        '7 = Return In Sample
        '8 = PL Borrow
        '9 = Req Sample
        '10 = Sample Plan
        '11 = Sample Return
        '12 = Sample Adj In
        '13 = Sample Adj Out 
        '14 = PL Sample Del
        '15 = REC PL Sample Del
        '16 = SAles Order Sample
        '17 = Delivery Order Sample
        '19 = SAMPLE PL
        '20 = SAMPLE PRICE

        Dim header_number_x As String
        header_number_x = ""

        If opt = "1" Then 'stock take
            header_number_x = combine_header_number(st_user_code, Integer.Parse(get_setup_field("st_inc")), 5)
            increase_inc("1")
        ElseIf opt = "2" Then 'stock take combine
            header_number_x = combine_header_number("IA", Integer.Parse(get_setup_field("stc_inc")), 5)
            increase_inc("3")
        ElseIf opt = "3" Then 'file
            header_number_x = combine_header_number("", Integer.Parse(get_setup_field("file_inc")), 0)
            increase_inc("2")
        ElseIf opt = "4" Then 'WH pre stock take
            header_number_x = combine_header_number("PS", Integer.Parse(get_setup_field("st_pre_inc")), 5)
            increase_inc("4")
        ElseIf opt = "5" Then 'WH pre stock take combine
            header_number_x = combine_header_number("PSC", Integer.Parse(get_setup_field("st_pre_comb_inc")), 5)
            increase_inc("5")
        ElseIf opt = "6" Then 'WH stock take
            header_number_x = combine_header_number("S", Integer.Parse(get_setup_field("st_ver_inc")), 5)
            increase_inc("6")
        ElseIf opt = "7" Then 'WH stock take combine
            header_number_x = combine_header_number("SC", Integer.Parse(get_setup_field("st_ver_comb_inc")), 5)
            increase_inc("7")
        End If

        Return header_number_x
    End Function
    ' for setup increase increment header
    Sub increase_inc(ByVal opt As String)
        Dim query As String
        query = ""

        If opt = "1" Then 'stock take
            query = "UPDATE tb_st_opt SET st_inc=(tb_st_opt.st_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "2" Then ' file
            query = "UPDATE tb_st_opt SET file_inc=(tb_st_opt.file_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "3" Then 'stock take combine
            query = "UPDATE tb_st_opt SET stc_inc=(tb_st_opt.stc_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "4" Then 'WH pre stock take
            query = "UPDATE tb_st_opt SET st_pre_inc=(tb_st_opt.st_pre_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "5" Then 'WH pre stock take combine
            query = "UPDATE tb_st_opt SET st_pre_comb_inc=(tb_st_opt.st_pre_comb_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "6" Then 'WH stock take
            query = "UPDATE tb_st_opt SET st_ver_inc=(tb_st_opt.st_ver_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "7" Then 'WH stock take combinee
            query = "UPDATE tb_st_opt SET st_ver_comb_inc=(tb_st_opt.st_ver_comb_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        End If
    End Sub
    '=>=========== opt code header mat =====================
    Function get_opt_mat_field(ByVal field As String)
        'opt as var choose field
        Dim ret_var, query As String
        ret_var = ""

        Try
            query = "SELECT " & field & " FROM tb_opt_mat LIMIT 1"
            ret_var = execute_query(query, 0, True, "", "", "", "")
        Catch ex As Exception
            ret_var = ""
        End Try

        Return ret_var
    End Function
    Function header_number_mat(ByVal opt As String)
        'opt
        '1 = purc mat
        '2 = wo mat
        '3 = rec purc mat
        '4 = rec wo mat
        '5 = return out mat
        '6 = return in mat
        '7 = PR mat purchase
        '8 = PR mat wo
        '9 = Adj In 
        '10 = Adj Out
        '11 = PL mrs production
        '12 = Invoice PL MRS
        '13 = Retur Invoice PL MRS
        Dim header_number_x As String
        header_number_x = ""

        If opt = "1" Then
            header_number_x = combine_header_number(get_opt_mat_field("purc_mat_code_head"), Integer.Parse(get_opt_mat_field("purc_mat_code_inc")), Integer.Parse(get_opt_mat_field("purc_mat_code_digit")))
        ElseIf opt = "2" Then
            header_number_x = combine_header_number(get_opt_mat_field("wo_mat_code_head"), Integer.Parse(get_opt_mat_field("wo_mat_code_inc")), Integer.Parse(get_opt_mat_field("wo_mat_code_digit")))
        ElseIf opt = "3" Then
            header_number_x = combine_header_number(get_opt_mat_field("rec_purc_mat_code_head"), Integer.Parse(get_opt_mat_field("rec_purc_mat_code_inc")), Integer.Parse(get_opt_mat_field("rec_purc_mat_code_digit")))
        ElseIf opt = "4" Then
            header_number_x = combine_header_number(get_opt_mat_field("rec_wo_mat_code_head"), Integer.Parse(get_opt_mat_field("rec_wo_mat_code_inc")), Integer.Parse(get_opt_mat_field("rec_wo_mat_code_digit")))
        ElseIf opt = "5" Then
            header_number_x = combine_header_number(get_opt_mat_field("ret_out_mat_code_head"), Integer.Parse(get_opt_mat_field("ret_out_mat_code_inc")), Integer.Parse(get_opt_mat_field("ret_out_mat_code_digit")))
        ElseIf opt = "6" Then
            header_number_x = combine_header_number(get_opt_mat_field("ret_in_mat_code_head"), Integer.Parse(get_opt_mat_field("ret_in_mat_code_inc")), Integer.Parse(get_opt_mat_field("ret_in_mat_code_digit")))
        ElseIf opt = "7" Then
            header_number_x = combine_header_number(get_opt_mat_field("pr_purc_mat_code_head"), Integer.Parse(get_opt_mat_field("pr_purc_mat_code_inc")), Integer.Parse(get_opt_mat_field("pr_purc_mat_code_digit")))
        ElseIf opt = "8" Then
            header_number_x = combine_header_number(get_opt_mat_field("pr_wo_mat_code_head"), Integer.Parse(get_opt_mat_field("pr_wo_mat_code_inc")), Integer.Parse(get_opt_mat_field("pr_wo_mat_code_digit")))
        ElseIf opt = "9" Then
            header_number_x = combine_header_number(get_opt_mat_field("adj_in_mat_code_head"), Integer.Parse(get_opt_mat_field("adj_in_mat_code_inc")), Integer.Parse(get_opt_mat_field("adj_in_mat_code_digit")))
        ElseIf opt = "10" Then
            header_number_x = combine_header_number(get_opt_mat_field("adj_out_mat_code_head"), Integer.Parse(get_opt_mat_field("adj_out_mat_code_inc")), Integer.Parse(get_opt_mat_field("adj_out_mat_code_digit")))
        ElseIf opt = "11" Then
            header_number_x = combine_header_number(get_opt_mat_field("pl_mrs_code_head"), Integer.Parse(get_opt_mat_field("pl_mrs_code_inc")), Integer.Parse(get_opt_mat_field("pl_mrs_code_digit")))
        ElseIf opt = "12" Then
            header_number_x = combine_header_number(get_opt_mat_field("inv_pl_mrs_code_head"), Integer.Parse(get_opt_mat_field("inv_pl_mrs_code_inc")), Integer.Parse(get_opt_mat_field("inv_pl_mrs_code_digit")))
        ElseIf opt = "13" Then
            header_number_x = combine_header_number(get_opt_mat_field("retur_inv_code_head"), Integer.Parse(get_opt_mat_field("retur_inv_code_inc")), Integer.Parse(get_opt_mat_field("retur_inv_code_digit")))
        ElseIf opt = "14" Then
            header_number_x = combine_header_number(get_opt_mat_field("mrs_mat_code_head"), Integer.Parse(get_opt_mat_field("mrs_mat_code_inc")), Integer.Parse(get_opt_mat_field("mrs_mat_code_digit")))
        ElseIf opt = "15" Then
            header_number_x = combine_header_number(get_opt_mat_field("so_mat_code_head"), Integer.Parse(get_opt_mat_field("so_mat_code_inc")), Integer.Parse(get_opt_mat_field("so_mat_code_digit")))
        End If

        Return header_number_x
    End Function
    Sub increase_inc_mat(ByVal opt As String)
        'opt
        '1 = purc mat
        '2 = wo mat
        '3 = rec mat purchase
        '3 = rec mat wo
        '5 = return out mat
        '6 = return in mat
        '7 = PR purc mat
        '8 = PR wo mat
        '9 = Adj In 
        '10 = Adj Out
        '11 = PL mrs production
        '12 = Invoice PL mrs 
        '13 = Retur Invoice PL MRS

        Dim query As String
        query = ""

        If opt = "1" Then
            query = "UPDATE tb_opt_mat SET purc_mat_code_inc=(tb_opt_mat.purc_mat_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "2" Then
            query = "UPDATE tb_opt_mat SET wo_mat_code_inc=(tb_opt_mat.wo_mat_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "3" Then
            query = "UPDATE tb_opt_mat SET rec_purc_mat_code_inc=(tb_opt_mat.rec_purc_mat_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "4" Then
            query = "UPDATE tb_opt_mat SET rec_wo_mat_code_inc=(tb_opt_mat.rec_wo_mat_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "5" Then
            query = "UPDATE tb_opt_mat SET ret_out_mat_code_inc=(tb_opt_mat.ret_out_mat_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "6" Then
            query = "UPDATE tb_opt_mat SET ret_in_mat_code_inc=(tb_opt_mat.ret_in_mat_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "7" Then
            query = "UPDATE tb_opt_mat SET pr_purc_mat_code_inc=(tb_opt_mat.pr_purc_mat_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "8" Then
            query = "UPDATE tb_opt_mat SET pr_wo_mat_code_inc=(tb_opt_mat.pr_wo_mat_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "9" Then
            query = "UPDATE tb_opt_mat SET adj_in_mat_code_inc=(tb_opt_mat.adj_in_mat_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "10" Then
            query = "UPDATE tb_opt_mat SET adj_out_mat_code_inc=(tb_opt_mat.adj_out_mat_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "11" Then
            query = "UPDATE tb_opt_mat SET pl_mrs_code_inc=(tb_opt_mat.pl_mrs_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "12" Then
            query = "UPDATE tb_opt_mat SET inv_pl_mrs_code_inc=(tb_opt_mat.inv_pl_mrs_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "13" Then
            query = "UPDATE tb_opt_mat SET retur_inv_code_inc=(tb_opt_mat.retur_inv_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "14" Then
            query = "UPDATE tb_opt_mat SET mrs_mat_code_inc=(tb_opt_mat.mrs_mat_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "15" Then
            query = "UPDATE tb_opt_mat SET so_mat_code_inc=(tb_opt_mat.so_mat_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        End If
    End Sub
    '=>=========== opt code header production =====================
    Function get_opt_prod_field(ByVal field As String)
        'opt as var choose field
        Dim ret_var, query As String
        ret_var = ""

        Try
            query = "SELECT " & field & " FROM tb_opt_prod LIMIT 1"
            ret_var = execute_query(query, 0, True, "", "", "", "")
        Catch ex As Exception
            ret_var = ""
        End Try

        Return ret_var
    End Function
    Function header_number_prod(ByVal opt As String)
        'opt
        '1 = prod_order
        '2 = prod_wo
        '3 = rec QC 
        '4 = ret out
        '5 = rtet in
        '6 = prod_mrs
        '7 = prod PL
        '8 = receive FG in WH

        Dim header_number_x As String
        header_number_x = ""

        If opt = "1" Then
            header_number_x = combine_header_number(get_opt_prod_field("prod_order_code_head"), Integer.Parse(get_opt_prod_field("prod_order_code_inc")), Integer.Parse(get_opt_prod_field("prod_order_code_digit")))
        ElseIf opt = "2" Then
            header_number_x = combine_header_number(get_opt_prod_field("prod_wo_code_head"), Integer.Parse(get_opt_prod_field("prod_wo_code_inc")), Integer.Parse(get_opt_prod_field("prod_wo_code_digit")))
        ElseIf opt = "3" Then
            header_number_x = combine_header_number(get_opt_prod_field("prod_rec_qc_code_head"), Integer.Parse(get_opt_prod_field("prod_rec_qc_code_inc")), Integer.Parse(get_opt_prod_field("prod_rec_qc_code_digit")))
        ElseIf opt = "4" Then
            header_number_x = combine_header_number(get_opt_prod_field("prod_ret_out_code_head"), Integer.Parse(get_opt_prod_field("prod_ret_out_code_inc")), Integer.Parse(get_opt_prod_field("prod_ret_out_code_digit")))
        ElseIf opt = "5" Then
            header_number_x = combine_header_number(get_opt_prod_field("prod_ret_in_code_head"), Integer.Parse(get_opt_prod_field("prod_ret_in_code_inc")), Integer.Parse(get_opt_prod_field("prod_ret_in_code_digit")))
        ElseIf opt = "6" Then
            header_number_x = combine_header_number(get_opt_prod_field("prod_mrs_code_head"), Integer.Parse(get_opt_prod_field("prod_mrs_code_inc")), Integer.Parse(get_opt_prod_field("prod_mrs_code_digit")))
        ElseIf opt = "7" Then
            header_number_x = combine_header_number(get_opt_prod_field("prod_pl_code_head"), Integer.Parse(get_opt_prod_field("prod_pl_code_inc")), Integer.Parse(get_opt_prod_field("prod_pl_code_digit")))
        ElseIf opt = "8" Then
            header_number_x = combine_header_number(get_opt_prod_field("prod_pl_rec_code_head"), Integer.Parse(get_opt_prod_field("prod_pl_rec_code_inc")), Integer.Parse(get_opt_prod_field("prod_pl_rec_code_digit")))
        ElseIf opt = "9" Then
            header_number_x = combine_header_number(get_opt_prod_field("prod_pr_code_head"), Integer.Parse(get_opt_prod_field("prod_pr_code_inc")), Integer.Parse(get_opt_prod_field("prod_pr_code_digit")))
        ElseIf opt = "10" Then
            header_number_x = combine_header_number(get_opt_prod_field("prod_qc_adj_in_code_head"), Integer.Parse(get_opt_prod_field("prod_qc_adj_in_code_inc")), Integer.Parse(get_opt_prod_field("prod_qc_adj_in_code_digit")))
        ElseIf opt = "11" Then
            header_number_x = combine_header_number(get_opt_prod_field("prod_qc_adj_out_code_head"), Integer.Parse(get_opt_prod_field("prod_qc_adj_out_code_inc")), Integer.Parse(get_opt_prod_field("prod_qc_adj_out_code_digit")))
        ElseIf opt = "12" Then
            header_number_x = combine_header_number(get_opt_prod_field("prod_fc_code_head"), Integer.Parse(get_opt_prod_field("prod_fc_code_inc")), Integer.Parse(get_opt_prod_field("prod_fc_code_digit")))
        ElseIf opt = "13" Then
            header_number_x = combine_header_number(get_opt_prod_field("prod_ass_code_head"), Integer.Parse(get_opt_prod_field("prod_ass_code_inc")), Integer.Parse(get_opt_prod_field("prod_ass_code_digit")))
        End If

        Return header_number_x
    End Function
    Sub increase_inc_prod(ByVal opt As String)
        'opt
        '1 = prod_order
        '2 = prod_wo
        '3 = rec QC
        '4 = ret out
        '5 = ret in
        '6 = prod_mrs
        '7 = prod PL
        '8 = receive FG in WH

        Dim query As String
        query = ""

        If opt = "1" Then
            query = "UPDATE tb_opt_prod SET prod_order_code_inc=(tb_opt_prod.prod_order_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "2" Then
            query = "UPDATE tb_opt_prod SET prod_wo_code_inc=(tb_opt_prod.prod_wo_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "3" Then
            query = "UPDATE tb_opt_prod SET prod_rec_qc_code_inc = (tb_opt_prod.prod_rec_qc_code_inc + 1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "4" Then
            query = "UPDATE tb_opt_prod SET prod_ret_out_code_inc = (tb_opt_prod.prod_ret_out_code_inc + 1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "5" Then
            query = "UPDATE tb_opt_prod SET prod_ret_in_code_inc = (tb_opt_prod.prod_ret_in_code_inc + 1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "6" Then
            query = "UPDATE tb_opt_prod SET prod_mrs_code_inc=(tb_opt_prod.prod_mrs_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "7" Then
            query = "UPDATE tb_opt_prod SET prod_pl_code_inc = (tb_opt_prod.prod_pl_code_inc + 1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "8" Then
            query = "UPDATE tb_opt_prod SET prod_pl_rec_code_inc = (tb_opt_prod.prod_pl_rec_code_inc + 1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "9" Then
            query = "UPDATE tb_opt_prod SET prod_pr_code_inc = (tb_opt_prod.prod_pr_code_inc + 1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "10" Then
            query = "UPDATE tb_opt_prod SET prod_qc_adj_in_code_inc = (tb_opt_prod.prod_qc_adj_in_code_inc + 1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "11" Then
            query = "UPDATE tb_opt_prod SET prod_qc_adj_out_code_inc = (tb_opt_prod.prod_qc_adj_out_code_inc + 1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "12" Then
            query = "UPDATE tb_opt_prod SET prod_fc_code_inc = (tb_opt_prod.prod_fc_code_inc + 1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "13" Then
            query = "UPDATE tb_opt_prod SET prod_ass_code_inc = (tb_opt_prod.prod_ass_code_inc + 1)"
            execute_non_query(query, True, "", "", "", "")
        End If
    End Sub
    '=>=========== opt code header production =====================
    Function get_opt_acc_field(ByVal field As String)
        'opt as var choose field
        Dim ret_var, query As String
        ret_var = ""

        Try
            query = "SELECT " & field & " FROM tb_opt_accounting LIMIT 1"
            ret_var = execute_query(query, 0, True, "", "", "", "")
        Catch ex As Exception
            ret_var = ""
        End Try

        Return ret_var
    End Function
    Function header_number_acc(ByVal opt As String)
        'opt
        '1 = acc trans

        Dim header_number_x As String
        header_number_x = ""

        If opt = "1" Then
            header_number_x = combine_header_number(get_opt_acc_field("acc_trans_code_head"), Integer.Parse(get_opt_acc_field("acc_trans_code_inc")), Integer.Parse(get_opt_acc_field("acc_trans_code_digit")))
        ElseIf opt = "2" Then
            header_number_x = combine_header_number(get_opt_acc_field("acc_trans_adj_code_head"), Integer.Parse(get_opt_acc_field("acc_trans_adj_code_inc")), Integer.Parse(get_opt_acc_field("acc_trans_adj_code_digit")))
        ElseIf opt = "3" Then 'BPJ
            header_number_x = combine_header_number(get_opt_acc_field("bpj_code_head"), Integer.Parse(get_opt_acc_field("bpj_code_inc")), Integer.Parse(get_opt_acc_field("bpj_code_digit")))
        ElseIf opt = "4" Then 'BPL
            header_number_x = combine_header_number(get_opt_acc_field("bpl_code_head"), Integer.Parse(get_opt_acc_field("bpl_code_inc")), Integer.Parse(get_opt_acc_field("bpl_code_digit")))
        ElseIf opt = "5" Then 'PRM
            header_number_x = combine_header_number(get_opt_acc_field("prm_code_head"), Integer.Parse(get_opt_acc_field("prm_code_inc")), Integer.Parse(get_opt_acc_field("prm_code_digit")))
        End If

        Return header_number_x
    End Function
    Sub increase_inc_acc(ByVal opt As String)
        'opt
        '1 = acc trans

        Dim query As String
        query = ""

        If opt = "1" Then
            query = "UPDATE tb_opt_accounting SET acc_trans_code_inc=(tb_opt_accounting.acc_trans_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "2" Then
            query = "UPDATE tb_opt_accounting SET acc_trans_adj_code_inc=(tb_opt_accounting.acc_trans_adj_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "3" Then ' BPJ
            query = "UPDATE tb_opt_accounting SET bpj_code_inc=(tb_opt_accounting.bpj_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "4" Then ' BPL
            query = "UPDATE tb_opt_accounting SET bpl_code_inc=(tb_opt_accounting.bpl_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "5" Then ' PRM
            query = "UPDATE tb_opt_accounting SET prm_code_inc=(tb_opt_accounting.prm_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        End If
    End Sub

    '=>=========== opt code header sales =====================
    Function get_opt_sales_field(ByVal field As String)
        'opt as var choose field
        Dim ret_var, query As String
        ret_var = ""

        Try
            query = "SELECT " & field & " FROM tb_opt_sales LIMIT 1"
            ret_var = execute_query(query, 0, True, "", "", "", "")
        Catch ex As Exception
            ret_var = ""
        End Try

        Return ret_var
    End Function

    Function header_number_sales(ByVal opt As String)
        'opt
        '1 = sales target
        '2 = Sales order
        '3 = delivery order
        '4 = return order
        '5 = return 
        '6 = virtual POS
        '7 = return QC
        '8 = sales invoice
        '9 = Stock Opname Store
        '10 = FG Missing
        '11 = FG Missing Invoice
        '12 = Stock Opname WH
        '13 = adj out FG
        '14 = adj in FG
        '15 = transfer
        '16 = Code Replacement
        '17 = Sales Credit Note
        '18 = Missing Store Credit Notre
        '19 = Code Replacement WH
        '20 = WRITE OFF
        '21 = SO PRODUCT TRACKER
        '25 = Master Price From Excel
        '26 = Inventory Allocation
        '27 = repair FG
        '28 = receive repair FG
        '29 = return repair FG
        '30 = rec return repair FG



        Dim header_number_x As String
        header_number_x = ""


        If opt = "1" Then
            header_number_x = combine_header_number(get_opt_sales_field("sales_target_code_head"), Integer.Parse(get_opt_sales_field("sales_target_code_inc")), Integer.Parse(get_opt_sales_field("sales_target_code_digit")))
        ElseIf opt = "2" Then
            header_number_x = combine_header_number(get_opt_sales_field("sales_order_code_head"), Integer.Parse(get_opt_sales_field("sales_order_code_inc")), Integer.Parse(get_opt_sales_field("sales_order_code_digit")))
        ElseIf opt = "3" Then
            header_number_x = combine_header_number(get_opt_sales_field("sales_del_order_code_head"), Integer.Parse(get_opt_sales_field("sales_del_order_code_inc")), Integer.Parse(get_opt_sales_field("sales_del_order_code_digit")))
            increase_inc_sales("3")
        ElseIf opt = "4" Then
            header_number_x = combine_header_number(get_opt_sales_field("sales_return_order_code_head"), Integer.Parse(get_opt_sales_field("sales_return_order_code_inc")), Integer.Parse(get_opt_sales_field("sales_return_order_code_digit")))
        ElseIf opt = "5" Then
            header_number_x = combine_header_number(get_opt_sales_field("sales_return_code_head"), Integer.Parse(get_opt_sales_field("sales_return_code_inc")), Integer.Parse(get_opt_sales_field("sales_return_code_digit")))
        ElseIf opt = "6" Then
            header_number_x = combine_header_number(get_opt_sales_field("sales_pos_code_head"), Integer.Parse(get_opt_sales_field("sales_pos_code_inc")), Integer.Parse(get_opt_sales_field("sales_pos_code_digit")))
        ElseIf opt = "7" Then
            header_number_x = combine_header_number(get_opt_sales_field("sales_return_qc_code_head"), Integer.Parse(get_opt_sales_field("sales_return_qc_code_inc")), Integer.Parse(get_opt_sales_field("sales_return_qc_code_digit")))
        ElseIf opt = "8" Then
            header_number_x = combine_header_number(get_opt_sales_field("sales_invoice_code_head"), Integer.Parse(get_opt_sales_field("sales_invoice_code_inc")), Integer.Parse(get_opt_sales_field("sales_invoice_code_digit")))
        ElseIf opt = "9" Then
            header_number_x = combine_header_number(get_opt_sales_field("fg_so_store_code_head"), Integer.Parse(get_opt_sales_field("fg_so_store_code_inc")), Integer.Parse(get_opt_sales_field("fg_so_store_code_digit")))
        ElseIf opt = "10" Then
            header_number_x = combine_header_number(get_opt_sales_field("fg_missing_code_head"), Integer.Parse(get_opt_sales_field("fg_missing_code_inc")), Integer.Parse(get_opt_sales_field("fg_missing_code_digit")))
        ElseIf opt = "11" Then
            header_number_x = combine_header_number(get_opt_sales_field("fg_missing_invoice_code_head"), Integer.Parse(get_opt_sales_field("fg_missing_invoice_code_inc")), Integer.Parse(get_opt_sales_field("fg_missing_invoice_code_digit")))
        ElseIf opt = "12" Then
            header_number_x = combine_header_number(get_opt_sales_field("fg_so_wh_code_head"), Integer.Parse(get_opt_sales_field("fg_so_wh_code_inc")), Integer.Parse(get_opt_sales_field("fg_so_wh_code_digit")))
        ElseIf opt = "13" Then
            header_number_x = combine_header_number(get_opt_sales_field("fg_adj_out_code_head"), Integer.Parse(get_opt_sales_field("fg_adj_out_code_inc")), Integer.Parse(get_opt_sales_field("fg_adj_out_code_digit")))
        ElseIf opt = "14" Then
            header_number_x = combine_header_number(get_opt_sales_field("fg_adj_in_code_head"), Integer.Parse(get_opt_sales_field("fg_adj_in_code_inc")), Integer.Parse(get_opt_sales_field("fg_adj_in_code_digit")))
        ElseIf opt = "15" Then
            header_number_x = combine_header_number(get_opt_sales_field("fg_trf_code_head"), Integer.Parse(get_opt_sales_field("fg_trf_code_inc")), Integer.Parse(get_opt_sales_field("fg_trf_code_digit")))
        ElseIf opt = "16" Then
            header_number_x = combine_header_number(get_opt_sales_field("fg_code_replace_store_head"), Integer.Parse(get_opt_sales_field("fg_code_replace_store_inc")), Integer.Parse(get_opt_sales_field("fg_code_replace_store_digit")))
        ElseIf opt = "17" Then
            header_number_x = combine_header_number(get_opt_sales_field("sales_credit_note_head"), Integer.Parse(get_opt_sales_field("sales_credit_note_inc")), Integer.Parse(get_opt_sales_field("sales_credit_note_digit")))
        ElseIf opt = "18" Then
            header_number_x = combine_header_number(get_opt_sales_field("fg_missing_cn_code_head"), Integer.Parse(get_opt_sales_field("fg_missing_cn_code_inc")), Integer.Parse(get_opt_sales_field("fg_missing_cn_code_digit")))
        ElseIf opt = "19" Then
            header_number_x = combine_header_number(get_opt_sales_field("fg_code_replace_wh_head"), Integer.Parse(get_opt_sales_field("fg_code_replace_wh_inc")), Integer.Parse(get_opt_sales_field("fg_code_replace_wh_digit")))
        ElseIf opt = "20" Then
            header_number_x = combine_header_number(get_opt_sales_field("fg_write_off_code_head"), Integer.Parse(get_opt_sales_field("fg_write_off_code_inc")), Integer.Parse(get_opt_sales_field("fg_write_off_code_digit")))
        ElseIf opt = "21" Then
            Dim curr_year As String = execute_query("select CAST(year(now()) AS CHAR(4)) AS curr", 0, True, "", "", "", "")
            header_number_x = combine_header_number(get_opt_sales_field("sales_order_track_code_head"), Integer.Parse(get_opt_sales_field("sales_order_track_code_inc")), Integer.Parse(get_opt_sales_field("sales_order_track_code_digit"))) + curr_year
        ElseIf opt = "22" Then
            header_number_x = combine_header_number(get_opt_sales_field("sales_promo_code_head"), Integer.Parse(get_opt_sales_field("sales_promo_code_inc")), Integer.Parse(get_opt_sales_field("sales_promo_code_digit")))
        ElseIf opt = "23" Then
            header_number_x = combine_header_number(get_opt_sales_field("sales_prm_cn_code_head"), Integer.Parse(get_opt_sales_field("sales_prm_cn_code_inc")), Integer.Parse(get_opt_sales_field("sales_prm_cn_code_digit")))
        ElseIf opt = "24" Then
            header_number_x = combine_header_number(get_opt_sales_field("fg_missing_wh_code_head"), Integer.Parse(get_opt_sales_field("fg_missing_wh_code_inc")), Integer.Parse(get_opt_sales_field("fg_missing_wh_code_digit")))
        ElseIf opt = "25" Then
            header_number_x = combine_header_number(get_opt_sales_field("fg_price_code_head"), Integer.Parse(get_opt_sales_field("fg_price_code_inc")), Integer.Parse(get_opt_sales_field("fg_price_code_digit")))
        ElseIf opt = "26" Then
            header_number_x = combine_header_number(get_opt_sales_field("fg_wh_alloc_code_head"), Integer.Parse(get_opt_sales_field("fg_wh_alloc_code_inc")), Integer.Parse(get_opt_sales_field("fg_wh_alloc_code_digit")))
        ElseIf opt = "27" Then
            header_number_x = combine_header_number(get_opt_sales_field("fg_repair_head"), Integer.Parse(get_opt_sales_field("fg_repair_inc")), Integer.Parse(get_opt_sales_field("fg_repair_digit")))
        ElseIf opt = "28" Then
            header_number_x = combine_header_number(get_opt_sales_field("fg_repair_rec_head"), Integer.Parse(get_opt_sales_field("fg_repair_rec_inc")), Integer.Parse(get_opt_sales_field("fg_repair_rec_digit")))
        ElseIf opt = "29" Then
            header_number_x = combine_header_number(get_opt_sales_field("fg_repair_return_head"), Integer.Parse(get_opt_sales_field("fg_repair_return_inc")), Integer.Parse(get_opt_sales_field("fg_repair_return_digit")))
        ElseIf opt = "30" Then
            header_number_x = combine_header_number(get_opt_sales_field("fg_repair_return_rec_head"), Integer.Parse(get_opt_sales_field("fg_repair_return_rec_inc")), Integer.Parse(get_opt_sales_field("fg_repair_return_rec_digit")))
        ElseIf opt = "31" Then
            header_number_x = combine_header_number(get_opt_sales_field("sales_del_emp_code_head"), Integer.Parse(get_opt_sales_field("sales_del_emp_code_inc")), Integer.Parse(get_opt_sales_field("sales_del_emp_code_digit")))
        ElseIf opt = "32" Then
            header_number_x = combine_header_number(get_opt_sales_field("fg_non_stock_code_head"), Integer.Parse(get_opt_sales_field("fg_non_stock_code_inc")), Integer.Parse(get_opt_sales_field("fg_non_stock_code_digit")))
        ElseIf opt = "33" Then
            header_number_x = combine_header_number(get_opt_sales_field("fg_inv_prm_code_head"), Integer.Parse(get_opt_sales_field("fg_inv_prm_code_inc")), Integer.Parse(get_opt_sales_field("fg_inv_prm_code_digit")))
        ElseIf opt = "34" Then
            header_number_x = combine_header_number(get_opt_sales_field("fg_inv_staff_code_head"), Integer.Parse(get_opt_sales_field("fg_inv_staff_code_inc")), Integer.Parse(get_opt_sales_field("fg_inv_staff_code_digit")))
        End If
        Return header_number_x
    End Function

    Sub increase_inc_sales(ByVal opt As String)
        'opt
        '1 = sales target
        '2 = sales order
        '3 = sales delivery order
        '4 = return order
        '5 = return
        '6 = virtual pos
        '7 = return QC
        '8 = sales invoice
        '9 = Stock opname Store 
        '10 = Missing FG
        '11 = Missing FG INVOICE
        '12 = Stock opname WH 
        '13 = adj out FG
        '14 = adj in FG
        '15 = transfer
        '16 = Code Replacement
        '17 = Sales Credit Note
        '18 = Missing Store Credit Note
        '19 = Code Replacement WH
        '20 = Write Off
        '21 = SO Product tracker
        '25 = Import Price From Excel
        '26 = inventory allocation
        '27 = repair FG
        '28 = receive repair FG
        '29 = return repair FG
        '30 = rec return repair FG

        Dim query As String
        query = ""

        If opt = "1" Then
            query = "UPDATE tb_opt_sales SET sales_target_code_inc=(tb_opt_sales.sales_target_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "2" Then
            query = "UPDATE tb_opt_sales SET sales_order_code_inc=(tb_opt_sales.sales_order_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "3" Then
            query = "UPDATE tb_opt_sales SET sales_del_order_code_inc=(tb_opt_sales.sales_del_order_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "4" Then
            query = "UPDATE tb_opt_sales SET sales_return_order_code_inc=(tb_opt_sales.sales_return_order_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "5" Then
            query = "UPDATE tb_opt_sales SET sales_return_code_inc=(tb_opt_sales.sales_return_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "6" Then
            query = "UPDATE tb_opt_sales SET sales_pos_code_inc = (tb_opt_sales.sales_pos_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "7" Then
            query = "UPDATE tb_opt_sales SET sales_return_qc_code_inc = (tb_opt_sales.sales_return_qc_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "8" Then
            query = "UPDATE tb_opt_sales SET sales_invoice_code_inc = (tb_opt_sales.sales_invoice_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "9" Then
            query = "UPDATE tb_opt_sales SET fg_so_store_code_inc = (tb_opt_sales.fg_so_store_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "10" Then
            query = "UPDATE tb_opt_sales SET fg_missing_code_inc = (tb_opt_sales.fg_missing_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "11" Then
            query = "UPDATE tb_opt_sales SET fg_missing_invoice_code_inc = (tb_opt_sales.fg_missing_invoice_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "12" Then
            query = "UPDATE tb_opt_sales SET fg_so_wh_code_inc = (tb_opt_sales.fg_so_wh_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "13" Then
            query = "UPDATE tb_opt_sales SET fg_adj_out_code_inc = (tb_opt_sales.fg_adj_out_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "14" Then
            query = "UPDATE tb_opt_sales SET fg_adj_in_code_inc = (tb_opt_sales.fg_adj_in_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "15" Then
            query = "UPDATE tb_opt_sales SET fg_trf_code_inc = (tb_opt_sales.fg_trf_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "16" Then
            query = "UPDATE tb_opt_sales SET fg_code_replace_store_inc = (tb_opt_sales.fg_code_replace_store_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "17" Then
            query = "UPDATE tb_opt_sales SET sales_credit_note_inc = (tb_opt_sales.sales_credit_note_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "18" Then
            query = "UPDATE tb_opt_sales SET fg_missing_cn_code_inc = (tb_opt_sales.fg_missing_cn_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "19" Then
            query = "UPDATE tb_opt_sales SET fg_code_replace_wh_inc = (tb_opt_sales.fg_code_replace_wh_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "20" Then
            query = "UPDATE tb_opt_sales SET fg_write_off_code_inc = (tb_opt_sales.fg_write_off_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "21" Then
            query = "UPDATE tb_opt_sales SET sales_order_track_code_inc = (tb_opt_sales.sales_order_track_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "22" Then
            query = "UPDATE tb_opt_sales SET sales_promo_code_inc = (tb_opt_sales.sales_promo_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "23" Then
            query = "UPDATE tb_opt_sales SET sales_prm_cn_code_inc = (tb_opt_sales.sales_prm_cn_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "24" Then
            query = "UPDATE tb_opt_sales SET fg_missing_wh_code_inc = (tb_opt_sales.fg_missing_wh_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "25" Then
            query = "UPDATE tb_opt_sales SET fg_price_code_inc = (tb_opt_sales.fg_price_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "26" Then
            query = "UPDATE tb_opt_sales SET fg_wh_alloc_code_inc  = (tb_opt_sales.fg_wh_alloc_code_inc +1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "27" Then
            query = "UPDATE tb_opt_sales SET fg_repair_inc  = (tb_opt_sales.fg_repair_inc +1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "28" Then
            query = "UPDATE tb_opt_sales SET fg_repair_rec_inc  = (tb_opt_sales.fg_repair_rec_inc +1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "29" Then
            query = "UPDATE tb_opt_sales SET fg_repair_return_inc  = (tb_opt_sales.fg_repair_return_inc +1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "30" Then
            query = "UPDATE tb_opt_sales SET fg_repair_return_rec_inc  = (tb_opt_sales.fg_repair_return_rec_inc +1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "31" Then
            query = "UPDATE tb_opt_sales SET sales_del_emp_code_inc  = (tb_opt_sales.sales_del_emp_code_inc +1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "32" Then
            query = "UPDATE tb_opt_sales SET fg_non_stock_code_inc  = (tb_opt_sales.fg_non_stock_code_inc +1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "33" Then
            query = "UPDATE tb_opt_sales SET fg_inv_prm_code_inc  = (tb_opt_sales.fg_inv_prm_code_inc +1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "34" Then
            query = "UPDATE tb_opt_sales SET fg_inv_staff_code_inc  = (tb_opt_sales.fg_inv_staff_code_inc +1)"
            execute_non_query(query, True, "", "", "", "")
        End If
    End Sub
    '============= Employee code ===========================
    Function get_opt_emp_field(ByVal field As String)
        'opt as var choose field
        Dim ret_var, query As String
        ret_var = ""

        Try
            query = "SELECT " & field & " FROM tb_opt_emp LIMIT 1"
            ret_var = execute_query(query, 0, True, "", "", "", "")
        Catch ex As Exception
            ret_var = ""
        End Try

        Return ret_var
    End Function
    Function header_number_emp(ByVal opt As String)
        'opt
        '1 = leave
        '2 = DP
        '3 = Change Schedule
        '4 = Propose Schedule

        Dim header_number_x As String
        header_number_x = ""


        If opt = "1" Then
            header_number_x = combine_header_number(get_opt_emp_field("emp_leave_code_head"), Integer.Parse(get_opt_emp_field("emp_leave_code_inc")), Integer.Parse(get_opt_emp_field("emp_leave_code_digit")))
        ElseIf opt = "2" Then
            header_number_x = combine_header_number(get_opt_emp_field("emp_dp_code_head"), Integer.Parse(get_opt_emp_field("emp_dp_code_inc")), Integer.Parse(get_opt_emp_field("emp_dp_code_digit")))
        ElseIf opt = "3" Then
            header_number_x = combine_header_number(get_opt_emp_field("emp_chsch_code_head"), Integer.Parse(get_opt_emp_field("emp_chsch_code_inc")), Integer.Parse(get_opt_emp_field("emp_chsch_code_digit")))
        ElseIf opt = "4" Then
            header_number_x = combine_header_number(get_opt_emp_field("emp_schass_code_head"), Integer.Parse(get_opt_emp_field("emp_schass_code_inc")), Integer.Parse(get_opt_emp_field("emp_schass_code_digit")))
        End If

        Return header_number_x
    End Function
    Sub increase_inc_emp(ByVal opt As String)
        'opt
        '1 = leave
        '2 = DP
        '3 = Change Schedule
        '4 = Propose Schedule

        Dim query As String
        query = ""

        If opt = "1" Then
            query = "UPDATE tb_opt_emp SET emp_leave_code_inc=(tb_opt_emp.emp_leave_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "2" Then
            query = "UPDATE tb_opt_emp SET emp_dp_code_inc=(tb_opt_emp.emp_dp_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "3" Then
            query = "UPDATE tb_opt_emp SET emp_chsch_code_inc=(tb_opt_emp.emp_chsch_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        ElseIf opt = "4" Then
            query = "UPDATE tb_opt_emp SET emp_schass_code_inc=(tb_opt_emp.emp_schass_code_inc+1)"
            execute_non_query(query, True, "", "", "", "")
        End If
    End Sub
    '============= end of opt code head ====================
    Sub apply_skin()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        UserLookAndFeel.Default.UseWindowsXPTheme = False
        UserLookAndFeel.Default.SkinName = "Devexpress Style"
    End Sub

    Public Sub RunAtStartup(ByVal ApplicationName As String, ByVal ApplicationPath As String)
        Dim CU As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run")
        With CU
            .OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
            .SetValue(ApplicationName, ApplicationPath)
        End With
    End Sub

    Public Sub RemoveValue(ByVal ApplicationName As String)
        Dim CU As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run")
        With CU
            .OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
            .DeleteValue(ApplicationName, False)
        End With
    End Sub

    Public Function CheckValue(ByVal ApplicationName As String)
        Dim CU As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run")
        With CU
            .OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
            Return .GetValue(ApplicationName)
        End With
    End Function
    '--------------USER MANAGE---------------
    Private Sub hideGroupMenu()
        For Each group As DevExpress.XtraNavBar.NavBarGroup In FormMain.NBMain.Groups
            Dim jum As Integer = 0
            For i As Integer = 0 To (group.ItemLinks.Count - 1)
                If group.ItemLinks(i).Item.Visible = True Then
                    jum = jum + 1
                    Exit For
                End If
            Next
            If jum = 0 Then
                group.Visible = False
            End If
        Next group
    End Sub
    Public Sub hideAllMenu()
        For Each group As DevExpress.XtraNavBar.NavBarGroup In FormMain.NBMain.Groups
            For i As Integer = 0 To (group.ItemLinks.Count - 1)
                group.ItemLinks(i).Item.Visible = False
            Next
        Next group
    End Sub
    Public Sub disableAllMenu()
        For Each group As DevExpress.XtraNavBar.NavBarGroup In FormMain.NBMain.Groups
            For i As Integer = 0 To (group.ItemLinks.Count - 1)
                group.ItemLinks(i).Item.Enabled = False
            Next
        Next group
    End Sub
    Public Sub restartMenu()
        'close all mdi child form
        For Each frm As Form In FormMain.MdiChildren
            frm.Close()
        Next

        'hide all link & show all group
        hideAllMenu()
        For Each group As DevExpress.XtraNavBar.NavBarGroup In FormMain.NBMain.Groups
            group.Visible = True
        Next group

    End Sub
    'CHECK MENU
    Public Sub checkMenu()
        'hide menu 
        hideAllMenu()
        disableAllMenu()

        'check access
        Dim barItem As DevExpress.XtraNavBar.NavBarItem
        Dim query As String = "SELECT * FROM tb_menu a "
        query += "INNER JOIN tb_menu_involved b ON a.id_menu = b.id_menu AND b.is_view = '1' "
        query += "INNER JOIN tb_menu_form c ON b.id_form = c.id_form "
        query += "INNER JOIN tb_menu_form_control d ON c.id_form = d.id_form AND d.is_view = '1' "
        query += "INNER JOIN tb_menu_acc e ON d.id_form_control = e.id_form_control AND e.id_role = '" + id_role_login + "' "
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        If data.Rows.Count > 0 Then
            For i As Integer = 0 To (data.Rows.Count - 1)
                Try
                    barItem = FindBarItem(data.Rows(i)("menu_name").ToString)
                    barItem.Visible = True
                    barItem.Enabled = True
                Catch ex As Exception
                    'no action
                End Try
            Next
        End If

        'hide group if no item
        hideGroupMenu()
    End Sub
    'CHECK FORM ACCESS
    Public Sub checkFormAccess(ByVal frmx As String)


    End Sub

    Public Function FindBarItem(ByVal itemName As String) As DevExpress.XtraNavBar.NavBarItem
        For Each item As DevExpress.XtraNavBar.NavBarItem In FormMain.NBMain.Items
            If item.Name = itemName Then
                Return item
            End If
        Next item
        Return Nothing
    End Function
    'Public Function FindBarItemSimpleButton(ByVal itemName As String, ByVal formku As String) As DevExpress.XtraEditors.SimpleButton
    '    'Dim frm As Form = GetForm(formku)
    '    'For Each item As DevExpress.XtraEditors.SimpleButton In FormMain.FindForm
    '    '    If item.Name = itemName Then
    '    '        Return item
    '    '    End If
    '    'Next item
    '    'Return Nothing
    'End Function
    Public Function GetForm(ByVal formnameku As String) As DevExpress.XtraEditors.XtraForm
        Dim t As Type = Type.GetType(formnameku) ', True, True)
        If t Is Nothing Then
            Dim Fullname As String = Application.ProductName & "." & formnameku
            t = Type.GetType(Fullname, True, True)
        End If
        Return CType(Activator.CreateInstance(t), DevExpress.XtraEditors.XtraForm)
    End Function
    Public Function CreateObjectInstance(ByVal objectName As String) As Object
        ' Creates and returns an instance of any object in the assembly by its type name.

        Dim obj As Object

        Try
            If objectName.LastIndexOf(".") = -1 Then
                'Appends the root namespace if not specified.
                objectName = Reflection.Assembly.GetEntryAssembly.GetName.Name & "." & objectName
            End If

            obj = Reflection.Assembly.GetEntryAssembly.CreateInstance(objectName)

        Catch ex As Exception
            obj = Nothing
        End Try
        Return obj

    End Function

    Public Function CreateForm(ByVal formNameNya As String) As Form
        ' Return the instance of the form by specifying its name.
        Return DirectCast(CreateObjectInstance(formNameNya), Form)
    End Function
    'Log Data
    Public Sub logData(ByVal table_name As String, ByVal id_dml As Integer)
        'Dim query As String
        'query = "SELECT is_log_active FROM tb_opt"
        'Dim is_log_active As Integer = execute_query(query, 0, True, "", "", "", "")
        'If is_log_active = 1 Then
        '    query = String.Format("INSERT INTO tb_log VALUES('{0}', '{1}', NOW(), '{2}')", id_user, table_name, id_dml)
        '    execute_non_query(query, True, "", "", "", "")
        'End If
    End Sub

    '--------------END OF USER MANAGE---------------------
    Public Function addSlashes(ByVal InputTxt As String) As String
        ' List of characters handled:
        ' \000 null
        ' \010 backspace
        ' \011 horizontal tab
        ' \012 new line
        ' \015 carriage return
        ' \032 substitute
        ' \042 double quote
        ' \047 single quote
        ' \134 backslash
        ' \140 grave accent

        Dim Result As String = InputTxt

        Try
            Result = System.Text.RegularExpressions.Regex.Replace(InputTxt, "[\000\010\011\012\015\032\042\047\134\140]", "\$0")
        Catch Ex As Exception
            ' handle any exception here
            Console.WriteLine(Ex.Message)
        End Try
        Return Result
    End Function
    Public Function stripSlashes(ByVal InputTxt As String) As String
        ' List of characters handled:
        ' \000 null
        ' \010 backspace
        ' \011 horizontal tab
        ' \012 new line
        ' \015 carriage return
        ' \032 substitute
        ' \042 double quote
        ' \047 single quote
        ' \134 backslash
        ' \140 grave accent

        Dim Result As String = InputTxt

        Try
            Result = System.Text.RegularExpressions.Regex.Replace(InputTxt, "(\\)([\000\010\011\012\015\032\042\047\134\140])", "$2")
        Catch Ex As Exception
            ' handle any exception here
            Console.WriteLine(Ex.Message)
        End Try

        Return Result
    End Function

    Public Function isDecimal(ByVal value As String)
        Dim pattern As String = "^\d+(\.\d{1,2})?$"
        Dim test As New RegularExpressions.Regex(pattern)
        Dim valid As Boolean = False
        valid = test.IsMatch(value, 0)
        Return valid
    End Function
    Public Function isValue(ByVal value As String)
        Dim valid As Boolean = True
        If value = "" Then
            valid = False
        End If
        Return valid
    End Function

    Public Function isGridFilled(ByVal grid As DevExpress.XtraGrid.Views.Grid.GridView)
        Dim valid As Boolean = True
        For i As Integer = 0 To grid.RowCount - 1
            For j As Integer = 0 To 1
                If grid.GetRowCellValue(i, grid.Columns.Item(j)).ToString = "" Then
                    valid = False
                End If
            Next
        Next
        Return valid
    End Function
    'empty error provider Text Editor
    Public Sub EP_TE_cant_blank(ByVal EPNameHere As ErrorProvider, ByVal TENameHere As TextEdit)
        If TENameHere.Text.Length < 1 Then
            EPNameHere.SetError(TENameHere, "Don't leave this field blank.")
        Else
            EPNameHere.SetError(TENameHere, String.Empty)
        End If
    End Sub
    'empty error provider SLE
    Public Sub EP_SLE_cant_blank(ByVal EPNameHere As ErrorProvider, ByVal TENameHere As SearchLookUpEdit)
        If TENameHere.EditValue = Nothing Then
            EPNameHere.SetError(TENameHere, "Don't leave this field blank.")
        Else
            EPNameHere.SetError(TENameHere, String.Empty)
        End If
    End Sub
    'empty error provider LE
    Public Sub EP_LE_cant_blank(ByVal EPNameHere As ErrorProvider, ByVal TENameHere As LookUpEdit)
        If TENameHere.EditValue = Nothing Then
            EPNameHere.SetError(TENameHere, "Don't leave this field blank.")
        Else
            EPNameHere.SetError(TENameHere, String.Empty)
        End If
    End Sub
    'empty error provider Date Editor
    Public Sub EP_DE_cant_blank(ByVal EPNameHere As ErrorProvider, ByVal DENameHere As DateEdit)
        If DENameHere.Text.Length < 1 Then
            EPNameHere.SetError(DENameHere, "Don't leave this field blank.")
        Else
            EPNameHere.SetError(DENameHere, String.Empty)
        End If
    End Sub
    'must decimal
    Public Sub EP_TE_must_decimal(ByVal EPNameHere As ErrorProvider, ByVal TENameHere As TextEdit)
        If Not isDecimal(TENameHere.EditValue.ToString) Then
            EPNameHere.SetError(TENameHere, "Only decimal number")
        Else
            EPNameHere.SetError(TENameHere, String.Empty)
        End If
    End Sub
    'must same error provider Text Editor
    Public Sub EP_TE_must_same(ByVal EPNameHere As ErrorProvider, ByVal TENameHere As TextEdit, ByVal TENameHere2 As TextEdit)
        If TENameHere.Text.Length < 1 Then
            EPNameHere.SetError(TENameHere, "Don't leave this field blank.")
        ElseIf TENameHere.Text <> TENameHere2.Text Then
            EPNameHere.SetError(TENameHere, "Not match")
        Else
            EPNameHere.SetError(TENameHere, String.Empty)
        End If
    End Sub
    'already used error provider Text Editor
    Public Sub EP_TE_already_used(ByVal EPNameHere As ErrorProvider, ByVal TENameHere As TextEdit, ByVal adds As String)
        ' -1 untuk normal 
        If adds <> "-1" Then
            EPNameHere.SetError(TENameHere, "This value already used.")
        Else
            EPNameHere.SetError(TENameHere, String.Empty)
        End If
    End Sub
    'error provider Memo Editor
    Public Sub EP_ME_cant_blank(ByVal EPNameHere As ErrorProvider, ByVal MENameHere As MemoEdit)
        If MENameHere.Text.Length < 1 Then
            EPNameHere.SetError(MENameHere, "Don't leave this field blank.")
        Else
            EPNameHere.SetError(MENameHere, String.Empty)
        End If
    End Sub
    'error check value
    Public Sub EP_TE_check_value(ByVal EPNameHere As ErrorProvider, ByVal TENameHere As TextEdit, ByVal adds As String)
        ' -1 untuk normal 
        If adds <> "-1" Then
            EPNameHere.SetError(TENameHere, "This value doesn't exist.")
        Else
            EPNameHere.SetError(TENameHere, String.Empty)
        End If
    End Sub
    'cek all field
    Public Function formIsValid(ByVal EPNameHere As ErrorProvider)
        Dim count_error As Integer = 0
        For Each c As System.Windows.Forms.Control In EPNameHere.ContainerControl.Controls
            If Not EPNameHere.GetError(c) = "" Then
                count_error += 1
            End If
        Next
        If count_error < 1 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function formIsValidInGroup(ByVal EPNameHere As ErrorProvider, ByVal GroupnameHere As GroupControl)
        Dim count_error As Integer = 0
        For Each c As System.Windows.Forms.Control In GroupnameHere.Controls
            If Not EPNameHere.GetError(c) = "" Then
                count_error += 1
            End If
        Next
        If count_error < 1 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function formIsValidInPanel(ByVal EPNameHere As ErrorProvider, ByVal GroupnameHere As PanelControl)
        Dim count_error As Integer = 0
        For Each c As System.Windows.Forms.Control In GroupnameHere.Controls
            If Not EPNameHere.GetError(c) = "" Then
                count_error += 1
            End If
        Next
        If count_error < 1 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function formIsValidInXTP(ByVal EPNameHere As ErrorProvider, ByVal Page As DevExpress.XtraTab.XtraTabPage) As Boolean
        Dim count_error As Integer = 0
        For Each c As System.Windows.Forms.Control In Page.Controls
            If Not EPNameHere.GetError(c) = "" Then
                count_error += 1
            End If
        Next
        If count_error < 1 Then
            Return True
        Else
            Return False
        End If
    End Function
    '==== Validate function
    Public Function isPhoneNumber(ByVal phoneNumber As String)
        Dim pattern As String = "^([\+][0-9]{1,3}[ \.\-])?([\(]{1}[0-9]{2,6}[\)])?([0-9 \.\-\/]{3,20})((x|ext|extension)[ ]?[0-9]{1,4})?$"
        Dim test As New RegularExpressions.Regex(pattern)
        Dim valid As Boolean = False
        valid = test.IsMatch(phoneNumber, 0)
        Return valid
    End Function

    Public Function isNumber(ByVal number As String)
        Dim pattern As String = "^^[0-9\ ]+$"
        Dim test As New RegularExpressions.Regex(pattern)
        Dim valid As Boolean = False
        valid = test.IsMatch(number, 0)
        Return valid
    End Function

    Public Function isEmail(ByVal email As String)
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim test As New RegularExpressions.Regex(pattern)
        Dim valid As Boolean = False
        valid = test.IsMatch(email, 0)
        Return valid
    End Function

    Public Function isWebsite(ByVal website As String)
        Dim pattern As String = "^((([A-Za-z]{3,9}:(?:\/\/)?)(?:[-;:&=\+\$,\w]+@)?[A-Za-z0-9.-]+|(?:www.|[-;:&=\+\$,\w]+@)[A-Za-z0-9.-]+)((?:\/[\+~%\/.\w-_]*)?\??(?:[-\+=&;%@.\w_]*)#?(?:[\w]*))?)$"
        Dim test As New RegularExpressions.Regex(pattern)
        Dim valid As Boolean = False
        valid = test.IsMatch(website, 0)
        Return valid
    End Function
    '==== End validate
    Sub errorProcess()
        XtraMessageBox.Show("Process Error, please try again later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Sub errorConnection()
        XtraMessageBox.Show("Connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Sub errorDuplicate(ByVal value As String)
        XtraMessageBox.Show("Proses Failed, Duplicate" & value, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Sub errorDelete()
        XtraMessageBox.Show("Delete failed, this data currently used", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Sub errorInput()
        XtraMessageBox.Show("Please check your input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Sub errorCustom(ByVal err_msg As String)
        XtraMessageBox.Show(err_msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Sub stopCustom(ByVal stop_msg As String)
        XtraMessageBox.Show(stop_msg, "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    End Sub

    Sub stopCustomDialog(ByVal stop_msg As String)
        FormError.LabelContent.Text = stop_msg
        FormError.ShowDialog()
    End Sub

    Sub infoCustom(ByVal info_msg As String)
        XtraMessageBox.Show(info_msg, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Sub warningCustom(ByVal warning_msg As String)
        XtraMessageBox.Show(warning_msg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Sub getYear(ByVal CmbData As ComboBoxEdit)
        For i As Integer = Date.Today.Year - 30 To Date.Today.Year + 10
            CmbData.Properties.Items.Add(i.ToString)
        Next
    End Sub
    '======================get something================
    'get region
    Function get_region(ByVal id_state As String)
        Dim query, id_region As String
        query = String.Format("SELECT id_region FROM tb_m_state WHERE id_state='{0}'", id_state)
        id_region = execute_query(query, 0, True, "", "", "", "")
        Return id_region
    End Function
    'get state
    Function get_state(ByVal id_city As String)
        Dim query, id_state As String
        query = String.Format("SELECT id_state FROM tb_m_city WHERE id_city='{0}'", id_city)
        id_state = execute_query(query, 0, True, "", "", "", "")
        Return id_state
    End Function
    'get country
    Function get_country(ByVal id_region As String)
        Dim query, id_country As String
        query = String.Format("SELECT id_country FROM tb_m_region WHERE id_region='{0}'", id_region)
        id_country = execute_query(query, 0, True, "", "", "", "")
        Return id_country
    End Function
    'get id_company
    Function get_id_company(ByVal id_company_contact As String)
        Dim query, id_company As String
        query = String.Format("SELECT id_comp FROM tb_m_comp_contact WHERE id_comp_contact='{0}'", id_company_contact)
        id_company = execute_query(query, 0, True, "", "", "", "")
        Return id_company
    End Function
    'get id_employee
    Function get_id_employee(ByVal id_user As String)
        Dim query, id_employee As String
        query = String.Format("SELECT id_employee FROM tb_m_user WHERE id_user='{0}'", id_user)
        id_employee = execute_query(query, 0, True, "", "", "", "")
        Return id_employee
    End Function
    'get term production
    Function get_term_production_x(ByVal id_term_production As String)
        Dim query, term_production As String
        query = String.Format("SELECT term_production FROM tb_lookup_term_production WHERE id_term_production='{0}'", id_term_production)
        term_production = execute_query(query, 0, True, "", "", "", "")
        Return term_production
    End Function
    'get something from prod_demand design
    Function get_prod_demand_design_x(ByVal id_prod_demand_design As String, ByVal opt As String)
        'opt
        '1 = id_prod_demand
        '2 = id_delivery
        '3 = id_design
        Dim query, result As String
        result = ""

        Try
            If opt = "1" Then
                query = String.Format("SELECT id_prod_demand FROM tb_prod_demand_design WHERE id_prod_demand_design='{0}'", id_prod_demand_design)
                result = execute_query(query, 0, True, "", "", "", "")
            ElseIf opt = "2" Then
                query = String.Format("SELECT id_delivery FROM tb_prod_demand_design WHERE id_prod_demand_design='{0}'", id_prod_demand_design)
                result = execute_query(query, 0, True, "", "", "", "")
            ElseIf opt = "3" Then
                query = String.Format("SELECT id_design FROM tb_prod_demand_design WHERE id_prod_demand_design='{0}'", id_prod_demand_design)
                result = execute_query(query, 0, True, "", "", "", "")
            End If
        Catch ex As Exception
        End Try

        Return result
    End Function
    'get something from prod_demand 
    Function get_prod_demand_x(ByVal id_prod_demand As String, ByVal opt As String)
        'opt
        '1 = id_prod_demand
        '2 = id_delivery
        Dim query, result As String
        result = ""

        If opt = "1" Then
            query = String.Format("SELECT prod_demand_number FROM tb_prod_demand WHERE id_prod_demand='{0}'", id_prod_demand)
            result = execute_query(query, 0, True, "", "", "", "")
        ElseIf opt = "2" Then
            query = String.Format("SELECT id_season FROM tb_prod_demand WHERE id_prod_demand='{0}'", id_prod_demand)
            result = execute_query(query, 0, True, "", "", "", "")
        End If

        Return result
    End Function
    'get from prod order
    Function get_prod_order_x(ByVal id_prod_order As String, ByVal opt As String)
        'opt
        '1 = id_prod_demand_design
        Dim query, result As String
        result = ""

        If opt = "1" Then
            query = String.Format("SELECT id_prod_demand_design FROM tb_prod_order WHERE id_prod_order='{0}'", id_prod_order)
            result = execute_query(query, 0, True, "", "", "", "")
        ElseIf opt = "2" Then
            query = String.Format("SELECT prod_order_number FROM tb_prod_order WHERE id_prod_order='{0}'", id_prod_order)
            result = execute_query(query, 0, True, "", "", "", "")
        End If

        Return result
    End Function
    'get id_currency from bom
    Function get_id_currency(ByVal id_bom As String)
        Dim query, id_currency As String
        query = String.Format("SELECT id_currency FROM tb_bom WHERE id_bom='{0}'", id_bom)
        id_currency = execute_query(query, 0, True, "", "", "", "")
        Return id_currency
    End Function
    'get id_currency from purc
    Function get_id_currency_purc(ByVal id_purc As String, ByVal opt As String)
        Dim query, id_currency As String
        id_currency = "1"
        If opt = "1" Then
            query = String.Format("SELECT id_currency FROM tb_sample_purc WHERE id_sample_purc='{0}'", id_purc)
            id_currency = execute_query(query, 0, True, "", "", "", "")
        End If
        Return id_currency
    End Function
    Function get_prod_wo_x(ByVal id_wo As String, ByVal opt As String)
        Dim result As String = ""
        Dim query As String = ""

        If opt = "1" Then
            'number
            query = "SELECT prod_order_wo_number FROM tb_prod_order_wo WHERE id_prod_order_wo='" & id_wo & "'"
            result = execute_query(query, 0, True, "", "", "", "")
        End If
        Return result
    End Function
    Function get_id_season(ByVal id_delivery As String)
        Dim query, id_season As String
        query = String.Format("SELECT id_season FROM tb_season_delivery WHERE id_delivery='{0}'", id_delivery)
        id_season = execute_query(query, 0, True, "", "", "", "")
        Return id_season
    End Function
    Function get_id_range(ByVal id_season As String)
        Dim query, id_range As String
        query = String.Format("SELECT id_range FROM tb_season WHERE id_season='{0}'", id_season)
        id_range = execute_query(query, 0, True, "", "", "", "")
        Return id_range
    End Function
    Function get_id_sample_fcode(ByVal code As String)
        Dim query, id_sample As String
        query = String.Format("SELECT id_sample FROM tb_m_sample WHERE sample_code='{0}' LIMIT 1", code)
        id_sample = execute_query(query, 0, True, "", "", "", "")
        Return id_sample
    End Function
    Function get_id_sample_f_id_price(ByVal id_sample_price As String)
        Dim query, id_sample As String
        query = String.Format("SELECT id_sample FROM tb_m_sample_price WHERE id_sample_price='{0}' LIMIT 1", id_sample_price)
        id_sample = execute_query(query, 0, True, "", "", "", "")
        Return id_sample
    End Function
    Function get_sample_x(ByVal id_sample As String, ByVal opt As String)
        Dim query, result As String
        result = "0"

        If opt = "1" Then
            'sample default price
            query = String.Format("SELECT id_sample_price FROM tb_m_sample_price WHERE id_sample='{0}' LIMIT 1", id_sample)
            result = execute_query(query, 0, True, "", "", "", "")
        ElseIf opt = "2" Then
            'sample name
            query = String.Format("SELECT sample_name FROM tb_m_sample WHERE id_sample='{0}' LIMIT 1", id_sample)
            result = execute_query(query, 0, True, "", "", "", "")
        ElseIf opt = "3" Then
            'sample size
            query = execute_query("CALL view_sample_spec(" & id_sample & ")", 0, True, "", "", "", "")
            query = "SELECT a.Size FROM (" & query & ") as a LIMIT 1"
            result = execute_query(query, 0, True, "", "", "", "")
        End If

        Return result
    End Function
    Function get_id_mat_det(ByVal id_bom_det As String)
        Dim id_mat_det As String = ""

        Dim query As String
        query = String.Format("SELECT tb_m_mat_det.id_mat_det FROM tb_m_mat_det,tb_bom_det,tb_m_mat_det_price WHERE tb_m_mat_det.id_mat_det=tb_m_mat_det_price.id_mat_det AND tb_bom_det.id_mat_det_price=tb_m_mat_det_price.id_mat_det_price AND tb_bom_det.id_bom_det='{0}'", id_bom_det)
        id_mat_det = execute_query(query, 0, True, "", "", "", "")

        Return id_mat_det
    End Function
    Function get_id_mat_det_price(ByVal id_bom_det As String)
        Dim id_mat_det_price As String = ""

        Dim query As String
        query = String.Format("SELECT id_mat_det_price FROM tb_bom_det WHERE tb_bom_det.id_bom_det='{0}'", id_bom_det)
        id_mat_det_price = execute_query(query, 0, True, "", "", "", "")

        Return id_mat_det_price
    End Function
    Function get_id_mat(ByVal id_mat_det As String)
        Dim id_mat As String = ""

        Dim query As String
        query = String.Format("SELECT id_mat FROM tb_m_mat_det WHERE id_mat_det='{0}'", id_mat_det)
        id_mat = execute_query(query, 0, True, "", "", "", "")

        Return id_mat
    End Function
    Function get_id_ovh(ByVal id_bom_det As String)
        Dim id_ovh As String = ""

        Dim query As String
        query = String.Format("SELECT tb_m_ovh.id_ovh FROM tb_m_ovh,tb_bom_det,tb_m_ovh_price WHERE tb_m_ovh.id_ovh=tb_m_ovh_price.id_ovh AND tb_bom_det.id_ovh_price=tb_m_ovh_price.id_ovh_price AND tb_bom_det.id_bom_det='{0}'", id_bom_det)
        id_ovh = execute_query(query, 0, True, "", "", "", "")

        Return id_ovh
    End Function
    Function get_id_ovh_price(ByVal id_bom_det As String)
        Dim id_ovh_price As String = ""

        Dim query As String
        query = String.Format("SELECT id_ovh_price FROM tb_bom_det WHERE tb_bom_det.id_bom_det='{0}'", id_bom_det)
        id_ovh_price = execute_query(query, 0, True, "", "", "", "")

        Return id_ovh_price
    End Function
    Function get_id_product(ByVal id_bom_det As String)
        Dim id_product As String = ""

        Dim query As String
        query = String.Format("SELECT tb_m_product.id_product FROM tb_m_product,tb_bom_det,tb_m_product_price WHERE tb_m_product.id_product=tb_m_product_price.id_product AND tb_bom_det.id_product_price=tb_m_product_price.id_product_price AND tb_bom_det.id_bom_det='{0}'", id_bom_det)
        id_product = execute_query(query, 0, True, "", "", "", "")

        Return id_product
    End Function
    Function get_id_sample(ByVal id_sample_purc_det As String)
        Dim id_sample As String = ""

        Dim query As String
        query = String.Format("SELECT tb_m_sample.id_sample FROM tb_m_sample,tb_sample_purc_det,tb_m_sample_price WHERE tb_m_sample.id_sample=tb_m_sample_price.id_sample AND tb_sample_purc_det.id_sample_price=tb_m_sample_price.id_sample_price AND tb_sample_purc_det.id_sample_purc_det='{0}'", id_sample_purc_det)
        id_sample = execute_query(query, 0, True, "", "", "", "")

        Return id_sample
    End Function
    Function get_id_mat_det2(ByVal id_mat_det_price As String)
        'from price
        Dim id_mat_det As String = ""

        Dim query As String
        query = String.Format("SELECT id_mat_det FROM tb_m_mat_det_price WHERE id_mat_det_price='{0}'", id_mat_det_price)
        id_mat_det = execute_query(query, 0, True, "", "", "", "")

        Return id_mat_det
    End Function
    Function get_product_x(ByVal id_product As String, ByVal opt As String)
        Dim result As String = ""

        Dim query As String
        If opt = "1" Then
            'display name
            query = String.Format("SELECT product_name FROM tb_m_product WHERE id_product='{0}'", id_product)
            result = execute_query(query, 0, True, "", "", "", "")
        ElseIf opt = "2" Then
            ' full code
            query = String.Format("SELECT product_full_code FROM tb_m_product WHERE id_product='{0}'", id_product)
            result = execute_query(query, 0, True, "", "", "", "")
        End If

        Return result
    End Function
    'departement
    Function get_departement_x(ByVal id_departement As String, ByVal opt As String)
        Dim result As String = ""
        Dim query As String = ""

        If opt = "1" Then
            'company_name
            query = "SELECT departement FROM tb_m_departement WHERE id_departement='" & id_departement & "'"
            result = execute_query(query, 0, True, "", "", "", "")
        ElseIf opt = "2" Then
            'company_code
            query = "SELECT departement_code FROM tb_m_departement WHERE id_departement='" & id_departement & "'"
            result = execute_query(query, 0, True, "", "", "", "")
        End If
        Return result
    End Function
    Function get_report_mark_status(ByVal id_report_status As String, ByVal opt As String)
        Dim result As String = ""
        Dim query As String

        If opt = "1" Then 'report display name
            query = String.Format("SELECT report_status_display FROM tb_lookup_report_status WHERE id_report_status='{0}'", id_report_status)
            result = execute_query(query, 0, True, "", "", "", "")
        End If

        Return result
    End Function
    'company xx
    Function get_company_x(ByVal id_comp As String, ByVal opt As String)
        Dim result As String = ""
        Dim query As String = ""

        If opt = "1" Then
            'company_name
            query = "SELECT comp_name FROM tb_m_comp WHERE id_comp='" & id_comp & "'"
            result = execute_query(query, 0, True, "", "", "", "")
        ElseIf opt = "2" Then
            'company_code
            query = "SELECT comp_number FROM tb_m_comp WHERE id_comp='" & id_comp & "'"
            result = execute_query(query, 0, True, "", "", "", "")
        ElseIf opt = "3" Then
            'address
            query = "SELECT address_primary FROM tb_m_comp WHERE id_comp='" & id_comp & "'"
            result = execute_query(query, 0, True, "", "", "", "")
        ElseIf opt = "4" Then
            'tax
            query = "SELECT b.tax FROM tb_m_comp a INNER JOIN tb_lookup_tax b ON a.id_tax=b.id_tax WHERE id_comp='" & id_comp & "'"
            result = execute_query(query, 0, True, "", "", "", "")
        ElseIf opt = "5" Then
            'npwp
            query = "SELECT npwp FROM tb_m_comp WHERE id_comp='" & id_comp & "'"
            result = execute_query(query, 0, True, "", "", "", "")
        ElseIf opt = "6" Then
            'default contact
            query = "SELECT id_comp_contact FROM tb_m_comp_contact WHERE id_comp='" & id_comp & "' AND is_default=1"
            result = execute_query(query, 0, True, "", "", "", "")
        ElseIf opt = "7" Then
            'city
            query = "SELECT city FROM tb_m_comp INNER JOIN tb_m_city ON tb_m_comp.id_city=tb_m_city.id_city WHERE tb_m_comp.id_comp='" & id_comp & "'"
            result = execute_query(query, 0, True, "", "", "", "")
        ElseIf opt = "8" Then
            'so category
            query = "SELECT id_so_type FROM tb_m_comp WHERE id_comp='" & id_comp & "'"
            result = execute_query(query, 0, True, "", "", "", "")
        End If
        Return result
    End Function
    'company contact xx
    Function get_company_contact_x(ByVal id_comp_contact As String, ByVal opt As String)
        Dim result As String = ""
        Dim query As String = ""

        If opt = "1" Then
            'contact_person
            query = "SELECT contact_person FROM tb_m_comp_contact WHERE id_comp_contact='" & id_comp_contact & "'"
            result = execute_query(query, 0, True, "", "", "", "")
        ElseIf opt = "2" Then
            'contact number
            query = "SELECT contact_number FROM tb_m_comp_contact WHERE id_comp_contact='" & id_comp_contact & "'"
            result = execute_query(query, 0, True, "", "", "", "")
        ElseIf opt = "3" Then
            'id_comp
            query = "SELECT id_comp FROM tb_m_comp_contact WHERE id_comp_contact='" & id_comp_contact & "'"
            result = execute_query(query, 0, True, "", "", "", "")
        End If
        Return result
    End Function
    'company from
    Function get_company_from(ByVal id_user_param As String)
        Dim query_comp_from = "SELECT c.id_comp FROM tb_m_user a "
        query_comp_from += "INNER JOIN tb_m_employee b ON a.id_employee = b.id_employee "
        query_comp_from += "INNER JOIN tb_m_comp c ON b.id_departement = c.id_departement "
        query_comp_from += "WHERE a.id_user = '" + id_user_param + "' LIMIT 1 "
        Dim id_comp As String = execute_query(query_comp_from, 0, True, "", "", "", "")
        Return id_comp
    End Function

    'get company info by code
    Public Function get_company_by_code(ByVal code_par As String, ByVal cond_par As String)
        code_par = addSlashes(code_par)
        Dim query As String = "SELECT comp.id_drawer_def,comp.comp_commission,comp.id_comp as id_comp,comp.comp_number as comp_number,comp.comp_name as comp_name,comp.address_primary as address_primary,comp.is_active as is_active, comp.id_comp_cat, comp.id_wh_type, IFNULL(comp.id_commerce_type,1) AS `id_commerce_type`, 
        cont.id_comp_contact, getCompByContact(cont.id_comp_contact,4) AS `id_wh_drawer`,getCompByContact(cont.id_comp_contact,6) AS `id_wh_rack`, getCompByContact(cont.id_comp_contact,7) AS `id_wh_locator`, cont.contact_person, cont.contact_number, cont.is_default "
        query += "FROM tb_m_comp comp "
        query += "INNER JOIN tb_m_comp_contact cont ON cont.id_comp = comp.id_comp AND cont.is_default='1' "
        query += "WHERE comp.comp_number='" + code_par + "' "
        If cond_par <> "-1" Then
            query += cond_par + " "
        End If
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        Return data
    End Function

    Public Function get_company_by_code_no_limit(ByVal code_par As String, ByVal cond_par As String)
        code_par = addSlashes(code_par)
        Dim query As String = "SELECT comp.* "
        query += "FROM tb_m_comp comp "
        query += "WHERE comp.id_comp>0 "
        If code_par <> "" Then
            query += "AND comp.comp_number='" + code_par + "'  "
        End If
        If cond_par <> "-1" Then
            query += cond_par + " "
        End If
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        Return data
    End Function


    Function get_range_x(ByVal id_range As String, ByVal opt As String)
        Dim result As String = ""
        Dim query As String = ""

        If opt = "1" Then
            'season printed name
            query = "SELECT tb_range.range FROM tb_range WHERE id_range='" & id_range & "'"
            result = execute_query(query, 0, True, "", "", "", "")
        End If
        Return result
    End Function
    Function get_user_identify(ByVal id_user_param As String, ByVal opt As String) As String
        Dim result As String = ""
        Dim query As String = ""
        If opt = "1" Then 'name
            query = "SELECT b.employee_name "
        ElseIf opt = "2" Then 'code
            query = "SELECT b.employee_code "
        ElseIf opt = "3" Then 'sex
            query = "SELECT d.sex "
        ElseIf opt = "4" Then 'departement name
            query = "SELECT c.departement "
        ElseIf opt = "5" Then ' departement code
            query = "SELECT c.departement_code "
        ElseIf opt = "6" Then ' departement code
            query = "SELECT b.employee_position "
        End If
        query += "FROM tb_m_user a "
        query += "INNER JOIN tb_m_employee b ON a.id_employee = b.id_employee "
        query += "INNER JOIN tb_m_departement c ON b.id_departement = c.id_departement "
        query += "INNER JOIN tb_lookup_sex d ON b.id_sex = d.id_sex "
        query += "WHERE a.id_user = '" + id_user_param + "' "
        result = execute_query(query, 0, True, "", "", "", "")
        Return result
    End Function
    Function get_season_x(ByVal id_season As String, ByVal opt As String)
        Dim result As String = ""
        Dim query As String = ""

        If opt = "1" Then
            'season printed name
            query = "SELECT season_printed_name FROM tb_season WHERE id_season='" & id_season & "'"
            result = execute_query(query, 0, True, "", "", "", "")
        End If
        Return result
    End Function
    Function get_season_orign_x(ByVal id_season_orign As String, ByVal opt As String)
        Dim result As String = ""
        Dim query As String = ""

        If opt = "1" Then
            'season printed name
            query = "SELECT season_orign_display FROM tb_season_orign WHERE id_season_orign='" & id_season_orign & "'"
            result = execute_query(query, 0, True, "", "", "", "")
        End If
        Return result
    End Function
    Function get_delivery_x(ByVal id_delivery As String, ByVal opt As String)
        Dim result As String = ""
        Dim query As String = ""

        If opt = "1" Then
            'delivery printed name
            query = "SELECT delivery FROM tb_season_delivery WHERE id_delivery='" & id_delivery & "'"
            result = execute_query(query, 0, True, "", "", "", "")
        End If
        Return result
    End Function
    Function get_potype_x(ByVal id_po_type As String, ByVal opt As String)
        Dim result As String = ""
        Dim query As String = ""

        If opt = "1" Then
            'po type name
            query = "SELECT po_type FROM tb_lookup_po_type WHERE id_po_type='" & id_po_type & "'"
            result = execute_query(query, 0, True, "", "", "", "")
        End If
        Return result
    End Function
    Function get_currency(ByVal id_currency As String)
        Dim result As String = ""
        Dim query As String = ""

        query = "SELECT currency FROM tb_lookup_currency WHERE id_currency='" & id_currency & "'"
        result = execute_query(query, 0, True, "", "", "", "")

        Return result
    End Function
    Function get_payment(ByVal id_payment As String)
        Dim result As String = ""
        Dim query As String = ""

        query = "SELECT payment FROM tb_lookup_payment WHERE id_payment='" & id_payment & "'"
        result = execute_query(query, 0, True, "", "", "", "")

        Return result
    End Function
    Function get_overhead_x(ByVal id_ovh As String, ByVal opt As String)
        Dim result As String = ""
        Dim query As String = ""

        If opt = "1" Then
            'ovh printed name
            query = "SELECT overhead FROM tb_m_ovh WHERE id_ovh='" & id_ovh & "'"
            result = execute_query(query, 0, True, "", "", "", "")
        End If
        Return result
    End Function
    '===================end get something===============
    '==== print ===
    Sub CreateMarginalHeaderArea(ByVal sender As System.Object, ByVal e As CreateAreaEventArgs)
        'Dim rec As RectangleF = New RectangleF(0, 5, e.Graph.ClientPageSize.Width, 50)
        'Dim top As Integer = rec.Top
        'Dim test As PageInfoBrick
        'Dim company_name As String
        'Dim company_address As String
        'Dim company_website As String
        'Dim query As String
        'Dim data As DataTable
        'Dim url_img As String = get_setup_field("pic_path_logo") & "\logo_default.png"

        ''fetch dari db
        'Try
        '    query = ("SELECT * FROM `tb_opt` a INNER JOIN `tb_m_comp` b ON a.`id_own_company` = b.`id_comp`")
        '    data = execute_query(query, -1, True, "", "", "", "")
        '    company_name = data.Rows(0)("comp_name").ToString.ToUpper
        '    company_address = data.Rows(0)("address_primary").ToString
        '    company_website = data.Rows(0)("website").ToString

        '    'company name
        '    e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        '    e.Graph.Font = New Font("Tahoma", 14, FontStyle.Bold)
        '    test = e.Graph.DrawPageInfo(PageInfo.DateTime, company_name, Color.Black, rec, BorderSide.None)


        '    'Address
        '    e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        '    e.Graph.Font = New Font("Tahoma", 10, FontStyle.Regular)
        '    top += 28
        '    test = e.Graph.DrawPageInfo(PageInfo.DateTime, company_address, Color.Black, New RectangleF(0, top, e.Graph.ClientPageSize.Width, 50), BorderSide.None)

        '    'Contact
        '    e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        '    e.Graph.Font = New Font("Tahoma", 10, FontStyle.Regular)
        '    top += 18
        '    test = e.Graph.DrawPageInfo(PageInfo.DateTime, company_website, Color.Black, New RectangleF(0, top, e.Graph.ClientPageSize.Width, 50), BorderSide.None)


        '    'image
        '    ' Dim pimBrick As PageImageBrick
        '    'Dim img As Image = Image.FromFile(url_img)
        '    'Dim rect As RectangleF = New RectangleF(New PointF(0, -7), New SizeF(90, 90))

        '    ' Create a page image brick.
        '    '  pimBrick = e.Graph.DrawPageImage(img, rect, BorderSide.None, Color.Transparent)

        'Catch ex As Exception
        '    errorConnection()
        'End Try
    End Sub
    Sub print(ByVal GridControlHere As DevExpress.XtraGrid.GridControl, ByVal title_here As String)
        title_print = ""
        title_print = title_here
        Dim componentLink As New PrintableComponentLink(New PrintingSystem())
        componentLink.Component = GridControlHere
        componentLink.Landscape = True
        AddHandler componentLink.CreateMarginalHeaderArea, AddressOf CreateMarginalHeaderArea
        AddHandler componentLink.CreateReportHeaderArea, AddressOf CreateReportHeaderArea
        Dim phf As PageHeaderFooter = TryCast(componentLink.PageHeaderFooter, PageHeaderFooter)

        ' Clear the PageHeaderFooter's contents.
        phf.Header.Content.Clear()

        ' Add custom information to the link's header.
        phf.Footer.Content.AddRange(New String() _
            {"Printed By: " + name_user + "", "", "Date: [Date Printed]"})
        phf.Footer.LineAlignment = BrickAlignment.Near

        componentLink.CreateDocument()
        componentLink.ShowPreview()
    End Sub
    Sub print_no_footer(ByVal GridControlHere As DevExpress.XtraGrid.GridControl, ByVal title_here As String)
        title_print = ""
        title_print = title_here
        Dim componentLink As New PrintableComponentLink(New PrintingSystem())
        componentLink.Component = GridControlHere
        componentLink.Landscape = True
        AddHandler componentLink.CreateMarginalHeaderArea, AddressOf CreateMarginalHeaderArea
        AddHandler componentLink.CreateReportHeaderArea, AddressOf CreateReportHeaderArea
        Dim phf As PageHeaderFooter = TryCast(componentLink.PageHeaderFooter, PageHeaderFooter)

        ' Clear the PageHeaderFooter's contents.
        phf.Header.Content.Clear()

        componentLink.CreateDocument()
        componentLink.ShowPreview()
    End Sub

    Sub print_raw(ByVal GridControlHere As DevExpress.XtraGrid.GridControl, ByVal title_here As String)
        title_print = ""
        title_print = title_here
        Dim componentLink As New PrintableComponentLink(New PrintingSystem())
        componentLink.Component = GridControlHere
        componentLink.Landscape = True

        componentLink.CreateDocument()
        componentLink.ShowPreview()
    End Sub


    'Sub print_tree(ByVal TreeHere As DevExpress.XtraTreeList.TreeList, ByVal title_here As String)
    '    title_print = ""
    '    title_print = title_here
    '    Dim componentLink As New PrintableComponentLink(New PrintingSystem())
    '    componentLink.Component = TreeHere
    '    componentLink.Landscape = True
    '    AddHandler componentLink.CreateMarginalHeaderArea, AddressOf CreateMarginalHeaderArea
    '    AddHandler componentLink.CreateReportHeaderArea, AddressOf CreateReportHeaderArea
    '    Dim phf As PageHeaderFooter = TryCast(componentLink.PageHeaderFooter, PageHeaderFooter)

    '    ' Clear the PageHeaderFooter's contents.
    '    phf.Header.Content.Clear()

    '    ' Add custom information to the link's header.
    '    phf.Footer.Content.AddRange(New String() _
    '        {"Printed By: [User Name]", "", "Date: [Date Printed]"})
    '    phf.Footer.LineAlignment = BrickAlignment.Near

    '    componentLink.CreateDocument()
    '    componentLink.ShowPreview()
    'End Sub
    Sub CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As CreateAreaEventArgs)
        Dim reportHeader As String = title_print
        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Tahoma", 11, FontStyle.Bold)
        Dim rec As RectangleF = New RectangleF(0, 20, e.Graph.ClientPageSize.Width, 50)
        e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None)
    End Sub
    '==== end of print ===
    'Get Code Raw Mat
    Function generateCodeRaw(ByVal id_raw_mat As String, ByVal id_raw_mat_code As String, ByVal id_item_color As String, ByVal id_item_size As String, ByVal id_item_lot As String, ByVal id_item_category As String, ByVal id_item_category_sub As String, ByVal id_season As String)
        'general
        Dim code As String = ""
        Dim query As String = "SELECT id_code_lookup FROM tb_m_raw_mat_code a INNER JOIN tb_m_raw_mat_code_detail b ON a.id_raw_mat_code = b.id_raw_mat_code "
        query += "WHERE a.id_raw_mat_code = '" + id_raw_mat_code + "' ORDER BY b.index_code ASC"
        Dim dataku As DataTable = execute_query(query, -1, True, "", "", "", "")

        'season
        Dim query_season = String.Format("SELECT year_season FROM tb_season where id_season='{0}'", id_season)
        Dim data_season As DataTable = execute_query(query_season, -1, True, "", "", "", "")
        Dim year_season As String = data_season.Rows(0)("year_season").ToString
        Dim query_other As String
        Dim data_other As DataTable
        Dim jum_data_other As Integer

        'loop index code
        For i As Integer = 0 To (dataku.Rows.Count - 1)
            If dataku.Rows(i)("id_code_lookup").ToString = "1" Then 'Raw Mat Category
                query_other = "SELECT * FROM tb_m_raw_mat_category a WHERE a.id_item_category = '" + id_item_category + "'"
                data_other = execute_query(query_other, -1, True, "", "", "", "")
                code += data_other.Rows(0)("code_item_category").ToString
            ElseIf dataku.Rows(i)("id_code_lookup").ToString = "2" Then 'Raw Mat Sub Category
                query_other = "SELECT * FROM tb_m_raw_mat_category_sub a WHERE a.id_item_category_sub = '" + id_item_category_sub + "'"
                data_other = execute_query(query_other, -1, True, "", "", "", "")
                code += data_other.Rows(0)("code_item_category_sub").ToString
            ElseIf dataku.Rows(i)("id_code_lookup").ToString = "3" Then 'Item Color
                query_other = "SELECT * FROM tb_m_item_color WHERE id_item_color = '" + id_item_color + "'"
                data_other = execute_query(query_other, -1, True, "", "", "", "")
                code += data_other.Rows(0)("code_item_color").ToString
            ElseIf dataku.Rows(i)("id_code_lookup").ToString = "4" Then 'Item Size
                query_other = "SELECT * FROM tb_m_item_size WHERE id_item_size = '" + id_item_size + "'"
                data_other = execute_query(query_other, -1, True, "", "", "", "")
                code += data_other.Rows(0)("code_item_size").ToString
            ElseIf dataku.Rows(i)("id_code_lookup").ToString = "5" Then 'Item Lot
                query_other = "SELECT * FROM tb_m_item_lot WHERE id_item_lot = '" + id_item_lot + "'"
                data_other = execute_query(query_other, -1, True, "", "", "", "")
                code += data_other.Rows(0)("lot_code").ToString
            ElseIf dataku.Rows(i)("id_code_lookup").ToString = "6" Then 'Current Year
                code += year_season.Substring(2, 2)
            ElseIf dataku.Rows(i)("id_code_lookup").ToString = "7" Then 'Urutan PO
                query_other = String.Format("SELECT * FROM tb_m_raw_mat_detail a INNER JOIN tb_season b ON a.id_season = b.id_season WHERE id_raw_mat='{0}' AND id_item_color='{1}' AND id_item_lot='{2}' AND id_item_size='{3}' AND b.year_season='{4}'", id_raw_mat, id_item_color, id_item_lot, id_item_size, year_season)
                data_other = execute_query(query_other, -1, True, "", "", "", "")
                jum_data_other = data_other.Rows.Count
                If jum_data_other.ToString.Length = "1" Then
                    code += "0" + jum_data_other.ToString
                Else
                    code += jum_data_other.ToString
                End If
                'code += data_other.Rows(
            End If
        Next
        Return code
    End Function
    'Set Time Format for datatable
    Public Sub setTimeFormat(ByVal data As DataTable, ByVal data_change() As String)
        Dim edit As String
        For i As Integer = 0 To (data.Rows.Count - 1)
            For j As Integer = 0 To (data_change.Count - 1)
                edit = data.Rows(i)(data_change(j).ToString).ToString
                If edit = "" Or edit = "0000-00-00 00:00:00" Or edit = "0000-00-00" Then
                    edit = "-"
                Else
                    edit = FormatDateTime(edit, DateFormat.GeneralDate).ToString
                End If
            Next
        Next
    End Sub

    'conversion currency
    Public Function ConvertCurrencyToEnglish(ByVal MyNumber As Double, ByVal opt As String) As String
        Dim Temp As String
        Dim Dollars As String = ""
        Dim Cents As String = ""
        Dim DecimalPlace, Count As Integer
        Dim Place(9) As String
        Dim Numb As String
        Place(2) = " Thousand " : Place(3) = " Million " : Place(4) = " Billion " : Place(5) = " Trillion "
        ' Convert Numb to a string, trimming extra spaces.
        Numb = Trim(Str(MyNumber))
        ' Find decimal place.
        DecimalPlace = InStr(Numb, ".")
        ' If we find decimal place...
        If DecimalPlace > 0 Then
            ' Convert cents
            Temp = Left(Mid(Numb, DecimalPlace + 1) & "00", 2)
            Cents = ConvertTens(Temp)
            ' Strip off cents from remainder to convert.
            Numb = Trim(Left(Numb, DecimalPlace - 1))
        End If
        Count = 1
        Do While Numb <> ""
            ' Convert last 3 digits of Numb to English dollars.
            Temp = ConvertHundreds(Right(Numb, 3))
            If Temp <> "" Then Dollars = Temp & Place(Count) & Dollars
            If Len(Numb) > 3 Then
                ' Remove last 3 converted digits from Numb.
                Numb = Left(Numb, Len(Numb) - 3)
            Else
                Numb = ""
            End If
            Count = Count + 1
        Loop

        'opt here
        '1 = rp
        '6 = euro
        'else dollars

        If opt = "1" Then
            ' Clean up dollars.
            Select Case Dollars
                Case "" : Dollars = "Nol Rupiah"
                Case Else : Dollars = Dollars & " Rupiah"
            End Select
        ElseIf opt = "6" Then
            ' Clean up dollars.
            Select Case Dollars
                Case "" : Dollars = "No euro"
                Case "One" : Dollars = "One euro"
                Case Else : Dollars = Dollars & " euro"
            End Select
        Else
            ' Clean up dollars.
            Select Case Dollars
                Case "" : Dollars = "No Dollars"
                Case "One" : Dollars = "One Dollar"
                Case Else : Dollars = Dollars & " Dollars"
            End Select
        End If
        ' Clean up cents.
        Select Case Cents
            Case "" : Cents = " "
            Case "One" : Cents = " And One Cent"
            Case Else : Cents = " And " & Cents & " Cents"
        End Select
        ConvertCurrencyToEnglish = Dollars & Cents
        Return ConvertCurrencyToEnglish.ToString
    End Function

    Private Function ConvertHundreds(ByVal MyNumber As String) As String
        Dim Result As String = ""
        ' Exit if there is nothing to convert.
        If Not Val(MyNumber) = 0 Then
            ' Append leading zeros to number.
            MyNumber = Right("000" & MyNumber, 3)
            ' Do we have a hundreds place digit to convert?
            If Left(MyNumber, 1) <> "0" Then
                Result = ConvertDigit(Left(MyNumber, 1)) & " Hundred "
            End If
            ' Do we have a tens place digit to convert?
            If Mid(MyNumber, 2, 1) <> "0" Then
                Result = Result & ConvertTens(Mid(MyNumber, 2))
            Else
                ' If not, then convert the ones place digit.
                Result = Result & ConvertDigit(Mid(MyNumber, 3))
            End If
            ConvertHundreds = Trim(Result)
        Else
            ConvertHundreds = Result
        End If
    End Function

    Private Function ConvertTens(ByVal MyTens As String) As String
        Dim Result As String = ""
        ' Is value between 10 and 19?
        If Val(Left(MyTens, 1)) = 1 Then
            Select Case Val(MyTens)
                Case 10 : Result = "Ten"
                Case 11 : Result = "Eleven"
                Case 12 : Result = "Twelve"
                Case 13 : Result = "Thirteen"
                Case 14 : Result = "Fourteen"
                Case 15 : Result = "Fifteen"
                Case 16 : Result = "Sixteen"
                Case 17 : Result = "Seventeen"
                Case 18 : Result = "Eighteen"
                Case 19 : Result = "Nineteen"
                Case Else
            End Select
        Else
            ' .. otherwise it's between 20 and 99.
            Select Case Val(Left(MyTens, 1))
                Case 2 : Result = "Twenty "
                Case 3 : Result = "Thirty "
                Case 4 : Result = "Forty "
                Case 5 : Result = "Fifty "
                Case 6 : Result = "Sixty "
                Case 7 : Result = "Seventy "
                Case 8 : Result = "Eighty "
                Case 9 : Result = "Ninety "
                Case Else
            End Select
            ' Convert ones place digit.
            Result = Result & ConvertDigit(Right(MyTens, 1))
        End If
        ConvertTens = Result
    End Function

    Private Function ConvertDigit(ByVal MyDigit As String) As String
        Select Case Val(MyDigit)
            Case 1 : ConvertDigit = "One"
            Case 2 : ConvertDigit = "Two"
            Case 3 : ConvertDigit = "Three"
            Case 4 : ConvertDigit = "Four"
            Case 5 : ConvertDigit = "Five"
            Case 6 : ConvertDigit = "Six"
            Case 7 : ConvertDigit = "Seven"
            Case 8 : ConvertDigit = "Eight"
            Case 9 : ConvertDigit = "Nine"
            Case Else : ConvertDigit = ""
        End Select
    End Function
    'end of currency conversion

    '--------Lookup---------------------
    'View Lookup with Query
    Public Sub viewLookupQuery(ByVal LE As DevExpress.XtraEditors.LookUpEdit, ByVal query As String, ByVal index_selected As Integer, ByVal display As String, ByVal value As String)
        Try
            Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
            LE.Properties.DataSource = Nothing
            LE.Properties.DataSource = data
            LE.Properties.DisplayMember = display
            LE.Properties.ValueMember = value
            LE.ItemIndex = index_selected
        Catch ex As Exception
            'errorConnection()
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    'View Lookup with Query
    Public Sub viewSearchLookupQuery(ByVal SLE As DevExpress.XtraEditors.SearchLookUpEdit, ByVal query As String, ByVal index_selected As String, ByVal display As String, ByVal value As String)
        'Try
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        SLE.Properties.DataSource = Nothing
        SLE.Properties.DataSource = data
        SLE.Properties.DisplayMember = display
        SLE.Properties.ValueMember = value
        If data.Rows.Count.ToString >= 1 Then
            SLE.EditValue = data.Rows(0)(index_selected).ToString
        Else
            SLE.EditValue = Nothing
        End If
        'Catch ex As Exception
        'errorConnection()
        'errorCustom(ex.ToString)
        'End Try
    End Sub
    '--------End Of Lookup---------------------

    '--------IMAGE----------------------------
    'save image
    Sub save_image(ByVal pictureedit As DevExpress.XtraEditors.PictureEdit, ByVal location As String, ByVal filename As String)
        Dim currentImage As Bitmap = TryCast(pictureedit.EditValue, Bitmap)
        Dim savedImage As New Bitmap(pictureedit.EditValue, pictureedit.ClientSize.Width, pictureedit.ClientSize.Height)

        If System.IO.File.Exists(location & filename) Then
            System.IO.File.Delete(location & filename)
        End If

        savedImage.Save(location & filename)
    End Sub
    Sub save_image_ori(ByVal pictureedit As DevExpress.XtraEditors.PictureEdit, ByVal location As String, ByVal filename As String)
        Dim currentImage As Bitmap = TryCast(pictureedit.EditValue, Bitmap)
        Dim savedImage As New Bitmap(pictureedit.EditValue, pictureedit.ClientSize.Width, pictureedit.ClientSize.Height)

        If System.IO.File.Exists(location & filename) Then
            System.IO.File.Delete(location & filename)
        End If

        currentImage.Save(location & filename)
    End Sub
    '--------END OF IMAGE----------------------

    Function find_row(ByVal gridview As DevExpress.XtraGrid.Views.Grid.GridView, ByVal col_name As String, ByVal value_s As String) As Integer
        Dim index As Integer

        index = 0
        gridview.ExpandAllGroups()
        gridview.ApplyFindFilter("")
        gridview.ClearColumnsFilter()
        gridview.ActiveFilter.Clear()
        For i As Integer = 0 To gridview.RowCount - 1 - GetGroupRowCount(gridview)
            If gridview.GetRowCellValue(i, col_name).ToString = value_s Then
                index = i
                'gridview.CollapseAllGroups()
                Exit For
            End If
        Next
        gridview.MakeRowVisible(index)
        Return index
    End Function

    Function find_row_as_is(ByVal gridview As DevExpress.XtraGrid.Views.Grid.GridView, ByVal col_name As String, ByVal value_s As String) As Integer
        Dim index As Integer

        index = 0
        For i As Integer = 0 To gridview.RowCount - 1 - GetGroupRowCount(gridview)
            If gridview.GetRowCellValue(i, col_name).ToString = value_s Then
                index = i
                'gridview.CollapseAllGroups()
                Exit For
            End If
        Next
        gridview.MakeRowVisible(index)
        Return index
    End Function

    Sub makeSafeGV(ByVal gridview As DevExpress.XtraGrid.Views.Grid.GridView)
        gridview.ApplyFindFilter("")
        gridview.ActiveFilter.Clear()
        gridview.ExpandAllGroups()
        gridview.ClearGrouping()
    End Sub


    Function view_date(ByVal plus As Integer)
        Dim query As String = "SELECT DATE(NOW()) as now_date"
        Dim date_now As String
        Dim date_now_dt As Date
        If plus = 0 Then
            query = "SELECT DATE_FORMAT(NOW(),'%d/%m/%Y') AS now_date"
            date_now = execute_query(query, 0, True, "", "", "", "")
            Return date_now
        ElseIf plus = -1 Then
            query = "SELECT DATE(NOW())"
            date_now_dt = execute_query(query, 0, True, "", "", "", "")
            Return date_now_dt
        Else
            query = "SELECT DATE_FORMAT(DATE_ADD(NOW(),INTERVAL " & plus & " DAY),'%d/%m/%Y')  AS now_date "
            date_now = execute_query(query, 0, True, "", "", "", "")
            Return date_now
        End If
    End Function
    Function view_date_from(ByVal datex As String, ByVal plus As Integer)
        Dim query As String = ""
        Dim date_now As String

        If plus = 0 Then
            query = "SELECT DATE_FORMAT('" & datex & "','%d/%m/%Y') AS now_datex"
            date_now = execute_query(query, 0, True, "", "", "", "")
        Else
            query = "SELECT DATE_FORMAT(DATE_ADD('" & datex & "',INTERVAL " & plus & " DAY),'%d/%m/%Y')  AS now_datex "
            date_now = execute_query(query, 0, True, "", "", "", "")
        End If

        Return date_now
    End Function

    Sub insert_who_prepared(ByVal report_mark_type As String, ByVal id_report As String, ByVal id_userx As String)
        ' moved to submit
    End Sub

    Sub insert_who_approved(ByVal report_mark_type As String, ByVal id_report As String, ByVal id_userx As String)
        'report mark type = tb_lookup_report_mark_type ->
        Dim query As String = ""
        query = "INSERT INTO tb_report_mark(id_report_status,report_mark_type,id_report,id_user,id_mark,report_mark_datetime,is_use) VALUES('1','" & report_mark_type & "','" & id_report & "','" & id_userx & "','2',NOW(),'1')"
        execute_non_query(query, True, "", "", "", "")

        Dim query_cek As String = "SELECT HOUR(a.lead_time) AS hourx,MINUTE(a.lead_time) AS minutex,SECOND(a.lead_time) AS secondx,a.lead_time,a.level,b.id_mark_asg,b.report_mark_type,b.id_report_status,a.id_user "
        query_cek += "FROM tb_mark_asg_user a INNER JOIN tb_mark_asg b ON a.id_mark_asg=b.id_mark_asg "
        query_cek += "WHERE b.report_mark_type='" & report_mark_type & "' ORDER BY b.id_report_status,a.level"
        Dim data As DataTable = execute_query(query_cek, -1, True, "", "", "", "")

        For i As Integer = 0 To (data.Rows.Count - 1)
            If data.Rows(i)("level").ToString() = "1" Then
                query = "INSERT INTO tb_report_mark(id_mark_asg,id_report_status,report_mark_type,id_report,id_user,id_mark,report_mark_datetime,level,is_use) VALUES('" & data.Rows(i)("id_mark_asg").ToString() & "','" & data.Rows(i)("id_report_status").ToString() & "','" & report_mark_type & "','" & id_report & "','" & data.Rows(i)("id_user").ToString() & "','2',NOW(),'" & data.Rows(i)("level").ToString() & "','1')"
            Else
                query = "INSERT INTO tb_report_mark(id_mark_asg,id_report_status,report_mark_type,id_report,id_user,id_mark,report_mark_datetime,level) VALUES('" & data.Rows(i)("id_mark_asg").ToString() & "','" & data.Rows(i)("id_report_status").ToString() & "','" & report_mark_type & "','" & id_report & "','" & data.Rows(i)("id_user").ToString() & "','2',NOW(),'" & data.Rows(i)("level").ToString() & "')"
            End If
            execute_non_query(query, True, "", "", "", "")
        Next
    End Sub

    Function get_who_prepared(ByVal report_mark_type As String, ByVal id_report As String)
        Dim query As String = "SELECT a.id_user FROM tb_report_mark a WHERE a.report_mark_type='" + report_mark_type + "' and a.id_report='" + id_report + "' and a.id_report_status='1' "
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        Return data
    End Function

    Function check_print_report_status(ByVal id_report_status As String)
        Dim status As Boolean = True

        If id_report_status = "3" Or id_report_status = "4" Or id_report_status = "6" Or id_report_status = "7" Then
            'approve / on process / completed / received
            status = True
        Else
            status = False
        End If

        Return status
    End Function

    Function check_pre_print_report_status(ByVal id_report_status As String)
        Dim status As Boolean = True

        If id_report_status = "1" Or id_report_status = "2" Or id_report_status = "3" Or id_report_status = "4" Or id_report_status = "6" Or id_report_status = "7" Then
            'prepared/ checked /approve / on process / completed / received
            status = True
        Else
            status = False
        End If

        Return status
    End Function

    Function check_attach_report_status(ByVal id_report_status As String, ByVal report_mark_type As String, ByVal id_report As String)
        Dim status As Boolean = True
        Dim status_mark As Boolean = check_edit_report_status(id_report_status, report_mark_type, id_report)

        If (id_report_status = "1" Or id_report_status = "2") And status_mark Then
            'approve / on process / completed / received
            status = True
        Else
            status = False
        End If

        Return status
    End Function

    Function check_storage_report_status(ByVal id_report_status As String)
        Dim status As Boolean = True

        If id_report_status = "6" Then
            'approve / on process / completed / received
            status = True
        Else
            status = False
        End If

        Return status
    End Function
    Function check_edit_report_status(ByVal id_report_status As String, ByVal report_mark_type As String, ByVal id_report As String)
        Dim status As Boolean = True

        Dim query, result As String
        'Dim res As String
        'query = String.Format("SELECT count(id_report_mark) FROM tb_report_mark WHERE report_mark_type='{0}' AND id_report='{1}' AND id_report_status>'1' AND is_use='1' ", report_mark_type, id_report)
        'res = execute_query(query, 0, True, "", "", "", "")
        query = ""
        result = ""
        query = String.Format("SELECT count(id_report_mark) FROM tb_report_mark WHERE report_mark_type='{0}' AND id_report='{1}' AND id_report_status>'1' AND id_mark='2' AND is_use='1' ", report_mark_type, id_report)
        result = execute_query(query, 0, True, "", "", "", "")

        If id_report_status = "3" Or id_report_status = "4" Or id_report_status = "6" Or id_report_status = "5" Or id_report_status = "7" Or result > 0 Then
            'approve / on process / completed / received / canceled
            status = False
        Else
            status = True
        End If

        Return status
    End Function
    Function check_fill_report_status(ByVal id_report_status As String, ByVal report_mark_type As String, ByVal id_report As String)
        Dim status As Boolean = True

        Dim query, result As String
        query = ""
        result = ""
        query = String.Format("SELECT count(id_report_mark) FROM tb_report_mark WHERE report_mark_type='{0}' AND id_report='{1}' AND id_report_status>'1' AND id_mark!='1'", report_mark_type, id_report)
        result = execute_query(query, 0, True, "", "", "", "")

        If id_report_status = "3" Or id_report_status = "4" Or id_report_status = "6" Or id_report_status = "7" Or result > 0 Then
            'approve / on process / completed / received
            status = False
        Else
            status = True
        End If

        Return status
    End Function
    Sub reset_is_use_mark(ByVal id_report_mark As String, ByVal val As String)
        Dim query As String = "SELECT id_report,id_mark_asg,report_mark_type FROM tb_report_mark WHERE id_report_mark='" & id_report_mark & "' LIMIT 1"
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")

        Dim id_mark_asg, id_report, report_mark_type As String

        id_mark_asg = data.Rows(0)("id_mark_asg").ToString()
        id_report = data.Rows(0)("id_report").ToString()
        report_mark_type = data.Rows(0)("report_mark_type").ToString()

        query = "UPDATE tb_report_mark SET is_use='" & val & "' WHERE id_report='" & id_report & "' AND report_mark_type='" & report_mark_type & "' AND id_mark_asg='" & id_mark_asg & "'"
        execute_non_query(query, True, "", "", "", "")

    End Sub
    Sub delete_all_mark_related(ByVal report_mark_type As String, ByVal id_report As String)
        Dim query As String = "DELETE FROM tb_report_mark WHERE id_report='" & id_report & "' AND report_mark_type='" & report_mark_type & "'"
        execute_non_query(query, True, "", "", "", "")
    End Sub
    '======================= end of mark related ============================
    Function get_design_name(ByVal id_design As String)
        Dim result As String = ""
        Dim query As String = ""

        query = "SELECT design_display_name FROM tb_m_design WHERE id_design='" & id_design & "'"
        result = execute_query(query, 0, True, "", "", "", "")

        Return result
    End Function
    Function get_design_x(ByVal id_design As String, ByVal opt As String)
        Dim result As String = ""
        Dim query As String = ""

        Try
            If opt = "1" Then
                query = "SELECT design_display_name FROM tb_m_design WHERE id_design='" & id_design & "'"
                result = execute_query(query, 0, True, "", "", "", "")
            ElseIf opt = "2" Then
                query = "SELECT design_code FROM tb_m_design WHERE id_design='" & id_design & "'"
                result = execute_query(query, 0, True, "", "", "", "")
            ElseIf opt = "3" Then
                query = "SELECT b.sample_us_code FROM tb_m_design a INNER JOIN tb_m_sample b ON a.id_sample=b.id_sample WHERE a.id_design='" & id_design & "'"
                result = execute_query(query, 0, True, "", "", "", "")
            ElseIf opt = "4" Then
                query = "SELECT id_sample FROM tb_m_design WHERE id_design='" & id_design & "'"
                result = execute_query(query, 0, True, "", "", "", "")
            End If
        Catch ex As Exception
        End Try

        Return result
    End Function
    Public Function nominalWrite(ByVal value As String)
        Dim nominal As String
        'nominal = value.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("en-US"))
        Dim nfi As Globalization.NumberFormatInfo = New Globalization.CultureInfo("en-US", False).NumberFormat
        Dim myInt As Decimal = Decimal.Parse(value)
        nfi.NumberDecimalSeparator = "."
        nfi.NumberGroupSeparator = ""
        nominal = myInt.ToString("N", nfi)
        Return nominal
    End Function
    Public Function decimalSQL(ByVal value As String) 'hanya kalo masuk ke database
        Dim nominal As String

        nominal = value.Replace(",", ".")
        Return nominal
    End Function
    Public Function toDoubleQuote(ByVal value As String) 'hanya kalo activefilter
        Dim nominal As String
        nominal = value.Replace("'", "''")
        Return nominal
    End Function
    Function check_date_passed_now(ByVal date_check As String)
        Dim query As String = "SELECT NOW() as now_date"
        Dim date_now As String

        query = "SELECT TIME_TO_SEC(TIMEDIFF(NOW(),'" & date_check & "')) as date_now"
        date_now = execute_query(query, 0, True, "", "", "", "")

        Return date_now
    End Function
    'Insert Stock
    Sub insertStock(ByVal id_opt As String, ByVal id_wh_drawer As String, ByVal type_stock As String, ByVal id_objectx As String, ByVal qty As String, ByVal comment As String)
        If id_opt = "1" Then 'sample
            Dim query_upd_storage As String = "INSERT tb_storage_sample(id_wh_drawer, id_storage_category, id_sample, qty_sample, datetime_storage_sample, storage_sample_notes) "
            query_upd_storage += "VALUES('" + id_wh_drawer + "', '" + type_stock + "', '" + id_objectx + "', '" + qty + "', NOW(), '" + comment + "')"
            execute_non_query(query_upd_storage, True, "", "", "", "")
        ElseIf id_opt = "2" Then 'material
            Dim query_upd_storage As String = "INSERT tb_storage_mat(id_wh_drawer, id_storage_category, id_mat_det, storage_mat_qty, storage_mat_datetime, storage_mat_notes) "
            query_upd_storage += "VALUES('" + id_wh_drawer + "', '" + type_stock + "', '" + id_objectx + "', '" + qty + "', NOW(), '" + comment + "')"
            execute_non_query(query_upd_storage, True, "", "", "", "")
        End If
    End Sub
    'New InsertStock
    Sub insertStockNew(ByVal id_opt As String, ByVal id_wh_drawer As String, ByVal type_stock As String, ByVal id_objectx As String, ByVal qty As String, ByVal comment As String, ByVal cost As String, ByVal report_mark_type As String, ByVal id_report As String)
        If id_opt = "1" Then 'Sample

        ElseIf id_opt = "2" Then 'Mat

        ElseIf id_opt = "3" Then 'FG
            Dim query_upd_storage As String = "INSERT tb_storage_fg(id_wh_drawer, id_storage_category, id_product, storage_product_qty, storage_product_datetime, storage_product_notes, bom_unit_price, report_mark_type, id_report) "
            query_upd_storage += "VALUES('" + id_wh_drawer + "', '" + type_stock + "', '" + id_objectx + "', '" + qty + "', NOW(), '" + comment + "', '" + cost + "', '" + report_mark_type + "', '" + id_report + "')"
            execute_non_query(query_upd_storage, True, "", "", "", "")
        End If
    End Sub

    Sub pre_viewImages(ByVal opt As String, ByVal PE As DevExpress.XtraEditors.PictureEdit, ByVal id_goods As String, ByVal is_open As Boolean)
        'opt
        '1 = sample
        '2 = design
        '3 = mat
        '4 = emp
        'change id_goods and dir if something happened
        Dim dir As String = ""
        If opt = "1" Then
            dir = get_setup_field("pic_path_sample") & "\"
        ElseIf opt = "2" Then
            dir = get_setup_field("pic_path_design") & "\"
        ElseIf opt = "3" Then
            dir = get_setup_field("pic_path_mat") & "\"
        ElseIf opt = "4" Then
            dir = get_setup_field("pic_path_emp") & "\"
        End If
        viewImages(PE, dir, id_goods, is_open)
    End Sub
    Sub viewImages(ByVal PE As DevExpress.XtraEditors.PictureEdit, ByVal dir As String, ByVal id_goods As String, ByVal is_open As Boolean)
        If System.IO.File.Exists(dir & id_goods & ".jpg") Then
            If Not is_open Then
                PE.LoadAsync(dir & id_goods & ".jpg")
            Else
                My.Computer.Network.DownloadFile(dir & id_goods & ".jpg", Application.StartupPath & "\imagestemp\" & id_goods & ".jpg", "", "", True, 100, True)
                Process.Start(Application.StartupPath & "\imagestemp\" & id_goods & ".jpg")
            End If
        Else
            If Not is_open Then
                PE.LoadAsync(dir & "default" & ".jpg")
            Else
                My.Computer.Network.DownloadFile(dir & "default" & ".jpg", Application.StartupPath & "\imagestemp\" & "default" & ".jpg", "", "", True, 100, True)
                Process.Start(Application.StartupPath & "\imagestemp\" & "default" & ".jpg")
            End If
        End If
    End Sub

    Sub viewImagesRepo(ByVal PE As DevExpress.XtraEditors.PictureEdit, ByVal dir As String, ByVal id_goods As String, ByVal is_open As Boolean)
        If System.IO.File.Exists(dir & id_goods & ".jpg") Then
            If Not is_open Then
                PE.LoadAsync(dir & id_goods & ".jpg")
            Else
                My.Computer.Network.DownloadFile(dir & id_goods & ".jpg", Application.StartupPath & "\imagestemp\" & id_goods & ".jpg", "", "", True, 100, True)
                Process.Start(Application.StartupPath & "\imagestemp\" & id_goods & ".jpg")
            End If
        Else
            If Not is_open Then
                PE.LoadAsync(dir & "default" & ".jpg")
            Else
                My.Computer.Network.DownloadFile(dir & "default" & ".jpg", Application.StartupPath & "\imagestemp\" & "default" & ".jpg", "", "", True, 100, True)
                Process.Start(Application.StartupPath & "\imagestemp\" & "default" & ".jpg")
            End If
        End If
    End Sub

    Sub viewImagesBarcode(ByVal PE As DevExpress.XtraEditors.PictureEdit, ByVal dir As String, ByVal is_open As Boolean)
        If Not is_open Then
            PE.LoadAsync(dir & "default_barcode" & ".png")
        Else
            Process.Start(dir & "default_barcode" & ".png")
        End If
    End Sub

    '========================coa mapping=======================================
    '========================coa mapping=======================================
    Function get_coa_mapping(ByVal id_coa_mapping As String, ByVal opt As String)
        Dim query As String = ""
        Dim result As String = ""
        If opt = "1" Then 'id_acc
            query = String.Format("SELECT a.id_acc FROM tb_opt_coa_mapping a WHERE a.id_coa_mapping='{0}'", id_coa_mapping)
            result = execute_query(query, 0, True, "", "", "", "")
        ElseIf opt = "2" Then 'acc_name
            query = String.Format("SELECT b.acc_name FROM tb_opt_coa_mapping a LEFT JOIN tb_a_acc b ON a.id_acc=b.id_acc WHERE a.id_coa_mapping='{0}'", id_coa_mapping)
            result = execute_query(query, 0, True, "", "", "", "")
        ElseIf opt = "3" Then 'acc_desc
            query = String.Format("SELECT b.acc_description FROM tb_opt_coa_mapping a LEFT JOIN tb_a_acc b ON a.id_acc=b.id_acc WHERE a.id_coa_mapping='{0}'", id_coa_mapping)
            result = execute_query(query, 0, True, "", "", "", "")
        ElseIf opt = "4" Then 'followed by vendor
            query = String.Format("SELECT a.is_acc_sup FROM tb_opt_coa_mapping a LEFT JOIN tb_a_acc b ON a.id_acc=b.id_acc WHERE a.id_coa_mapping='{0}'", id_coa_mapping)
            result = execute_query(query, 0, True, "", "", "", "")
        ElseIf opt = "5" Then 'id dc
            query = String.Format("SELECT a.id_dc FROM tb_opt_coa_mapping a LEFT JOIN tb_a_acc b ON a.id_acc=b.id_acc WHERE a.id_coa_mapping='{0}'", id_coa_mapping)
            result = execute_query(query, 0, True, "", "", "", "")
        End If

        Return result
    End Function
    Function make_sure_acc(ByVal id_acc_parent As String, ByVal acc_name As String, ByVal acc_description As String)
        Dim id_acc_x As String = ""
        Dim query As String = String.Format("SELECT COUNT(id_acc) FROM tb_a_acc WHERE acc_name='{0}' AND id_acc_parent='{1}'", acc_name, id_acc_parent)
        Dim jml As Integer = execute_query(query, 0, True, "", "", "", "")
        If jml < 1 Then 'create acc
            query = String.Format("INSERT INTO tb_a_acc(acc_name,acc_description,id_acc_parent,id_acc_cat,id_is_det) VALUES('{0}','{1}','{2}',(SELECT a.id_acc_cat FROM tb_a_acc a WHERE a.id_acc='{2}'),'2');SELECT LAST_INSERT_ID(); ", acc_name, acc_description, id_acc_parent)

            id_acc_x = execute_query(query, 0, True, "", "", "", "")

            Return id_acc_x
        Else
            query = String.Format("SELECT id_acc FROM tb_a_acc WHERE acc_name='{0}' AND id_acc_parent='{1}'", acc_name, id_acc_parent)
            id_acc_x = execute_query(query, 0, True, "", "", "", "")

            Return id_acc_x
        End If
    End Function

    '==============FUNCTION QUERY==========================='
    Function getQueryWHDrawer() As String
        Dim query As String = ""
        query += "SELECT ('0') AS id_drawer_def, ('-') AS comp_number, ('All WH') AS comp_name, ('ALL WH') AS comp_name_label UNION ALL "
        query += "SELECT e.id_drawer_def, e.comp_number, e.comp_name, CONCAT_WS(' - ', e.comp_number, e.comp_name) AS comp_name_label FROM tb_st_stock a "
        query += "INNER JOIN tb_m_comp e ON e.id_drawer_def = a.id_wh_drawer "
        query += "GROUP BY e.id_drawer_def "
        Return query
    End Function

    Function getQueryStore() As String
        Dim query As String = ""
        Dim id_comp_cat_store As String = execute_query("SELECT id_comp_cat_store FROM tb_opt", 0, True, "", "", "", "")
        query += "SELECT ('0') AS id_comp, ('-') AS comp_number, ('All WH') AS comp_name, ('ALL Store') AS comp_name_label UNION ALL "
        query += "SELECT a.id_comp, a.comp_number, a.comp_name, CONCAT_WS(' - ', a.comp_number, a.comp_name) AS comp_name_label FROM tb_m_comp a WHERE a.id_comp_cat='" + id_comp_cat_store + "' "
        query += "ORDER BY comp_number ASC "
        Return query
    End Function

    Function getQueryLocator(ByVal id_comp) As String
        Dim query As String = ""
        query += "SELECT ('0') AS id_comp, ('0') AS id_wh_locator, ('-') AS wh_locator_code, ('All Loactor') AS wh_locator, ('-') AS wh_locator_description, ('All Locator') AS locator_label UNION ALL "
        query += "SELECT a.id_comp, a.id_wh_locator, a.wh_locator_code, a.wh_locator, a.wh_locator_description, CONCAT_WS(' - ', a.wh_locator_code, a.wh_locator) AS locator_label FROM tb_m_wh_locator a WHERE a.id_comp = '" + id_comp + "' "
        Return query
    End Function

    Function getRack(ByVal id_locator As String) As String
        Dim query As String = "SELECT ('0') AS id_locator, ('0') AS id_wh_rack, ('-') AS wh_rack_code, ('All Rack') AS wh_rack, ('-') AS wh_rack_description, ('All Rack') AS rack_label UNION ALL "
        query += "SELECT a.id_wh_locator, a.id_wh_rack, a.wh_rack_code, a.wh_rack, a.wh_rack_description, CONCAT_WS(' - ', a.wh_rack_code, a.wh_rack) AS rack_label FROM tb_m_wh_rack a WHERE a.id_wh_locator = '" + id_locator + "' "
        Return query
    End Function

    Function getDrawer(ByVal id_rack As String) As String
        Dim query As String = "SELECT ('0') AS id_rack, ('0') AS id_wh_drawer, ('-') AS wh_drawer_code, ('All Drawer') AS wh_drawer, ('-') AS wh_drawer_description, ('All Drawer') AS drawer_label UNION ALL "
        query += "SELECT a.id_wh_rack, a.id_wh_drawer, a.wh_drawer_code, a.wh_drawer, a.wh_drawer_description, CONCAT_WS(' - ', a.wh_drawer_code, a.wh_drawer) AS drawer_label FROM tb_m_wh_drawer a WHERE a.id_wh_rack = '" + id_rack + "'"
        Return query
    End Function

    Function getStockSum(ByVal id_wh_view As String, ByVal id_wh_locator_view As String, ByVal id_wh_rack_view As String, ByVal id_wh_drawer_view As String)
        Dim query As String = "CALL view_stock_fg('" + id_wh_view + "','" + id_wh_locator_view + "','" + id_wh_rack_view + "','" + id_wh_drawer_view + "', '0','3', '9999-01-01')"
        Return query
    End Function

    Function getOptionView() As String
        Dim query As String = "SELECT * FROM tb_lookup_option_view a ORDER BY a.id_option_view ASC "
        Return query
    End Function

    Function getQueryVendor() As String 'garment or vendor
        Dim query As String = ""
        Dim id_comp_cat_store As String = execute_query("SELECT id_comp_cat_vendor FROM tb_opt", 0, True, "", "", "", "")
        query += "SELECT ('0') AS id_comp, ('-') AS comp_number, ('All Vendor') AS comp_name, ('ALL Vendor') AS comp_name_label UNION ALL "
        query += "SELECT a.id_comp, a.comp_number, a.comp_name, CONCAT_WS(' - ', a.comp_number, a.comp_name) AS comp_name_label FROM tb_m_comp a WHERE a.id_comp_cat='" + id_comp_cat_store + "' "
        query += "ORDER BY comp_number ASC "
        Return query
    End Function

    Function getQueryVendorSimple() As String
        'no all vendor
        Dim query As String = ""
        Dim id_comp_cat_store As String = execute_query("SELECT id_comp_cat_vendor FROM tb_opt", 0, True, "", "", "", "")
        query += "SELECT a.id_comp, a.comp_number, a.comp_name,a.address_primary, CONCAT_WS(' - ', a.comp_number, a.comp_name) AS comp_name_label FROM tb_m_comp a WHERE a.id_comp_cat='" + id_comp_cat_store + "' "
        query += "ORDER BY comp_number ASC "
        Return query
    End Function

    Sub ReportStyleBanded(ByVal BandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView)
        BandedGridView1.OptionsPrint.UsePrintStyles = True
        BandedGridView1.AppearancePrint.BandPanel.Font = New Font(BandedGridView1.Appearance.Row.Font.FontFamily, BandedGridView1.Appearance.Row.Font.Size, FontStyle.Bold)


        BandedGridView1.AppearancePrint.BandPanel.BackColor = Color.Transparent
        BandedGridView1.AppearancePrint.BandPanel.ForeColor = Color.Black
        BandedGridView1.AppearancePrint.BandPanel.Font = New Font("Segoe UI", 6.3, FontStyle.Bold)

        BandedGridView1.AppearancePrint.FilterPanel.BackColor = Color.Transparent
        BandedGridView1.AppearancePrint.FilterPanel.ForeColor = Color.Black
        BandedGridView1.AppearancePrint.FilterPanel.Font = New Font("Segoe UI", 6.3, FontStyle.Regular)

        BandedGridView1.AppearancePrint.GroupFooter.BackColor = Color.Transparent
        BandedGridView1.AppearancePrint.GroupFooter.ForeColor = Color.Black
        BandedGridView1.AppearancePrint.GroupFooter.Font = New Font("Segoe UI", 6.3, FontStyle.Bold)

        BandedGridView1.AppearancePrint.GroupRow.BackColor = Color.Transparent
        BandedGridView1.AppearancePrint.GroupRow.ForeColor = Color.Black
        BandedGridView1.AppearancePrint.GroupRow.Font = New Font("Segoe UI", 6.3, FontStyle.Bold)

        BandedGridView1.AppearancePrint.HeaderPanel.BackColor = Color.Transparent
        BandedGridView1.AppearancePrint.HeaderPanel.ForeColor = Color.Black
        BandedGridView1.AppearancePrint.HeaderPanel.Font = New Font("Segoe UI", 6.3, FontStyle.Bold)

        BandedGridView1.AppearancePrint.FooterPanel.BackColor = Color.Transparent
        BandedGridView1.AppearancePrint.FooterPanel.ForeColor = Color.Black
        BandedGridView1.AppearancePrint.FooterPanel.Font = New Font("Segoe UI", 6.3, FontStyle.Bold)

        BandedGridView1.AppearancePrint.Row.Font = New Font("Segoe UI", 6.3, FontStyle.Regular)

        BandedGridView1.OptionsPrint.ExpandAllDetails = True
        BandedGridView1.OptionsPrint.UsePrintStyles = True
        BandedGridView1.OptionsPrint.PrintDetails = True
        BandedGridView1.OptionsPrint.PrintFooter = True
    End Sub

    Sub ReportStyleGridview(ByVal BandedGridView1 As DevExpress.XtraGrid.Views.Grid.GridView)
        BandedGridView1.OptionsPrint.UsePrintStyles = True

        BandedGridView1.AppearancePrint.FilterPanel.BackColor = Color.Transparent
        BandedGridView1.AppearancePrint.FilterPanel.ForeColor = Color.Black
        BandedGridView1.AppearancePrint.FilterPanel.Font = New Font("Segoe UI", 7, FontStyle.Regular)

        BandedGridView1.AppearancePrint.GroupFooter.BackColor = Color.Transparent
        BandedGridView1.AppearancePrint.GroupFooter.ForeColor = Color.Black
        BandedGridView1.AppearancePrint.GroupFooter.Font = New Font("Segoe UI", 7, FontStyle.Bold)

        BandedGridView1.AppearancePrint.GroupRow.BackColor = Color.Transparent
        BandedGridView1.AppearancePrint.GroupRow.ForeColor = Color.Black
        BandedGridView1.AppearancePrint.GroupRow.Font = New Font("Segoe UI", 7, FontStyle.Bold)


        BandedGridView1.AppearancePrint.HeaderPanel.BackColor = Color.Transparent
        BandedGridView1.AppearancePrint.HeaderPanel.ForeColor = Color.Black
        BandedGridView1.AppearancePrint.HeaderPanel.Font = New Font("Segoe UI", 7, FontStyle.Bold)

        BandedGridView1.AppearancePrint.FooterPanel.BackColor = Color.Transparent
        BandedGridView1.AppearancePrint.FooterPanel.ForeColor = Color.Black
        BandedGridView1.AppearancePrint.FooterPanel.Font = New Font("Segoe UI", 7, FontStyle.Bold)

        BandedGridView1.AppearancePrint.Row.Font = New Font("Segoe UI", 7, FontStyle.Regular)

        BandedGridView1.OptionsPrint.ExpandAllDetails = True
        BandedGridView1.OptionsPrint.UsePrintStyles = True
        BandedGridView1.OptionsPrint.PrintDetails = True
        BandedGridView1.OptionsPrint.PrintFooter = True
    End Sub

    Function getNowDB(ByVal type As String)
        Dim date_default As String = ""
        Dim query_date_def As String = "SELECT DATE(NOW())"
        Dim date_defaultx As Date = execute_query(query_date_def, 0, True, "", "", "", "")
        If type = "1" Then 'for query
            date_default = Date.Parse(date_defaultx.ToString).ToString("yyyy-MM-dd")
        ElseIf type = "2" Then ' for display
            date_default = Date.Parse(date_defaultx.ToString).ToString("dd MMM yyyy")
        End If
        Return date_default
    End Function

    Function GetGroupRowCount(ByVal view As DevExpress.XtraGrid.Views.Grid.GridView) As Integer
        For i As Integer = -1 To Integer.MinValue Step -1
            If Not view.IsValidRowHandle(i) Then
                Return -(i + 1)
            End If
        Next
        Return 0
    End Function
    Function is_coa_posting(ByVal report_mark_type As String)
        Dim is_posting_x As Boolean = False

        Dim query As String = "SELECT is_auto_posting_coa FROM tb_lookup_report_mark_type WHERE report_mark_type='" & report_mark_type & "'"
        Dim is_auto_posting_coa As String = execute_query(query, 0, True, "", "", "", "")
        If is_auto_posting_coa = "1" Then
            ' posting 
            is_posting_x = True
        Else
            is_posting_x = False
        End If

        Return is_posting_x
    End Function

    Function myCoalesce(ByVal par As String, ByVal over_par As String)
        If IsDBNull(par) Or par = "" Or par = Nothing Then
            Return over_par
        Else
            Return par
        End If
    End Function

    Function checkNullInput(ByVal val As String) As String
        Dim res As String = ""
        If val = "" Then
            res = "NULL"
        Else
            res = "'" + addSlashes(val) + "'"
        End If
        Return res
    End Function

    <Runtime.CompilerServices.Extension()>
    Public Sub AddMyMergeBand(Of T)(ByRef arr As T(), ByVal item As T)
        Try
            Array.Resize(arr, arr.Length + 1)
        Catch ex As Exception
            Array.Resize(arr, 1)
        End Try
        arr(arr.Length - 1) = item
    End Sub

    'PROGRES BAR
    Sub progres_bar_update(ByVal progress As Decimal, ByVal max As Decimal)
        'FormMain.RepositoryItemProgressBar1.BeginUpdate()
        'FormMain.RepositoryItemProgressBar1.Step = 1
        'FormMain.RepositoryItemProgressBar1.ShowTitle = True
        'FormMain.RepositoryItemProgressBar1.PercentView = True
        'FormMain.RepositoryItemProgressBar1.Minimum = 0
        'FormMain.RepositoryItemProgressBar1.Maximum = max
        'FormMain.BEProgress.EditValue = progress
        'FormMain.BEProgress.Refresh()
    End Sub

    Sub progres_bar_cus_update(ByRef pgb As ProgressBarControl, ByVal progress As Decimal, ByVal max As Decimal)
        pgb.Properties.Step = 1
        pgb.Properties.PercentView = True
        pgb.Properties.Maximum = max
        pgb.Properties.Minimum = 0
        pgb.EditValue = progress
        pgb.Refresh()
    End Sub

    Sub load_billing_type(ByVal lookup As DevExpress.XtraEditors.LookUpEdit)
        Dim query As String = "SELECT id_bill_type,bill_type FROM tb_lookup_bill_type WHERE is_active='1'"
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")

        lookup.Properties.DataSource = data

        lookup.Properties.DisplayMember = "bill_type"
        lookup.Properties.ValueMember = "id_bill_type"
        lookup.ItemIndex = 0
    End Sub
    Sub load_currency(ByVal lookup As DevExpress.XtraEditors.LookUpEdit)
        Dim query As String = "SELECT id_currency,currency FROM tb_lookup_currency"
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")

        lookup.Properties.DataSource = data

        lookup.Properties.DisplayMember = "currency"
        lookup.Properties.ValueMember = "id_currency"
        lookup.ItemIndex = 0
    End Sub
    Sub te_now_date(ByVal textbox As TextEdit)
        Dim date_now As DateTime
        date_now = Now
        textbox.EditValue = date_now
    End Sub

    Public Function getDefaultLocator(ByVal id_comp_par As String) As String
        Dim query As String = "SELECT IFNULL(id_drawer_def, '-1') AS `id_drawer_def` FROM tb_m_comp where id_comp = '" + id_comp_par + "' "
        Return execute_query(query, 0, True, "", "", "", "")
    End Function

    '----------------NOTIF------------
    Sub playNotify()
        Try
            My.Computer.Audio.Play(Application.StartupPath + "\notify.wav")
        Catch ex As Exception
        End Try
    End Sub


    Sub pushNotif(ByVal notif_title As String, ByVal notif_content As String, ByVal notif_frm_to As String, ByVal id_user_par As String, ByVal id_sender_par As String, ByVal id_report As String, ByVal report_number As String, ByVal notif_tag As String)
        If id_sender_par = "-1" Then
            id_sender_par = "NULL"
        End If
        Dim query_main As String = "INSERT INTO tb_notif(notif_title, notif_content, notif_frm_to, notif_time,id_sender, id_report, report_number, notif_tag) VALUES('" + notif_title + "', '" + notif_content + "', '" + notif_frm_to + "', NOW(), " + id_sender_par + ", '" + id_report + "', '" + report_number + "', '" + notif_tag + "'); SELECT LAST_INSERT_ID(); "
        Dim id_notif As String = execute_query(query_main, 0, True, "", "", "", "")
        Dim query_det As String = ""

        If id_user_par = "0" Then 'kirim ke semua user yg terkait dgn form itu
            query_det += "INSERT INTO tb_notif_det(id_notif, id_user) "
            query_det += "Select '" + id_notif + "',user.id_user "
            query_det += "From tb_menu_acc acc "
            query_det += "INNER Join tb_menu_form_control ctrl ON ctrl.id_form_control = acc.id_form_control "
            query_det += "INNER Join tb_menu_form form On form.id_form = ctrl.id_form "
            query_det += "INNER Join tb_m_user user ON user.id_role = acc.id_role "
            query_det += "WHERE Form.form_name ='" + notif_frm_to + "' AND is_view='1' "
            execute_non_query(query_det, True, "", "", "", "")
        Else
            query_det += "INSERT INTO tb_notif_det(id_notif, id_user) "
            query_det += "VALUES('" + id_notif + "', '" + id_user_par + "') "
            execute_non_query(query_det, True, "", "", "", "")
        End If
    End Sub

    Sub frmNotifOld(ByVal form_par As String)
        Dim ass As String = "VolcomMRP"
        Dim par As String = form_par
        Dim str As String = ass + "." + par
        Dim frm As XtraForm = CType(Activator.CreateInstance(Type.GetType(str)), XtraForm)
        Try
            frm.MdiParent = FormMain
            frm.Show()
            frm.WindowState = FormWindowState.Maximized
            frm.Focus()
        Catch ex As Exception
            errorProcess()
        End Try
    End Sub


    Public Function getTimeDB()
        Dim query As String = "SELECT NOW() as time_now"
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        Return data.Rows(0)("time_now")
    End Function

    Function removeCharacter(ByVal str As String) As String
        Dim MyChar() As Char = {",", ".", "/", "?", "'", "!", " ", "-", "_"}
        Dim NewString As String = str.TrimEnd(MyChar)
        Return NewString
    End Function

    Sub optionsViewBanded(ByVal gv As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView, ByVal frm_name As String, ByVal gv_name As String, ByVal tag_name As String)
        Dim query As String = "SELECT * FROM tb_options_view a "
        query += "INNER JOIN tb_options_view_role b ON a.id_options_view = b.id_options_view "
        query += "INNER JOIN tb_options_view_det c ON c.id_options_view = a.id_options_view "
        query += "WHERE a.options_view_tag='" + tag_name + "' AND a.options_view_form='" + frm_name + "' AND a.options_view_gv='" + gv_name + "' AND b.id_role='" + id_role_login + "'  "
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        If data.Rows.Count > 0 Then
            For i As Integer = 0 To data.Rows.Count - 1
                Dim options_view_det_visible As Boolean = Boolean.Parse(data.Rows(i)("options_view_det_visible").ToString)
                Dim options_view_det_column As String = data.Rows(i)("options_view_det_column").ToString
                gv.Columns(options_view_det_column).Visible = options_view_det_visible
                If options_view_det_visible = False Then
                    gv.Columns(options_view_det_column).OptionsColumn.ShowInCustomizationForm = False
                End If
            Next

            For j As Integer = 0 To gv.Bands.Count - 1
                If gv.Bands(j).Columns.VisibleColumnCount = 0 Then
                    gv.Bands(j).Visible = False
                    gv.Bands(j).OptionsBand.ShowInCustomizationForm = False
                End If
            Next
        End If
    End Sub

    Sub optionsView(ByVal gv As DevExpress.XtraGrid.Views.Grid.GridView, ByVal frm_name As String, ByVal gv_name As String, ByVal tag_name As String)
        Dim query As String = "SELECT * FROM tb_options_view a "
        query += "INNER JOIN tb_options_view_role b ON a.id_options_view = b.id_options_view "
        query += "INNER JOIN tb_options_view_det c ON c.id_options_view = a.id_options_view "
        query += "WHERE a.options_view_tag='" + tag_name + "' AND a.options_view_form='" + frm_name + "' AND a.options_view_gv='" + gv_name + "' AND b.id_role='" + id_role_login + "'  "
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        If data.Rows.Count > 0 Then
            For i As Integer = 0 To data.Rows.Count - 1
                Dim options_view_det_visible As Boolean = Boolean.Parse(data.Rows(i)("options_view_det_visible").ToString)
                Dim options_view_det_column As String = data.Rows(i)("options_view_det_column").ToString
                gv.Columns(options_view_det_column).Visible = options_view_det_visible
                If options_view_det_visible = False Then
                    gv.Columns(options_view_det_column).OptionsColumn.ShowInCustomizationForm = False
                End If
            Next
        End If
    End Sub

    Function getMainVendor(ByVal id_order As String)
        Dim query As String = "SELECT c.id_comp,  cc.id_comp_contact, c.comp_number, c.comp_name, c.address_primary "
        query += "FROM tb_prod_order_wo wo "
        query += "INNER JOIN tb_m_ovh_price ovh ON ovh.id_ovh_price = wo.id_ovh_price "
        query += "INNER JOIN tb_m_comp_contact cc ON cc.id_comp_contact = ovh.id_comp_contact "
        query += "INNER JOIN tb_m_comp c ON c.id_comp = cc.id_comp "
        query += "WHERE wo.id_prod_order='" + id_order + "' AND wo.is_main_vendor='1' LIMIT 1 "
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        Return data
    End Function

    Public Function ConvertToDataTable(Of T)(ByVal list As IList(Of T)) As DataTable
        Dim table As New DataTable()
        Dim fields() As FieldInfo = GetType(T).GetFields()
        For Each field As FieldInfo In fields
            table.Columns.Add(field.Name, field.FieldType)
        Next
        For Each item As T In list
            Dim row As DataRow = table.NewRow()
            For Each field As FieldInfo In fields
                row(field.Name) = field.GetValue(item)
            Next
            table.Rows.Add(row)
        Next
        Return table
    End Function
    Function get_emp(ByVal param As String, ByVal opt As String)
        Dim ret_var As String = ""
        If opt = "1" Then 'get id_employee from nip
            Dim query As String = "SELECT id_employee FROM tb_m_employee WHERE employee_code='" + param + "' LIMIT 1"
            ret_var = execute_query(query, 0, True, "", "", "", "")
        End If
        Return ret_var
    End Function

    Public Function GetCurrentAge(ByVal dob As Date, ByVal start As Date) As Integer
        Dim age As Integer
        age = start.Year - dob.Year
        If (dob > start.AddYears(-age)) Then age -= 1
        Return age
    End Function

    Public Function getIdSt()
        Dim id As String = execute_query("SELECT st_inc FROM tb_opt", 0, False, app_host_main, app_username_main, app_password_main, app_database_main)
        Dim query As String = "UPDATE tb_opt SET st_inc=(tb_opt.st_inc+1)"
        execute_non_query(query, False, app_host_main, app_username_main, app_password_main, app_database_main)
        Return id
    End Function

    Public Sub initialServerCentre()
        Dim query As String = "SELECT * FROM tb_opt"
        Dim data As DataTable = execute_query(query, -1, False, app_host, app_username, app_password, "db_opt")
        app_host_main = data.Rows(0)("host_main").ToString
        app_username_main = data.Rows(0)("user_main").ToString
        app_password_main = data.Rows(0)("password_main").ToString
        app_database_main = data.Rows(0)("db_main").ToString
    End Sub
End Module