Imports Npgsql

Public Class frmFornecedor
    Private Sub FrmFornecedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tcFornec.SelectedPage = tpDadosFornec

    End Sub

    Private Sub VerificaDocumento(sender, e)
        If checkCPF.Checked Then
            fCPF(sender, e)
            checkCNPJ.Enabled = False
            Exit Sub
        ElseIf checkCNPJ.Checked Then
            fCNPJ(sender, e)
            checkCPF.Enabled = False
            Exit Sub
        End If
    End Sub

    Private Sub txtDocumento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDocumento.KeyPress
        VerificaDocumento(sender, e)
    End Sub

    Private Sub BtnLimpar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick
        checkCPF.Enabled = True
        checkCNPJ.Enabled = True
        checkCNPJ.Checked = False
        checkCPF.Checked = False
        txtNome.Text = ""
        txtRg.Text = ""
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
    End Sub

    Private Sub BtnSair_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSair.ItemClick
        Me.Close()
    End Sub

    Private Sub CheckCPF_CheckedChanged(sender As Object, e As EventArgs) Handles checkCPF.CheckedChanged
        txtDocumento.Focus()
        txtDocumento.Select()
    End Sub

    Private Sub CheckCNPJ_CheckedChanged(sender As Object, e As EventArgs) Handles checkCNPJ.CheckedChanged
        txtDocumento.Focus()
        txtDocumento.Select()
    End Sub
End Class