Public Class Form_Barang
    Sub Tampil()



        txtNamaBarang.Text = ""
        txtStok.Text = ""
        txtHarga.Text = ""
        txtIdSuplier.Text = ""

        txtNoBarang.Enabled = False
        txtNamaBarang.Enabled = False
        txtStok.Enabled = False
        txtHarga.Enabled = False
        txtIdSuplier.Enabled = False

        BtnTambah.Text = "Tambah"
        BtnUpdate.Enabled = True
        BtnUpdate.Text = "Update"
        btnHapus.Enabled = True
        btnHapus.Text = "Hapus"
        BtnKeluar.Text = "X"
    End Sub
    Sub Hidup()
        txtNamaBarang.Enabled = True
        txtStok.Enabled = True
        txtHarga.Enabled = True
        txtIdSuplier.Enabled = True
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Me.Close()
    End Sub

    Private Sub Form_Barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Tampil()
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        If BtnTambah.Text = "Tambah" Then
            BtnTambah.Text = "Simpan"
            BtnUpdate.Enabled = False
            btnHapus.Enabled = False
            BtnKeluar.Text = "X"
            Call Hidup()
            txtNamaBarang.Focus()
        Else
            If txtNoBarang.Text = "" Or txtNamaBarang.Text = "" Or txtHarga.Text = "" Or txtStok.Text = "" Or txtIdSuplier.Text = "" Then
                MsgBox("Pastikan Semua Sudah Terisi")
            Else
                Try
                    MsgBox("Data Berhasil ditambah", MsgBoxStyle.MsgBoxRight, "pesan")
                    Call Tampil()
                Catch ex As Exception
                    MsgBox("Data Gagal Disimpan...... Mohon Periksa Kembali!", MsgBoxStyle.MsgBoxRight, "Pesan")
                End Try
            End If
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If BtnUpdate.Text = "UPpdate" Then
            BtnUpdate.Text = "Ubah"
            BtnTambah.Enabled = False
            btnHapus.Enabled = False
            BtnKeluar.Text = "X"
            Call Hidup()
            txtNamaBarang.Focus()
        Else
            If txtNoBarang.Text = "" Or txtNamaBarang.Text = "" Or txtHarga.Text = "" Or txtStok.Text = "" Or txtIdSuplier.Text = "" Then
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

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If btnHapus.Text = "Hapus" Then
            btnHapus.Text = "Hapus"
            BtnTambah.Enabled = False
            BtnUpdate.Enabled = False
            BtnKeluar.Text = "X"
            Call Hidup()
            txtNamaBarang.Focus()
        Else
            If txtNoBarang.Text = "" Or txtNamaBarang.Text = "" Or txtHarga.Text = "" Or txtStok.Text = "" Or txtIdSuplier.Text = "" Then
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
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgBarang.CellContentClick
        If DgBarang.RowCount > 0 Then
            Dim i As Integer
            With DgBarang
                i = .CurrentRow.Index
                txtNoBarang.Text = .Item(0, i).Value
                txtNamaBarang.Text = .Item(1, i).Value
                txtStok.Text = .Item(2, i).Value
                txtHarga.Text = .Item(3, i).Value
                txtIdSuplier.Text = .Item(4, i).Value
                txtNamaBarang.Focus()
            End With
        End If
    End Sub
End Class