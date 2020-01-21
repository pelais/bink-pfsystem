Imports Npgsql

Public Class csEmpresa
    Public Sub New()
        info_empresa()
    End Sub

    Public Property idempresa As Integer = 0
    Public Property empresa As String = ""
    Public Property endereco As String = ""
    Public Property numero As String = ""
    Public Property bairro As String = ""
    Public Property cidade As String = ""
    Public Property uf As String = ""
    Public Property cep As String = ""
    Public Property cnpj As String = ""
    Public Property telefone As String = ""
    Public Property celular As String = ""
    Public Property email As String = ""
    Public Property complemento As String = ""
    Public Property emailsenha As String = ""
    Public Property serversmtp As String = ""
    Public Property emailporta As Integer = 0
    Public Property emailssl As Boolean = False
    Public Property emailtls As Boolean = False
    Public Property emailautentic As Boolean = False
    Public Property email_timeout As Integer = 0
    Public Property datacadastro As Date

    Private Sub info_empresa()

        Dim SQL As String = "select * from tbcadastroempresa"
        Dim connection As New NpgsqlConnection(cnSQL)
        Dim command As New NpgsqlCommand(SQL, connection)

        Try

            connection.Open()

            Dim r As NpgsqlDataReader = command.ExecuteReader

            If r.Read() Then

                idempresa = r.Item("idempresa")
                empresa = r.Item("empresa")
                endereco = r.Item("endereco")
                numero = r.Item("numero")
                bairro = r.Item("bairro")
                cidade = r.Item("cidade")
                uf = r.Item("uf")
                cep = r.Item("cep")
                cnpj = r.Item("cnpj")
                telefone = r.Item("telefone")
                celular = r.Item("celular")
                email = r.Item("email")
                complemento = r.Item("complemento")
                emailautentic = r.Item("emailautentic")
                emailporta = r.Item("emailporta")
                emailssl = r.Item("emailssl")
                emailtls = r.Item("emailtls")
                email_timeout = r.Item("email_timeout")
                serversmtp = r.Item("serversmtp")
                emailsenha = r.Item("emailsenha")


            End If

        Catch ex As Exception
            MsgBox(ex)
        Finally
            SQL = Nothing
            connection.Close()
            command = Nothing
        End Try

    End Sub
End Class
