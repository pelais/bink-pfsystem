Imports Npgsql

Module mdoAutoCompletar


    ''COMPLETA NOME CLIENTE NO AGENDAMENTO
    Public Sub autocompletarNomeAgendamento(ByVal CAMPOTEXTO As TextBox)

        Dim sql As String = "select nome from tbcadastrocliente"
        Dim connection As New NpgsqlConnection(cnSQL)
        Dim command As New NpgsqlCommand(sql, connection)

        Try

            connection.Open()
            Dim reader As NpgsqlDataReader = command.ExecuteReader

            While reader.Read
                CAMPOTEXTO.AutoCompleteCustomSource.Add(reader.Item("nome"))
            End While

            connection.Close()
            command = Nothing
            connection = Nothing
            sql = Nothing

        Catch ex As Exception
            MsgBox(ex)
        Finally
        End Try
    End Sub

    ''COMPLETA SERVICO NO AGENDAMENTO
    Public Sub autocompletarServicoAgendamento(ByVal CAMPOTEXTO As TextBox)

        Dim sql As String = "select servico from tbcadservico"
        Dim connection As New NpgsqlConnection(cnSQL)
        Dim command As New NpgsqlCommand(sql, connection)

        Try

            connection.Open()
            Dim reader As NpgsqlDataReader = command.ExecuteReader

            While reader.Read
                CAMPOTEXTO.AutoCompleteCustomSource.Add(reader.Item("servico"))
            End While

            connection.Close()
            command = Nothing
            connection = Nothing
            sql = Nothing

        Catch ex As Exception
            MsgBox(ex)
        Finally
        End Try
    End Sub


    ''AUTOCOMPLETA NOME DO CLIENTE LANCAMENTO
    Public Sub autocompletaClienteLancamento(ByVal CAMPOTEXTO As TextBox)

        Dim sql As String = "select nomecliente from tblancamento"
        Dim connection As New NpgsqlConnection(cnSQL)
        Dim command As New NpgsqlCommand(sql, connection)

        Try

            connection.Open()
            Dim reader As NpgsqlDataReader = command.ExecuteReader

            While reader.Read
                CAMPOTEXTO.AutoCompleteCustomSource.Add(reader.Item("nomecliente"))
            End While

            connection.Close()
            command = Nothing
            connection = Nothing
            sql = Nothing

        Catch ex As Exception
            MsgBox(ex)
        Finally
        End Try
    End Sub

End Module
