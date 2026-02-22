Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms

Public Class Adm_MataKuliah

    ' =======================================================
    ' KONSTANTA & KONFIGURASI
    ' =======================================================

    ' Connection String Anda
    Private Const CONNECTION_STRING As String = "Data Source=LAPTOP-N3HRLL7J;Initial Catalog=DB_KRS_KHS;Integrated Security=True;"

    ' =======================================================
    ' FUNGSI UTAMA & LOAD DATA
    ' =======================================================

    Private Sub Adm_MataKuliah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If dgvMataKuliah Is Nothing Then
            MessageBox.Show("Kontrol dgvMataKuliah tidak ditemukan di form. Cek nama kontrol Anda.", "Error Fatal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        LoadDataJadwal()
    End Sub

    ' Fungsi untuk memuat data GABUNGAN (JOIN) dari database
    Public Sub LoadDataJadwal()
        If dgvMataKuliah Is Nothing Then Return

        dgvMataKuliah.DataSource = Nothing
        dgvMataKuliah.Columns.Clear()

        ' Kueri SQL: Mengambil semua kolom yang dibutuhkan
        Dim sql As String = "
        SELECT 
            J.IDJadwal, 
            J.Kode, 
            M.MataKuliah, 
            M.SKS,
            J.Kelas,
            J.Ruang,
            J.Hari,
            FORMAT(J.JamMulai, 'hh\:mm') AS JamMulai,
            FORMAT(J.JamSelesai, 'hh\:mm') AS JamSelesai
        FROM 
            Tbl_JadwalPerkuliahan J 
        INNER JOIN 
            Tbl_MataKuliah M ON J.Kode = M.Kode
        ORDER BY J.Hari, J.JamMulai"

        Using conn As New SqlConnection(CONNECTION_STRING)
            Using da As New SqlDataAdapter(sql, conn)
                Dim dt As New DataTable()
                Try
                    da.Fill(dt)

                    dgvMataKuliah.DataSource = dt

                    SetupDataGridViewColumns()

                Catch ex As Exception
                    MessageBox.Show("Gagal memuat data jadwal perkuliahan! Pastikan koneksi dan service SQL Server berjalan. Error: " & ex.Message, "Error Load Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    ' Fungsi untuk mengatur DataGridView setelah data terikat
    Private Sub SetupDataGridViewColumns()
        If dgvMataKuliah.DataSource Is Nothing OrElse dgvMataKuliah.Columns.Count = 0 Then Return

        Try
            ' 1. Sembunyikan kolom IDJadwal (Kunci Utama)
            If dgvMataKuliah.Columns.Contains("IDJadwal") Then
                dgvMataKuliah.Columns("IDJadwal").Visible = False
            End If

            ' 2. Atur Header Text (menggunakan nama kolom SQL: MataKuliah, SKS, JamMulai, JamSelesai)
            If dgvMataKuliah.Columns.Contains("MataKuliah") Then dgvMataKuliah.Columns("MataKuliah").HeaderText = "Mata Kuliah"
            If dgvMataKuliah.Columns.Contains("SKS") Then dgvMataKuliah.Columns("SKS").HeaderText = "SKS"
            If dgvMataKuliah.Columns.Contains("JamMulai") Then dgvMataKuliah.Columns("JamMulai").HeaderText = "Jam Mulai"
            If dgvMataKuliah.Columns.Contains("JamSelesai") Then dgvMataKuliah.Columns("JamSelesai").HeaderText = "Jam Selesai"

            ' 3. Pengaturan Umum
            dgvMataKuliah.ReadOnly = True
            dgvMataKuliah.AllowUserToAddRows = False
            dgvMataKuliah.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvMataKuliah.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)

        Catch ex As Exception
            MessageBox.Show("Gagal mengatur kolom DataGridView: " & ex.Message, "Error Tampilan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    ' Fungsi untuk menghapus data JADWAL (berdasarkan IDJadwal)
    Private Function DeleteDataJadwal(ByVal idJadwal As Integer) As Boolean
        Dim sql As String = "DELETE FROM Tbl_JadwalPerkuliahan WHERE IDJadwal = @IDJadwal"

        Using conn As New SqlConnection(CONNECTION_STRING)
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@IDJadwal", idJadwal)

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    Return True
                Catch ex As SqlException
                    MessageBox.Show("Gagal menghapus data jadwal! Pastikan jadwal tidak terikat pada KRS Mahasiswa. Error: " & ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End Try
            End Using
        End Using
    End Function

    ' =======================================================
    ' EVENT MENU NAVIGASI LAINNYA
    ' =======================================================
    ' (Bagian ini dibiarkan sesuai kode Anda)

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

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Application.Exit()
    End Sub
    ' =======================================================
    ' EVENT HANDLER TAMBAH, EDIT, HAPUS
    ' =======================================================

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        ' Menggunakan TambahJadwal_Adm
        Dim tambahForm As New TambahJadwal_Adm()
        tambahForm.MainForm = Me

        tambahForm.ShowDialog()
        LoadDataJadwal() ' Muat ulang data setelah ditutup
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvMataKuliah Is Nothing OrElse dgvMataKuliah.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih baris data yang ingin diubah.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedRow As DataGridViewRow = dgvMataKuliah.SelectedRows(0)
        Dim idJadwalValue As Integer

        ' 📌 PERBAIKAN: Pengecekan kolom dan nilai yang lebih aman
        If Not dgvMataKuliah.Columns.Contains("IDJadwal") OrElse selectedRow.Cells("IDJadwal").Value Is Nothing OrElse
           Not Integer.TryParse(selectedRow.Cells("IDJadwal").Value.ToString(), idJadwalValue) Then

            MessageBox.Show("Data ID Jadwal tidak valid atau tidak ditemukan.", "Error Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim editForm As New TambahJadwal_Adm()
        editForm.MainForm = Me

        ' Kirim data ke form edit
        editForm.IsEditMode = True
        editForm.IDJadwalValue = idJadwalValue

        ' 📌 PERBAIKAN: Mengambil data menggunakan NAMA KOLOM SQL (MataKuliah, JamMulai, dsb.)
        ' Menggunakan operator If() untuk menangani nilai NULL/DBNull dengan aman
        editForm.KodeValue = If(selectedRow.Cells("Kode").Value, "").ToString()
        editForm.MataKuliahValue = If(selectedRow.Cells("MataKuliah").Value, "").ToString()

        ' Pengambilan SKS
        Dim sks_temp As Integer = 0
        If selectedRow.Cells("SKS").Value IsNot Nothing AndAlso Integer.TryParse(selectedRow.Cells("SKS").Value.ToString(), sks_temp) Then
            editForm.SKSValue = sks_temp
        Else
            editForm.SKSValue = 0 ' Default jika gagal parsing
        End If

        editForm.KelasValue = If(selectedRow.Cells("Kelas").Value, "").ToString()
        editForm.RuangValue = If(selectedRow.Cells("Ruang").Value, "").ToString()
        editForm.HariValue = If(selectedRow.Cells("Hari").Value, "").ToString()
        editForm.JamMulaiValue = If(selectedRow.Cells("JamMulai").Value, "").ToString()
        editForm.JamSelesaiValue = If(selectedRow.Cells("JamSelesai").Value, "").ToString()

        editForm.ShowDialog()
        LoadDataJadwal() ' Muat ulang data setelah ditutup
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If dgvMataKuliah Is Nothing OrElse dgvMataKuliah.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih data yang ingin dihapus dulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus jadwal ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim selectedRow As DataGridViewRow = dgvMataKuliah.SelectedRows(0)
            Dim idJadwalToDelete As Integer

            If dgvMataKuliah.Columns.Contains("IDJadwal") AndAlso Integer.TryParse(selectedRow.Cells("IDJadwal").Value.ToString(), idJadwalToDelete) Then

                If DeleteDataJadwal(idJadwalToDelete) Then
                    LoadDataJadwal() ' Muat ulang data
                    MessageBox.Show("Jadwal perkuliahan berhasil dihapus.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Gagal mengambil ID Jadwal dari baris terpilih.", "Error Hapus", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

End Class