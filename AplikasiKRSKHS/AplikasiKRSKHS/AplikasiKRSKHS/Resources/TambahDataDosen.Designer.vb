<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TambahDataDosen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnSimpanData = New System.Windows.Forms.Button()
        Me.cmbStatusAkun = New System.Windows.Forms.ComboBox()
        Me.cmbJenisKelamin = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKodeDosen = New System.Windows.Forms.TextBox()
        Me.txtNIP = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtNoTelepon = New System.Windows.Forms.TextBox()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSimpanData
        '
        Me.btnSimpanData.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnSimpanData.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpanData.ForeColor = System.Drawing.Color.Linen
        Me.btnSimpanData.Location = New System.Drawing.Point(901, 736)
        Me.btnSimpanData.Name = "btnSimpanData"
        Me.btnSimpanData.Size = New System.Drawing.Size(179, 50)
        Me.btnSimpanData.TabIndex = 54
        Me.btnSimpanData.Text = "Simpan Data"
        Me.btnSimpanData.UseVisualStyleBackColor = False
        '
        'cmbStatusAkun
        '
        Me.cmbStatusAkun.FormattingEnabled = True
        Me.cmbStatusAkun.Items.AddRange(New Object() {"Aktif", "Tidak Aktif"})
        Me.cmbStatusAkun.Location = New System.Drawing.Point(687, 597)
        Me.cmbStatusAkun.Name = "cmbStatusAkun"
        Me.cmbStatusAkun.Size = New System.Drawing.Size(722, 28)
        Me.cmbStatusAkun.TabIndex = 6
        '
        'cmbJenisKelamin
        '
        Me.cmbJenisKelamin.FormattingEnabled = True
        Me.cmbJenisKelamin.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.cmbJenisKelamin.Location = New System.Drawing.Point(687, 451)
        Me.cmbJenisKelamin.Name = "cmbJenisKelamin"
        Me.cmbJenisKelamin.Size = New System.Drawing.Size(722, 28)
        Me.cmbJenisKelamin.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(478, 596)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(155, 29)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Status Akun:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(478, 549)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 29)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "No Telepon:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(478, 500)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 29)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Email:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(478, 450)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 29)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Jenis kelamin:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(478, 401)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 29)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Nama:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(478, 353)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 29)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "NIP:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(478, 303)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 29)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Kode:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Humanst521 BT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(809, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(355, 43)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Tambah Data Dosen" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtKodeDosen
        '
        Me.txtKodeDosen.Location = New System.Drawing.Point(687, 307)
        Me.txtKodeDosen.Name = "txtKodeDosen"
        Me.txtKodeDosen.Size = New System.Drawing.Size(722, 26)
        Me.txtKodeDosen.TabIndex = 0
        '
        'txtNIP
        '
        Me.txtNIP.Location = New System.Drawing.Point(687, 355)
        Me.txtNIP.Name = "txtNIP"
        Me.txtNIP.Size = New System.Drawing.Size(722, 26)
        Me.txtNIP.TabIndex = 1
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(687, 403)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(722, 26)
        Me.txtNama.TabIndex = 2
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(687, 502)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(722, 26)
        Me.txtEmail.TabIndex = 4
        '
        'txtNoTelepon
        '
        Me.txtNoTelepon.Location = New System.Drawing.Point(687, 551)
        Me.txtNoTelepon.Name = "txtNoTelepon"
        Me.txtNoTelepon.Size = New System.Drawing.Size(722, 26)
        Me.txtNoTelepon.TabIndex = 5
        '
        'btnKembali
        '
        Me.btnKembali.BackColor = System.Drawing.Color.Teal
        Me.btnKembali.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKembali.ForeColor = System.Drawing.Color.Linen
        Me.btnKembali.Location = New System.Drawing.Point(40, 31)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(138, 45)
        Me.btnKembali.TabIndex = 55
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = False
        '
        'TambahDataDosen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1898, 1024)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.txtNoTelepon)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtNIP)
        Me.Controls.Add(Me.txtKodeDosen)
        Me.Controls.Add(Me.btnSimpanData)
        Me.Controls.Add(Me.cmbStatusAkun)
        Me.Controls.Add(Me.cmbJenisKelamin)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TambahDataDosen"
        Me.Text = "54"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSimpanData As Button
    Friend WithEvents cmbStatusAkun As ComboBox
    Friend WithEvents cmbJenisKelamin As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtKodeDosen As TextBox
    Friend WithEvents txtNIP As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtNoTelepon As TextBox
    Friend WithEvents btnKembali As Button
End Class
