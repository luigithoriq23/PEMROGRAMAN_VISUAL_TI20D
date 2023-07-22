<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReamurKeKelvin
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
        Me.konvert = New System.Windows.Forms.Button()
        Me.textReamur = New System.Windows.Forms.TextBox()
        Me.txtKelvin = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reamur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(524, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kelvin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(154, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(380, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tugas Konversi Reamur Ke Kelvin Tersetruktur"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(217, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(234, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "AZIZ MAULANA 200511084"
        '
        'konvert
        '
        Me.konvert.Location = New System.Drawing.Point(254, 83)
        Me.konvert.Name = "konvert"
        Me.konvert.Size = New System.Drawing.Size(180, 35)
        Me.konvert.TabIndex = 4
        Me.konvert.Text = "Konvert"
        Me.konvert.UseVisualStyleBackColor = True
        '
        'textReamur
        '
        Me.textReamur.Location = New System.Drawing.Point(18, 92)
        Me.textReamur.Name = "textReamur"
        Me.textReamur.Size = New System.Drawing.Size(203, 26)
        Me.textReamur.TabIndex = 5
        '
        'txtKelvin
        '
        Me.txtKelvin.Location = New System.Drawing.Point(463, 92)
        Me.txtKelvin.Name = "txtKelvin"
        Me.txtKelvin.Size = New System.Drawing.Size(203, 26)
        Me.txtKelvin.TabIndex = 6
        '
        'ReamurKeKelvin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 138)
        Me.Controls.Add(Me.txtKelvin)
        Me.Controls.Add(Me.textReamur)
        Me.Controls.Add(Me.konvert)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ReamurKeKelvin"
        Me.Text = "ReamurKeKelvin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents konvert As Button
    Friend WithEvents textReamur As TextBox
    Friend WithEvents txtKelvin As TextBox
End Class
