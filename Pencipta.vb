Imports MySql.Data.MySqlClient

Public Class Pencipta
    Private selectedPenciptaId As String = ""

    Private Function GenerateNewPenciptaId() As String
        BukaKoneksi()
        Dim newId As String = "P001"
        Try
            Dim query As String = "SELECT id FROM Pencipta ORDER BY id DESC LIMIT 1"
            Dim cmd As New MySqlCommand(query, Conn)
            Dim lastId As Object = cmd.ExecuteScalar()
            If lastId IsNot Nothing AndAlso Not DBNull.Value.Equals(lastId) Then
                Dim numPart As Integer = Integer.Parse(lastId.ToString().Substring(1))
                numPart += 1
                newId = "P" & numPart.ToString("D3")
            End If
        Catch ex As Exception
            MsgBox("Gagal membuat ID Pencipta baru: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
        Return newId
    End Function
    Public Sub LoadLmkComboBox()
        BukaKoneksi()
        Try
            ' Memanggil stored procedure sp_LMK_Select
            Dim cmd As New MySqlCommand("sp_LMK_Select", Conn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            cmbLmk.DataSource = dt
            cmbLmk.DisplayMember = "nama_lmk"
            cmbLmk.ValueMember = "id"
            cmbLmk.SelectedIndex = -1

        Catch ex As Exception
            MsgBox("Gagal memuat data LMK: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    Private Sub frmManajemenPencipta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilkanData()
        LoadLmkComboBox()
        ResetForm()
    End Sub

    Private Sub TampilkanData()
        BukaKoneksi()
        Try
            Dim cmd As New MySqlCommand("sp_Pencipta_Select", Conn)
            cmd.CommandType = CommandType.StoredProcedure
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvPencipta.DataSource = dt
            dgvPencipta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MsgBox("Gagal menampilkan data Pencipta: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    Private Sub ResetForm()
        cmbLmk.SelectedIndex = -1
        txtNomorAnggota.Clear()
        txtNamaPencipta.Clear()
        txtAlamat.Clear()
        txtNomorRekening.Clear()
        txtNamaBank.Clear()
        txtId.Text = GenerateNewPenciptaId()
        btnSimpan.Enabled = True
        btnUbah.Enabled = False
        btnHapus.Enabled = False
        selectedPenciptaId = ""
        txtNamaPencipta.Focus()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If String.IsNullOrWhiteSpace(txtNomorAnggota.Text) OrElse String.IsNullOrWhiteSpace(txtNamaPencipta.Text) Then
            MsgBox("Nomor Anggota dan Nama Pencipta wajib diisi!", MsgBoxStyle.Exclamation)
            Return
        End If

        BukaKoneksi()
        Try
            Dim cmd As New MySqlCommand("sp_Pencipta_Insert", Conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@p_id", txtId.Text)
            cmd.Parameters.AddWithValue("@p_lmk_id", If(cmbLmk.SelectedIndex = -1, CType(Nothing, Object), cmbLmk.SelectedValue))
            cmd.Parameters.AddWithValue("@p_nomor_anggota", txtNomorAnggota.Text)
            cmd.Parameters.AddWithValue("@p_nama_pencipta", txtNamaPencipta.Text)
            cmd.Parameters.AddWithValue("@p_alamat", txtAlamat.Text)
            cmd.Parameters.AddWithValue("@p_nomor_rekening", txtNomorRekening.Text)
            cmd.Parameters.AddWithValue("@p_nama_bank", txtNamaBank.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Data Pencipta baru berhasil disimpan.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Gagal menyimpan data Pencipta: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
        TampilkanData()
        ResetForm()
    End Sub

    Private Sub dgvPencipta_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPencipta.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvPencipta.Rows(e.RowIndex)
            selectedPenciptaId = row.Cells("id").Value.ToString()
            txtId.Text = selectedPenciptaId
            txtNomorAnggota.Text = row.Cells("nomor_anggota").Value.ToString()
            txtNamaPencipta.Text = row.Cells("nama_pencipta").Value.ToString()
            cmbLmk.SelectedValue = If(IsDBNull(row.Cells("lmk_id").Value), Nothing, row.Cells("lmk_id").Value)
            txtAlamat.Text = If(IsDBNull(row.Cells("alamat").Value), "", row.Cells("alamat").Value.ToString())
            txtNomorRekening.Text = If(IsDBNull(row.Cells("nomor_rekening").Value), "", row.Cells("nomor_rekening").Value.ToString())
            txtNamaBank.Text = If(IsDBNull(row.Cells("nama_bank").Value), "", row.Cells("nama_bank").Value.ToString())

            btnSimpan.Enabled = False
            btnUbah.Enabled = True
            btnHapus.Enabled = True
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If String.IsNullOrEmpty(selectedPenciptaId) OrElse String.IsNullOrWhiteSpace(txtNamaPencipta.Text) Then
            MsgBox("Pilih data dan isi Nama Pencipta!", MsgBoxStyle.Exclamation)
            Return
        End If

        BukaKoneksi()
        Try
            Dim cmd As New MySqlCommand("sp_Pencipta_Update", Conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@p_id", selectedPenciptaId)
            cmd.Parameters.AddWithValue("@p_lmk_id", If(cmbLmk.SelectedIndex = -1, CType(Nothing, Object), cmbLmk.SelectedValue))
            cmd.Parameters.AddWithValue("@p_nama_pencipta", txtNamaPencipta.Text)
            cmd.Parameters.AddWithValue("@p_alamat", txtAlamat.Text)
            cmd.Parameters.AddWithValue("@p_nomor_rekening", txtNomorRekening.Text)
            cmd.Parameters.AddWithValue("@p_nama_bank", txtNamaBank.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Data Pencipta berhasil diperbarui.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Gagal memperbarui data: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            TutupKoneksi()
        End Try
        TampilkanData()
        ResetForm()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If String.IsNullOrEmpty(selectedPenciptaId) Then
            MsgBox("Pilih data yang akan dihapus!", MsgBoxStyle.Exclamation)
            Return
        End If

        If MsgBox("Apakah Anda yakin ingin menghapus Pencipta ini?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            BukaKoneksi()
            Try
                Dim cmd As New MySqlCommand("sp_Pencipta_Delete", Conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@p_id", selectedPenciptaId)
                cmd.ExecuteNonQuery()
                MsgBox("Data Pencipta berhasil dihapus.", MsgBoxStyle.Information)
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