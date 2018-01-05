Public Class FormStart
    Private Sub FormStart_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Cursor = Cursors.WaitCursor
        FormLogin.id_menu = "1"
        FormLogin.is_first = "1"
        FormLogin.ShowDialog()
        Close()
        Cursor = Cursors.Default
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        End
    End Sub

    Private Sub FormStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'initial server centre
        initialServerCentre()
    End Sub
End Class