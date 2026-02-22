Public Class TambahJadwal_Adm
    Private Sub btnSimpanData_Click(sender As Object, e As EventArgs) Handles btnSimpanData.Click
        ' Cek apakah semua ComboBox sudah dipilih
        If cmbFakultas.SelectedIndex = -1 OrElse cmbProgramStudi.SelectedIndex = -1 OrElse
           cmbMataKuliah.SelectedIndex = -1 OrElse cmbDosen.SelectedIndex = -1 OrElse
           cmbRuang.SelectedIndex = -1 OrElse cmbHari.SelectedIndex = -1 OrElse
           cmbJamMulai.SelectedIndex = -1 OrElse cmbJamSelesai.SelectedIndex = -1 Then

            MessageBox.Show("Harap lengkapi semua data sebelum menyimpan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Ambil data dari ComboBox
        Dim fakultas As String = cmbFakultas.SelectedItem.ToString()
        Dim programstudi As String = cmbProgramStudi.SelectedItem.ToString()
        Dim mataKuliah As String = cmbMataKuliah.SelectedItem.ToString()
        Dim dosen As String = cmbDosen.SelectedItem.ToString()
        Dim ruang As String = cmbRuang.SelectedItem.ToString()
        Dim hari As String = cmbHari.SelectedItem.ToString()
        Dim jamMulai As String = cmbJamMulai.SelectedItem.ToString()
        Dim jamSelesai As String = cmbJamSelesai.SelectedItem.ToString()

        ' Cari form Adm_JadwalPerkuliahan
        Dim jadwalForm As Adm_JadwalPerkuliahan = Nothing
        For Each f As Form In Application.OpenForms
            If TypeOf f Is Adm_JadwalPerkuliahan Then
                jadwalForm = CType(f, Adm_JadwalPerkuliahan)
                Exit For
            End If
        Next

        If jadwalForm IsNot Nothing Then
            ' Pastikan DataGridView sudah memiliki kolom yang sesuai
            ' Kolom: Fakultas, Program Studi, Mata Kuliah, Dosen, Ruang, Hari, Jam Mulai, Jam Selesai
            Dim dgv As DataGridView = jadwalForm.dgvJadwalPerkuliahan  ' ganti sesuai nama DataGridView
            dgv.Rows.Add(fakultas, programstudi, mataKuliah, dosen, ruang, hari, jamMulai, jamSelesai)

            MessageBox.Show("Data berhasil ditambahkan ke Jadwal Perkuliahan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Form Adm_JadwalPerkuliahan belum dibuka.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
