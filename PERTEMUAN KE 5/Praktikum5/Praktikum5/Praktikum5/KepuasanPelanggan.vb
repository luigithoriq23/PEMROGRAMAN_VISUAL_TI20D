Public Class KepuasanPelanggan
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (Val(txtRanting.Text) = 100) Then
            txtTingkatKepuasan.Text = "Sangat puas"

        ElseIf (txtRanting.Text >= 70) Then
            txtTingkatKepuasan.Text = "Puas"

        ElseIf (txtRanting.Text >= 50) Then
            txtTingkatKepuasan.Text = "Kurang Puas"

        Else
            txtTingkatKepuasan.Text = "Tidak Puas"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
