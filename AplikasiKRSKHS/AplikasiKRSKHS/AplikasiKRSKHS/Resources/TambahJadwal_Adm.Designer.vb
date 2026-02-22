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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbRuang = New System.Windows.Forms.ComboBox()
        Me.cmbMataKuliah = New System.Windows.Forms.ComboBox()
        Me.cmbJamMulai = New System.Windows.Forms.ComboBox()
        Me.cmbJamSelesai = New System.Windows.Forms.ComboBox()
        Me.btnSimpanData = New System.Windows.Forms.Button()
        Me.cmbSKS = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbKelas = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbHari = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Humanst521 BT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(648, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(657, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tambah Jadwal Perkuliahan Mahasiswa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(478, 536)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 29)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Ruang:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(478, 370)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 29)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Mata Kuliah:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(477, 648)
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
        Me.Label9.Location = New System.Drawing.Point(477, 702)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(142, 29)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Jam Selesai:"
        '
        'cmbRuang
        '
        Me.cmbRuang.FormattingEnabled = True
        Me.cmbRuang.Items.AddRange(New Object() {"A10.01.03", "A10.01.13", "A10.01.14", "A10.01.15", "A10.01.18", "A10.03.10 LAB MULTIMEDIA", "A10.04.05", "A10.04.07"})
        Me.cmbRuang.Location = New System.Drawing.Point(687, 537)
        Me.cmbRuang.Name = "cmbRuang"
        Me.cmbRuang.Size = New System.Drawing.Size(722, 28)
        Me.cmbRuang.TabIndex = 4
        '
        'cmbMataKuliah
        '
        Me.cmbMataKuliah.FormattingEnabled = True
        Me.cmbMataKuliah.Items.AddRange(New Object() {"Basis Data", "Struktur Data", "Grafika Komputer", "Pemrograman Visual", "Pemrograman Mobile", "Interaksi Manusia dan Komputer", "Matematika Diskrit", "Statistika", "Evaluasi Belajar dan Pembelajaran", "Pengembangan Bahan Ajar"})
        Me.cmbMataKuliah.Location = New System.Drawing.Point(687, 369)
        Me.cmbMataKuliah.Name = "cmbMataKuliah"
        Me.cmbMataKuliah.Size = New System.Drawing.Size(722, 28)
        Me.cmbMataKuliah.TabIndex = 1
        '
        'cmbJamMulai
        '
        Me.cmbJamMulai.FormattingEnabled = True
        Me.cmbJamMulai.Items.AddRange(New Object() {"07:00", "08:40", "09.30", "10:20", "11:10", "12:00", "13:00", "13:40", "14:30", "14:40", "15:00", "15:30"})
        Me.cmbJamMulai.Location = New System.Drawing.Point(686, 649)
        Me.cmbJamMulai.Name = "cmbJamMulai"
        Me.cmbJamMulai.Size = New System.Drawing.Size(722, 28)
        Me.cmbJamMulai.TabIndex = 6
        '
        'cmbJamSelesai
        '
        Me.cmbJamSelesai.FormattingEnabled = True
        Me.cmbJamSelesai.Items.AddRange(New Object() {"08:40", "09:30", "10:20", "11:10", "12:00", "13:00", "13:40", "14:30", "14:40", "15:00", "15:30", "16:40", "17:30"})
        Me.cmbJamSelesai.Location = New System.Drawing.Point(686, 702)
        Me.cmbJamSelesai.Name = "cmbJamSelesai"
        Me.cmbJamSelesai.Size = New System.Drawing.Size(722, 28)
        Me.cmbJamSelesai.TabIndex = 7
        '
        'btnSimpanData
        '
        Me.btnSimpanData.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnSimpanData.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpanData.ForeColor = System.Drawing.Color.Linen
        Me.btnSimpanData.Location = New System.Drawing.Point(903, 796)
        Me.btnSimpanData.Name = "btnSimpanData"
        Me.btnSimpanData.Size = New System.Drawing.Size(179, 50)
        Me.btnSimpanData.TabIndex = 18
        Me.btnSimpanData.Text = "Simpan Data"
        Me.btnSimpanData.UseVisualStyleBackColor = False
        '
        'cmbSKS
        '
        Me.cmbSKS.FormattingEnabled = True
        Me.cmbSKS.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cmbSKS.Location = New System.Drawing.Point(687, 426)
        Me.cmbSKS.Name = "cmbSKS"
        Me.cmbSKS.Size = New System.Drawing.Size(722, 28)
        Me.cmbSKS.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(478, 425)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 29)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "SKS:"
        '
        'cmbKelas
        '
        Me.cmbKelas.FormattingEnabled = True
        Me.cmbKelas.Items.AddRange(New Object() {"PTI A", "PTI B", "PTI C"})
        Me.cmbKelas.Location = New System.Drawing.Point(687, 480)
        Me.cmbKelas.Name = "cmbKelas"
        Me.cmbKelas.Size = New System.Drawing.Size(722, 28)
        Me.cmbKelas.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(478, 479)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 29)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Kelas:"
        '
        'cmbHari
        '
        Me.cmbHari.FormattingEnabled = True
        Me.cmbHari.Items.AddRange(New Object() {"Senin", "Selasa", "Rabu", "Kamis", "Jumat"})
        Me.cmbHari.Location = New System.Drawing.Point(687, 593)
        Me.cmbHari.Name = "cmbHari"
        Me.cmbHari.Size = New System.Drawing.Size(722, 28)
        Me.cmbHari.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(478, 592)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 29)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Hari:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(478, 317)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Kode:"
        '
        'txtKode
        '
        Me.txtKode.Location = New System.Drawing.Point(687, 320)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(722, 26)
        Me.txtKode.TabIndex = 0
        '
        'btnKembali
        '
        Me.btnKembali.BackColor = System.Drawing.Color.Teal
        Me.btnKembali.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKembali.ForeColor = System.Drawing.Color.Linen
        Me.btnKembali.Location = New System.Drawing.Point(43, 36)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(138, 45)
        Me.btnKembali.TabIndex = 56
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = False
        '
        'TambahJadwal_Adm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1898, 1024)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.txtKode)
        Me.Controls.Add(Me.cmbHari)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbKelas)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbSKS)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnSimpanData)
        Me.Controls.Add(Me.cmbJamSelesai)
        Me.Controls.Add(Me.cmbJamMulai)
        Me.Controls.Add(Me.cmbMataKuliah)
        Me.Controls.Add(Me.cmbRuang)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
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
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbRuang As ComboBox
    Friend WithEvents cmbMataKuliah As ComboBox
    Friend WithEvents cmbJamMulai As ComboBox
    Friend WithEvents cmbJamSelesai As ComboBox
    Friend WithEvents btnSimpanData As Button
    Friend WithEvents cmbSKS As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbKelas As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbHari As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtKode As TextBox
    Friend WithEvents btnKembali As Button
End Class
