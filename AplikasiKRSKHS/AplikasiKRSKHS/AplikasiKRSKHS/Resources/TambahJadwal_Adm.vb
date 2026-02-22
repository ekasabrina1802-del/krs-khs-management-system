Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms

Public Class TambahJadwal_Adm

    ' =======================================================
    ' KONSTANTA & KONFIGURASI
    ' =======================================================

    ' Connection String Anda
    Private Const CONNECTION_STRING As String = "Data Source=LAPTOP-N3HRLL7J;Initial Catalog=DB_KRS_KHS;Integrated Security=True;"

    ' Konstanta untuk pesan
    Private Const MSG_REQUIRED As String = "Harap lengkapi semua data sebelum menyimpan!"
    Private Const MSG_DB_ERROR As String = "Gagal memproses data jadwal di database. Error: "

    ' Variabel & Properti 
    Public Property MainForm As Adm_MataKuliah
    Public Property IsEditMode As Boolean = False

    ' Properti untuk data yang dikirim dari Adm_MataKuliah saat EDIT
    Public Property IDJadwalValue As Integer
    Public Property KodeValue As String
    Public Property MataKuliahValue As String
    Public Property SKSValue As Integer
    Public Property KelasValue As String
    Public Property RuangValue As String
    Public Property HariValue As String
    Public Property JamMulaiValue As String
    Public Property JamSelesaiValue As String

    ' =======================================================
    ' FUNGSI CRUD KE Tbl_JadwalPerkuliahan
    ' =======================================================

    ' Fungsi InsertDataJadwal (Tidak Berubah)
    Private Function InsertDataJadwal(ByVal kode As String, ByVal kelas As String, ByVal ruang As String, ByVal hari As String, ByVal jamMulai As String, ByVal jamSelesai As String) As Boolean
        Dim sql As String = "INSERT INTO Tbl_JadwalPerkuliahan (Kode, Kelas, Ruang, Hari, JamMulai, JamSelesai) VALUES (@Kode, @Kelas, @Ruang, @Hari, @Mulai, @Selesai)"

        Using conn As New SqlConnection(CONNECTION_STRING)
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@Kode", kode)
                cmd.Parameters.AddWithValue("@Kelas", kelas)
                cmd.Parameters.AddWithValue("@Ruang", ruang)
                cmd.Parameters.AddWithValue("@Hari", hari)
                cmd.Parameters.AddWithValue("@Mulai", jamMulai)
                cmd.Parameters.AddWithValue("@Selesai", jamSelesai)

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    Return True
                Catch ex As SqlException
                    MessageBox.Show(MSG_DB_ERROR & ex.Message & vbCrLf & "Pastikan Kode Mata Kuliah valid dan tidak ada tabrakan jadwal unik.", "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End Try
            End Using
        End Using
    End Function

    ' Fungsi UpdateDataJadwal (Tidak Berubah)
    Private Function UpdateDataJadwal(ByVal idJadwal As Integer, ByVal kode As String, ByVal kelas As String, ByVal ruang As String, ByVal hari As String, ByVal jamMulai As String, ByVal jamSelesai As String) As Boolean

        Dim sql As String = "UPDATE Tbl_JadwalPerkuliahan SET Kode = @Kode, Kelas = @Kelas, Ruang = @Ruang, Hari = @Hari, JamMulai = @Mulai, JamSelesai = @Selesai WHERE IDJadwal = @IDJadwal"

        Using conn As New SqlConnection(CONNECTION_STRING)
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@IDJadwal", idJadwal)
                cmd.Parameters.AddWithValue("@Kode", kode)
                cmd.Parameters.AddWithValue("@Kelas", kelas)
                cmd.Parameters.AddWithValue("@Ruang", ruang)
                cmd.Parameters.AddWithValue("@Hari", hari)
                cmd.Parameters.AddWithValue("@Mulai", jamMulai)
                cmd.Parameters.AddWithValue("@Selesai", jamSelesai)

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    Return True
                Catch ex As SqlException
                    MessageBox.Show(MSG_DB_ERROR & ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End Try
            End Using
        End Using
    End Function

    ' =======================================================
    ' FUNGSI MASTER MATA KULIAH (Dipertahankan untuk INSERT/UPDATE)
    ' =======================================================

    ' Fungsi untuk INSERT/UPDATE Mata Kuliah Master baru (Tbl_MataKuliah)
    ' Logika ini akan memastikan Tbl_MataKuliah selalu sinkron.
    Private Function InsertUpdateMataKuliah(ByVal kode As String, ByVal MataKuliah As String, ByVal sks As Integer) As Boolean
        ' Logika: Coba UPDATE jika kode sudah ada. Jika belum ada, lakukan INSERT.
        Dim sqlUpdate As String = "UPDATE Tbl_MataKuliah SET MataKuliah = @MataKuliah, SKS = @SKS WHERE Kode = @Kode"
        Dim sqlInsert As String = "INSERT INTO Tbl_MataKuliah (Kode, MataKuliah, SKS) VALUES (@Kode, @MataKuliah, @SKS)"

        Using conn As New SqlConnection(CONNECTION_STRING)
            Try
                conn.Open()

                ' 1. Coba UPDATE
                Using cmdUpdate As New SqlCommand(sqlUpdate, conn)
                    cmdUpdate.Parameters.AddWithValue("@Kode", kode)
                    cmdUpdate.Parameters.AddWithValue("@MataKuliah", MataKuliah)
                    cmdUpdate.Parameters.AddWithValue("@SKS", sks)

                    If cmdUpdate.ExecuteNonQuery() = 0 Then
                        ' 2. Jika UPDATE gagal (data belum ada), lakukan INSERT
                        Using cmdInsert As New SqlCommand(sqlInsert, conn)
                            cmdInsert.Parameters.AddWithValue("@Kode", kode)
                            cmdInsert.Parameters.AddWithValue("@MataKuliah", MataKuliah)
                            cmdInsert.Parameters.AddWithValue("@SKS", sks)
                            cmdInsert.ExecuteNonQuery()
                        End Using
                    End If
                End Using
                Return True
            Catch ex As Exception
                MessageBox.Show("Gagal mengelola data Mata Kuliah Master! Pastikan Kode Mata Kuliah tidak melanggar Primary Key atau Constraint lainnya. Error: " & ex.Message, "Error Database Master", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
    End Function


    ' =======================================================
    ' EVENT HANDLER DAN LOGIKA FORM
    ' =======================================================

    ' Saat form dibuka
    Private Sub TambahJadwal_Adm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' HANYA MEMUAT DATA STATIS (Hari)
        LoadReferenceData()

        If IsEditMode Then
            Me.Text = "Ubah Jadwal Perkuliahan (ID: " & IDJadwalValue.ToString() & ")"
            btnSimpanData.Text = "Update Data"

            ' Mode edit → isi form dengan data lama
            txtKode.Text = KodeValue
            cmbMataKuliah.Text = MataKuliahValue
            ' Pastikan SKSValue dikonversi ke String untuk ComboBox.Text
            cmbSKS.Text = SKSValue.ToString()
            cmbKelas.Text = KelasValue
            cmbRuang.Text = RuangValue
            cmbHari.Text = HariValue
            cmbJamMulai.Text = JamMulaiValue
            cmbJamSelesai.Text = JamSelesaiValue

            ' 📌 PERBAIKAN UTAMA: Mengaktifkan edit untuk semua field Master Data
            ' Kunci Kode, Mata Kuliah, dan SKS sebelumnya DIBATALKAN
            txtKode.ReadOnly = False
            cmbMataKuliah.Enabled = True
            cmbSKS.Enabled = True

        Else
            Me.Text = "Tambah Jadwal Perkuliahan Mahasiswa"
            btnSimpanData.Text = "Simpan Data"
            ClearInput()

            ' Pastikan semua input bisa diisi saat Mode Tambah
            txtKode.ReadOnly = False
            cmbMataKuliah.Enabled = True
            cmbSKS.Enabled = True
        End If
    End Sub

    ' 📌 FUNGSI LOAD REFERENCE DIUBAH TOTAL UNTUK MENGHAPUS SEMUA PENGISIAN DB/OTOMATIS
    Private Sub LoadReferenceData()
        ' Hanya Hari yang diisi di sini. Sisanya (MK, SKS, Kelas, Ruang, Jam) diisi manual di Designer.
        cmbHari.Items.Clear()
        cmbHari.Items.AddRange(New String() {"Senin", "Selasa", "Rabu", "Kamis", "Jumat"})
    End Sub

    ' Tombol Simpan/Update
    Private Sub btnSimpanData_Click(sender As Object, e As EventArgs) Handles btnSimpanData.Click

        ' 1. VALIDASI INPUT 
        If String.IsNullOrWhiteSpace(txtKode.Text) OrElse String.IsNullOrWhiteSpace(cmbMataKuliah.Text) OrElse String.IsNullOrWhiteSpace(cmbSKS.Text) OrElse
           String.IsNullOrWhiteSpace(cmbKelas.Text) OrElse String.IsNullOrWhiteSpace(cmbRuang.Text) OrElse String.IsNullOrWhiteSpace(cmbHari.Text) OrElse
           String.IsNullOrWhiteSpace(cmbJamMulai.Text) OrElse String.IsNullOrWhiteSpace(cmbJamSelesai.Text) Then

            MessageBox.Show(MSG_REQUIRED, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validasi SKS (pastikan input SKS bisa dikonversi ke Integer)
        Dim sks As Integer
        If Not Integer.TryParse(cmbSKS.Text, sks) Then
            MessageBox.Show("SKS harus berupa angka yang valid.", "Peringatan SKS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validasi Jam: Mulai harus sebelum Selesai
        If TimeSpan.Parse(cmbJamMulai.Text) >= TimeSpan.Parse(cmbJamSelesai.Text) Then
            MessageBox.Show("Jam Mulai harus lebih awal daripada Jam Selesai.", "Peringatan Waktu", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 2. AMBIL DATA DARI FORM
        Dim kode As String = txtKode.Text.Trim()
        Dim MataKuliah As String = cmbMataKuliah.Text
        ' SKS sudah divalidasi di atas
        Dim kelas As String = cmbKelas.Text
        Dim ruang As String = cmbRuang.Text
        Dim hari As String = cmbHari.Text
        Dim jamMulai As String = cmbJamMulai.Text
        Dim jamSelesai As String = cmbJamSelesai.Text

        ' 3. PROSES DATABASE
        Dim success As Boolean = False
        Dim masterSuccess As Boolean = False

        ' A. Simpan/Update Mata Kuliah Master (Dilakukan di mode Tambah & Edit)
        masterSuccess = InsertUpdateMataKuliah(kode, MataKuliah, sks)

        If masterSuccess Then
            If IsEditMode Then
                ' 📌 PERBAIKAN: MODE EDIT - Lanjutkan Update Jadwal setelah Master berhasil diupdate
                success = UpdateDataJadwal(IDJadwalValue, kode, kelas, ruang, hari, jamMulai, jamSelesai)
                If success Then
                    MessageBox.Show("Jadwal perkuliahan berhasil diperbarui di Database.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Else
                ' MODE TAMBAH: Lanjutkan Insert Jadwal Detail
                success = InsertDataJadwal(kode, kelas, ruang, hari, jamMulai, jamSelesai)
                If success Then
                    MessageBox.Show("Jadwal perkuliahan berhasil ditambahkan ke Database.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If

        ' 4. Tutup form jika operasi database sukses
        If success Then
            ' Panggil LoadDataJadwal() pada MainForm (Adm_MataKuliah) untuk refresh DGV
            If MainForm IsNot Nothing Then
                MainForm.LoadDataJadwal()
            End If
            Me.Close()
        End If

    End Sub

    ' Tombol Kembali (Tidak Berubah)
    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
    End Sub

    ' Bersihkan semua input (Tidak Berubah)
    Private Sub ClearInput()
        txtKode.Clear()
        cmbMataKuliah.SelectedIndex = -1
        cmbSKS.SelectedIndex = -1
        cmbKelas.SelectedIndex = -1
        cmbRuang.SelectedIndex = -1
        cmbHari.SelectedIndex = -1
        cmbJamMulai.SelectedIndex = -1
        cmbJamSelesai.SelectedIndex = -1

        ' Atur ulang status input
        txtKode.ReadOnly = False
        cmbMataKuliah.Enabled = True
        cmbSKS.Enabled = True
    End Sub

End Class

' -------------------------------------------------------
' Wrapper classes for backward compatibility 
' -------------------------------------------------------
Public Class TambahJadwal
    Inherits TambahJadwal_Adm
End Class
