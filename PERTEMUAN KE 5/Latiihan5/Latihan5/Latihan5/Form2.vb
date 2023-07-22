Public Class Form2
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (Val(txtMasaKerja.Text) >= 20) Then
            txtKeterangan.Text = "Selamat Anda Mendapatkan 1 Rumah 2 Lantai"

        ElseIf (txtMasaKerja.Text >= 15) Then
            txtKeterangan.Text = "Selamat Anda Mendapatkan THR 50JT"

        ElseIf (txtMasaKerja.Text >= 10) Then
            txtKeterangan.Text = "Selamat Anda Mendapatkan THR 10JT"

        ElseIf (txtMasaKerja.Text >= 5) Then
            txtKeterangan.Text = "Anda mendapat Handphone Android"

        Else
            txtKeterangan.Text = "Maaf anda belum layak dapat bonus"
        End If
    End Sub
End Class