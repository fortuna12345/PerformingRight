<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Penerimaan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Penerimaan))
        Me.dtpPeriodeAwal = New System.Windows.Forms.DateTimePicker()
        Me.dtpTanggalBayar = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbOutlet = New System.Windows.Forms.ComboBox()
        Me.dgvPenerimaan = New System.Windows.Forms.DataGridView()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.txtNomorInvoice = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpPeriodeAkhir = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnVerifikasi = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        CType(Me.dgvPenerimaan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpPeriodeAwal
        '
        Me.dtpPeriodeAwal.Location = New System.Drawing.Point(391, 37)
        Me.dtpPeriodeAwal.Name = "dtpPeriodeAwal"
        Me.dtpPeriodeAwal.Size = New System.Drawing.Size(137, 20)
        Me.dtpPeriodeAwal.TabIndex = 144
        '
        'dtpTanggalBayar
        '
        Me.dtpTanggalBayar.Location = New System.Drawing.Point(391, 4)
        Me.dtpTanggalBayar.Name = "dtpTanggalBayar"
        Me.dtpTanggalBayar.Size = New System.Drawing.Size(137, 20)
        Me.dtpTanggalBayar.TabIndex = 143
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 142
        Me.Label7.Text = "Outlet"
        '
        'cmbOutlet
        '
        Me.cmbOutlet.FormattingEnabled = True
        Me.cmbOutlet.Location = New System.Drawing.Point(103, 57)
        Me.cmbOutlet.Name = "cmbOutlet"
        Me.cmbOutlet.Size = New System.Drawing.Size(120, 21)
        Me.cmbOutlet.TabIndex = 141
        '
        'dgvPenerimaan
        '
        Me.dgvPenerimaan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPenerimaan.Location = New System.Drawing.Point(12, 189)
        Me.dgvPenerimaan.Name = "dgvPenerimaan"
        Me.dgvPenerimaan.Size = New System.Drawing.Size(760, 286)
        Me.dgvPenerimaan.TabIndex = 140
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(103, 84)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(120, 20)
        Me.txtJumlah.TabIndex = 139
        '
        'txtNomorInvoice
        '
        Me.txtNomorInvoice.Location = New System.Drawing.Point(105, 31)
        Me.txtNomorInvoice.Name = "txtNomorInvoice"
        Me.txtNomorInvoice.Size = New System.Drawing.Size(119, 20)
        Me.txtNomorInvoice.TabIndex = 138
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(105, 5)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(119, 20)
        Me.txtId.TabIndex = 137
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 132
        Me.Label6.Text = "Jumlah"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(245, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 131
        Me.Label5.Text = "Tanggal Bayar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(244, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 130
        Me.Label3.Text = "Periode Awal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 129
        Me.Label2.Text = "Nomor Invoice"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 128
        Me.Label1.Text = "Id Penerimaan"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(103, 110)
        Me.txtKeterangan.Multiline = True
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(120, 51)
        Me.txtKeterangan.TabIndex = 146
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 145
        Me.Label4.Text = "Keterangan"
        '
        'dtpPeriodeAkhir
        '
        Me.dtpPeriodeAkhir.Location = New System.Drawing.Point(391, 68)
        Me.dtpPeriodeAkhir.Name = "dtpPeriodeAkhir"
        Me.dtpPeriodeAkhir.Size = New System.Drawing.Size(137, 20)
        Me.dtpPeriodeAkhir.TabIndex = 148
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(244, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 147
        Me.Label8.Text = "Periode Akhir"
        '
        'btnBatal
        '
        Me.btnBatal.Image = CType(resources.GetObject("btnBatal.Image"), System.Drawing.Image)
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBatal.Location = New System.Drawing.Point(339, 121)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(59, 52)
        Me.btnBatal.TabIndex = 135
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnVerifikasi
        '
        Me.btnVerifikasi.Image = CType(resources.GetObject("btnVerifikasi.Image"), System.Drawing.Image)
        Me.btnVerifikasi.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnVerifikasi.Location = New System.Drawing.Point(404, 121)
        Me.btnVerifikasi.Name = "btnVerifikasi"
        Me.btnVerifikasi.Size = New System.Drawing.Size(71, 52)
        Me.btnVerifikasi.TabIndex = 134
        Me.btnVerifikasi.Text = "Verivikasi"
        Me.btnVerifikasi.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnVerifikasi.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Image = CType(resources.GetObject("btnSimpan.Image"), System.Drawing.Image)
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSimpan.Location = New System.Drawing.Point(274, 121)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(59, 52)
        Me.btnSimpan.TabIndex = 133
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'Penerimaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 487)
        Me.Controls.Add(Me.dtpPeriodeAkhir)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpPeriodeAwal)
        Me.Controls.Add(Me.dtpTanggalBayar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbOutlet)
        Me.Controls.Add(Me.dgvPenerimaan)
        Me.Controls.Add(Me.txtJumlah)
        Me.Controls.Add(Me.txtNomorInvoice)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnVerifikasi)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Penerimaan"
        Me.Text = "Penerimaan"
        CType(Me.dgvPenerimaan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpPeriodeAwal As DateTimePicker
    Friend WithEvents dtpTanggalBayar As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbOutlet As ComboBox
    Friend WithEvents dgvPenerimaan As DataGridView
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents txtNomorInvoice As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnVerifikasi As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtKeterangan As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpPeriodeAkhir As DateTimePicker
    Friend WithEvents Label8 As Label
End Class
