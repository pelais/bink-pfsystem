Public Class NumeroPorExtenso
    Public Function EscreverNumero(ByVal Numero As Decimal) As String
        Dim cent As Integer
        Try
            ' se for =0 retorna 0 reais
            If Numero = 0 Then
                Return "Zero Reais"
            End If
            ' Verifica a parte decimal, ou seja, os centavos
            cent = Decimal.Round((Numero - Int(Numero)) * 100, MidpointRounding.ToEven)
            ' Verifica apenas a parte inteira
            Numero = Int(Numero)
            ' Caso existam centavos
            If cent > 0 Then
                ' Caso seja 1 não coloca "Reais" mas sim "Real"
                If Numero = 1 Then
                    Return "Um Real e " + Centavos(cent) + "centavos"
                    ' Caso o valor seja inferior a 1 Real
                ElseIf Numero = 0 Then
                    Return Centavos(cent) + "centavos"
                Else
                    Return Inteiro(Numero) + "Reais e " + Centavos(cent) + "centavos"
                End If
            Else
                ' Caso seja 1 não coloca "Reais" mas sim "Real"
                If Numero = 1 Then
                    Return "Um Real"
                Else
                    Return Inteiro(Numero) + "Reais"
                End If
            End If
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function Centavos(ByVal Numero As Byte) As String
        Try
            Select Case Numero
                Case 0
                    Return ""
                Case 1 To 19
                    Dim strArray() As String =
                       {"Um", "Dois", "Três", "Quatro", "Cinco", "Seis",
                        "Sete", "Oito", "Nove", "Dez", "Onze",
                        "Doze", "Treze", "Quatorze", "Quinze",
                        "Dezesseis", "Dezessete", "Dezoito", "Dezenove"}
                    Return strArray(Numero - 1) + " "
                Case 20 To 99
                    Dim strArray() As String =
                        {"Vinte", "Trinta", "Quarenta", "Cinquenta",
                        "Sessenta", "Setenta", "Oitenta", "Noventa"}
                    If (Numero Mod 10) = 0 Then
                        Return strArray(Numero \ 10 - 2) + " "
                    Else
                        Return strArray(Numero \ 10 - 2) + " e " + Centavos(Numero Mod 10) + " "
                    End If
                Case Else
                    Return ""
            End Select
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function Inteiro(ByVal Numero As Decimal) As String
        Try
            Numero = Int(Numero)
            Select Case Numero
                Case Is < 0
                    Return "-" & Inteiro(-Numero)
                Case 0
                    Return ""
                Case 1 To 19
                    Dim strArray() As String =
                        {"Um", "Dois", "Três", "Quatro", "Cinco", "Seis",
                        "Sete", "Oito", "Nove", "Dez", "Onze", "Doze",
                        "Treze", "Quatorze", "Quinze", "Dezesseis",
                        "Dezessete", "Dezoito", "Dezenove"}
                    Return strArray(Numero - 1) + " "
                Case 20 To 99
                    Dim strArray() As String =
                        {"Vinte", "Trinta", "Quarenta", "Cinquenta",
                        "Sessenta", "Setenta", "Oitenta", "Noventa"}
                    If (Numero Mod 10) = 0 Then
                        Return strArray(Numero \ 10 - 2)
                    Else
                        Return strArray(Numero \ 10 - 2) + " e " + Inteiro(Numero Mod 10)
                    End If
                Case 100
                    Return "Cem"
                Case 101 To 999
                    Dim strArray() As String =
                           {"Cento", "Duzentos", "Trezentos", "Quatrocentos", "Quinhentos",
                           "Seiscentos", "Setecentos", "Oitocentos", "Novecentos"}
                    If (Numero Mod 100) = 0 Then
                        Return strArray(Numero \ 100 - 1) + " "
                    Else
                        Return strArray(Numero \ 100 - 1) + " e " + Inteiro(Numero Mod 100)
                    End If
                Case 1000 To 1999
                    Select Case (Numero Mod 1000)
                        Case 0
                            Return "Mil"
                        Case Is <= 100
                            Return "Mil e " + Inteiro(Numero Mod 1000)
                        Case Else
                            Return "Mil, " + Inteiro(Numero Mod 1000)
                    End Select
                Case 2000 To 999999
                    Select Case (Numero Mod 1000)
                        Case 0
                            Return Inteiro(Numero \ 1000) & "Mil"
                        Case Is <= 100
                            Return Inteiro(Numero \ 1000) & "Mil e " & Inteiro(Numero Mod 1000)
                        Case Else
                            Return Inteiro(Numero \ 1000) & "Mil, " & Inteiro(Numero Mod 1000)
                    End Select
                Case 1000000 To 1999999
                    Select Case (Numero Mod 1000000)
                        Case 0
                            Return "Um Milhão"
                        Case Is <= 100
                            Return Inteiro(Numero \ 1000000) + "Milhão e " & Inteiro(Numero Mod 1000000)
                        Case Else
                            Return Inteiro(Numero \ 1000000) + "Milhão, " & Inteiro(Numero Mod 1000000)
                    End Select
                Case 2000000 To 999999999
                    Select Case (Numero Mod 1000000)
                        Case 0
                            Return Inteiro(Numero \ 1000000) + " Milhões"
                        Case Is <= 100
                            Return Inteiro(Numero \ 1000000) + "Milhões e " & Inteiro(Numero Mod 1000000)
                        Case Else
                            Return Inteiro(Numero \ 1000000) + "Milhões, " & Inteiro(Numero Mod 1000000)
                    End Select
                Case 1000000000 To 1999999999
                    Select Case (Numero Mod 1000000000)
                        Case 0
                            Return "Um Bilhão"
                        Case Is <= 100
                            Return Inteiro(Numero \ 1000000000) + "Bilhão e " + Inteiro(Numero Mod 1000000000)
                        Case Else
                            Return Inteiro(Numero \ 1000000000) + "Bilhão, " + Inteiro(Numero Mod 1000000000)
                    End Select
                Case Else
                    Select Case (Numero Mod 1000000000)
                        Case 0
                            Return Inteiro(Numero \ 1000000000) + " Bilhões"
                        Case Is <= 100
                            Return Inteiro(Numero \ 1000000000) + "Bilhões e " + Inteiro(Numero Mod 1000000000)
                        Case Else
                            Return Inteiro(Numero \ 1000000000) + "Bilhões, " + Inteiro(Numero Mod 1000000000)
                    End Select
            End Select
        Catch ex As Exception
            Return ""
        End Try
    End Function

End Class
