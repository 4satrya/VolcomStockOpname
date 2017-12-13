Public Class ClassDesign
    Function getDesign(ByVal cond_param As String) As DataTable
        If cond_param = "-1" Then
            cond_param = ""
        End If
        Dim query As String = "SELECT * FROM tb_m_design d WHERE d.id_design>0 " + cond_param + " "
        Dim dt As DataTable = execute_query(query, -1, True, "", "", "", "")
        Return dt
    End Function
End Class