<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DataMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenciptaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LMKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaguToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutletToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenerimaanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DistribusiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanDistribusiToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataMasterToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DataMasterToolStripMenuItem
        '
        Me.DataMasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripMenuItem, Me.PenciptaToolStripMenuItem, Me.LMKToolStripMenuItem, Me.LaguToolStripMenuItem, Me.OutletToolStripMenuItem})
        Me.DataMasterToolStripMenuItem.Name = "DataMasterToolStripMenuItem"
        Me.DataMasterToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.DataMasterToolStripMenuItem.Text = "Data Master"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'PenciptaToolStripMenuItem
        '
        Me.PenciptaToolStripMenuItem.Name = "PenciptaToolStripMenuItem"
        Me.PenciptaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PenciptaToolStripMenuItem.Text = "Pencipta"
        '
        'LMKToolStripMenuItem
        '
        Me.LMKToolStripMenuItem.Name = "LMKToolStripMenuItem"
        Me.LMKToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LMKToolStripMenuItem.Text = "LMK"
        '
        'LaguToolStripMenuItem
        '
        Me.LaguToolStripMenuItem.Name = "LaguToolStripMenuItem"
        Me.LaguToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LaguToolStripMenuItem.Text = "Lagu"
        '
        'OutletToolStripMenuItem
        '
        Me.OutletToolStripMenuItem.Name = "OutletToolStripMenuItem"
        Me.OutletToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OutletToolStripMenuItem.Text = "Outlet"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenerimaanToolStripMenuItem, Me.DistribusiToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'PenerimaanToolStripMenuItem
        '
        Me.PenerimaanToolStripMenuItem.Name = "PenerimaanToolStripMenuItem"
        Me.PenerimaanToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.PenerimaanToolStripMenuItem.Text = "Penerimaan Pembayaran Royalti "
        '
        'DistribusiToolStripMenuItem
        '
        Me.DistribusiToolStripMenuItem.Name = "DistribusiToolStripMenuItem"
        Me.DistribusiToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.DistribusiToolStripMenuItem.Text = "Distribusi Royalti"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanDistribusiToolStripMenuItem1})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LaporanDistribusiToolStripMenuItem1
        '
        Me.LaporanDistribusiToolStripMenuItem1.Name = "LaporanDistribusiToolStripMenuItem1"
        Me.LaporanDistribusiToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.LaporanDistribusiToolStripMenuItem1.Text = "Distribusi Royalti"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Dashboard"
        Me.Text = "FrmDashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DataMasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenciptaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LMKToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaguToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OutletToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenerimaanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DistribusiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanDistribusiToolStripMenuItem1 As ToolStripMenuItem
End Class
