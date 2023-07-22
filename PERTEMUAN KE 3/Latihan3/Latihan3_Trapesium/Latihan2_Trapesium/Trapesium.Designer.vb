<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Trapesium
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.textTinggi = New System.Windows.Forms.TextBox()
        Me.textSisi1 = New System.Windows.Forms.TextBox()
        Me.textSisi2 = New System.Windows.Forms.TextBox()
        Me.textSisi3 = New System.Windows.Forms.TextBox()
        Me.textSisi4 = New System.Windows.Forms.TextBox()
        Me.txtLuas = New System.Windows.Forms.TextBox()
        Me.txtKeliling = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tinggi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sisi Kiri"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sisi Atas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Sisi Kanan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Sisi Bawah"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(434, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Luas"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(434, 198)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Keliling"
        '
        'textTinggi
        '
        Me.textTinggi.Location = New System.Drawing.Point(170, 13)
        Me.textTinggi.Name = "textTinggi"
        Me.textTinggi.Size = New System.Drawing.Size(216, 26)
        Me.textTinggi.TabIndex = 7
        '
        'textSisi1
        '
        Me.textSisi1.Location = New System.Drawing.Point(170, 45)
        Me.textSisi1.Name = "textSisi1"
        Me.textSisi1.Size = New System.Drawing.Size(216, 26)
        Me.textSisi1.TabIndex = 8
        '
        'textSisi2
        '
        Me.textSisi2.Location = New System.Drawing.Point(170, 77)
        Me.textSisi2.Name = "textSisi2"
        Me.textSisi2.Size = New System.Drawing.Size(216, 26)
        Me.textSisi2.TabIndex = 9
        '
        'textSisi3
        '
        Me.textSisi3.Location = New System.Drawing.Point(170, 108)
        Me.textSisi3.Name = "textSisi3"
        Me.textSisi3.Size = New System.Drawing.Size(216, 26)
        Me.textSisi3.TabIndex = 10
        '
        'textSisi4
        '
        Me.textSisi4.Location = New System.Drawing.Point(170, 138)
        Me.textSisi4.Name = "textSisi4"
        Me.textSisi4.Size = New System.Drawing.Size(216, 26)
        Me.textSisi4.TabIndex = 11
        '
        'txtLuas
        '
        Me.txtLuas.Location = New System.Drawing.Point(591, 163)
        Me.txtLuas.Name = "txtLuas"
        Me.txtLuas.Size = New System.Drawing.Size(216, 26)
        Me.txtLuas.TabIndex = 12
        '
        'txtKeliling
        '
        Me.txtKeliling.Location = New System.Drawing.Point(591, 192)
        Me.txtKeliling.Name = "txtKeliling"
        Me.txtKeliling.Size = New System.Drawing.Size(216, 26)
        Me.txtKeliling.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(17, 181)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(369, 37)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "HITUNG"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(430, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(210, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Latihan Tidak Terstruktur"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(430, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Trapesium"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(430, 97)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(139, 20)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Luigi"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(430, 129)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 20)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "200511084"
        '
        'Trapesium
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 238)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtKeliling)
        Me.Controls.Add(Me.txtLuas)
        Me.Controls.Add(Me.textSisi4)
        Me.Controls.Add(Me.textSisi3)
        Me.Controls.Add(Me.textSisi2)
        Me.Controls.Add(Me.textSisi1)
        Me.Controls.Add(Me.textTinggi)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Trapesium"
        Me.Text = "Trapesium"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents textTinggi As TextBox
    Friend WithEvents textSisi1 As TextBox
    Friend WithEvents textSisi2 As TextBox
    Friend WithEvents textSisi3 As TextBox
    Friend WithEvents textSisi4 As TextBox
    Friend WithEvents txtLuas As TextBox
    Friend WithEvents txtKeliling As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
