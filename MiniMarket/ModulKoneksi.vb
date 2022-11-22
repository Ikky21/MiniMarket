Imports MySql.Data.MySqlClient
Module ModulKoneksi
    Public Conn As MySqlConnection
    Public Da As MySqlDataAdapter
    Public Rd As MySqlDataReader
    Public Ds As DataSet
    Public Cmd As MySqlCommand
    Public MyDB As String
    Sub OpenConn()
        MyDB = ("Server = Localhost; port= 3306; User Id= root;Password=;database=penjualan")
        Conn = New MySqlConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub
End Module
