<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPenyewa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPenyewa))
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtIDKAMAR = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTELEPON = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNMPENYEWA = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.txtHARGA = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtJUMBLAHMALAM = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTOTALBIAYA = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNMKAMAR = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Yellow
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(885, 195)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(94, 26)
        Me.btnDelete.TabIndex = 45
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Yellow
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(461, 195)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(94, 26)
        Me.btnSubmit.TabIndex = 44
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Yellow
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(15, 195)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(94, 26)
        Me.btnClear.TabIndex = 43
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txtIDKAMAR
        '
        Me.txtIDKAMAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDKAMAR.Location = New System.Drawing.Point(647, 64)
        Me.txtIDKAMAR.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtIDKAMAR.Name = "txtIDKAMAR"
        Me.txtIDKAMAR.Size = New System.Drawing.Size(60, 21)
        Me.txtIDKAMAR.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Yellow
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(551, 62)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 17)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "ID Barang"
        '
        'txtTELEPON
        '
        Me.txtTELEPON.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTELEPON.Location = New System.Drawing.Point(111, 96)
        Me.txtTELEPON.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtTELEPON.Name = "txtTELEPON"
        Me.txtTELEPON.Size = New System.Drawing.Size(235, 21)
        Me.txtTELEPON.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Yellow
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(13, 96)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 17)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "No Telp"
        '
        'txtNMPENYEWA
        '
        Me.txtNMPENYEWA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNMPENYEWA.Location = New System.Drawing.Point(111, 64)
        Me.txtNMPENYEWA.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtNMPENYEWA.Name = "txtNMPENYEWA"
        Me.txtNMPENYEWA.Size = New System.Drawing.Size(235, 21)
        Me.txtNMPENYEWA.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Yellow
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(13, 64)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 17)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Nama Pembeli"
        '
        'dgvData
        '
        Me.dgvData.BackgroundColor = System.Drawing.Color.Yellow
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.GridColor = System.Drawing.Color.Yellow
        Me.dgvData.Location = New System.Drawing.Point(15, 226)
        Me.dgvData.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.RowTemplate.Height = 24
        Me.dgvData.Size = New System.Drawing.Size(963, 198)
        Me.dgvData.TabIndex = 36
        '
        'txtHARGA
        '
        Me.txtHARGA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHARGA.Location = New System.Drawing.Point(846, 64)
        Me.txtHARGA.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtHARGA.Name = "txtHARGA"
        Me.txtHARGA.ReadOnly = True
        Me.txtHARGA.Size = New System.Drawing.Size(134, 21)
        Me.txtHARGA.TabIndex = 47
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Yellow
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(912, 138)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 17)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Tgl. Keluar"
        '
        'txtJUMBLAHMALAM
        '
        Me.txtJUMBLAHMALAM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJUMBLAHMALAM.Location = New System.Drawing.Point(647, 94)
        Me.txtJUMBLAHMALAM.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtJUMBLAHMALAM.Name = "txtJUMBLAHMALAM"
        Me.txtJUMBLAHMALAM.Size = New System.Drawing.Size(333, 21)
        Me.txtJUMBLAHMALAM.TabIndex = 53
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Yellow
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(551, 96)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 17)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Jumblah Barang"
        '
        'txtTOTALBIAYA
        '
        Me.txtTOTALBIAYA.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTOTALBIAYA.Location = New System.Drawing.Point(445, 162)
        Me.txtTOTALBIAYA.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtTOTALBIAYA.Multiline = True
        Me.txtTOTALBIAYA.Name = "txtTOTALBIAYA"
        Me.txtTOTALBIAYA.ReadOnly = True
        Me.txtTOTALBIAYA.Size = New System.Drawing.Size(134, 29)
        Me.txtTOTALBIAYA.TabIndex = 55
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Yellow
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(476, 144)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 17)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "Total Biaya"
        '
        'txtNMKAMAR
        '
        Me.txtNMKAMAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNMKAMAR.Location = New System.Drawing.Point(709, 64)
        Me.txtNMKAMAR.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtNMKAMAR.Name = "txtNMKAMAR"
        Me.txtNMKAMAR.ReadOnly = True
        Me.txtNMKAMAR.Size = New System.Drawing.Size(134, 21)
        Me.txtNMKAMAR.TabIndex = 56
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(289, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(362, 31)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Silakan Isi Form untuk Memesan"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FormPenyewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(913, 454)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNMKAMAR)
        Me.Controls.Add(Me.txtTOTALBIAYA)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtJUMBLAHMALAM)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtHARGA)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtIDKAMAR)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTELEPON)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNMPENYEWA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvData)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FormPenyewa"
        Me.Text = "FormPenyewa"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtIDKAMAR As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTELEPON As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNMPENYEWA As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents txtHARGA As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtJUMBLAHMALAM As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTOTALBIAYA As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNMKAMAR As TextBox
    Friend WithEvents Label1 As Label
End Class
