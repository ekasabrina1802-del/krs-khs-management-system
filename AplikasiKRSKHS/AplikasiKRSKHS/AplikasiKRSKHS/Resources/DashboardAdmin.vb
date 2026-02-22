Public Class DashboardAdmin

    Private Sub btnDasboard_Click(sender As Object, e As EventArgs) Handles btnDasboard.Click

    End Sub

    Private Sub btnMahasiswa_Click_1(sender As Object, e As EventArgs) Handles btnMahasiswa.Click
        Adm_Mahasiswa.Show()
        Me.Hide()
    End Sub

    Private Sub btnDosen_Click_1(sender As Object, e As EventArgs) Handles btnDosen.Click
        Adm_Dosen.Show()
        Me.Hide()
    End Sub

    Private Sub btnMataKuliah_Click_1(sender As Object, e As EventArgs) Handles btnMataKuliah.Click
        Adm_MataKuliah.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click_1(sender As Object, e As EventArgs) Handles btnLogout.Click
        Application.Exit()
    End Sub
End Class