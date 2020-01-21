Module mdoSoLetrasNumeros
    Public Sub Letras(ByRef e As System.Windows.Forms.KeyPressEventArgs)

        If Char.IsLetter(e.KeyChar) Then

            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Or Asc(e.KeyChar) = 32 Then

            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Public Sub numeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)

        If Char.IsDigit(e.KeyChar) Then

            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then

            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

End Module
