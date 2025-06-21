<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan
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
        Me.dtpAkhir = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpMulai = New System.Windows.Forms.DateTimePicker()
        Me.dgvLaporan = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnTampilkan = New System.Windows.Forms.Button()
        Me.btnCetak = New System.Windows.Forms.Button()
        CType(Me.dgvLaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpAkhir
        '
        Me.dtpAkhir.Location = New System.Drawing.Point(214, 40)
        Me.dtpAkhir.Name = "dtpAkhir"
        Me.dtpAkhir.Size = New System.Drawing.Size(137, 20)
        Me.dtpAkhir.TabIndex = 153
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(67, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 152
        Me.Label8.Text = "Tanggal Akhir"
        '
        'dtpMulai
        '
        Me.dtpMulai.Location = New System.Drawing.Point(214, 9)
        Me.dtpMulai.Name = "dtpMulai"
        Me.dtpMulai.Size = New System.Drawing.Size(137, 20)
        Me.dtpMulai.TabIndex = 151
        '
        'dgvLaporan
        '
        Me.dgvLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLaporan.Location = New System.Drawing.Point(12, 89)
        Me.dgvLaporan.Name = "dgvLaporan"
        Me.dgvLaporan.Size = New System.Drawing.Size(757, 299)
        Me.dgvLaporan.TabIndex = 150
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 149
        Me.Label3.Text = "Tanggal Awal"
        '
        'btnTampilkan
        '
        Me.btnTampilkan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTampilkan.Location = New System.Drawing.Point(420, 24)
        Me.btnTampilkan.Name = "btnTampilkan"
        Me.btnTampilkan.Size = New System.Drawing.Size(95, 29)
        Me.btnTampilkan.TabIndex = 154
        Me.btnTampilkan.Text = "Tampilkan"
        Me.btnTampilkan.UseVisualStyleBackColor = True
        '
        'btnCetak
        '
        Me.btnCetak.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCetak.Location = New System.Drawing.Point(543, 24)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(84, 29)
        Me.btnCetak.TabIndex = 155
        Me.btnCetak.Text = "Cetak"
        Me.btnCetak.UseVisualStyleBackColor = True
        '
        'Laporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 400)
        Me.Controls.Add(Me.btnCetak)
        Me.Controls.Add(Me.btnTampilkan)
        Me.Controls.Add(Me.dtpAkhir)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtpMulai)
        Me.Controls.Add(Me.dgvLaporan)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Laporan"
        Me.Text = "Laporan"
        CType(Me.dgvLaporan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpAkhir As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpMulai As DateTimePicker
    Friend WithEvents dgvLaporan As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents btnTampilkan As Button
    Friend WithEvents btnCetak As Button
End Class
