<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CelciusKeFahreinhit
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
        Me.txtFahreinhit = New System.Windows.Forms.TextBox()
        Me.textCel = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Konvert
        '
        Me.Konvert.Location = New System.Drawing.Point(239, 67)
        Me.Konvert.Name = "Konvert"
        Me.Konvert.Size = New System.Drawing.Size(146, 31)
        Me.Konvert.TabIndex = 0
        Me.Konvert.Text = "Konvert"
        Me.Konvert.UseVisualStyleBackColor = True
        '
        'txtFahreinhit
        '
        Me.txtFahreinhit.Location = New System.Drawing.Point(409, 77)
        Me.txtFahreinhit.Name = "txtFahreinhit"
        Me.txtFahreinhit.Size = New System.Drawing.Size(210, 26)
        Me.txtFahreinhit.TabIndex = 1
        '
        'textCel
        '
        Me.textCel.Location = New System.Drawing.Point(10, 72)
        Me.textCel.Name = "textCel"
        Me.textCel.Size = New System.Drawing.Size(210, 26)
        Me.textCel.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(123, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(399, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tugas Konversi Celcius Ke Fahreinhit Terstruktur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(202, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(234, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "AZIZ MAULANA 200511084"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(72, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Celcius"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(468, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fahreinhit"
        '
        'CelciusKeFahreinhit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 115)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.textCel)
        Me.Controls.Add(Me.txtFahreinhit)
        Me.Controls.Add(Me.Konvert)
        Me.Name = "CelciusKeFahreinhit"
        Me.Text = "CelciusKeFahreinhit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Konvert As Button
    Friend WithEvents txtFahreinhit As TextBox
    Friend WithEvents textCel As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
