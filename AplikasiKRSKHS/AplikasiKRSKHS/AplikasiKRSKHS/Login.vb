Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class Login

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim inputUsername As String = txtUsername.Text.Trim()
        Dim inputPassword As String = txtPassword.Text

        If inputUsername = "" OrElse inputPassword = "" Then
            MessageBox.Show("Masukkan Username dan Password.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim hashedInputPassword As String = ModuleKoneksi.HashPassword(inputPassword)

            ModuleKoneksi.OpenConnection()

            Dim rolePengguna As String = String.Empty
            Dim namaPengguna As String = String.Empty
            Dim nimPengguna As String = String.Empty

            Dim query As String =
                "SELECT Role, NamaLengkap, NIM FROM Tbl_Pengguna WHERE Username = @user AND PasswordHash = @pass"

            Using cmd As New SqlCommand(query, ModuleKoneksi.Conn)
                cmd.Parameters.AddWithValue("@user", inputUsername)
                cmd.Parameters.AddWithValue("@pass", hashedInputPassword)

                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        rolePengguna = If(IsDBNull(reader("Role")), String.Empty, reader("Role").ToString())
                        namaPengguna = If(IsDBNull(reader("NamaLengkap")), String.Empty, reader("NamaLengkap").ToString())
                        nimPengguna = If(IsDBNull(reader("NIM")), String.Empty, reader("NIM").ToString())
                    End If
                End Using
            End Using

            If String.IsNullOrEmpty(rolePengguna) Then
                MessageBox.Show("Username atau Password salah.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If rolePengguna.Equals("Admin", StringComparison.OrdinalIgnoreCase) Then
                ModuleKoneksi.GlobalMahasiswaNIM = String.Empty
                Dim frmAdmin As New DashboardAdmin()
                ModuleKoneksi.GlobalDashboard = frmAdmin
                frmAdmin.Show()
                Me.Hide()

            ElseIf rolePengguna.Equals("Mahasiswa", StringComparison.OrdinalIgnoreCase) Then
                ' Set global NIM untuk filter otomatis
                ModuleKoneksi.GlobalMahasiswaNIM = nimPengguna

                Dim frmDashboard As New DasboardMahasiswa()
                frmDashboard.NIM_Mahasiswa = nimPengguna
                frmDashboard.NamaMahasiswa = namaPengguna

                ModuleKoneksi.GlobalDashboard = frmDashboard
                frmDashboard.Show()
                Me.Hide()

            ElseIf rolePengguna.Equals("DPA", StringComparison.OrdinalIgnoreCase) Then
                ModuleKoneksi.GlobalMahasiswaNIM = String.Empty
                Dim frmDPA As New DPA()
                ModuleKoneksi.GlobalDashboard = frmDPA
                frmDPA.Show()
                Me.Hide()

            Else
                MessageBox.Show("Role pengguna tidak dikenali. Hubungi admin.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            txtUsername.Clear()
            txtPassword.Clear()

        Catch ex As Exception
            MessageBox.Show("Terjadi error saat proses login: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ModuleKoneksi.CloseConnection()
        End Try

    End Sub

    Private Sub btnDaftar_Click(sender As Object, e As EventArgs) Handles btnDaftar.Click
        DaftarAkun.Show()
        Me.Hide()
    End Sub

End Class
