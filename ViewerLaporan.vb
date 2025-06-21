Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports MySql.Data.MySqlClient

Public Class ViewerLaporan
    Private startDate As DateTime
    Private endDate As DateTime

    ' Konstruktor untuk menerima parameter tanggal
    Public Sub New(ByVal tglMulai As DateTime, ByVal tglAkhir As DateTime)
        InitializeComponent()
        Me.startDate = tglMulai
        Me.endDate = tglAkhir
    End Sub

    'Private Sub frmViewerLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Try
    '        ' 1. Buat instance dari file laporan .rpt Anda
    '        Dim rptDokumen As New LaporanDistribusi() ' Ganti dengan nama file .rpt Anda

    '        ' 2. Atur Informasi Koneksi untuk Laporan (INI BAGIAN PENTING)
    '        SetReportConnection(rptDokumen)

    '        ' 3. Set Parameter Stored Procedure
    '        rptDokumen.SetParameterValue("@p_tanggal_awal", Me.startDate)
    '        rptDokumen.SetParameterValue("@p_tanggal_akhir", Me.endDate)

    '        ' 4. Tampilkan laporan di viewer
    '        CrystalReportViewer1.ReportSource = rptDokumen
    '        CrystalReportViewer1.Refresh()

    '    Catch ex As Exception
    '        MsgBox("Gagal memuat laporan: " & ex.Message, MsgBoxStyle.Critical)
    '    End Try
    'End Sub

    'Private Sub SetReportConnection(ByVal report As ReportDocument)
    '    ' Buat objek ConnectionInfo untuk menyimpan detail koneksi
    '    Dim connInfo As New ConnectionInfo()

    '    ' Gunakan koneksi dari modul Koneksi.vb Anda untuk konsistensi
    '    BukaKoneksi()
    '    Dim csb As New MySqlConnectionStringBuilder(Conn.ConnectionString)
    '    TutupKoneksi()

    '    ' Isi detail koneksi
    '    connInfo.ServerName = csb.Server
    '    connInfo.DatabaseName = csb.Database
    '    connInfo.UserID = csb.UserID
    '    connInfo.Password = csb.Password

    '    ' Terapkan informasi koneksi ini ke semua tabel di dalam laporan
    '    For Each table As CrystalDecisions.CrystalReports.Engine.Table In report.Database.Tables
    '        Dim logOnInfo As TableLogOnInfo = table.LogOnInfo
    '        logOnInfo.ConnectionInfo = connInfo
    '        table.ApplyLogOnInfo(logOnInfo)
    '    Next
    'End Sub
End Class