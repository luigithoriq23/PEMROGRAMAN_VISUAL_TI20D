<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lingkaran
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.textJari = New System.Windows.Forms.TextBox()
        Me.txtLuas = New System.Windows.Forms.TextBox()
        Me.txtKeliling = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(126, 51)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(224, 38)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "HITUNG"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Jari-Jari"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Luas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Keliling"
        '
        'textJari
        '
        Me.textJari.Location = New System.Drawing.Point(126, 13)
        Me.textJari.Name = "textJari"
        Me.textJari.Size = New System.Drawing.Size(224, 26)
        Me.textJari.TabIndex = 4
        '
        'txtLuas
        '
        Me.txtLuas.Location = New System.Drawing.Point(126, 110)
        Me.txtLuas.Name = "txtLuas"
        Me.txtLuas.Size = New System.Drawing.Size(224, 26)
        Me.txtLuas.TabIndex = 5
        '
        'txtKeliling
        '
        Me.txtKeliling.Location = New System.Drawing.Point(126, 154)
        Me.txtKeliling.Name = "txtKeliling"
        Me.txtKeliling.Size = New System.Drawing.Size(224, 26)
        Me.txtKeliling.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(392, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(210, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Latihan Tidak Terstruktur"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(392, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Lingkaran"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(392, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Luigi"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(392, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "200511084"
        '
        'Lingkaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 195)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtKeliling)
        Me.Controls.Add(Me.txtLuas)
        Me.Controls.Add(Me.textJari)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Lingkaran"
        Me.Text = "Lingkaran"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents textJari As TextBox
    Friend WithEvents txtLuas As TextBox
    Friend WithEvents txtKeliling As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
