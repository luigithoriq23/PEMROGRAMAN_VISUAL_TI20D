Public Class Tabung

    Private Function HitungLuas(pi As Integer, jarijari As Integer, tinggi As Integer) As Integer
        Dim luas As Integer
        pi = 22 / 7
        luas = 2 * pi * jarijari * (jarijari + tinggi)
        Return luas
    End Function

    Private Function HitungVolume(pi As Integer, jarijari As Integer, tinggi As Integer) As Integer
        Dim volume As Integer
        pi = 22 / 7
        volume = pi * jarijari * jarijari * tinggi
        Return volume
    End Function

    Private Sub Btn(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pi, jarijari, tinggi, luas, volume As Integer

        jarijari = Val(textJari.Text)
        tinggi = Val(textTinggi.Text)

        luas = HitungLuas(pi, jarijari, tinggi)
        volume = HitungVolume(pi, jarijari, tinggi)

        txtLuas.Text = Str(luas)
        txtVolume.Text = Str(volume)
    End Sub
End Class
