Public Class Mhs_KRS
    Private Sub btnDasboard_Click(sender As Object, e As EventArgs) Handles btnDasboard.Click
        DasboardMahasiswa.Show()
        Me.Hide()
    End Sub

    Private Sub btnJadwalPerkuliahan_Click(sender As Object, e As EventArgs) Handles btnJadwalPerkuliahan.Click
        Mhs_JadwalPerkuliahan.Show()
        Me.Hide()
    End Sub

    Private Sub btnKRS_Click(sender As Object, e As EventArgs) Handles btnKRS.Click

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
End Class