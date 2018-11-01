Public Class Registration
    Private Sub picBoxRegBk_Click(sender As Object, e As EventArgs) Handles picBoxRegBk.Click
        Hide()
        Login.Show()
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        If txtBoxFName.TextLength > 0 Then
            If txtBoxSName.TextLength > 0 Then
                If txtBoxDOB.TextLength > 0 Then
                    If txtBoxAge.TextLength > 0 Then
                        If txtBoxRegUser.TextLength > 0 Then
                            If txtBoxRegPass.TextLength > 0 Then
                                Hide()
                                txtBoxFName.Clear()
                                txtBoxSName.Clear()
                                txtBoxDOB.Clear()
                                txtBoxAge.Clear()
                                txtBoxRegUser.Clear()
                                txtBoxRegPass.Clear()
                                Login.Show()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub
End Class