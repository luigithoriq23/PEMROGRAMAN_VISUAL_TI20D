Public Class Kerucut

    Private Function HitungLuas(pi As Integer, pel As Integer, jarijari As Integer, tinggi As Integer) As Integer
        Dim luas As Integer
        pi = 22 / 7
        pel = Math.Sqrt((jarijari * jarijari) + (tinggi * tinggi))
        luas = pi * jarijari * (jarijari + pel)
        Return luas
    End Function

    Private Function HitungVolume(pi As Integer, jarijari As Integer, tinggi As Integer) As Integer
        Dim volume As Integer
        pi = 22 / 7
        volume = 1 / 3 * pi * (jarijari * jarijari) * tinggi
        Return volume
    End Function

    Private Sub Btn(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pi, pel, jarijari, tinggi, luas, volume As Integer

        jarijari = Val(textJari.Text)
        tinggi = Val(textTinggi.Text)

        luas = HitungLuas(pi, pel, jarijari, tinggi)
        volume = HitungVolume(pi, jarijari, tinggi)

        txtLuas.Text = Str(luas)
        txtVolume.Text = Str(volume)
    End Sub
End Class
