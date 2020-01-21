Imports System.IO
Imports Npgsql
Imports System.Text

Module mdoConexao

    Public cnSQL As String = ""
    Public Server As String = ""
    Public Database As String = ""
    Public User As String = ""
    Public Password As String = ""

    Public Function cv() As Byte()
        Return ASCIIEncoding.ASCII.GetBytes(My.Resources.cv)
    End Function

    Public Function cvecb() As String
        Dim c As New aes_ecb(My.Resources.cv, aes_ecb.Tipo.Base64)
        Return c.decrypt(My.Resources.cvecb)
    End Function

    Public Function main() As Boolean

        Dim dt As New DataSet

        Try

            dt.RemotingFormat = SerializationFormat.Xml

            Dim c As New aes

            If Not Directory.Exists("c:\configBink") Then
                Directory.CreateDirectory("c:\configBink")
            End If

            If Not File.Exists("c:\configBink\conexao.xml") Then
                File.Copy(My.Application.Info.DirectoryPath & "\conexao.xml", "c:\configBink\conexao.xml", True)
            End If

            dt.ReadXml("c:\configBink\conexao.xml", XmlReadMode.Auto)

            Server = c.decrypt(dt.Tables(0).Rows(0)("servidor"), cv, cv)
            Database = c.decrypt(dt.Tables(0).Rows(0)("banco"), cv, cv)
            User = c.decrypt(dt.Tables(0).Rows(0)("login"), cv, cv)
            Password = c.decrypt(dt.Tables(0).Rows(0)("senha"), cv, cv)

            cnSQL = "Server=" & Server & "; Database=" & Database & "; user id=" & User & "; password=" & Password & ";  Pooling=true; MinPoolSize= 0; MaxPoolSize=100; CommandTimeout=900; Timeout=15; ApplicationName=" & My.Application.Info.Title & ";"

            Dim con As New NpgsqlConnection(cnSQL)

            Try
                con.Open()
                Return True
            Catch ex As Exception
                Return False
            Finally
                con.Close()
            End Try

        Catch ex As Exception
            msgbox(ex)
            Return False
        Finally
            dt.Clear()
            dt.Dispose()
        End Try

    End Function

End Module