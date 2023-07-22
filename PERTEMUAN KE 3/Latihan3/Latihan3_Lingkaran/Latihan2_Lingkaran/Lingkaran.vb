Public Class Lingkaran
    Private Sub BtnHitung(sender As Object, e As EventArgs) Handles Button1.Click
        Dim jarijari, pi, luas, keliling As Integer

        jarijari = Val(textJari.Text)

        pi = 3.14
        luas = pi * (jarijari * jarijari)
        keliling = 2 * pi * jarijari

        txtLuas.Text = Str(luas)
        txtKeliling.Text = Str(keliling)

    End Sub
End Class
