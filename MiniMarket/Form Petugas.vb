Imports MySql.Data.MySqlClient
Public Class Form_Petugas
    Sub Tampil()
        Call OpenConn()

        Da = New MySqlDataAdapter("select * from tblpetugas", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tblpetugas")
        dgpetugas.DataSource = Ds.Tables("tblpetugas")

        txtnamapetugas.Text = ""
        txtpassword.Text = ""
        txtalamat.Text = ""
        txtnohp.Text = ""

        txtNoPetugas.Enabled = False
        txtnamapetugas.Enabled = False
        txtpassword.Enabled = False
        txtalamat.Text = False
        txtnohp.Enabled = False

        btntambah.Text = "Tambah"
        btnupdate.Enabled = True
        btnupdate.Text = "Update"
        btnhapus.Enabled = True
        btnhapus.Text = "Hapus"
    End Sub
    Sub Hidup()
        txtnamapetugas.Enabled = True
        txtpassword.Enabled = True
        txtalamat.Enabled = True
        txtnohp.Enabled = True
    End Sub
    Sub KodeOtomatis()
        Call OpenConn()
        Cmd = New MySqlCommand("select * from tblpetugas where id_petugas in (select max(id_petugas) from tblpetugas) ", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows = 0 Then
            txtNoPetugas.Text = "BRG001"
            Rd.Close()
        End If
        If Not Rd.HasRows Then
            txtNoPetugas.Text = "BRG" + "001"
            Rd.Close()
        Else
            txtNoPetugas.Text = Microsoft.VisualBasic.Mid(Rd.Item("id_petugas").ToString, 4, 3) + 1
            If Len(txtNoPetugas.Text) = 1 Then
                txtNoPetugas.Text = "PTG00" & txtNoPetugas.Text & ""
            ElseIf Len(txtNopetugas.Text) = 2 Then
                txtNoPetugas.Text = "PTG0" & txtNoPetugas.Text & ""
            ElseIf Len(txtNopetugas.Text) = 3 Then
                txtNoPetugas.Text = "PTG" & txtNoPetugas.Text & ""
            End If
            Rd.Close()
        End If
    End Sub
    Private Sub Form_Petugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Tampil()
    End Sub

    Private Sub Keluar_Click(sender As Object, e As EventArgs) Handles Keluar.Click
        Me.Close()
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        If btntambah.Text = "Tambah" Then
            btntambah.Text = "Simpan"
            btnupdate.Enabled = False
            btnhapus.Enabled = False
            Keluar.Text = "X"
            Call Hidup()
            txtnamapetugas.Focus()
        Else
            If txtNoPetugas.Text = "" Or txtnamapetugas.Text = "" Or txtpassword.Text = "" Or txtalamat.Text = "" Or txtnohp.Text = "" Then
                MsgBox("Pastikan Semua Sudah Terisi")
            Else
                Try
                    Call OpenConn()
                    Dim InputData As String = "Insert into tblpetugas values ( '" & txtNoPetugas.Text & "','" & txtnamapetugas.Text & "','" & txtpassword.Text & "','" & txtalamat.Text & "','" & txtnohp.Text & "')"
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

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If btnupdate.Text = "Update" Then
            btnupdate.Text = "Ubah"
            btntambah.Enabled = False
            btnhapus.Enabled = False
            Keluar.Text = "X"
            Call Hidup()
            txtnamapetugas.Focus()
        Else
            If txtNoPetugas.Text = "" Or txtnamapetugas.Text = "" Or txtpassword.Text = "" Or txtalamat.Text = "" Or txtnohp.Text = "" Then
                MsgBox("Pastikan Semua Sudah Terisi")
            Else
                Try
                    Call OpenConn()
                    Dim InputData As String = "update tblpetugas Set nama_petugas= '" & txtnamapetugas.Text & "',password='" & txtpassword.Text & "',alamat_petugas='" & txtalamat.Text & "', no_hp= '" & txtnohp.Text & "' Where tblpembeli= '" & txtNoPetugas.Text & "'"
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
            Keluar.Text = "X"
            Call Hidup()
            txtnamapetugas.Focus()
        Else
            If txtNoPetugas.Text = "" Or txtnamapetugas.Text = "" Or txtpassword.Text = "" Or txtalamat.Text = "" Or txtnohp.Text = "" Then
                MsgBox("Pastikan Semua Sudah Terisi")
            Else
                Try
                    Call OpenConn()
                    Dim InputData As String = "delete from tblpembeli Where id_petugas='" & txtNoPetugas.Text & "'"
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

    Private Sub dgpetugas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgpetugas.CellContentClick
        If dgpetugas.RowCount > 0 Then
            Dim i As Integer
            With dgpetugas
                i = .CurrentRow.Index
                txtNoPetugas.Text = .Item(0, i).Value
                txtnamapetugas.Text = .Item(1, i).Value
                txtpassword.Text = .Item(2, i).Value
                txtalamat.Text = .Item(3, i).Value
                txtnohp.Text = .Item(4, i).Value
                txtnamapetugas.Focus()
            End With
        End If
    End Sub
End Class