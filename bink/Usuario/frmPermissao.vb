Public Class frmPermissao
    Private Sub FrmPerfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tcPerfil.SelectedPage = tpCadastro

        cbonivelusuario.DataSource = frmUsuario.nivelacesso()
        cbonivelusuario.DisplayMember = "Tipo"
        cbonivelusuario.ValueMember = "IdTipo"

    End Sub

    Private Sub Cbonivelusuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbonivelusuario.SelectedIndexChanged

        tcPerfil.Enabled = True

    End Sub
End Class
