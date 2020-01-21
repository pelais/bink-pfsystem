Public Class CamposObrig

    Dim CamposLivres As List(Of Control)

    Dim frm As Form

    Public Sub New(ByRef frm As Form)
        Me.frm = frm
        CamposLivres = New List(Of Control)
    End Sub

    Public Sub AddCampoLivre(ctrl As Control)
        If Not CamposLivres.Contains(ctrl) Then CamposLivres.Add(ctrl)
    End Sub

    Public Sub RemoveCampoLivre(ctrl As Control)
        If CamposLivres.Contains(ctrl) Then CamposLivres.Remove(ctrl)
    End Sub

    Private Campos As Hashtable


    Dim nomes_comps As String() = New String() {"TextBox"}

    ''' <summary>
    '''Função para verificar os campos em branco.
    ''' </summary>
    ''' <returns>Retorna Boolean</returns>
    ''' <remarks></remarks>
    Public Function VerificarForm() As Boolean

        Dim ok As Boolean = True

        setDefaultCampos()

        Campos = New Hashtable

        For Each c As Control In frm.Controls

            If nomes_comps.Contains(c.GetType.Name) And Not CamposLivres.Contains(c) And c.Enabled Then

                If c.GetType.Name = "TextBox" Then
                    Dim txt As TextBox = DirectCast(c, TextBox)
                    If txt.ReadOnly Then
                        If Not VerificarControl(c, True, False) Then
                            ok = False
                        End If
                        Continue For
                    End If
                End If


                If c.Text = Nothing Then
                    Campos.Add(c, c.BackColor)
                    ok = False
                    If c.BackColor = Color.Yellow Then
                        c.BackColor = Color.Red
                    Else
                        c.BackColor = Color.Yellow
                    End If
                End If
            End If

            If Not VerificarControl(c, True, False) Then
                ok = False
            End If
        Next

        If Not ok Then
            MessageBox.Show("Preencha todos os campos em destaque!", "CROMA", MessageBoxButtons.OK)

        End If

        Return ok

    End Function

    ''' <summary>
    ''' Função para verificar os campos em branco.
    ''' </summary>
    ''' <param name="ctr">Controle que contem os campos.</param>
    ''' <param name="msg">Não utilizar esse parâmetro.</param>
    ''' <returns>Retorna Boolean</returns>
    ''' <remarks></remarks>
    Public Function VerificarControl(ByRef ctr As Control, ByVal pintar As Boolean, Optional msg As Boolean = True) As Boolean

        Dim ok As Boolean = True

        If msg Then
            setDefaultCampos()
            Campos = New Hashtable
        End If

        For Each c As Control In ctr.Controls

            If nomes_comps.Contains(c.GetType.Name) And Not CamposLivres.Contains(c) And c.Enabled Then

                If c.GetType.Name = "TextBox" Then

                    Dim txt As TextBox = DirectCast(c, TextBox)

                    If txt.ReadOnly Then
                        If Not VerificarControl(c, pintar, False) Then
                            ok = False
                        End If
                        Continue For
                    End If
                End If


                If c.Text = Nothing Then
                    Campos.Add(c, c.BackColor)
                    ok = False
                    If pintar Then
                        If c.BackColor = Color.Yellow Then
                            c.BackColor = Color.Red
                        Else
                            c.BackColor = Color.Yellow
                        End If
                    End If
                End If

            End If

            If Not VerificarControl(c, pintar, False) Then
                ok = False
            End If
        Next

        If msg And pintar Then
            If Not ok Then
                DevExpress.XtraEditors.XtraMessageBox.Show("Preencha todos os campos em destaque!", "B-INK", MessageBoxButtons.OK)
            End If
        End If

        Return ok

    End Function

    Public Sub setDefaultCampos()

        If Campos IsNot Nothing Then

            For i As Integer = 0 To Campos.Keys.Count - 1
                Dim c As Control = Campos.Keys(i)
                c.BackColor = Campos.Values(i)
            Next

        End If
    End Sub

End Class
