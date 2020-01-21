Imports Npgsql

Public Class frmAlterarSenhas
    Private Sub FrmAlterarSenhas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FundoTextBox(Me)

        lblusuario.Text = "Usuário logado: " + usuariologado.ToString

    End Sub

    Private Sub EditaSenha()

        If txtsenhaantiga.Text <> senhausuario Then

            DevExpress.XtraEditors.XtraMessageBox.Show("Senha antiga INCORRETA, favor verificar!", "B-INK")

            SetControlText(txtsenhaantiga, "")
            SetControlFocus(txtsenhaantiga)

            Exit Sub

        End If

        If txtsenha.Text = "" Or TxTcontrasenha.Text = "" Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Preencha os campos NOVA SENHA e REPITA A NOVA SENHA para prosseguir!", "B-INK")

            SetControlText(txtsenha, "")
            SetControlText(TxTcontrasenha, "")
            SetControlFocus(txtsenha)

            Exit Sub
        End If

        If txtsenha.Text <> TxTcontrasenha.Text Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Nova senha e repita nova senha estão DIFERENTES, favor verificar!", "B-INK")

            SetControlText(txtsenha, "")
            SetControlText(TxTcontrasenha, "")
            SetControlFocus(txtsenha)

            Exit Sub
        End If

        Dim c As New aes_ecb(cvecb, aes_ecb.Tipo.Hexa)

        Dim sql As String = "update tbcadastrousuario set  senha =@senha where idcadastrousuario = @idcadastrousuario"
        Dim connection As New NpgsqlConnection(cnSQL)
        Dim command As New NpgsqlCommand(sql, connection)


        Try

            connection.Open()

            With command.Parameters
                .AddWithValue("@idcadastrousuario", idusuario)
                .AddWithValue("@senha", c.encrypt(GetControlText(txtsenha).Trim))

            End With

            Dim x As Integer = command.ExecuteNonQuery()
            If x >= 1 Then

                senhausuario = txtsenha.Text

                DevExpress.XtraEditors.XtraMessageBox.Show(" Dados alterados!" & vbCrLf & " Operação efetuada com sucesso!", "B-INK")

                GravaLog(Me.Text, "Editar", "O Usuário " & usuariologado & " trocou a senha de acesso")

                SetControlText(txtsenha, "")
                SetControlText(TxTcontrasenha, "")
                SetControlText(txtsenhaantiga, "")

                Me.Close()

            End If

        Catch ex As Exception
            MsgBox(ex)
        Finally
            connection.Close()
            connection = Nothing
            command = Nothing
            sql = Nothing
        End Try
    End Sub

    Private Sub BtnSair_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSair.ItemClick
        Me.Close()
    End Sub

    Private Sub BtnSalvar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick
        Dim vc As New CamposObrig(Me)

        If vc.VerificarControl(mrcPrincipal, True, True) Then

            EditaSenha()

        End If
    End Sub

    Private Sub frmAlterarSenhas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        TxTcontrasenha.Text = ""
        txtsenha.Text = ""
        txtsenhaantiga.Text = ""
    End Sub
End Class