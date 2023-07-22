Public Class KelvinKeCelciusFahreinhitReamur
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim K, C, F, R As Decimal
        K = CDec(txtKelvin.Text)
        C = ToCelcius(K)
        F = ToFahrenheit(K)
        R = ToReamur(K)

        txtCelcius.Text = Str(C)
        txtFahrenheit.Text = Str(F)
        txtReamur.Text = Str(R)
    End Sub

    Private Function ToCelcius(kelvin As Decimal) As Decimal
        Dim C As Decimal
        C = kelvin - 273
        Return C
    End Function

    Private Function ToFahrenheit(kelvin As Decimal) As Decimal
        Dim F As Decimal
        F = 9 / 5 * (kelvin - 273) + 32
        Return F
    End Function

    Private Function ToReamur(kelvin As Decimal) As Decimal
        Dim R As Decimal
        R = 4 / 5 * (kelvin - 273)
        Return R
    End Function
End Class
