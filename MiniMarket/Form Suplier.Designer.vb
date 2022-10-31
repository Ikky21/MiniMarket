<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Suplier
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtidsuplier = New System.Windows.Forms.TextBox()
        Me.txtnamasuplier = New System.Windows.Forms.TextBox()
        Me.txtnohp = New System.Windows.Forms.TextBox()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.DgSuplier = New System.Windows.Forms.DataGridView()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.BtnLanjut = New System.Windows.Forms.Button()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        CType(Me.DgSuplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id Suplier"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Suplier"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "No HP/WA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Alamat"
        '
        'txtidsuplier
        '
        Me.txtidsuplier.Location = New System.Drawing.Point(149, 13)
        Me.txtidsuplier.Name = "txtidsuplier"
        Me.txtidsuplier.Size = New System.Drawing.Size(100, 20)
        Me.txtidsuplier.TabIndex = 4
        '
        'txtnamasuplier
        '
        Me.txtnamasuplier.Location = New System.Drawing.Point(149, 56)
        Me.txtnamasuplier.Name = "txtnamasuplier"
        Me.txtnamasuplier.Size = New System.Drawing.Size(100, 20)
        Me.txtnamasuplier.TabIndex = 5
        '
        'txtnohp
        '
        Me.txtnohp.Location = New System.Drawing.Point(149, 95)
        Me.txtnohp.Name = "txtnohp"
        Me.txtnohp.Size = New System.Drawing.Size(100, 20)
        Me.txtnohp.TabIndex = 6
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(149, 134)
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(100, 20)
        Me.txtalamat.TabIndex = 7
        '
        'DgSuplier
        '
        Me.DgSuplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgSuplier.Location = New System.Drawing.Point(317, 13)
        Me.DgSuplier.Name = "DgSuplier"
        Me.DgSuplier.Size = New System.Drawing.Size(471, 197)
        Me.DgSuplier.TabIndex = 8
        '
        'btntambah
        '
        Me.btntambah.Location = New System.Drawing.Point(25, 187)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(75, 23)
        Me.btntambah.TabIndex = 9
        Me.btntambah.Text = "Tambah"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(127, 187)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 10
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'BtnLanjut
        '
        Me.BtnLanjut.Location = New System.Drawing.Point(794, 34)
        Me.BtnLanjut.Name = "BtnLanjut"
        Me.BtnLanjut.Size = New System.Drawing.Size(45, 23)
        Me.BtnLanjut.TabIndex = 11
        Me.BtnLanjut.Text = "NEXT"
        Me.BtnLanjut.UseVisualStyleBackColor = True
        '
        'btnkeluar
        '
        Me.btnkeluar.Location = New System.Drawing.Point(812, -3)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(27, 20)
        Me.btnkeluar.TabIndex = 12
        Me.btnkeluar.Text = "X"
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(229, 187)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(75, 23)
        Me.BtnHapus.TabIndex = 13
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'Form_Suplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 228)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.BtnLanjut)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.DgSuplier)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.txtnohp)
        Me.Controls.Add(Me.txtnamasuplier)
        Me.Controls.Add(Me.txtidsuplier)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_Suplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DgSuplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtidsuplier As TextBox
    Friend WithEvents txtnamasuplier As TextBox
    Friend WithEvents txtnohp As TextBox
    Friend WithEvents txtalamat As TextBox
    Friend WithEvents DgSuplier As DataGridView
    Friend WithEvents btntambah As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents BtnLanjut As Button
    Friend WithEvents btnkeluar As Button
    Friend WithEvents BtnHapus As Button
End Class
