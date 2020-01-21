Imports Npgsql
Imports System.IO
Module mdoCarregaImagens

    Dim idcadimagem As Integer = 0
    Public icone_form As String = ""
    Public logo_principal As Image
    Public logo_recibo As String = ""

    Public Function VoltaFotos(ByVal foto() As Byte) As Bitmap
        If Not IsDBNull(foto) Then
            Dim ms As New MemoryStream(foto)
            Dim bmp As New Bitmap(ms)
            Return bmp
        Else
            Return Nothing
        End If
    End Function
    Public Sub ConsultaImagem()
        Dim sql As String = "select * from tbcadimagem"
        Dim connection As New NpgsqlConnection(cnSQL)
        Dim command As New NpgsqlCommand(sql, connection)
        Try
            connection.Open()

            Dim reader As NpgsqlDataReader = command.ExecuteReader
            If reader.HasRows Then
                reader.Read()

                If IsDBNull(reader.Item("logoprincipa")) Then
                    logo_principal = Nothing
                Else
                    logo_principal = VoltaFotos(reader.Item("logoprincipa"))
                End If
                'icone_form = (reader.Item("iconeform"))
                'logo_principal = (reader.Item("logoprincipa"))
                'logo_recibo = (reader.Item("logorecibo"))

            End If

        Catch x As Exception
            MessageBox.Show("Erro: " + x.Message)
        Finally
            connection.Close()
            command = Nothing
            connection = Nothing
            sql = Nothing
        End Try
    End Sub
End Module
