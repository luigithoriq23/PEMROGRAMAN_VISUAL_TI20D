Public Class ReamurKeCelciusFahreinhitKelvin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim K, C, F, R As Decimal
        R = CDec(txtReamur.Text)
        C = ToCelcius(R)
        F = ToFahrenheit(R)
        K = ToKelvin(R)

        txtCelcius.Text = Str(C)
        txtFahrenheit.Text = Str(F)
        txtKelvin.Text = Str(K)
    End Sub

    Private Function ToCelcius(reamur As Decimal) As Decimal
        Dim C As Decimal
        C = (5 / 4) * reamur
        Return C
    End Function

    Private Function ToFahrenheit(reamur As Decimal) As Decimal
        Dim F As Decimal
        F = (9 / 4) * reamur + 32
        Return F
    End Function

    Private Function ToKelvin(reamur As Decimal) As Decimal
        Dim K As Decimal
        K = (5 / 4 * reamur) + 273
        Return K
    End Function
End Class
