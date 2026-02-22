Public Class Mhs_KHS

    Private Sub btnLMS_Click_1(sender As Object, e As EventArgs) Handles btnLMS.Click
        Mhs_LMS.Show()
        Me.Hide()
    End Sub

    Private Sub btnDasboard_Click_1(sender As Object, e As EventArgs) Handles btnDasboard.Click
        DasboardMahasiswa.Show()
        Me.Hide()
    End Sub

    Private Sub btnJadwalPerkuliahan_Click_1(sender As Object, e As EventArgs) Handles btnJadwalPerkuliahan.Click
        Mhs_JadwalPerkuliahan.Show()
        Me.Hide()
    End Sub

    Private Sub btnKRS_Click_1(sender As Object, e As EventArgs) Handles btnKRS.Click
        Mhs_KRS.Show()
        Me.Hide()
    End Sub

    Private Sub btnKHS_Click_1(sender As Object, e As EventArgs) Handles btnKHS.Click

    End Sub

    Private Sub btnLogout_Click_1(sender As Object, e As EventArgs) Handles btnLogout.Click
        Application.Exit()
    End Sub
End Class