Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient
Module Koneksi
    Private ConnectionString As String = "Server=localhost;Database=royalti_db;Uid=root;Pwd=;"
    Public Conn As MySqlConnection

    Public Sub BukaKoneksi()
        Try
            Conn = New MySqlConnection(ConnectionString)
            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
            End If
        Catch ex As Exception
            MsgBox("Gagal terhubung ke database: " & ex.Message)
        End Try
    End Sub

    Public Sub TutupKoneksi()
        If Conn IsNot Nothing AndAlso Conn.State = ConnectionState.Open Then
            Conn.Close()
        End If
    End Sub

    Public Function HashPassword(ByVal password As String) As String
        ' Lakukan hashing dengan SHA256 secara langsung
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
            Dim hashBytes As Byte() = sha256.ComputeHash(bytes)

            ' Konversi hash menjadi string heksadesimal
            Return BitConverter.ToString(hashBytes).Replace("-", "").ToLower()
        End Using
    End Function

    Public Function VerifyPassword(ByVal passwordInput As String, ByVal hashFromDb As String) As Boolean
        Dim newHash As String = HashPassword(passwordInput)

        Return newHash = hashFromDb
    End Function
End Module
