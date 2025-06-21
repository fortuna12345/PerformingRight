<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pencipta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pencipta))
        Me.txtNomorRekening = New System.Windows.Forms.TextBox()
        Me.dgvPencipta = New System.Windows.Forms.DataGridView()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtNomorAnggota = New System.Windows.Forms.TextBox()
        Me.txtNamaPencipta = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNamaBank = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbLmk = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dgvPencipta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNomorRekening
        '
        Me.txtNomorRekening.Location = New System.Drawing.Point(333, 39)
        Me.txtNomorRekening.Name = "txtNomorRekening"
        Me.txtNomorRekening.Size = New System.Drawing.Size(119, 20)
        Me.txtNomorRekening.TabIndex = 102
        '
        'dgvPencipta
        '
        Me.dgvPencipta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPencipta.Location = New System.Drawing.Point(13, 157)
        Me.dgvPencipta.Name = "dgvPencipta"
        Me.dgvPencipta.Size = New System.Drawing.Size(723, 286)
        Me.dgvPencipta.TabIndex = 101
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(104, 89)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(120, 49)
        Me.txtAlamat.TabIndex = 100
        '
        'txtNomorAnggota
        '
        Me.txtNomorAnggota.Location = New System.Drawing.Point(333, 10)
        Me.txtNomorAnggota.Name = "txtNomorAnggota"
        Me.txtNomorAnggota.Size = New System.Drawing.Size(119, 20)
        Me.txtNomorAnggota.TabIndex = 99
        '
        'txtNamaPencipta
        '
        Me.txtNamaPencipta.Location = New System.Drawing.Point(105, 63)
        Me.txtNamaPencipta.Name = "txtNamaPencipta"
        Me.txtNamaPencipta.Size = New System.Drawing.Size(119, 20)
        Me.txtNamaPencipta.TabIndex = 98
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(106, 10)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(119, 20)
        Me.txtId.TabIndex = 97
        '
        'btnHapus
        '
        Me.btnHapus.Image = CType(resources.GetObject("btnHapus.Image"), System.Drawing.Image)
        Me.btnHapus.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnHapus.Location = New System.Drawing.Point(509, 99)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(59, 52)
        Me.btnHapus.TabIndex = 96
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Image = CType(resources.GetObject("btnBatal.Image"), System.Drawing.Image)
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBatal.Location = New System.Drawing.Point(444, 99)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(59, 52)
        Me.btnBatal.TabIndex = 95
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnUbah
        '
        Me.btnUbah.Image = CType(resources.GetObject("btnUbah.Image"), System.Drawing.Image)
        Me.btnUbah.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUbah.Location = New System.Drawing.Point(379, 99)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(59, 52)
        Me.btnUbah.TabIndex = 94
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Image = CType(resources.GetObject("btnSimpan.Image"), System.Drawing.Image)
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSimpan.Location = New System.Drawing.Point(314, 99)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(59, 52)
        Me.btnSimpan.TabIndex = 93
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(246, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 91
        Me.Label5.Text = "No. Anggota"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(245, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Nomor Rekening"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Nama Pencipta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Id Pengguna"
        '
        'txtNamaBank
        '
        Me.txtNamaBank.Location = New System.Drawing.Point(333, 65)
        Me.txtNamaBank.Name = "txtNamaBank"
        Me.txtNamaBank.Size = New System.Drawing.Size(119, 20)
        Me.txtNamaBank.TabIndex = 104
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(245, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "Nama Bank"
        '
        'cmbLmk
        '
        Me.cmbLmk.FormattingEnabled = True
        Me.cmbLmk.Location = New System.Drawing.Point(105, 36)
        Me.cmbLmk.Name = "cmbLmk"
        Me.cmbLmk.Size = New System.Drawing.Size(121, 21)
        Me.cmbLmk.TabIndex = 105
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 106
        Me.Label7.Text = "LMK"
        '
        'Pencipta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 450)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbLmk)
        Me.Controls.Add(Me.txtNamaBank)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNomorRekening)
        Me.Controls.Add(Me.dgvPencipta)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.txtNomorAnggota)
        Me.Controls.Add(Me.txtNamaPencipta)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Pencipta"
        Me.Text = "Pencipta"
        CType(Me.dgvPencipta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNomorRekening As TextBox
    Friend WithEvents dgvPencipta As DataGridView
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtNomorAnggota As TextBox
    Friend WithEvents txtNamaPencipta As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNamaBank As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbLmk As ComboBox
    Friend WithEvents Label7 As Label
End Class
