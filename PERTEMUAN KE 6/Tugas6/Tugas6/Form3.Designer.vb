<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.chkMember = New System.Windows.Forms.CheckBox()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.txtHargaBarang = New System.Windows.Forms.TextBox()
        Me.txtJumlahBarang = New System.Windows.Forms.TextBox()
        Me.txtTotalHarga = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPakaian = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPesanan = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'chkMember
        '
        Me.chkMember.AutoSize = True
        Me.chkMember.Location = New System.Drawing.Point(184, 260)
        Me.chkMember.Name = "chkMember"
        Me.chkMember.Size = New System.Drawing.Size(120, 24)
        Me.chkMember.TabIndex = 0
        Me.chkMember.Text = "Diskon 10%"
        Me.chkMember.UseVisualStyleBackColor = True
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(16, 299)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(421, 38)
        Me.btnHitung.TabIndex = 1
        Me.btnHitung.Text = "Pesan Sekarang"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'txtHargaBarang
        '
        Me.txtHargaBarang.Location = New System.Drawing.Point(184, 167)
        Me.txtHargaBarang.Name = "txtHargaBarang"
        Me.txtHargaBarang.Size = New System.Drawing.Size(253, 26)
        Me.txtHargaBarang.TabIndex = 2
        '
        'txtJumlahBarang
        '
        Me.txtJumlahBarang.Location = New System.Drawing.Point(184, 214)
        Me.txtJumlahBarang.Name = "txtJumlahBarang"
        Me.txtJumlahBarang.Size = New System.Drawing.Size(253, 26)
        Me.txtJumlahBarang.TabIndex = 3
        '
        'txtTotalHarga
        '
        Me.txtTotalHarga.Location = New System.Drawing.Point(184, 394)
        Me.txtTotalHarga.Name = "txtTotalHarga"
        Me.txtTotalHarga.Size = New System.Drawing.Size(253, 26)
        Me.txtTotalHarga.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(180, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "TUGAS 6"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(91, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(258, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "APLIKASI PEMESANAN PAKAIAN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(91, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(270, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Luigi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Harga Barang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Jumblah Pesanan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 400)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Total Bayar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 264)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Khusus Member"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 20)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Nama Pakaian"
        '
        'txtPakaian
        '
        Me.txtPakaian.Location = New System.Drawing.Point(184, 130)
        Me.txtPakaian.Name = "txtPakaian"
        Me.txtPakaian.Size = New System.Drawing.Size(253, 26)
        Me.txtPakaian.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 358)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(139, 20)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Memesan Sebuah"
        '
        'txtPesanan
        '
        Me.txtPesanan.Location = New System.Drawing.Point(184, 352)
        Me.txtPesanan.Name = "txtPesanan"
        Me.txtPesanan.Size = New System.Drawing.Size(253, 26)
        Me.txtPesanan.TabIndex = 15
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 443)
        Me.Controls.Add(Me.txtPesanan)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtPakaian)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotalHarga)
        Me.Controls.Add(Me.txtJumlahBarang)
        Me.Controls.Add(Me.txtHargaBarang)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.chkMember)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkMember As CheckBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents txtHargaBarang As TextBox
    Friend WithEvents txtJumlahBarang As TextBox
    Friend WithEvents txtTotalHarga As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPakaian As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPesanan As TextBox
End Class
