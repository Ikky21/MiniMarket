Imports MySql.Data.MySqlClient
Public Class Form_Pembeli
    Sub Tampil()
        Call OpenConn()

        Da = New MySqlDataAdapter("select * from tblpembeli", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tblpembeli")
        Dgpembeli.DataSource = Ds.Tables("tblPembeli")

        txtNamaPembeli.Text = ""
        txtNoHp.Text = ""
        txtAlamatPembeli.Text = ""

        txtNoPembeli.Enabled = False
        txtAlamatPembeli.Enabled = False
        txtNoHp.Enabled = False


        btntambah.Text = "Tambah"
        btnupdate.Enabled = True
        btnupdate.Text = "Update"
        btnhapus.Enabled = True
        btnhapus.Text = "Hapus"
    End Sub

    Sub Hidup()
        txtNamaPembeli.Enabled = True
        txtAlamatPembeli.Enabled = True
        txtNoHp.Enabled = True

    End Sub

    Sub KodeOtomatis()
        Call OpenConn()
        Cmd = New MySqlCommand("select * from tblpemeli where id_pembeli in (select max(id_pembeli) from tblpembeli) ", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows = 0 Then
            txtNoPembeli.Text = "PBI001"
            Rd.Close()
        End If
        If Not Rd.HasRows Then
            txtNoPembeli.Text = "PBI" + "001"
            Rd.Close()
        Else
            txtNoPembeli.Text = Microsoft.VisualBasic.Mid(Rd.Item("id_pembeli").ToString, 4, 3) + 1
            If Len(txtNoPembeli.Text) = 1 Then
                txtNoPembeli.Text = "PBI00" & txtNoPembeli.Text & ""
            ElseIf Len(txtNopembeli.Text) = 2 Then
                txtNoPembeli.Text = "PBI0" & txtNoPembeli.Text & ""
            ElseIf Len(txtNoPembeli.Text) = 3 Then
                txtNoPembeli.Text = "PBI" & txtNoPembeli.Text & ""
            End If
            Rd.Close()
        End If
    End Sub

    Private Sub Form_Pembeli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Tampil() 'KOMRNYST
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        If btntambah.Text = "Tambah" Then
            btntambah.Text = "Simpan"
            btnupdate.Enabled = False
            btnhapus.Enabled = False
            Label6.Text = "X"
            Call Hidup()
            txtNamaPembeli.Focus()
        Else
            If txtNoPembeli.Text = "" Or txtNamaPembeli.Text = "" Or txtAlamatPembeli.Text = "" Or txtNoHp.Text = "" Then
                MsgBox("Pastikan Semua Sudah Terisi")
            Else
                Try
                    Call OpenConn()
                    Dim InputData As String = "Insert into tblpembeli values ( '" & txtNoPembeli.Text & "','" & txtNamaPembeli.Text & "','" & txtAlamatPembeli.Text & "','" & txtNoHp.Text & "')"
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

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Close()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If btnupdate.Text = "Update" Then
            btnupdate.Text = "Ubah"
            btntambah.Enabled = False
            btnhapus.Enabled = False
            Label6.Text = "X"
            Call Hidup()
            txtNamaPembeli.Focus()
        Else
            If txtNoPembeli.Text = "" Or txtNamaPembeli.Text = "" Or txtAlamatPembeli.Text = "" Or txtNoHp.Text = "" Then
                MsgBox("Pastikan Semua Sudah Terisi")
            Else
                Try
                    Call OpenConn()
                    Dim InputData As String = "update tblPembeli Set nama_pembeli= '" & txtNamaPembeli.Text & "',alamat='" & txtAlamatPembeli.Text & "', no_hp= '" & txtNoHp.Text & "' Where tblpembeli= '" & txtNoPembeli.Text & "'"
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

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If btnhapus.Text = "Hapus" Then
            btnhapus.Text = "Hapus"
            btntambah.Enabled = False
            btnupdate.Enabled = False
            Label6.Text = "X"
            Call Hidup()
            txtNamaPembeli.Focus()
        Else
            If txtNoPembeli.Text = "" Or txtNamaPembeli.Text = "" Or txtAlamatPembeli.Text = "" Or txtNoHp.Text = "" Then
                MsgBox("Pastikan Semua Sudah Terisi")
            Else
                Try
                    Call OpenConn()
                    Dim InputData As String = "delete from tblpembeli Where id_bpembeli='" & txtNoPembeli.Text & "'"
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

    Private Sub Dgpembeli_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgpembeli.CellContentClick
        If Dgpembeli.RowCount > 0 Then
            Dim i As Integer
            With Dgpembeli
                i = .CurrentRow.Index
                txtNoPembeli.Text = .Item(0, i).Value
                txtNamaPembeli.Text = .Item(1, i).Value
                txtAlamatPembeli.Text = .Item(2, i).Value
                txtNoHp.Text = .Item(3, i).Value
                txtNamaPembeli.Focus()
            End With
        End If
    End Sub
End Class