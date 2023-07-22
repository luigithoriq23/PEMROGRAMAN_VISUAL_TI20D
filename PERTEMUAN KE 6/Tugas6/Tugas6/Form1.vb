Public Class Form1
    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Dim Nama, Prodi As String
        Dim Bayar, BiayaReg, Kembalian As Integer
        Nama = textNama.Text
        Prodi = cmbProdi.SelectedItem.ToString()
        Select Case Prodi
            Case "Teknik Informatika"
                BiayaReg = 4000000
            Case "Sistem Informasi"
                BiayaReg = 3500000
            Case "Manajemen Informatika"
                BiayaReg = 3000000
            Case "Teknik Elektro"
                BiayaReg = 5000000
            Case Else
                MessageBox.Show("Prodi yang dipilih tidak valid.")
                Exit Sub
        End Select
        Bayar = Val(textBayar.Text)
        If Bayar < BiayaReg Then
            MessageBox.Show("Pembayaran kurang. anda harus membayar Rp." & BiayaReg.ToString)
            Exit Sub
        End If
        Kembalian = Bayar - BiayaReg
        txtNama1.Text = Nama
        txtProdi1.Text = Prodi
        txtBiayaReg1.Text = "Rp." & BiayaReg.ToString("N0")
        txtBayar2.Text = "Rp." & Bayar.ToString("N0")
        txtKembalian.Text = "Rp." & Kembalian.ToString("N0")
        textNama.Text = ""
        cmbProdi.SelectedIndex = -1
        textBayar.Text = ""
    End Sub
    Private Sub cmbProdi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProdi.SelectedIndexChanged
        Dim Prodi As String = ""
        If cmbProdi.SelectedItem IsNot Nothing Then
            Prodi = cmbProdi.SelectedItem.ToString()
        End If
        Select Case Prodi
            Case "Teknik Informatika"
                txtReg.Text = "4000000"
            Case "Sistem Informasi"
                txtReg.Text = "3500000"
            Case "Manajemen Informatika"
                txtReg.Text = "3000000"
            Case "Teknik Elektro"
                txtReg.Text = "5000000"
            Case Else
                txtReg.Text = ""
                MessageBox.Show("Pembayaran Berhasil")
        End Select
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbProdi.Items.Add("Teknik Informatika")
        cmbProdi.Items.Add("Sistem Informasi")
        cmbProdi.Items.Add("Manajemen Informatika")
        cmbProdi.Items.Add("Teknik Elektro")
    End Sub
End Class