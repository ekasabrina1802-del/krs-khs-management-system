<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Mhs_KHS
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
        Me.SKS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDasboard = New System.Windows.Forms.Button()
        Me.btnKHS = New System.Windows.Forms.Button()
        Me.btnKRS = New System.Windows.Forms.Button()
        Me.Kelas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dosen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvKHS = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCetakKHS = New System.Windows.Forms.Button()
        CType(Me.dgvKHS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'SKS
        '
        Me.SKS.HeaderText = "SKS"
        Me.SKS.MinimumWidth = 8
        Me.SKS.Name = "SKS"
        Me.SKS.Width = 150
        '
        'btnDasboard
        '
        Me.btnDasboard.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.btnDasboard.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDasboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnDasboard.Location = New System.Drawing.Point(32, 194)
        Me.btnDasboard.Name = "btnDasboard"
        Me.btnDasboard.Size = New System.Drawing.Size(286, 55)
        Me.btnDasboard.TabIndex = 11
        Me.btnDasboard.Text = "Dasboard"
        Me.btnDasboard.UseVisualStyleBackColor = False
        '
        'btnKHS
        '
        Me.btnKHS.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.btnKHS.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKHS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnKHS.Location = New System.Drawing.Point(32, 378)
        Me.btnKHS.Name = "btnKHS"
        Me.btnKHS.Size = New System.Drawing.Size(286, 55)
        Me.btnKHS.TabIndex = 9
        Me.btnKHS.Text = "KHS"
        Me.btnKHS.UseVisualStyleBackColor = False
        '
        'btnKRS
        '
        Me.btnKRS.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.btnKRS.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKRS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnKRS.Location = New System.Drawing.Point(32, 285)
        Me.btnKRS.Name = "btnKRS"
        Me.btnKRS.Size = New System.Drawing.Size(286, 55)
        Me.btnKRS.TabIndex = 6
        Me.btnKRS.Text = "KRS"
        Me.btnKRS.UseVisualStyleBackColor = False
        '
        'Kelas
        '
        Me.Kelas.HeaderText = "Nilai Indeks"
        Me.Kelas.MinimumWidth = 8
        Me.Kelas.Name = "Kelas"
        Me.Kelas.Width = 150
        '
        'Dosen
        '
        Me.Dosen.HeaderText = "Nilai Huruf"
        Me.Dosen.MinimumWidth = 8
        Me.Dosen.Name = "Dosen"
        Me.Dosen.Width = 150
        '
        'Nama
        '
        Me.Nama.HeaderText = "Mata Kuliah"
        Me.Nama.MinimumWidth = 8
        Me.Nama.Name = "Nama"
        Me.Nama.Width = 150
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Teal
        Me.btnLogout.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.Linen
        Me.btnLogout.Location = New System.Drawing.Point(1712, 15)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(130, 48)
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Humanst521 BT", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(394, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(292, 68)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Tahun Ajaran 2025/2026" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Semester 3"
        '
        'dgvKHS
        '
        Me.dgvKHS.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvKHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKHS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nama, Me.Dosen, Me.Kelas, Me.SKS})
        Me.dgvKHS.Location = New System.Drawing.Point(399, 264)
        Me.dgvKHS.Name = "dgvKHS"
        Me.dgvKHS.RowHeadersWidth = 62
        Me.dgvKHS.RowTemplate.Height = 28
        Me.dgvKHS.Size = New System.Drawing.Size(1442, 714)
        Me.dgvKHS.TabIndex = 23
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.btnDasboard)
        Me.Panel1.Controls.Add(Me.btnKHS)
        Me.Panel1.Controls.Add(Me.btnKRS)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 1080)
        Me.Panel1.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(24, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 37)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "KHS"
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
        'btnCetakKHS
        '
        Me.btnCetakKHS.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnCetakKHS.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCetakKHS.ForeColor = System.Drawing.Color.White
        Me.btnCetakKHS.Location = New System.Drawing.Point(399, 194)
        Me.btnCetakKHS.Name = "btnCetakKHS"
        Me.btnCetakKHS.Size = New System.Drawing.Size(196, 52)
        Me.btnCetakKHS.TabIndex = 25
        Me.btnCetakKHS.Text = "Cetak KHS"
        Me.btnCetakKHS.UseVisualStyleBackColor = False
        '
        'Mhs_KHS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(1898, 1024)
        Me.Controls.Add(Me.btnCetakKHS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvKHS)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "Mhs_KHS"
        Me.Text = "Mhs_KHS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvKHS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SKS As DataGridViewTextBoxColumn
    Friend WithEvents btnDasboard As Button
    Friend WithEvents btnKHS As Button
    Friend WithEvents btnKRS As Button
    Friend WithEvents Kelas As DataGridViewTextBoxColumn
    Friend WithEvents Dosen As DataGridViewTextBoxColumn
    Friend WithEvents Nama As DataGridViewTextBoxColumn
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvKHS As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnCetakKHS As Button
End Class
