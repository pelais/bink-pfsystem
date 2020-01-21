Imports System.ComponentModel
Imports Npgsql

Public Class frmTipoUsuario

    Private idperfil As Integer = 0
    Private Sub FrmTipoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If Not bgwCarregaPerfil.IsBusy Then
            bgwCarregaPerfil.RunWorkerAsync()
        End If

        FundoTextBox(Me)

    End Sub

    Private Sub BgwCarregaPerfil_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwCarregaPerfil.DoWork
        SetControlVisible(dgvPerfil, False)
        clearRows(dgvPerfil)

        Dim sql As String = "select * from tbtipodeusuario"
        Dim connection As New NpgsqlConnection(cnSQL)
        Dim command As New NpgsqlCommand(sql, connection)
        Try
            connection.Open()
            Dim reader As NpgsqlDataReader = command.ExecuteReader
            If reader.HasRows Then
                While reader.Read()

                    addRow(dgvPerfil, New Object() {reader.Item("idtipousuario").ToString, reader.Item("tipousuario").ToString})

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

    Private Sub DgvPerfil_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPerfil.CellClick
        idperfil = dgvPerfil.CurrentRow.Cells(colidperfil.Index).Value
        txtPerfil.Text = dgvPerfil.CurrentRow.Cells(colnomeperfil.Index).Value
    End Sub

    Private Sub BtnIncluir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnIncluir.ItemClick
        idperfil = 0
        txtPerfil.Text = ""
        If Not bgwCarregaPerfil.IsBusy Then
            bgwCarregaPerfil.RunWorkerAsync()
        End If
    End Sub

    Private Sub bgwCarregaPerfil_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgwCarregaPerfil.RunWorkerCompleted
        dgvPerfil.Visible = True
    End Sub

    Private Sub BtnSair_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSair.ItemClick
        Me.Close()
    End Sub

    Private Sub frmTipoUsuario_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmUsuario.atualizaGridPerfilUsuario()
    End Sub

    Private Sub GravaPerfil(recebeidusuario As Integer)


        Dim c As New aes_ecb(cvecb, aes_ecb.Tipo.Hexa)
        Dim sql As String = "insert into tbtipodeusuario(tipousuario) Values (@tipousuario) returning idtipousuario"
        Dim connection As New NpgsqlConnection(cnSQL)
        Dim command As New NpgsqlCommand(sql, connection)

        connection.Open()

        Dim t As NpgsqlTransaction = connection.BeginTransaction

        command.Transaction = t

        If txtPerfil.Text = "" Then

            DevExpress.XtraEditors.XtraMessageBox.Show("É obrigatorio o preenchimento dos campos indicados com o ( * )", "B-INK")

            Exit Sub
        End If

        Try

            With command.Parameters
                .AddWithValue("@tipousuario", GetControlText(txtPerfil).Trim)
            End With

            recebeidusuario = command.ExecuteScalar()

            t.Commit()

            DevExpress.XtraEditors.XtraMessageBox.Show("Dados cadastrados!" & vbCrLf & " Operação efetuada com sucesso!", "B-INK")

            GravaLog(Me.Text, "Gravar", "O usuário " & usuariologado & " cadastrou um novo perfil de usuário -  " + txtPerfil.Text)

            BtnIncluir_ItemClick(Nothing, Nothing)

            If Not bgwCarregaPerfil.IsBusy Then
                bgwCarregaPerfil.RunWorkerAsync()
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

        If vc.VerificarControl(gpInfo, True, True) Then

            If idperfil <> 0 Then
                editaPerfil()
            Else
                GravaPerfil(idperfil)
            End If

        End If

    End Sub

    Private Sub excluiPerfil()

        Dim SQL As String = "Delete from tbtipodeusuario Where idtipousuario = @idtipousuario"
        Dim connection As New NpgsqlConnection(cnSQL)
        Dim command As New NpgsqlCommand(SQL, connection)

        With command.Parameters
            .AddWithValue("@idtipousuario", idperfil)

        End With

        Try

            connection.Open()

            Dim x As Integer = command.ExecuteNonQuery()
            If x >= 1 Then


                DevExpress.XtraEditors.XtraMessageBox.Show(" Dados excluídos!" & vbCrLf & " Operação efetuada com sucesso!", "B-INK")

                GravaLog(Me.Text, "Excluir", "O Usuário " & usuariologado & " excluiu o cadastro do perfil " + txtPerfil.Text)

                BtnIncluir_ItemClick(Nothing, Nothing)

            End If

        Catch x As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show("Não é possível excluir o perfil " + txtPerfil.Text + ", pois existe vincúlo(s) com usuário(s). Por favor verifique!", "B-INK")
        Finally
            connection.Close()
            connection = Nothing
            command = Nothing
            SQL = Nothing
        End Try
    End Sub

    Private Sub BtnExcluir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcluir.ItemClick
        If idperfil = 0 Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Por favor selecione o perfil que deseja exlcuir na aba abaixo.", "B-INK")
        Else
            If DevExpress.XtraEditors.XtraMessageBox.Show("Deseja excluir realmente exluir o perfil " + txtPerfil.Text + "?", "B-INK", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                excluiPerfil()
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub editaPerfil()
        Dim c As New aes_ecb(cvecb, aes_ecb.Tipo.Hexa)
        Dim sql As String = "update tbtipodeusuario set tipousuario =@tipousuario where idtipousuario = @idtipousuario"
        Dim connection As New NpgsqlConnection(cnSQL)
        Dim command As New NpgsqlCommand(sql, connection)

        Try

            connection.Open()

            With command.Parameters
                .AddWithValue("@idtipousuario", idperfil)
                .AddWithValue("@tipousuario", GetControlText(txtPerfil))
            End With

            Dim x As Integer = command.ExecuteNonQuery()
            If x >= 1 Then

                DevExpress.XtraEditors.XtraMessageBox.Show(" Dados alterados!" & vbCrLf & " Operação efetuada com sucesso!", "B-INK")

                GravaLog(Me.Text, "Editar", "O Usuário " & usuariologado & " editou o cadastro do perfil " + txtPerfil.Text)

                If Not bgwCarregaPerfil.IsBusy Then
                    bgwCarregaPerfil.RunWorkerAsync()
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
End Class