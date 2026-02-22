<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Adm_Semester
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
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.DGAdmMahasiswa = New System.Windows.Forms.DataGridView()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NIM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JenisKelamin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.No_Telepon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fakultas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProgramStudi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Action = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DGAdmMahasiswa, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 16
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
        Me.Label1.Location = New System.Drawing.Point(23, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 37)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "SEMESTER"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Humanst521 BT", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(378, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(544, 34)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Hai, Admin! Selamat datang di menu Semester." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkViolet
        Me.Panel3.Controls.Add(Me.btnLogout)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1920, 80)
        Me.Panel3.TabIndex = 17
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Lime
        Me.btnEdit.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.Black
        Me.btnEdit.Location = New System.Drawing.Point(384, 193)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(218, 55)
        Me.btnEdit.TabIndex = 26
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'DGAdmMahasiswa
        '
        Me.DGAdmMahasiswa.BackgroundColor = System.Drawing.Color.White
        Me.DGAdmMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGAdmMahasiswa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.NIM, Me.Kode, Me.Nama, Me.JenisKelamin, Me.No_Telepon, Me.Fakultas, Me.ProgramStudi, Me.Action})
        Me.DGAdmMahasiswa.Location = New System.Drawing.Point(384, 285)
        Me.DGAdmMahasiswa.Name = "DGAdmMahasiswa"
        Me.DGAdmMahasiswa.RowHeadersWidth = 62
        Me.DGAdmMahasiswa.RowTemplate.Height = 28
        Me.DGAdmMahasiswa.Size = New System.Drawing.Size(1410, 681)
        Me.DGAdmMahasiswa.TabIndex = 25
        '
        'No
        '
        Me.No.HeaderText = "No"
        Me.No.MinimumWidth = 8
        Me.No.Name = "No"
        Me.No.Width = 150
        '
        'NIM
        '
        Me.NIM.HeaderText = "NIM"
        Me.NIM.MinimumWidth = 8
        Me.NIM.Name = "NIM"
        Me.NIM.Width = 150
        '
        'Kode
        '
        Me.Kode.HeaderText = "Tahun akademik"
        Me.Kode.MinimumWidth = 8
        Me.Kode.Name = "Kode"
        Me.Kode.Width = 150
        '
        'Nama
        '
        Me.Nama.HeaderText = "Semester"
        Me.Nama.MinimumWidth = 8
        Me.Nama.Name = "Nama"
        Me.Nama.Width = 150
        '
        'JenisKelamin
        '
        Me.JenisKelamin.HeaderText = "Status"
        Me.JenisKelamin.MinimumWidth = 8
        Me.JenisKelamin.Name = "JenisKelamin"
        Me.JenisKelamin.Width = 150
        '
        'No_Telepon
        '
        Me.No_Telepon.HeaderText = "Tgl mulai"
        Me.No_Telepon.MinimumWidth = 8
        Me.No_Telepon.Name = "No_Telepon"
        Me.No_Telepon.Width = 150
        '
        'Fakultas
        '
        Me.Fakultas.HeaderText = "Tgl selesai"
        Me.Fakultas.MinimumWidth = 8
        Me.Fakultas.Name = "Fakultas"
        Me.Fakultas.Width = 150
        '
        'ProgramStudi
        '
        Me.ProgramStudi.HeaderText = "SKS maks"
        Me.ProgramStudi.MinimumWidth = 8
        Me.ProgramStudi.Name = "ProgramStudi"
        Me.ProgramStudi.Width = 150
        '
        'Action
        '
        Me.Action.HeaderText = "Action"
        Me.Action.MinimumWidth = 8
        Me.Action.Name = "Action"
        Me.Action.Width = 150
        '
        'Adm_Semester
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1898, 1024)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.DGAdmMahasiswa)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "Adm_Semester"
        Me.Text = "Adm_Semester"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DGAdmMahasiswa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnDasboard As Button
    Friend WithEvents btnJadwalPerkuliahan As Button
    Friend WithEvents btnSemester As Button
    Friend WithEvents btnRuangan As Button
    Friend WithEvents btnFakultasProdi As Button
    Friend WithEvents btnDosen As Button
    Friend WithEvents btnMahasiswa As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnEdit As Button
    Friend WithEvents DGAdmMahasiswa As DataGridView
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents NIM As DataGridViewTextBoxColumn
    Friend WithEvents Kode As DataGridViewTextBoxColumn
    Friend WithEvents Nama As DataGridViewTextBoxColumn
    Friend WithEvents JenisKelamin As DataGridViewTextBoxColumn
    Friend WithEvents No_Telepon As DataGridViewTextBoxColumn
    Friend WithEvents Fakultas As DataGridViewTextBoxColumn
    Friend WithEvents ProgramStudi As DataGridViewTextBoxColumn
    Friend WithEvents Action As DataGridViewTextBoxColumn
End Class
