Public Class ReamurKeKelvin

    Private Function HitungKelvin(reamur As Integer) As Integer
        Dim kelvin As Integer
        kelvin = (5 / 4) * reamur + 273
        Return kelvin
    End Function
    Private Sub btn(sender As Object, e As EventArgs) Handles konvert.Click
        Dim reamur, kelvin As Integer

        reamur = Val(textReamur.Text)

        kelvin = HitungKelvin(reamur)

        txtKelvin.Text = kelvin.ToString("#,##0.##") & " K"
    End Sub
End Class
