Imports System.Data.SqlClient

Public Class DPA_Approved

    ' Jika kamu punya ModuleKoneksi, kita gunakan ModuleKoneksi.Conn
    ' Jika tidak ada, fallback pakai local connStr
    Private ReadOnly connStr As String = "Data Source=LAPTOP-N3HRLL7J;Initial Catalog=DB_KRS_KHS;Integrated Security=True;"
    Private ReadOnly UseModuleKoneksi As Boolean = (GetType(ModuleKoneksi) IsNot Nothing)

    Private Function GetConnection() As SqlConnection
        If UseModuleKoneksi Then
            ModuleKoneksi.OpenConnection()
            Return ModuleKoneksi.Conn
        Else
            Return New SqlConnection(connStr)
        End If
    End Function

    Private Sub CloseConnIfNeeded(conn As SqlConnection)
        If UseModuleKoneksi Then
            ModuleKoneksi.CloseConnection()
        Else
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then conn.Close()
        End If
    End Sub

    Private Sub DPA_Approved_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Pastikan kolom yang dibutuhkan ada (jika tidak, coba tambahkan)
            EnsureKRSColumnsExist()

            ' Load data pending untuk approval
            LoadKRSApproval()
        Catch ex As Exception
            MessageBox.Show("Error saat inisialisasi DPA Approved: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Cek dan tambahkan kolom Tahun_Akademik & Status_Approve bila belum ada
    Private Sub EnsureKRSColumnsExist()
        Dim conn As SqlConnection = Nothing
        Try
            conn = GetConnection()

            If Not UseModuleKoneksi Then conn.Open()

            Dim checkSql As String = "
                SELECT COLUMN_NAME 
                FROM INFORMATION_SCHEMA.COLUMNS 
                WHERE TABLE_NAME = 'Tbl_KRS' AND COLUMN_NAME IN ('Tahun_Akademik','Status_Approve')"

            Dim existing As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase)
            Using cmd As New SqlCommand(checkSql, conn)
                Using rdr = cmd.ExecuteReader()
                    While rdr.Read()
                        existing.Add(rdr.GetString(0))
                    End While
                End Using
            End Using

            Dim alterCmds As New List(Of String)

            If Not existing.Contains("Tahun_Akademik") Then
                alterCmds.Add("ALTER TABLE dbo.Tbl_KRS ADD Tahun_Akademik VARCHAR(50) NULL;")
            End If
            If Not existing.Contains("Status_Approve") Then
                alterCmds.Add("ALTER TABLE dbo.Tbl_KRS ADD Status_Approve VARCHAR(50) NULL;")
            End If

            If alterCmds.Count > 0 Then
                For Each sqlCmd As String In alterCmds
                    Using cmd As New SqlCommand(sqlCmd, conn)
                        cmd.ExecuteNonQuery()
                    End Using
                Next
            End If

        Catch ex As Exception
            ' Jika gagal menambahkan kolom (mis. permission), beri tahu user caranya manual
            Dim msg As String = "Gagal memastikan kolom Tbl_KRS ada. " &
                                "Jika Anda tidak memiliki hak ALTER TABLE, jalankan perintah SQL berikut di SSMS:" & vbCrLf & vbCrLf &
                                "ALTER TABLE dbo.Tbl_KRS ADD Tahun_Akademik VARCHAR(50) NULL;" & vbCrLf &
                                "ALTER TABLE dbo.Tbl_KRS ADD Status_Approve VARCHAR(50) NULL;" & vbCrLf & vbCrLf &
                                "Error detail: " & ex.Message
            MessageBox.Show(msg, "Perlu tindakan manual", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Throw
        Finally
            If conn IsNot Nothing AndAlso Not UseModuleKoneksi Then
                If conn.State = ConnectionState.Open Then conn.Close()
                conn.Dispose()
            Else
                CloseConnIfNeeded(conn)
            End If
        End Try
    End Sub

    Private Sub LoadKRSApproval()
        Dim dt As New DataTable()
        Dim conn As SqlConnection = Nothing
        Try
            conn = GetConnection()
            If Not UseModuleKoneksi Then conn.Open()

            Dim query As String = "
                SELECT
                    k.ID_KRS,
                    k.NIM,
                    mhs.Nama AS NamaMahasiswa,
                    mk.MataKuliah,
                    mk.SKS,
                    j.Kelas,
                    j.Hari,
                    ISNULL(k.Tahun_Akademik, '') AS Tahun_Akademik,
                    ISNULL(k.Status_Approve, '') AS Status_Approve
                FROM Tbl_KRS k
                INNER JOIN Tbl_JadwalPerkuliahan j ON k.IDJadwal = j.IDJadwal
                INNER JOIN Tbl_MataKuliah mk ON j.Kode = mk.Kode
                LEFT JOIN Tbl_Mahasiswa mhs ON k.NIM = mhs.NIM
                WHERE ISNULL(k.Status_Approve,'') = '' OR k.Status_Approve = 'Pending'
                ORDER BY k.NIM, mk.MataKuliah
            "

            Using cmd As New SqlCommand(query, conn)
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using

            dgvApproval.DataSource = dt
            If dgvApproval.Columns.Contains("ID_KRS") Then dgvApproval.Columns("ID_KRS").Visible = False

            ' Atur header kolom jika mau
            If dgvApproval.Columns.Contains("NamaMahasiswa") Then dgvApproval.Columns("NamaMahasiswa").HeaderText = "Nama"
            If dgvApproval.Columns.Contains("Tahun_Akademik") Then dgvApproval.Columns("Tahun_Akademik").HeaderText = "Tahun Akademik"
            If dgvApproval.Columns.Contains("Status_Approve") Then dgvApproval.Columns("Status_Approve").HeaderText = "Status"

        Catch ex As Exception
            MessageBox.Show("Error saat memuat data KRS DPA: " & ex.Message, "Error DB", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso Not UseModuleKoneksi Then
                If conn.State = ConnectionState.Open Then conn.Close()
                conn.Dispose()
            Else
                CloseConnIfNeeded(conn)
            End If
        End Try
    End Sub

    Private Sub UpdateStatusKRS(statusBaru As String)
        If dgvApproval.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih minimal satu baris KRS untuk diupdate.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim conn As SqlConnection = Nothing
        Try
            conn = GetConnection()
            If Not UseModuleKoneksi Then conn.Open()

            Using trans = conn.BeginTransaction()
                Try
                    Dim sql As String = "UPDATE Tbl_KRS SET Status_Approve = @Status WHERE ID_KRS = @ID"
                    Using cmd As New SqlCommand(sql, conn, trans)
                        cmd.Parameters.Add("@Status", SqlDbType.VarChar, 50).Value = statusBaru
                        cmd.Parameters.Add("@ID", SqlDbType.Int)
                        For Each row As DataGridViewRow In dgvApproval.SelectedRows
                            If row.IsNewRow Then Continue For
                            Dim idKRS As Integer = Convert.ToInt32(row.Cells("ID_KRS").Value)
                            cmd.Parameters("@ID").Value = idKRS
                            cmd.ExecuteNonQuery()
                        Next
                    End Using

                    trans.Commit()
                    MessageBox.Show("KRS berhasil diatur statusnya menjadi '" & statusBaru & "'.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadKRSApproval()
                Catch ex As Exception
                    trans.Rollback()
                    Throw
                End Try
            End Using

        Catch ex As Exception
            MessageBox.Show("Error saat mengupdate status KRS: " & ex.Message, "Error DB", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso Not UseModuleKoneksi Then
                If conn.State = ConnectionState.Open Then conn.Close()
                conn.Dispose()
            Else
                CloseConnIfNeeded(conn)
            End If
        End Try
    End Sub

    Private Sub btnApprovedData_Click(sender As Object, e As EventArgs) Handles btnApprovedData.Click
        UpdateStatusKRS("Approved")
    End Sub

    Private Sub btnReject_Click_1(sender As Object, e As EventArgs) Handles btnReject.Click
        UpdateStatusKRS("Rejected")
    End Sub

    Private Sub btnDasboard_Click(sender As Object, e As EventArgs) Handles btnDasboard.Click
        If ModuleKoneksi.GlobalDashboard IsNot Nothing Then
            ModuleKoneksi.GlobalDashboard.Show()
            Me.Hide()
        Else
            MessageBox.Show("Dashboard tidak ditemukan. Silakan login ulang.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Application.Exit()
    End Sub

    Private Sub btnSubmitNilai_Click(sender As Object, e As EventArgs) Handles btnSubmitNilai.Click
        DPA_SubmitNilai.Show()
        Me.Hide()
    End Sub
End Class
