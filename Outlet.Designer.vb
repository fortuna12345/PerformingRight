<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Outlet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Outlet))
        Me.txtPenanggungJawab = New System.Windows.Forms.TextBox()
        Me.dgvOutlet = New System.Windows.Forms.DataGridView()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtTelepon = New System.Windows.Forms.TextBox()
        Me.txtNamaOutlet = New System.Windows.Forms.TextBox()
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
        Me.cmbJenisOutlet = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgvOutlet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPenanggungJawab
        '
        Me.txtPenanggungJawab.Location = New System.Drawing.Point(354, 46)
        Me.txtPenanggungJawab.Name = "txtPenanggungJawab"
        Me.txtPenanggungJawab.Size = New System.Drawing.Size(119, 20)
        Me.txtPenanggungJawab.TabIndex = 102
        '
        'dgvOutlet
        '
        Me.dgvOutlet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOutlet.Location = New System.Drawing.Point(12, 152)
        Me.dgvOutlet.Name = "dgvOutlet"
        Me.dgvOutlet.Size = New System.Drawing.Size(605, 286)
        Me.dgvOutlet.TabIndex = 101
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(105, 94)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(120, 50)
        Me.txtAlamat.TabIndex = 100
        '
        'txtTelepon
        '
        Me.txtTelepon.Location = New System.Drawing.Point(354, 13)
        Me.txtTelepon.Name = "txtTelepon"
        Me.txtTelepon.Size = New System.Drawing.Size(119, 20)
        Me.txtTelepon.TabIndex = 99
        '
        'txtNamaOutlet
        '
        Me.txtNamaOutlet.Location = New System.Drawing.Point(106, 43)
        Me.txtNamaOutlet.Name = "txtNamaOutlet"
        Me.txtNamaOutlet.Size = New System.Drawing.Size(119, 20)
        Me.txtNamaOutlet.TabIndex = 98
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(106, 17)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(119, 20)
        Me.txtId.TabIndex = 97
        '
        'btnHapus
        '
        Me.btnHapus.Image = CType(resources.GetObject("btnHapus.Image"), System.Drawing.Image)
        Me.btnHapus.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnHapus.Location = New System.Drawing.Point(508, 94)
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
        Me.btnBatal.Location = New System.Drawing.Point(443, 94)
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
        Me.btnUbah.Location = New System.Drawing.Point(378, 94)
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
        Me.btnSimpan.Location = New System.Drawing.Point(313, 94)
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
        Me.Label6.Location = New System.Drawing.Point(19, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(246, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 91
        Me.Label5.Text = "No. Telepon"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(246, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Penanggung Jawab"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Nama Outlet"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Id Outlet"
        '
        'cmbJenisOutlet
        '
        Me.cmbJenisOutlet.FormattingEnabled = True
        Me.cmbJenisOutlet.Location = New System.Drawing.Point(106, 69)
        Me.cmbJenisOutlet.Name = "cmbJenisOutlet"
        Me.cmbJenisOutlet.Size = New System.Drawing.Size(119, 21)
        Me.cmbJenisOutlet.TabIndex = 103
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 104
        Me.Label4.Text = "Jenis Outlet"
        '
        'Outlet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbJenisOutlet)
        Me.Controls.Add(Me.txtPenanggungJawab)
        Me.Controls.Add(Me.dgvOutlet)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.txtTelepon)
        Me.Controls.Add(Me.txtNamaOutlet)
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
        Me.Name = "Outlet"
        Me.Text = "Outlet"
        CType(Me.dgvOutlet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPenanggungJawab As TextBox
    Friend WithEvents dgvOutlet As DataGridView
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtTelepon As TextBox
    Friend WithEvents txtNamaOutlet As TextBox
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
    Friend WithEvents cmbJenisOutlet As ComboBox
    Friend WithEvents Label4 As Label
End Class
