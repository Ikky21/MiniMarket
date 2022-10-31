Public Class Form_Suplier
    Sub Tampil()
        txtnamasuplier.Text = ""
        txtnohp.Text = ""
        txtalamat.Text = ""

        txtidsuplier.Enabled = False
        txtnamasuplier.Enabled = False
        txtnohp.Enabled = False
        txtalamat.Enabled = False

        btntambah.Enabled = True
        btntambah.Text = "Tambah"
        btnUpdate.Enabled = True
        btnUpdate.Text = "Update"
        BtnHapus.Enabled = True
        BtnHapus.Text = "Hapus"
        btnkeluar.Text = "X"
    End Sub
    Sub Hidup()
        txtidsuplier.Enabled = True
        txtnamasuplier.Enabled = True
        txtnohp.Enabled = True
        txtalamat.Enabled = True
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Form_Suplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnLanjut.Click
        Form_Barang.Show()
        Me.Hide()
    End Sub

    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        Me.Close()
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        If btntambah.Text = "Tambah" Then
            btntambah.Text = "Simpan"
            btnUpdate.Enabled = False
            BtnHapus.Enabled = False
            btnkeluar.Text = "X"
            Call Hidup()
            txtidsuplier.Focus()
        Else
            If txtidsuplier.Text = "" Or txtnamasuplier.Text = "" Or txtnohp.Text = "" Or txtalamat.Text = "" Then
                MsgBox("Pastikan Semua Sudah Terisi")
            Else
                Try
                    MsgBox("Data Berhasil diinput", MsgBoxStyle.MsgBoxRight, "pesan")
                    Call Tampil()
                Catch ex As Exception
                    MsgBox("Data Gagal Disimpan...... Periksa Koneksi Ada!", MsgBoxStyle.MsgBoxRight, "Pesan")
                End Try
            End If
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If btnUpdate.Text = "Update" Then
            btnUpdate.Text = "Ubah"
            btntambah.Enabled = False
            BtnHapus.Enabled = False
            btnkeluar.Text = "X"
            Call Hidup()
            txtnamasuplier.Focus()
        Else
            If txtidsuplier.Text = "" Or txtnamasuplier.Text = "" Or txtnohp.Text = "" Or txtalamat.Text = "" Then
                MsgBox("Pastikan Semua Sudah Terisi")
            Else
                Try
                    MsgBox("Data Berhasil diupdate", MsgBoxStyle.MsgBoxRight, "Pesan")
                    Call Tampil()
                Catch ex As Exception
                    MsgBox("Data Gagal Disimpan...... Periksa Koneksi Ada!", MsgBoxStyle.MsgBoxRight, "Pesan")
                End Try
            End If
        End If
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If BtnHapus.Text = "Hapus" Then
            BtnHapus.Text = "Hapus"
            btntambah.Enabled = False
            btnUpdate.Enabled = False
            btnkeluar.Text = "X"
            Call Hidup()
            txtnamasuplier.Focus()
        Else
            If txtidsuplier.Text = "" Or txtnamasuplier.Text = "" Or txtnohp.Text = "" Or txtalamat.Text = "" Then
                MsgBox("Pastikan Semua Sudah Terisi")
            Else
                Try
                    MsgBox("Data Berhasil Dihapus", MsgBoxStyle.MsgBoxRight, "pesan")
                    Call Tampil()
                Catch ex As Exception
                    MsgBox("Data Gagal Disimpan...... Periksa Koneksi Ada!", MsgBoxStyle.MsgBoxRight, "Pesan")
                End Try
            End If
        End If
    End Sub

    Private Sub DgSuplier_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgSuplier.CellContentClick
        If DgSuplier.RowCount > 0 Then
            Dim i As Integer
            With DgSuplier
                i = .CurrentRow.Index
                txtidsuplier.Text = DgSuplier.Item(0, i).Value
                txtnamasuplier.Text = DgSuplier.Item(1, i).Value
                txtnohp.Text = DgSuplier.Item(2, i).Value
                txtalamat.Text = DgSuplier.Item(3, i).Value
                txtnamasuplier.Focus()
            End With
        End If
    End Sub
End Class