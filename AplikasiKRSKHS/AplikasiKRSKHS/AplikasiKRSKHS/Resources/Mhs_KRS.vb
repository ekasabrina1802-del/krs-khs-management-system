Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Printing

Public Class Mhs_KRS

    ' ==============================
    ' Properti publik (dari Login)
    ' ==============================
    Public Property NamaMahasiswa As String
    Public Property NIM_Mahasiswa As String

    ' ------------------------------
    ' Kontrol dinamis (jika belum ada di Designer)
    ' ------------------------------
    Private dgvTakenKRS As DataGridView = Nothing
    Private dgvPendingKRS As DataGridView = Nothing
    Private TabControl1 As TabControl = Nothing

    ' ==============================
    ' Printing state (untuk paging)
    ' ==============================
    Private printDGV As DataGridView = Nothing
    Private printRowIndex As Integer = 0
    Private printColWidths As List(Of Integer) = Nothing
    Private printTotalWidth As Integer = 0
    Private printHeaderHeight As Integer = 0
    Private printingFont As Font = Nothing
    Private printingHeaderFont As Font = Nothing
    Private printingSubFont As Font = Nothing

    ' ============================================================
    ' SHOWN -> dipanggil setiap kali form tampil (refresh state)
    ' ============================================================
    Private Sub Mhs_KRS_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        RefreshProfile()
        EnsureTabsAndGrids()   ' pastikan TabControl + grids ada
        LoadKelas()
        LoadTakenKRS()
        LoadPendingKRS()
    End Sub

    Public Sub RefreshProfile()
        If String.IsNullOrWhiteSpace(NIM_Mahasiswa) Then
            lblNamaMahasiswa.Text = "Error: NIM Tidak Diterima"
            lblNIM.Text = "-"
            Return
        End If

        lblNamaMahasiswa.Text = If(String.IsNullOrWhiteSpace(NamaMahasiswa), "(Nama tidak tersedia)", NamaMahasiswa)
        lblNIM.Text = NIM_Mahasiswa
    End Sub

    ' ============================================================
    ' Pastikan TabControl + TabPages + DataGridView ada (atau buat)
    ' ============================================================
    Private Sub EnsureTabsAndGrids()
        If TabControl1 Is Nothing Then
            TabControl1 = New TabControl()
            TabControl1.Name = "TabControl1"
            TabControl1.Dock = DockStyle.None

            Dim leftPos As Integer = 10
            Dim widthTab As Integer = CInt(Me.ClientSize.Width * 0.85)
            Dim topPos As Integer = CInt(FlowLayoutPanel1.Bottom + 10)

            If FlowLayoutPanel1 IsNot Nothing Then
                leftPos = FlowLayoutPanel1.Left
                widthTab = FlowLayoutPanel1.Width
                topPos = FlowLayoutPanel1.Bottom + 8
            End If

            TabControl1.Left = leftPos
            TabControl1.Top = topPos
            TabControl1.Width = widthTab
            TabControl1.Height = CInt(Me.ClientSize.Height * 0.35)
            TabControl1.Anchor = AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Bottom

            Me.Controls.Add(TabControl1)
            TabControl1.BringToFront()
        End If

        Dim tabApproved As TabPage = Nothing
        Dim tabPending As TabPage = Nothing
        For Each tp As TabPage In TabControl1.TabPages
            If tp.Name = "TabApproved" Then tabApproved = tp
            If tp.Name = "TabPending" Then tabPending = tp
        Next

        If tabApproved Is Nothing Then
            tabApproved = New TabPage("Approved")
            tabApproved.Name = "TabApproved"
            TabControl1.TabPages.Add(tabApproved)
        End If
        If tabPending Is Nothing Then
            tabPending = New TabPage("Pending")
            tabPending.Name = "TabPending"
            TabControl1.TabPages.Add(tabPending)
        End If

        If dgvTakenKRS Is Nothing Then
            For Each ctl As Control In tabApproved.Controls
                If TypeOf ctl Is DataGridView Then
                    dgvTakenKRS = CType(ctl, DataGridView)
                    Exit For
                End If
            Next
            If dgvTakenKRS Is Nothing Then
                dgvTakenKRS = New DataGridView()
                dgvTakenKRS.Name = "dgvTakenKRS"
                dgvTakenKRS.Dock = DockStyle.Fill
                dgvTakenKRS.ReadOnly = True
                dgvTakenKRS.AllowUserToAddRows = False
                dgvTakenKRS.AllowUserToDeleteRows = False
                tabApproved.Controls.Add(dgvTakenKRS)
            End If
        End If

        If dgvPendingKRS Is Nothing Then
            For Each ctl As Control In tabPending.Controls
                If TypeOf ctl Is DataGridView Then
                    dgvPendingKRS = CType(ctl, DataGridView)
                    Exit For
                End If
            Next
            If dgvPendingKRS Is Nothing Then
                dgvPendingKRS = New DataGridView()
                dgvPendingKRS.Name = "dgvPendingKRS"
                dgvPendingKRS.Dock = DockStyle.Fill
                dgvPendingKRS.ReadOnly = True
                dgvPendingKRS.AllowUserToAddRows = False
                dgvPendingKRS.AllowUserToDeleteRows = False
                tabPending.Controls.Add(dgvPendingKRS)
            End If
        End If
    End Sub

    ' ============================================================
    ' LOAD KELAS (FlowLayoutPanel show kelas)
    ' ============================================================
    Private Sub LoadKelas()
        FlowLayoutPanel1.Controls.Clear()

        Try
            ModuleKoneksi.OpenConnection()

            Dim sql As String = "SELECT DISTINCT Kelas FROM Tbl_JadwalPerkuliahan ORDER BY Kelas"
            Using cmd As New SqlCommand(sql, ModuleKoneksi.Conn)
                Using da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    For Each row As DataRow In dt.Rows
                        BuatPanelKelas(row("Kelas").ToString())
                    Next
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error memuat kelas: " & ex.Message, "Error DB", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ModuleKoneksi.CloseConnection()
        End Try
    End Sub

    Private Sub BuatPanelKelas(kelasName As String)
        Dim grp As New GroupBox()
        grp.Text = "Kelas " & kelasName
        grp.Width = 650
        grp.Height = 260
        grp.Margin = New Padding(10)

        Dim dgv As New DataGridView()
        dgv.Width = 620
        dgv.Height = 190
        dgv.Top = 20
        dgv.Left = 10
        dgv.ReadOnly = True
        dgv.AllowUserToAddRows = False
        dgv.AllowUserToDeleteRows = False
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.AutoGenerateColumns = True

        Dim dt = GetJadwalByKelas(kelasName)
        dgv.DataSource = dt

        If dgv.Columns.Contains("IDJadwal") Then dgv.Columns("IDJadwal").Visible = False
        If dgv.Columns.Contains("Kode") Then dgv.Columns("Kode").HeaderText = "Kode"
        If dgv.Columns.Contains("MataKuliah") Then dgv.Columns("MataKuliah").HeaderText = "Mata Kuliah"
        If dgv.Columns.Contains("SKS") Then dgv.Columns("SKS").HeaderText = "SKS"
        If dgv.Columns.Contains("Kelas") Then dgv.Columns("Kelas").HeaderText = "Kelas"
        If dgv.Columns.Contains("Ruang") Then dgv.Columns("Ruang").HeaderText = "Ruang"
        If dgv.Columns.Contains("Hari") Then dgv.Columns("Hari").HeaderText = "Hari"
        If dgv.Columns.Contains("JamMulai") Then dgv.Columns("JamMulai").HeaderText = "Jam Mulai"
        If dgv.Columns.Contains("JamSelesai") Then dgv.Columns("JamSelesai").HeaderText = "Jam Selesai"

        Dim btnAmbil As New Button()
        btnAmbil.Text = "Ambil KRS"
        btnAmbil.Width = 120
        btnAmbil.Top = 215
        btnAmbil.Left = 10
        btnAmbil.Tag = kelasName
        AddHandler btnAmbil.Click, AddressOf AmbilKRS_Click

        grp.Controls.Add(dgv)
        grp.Controls.Add(btnAmbil)

        FlowLayoutPanel1.Controls.Add(grp)
    End Sub

    Private Function GetJadwalByKelas(kelas As String) As DataTable
        Dim dt As New DataTable()
        Try
            ModuleKoneksi.OpenConnection()
            Dim sql As String = "SELECT j.IDJadwal, j.Kode, m.MataKuliah, m.SKS, j.Kelas, j.Ruang, j.Hari, j.JamMulai, j.JamSelesai " &
                                "FROM Tbl_JadwalPerkuliahan j INNER JOIN Tbl_MataKuliah m ON j.Kode = m.Kode " &
                                "WHERE j.Kelas = @kelas " &
                                "ORDER BY CASE j.Hari WHEN 'Senin' THEN 1 WHEN 'Selasa' THEN 2 WHEN 'Rabu' THEN 3 WHEN 'Kamis' THEN 4 WHEN 'Jumat' THEN 5 END, j.JamMulai"

            Using cmd As New SqlCommand(sql, ModuleKoneksi.Conn)
                cmd.Parameters.AddWithValue("@kelas", kelas)
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            Throw
        Finally
            ModuleKoneksi.CloseConnection()
        End Try
        Return dt
    End Function

    ' ============================================================
    ' AMBIL KRS (CEK DUPLIKAT) → INSERT Status_Approve = 'Pending'
    ' ============================================================
    Private Sub AmbilKRS_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim kelasName As String = btn.Tag.ToString()

        Dim grp As GroupBox = CType(btn.Parent, GroupBox)
        Dim dgv As DataGridView = CType(grp.Controls.OfType(Of DataGridView)().FirstOrDefault(), DataGridView)
        If dgv Is Nothing OrElse dgv.Rows.Count = 0 Then
            MessageBox.Show("Tidak ada jadwal yang bisa diambil.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("Ambil semua jadwal untuk kelas " & kelasName & "?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
            Return
        End If

        Dim nimMhs As String = Me.NIM_Mahasiswa
        If String.IsNullOrWhiteSpace(nimMhs) Then
            MessageBox.Show("NIM tidak tersedia. Silakan login ulang.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ModuleKoneksi.OpenConnection()

            Dim sqlCekPaket As String =
            "SELECT TOP 1 j.Kelas " &
            "FROM Tbl_KRS k " &
            "INNER JOIN Tbl_JadwalPerkuliahan j ON k.IDJadwal = j.IDJadwal " &
            "WHERE k.NIM = @nim " &
            "  AND (k.Status_Approve = 'Pending' OR k.Status_Approve = 'Approved')"

            Dim kelasSudahAda As String = Nothing
            Using cmdCek As New SqlCommand(sqlCekPaket, ModuleKoneksi.Conn)
                cmdCek.Parameters.AddWithValue("@nim", nimMhs)
                Dim obj = cmdCek.ExecuteScalar()
                If obj IsNot Nothing AndAlso obj IsNot DBNull.Value Then
                    kelasSudahAda = obj.ToString()
                End If
            End Using

            If Not String.IsNullOrEmpty(kelasSudahAda) AndAlso
           Not String.Equals(kelasSudahAda, kelasName, StringComparison.OrdinalIgnoreCase) Then

                MessageBox.Show(
                "Anda sudah mengambil paket KRS di kelas " & kelasSudahAda &
                ". Mahasiswa hanya boleh mengambil satu paket KRS. " &
                vbCrLf & "Jika ingin pindah paket, minta DPA untuk menolak / membatalkan KRS sebelumnya.",
                "Tidak Diizinkan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

                Return
            End If

            Using trans = ModuleKoneksi.Conn.BeginTransaction()
                Try
                    Dim insertSql As String = "INSERT INTO Tbl_KRS (NIM, IDJadwal, Status_Approve) VALUES (@nim, @idjadwal, 'Pending')"
                    Dim existsSql As String = "SELECT COUNT(1) FROM Tbl_KRS WHERE NIM = @nim AND IDJadwal = @idjadwal AND ISNULL(Status_Approve,'') <> 'Rejected'"

                    Using cmdExists As New SqlCommand(existsSql, ModuleKoneksi.Conn, trans)
                        cmdExists.Parameters.Add("@nim", SqlDbType.VarChar, 20).Value = nimMhs
                        cmdExists.Parameters.Add("@idjadwal", SqlDbType.Int)

                        Using cmdInsert As New SqlCommand(insertSql, ModuleKoneksi.Conn, trans)
                            cmdInsert.Parameters.Add("@nim", SqlDbType.VarChar, 20).Value = nimMhs
                            cmdInsert.Parameters.Add("@idjadwal", SqlDbType.Int)

                            Dim countInserted As Integer = 0
                            Dim countSkipped As Integer = 0

                            For Each row As DataGridViewRow In dgv.Rows
                                If row.IsNewRow Then Continue For
                                Dim idJadwal As Integer = Convert.ToInt32(row.Cells("IDJadwal").Value)

                                cmdExists.Parameters("@idjadwal").Value = idJadwal
                                Dim already As Integer = Convert.ToInt32(cmdExists.ExecuteScalar())
                                If already > 0 Then
                                    countSkipped += 1
                                    Continue For
                                End If

                                cmdInsert.Parameters("@idjadwal").Value = idJadwal
                                cmdInsert.ExecuteNonQuery()
                                countInserted += 1
                            Next

                            trans.Commit()
                            Dim msg As String = "Proses selesai. Berhasil disimpan: " & countInserted & " baris."
                            If countSkipped > 0 Then msg &= vbCrLf & "Lewat karena sudah pernah diambil: " & countSkipped & " baris."
                            MessageBox.Show(msg, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End Using
                    End Using
                Catch exTrans As Exception
                    trans.Rollback()
                    Throw
                End Try
            End Using

        Catch ex As Exception
            MessageBox.Show("Error saat menyimpan data KRS: " & ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ModuleKoneksi.CloseConnection()
        End Try

        LoadTakenKRS()
        LoadPendingKRS()
    End Sub


    ' ============================================================
    ' LOAD KRS APPROVED (untuk mahasiswa)
    ' ============================================================
    Private Sub LoadTakenKRS()
        Try
            EnsureTabsAndGrids()

            Dim dt As New DataTable()
            ModuleKoneksi.OpenConnection()

            Dim sql As String =
                "SELECT k.ID_KRS, j.Kode, m.MataKuliah, m.SKS, j.Kelas, j.Ruang " &
                "FROM Tbl_KRS k " &
                "INNER JOIN Tbl_JadwalPerkuliahan j ON k.IDJadwal = j.IDJadwal " &
                "INNER JOIN Tbl_MataKuliah m ON j.Kode = m.Kode " &
                "WHERE k.NIM = @nim AND k.Status_Approve = 'Approved' " &
                "ORDER BY j.Kelas, m.MataKuliah"

            Using cmd As New SqlCommand(sql, ModuleKoneksi.Conn)
                cmd.Parameters.AddWithValue("@nim", NIM_Mahasiswa)
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using

            dgvTakenKRS.DataSource = dt
            If dgvTakenKRS.Columns.Contains("ID_KRS") Then dgvTakenKRS.Columns("ID_KRS").Visible = False

        Catch ex As Exception
            MessageBox.Show("Error memuat KRS yang disetujui: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ModuleKoneksi.CloseConnection()
        End Try
    End Sub

    ' ============================================================
    ' LOAD KRS PENDING (untuk mahasiswa melihat status pending)
    ' ============================================================
    Private Sub LoadPendingKRS()
        Try
            EnsureTabsAndGrids()

            Dim dt As New DataTable()
            ModuleKoneksi.OpenConnection()

            Dim sql As String =
                "SELECT k.ID_KRS, j.Kode, m.MataKuliah, m.SKS, j.Kelas, j.Ruang, ISNULL(k.Status_Approve,'') as Status_Approve " &
                "FROM Tbl_KRS k " &
                "INNER JOIN Tbl_JadwalPerkuliahan j ON k.IDJadwal = j.IDJadwal " &
                "INNER JOIN Tbl_MataKuliah m ON j.Kode = m.Kode " &
                "WHERE k.NIM = @nim AND (k.Status_Approve = 'Pending' OR ISNULL(k.Status_Approve,'') = '') " &
                "ORDER BY j.Kelas, m.MataKuliah"

            Using cmd As New SqlCommand(sql, ModuleKoneksi.Conn)
                cmd.Parameters.AddWithValue("@nim", NIM_Mahasiswa)
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using

            dgvPendingKRS.DataSource = dt
            If dgvPendingKRS.Columns.Contains("ID_KRS") Then dgvPendingKRS.Columns("ID_KRS").Visible = False
            If dgvPendingKRS.Columns.Contains("Status_Approve") Then dgvPendingKRS.Columns("Status_Approve").HeaderText = "Status"

        Catch ex As Exception
            MessageBox.Show("Error memuat KRS pending: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ModuleKoneksi.CloseConnection()
        End Try
    End Sub

    ' ============================================================
    ' NAVIGASI & LOGOUT
    ' ============================================================
    Private Sub btnDasboard_Click(sender As Object, e As EventArgs) Handles btnDasboard.Click
        If ModuleKoneksi.GlobalDashboard IsNot Nothing Then
            ModuleKoneksi.GlobalDashboard.Show()
            Me.Hide()
        Else
            MessageBox.Show("Dashboard tidak ditemukan. Silakan login ulang.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnKHS_Click(sender As Object, e As EventArgs) Handles btnKHS.Click
        Dim frm As New Mhs_KHS()
        frm.NIM_Mahasiswa = Me.NIM_Mahasiswa
        frm.NamaMahasiswa = Me.NamaMahasiswa
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Application.Exit()
    End Sub

    ' ============================================================
    ' CETAK: inisialisasi & print
    ' ============================================================
    Private WithEvents PrintDocument2 As New Printing.PrintDocument()
    Private PrintPreviewDialog2 As New PrintPreviewDialog()

    Private Sub btnCetakKRS_Click(sender As Object, e As EventArgs) Handles btnCetakKRS.Click
        If TabControl1 Is Nothing Then
            MessageBox.Show("TabControl tidak ditemukan. Tidak dapat mencetak.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim selectedTab As TabPage = TabControl1.SelectedTab
        If selectedTab Is Nothing Then
            MessageBox.Show("Pilih tab (Approved/Pending) sebelum mencetak.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim dgvFound As DataGridView = Nothing
        For Each ctl As Control In selectedTab.Controls
            If TypeOf ctl Is DataGridView Then
                dgvFound = CType(ctl, DataGridView)
                Exit For
            End If
        Next

        If dgvFound Is Nothing Then
            MessageBox.Show("Tidak ada tabel pada tab yang dipilih.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        printDGV = dgvFound

        printingHeaderFont = New Font("Segoe UI", 14, FontStyle.Bold)
        printingSubFont = New Font("Segoe UI", 10, FontStyle.Regular)
        printingFont = New Font("Segoe UI", 9, FontStyle.Regular)

        printRowIndex = 0
        printColWidths = Nothing
        printTotalWidth = 0

        PrintPreviewDialog2.Document = PrintDocument2
        PrintPreviewDialog2.WindowState = FormWindowState.Maximized
        ' pastikan preview zoom ke 1 (full visible)
        Try
            PrintPreviewDialog2.PrintPreviewControl.Zoom = 1.0
        Catch
        End Try
        PrintPreviewDialog2.ShowDialog()
    End Sub

    Private Sub PrintDocument2_BeginPrint(sender As Object, e As PrintEventArgs) Handles PrintDocument2.BeginPrint
        printRowIndex = 0
        printColWidths = Nothing
        printTotalWidth = 0
    End Sub

    Private Sub PrintDocument2_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
        If printDGV Is Nothing Then
            e.Graphics.DrawString("Tidak ada data untuk dicetak", New Font("Segoe UI", 10), Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top)
            e.HasMorePages = False
            Return
        End If

        Dim leftMargin As Integer = e.MarginBounds.Left
        Dim topMargin As Integer = e.MarginBounds.Top
        Dim pageWidth As Integer = e.MarginBounds.Width
        Dim pageHeight As Integer = e.MarginBounds.Height

        ' =========================
        ' CETAK LOGO DI ATAS (TENGAH) — perbesar sesuai kebutuhan
        ' =========================
        Dim curY As Integer = topMargin - 40
        Try
            Dim logo As Image = My.Resources.cover_sintesa ' <-- ganti kalau nama resource beda
            If logo IsNot Nothing Then
                Dim logoMaxWidth As Integer = 400 ' perbesar sesuai kebutuhan
                Dim logoMaxHeight As Integer = 400
                Dim ratio As Double = Math.Min(logoMaxWidth / logo.Width, logoMaxHeight / logo.Height)
                If ratio <= 0 Then ratio = 1
                Dim logoWidth As Integer = CInt(logo.Width * ratio)
                Dim logoHeight As Integer = CInt(logo.Height * ratio)
                Dim centerX As Integer = leftMargin + (pageWidth - logoWidth) \ 2

                ' jika ingin sedikit naik ke atas gunakan curY = topMargin - 20
                e.Graphics.DrawImage(logo, centerX, curY, logoWidth, logoHeight)
                curY += logoHeight + 12

                ' =========================
                ' GARIS HORIZONTAL DI BAWAH LOGO
                ' =========================
                ' buat garis melintang di bawah logo dengan jarak tambahan agar tidak mepet
                Dim lineY As Integer = curY + 8 ' jarak 8px setelah logo
                e.Graphics.DrawLine(Pens.Black, leftMargin, lineY, leftMargin + pageWidth, lineY)
                curY = lineY + 12 ' beri jarak ke bawah sebelum header

                ' =========================
                ' CETAK TEKS "Kartu Rencana Studi (KRS)"
                ' =========================
                Dim titleKRS As String = "Kartu Rencana Studi (KRS)"
                Dim titleFont As New Font("Segoe UI", 14, FontStyle.Bold)
                Dim sizeTitle As SizeF = e.Graphics.MeasureString(titleKRS, titleFont)
                Dim centerTitleX As Integer = leftMargin + (pageWidth - sizeTitle.Width) \ 2

                e.Graphics.DrawString(titleKRS, titleFont, Brushes.Black, centerTitleX, curY)

                curY += CInt(sizeTitle.Height) + 20 ' beri jarak sebelum nama & NIM

            End If
        Catch
            ' lanjut tanpa logo jika error
        End Try

        ' =========================
        ' CETAK HEADER (Nama & NIM)
        ' =========================
        Dim headerText As String = "Nama: " & If(String.IsNullOrWhiteSpace(lblNamaMahasiswa.Text), NamaMahasiswa, lblNamaMahasiswa.Text)
        Dim nimText As String = "NIM: " & If(String.IsNullOrWhiteSpace(lblNIM.Text), NIM_Mahasiswa, lblNIM.Text)

        e.Graphics.DrawString(headerText, printingSubFont, Brushes.Black, leftMargin, curY + CInt(printingSubFont.GetHeight(e.Graphics) + 6))
        e.Graphics.DrawString(nimText, printingSubFont, Brushes.Black, leftMargin, curY + CInt(printingHeaderFont.GetHeight(e.Graphics) + 22))

        Dim extraSpacing As Integer = 16
        curY += CInt(printingSubFont.GetHeight(e.Graphics)) + extraSpacing

        Dim headerBlockHeight As Integer = CInt(printingHeaderFont.GetHeight(e.Graphics) + printingSubFont.GetHeight(e.Graphics) + 10)
        curY += headerBlockHeight

        ' prepare columns widths once
        If printColWidths Is Nothing Then
            CalculateColumnWidthsForPrinting(e.Graphics, pageWidth)
        End If

        ' area for table
        Dim tableTop As Integer = curY
        curY = tableTop

        ' print table header
        Dim headerHeight As Integer = PrintTableHeader(e.Graphics, leftMargin, curY)
        curY += headerHeight

        ' rows
        Dim rowHeight As Integer = CInt(printingFont.GetHeight(e.Graphics) + 6)
        Dim rowsPerPageAvailableHeight As Integer = (pageHeight - (curY - topMargin) - 80) ' sisakan ruang footer
        Dim maxRowsThisPage As Integer = Math.Max(1, rowsPerPageAvailableHeight \ rowHeight)

        Dim rowsPrinted As Integer = 0
        Dim totalRows As Integer = printDGV.Rows.Count

        While printRowIndex < totalRows AndAlso rowsPrinted < maxRowsThisPage
            Dim dgvr As DataGridViewRow = printDGV.Rows(printRowIndex)
            If dgvr.IsNewRow Then
                printRowIndex += 1
                Continue While
            End If

            Dim curX As Integer = leftMargin
            Dim colIdx As Integer = 0

            For Each col As DataGridViewColumn In printDGV.Columns
                If Not col.Visible Then Continue For

                Dim cellText As String = If(dgvr.Cells(col.Index).Value Is Nothing, "", dgvr.Cells(col.Index).Value.ToString())
                Dim rect As New Rectangle(curX, curY, printColWidths(colIdx), rowHeight)
                e.Graphics.DrawRectangle(Pens.Black, rect)

                Dim sf As New StringFormat()
                sf.Alignment = StringAlignment.Near
                sf.LineAlignment = StringAlignment.Center
                sf.Trimming = StringTrimming.EllipsisCharacter

                If String.Compare(col.HeaderText, "SKS", True) = 0 Then
                    sf.Alignment = StringAlignment.Far
                    Dim paddedRect As Rectangle = rect
                    paddedRect.Inflate(-6, 0)
                    e.Graphics.DrawString(cellText, printingFont, Brushes.Black, paddedRect, sf)
                Else
                    Dim paddedRect As Rectangle = rect
                    paddedRect.Inflate(-6, 0)
                    e.Graphics.DrawString(cellText, printingFont, Brushes.Black, paddedRect, sf)
                End If

                curX += printColWidths(colIdx)
                colIdx += 1
            Next

            curY += rowHeight
            printRowIndex += 1
            rowsPrinted += 1
        End While

        ' Jika ini halaman terakhir (semua baris sudah dicetak), gambar Total SKS
        If printRowIndex >= totalRows Then
            ' hitung total SKS dari semua row
            Dim totalSksAll As Integer = 0
            Try
                ' cari indeks kolom SKS di printDGV
                Dim idxSksCol As Integer = -1
                For Each c As DataGridViewColumn In printDGV.Columns
                    If String.Compare(c.HeaderText, "SKS", True) = 0 OrElse String.Compare(c.Name, "SKS", True) = 0 Then
                        idxSksCol = c.Index
                        Exit For
                    End If
                Next

                For Each r As DataGridViewRow In printDGV.Rows
                    If r.IsNewRow Then Continue For
                    If idxSksCol >= 0 AndAlso idxSksCol < r.Cells.Count Then
                        Dim sval As String = If(r.Cells(idxSksCol).Value Is Nothing, "0", r.Cells(idxSksCol).Value.ToString())
                        Dim tmp As Integer = 0
                        Integer.TryParse(sval, tmp)
                        totalSksAll += tmp
                    Else
                        ' fallback: coba cari kolom SKS berdasarkan header text scanning
                        For Each cc As DataGridViewColumn In printDGV.Columns
                            If String.Compare(cc.HeaderText, "SKS", True) = 0 Then
                                Dim sval As String = If(r.Cells(cc.Index).Value Is Nothing, "0", r.Cells(cc.Index).Value.ToString())
                                Dim tmp As Integer = 0
                                Integer.TryParse(sval, tmp)
                                totalSksAll += tmp
                                Exit For
                            End If
                        Next
                    End If
                Next
            Catch
                totalSksAll = 0
            End Try

            ' gambar baris Total SKS (gabungkan semua kolom kecuali kolom terakhir untuk label)
            If printColWidths IsNot Nothing AndAlso printColWidths.Count > 0 Then
                Dim totalColsVisible As Integer = printColWidths.Count
                Dim labelWidth As Integer = 0
                For i As Integer = 0 To totalColsVisible - 2
                    labelWidth += printColWidths(i)
                Next
                Dim valueWidth As Integer = printColWidths(totalColsVisible - 1)

                Dim rectLabel As New Rectangle(leftMargin, curY, labelWidth, rowHeight)
                Dim rectValue As New Rectangle(leftMargin + labelWidth, curY, valueWidth, rowHeight)

                e.Graphics.FillRectangle(Brushes.LightGray, rectLabel)
                e.Graphics.DrawRectangle(Pens.Black, rectLabel)
                e.Graphics.DrawRectangle(Pens.Black, rectValue)

                Dim sfLabel As New StringFormat()
                sfLabel.Alignment = StringAlignment.Center
                sfLabel.LineAlignment = StringAlignment.Center

                e.Graphics.DrawString("Total SKS", printingFont, Brushes.Black, rectLabel, sfLabel)

                Dim sfValue As New StringFormat()
                sfValue.Alignment = StringAlignment.Far
                sfValue.LineAlignment = StringAlignment.Center
                Dim paddedValueRect As Rectangle = rectValue
                paddedValueRect.Inflate(-6, 0)
                e.Graphics.DrawString(totalSksAll.ToString(), printingFont, Brushes.Black, paddedValueRect, sfValue)

                curY += rowHeight
            End If
        End If

        ' footer page number (simple)
        Static printedPages As Integer = 0
        printedPages += 1
        Dim footerText As String = "Halaman " & printedPages.ToString()
        Dim ftSize As SizeF = e.Graphics.MeasureString(footerText, printingSubFont)
        e.Graphics.DrawString(footerText, printingSubFont, Brushes.Black, leftMargin + pageWidth - CInt(ftSize.Width), topMargin + pageHeight + 10 - CInt(ftSize.Height))

        If printRowIndex < totalRows Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            printRowIndex = 0
            printColWidths = Nothing
            printTotalWidth = 0
            printedPages = 0
        End If
    End Sub

    ' Hitung lebar kolom yang akan dipakai untuk menggambar
    Private Sub CalculateColumnWidthsForPrinting(g As Graphics, pageWidth As Integer)
        printColWidths = New List(Of Integer)()
        printTotalWidth = 0

        Dim visibleColumns As New List(Of DataGridViewColumn)()
        For Each col As DataGridViewColumn In printDGV.Columns
            If col.Visible Then visibleColumns.Add(col)
        Next

        For Each col As DataGridViewColumn In visibleColumns
            Dim maxW As Integer = 0
            Dim headerText As String = If(String.IsNullOrEmpty(col.HeaderText), col.Name, col.HeaderText)
            Dim headerSize As SizeF = g.MeasureString(headerText, printingFont)
            maxW = CInt(headerSize.Width)

            Dim rowsToCheck As Integer = Math.Min(100, printDGV.Rows.Count)
            For r As Integer = 0 To rowsToCheck - 1
                Dim cellVal As Object = printDGV.Rows(r).Cells(col.Index).Value
                If cellVal IsNot Nothing Then
                    Dim s As String = cellVal.ToString()
                    Dim sz As SizeF = g.MeasureString(s, printingFont, 300)
                    If CInt(sz.Width) > maxW Then maxW = CInt(sz.Width)
                End If
            Next

            Dim prefW As Integer = maxW + 24

            If String.Compare(col.HeaderText, "Ruang", True) = 0 Or String.Compare(col.Name, "Ruang", True) = 0 Then
                If prefW < 140 Then prefW = 140
            Else
                If prefW < 60 Then prefW = 60
            End If

            printColWidths.Add(prefW)
            printTotalWidth += prefW
        Next

        If printTotalWidth > pageWidth Then
            Dim scale As Single = pageWidth / CSng(printTotalWidth)
            For i As Integer = 0 To printColWidths.Count - 1
                printColWidths(i) = CInt(printColWidths(i) * scale)
                If printColWidths(i) < 40 Then printColWidths(i) = 40
            Next
            printTotalWidth = 0
            For Each w In printColWidths
                printTotalWidth += w
            Next
        Else
            Dim extra As Integer = pageWidth - printTotalWidth
            If extra > 0 AndAlso printColWidths.Count > 0 Then
                Dim addPerCol As Integer = extra \ printColWidths.Count
                If addPerCol > 0 Then
                    For i As Integer = 0 To printColWidths.Count - 1
                        printColWidths(i) += addPerCol
                    Next
                End If
            End If
        End If
    End Sub


    ' Gambar header tabel (baris header kolom)
    Private Function PrintTableHeader(g As Graphics, left As Integer, top As Integer) As Integer
        Dim curX As Integer = left
        Dim colIdx As Integer = 0

        Dim maxHeaderHeight As Single = 0
        Dim sfMeasure As New StringFormat()
        sfMeasure.Alignment = StringAlignment.Center
        sfMeasure.LineAlignment = StringAlignment.Center
        sfMeasure.Trimming = StringTrimming.EllipsisWord
        sfMeasure.FormatFlags = StringFormatFlags.LineLimit

        For Each col As DataGridViewColumn In printDGV.Columns
            If Not col.Visible Then Continue For
            Dim hdr As String = If(String.IsNullOrEmpty(col.HeaderText), col.Name, col.HeaderText)
            Dim colWidth As Integer = printColWidths(colIdx)
            Dim measured As SizeF = g.MeasureString(hdr, printingFont, colWidth - 8, sfMeasure)
            If measured.Height > maxHeaderHeight Then maxHeaderHeight = measured.Height
            colIdx += 1
        Next

        Dim headerHeight As Integer = CInt(Math.Ceiling(maxHeaderHeight)) + 6
        If headerHeight < CInt(printingFont.GetHeight(g) + 8) Then
            headerHeight = CInt(printingFont.GetHeight(g) + 8)
        End If

        curX = left
        colIdx = 0
        Dim sfDraw As New StringFormat()
        sfDraw.Alignment = StringAlignment.Center
        sfDraw.LineAlignment = StringAlignment.Center
        sfDraw.Trimming = StringTrimming.EllipsisWord
        sfDraw.FormatFlags = StringFormatFlags.LineLimit

        For Each col As DataGridViewColumn In printDGV.Columns
            If Not col.Visible Then Continue For
            Dim hdr As String = If(String.IsNullOrEmpty(col.HeaderText), col.Name, col.HeaderText)
            Dim rect As New Rectangle(curX, top, printColWidths(colIdx), headerHeight)
            g.FillRectangle(Brushes.LightGray, rect)
            g.DrawRectangle(Pens.Black, rect)

            Dim padded As Rectangle = rect
            padded.Inflate(-4, -2)

            g.DrawString(hdr, printingFont, Brushes.Black, padded, sfDraw)
            curX += printColWidths(colIdx)
            colIdx += 1
        Next

        Return headerHeight
    End Function
End Class
