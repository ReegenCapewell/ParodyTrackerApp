Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtBoxUsername.Text = "Admin" Then
            If txtBoxPass.Text = "Password" Then
                lblCredentials.Hide()
                Hide()
                txtBoxUsername.Clear()
                txtBoxPass.Clear()
                MainHub.Show()
            Else
                lblCredentials.Show()
            End If
        Else
            lblCredentials.Show()
        End If
    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        Hide()
        Registration.Show()
    End Sub
End Class
