Public Class MainHub
    Private Sub picBoxSetngs_Click(sender As Object, e As EventArgs) Handles picBoxSetngs.Click
        Hide()
        Settings.Show()
    End Sub

    Private Sub picBoxHelp_Click(sender As Object, e As EventArgs) Handles picBoxHelp.Click
        Hide()
        Help.Show()
    End Sub
End Class