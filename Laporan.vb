Imports System.Text
Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.IO
Public Class Laporan
    Private Sub frmLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpMulai.Value = New DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
        dtpAkhir.Value = DateTime.Now
        TampilkanData()
    End Sub

    Private Sub TampilkanData()
        BukaKoneksi()
        Try
            Dim cmd As New MySqlCommand("sp_Laporan_FilterTanggal", Conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@p_tanggal_awal", dtpMulai.Value.Date)
            cmd.Parameters.AddWithValue("@p_tanggal_akhir", dtpAkhir.Value.Date)

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            dgvLaporan.DataSource = dt
            dgvLaporan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            FormatGridColumns()

        Catch ex As Exception
            MsgBox("Gagal menampilkan laporan: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    Private Sub FormatGridColumns()
        If dgvLaporan.Columns.Contains("jumlah_pembayaran") Then
            dgvLaporan.Columns("jumlah_pembayaran").DefaultCellStyle.Format = "N2"
            dgvLaporan.Columns("jumlah_pembayaran").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End If
        If dgvLaporan.Columns.Contains("jumlah_distribusi") Then
            dgvLaporan.Columns("jumlah_distribusi").DefaultCellStyle.Format = "N2"
            dgvLaporan.Columns("jumlah_distribusi").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End If
        If dgvLaporan.Columns.Contains("tanggal_pembayaran") Then
            dgvLaporan.Columns("tanggal_pembayaran").DefaultCellStyle.Format = "dd-MM-yyyy"
        End If
        If dgvLaporan.Columns.Contains("tanggal_distribusi") AndAlso dgvLaporan.Columns("tanggal_distribusi") IsNot Nothing Then
            dgvLaporan.Columns("tanggal_distribusi").DefaultCellStyle.Format = "dd-MM-yyyy"
        End If
    End Sub


    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        TampilkanData()
    End Sub


    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        ' --- FITUR CETAK MENGGUNAKAN CRYSTAL REPORTS ---

        Dim tglMulai As DateTime = dtpMulai.Value
        Dim tglAkhir As DateTime = dtpAkhir.Value

        ' Buat instance form viewer dan kirimkan tanggal
        Dim frmViewer As New ViewerLaporan(tglMulai, tglAkhir)

        ' Tampilkan form viewer
        frmViewer.ShowDialog()
        ' --- FITUR CETAK / EKSPOR KE CSV ---
        'If dgvLaporan.Rows.Count = 0 Then
        '    MsgBox("Tidak ada data untuk diekspor.", MsgBoxStyle.Information)
        '    Return
        'End If

        '' Buka dialog untuk menyimpan file
        'Dim saveDialog As New SaveFileDialog()
        'saveDialog.Filter = "CSV (Comma-Separated Values)|*.csv"
        'saveDialog.Title = "Simpan Laporan Sebagai..."
        'saveDialog.FileName = "Laporan_Distribusi_" & DateTime.Now.ToString("yyyyMMdd") & ".csv"

        'If saveDialog.ShowDialog() = DialogResult.OK Then
        '    Try
        '        ' Buat objek StringBuilder untuk membangun string CSV
        '        Dim sb As New StringBuilder()

        '        ' 1. Tambahkan Header Kolom
        '        Dim headers = dgvLaporan.Columns.Cast(Of DataGridViewColumn)()
        '        sb.AppendLine(String.Join(",", headers.Select(Function(column) """" & column.HeaderText & """").ToArray()))

        '        ' 2. Tambahkan setiap baris data
        '        For Each row As DataGridViewRow In dgvLaporan.Rows
        '            ' Pastikan bukan baris baru yang kosong (jika ada)
        '            If Not row.IsNewRow Then
        '                Dim cells = row.Cells.Cast(Of DataGridViewCell)()
        '                ' Handle nilai NULL dan pastikan semua data menjadi string
        '                Dim cellValues = cells.Select(Function(cell) """" & If(cell.Value IsNot Nothing, cell.Value.ToString().Replace("""", """"""), "") & """")
        '                sb.AppendLine(String.Join(",", cellValues))
        '            End If
        '        Next

        '        ' 3. Tulis string ke file
        '        File.WriteAllText(saveDialog.FileName, sb.ToString(), Encoding.UTF8)

        '        MsgBox("Laporan berhasil diekspor ke: " & saveDialog.FileName, MsgBoxStyle.Information)

        '    Catch ex As Exception
        '        MsgBox("Terjadi kesalahan saat mengekspor data: " & ex.Message, MsgBoxStyle.Critical)
        '    End Try
        'End If
    End Sub
End Class