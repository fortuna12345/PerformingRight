Imports MySql.Data.MySqlClient

Public Class Penerimaan
    Private currentUserId As String
    Private selectedPenerimaanId As String = ""
    Public Sub New(ByVal userId As String)
        InitializeComponent()

        Me.currentUserId = userId
    End Sub
    Private Function GenerateNewPenerimaanId() As String
        BukaKoneksi()
        Dim newId As String = "TRX-IN-001"
        Try
            Dim query As String = "SELECT id FROM penerimaan_royalti ORDER BY id DESC LIMIT 1"
            Dim cmd As New MySqlCommand(query, Conn)
            Dim lastId As Object = cmd.ExecuteScalar()
            If lastId IsNot Nothing AndAlso Not DBNull.Value.Equals(lastId) Then
                ' Mengambil bagian numerik dari ID
                Dim numPartStr As String = System.Text.RegularExpressions.Regex.Match(lastId.ToString(), "\d+").Value
                Dim numPart As Integer = Integer.Parse(numPartStr)
                numPart += 1
                newId = "TRX-IN-" & numPart.ToString("D3")
            End If
        Catch ex As Exception
            MsgBox("Gagal membuat ID Penerimaan baru: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
        Return newId
    End Function
    Public Sub LoadOutletComboBox(ByVal cmb As ComboBox)
        BukaKoneksi()
        Try
            Dim cmd As New MySqlCommand("sp_Outlet_Select", Conn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            cmb.DataSource = dt
            cmb.DisplayMember = "nama_outlet" ' Kolom yang akan ditampilkan
            cmb.ValueMember = "id"          ' Kolom yang akan menjadi nilai
            cmb.SelectedIndex = -1

        Catch ex As Exception
            MsgBox("Gagal memuat data Outlet: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            TutupKoneksi()
        End Try
    End Sub
    Private Sub frmPenerimaan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilkanData()
        LoadOutletComboBox(cmbOutlet)
        ResetForm()
    End Sub

    ' Menampilkan data menggunakan Stored Procedure
    Private Sub TampilkanData()
        BukaKoneksi()
        Try
            Dim cmd As New MySqlCommand("sp_Penerimaan_Tampil", Conn)
            cmd.CommandType = CommandType.StoredProcedure
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvPenerimaan.DataSource = dt
            dgvPenerimaan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MsgBox("Gagal menampilkan data Penerimaan: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    Private Sub ResetForm()
        txtId.Text = GenerateNewPenerimaanId()
        txtNomorInvoice.Clear()
        cmbOutlet.SelectedIndex = -1
        dtpTanggalBayar.Value = DateTime.Now
        dtpPeriodeAwal.Value = New DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
        dtpPeriodeAkhir.Value = dtpPeriodeAwal.Value.AddMonths(1).AddDays(-1)
        txtJumlah.Text = "0"
        txtKeterangan.Clear()

        btnSimpan.Enabled = True
        btnVerifikasi.Enabled = False
        selectedPenerimaanId = ""
        txtNomorInvoice.Focus()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If String.IsNullOrWhiteSpace(txtNomorInvoice.Text) OrElse cmbOutlet.SelectedIndex = -1 OrElse CDec(txtJumlah.Text) <= 0 Then
            MsgBox("Nomor Invoice, Outlet, dan Jumlah Pembayaran wajib diisi!", MsgBoxStyle.Exclamation)
            Return
        End If

        BukaKoneksi()
        ' Tidak ada SP untuk insert, jadi kita buat query manual
        Dim query As String = "INSERT INTO penerimaan_royalti (id, outlet_id, nomor_invoice, tanggal_pembayaran, periode_awal, periode_akhir, jumlah_pembayaran, status_pembayaran, keterangan, dicatat_oleh) " &
                              "VALUES (@id, @outlet_id, @nomor_invoice, @tanggal_pembayaran, @periode_awal, @periode_akhir, @jumlah_pembayaran, 'Diterima', @keterangan, @dicatat_oleh)"
        Try
            Dim cmd As New MySqlCommand(query, Conn)
            cmd.Parameters.AddWithValue("@id", txtId.Text)
            cmd.Parameters.AddWithValue("@outlet_id", cmbOutlet.SelectedValue)
            cmd.Parameters.AddWithValue("@nomor_invoice", txtNomorInvoice.Text)
            cmd.Parameters.AddWithValue("@tanggal_pembayaran", dtpTanggalBayar.Value)
            cmd.Parameters.AddWithValue("@periode_awal", dtpPeriodeAwal.Value)
            cmd.Parameters.AddWithValue("@periode_akhir", dtpPeriodeAkhir.Value)
            cmd.Parameters.AddWithValue("@jumlah_pembayaran", CDec(txtJumlah.Text))
            cmd.Parameters.AddWithValue("@keterangan", txtKeterangan.Text)
            cmd.Parameters.AddWithValue("@dicatat_oleh", currentUserId)
            cmd.ExecuteNonQuery()
            MsgBox("Data Penerimaan berhasil disimpan.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Gagal menyimpan data Penerimaan: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
        TampilkanData()
        ResetForm()
    End Sub

    Private Sub dgvPenerimaan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPenerimaan.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvPenerimaan.Rows(e.RowIndex)

            selectedPenerimaanId = row.Cells("id").Value.ToString()

            txtId.Text = selectedPenerimaanId
            txtNomorInvoice.Text = row.Cells("nomor_invoice").Value.ToString()
            dtpTanggalBayar.Value = Convert.ToDateTime(row.Cells("tanggal_pembayaran").Value)
            dtpPeriodeAwal.Value = Convert.ToDateTime(row.Cells("periode_awal").Value)
            dtpPeriodeAkhir.Value = Convert.ToDateTime(row.Cells("periode_akhir").Value)
            txtJumlah.Text = Convert.ToDecimal(row.Cells("jumlah_pembayaran").Value).ToString("N2") ' Format dengan 2 desimal
            txtKeterangan.Text = If(IsDBNull(row.Cells("keterangan").Value), "", row.Cells("keterangan").Value.ToString())

            ' 3. Logika untuk memilih item di ComboBox Outlet
            ' Catatan: Agar ini berfungsi, pastikan Stored Procedure 'sp_Penerimaan_Tampil'
            ' juga menyertakan kolom 'outlet_id' dalam SELECT statement-nya.
            ' Jika tidak, Anda tidak akan bisa mencocokkan nilainya.
            ' Contoh modifikasi SP: SELECT pr.id, pr.outlet_id, ... FROM ...
            If dgvPenerimaan.Columns.Contains("outlet_id") AndAlso Not IsDBNull(row.Cells("outlet_id").Value) Then
                cmbOutlet.SelectedValue = row.Cells("outlet_id").Value
            Else
                ' Jika outlet_id tidak ada, kita bisa coba mencocokkan berdasarkan nama.
                ' Ini kurang ideal tapi bisa menjadi alternatif.
                Dim namaOutlet As String = row.Cells("nama_outlet").Value.ToString()
                cmbOutlet.SelectedIndex = cmbOutlet.FindStringExact(namaOutlet)
            End If

            ' 4. Logika untuk mengaktifkan/menonaktifkan tombol
            btnSimpan.Enabled = False ' Tombol simpan dinonaktifkan saat mode edit/pilih
            Dim status As String = row.Cells("status_pembayaran").Value.ToString()
            If status = "Diterima" Then
                btnVerifikasi.Enabled = True
            Else
                btnVerifikasi.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnVerifikasi_Click(sender As Object, e As EventArgs) Handles btnVerifikasi.Click
        If String.IsNullOrEmpty(selectedPenerimaanId) Then
            MsgBox("Pilih data yang akan diverifikasi!", MsgBoxStyle.Exclamation)
            Return
        End If

        BukaKoneksi()
        Try
            Dim cmd As New MySqlCommand("sp_Penerimaan_UbahStatus", Conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@p_id", selectedPenerimaanId)
            cmd.Parameters.AddWithValue("@p_status_baru", "Diverifikasi")
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil diverifikasi.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Gagal memverifikasi data: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            TutupKoneksi()
        End Try
        TampilkanData()
        ResetForm()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        ResetForm()
    End Sub
End Class