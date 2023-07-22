<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProdi = New System.Windows.Forms.TextBox()
        Me.txtSKS = New System.Windows.Forms.TextBox()
        Me.txtNamaMk = New System.Windows.Forms.TextBox()
        Me.txtKodemk = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(651, 19)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(75, 32)
        Me.BtnHapus.TabIndex = 23
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(517, 19)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 32)
        Me.btnSimpan.TabIndex = 22
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 20)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Prodi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "SKS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Nama MK"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Kode MK"
        '
        'txtProdi
        '
        Me.txtProdi.Location = New System.Drawing.Point(143, 117)
        Me.txtProdi.Name = "txtProdi"
        Me.txtProdi.Size = New System.Drawing.Size(183, 26)
        Me.txtProdi.TabIndex = 17
        '
        'txtSKS
        '
        Me.txtSKS.Location = New System.Drawing.Point(143, 82)
        Me.txtSKS.Name = "txtSKS"
        Me.txtSKS.Size = New System.Drawing.Size(183, 26)
        Me.txtSKS.TabIndex = 16
        '
        'txtNamaMk
        '
        Me.txtNamaMk.Location = New System.Drawing.Point(143, 49)
        Me.txtNamaMk.Name = "txtNamaMk"
        Me.txtNamaMk.Size = New System.Drawing.Size(183, 26)
        Me.txtNamaMk.TabIndex = 15
        '
        'txtKodemk
        '
        Me.txtKodemk.Location = New System.Drawing.Point(143, 13)
        Me.txtKodemk.Name = "txtKodemk"
        Me.txtKodemk.Size = New System.Drawing.Size(183, 26)
        Me.txtKodemk.TabIndex = 14
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(386, 19)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 32)
        Me.btnReset.TabIndex = 13
        Me.btnReset.Text = "Resset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 162)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(840, 373)
        Me.DataGridView1.TabIndex = 12
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 547)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtProdi)
        Me.Controls.Add(Me.txtSKS)
        Me.Controls.Add(Me.txtNamaMk)
        Me.Controls.Add(Me.txtKodemk)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnHapus As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtProdi As TextBox
    Friend WithEvents txtSKS As TextBox
    Friend WithEvents txtNamaMk As TextBox
    Friend WithEvents txtKodemk As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
