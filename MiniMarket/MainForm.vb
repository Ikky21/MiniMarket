Public Class MainForm
    Private Sub TransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiToolStripMenuItem.Click
        Form_Transaksi.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        End
    End Sub

    Private Sub BarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangToolStripMenuItem.Click
        Form_Barang.Show()
    End Sub

    Private Sub SuplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuplierToolStripMenuItem.Click
        Form_Suplier.Show()
    End Sub
End Class