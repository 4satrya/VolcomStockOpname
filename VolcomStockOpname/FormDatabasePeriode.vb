Public Class FormDatabasePeriode
    Public action As String = ""
    Public id As String = ""

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Close()
    End Sub

    Private Sub FormDatabasePeriode_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub FormDatabasePeriode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If action = "upd" Then
            Dim query As String = "SELECT * FROM tb_periode WHERE id_periode='" + id + "' ORDER BY id_periode ASC"
            Dim data As DataTable = execute_query(query, -1, False, app_host, app_username, app_password, "db_opt")
            TextEdit1.Text = data.Rows(0)("description").ToString
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim query As String = ""
        If action = "ins" Then
            query = "INSERT INTO tb_periode(description) VALUES('" + addSlashes(TextEdit1.Text) + "')"
        Else
            query = "UPDATE tb_periode SET description='" + addSlashes(TextEdit1.Text) + "' WHERE id_periode='" + id + "'"
        End If
        execute_non_query(query, False, app_host, app_username, app_password, "db_opt")
        FormDatabaseUI.view_periode()
        Close()
    End Sub
End Class