Imports Npgsql

Public Class csFuncoes
    Dim cnsql As String = ""

    Public Sub New(cnsql As String)

        Me.cnsql = cnsql

    End Sub

    Public Function FotoUsuario(idusuario As Integer) As Bitmap

        Try
            Dim sql As String = "select foto from tbfotofuncionario where idfuncionario = @idfuncionario"

            Dim connection As New NpgsqlConnection(cnsql)
            Dim command As New NpgsqlCommand(sql, connection)

            With command.Parameters
                .AddWithValue("@idfuncionario", idusuario)
            End With

            Try
                connection.Open()

                Dim reader As NpgsqlDataReader = command.ExecuteReader

                If reader.Read() Then

                    If reader.Item("foto") IsNot DBNull.Value Then
                        Return ByteArrayToBitmap(reader.Item("foto"))
                    Else
                        Return My.Resources.SemRosto2
                    End If
                Else
                    Return My.Resources.SemRosto2
                End If

            Finally
                connection.Close()
                command = Nothing
                connection = Nothing
                sql = Nothing
            End Try
        Catch x As Exception
            msgbox(x)
            Return My.Resources.SemRosto2
        End Try
    End Function


    Public Function FotoCliente(idcliente As Integer) As Bitmap

        Try
            Dim sql As String = "select foto from tbfotocliente where idcadcliente = @idcadcliente"

            Dim connection As New NpgsqlConnection(cnsql)
            Dim command As New NpgsqlCommand(sql, connection)

            With command.Parameters
                .AddWithValue("@idcadcliente", idcliente)
            End With

            Try
                connection.Open()

                Dim reader As NpgsqlDataReader = command.ExecuteReader

                If reader.Read() Then

                    If reader.Item("foto") IsNot DBNull.Value Then
                        Return ByteArrayToBitmap(reader.Item("foto"))
                    Else
                        Return My.Resources.SemRosto2
                    End If
                Else
                    Return My.Resources.SemRosto2
                End If

            Finally
                connection.Close()
                command = Nothing
                connection = Nothing
                sql = Nothing
            End Try
        Catch x As Exception
            msgbox(x)
            Return My.Resources.SemRosto2
        End Try
    End Function
End Class
