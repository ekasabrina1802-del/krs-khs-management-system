<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahJadwal_Adm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbFakultas = New System.Windows.Forms.ComboBox()
        Me.cmbProgramStudi = New System.Windows.Forms.ComboBox()
        Me.cmbMataKuliah = New System.Windows.Forms.ComboBox()
        Me.cmbDosen = New System.Windows.Forms.ComboBox()
        Me.cmbRuang = New System.Windows.Forms.ComboBox()
        Me.cmbHari = New System.Windows.Forms.ComboBox()
        Me.cmbJamMulai = New System.Windows.Forms.ComboBox()
        Me.cmbJamSelesai = New System.Windows.Forms.ComboBox()
        Me.btnSimpanData = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Humanst521 BT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(639, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(657, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tambah Jadwal Perkuliahan Mahasiswa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(469, 235)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fakultas:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(469, 285)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 29)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Program Studi:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(469, 333)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 29)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Mata Kuliah:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(469, 382)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 29)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Dosen:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(469, 432)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 29)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Ruang:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(469, 481)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 29)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Hari:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(469, 528)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 29)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Jam Mulai:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(469, 581)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(142, 29)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Jam Selesai:"
        '
        'cmbFakultas
        '
        Me.cmbFakultas.FormattingEnabled = True
        Me.cmbFakultas.Items.AddRange(New Object() {"Teknik"})
        Me.cmbFakultas.Location = New System.Drawing.Point(678, 236)
        Me.cmbFakultas.Name = "cmbFakultas"
        Me.cmbFakultas.Size = New System.Drawing.Size(722, 28)
        Me.cmbFakultas.TabIndex = 10
        '
        'cmbProgramStudi
        '
        Me.cmbProgramStudi.FormattingEnabled = True
        Me.cmbProgramStudi.Items.AddRange(New Object() {"Pendidikan Teknologi Informasi", "Teknik Informatika"})
        Me.cmbProgramStudi.Location = New System.Drawing.Point(678, 286)
        Me.cmbProgramStudi.Name = "cmbProgramStudi"
        Me.cmbProgramStudi.Size = New System.Drawing.Size(722, 28)
        Me.cmbProgramStudi.TabIndex = 11
        '
        'cmbMataKuliah
        '
        Me.cmbMataKuliah.FormattingEnabled = True
        Me.cmbMataKuliah.Items.AddRange(New Object() {"Basis Data", "Struktur Data", "Grafika Komputer", "Pemrograman Visual", "Pemrograman Mobile"})
        Me.cmbMataKuliah.Location = New System.Drawing.Point(678, 334)
        Me.cmbMataKuliah.Name = "cmbMataKuliah"
        Me.cmbMataKuliah.Size = New System.Drawing.Size(722, 28)
        Me.cmbMataKuliah.TabIndex = 12
        '
        'cmbDosen
        '
        Me.cmbDosen.FormattingEnabled = True
        Me.cmbDosen.Items.AddRange(New Object() {"Rizky Basatha, S.Pd., M.MT.", "Riza Akhsani Setyo Prayoga, S.Kom., M.MT.", "Muhammad Sonhaji Akbar, S.Pd., M.Kom.", "I Gusti Lanang Putra Eka Prismana, S.Kom., M.Kom."})
        Me.cmbDosen.Location = New System.Drawing.Point(678, 383)
        Me.cmbDosen.Name = "cmbDosen"
        Me.cmbDosen.Size = New System.Drawing.Size(722, 28)
        Me.cmbDosen.TabIndex = 13
        '
        'cmbRuang
        '
        Me.cmbRuang.FormattingEnabled = True
        Me.cmbRuang.Items.AddRange(New Object() {"A10.01.04", "A10.01.18", "A10.03.10 LAB MULTIMEDIA", "A10.01.15"})
        Me.cmbRuang.Location = New System.Drawing.Point(678, 433)
        Me.cmbRuang.Name = "cmbRuang"
        Me.cmbRuang.Size = New System.Drawing.Size(722, 28)
        Me.cmbRuang.TabIndex = 14
        '
        'cmbHari
        '
        Me.cmbHari.FormattingEnabled = True
        Me.cmbHari.Items.AddRange(New Object() {"Senin", "Selasa", "Rabu", "Kamis", "Jumat"})
        Me.cmbHari.Location = New System.Drawing.Point(678, 482)
        Me.cmbHari.Name = "cmbHari"
        Me.cmbHari.Size = New System.Drawing.Size(722, 28)
        Me.cmbHari.TabIndex = 15
        '
        'cmbJamMulai
        '
        Me.cmbJamMulai.FormattingEnabled = True
        Me.cmbJamMulai.Items.AddRange(New Object() {"07.00", "08.40", "10.20", "15.00"})
        Me.cmbJamMulai.Location = New System.Drawing.Point(678, 529)
        Me.cmbJamMulai.Name = "cmbJamMulai"
        Me.cmbJamMulai.Size = New System.Drawing.Size(722, 28)
        Me.cmbJamMulai.TabIndex = 16
        '
        'cmbJamSelesai
        '
        Me.cmbJamSelesai.FormattingEnabled = True
        Me.cmbJamSelesai.Items.AddRange(New Object() {"08.40", "10.20", "12.00", "16.40"})
        Me.cmbJamSelesai.Location = New System.Drawing.Point(678, 581)
        Me.cmbJamSelesai.Name = "cmbJamSelesai"
        Me.cmbJamSelesai.Size = New System.Drawing.Size(722, 28)
        Me.cmbJamSelesai.TabIndex = 17
        '
        'btnSimpanData
        '
        Me.btnSimpanData.BackColor = System.Drawing.Color.DarkMagenta
        Me.btnSimpanData.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpanData.ForeColor = System.Drawing.Color.White
        Me.btnSimpanData.Location = New System.Drawing.Point(892, 668)
        Me.btnSimpanData.Name = "btnSimpanData"
        Me.btnSimpanData.Size = New System.Drawing.Size(179, 50)
        Me.btnSimpanData.TabIndex = 18
        Me.btnSimpanData.Text = "Simpan Data"
        Me.btnSimpanData.UseVisualStyleBackColor = False
        '
        'TambahJadwal_Adm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkViolet
        Me.ClientSize = New System.Drawing.Size(1898, 1024)
        Me.Controls.Add(Me.btnSimpanData)
        Me.Controls.Add(Me.cmbJamSelesai)
        Me.Controls.Add(Me.cmbJamMulai)
        Me.Controls.Add(Me.cmbHari)
        Me.Controls.Add(Me.cmbRuang)
        Me.Controls.Add(Me.cmbDosen)
        Me.Controls.Add(Me.cmbMataKuliah)
        Me.Controls.Add(Me.cmbProgramStudi)
        Me.Controls.Add(Me.cmbFakultas)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TambahJadwal_Adm"
        Me.Text = "TambahJadwal_Adm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbFakultas As ComboBox
    Friend WithEvents cmbProgramStudi As ComboBox
    Friend WithEvents cmbMataKuliah As ComboBox
    Friend WithEvents cmbDosen As ComboBox
    Friend WithEvents cmbRuang As ComboBox
    Friend WithEvents cmbHari As ComboBox
    Friend WithEvents cmbJamMulai As ComboBox
    Friend WithEvents cmbJamSelesai As ComboBox
    Friend WithEvents btnSimpanData As Button
End Class
