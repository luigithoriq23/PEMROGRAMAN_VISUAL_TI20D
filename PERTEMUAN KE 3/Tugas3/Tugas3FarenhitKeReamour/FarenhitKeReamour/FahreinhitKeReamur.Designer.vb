<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FahreinhitKeReamur
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
        Me.Konvert = New System.Windows.Forms.Button()
        Me.textFht = New System.Windows.Forms.TextBox()
        Me.txtReamur = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Konvert
        '
        Me.Konvert.Location = New System.Drawing.Point(223, 80)
        Me.Konvert.Name = "Konvert"
        Me.Konvert.Size = New System.Drawing.Size(195, 40)
        Me.Konvert.TabIndex = 0
        Me.Konvert.Text = "Konvert"
        Me.Konvert.UseVisualStyleBackColor = True
        '
        'textFht
        '
        Me.textFht.Location = New System.Drawing.Point(12, 94)
        Me.textFht.Name = "textFht"
        Me.textFht.Size = New System.Drawing.Size(195, 26)
        Me.textFht.TabIndex = 1
        '
        'txtReamur
        '
        Me.txtReamur.Location = New System.Drawing.Point(448, 94)
        Me.txtReamur.Name = "txtReamur"
        Me.txtReamur.Size = New System.Drawing.Size(195, 26)
        Me.txtReamur.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(126, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(414, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tugas Konversi Fahreinheit Ke Reamur Terstruktur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(210, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(234, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "AZIZ MAULANA 200511084"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fahreinhit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(510, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Reamur"
        '
        'FahreinhitKeReamur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 139)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtReamur)
        Me.Controls.Add(Me.textFht)
        Me.Controls.Add(Me.Konvert)
        Me.Name = "FahreinhitKeReamur"
        Me.Text = "FahreinhitKeReamur"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Konvert As Button
    Friend WithEvents textFht As TextBox
    Friend WithEvents txtReamur As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
