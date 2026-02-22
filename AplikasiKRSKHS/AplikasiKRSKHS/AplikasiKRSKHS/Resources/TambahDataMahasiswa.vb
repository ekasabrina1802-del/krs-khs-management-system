Imports System.Data.SqlClient

Public Class TambahDataMahasiswa

    ' ================================================
    ' KONFIGURASI DATABASE
    ' ================================================
    ' Catatan: Pastikan nama server 'LAPTOP-N3HRLL7J' sudah benar dan Integrated Security=True
    Private Const CONNECTION_STRING As String = "Data Source=LAPTOP-N3HRLL7J;Initial Catalog=DB_KRS_KHS;Integrated Security=True;"

    ' ================================================
    ' VARIABEL & PROPERTI
    ' ================================================
    Public Property MainForm As Adm_Mahasiswa
    Public Property RowIndex As Integer
    Public Property IsEditMode As Boolean = False

    ' Properti data yang dikirim dari Adm_Mahasiswa (jika mode edit)
    Public Property NIMValue As String      ' Primary Key
    Public Property NamaValue As String
    Public Property JenisKelaminValue As String
    Public Property NoTeleponValue As String
    Public Property ProgramStudiValue As String
    Public Property FakultasValue As String
    Public Property StatusAkunValue As String


    ' =======================================================
    ' FUNGSI DATABASE
    ' =======================================================

    ' Fungsi untuk MENAMBAH data ke Tbl_Mahasiswa
    Private Function InsertDataMahasiswa(ByVal nim As String, ByVal nama As String, ByVal jenisKelamin As String,
                                         ByVal noTelepon As String, ByVal programStudi As String, ByVal fakultas As String,
                                         ByVal statusAkun As String) As Boolean

        Dim sql As String = "INSERT INTO Tbl_Mahasiswa (NIM, Nama, JenisKelamin, NoTelepon, ProgramStudi, Fakultas, StatusAkun) " &
                            "VALUES (@NIM, @Nama, @JK, @Telp, @Prodi, @Fakultas, @Status)"

        Using conn As New SqlConnection(CONNECTION_STRING)
            Using cmd As New SqlCommand(sql, conn)
                ' Menggunakan Parameter
                cmd.Parameters.AddWithValue("@NIM", nim)
                cmd.Parameters.AddWithValue("@Nama", nama)
                cmd.Parameters.AddWithValue("@JK", jenisKelamin)
                cmd.Parameters.AddWithValue("@Telp", noTelepon)
                cmd.Parameters.AddWithValue("@Prodi", programStudi)
                cmd.Parameters.AddWithValue("@Fakultas", fakultas)
                cmd.Parameters.AddWithValue("@Status", statusAkun)

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    Return True
                Catch ex As SqlException
                    ' Pesan error akan menampilkan pelanggaran UNIQUE KEY (NIM) atau CHECK constraint (Angka/Format)
                    MessageBox.Show("Gagal menyimpan ke database! Error: " & ex.Message & vbCrLf &
                                    "Pastikan NIM tidak ganda dan format data (NIM, Telepon, JK, Status) sesuai batasan DB.", "Error Database",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End Try
            End Using
        End Using
    End Function

    ' Fungsi untuk MEMPERBARUI data di Tbl_Mahasiswa
    Private Function UpdateDataMahasiswa(ByVal nimLama As String, ByVal nimBaru As String, ByVal nama As String, ByVal jenisKelamin As String,
                                         ByVal noTelepon As String, ByVal programStudi As String, ByVal fakultas As String,
                                         ByVal statusAkun As String) As Boolean

        Dim sql As String = "UPDATE Tbl_Mahasiswa SET NIM = @NIMBaru, Nama = @Nama, JenisKelamin = @JK, NoTelepon = @Telp, " &
                            "ProgramStudi = @Prodi, Fakultas = @Fakultas, StatusAkun = @Status WHERE NIM = @NIMLama"

        Using conn As New SqlConnection(CONNECTION_STRING)
            Using cmd As New SqlCommand(sql, conn)
                ' Menggunakan Parameter
                cmd.Parameters.AddWithValue("@NIMBaru", nimBaru)
                cmd.Parameters.AddWithValue("@Nama", nama)
                cmd.Parameters.AddWithValue("@JK", jenisKelamin)
                cmd.Parameters.AddWithValue("@Telp", noTelepon)
                cmd.Parameters.AddWithValue("@Prodi", programStudi)
                cmd.Parameters.AddWithValue("@Fakultas", fakultas)
                cmd.Parameters.AddWithValue("@Status", statusAkun)
                cmd.Parameters.AddWithValue("@NIMLama", nimLama)

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    Return True
                Catch ex As SqlException
                    MessageBox.Show("Gagal memperbarui database! Error: " & ex.Message & vbCrLf &
                                    "Pastikan NIM baru tidak ganda dan format data sesuai batasan DB.", "Error Database",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End Try
            End Using
        End Using
    End Function


    ' =======================================================
    ' EVENT HANDLER
    ' =======================================================

    Private Sub TambahDataMahasiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IsEditMode Then
            ' Mode edit → isi form dengan data lama
            txtNIM.Text = NIMValue
            txtNama.Text = NamaValue

            ' Asumsi cmbJenisKelamin.Text akan menampilkan teks panjang (misal: "Laki-laki") 
            ' dan bukan kode DB ('L')
            cmbJenisKelamin.Text = If(JenisKelaminValue = "L", "Laki-laki", "Perempuan")

            txtNoTelepon.Text = NoTeleponValue
            cmbProgramStudi.Text = ProgramStudiValue
            cmbFakultas.Text = FakultasValue
            cmbStatusAkun.Text = StatusAkunValue ' Teks di ComboBox harus sesuai nilai di DB ("Aktif"/"Tidak Aktif")

            ' Mencegah perubahan Primary Key di mode edit
            txtNIM.ReadOnly = True
        Else
            ' Mode tambah → kosongkan semua input
            ClearInput()
        End If
    End Sub

    ' Tombol Simpan
    Private Sub btnSimpanData_Click(sender As Object, e As EventArgs) Handles btnSimpanData.Click
        ' 1. VALIDASI INPUT
        If String.IsNullOrWhiteSpace(txtNIM.Text) OrElse
           String.IsNullOrWhiteSpace(txtNama.Text) OrElse
           cmbJenisKelamin.SelectedIndex = -1 OrElse
           String.IsNullOrWhiteSpace(txtNoTelepon.Text) OrElse
           cmbProgramStudi.SelectedIndex = -1 OrElse
           cmbFakultas.SelectedIndex = -1 OrElse
           cmbStatusAkun.SelectedIndex = -1 Then

            MessageBox.Show("Harap lengkapi semua data sebelum menyimpan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 2. AMBIL DATA DARI FORM DAN KONVERSI
        Dim nim As String = txtNIM.Text

        ' REVISI: Asumsi Anda akan mengubah Nama di DB menjadi VARCHAR(100).
        ' Jika Anda tetap menggunakan VARCHAR(5), Anda berisiko ERROR atau data terpotong.
        Dim nama As String = txtNama.Text

        Dim noTelepon As String = txtNoTelepon.Text
        Dim programStudi As String = cmbProgramStudi.Text
        Dim fakultas As String = cmbFakultas.Text

        ' --- LOGIC KONVERSI JENIS KELAMIN ('Laki-laki'/'Perempuan' menjadi 'L'/'P') ---
        Dim jenisKelamin As String
        If cmbJenisKelamin.Text = "Laki-laki" Then
            jenisKelamin = "L"
        ElseIf cmbJenisKelamin.Text = "Perempuan" Then
            jenisKelamin = "P"
        Else
            ' Jika ComboBox diisi 'L' atau 'P' (fallback)
            jenisKelamin = cmbJenisKelamin.Text.Substring(0, 1)
        End If

        ' --- LOGIC STATUS AKUN (REVISI PENTING) ---
        ' Mengirimkan kata kunci lengkap "Aktif" atau "Tidak Aktif" sesuai VARCHAR(11) di DB
        Dim statusAkun As String = cmbStatusAkun.Text


        ' 3. PROSES DATABASE
        Dim success As Boolean = False
        Dim dgv As DataGridView = MainForm.dgvMahasiswa

        If IsEditMode Then
            ' Mode edit → UPDATE database
            Dim nimLama As String = NIMValue
            success = UpdateDataMahasiswa(nimLama, nim, nama, jenisKelamin, noTelepon, programStudi, fakultas, statusAkun)

            If success Then
                ' Update tampilan di DataGridView
                With dgv.Rows(RowIndex)
                    .Cells(0).Value = nim
                    .Cells(1).Value = nama
                    .Cells(2).Value = jenisKelamin
                    .Cells(3).Value = noTelepon
                    .Cells(4).Value = programStudi
                    .Cells(5).Value = fakultas
                    .Cells(6).Value = statusAkun
                End With
                MessageBox.Show("Data mahasiswa berhasil diperbarui di Database.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Else
            ' Mode tambah → INSERT database
            success = InsertDataMahasiswa(nim, nama, jenisKelamin, noTelepon, programStudi, fakultas, statusAkun)

            If success Then
                dgv.Rows.Add(nim, nama, jenisKelamin, noTelepon, programStudi, fakultas, statusAkun)
                MessageBox.Show("Data mahasiswa berhasil ditambahkan ke Database.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Opsional: Bersihkan input setelah tambah sukses
                ClearInput()
            End If
        End If

        ' Tutup form hanya jika operasi database sukses DAN bukan mode tambah yang meminta ClearInput
        If success AndAlso IsEditMode Then
            Me.Close()
        ElseIf success AndAlso Not IsEditMode Then
            ' Biarkan form terbuka jika sukses menambah data (opsional, bisa diubah Me.Close() jika Anda mau)
        End If

    End Sub

    ' Tombol Kembali
    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
    End Sub

    ' Bersihkan semua input
    Private Sub ClearInput()
        txtNIM.Clear()
        txtNama.Clear()
        cmbJenisKelamin.SelectedIndex = -1
        txtNoTelepon.Clear()
        cmbProgramStudi.SelectedIndex = -1
        cmbFakultas.SelectedIndex = -1
        cmbStatusAkun.SelectedIndex = -1
    End Sub

End Class