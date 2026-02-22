<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahDataMahasiswa
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
        Me.btnSimpanData = New System.Windows.Forms.Button()
        Me.cmbFakultas = New System.Windows.Forms.ComboBox()
        Me.cmbProgramStudi = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbStatusAkun = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNIM = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtNoTelepon = New System.Windows.Forms.TextBox()
        Me.cmbJenisKelamin = New System.Windows.Forms.ComboBox()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSimpanData
        '
        Me.btnSimpanData.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnSimpanData.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpanData.ForeColor = System.Drawing.Color.Linen
        Me.btnSimpanData.Location = New System.Drawing.Point(902, 736)
        Me.btnSimpanData.Name = "btnSimpanData"
        Me.btnSimpanData.Size = New System.Drawing.Size(179, 50)
        Me.btnSimpanData.TabIndex = 72
        Me.btnSimpanData.Text = "Simpan Data"
        Me.btnSimpanData.UseVisualStyleBackColor = False
        '
        'cmbFakultas
        '
        Me.cmbFakultas.FormattingEnabled = True
        Me.cmbFakultas.Items.AddRange(New Object() {"Teknik"})
        Me.cmbFakultas.Location = New System.Drawing.Point(688, 549)
        Me.cmbFakultas.Name = "cmbFakultas"
        Me.cmbFakultas.Size = New System.Drawing.Size(722, 28)
        Me.cmbFakultas.TabIndex = 5
        '
        'cmbProgramStudi
        '
        Me.cmbProgramStudi.FormattingEnabled = True
        Me.cmbProgramStudi.Items.AddRange(New Object() {"Pendidikan Teknologi Informasi"})
        Me.cmbProgramStudi.Location = New System.Drawing.Point(688, 500)
        Me.cmbProgramStudi.Name = "cmbProgramStudi"
        Me.cmbProgramStudi.Size = New System.Drawing.Size(722, 28)
        Me.cmbProgramStudi.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(479, 548)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 29)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "Fakultas:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(479, 499)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(179, 29)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Program Studi:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(479, 450)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(149, 29)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "No Telepon:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(479, 400)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(167, 29)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Jenis Kelamin:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(479, 351)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 29)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Nama:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(479, 303)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 29)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "NIM:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Humanst521 BT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(771, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(428, 43)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Tambah Data Mahasiswa"
        '
        'cmbStatusAkun
        '
        Me.cmbStatusAkun.FormattingEnabled = True
        Me.cmbStatusAkun.Items.AddRange(New Object() {"Aktif", "Tidak Aktif"})
        Me.cmbStatusAkun.Location = New System.Drawing.Point(688, 600)
        Me.cmbStatusAkun.Name = "cmbStatusAkun"
        Me.cmbStatusAkun.Size = New System.Drawing.Size(722, 28)
        Me.cmbStatusAkun.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(479, 599)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 29)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Status Akun:"
        '
        'txtNIM
        '
        Me.txtNIM.Location = New System.Drawing.Point(689, 306)
        Me.txtNIM.Name = "txtNIM"
        Me.txtNIM.Size = New System.Drawing.Size(721, 26)
        Me.txtNIM.TabIndex = 0
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(689, 354)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(721, 26)
        Me.txtNama.TabIndex = 1
        '
        'txtNoTelepon
        '
        Me.txtNoTelepon.Location = New System.Drawing.Point(689, 452)
        Me.txtNoTelepon.Name = "txtNoTelepon"
        Me.txtNoTelepon.Size = New System.Drawing.Size(721, 26)
        Me.txtNoTelepon.TabIndex = 3
        '
        'cmbJenisKelamin
        '
        Me.cmbJenisKelamin.FormattingEnabled = True
        Me.cmbJenisKelamin.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.cmbJenisKelamin.Location = New System.Drawing.Point(688, 403)
        Me.cmbJenisKelamin.Name = "cmbJenisKelamin"
        Me.cmbJenisKelamin.Size = New System.Drawing.Size(722, 28)
        Me.cmbJenisKelamin.TabIndex = 2
        '
        'btnKembali
        '
        Me.btnKembali.BackColor = System.Drawing.Color.Teal
        Me.btnKembali.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKembali.ForeColor = System.Drawing.Color.Linen
        Me.btnKembali.Location = New System.Drawing.Point(40, 31)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(138, 45)
        Me.btnKembali.TabIndex = 74
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = False
        '
        'TambahDataMahasiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1898, 1024)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.cmbJenisKelamin)
        Me.Controls.Add(Me.txtNoTelepon)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtNIM)
        Me.Controls.Add(Me.cmbStatusAkun)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSimpanData)
        Me.Controls.Add(Me.cmbFakultas)
        Me.Controls.Add(Me.cmbProgramStudi)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TambahDataMahasiswa"
        Me.Text = "TambahDataMahasiswa"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSimpanData As Button
    Friend WithEvents cmbFakultas As ComboBox
    Friend WithEvents cmbProgramStudi As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbStatusAkun As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNIM As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNoTelepon As TextBox
    Friend WithEvents cmbJenisKelamin As ComboBox
    Friend WithEvents btnKembali As Button
End Class
