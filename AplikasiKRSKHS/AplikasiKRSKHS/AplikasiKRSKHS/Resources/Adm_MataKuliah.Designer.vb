<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Adm_MataKuliah
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
        Me.dgvMataKuliah = New System.Windows.Forms.DataGridView()
        Me.Kode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MataKuliah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SKS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kelas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ruang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hari = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JamMulai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JamSelesai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMahasiswa = New System.Windows.Forms.Button()
        Me.btnDosen = New System.Windows.Forms.Button()
        Me.btnMataKuliah = New System.Windows.Forms.Button()
        Me.btnDasboard = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        CType(Me.dgvMataKuliah, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvMataKuliah
        '
        Me.dgvMataKuliah.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvMataKuliah.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMataKuliah.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Kode, Me.MataKuliah, Me.SKS, Me.Kelas, Me.Ruang, Me.Hari, Me.JamMulai, Me.JamSelesai})
        Me.dgvMataKuliah.Location = New System.Drawing.Point(384, 259)
        Me.dgvMataKuliah.Name = "dgvMataKuliah"
        Me.dgvMataKuliah.RowHeadersWidth = 62
        Me.dgvMataKuliah.RowTemplate.Height = 28
        Me.dgvMataKuliah.Size = New System.Drawing.Size(1409, 610)
        Me.dgvMataKuliah.TabIndex = 31
        '
        'Kode
        '
        Me.Kode.HeaderText = "Kode"
        Me.Kode.MinimumWidth = 8
        Me.Kode.Name = "Kode"
        Me.Kode.Width = 150
        '
        'MataKuliah
        '
        Me.MataKuliah.HeaderText = "Mata Kuliah"
        Me.MataKuliah.MinimumWidth = 8
        Me.MataKuliah.Name = "MataKuliah"
        Me.MataKuliah.Width = 150
        '
        'SKS
        '
        Me.SKS.HeaderText = "SKS"
        Me.SKS.MinimumWidth = 8
        Me.SKS.Name = "SKS"
        Me.SKS.Width = 150
        '
        'Kelas
        '
        Me.Kelas.HeaderText = "Kelas"
        Me.Kelas.MinimumWidth = 8
        Me.Kelas.Name = "Kelas"
        Me.Kelas.Width = 150
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Humanst521 BT", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(378, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(776, 34)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Hai, Admin! Selamat datang di menu Jadwal Perkuliahan Mahasiswa." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Teal
        Me.btnLogout.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.Linen
        Me.btnLogout.Location = New System.Drawing.Point(1712, 16)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(131, 47)
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Teal
        Me.Panel3.Controls.Add(Me.btnLogout)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1920, 80)
        Me.Panel3.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Linen
        Me.Label1.Location = New System.Drawing.Point(23, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 37)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Mata Kuliah"
        '
        'btnMahasiswa
        '
        Me.btnMahasiswa.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.btnMahasiswa.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMahasiswa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnMahasiswa.Location = New System.Drawing.Point(32, 284)
        Me.btnMahasiswa.Name = "btnMahasiswa"
        Me.btnMahasiswa.Size = New System.Drawing.Size(286, 55)
        Me.btnMahasiswa.TabIndex = 28
        Me.btnMahasiswa.Text = "Mahasiswa"
        Me.btnMahasiswa.UseVisualStyleBackColor = False
        '
        'btnDosen
        '
        Me.btnDosen.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.btnDosen.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDosen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnDosen.Location = New System.Drawing.Point(32, 375)
        Me.btnDosen.Name = "btnDosen"
        Me.btnDosen.Size = New System.Drawing.Size(286, 55)
        Me.btnDosen.TabIndex = 29
        Me.btnDosen.Text = "Dosen"
        Me.btnDosen.UseVisualStyleBackColor = False
        '
        'btnMataKuliah
        '
        Me.btnMataKuliah.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.btnMataKuliah.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMataKuliah.ForeColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnMataKuliah.Location = New System.Drawing.Point(32, 470)
        Me.btnMataKuliah.Name = "btnMataKuliah"
        Me.btnMataKuliah.Size = New System.Drawing.Size(286, 55)
        Me.btnMataKuliah.TabIndex = 33
        Me.btnMataKuliah.Text = "Mata Kuliah"
        Me.btnMataKuliah.UseVisualStyleBackColor = False
        '
        'btnDasboard
        '
        Me.btnDasboard.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.btnDasboard.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDasboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnDasboard.Location = New System.Drawing.Point(32, 192)
        Me.btnDasboard.Name = "btnDasboard"
        Me.btnDasboard.Size = New System.Drawing.Size(286, 55)
        Me.btnDasboard.TabIndex = 34
        Me.btnDasboard.Text = "Dasboard"
        Me.btnDasboard.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.btnDasboard)
        Me.Panel1.Controls.Add(Me.btnMataKuliah)
        Me.Panel1.Controls.Add(Me.btnDosen)
        Me.Panel1.Controls.Add(Me.btnMahasiswa)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 1080)
        Me.Panel1.TabIndex = 26
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.Red
        Me.btnHapus.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.btnHapus.Image = Global.AplikasiKRSKHS.My.Resources.Resources.hapus3
        Me.btnHapus.Location = New System.Drawing.Point(508, 194)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(46, 48)
        Me.btnHapus.TabIndex = 40
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnTambah.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.ForeColor = System.Drawing.Color.Black
        Me.btnTambah.Image = Global.AplikasiKRSKHS.My.Resources.Resources.tambah
        Me.btnTambah.Location = New System.Drawing.Point(384, 194)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(46, 48)
        Me.btnTambah.TabIndex = 38
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Yellow
        Me.btnEdit.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Image = Global.AplikasiKRSKHS.My.Resources.Resources.edit
        Me.btnEdit.Location = New System.Drawing.Point(446, 194)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(46, 48)
        Me.btnEdit.TabIndex = 39
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'Adm_MataKuliah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(1898, 1024)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvMataKuliah)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "Adm_MataKuliah"
        Me.Text = "Adm_MataKuliah"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvMataKuliah, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvMataKuliah As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnMahasiswa As Button
    Friend WithEvents btnDosen As Button
    Friend WithEvents btnMataKuliah As Button
    Friend WithEvents btnDasboard As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents Kode As DataGridViewTextBoxColumn
    Friend WithEvents MataKuliah As DataGridViewTextBoxColumn
    Friend WithEvents SKS As DataGridViewTextBoxColumn
    Friend WithEvents Kelas As DataGridViewTextBoxColumn
    Friend WithEvents Ruang As DataGridViewTextBoxColumn
    Friend WithEvents Hari As DataGridViewTextBoxColumn
    Friend WithEvents JamMulai As DataGridViewTextBoxColumn
    Friend WithEvents JamSelesai As DataGridViewTextBoxColumn
End Class
