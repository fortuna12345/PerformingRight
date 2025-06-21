Imports MySql.Data.MySqlClient

Public Class Distribusi
    Private selectedDistribusiId As String = ""
    Private Function GenerateNewDistribusiId() As String
        BukaKoneksi()
        Dim newId As String = "TRX-OUT-001"
        Try
            Dim query As String = "SELECT id FROM distribusi_royalti ORDER BY id DESC LIMIT 1"
            Dim cmd As New MySqlCommand(query, Conn)
            Dim lastId As Object = cmd.ExecuteScalar()
            If lastId IsNot Nothing AndAlso Not DBNull.Value.Equals(lastId) Then
                Dim numPartStr As String = System.Text.RegularExpressions.Regex.Match(lastId.ToString(), "\d+").Value
                Dim numPart As Integer = Integer.Parse(numPartStr)
                numPart += 1
                newId = "TRX-OUT-" & numPart.ToString("D3")
            End If
        Catch ex As Exception
            MsgBox("Gagal membuat ID Distribusi baru: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
        Return newId
    End Function
    Public Sub LoadPenciptaComboBox(ByVal cmb As ComboBox)
        BukaKoneksi()
        Try
            Dim cmd As New MySqlCommand("sp_Pencipta_Select", Conn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            cmb.DataSource = dt
            cmb.DisplayMember = "nama_pencipta"
            cmb.ValueMember = "id"
            cmb.SelectedIndex = -1

        Catch ex As Exception
            MsgBox("Gagal memuat data Pencipta: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            TutupKoneksi()
        End Try
    End Sub
    Public Sub LoadPenerimaanComboBox(ByVal cmb As ComboBox)
        BukaKoneksi()
        Try
            Dim cmd As New MySqlCommand("sp_Penerimaan_UntukDistribusi_Select", Conn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            cmb.DataSource = dt
            cmb.DisplayMember = "DisplayText"
            cmb.ValueMember = "id"
            cmb.SelectedIndex = -1

        Catch ex As Exception
            MsgBox("Gagal memuat data Penerimaan Royalti: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            TutupKoneksi()
        End Try
    End Sub
    Private Sub frmDistribusi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilkanData(Nothing, Nothing, Nothing)
        LoadPenciptaComboBox(cmbPencipta)
        LoadPenerimaanComboBox(cmbPenerimaan)
        ResetForm()
    End Sub

    ' Menampilkan data dengan filter
    Private Sub TampilkanData(ByVal tglAwal As DateTime?, ByVal tglAkhir As DateTime?, ByVal status As String)
        BukaKoneksi()
        Try
            Dim cmd As New MySqlCommand("sp_Distribusi_Tampil", Conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@p_tanggal_awal", tglAwal)
            cmd.Parameters.AddWithValue("@p_tanggal_akhir", tglAkhir)
            cmd.Parameters.AddWithValue("@p_status", status)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvDistribusi.DataSource = dt
            dgvDistribusi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MsgBox("Gagal menampilkan data Distribusi: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    Private Sub ResetForm()
        txtId.Text = GenerateNewDistribusiId()
        cmbPencipta.SelectedIndex = -1
        cmbPenerimaan.SelectedIndex = -1
        dtpTanggalDistribusi.Value = DateTime.Now
        txtJumlahDistribusi.Text = "0"
        txtKeterangan.Clear()

        btnJadwalkan.Enabled = True
        btnProsesTransfer.Enabled = False
        btnSelesaiTransfer.Enabled = False
        selectedDistribusiId = ""
        cmbPenerimaan.Focus()
    End Sub

    Private Sub btnJadwalkan_Click(sender As Object, e As EventArgs) Handles btnJadwalkan.Click
        If cmbPencipta.SelectedIndex = -1 OrElse cmbPenerimaan.SelectedIndex = -1 OrElse CDec(txtJumlahDistribusi.Text) <= 0 Then
            MsgBox("Penerimaan, Pencipta, dan Jumlah Distribusi wajib diisi!", MsgBoxStyle.Exclamation)
            Return
        End If

        BukaKoneksi()
        Dim query As String = "INSERT INTO distribusi_royalti (id, pencipta_id, penerimaan_id, tanggal_distribusi, jumlah_distribusi, status_distribusi, keterangan) " &
                              "VALUES (@id, @pencipta_id, @penerimaan_id, @tanggal_distribusi, @jumlah_distribusi, 'Menunggu Jadwal', @keterangan)"
        Try
            Dim cmd As New MySqlCommand(query, Conn)
            cmd.Parameters.AddWithValue("@id", txtId.Text)
            cmd.Parameters.AddWithValue("@pencipta_id", cmbPencipta.SelectedValue)
            cmd.Parameters.AddWithValue("@penerimaan_id", cmbPenerimaan.SelectedValue)
            cmd.Parameters.AddWithValue("@tanggal_distribusi", dtpTanggalDistribusi.Value)
            cmd.Parameters.AddWithValue("@jumlah_distribusi", CDec(txtJumlahDistribusi.Text))
            cmd.Parameters.AddWithValue("@keterangan", txtKeterangan.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Distribusi royalti berhasil dijadwalkan.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Gagal menjadwalkan distribusi: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
        TampilkanData(Nothing, Nothing, Nothing)
        ResetForm()
    End Sub

    Private Sub dgvDistribusi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDistribusi.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvDistribusi.Rows(e.RowIndex)
            selectedDistribusiId = row.Cells("id").Value.ToString()
            txtId.Text = selectedDistribusiId

            dtpTanggalDistribusi.Value = Convert.ToDateTime(row.Cells("tanggal_distribusi").Value)
            txtJumlahDistribusi.Text = Convert.ToDecimal(row.Cells("jumlah_distribusi").Value).ToString("N2")
            txtKeterangan.Text = If(IsDBNull(row.Cells("keterangan").Value), "", row.Cells("keterangan").Value.ToString())

            If dgvDistribusi.Columns.Contains("pencipta_id") AndAlso Not IsDBNull(row.Cells("pencipta_id").Value) Then
                cmbPencipta.SelectedValue = row.Cells("pencipta_id").Value
            End If

            If dgvDistribusi.Columns.Contains("penerimaan_id") AndAlso Not IsDBNull(row.Cells("penerimaan_id").Value) Then
                cmbPenerimaan.SelectedValue = row.Cells("penerimaan_id").Value
            End If

            Dim status As String = row.Cells("status_distribusi").Value.ToString()
            btnJadwalkan.Enabled = False
            btnProsesTransfer.Enabled = (status = "Menunggu Jadwal")
            btnSelesaiTransfer.Enabled = (status = "Proses Transfer")
        End If
    End Sub

    ' Helper untuk mengubah status
    Private Sub UbahStatusDistribusi(ByVal status As String)
        If String.IsNullOrEmpty(selectedDistribusiId) Then
            MsgBox("Pilih data yang akan diubah statusnya!", MsgBoxStyle.Exclamation)
            Return
        End If

        BukaKoneksi()
        Try
            Dim cmd As New MySqlCommand("sp_Distribusi_UbahStatus", Conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@p_id", selectedDistribusiId)
            cmd.Parameters.AddWithValue("@p_status_baru", status)
            cmd.Parameters.AddWithValue("@p_keterangan", "Status diubah pada " & DateTime.Now.ToString()) ' Contoh Keterangan
            cmd.ExecuteNonQuery()
            MsgBox("Status distribusi berhasil diubah menjadi '" & status & "'.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Gagal mengubah status: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            TutupKoneksi()
        End Try
        TampilkanData(Nothing, Nothing, Nothing)
        ResetForm()
    End Sub

    Private Sub btnProsesTransfer_Click(sender As Object, e As EventArgs) Handles btnProsesTransfer.Click
        UbahStatusDistribusi("Proses Transfer")
    End Sub

    Private Sub btnSelesaiTransfer_Click(sender As Object, e As EventArgs) Handles btnSelesaiTransfer.Click
        UbahStatusDistribusi("Selesai Ditransfer")
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        ResetForm()
    End Sub
End Class