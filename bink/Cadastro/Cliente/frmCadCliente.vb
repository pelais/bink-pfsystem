Imports System.ComponentModel
Imports Npgsql

Public Class frmCadCliente

    Dim idcadcliente As Integer
    Private Sub FrmCadCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tcCliente.SelectedPage = tpDadosCliente
        FundoCombobox(Me)
        FundoTextBox(Me)
        FundoRictext(Me)

        If Not bgwCliente.IsBusy Then
            bgwCliente.RunWorkerAsync()
        End If

    End Sub

    Public Function BuscarCPF(ByVal IdBuscacpf As String) As NpgsqlDataReader

        Dim sql As String = "select documento from tbcadcliente where documento = '" & IdBuscacpf & "'"
        Dim connection As New NpgsqlConnection(cnSQL)
        Dim command As New NpgsqlCommand(sql, connection)
        Dim dr As NpgsqlDataReader

        Try
            connection.Open()
            dr = command.ExecuteReader
            Return dr
        Catch ex As Exception
            MsgBox(ex)
            Return Nothing
        Finally
            connection.Close()
            command = Nothing
            connection = Nothing
            sql = Nothing
        End Try
    End Function

    Private Sub gravaCliente()
        Try

            Dim sql As String = "insert into tbcadcliente (nome, documento, sexo, datanasc, endereco, bairro, cidade, uf, cep, telefone, celular, email, datacadastro, observacao, ocupacao, rg, ativo) Values (@nome, @documento, @sexo, @datanasc, @endereco, @bairro, @cidade, @uf, @cep, @telefone, @celular, @email, @datacadastro, @observacao, @ocupacao, @rg, @ativo)"
            Dim connection As New NpgsqlConnection(cnSQL)
            Dim command As New NpgsqlCommand(sql, connection)

            connection.Open()

            If txtNome.Text = "" Or txtDocumento.Text = "" Then

                DevExpress.XtraEditors.XtraMessageBox.Show("É obrigatório o preenchimento de pelo menos o nome e Documento!", "B-INK")

                Exit Sub
            Else
                Dim dr As Npgsql.NpgsqlDataReader
                dr = BuscarCPF(txtDocumento.Text)
                If dr.Read Then

                    DevExpress.XtraEditors.XtraMessageBox.Show("CPF do cliente já cadastrado! Por favor verifique!", "B-INK")
                    Exit Sub

                End If

                With command.Parameters
                    .AddWithValue("@nome", txtNome.Text)
                    .AddWithValue("@documento", txtDocumento.Text)
                    .AddWithValue("@sexo", cbSexo.Text)
                    .AddWithValue("@datanasc", CDate(dtpDataNasc.Value))
                    .AddWithValue("@endereco", txtEndereco.Text)
                    .AddWithValue("@bairro", txtBairro.Text)
                    .AddWithValue("@cidade", txtCidade.Text)
                    .AddWithValue("@uf", cbEstado.Text)
                    .AddWithValue("@cep", TxTCep.Text)
                    .AddWithValue("@telefone", TxTTelefone.Text)
                    .AddWithValue("@celular", TxTCelular.Text)
                    .AddWithValue("@email", txtEmail.Text)
                    .AddWithValue("@datacadastro", Date.Now)
                    .AddWithValue("@ocupacao", cmbOcupacao.Text)
                    .AddWithValue("@observacao", txtObservacao.Text)
                    .AddWithValue("@rg", txtRg.Text)
                    If checkAtivo.Checked Then
                        .AddWithValue("@ativo", True)
                    Else
                        .AddWithValue("@ativo", False)
                    End If
                End With
                Try

                    Dim x As Integer = command.ExecuteNonQuery()
                    If x = 1 Then

                        DevExpress.XtraEditors.XtraMessageBox.Show(" Cliente cadastrado!" & vbCrLf & " Operação efetuada com sucesso!")

                        GravaLog(Me.Text, "Gravar", "Usuário " + usuariologado + " gravou o cadastro de cliente")

                        BtnLimpar_ItemClick(Nothing, Nothing)

                    End If
                Finally
                    connection.Close()
                    connection = Nothing
                    command = Nothing
                    sql = Nothing
                End Try
            End If
        Catch x As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(x, "B-INK")
        Finally
        End Try
    End Sub

    Private Sub BtnLimpar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick
        txtNome.Text = ""
        txtRg.Text = ""
        idcadcliente = 0
        txtBairro.Text = ""
        TxTCelular.Text = ""
        TxTCep.Text = ""
        txtCidade.Text = ""
        txtDocumento.Text = ""
        txtEmail.Text = ""
        txtEndereco.Text = ""
        cmbOcupacao.Text = Nothing
        txtObservacao.Text = ""
        TxTTelefone.Text = ""
        dtpDataNasc.Value = Date.Now
        dtDataCadastro.Value = Date.Now
        cbEstado.Text = Nothing
        cbSexo.Text = Nothing

        If Not bgwCliente.IsBusy Then
            bgwCliente.RunWorkerAsync()
        End If

    End Sub

    Private Sub BtnSalvar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick
        If idcadcliente <> 0 Then
            editaCliente()
        Else
            gravaCliente()
        End If
    End Sub

    Private Sub BtnSair_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSair.ItemClick
        Me.Close()
    End Sub

    Private Sub txtDocumento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDocumento.KeyPress
        fCPF(sender, e)
    End Sub

    Private Sub txtDocumento_LostFocus(sender As Object, e As EventArgs)

        'If txtDocumento.Text.Trim <> "" Then

        '    Dim cpf As New mdovalida_CPF
        '    cpf.cpf = txtDocumento.Text

        '    If txtDocumento.Text = cpf.cpf Then
        '    Else
        '        txtDocumento.Text = ""
        '        txtDocumento.Focus()
        '    End If
        'End If

    End Sub

    Dim WithEvents CEP As ConsultaCEP.CEP

    Private Sub CEP_BuscaCompletada(sender As Object, e As EventArgs) Handles CEP.BuscaCompletada

        If CEP.Erro = "" Then
            txtBairro.Text = CEP.Bairro
            txtCidade.Text = CEP.Cidade
            cbEstado.Text = CEP.Estado
            txtEndereco.Text = CEP.Logradouro
        Else
            DevExpress.XtraEditors.XtraMessageBox.Show(CEP.Erro, "B-INK")

            txtBairro.Text = ""
            txtCidade.Text = ""
            cbEstado.Text = Nothing
            txtEndereco.Text = ""
        End If

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


    Private Sub BgwCliente_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwCliente.DoWork
        dgvConsultaCliente.Invoke(New MethodInvoker(Sub()
                                                        dgvConsultaCliente.Rows.Clear()
                                                        dgvConsultaCliente.Visible = False
                                                    End Sub))

        Dim sql As String = "select * from tbcadcliente order by nome"
        Dim connection As New NpgsqlConnection(cnSQL)
        Dim command As New NpgsqlCommand(sql, connection)
        Try
            connection.Open()
            Dim reader As NpgsqlDataReader = command.ExecuteReader
            If reader.HasRows Then
                While reader.Read()

                    dgvConsultaCliente.Invoke(New MethodInvoker(Sub()
                                                                    dgvConsultaCliente.Rows.Add(reader.Item("idcliente"), reader.Item("nome").ToString, reader.Item("documento"), reader.Item("rg").ToString, reader.Item("sexo").ToString, reader.Item("datanasc").ToString, reader.Item("endereco"), reader.Item("bairro").ToString, reader.Item("cidade").ToString, reader.Item("uf").ToString, reader.Item("cep").ToString, reader.Item("telefone").ToString, reader.Item("celular"), reader.Item("observacao").ToString, reader.Item("ocupacao").ToString, reader.Item("email").ToString, reader.Item("ativo").ToString)
                                                                End Sub))
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

    Private Sub bgwCliente_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgwCliente.RunWorkerCompleted
        dgvConsultaCliente.Visible = True
    End Sub

    Private Sub editaCliente()
        Try
            Dim sql As String = "update tbcadcliente set nome =@nome, documento =@documento, sexo =@sexo, datanasc =@datanasc, endereco =@endereco, bairro =@bairro, cidade =@cidade, uf =@uf, cep =@cep, telefone =@telefone, celular =@celular, email =@email, observacao =@observacao, ocupacao =@ocupacao, rg =@rg, ativo =@ativo where idcliente = @idcliente"
            Dim connection As New NpgsqlConnection(cnSQL)
            Dim command As New NpgsqlCommand(sql, connection)

            If txtNome.Text = "" Then

                MessageBox.Show("É obrigatório o preenchimento de pelo menos o nome do cliente!", "B-INK")
                Exit Sub

            Else
                With command.Parameters
                    .AddWithValue("@idcliente", idcadcliente)
                    .AddWithValue("@nome", txtNome.Text)
                    .AddWithValue("@documento", txtDocumento.Text)
                    .AddWithValue("@sexo", cbSexo.Text)
                    .AddWithValue("@datanasc", CDate(dtpDataNasc.Value))
                    .AddWithValue("@endereco", txtEndereco.Text)
                    .AddWithValue("@bairro", txtBairro.Text)
                    .AddWithValue("@cidade", txtCidade.Text)
                    .AddWithValue("@uf", cbEstado.Text)
                    .AddWithValue("@cep", TxTCep.Text)
                    .AddWithValue("@telefone", TxTTelefone.Text)
                    .AddWithValue("@celular", TxTCelular.Text)
                    .AddWithValue("@email", txtEmail.Text)
                    .AddWithValue("@ocupacao", cmbOcupacao.Text)
                    .AddWithValue("@observacao", txtObservacao.Text)
                    .AddWithValue("@rg", txtRg.Text)
                    If checkAtivo.Checked Then
                        .AddWithValue("@ativo", True)
                    Else
                        .AddWithValue("@ativo", False)
                    End If


                End With

                Try
                    connection.Open()

                    Dim x As Integer = command.ExecuteNonQuery()
                    If x >= 1 Then

                        DevExpress.XtraEditors.XtraMessageBox.Show(" Dados alterados!" & vbCrLf & " Operação efetuada com sucesso!")

                        GravaLog(Me.Text, "Editar", "O usuário " + usuariologado + " alterou o cadastro do cliente " + txtNome.Text)

                        BtnLimpar_ItemClick(Nothing, Nothing)

                    End If
                Finally
                    connection.Close()
                    connection = Nothing
                    command = Nothing
                    sql = Nothing
                End Try
            End If
        Catch x As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(x, "B-INK")
        Finally
        End Try
    End Sub

    Private Sub DgvConsultaCliente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConsultaCliente.CellClick

        idcadcliente = dgvConsultaCliente.CurrentRow.Cells(colidcliente.Index).Value
        txtNome.Text = dgvConsultaCliente.CurrentRow.Cells(colnome.Index).Value
        txtDocumento.Text = dgvConsultaCliente.CurrentRow.Cells(coldocumento.Index).Value
        txtRg.Text = dgvConsultaCliente.CurrentRow.Cells(colrg.Index).Value
        cbSexo.Text = dgvConsultaCliente.CurrentRow.Cells(colsexo.Index).Value
        dtpDataNasc.Value = dgvConsultaCliente.CurrentRow.Cells(coldtnasc.Index).Value
        txtEndereco.Text = dgvConsultaCliente.CurrentRow.Cells(colendereco.Index).Value
        txtBairro.Text = dgvConsultaCliente.CurrentRow.Cells(colbairro.Index).Value
        txtCidade.Text = dgvConsultaCliente.CurrentRow.Cells(colcidade.Index).Value
        TxTCep.Text = dgvConsultaCliente.CurrentRow.Cells(colcep.Index).Value
        txtEmail.Text = dgvConsultaCliente.CurrentRow.Cells(colemail.Index).Value
        txtObservacao.Text = dgvConsultaCliente.CurrentRow.Cells(colobservacao.Index).Value
        TxTCelular.Text = dgvConsultaCliente.CurrentRow.Cells(colcelular.Index).Value
        TxTTelefone.Text = dgvConsultaCliente.CurrentRow.Cells(coltelefone.Index).Value
        cbEstado.Text = dgvConsultaCliente.CurrentRow.Cells(coluf.Index).Value
        cmbOcupacao.Text = dgvConsultaCliente.CurrentRow.Cells(colocupacao.Index).Value
        checkAtivo.Checked = dgvConsultaCliente.CurrentRow.Cells(colativo.Index).Value

    End Sub

    Private Sub excluiCliente()
        Dim SQL As String = "Delete from tbcadcliente Where idcliente = @idcliente"
        Dim connection As New NpgsqlConnection(cnSQL)
        Dim command As New NpgsqlCommand(SQL, connection)

        With command.Parameters
            .AddWithValue("@idcliente", idcadcliente)
        End With

        Try

            connection.Open()

            Dim x As Integer = command.ExecuteNonQuery()
            If x >= 1 Then


                DevExpress.XtraEditors.XtraMessageBox.Show("Dados excluídos!" & vbCrLf & " Operação efetuada com sucesso!")

                GravaLog(Me.Text, "Excluir", "O Usuário " & usuariologado & " excluiu um cliente cadastrado")

                BtnLimpar_ItemClick(Nothing, Nothing)

            End If

        Catch x As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show("Não é possível excluir o cliente " + txtNome.Text + ", pois o mesmo possui dados vinculados no sistema.", "B-INK")
        Finally
            connection.Close()
            connection = Nothing
            command = Nothing
            SQL = Nothing
        End Try
    End Sub

    Private Sub BtnExcluir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcluir.ItemClick
        If idcadcliente = 0 Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Selecione o cliente que deseja exluir na ABA de consulta abaixo!", "B-INK", MessageBoxButtons.OK)
        ElseIf idcadcliente <> 0 Then
            If DevExpress.XtraEditors.XtraMessageBox.Show("Tem certeza de que deseja excluir o Cliente " + txtNome.Text + " ?", "B-INK", MessageBoxButtons.YesNo) = DialogResult.No Then
                BtnLimpar_ItemClick(Nothing, Nothing)
                Exit Sub
            Else
                excluiCliente()
            End If
        End If
    End Sub
End Class