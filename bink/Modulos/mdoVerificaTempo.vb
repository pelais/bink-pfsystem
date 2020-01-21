Module mdoVerificaTempo

    Public VerificaSenha As Boolean = False

    Public Function VerificaTempo() As Boolean

        If minutos = 2 And segundos = 0 Then

            VerificaSenha = True

            AbrirLogin()

            Return Not VerificaSenha

        Else
            Return True
        End If

    End Function

    Delegate Sub dAbrirLogin()
    Private Sub AbrirLogin()

        If frmLogin.InvokeRequired Then

            frmLogin.Invoke(New dAbrirLogin(AddressOf AbrirLogin))

        Else
            frmLogin.ShowDialog()
        End If

    End Sub

End Module