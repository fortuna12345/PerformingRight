<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Distribusi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Distribusi))
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpTanggalDistribusi = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbPenerimaan = New System.Windows.Forms.ComboBox()
        Me.dgvDistribusi = New System.Windows.Forms.DataGridView()
        Me.txtJumlahDistribusi = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbPencipta = New System.Windows.Forms.ComboBox()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnProsesTransfer = New System.Windows.Forms.Button()
        Me.btnJadwalkan = New System.Windows.Forms.Button()
        Me.btnSelesaiTransfer = New System.Windows.Forms.Button()
        CType(Me.dgvDistribusi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(105, 112)
        Me.txtKeterangan.Multiline = True
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(120, 51)
        Me.txtKeterangan.TabIndex = 166
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 165
        Me.Label4.Text = "Keterangan"
        '
        'dtpTanggalDistribusi
        '
        Me.dtpTanggalDistribusi.Location = New System.Drawing.Point(373, 7)
        Me.dtpTanggalDistribusi.Name = "dtpTanggalDistribusi"
        Me.dtpTanggalDistribusi.Size = New System.Drawing.Size(137, 20)
        Me.dtpTanggalDistribusi.TabIndex = 163
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 162
        Me.Label7.Text = "Penerimaan"
        '
        'cmbPenerimaan
        '
        Me.cmbPenerimaan.FormattingEnabled = True
        Me.cmbPenerimaan.Location = New System.Drawing.Point(105, 60)
        Me.cmbPenerimaan.Name = "cmbPenerimaan"
        Me.cmbPenerimaan.Size = New System.Drawing.Size(120, 21)
        Me.cmbPenerimaan.TabIndex = 161
        '
        'dgvDistribusi
        '
        Me.dgvDistribusi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDistribusi.Location = New System.Drawing.Point(12, 169)
        Me.dgvDistribusi.Name = "dgvDistribusi"
        Me.dgvDistribusi.Size = New System.Drawing.Size(783, 286)
        Me.dgvDistribusi.TabIndex = 160
        '
        'txtJumlahDistribusi
        '
        Me.txtJumlahDistribusi.Location = New System.Drawing.Point(105, 86)
        Me.txtJumlahDistribusi.Name = "txtJumlahDistribusi"
        Me.txtJumlahDistribusi.Size = New System.Drawing.Size(120, 20)
        Me.txtJumlahDistribusi.TabIndex = 159
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(105, 7)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(119, 20)
        Me.txtId.TabIndex = 157
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 153
        Me.Label6.Text = "Jumlah Distribusi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(245, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 152
        Me.Label5.Text = "Tanggal Distribusi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 150
        Me.Label2.Text = "Pencipta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 149
        Me.Label1.Text = "Id Distribusi"
        '
        'cmbPencipta
        '
        Me.cmbPencipta.FormattingEnabled = True
        Me.cmbPencipta.Location = New System.Drawing.Point(105, 33)
        Me.cmbPencipta.Name = "cmbPencipta"
        Me.cmbPencipta.Size = New System.Drawing.Size(120, 21)
        Me.cmbPencipta.TabIndex = 167
        '
        'btnBatal
        '
        Me.btnBatal.Image = CType(resources.GetObject("btnBatal.Image"), System.Drawing.Image)
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBatal.Location = New System.Drawing.Point(336, 76)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(59, 52)
        Me.btnBatal.TabIndex = 156
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnProsesTransfer
        '
        Me.btnProsesTransfer.Image = CType(resources.GetObject("btnProsesTransfer.Image"), System.Drawing.Image)
        Me.btnProsesTransfer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnProsesTransfer.Location = New System.Drawing.Point(401, 76)
        Me.btnProsesTransfer.Name = "btnProsesTransfer"
        Me.btnProsesTransfer.Size = New System.Drawing.Size(91, 52)
        Me.btnProsesTransfer.TabIndex = 155
        Me.btnProsesTransfer.Text = "Proses Transfer"
        Me.btnProsesTransfer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProsesTransfer.UseVisualStyleBackColor = True
        '
        'btnJadwalkan
        '
        Me.btnJadwalkan.Image = CType(resources.GetObject("btnJadwalkan.Image"), System.Drawing.Image)
        Me.btnJadwalkan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnJadwalkan.Location = New System.Drawing.Point(260, 76)
        Me.btnJadwalkan.Name = "btnJadwalkan"
        Me.btnJadwalkan.Size = New System.Drawing.Size(70, 52)
        Me.btnJadwalkan.TabIndex = 154
        Me.btnJadwalkan.Text = "Jadwalkan"
        Me.btnJadwalkan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnJadwalkan.UseVisualStyleBackColor = True
        '
        'btnSelesaiTransfer
        '
        Me.btnSelesaiTransfer.Image = CType(resources.GetObject("btnSelesaiTransfer.Image"), System.Drawing.Image)
        Me.btnSelesaiTransfer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSelesaiTransfer.Location = New System.Drawing.Point(498, 76)
        Me.btnSelesaiTransfer.Name = "btnSelesaiTransfer"
        Me.btnSelesaiTransfer.Size = New System.Drawing.Size(91, 52)
        Me.btnSelesaiTransfer.TabIndex = 168
        Me.btnSelesaiTransfer.Text = "Selesai Transfer"
        Me.btnSelesaiTransfer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSelesaiTransfer.UseVisualStyleBackColor = True
        '
        'Distribusi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 467)
        Me.Controls.Add(Me.btnSelesaiTransfer)
        Me.Controls.Add(Me.cmbPencipta)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpTanggalDistribusi)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbPenerimaan)
        Me.Controls.Add(Me.dgvDistribusi)
        Me.Controls.Add(Me.txtJumlahDistribusi)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnProsesTransfer)
        Me.Controls.Add(Me.btnJadwalkan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Distribusi"
        Me.Text = "Distribusi"
        CType(Me.dgvDistribusi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtKeterangan As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpTanggalDistribusi As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbPenerimaan As ComboBox
    Friend WithEvents dgvDistribusi As DataGridView
    Friend WithEvents txtJumlahDistribusi As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnProsesTransfer As Button
    Friend WithEvents btnJadwalkan As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbPencipta As ComboBox
    Friend WithEvents btnSelesaiTransfer As Button
End Class
