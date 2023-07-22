Public Class Balok

    Private Function HitungLuas(panjang As Integer, lebar As Integer, tinggi As Integer) As Integer
        Dim luas As Integer
        luas = 2 * ((panjang * lebar) + (panjang * tinggi) + (lebar * tinggi))
        Return luas
    End Function

    Private Function HitungVolume(panjang As Integer, lebar As Integer, tinggi As Integer) As Integer
        Dim volume As Integer
        volume = panjang * lebar * tinggi
        Return volume
    End Function

    Private Sub Btn(sender As Object, e As EventArgs) Handles Button1.Click
        Dim panjang, lebar, tinggi, luas, volume As Integer

        panjang = Val(textPanjang.Text)
        lebar = Val(textLebar.Text)
        tinggi = Val(textTinggi.Text)

        luas = HitungLuas(panjang, lebar, tinggi)
        volume = HitungVolume(panjang, lebar, tinggi)

        txtLuas.Text = Str(luas)
        txtVolume.Text = Str(volume)
    End Sub
End Class
