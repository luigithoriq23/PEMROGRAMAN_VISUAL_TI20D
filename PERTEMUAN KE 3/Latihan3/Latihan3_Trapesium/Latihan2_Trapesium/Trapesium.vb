Public Class Trapesium
    Private Sub BtnHitung(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tinggi, sisiKiri, sisiAtas, sisiKanan, sisiBawah, luas, keliling As Integer

        tinggi = Val(textTinggi.Text)
        sisiKiri = Val(textSisi1.Text)
        sisiAtas = Val(textSisi2.Text)
        sisiKanan = Val(textSisi3.Text)
        sisiBawah = Val(textSisi4.Text)

        luas = 0.5 * (sisiAtas + sisiBawah) * tinggi
        keliling = sisiKiri + sisiAtas + sisiKanan + sisiBawah

        txtLuas.Text = Str(luas)
        txtKeliling.Text = Str(keliling)
    End Sub
End Class
