Public Class MainForm
    Sub Terkunci()
        Login.Enabled = True
        LogOut.Enabled = False
        Master.Enabled = False
        Transaksi.Enabled = False
    End Sub
    Private Sub TransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Transaksi.Click
        Form_Transaksi.ShowDialog()
    End Sub

    Private Sub BarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Barang.Click
        Form_Barang.ShowDialog()
    End Sub

    Private Sub PembeliToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Pembeli.Click
        Form_Pembeli.ShowDialog()
    End Sub

    Private Sub PetugasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Petugas.Click
        Form_Petugas.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitTS.Click
        End
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Terkunci()
    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        Form_Login.ShowDialog()
    End Sub

    Private Sub LogOut_Click(sender As Object, e As EventArgs) Handles LogOut.Click
        Call Terkunci()
    End Sub
End Class