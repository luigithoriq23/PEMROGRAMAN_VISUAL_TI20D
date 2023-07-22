Public Class PredikatSiswa
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (Val(txtPredikat.Text) >= 85) Then
            txtHasil.Text = "Predikat A/Memuaskan"

        ElseIf (txtPredikat.Text >= 75) Then
            txtHasil.Text = "Predikat B/Bagus"

        ElseIf (txtPredikat.Text >= 65) Then
            txtHasil.Text = "Predikat C/Cukup"

        Else
            txtHasil.Text = "Predikat D/Kurang"
        End If
    End Sub
End Class