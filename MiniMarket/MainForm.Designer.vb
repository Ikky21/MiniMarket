<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Login = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.LogOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitTS = New System.Windows.Forms.ToolStripMenuItem()
        Me.Master = New System.Windows.Forms.ToolStripMenuItem()
        Me.Barang = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pembeli = New System.Windows.Forms.ToolStripMenuItem()
        Me.Petugas = New System.Windows.Forms.ToolStripMenuItem()
        Me.Transaksi = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.Master, Me.Transaksi})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(753, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Login, Me.ToolStripMenuItem1, Me.LogOut, Me.ToolStripMenuItem2, Me.ExitTS})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'Login
        '
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(180, 22)
        Me.Login.Text = "Login"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(177, 6)
        '
        'LogOut
        '
        Me.LogOut.Name = "LogOut"
        Me.LogOut.Size = New System.Drawing.Size(180, 22)
        Me.LogOut.Text = "LogOut"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(177, 6)
        '
        'ExitTS
        '
        Me.ExitTS.Name = "ExitTS"
        Me.ExitTS.Size = New System.Drawing.Size(180, 22)
        Me.ExitTS.Text = "Exit"
        '
        'Master
        '
        Me.Master.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Barang, Me.Pembeli, Me.Petugas})
        Me.Master.Name = "Master"
        Me.Master.Size = New System.Drawing.Size(55, 20)
        Me.Master.Text = "Master"
        '
        'Barang
        '
        Me.Barang.Name = "Barang"
        Me.Barang.Size = New System.Drawing.Size(117, 22)
        Me.Barang.Text = "Barang"
        '
        'Pembeli
        '
        Me.Pembeli.Name = "Pembeli"
        Me.Pembeli.Size = New System.Drawing.Size(117, 22)
        Me.Pembeli.Text = "Pembeli"
        '
        'Petugas
        '
        Me.Petugas.Name = "Petugas"
        Me.Petugas.Size = New System.Drawing.Size(117, 22)
        Me.Petugas.Text = "petugas"
        '
        'Transaksi
        '
        Me.Transaksi.Name = "Transaksi"
        Me.Transaksi.Size = New System.Drawing.Size(66, 20)
        Me.Transaksi.Text = "Transaksi"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 481)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Master As ToolStripMenuItem
    Friend WithEvents Barang As ToolStripMenuItem
    Friend WithEvents Transaksi As ToolStripMenuItem
    Friend WithEvents Pembeli As ToolStripMenuItem
    Friend WithEvents Petugas As ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Login As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents LogOut As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents ExitTS As ToolStripMenuItem
End Class
