Public Class Limas

    Private Function HitungLuas(luasAlas As Integer, sisi As Integer) As Integer
        Dim luas As Integer

        luas = luasAlas + sisi
        Return luas
    End Function

    Private Function HitungVolume(luasAlas As Integer, tinggi As Integer, sisi As Integer) As Integer
        Dim volume As Integer

        volume = 1 / 3 * luasAlas * tinggi * sisi
        Return volume
    End Function

    Private Sub Btn(sender As Object, e As EventArgs) Handles Button1.Click
        Dim luasAlas, tinggi, sisi, luas, volume As Integer

        luasAlas = Val(textLuasAlas.Text)
        tinggi = Val(textTinggi.Text)
        sisi = Val(textSisi.Text)

        luas = HitungLuas(luas, sisi)
        volume = HitungVolume(luasAlas, tinggi, sisi)

        txtLuas.Text = Str(luas)
        txtVolume.Text = Str(volume)
    End Sub
End Class
