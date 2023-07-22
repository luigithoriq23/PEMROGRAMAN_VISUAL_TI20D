Public Class Segitiga

    Private Sub Btn_hitung(sender As Object, e As EventArgs) Handles Button1.Click
        Dim alas, tinggi, sisi_1, sisi_2, sisi_3, luas, keliling As Integer

        alas = Val(textAlas.Text)
        tinggi = Val(textTinggi.Text)

        sisi_1 = Val(textSisi1.Text)
        sisi_2 = Val(textSisi1.Text)
        sisi_3 = Val(textSisi2.Text)

        luas = 0.5 * alas * tinggi
        keliling = sisi_1 + sisi_2 + sisi_3

        txtluas.Text = (luas)
        txtkeliling.Text = (keliling)

    End Sub
End Class
