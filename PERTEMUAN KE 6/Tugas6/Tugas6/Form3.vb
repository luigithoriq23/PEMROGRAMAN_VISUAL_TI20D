Public Class Form3
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim nama As String
        Dim hargaBarang, jumlahBarang, totalHarga As Integer
        nama = txtPakaian.Text
        hargaBarang = CInt(txtHargaBarang.Text)
        jumlahBarang = CInt(txtJumlahBarang.Text)
        totalHarga = hargaBarang * jumlahBarang
        txtPesanan.Text = nama
        If chkMember.Checked Then
            Dim diskon As Integer = CInt(totalHarga * 0.1)
            totalHarga -= diskon
        End If
        txtTotalHarga.Text = totalHarga.ToString()
    End Sub
End Class
