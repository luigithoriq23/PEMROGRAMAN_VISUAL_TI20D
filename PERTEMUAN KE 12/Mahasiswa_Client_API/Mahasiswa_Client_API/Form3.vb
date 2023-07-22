
Imports System.Text
Imports System.Net.Http
Imports Newtonsoft.Json
Imports System.Net
Public Class Form3
    Private Sub TambahData()

        ' Set the data you want to send as key-value pairs
        Dim nidn As String = txtNIDN.Text
        Dim nama As String = txtNama.Text
        Dim jk As String = txtJK.Text
        Dim prodi As String = txtProdi.Text
        Dim jabatan As String = txtJabatan.Text

        Dim postData As String = $"nidn={nidn}&nama={nama}&jk={jk}&prodi={prodi}&jabatan={jabatan}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the POST request and get the response
            Dim responseBytes As Byte() = client.UploadData(dosen_api, "POST", byteArray)

            ' Convert the response bytes to a string
            Dim responseBody As String = Encoding.ASCII.GetString(responseBytes)

            ' Display the response
            MessageBox.Show(responseBody, "Response")
        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        End Try
        GetClear()
    End Sub

    Private Sub UpdateData()

        ' Set the data you want to send as key-value pairs
        Dim nidn As String = txtNIDN.Text
        Dim nama As String = txtNama.Text
        Dim jk As String = txtJK.Text
        Dim prodi As String = txtProdi.Text
        Dim jabatan As String = txtJabatan.Text

        Dim postData As String = $"nidn={nidn}&nama={nama}&jk={jk}&prodi={prodi}&jabatan={jabatan}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the PUT request and get the response
            Dim responseBytes As Byte() = client.UploadData(dosen_api & "?nidn=" & txtNIDN.Text, "PUT", byteArray)

            ' Convert the response bytes to a string
            Dim responseBody As String = Encoding.ASCII.GetString(responseBytes)

            ' Display the response
            MessageBox.Show(responseBody, "Response")
        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        End Try
        GetClear()
    End Sub

    Private Sub DeleteData()

        ' Set the data you want to send as key-value pairs
        Dim nidn As String = txtNIDN.Text
        Dim nama As String = txtNama.Text
        Dim jk As String = txtJK.Text
        Dim prodi As String = txtProdi.Text
        Dim jabatan As String = txtJabatan.Text

        Dim postData As String = $"nidn={nidn}&nama={nama}&jk={jk}&prodi={prodi}&jabatan={jabatan}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the PUT request and get the response
            Dim responseBytes As Byte() = client.UploadData(dosen_api & "?nidn=" & txtNIDN.Text, "DELETE", byteArray)

            ' Convert the response bytes to a string
            Dim responseBody As String = Encoding.ASCII.GetString(responseBytes)

            ' Display the response
            MessageBox.Show(responseBody, "Response")
        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        End Try
        GetClear()
    End Sub

    Private Sub GetData()
        Using client As New HttpClient()
            ' Send a GET request to the API endpoint
            Dim response As HttpResponseMessage = client.GetAsync(dosen_api & "?nidn=" & txtNIDN.Text).Result

            ' Check if the request was successful
            If response.IsSuccessStatusCode Then
                ' Read the response content as a string
                Dim jsonString As String = response.Content.ReadAsStringAsync().Result
                Try
                    If (jsonString = "[]") Then
                        dosen_baru = True
                        MessageBox.Show("Data Not Found")
                        Exit Sub
                    Else
                        dosen_baru = False
                        Exit Sub
                    End If
                Catch ex As Exception

                Finally
                    If (dosen_baru = False) Then
                        ' Deserialize the JSON into objects
                        Dim data As List(Of Dosen) = JsonConvert.DeserializeObject(Of List(Of Dosen))(jsonString)

                        ' Create textboxes dynamically and set their values
                        For Each mydata As Dosen In data
                            txtNIDN.Text = mydata.nidn
                            txtNama.Text = mydata.nama
                            txtJK.Text = mydata.jk
                            txtProdi.Text = mydata.prodi
                            txtJabatan.Text = mydata.jabatan
                        Next
                    End If

                End Try
            Else
                ' Request failed, handle the error
                MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}")

            End If
        End Using
    End Sub
    Private Sub GetClear()
        txtNIDN.Clear()
        txtNama.Clear()
        txtJK.Clear()
        txtProdi.Clear()
        txtJabatan.Clear()
        Reloaded()
        txtNIDN.Focus()
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (dosen_baru = True) Then
            TambahData()
        Else
            UpdateData()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        GetClear()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If (dosen_baru = False) Then
            Dim result As DialogResult = MessageBox.Show("Apakah data akan dihapus?", "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                DeleteData()
            Else
                MessageBox.Show("Data batal dihapus.")
            End If
        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reloaded()
    End Sub

    Private Sub Reloaded()

        ' Create a WebClient instance to make the HTTP request
        Dim client As New WebClient()

        ' Make the GET request and retrieve the response
        Dim response As String = client.DownloadString(dosen_api)

        ' Deserialize the JSON response into a list of objects
        Dim data As List(Of Dosen) = JsonConvert.DeserializeObject(Of List(Of Dosen))(response)

        ' Bind the data to the DataGridView
        dgvData.DataSource = data
    End Sub

    Private Sub txtNIM_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNIDN.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            GetData()
        End If
    End Sub

End Class
