Public Class BelahKetupat

    Private Sub BtnHitung(sender As Object, e As EventArgs) Handles Button1.Click
        Dim diagonal1, diagonal2, sisi, luas, keliling As Integer

        diagonal1 = Val(textDiag1.Text)
        diagonal2 = Val(textDiag2.Text)

        sisi = Val(textSisi.Text)

        luas = 0.5 * diagonal1 * diagonal2
        keliling = 4 * sisi

        txtLuas.Text = (luas)
        txtKeliling.Text = (keliling)

    End Sub
End Class
