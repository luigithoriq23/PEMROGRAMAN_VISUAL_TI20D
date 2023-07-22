<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bola
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.textJari = New System.Windows.Forms.TextBox()
        Me.txtLuas = New System.Windows.Forms.TextBox()
        Me.txtVolume = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Jari-jari"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Luas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Volume"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(358, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(191, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Praktikum Tersetruktur"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(358, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Bola"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(358, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Luigi"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(358, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "200511084"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 63)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(317, 34)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "HITUNG"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'textJari
        '
        Me.textJari.Location = New System.Drawing.Point(105, 16)
        Me.textJari.Name = "textJari"
        Me.textJari.Size = New System.Drawing.Size(228, 26)
        Me.textJari.TabIndex = 8
        '
        'txtLuas
        '
        Me.txtLuas.Location = New System.Drawing.Point(105, 114)
        Me.txtLuas.Name = "txtLuas"
        Me.txtLuas.Size = New System.Drawing.Size(228, 26)
        Me.txtLuas.TabIndex = 9
        '
        'txtVolume
        '
        Me.txtVolume.Location = New System.Drawing.Point(105, 152)
        Me.txtVolume.Name = "txtVolume"
        Me.txtVolume.Size = New System.Drawing.Size(228, 26)
        Me.txtVolume.TabIndex = 10
        '
        'Bola
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 196)
        Me.Controls.Add(Me.txtVolume)
        Me.Controls.Add(Me.txtLuas)
        Me.Controls.Add(Me.textJari)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Bola"
        Me.Text = "Bola"
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
    Friend WithEvents Button1 As Button
    Friend WithEvents textJari As TextBox
    Friend WithEvents txtLuas As TextBox
    Friend WithEvents txtVolume As TextBox
End Class
