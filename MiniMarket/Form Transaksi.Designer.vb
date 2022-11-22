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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LblIdTR = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnInput = New System.Windows.Forms.Button()
        Me.TxtSub = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.TxtTotJmlh = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.DgvBarang = New System.Windows.Forms.DataGridView()
        Me.TMTR = New System.Windows.Forms.Timer(Me.components)
        Me.TxtHarga = New System.Windows.Forms.TextBox()
        Me.TxtIdBarang = New System.Windows.Forms.TextBox()
        Me.CbNamaBarang = New System.Windows.Forms.ComboBox()
        Me.LblIdPetugas = New System.Windows.Forms.Label()
        Me.LblJam = New System.Windows.Forms.Label()
        Me.LblTgl = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.TxtTotHarga = New System.Windows.Forms.TextBox()
        Me.TxtKembalian = New System.Windows.Forms.TextBox()
        Me.TxtBayar = New System.Windows.Forms.TextBox()
        Me.TxtJmlh = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LblNama = New System.Windows.Forms.Label()
        Me.LblAlamat = New System.Windows.Forms.Label()
        Me.LblNoHp = New System.Windows.Forms.Label()
        Me.CbIdPembeli = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DgvBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblIdTR
        '
        Me.LblIdTR.AutoSize = True
        Me.LblIdTR.Location = New System.Drawing.Point(118, 23)
        Me.LblIdTR.Name = "LblIdTR"
        Me.LblIdTR.Size = New System.Drawing.Size(67, 13)
        Me.LblIdTR.TabIndex = 133
        Me.LblIdTR.Text = "ID Transaksi"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(101, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(10, 13)
        Me.Label10.TabIndex = 132
        Me.Label10.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(20, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 13)
        Me.Label11.TabIndex = 131
        Me.Label11.Text = "ID Transaksi"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(549, 1)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(22, 23)
        Me.Button3.TabIndex = 130
        Me.Button3.Text = "X"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(479, 238)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 46)
        Me.BtnSave.TabIndex = 129
        Me.BtnSave.Text = "SAVE"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnInput
        '
        Me.BtnInput.Location = New System.Drawing.Point(272, 251)
        Me.BtnInput.Name = "BtnInput"
        Me.BtnInput.Size = New System.Drawing.Size(60, 32)
        Me.BtnInput.TabIndex = 128
        Me.BtnInput.Text = "Input"
        Me.BtnInput.UseVisualStyleBackColor = True
        '
        'TxtSub
        '
        Me.TxtSub.Location = New System.Drawing.Point(107, 470)
        Me.TxtSub.Name = "TxtSub"
        Me.TxtSub.Size = New System.Drawing.Size(100, 20)
        Me.TxtSub.TabIndex = 127
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(88, 473)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(10, 13)
        Me.Label28.TabIndex = 126
        Me.Label28.Text = ":"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(20, 473)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(56, 13)
        Me.Label38.TabIndex = 125
        Me.Label38.Text = "SUB Total"
        '
        'TxtTotJmlh
        '
        Me.TxtTotJmlh.Location = New System.Drawing.Point(503, 422)
        Me.TxtTotJmlh.Name = "TxtTotJmlh"
        Me.TxtTotJmlh.Size = New System.Drawing.Size(51, 20)
        Me.TxtTotJmlh.TabIndex = 124
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(484, 425)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(10, 13)
        Me.Label24.TabIndex = 123
        Me.Label24.Text = ":"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(411, 425)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(67, 13)
        Me.Label27.TabIndex = 122
        Me.Label27.Text = "Total Jumlah"
        '
        'DgvBarang
        '
        Me.DgvBarang.AllowUserToAddRows = False
        Me.DgvBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvBarang.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvBarang.Location = New System.Drawing.Point(23, 289)
        Me.DgvBarang.Name = "DgvBarang"
        Me.DgvBarang.ReadOnly = True
        Me.DgvBarang.RowHeadersVisible = False
        Me.DgvBarang.Size = New System.Drawing.Size(533, 127)
        Me.DgvBarang.TabIndex = 121
        '
        'TMTR
        '
        Me.TMTR.Enabled = True
        '
        'TxtHarga
        '
        Me.TxtHarga.Location = New System.Drawing.Point(121, 238)
        Me.TxtHarga.Name = "TxtHarga"
        Me.TxtHarga.Size = New System.Drawing.Size(100, 20)
        Me.TxtHarga.TabIndex = 120
        '
        'TxtIdBarang
        '
        Me.TxtIdBarang.Location = New System.Drawing.Point(121, 181)
        Me.TxtIdBarang.Name = "TxtIdBarang"
        Me.TxtIdBarang.Size = New System.Drawing.Size(100, 20)
        Me.TxtIdBarang.TabIndex = 119
        '
        'CbNamaBarang
        '
        Me.CbNamaBarang.FormattingEnabled = True
        Me.CbNamaBarang.Location = New System.Drawing.Point(121, 210)
        Me.CbNamaBarang.Name = "CbNamaBarang"
        Me.CbNamaBarang.Size = New System.Drawing.Size(121, 21)
        Me.CbNamaBarang.TabIndex = 118
        '
        'LblIdPetugas
        '
        Me.LblIdPetugas.AutoSize = True
        Me.LblIdPetugas.Location = New System.Drawing.Point(399, 104)
        Me.LblIdPetugas.Name = "LblIdPetugas"
        Me.LblIdPetugas.Size = New System.Drawing.Size(58, 13)
        Me.LblIdPetugas.TabIndex = 117
        Me.LblIdPetugas.Text = "Id Petugas"
        '
        'LblJam
        '
        Me.LblJam.AutoSize = True
        Me.LblJam.Location = New System.Drawing.Point(399, 75)
        Me.LblJam.Name = "LblJam"
        Me.LblJam.Size = New System.Drawing.Size(26, 13)
        Me.LblJam.TabIndex = 116
        Me.LblJam.Text = "Jam"
        '
        'LblTgl
        '
        Me.LblTgl.AutoSize = True
        Me.LblTgl.Location = New System.Drawing.Point(399, 47)
        Me.LblTgl.Name = "LblTgl"
        Me.LblTgl.Size = New System.Drawing.Size(71, 13)
        Me.LblTgl.TabIndex = 115
        Me.LblTgl.Text = "Tgl Transaksi"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(383, 104)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(10, 13)
        Me.Label32.TabIndex = 114
        Me.Label32.Text = ":"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(383, 75)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(10, 13)
        Me.Label33.TabIndex = 113
        Me.Label33.Text = ":"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(383, 47)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(10, 13)
        Me.Label34.TabIndex = 112
        Me.Label34.Text = ":"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(306, 104)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(58, 13)
        Me.Label29.TabIndex = 111
        Me.Label29.Text = "Id Petugas"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(306, 75)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(26, 13)
        Me.Label30.TabIndex = 110
        Me.Label30.Text = "Jam"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(306, 47)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(71, 13)
        Me.Label31.TabIndex = 109
        Me.Label31.Text = "Tgl Transaksi"
        '
        'TxtTotHarga
        '
        Me.TxtTotHarga.Location = New System.Drawing.Point(328, 422)
        Me.TxtTotHarga.Name = "TxtTotHarga"
        Me.TxtTotHarga.Size = New System.Drawing.Size(77, 20)
        Me.TxtTotHarga.TabIndex = 108
        '
        'TxtKembalian
        '
        Me.TxtKembalian.Location = New System.Drawing.Point(456, 470)
        Me.TxtKembalian.Name = "TxtKembalian"
        Me.TxtKembalian.Size = New System.Drawing.Size(100, 20)
        Me.TxtKembalian.TabIndex = 107
        '
        'TxtBayar
        '
        Me.TxtBayar.Location = New System.Drawing.Point(272, 470)
        Me.TxtBayar.Name = "TxtBayar"
        Me.TxtBayar.Size = New System.Drawing.Size(100, 20)
        Me.TxtBayar.TabIndex = 106
        '
        'TxtJmlh
        '
        Me.TxtJmlh.Location = New System.Drawing.Point(121, 263)
        Me.TxtJmlh.Name = "TxtJmlh"
        Me.TxtJmlh.Size = New System.Drawing.Size(100, 20)
        Me.TxtJmlh.TabIndex = 105
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(309, 425)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(10, 13)
        Me.Label23.TabIndex = 104
        Me.Label23.Text = ":"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(440, 473)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(10, 13)
        Me.Label25.TabIndex = 103
        Me.Label25.Text = ":"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(253, 473)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(10, 13)
        Me.Label26.TabIndex = 102
        Me.Label26.Text = ":"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(101, 184)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(10, 13)
        Me.Label19.TabIndex = 101
        Me.Label19.Text = ":"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(101, 266)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(10, 13)
        Me.Label20.TabIndex = 100
        Me.Label20.Text = ":"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(101, 238)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(10, 13)
        Me.Label21.TabIndex = 99
        Me.Label21.Text = ":"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(101, 213)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(10, 13)
        Me.Label22.TabIndex = 98
        Me.Label22.Text = ":"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(378, 473)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 13)
        Me.Label14.TabIndex = 97
        Me.Label14.Text = "Kembalian"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(213, 473)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 13)
        Me.Label13.TabIndex = 96
        Me.Label13.Text = "Bayar"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(241, 425)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 13)
        Me.Label12.TabIndex = 95
        Me.Label12.Text = "Total Harga"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(20, 266)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 13)
        Me.Label18.TabIndex = 94
        Me.Label18.Text = "Jumlah"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(20, 238)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(36, 13)
        Me.Label17.TabIndex = 93
        Me.Label17.Text = "Harga"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(20, 213)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 13)
        Me.Label16.TabIndex = 92
        Me.Label16.Text = "Nama Barang"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(20, 184)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 13)
        Me.Label15.TabIndex = 91
        Me.Label15.Text = "Id Barang"
        '
        'LblNama
        '
        Me.LblNama.AutoSize = True
        Me.LblNama.Location = New System.Drawing.Point(117, 79)
        Me.LblNama.Name = "LblNama"
        Me.LblNama.Size = New System.Drawing.Size(75, 13)
        Me.LblNama.TabIndex = 88
        Me.LblNama.Text = "Nama Pembeli"
        '
        'LblAlamat
        '
        Me.LblAlamat.AutoSize = True
        Me.LblAlamat.Location = New System.Drawing.Point(117, 104)
        Me.LblAlamat.Name = "LblAlamat"
        Me.LblAlamat.Size = New System.Drawing.Size(39, 13)
        Me.LblAlamat.TabIndex = 90
        Me.LblAlamat.Text = "Alamat"
        '
        'LblNoHp
        '
        Me.LblNoHp.AutoSize = True
        Me.LblNoHp.Location = New System.Drawing.Point(117, 128)
        Me.LblNoHp.Name = "LblNoHp"
        Me.LblNoHp.Size = New System.Drawing.Size(38, 13)
        Me.LblNoHp.TabIndex = 89
        Me.LblNoHp.Text = "No Hp"
        '
        'CbIdPembeli
        '
        Me.CbIdPembeli.FormattingEnabled = True
        Me.CbIdPembeli.Location = New System.Drawing.Point(121, 47)
        Me.CbIdPembeli.Name = "CbIdPembeli"
        Me.CbIdPembeli.Size = New System.Drawing.Size(121, 21)
        Me.CbIdPembeli.TabIndex = 87
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(101, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(10, 13)
        Me.Label8.TabIndex = 86
        Me.Label8.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(101, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 13)
        Me.Label7.TabIndex = 85
        Me.Label7.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(101, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 13)
        Me.Label6.TabIndex = 84
        Me.Label6.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(101, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 13)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = ":"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Id Pembeli"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Nama Pembeli"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Alamat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "No Hp"
        '
        'Form_Transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 503)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblIdTR)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnInput)
        Me.Controls.Add(Me.TxtSub)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.TxtTotJmlh)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.DgvBarang)
        Me.Controls.Add(Me.TxtHarga)
        Me.Controls.Add(Me.TxtIdBarang)
        Me.Controls.Add(Me.CbNamaBarang)
        Me.Controls.Add(Me.LblIdPetugas)
        Me.Controls.Add(Me.LblJam)
        Me.Controls.Add(Me.LblTgl)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.TxtTotHarga)
        Me.Controls.Add(Me.TxtKembalian)
        Me.Controls.Add(Me.TxtBayar)
        Me.Controls.Add(Me.TxtJmlh)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.LblNama)
        Me.Controls.Add(Me.LblAlamat)
        Me.Controls.Add(Me.LblNoHp)
        Me.Controls.Add(Me.CbIdPembeli)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Name = "Form_Transaksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DgvBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblIdTR As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnInput As Button
    Friend WithEvents TxtSub As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents TxtTotJmlh As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents DgvBarang As DataGridView
    Friend WithEvents TMTR As Timer
    Friend WithEvents TxtHarga As TextBox
    Friend WithEvents TxtIdBarang As TextBox
    Friend WithEvents CbNamaBarang As ComboBox
    Friend WithEvents LblIdPetugas As Label
    Friend WithEvents LblJam As Label
    Friend WithEvents LblTgl As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents TxtTotHarga As TextBox
    Friend WithEvents TxtKembalian As TextBox
    Friend WithEvents TxtBayar As TextBox
    Friend WithEvents TxtJmlh As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents LblNama As Label
    Friend WithEvents LblAlamat As Label
    Friend WithEvents LblNoHp As Label
    Friend WithEvents CbIdPembeli As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
