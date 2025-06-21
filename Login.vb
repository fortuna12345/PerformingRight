Imports MySql.Data.MySqlClient

Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrWhiteSpace(txtKdPengguna.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MsgBox("Nama pengguna dan kata sandi tidak boleh kosong!", MsgBoxStyle.Exclamation, "Peringatan")
            Return
        End If

        BukaKoneksi()
        Dim reader As MySqlDataReader
        Dim userId As String = ""
        Dim userRole As String = ""
        Dim passwordFromDb As String = ""

        Try
            Dim query As String = "SELECT id, password_hash, role FROM Users WHERE username = @username"
            Dim cmd As New MySqlCommand(query, Conn)
            cmd.Parameters.AddWithValue("@username", txtKdPengguna.Text)

            reader = cmd.ExecuteReader()

            If reader.HasRows Then
                reader.Read()
                Dim passwordHashFromDb As String = reader("password_hash").ToString()
                userId = reader("id").ToString()
                userRole = reader("role").ToString()

                If VerifyPassword(txtPassword.Text, passwordHashFromDb) Then
                    MsgBox("Login berhasil!", MsgBoxStyle.Information, "Login Sukses")

                    ' Sembunyikan form login
                    Me.Hide()

                    Dim dashboardForm As New Dashboard(userRole, userId)
                    dashboardForm.ShowDialog()

                    txtPassword.Clear()
                    Me.Show()

                Else
                    MsgBox("Kata sandi salah.", MsgBoxStyle.Critical, "Login Gagal")
                End If
            Else
                MsgBox("Nama pengguna tidak ditemukan.", MsgBoxStyle.Critical, "Login Gagal")
            End If

        Catch ex As Exception
            MsgBox("Terjadi kesalahan: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            TutupKoneksi()
        End Try
    End Sub
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Application.Exit()
    End Sub

    Private Sub frmLogin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If Application.OpenForms.Count = 0 Then
            Application.Exit()
        End If
    End Sub
End Class
