Public Class Settings
    Private Sub picBoxSetBk_Click(sender As Object, e As EventArgs) Handles picBoxSetBk.Click
        Hide()
        MainHub.Show()
    End Sub

    Private Sub picBoxSignOut_Click(sender As Object, e As EventArgs) Handles picBoxSignOut.Click
        Hide()
        Login.Show()
    End Sub

    Private Sub picBoxHome_Click(sender As Object, e As EventArgs) Handles picBoxHome.Click
        Hide()
        SetHome.Show()
    End Sub

    Private Sub picBoxRadius_Click(sender As Object, e As EventArgs) Handles picBoxRadius.Click
        Hide()
        SetRadius.Show()
    End Sub

    Private Sub picBoxCurfew_Click(sender As Object, e As EventArgs) Handles picBoxCurfew.Click
        Hide()
        SetCurfew.Show()
    End Sub
End Class