Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class DaftarAkun

    Private Sub btnDaftar_Click(sender As Object, e As EventArgs) Handles btnDaftar.Click

        ' --- Deklarasi Variabel Input ---
        Dim inputUsername As String = txtUsername.Text.Trim()
        Dim inputNIM As String = txtNIM.Text.Trim()
        Dim password As String = txtPassword.Text
        Dim konfirmasiPass As String = txtKonfirmasiPassword.Text

        ' ---------------------------------------
        ' --- 1. VALIDASI DATA INPUT ---
        ' ---------------------------------------
        If inputUsername = "" OrElse inputNIM = "" OrElse password = "" OrElse konfirmasiPass = "" Then
            MessageBox.Show("Semua field (Username, NIM, Password) harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' VALIDASI NIM HANYA ANGKA (tanpa spasi)
        If Not IsNumeric(inputNIM) OrElse inputNIM.Contains(" "c) Then
            MessageBox.Show("NIM harus berupa angka dan tidak boleh mengandung spasi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If password <> konfirmasiPass Then
            MessageBox.Show("Password dan Konfirmasi Password tidak cocok.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If password.Length < 6 Then
            MessageBox.Show("Password minimal 6 karakter.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' ---------------------------------------
        ' --- 2. CEK DUPLIKASI ---
        ' ---------------------------------------
        ' A. Cek duplikasi NIM (di kolom NIM)
        If IsNIMExist(inputNIM) Then
            MessageBox.Show("NIM '" & inputNIM & "' sudah terdaftar.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' B. Cek duplikasi Username (di kolom Username)
        If IsUsernameExist(inputUsername) Then
            MessageBox.Show("Username '" & inputUsername & "' sudah digunakan. Gunakan Username lain.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' ---------------------------------------
        ' --- 3. HASHING & SIMPAN DATA BARU ---
        ' ---------------------------------------
        Try
            Dim hashedPassword As String = ModuleKoneksi.HashPassword(password)

            ModuleKoneksi.OpenConnection()

            Dim query As String = "INSERT INTO Tbl_Pengguna (Username, PasswordHash, NamaLengkap, Role, NIM) VALUES (@user, @pass, @nama, @role, @nim)"

            Using cmd As New SqlCommand(query, ModuleKoneksi.Conn)
                cmd.Parameters.AddWithValue("@user", inputUsername)
                cmd.Parameters.AddWithValue("@pass", hashedPassword)
                ' Bila kamu punya field NamaLengkap tersendiri, ganti sesuai input. Untuk sementara gunakan username.
                cmd.Parameters.AddWithValue("@nama", inputUsername)
                cmd.Parameters.AddWithValue("@role", "Mahasiswa")
                cmd.Parameters.AddWithValue("@nim", inputNIM)

                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Akun Mahasiswa berhasil didaftarkan! Username Anda adalah: " & inputUsername, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Bersihkan field dan kembali ke login
            txtNIM.Clear()
            txtUsername.Clear()
            txtPassword.Clear()
            txtKonfirmasiPassword.Clear()

            Me.Hide()
            Login.Show()

        Catch ex As SqlException
            MessageBox.Show("Gagal mendaftar akun (DB): " & ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Gagal mendaftar akun: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ModuleKoneksi.CloseConnection()
        End Try
    End Sub

    ' ---------------------------------------
    ' --- FUNGSI PENDUKUNG: CEK DUPLIKASI USERNAME ---
    ' ---------------------------------------
    Public Function IsUsernameExist(ByVal username As String) As Boolean
        Try
            ModuleKoneksi.OpenConnection()

            Dim query As String = "SELECT COUNT(*) FROM Tbl_Pengguna WHERE Username = @user"
            Using cmd As New SqlCommand(query, ModuleKoneksi.Conn)
                cmd.Parameters.AddWithValue("@user", username)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using

        Catch ex As Exception
            MessageBox.Show("Error saat mengecek duplikasi Username: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Jika error DB, aman menganggap ada duplikasi agar pendaftaran tidak lanjut
            Return True
        Finally
            ModuleKoneksi.CloseConnection()
        End Try
    End Function

    ' ---------------------------------------
    ' --- FUNGSI PENDUKUNG: CEK DUPLIKASI NIM ---
    ' ---------------------------------------
    Public Function IsNIMExist(ByVal nim As String) As Boolean
        Try
            ModuleKoneksi.OpenConnection()

            Dim query As String = "SELECT COUNT(*) FROM Tbl_Pengguna WHERE NIM = @nim"
            Using cmd As New SqlCommand(query, ModuleKoneksi.Conn)
                cmd.Parameters.AddWithValue("@nim", nim)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using

        Catch ex As Exception
            MessageBox.Show("Error saat mengecek duplikasi NIM: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        Finally
            ModuleKoneksi.CloseConnection()
        End Try
    End Function

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Login.Show()
        Me.Close()
    End Sub

End Class
