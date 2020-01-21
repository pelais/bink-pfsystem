Imports Npgsql

Module mdoLog
    Public Sub GravaLog(ByVal tela As String, ByVal funcao As String, ByVal evento As String)
        Try
            Dim sql As String = "INSERT INTO TBLOG(tela, funcao, evento, hora, data, logado) Values (@tela, @funcao, @evento,@hora, @data, @logado)"
            Dim connection As New NpgsqlConnection(cnSQL)
            Dim command As New NpgsqlCommand(sql, connection)
            With command.Parameters

                .AddWithValue("@logado", usuariologado)
                .AddWithValue("@tela", tela)
                .AddWithValue("@funcao", funcao)
                .AddWithValue("@evento", evento)
                .AddWithValue("@hora", Date.Now)
                .AddWithValue("@data", Date.Now)

            End With
            Try
                connection.Open()
                Dim x As Integer = command.ExecuteNonQuery()
                If x = 1 Then

                End If
            Finally
                connection.Close()
                connection = Nothing
                command = Nothing
                sql = Nothing
            End Try
        Catch x As Exception
            msgbox(x)
        Finally
        End Try
    End Sub
End Module
