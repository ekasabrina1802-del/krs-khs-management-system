Imports System.Data.SqlClient

Public Class Adm_Dosen

    ' Connection String Anda
    Private Const CONNECTION_STRING As String = "Data Source=LAPTOP-N3HRLL7J;Initial Catalog=DB_KRS_KHS;Integrated Security=True;"

    ' =======================================================
    ' FUNGSI LOAD & DELETE DATA
    ' =======================================================

    ' Event Load: Dipanggil saat form Adm_Dosen dibuka
    Private Sub Adm_Dosen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Panggil fungsi untuk mengisi DataGridView saat form dimuat
        LoadDataDosen()
    End Sub

    ' Fungsi untuk memuat data dari database ke dgvDosen
    Private Sub LoadDataDosen()
        dgvDosen.Rows.Clear() ' Bersihkan DataGridView

        Dim sql As String = "SELECT Kode, NIP, Nama, JenisKelamin, Email, NoTelepon, StatusAkun FROM Tbl_Dosen ORDER BY Kode"

        Using conn As New SqlConnection(CONNECTION_STRING)
            Using cmd As New SqlCommand(sql, conn)
                Try
                    conn.Open()
                    Dim reader As SqlDataReader = cmd.ExecuteReader()

                    While reader.Read()
                        dgvDosen.Rows.Add(
                            reader("Kode").ToString(),
                            reader("NIP").ToString(),
                            reader("Nama").ToString(),
                            reader("JenisKelamin").ToString(),
                            reader("Email").ToString(),
                            reader("NoTelepon").ToString(),
                            reader("StatusAkun").ToString()
                        )
                    End While
                    reader.Close()

                Catch ex As Exception
                    MessageBox.Show("Gagal memuat data dosen dari database: " & ex.Message, "Error Load Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    ' Fungsi untuk menghapus data dari database
    Private Function DeleteDataDosen(ByVal kodeDosen As String) As Boolean
        Dim sql As String = "DELETE FROM Tbl_Dosen WHERE Kode = @Kode"

        Using conn As New SqlConnection(CONNECTION_STRING)
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@Kode", kodeDosen)

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
    ' EVENT HANDLER TAMBAH, EDIT, HAPUS
    ' =======================================================

    ' Tombol Tambah Data
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim tambahForm As New TambahDataDosen()
        tambahForm.IsEditMode = False

        ' Passing referensi MainForm agar TambahDataDosen bisa refresh Adm_Dosen (opsional)
        ' Meskipun kita akan menggunakan LoadDataDosen, tetap sediakan referensi.
        tambahForm.MainForm = Me

        tambahForm.ShowDialog()

        ' REFRESH: Muat ulang data dari database setelah form Tambah ditutup
        LoadDataDosen()
    End Sub

    ' Tombol Edit Data
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvDosen.SelectedRows.Count = 0 Then
            MessageBox.Show("Silakan pilih baris yang akan diedit.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedRow As DataGridViewRow = dgvDosen.SelectedRows(0)
        Dim rowIndex As Integer = selectedRow.Index

        Dim editForm As New TambahDataDosen()
        editForm.IsEditMode = True
        editForm.MainForm = Me
        editForm.RowIndex = rowIndex

        ' Mengambil data dari baris terpilih (gunakan selectedRow, bukan dgvDosen.Rows(rowIndex))
        editForm.KodeDosenValue = selectedRow.Cells("Kode").Value.ToString()
        editForm.NIPValue = selectedRow.Cells("NIP").Value.ToString()
        editForm.NamaValue = selectedRow.Cells("Nama").Value.ToString()
        editForm.JenisKelaminValue = selectedRow.Cells("JenisKelamin").Value.ToString()
        editForm.EmailValue = selectedRow.Cells("Email").Value.ToString()
        editForm.NoTeleponValue = selectedRow.Cells("NoTelepon").Value.ToString()
        editForm.StatusAkunValue = selectedRow.Cells("StatusAkun").Value.ToString()

        editForm.ShowDialog()

        ' REFRESH: Muat ulang data dari database setelah form Edit ditutup
        LoadDataDosen()
    End Sub

    ' Tombol Hapus Data
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If dgvDosen.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih data yang ingin dihapus dulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini dari database?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim selectedRow As DataGridViewRow = dgvDosen.SelectedRows(0)
            ' Kode Dosen ada di kolom 0 (Cells(0))
            Dim kodeDosenToDelete As String = selectedRow.Cells(0).Value.ToString()

            ' Hapus data dari database
            If DeleteDataDosen(kodeDosenToDelete) Then
                ' Jika penghapusan database sukses, hapus dari DataGridView
                dgvDosen.Rows.Remove(selectedRow)
                MessageBox.Show("Data berhasil dihapus dari database.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnDasboard_Click(sender As Object, e As EventArgs) Handles btnDasboard.Click
        DashboardAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub btnMahasiswa_Click(sender As Object, e As EventArgs) Handles btnMahasiswa.Click
        Adm_Mahasiswa.Show()
        Me.Hide()
    End Sub

    Private Sub btnMataKuliah_Click(sender As Object, e As EventArgs) Handles btnMataKuliah.Click
        Adm_MataKuliah.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Application.Exit()
    End Sub

End Class