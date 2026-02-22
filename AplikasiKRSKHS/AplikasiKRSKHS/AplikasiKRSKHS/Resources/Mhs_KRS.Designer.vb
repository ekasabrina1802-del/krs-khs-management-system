<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Mhs_KRS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mhs_KRS))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDasboard = New System.Windows.Forms.Button()
        Me.btnKHS = New System.Windows.Forms.Button()
        Me.btnKRS = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblNamaMahasiswa = New System.Windows.Forms.Label()
        Me.lblNIM = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCetakKRS = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Panel1.TabIndex = 12
        '
        'btnDasboard
        '
        Me.btnDasboard.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.btnDasboard.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDasboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnDasboard.Location = New System.Drawing.Point(31, 194)
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
        Me.btnKHS.Location = New System.Drawing.Point(31, 376)
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
        Me.btnKRS.Location = New System.Drawing.Point(31, 284)
        Me.btnKRS.Name = "btnKRS"
        Me.btnKRS.Size = New System.Drawing.Size(286, 55)
        Me.btnKRS.TabIndex = 6
        Me.btnKRS.Text = "KRS"
        Me.btnKRS.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Linen
        Me.Label1.Location = New System.Drawing.Point(24, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 37)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "KRS"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Teal
        Me.Panel3.Controls.Add(Me.btnLogout)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1920, 80)
        Me.Panel3.TabIndex = 13
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
        'lblNamaMahasiswa
        '
        Me.lblNamaMahasiswa.AutoSize = True
        Me.lblNamaMahasiswa.BackColor = System.Drawing.Color.Transparent
        Me.lblNamaMahasiswa.Font = New System.Drawing.Font("Humanst521 BT", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaMahasiswa.Location = New System.Drawing.Point(386, 113)
        Me.lblNamaMahasiswa.Name = "lblNamaMahasiswa"
        Me.lblNamaMahasiswa.Size = New System.Drawing.Size(234, 34)
        Me.lblNamaMahasiswa.TabIndex = 14
        Me.lblNamaMahasiswa.Text = "Nama Mahasiswa"
        '
        'lblNIM
        '
        Me.lblNIM.AutoSize = True
        Me.lblNIM.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNIM.Location = New System.Drawing.Point(445, 169)
        Me.lblNIM.Name = "lblNIM"
        Me.lblNIM.Size = New System.Drawing.Size(145, 29)
        Me.lblNIM.TabIndex = 12
        Me.lblNIM.Text = "00000000000"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(696, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(496, 29)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Program Studi: S1 Pendidikan Teknologi Informasi"
        '
        'btnCetakKRS
        '
        Me.btnCetakKRS.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnCetakKRS.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCetakKRS.ForeColor = System.Drawing.Color.White
        Me.btnCetakKRS.Location = New System.Drawing.Point(393, 235)
        Me.btnCetakKRS.Name = "btnCetakKRS"
        Me.btnCetakKRS.Size = New System.Drawing.Size(196, 52)
        Me.btnCetakKRS.TabIndex = 17
        Me.btnCetakKRS.Text = "Cetak KRS"
        Me.btnCetakKRS.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(392, 312)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1451, 372)
        Me.FlowLayoutPanel1.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(388, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 29)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "NIM:"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'Mhs_KRS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(1898, 1024)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.btnCetakKRS)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblNIM)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lblNamaMahasiswa)
        Me.Name = "Mhs_KRS"
        Me.Text = "Mhs_KRS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnDasboard As Button
    Friend WithEvents btnKHS As Button
    Friend WithEvents btnKRS As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblNamaMahasiswa As Label
    Friend WithEvents lblNIM As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCetakKRS As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
