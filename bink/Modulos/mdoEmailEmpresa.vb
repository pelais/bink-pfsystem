Imports Npgsql


Module mdoEmailEmpresa

    Dim idempresa As Integer = 0
    Public emailempresa As String = ""
    Public Sub ConsultaEmailEmprersa()
        Try
            Dim sql As String = "select * from tbcadastroempresa"
            Dim connection As New NpgsqlConnection(cnSQL)
            Dim command As New NpgsqlCommand(sql, connection)

            Try
                connection.Open()

                Dim reader As NpgsqlDataReader = command.ExecuteReader
                If reader.HasRows Then

                    reader.Read()
                    idempresa = reader.Item("idempresa").ToString
                    emailempresa = reader.Item("email").ToString

                End If
            Finally
                connection.Close()
                command = Nothing
                connection = Nothing
                sql = Nothing
            End Try
        Catch x As Exception
            msgbox(x)
        Finally
        End Try
    End Sub
End Module
