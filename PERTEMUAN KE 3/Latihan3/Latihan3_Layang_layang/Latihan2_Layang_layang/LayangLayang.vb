Public Class LayangLayang

    Private Sub BtnHitung(sender As Object, e As EventArgs) Handles Button1.Click
        Dim panjang, lebar, diagonal1, diagonal2, luas, keliling As Integer

        panjang = Val(textPanjang.Text)
        lebar = Val(textLebar.Text)
        diagonal1 = Val(textDiag1.Text)
        diagonal2 = Val(textDiag2.Text)

        luas = (2 * panjang) + (2 * lebar)
        keliling = (diagonal1 * diagonal2) / 2

        txtLuas.Text = Str(luas)
        txtKeliling.Text = Str(keliling)

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub
End Class
