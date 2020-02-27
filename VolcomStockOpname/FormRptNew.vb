Public Class FormRptNew
    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        Dim query_no As String = "SELECT CONCAT(LPAD(COUNT(p.id_rpt)+1 ,5,'0'),'/', convert_romawi(MONTH(NOW())),'/',YEAR(NOW())) AS `numb`
		FROM tb_rpt p
		WHERE MONTH(p.rpt_created_date)=MONTH(NOW()) AND YEAR(p.rpt_created_date)=YEAR(NOW()); "
        Dim numb As String = execute_query(query_no, 0, False, app_host, app_username, app_password, "db_opt")
        Dim qry As String = "INSERT INTO tb_rpt(rpt_number, rpt_note, rpt_created_date, rpt_created_by) 
        VALUES('" + numb + "', '" + addSlashes(MENote.Text) + "', NOW(), '" + addSlashes(name_user) + "'); "
        execute_non_query(qry, False, app_host, app_username, app_password, "db_opt")
        infoCustom("Report : " + numb + " created successfully ")
        FormRpt.viewData()
        Close()
    End Sub

    Private Sub FormRptNew_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub
End Class