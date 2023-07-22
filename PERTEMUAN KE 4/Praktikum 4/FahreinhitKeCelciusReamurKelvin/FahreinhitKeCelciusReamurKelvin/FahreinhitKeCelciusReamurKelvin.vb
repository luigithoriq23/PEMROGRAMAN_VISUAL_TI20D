Public Class FahreinhitKeCelciusReamurKelvin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim F, C, R, K As Decimal

        F = CDec(txtFahreinhit.Text)
        C = ToCelcius(F)
        R = ToReamur(F)
        K = ToKelvin(F)

        txtCelcius.Text = Str(C)
        txtReamur.Text = Str(R)
        txtKelvin.Text = Str(K)
    End Sub

    Private Function ToCelcius(fahreinhit As Decimal) As Decimal
        Dim C As Decimal
        C = 5 / 9 * (fahreinhit - 32)
        Return C
    End Function

    Private Function ToReamur(fahreinhit As Decimal) As Decimal
        Dim R As Decimal
        R = 4 / 9 * (fahreinhit - 32)
        Return R
    End Function

    Private Function ToKelvin(fahreinhit As Decimal) As Decimal
        Dim K As Decimal
        K = 5 / 9 * (fahreinhit - 32) + 273
        Return K
    End Function

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
