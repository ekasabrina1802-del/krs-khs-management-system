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

    Private Sub btnFakultasProdi_Click_1(sender As Object, e As EventArgs) Handles btnFakultasProdi.Click
        Adm_FakultasProdi.Show()
        Me.Hide()
    End Sub

    Private Sub btnRuangan_Click_1(sender As Object, e As EventArgs) Handles btnRuangan.Click
        Adm_Ruangan.Show()
        Me.Hide()
    End Sub

    Private Sub btnSemester_Click(sender As Object, e As EventArgs) Handles btnSemester.Click
        Adm_Semester.Show()
        Me.Hide()
    End Sub

    Private Sub btnJadwalPerkuliahan_Click_1(sender As Object, e As EventArgs) Handles btnJadwalPerkuliahan.Click
        Adm_JadwalPerkuliahan.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click_1(sender As Object, e As EventArgs) Handles btnLogout.Click
        Application.Exit()
    End Sub
End Class