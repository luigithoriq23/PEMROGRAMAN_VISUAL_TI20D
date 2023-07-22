<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KepuasanPelanggan
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
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRanting = New System.Windows.Forms.TextBox()
        Me.txtTingkatKepuasan = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(276, 104)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(108, 31)
        Me.btnSubmit.TabIndex = 0
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(552, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PRAKTIKUM 5 PENGGUNA IF MENCARI KEPUASAN PELANGGAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(299, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "AZIZ MAULANA 200511084 TIF20D"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nilai Ranting"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tingkat Kepuasan"
        '
        'txtRanting
        '
        Me.txtRanting.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRanting.Location = New System.Drawing.Point(17, 104)
        Me.txtRanting.Multiline = True
        Me.txtRanting.Name = "txtRanting"
        Me.txtRanting.Size = New System.Drawing.Size(237, 34)
        Me.txtRanting.TabIndex = 5
        '
        'txtTingkatKepuasan
        '
        Me.txtTingkatKepuasan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTingkatKepuasan.Location = New System.Drawing.Point(17, 166)
        Me.txtTingkatKepuasan.Multiline = True
        Me.txtTingkatKepuasan.Name = "txtTingkatKepuasan"
        Me.txtTingkatKepuasan.Size = New System.Drawing.Size(384, 34)
        Me.txtTingkatKepuasan.TabIndex = 6
        '
        'KepuasanPelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 218)
        Me.Controls.Add(Me.txtTingkatKepuasan)
        Me.Controls.Add(Me.txtRanting)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSubmit)
        Me.Name = "KepuasanPelanggan"
        Me.Text = "KepuasanPelanggan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRanting As TextBox
    Friend WithEvents txtTingkatKepuasan As TextBox
End Class
