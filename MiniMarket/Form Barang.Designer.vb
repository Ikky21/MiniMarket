<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Barang
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
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.DgBarang = New System.Windows.Forms.DataGridView()
        Me.txtIdSuplier = New System.Windows.Forms.TextBox()
        Me.txtStok = New System.Windows.Forms.TextBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtNamaBarang = New System.Windows.Forms.TextBox()
        Me.txtNoBarang = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnHapus = New System.Windows.Forms.Button()
        CType(Me.DgBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Location = New System.Drawing.Point(718, 12)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(31, 23)
        Me.BtnKeluar.TabIndex = 27
        Me.BtnKeluar.Text = "X"
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(118, 232)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(64, 23)
        Me.BtnUpdate.TabIndex = 26
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(26, 232)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(69, 23)
        Me.BtnTambah.TabIndex = 25
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'DgBarang
        '
        Me.DgBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgBarang.Location = New System.Drawing.Point(289, 12)
        Me.DgBarang.Name = "DgBarang"
        Me.DgBarang.Size = New System.Drawing.Size(405, 243)
        Me.DgBarang.TabIndex = 24
        '
        'txtIdSuplier
        '
        Me.txtIdSuplier.Location = New System.Drawing.Point(131, 185)
        Me.txtIdSuplier.Name = "txtIdSuplier"
        Me.txtIdSuplier.Size = New System.Drawing.Size(100, 20)
        Me.txtIdSuplier.TabIndex = 23
        '
        'txtStok
        '
        Me.txtStok.Location = New System.Drawing.Point(131, 143)
        Me.txtStok.Name = "txtStok"
        Me.txtStok.Size = New System.Drawing.Size(100, 20)
        Me.txtStok.TabIndex = 22
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(131, 93)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(100, 20)
        Me.txtHarga.TabIndex = 21
        '
        'txtNamaBarang
        '
        Me.txtNamaBarang.Location = New System.Drawing.Point(131, 52)
        Me.txtNamaBarang.Name = "txtNamaBarang"
        Me.txtNamaBarang.Size = New System.Drawing.Size(100, 20)
        Me.txtNamaBarang.TabIndex = 20
        '
        'txtNoBarang
        '
        Me.txtNoBarang.Location = New System.Drawing.Point(131, 12)
        Me.txtNoBarang.Name = "txtNoBarang"
        Me.txtNoBarang.Size = New System.Drawing.Size(100, 20)
        Me.txtNoBarang.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Id Suplier"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Stok"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Harga"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Nama Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "No Barang"
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(214, 232)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(54, 23)
        Me.btnHapus.TabIndex = 28
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'Form_Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 278)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.DgBarang)
        Me.Controls.Add(Me.txtIdSuplier)
        Me.Controls.Add(Me.txtStok)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.txtNamaBarang)
        Me.Controls.Add(Me.txtNoBarang)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_Barang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DgBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnKeluar As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnTambah As Button
    Friend WithEvents DgBarang As DataGridView
    Friend WithEvents txtIdSuplier As TextBox
    Friend WithEvents txtStok As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtNamaBarang As TextBox
    Friend WithEvents txtNoBarang As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnHapus As Button
End Class
