<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Petugas
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
        Me.txtNoPetugas = New System.Windows.Forms.TextBox()
        Me.txtnamapetugas = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtnohp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgpetugas = New System.Windows.Forms.DataGridView()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.Keluar = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        CType(Me.dgpetugas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id Petugas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Petugass"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'txtNoPetugas
        '
        Me.txtNoPetugas.Location = New System.Drawing.Point(139, 17)
        Me.txtNoPetugas.Name = "txtNoPetugas"
        Me.txtNoPetugas.Size = New System.Drawing.Size(100, 20)
        Me.txtNoPetugas.TabIndex = 3
        '
        'txtnamapetugas
        '
        Me.txtnamapetugas.Location = New System.Drawing.Point(139, 54)
        Me.txtnamapetugas.Name = "txtnamapetugas"
        Me.txtnamapetugas.Size = New System.Drawing.Size(100, 20)
        Me.txtnamapetugas.TabIndex = 4
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(139, 94)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(100, 20)
        Me.txtpassword.TabIndex = 5
        '
        'txtnohp
        '
        Me.txtnohp.Location = New System.Drawing.Point(139, 172)
        Me.txtnohp.Name = "txtnohp"
        Me.txtnohp.Size = New System.Drawing.Size(100, 20)
        Me.txtnohp.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "NO HP/WA"
        '
        'dgpetugas
        '
        Me.dgpetugas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgpetugas.Location = New System.Drawing.Point(264, 12)
        Me.dgpetugas.Name = "dgpetugas"
        Me.dgpetugas.Size = New System.Drawing.Size(533, 180)
        Me.dgpetugas.TabIndex = 8
        '
        'btntambah
        '
        Me.btntambah.Location = New System.Drawing.Point(264, 208)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(75, 23)
        Me.btntambah.TabIndex = 9
        Me.btntambah.Text = "Tambah"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnhapus.Location = New System.Drawing.Point(539, 208)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(75, 23)
        Me.btnhapus.TabIndex = 10
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(395, 208)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 23)
        Me.btnupdate.TabIndex = 11
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'Keluar
        '
        Me.Keluar.AutoSize = True
        Me.Keluar.Location = New System.Drawing.Point(803, 0)
        Me.Keluar.Name = "Keluar"
        Me.Keluar.Size = New System.Drawing.Size(14, 13)
        Me.Keluar.TabIndex = 12
        Me.Keluar.Text = "X"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Alamat"
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(139, 136)
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(100, 20)
        Me.txtalamat.TabIndex = 14
        '
        'Form_Petugas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 239)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Keluar)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.dgpetugas)
        Me.Controls.Add(Me.txtnohp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtnamapetugas)
        Me.Controls.Add(Me.txtNoPetugas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_Petugas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgpetugas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNoPetugas As TextBox
    Friend WithEvents txtnamapetugas As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtnohp As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dgpetugas As DataGridView
    Friend WithEvents btntambah As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents Keluar As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtalamat As TextBox
End Class
