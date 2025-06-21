Imports MySql.Data.MySqlClient

Public Class Lagu
    Private selectedLaguId As String = ""

    Private Function GenerateNewLaguId() As String
        BukaKoneksi()
        Dim newId As String = "L001"
        Try
            Dim query As String = "SELECT id FROM Lagu ORDER BY id DESC LIMIT 1"
            Dim cmd As New MySqlCommand(query, Conn)
            Dim lastId As Object = cmd.ExecuteScalar()
            If lastId IsNot Nothing AndAlso Not DBNull.Value.Equals(lastId) Then
                Dim numPart As Integer = Integer.Parse(lastId.ToString().Substring(1))
                numPart += 1
                newId = "L" & numPart.ToString("D3")
            End If
        Catch ex As Exception
            MsgBox("Gagal membuat ID Lagu baru: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
        Return newId
    End Function
    Public Sub LoadPenciptaComboBox()
        BukaKoneksi()
        Try
            Dim cmd As New MySqlCommand("sp_Pencipta_Select", Conn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            cmbPencipta.DataSource = dt
            cmbPencipta.DisplayMember = "nama_pencipta"
            cmbPencipta.ValueMember = "id"
            cmbPencipta.SelectedIndex = -1

        Catch ex As Exception
            MsgBox("Gagal memuat data Pencipta: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    Private Sub frmManajemenLagu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilkanData()
        LoadPenciptaComboBox()
        ResetForm()
    End Sub

    Private Sub TampilkanData()
        BukaKoneksi()
        Try
            Dim cmd As New MySqlCommand("sp_Lagu_Select", Conn)
            cmd.CommandType = CommandType.StoredProcedure
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvLagu.DataSource = dt
            dgvLagu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MsgBox("Gagal menampilkan data Lagu: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    Private Sub ResetForm()
        txtJudulLagu.Clear()
        txtTahunCipta.Clear()
        dtpMulai.Value = DateTime.Now
        dtpAkhir.Value = DateTime.Now
        cmbPencipta.SelectedIndex = -1
        txtId.Text = GenerateNewLaguId()

        btnSimpan.Enabled = True
        btnUbah.Enabled = False
        btnHapus.Enabled = False
        selectedLaguId = ""
        txtJudulLagu.Focus()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If String.IsNullOrWhiteSpace(txtJudulLagu.Text) OrElse cmbPencipta.SelectedIndex = -1 Then
            MsgBox("Judul Lagu dan Pencipta wajib diisi!", MsgBoxStyle.Exclamation)
            Return
        End If

        BukaKoneksi()
        Try
            Dim cmd As New MySqlCommand("sp_Lagu_Insert", Conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@p_id", txtId.Text)
            cmd.Parameters.AddWithValue("@p_pencipta_id", cmbPencipta.SelectedValue.ToString())
            cmd.Parameters.AddWithValue("@p_judul_lagu", txtJudulLagu.Text)
            cmd.Parameters.AddWithValue("@p_tahun_cipta", If(String.IsNullOrEmpty(txtTahunCipta.Text), CType(Nothing, Object), Integer.Parse(txtTahunCipta.Text)))
            cmd.Parameters.AddWithValue("@p_tanggal_mulai_perlindungan", dtpMulai.Value)
            cmd.Parameters.AddWithValue("@p_tanggal_akhir_perlindungan", dtpAkhir.Value)
            cmd.ExecuteNonQuery()
            MsgBox("Data Lagu baru berhasil disimpan.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Gagal menyimpan data Lagu: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
        TampilkanData()
        ResetForm()
    End Sub

    Private Sub dgvLagu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLagu.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvLagu.Rows(e.RowIndex)
            selectedLaguId = row.Cells("id").Value.ToString()
            txtId.Text = selectedLaguId
            txtJudulLagu.Text = row.Cells("judul_lagu").Value.ToString()
            cmbPencipta.SelectedValue = row.Cells("pencipta_id").Value.ToString()
            txtTahunCipta.Text = If(IsDBNull(row.Cells("tahun_cipta").Value), "", row.Cells("tahun_cipta").Value.ToString())
            dtpMulai.Value = Convert.ToDateTime(row.Cells("tanggal_mulai_perlindungan").Value)
            dtpAkhir.Value = Convert.ToDateTime(row.Cells("tanggal_akhir_perlindungan").Value)


            btnSimpan.Enabled = False
            btnUbah.Enabled = True
            btnHapus.Enabled = True
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If String.IsNullOrEmpty(selectedLaguId) OrElse String.IsNullOrWhiteSpace(txtJudulLagu.Text) OrElse cmbPencipta.SelectedIndex = -1 Then
            MsgBox("Pilih data dan isi semua field wajib!", MsgBoxStyle.Exclamation)
            Return
        End If

        BukaKoneksi()
        Try
            Dim cmd As New MySqlCommand("sp_Lagu_Update", Conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@p_id", selectedLaguId)
            cmd.Parameters.AddWithValue("@p_pencipta_id", cmbPencipta.SelectedValue.ToString())
            cmd.Parameters.AddWithValue("@p_judul_lagu", txtJudulLagu.Text)
            cmd.Parameters.AddWithValue("@p_tahun_cipta", If(String.IsNullOrEmpty(txtTahunCipta.Text), CType(Nothing, Object), Integer.Parse(txtTahunCipta.Text)))
            cmd.Parameters.AddWithValue("@p_tanggal_mulai_perlindungan", dtpMulai.Value)
            cmd.Parameters.AddWithValue("@p_tanggal_akhir_perlindungan", dtpAkhir.Value)
            cmd.ExecuteNonQuery()
            MsgBox("Data Lagu berhasil diperbarui.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Gagal memperbarui data: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            TutupKoneksi()
        End Try
        TampilkanData()
        ResetForm()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If String.IsNullOrEmpty(selectedLaguId) Then
            MsgBox("Pilih data yang akan dihapus!", MsgBoxStyle.Exclamation)
            Return
        End If

        If MsgBox("Apakah Anda yakin ingin menghapus Lagu ini?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            BukaKoneksi()
            Try
                Dim cmd As New MySqlCommand("sp_Lagu_Delete", Conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@p_id", selectedLaguId)
                cmd.ExecuteNonQuery()
                MsgBox("Data Lagu berhasil dihapus.", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox("Gagal menghapus data: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                TutupKoneksi()
            End Try
            TampilkanData()
            ResetForm()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        ResetForm()
    End Sub
End Class