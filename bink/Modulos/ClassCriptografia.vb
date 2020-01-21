Imports System.Security.Cryptography
Imports System.IO

Public Class ClassCriptografia
    Function encrypt(ByVal plainText As String, ByVal Key() As Byte, ByVal IV() As Byte) As String

        If plainText Is Nothing OrElse plainText.Length <= 0 Then
            Throw New ArgumentNullException("plainText")
        End If
        If Key Is Nothing OrElse Key.Length <= 0 Then
            Throw New ArgumentNullException("Key")
        End If
        If IV Is Nothing OrElse IV.Length <= 0 Then
            Throw New ArgumentNullException("Key")
        End If
        Dim aesAlg As RijndaelManaged = Nothing

        Dim msEncrypt As MemoryStream = Nothing

        Try
            aesAlg = New RijndaelManaged()
            aesAlg.Key = Key
            aesAlg.IV = IV

            Dim encryptor As ICryptoTransform = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV)

            msEncrypt = New MemoryStream()
            Using csEncrypt As New CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write)
                Using swEncrypt As New StreamWriter(csEncrypt)
                    swEncrypt.Write(plainText)
                End Using
            End Using

        Finally

            If Not (aesAlg Is Nothing) Then
                aesAlg.Clear()
            End If
        End Try

        Return Convert.ToBase64String(msEncrypt.ToArray())

    End Function


    Function decrypt(ByVal texto As String, ByVal Key() As Byte, ByVal IV() As Byte) As String

        Dim cipherText() As Byte = Convert.FromBase64String(texto)

        If cipherText Is Nothing OrElse cipherText.Length <= 0 Then
            Throw New ArgumentNullException("cipherText")
        End If
        If Key Is Nothing OrElse Key.Length <= 0 Then
            Throw New ArgumentNullException("Key")
        End If
        If IV Is Nothing OrElse IV.Length <= 0 Then
            Throw New ArgumentNullException("Key")
        End If

        Dim aesAlg As RijndaelManaged = Nothing
        Dim plaintext As String = Nothing

        Try
            aesAlg = New RijndaelManaged()
            aesAlg.Key = Key
            aesAlg.IV = IV

            Dim decryptor As ICryptoTransform = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV)

            Using msDecrypt As New MemoryStream(cipherText)
                Using csDecrypt As New CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read)
                    Using srDecrypt As New StreamReader(csDecrypt)
                        plaintext = srDecrypt.ReadToEnd()
                    End Using
                End Using
            End Using

        Finally

            If Not (aesAlg Is Nothing) Then
                aesAlg.Clear()
            End If
        End Try
        Return plaintext
    End Function
End Class