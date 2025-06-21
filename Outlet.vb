Imports MySql.Data.MySqlClient

Public Class Outlet
    Private selectedOutletId As String = ""

    Private Function GenerateNewOutletId() As String
        BukaKoneksi()
        Dim newId As String = "O001"
        Try
            Dim query As String = "SELECT id FROM Outlet ORDER BY id DESC LIMIT 1"
            Dim cmd As New MySqlCommand(query, Conn)
            Dim lastId As Object = cmd.ExecuteScalar()
            If lastId IsNot Nothing AndAlso Not DBNull.Value.Equals(lastId) Then
                Dim numPart As Integer = Integer.Parse(lastId.ToString().Substring(1))
                numPart += 1
                newId = "O" & numPart.ToString("D3")
            End If
        Catch ex As Exception
            MsgBox("Gagal membuat ID Outlet baru: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
        Return newId
    End Function

    Private Sub frmManajemenOutlet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilkanData()
        ' Isi ComboBox Jenis Outlet
        cmbJenisOutlet.Items.AddRange(New String() {"Hotel", "Cafe", "Restoran", "Karaoke", "Lainnya"})
        ResetForm()
    End Sub

    Private Sub TampilkanData()
        BukaKoneksi()
        Try
            Dim cmd As New MySqlCommand("sp_Outlet_Select", Conn)
            cmd.CommandType = CommandType.StoredProcedure
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvOutlet.DataSource = dt
            dgvOutlet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MsgBox("Gagal menampilkan data Outlet: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    Private Sub ResetForm()
        txtNamaOutlet.Clear()
        cmbJenisOutlet.SelectedIndex = -1
        txtAlamat.Clear()
        txtPenanggungJawab.Clear()
        txtTelepon.Clear()
        txtId.Text = GenerateNewOutletId()
        btnSimpan.Enabled = True
        btnUbah.Enabled = False
        btnHapus.Enabled = False
        selectedOutletId = ""
        txtNamaOutlet.Focus()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If String.IsNullOrWhiteSpace(txtNamaOutlet.Text) OrElse cmbJenisOutlet.SelectedIndex = -1 Then
            MsgBox("Nama Outlet dan Jenis Outlet wajib diisi!", MsgBoxStyle.Exclamation)
            Return
        End If

        BukaKoneksi()
        Try
            Dim cmd As New MySqlCommand("sp_Outlet_Insert", Conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@p_id", txtId.Text)
            cmd.Parameters.AddWithValue("@p_nama_outlet", txtNamaOutlet.Text)
            cmd.Parameters.AddWithValue("@p_jenis_outlet", cmbJenisOutlet.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@p_alamat", txtAlamat.Text)
            cmd.Parameters.AddWithValue("@p_penanggung_jawab", txtPenanggungJawab.Text)
            cmd.Parameters.AddWithValue("@p_telepon", txtTelepon.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Data Outlet baru berhasil disimpan.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Gagal menyimpan data Outlet: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
        TampilkanData()
        ResetForm()
    End Sub

    Private Sub dgvOutlet_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOutlet.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvOutlet.Rows(e.RowIndex)
            selectedOutletId = row.Cells("id").Value.ToString()
            txtId.Text = selectedOutletId
            txtNamaOutlet.Text = row.Cells("nama_outlet").Value.ToString()
            cmbJenisOutlet.SelectedItem = row.Cells("jenis_outlet").Value.ToString()
            txtAlamat.Text = If(IsDBNull(row.Cells("alamat").Value), "", row.Cells("alamat").Value.ToString())
            txtPenanggungJawab.Text = If(IsDBNull(row.Cells("penanggung_jawab").Value), "", row.Cells("penanggung_jawab").Value.ToString())
            txtTelepon.Text = If(IsDBNull(row.Cells("telepon").Value), "", row.Cells("telepon").Value.ToString())

            btnSimpan.Enabled = False
            btnUbah.Enabled = True
            btnHapus.Enabled = True
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If String.IsNullOrEmpty(selectedOutletId) OrElse String.IsNullOrWhiteSpace(txtNamaOutlet.Text) OrElse cmbJenisOutlet.SelectedIndex = -1 Then
            MsgBox("Pilih data dan isi semua field wajib!", MsgBoxStyle.Exclamation)
            Return
        End If

        BukaKoneksi()
        Try
            Dim cmd As New MySqlCommand("sp_Outlet_Update", Conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@p_id", selectedOutletId)
            cmd.Parameters.AddWithValue("@p_nama_outlet", txtNamaOutlet.Text)
            cmd.Parameters.AddWithValue("@p_jenis_outlet", cmbJenisOutlet.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@p_alamat", txtAlamat.Text)
            cmd.Parameters.AddWithValue("@p_penanggung_jawab", txtPenanggungJawab.Text)
            cmd.Parameters.AddWithValue("@p_telepon", txtTelepon.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Data Outlet berhasil diperbarui.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Gagal memperbarui data Outlet: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            TutupKoneksi()
        End Try
        TampilkanData()
        ResetForm()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If String.IsNullOrEmpty(selectedOutletId) Then
            MsgBox("Pilih data yang akan dihapus!", MsgBoxStyle.Exclamation)
            Return
        End If

        If MsgBox("Apakah Anda yakin ingin menghapus Outlet ini?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            BukaKoneksi()
            Try
                Dim cmd As New MySqlCommand("sp_Outlet_Delete", Conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@p_id", selectedOutletId)
                cmd.ExecuteNonQuery()
                MsgBox("Data Outlet berhasil dihapus.", MsgBoxStyle.Information)
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