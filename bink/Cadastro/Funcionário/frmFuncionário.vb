Imports System.ComponentModel
Imports Npgsql
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Threading
Public Class frmFuncionario

    Private idfuncionario As Integer = 0
    Private Sub BtnTirarFoto_Click(sender As Object, e As EventArgs) Handles btnTirarFoto.Click

        Dim frmFoto As New frmTirarFoto

        If frmFoto.ShowDialog = Windows.Forms.DialogResult.OK Then
            PicFoto.Image = frmFoto.picCaptura2.Image
        End If

    End Sub

    Dim ofd As New OpenFileDialog
    Private Sub BtnProcurar_Click(sender As Object, e As EventArgs) Handles btnProcurar.Click
        ofd = New OpenFileDialog
        ofd.Filter = "Arquivos de Imagem|*.bmp;*.jpg;*.gif;*.png"
        ofd.FileName = ""

        If (ofd.ShowDialog() = DialogResult.OK) Then

            Dim foto As String = ofd.FileName
            Dim bmp As Image = New Bitmap(foto)
            PicFoto.Image = bmp

        End If
    End Sub

    Private Sub BtnSair_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSair.ItemClick
        Me.Close()
    End Sub

    Private Sub gravaFuncionario()
        Try

            Dim sql As String = "insert into tbcadfuncionario (nome, cpf, estado_civil, endereco, numero, bairro, cidade, uf, cep, telefone, celular, email, datacadastro, observacoes, rg, complemento) Values (@nome, @cpf, @estado_civil, @endereco, @numero, @bairro, @cidade, @uf, @cep, @telefone, @celular, @email, @datacadastro, @observacoes, @rg, @complemento)"
            Dim connection As New NpgsqlConnection(cnSQL)
            Dim command As New NpgsqlCommand(sql, connection)

            connection.Open()

            If txtNome.Text = "" Or TxTCpf.Text = "" Then
                DevExpress.XtraEditors.XtraMessageBox.Show("É necessário incluir ao menos nome e CPF do funcionário para prosseguir!", "B-INK")
                Exit Sub
            End If

            With command.Parameters
                .AddWithValue("@nome", txtNome.Text)
                .AddWithValue("@cpf", TxTCpf.Text)
                .AddWithValue("@estado_civil", TxTEstadoCivil.Text)
                .AddWithValue("@endereco", TxTEndereco.Text)
                .AddWithValue("@numero", TxtNumero.Text)
                .AddWithValue("@bairro", TxTBairro.Text)
                .AddWithValue("@cidade", TxTCidade.Text)
                .AddWithValue("@uf", txtUF.Text)
                .AddWithValue("@cep", TxTCep.Text)
                .AddWithValue("@telefone", TxTTelefone.Text)
                .AddWithValue("@celular", TxTCelular.Text)
                .AddWithValue("@email", TxTEmail.Text)
                .AddWithValue("@datacadastro", Date.Now)
                .AddWithValue("@observacoes", RicTxTObservacoes.Text)
                .AddWithValue("@rg", TxTRG.Text)
                .AddWithValue("@complemento", txtcomplemento.Text)
            End With

            Try

                Dim x As Integer = command.ExecuteNonQuery()
                If x = 1 Then

                    Consultafotousuarios()

                    DevExpress.XtraEditors.XtraMessageBox.Show("Funcionário cadastrado!" & vbCrLf & "Operação efetuada com sucesso!")

                    GravaLog(Me.Text, "Gravar", "Usuário " + usuariologado + " gravou o cadastro de funcionário!")

                    BtnLimpar_ItemClick(Nothing, Nothing)

                End If
            Finally
                connection.Close()
                connection = Nothing
                command = Nothing
                sql = Nothing
            End Try
        Catch x As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(x, "B-INK")
        Finally
        End Try
    End Sub

    Private Sub editaFuncionario()
        Try

            Dim sql As String = "update tbcadfuncionario set  nome =@nome, endereco =@endereco, numero = @numero, bairro =@bairro, cep =@cep, cpf = @cpf, telefone = @telefone, email = @email ,observacoes = @observacoes, uf = @uf, estado_civil = @estado_civil, celular = @celular, cidade = @cidade, rg = @rg, complemento = @complemento where idfuncionario = @idfuncionario"
            Dim connection As New NpgsqlConnection(cnSQL)
            Dim command As New NpgsqlCommand(sql, connection)

            With command.Parameters
                .AddWithValue("@idfuncionario", idfuncionario)
                .AddWithValue("@nome", txtNome.Text)
                .AddWithValue("@endereco", TxTEndereco.Text)
                .AddWithValue("@numero", TxtNumero.Text)
                .AddWithValue("@bairro", TxTBairro.Text)
                .AddWithValue("@cep", TxTCep.Text)
                .AddWithValue("@cpf", TxTCpf.Text)
                .AddWithValue("@telefone", TxTTelefone.Text)
                .AddWithValue("@email", TxTEmail.Text)
                .AddWithValue("@observacoes", RicTxTObservacoes.Text)
                .AddWithValue("@uf", txtUF.Text)
                .AddWithValue("@estado_civil", TxTEstadoCivil.Text)
                .AddWithValue("@celular", TxTCelular.Text)
                .AddWithValue("@cidade", TxTCidade.Text)
                .AddWithValue("@rg", TxTRG.Text)
                .AddWithValue("@complemento", txtcomplemento.Text)
            End With

            Try
                connection.Open()

                Dim x As Integer = command.ExecuteNonQuery()
                If x >= 1 Then

                    Consultafotousuarios()

                    DevExpress.XtraEditors.XtraMessageBox.Show("Cadastro do funcionário alterado com sucesso!")

                    GravaLog(Me.Text, "Editar", "O Usuário " & usuariologado & " alterou o cadastro do funcionário")

                    BtnLimpar_ItemClick(Nothing, Nothing)

                End If
            Finally
                connection.Close()
                connection = Nothing
                command = Nothing
                sql = Nothing
            End Try

        Catch x As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(x, "B-INK")
        End Try
    End Sub


    Private Sub excluiFuncionario()
        Dim SQL As String = "Delete from tbcadfuncionario Where idfuncionario = @idfuncionario"
        Dim connection As New NpgsqlConnection(cnSQL)
        Dim command As New NpgsqlCommand(SQL, connection)

        With command.Parameters
            .AddWithValue("@idfuncionario", idfuncionario)
        End With

        Try

            connection.Open()

            Dim x As Integer = command.ExecuteNonQuery()
            If x >= 1 Then


                DevExpress.XtraEditors.XtraMessageBox.Show("Funcionário excluído!" & vbCrLf & " Operação efetuada com sucesso!")

                GravaLog(Me.Text, "Excluir", "O Usuário " & usuariologado & " excluiu um funcionário cadastrado")

                BtnLimpar_ItemClick(Nothing, Nothing)

            End If

        Catch x As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show("Não é possível excluir o funcionário " + txtNome.Text + ", pois o mesmo possui dados vinculados no sistema.", "B-INK")
        Finally
            connection.Close()
            connection = Nothing
            command = Nothing
            SQL = Nothing
        End Try
    End Sub

    Private Sub BtnSalvar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick
        If idfuncionario = 0 Then
            gravaFuncionario()
        Else
            editaFuncionario()
        End If
    End Sub

    Private Sub TxTBairro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Letras(e)
    End Sub

    Private Sub TxTCidade_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Letras(e)
    End Sub

    Private Sub TxTEndereco_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Letras(e)
    End Sub

    Private Sub TxTEstadoCivil_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Letras(e)
    End Sub


    Dim WithEvents CEP As ConsultaCEP.CEP

    Private Sub CEP_BuscaCompletada(sender As Object, e As EventArgs) Handles CEP.BuscaCompletada

        If CEP.Erro = "" Then
            TxTBairro.Text = CEP.Bairro
            TxTCidade.Text = CEP.Cidade
            txtUF.Text = CEP.Estado
            TxTEndereco.Text = CEP.Logradouro
        Else
            DevExpress.XtraEditors.XtraMessageBox.Show(CEP.Erro, "B-INK")

            TxTBairro.Text = ""
            TxTCidade.Text = ""
            txtUF.Text = Nothing
            TxTEndereco.Text = ""
        End If

    End Sub

    Private Sub TxTCpf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxTCpf.KeyPress
        fCPF(sender, e)
    End Sub
    Private Sub TxTCep_LostFocus(sender As Object, e As EventArgs) Handles TxTCep.LostFocus
        CEP = New ConsultaCEP.CEP(TxTCep.Text)
    End Sub

    Private Sub TxTTelefone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxTTelefone.KeyPress
        fTelefone(sender, e)
    End Sub

    Private Sub TxTCelular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxTCelular.KeyPress
        fCelular(sender, e)
    End Sub

    Private Sub TxTCep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxTCep.KeyPress
        fCEP(sender, e)
    End Sub

    Private Sub BgwCarregaFuncionario_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwCarregaFuncionario.DoWork
        SetControlVisible(DgvFuncionario, False)

        clearRows(DgvFuncionario)


        Dim sql As String = "select * from tbcadfuncionario order by nome "


        Dim connection As New NpgsqlConnection(cnSQL)
        Dim command As New NpgsqlCommand(sql, connection)
        Try
            connection.Open()
            Dim reader As NpgsqlDataReader = command.ExecuteReader
            If reader.HasRows Then
                While reader.Read()

                    addRow(DgvFuncionario, New Object() {reader.Item("idfuncionario"), reader.Item("nome").ToString, reader.Item("endereco").ToString, reader.Item("numero"), reader.Item("complemento").ToString, reader.Item("bairro").ToString, reader.Item("cep"), reader.Item("cpf"), reader.Item("telefone"), reader.Item("email").ToString, reader.Item("uf").ToString, reader.Item("estado_civil").ToString, reader.Item("celular"), reader.Item("cidade").ToString, reader.Item("rg"), reader.Item("observacoes").ToString})

                End While
            End If

        Catch x As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(x, "B-INK")
        Finally
            connection.Close()
            command = Nothing
            connection = Nothing
            sql = Nothing
        End Try

    End Sub

    Private Sub bgwCarregaFuncionario_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgwCarregaFuncionario.RunWorkerCompleted
        DgvFuncionario.Visible = True
    End Sub

    Private Sub FrmFuncionário_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not bgwCarregaFuncionario.IsBusy Then
            bgwCarregaFuncionario.RunWorkerAsync()
        End If
    End Sub

    Private Sub BtnLimpar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick
        If Not bgwCarregaFuncionario.IsBusy Then
            bgwCarregaFuncionario.RunWorkerAsync()
        End If

        txtNome.Text = ""
        TxTRG.Text = ""
        idfuncionario = 0
        TxTBairro.Text = ""
        TxTCelular.Text = ""
        TxTCep.Text = ""
        TxTCidade.Text = ""
        TxTCpf.Text = ""
        TxTEmail.Text = ""
        TxTEndereco.Text = ""
        RicTxTObservacoes.Text = ""
        TxTTelefone.Text = ""
        txtUF.Text = Nothing
        TxTEstadoCivil.Text = Nothing
        RicTxTObservacoes.Text = ""
        TxtNumero.Text = ""
        txtcomplemento.Text = ""
        PicFoto.Image = Nothing

    End Sub

    Private Sub DgvFuncionario_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvFuncionario.CellClick
        If DgvFuncionario.Rows.Count <> 0 Then


            idfuncionario = DgvFuncionario.CurrentRow.Cells(colidusuario.Index).Value.ToString
            txtNome.Text = DgvFuncionario.CurrentRow.Cells(colnome.Index).Value.ToString
            TxTEndereco.Text = DgvFuncionario.CurrentRow.Cells(colendereco.Index).Value.ToString
            TxtNumero.Text = DgvFuncionario.CurrentRow.Cells(colnumero.Index).Value.ToString
            TxTBairro.Text = DgvFuncionario.CurrentRow.Cells(colbairro.Index).Value.ToString
            TxTCep.Text = DgvFuncionario.CurrentRow.Cells(colcep.Index).Value.ToString
            TxTCpf.Text = DgvFuncionario.CurrentRow.Cells(colcpf.Index).Value.ToString
            TxTTelefone.Text = DgvFuncionario.CurrentRow.Cells(coltelefone.Index).Value.ToString
            TxTEmail.Text = DgvFuncionario.CurrentRow.Cells(colemail.Index).Value.ToString
            RicTxTObservacoes.Text = DgvFuncionario.CurrentRow.Cells(colobservacoes.Index).Value.ToString
            txtUF.Text = DgvFuncionario.CurrentRow.Cells(coluf.Index).Value.ToString
            TxTEstadoCivil.Text = DgvFuncionario.CurrentRow.Cells(colestadocivil.Index).Value.ToString
            TxTCelular.Text = DgvFuncionario.CurrentRow.Cells(colcelular.Index).Value.ToString
            TxTCidade.Text = DgvFuncionario.CurrentRow.Cells(colcidade.Index).Value.ToString
            TxTRG.Text = DgvFuncionario.CurrentRow.Cells(colrg.Index).Value.ToString

            Dim f As New csFuncoes(cnSQL)
            PicFoto.Image = f.FotoUsuario(idfuncionario)

        End If
    End Sub

    Private Sub BtnExcluir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcluir.ItemClick
        If idfuncionario = 0 Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Selecione o funcionário que deseja exluir na ABA de consulta abaixo!", "B-INK", MessageBoxButtons.OK)
        ElseIf idfuncionario <> 0 Then
            If DevExpress.XtraEditors.XtraMessageBox.Show("Tem certeza de que deseja excluir o funcionário " + txtNome.Text + " ?", "B-INK", MessageBoxButtons.YesNo) = DialogResult.No Then
                BtnLimpar_ItemClick(Nothing, Nothing)
                Exit Sub
            Else
                excluiFuncionario()
            End If
        End If
    End Sub

    Public Sub Consultafotousuarios()

        Dim sql As String = "select idfotofuncionario from tbfotofuncionario where idfuncionario = @idfuncionario"

        Dim connection As New NpgsqlConnection(cnSQL)
        Dim command As New NpgsqlCommand(sql, connection)


        Try
            connection.Open()

            With command.Parameters
                .AddWithValue("@idfuncionario", idfuncionario)
            End With

            Dim reader As NpgsqlDataReader = command.ExecuteReader

            If reader.HasRows Then
                AlterarFotoFuncionario()
            Else
                GravaFotoFuncionario(idfuncionario)
            End If

        Catch x As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(x, "B-INK")
        Finally
            connection.Close()
            command = Nothing
            connection = Nothing
            sql = Nothing
        End Try
    End Sub

    Private Sub GravaFotoFuncionario(recebeidusuario As Integer)

        Dim sql As String = "insert into tbfotofuncionario (idfuncionario, foto) Values (@idfuncionario, @foto)"
        Dim connection As New NpgsqlConnection(cnSQL)
        Dim command As New NpgsqlCommand(sql, connection)

        With command.Parameters

            .AddWithValue("@idfuncionario", recebeidusuario)

            .AddWithValue("@foto", Fotos(PicFoto.Image))

        End With

        Try
            connection.Open()

            Dim x As Integer = command.ExecuteNonQuery()
            If x = 1 Then

                GravaLog(Me.Text, "Gravar", "O Usuário " & usuariologado & " gravou a foto do funcionario")
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

    Public Function Fotos(ByVal PicFoto As Image)
        If IsNothing(PicFoto) Then
            Return DBNull.Value
        Else
            Dim bmp As Image = New Bitmap(PicFoto)
            PicFoto = bmp
            Dim ms As New MemoryStream()
            bmp.Save(ms, Imaging.ImageFormat.Bmp)
            Return ms.ToArray
        End If
    End Function

    Private Sub AlterarFotoFuncionario()

        Dim sql As String = "update tbfotofuncionario set foto = @foto where idfuncionario = @idfuncionario "
        Dim connection As New NpgsqlConnection(cnSQL)
        Dim command As New NpgsqlCommand(sql, connection)

        With command.Parameters

            .AddWithValue("@idfuncionario", idfuncionario)

            .AddWithValue("@foto", Fotos(PicFoto.Image))


        End With

        Try
            connection.Open()

            Dim x As Integer = command.ExecuteNonQuery()
            If x = 1 Then

                GravaLog(Me.Text, "Gravar", "O Usuário " & usuariologado & " alterou a foto do funcionario")
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
End Class