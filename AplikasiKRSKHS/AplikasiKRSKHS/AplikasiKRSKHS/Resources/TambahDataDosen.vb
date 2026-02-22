Imports System.Data.SqlClient

Public Class TambahDataDosen

    ' Connection String Anda
    Private Const CONNECTION_STRING As String = "Data Source=LAPTOP-N3HRLL7J;Initial Catalog=DB_KRS_KHS;Integrated Security=True;"

    ' Variabel & Properti
    Public Property MainForm As Adm_Dosen
    Public Property RowIndex As Integer
    Public Property IsEditMode As Boolean = False

    ' Properti untuk data yang dikirim dari Adm_Dosen
    Public Property KodeDosenValue As String ' Digunakan sebagai kunci utama lama saat EDIT
    Public Property NIPValue As String
    Public Property NamaValue As String
    Public Property JenisKelaminValue As String
    Public Property EmailValue As String
    Public Property NoTeleponValue As String
    Public Property StatusAkunValue As String

    ' =======================================================
    ' FUNGSI UTAMA UNTUK INTERAKSI DATABASE (INSERT/UPDATE)
    ' =======================================================

    ' Fungsi untuk MENAMBAH data ke Tbl_Dosen
    Private Function InsertDataDosen(ByVal kode As String, ByVal nip As String, ByVal nama As String, ByVal jenisKelamin As String, ByVal email As String, ByVal noTelepon As String, ByVal statusAkun As String) As Boolean
        Dim sql As String = "INSERT INTO Tbl_Dosen (Kode, NIP, Nama, JenisKelamin, Email, NoTelepon, StatusAkun) " &
                            "VALUES (@Kode, @NIP, @Nama, @JK, @Email, @Telp, @Status)"

        Using conn As New SqlConnection(CONNECTION_STRING)
            Using cmd As New SqlCommand(sql, conn)
                ' Menggunakan Parameter untuk keamanan
                cmd.Parameters.AddWithValue("@Kode", kode)
                cmd.Parameters.AddWithValue("@NIP", nip)
                cmd.Parameters.AddWithValue("@Nama", nama)
                cmd.Parameters.AddWithValue("@JK", jenisKelamin)
                cmd.Parameters.AddWithValue("@Email", email)
                cmd.Parameters.AddWithValue("@Telp", noTelepon)
                cmd.Parameters.AddWithValue("@Status", statusAkun)

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    Return True
                Catch ex As SqlException
                    MessageBox.Show("Gagal menyimpan ke database! Error: " & ex.Message & vbCrLf & "Pastikan KODE Dosen atau NIP tidak ganda dan hanya angka.", "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End Try
            End Using
        End Using
    End Function

    ' Fungsi untuk MEMPERBARUI data di Tbl_Dosen
    Private Function UpdateDataDosen(ByVal kodeLama As String, ByVal kodeBaru As String, ByVal nip As String, ByVal nama As String, ByVal jenisKelamin As String, ByVal email As String, ByVal noTelepon As String, ByVal statusAkun As String) As Boolean

        ' UPDATE data berdasarkan Kode Dosen yang lama (Primary Key)
        Dim sql As String = "UPDATE Tbl_Dosen SET Kode = @KodeBaru, NIP = @NIP, Nama = @Nama, JenisKelamin = @JK, Email = @Email, NoTelepon = @Telp, StatusAkun = @Status WHERE Kode = @KodeLama"

        Using conn As New SqlConnection(CONNECTION_STRING)
            Using cmd As New SqlCommand(sql, conn)
                ' Parameter data baru
                cmd.Parameters.AddWithValue("@KodeBaru", kodeBaru)
                cmd.Parameters.AddWithValue("@NIP", nip)
                cmd.Parameters.AddWithValue("@Nama", nama)
                cmd.Parameters.AddWithValue("@JK", jenisKelamin)
                cmd.Parameters.AddWithValue("@Email", email)
                cmd.Parameters.AddWithValue("@Telp", noTelepon)
                cmd.Parameters.AddWithValue("@Status", statusAkun)

                ' Parameter WHERE (Kunci utama yang lama)
                cmd.Parameters.AddWithValue("@KodeLama", kodeLama)

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    Return True
                Catch ex As SqlException
                    MessageBox.Show("Gagal memperbarui database! Error: " & ex.Message & vbCrLf & "Pastikan Kode Dosen atau NIP baru tidak ganda.", "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End Try
            End Using
        End Using
    End Function


    ' =======================================================
    ' EVENT HANDLER
    ' =======================================================

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        ' Cukup tutup form, biarkan form Adm_Dosen yang sudah ada tetap aktif
        Me.Close()
    End Sub

    ' Saat form dibuka
    Private Sub TambahDataDosen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IsEditMode Then
            ' Mode edit → isi form dengan data lama
            txtKodeDosen.Text = KodeDosenValue
            txtNIP.Text = NIPValue
            txtNama.Text = NamaValue
            cmbJenisKelamin.Text = JenisKelaminValue
            txtEmail.Text = EmailValue
            txtNoTelepon.Text = NoTeleponValue
            cmbStatusAkun.Text = StatusAkunValue

            ' Mengunci Kode Dosen (Primary Key) agar tidak mudah diubah
            ' Jika Kode Dosen boleh diubah, hapus baris di bawah
            txtKodeDosen.ReadOnly = True
        Else
            ' Mode tambah → kosongkan semua input
            ClearInput()
        End If
    End Sub

    ' Tombol Simpan (TELAH DIMODIFIKASI UNTUK DATABASE)
    Private Sub btnSimpanData_Click(sender As Object, e As EventArgs) Handles btnSimpanData.Click

        ' 1. VALIDASI INPUT (Kode Anda)
        If String.IsNullOrWhiteSpace(txtKodeDosen.Text) OrElse
           String.IsNullOrWhiteSpace(txtNIP.Text) OrElse
           String.IsNullOrWhiteSpace(txtNama.Text) OrElse
           cmbJenisKelamin.SelectedIndex = -1 OrElse
           String.IsNullOrWhiteSpace(txtEmail.Text) OrElse
           String.IsNullOrWhiteSpace(txtNoTelepon.Text) OrElse
           cmbStatusAkun.SelectedIndex = -1 Then

            MessageBox.Show("Harap lengkapi semua data sebelum menyimpan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 2. AMBIL DATA DARI FORM
        Dim kode As String = txtKodeDosen.Text
        Dim nip As String = txtNIP.Text
        Dim nama As String = txtNama.Text
        Dim jenisKelamin As String = String.Empty
        If cmbJenisKelamin.SelectedItem.ToString() = "Laki-laki" Then
            jenisKelamin = "L"
        ElseIf cmbJenisKelamin.SelectedItem.ToString() = "Perempuan" Then
            jenisKelamin = "P"
        End If

        Dim email As String = txtEmail.Text
        Dim noTelepon As String = txtNoTelepon.Text
        Dim statusAkun As String = cmbStatusAkun.SelectedItem.ToString()

        ' 3. PROSES DATABASE & DATAGRIDVIEW
        Dim success As Boolean = False
        Dim dgv As DataGridView = MainForm.dgvDosen

        If IsEditMode Then
            ' MODE EDIT: UPDATE DATABASE
            Dim kodeLama As String = KodeDosenValue ' Kunci utama yang asli

            ' Gunakan kodeLama sebagai kodeBaru jika txtKodeDosen.ReadOnly = True
            success = UpdateDataDosen(kodeLama, kodeLama, nip, nama, jenisKelamin, email, noTelepon, statusAkun)

            If success Then
                ' Update DataGridView jika update database sukses
                With dgv.Rows(RowIndex)
                    .Cells(0).Value = kodeLama ' Kode Dosen (Tetap sama)
                    .Cells(1).Value = nip
                    .Cells(2).Value = nama
                    .Cells(3).Value = jenisKelamin
                    .Cells(4).Value = email
                    .Cells(5).Value = noTelepon
                    .Cells(6).Value = statusAkun
                End With
                MessageBox.Show("Data dosen berhasil diperbarui di Database.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Else
            ' MODE TAMBAH: INSERT DATABASE
            success = InsertDataDosen(kode, nip, nama, jenisKelamin, email, noTelepon, statusAkun)

            If success Then
                ' Tambahkan ke DataGridView jika insert database sukses
                dgv.Rows.Add(kode, nip, nama, jenisKelamin, email, noTelepon, statusAkun)
                MessageBox.Show("Data dosen berhasil ditambahkan ke Database.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

        ' Tutup form hanya jika operasi database sukses
        If success Then
            Me.Close()
        End If

    End Sub

    ' Bersihkan semua input
    Private Sub ClearInput()
        txtKodeDosen.Clear()
        txtNIP.Clear()
        txtNama.Clear()
        txtEmail.Clear()
        txtNoTelepon.Clear()
        cmbJenisKelamin.SelectedIndex = -1
        cmbStatusAkun.SelectedIndex = -1
    End Sub
End Class