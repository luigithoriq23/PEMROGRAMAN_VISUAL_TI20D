Public Class Form2
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If Not String.IsNullOrEmpty(usia1.Text) AndAlso Val(usia1.Text) > 15 Then
            MessageBox.Show("Usia anak-anak maksimal 15 tahun.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            RadioButton1.Checked = False
            usia1.Clear()
        End If
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If Not String.IsNullOrEmpty(usia1.Text) AndAlso Val(usia1.Text) <= 15 Then
            MessageBox.Show("Usia dewasa minimal 16 tahun.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            RadioButton2.Checked = False
            usia1.Clear()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Pesan.Click
        Dim Nama As String
        Dim Usia As Integer
        Nama = nama1.Text
        Usia = Val(usia1.Text)
        Dim harga As Integer
        If RadioButton1.Checked Then
            If Usia <= 10 Then
                harga = 5000
            Else
                harga = 10000
            End If
        ElseIf RadioButton2.Checked Then
            If Usia <= 20 Then
                harga = 15000
            Else
                harga = 20000
            End If
        End If
        txtNama2.Text = Nama
        txtUsia2.Text = Usia
        txtTotal.Text = harga.ToString("N0")
        nama1.Clear()
        usia1.Clear()
    End Sub
End Class
