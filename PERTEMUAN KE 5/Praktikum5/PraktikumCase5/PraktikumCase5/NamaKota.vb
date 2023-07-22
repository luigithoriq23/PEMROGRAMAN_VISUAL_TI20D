Public Class NamaKota
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Select Case txtKodeKota.Text
            Case "JKT" : txtKeterangan.Text = "Jakarta"

            Case "CRB" : txtKeterangan.Text = "Cirebon"

            Case "BDG" : txtKeterangan.Text = "Bandung"

            Case Else : txtKeterangan.Text = "Kota Tidak Terdaftar"
        End Select
    End Sub
End Class
