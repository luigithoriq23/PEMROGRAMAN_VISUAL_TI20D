Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Dim Mutu, Nim, Nama, Prodi As String
        Dim NA, NKHD, TGS, UTS, UAS As Integer

        Nim = texNim.Text
        Nama = textNama.Text
        Prodi = textProdi.Text
        NKHD = Val(textNKHD.Text)
        TGS = Val(textTGS.Text)
        UTS = Val(textUTS.Text)
        UAS = Val(textUAS.Text)
        NA = Mencari(NKHD, TGS, UTS, UAS)        Mutu = NilaiMutu(NA)
        txtNim1.Text = Str(Nim)
        txtNama1.Text = Nama
        txtProdi1.Text = Prodi

        txtNA.Text = Str(NA)
        txtMutu.Text = Mutu
    End Sub
    Private Function Mencari(NKHD As Integer, TGS As Integer, UTS As Integer, UAS As Integer) As Integer
        Dim NA As Integer = (25D / 100D * NKHD) + (35D / 100D * TGS) + (20D / 100D * UTS) + (20D / 100D * UAS)
        Return NA
    End Function

    Private Function NilaiMutu(NA As Decimal) As String
        If NA >= 80D And NA <= 100D Then
            Return "A"
        ElseIf NA >= 68D And NA < 80D Then
            Return "B"
        ElseIf NA >= 56D And NA < 68D Then
            Return "C"
        ElseIf NA >= 45D And NA < 56D Then
            Return "D"
        Else
            Return "E"
        End If
    End Function
End Class
