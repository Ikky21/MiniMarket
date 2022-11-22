Imports MySql.Data.MySqlClient
Public Class Form_Barang
    Sub Tampil()
        Call OpenConn()
        Call KodeOtomatis()
        Da = New MySqlDataAdapter("select * from tblbarang", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tblbarang")
        DgBarang.DataSource = Ds.Tables("tblbarang")

        txtNamaBarang.Text = ""
        txtStok.Text = ""
        txtHarga.Text = ""

        txtNoBarang.Enabled = False
        txtNamaBarang.Enabled = False
        txtStok.Enabled = False
        txtHarga.Enabled = False

        BtnTambah.Text = "Tambah"
        BtnUpdate.Enabled = True
        BtnUpdate.Text = "Update"
        btnHapus.Enabled = True
        btnHapus.Text = "Hapus"
    End Sub
    Sub Hidup()
        txtNamaBarang.Enabled = True
        txtStok.Enabled = True
        txtHarga.Enabled = True
    End Sub
    Sub KodeOtomatis()
        Call OpenConn()
        Cmd = New MySqlCommand("select * from tblbarang where id_barang in (select max(id_barang) from tblbarang) ", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows = 0 Then
            txtNoBarang.Text = "BRG001"
            Rd.Close()
        End If
        If Not Rd.HasRows Then
            txtNoBarang.Text = "BRG" + "001"
            Rd.Close()
        Else
            txtNoBarang.Text = Microsoft.VisualBasic.Mid(Rd.Item("id_barang").ToString, 4, 3) + 1
            If Len(txtNoBarang.Text) = 1 Then
                txtNoBarang.Text = "BRG00" & txtNoBarang.Text & ""
            ElseIf Len(txtNoBarang.Text) = 2 Then
                txtNoBarang.Text = "BRG0" & txtNoBarang.Text & ""
            ElseIf Len(txtNoBarang.Text) = 3 Then
                txtNoBarang.Text = "BRG" & txtNoBarang.Text & ""
            End If
            Rd.Close()
        End If
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
            If txtNoBarang.Text = "" Or txtNamaBarang.Text = "" Or txtHarga.Text = "" Or txtStok.Text = "" Then
                MsgBox("Pastikan Semua Sudah Terisi")
            Else
                Try
                    Call OpenConn()
                    Dim InputData As String = "Insert into tblbarang values ( '" & txtNoBarang.Text & "','" & txtNamaBarang.Text & "','" & txtHarga.Text & "','" & txtStok.Text & "')"
                    Cmd = New MySqlCommand(InputData, Conn)
                    Cmd.ExecuteNonQuery()
                    MsgBox("Data Berhasil ditambah", MsgBoxStyle.MsgBoxRight, "pesan")
                    Call Tampil()
                Catch ex As Exception
                    MsgBox("Data Gagal Disimpan...... Mohon Periksa Kembali!", MsgBoxStyle.MsgBoxRight, "Warning!!")
                End Try
            End If
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If BtnUpdate.Text = "Update" Then
            BtnUpdate.Text = "Ubah"
            BtnTambah.Enabled = False
            btnHapus.Enabled = False
            BtnKeluar.Text = "X"
            Call Hidup()
            txtNamaBarang.Focus()
        Else
            If txtNoBarang.Text = "" Or txtNamaBarang.Text = "" Or txtHarga.Text = "" Or txtStok.Text = "" Then
                MsgBox("Pastikan Semua Sudah Terisi")
            Else
                Try
                    Call OpenConn()
                    Dim InputData As String = "update tblbarang Set nama_barang= '" & txtNamaBarang.Text & "',stok='" & txtHarga.Text & "', harga= '" & txtStok.Text & "' Where barang= '" & txtNoBarang.Text & "'"
                    Cmd = New MySqlCommand(InputData, Conn)
                    Cmd.ExecuteNonQuery()
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
            If txtNoBarang.Text = "" Or txtNamaBarang.Text = "" Or txtHarga.Text = "" Or txtStok.Text = "" Then
                MsgBox("Pastikan Semua Sudah Terisi")
            Else
                Try
                    Call OpenConn()
                    Dim InputData As String = "delete from tblbarang Where id_barang='" & txtNoBarang.Text & "'"
                    Cmd = New MySqlCommand(InputData, Conn)
                    Cmd.ExecuteNonQuery()
                    MsgBox("Data Berhasil Dihapus", MsgBoxStyle.MsgBoxRight, "pesan")
                    Call Tampil()
                Catch ex As Exception
                    MsgBox("Data Gagal Disimpan...... Periksa Koneksi Ada!", MsgBoxStyle.MsgBoxRight, "Pesan")
                End Try
            End If
        End If
    End Sub

    Private Sub DgBarang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgBarang.CellContentClick
        If DgBarang.RowCount > 0 Then
            Dim i As Integer
            With DgBarang
                i = .CurrentRow.Index
                txtNoBarang.Text = .Item(0, i).Value
                txtNamaBarang.Text = .Item(1, i).Value
                txtStok.Text = .Item(2, i).Value
                txtHarga.Text = .Item(3, i).Value
                txtNamaBarang.Focus()
            End With
        End If
    End Sub
End Class