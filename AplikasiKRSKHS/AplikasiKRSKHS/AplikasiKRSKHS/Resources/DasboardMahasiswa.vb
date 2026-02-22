Imports System.Data.SqlClient

Public Class DasboardMahasiswa

    ' Properti yang diterima dari Login
    Public Property NamaMahasiswa As String
    Public Property NIM_Mahasiswa As String

    ' Ketika form muncul (baik pertama kali ataupun kembali dari form lain)
    Private Sub DasboardMahasiswa_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        RefreshProfile()
    End Sub

    ' Method tunggal untuk menampilkan / refresh data profile
    Public Sub RefreshProfile()
        ' Jika NIM tidak tersedia, tampilkan pesan yang sopan dan hentikan proses DB
        If String.IsNullOrWhiteSpace(NIM_Mahasiswa) Then
            lblNamaMahasiswa.Text = "Error: NIM Tidak Diterima"
            lblNIM.Text = "-"
            Return
        End If

        ' Gunakan nama yang dikirim dari Login (hindari inkonsistensi DB)
        lblNamaMahasiswa.Text = If(String.IsNullOrWhiteSpace(NamaMahasiswa), "(Nama tidak tersedia)", NamaMahasiswa)
        lblNIM.Text = NIM_Mahasiswa

        ' Note: tidak melakukan query ulang ke Tbl_Mahasiswa untuk menghindari
        ' perbedaan antara Tbl_Pengguna dan Tbl_Mahasiswa. Jika Anda memang ingin
        ' sinkronisasi DB, lakukan update Tbl_Mahasiswa saat pendaftaran/login.
    End Sub

    ' ================================
    '             TOMBOL KRS
    ' ================================
    Private Sub btnKRS_Click(sender As Object, e As EventArgs) Handles btnKRS.Click
        Dim frm As New Mhs_KRS()
        frm.NIM_Mahasiswa = Me.NIM_Mahasiswa
        frm.NamaMahasiswa = Me.NamaMahasiswa
        frm.Show()
        Me.Hide()
    End Sub

    ' ================================
    '             TOMBOL KHS
    ' ================================
    Private Sub btnKHS_Click(sender As Object, e As EventArgs) Handles btnKHS.Click
        Dim frm As New Mhs_KHS()
        frm.NIM_Mahasiswa = Me.NIM_Mahasiswa
        frm.NamaMahasiswa = Me.NamaMahasiswa
        frm.Show()
        Me.Hide()
    End Sub

    ' ================================
    '             TOMBOL LOGOUT
    ' ================================
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Optional: bersihkan global instances
        Try
            If ModuleKoneksi.GlobalKRS IsNot Nothing Then
                ModuleKoneksi.GlobalKRS.Close()
                ModuleKoneksi.GlobalKRS = Nothing
            End If
        Catch ex As Exception
            ' ignore
        End Try

        ModuleKoneksi.GlobalDashboard = Nothing
        Application.Exit()
    End Sub

    ' Tombol Dashboard pada sidebar — saat sudah di dashboard tidak perlu melakukan apa-apa.
    ' Jika kamu memanggil dashboard dari form lain, gunakan ModuleKoneksi.GlobalDashboard.Show() di form tersebut.
    Private Sub btnDasboard_Click(sender As Object, e As EventArgs) Handles btnDasboard.Click
        ' Tidak ada aksi (sudah di dashboard)
    End Sub
End Class
