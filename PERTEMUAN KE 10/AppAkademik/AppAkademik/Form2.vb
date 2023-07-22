Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload()
    End Sub

    Private Sub Reload()
        oMatakuliah.getAllData(DataGridView1)
    End Sub

    Private Sub txtKodemk_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKodemk.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            oMatakuliah.Carimatakuliah(txtKodemk.Text)
            If (matakuliah_baru = False) Then
                TampilMatakuliah()
            Else
                MessageBox.Show("Data tidak ditemukan")
                matakuliah_baru = True
            End If
        End If
    End Sub

    Private Sub TampilMatakuliah()
        txtKodemk.Text = oMatakuliah.kodemk
        txtNamaMk.Text = oMatakuliah.namamk
        txtSKS.Text = oMatakuliah.sks
        txtProdi.Text = oMatakuliah.prodi
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ClearEntry()
    End Sub

    Private Sub ClearEntry()
        txtKodemk.Clear()
        txtNamaMk.Clear()
        txtSKS.Clear()
        txtProdi.Clear()
        txtKodemk.Focus()
    End Sub

    Private Sub SimpanDataMatakuliah()
        oMatakuliah.kodemk = txtKodemk.Text
        oMatakuliah.namamk = txtNamaMk.Text
        oMatakuliah.sks = txtSKS.Text
        oMatakuliah.prodi = txtProdi.Text
        oMatakuliah.Simpan()
        Reload()
        If oMatakuliah.InsertState = True Then
            MessageBox.Show("Data berhasil disimpan.")
        ElseIf oMatakuliah.UpdateState = True Then
            MessageBox.Show("Data berhasil diperbarui.")
        Else
            MessageBox.Show("Data gagal disimpan.")
        End If
        ClearEntry()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If (txtKodemk.Text <> "" And txtNamaMk.Text <> "") Then
            SimpanDataMatakuliah()
            ClearEntry()
            Reload()
        Else
            MessageBox.Show("Kodemk dan namamk tidak boleh kosong!")
        End If
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If txtKodemk.Text <> "" Then
            Dim confirmResult As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data matakuliah?", "Konfirmasi Hapus", MessageBoxButtons.YesNo)
            If confirmResult = DialogResult.Yes Then
                oMatakuliah.kodemk = txtKodemk.Text
                oMatakuliah.Hapus()

                If oMatakuliah.DeleteState = True Then
                    MessageBox.Show("Data matakuliah berhasil dihapus.")
                    ClearEntry()
                    Reload()
                Else
                    MessageBox.Show("Gagal menghapus data matakuliah.")
                End If
            End If
        Else
            MessageBox.Show("Kodemk tidak boleh kosong.")
        End If
    End Sub

End Class
