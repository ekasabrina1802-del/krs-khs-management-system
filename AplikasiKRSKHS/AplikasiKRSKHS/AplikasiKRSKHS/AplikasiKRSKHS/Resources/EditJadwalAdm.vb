Public Class EditJadwalAdm

    '--- Property untuk menerima data dari form utama ---

    Public MainForm As Adm_JadwalPerkuliahan
    Public RowIndex As Integer
    Public FakultasValue As String
    Public ProgramStudiValue As String
    Public MataKuliahValue As String
    Public DosenValue As String
    Public RuangValue As String
    Public HariValue As String
    Public JamMulaiValue As String
    Public JamSelesaiValue As String


    '--- Saat form dibuka, langsung isi ComboBox sesuai data lama ---
    Private Sub EditJadwalAdm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbFakultas.Text = FakultasValue
        cmbProgramStudi.Text = ProgramStudiValue
        cmbMataKuliah.Text = MataKuliahValue
        cmbDosen.Text = DosenValue
        cmbRuang.Text = RuangValue
        cmbHari.Text = HariValue
        cmbJamMulai.Text = JamMulaiValue
        cmbJamSelesai.Text = JamSelesaiValue
    End Sub


    '--- Ketika tombol SIMPAN diklik ---
    Private Sub btnSimpanData_Click(sender As Object, e As EventArgs) Handles btnSimpanData.Click

        ' Validasi kalau ada ComboBox yang belum dipilih
        If cmbFakultas.SelectedIndex = -1 OrElse
           cmbProgramStudi.SelectedIndex = -1 OrElse
           cmbMataKuliah.SelectedIndex = -1 OrElse
           cmbDosen.SelectedIndex = -1 OrElse
           cmbRuang.SelectedIndex = -1 OrElse
           cmbHari.SelectedIndex = -1 OrElse
           cmbJamMulai.SelectedIndex = -1 OrElse
           cmbJamSelesai.SelectedIndex = -1 Then

            MessageBox.Show("Harap lengkapi semua data sebelum menyimpan.",
                            "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Pastikan MainForm dan row yang dipilih valid
        If MainForm IsNot Nothing AndAlso
   MainForm.dgvJadwalPerkuliahan.Rows.Count > RowIndex Then

            With MainForm.dgvJadwalPerkuliahan.Rows(RowIndex)

                .Cells(0).Value = cmbFakultas.Text
                .Cells(1).Value = cmbProgramStudi.Text
                .Cells(2).Value = cmbMataKuliah.Text
                .Cells(3).Value = cmbDosen.Text
                .Cells(4).Value = cmbRuang.Text
                .Cells(5).Value = cmbHari.Text
                .Cells(6).Value = cmbJamMulai.Text
                .Cells(7).Value = cmbJamSelesai.Text
            End With

            MessageBox.Show("Perubahan berhasil disimpan.",
                            "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Tidak bisa mengakses data yang akan diedit.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class
