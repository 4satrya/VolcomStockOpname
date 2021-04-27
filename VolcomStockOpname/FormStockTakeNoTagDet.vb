Public Class FormStockTakeNoTagDet
    Public id_st_no_tag As String = "-1"

    Private Sub FormStockTakeNoTagDet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'check login store
        Dim is_login_store As String = "2"

        Try
            is_login_store = execute_query("SELECT is_login_store FROM tb_opt", 0, False, app_host, app_username, app_password, "db_opt")
        Catch ex As Exception
            is_login_store = "2"
        End Try

        If is_login_store = "1" Then
            LookAndFeel.SkinMaskColor = Color.LightBlue
            LookAndFeel.UseDefaultLookAndFeel = False
        End If

        viewSearchLookupQuery(SLUESize, "
            (SELECT '' AS display_name)
            UNION ALL
            (SELECT display_name FROM tb_m_code_detail WHERE id_code = 33)
        ", "display_name", "display_name", "display_name")
    End Sub

    Private Sub SBClose_Click(sender As Object, e As EventArgs) Handles SBClose.Click
        Close()
    End Sub

    Private Sub SBSave_Click(sender As Object, e As EventArgs) Handles SBSave.Click
        If TEName.Text = "" Or TECode.Text = "" Or SLUESize.Text = "" Then
            stopCustom("Please check your input.")
        Else
            execute_non_query("INSERT INTO tb_st_no_tag_det (id_st_no_tag, code, name, size) VALUES (" + id_st_no_tag + ", '" + addSlashes(TECode.EditValue) + "', '" + addSlashes(TEName.EditValue) + "', '" + addSlashes(SLUESize.EditValue) + "')", True, "", "", "", "")

            FormStockTakeNoTag.form_load()

            TEName.EditValue = ""
            TECode.EditValue = ""
            SLUESize.EditValue = ""
        End If
    End Sub

    Private Sub FormStockTakeNoTagDet_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub TEName_KeyDown(sender As Object, e As KeyEventArgs) Handles TEName.KeyDown
        If e.KeyCode = Keys.Enter Then
            SBSave_Click(SBSave, New EventArgs)
        End If
    End Sub

    Private Sub TECode_KeyDown(sender As Object, e As KeyEventArgs) Handles TECode.KeyDown
        If e.KeyCode = Keys.Enter Then
            check_product()
        Else
            TEName.EditValue = ""
            SLUESize.EditValue = ""
        End If
    End Sub

    Sub check_product()
        Dim length As String = TECode.EditValue.ToString.Length.ToString

        TEName.EditValue = ""
        SLUESize.EditValue = ""

        If length = "9" Or length = "12" Then
            Dim product_count As String = execute_query("SELECT COUNT(*) FROM tb_m_product WHERE LEFT(product_full_code, " + length + ") = '" + TECode.EditValue.ToString + "'", 0, True, "", "", "", "")

            If Not product_count = "0" Then
                Dim design_name As String = execute_query("SELECT design_display_name FROM tb_m_design WHERE design_code = LEFT('" + TECode.EditValue.ToString + "', 9)", 0, True, "", "", "", "")

                TEName.EditValue = design_name

                SLUESize.ReadOnly = False

                If length = "12" Then
                    Dim size As String = execute_query("
                        SELECT d.display_name
                        FROM tb_m_product AS p
                        LEFT JOIN tb_m_code_detail AS d ON p.product_code = d.code AND d.id_code = 33
                        WHERE p.product_full_code = '" + TECode.EditValue.ToString + "'
                    ", 0, True, "", "", "", "")

                    SLUESize.EditValue = size

                    SLUESize.ReadOnly = True
                End If
            Else
                stopCustom("Product not found.")
            End If
        Else
            stopCustom("Please input 9 or 12 digit code.")
        End If
    End Sub
End Class