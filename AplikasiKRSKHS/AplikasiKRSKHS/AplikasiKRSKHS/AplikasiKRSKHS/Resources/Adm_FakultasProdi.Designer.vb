<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Adm_FakultasProdi
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnDasboard = New System.Windows.Forms.Button()
        Me.btnJadwalPerkuliahan = New System.Windows.Forms.Button()
        Me.btnSemester = New System.Windows.Forms.Button()
        Me.btnRuangan = New System.Windows.Forms.Button()
        Me.btnFakultasProdi = New System.Windows.Forms.Button()
        Me.btnDosen = New System.Windows.Forms.Button()
        Me.btnMahasiswa = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.dgvJadwalPerkuliahan = New System.Windows.Forms.DataGridView()
        Me.Kode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AktifitasLMSSINTESA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fakultas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProgramStudi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JadwalKuliah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Course = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProfilKurikulum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvJadwalPerkuliahan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Humanst521 BT", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(378, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(528, 34)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Hai, Admin! Selamat datang di menu Fakultas." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.DarkViolet
        Me.btnLogout.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(1712, 15)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(131, 47)
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnDasboard
        '
        Me.btnDasboard.BackColor = System.Drawing.Color.DarkViolet
        Me.btnDasboard.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDasboard.ForeColor = System.Drawing.Color.White
        Me.btnDasboard.Location = New System.Drawing.Point(32, 193)
        Me.btnDasboard.Name = "btnDasboard"
        Me.btnDasboard.Size = New System.Drawing.Size(286, 55)
        Me.btnDasboard.TabIndex = 27
        Me.btnDasboard.Text = "Dasboard"
        Me.btnDasboard.UseVisualStyleBackColor = False
        '
        'btnJadwalPerkuliahan
        '
        Me.btnJadwalPerkuliahan.BackColor = System.Drawing.Color.DarkViolet
        Me.btnJadwalPerkuliahan.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJadwalPerkuliahan.ForeColor = System.Drawing.Color.White
        Me.btnJadwalPerkuliahan.Location = New System.Drawing.Point(32, 749)
        Me.btnJadwalPerkuliahan.Name = "btnJadwalPerkuliahan"
        Me.btnJadwalPerkuliahan.Size = New System.Drawing.Size(286, 55)
        Me.btnJadwalPerkuliahan.TabIndex = 26
        Me.btnJadwalPerkuliahan.Text = "Jadwal Perkuliahan"
        Me.btnJadwalPerkuliahan.UseVisualStyleBackColor = False
        '
        'btnSemester
        '
        Me.btnSemester.BackColor = System.Drawing.Color.DarkViolet
        Me.btnSemester.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSemester.ForeColor = System.Drawing.Color.White
        Me.btnSemester.Location = New System.Drawing.Point(32, 656)
        Me.btnSemester.Name = "btnSemester"
        Me.btnSemester.Size = New System.Drawing.Size(286, 55)
        Me.btnSemester.TabIndex = 25
        Me.btnSemester.Text = "Semester"
        Me.btnSemester.UseVisualStyleBackColor = False
        '
        'btnRuangan
        '
        Me.btnRuangan.BackColor = System.Drawing.Color.DarkViolet
        Me.btnRuangan.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRuangan.ForeColor = System.Drawing.Color.White
        Me.btnRuangan.Location = New System.Drawing.Point(32, 561)
        Me.btnRuangan.Name = "btnRuangan"
        Me.btnRuangan.Size = New System.Drawing.Size(286, 55)
        Me.btnRuangan.TabIndex = 24
        Me.btnRuangan.Text = "Ruangan"
        Me.btnRuangan.UseVisualStyleBackColor = False
        '
        'btnFakultasProdi
        '
        Me.btnFakultasProdi.BackColor = System.Drawing.Color.DarkViolet
        Me.btnFakultasProdi.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFakultasProdi.ForeColor = System.Drawing.Color.White
        Me.btnFakultasProdi.Location = New System.Drawing.Point(32, 468)
        Me.btnFakultasProdi.Name = "btnFakultasProdi"
        Me.btnFakultasProdi.Size = New System.Drawing.Size(286, 55)
        Me.btnFakultasProdi.TabIndex = 22
        Me.btnFakultasProdi.Text = "Fakultas dan Prodi"
        Me.btnFakultasProdi.UseVisualStyleBackColor = False
        '
        'btnDosen
        '
        Me.btnDosen.BackColor = System.Drawing.Color.DarkViolet
        Me.btnDosen.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDosen.ForeColor = System.Drawing.Color.White
        Me.btnDosen.Location = New System.Drawing.Point(32, 376)
        Me.btnDosen.Name = "btnDosen"
        Me.btnDosen.Size = New System.Drawing.Size(286, 55)
        Me.btnDosen.TabIndex = 21
        Me.btnDosen.Text = "Dosen"
        Me.btnDosen.UseVisualStyleBackColor = False
        '
        'btnMahasiswa
        '
        Me.btnMahasiswa.BackColor = System.Drawing.Color.DarkViolet
        Me.btnMahasiswa.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMahasiswa.ForeColor = System.Drawing.Color.White
        Me.btnMahasiswa.Location = New System.Drawing.Point(32, 285)
        Me.btnMahasiswa.Name = "btnMahasiswa"
        Me.btnMahasiswa.Size = New System.Drawing.Size(286, 55)
        Me.btnMahasiswa.TabIndex = 20
        Me.btnMahasiswa.Text = "Mahasiswa"
        Me.btnMahasiswa.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(25, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 74)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "FAKULTAS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PRODI"
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
        Me.Panel1.TabIndex = 13
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkViolet
        Me.Panel3.Controls.Add(Me.btnLogout)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1920, 80)
        Me.Panel3.TabIndex = 14
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.Transparent
        Me.btnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.ForeColor = System.Drawing.Color.Black
        Me.btnTambah.Location = New System.Drawing.Point(1215, 279)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(281, 41)
        Me.btnTambah.TabIndex = 48
        Me.btnTambah.Text = "Search Your Course.."
        Me.btnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkGray
        Me.Label7.Location = New System.Drawing.Point(379, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(1476, 78)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "_________________________________________________________________________________" &
    "_________________________________________" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.DarkOrchid
        Me.lblTitle.Location = New System.Drawing.Point(376, 168)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(440, 43)
        Me.lblTitle.TabIndex = 46
        Me.lblTitle.Text = "Profil Fakultas dan Prodi"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvJadwalPerkuliahan
        '
        Me.dgvJadwalPerkuliahan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvJadwalPerkuliahan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Kode, Me.AktifitasLMSSINTESA, Me.Fakultas, Me.ProgramStudi, Me.JadwalKuliah, Me.Course, Me.ProfilKurikulum})
        Me.dgvJadwalPerkuliahan.Location = New System.Drawing.Point(383, 340)
        Me.dgvJadwalPerkuliahan.Name = "dgvJadwalPerkuliahan"
        Me.dgvJadwalPerkuliahan.RowHeadersWidth = 62
        Me.dgvJadwalPerkuliahan.RowTemplate.Height = 28
        Me.dgvJadwalPerkuliahan.Size = New System.Drawing.Size(1113, 634)
        Me.dgvJadwalPerkuliahan.TabIndex = 45
        '
        'Kode
        '
        Me.Kode.HeaderText = "Kode"
        Me.Kode.MinimumWidth = 8
        Me.Kode.Name = "Kode"
        Me.Kode.ReadOnly = True
        Me.Kode.Width = 150
        '
        'AktifitasLMSSINTESA
        '
        Me.AktifitasLMSSINTESA.HeaderText = "Aktifitas LMS SINTESA"
        Me.AktifitasLMSSINTESA.MinimumWidth = 8
        Me.AktifitasLMSSINTESA.Name = "AktifitasLMSSINTESA"
        Me.AktifitasLMSSINTESA.ReadOnly = True
        Me.AktifitasLMSSINTESA.Width = 150
        '
        'Fakultas
        '
        Me.Fakultas.HeaderText = "Fakultas"
        Me.Fakultas.MinimumWidth = 8
        Me.Fakultas.Name = "Fakultas"
        Me.Fakultas.ReadOnly = True
        Me.Fakultas.Width = 150
        '
        'ProgramStudi
        '
        Me.ProgramStudi.HeaderText = "Program Studi"
        Me.ProgramStudi.MinimumWidth = 8
        Me.ProgramStudi.Name = "ProgramStudi"
        Me.ProgramStudi.ReadOnly = True
        Me.ProgramStudi.Width = 150
        '
        'JadwalKuliah
        '
        Me.JadwalKuliah.HeaderText = "Jadwal Kuliah"
        Me.JadwalKuliah.MinimumWidth = 8
        Me.JadwalKuliah.Name = "JadwalKuliah"
        Me.JadwalKuliah.ReadOnly = True
        Me.JadwalKuliah.Width = 150
        '
        'Course
        '
        Me.Course.HeaderText = "Course"
        Me.Course.MinimumWidth = 8
        Me.Course.Name = "Course"
        Me.Course.ReadOnly = True
        Me.Course.Width = 150
        '
        'ProfilKurikulum
        '
        Me.ProfilKurikulum.HeaderText = "Profil Prodi & Kurikulum"
        Me.ProfilKurikulum.MinimumWidth = 8
        Me.ProfilKurikulum.Name = "ProfilKurikulum"
        Me.ProfilKurikulum.ReadOnly = True
        Me.ProfilKurikulum.Width = 150
        '
        'Adm_FakultasProdi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1898, 1024)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.dgvJadwalPerkuliahan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "Adm_FakultasProdi"
        Me.Text = "Adm_FakultasProdi"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvJadwalPerkuliahan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnDasboard As Button
    Friend WithEvents btnJadwalPerkuliahan As Button
    Friend WithEvents btnSemester As Button
    Friend WithEvents btnRuangan As Button
    Friend WithEvents btnFakultasProdi As Button
    Friend WithEvents btnDosen As Button
    Friend WithEvents btnMahasiswa As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnTambah As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents dgvJadwalPerkuliahan As DataGridView
    Friend WithEvents Kode As DataGridViewTextBoxColumn
    Friend WithEvents AktifitasLMSSINTESA As DataGridViewTextBoxColumn
    Friend WithEvents Fakultas As DataGridViewTextBoxColumn
    Friend WithEvents ProgramStudi As DataGridViewTextBoxColumn
    Friend WithEvents JadwalKuliah As DataGridViewTextBoxColumn
    Friend WithEvents Course As DataGridViewTextBoxColumn
    Friend WithEvents ProfilKurikulum As DataGridViewTextBoxColumn
End Class
