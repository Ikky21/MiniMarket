Imports MySql.Data.MySqlClient
Imports System.Windows

Public Class Form_Login
    Sub Terbuka()
        MainForm.Login.Enabled = False
        MainForm.LogOut.Enabled = True
        MainForm.Master.Enabled = True
        MainForm.Transaksi.Enabled = True
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TxtID.Text = "" Or TxtPass.Text = "" Then
            MsgBox("Kode Petugas Atau Password Tidak Boleh Kosong !!!", MsgBoxStyle.Exclamation, "WARNING")
            TxtID.Focus()
        Else
            Call OpenConn()
            Cmd = New MySqlCommand("select * from tblpetugas where id_petugas = '" & TxtID.Text & "' and password ='" & TxtPass.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                Me.Close()
                Call Terbuka()
            End If
        End If
    End Sub

    Private Sub BtnEX_Click(sender As Object, e As EventArgs) Handles BtnEX.Click
        Me.Close()
    End Sub
End Class