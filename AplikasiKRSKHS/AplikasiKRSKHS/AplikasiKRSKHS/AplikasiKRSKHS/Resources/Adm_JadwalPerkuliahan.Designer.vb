<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Adm_JadwalPerkuliahan
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDasboard = New System.Windows.Forms.Button()
        Me.btnJadwalPerkuliahan = New System.Windows.Forms.Button()
        Me.btnSemester = New System.Windows.Forms.Button()
        Me.btnRuangan = New System.Windows.Forms.Button()
        Me.btnFakultasProdi = New System.Windows.Forms.Button()
        Me.btnDosen = New System.Windows.Forms.Button()
        Me.btnMahasiswa = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbSemester = New System.Windows.Forms.ComboBox()
        Me.btnPilih = New System.Windows.Forms.Button()
        Me.dgvJadwalPerkuliahan = New System.Windows.Forms.DataGridView()
        Me.Fakultas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProgramStudi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MataKuliah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dosen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ruang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hari = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JamMulai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JamSelesai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Action = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvJadwalPerkuliahan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Indigo
        Me.Panel1.Controls.Add(Me.btnDasboard)
        Me.Panel1.Controls.Add(Me.btnJadwalPerkuliahan)
        Me.Panel1.Controls.Add(Me.btnSemester)
        Me.Panel1.Controls.Add(Me.btnRuangan)
        Me.Panel1.Controls.Add(Me.btnFakultasProdi)
        Me.Panel1.Controls.Add(Me.btnDosen)
        Me.Panel1.Controls.Add(Me.btnMahasiswa)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 1080)
        Me.Panel1.TabIndex = 9
        '
        'btnDasboard
        '
        Me.btnDasboard.BackColor = System.Drawing.Color.DarkViolet
        Me.btnDasboard.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDasboard.ForeColor = System.Drawing.Color.White
        Me.btnDasboard.Location = New System.Drawing.Point(32, 192)
        Me.btnDasboard.Name = "btnDasboard"
        Me.btnDasboard.Size = New System.Drawing.Size(286, 55)
        Me.btnDasboard.TabIndex = 34
        Me.btnDasboard.Text = "Dasboard"
        Me.btnDasboard.UseVisualStyleBackColor = False
        '
        'btnJadwalPerkuliahan
        '
        Me.btnJadwalPerkuliahan.BackColor = System.Drawing.Color.DarkViolet
        Me.btnJadwalPerkuliahan.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJadwalPerkuliahan.ForeColor = System.Drawing.Color.White
        Me.btnJadwalPerkuliahan.Location = New System.Drawing.Point(32, 748)
        Me.btnJadwalPerkuliahan.Name = "btnJadwalPerkuliahan"
        Me.btnJadwalPerkuliahan.Size = New System.Drawing.Size(286, 55)
        Me.btnJadwalPerkuliahan.TabIndex = 33
        Me.btnJadwalPerkuliahan.Text = "Jadwal Perkuliahan"
        Me.btnJadwalPerkuliahan.UseVisualStyleBackColor = False
        '
        'btnSemester
        '
        Me.btnSemester.BackColor = System.Drawing.Color.DarkViolet
        Me.btnSemester.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSemester.ForeColor = System.Drawing.Color.White
        Me.btnSemester.Location = New System.Drawing.Point(32, 655)
        Me.btnSemester.Name = "btnSemester"
        Me.btnSemester.Size = New System.Drawing.Size(286, 55)
        Me.btnSemester.TabIndex = 32
        Me.btnSemester.Text = "Semester"
        Me.btnSemester.UseVisualStyleBackColor = False
        '
        'btnRuangan
        '
        Me.btnRuangan.BackColor = System.Drawing.Color.DarkViolet
        Me.btnRuangan.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRuangan.ForeColor = System.Drawing.Color.White
        Me.btnRuangan.Location = New System.Drawing.Point(32, 560)
        Me.btnRuangan.Name = "btnRuangan"
        Me.btnRuangan.Size = New System.Drawing.Size(286, 55)
        Me.btnRuangan.TabIndex = 31
        Me.btnRuangan.Text = "Ruangan"
        Me.btnRuangan.UseVisualStyleBackColor = False
        '
        'btnFakultasProdi
        '
        Me.btnFakultasProdi.BackColor = System.Drawing.Color.DarkViolet
        Me.btnFakultasProdi.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFakultasProdi.ForeColor = System.Drawing.Color.White
        Me.btnFakultasProdi.Location = New System.Drawing.Point(32, 467)
        Me.btnFakultasProdi.Name = "btnFakultasProdi"
        Me.btnFakultasProdi.Size = New System.Drawing.Size(286, 55)
        Me.btnFakultasProdi.TabIndex = 30
        Me.btnFakultasProdi.Text = "Fakultas dan Prodi"
        Me.btnFakultasProdi.UseVisualStyleBackColor = False
        '
        'btnDosen
        '
        Me.btnDosen.BackColor = System.Drawing.Color.DarkViolet
        Me.btnDosen.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDosen.ForeColor = System.Drawing.Color.White
        Me.btnDosen.Location = New System.Drawing.Point(32, 375)
        Me.btnDosen.Name = "btnDosen"
        Me.btnDosen.Size = New System.Drawing.Size(286, 55)
        Me.btnDosen.TabIndex = 29
        Me.btnDosen.Text = "Dosen"
        Me.btnDosen.UseVisualStyleBackColor = False
        '
        'btnMahasiswa
        '
        Me.btnMahasiswa.BackColor = System.Drawing.Color.DarkViolet
        Me.btnMahasiswa.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMahasiswa.ForeColor = System.Drawing.Color.White
        Me.btnMahasiswa.Location = New System.Drawing.Point(32, 284)
        Me.btnMahasiswa.Name = "btnMahasiswa"
        Me.btnMahasiswa.Size = New System.Drawing.Size(286, 55)
        Me.btnMahasiswa.TabIndex = 28
        Me.btnMahasiswa.Text = "Mahasiswa"
        Me.btnMahasiswa.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(23, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(315, 37)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Jadwal Perkuliahan"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkViolet
        Me.Panel3.Controls.Add(Me.btnLogout)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1920, 80)
        Me.Panel3.TabIndex = 10
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.DarkViolet
        Me.btnLogout.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(1712, 16)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(131, 47)
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Humanst521 BT", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(378, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(776, 34)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Hai, Admin! Selamat datang di menu Jadwal Perkuliahan Mahasiswa." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cmbSemester
        '
        Me.cmbSemester.FormattingEnabled = True
        Me.cmbSemester.Items.AddRange(New Object() {"2024 Ganjil", "2024 Genap"})
        Me.cmbSemester.Location = New System.Drawing.Point(384, 194)
        Me.cmbSemester.Name = "cmbSemester"
        Me.cmbSemester.Size = New System.Drawing.Size(516, 28)
        Me.cmbSemester.TabIndex = 20
        '
        'btnPilih
        '
        Me.btnPilih.BackColor = System.Drawing.Color.DarkMagenta
        Me.btnPilih.Font = New System.Drawing.Font("Humanst521 BT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPilih.ForeColor = System.Drawing.Color.White
        Me.btnPilih.Location = New System.Drawing.Point(929, 187)
        Me.btnPilih.Name = "btnPilih"
        Me.btnPilih.Size = New System.Drawing.Size(108, 41)
        Me.btnPilih.TabIndex = 21
        Me.btnPilih.Text = "Pilih"
        Me.btnPilih.UseVisualStyleBackColor = False
        '
        'dgvJadwalPerkuliahan
        '
        Me.dgvJadwalPerkuliahan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvJadwalPerkuliahan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Fakultas, Me.ProgramStudi, Me.MataKuliah, Me.Dosen, Me.Ruang, Me.Hari, Me.JamMulai, Me.JamSelesai, Me.Action})
        Me.dgvJadwalPerkuliahan.Location = New System.Drawing.Point(384, 361)
        Me.dgvJadwalPerkuliahan.Name = "dgvJadwalPerkuliahan"
        Me.dgvJadwalPerkuliahan.RowHeadersWidth = 62
        Me.dgvJadwalPerkuliahan.RowTemplate.Height = 28
        Me.dgvJadwalPerkuliahan.Size = New System.Drawing.Size(1409, 610)
        Me.dgvJadwalPerkuliahan.TabIndex = 22
        '
        'Fakultas
        '
        Me.Fakultas.HeaderText = "Fakultas"
        Me.Fakultas.MinimumWidth = 8
        Me.Fakultas.Name = "Fakultas"
        Me.Fakultas.Width = 150
        '
        'ProgramStudi
        '
        Me.ProgramStudi.HeaderText = "Program Studi"
        Me.ProgramStudi.MinimumWidth = 8
        Me.ProgramStudi.Name = "ProgramStudi"
        Me.ProgramStudi.Width = 150
        '
        'MataKuliah
        '
        Me.MataKuliah.HeaderText = "Mata Kuliah"
        Me.MataKuliah.MinimumWidth = 8
        Me.MataKuliah.Name = "MataKuliah"
        Me.MataKuliah.Width = 150
        '
        'Dosen
        '
        Me.Dosen.HeaderText = "Dosen"
        Me.Dosen.MinimumWidth = 8
        Me.Dosen.Name = "Dosen"
        Me.Dosen.Width = 150
        '
        'Ruang
        '
        Me.Ruang.HeaderText = "Ruang"
        Me.Ruang.MinimumWidth = 8
        Me.Ruang.Name = "Ruang"
        Me.Ruang.Width = 150
        '
        'Hari
        '
        Me.Hari.HeaderText = "Hari"
        Me.Hari.MinimumWidth = 8
        Me.Hari.Name = "Hari"
        Me.Hari.Width = 150
        '
        'JamMulai
        '
        Me.JamMulai.HeaderText = "Jam Mulai"
        Me.JamMulai.MinimumWidth = 8
        Me.JamMulai.Name = "JamMulai"
        Me.JamMulai.Width = 150
        '
        'JamSelesai
        '
        Me.JamSelesai.HeaderText = "Jam Selesai"
        Me.JamSelesai.MinimumWidth = 8
        Me.JamSelesai.Name = "JamSelesai"
        Me.JamSelesai.Width = 150
        '
        'Action
        '
        Me.Action.HeaderText = "Action"
        Me.Action.MinimumWidth = 8
        Me.Action.Name = "Action"
        Me.Action.Width = 150
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.Lime
        Me.btnTambah.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.ForeColor = System.Drawing.Color.Black
        Me.btnTambah.Location = New System.Drawing.Point(384, 284)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(315, 55)
        Me.btnTambah.TabIndex = 23
        Me.btnTambah.Text = "Tambah Jadwal Perkuliahan"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Yellow
        Me.btnEdit.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(755, 284)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(214, 55)
        Me.btnEdit.TabIndex = 24
        Me.btnEdit.Text = "Edit Jadwal"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.Red
        Me.btnHapus.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Location = New System.Drawing.Point(1031, 284)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(214, 55)
        Me.btnHapus.TabIndex = 25
        Me.btnHapus.Text = "Hapus Jadwal"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'Adm_JadwalPerkuliahan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1898, 1024)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.dgvJadwalPerkuliahan)
        Me.Controls.Add(Me.btnPilih)
        Me.Controls.Add(Me.cmbSemester)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Adm_JadwalPerkuliahan"
        Me.Text = "Adm_JadwalPerkuliahan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvJadwalPerkuliahan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbSemester As ComboBox
    Friend WithEvents btnPilih As Button
    Friend WithEvents btnDasboard As Button
    Friend WithEvents btnJadwalPerkuliahan As Button
    Friend WithEvents btnSemester As Button
    Friend WithEvents btnRuangan As Button
    Friend WithEvents btnFakultasProdi As Button
    Friend WithEvents btnDosen As Button
    Friend WithEvents btnMahasiswa As Button
    Friend WithEvents dgvJadwalPerkuliahan As DataGridView
    Friend WithEvents Fakultas As DataGridViewTextBoxColumn
    Friend WithEvents ProgramStudi As DataGridViewTextBoxColumn
    Friend WithEvents MataKuliah As DataGridViewTextBoxColumn
    Friend WithEvents Dosen As DataGridViewTextBoxColumn
    Friend WithEvents Ruang As DataGridViewTextBoxColumn
    Friend WithEvents Hari As DataGridViewTextBoxColumn
    Friend WithEvents JamMulai As DataGridViewTextBoxColumn
    Friend WithEvents JamSelesai As DataGridViewTextBoxColumn
    Friend WithEvents Action As DataGridViewTextBoxColumn
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHapus As Button
End Class
