<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JenisIkan
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
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.txtKodeKota = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(5, 206)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(327, 26)
        Me.txtKeterangan.TabIndex = 13
        '
        'txtKodeKota
        '
        Me.txtKodeKota.Location = New System.Drawing.Point(6, 136)
        Me.txtKodeKota.Name = "txtKodeKota"
        Me.txtKodeKota.Size = New System.Drawing.Size(231, 26)
        Me.txtKodeKota.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Keterangan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Kode Ikan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(270, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Luigi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "PRAKTIKUM 5 CASE JENIS IKAN"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(257, 130)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 39)
        Me.btnSubmit.TabIndex = 7
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'JenisIkan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 244)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.txtKodeKota)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSubmit)
        Me.Name = "JenisIkan"
        Me.Text = "JenisIkan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtKeterangan As TextBox
    Friend WithEvents txtKodeKota As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSubmit As Button
End Class
