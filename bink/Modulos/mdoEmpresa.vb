Imports Npgsql

Module mdoEmpresa

    Dim idempresa As Integer = 0
    Public nomeempresa As String = ""
    Public cnpj As String = ""
    Public endereco As String = ""
    Public n As String = ""
    Public bairro As String = ""
    Public celular As String = ""
    Public telefone As String = ""
    Public bmp As Image
    Public avisoversao As String
    Public idaviso As Integer = 0
    Public exibiratt As Boolean
    Public chavelicenca As String = ""

    Public Sub ConsultaEmpresa()
        Try
            Dim sql As String = "select * from tbcadastroempresa"
            Dim connection As New npgSqlconnection(cnSQL)
            Dim command As New npgSqlCommand(sql, connection)

            Try
                connection.Open()

                Dim reader As npgSqlDataReader = command.ExecuteReader
                If reader.HasRows Then

                    reader.Read()
                    idempresa = reader.Item("idempresa").ToString
                    nomeempresa = reader.Item("empresa").ToString
                    cnpj = reader.Item("cnpj").ToString
                    endereco = reader.Item("endereco").ToString
                    n = reader.Item("numero").ToString
                    bairro = reader.Item("bairro").ToString
                    celular = reader.Item("celular").ToString
                    telefone = reader.Item("telefone").ToString

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

    Public Sub consultaAtt()
        Try
            Dim sql As String = "select * from tbavisoatt"
            Dim connection As New NpgsqlConnection(cnSQL)
            Dim command As New NpgsqlCommand(sql, connection)

            Try
                connection.Open()

                Dim reader As NpgsqlDataReader = command.ExecuteReader
                If reader.HasRows Then

                    reader.Read()
                    idaviso = reader.Item("idaviso").ToString
                    avisoversao = reader.Item("versao").ToString
                    exibiratt = reader.Item("exibir").ToString
                End If
            Finally
                connection.Close()
                command = Nothing
                connection = Nothing
                sql = Nothing
            End Try
        Catch x As Exception
            MsgBox(x)
        Finally
        End Try
    End Sub

    Public Sub consultaChave()
        Try
            Dim sql As String = "select * from tbregistro"
            Dim connection As New NpgsqlConnection(cnSQL)
            Dim command As New NpgsqlCommand(sql, connection)

            Try
                connection.Open()

                Dim reader As NpgsqlDataReader = command.ExecuteReader
                If reader.HasRows Then

                    reader.Read()
                    chavelicenca = reader.Item("chave").ToString

                End If
            Finally
                connection.Close()
                command = Nothing
                connection = Nothing
                sql = Nothing
            End Try
        Catch x As Exception
            MsgBox(x)
        Finally
        End Try
    End Sub
End Module