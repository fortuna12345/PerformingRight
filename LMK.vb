Imports MySql.Data.MySqlClient

Public Class LMK
    Private selectedLmkId As String = ""

    Private Function GenerateNewLmkId() As String
        BukaKoneksi()
        Dim newId As String = "LMK001"
        Try
            Dim query As String = "SELECT id FROM LMK ORDER BY id DESC LIMIT 1"
            Dim cmd As New MySqlCommand(query, Conn)
            Dim lastId As Object = cmd.ExecuteScalar()
            If lastId IsNot Nothing AndAlso Not DBNull.Value.Equals(lastId) Then
                Dim numPart As Integer = Integer.Parse(lastId.ToString().Substring(3))
                numPart += 1
                newId = "LMK" & numPart.ToString("D3")
            End If
        Catch ex As Exception
            MsgBox("Gagal membuat ID LMK baru: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
        Return newId
    End Function

    Private Sub frmManajemenLmk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilkanData()
        ResetForm()
    End Sub

    Private Sub TampilkanData()
        BukaKoneksi()
        Try
            Dim cmd As New MySqlCommand("sp_Lmk_Select", Conn)
            cmd.CommandType = CommandType.StoredProcedure
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvLmk.DataSource = dt
            dgvLmk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MsgBox("Gagal menampilkan data LMK: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    Private Sub ResetForm()
        txtNamaLmk.Clear()
        txtAlamat.Clear()
        txtTelepon.Clear()
        txtEmail.Clear()
        txtId.Text = GenerateNewLmkId()
        btnSimpan.Enabled = True
        btnUbah.Enabled = False
        btnHapus.Enabled = False
        selectedLmkId = ""
        txtNamaLmk.Focus()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If String.IsNullOrWhiteSpace(txtEmail.Text) OrElse
                String.IsNullOrWhiteSpace(txtAlamat.Text) OrElse
                String.IsNullOrWhiteSpace(txtTelepon.Text) OrElse
           String.IsNullOrWhiteSpace(txtNamaLmk.Text) Then
            MsgBox("Semua field wajib diisi!", MsgBoxStyle.Exclamation)
            Return
        End If

        BukaKoneksi()
        Try
            Dim cmd As New MySqlCommand("sp_Lmk_Insert", Conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@p_id", txtId.Text)
            cmd.Parameters.AddWithValue("@p_nama_lmk", txtNamaLmk.Text)
            cmd.Parameters.AddWithValue("@p_alamat", txtAlamat.Text)
            cmd.Parameters.AddWithValue("@p_telepon", txtTelepon.Text)
            cmd.Parameters.AddWithValue("@p_email", txtEmail.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Data LMK baru berhasil disimpan.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Gagal menyimpan data LMK: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
        TampilkanData()
        ResetForm()
    End Sub

    Private Sub dgvLmk_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLmk.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvLmk.Rows(e.RowIndex)
            selectedLmkId = row.Cells("id").Value.ToString()
            txtId.Text = selectedLmkId
            txtNamaLmk.Text = row.Cells("nama_lmk").Value.ToString()
            txtAlamat.Text = row.Cells("alamat").Value.ToString()
            txtTelepon.Text = row.Cells("telepon").Value.ToString()
            txtEmail.Text = row.Cells("email").Value.ToString()

            btnSimpan.Enabled = False
            btnUbah.Enabled = True
            btnHapus.Enabled = True
        End If
    End Sub
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        ' Validasi
        If selectedLmkId = "" OrElse
           String.IsNullOrWhiteSpace(txtEmail.Text) OrElse
                String.IsNullOrWhiteSpace(txtAlamat.Text) OrElse
                String.IsNullOrWhiteSpace(txtTelepon.Text) OrElse
           String.IsNullOrWhiteSpace(txtNamaLmk.Text) Then
            MsgBox("Pilih data dan isi semua field wajib!", MsgBoxStyle.Exclamation)
            Return
        End If

        BukaKoneksi()
        Try

            Dim cmd As New MySqlCommand("sp_Lmk_Update", Conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@p_id", selectedLmkId)
            cmd.Parameters.AddWithValue("@p_nama_lmk", txtNamaLmk.Text)
            cmd.Parameters.AddWithValue("@p_alamat", txtAlamat.Text)
            cmd.Parameters.AddWithValue("@p_telepon", txtTelepon.Text)
            cmd.Parameters.AddWithValue("@p_email", txtEmail.Text)
            cmd.ExecuteNonQuery()

            MsgBox("Data LMK berhasil diperbarui.", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox("Gagal memperbarui data: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            TutupKoneksi()
        End Try

        TampilkanData()
        ResetForm()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If String.IsNullOrEmpty(selectedLmkId) Then
            MsgBox("Pilih data yang akan dihapus!", MsgBoxStyle.Exclamation)
            Return
        End If

        ' Konfirmasi sebelum hapus
        If MsgBox("Apakah Anda yakin ingin menghapus LMK ini?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            BukaKoneksi()
            Try
                Dim cmd As New MySqlCommand("sp_Lmk_Delete", Conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@p_id", selectedLmkId)
                cmd.ExecuteNonQuery()

                MsgBox("Data LMK berhasil dihapus.", MsgBoxStyle.Information)

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