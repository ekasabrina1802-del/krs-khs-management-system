Public Class Adm_JadwalPerkuliahan
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
        Adm_FakultasProdi.Show()
        Me.Hide()
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

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Application.Exit()
    End Sub

    Private Sub cmbSemester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSemester.SelectedIndexChanged

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        TambahJadwal_Adm.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvJadwalPerkuliahan.SelectedRows.Count = 0 Then
            MessageBox.Show("Silakan pilih baris yang akan diedit.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Ambil index baris yang dipilih
        Dim rowIndex As Integer = dgvJadwalPerkuliahan.SelectedRows(0).Index

        ' Buka form Edit dan kirim data
        Dim editForm As New EditJadwalAdm()
        editForm.MainForm = Me  ' ✅ kirim form utama ke form edit
        editForm.RowIndex = rowIndex

        With dgvJadwalPerkuliahan.Rows(rowIndex)
            editForm.FakultasValue = .Cells(0).Value.ToString()
            editForm.ProgramStudiValue = .Cells(1).Value.ToString()
            editForm.MataKuliahValue = .Cells(2).Value.ToString()
            editForm.DosenValue = .Cells(3).Value.ToString()
            editForm.RuangValue = .Cells(4).Value.ToString()
            editForm.HariValue = .Cells(5).Value.ToString()
            editForm.JamMulaiValue = .Cells(6).Value.ToString()
            editForm.JamSelesaiValue = .Cells(7).Value.ToString()
        End With

        editForm.ShowDialog()
    End Sub


    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If dgvJadwalPerkuliahan.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih data yang ingin dihapus dulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            dgvJadwalPerkuliahan.Rows.Remove(dgvJadwalPerkuliahan.SelectedRows(0))
            MessageBox.Show("Data berhasil dihapus.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class