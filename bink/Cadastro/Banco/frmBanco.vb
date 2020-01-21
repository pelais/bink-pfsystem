Imports System.ComponentModel
Imports Npgsql

Public Class frmBanco

    Dim idbanco As Integer
    Private Sub BtnSair_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSair.ItemClick
        Me.Close()
    End Sub

    Private Sub FrmBanco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FundoTextBox(Me)


        If Not bgwCarregaBanco.IsBusy Then
            bgwCarregaBanco.RunWorkerAsync()
        End If

    End Sub

    Private Sub gravaBanco()
        Try

            Dim sql As String = "insert into tbcadbanco (banco, digito, descricao, abreviatura, razsocial) Values (@banco, @digito, @descricao, @abreviatura, @razsocial)"
            Dim connection As New NpgsqlConnection(cnSQL)
            Dim command As New NpgsqlCommand(sql, connection)

            connection.Open()

            If txtBanco.Text = "" Or txtAbreviatura.Text = "" Or txtDescricao.Text = "" Then

                DevExpress.XtraEditors.XtraMessageBox.Show("É obrigatório o preenchimento dos campos marcados com (*)!", "B-INK")
                Exit Sub

            End If

            With command.Parameters

                .AddWithValue("@banco", txtBanco.Text)
                .AddWithValue("@digito", txtDg.Text)
                .AddWithValue("@descricao", txtDescricao.Text)
                .AddWithValue("@abreviatura", txtAbreviatura.Text)
                .AddWithValue("@razsocial", txtRazSocial.Text)

            End With
            Try

                Dim x As Integer = command.ExecuteNonQuery()
                If x = 1 Then

                    DevExpress.XtraEditors.XtraMessageBox.Show("Banco cadastrado!" & vbCrLf & " Operação efetuada com sucesso!")

                    GravaLog(Me.Text, "Gravar", "Usuário " + usuariologado + " gravou o cadastro de banco")

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

    Private Sub BtnLimpar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick

        idbanco = 0
        txtRazSocial.Text = ""
        txtDescricao.Text = ""
        txtDg.Text = ""
        txtBanco.Text = ""
        txtAbreviatura.Text = ""

        If Not bgwCarregaBanco.IsBusy Then
            bgwCarregaBanco.RunWorkerAsync()
        End If

    End Sub

    Private Sub BtnSalvar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick
        If idbanco = 0 Then
            gravaBanco()
        Else
            editaBanco()
        End If
    End Sub

    Private Sub BgwCarregaBanco_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwCarregaBanco.DoWork
        dgvConsultaBanco.Invoke(New MethodInvoker(Sub()
                                                      dgvConsultaBanco.Rows.Clear()
                                                      dgvConsultaBanco.Visible = False
                                                  End Sub))

        Dim sql As String = "select tbcadbanco.idbanco, tbcadbanco.banco, tbcadbanco.digito, tbcadbanco.descricao, tbcadbanco.abreviatura, tbcadbanco.razsocial from tbcadbanco order by banco"
        Dim connection As New NpgsqlConnection(cnSQL)
        Dim command As New NpgsqlCommand(sql, connection)
        Try
            connection.Open()
            Dim reader As NpgsqlDataReader = command.ExecuteReader
            If reader.HasRows Then
                While reader.Read()

                    dgvConsultaBanco.Invoke(New MethodInvoker(Sub()
                                                                  dgvConsultaBanco.Rows.Add(reader.Item("idbanco"), reader.Item("banco").ToString, reader.Item("digito"), reader.Item("descricao").ToString, reader.Item("abreviatura").ToString, reader.Item("razsocial").ToString)
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

    Private Sub bgwCarregaBanco_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgwCarregaBanco.RunWorkerCompleted
        dgvConsultaBanco.Visible = True
    End Sub

    Private Sub DgvConsultaBanco_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConsultaBanco.CellClick
        idbanco = dgvConsultaBanco.CurrentRow.Cells(colidbanco.Index).Value
        txtBanco.Text = dgvConsultaBanco.CurrentRow.Cells(colbanco.Index).Value
        txtDg.Text = dgvConsultaBanco.CurrentRow.Cells(coldigito.Index).Value
        txtDescricao.Text = dgvConsultaBanco.CurrentRow.Cells(coldescricao.Index).Value
        txtAbreviatura.Text = dgvConsultaBanco.CurrentRow.Cells(colabreviatura.Index).Value
        txtRazSocial.Text = dgvConsultaBanco.CurrentRow.Cells(colrazaobanco.Index).Value
    End Sub

    Private Sub BtnExcluir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcluir.ItemClick
        If idbanco = 0 Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Selecione o banco que deseja exluir na ABA de consulta abaixo!", "B-INK", MessageBoxButtons.OK)
        ElseIf idbanco <> 0 Then
            If DevExpress.XtraEditors.XtraMessageBox.Show("Tem certeza de que deseja excluir o banco " + txtDescricao.Text + " ?", "B-INK", MessageBoxButtons.YesNo) = DialogResult.No Then
                BtnLimpar_ItemClick(Nothing, Nothing)
                Exit Sub
            Else
                excluiBanco()
            End If
        End If
    End Sub

    Private Sub excluiBanco()
        Dim SQL As String = "Delete from tbcadbanco Where idbanco = @idbanco"
        Dim connection As New NpgsqlConnection(cnSQL)
        Dim command As New NpgsqlCommand(SQL, connection)

        With command.Parameters
            .AddWithValue("@idbanco", idbanco)
        End With

        Try

            connection.Open()

            Dim x As Integer = command.ExecuteNonQuery()
            If x >= 1 Then


                DevExpress.XtraEditors.XtraMessageBox.Show("Banco excluído!" & vbCrLf & " Operação efetuada com sucesso!")

                GravaLog(Me.Text, "Excluir", "O Usuário " & usuariologado & " excluiu um banco cadastrado")

                BtnLimpar_ItemClick(Nothing, Nothing)

            End If

        Catch x As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show("Não é possível excluir o banco " + txtDescricao.Text + ", pois o mesmo possui dados vinculados no sistema.", "B-INK")
        Finally
            connection.Close()
            connection = Nothing
            command = Nothing
            SQL = Nothing
        End Try
    End Sub

    Private Sub editaBanco()
        Try
            Dim sql As String = "update tbcadbanco set banco =@banco, digito =@digito, descricao =@descricao, abreviatura =@abreviatura, razsocial =@razsocial where idbanco = @idbanco"
            Dim connection As New NpgsqlConnection(cnSQL)
            Dim command As New NpgsqlCommand(sql, connection)


            If txtBanco.Text = "" Or txtAbreviatura.Text = "" Or txtDescricao.Text = "" Then

                DevExpress.XtraEditors.XtraMessageBox.Show("É obrigatório o preenchimento dos campos marcados com (*)!", "B-INK")
                Exit Sub

            End If
            With command.Parameters
                .AddWithValue("@banco", txtBanco.Text)
                .AddWithValue("@digito", txtDg.Text)
                .AddWithValue("@descricao", txtDescricao.Text)
                .AddWithValue("@abreviatura", txtAbreviatura.Text)
                .AddWithValue("@razsocial", txtRazSocial.Text)
            End With

            Try
                connection.Open()

                Dim x As Integer = command.ExecuteNonQuery()
                If x >= 1 Then

                    DevExpress.XtraEditors.XtraMessageBox.Show("Banco alterado!" & vbCrLf & "Operação efetuada com sucesso!")

                    GravaLog(Me.Text, "Editar", "O usuário " + usuariologado + " alterou o cadastro do banco " + txtDescricao.Text)

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
End Class