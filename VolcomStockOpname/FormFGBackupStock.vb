Public Class FormFGBackupStock
    Dim bnew_active As String = "1"
    Dim bedit_active As String = "1"
    Dim bdel_active As String = "1"

    Private Sub FormFGBackupStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewSt()
    End Sub

    Sub viewSt()
        Cursor = Cursors.WaitCursor
        Dim st As New ClassStockTake()
        Dim query As String = st.queryMain("-1", "1")
        Dim data As DataTable = execute_query(query, -1, False, app_host_main, app_username_main, app_password_main, app_database_main)
        GCPeriod.DataSource = data
        Cursor = Cursors.Default
    End Sub



    Sub check_menu()
        'If GVPeriod.RowCount < 1 Then
        '    'hide all except new
        '    bnew_active = "1"
        '    bedit_active = "0"
        '    bdel_active = "0"
        '    checkFormAccess(Name)
        '    button_main(bnew_active, bedit_active, bdel_active)
        '    noManipulating()
        'Else
        '    'show all
        '    bnew_active = "1"
        '    bedit_active = "1"
        '    bdel_active = "1"
        '    checkFormAccess(Name)
        '    button_main(bnew_active, bedit_active, bdel_active)
        '    noManipulating()
        'End If
    End Sub

    Sub noManipulating()
        Dim indeks As Integer = 0
        Try
            indeks = GVPeriod.FocusedRowHandle
        Catch ex As Exception
        End Try
        If indeks < 0 Then
            bnew_active = "1"
            bedit_active = "0"
            bdel_active = "0"
        Else
            bnew_active = "1"
            bedit_active = "1"
            bdel_active = "1"
        End If
        'checkFormAccess(Name)
        'button_main(bnew_active, bedit_active, bdel_active)
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
        Dispose()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        FormFGBackupStockDet.action = "ins"
        FormFGBackupStockDet.ShowDialog()
    End Sub
End Class