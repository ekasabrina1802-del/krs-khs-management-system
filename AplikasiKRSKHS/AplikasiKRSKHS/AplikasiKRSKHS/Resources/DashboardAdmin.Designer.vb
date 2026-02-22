<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardAdmin
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
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblSlogan = New System.Windows.Forms.Label()
        Me.lblSubTitle = New System.Windows.Forms.Label()
        Me.btnDasboard = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnMataKuliah = New System.Windows.Forms.Button()
        Me.btnDosen = New System.Windows.Forms.Button()
        Me.btnMahasiswa = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDesc
        '
        Me.lblDesc.BackColor = System.Drawing.Color.Transparent
        Me.lblDesc.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.ForeColor = System.Drawing.Color.Teal
        Me.lblDesc.Location = New System.Drawing.Point(932, 628)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(436, 83)
        Me.lblDesc.TabIndex = 20
        Me.lblDesc.Text = "Menghubungkan admin, Dosen, dan mahasiswa dalam satu sistem akademik"
        Me.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSlogan
        '
        Me.lblSlogan.AutoSize = True
        Me.lblSlogan.BackColor = System.Drawing.Color.Transparent
        Me.lblSlogan.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSlogan.ForeColor = System.Drawing.Color.Teal
        Me.lblSlogan.Location = New System.Drawing.Point(976, 605)
        Me.lblSlogan.Name = "lblSlogan"
        Me.lblSlogan.Size = New System.Drawing.Size(335, 26)
        Me.lblSlogan.TabIndex = 19
        Me.lblSlogan.Text = """Terpadu, Efisien, dan Informatif."""
        Me.lblSlogan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSubTitle
        '
        Me.lblSubTitle.AutoSize = True
        Me.lblSubTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTitle.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTitle.ForeColor = System.Drawing.Color.Black
        Me.lblSubTitle.Location = New System.Drawing.Point(949, 567)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.Size = New System.Drawing.Size(388, 27)
        Me.lblSubTitle.TabIndex = 18
        Me.lblSubTitle.Text = "Sistem Integrasi Akademik Terpadu"
        Me.lblSubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDasboard
        '
        Me.btnDasboard.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.btnDasboard.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDasboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnDasboard.Location = New System.Drawing.Point(32, 193)
        Me.btnDasboard.Name = "btnDasboard"
        Me.btnDasboard.Size = New System.Drawing.Size(286, 55)
        Me.btnDasboard.TabIndex = 27
        Me.btnDasboard.Text = "Dasboard"
        Me.btnDasboard.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnDasboard)
        Me.Panel1.Controls.Add(Me.btnMataKuliah)
        Me.Panel1.Controls.Add(Me.btnDosen)
        Me.Panel1.Controls.Add(Me.btnMahasiswa)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 1080)
        Me.Panel1.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Linen
        Me.Label2.Location = New System.Drawing.Point(23, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 74)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "DASHBOARD" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ADMIN"
        '
        'btnMataKuliah
        '
        Me.btnMataKuliah.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.btnMataKuliah.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMataKuliah.ForeColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnMataKuliah.Location = New System.Drawing.Point(30, 470)
        Me.btnMataKuliah.Name = "btnMataKuliah"
        Me.btnMataKuliah.Size = New System.Drawing.Size(286, 55)
        Me.btnMataKuliah.TabIndex = 26
        Me.btnMataKuliah.Text = "Mata Kuliah"
        Me.btnMataKuliah.UseVisualStyleBackColor = False
        '
        'btnDosen
        '
        Me.btnDosen.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.btnDosen.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDosen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnDosen.Location = New System.Drawing.Point(32, 376)
        Me.btnDosen.Name = "btnDosen"
        Me.btnDosen.Size = New System.Drawing.Size(286, 55)
        Me.btnDosen.TabIndex = 21
        Me.btnDosen.Text = "Dosen"
        Me.btnDosen.UseVisualStyleBackColor = False
        '
        'btnMahasiswa
        '
        Me.btnMahasiswa.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.btnMahasiswa.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMahasiswa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(34, Byte), Integer))
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
        Me.Label1.Size = New System.Drawing.Size(0, 37)
        Me.Label1.TabIndex = 2
        '
        'btnLogout
        '
        Me.btnLogout.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock
        Me.btnLogout.BackColor = System.Drawing.Color.Teal
        Me.btnLogout.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.Linen
        Me.btnLogout.Location = New System.Drawing.Point(1712, 15)
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
        Me.Panel3.TabIndex = 22
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox2.Image = Global.AplikasiKRSKHS.My.Resources.Resources.Sistem_Integrasi_Akademik_Terpadu
        Me.PictureBox2.Location = New System.Drawing.Point(860, 351)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(565, 339)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 27
        Me.PictureBox2.TabStop = False
        '
        'DashboardAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(1898, 1024)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.lblSlogan)
        Me.Controls.Add(Me.lblSubTitle)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "DashboardAdmin"
        Me.Text = "DashboardAdmin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDesc As Label
    Friend WithEvents lblSlogan As Label
    Friend WithEvents lblSubTitle As Label
    Friend WithEvents btnDasboard As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMataKuliah As Button
    Friend WithEvents btnDosen As Button
    Friend WithEvents btnMahasiswa As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
