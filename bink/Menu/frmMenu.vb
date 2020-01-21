Imports DevExpress.XtraTabbedMdi
Imports Npgsql

Public Class frmMenu

    Dim vsair As Boolean = False
    Private Sub BtnEmpresa_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEmpresa.ItemClick

        'With frmCadEmpresa
        '    .MdiParent = Me
        '    .Show()
        '    .Focus()
        'End With
        frmCadEmpresa.ShowDialog()
    End Sub

    Private Sub BtnUsuario_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUsuario.ItemClick
        'With frmUsuario
        '    .MdiParent = Me
        '    .Show()
        '    .Focus()
        'End With

        frmUsuario.ShowDialog()
    End Sub



#Region "BuscaMenu"

    Public Sub LerMenus()
        Dim menu As String = BuscaMenu()
        If menu <> "" Then
            For Each s As String In menu.Split("|")
                'If MenuStrip1.Items.Find(s, True).Count > 0 Then
                '    Dim ts As ToolStripMenuItem = MenuStrip1.Items.Find(s, True)(0)
                '    ts.Enabled = False
                'End If
            Next
        End If
    End Sub

    Private Function BuscaMenu() As String
        Try
            Dim sql As String = "select menus from vwusuarios where idcadastrousuario = @idcadastrousuario"
            Dim connection As New NpgsqlConnection(cnSQL)
            Dim command As New NpgsqlCommand(sql, connection)
            Try
                connection.Open()
                command.Parameters.AddWithValue("@idcadastrousuario", idusuario)

                Dim r As NpgsqlDataReader = command.ExecuteReader

                If r.Read Then
                    Return r(0)
                Else
                    Return ""
                End If

            Finally
                connection.Close()
                connection = Nothing
                command = Nothing
                sql = Nothing
            End Try
        Catch ex As Exception
            MsgBox(ex)
            Return ""
        End Try
    End Function

#End Region


    Private Sub ClientePainel()
        If tableMDI.Pages.Count = 0 Then
            pnImageMenu.Visible = True
        Else
            pnImageMenu.Visible = False
        End If
    End Sub

    Private Sub tableMDI_PageAdded(sender As Object, e As MdiTabPageEventArgs) Handles tableMDI.PageAdded
        ClientePainel()
    End Sub

    Private Sub tableMDI_PageRemoved(sender As Object, e As MdiTabPageEventArgs) Handles tableMDI.PageRemoved
        ClientePainel()
    End Sub

    Private Sub frmMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If DevExpress.XtraEditors.XtraMessageBox.Show("Deseja realmente sair do sistema?", "B-INK", MessageBoxButtons.YesNo) = DialogResult.No Then
            e.Cancel = True

        Else
            vsair = True
            GravaLog(Me.Text, "SAIR", "Usuário " & usuariologado & " saiu do sistema B-INK")
            End
        End If
    End Sub

    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        frmLogin.Close()
        CarregaFotoEmpresa()
        CarregaEmpresa()

    End Sub

    Private Sub TmHra_Tick(sender As Object, e As EventArgs) Handles tmHra.Tick
        lblHora.Text = DateTime.Now.ToLongDateString + (DateTime.Now.ToString(" - HH:mm:ss")) + " - Usuário logado: " & usuariologado.ToString.ToLower & " "
    End Sub


    Private Sub CarregaFotoEmpresa()

        Dim sql As String = "select * from tbfotoempresa"
        Dim connection As New NpgsqlConnection(cnSQL)
        Dim command As New NpgsqlCommand(sql, connection)
        Try
            connection.Open()

            Dim reader As NpgsqlDataReader = command.ExecuteReader
            If reader.HasRows Then
                reader.Read()

                If IsDBNull(reader.Item("foto")) Then
                    picFoto.Image = Nothing
                    pnImagemEmpresa = Nothing
                Else
                    picFoto.Image = VoltaFotos(reader.Item("foto"))
                    pnImagemEmpresa.Image = VoltaFotos(reader.Item("foto"))
                End If
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

    Private Sub CarregaEmpresa()

        Dim sql As String = "select * from tbcadastroempresa"
        Dim connection As New NpgsqlConnection(cnSQL)
        Dim command As New NpgsqlCommand(sql, connection)
        Try
            connection.Open()

            Dim reader As NpgsqlDataReader = command.ExecuteReader
            If reader.HasRows Then
                reader.Read()
                lbEmpresa.Text = (reader.Item("empresa").ToString)
                lbEndereco.Text = "Endereço: " + (reader.Item(Trim("endereco")).ToString) + ", Nº " + (reader.Item("numero").ToString)
                lbContato.Text = "Cel: " + (reader.Item("celular").ToString) + " / " + "Tel: " + (reader.Item("telefone").ToString)
                lbEmail.Text = "E-mail: " + (reader.Item("email").ToString)
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

    Private Sub BtnPerfil_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPermissoes.ItemClick
        'With frmPerfil
        '    .MdiParent = Me
        '    .Show()
        '    .Focus()
        'End With

        frmPermissao.Show()
    End Sub

    Private Sub BtnCalculadora_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCalculadora.ItemClick
        System.Diagnostics.Process.Start("calc.exe")
    End Sub

    Private Sub BtnLogs_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLogs.ItemClick
        With frmLog
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub BtnContrato_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnContrato.ItemClick
        'frmContrato.Show()

        With frmContrato
            .MdiParent = Me
            .Show()
            .Focus()
        End With

    End Sub

    Private Sub BtnSobre_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSobre.ItemClick
        frmSobre.ShowDialog()
    End Sub

    Private Sub BtnTrocaSenha_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTrocaSenha.ItemClick
        frmAlterarSenhas.ShowDialog()
    End Sub

    Private Sub BtnFuncionario_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFuncionario.ItemClick
        frmFuncionario.Show()
    End Sub

    Private Sub BtnCadImagem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCadImagem.ItemClick
        frmCadImagem.ShowDialog()
    End Sub

    Private Sub BtnCliente_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCliente.ItemClick
        frmCadCliente.Show()
    End Sub

    Private Sub BtnBanco_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBanco.ItemClick
        frmBanco.ShowDialog()
    End Sub

    Private Sub BtnFornecedor_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFornecedor.ItemClick
        frmFornecedor.Show()
    End Sub

    Private Sub BtnPerfil_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPerfil.ItemClick
        frmPerfil.ShowDialog()
    End Sub

    Private Sub BtnContaPagar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnContaPagar.ItemClick
        frmContaRicardo.ShowDialog()
    End Sub
End Class