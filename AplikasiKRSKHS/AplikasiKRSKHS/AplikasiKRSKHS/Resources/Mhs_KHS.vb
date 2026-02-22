Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Collections.Generic
Imports System.Linq

Public Class Mhs_KHS
    ' Properti yang diterima dari Login
    Public Property NamaMahasiswa As String
    Public Property NIM_Mahasiswa As String

    ' untuk paging print
    Private currentPrintRowIndex As Integer = 0

    ' helper untuk kolom cetak (mirip KRS)
    Private printColWidths_KHS As List(Of Integer) = Nothing
    Private printTotalWidth_KHS As Integer = 0

    ' page counter (di-reset di BeginPrint)
    Private printedPages As Integer = 0

    ' =========================================================
    '  MUAT / REFRESH DATA KHS
    ' =========================================================
    Public Sub RefreshKHS(Optional ByVal nim As String = "")
        Try
            If String.IsNullOrWhiteSpace(nim) Then
                If Not String.IsNullOrWhiteSpace(Me.NIM_Mahasiswa) Then
                    nim = Me.NIM_Mahasiswa
                End If
            End If

            If String.IsNullOrWhiteSpace(nim) Then
                Try
                    If Not String.IsNullOrWhiteSpace(ModuleKoneksi.GlobalMahasiswaNIM) Then
                        nim = ModuleKoneksi.GlobalMahasiswaNIM
                        Me.NIM_Mahasiswa = nim
                    End If
                Catch
                    nim = String.Empty
                End Try
            End If

            If String.IsNullOrWhiteSpace(nim) Then
                If dgvKHS.InvokeRequired Then
                    dgvKHS.Invoke(Sub()
                                      dgvKHS.DataSource = Nothing
                                      dgvKHS.Columns.Clear()
                                  End Sub)
                Else
                    dgvKHS.DataSource = Nothing
                    dgvKHS.Columns.Clear()
                End If
                Return
            End If

            ModuleKoneksi.OpenConnection()

            Dim sql As String =
                "SELECT NIM, MataKuliah AS [Mata Kuliah], NilaiHuruf AS [Nilai Huruf], " &
                "NilaiIndeks AS [Nilai Indeks], sks AS SKS " &
                "FROM dbo.Tbl_KHS " &
                "WHERE NIM = @nim " &
                "ORDER BY MataKuliah"

            Using cmd As New SqlCommand(sql, ModuleKoneksi.Conn)
                cmd.Parameters.AddWithValue("@nim", nim)

                Using da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)

                    If dgvKHS.InvokeRequired Then
                        dgvKHS.Invoke(Sub()
                                          dgvKHS.DataSource = Nothing
                                          dgvKHS.Columns.Clear()
                                          dgvKHS.AutoGenerateColumns = True
                                          dgvKHS.DataSource = dt
                                          dgvKHS.AutoResizeColumns()
                                      End Sub)
                    Else
                        dgvKHS.DataSource = Nothing
                        dgvKHS.Columns.Clear()
                        dgvKHS.AutoGenerateColumns = True
                        dgvKHS.DataSource = dt
                        dgvKHS.AutoResizeColumns()
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal memuat data KHS: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Try : ModuleKoneksi.CloseConnection() : Catch : End Try
        End Try
    End Sub

    ' =========================================================
    '  EVENT FORM
    ' =========================================================
    Private Sub Mhs_KHS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If String.IsNullOrWhiteSpace(Me.NIM_Mahasiswa) Then
            Try
                Me.NIM_Mahasiswa = ModuleKoneksi.GlobalMahasiswaNIM
            Catch
            End Try
        End If

        RefreshKHS()
    End Sub

    Private Sub Mhs_KHS_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        RefreshKHS()
    End Sub

    ' =========================================================
    '  PRINT KHS (dengan struktur sama seperti KRS)
    ' =========================================================
    Private WithEvents pdDocument As New Printing.PrintDocument()
    Private dlgPreview As New PrintPreviewDialog()

    Private Sub btnCetakKHS_Click(sender As Object, e As EventArgs) Handles btnCetakKHS.Click
        ' reset index sebelum cetak agar selalu mulai dari awal
        currentPrintRowIndex = 0
        ' reset helper kolom agar dihitung ulang
        printColWidths_KHS = Nothing
        dlgPreview.Document = pdDocument
        dlgPreview.WindowState = FormWindowState.Maximized
        Try
            dlgPreview.PrintPreviewControl.Zoom = 1.0
        Catch
        End Try
        dlgPreview.ShowDialog()
    End Sub

    Private Sub pdDocument_BeginPrint(sender As Object, e As PrintEventArgs) Handles pdDocument.BeginPrint
        currentPrintRowIndex = 0
        printColWidths_KHS = Nothing
        printTotalWidth_KHS = 0
        printedPages = 0 ' reset counter halaman
    End Sub

    Private Sub pdDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdDocument.PrintPage
        If dgvKHS Is Nothing OrElse dgvKHS.Rows.Count = 0 Then
            e.Graphics.DrawString("Tidak ada data untuk dicetak", New Font("Segoe UI", 10), Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top)
            e.HasMorePages = False
            Return
        End If

        Dim leftMargin As Integer = e.MarginBounds.Left
        Dim topMargin As Integer = e.MarginBounds.Top
        Dim pageWidth As Integer = e.MarginBounds.Width
        Dim pageHeight As Integer = e.MarginBounds.Height
        Dim bottom As Integer = e.MarginBounds.Bottom

        Dim x As Integer = leftMargin
        Dim y As Integer = topMargin

        Dim titleFont As New Font("Segoe UI", 14, FontStyle.Bold)
        Dim headerFont As New Font("Segoe UI", 10, FontStyle.Bold)
        Dim cellFont As New Font("Segoe UI", 10, FontStyle.Regular)
        Dim smallFont As New Font("Segoe UI", 9, FontStyle.Regular)

        Dim rowHeight As Integer = CInt(cellFont.GetHeight(e.Graphics) + 8)

        ' ================= HITUNG TOTAL SKS & IP =================
        Dim totalSks As Integer = 0
        Dim totalWeighted As Double = 0.0
        Try
            Dim idxNilaiIndeks As Integer = -1
            Dim idxSks As Integer = -1
            For i As Integer = 0 To dgvKHS.Columns.Count - 1
                Dim hdr As String = dgvKHS.Columns(i).HeaderText.Trim().ToLower()
                If hdr = "nilai indeks" OrElse hdr = "nilaiindeks" OrElse hdr = "bobot" Then idxNilaiIndeks = i
                If hdr = "sks" Then idxSks = i
            Next
            If idxNilaiIndeks = -1 AndAlso dgvKHS.Columns.Count >= 4 Then idxNilaiIndeks = 3
            If idxSks = -1 AndAlso dgvKHS.Columns.Count >= 5 Then idxSks = 4

            For Each r As DataGridViewRow In dgvKHS.Rows
                If r.IsNewRow Then Continue For
                Dim sval As String = If(idxSks >= 0 AndAlso idxSks < r.Cells.Count, If(r.Cells(idxSks).Value, "0").ToString(), "0")
                Dim nval As String = If(idxNilaiIndeks >= 0 AndAlso idxNilaiIndeks < r.Cells.Count, If(r.Cells(idxNilaiIndeks).Value, "0").ToString(), "0")
                Dim s As Integer = 0
                Dim idx As Double = 0
                Integer.TryParse(sval, s)
                Double.TryParse(nval, idx)
                totalSks += s
                totalWeighted += s * idx
            Next
        Catch
            totalSks = 0
            totalWeighted = 0
        End Try

        Dim ip As Double = 0.0
        If totalSks > 0 Then ip = totalWeighted / totalSks

        ' ================= CETAK LOGO DI ATAS (TENGAH) =================
        Try
            Dim logo As Image = My.Resources.cover_sintesa ' ganti nama resource jika berbeda
            If logo IsNot Nothing Then
                Dim logoMaxWidth As Integer = 400
                Dim logoMaxHeight As Integer = 400
                Dim ratio As Double = Math.Min(logoMaxWidth / logo.Width, logoMaxHeight / logo.Height)
                If ratio <= 0 Then ratio = 1
                Dim logoWidth As Integer = CInt(logo.Width * ratio)
                Dim logoHeight As Integer = CInt(logo.Height * ratio)
                Dim centerX As Integer = leftMargin + (pageWidth - logoWidth) \ 2

                e.Graphics.DrawImage(logo, centerX, y, logoWidth, logoHeight)
                y += logoHeight + 6

                ' garis horizontal di bawah logo - bisa dihapus nanti jika mau
                Dim lineY As Integer = y + 2
                e.Graphics.DrawLine(Pens.Black, leftMargin, lineY, leftMargin + pageWidth, lineY)
                y = lineY + 10
            End If
        Catch
            ' lanjut tanpa logo jika error
        End Try

        ' ================= CETAK JUDUL DI TENGAH =================
        Dim title As String = "Kartu Hasil Studi (KHS)"
        Dim titleSize As SizeF = e.Graphics.MeasureString(title, titleFont)
        Dim titleX As Integer = leftMargin + (pageWidth - CInt(titleSize.Width)) \ 2
        e.Graphics.DrawString(title, titleFont, Brushes.Black, titleX, y)
        y += CInt(titleSize.Height) + 8

        ' ================= CETAK HEADER: NIM -> NAMA -> IP (RAPIH) =================
        Dim nimText As String = If(String.IsNullOrWhiteSpace(Me.NIM_Mahasiswa), "", Me.NIM_Mahasiswa)
        Dim namaText As String = If(String.IsNullOrWhiteSpace(Me.NamaMahasiswa), "", Me.NamaMahasiswa)
        Dim ipText As String = String.Format("{0:0.00}", ip)

        Dim valueFont As New Font("Segoe UI", 10, FontStyle.Regular)
        Dim smallSpacing As Integer = 6

        e.Graphics.DrawString("NIM : " & nimText, valueFont, Brushes.Black, leftMargin, y)
        y += CInt(valueFont.GetHeight(e.Graphics)) + smallSpacing

        e.Graphics.DrawString("Nama : " & namaText, valueFont, Brushes.Black, leftMargin, y)
        y += CInt(valueFont.GetHeight(e.Graphics)) + smallSpacing

        e.Graphics.DrawString("Indeks Prestasi (IP) : " & ipText, valueFont, Brushes.Black, leftMargin, y)
        y += CInt(valueFont.GetHeight(e.Graphics))

        Dim extraSpacingBeforeTable As Integer = 22
        y += extraSpacingBeforeTable

        ' ---------------------------
        ' PREPARE VISIBLE ROWS LIST (exclude NewRow)
        ' ---------------------------
        Dim visibleRows As New List(Of DataGridViewRow)()
        For Each r As DataGridViewRow In dgvKHS.Rows
            If Not r.IsNewRow Then visibleRows.Add(r)
        Next
        Dim totalRowsAll As Integer = visibleRows.Count

        ' jika tidak ada baris visible, hentikan
        If totalRowsAll = 0 Then
            e.HasMorePages = False
            Return
        End If

        ' ================= CETAK TABEL HEADER & HITUNG LEBAR KOLOM =================
        If printColWidths_KHS Is Nothing Then
            CalculateColumnWidthsForPrinting_KHS(e.Graphics, pageWidth)
        End If

        Dim headerH As Integer = PrintTableHeader_KHS(e.Graphics, leftMargin, y, headerFont)
        y += headerH

        ' ---- guard untuk paging (hindari infinite loop halaman kosong) ----
        Dim availableHeightForRows As Integer = bottom - y - (rowHeight + 40)
        If availableHeightForRows < 0 Then availableHeightForRows = 0
        Dim maxRowsThisPage As Integer = Math.Max(1, availableHeightForRows \ rowHeight)

        ' hitung berapa baris yang bisa dicetak dari currentPrintRowIndex (pada visibleRows)
        Dim rowsToPrintThisPage As Integer = Math.Min(maxRowsThisPage, Math.Max(0, totalRowsAll - currentPrintRowIndex))

        ' safety: jika rowsToPrintThisPage = 0 tetapi masih ada baris tersisa, paksa 1
        If rowsToPrintThisPage = 0 AndAlso currentPrintRowIndex < totalRowsAll Then
            rowsToPrintThisPage = 1
        End If

        ' posisi dan ukuran tabel
        Dim tableLeft As Integer = leftMargin
        Dim tableTop As Integer = y - headerH
        Dim tableRight As Integer = leftMargin + printColWidths_KHS.Sum(Function(v) v)
        Dim tableBottom As Integer = tableTop + headerH + (rowsToPrintThisPage * rowHeight)

        e.Graphics.DrawRectangle(Pens.Black, New Rectangle(tableLeft, tableTop, Math.Max(1, tableRight - tableLeft), Math.Max(1, tableBottom - tableTop)))

        ' draw vertical separators
        Dim curXsep As Integer = tableLeft
        For iCol As Integer = 0 To printColWidths_KHS.Count - 1
            curXsep += printColWidths_KHS(iCol)
            e.Graphics.DrawLine(Pens.Black, curXsep, tableTop, curXsep, tableBottom)
        Next

        ' CETAK BARIS
        Dim rowsPrintedOnThisPage As Integer = 0
        Dim idxVisible As Integer = currentPrintRowIndex
        Dim yPos As Integer = y
        While idxVisible < totalRowsAll AndAlso rowsPrintedOnThisPage < rowsToPrintThisPage
            Dim row As DataGridViewRow = visibleRows(idxVisible)
            Dim curX As Integer = leftMargin
            Dim colIdx As Integer = 0
            For Each col As DataGridViewColumn In dgvKHS.Columns
                If Not col.Visible Then Continue For
                Dim cw As Integer = printColWidths_KHS(colIdx)
                Dim rect As New Rectangle(curX, yPos, cw, rowHeight)
                ' only draw inner cell border (outer borders already drawn)
                e.Graphics.DrawRectangle(Pens.Black, rect)

                Dim value As String = If(row.Cells(col.Index).Value Is Nothing, "", row.Cells(col.Index).Value.ToString())
                Dim padded As Rectangle = rect
                padded.Inflate(-6, -2)

                Dim sf As New StringFormat()
                sf.LineAlignment = StringAlignment.Center
                If String.Compare(col.HeaderText, "SKS", True) = 0 Then
                    sf.Alignment = StringAlignment.Far
                Else
                    sf.Alignment = StringAlignment.Near
                End If

                e.Graphics.DrawString(value, cellFont, Brushes.Black, padded, sf)

                curX += cw
                colIdx += 1
            Next

            yPos += rowHeight
            rowsPrintedOnThisPage += 1
            idxVisible += 1
        End While

        ' pastikan index naik (safety)
        If rowsPrintedOnThisPage > 0 Then
            currentPrintRowIndex += rowsPrintedOnThisPage
        Else
            ' jika tidak ada baris dicetak di halaman ini, hentikan agar tidak infinite loop
            e.HasMorePages = False
            Return
        End If

        ' jika masih ada baris tersisa -> more pages
        If currentPrintRowIndex < totalRowsAll Then
            printedPages += 1
            ' safety cap: hentikan jika terlalu banyak halaman (mencegah infinite loop)
            If printedPages > 500 Then
                e.HasMorePages = False
                currentPrintRowIndex = 0
                Return
            End If

            e.HasMorePages = True
            Return
        End If

        ' semua baris sudah dicetak -> gambar Total SKS
        If printColWidths_KHS IsNot Nothing AndAlso printColWidths_KHS.Count > 0 Then
            If yPos + rowHeight > bottom Then
                printedPages += 1
                e.HasMorePages = True
                currentPrintRowIndex = totalRowsAll
                Return
            End If

            Dim totalColsVisible As Integer = printColWidths_KHS.Count
            Dim labelWidth As Integer = 0
            For i As Integer = 0 To totalColsVisible - 2
                labelWidth += printColWidths_KHS(i)
            Next
            Dim valueWidth As Integer = printColWidths_KHS(totalColsVisible - 1)

            Dim rectLabel As New Rectangle(leftMargin, yPos, labelWidth, rowHeight)
            Dim rectValue As New Rectangle(leftMargin + labelWidth, yPos, valueWidth, rowHeight)

            e.Graphics.FillRectangle(Brushes.LightGray, rectLabel)
            e.Graphics.DrawRectangle(Pens.Black, rectLabel)
            e.Graphics.DrawRectangle(Pens.Black, rectValue)

            Dim sfLabel As New StringFormat()
            sfLabel.Alignment = StringAlignment.Center
            sfLabel.LineAlignment = StringAlignment.Center
            e.Graphics.DrawString("Total SKS", cellFont, Brushes.Black, rectLabel, sfLabel)

            Dim sfValue As New StringFormat()
            sfValue.Alignment = StringAlignment.Far
            sfValue.LineAlignment = StringAlignment.Center
            Dim paddedValueRect As Rectangle = rectValue
            paddedValueRect.Inflate(-6, 0)
            e.Graphics.DrawString(totalSks.ToString(), cellFont, Brushes.Black, paddedValueRect, sfValue)

            yPos += rowHeight
        End If

        ' footer page number
        printedPages += 1
        Dim footerText As String = "Halaman " & printedPages.ToString()
        Dim ftSize As SizeF = e.Graphics.MeasureString(footerText, smallFont)
        e.Graphics.DrawString(footerText, smallFont, Brushes.Black, leftMargin + pageWidth - CInt(ftSize.Width), topMargin + pageHeight + 10 - CInt(ftSize.Height))

        e.HasMorePages = False
        currentPrintRowIndex = 0
    End Sub


    ' =========================================================
    '  Helpers untuk menghitung lebar kolom dan cetak header tabel
    '  (salin / adaptasi dari struktur KRS)
    ' =========================================================
    Private Sub CalculateColumnWidthsForPrinting_KHS(g As Graphics, pageWidth As Integer)
        printColWidths_KHS = New List(Of Integer)()
        printTotalWidth_KHS = 0

        Dim visibleColumns As New List(Of DataGridViewColumn)()
        For Each col As DataGridViewColumn In dgvKHS.Columns
            If col.Visible Then visibleColumns.Add(col)
        Next

        For Each col As DataGridViewColumn In visibleColumns
            Dim maxW As Integer = 0
            Dim headerText As String = If(String.IsNullOrEmpty(col.HeaderText), col.Name, col.HeaderText)
            Dim headerSize As SizeF = g.MeasureString(headerText, New Font("Segoe UI", 9))
            maxW = CInt(headerSize.Width)

            Dim rowsToCheck As Integer = Math.Min(100, dgvKHS.Rows.Count)
            For r As Integer = 0 To rowsToCheck - 1
                Dim cellVal As Object = dgvKHS.Rows(r).Cells(col.Index).Value
                If cellVal IsNot Nothing Then
                    Dim s As String = cellVal.ToString()
                    Dim sz As SizeF = g.MeasureString(s, New Font("Segoe UI", 9), 300)
                    If CInt(sz.Width) > maxW Then maxW = CInt(sz.Width)
                End If
            Next

            Dim prefW As Integer = maxW + 24

            If String.Compare(col.HeaderText, "Mata Kuliah", True) = 0 OrElse String.Compare(col.HeaderText, "MataKuliah", True) = 0 Then
                If prefW < 200 Then prefW = 200
            ElseIf String.Compare(col.HeaderText, "SKS", True) = 0 Then
                If prefW < 50 Then prefW = 50
            Else
                If prefW < 80 Then prefW = 80
            End If

            printColWidths_KHS.Add(prefW)
            printTotalWidth_KHS += prefW
        Next

        If printTotalWidth_KHS > pageWidth Then
            Dim scale As Single = pageWidth / CSng(printTotalWidth_KHS)
            For i As Integer = 0 To printColWidths_KHS.Count - 1
                printColWidths_KHS(i) = CInt(printColWidths_KHS(i) * scale)
                If printColWidths_KHS(i) < 40 Then printColWidths_KHS(i) = 40
            Next
        Else
            Dim extra As Integer = pageWidth - printTotalWidth_KHS
            If extra > 0 AndAlso printColWidths_KHS.Count > 0 Then
                Dim addPerCol As Integer = extra \ printColWidths_KHS.Count
                If addPerCol > 0 Then
                    For i As Integer = 0 To printColWidths_KHS.Count - 1
                        printColWidths_KHS(i) += addPerCol
                    Next
                End If
            End If
        End If
    End Sub

    Private Function PrintTableHeader_KHS(g As Graphics, left As Integer, top As Integer, headerFont As Font) As Integer
        Dim curX As Integer = left
        Dim colIdx As Integer = 0

        Dim maxHeaderHeight As Single = 0
        Dim sfMeasure As New StringFormat()
        sfMeasure.Alignment = StringAlignment.Center
        sfMeasure.LineAlignment = StringAlignment.Center
        sfMeasure.Trimming = StringTrimming.EllipsisWord
        sfMeasure.FormatFlags = StringFormatFlags.LineLimit

        For Each col As DataGridViewColumn In dgvKHS.Columns
            If Not col.Visible Then Continue For
            Dim hdr As String = If(String.IsNullOrEmpty(col.HeaderText), col.Name, col.HeaderText)
            Dim colWidth As Integer = printColWidths_KHS(colIdx)
            Dim measured As SizeF = g.MeasureString(hdr, headerFont, colWidth - 8, sfMeasure)
            If measured.Height > maxHeaderHeight Then maxHeaderHeight = measured.Height
            colIdx += 1
        Next

        Dim headerHeight As Integer = CInt(Math.Ceiling(maxHeaderHeight)) + 6
        If headerHeight < CInt(headerFont.GetHeight(g) + 8) Then headerHeight = CInt(headerFont.GetHeight(g) + 8)

        curX = left
        colIdx = 0
        Dim sfDraw As New StringFormat()
        sfDraw.Alignment = StringAlignment.Center
        sfDraw.LineAlignment = StringAlignment.Center
        sfDraw.Trimming = StringTrimming.EllipsisWord
        sfDraw.FormatFlags = StringFormatFlags.LineLimit

        For Each col As DataGridViewColumn In dgvKHS.Columns
            If Not col.Visible Then Continue For
            Dim hdr As String = If(String.IsNullOrEmpty(col.HeaderText), col.Name, col.HeaderText)
            Dim rect As New Rectangle(curX, top, printColWidths_KHS(colIdx), headerHeight)
            g.FillRectangle(Brushes.LightGray, rect)
            g.DrawRectangle(Pens.Black, rect)
            Dim padded As Rectangle = rect
            padded.Inflate(-4, -2)
            g.DrawString(hdr, headerFont, Brushes.Black, padded, sfDraw)
            curX += printColWidths_KHS(colIdx)
            colIdx += 1
        Next

        Return headerHeight
    End Function

    ' =========================================================
    '  NAVIGASI BUTTON
    ' =========================================================
    Private Sub btnDasboard_Click(sender As Object, e As EventArgs) Handles btnDasboard.Click
        If ModuleKoneksi.GlobalDashboard IsNot Nothing Then
            ModuleKoneksi.GlobalDashboard.Show()
            Me.Hide()
        Else
            MessageBox.Show("Dashboard tidak ditemukan. Silakan login ulang.",
                            "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnKRS_Click_1(sender As Object, e As EventArgs) Handles btnKRS.Click
        Dim frm As New Mhs_KRS()
        frm.NIM_Mahasiswa = Me.NIM_Mahasiswa
        frm.NamaMahasiswa = Me.NamaMahasiswa
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click_1(sender As Object, e As EventArgs) Handles btnLogout.Click
        Try
            ModuleKoneksi.GlobalMahasiswaNIM = String.Empty
        Catch
        End Try
        Application.Exit()
    End Sub
End Class
