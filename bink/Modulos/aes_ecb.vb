Imports System.Security.Cryptography
Imports System.Text

Public Class aes_ecb
    Private keyBytes As Byte()

    Private t As Tipo
    Private e As Encod

    Public Sub New(keyString As String, t As Tipo, e As Encod)
        Me.t = t
        Me.e = e

        If e = Encod.[Default] Then
            Me.keyBytes = Encoding.Default.GetBytes(keyString)
        Else
            Me.keyBytes = Encoding.UTF8.GetBytes(keyString)

        End If
    End Sub

    Public Sub New(keyString As String, t As Tipo)
        Me.t = t
        Me.e = Encod.Default

        Me.keyBytes = Encoding.Default.GetBytes(keyString)
    End Sub

    Public Enum Tipo
        Hexa
        Base64
    End Enum

    Public Enum Encod
        [Default]
        UTF8
    End Enum

    Private Shared Function paraHex(buf As Byte()) As String
        Dim sb As New StringBuilder(buf.Length * 2)
        For i As Integer = 0 To buf.Length - 1
            If buf(i) < &H10 Then
                sb.Append("0")
            End If
            sb.AppendFormat("{0:X}", buf(i))
        Next
        Return sb.ToString()
    End Function

    Private Function deHex(s As String) As Byte()
        Dim len As Integer = s.Length
        Dim data As Byte() = New Byte(len / 2 - 1) {}
        For i As Integer = 0 To len - 1 Step 2
            data(i / 2) = CByte((Convert.ToInt32(s(i).ToString(), 16) << 4) + Convert.ToInt32(s(i + 1).ToString(), 16))
        Next
        Return data
    End Function

    Public Function encrypt(textString As String) As String

        If textString <> "" Then
            Dim textBytes As Byte()

            If e = Encod.Default Then
                textBytes = Encoding.Default.GetBytes(nullPadString(textString))
            Else
                textBytes = Encoding.UTF8.GetBytes(nullPadString(textString))
            End If

            Dim rijndaelCipher As New RijndaelManaged()
            rijndaelCipher.Mode = CipherMode.ECB
            rijndaelCipher.Padding = PaddingMode.None
            rijndaelCipher.Key = keyBytes

            Dim transform As ICryptoTransform = rijndaelCipher.CreateEncryptor()
            Dim encrypted As Byte() = transform.TransformFinalBlock(textBytes, 0, textBytes.Length)

            If t = Tipo.Base64 Then
                Return Convert.ToBase64String(encrypted)
            Else
                Return paraHex(encrypted)
            End If
        Else
            Return ""
        End If
    End Function

    Public Function decrypt(textString As String) As String

        If textString <> "" Then

            Dim textBytes As Byte()

            If t = Tipo.Base64 Then
                textBytes = Convert.FromBase64String(textString)
            Else
                textBytes = deHex(textString)
            End If

            Dim rijndaelCipher As New RijndaelManaged()
            rijndaelCipher.Mode = CipherMode.ECB
            rijndaelCipher.Padding = PaddingMode.None
            rijndaelCipher.Key = keyBytes

            Dim transform As ICryptoTransform = rijndaelCipher.CreateDecryptor()
            Dim encrypted As Byte() = transform.TransformFinalBlock(textBytes, 0, textBytes.Length)

            If e = Encod.[Default] Then
                Return System.Text.Encoding.[Default].GetString(encrypted).ToString().Replace(Chr(0).ToString(), "")
            Else
                Return System.Text.Encoding.UTF8.GetString(encrypted).ToString().Replace(Chr(0).ToString(), "")
            End If
        Else
            Return ""
        End If

    End Function


    Private Function nullPadString(original As [String]) As [String]
        Dim output As New StringBuilder(original)
        Dim remain As Integer = output.Length Mod 16
        If remain <> 0 Then
            remain = 16 - remain
            For i As Integer = 0 To remain - 1
                output.Append(Chr(0))
            Next
        End If
        Return output.ToString()
    End Function
End Class
