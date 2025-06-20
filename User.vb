Imports MySql.Data.MySqlClient

Public Class User
    Private selectedUserId As String = ""

    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilkanData()
        ResetForm()
    End Sub

    Private Sub TampilkanData()
        BukaKoneksi()
        Try
            Dim cmd As New MySqlCommand("sp_User_Select", Conn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvUsers.DataSource = dt

            If dgvUsers.Columns.Contains("password_hash") Then
                dgvUsers.Columns("password_hash").Visible = False
            End If
            dgvUsers.Columns("id").HeaderText = "ID"
            dgvUsers.Columns("username").HeaderText = "Username"
            dgvUsers.Columns("nama_lengkap").HeaderText = "Nama Lengkap"
            dgvUsers.Columns("role").HeaderText = "Role"
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            MsgBox("Gagal menampilkan data: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            TutupKoneksi()
        End Try
    End Sub
    Private Function GenerateNewUserId() As String
        BukaKoneksi()

        Dim newId As String = "U001"

        Try
            Dim query As String = "SELECT id FROM Users ORDER BY id DESC LIMIT 1"
            Dim cmd As New MySqlCommand(query, Conn)

            Dim lastId As Object = cmd.ExecuteScalar()

            If lastId IsNot Nothing AndAlso Not DBNull.Value.Equals(lastId) Then
                Dim numPartAsString As String = lastId.ToString().Substring(1)

                Dim numPart As Integer = Integer.Parse(numPartAsString)

                numPart += 1

                newId = "U" & numPart.ToString("D3")
            End If

        Catch ex As Exception
            ' Tampilkan pesan error jika terjadi masalah saat query ke database
            MsgBox("Gagal membuat ID pengguna baru: " & ex.Message, MsgBoxStyle.Critical)
            ' Kembalikan nilai default atau string kosong sebagai tanda error
            Return "Error"
        Finally
            ' Pastikan koneksi selalu ditutup, apa pun yang terjadi
            TutupKoneksi()
        End Try

        Return newId
    End Function
    Private Sub ResetForm()
        ' Kosongkan semua input
        txtId.Text = GenerateNewUserId()
        txtUsername.Clear()
        txtPassword.Clear()
        txtNamaLengkap.Clear()
        cmbRole.SelectedIndex = -1 ' Tidak ada yang terpilih

        ' Atur kondisi awal tombol
        btnSimpan.Enabled = True
        btnUbah.Enabled = False
        btnHapus.Enabled = False

        selectedUserId = "" ' Reset ID yang dipilih
        txtUsername.Focus()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ' Validasi input
        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse
           String.IsNullOrWhiteSpace(txtPassword.Text) OrElse
           String.IsNullOrWhiteSpace(txtNamaLengkap.Text) OrElse
           cmbRole.SelectedIndex = -1 Then
            MsgBox("Semua field wajib diisi!", MsgBoxStyle.Exclamation)
            Return
        End If

        BukaKoneksi()
        Try
            ' Panggil fungsi hashing dari SecurityUtils
            Dim hashedPassword As String = HashPassword(txtPassword.Text)

            Dim cmd As New MySqlCommand("sp_User_Insert", Conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@p_id", txtId.Text)
            cmd.Parameters.AddWithValue("@p_username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@p_password", hashedPassword)
            cmd.Parameters.AddWithValue("@p_nama_lengkap", txtNamaLengkap.Text)
            cmd.Parameters.AddWithValue("@p_role", cmbRole.SelectedItem.ToString())
            cmd.ExecuteNonQuery()

            MsgBox("Data pengguna baru berhasil disimpan.", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox("Gagal menyimpan data: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            TutupKoneksi()
        End Try

        TampilkanData()
        ResetForm()
    End Sub

    Private Sub dgvUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellClick
        If e.RowIndex >= 0 Then ' Pastikan yang diklik adalah baris data, bukan header
            Dim row As DataGridViewRow = dgvUsers.Rows(e.RowIndex)

            ' Ambil data dan tampilkan ke form
            selectedUserId = row.Cells("id").Value.ToString()
            txtId.Text = selectedUserId
            txtUsername.Text = row.Cells("username").Value.ToString()
            txtNamaLengkap.Text = row.Cells("nama_lengkap").Value.ToString()
            cmbRole.SelectedItem = row.Cells("role").Value.ToString()

            txtPassword.Clear()

            ' Atur tombol
            btnSimpan.Enabled = False
            btnUbah.Enabled = True
            btnHapus.Enabled = True
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        ' Validasi
        If selectedUserId = "" OrElse
           String.IsNullOrWhiteSpace(txtUsername.Text) OrElse
           String.IsNullOrWhiteSpace(txtNamaLengkap.Text) OrElse
           cmbRole.SelectedIndex = -1 Then
            MsgBox("Pilih data dan isi semua field wajib!", MsgBoxStyle.Exclamation)
            Return
        End If

        BukaKoneksi()
        Try
            Dim hashedPassword As String = ""
            ' Hanya hash password baru jika field password diisi
            If Not String.IsNullOrWhiteSpace(txtPassword.Text) Then
                hashedPassword = HashPassword(txtPassword.Text)
            End If

            Dim cmd As New MySqlCommand("sp_User_Update", Conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@p_id", selectedUserId)
            cmd.Parameters.AddWithValue("@p_username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@p_password", hashedPassword) ' Kirim hash baru atau string kosong
            cmd.Parameters.AddWithValue("@p_nama_lengkap", txtNamaLengkap.Text)
            cmd.Parameters.AddWithValue("@p_role", cmbRole.SelectedItem.ToString())
            cmd.ExecuteNonQuery()

            MsgBox("Data pengguna berhasil diperbarui.", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox("Gagal memperbarui data: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            TutupKoneksi()
        End Try

        TampilkanData()
        ResetForm()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If String.IsNullOrEmpty(selectedUserId) Then
            MsgBox("Pilih data yang akan dihapus!", MsgBoxStyle.Exclamation)
            Return
        End If

        ' Konfirmasi sebelum hapus
        If MsgBox("Apakah Anda yakin ingin menghapus pengguna ini?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            BukaKoneksi()
            Try
                Dim cmd As New MySqlCommand("sp_User_Delete", Conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@p_id", selectedUserId)
                cmd.ExecuteNonQuery()

                MsgBox("Data pengguna berhasil dihapus.", MsgBoxStyle.Information)

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