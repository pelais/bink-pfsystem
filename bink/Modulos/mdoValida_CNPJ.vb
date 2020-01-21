Public Class mdoValida_CNPJ

    Private dadosArray() As String = {"111.111.111-11", "222.222.222-22", "333.333.333-33", "444.444.444-44", _
                                   "555.555.555-55", "666.666.666-66", "777.777.777-77", "888.888.888-88", "999.999.999-99"}

    Private Const msgErro As String = "Dados Inválidos"
    Private bValida As Boolean
    Private sCNPJ As String

    Public Property cnpj() As String
        Get
            Return sCNPJ
        End Get
        Set(ByVal Valor As String)
            bValida = ValidaCNPJ(Valor)
            If bValida Then
                sCNPJ = Valor
            Else
                MsgBox("CNPJ inválido, por favor verifique!", MsgBoxStyle.Information)
            End If
        End Set
    End Property

    Public ReadOnly Property isCnpjValido() As Boolean
        Get
            bValida = ValidaCNPJ(cnpj)
            If bValida Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property

    Private Function ValidaCNPJ(ByVal CNPJ As String) As Boolean

        Dim i As Integer
        Dim valida As Boolean

        CNPJ = CNPJ.Trim

        For i = 0 To dadosArray.Length - 1
            If CNPJ.Length <> 18 Or dadosArray(i).Equals(CNPJ) Then
                Return False
            End If
        Next

        CNPJ = CNPJ.Substring(0, 2) + CNPJ.Substring(3, 3) + CNPJ.Substring(7, 3) + CNPJ.Substring(11, 4) + CNPJ.Substring(16)
        valida = efetivaValidacao(CNPJ)

        If valida Then
            ValidaCNPJ = True
        Else
            ValidaCNPJ = False
        End If

    End Function

    Private Function efetivaValidacao(ByVal cnpj As String)
        Dim Numero(13) As Integer
        Dim soma As Integer
        Dim i As Integer
        Dim resultado1 As Integer
        Dim resultado2 As Integer

        For i = 0 To Numero.Length - 1
            Numero(i) = CInt(cnpj.Substring(i, 1))
        Next

        soma = Numero(0) * 5 + Numero(1) * 4 + Numero(2) * 3 + Numero(3) * 2 + Numero(4) * 9 + Numero(5) * 8 + Numero(6) * 7 + Numero(7) * 6 + Numero(8) * 5 + Numero(9) * 4 + Numero(10) * 3 + Numero(11) * 2
        soma = soma - (11 * (Int(soma / 11)))
        If soma = 0 Or soma = 1 Then
            resultado1 = 0
        Else
            resultado1 = 11 - soma
        End If

        If resultado1 = Numero(12) Then
            soma = Numero(0) * 6 + Numero(1) * 5 + Numero(2) * 4 + Numero(3) * 3 + Numero(4) * 2 + Numero(5) * 9 + Numero(6) * 8 + Numero(7) * 7 + Numero(8) * 6 + Numero(9) * 5 + Numero(10) * 4 + Numero(11) * 3 + Numero(12) * 2
            soma = soma - (11 * (Int(soma / 11)))
            If soma = 0 Or soma = 1 Then
                resultado2 = 0
            Else
                resultado2 = 11 - soma
            End If
            If resultado2 = Numero(13) Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

End Class
