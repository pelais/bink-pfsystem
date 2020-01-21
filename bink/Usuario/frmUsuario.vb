Imports DevExpress.XtraLayout
Imports DevExpress.XtraLayout.Helpers
Imports System.ComponentModel.DataAnnotations
Imports System.IO
Imports Npgsql
Imports System.ComponentModel




Partial Public Class frmUsuario

    Private IdUsua As Integer = 0
    Dim teste As Integer = 0
    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Not bgwCarregaUsu.IsBusy Then
            bgwCarregaUsu.RunWorkerAsync()
        End If

        cbonivelusuario.DataSource = nivelacesso()
        cbonivelusuario.DisplayMember = "Tipo"
        cbonivelusuario.ValueMember = "IdTipo"

    End Sub

    Private Sub BtnSair_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSair.ItemClick
        Me.Close()
    End Sub

    Public Sub atualizaGridPerfilUsuario()

        cbonivelusuario.DataSource = nivelacesso()
        cbonivelusuario.DisplayMember = "Tipo"
        cbonivelusuario.ValueMember = "IdTipo"

        If Not bgwCarregaUsu.IsBusy Then
            bgwCarregaUsu.RunWorkerAsync()
        End If

    End Sub

    Private Sub BgwCarregaUsu_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwCarregaUsu.DoWork

        SetControlVisible(DGVConsUsuario, False)
        clearRows(DGVConsUsuario)

        Dim sql As String = "select * from tbcadastrousuario inner join tbtipodeusuario on tbtipodeusuario.idtipousuario = tbcadastrousuario.idtipodeusuario"
        Dim connection As New NpgsqlConnection(cnSQL)
        Dim command As New NpgsqlCommand(sql, connection)
        Try
            connection.Open()
            Dim reader As NpgsqlDataReader = command.ExecuteReader
            If reader.HasRows Then
                While reader.Read()

                    addRow(DGVConsUsuario, New Object() {reader.Item("idcadastrousuario").ToString, reader.Item("nome").ToString, reader.Item("login").ToString, reader.Item("tipousuario").ToString, reader.Item("ativo").ToString})

                End While
            End If

        Catch x As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(x, "B-INK")
        Finally
            connection.Close()
            connection = Nothing
            command = Nothing
            sql = Nothing
        End Try
    End Sub

    Private Sub DGVConsUsuario_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVConsUsuario.CellClick
        IdUsua = DGVConsUsuario.CurrentRow.Cells(0).Value
        txtN.Text = DGVConsUsuario.CurrentRow.Cells(colNom.Index).Value
        TxTLogin.Text = DGVConsUsuario.CurrentRow.Cells(ColUsuario.Index).Value
        cbonivelusuario.Text = DGVConsUsuario.CurrentRow.Cells(coltipousuario.Index).Value
        checkAtivo.Checked = DGVConsUsuario.CurrentRow.Cells(colcheck.Index).Value
    End Sub

    Private Sub bgwCarregaUsu_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgwCarregaUsu.RunWorkerCompleted
        DGVConsUsuario.Visible = True
    End Sub

    Public Function nivelacesso() As TipoUsers

        Dim sql As String = "select tipousuario, idtipousuario from tbtipodeusuario"
        Dim connection As New NpgsqlConnection(cnSQL)
        Dim command As New NpgsqlCommand(sql, connection)
        Try
            connection.Open()
            Dim reader As NpgsqlDataReader = command.ExecuteReader

            Dim tipos As New TipoUsers

            While reader.Read

                Dim tipo As New TipoUser
                tipo.IdTipo = reader("idtipousuario")
                tipo.Tipo = reader("tipousuario")
                tipos.Add(tipo)

            End While

            Return tipos

        Catch x As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(x, "B-INK")
            Return Nothing
        Finally
            connection.Close()
            command = Nothing
            connection = Nothing
            sql = Nothing
        End Try
    End Function

    Class TipoUsers : Inherits List(Of TipoUser)
    End Class

    Class TipoUser
        Public Property IdTipo As Integer = 0
        Public Property Tipo As String = ""
    End Class

    Private Sub GravardadosUsuario(recebeidusuario As Integer)


        Dim c As New aes_ecb(cvecb, aes_ecb.Tipo.Hexa)
        Dim sql As String = "insert into tbcadastrousuario(nome, login, senha, datacadastro, idtipodeusuario, ativo) Values (@nome, @login, @senha,  @datacadastro, @idtipodeusuario, @ativo) returning idcadastrousuario"
        Dim connection As New NpgsqlConnection(cnSQL)
        Dim command As New NpgsqlCommand(sql, connection)

        connection.Open()

        Dim t As NpgsqlTransaction = connection.BeginTransaction

        command.Transaction = t

        If txtsenha.Text = "" Or TxTLogin.Text = "" Or txtN.Text = "" Or cbonivelusuario.Text = Nothing Then

            DevExpress.XtraEditors.XtraMessageBox.Show("É obrigatorio o preenchimento dos campos indicados com o ( * )", "B-INK")

            Exit Sub
        End If

        Try

            With command.Parameters
                .AddWithValue("@nome", GetControlText(txtN).Trim)
                .AddWithValue("@login", GetControlText(TxTLogin))
                .AddWithValue("@senha", c.encrypt(GetControlText(txtsenha).Trim))
                .AddWithValue("@datacadastro", Date.Now)
                .AddWithValue("@idtipodeusuario", cbonivelusuario.SelectedValue)
                .AddWithValue("@ativo", checkAtivo.Checked)
            End With

            If txtsenha.Text <> TxTcontrasenha.Text Then
                DevExpress.XtraEditors.XtraMessageBox.Show("Senha e contra senha estão diferentes, favor digite novamente!", "B-INK")

                Exit Sub

            End If

            recebeidusuario = command.ExecuteScalar()

            t.Commit()

            DevExpress.XtraEditors.XtraMessageBox.Show(" Dados cadastrados!" & vbCrLf & " Operação efetuada com sucesso!", "B-INK")

            GravaLog(Me.Text, "Gravar", "O usuário " & usuariologado & " cadastrou um novo usuário " + TxTLogin.Text)

            BtnIncluir_ItemClick(Nothing, Nothing)

            If Not bgwCarregaUsu.IsBusy Then
                bgwCarregaUsu.RunWorkerAsync()
            End If

        Catch x As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(x, "B-INK")
        Finally
            connection.Close()
            connection = Nothing
            command = Nothing
            sql = Nothing
        End Try

    End Sub

    Private Sub BtnSalvar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick
        Dim vc As New CamposObrig(Me)

        If vc.VerificarControl(GroupBox1, True, True) Then

            If IdUsua <> 0 Then
                EditarUsuario()
            Else
                GravardadosUsuario(IdUsua)
            End If

        End If
    End Sub

    Private Sub BtnIncluir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnIncluir.ItemClick

        txtN.Text = ""
        TxTLogin.Text = ""
        txtsenha.Text = ""
        TxTcontrasenha.Text = ""
        cbonivelusuario.Text = ""
        cbonivelusuario.Text = Nothing

        If Not bgwCarregaUsu.IsBusy Then
            bgwCarregaUsu.RunWorkerAsync()
        End If

        IdUsua = 0

    End Sub


    Public Sub EditarUsuario()

        Dim c As New aes_ecb(cvecb, aes_ecb.Tipo.Hexa)
        Dim sql As String = "update tbcadastrousuario set nome =@nome, login =@login, senha =@senha, idtipodeusuario = @idtipodeusuario, ativo = @ativo where idcadastrousuario = @idcadastrousuario"
        Dim connection As New NpgsqlConnection(cnSQL)
        Dim command As New NpgsqlCommand(sql, connection)

        Try

            connection.Open()

            With command.Parameters
                .AddWithValue("@idcadastrousuario", IdUsua)
                .AddWithValue("@nome", GetControlText(txtN))
                .AddWithValue("@login", GetControlText(TxTLogin))
                .AddWithValue("@senha", c.encrypt(GetControlText(txtsenha).Trim))
                .AddWithValue("@idtipodeusuario", cbonivelusuario.SelectedValue)
                .AddWithValue("@ativo", checkAtivo.Checked)
            End With

            If txtsenha.Text = "" Or TxTcontrasenha.Text = "" Then
                DevExpress.XtraEditors.XtraMessageBox.Show("Preencha os campos SENHA e REPITA A SENHA para prosseguir!", "B-INK")
                Exit Sub
            Else
                If txtsenha.Text <> TxTcontrasenha.Text Then

                    txtsenha.Focus()



                    DevExpress.XtraEditors.XtraMessageBox.Show("Os campos SENHA e REPITA A SENHA estão diferentes, favor digite novamente!", "B-INK")
                    Exit Sub
                End If

            End If

            Dim x As Integer = command.ExecuteNonQuery()
            If x >= 1 Then

                DevExpress.XtraEditors.XtraMessageBox.Show(" Dados alterados!" & vbCrLf & " Operação efetuada com sucesso!", "B-INK")

                GravaLog(Me.Text, "Editar", "O Usuário " & usuariologado & " editou o Cadastro do usuário " + TxTLogin.Text)

                If Not bgwCarregaUsu.IsBusy Then
                    bgwCarregaUsu.RunWorkerAsync()
                End If

                BtnIncluir_ItemClick(Nothing, Nothing)
            End If

        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(ex, "B-INK")
        Finally
            connection.Close()
            connection = Nothing
            command = Nothing
            sql = Nothing
        End Try
    End Sub


    Private Sub excluiUsuario()


        Dim SQL As String = "Delete from tbcadastrousuario Where idcadastrousuario = @idcadastrousuario"
        Dim connection As New NpgsqlConnection(cnSQL)
        Dim command As New NpgsqlCommand(SQL, connection)

        With command.Parameters

            .AddWithValue("@idcadastrousuario", IdUsua)

        End With

        Try

            connection.Open()

            Dim x As Integer = command.ExecuteNonQuery()
            If x >= 1 Then


                DevExpress.XtraEditors.XtraMessageBox.Show("Dados excluídos!" & vbCrLf & "Operação efetuada com sucesso!", "B-INK")

                GravaLog(Me.Text, "Excluir", "O Usuário " & usuariologado & " excluiu o cadastro do usuário " + TxTLogin.Text)

                BtnIncluir_ItemClick(Nothing, Nothing)

            End If

        Catch x As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(x, "B-INK")
        Finally
            connection.Close()
            connection = Nothing
            command = Nothing
            SQL = Nothing
        End Try
    End Sub

    Private Sub BtnExcluir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcluir.ItemClick
        If IdUsua = 0 Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Por favor selecione o usuário que deseja exlcuir na aba abaixo.", "B-INK")
        Else
            If DevExpress.XtraEditors.XtraMessageBox.Show("Deseja excluir realmente exluir o usuário " + TxTLogin.Text + "?", "B-INK", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                excluiUsuario()
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub BtnTelaCadPerfil_Click(sender As Object, e As EventArgs) Handles btnTelaCadPerfil.Click
        frmTipoUsuario.ShowDialog()
    End Sub

End Class
