Public Class Login

    Private adminUser As String = "admin"
    Private adminPass As String = "12345"

    Private mhsUser As String = "mahasiswa"
    Private mhsPass As String = "67890"
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        If username = adminUser And password = adminPass Then
            DashboardAdmin.Show()
            Me.Hide()

            ' Login Mahasiswa
        ElseIf username = mhsUser And password = mhsPass Then
            DasboardMahasiswa.Show()
            Me.Hide()

            ' Jika salah
        Else
            MessageBox.Show("Username atau Password salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class