Public Class CelciusKeFahreinhit
    Private Function HitungFahreinhit(celcius As Integer) As Integer
        Dim fahreinhit As Integer
        fahreinhit = (9 / 5) * celcius + 32
        Return fahreinhit
    End Function
    Private Sub Btn(sender As Object, e As EventArgs) Handles Konvert.Click
        Dim celcius, fahreinhit As Integer

        celcius = Val(textCel.Text)
        fahreinhit = HitungFahreinhit(celcius)
        txtFahreinhit.Text = fahreinhit.ToString("#,##0.##") & " F"
    End Sub
End Class
