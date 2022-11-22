<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Pembeli
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
        Me.txtNamaPembeli = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAlamatPembeli = New System.Windows.Forms.TextBox()
        Me.txtNoPembeli = New System.Windows.Forms.TextBox()
        Me.txtNoHp = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Dgpembeli = New System.Windows.Forms.DataGridView()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.Dgpembeli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNamaPembeli
        '
        Me.txtNamaPembeli.Location = New System.Drawing.Point(111, 52)
        Me.txtNamaPembeli.Name = "txtNamaPembeli"
        Me.txtNamaPembeli.Size = New System.Drawing.Size(100, 20)
        Me.txtNamaPembeli.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Id Pembeli"
        '
        'txtAlamatPembeli
        '
        Me.txtAlamatPembeli.Location = New System.Drawing.Point(111, 93)
        Me.txtAlamatPembeli.Name = "txtAlamatPembeli"
        Me.txtAlamatPembeli.Size = New System.Drawing.Size(100, 20)
        Me.txtAlamatPembeli.TabIndex = 19
        '
        'txtNoPembeli
        '
        Me.txtNoPembeli.Location = New System.Drawing.Point(111, 12)
        Me.txtNoPembeli.Name = "txtNoPembeli"
        Me.txtNoPembeli.Size = New System.Drawing.Size(100, 20)
        Me.txtNoPembeli.TabIndex = 12
        '
        'txtNoHp
        '
        Me.txtNoHp.Location = New System.Drawing.Point(111, 133)
        Me.txtNoHp.Name = "txtNoHp"
        Me.txtNoHp.Size = New System.Drawing.Size(100, 20)
        Me.txtNoHp.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nama Pembeli"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Alamat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "No Hp"
        '
        'Dgpembeli
        '
        Me.Dgpembeli.AllowUserToAddRows = False
        Me.Dgpembeli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgpembeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgpembeli.Location = New System.Drawing.Point(241, 12)
        Me.Dgpembeli.Name = "Dgpembeli"
        Me.Dgpembeli.RowHeadersVisible = False
        Me.Dgpembeli.Size = New System.Drawing.Size(470, 186)
        Me.Dgpembeli.TabIndex = 21
        '
        'btntambah
        '
        Me.btntambah.Location = New System.Drawing.Point(12, 175)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(56, 23)
        Me.btntambah.TabIndex = 22
        Me.btntambah.Text = "Tambah"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(91, 175)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(52, 23)
        Me.btnupdate.TabIndex = 23
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(171, 175)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(51, 23)
        Me.btnhapus.TabIndex = 24
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(713, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "X"
        '
        'Form_Pembeli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 212)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.Dgpembeli)
        Me.Controls.Add(Me.txtNamaPembeli)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAlamatPembeli)
        Me.Controls.Add(Me.txtNoPembeli)
        Me.Controls.Add(Me.txtNoHp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Name = "Form_Pembeli"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Dgpembeli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNamaPembeli As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAlamatPembeli As TextBox
    Friend WithEvents txtNoPembeli As TextBox
    Friend WithEvents txtNoHp As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Dgpembeli As DataGridView
    Friend WithEvents btntambah As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents Label6 As Label
End Class
