Public Class FahreinhitKeReamur
    Private Function HitungReamur(farenhit As Integer) As Integer
        Dim reamur As Integer
        reamur = (4 / 9) * (farenhit - 32)
        Return reamur
    End Function
    Private Sub Btn(sender As Object, e As EventArgs) Handles Konvert.Click
        Dim farenhit, reamur As Integer
        farenhit = Val(textFht.Text)
        reamur = HitungReamur(farenhit)
        txtReamur.Text = reamur.ToString("#,##0.##") & " R"
    End Sub
End Class
