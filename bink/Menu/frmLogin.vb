Imports Npgsql
Imports System.IO
Imports System.Net

Public Class frmLogin

    Dim qtd As Integer = 0
    Dim logado As Boolean = False
    Dim verificaAtt As New WebClient


    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        Dim j As New JanelaExterna(Me, lblTitle)

    End Sub

    Private Sub Conexao()

        Try

            Dim c As New aes_ecb(cvecb, aes_ecb.Tipo.Hexa)

            Dim SQL As String = "Select * from tbcadastrousuario where login = @login And senha = @senha and ativo = true"
            Dim connection As New NpgsqlConnection(cnSQL)
            Dim command As New NpgsqlCommand(SQL, connection)

            Dim login As String = GetControlText(TxTLogin).Trim
            Dim senha As String = c.encrypt(GetControlText(TxTSenha).Trim)

            With command.Parameters
                .AddWithValue("@login", login)
                .AddWithValue("@senha", senha)
            End With

            Try

                connection.Open()

                Dim reader As NpgsqlDataReader = command.ExecuteReader

                If reader.Read() Then

                    idusuario = reader("idcadastrousuario")


                    senhausuario = TxTSenha.Text

                    usuariologado = TxTLogin.Text
                    logado = True

                    minutos = 5
                    segundos = 0

                    SetControlVisible(lblAvisoLogin, False)


                    GravaLog("Login", "Entrar", "O Usuário " & usuariologado & " entrou no sistema")
                    AbrirMenu()

                Else



                    SetControlText(TxTLogin, "")
                    SetControlText(TxTSenha, "")

                    SetControlFocus(TxTLogin)
                    SetControlVisible(lblAvisoLogin, True)
                    SetControlText(lblAvisoLogin, "Usuário ou senha inválido, favor verificar!")

                    If qtd <> 3 Then
                        qtd += 1

                        If qtd = 2 Then

                            lblAvisoLogin.Invoke(New MethodInvoker(Sub()
                                                                       lblAvisoLogin.ForeColor = Color.DarkBlue
                                                                   End Sub))

                        End If

                        If qtd = 3 Then
                            lblAvisoLogin.Invoke(New MethodInvoker(Sub()
                                                                       lblAvisoLogin.ForeColor = Color.Red
                                                                   End Sub))
                        End If

                    End If

                    If qtd = 3 Then

                        DevExpress.XtraEditors.XtraMessageBox.Show("O sistema será fechado!", "B-INK")

                        Me.Invoke(New MethodInvoker(Sub()
                                                        logado = True
                                                        End
                                                    End Sub))
                    End If
                End If
            Finally
                connection.Close()
                command = Nothing
                connection = Nothing
                SQL = Nothing
            End Try

        Catch x As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(x, "B-INK")
        End Try
    End Sub

    Delegate Sub dAbrirMenu()
    Private Sub AbrirMenu()
        Try
            If Me.InvokeRequired Then

                Me.Invoke(New dAbrirMenu(AddressOf AbrirMenu))

            Else
                frmMenu.Show()
                Me.Hide()
            End If
        Catch x As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(x, "B-INK")
        Finally
        End Try

    End Sub

    Delegate Sub dAFecharLogin()
    Private Sub FecharLogin()

        If Me.InvokeRequired Then

            Me.Invoke(New dAFecharLogin(AddressOf FecharLogin))

        Else
            Me.Close()
        End If

    End Sub

    Private Sub frmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If logado = False Then
            e.Cancel = True
        Else
            Dispose()
        End If

    End Sub


    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If My.Computer.Keyboard.CapsLock Then
            lblAvisoLogin.Text = "Caps Lock ligado"
        End If

        logado = False
        FundoTextBox(Me)

        TxTLogin.Select()
        TxTLogin.Focus()

    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click

        pbEntrada1.Visible = False
        SetControlImage(pbEntrada, My.Resources.spinner1)

        If main() Then

            Dim vc As New CamposObrig(Me)

            If vc.VerificarControl(Me, True, True) Then

                If Not BgwAtualiza.IsBusy Then
                    BgwAtualiza.RunWorkerAsync()
                End If

            End If
        End If
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        logado = True
        End
    End Sub

    Private Sub btnConfig_Click(sender As Object, e As EventArgs) Handles btnConfig.Click
        frmServidor.ShowDialog()
    End Sub

    Private Sub BgwAtualiza_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BgwAtualiza.DoWork
        Try

            'SetControlText(lblAviso, "O sistema está carregando as informações...")


            If Directory.Exists(My.Application.Info.DirectoryPath & "\PostgreSQl\scripts") Then

                Dim arquivos() As String = IO.Directory.GetFiles(My.Application.Info.DirectoryPath & "\PostgreSQl\scripts")

                Dim conn As New NpgsqlConnection(cnSQL)

                Try

                    conn.Open()

                    ' SetControlText(lblAviso, "Aplicando atualizações...")

                    For Each s As String In arquivos

                        Dim file As New StreamReader(s)
                        Dim a As String = file.ReadToEnd()
                        file.Close()
                        file.Dispose()

                        Dim achou As Boolean = False
                        Dim arquivo As String = get_Nome_Arquivo_Caminho(s)

                        Dim sql As String = "select script from tbatualizacaobanco where script = @arq"

                        Dim cmd As New NpgsqlCommand(sql, conn)

                        cmd.Parameters.AddWithValue("@arq", arquivo)

                        Dim r As NpgsqlDataReader = cmd.ExecuteReader

                        If r.Read Then achou = True

                        r.Close()

                        If Not achou Then

                            Dim sql2 As String = a
                            Dim cmd2 As New NpgsqlCommand(sql2, conn)

                            If cmd2.ExecuteNonQuery Then

                                sql = "insert into tbatualizacaobanco (script) values (@script)"
                                cmd = New NpgsqlCommand(sql, conn)
                                cmd.Parameters.AddWithValue("@script", arquivo)
                                cmd.ExecuteNonQuery()

                            End If

                        End If
                    Next

                Finally
                    conn.Close()
                End Try

            End If

        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(ex, "B-INK")
        End Try
    End Sub

    Private Sub BgwAtualiza_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgwAtualiza.RunWorkerCompleted
        If Not BgwCarregaLogin.IsBusy Then
            BgwCarregaLogin.RunWorkerAsync()
        End If
    End Sub

    Private Sub BgwCarregaLogin_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BgwCarregaLogin.DoWork
        Conexao()
    End Sub
End Class