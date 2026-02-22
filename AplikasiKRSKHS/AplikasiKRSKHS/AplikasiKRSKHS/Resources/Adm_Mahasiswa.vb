Imports System.Data.SqlClient

Public Class Adm_Mahasiswa

    Private Const CONNECTION_STRING As String = "Data Source=LAPTOP-N3HRLL7J;Initial Catalog=DB_KRS_KHS;Integrated Security=True;"

    ' =======================================================
    ' EVENT LOAD & FUNGSI DATABASE
    ' =======================================================
    Private Sub Adm_Mahasiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataMahasiswa()
    End Sub

    ' Fungsi untuk memuat data dari database ke DataGridView
    Private Sub LoadDataMahasiswa()
        Try
            ' Buat kolom kalau belum ada
            If dgvMahasiswa.Columns.Count = 0 Then
                dgvMahasiswa.Columns.Add("NIM", "NIM")
                dgvMahasiswa.Columns.Add("Nama", "Nama")
                dgvMahasiswa.Columns.Add("JenisKelamin", "Jenis Kelamin")
                dgvMahasiswa.Columns.Add("NoTelepon", "No. Telepon")
                dgvMahasiswa.Columns.Add("ProgramStudi", "Program Studi")
                dgvMahasiswa.Columns.Add("Fakultas", "Fakultas")
                dgvMahasiswa.Columns.Add("StatusAkun", "Status Akun")
            End If

            dgvMahasiswa.Rows.Clear()

            Dim sql As String = "SELECT NIM, Nama, JenisKelamin, NoTelepon, ProgramStudi, Fakultas, StatusAkun FROM Tbl_Mahasiswa ORDER BY NIM"

            Using conn As New SqlConnection(CONNECTION_STRING)
                Using cmd As New SqlCommand(sql, conn)
                    conn.Open()
                    Dim reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        dgvMahasiswa.Rows.Add(
                            reader("NIM").ToString(),
                            reader("Nama").ToString(),
                            reader("JenisKelamin").ToString(),
                            reader("NoTelepon").ToString(),
                            reader("ProgramStudi").ToString(),
                            reader("Fakultas").ToString(),
                            reader("StatusAkun").ToString()
                        )
                    End While
                    reader.Close()
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal memuat data mahasiswa dari database: " & ex.Message, "Error Load Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Fungsi untuk menghapus data dari database
    Private Function DeleteDataMahasiswa(ByVal nim As String) As Boolean
        Dim sql As String = "DELETE FROM Tbl_Mahasiswa WHERE NIM = @NIM"

        Using conn As New SqlConnection(CONNECTION_STRING)
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@NIM", nim)
                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    Return True
                Catch ex As SqlException
                    MessageBox.Show("Gagal menghapus data dari database! Error: " & ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End Try
            End Using
        End Using
    End Function

    ' =======================================================
    ' EVENT HANDLER NAVIGASI
    ' =======================================================
    Private Sub btnDasboard_Click(sender As Object, e As EventArgs) Handles btnDasboard.Click
        DashboardAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub btnDosen_Click(sender As Object, e As EventArgs) Handles btnDosen.Click
        Adm_Dosen.Show()
        Me.Hide()
    End Sub

    Private Sub btnMataKuliah_Click(sender As Object, e As EventArgs) Handles btnMataKuliah.Click
        Adm_MataKuliah.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Application.Exit()
    End Sub

    ' =======================================================
    ' EVENT HANDLER TAMBAH, EDIT, HAPUS
    ' =======================================================
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim tambahForm As New TambahDataMahasiswa()
        tambahForm.IsEditMode = False
        tambahForm.MainForm = Me
        tambahForm.ShowDialog()

        ' Refresh data setelah tambah
        LoadDataMahasiswa()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvMahasiswa.SelectedRows.Count = 0 Then
            MessageBox.Show("Silakan pilih baris yang akan diedit.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedRow As DataGridViewRow = dgvMahasiswa.SelectedRows(0)
        Dim editForm As New TambahDataMahasiswa()
        editForm.IsEditMode = True
        editForm.MainForm = Me

        editForm.NIMValue = selectedRow.Cells("NIM").Value.ToString()
        editForm.NamaValue = selectedRow.Cells("Nama").Value.ToString()
        editForm.JenisKelaminValue = selectedRow.Cells("JenisKelamin").Value.ToString()
        editForm.NoTeleponValue = selectedRow.Cells("NoTelepon").Value.ToString()
        editForm.ProgramStudiValue = selectedRow.Cells("ProgramStudi").Value.ToString()
        editForm.FakultasValue = selectedRow.Cells("Fakultas").Value.ToString()
        editForm.StatusAkunValue = selectedRow.Cells("StatusAkun").Value.ToString()

        editForm.ShowDialog()

        ' Refresh data setelah edit
        LoadDataMahasiswa()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If dgvMahasiswa.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih data yang ingin dihapus dulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini dari database?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim selectedRow As DataGridViewRow = dgvMahasiswa.SelectedRows(0)
            Dim nimToDelete As String = selectedRow.Cells("NIM").Value.ToString()

            If DeleteDataMahasiswa(nimToDelete) Then
                dgvMahasiswa.Rows.Remove(selectedRow)
                MessageBox.Show("Data berhasil dihapus dari database.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

End Class
