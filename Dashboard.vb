Imports Microsoft.VisualBasic.ApplicationServices

Public Class Dashboard
    Private currentUserId As String
    Private currentUserRole As String
    Public Sub New(ByVal role As String, ByVal userId As String)
        InitializeComponent()
        Me.currentUserId = userId
        Me.currentUserRole = role
    End Sub
    Private Sub FrmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AturHakAkses()

        Me.Text = "Dashboard - Login sebagai: " & currentUserRole
    End Sub
    Private Sub AturHakAkses()
        ' Gunakan Select Case untuk mengatur kontrol mana yang terlihat
        Select Case currentUserRole
            Case "Admin"
                ' Admin bisa melihat semuanya
                UserToolStripMenuItem.Visible = True
                PenciptaToolStripMenuItem.Visible = True
                LMKToolStripMenuItem.Visible = True
                LaguToolStripMenuItem.Visible = True
                OutletToolStripMenuItem.Visible = True
                PenerimaanToolStripMenuItem.Visible = True
                DistribusiToolStripMenuItem.Visible = True
                LaporanToolStripMenuItem.Visible = True

            Case "Staf Keuangan"
                ' Staf Keuangan hanya bisa mengakses fitur terkait keuangan
                UserToolStripMenuItem.Visible = False
                PenciptaToolStripMenuItem.Visible = False
                LMKToolStripMenuItem.Visible = False
                LaguToolStripMenuItem.Visible = False
                OutletToolStripMenuItem.Visible = False
                PenerimaanToolStripMenuItem.Visible = True
                DistribusiToolStripMenuItem.Visible = True
                LaporanToolStripMenuItem.Visible = True

            Case "Staf Data"
                ' Staf Data hanya bisa mengelola data master
                UserToolStripMenuItem.Visible = False
                PenciptaToolStripMenuItem.Visible = True
                LMKToolStripMenuItem.Visible = True
                LaguToolStripMenuItem.Visible = True
                OutletToolStripMenuItem.Visible = True
                PenerimaanToolStripMenuItem.Visible = False
                DistribusiToolStripMenuItem.Visible = False
                LaporanToolStripMenuItem.Visible = True

            Case Else
                ' Jika role tidak dikenal, sembunyikan semua untuk keamanan
                MsgBox("Role tidak dikenali. Tidak ada fitur yang dapat diakses.", MsgBoxStyle.Critical)
                UserToolStripMenuItem.Visible = False
                PenciptaToolStripMenuItem.Visible = False
                LMKToolStripMenuItem.Visible = False
                LaguToolStripMenuItem.Visible = False
                OutletToolStripMenuItem.Visible = False
                PenerimaanToolStripMenuItem.Visible = False
                DistribusiToolStripMenuItem.Visible = False
                LaporanToolStripMenuItem.Visible = False
        End Select
    End Sub
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub UserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserToolStripMenuItem.Click
        Dim frm As New User()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PenciptaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenciptaToolStripMenuItem.Click
        Dim frm As New Pencipta()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub LMKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LMKToolStripMenuItem.Click
        Dim frm As New LMK()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub LaguToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaguToolStripMenuItem.Click
        Dim frm As New Lagu()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub OutletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OutletToolStripMenuItem.Click
        Dim frm As New Outlet()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PenerimaanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenerimaanToolStripMenuItem.Click
        Dim frm As New Penerimaan(currentUserId)
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DistribusiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DistribusiToolStripMenuItem.Click
        Dim frm As New Distribusi()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub LaporanDistribusiToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LaporanDistribusiToolStripMenuItem1.Click
        Dim frm As New Laporan()
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class