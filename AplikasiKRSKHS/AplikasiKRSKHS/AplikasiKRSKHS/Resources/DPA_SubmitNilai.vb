Imports System.Data.SqlClient
Imports System.Text

Public Class DPA_SubmitNilai
    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        DPA_Approved.Show()
        Me.Hide()
    End Sub

    Private Sub btnDasboard_Click(sender As Object, e As EventArgs) Handles btnDasboard.Click
        DPA.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Application.Exit()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        ' kosong
    End Sub

    Private Sub btnSimpanData_Click(sender As Object, e As EventArgs) Handles btnSimpanData.Click
        ' --- Ambil input dari kontrol ---
        Dim nim As String = String.Empty
        Dim mataKuliah As String = String.Empty
        Dim nilaiHuruf As String = String.Empty
        Dim nilaiIndeks As Decimal = 0D
        Dim sks As Integer? = Nothing

        ' Ambil NIM dari txtNIM (jika ada)
        If Me.Controls.ContainsKey("txtNIM") Then
            nim = CType(Me.Controls("txtNIM"), TextBox).Text.Trim()
        End If

        ' Ambil MataKuliah dari cmbMataKuliah (safe)
        If cmbMataKuliah.SelectedItem IsNot Nothing Then
            If TypeOf cmbMataKuliah.SelectedItem Is DataRowView Then
                Dim drv As DataRowView = CType(cmbMataKuliah.SelectedItem, DataRowView)
                If drv.DataView.Table.Columns.Contains("MataKuliah") Then
                    mataKuliah = Convert.ToString(drv("MataKuliah")).Trim()
                ElseIf drv.DataView.Table.Columns.Contains("NamaMatkul") Then
                    mataKuliah = Convert.ToString(drv("NamaMatkul")).Trim()
                ElseIf drv.DataView.Table.Columns.Contains("Kode") Then
                    mataKuliah = Convert.ToString(drv("Kode")).Trim()
                Else
                    mataKuliah = drv(0).ToString().Trim()
                End If
            Else
                mataKuliah = cmbMataKuliah.Text.Trim()
                If String.IsNullOrWhiteSpace(mataKuliah) AndAlso cmbMataKuliah.SelectedItem IsNot Nothing Then
                    mataKuliah = cmbMataKuliah.SelectedItem.ToString().Trim()
                End If
            End If
        Else
            mataKuliah = cmbMataKuliah.Text.Trim()
        End If

        ' Ambil Nilai Huruf
        If cmbNilaiHuruf.SelectedItem IsNot Nothing Then
            nilaiHuruf = cmbNilaiHuruf.SelectedItem.ToString().Trim()
        Else
            nilaiHuruf = cmbNilaiHuruf.Text.Trim()
        End If

        ' Ambil Nilai Indeks:
        ' dukung kedua kemungkinan kontrol: txtNilaiIndeks (TextBox) atau cmbNilaiIndeks (ComboBox)
        If Me.Controls.ContainsKey("txtNilaiIndeks") Then
            Dim ctrl = CType(Me.Controls("txtNilaiIndeks"), TextBox)
            If Not String.IsNullOrWhiteSpace(ctrl.Text) Then
                Decimal.TryParse(ctrl.Text.Trim(), nilaiIndeks)
            End If
        ElseIf Me.Controls.ContainsKey("cmbNilaiIndeks") Then
            Dim cb = CType(Me.Controls("cmbNilaiIndeks"), ComboBox)
            Dim tmpD As Decimal
            If cb.SelectedItem IsNot Nothing Then
                If Decimal.TryParse(cb.SelectedItem.ToString(), tmpD) Then
                    nilaiIndeks = tmpD
                End If
            ElseIf Not String.IsNullOrWhiteSpace(cb.Text) AndAlso Decimal.TryParse(cb.Text.Trim(), tmpD) Then
                nilaiIndeks = tmpD
            End If
        End If

        ' Ambil SKS jika ada (cmbSKS)
        If Me.Controls.ContainsKey("cmbSKS") Then
            Dim ctrlSKS = CType(Me.Controls("cmbSKS"), ComboBox)
            Dim tmp As Integer
            If ctrlSKS.SelectedItem IsNot Nothing AndAlso Integer.TryParse(ctrlSKS.SelectedItem.ToString(), tmp) Then
                sks = tmp
            ElseIf Not String.IsNullOrWhiteSpace(ctrlSKS.Text) AndAlso Integer.TryParse(ctrlSKS.Text.Trim(), tmp) Then
                sks = tmp
            End If
        End If

        ' --- Validasi dasar ---
        If String.IsNullOrWhiteSpace(nim) Then
            MessageBox.Show("Pilih atau masukkan NIM mahasiswa.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If String.IsNullOrWhiteSpace(mataKuliah) Then
            MessageBox.Show("Pilih atau masukkan Mata Kuliah.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If String.IsNullOrWhiteSpace(nilaiHuruf) Then
            MessageBox.Show("Pilih Nilai Huruf.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' --- Simpan dan update database ---
        Try
            ModuleKoneksi.OpenConnection()

            Using trans As SqlTransaction = ModuleKoneksi.Conn.BeginTransaction()
                Try
                    ' 1) Ambil daftar kolom Tbl_KHS
                    Dim kolomKhs As New List(Of String)
                    Using cmdCols As New SqlCommand("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Tbl_KHS'", ModuleKoneksi.Conn, trans)
                        Using r = cmdCols.ExecuteReader()
                            While r.Read()
                                kolomKhs.Add(Convert.ToString(r("COLUMN_NAME")))
                            End While
                        End Using
                    End Using

                    If kolomKhs.Count = 0 Then
                        trans.Rollback()
                        MessageBox.Show("Tabel Tbl_KHS tidak ditemukan pada database yang sedang terhubung.", "Error DB", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If

                    ' 2) Tentukan kolom yang mewakili MataKuliah di Tbl_KHS
                    Dim candidateCols() As String = {"MataKuliah", "Mata_Kuliah", "Matakuliah", "NamaMatkul", "Kode"}
                    Dim chosenCol As String = Nothing
                    For Each c In candidateCols
                        If kolomKhs.Contains(c) Then
                            chosenCol = c
                            Exit For
                        End If
                    Next
                    If String.IsNullOrEmpty(chosenCol) Then
                        trans.Rollback()
                        MessageBox.Show("Kolom untuk menyimpan Mata Kuliah tidak ditemukan. Kolom yang ada: " & vbCrLf & String.Join(", ", kolomKhs), "Error DB", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If
                    Dim quotedKhsCol As String = "[" & chosenCol.Replace("]", "]]") & "]"

                    ' 3) Cek apakah record sudah ada
                    Dim existsObj As Object = Nothing
                    Dim existsSql As String = $"SELECT 1 FROM dbo.Tbl_KHS WHERE NIM = @nim AND {quotedKhsCol} = @mk"
                    Using cmdExists As New SqlCommand(existsSql, ModuleKoneksi.Conn, trans)
                        cmdExists.Parameters.AddWithValue("@nim", nim)
                        cmdExists.Parameters.AddWithValue("@mk", mataKuliah)
                        existsObj = cmdExists.ExecuteScalar()
                    End Using

                    Dim recordExists As Boolean = False
                    If existsObj IsNot Nothing AndAlso Not IsDBNull(existsObj) Then
                        ' jika ada, ExecuteScalar akan mengembalikan 1 (int) -> treat as exists
                        Try
                            recordExists = Convert.ToInt32(existsObj) = 1
                        Catch
                            recordExists = True
                        End Try
                    End If

                    ' 4) lakukan INSERT atau UPDATE pada Tbl_KHS
                    If recordExists Then
                        ' UPDATE
                        Dim updateSql As String = $"UPDATE dbo.Tbl_KHS SET NilaiHuruf = @nh, NilaiIndeks = @ni, sks = @sks WHERE NIM = @nim AND {quotedKhsCol} = @mk"
                        Using cmdUpd As New SqlCommand(updateSql, ModuleKoneksi.Conn, trans)
                            cmdUpd.Parameters.AddWithValue("@nh", nilaiHuruf)
                            cmdUpd.Parameters.AddWithValue("@ni", nilaiIndeks)
                            If sks.HasValue Then
                                cmdUpd.Parameters.Add("@sks", SqlDbType.TinyInt).Value = Convert.ToByte(sks.Value)
                            Else
                                cmdUpd.Parameters.AddWithValue("@sks", DBNull.Value)
                            End If
                            cmdUpd.Parameters.AddWithValue("@nim", nim)
                            cmdUpd.Parameters.AddWithValue("@mk", mataKuliah)

                            Try
                                cmdUpd.ExecuteNonQuery()
                            Catch sqlEx As SqlException
                                ShowSqlErrorAndRethrow(cmdUpd, sqlEx)
                                Throw
                            End Try
                        End Using
                    Else
                        ' INSERT
                        Dim insertSql As String = $"INSERT INTO dbo.Tbl_KHS (NIM, {quotedKhsCol}, NilaiHuruf, NilaiIndeks, sks) VALUES (@nim, @mk, @nh, @ni, @sks)"
                        Using cmdIns As New SqlCommand(insertSql, ModuleKoneksi.Conn, trans)
                            cmdIns.Parameters.AddWithValue("@nim", nim)
                            cmdIns.Parameters.AddWithValue("@mk", mataKuliah)
                            cmdIns.Parameters.AddWithValue("@nh", nilaiHuruf)
                            cmdIns.Parameters.AddWithValue("@ni", nilaiIndeks)
                            If sks.HasValue Then
                                cmdIns.Parameters.Add("@sks", SqlDbType.TinyInt).Value = Convert.ToByte(sks.Value)
                            Else
                                cmdIns.Parameters.AddWithValue("@sks", DBNull.Value)
                            End If

                            Try
                                cmdIns.ExecuteNonQuery()
                            Catch sqlEx As SqlException
                                ShowSqlErrorAndRethrow(cmdIns, sqlEx)
                                Throw
                            End Try
                        End Using
                    End If

                    ' 5) Persiapkan kolom yang ada di Tbl_JadwalPerkuliahan untuk update KRS
                    Dim jadwalCols As New List(Of String)
                    Using cmdJ As New SqlCommand("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Tbl_JadwalPerkuliahan'", ModuleKoneksi.Conn, trans)
                        Using rj = cmdJ.ExecuteReader()
                            While rj.Read()
                                jadwalCols.Add(Convert.ToString(rj("COLUMN_NAME")))
                            End While
                        End Using
                    End Using

                    ' Pilih kolom jadwal yang cocok untuk membandingkan MataKuliah/kode
                    Dim jadwalMatchCol As String = Nothing
                    If jadwalCols.Contains(chosenCol) Then
                        jadwalMatchCol = chosenCol
                    ElseIf jadwalCols.Contains("Kode") Then
                        jadwalMatchCol = "Kode"
                    ElseIf jadwalCols.Contains("NamaMatkul") Then
                        jadwalMatchCol = "NamaMatkul"
                    End If

                    If Not String.IsNullOrEmpty(jadwalMatchCol) Then
                        Dim quotedJadwalCol As String = "[" & jadwalMatchCol.Replace("]", "]]") & "]"
                        Dim updateKrsSql As String = $"UPDATE k SET k.Status_Approve = 'Approved' FROM Tbl_KRS k INNER JOIN Tbl_JadwalPerkuliahan j ON k.IDJadwal = j.IDJadwal WHERE k.NIM = @nim AND j.{quotedJadwalCol} = @mk"

                        Using cmdUpdKrs As New SqlCommand(updateKrsSql, ModuleKoneksi.Conn, trans)
                            cmdUpdKrs.Parameters.AddWithValue("@nim", nim)
                            cmdUpdKrs.Parameters.AddWithValue("@mk", mataKuliah)
                            Try
                                cmdUpdKrs.ExecuteNonQuery()
                            Catch sqlEx As SqlException
                                ShowSqlErrorAndRethrow(cmdUpdKrs, sqlEx)
                                Throw
                            End Try
                        End Using
                    Else
                        ' fallback: jika jadwal punya kolom Kode coba dengan itu
                        If jadwalCols.Contains("Kode") Then
                            Using cmdFallback As New SqlCommand("UPDATE k SET k.Status_Approve='Approved' FROM Tbl_KRS k INNER JOIN Tbl_JadwalPerkuliahan j ON k.IDJadwal = j.IDJadwal WHERE k.NIM=@nim AND j.Kode=@mk", ModuleKoneksi.Conn, trans)
                                cmdFallback.Parameters.AddWithValue("@nim", nim)
                                cmdFallback.Parameters.AddWithValue("@mk", mataKuliah)
                                Try
                                    cmdFallback.ExecuteNonQuery()
                                Catch sqlEx As SqlException
                                    ShowSqlErrorAndRethrow(cmdFallback, sqlEx)
                                    Throw
                                End Try
                            End Using
                        Else
                            ' tidak ada kolom cocok -> beri informasi dan lanjutkan (KHS sudah ditulis)
                            MessageBox.Show("Update KRS tidak dijalankan karena tidak ditemukan kolom yang cocok di Tbl_JadwalPerkuliahan untuk mencocokkan mata kuliah/kode. Silakan cek struktur tabel jadwal jika perlu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End If

                    trans.Commit()

                    ' --- setelah trans.Commit() ---
                    Try
                        ' cari instance Mhs_KHS yang sedang terbuka
                        Dim frm As Mhs_KHS = Nothing
                        For Each f As Form In Application.OpenForms
                            If TypeOf f Is Mhs_KHS Then
                                frm = CType(f, Mhs_KHS)
                                Exit For
                            End If
                        Next

                        If frm IsNot Nothing Then
                            ' panggil refresh untuk NIM yang baru saja disimpan
                            frm.RefreshKHS(nim)
                        End If
                    Catch ex As Exception
                        ' optional: log, tapi jangan ganggu flow utama
                    End Try

                    ' Bersihkan input agar UI siap pakai lagi
                    ClearInputs()

                    MessageBox.Show("Nilai tersimpan. KRS mahasiswa ditandai 'Approved'.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Catch exInner As Exception
                    Try
                        trans.Rollback()
                    Catch : End Try
                    Throw
                End Try
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan nilai: " & ex.Message, "Error DB", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Try : ModuleKoneksi.CloseConnection() : Catch : End Try
        End Try
    End Sub

    ' --- Clear semua input yang relevan (panggil setelah commit) ---
    Private Sub ClearInputs()
        Try
            If Me.Controls.ContainsKey("txtNIM") Then CType(Me.Controls("txtNIM"), TextBox).Clear()

            If Me.Controls.ContainsKey("cmbMataKuliah") Then
                Dim cb = CType(Me.Controls("cmbMataKuliah"), ComboBox)
                cb.SelectedIndex = -1
                cb.Text = ""
            End If

            If Me.Controls.ContainsKey("cmbNilaiHuruf") Then
                Dim cb = CType(Me.Controls("cmbNilaiHuruf"), ComboBox)
                cb.SelectedIndex = -1
                cb.Text = ""
            End If

            ' Nilai Indeks: dukung txt atau cmb
            If Me.Controls.ContainsKey("txtNilaiIndeks") Then CType(Me.Controls("txtNilaiIndeks"), TextBox).Clear()
            If Me.Controls.ContainsKey("cmbNilaiIndeks") Then
                Dim cb = CType(Me.Controls("cmbNilaiIndeks"), ComboBox)
                cb.SelectedIndex = -1
                cb.Text = ""
            End If

            ' SKS
            If Me.Controls.ContainsKey("cmbSKS") Then
                Dim cb = CType(Me.Controls("cmbSKS"), ComboBox)
                cb.SelectedIndex = -1
                cb.Text = ""
            End If
        Catch
            ' ignore errors while clearing UI
        End Try
    End Sub

    ' Helper: tampilkan detail command (CommandText + parameter) saat SqlException
    Private Sub ShowSqlErrorAndRethrow(cmd As SqlCommand, sqlEx As SqlException)
        Try
            Dim sb As New StringBuilder()
            sb.AppendLine("SQL ERROR: " & sqlEx.Message)
            sb.AppendLine("Number: " & sqlEx.Number.ToString())
            sb.AppendLine()
            sb.AppendLine("CommandText:")
            sb.AppendLine(cmd.CommandText)
            sb.AppendLine()
            sb.AppendLine("Parameters:")
            For Each p As SqlParameter In cmd.Parameters
                Dim val As String = If(p.Value Is Nothing OrElse p.Value Is DBNull.Value, "<null>", p.Value.ToString())
                sb.AppendLine($"{p.ParameterName} = {val}")
            Next
            MessageBox.Show(sb.ToString(), "SQL Debug", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch
            ' ignore
        End Try
    End Sub

End Class
