Public Class Adm_FakultasProdi
    Private Sub btnDasboard_Click(sender As Object, e As EventArgs) Handles btnDasboard.Click
        DashboardAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub btnMahasiswa_Click(sender As Object, e As EventArgs) Handles btnMahasiswa.Click
        Adm_Mahasiswa.Show()
        Me.Hide()
    End Sub

    Private Sub btnDosen_Click(sender As Object, e As EventArgs) Handles btnDosen.Click
        Adm_Dosen.Show()
        Me.Hide()
    End Sub

    Private Sub btnFakultasProdi_Click(sender As Object, e As EventArgs) Handles btnFakultasProdi.Click

    End Sub

    Private Sub btnRuangan_Click(sender As Object, e As EventArgs) Handles btnRuangan.Click
        Adm_Ruangan.Show()
        Me.Hide()
    End Sub

    Private Sub btnSemester_Click(sender As Object, e As EventArgs) Handles btnSemester.Click
        Adm_Semester.Show()
        Me.Hide()
    End Sub

    Private Sub btnJadwalPerkuliahan_Click(sender As Object, e As EventArgs) Handles btnJadwalPerkuliahan.Click
        Adm_JadwalPerkuliahan.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Application.Exit()
    End Sub

    Private Sub Adm_FakultasProdi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class