Imports Npgsql

Module mdoEmail
    Dim idemail As Integer = 0
    Public email As String = ""
    Public emailsenha As String = ""
    Public serversmtp As String = ""
    Public emailssl As Boolean = False
    Public emailporta As String = ""

    Public Sub consultaEmail()
        Try
            Dim sql As String = "select * from tbcademail"
            Dim connection As New NpgsqlConnection(cnSQL)
            Dim command As New NpgsqlCommand(sql, connection)

            Try
                connection.Open()

                Dim reader As NpgsqlDataReader = command.ExecuteReader
                If reader.HasRows Then
                    reader.Read()
                    idemail = reader.Item("idcademail").ToString
                    email = reader.Item("email").ToString
                    emailsenha = reader.Item("emailsenha").ToString
                    serversmtp = reader.Item("serversmtp").ToString
                    emailporta = reader.Item("emailporta").ToString
                End If
            Finally
            End Try

        Catch x As Exception
            msgbox(x)
        Finally
        End Try
    End Sub
End Module
