Public Class Bola

    Private Function HitungLuas(pi As Integer, jarijari As Integer) As Integer
        Dim luas As Integer
        pi = 22 / 7
        luas = 4 * pi * (jarijari * jarijari)
        Return luas
    End Function

    Private Function HitungVolume(pi As Integer, jarijari As Integer) As Integer
        Dim volume As Integer
        pi = 22 / 7
        volume = 4 / 3 * pi * (jarijari * jarijari * jarijari)
        Return volume
    End Function

    Private Sub Btn(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pi, jarijari, luas, volume As Integer

        jarijari = Val(textJari.Text)
        luas = HitungLuas(pi, jarijari)
        volume = HitungVolume(pi, jarijari)

        txtLuas.Text = Str(luas)
        txtVolume.Text = Str(volume)
    End Sub
End Class
