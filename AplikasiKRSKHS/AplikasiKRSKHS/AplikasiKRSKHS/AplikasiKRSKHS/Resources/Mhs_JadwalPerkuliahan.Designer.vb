<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Mhs_JadwalPerkuliahan
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDasboard = New System.Windows.Forms.Button()
        Me.btnKHS = New System.Windows.Forms.Button()
        Me.btnLMS = New System.Windows.Forms.Button()
        Me.btnKRS = New System.Windows.Forms.Button()
        Me.btnJadwalPerkuliahan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MataKuliah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dosen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SKS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kelas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ruang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hari = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_Hari = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Indigo
        Me.Panel1.Controls.Add(Me.btnDasboard)
        Me.Panel1.Controls.Add(Me.btnKHS)
        Me.Panel1.Controls.Add(Me.btnLMS)
        Me.Panel1.Controls.Add(Me.btnKRS)
        Me.Panel1.Controls.Add(Me.btnJadwalPerkuliahan)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 1080)
        Me.Panel1.TabIndex = 8
        '
        'btnDasboard
        '
        Me.btnDasboard.BackColor = System.Drawing.Color.DarkViolet
        Me.btnDasboard.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDasboard.ForeColor = System.Drawing.Color.White
        Me.btnDasboard.Location = New System.Drawing.Point(31, 194)
        Me.btnDasboard.Name = "btnDasboard"
        Me.btnDasboard.Size = New System.Drawing.Size(286, 55)
        Me.btnDasboard.TabIndex = 11
        Me.btnDasboard.Text = "Dasboard"
        Me.btnDasboard.UseVisualStyleBackColor = False
        '
        'btnKHS
        '
        Me.btnKHS.BackColor = System.Drawing.Color.DarkViolet
        Me.btnKHS.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKHS.ForeColor = System.Drawing.Color.White
        Me.btnKHS.Location = New System.Drawing.Point(31, 554)
        Me.btnKHS.Name = "btnKHS"
        Me.btnKHS.Size = New System.Drawing.Size(286, 55)
        Me.btnKHS.TabIndex = 9
        Me.btnKHS.Text = "KHS"
        Me.btnKHS.UseVisualStyleBackColor = False
        '
        'btnLMS
        '
        Me.btnLMS.BackColor = System.Drawing.Color.DarkViolet
        Me.btnLMS.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLMS.ForeColor = System.Drawing.Color.White
        Me.btnLMS.Location = New System.Drawing.Point(31, 281)
        Me.btnLMS.Name = "btnLMS"
        Me.btnLMS.Size = New System.Drawing.Size(286, 55)
        Me.btnLMS.TabIndex = 8
        Me.btnLMS.Text = "LMS"
        Me.btnLMS.UseVisualStyleBackColor = False
        '
        'btnKRS
        '
        Me.btnKRS.BackColor = System.Drawing.Color.DarkViolet
        Me.btnKRS.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKRS.ForeColor = System.Drawing.Color.White
        Me.btnKRS.Location = New System.Drawing.Point(31, 462)
        Me.btnKRS.Name = "btnKRS"
        Me.btnKRS.Size = New System.Drawing.Size(286, 55)
        Me.btnKRS.TabIndex = 6
        Me.btnKRS.Text = "KRS"
        Me.btnKRS.UseVisualStyleBackColor = False
        '
        'btnJadwalPerkuliahan
        '
        Me.btnJadwalPerkuliahan.BackColor = System.Drawing.Color.DarkViolet
        Me.btnJadwalPerkuliahan.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJadwalPerkuliahan.ForeColor = System.Drawing.Color.White
        Me.btnJadwalPerkuliahan.Location = New System.Drawing.Point(31, 370)
        Me.btnJadwalPerkuliahan.Name = "btnJadwalPerkuliahan"
        Me.btnJadwalPerkuliahan.Size = New System.Drawing.Size(286, 55)
        Me.btnJadwalPerkuliahan.TabIndex = 5
        Me.btnJadwalPerkuliahan.Text = "Jadwal Perkuliahan"
        Me.btnJadwalPerkuliahan.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(24, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 74)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "JADWAL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PERKULIAHAN"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkViolet
        Me.Panel3.Controls.Add(Me.btnLogout)
        Me.Panel3.Location = New System.Drawing.Point(1, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1920, 80)
        Me.Panel3.TabIndex = 9
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
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MataKuliah, Me.Dosen, Me.SKS, Me.Kelas, Me.Ruang, Me.Hari, Me.Jam})
        Me.DataGridView1.Location = New System.Drawing.Point(398, 281)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(962, 671)
        Me.DataGridView1.TabIndex = 18
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
        'Jam
        '
        Me.Jam.HeaderText = "Jam"
        Me.Jam.MinimumWidth = 8
        Me.Jam.Name = "Jam"
        Me.Jam.Width = 150
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Humanst521 BT", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(392, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 34)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Hari"
        '
        'cmb_Hari
        '
        Me.cmb_Hari.FormattingEnabled = True
        Me.cmb_Hari.Items.AddRange(New Object() {"Senin", "Selasa", "Rabu", "Kamis", "Jum'at", "Sabtu", "Minggu"})
        Me.cmb_Hari.Location = New System.Drawing.Point(398, 221)
        Me.cmb_Hari.Name = "cmb_Hari"
        Me.cmb_Hari.Size = New System.Drawing.Size(251, 28)
        Me.cmb_Hari.TabIndex = 28
        '
        'Mhs_JadwalPerkuliahan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1898, 1024)
        Me.Controls.Add(Me.cmb_Hari)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "Mhs_JadwalPerkuliahan"
        Me.Text = "Mhs_JadwalPerkuliahan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnDasboard As Button
    Friend WithEvents btnKHS As Button
    Friend WithEvents btnLMS As Button
    Friend WithEvents btnKRS As Button
    Friend WithEvents btnJadwalPerkuliahan As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MataKuliah As DataGridViewTextBoxColumn
    Friend WithEvents Dosen As DataGridViewTextBoxColumn
    Friend WithEvents SKS As DataGridViewTextBoxColumn
    Friend WithEvents Kelas As DataGridViewTextBoxColumn
    Friend WithEvents Ruang As DataGridViewTextBoxColumn
    Friend WithEvents Hari As DataGridViewTextBoxColumn
    Friend WithEvents Jam As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_Hari As ComboBox
End Class
