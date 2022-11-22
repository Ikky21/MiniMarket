Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic
Imports System.Windows

Public Class Form_Transaksi
    Sub Kosong()
        Call NoOtomatis()
        Call NamaBarang()
        Call IdPembeli()
        CbIdPembeli.Text = ""
        LblNama.Text = ""
        LblAlamat.Text = ""
        LblNoHp.Text = ""
        TxtTotHarga.Text = ""
        TxtTotJmlh.Text = ""
        TxtSub.Text = ""
        TxtBayar.Text = ""
        TxtKembalian.Text = ""
        DgvBarang.Columns.Clear()
    End Sub
    Sub NoOtomatis()
        Call OpenConn()
        Cmd = New MySqlCommand("select id_transaksi from tbltransaksi order by id_transaksi desc", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows = True Then
            LblIdTR.Text = "TR" + Format(Today, "yyMMdd") + "01"
        Else
            If Microsoft.VisualBasic.Mid(Rd.Item("id_transaksi"), 3, 6) = Format(Today, "yyMMdd") Then
                LblIdTR.Text = "TR" + Format(Microsoft.VisualBasic.Right(Rd.Item("id_transaksi"), 8) + 1, "00")
            Else
                LblIdTR.Text = "TR" + Format(Today, "yyMMdd") + "01"
            End If
        End If
    End Sub
    Sub BuatKolom()
        DgvBarang.Columns.Clear()
        DgvBarang.Columns.Add("id", "ID BARANG")
        DgvBarang.Columns.Add("nama", "NAMA BARANG")
        DgvBarang.Columns.Add("harga", "HARGA")
        DgvBarang.Columns.Add("jmlh", "JUMLAH")
    End Sub
    Sub NamaBarang()
        Call OpenConn()
        CbNamaBarang.Items.Clear()
        Cmd = New MySqlCommand("select * from tblbarang", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            CbNamaBarang.Items.Add(Rd.Item(1))
        Loop
    End Sub
    Sub IdPembeli()
        Call OpenConn()
        CbIdPembeli.Items.Clear()
        Cmd = New MySqlCommand("select * from tblpembeli", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            CbIdPembeli.Items.Add(Rd.Item(0))
        Loop
    End Sub


    Private Sub Form_Transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call BuatKolom()
        Call Kosong()
        LblTgl.Text = Today
        Call OpenConn()
        Call NoOtomatis()
        LblIdPetugas.Text = Form_Login.TxtID.Text
    End Sub

    Private Sub CbNamaBarang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbNamaBarang.SelectedIndexChanged
        Call OpenConn()
        Cmd = New MySqlCommand("Select * from tblbarang where nama_barang='" & CbNamaBarang.Text & "'", Conn)
        Rd = Cmd.ExecuteReader()
        Rd.Read()
        If Not Rd.HasRows Then
            MsgBox("Data tidak ada")
        Else
            TxtIdBarang.Text = Rd.Item("id_barang")
            TxtHarga.Text = Rd.Item("harga_barang")
            TxtJmlh.Text = True
            TxtJmlh.Text = "1"
        End If
    End Sub

    Private Sub CbIdPembeli_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbIdPembeli.SelectedIndexChanged
        Call OpenConn()
        Cmd = New MySqlCommand("Select * from tblpembeli where id_pembeli='" & CbIdPembeli.Text & "'", Conn)
        Rd = Cmd.ExecuteReader()
        Rd.Read()
        If Not Rd.HasRows Then
            MsgBox("Data tidak ada")
        Else
            LblNama.Text = Rd.Item("nama_pembeli")
            LblAlamat.Text = Rd.Item("alamat")
            LblNoHp.Text = Rd.Item("no_hp")
        End If
        Call BuatKolom()
    End Sub
    Private Sub TMTR_Tick(sender As Object, e As EventArgs) Handles TMTR.Tick
        LblJam.Text = TimeOfDay
    End Sub

    Private Sub BtnInput_Click(sender As Object, e As EventArgs) Handles BtnInput.Click
        DgvBarang.Rows.Add(New String() {TxtIdBarang.Text, CbNamaBarang.Text, TxtHarga.Text, TxtJmlh.Text})
        TxtIdBarang.Text = ""
        CbNamaBarang.Text = ""
        TxtHarga.Text = ""
        TxtJmlh.Text = ""
        Dim sum As Decimal = 0
        For i = 0 To DgvBarang.Rows.Count - 1
            sum += DgvBarang.Rows(i).Cells(2).Value
        Next
        TxtTotHarga.Text = sum
        Dim Plus As Decimal = 0
        For i = 0 To DgvBarang.Rows.Count - 1
            Plus += DgvBarang.Rows(i).Cells(3).Value
        Next
        TxtTotJmlh.Text = Plus
        Dim a As String
        a = TxtTotHarga.Text * TxtTotJmlh.Text
        TxtSub.Text = a

    End Sub
    Private Sub TxtBayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBayar.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(TxtBayar.Text) < Val(TxtSub.Text) Then
                MsgBox("Pembayaran Kurang")
                TxtBayar.Focus()
            ElseIf Val(TxtBayar.Text) = Val(TxtSub.Text) Then
                TxtKembalian.Text = 0
            Else
                TxtKembalian.Text = Val(TxtBayar.Text) - Val(TxtSub.Text)
                TxtKembalian.Text = TxtKembalian.Text
            End If
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If CbIdPembeli.Text = "" Or TxtBayar.Text = "" Then
            MsgBox("Transaksi Tidak Ada, Silahkan lakukan Transaksi Terlebih Dahulu !!!", MsgBoxStyle.Information, "WARNING")
        Else
            Call OpenConn()
            Dim tglmysql As String = Format(Today, "yyyy-MM-dd")
            Dim SimpanTransaksi As String = "Insert into tbltransaksi values ('" & LblIdTR.Text & "', '" & tglmysql & "', '" & CbIdPembeli.Text & "', '" & TxtTotJmlh.Text & "','" & TxtSub.Text & "','" & TxtBayar.Text & "','" & TxtKembalian.Text & "','" & LblIdPetugas.Text & "')"
            Cmd = New MySqlCommand(SimpanTransaksi, Conn)
            Cmd.ExecuteNonQuery()
            Try
                For Baris As Integer = 0 To DgvBarang.Rows.Count - 1
                    Call OpenConn()
                    Dim SimpanDetailTransaksi As String = "Insert into detailtransaksi values ('" & LblIdTR.Text & "', '" & DgvBarang.Rows(Baris).Cells(0).Value & "', '" & DgvBarang.Rows(Baris).Cells(3).Value & "')"
                    Cmd = New MySqlCommand(SimpanDetailTransaksi, Conn)
                    Cmd.ExecuteNonQuery()
                    Cmd = New MySqlCommand("select * from tblbarang where id_barang = '" & DgvBarang.Rows(Baris).Cells(0).Value & "'", Conn)
                    Cmd.ExecuteReader()
                    Call OpenConn()
                    Dim KurangiStok As String = "update tblbarang set stok_barang = '" & Rd.Item("stok_barang") - DgvBarang.Rows(Baris).Cells(3).Value & "' where id_barang = '" & DgvBarang.Rows(Baris).Cells(0).Value & "'"
                    Cmd = New MySqlCommand(KurangiStok, Conn)
                    Cmd.ExecuteNonQuery()
                Next
                MsgBox("Transaksi Telah Berhasil Disimpan")
                Call Kosong()
            Catch ex As Exception
                MsgBox("Transaksi Gagal Disimpan, Coba Priksa Koneksi!!", MsgBoxStyle.Information, "WARNING")
            End Try

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub DgvBarang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvBarang.CellContentClick

    End Sub
End Class