<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Transaksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Tbtgl = New System.Windows.Forms.DateTimePicker()
        Me.Tbtrbayar = New System.Windows.Forms.TextBox()
        Me.Tbtotalbayar = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Tbidpembayaran = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TbNamaPembeli = New System.Windows.Forms.TextBox()
        Me.TbJk = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbAlamatPembeli = New System.Windows.Forms.TextBox()
        Me.TbIdPembeli = New System.Windows.Forms.TextBox()
        Me.TbNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TbIdTransaksi = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Tbtgltransaksi = New System.Windows.Forms.DateTimePicker()
        Me.Tbtrpembeli = New System.Windows.Forms.TextBox()
        Me.Tbtrbarang = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TbKeterangan = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TbBarang = New System.Windows.Forms.TextBox()
        Me.TbNamabarang = New System.Windows.Forms.TextBox()
        Me.txtHargaBarang = New System.Windows.Forms.TextBox()
        Me.TbJumlahBarang = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Tbtgl)
        Me.GroupBox3.Controls.Add(Me.Tbtrbayar)
        Me.GroupBox3.Controls.Add(Me.Tbtotalbayar)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Tbidpembayaran)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(22, 225)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(252, 171)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pembayaran"
        '
        'Tbtgl
        '
        Me.Tbtgl.Location = New System.Drawing.Point(120, 58)
        Me.Tbtgl.Name = "Tbtgl"
        Me.Tbtgl.Size = New System.Drawing.Size(124, 20)
        Me.Tbtgl.TabIndex = 22
        '
        'Tbtrbayar
        '
        Me.Tbtrbayar.Location = New System.Drawing.Point(120, 132)
        Me.Tbtrbayar.Name = "Tbtrbayar"
        Me.Tbtrbayar.Size = New System.Drawing.Size(100, 20)
        Me.Tbtrbayar.TabIndex = 18
        '
        'Tbtotalbayar
        '
        Me.Tbtotalbayar.Location = New System.Drawing.Point(120, 96)
        Me.Tbtotalbayar.Name = "Tbtotalbayar"
        Me.Tbtotalbayar.Size = New System.Drawing.Size(100, 20)
        Me.Tbtotalbayar.TabIndex = 17
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(21, 139)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Id Transaksi"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(21, 103)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 13)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Total Bayar"
        '
        'Tbidpembayaran
        '
        Me.Tbidpembayaran.Location = New System.Drawing.Point(120, 22)
        Me.Tbidpembayaran.Name = "Tbidpembayaran"
        Me.Tbidpembayaran.Size = New System.Drawing.Size(100, 20)
        Me.Tbidpembayaran.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(21, 65)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Tanggal Bayar"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(21, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Id Pembayaran"
        '
        'TbNamaPembeli
        '
        Me.TbNamaPembeli.Location = New System.Drawing.Point(128, 55)
        Me.TbNamaPembeli.Name = "TbNamaPembeli"
        Me.TbNamaPembeli.Size = New System.Drawing.Size(100, 20)
        Me.TbNamaPembeli.TabIndex = 6
        '
        'TbJk
        '
        Me.TbJk.FormattingEnabled = True
        Me.TbJk.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.TbJk.Location = New System.Drawing.Point(128, 87)
        Me.TbJk.Name = "TbJk"
        Me.TbJk.Size = New System.Drawing.Size(100, 21)
        Me.TbJk.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id Pembeli"
        '
        'TbAlamatPembeli
        '
        Me.TbAlamatPembeli.Location = New System.Drawing.Point(128, 157)
        Me.TbAlamatPembeli.Name = "TbAlamatPembeli"
        Me.TbAlamatPembeli.Size = New System.Drawing.Size(100, 20)
        Me.TbAlamatPembeli.TabIndex = 9
        '
        'TbIdPembeli
        '
        Me.TbIdPembeli.Location = New System.Drawing.Point(128, 17)
        Me.TbIdPembeli.Name = "TbIdPembeli"
        Me.TbIdPembeli.Size = New System.Drawing.Size(100, 20)
        Me.TbIdPembeli.TabIndex = 1
        '
        'TbNo
        '
        Me.TbNo.Location = New System.Drawing.Point(128, 124)
        Me.TbNo.Name = "TbNo"
        Me.TbNo.Size = New System.Drawing.Size(100, 20)
        Me.TbNo.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Pembeli"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Alamat"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TbNamaPembeli)
        Me.GroupBox1.Controls.Add(Me.TbJk)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TbAlamatPembeli)
        Me.GroupBox1.Controls.Add(Me.TbIdPembeli)
        Me.GroupBox1.Controls.Add(Me.TbNo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 193)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pembeli"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "No Hp"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(690, 23)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(386, 393)
        Me.DataGridView1.TabIndex = 22
        '
        'TbIdTransaksi
        '
        Me.TbIdTransaksi.Location = New System.Drawing.Point(124, 13)
        Me.TbIdTransaksi.Name = "TbIdTransaksi"
        Me.TbIdTransaksi.Size = New System.Drawing.Size(100, 20)
        Me.TbIdTransaksi.TabIndex = 33
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Tbtgltransaksi)
        Me.GroupBox2.Controls.Add(Me.Tbtrpembeli)
        Me.GroupBox2.Controls.Add(Me.Tbtrbarang)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TbKeterangan)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TbIdTransaksi)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(307, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(349, 216)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transaksi"
        '
        'Tbtgltransaksi
        '
        Me.Tbtgltransaksi.Location = New System.Drawing.Point(124, 124)
        Me.Tbtgltransaksi.Name = "Tbtgltransaksi"
        Me.Tbtgltransaksi.Size = New System.Drawing.Size(200, 20)
        Me.Tbtgltransaksi.TabIndex = 41
        '
        'Tbtrpembeli
        '
        Me.Tbtrpembeli.Location = New System.Drawing.Point(124, 48)
        Me.Tbtrpembeli.Name = "Tbtrpembeli"
        Me.Tbtrpembeli.Size = New System.Drawing.Size(100, 20)
        Me.Tbtrpembeli.TabIndex = 40
        '
        'Tbtrbarang
        '
        Me.Tbtrbarang.Location = New System.Drawing.Point(124, 84)
        Me.Tbtrbarang.Name = "Tbtrbarang"
        Me.Tbtrbarang.Size = New System.Drawing.Size(100, 20)
        Me.Tbtrbarang.TabIndex = 38
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(25, 127)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Tanggal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Id Transaksi"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 156)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Keterangan"
        '
        'TbKeterangan
        '
        Me.TbKeterangan.Location = New System.Drawing.Point(124, 153)
        Me.TbKeterangan.Multiline = True
        Me.TbKeterangan.Name = "TbKeterangan"
        Me.TbKeterangan.Size = New System.Drawing.Size(200, 56)
        Me.TbKeterangan.TabIndex = 39
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Id Pembeli"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Id Barang"
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(22, 440)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 23)
        Me.btnTambah.TabIndex = 24
        Me.btnTambah.Text = "TAMBAH"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(112, 440)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 25
        Me.btnSimpan.Text = "SIMPAN"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(581, 371)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(75, 23)
        Me.btnTotal.TabIndex = 26
        Me.btnTotal.Text = "TOTAL"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(1066, -3)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(24, 20)
        Me.btnKeluar.TabIndex = 28
        Me.btnKeluar.Text = "X"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnCetak
        '
        Me.btnCetak.Location = New System.Drawing.Point(581, 440)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(75, 23)
        Me.btnCetak.TabIndex = 27
        Me.btnCetak.Text = "CETAK"
        Me.btnCetak.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(321, 273)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 13)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Id Barang"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(321, 308)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 13)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Nama Barang"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(321, 340)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(36, 13)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "Harga"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(321, 376)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 13)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "Jumlah"
        '
        'TbBarang
        '
        Me.TbBarang.Location = New System.Drawing.Point(431, 265)
        Me.TbBarang.Name = "TbBarang"
        Me.TbBarang.Size = New System.Drawing.Size(100, 20)
        Me.TbBarang.TabIndex = 33
        '
        'TbNamabarang
        '
        Me.TbNamabarang.Location = New System.Drawing.Point(431, 301)
        Me.TbNamabarang.Name = "TbNamabarang"
        Me.TbNamabarang.Size = New System.Drawing.Size(100, 20)
        Me.TbNamabarang.TabIndex = 34
        '
        'txtHargaBarang
        '
        Me.txtHargaBarang.Location = New System.Drawing.Point(431, 333)
        Me.txtHargaBarang.Name = "txtHargaBarang"
        Me.txtHargaBarang.Size = New System.Drawing.Size(100, 20)
        Me.txtHargaBarang.TabIndex = 35
        '
        'TbJumlahBarang
        '
        Me.TbJumlahBarang.Location = New System.Drawing.Point(431, 369)
        Me.TbJumlahBarang.Name = "TbJumlahBarang"
        Me.TbJumlahBarang.Size = New System.Drawing.Size(100, 20)
        Me.TbJumlahBarang.TabIndex = 36
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(22, 469)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(1054, 160)
        Me.DataGridView2.TabIndex = 37
        '
        'Form_Transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1088, 641)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.TbJumlahBarang)
        Me.Controls.Add(Me.txtHargaBarang)
        Me.Controls.Add(Me.TbNamabarang)
        Me.Controls.Add(Me.TbBarang)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnCetak)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Form_Transaksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Tbtgl As DateTimePicker
    Friend WithEvents Tbtrbayar As TextBox
    Friend WithEvents Tbtotalbayar As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Tbidpembayaran As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TbNamaPembeli As TextBox
    Friend WithEvents TbJk As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TbAlamatPembeli As TextBox
    Friend WithEvents TbIdPembeli As TextBox
    Friend WithEvents TbNo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TbIdTransaksi As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Tbtgltransaksi As DateTimePicker
    Friend WithEvents Tbtrpembeli As TextBox
    Friend WithEvents Tbtrbarang As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TbKeterangan As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnTotal As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnCetak As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents TbBarang As TextBox
    Friend WithEvents TbNamabarang As TextBox
    Friend WithEvents txtHargaBarang As TextBox
    Friend WithEvents TbJumlahBarang As TextBox
    Friend WithEvents DataGridView2 As DataGridView
End Class
