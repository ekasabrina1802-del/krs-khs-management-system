Public Class Mhs_JadwalPerkuliahan
    Private Sub Mhs_JadwalPerkuliahan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDasboard_Click(sender As Object, e As EventArgs) Handles btnDasboard.Click
        DasboardMahasiswa.Show()
        Me.Hide()
    End Sub

    Private Sub btnJadwalPerkuliahan_Click(sender As Object, e As EventArgs) Handles btnJadwalPerkuliahan.Click

    End Sub

    Private Sub btnKRS_Click(sender As Object, e As EventArgs) Handles btnKRS.Click
        Mhs_KRS.Show()
        Me.Hide()
    End Sub

    Private Sub btnKHS_Click(sender As Object, e As EventArgs) Handles btnKHS.Click
        Mhs_KHS.Show()
        Me.Hide()
    End Sub

    Private Sub btnLMS_Click(sender As Object, e As EventArgs) Handles btnLMS.Click
        Mhs_LMS.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Application.Exit()
    End Sub

    'Private Sub lst_Jadwal_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    'Kosong, biarkan saja
    'End Sub
End Class
