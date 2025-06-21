<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lagu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lagu))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbPencipta = New System.Windows.Forms.ComboBox()
        Me.dgvLagu = New System.Windows.Forms.DataGridView()
        Me.txtTahunCipta = New System.Windows.Forms.TextBox()
        Me.txtJudulLagu = New System.Windows.Forms.TextBox()
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
        Me.dtpMulai = New System.Windows.Forms.DateTimePicker()
        Me.dtpAkhir = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgvLagu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 125
        Me.Label7.Text = "Pencipta"
        '
        'cmbPencipta
        '
        Me.cmbPencipta.FormattingEnabled = True
        Me.cmbPencipta.Location = New System.Drawing.Point(104, 31)
        Me.cmbPencipta.Name = "cmbPencipta"
        Me.cmbPencipta.Size = New System.Drawing.Size(121, 21)
        Me.cmbPencipta.TabIndex = 124
        '
        'dgvLagu
        '
        Me.dgvLagu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLagu.Location = New System.Drawing.Point(12, 152)
        Me.dgvLagu.Name = "dgvLagu"
        Me.dgvLagu.Size = New System.Drawing.Size(595, 286)
        Me.dgvLagu.TabIndex = 120
        '
        'txtTahunCipta
        '
        Me.txtTahunCipta.Location = New System.Drawing.Point(103, 84)
        Me.txtTahunCipta.Name = "txtTahunCipta"
        Me.txtTahunCipta.Size = New System.Drawing.Size(120, 20)
        Me.txtTahunCipta.TabIndex = 119
        '
        'txtJudulLagu
        '
        Me.txtJudulLagu.Location = New System.Drawing.Point(104, 58)
        Me.txtJudulLagu.Name = "txtJudulLagu"
        Me.txtJudulLagu.Size = New System.Drawing.Size(119, 20)
        Me.txtJudulLagu.TabIndex = 117
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(105, 5)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(119, 20)
        Me.txtId.TabIndex = 116
        '
        'btnHapus
        '
        Me.btnHapus.Image = CType(resources.GetObject("btnHapus.Image"), System.Drawing.Image)
        Me.btnHapus.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnHapus.Location = New System.Drawing.Point(469, 84)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(59, 52)
        Me.btnHapus.TabIndex = 115
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Image = CType(resources.GetObject("btnBatal.Image"), System.Drawing.Image)
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBatal.Location = New System.Drawing.Point(404, 84)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(59, 52)
        Me.btnBatal.TabIndex = 114
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnUbah
        '
        Me.btnUbah.Image = CType(resources.GetObject("btnUbah.Image"), System.Drawing.Image)
        Me.btnUbah.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUbah.Location = New System.Drawing.Point(339, 84)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(59, 52)
        Me.btnUbah.TabIndex = 113
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Image = CType(resources.GetObject("btnSimpan.Image"), System.Drawing.Image)
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSimpan.Location = New System.Drawing.Point(274, 84)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(59, 52)
        Me.btnSimpan.TabIndex = 112
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 111
        Me.Label6.Text = "Tahun Cipta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(245, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 13)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "Tanggal Mulai Perlindungan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(244, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 13)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "Tanggal Akhir Perlindungan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "Judul Lagu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "Id Lagu"
        '
        'dtpMulai
        '
        Me.dtpMulai.Location = New System.Drawing.Point(391, 4)
        Me.dtpMulai.Name = "dtpMulai"
        Me.dtpMulai.Size = New System.Drawing.Size(137, 20)
        Me.dtpMulai.TabIndex = 126
        '
        'dtpAkhir
        '
        Me.dtpAkhir.Location = New System.Drawing.Point(391, 37)
        Me.dtpAkhir.Name = "dtpAkhir"
        Me.dtpAkhir.Size = New System.Drawing.Size(137, 20)
        Me.dtpAkhir.TabIndex = 127
        '
        'Lagu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 450)
        Me.Controls.Add(Me.dtpAkhir)
        Me.Controls.Add(Me.dtpMulai)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbPencipta)
        Me.Controls.Add(Me.dgvLagu)
        Me.Controls.Add(Me.txtTahunCipta)
        Me.Controls.Add(Me.txtJudulLagu)
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
        Me.Name = "Lagu"
        Me.Text = "Lagu"
        CType(Me.dgvLagu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents cmbPencipta As ComboBox
    Friend WithEvents dgvLagu As DataGridView
    Friend WithEvents txtTahunCipta As TextBox
    Friend WithEvents txtJudulLagu As TextBox
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
    Friend WithEvents dtpMulai As DateTimePicker
    Friend WithEvents dtpAkhir As DateTimePicker
End Class
