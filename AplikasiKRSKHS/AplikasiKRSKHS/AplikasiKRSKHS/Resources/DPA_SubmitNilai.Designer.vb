<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DPA_SubmitNilai
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
        Me.btnApprove = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDasboard = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSubmitNilai = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cmbNilaiIndeks = New System.Windows.Forms.ComboBox()
        Me.btnSimpanData = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbMataKuliah = New System.Windows.Forms.ComboBox()
        Me.cmbNilaiHuruf = New System.Windows.Forms.ComboBox()
        Me.cmbSKS = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNIM = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnApprove
        '
        Me.btnApprove.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.btnApprove.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApprove.ForeColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnApprove.Location = New System.Drawing.Point(29, 284)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(286, 55)
        Me.btnApprove.TabIndex = 27
        Me.btnApprove.Text = "Approved" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnApprove.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.btnDasboard)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnApprove)
        Me.Panel1.Controls.Add(Me.btnSubmitNilai)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 1080)
        Me.Panel1.TabIndex = 37
        '
        'btnDasboard
        '
        Me.btnDasboard.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.btnDasboard.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDasboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnDasboard.Location = New System.Drawing.Point(31, 193)
        Me.btnDasboard.Name = "btnDasboard"
        Me.btnDasboard.Size = New System.Drawing.Size(286, 55)
        Me.btnDasboard.TabIndex = 29
        Me.btnDasboard.Text = "Dasboard"
        Me.btnDasboard.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Linen
        Me.Label2.Location = New System.Drawing.Point(22, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(227, 37)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "SUBMIT NILAI"
        '
        'btnSubmitNilai
        '
        Me.btnSubmitNilai.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.btnSubmitNilai.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitNilai.ForeColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnSubmitNilai.Location = New System.Drawing.Point(29, 376)
        Me.btnSubmitNilai.Name = "btnSubmitNilai"
        Me.btnSubmitNilai.Size = New System.Drawing.Size(286, 55)
        Me.btnSubmitNilai.TabIndex = 20
        Me.btnSubmitNilai.Text = "Submit Nilai"
        Me.btnSubmitNilai.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(22, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 37)
        Me.Label1.TabIndex = 2
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Teal
        Me.btnLogout.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.Linen
        Me.btnLogout.Location = New System.Drawing.Point(1711, 14)
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
        Me.Panel3.Location = New System.Drawing.Point(1, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1920, 80)
        Me.Panel3.TabIndex = 38
        '
        'cmbNilaiIndeks
        '
        Me.cmbNilaiIndeks.FormattingEnabled = True
        Me.cmbNilaiIndeks.Items.AddRange(New Object() {"4", "3,75", "3,5", "3", "2,75", "2,5", "2", "1", "0"})
        Me.cmbNilaiIndeks.Location = New System.Drawing.Point(859, 508)
        Me.cmbNilaiIndeks.Name = "cmbNilaiIndeks"
        Me.cmbNilaiIndeks.Size = New System.Drawing.Size(722, 28)
        Me.cmbNilaiIndeks.TabIndex = 77
        '
        'btnSimpanData
        '
        Me.btnSimpanData.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnSimpanData.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpanData.ForeColor = System.Drawing.Color.Linen
        Me.btnSimpanData.Location = New System.Drawing.Point(1126, 727)
        Me.btnSimpanData.Name = "btnSimpanData"
        Me.btnSimpanData.Size = New System.Drawing.Size(179, 50)
        Me.btnSimpanData.TabIndex = 89
        Me.btnSimpanData.Text = "Simpan Data"
        Me.btnSimpanData.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Teal
        Me.Label6.Location = New System.Drawing.Point(650, 555)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 29)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "SKS:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Teal
        Me.Label5.Location = New System.Drawing.Point(650, 505)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 29)
        Me.Label5.TabIndex = 85
        Me.Label5.Text = "Nilai Indeks:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Teal
        Me.Label4.Location = New System.Drawing.Point(650, 456)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 29)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "Nilai Huruf:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Teal
        Me.Label9.Location = New System.Drawing.Point(650, 406)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(151, 29)
        Me.Label9.TabIndex = 83
        Me.Label9.Text = "Mata Kuliah:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Humanst521 BT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Teal
        Me.Label10.Location = New System.Drawing.Point(977, 205)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(328, 43)
        Me.Label10.TabIndex = 82
        Me.Label10.Text = "Tambah Data Nilai"
        '
        'cmbMataKuliah
        '
        Me.cmbMataKuliah.FormattingEnabled = True
        Me.cmbMataKuliah.Items.AddRange(New Object() {"Basis Data", "Struktur Data", "Grafika Komputer", "Pemrograman Visual", "Pemrograman Mobile", "Interaksi Manusia dan Komputer", "Matematika Diskrit", "Statistika", "Evaluasi Belajar dan Pembelajaran", "Pengembangan Bahan Ajar"})
        Me.cmbMataKuliah.Location = New System.Drawing.Point(859, 406)
        Me.cmbMataKuliah.Name = "cmbMataKuliah"
        Me.cmbMataKuliah.Size = New System.Drawing.Size(722, 28)
        Me.cmbMataKuliah.TabIndex = 90
        '
        'cmbNilaiHuruf
        '
        Me.cmbNilaiHuruf.FormattingEnabled = True
        Me.cmbNilaiHuruf.Items.AddRange(New Object() {"A", "A-", "B+", "B", "B-", "C+", "C", "D", "E"})
        Me.cmbNilaiHuruf.Location = New System.Drawing.Point(860, 457)
        Me.cmbNilaiHuruf.Name = "cmbNilaiHuruf"
        Me.cmbNilaiHuruf.Size = New System.Drawing.Size(722, 28)
        Me.cmbNilaiHuruf.TabIndex = 91
        '
        'cmbSKS
        '
        Me.cmbSKS.FormattingEnabled = True
        Me.cmbSKS.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cmbSKS.Location = New System.Drawing.Point(859, 559)
        Me.cmbSKS.Name = "cmbSKS"
        Me.cmbSKS.Size = New System.Drawing.Size(722, 28)
        Me.cmbSKS.TabIndex = 92
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Teal
        Me.Label3.Location = New System.Drawing.Point(648, 355)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 29)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "NIM:"
        '
        'txtNIM
        '
        Me.txtNIM.Location = New System.Drawing.Point(859, 355)
        Me.txtNIM.Name = "txtNIM"
        Me.txtNIM.Size = New System.Drawing.Size(722, 26)
        Me.txtNIM.TabIndex = 95
        '
        'DPA_SubmitNilai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1898, 1024)
        Me.Controls.Add(Me.txtNIM)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbSKS)
        Me.Controls.Add(Me.cmbNilaiHuruf)
        Me.Controls.Add(Me.cmbMataKuliah)
        Me.Controls.Add(Me.cmbNilaiIndeks)
        Me.Controls.Add(Me.btnSimpanData)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "DPA_SubmitNilai"
        Me.Text = "DPA_SubmitNilai"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnApprove As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSubmitNilai As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnDasboard As Button
    Friend WithEvents cmbNilaiIndeks As ComboBox
    Friend WithEvents btnSimpanData As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbMataKuliah As ComboBox
    Friend WithEvents cmbNilaiHuruf As ComboBox
    Friend WithEvents cmbSKS As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNIM As TextBox
End Class
