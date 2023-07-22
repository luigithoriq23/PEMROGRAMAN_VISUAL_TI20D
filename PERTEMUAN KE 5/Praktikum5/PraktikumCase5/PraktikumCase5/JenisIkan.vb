Public Class JenisIkan
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Select Case txtKodeKota.Text
            Case "MJR" : txtKeterangan.Text = "Ikan Mujaer"

            Case "LL" : txtKeterangan.Text = "Ikan Lele"

            Case "PS" : txtKeterangan.Text = "Ikan PAUS"

            Case Else : txtKeterangan.Text = "Ikan Belum Terdaftar"
        End Select
    End Sub
End Class