Imports Npgsql
Imports System.Drawing.Printing
Imports System.IO
Imports System.ComponentModel

Public Class frmCadEmpresa
    Private IdEmpresa As Integer = 0
    Dim idfoto As Integer = 0
    Dim idlogo As Integer = 0

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

    Public Function VoltaFotos(ByVal foto() As Byte) As Bitmap
        If Not IsDBNull(foto) Then
            Dim ms As New MemoryStream(foto)
            Dim bmp As New Bitmap(ms)
            Return bmp
        Else
            Return Nothing
        End If
    End Function

    Dim ofd As New OpenFileDialog


    Private Sub GravaDadosEmpresa(recebeidempresa As Integer)

        Try

            Dim sql As String = "insert into tbcadastroempresa(empresa,endereco,numero,bairro,cidade,uf,cep,cnpj,telefone,celular,email,datacadastro,complemento, razsocial, ie, tipoempresa, porte) Values (@empresa, @endereco, @numero, @bairro, @cidade,@uf,@cep,@cnpj,@telefone,@celular,@email,@datacadastro, @complemento, @razsocial, @ie, @tipoempresa, @porte) returning idempresa"
            Dim connection As New NpgsqlConnection(cnSQL)
            Dim command As New NpgsqlCommand(sql, connection)

            connection.Open()

            Dim t As NpgsqlTransaction = connection.BeginTransaction

            command.Transaction = t

            If TxTEmpresa.Text = "" Or txtEndereco.Text = "" Or txtNumero.Text = "" Or txtBairro.Text = "" Or TxtCidade.Text = "" Or cboUF.Text = "" Then
                DevExpress.XtraEditors.XtraMessageBox.Show("É obrigatorio o preenchimento dos campos indicados com o ( * )", "B-INK")
                'MsgBox("É obrigatorio o preenchimento dos campos indicados com o ( * )", tipodeperg.Notifc)
                Exit Sub
            Else
                With command.Parameters
                    .AddWithValue("@empresa", TxTEmpresa.Text)
                    .AddWithValue("@endereco", txtEndereco.Text)
                    .AddWithValue("@numero", txtNumero.Text)
                    .AddWithValue("@bairro", txtBairro.Text)
                    .AddWithValue("@cidade", TxtCidade.Text)
                    .AddWithValue("@uf", cboUF.Text)
                    .AddWithValue("@cep", txtcep.Text)
                    .AddWithValue("@cnpj", txtCnpj.Text)
                    .AddWithValue("@email", txtEmail.Text)
                    .AddWithValue("@telefone", TxTTelefone.Text)
                    .AddWithValue("@celular", txtCelular.Text)
                    .AddWithValue("@datacadastro", Date.Now)
                    .AddWithValue("@complemento", txtComplemento.Text)
                    .AddWithValue("@razsocial", txtRazsocial.Text)
                    .AddWithValue("@ie", txtIE.Text)
                    .AddWithValue("@tipoempresa", cbTipoEmpresa.Text)
                    .AddWithValue("@porte", cbPorte.Text)

                End With

                Try

                    recebeidempresa = command.ExecuteScalar

                    t.Commit()

                    GravaFotoEmpresa(recebeidempresa)


                    DevExpress.XtraEditors.XtraMessageBox.Show(" Dados cadastrados!" & vbCrLf & "Operação efetuada com sucesso!", "B-INK")

                    GravaLog(Me.Text, "Gravar", "O usuário " & usuariologado & " Cadastrou a empresa")

                    Empresa = New csEmpresa

                    Me.Close()

                Finally
                    connection.Close()
                    connection = Nothing
                    command = Nothing
                    sql = Nothing
                End Try
            End If
        Catch x As Exception
            MsgBox(x)
        End Try
    End Sub

    Private Sub GravaFotoEmpresa(recebeidempresa As Integer)

        Dim sql As String = "insert into tbfotoempresa(idcadempresa,foto) Values (@idcadempresa, @foto)"
        Dim connection As New NpgsqlConnection(cnSQL)
        Dim command As New NpgsqlCommand(sql, connection)

        Try
            connection.Open()

            With command.Parameters

                .AddWithValue(" @idcadempresa", recebeidempresa)

                If PicFoto.Image Is Nothing Then
                    .AddWithValue("@foto", Nothing)
                Else
                    .AddWithValue("@foto", Fotos(PicFoto.Image))
                End If

            End With

            Dim x As Integer = command.ExecuteNonQuery
            If x >= 1 Then
                GravaLog(Me.Text, "Gravar", "O usuário " & usuariologado & " cadastrou a foto da empresa")
            End If

        Catch x As Exception
            MsgBox(x)
        Finally
            connection.Close()
            connection = Nothing
            command = Nothing
            sql = Nothing
        End Try

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
                    PicFoto.Image = Nothing
                Else
                    PicFoto.Image = VoltaFotos(reader.Item("foto"))
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
                IdEmpresa = (reader.Item("idempresa").ToString)
                TxTEmpresa.Text = (reader.Item("empresa").ToString)
                txtEndereco.Text = (reader.Item("endereco").ToString)
                txtNumero.Text = (reader.Item("numero").ToString)
                txtBairro.Text = (reader.Item("bairro").ToString)
                TxtCidade.Text = (reader.Item("cidade").ToString)
                cboUF.Text = (reader.Item("uf").ToString)
                txtcep.Text = (reader.Item("cep").ToString)
                txtCnpj.Text = (reader.Item("cnpj").ToString)
                txtEmail.Text = (reader.Item("email").ToString)
                TxTTelefone.Text = (reader.Item("telefone").ToString)
                txtCelular.Text = (reader.Item("celular").ToString)
                txtComplemento.Text = (reader.Item("complemento").ToString)
                txtRazsocial.Text = (reader.Item("razsocial").ToString)
                txtIE.Text = (reader.Item("ie").ToString)
                cbTipoEmpresa.Text = (reader.Item("tipoempresa").ToString)
                cbPorte.Text = (reader.Item("porte").ToString)
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

    Private Sub EditarFotoCadEmpresa()

        Dim sql As String = "update tbfotoempresa set foto=@foto where idcadempresa = @idcadempresa"
        Dim connection As New NpgsqlConnection(cnSQL)
        Dim command As New NpgsqlCommand(sql, connection)

        Try
            connection.Open()

            With command.Parameters
                .AddWithValue("@idcadempresa", IdEmpresa)

                If PicFoto.Image Is Nothing Then
                    .AddWithValue("@foto", Nothing)
                Else
                    .AddWithValue("@foto", Fotos(PicFoto.Image))
                End If
            End With


            Dim x As Integer = command.ExecuteNonQuery()
            If x >= 1 Then
                GravaLog(Me.Text, "Editar", "O usuário " & usuariologado & " editou a foto da empresa")
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
    Private Sub EditarCadEmpresa()
        Try
            Dim sql As String = "update tbcadastroempresa set empresa=@empresa, endereco=@endereco, numero=@numero, bairro=@bairro, cidade=@cidade, uf=@uf, cep=@cep, cnpj=@cnpj, telefone=@telefone, email=@email, celular = @celular, complemento = @complemento, razsocial = @razsocial, ie = @ie, tipoempresa =@tipoempresa, porte =@porte where IdEmpresa = @IdEmpresa"
            Dim connection As New NpgsqlConnection(cnSQL)
            Dim command As New NpgsqlCommand(sql, connection)

            If TxTEmpresa.Text = "" Or txtEndereco.Text = "" Or txtNumero.Text = "" Or txtBairro.Text = "" Or TxtCidade.Text = "" Or cboUF.Text = "" Then



                DevExpress.XtraEditors.XtraMessageBox.Show("É obrigatorio o preenchimento dos campos indicados com o ( * )", "B-INK")
                Exit Sub
            Else
                With command.Parameters
                    .AddWithValue("@IdEmpresa", IdEmpresa)
                    .AddWithValue("@empresa", TxTEmpresa.Text)
                    .AddWithValue("@endereco", txtEndereco.Text)
                    .AddWithValue("@numero", txtNumero.Text)
                    .AddWithValue("@bairro", txtBairro.Text)
                    .AddWithValue("@cidade", TxtCidade.Text)
                    .AddWithValue("@uf", cboUF.Text)
                    .AddWithValue("@cep", txtcep.Text)
                    .AddWithValue("@cnpj", txtCnpj.Text)
                    .AddWithValue("@email", txtEmail.Text)
                    .AddWithValue("@telefone", TxTTelefone.Text)
                    .AddWithValue("@celular", txtCelular.Text)
                    .AddWithValue("@datacadastro", Date.Now)
                    .AddWithValue("@complemento", txtComplemento.Text)
                    .AddWithValue("@razsocial", txtRazsocial.Text)
                    .AddWithValue("@ie", txtIE.Text)
                    .AddWithValue("@tipoempresa", cbTipoEmpresa.Text)
                    .AddWithValue("@porte", cbPorte.Text)
                End With

                Try
                    connection.Open()

                    Dim x As Integer = command.ExecuteNonQuery()
                    If x >= 1 Then

                        EditarFotoCadEmpresa()


                        DevExpress.XtraEditors.XtraMessageBox.Show(" Dados alterados!" & vbCrLf & "Operação efetuada com sucesso!", "B-INK")

                        GravaLog(Me.Text, "Editar", "O usuário " & usuariologado & " editou o cadastro da empresa")

                        Empresa = New csEmpresa

                        Me.Close()
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
        End Try
    End Sub


    Private Sub frmEmpresa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        tcEmpresa.SelectedPage = tpDadosEmpresa

        lblaviso.Visible = False
        lblAltura.Visible = False
        lblLargura.Visible = False

        TxTEmpresa.Select()
        TxTEmpresa.Focus()

        CarregaEmpresa()
        CarregaFotoEmpresa()

        FundoCombobox(Me)
        FundoTextBox(Me)
        FundoRictext(Me)

        If Not bgwCarregaLogo.IsBusy Then
            bgwCarregaLogo.RunWorkerAsync()
        End If

    End Sub


    Private Sub TxTTelefone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        fTelefone(sender, e)
    End Sub

    Private Sub txtCnpj_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        fCNPJ(sender, e)
    End Sub

    Private Sub txtcep_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        fCEP(sender, e)
    End Sub

    Private Sub TxTCelular_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        fCelular(sender, e)
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        ofd = New OpenFileDialog
        ofd.Filter = "Arquivos de Imagem|*.bmp;*.jpg;*.gif;*.png"
        ofd.FileName = ""
        If (ofd.ShowDialog() = DialogResult.OK) Then
            Dim foto As String = ofd.FileName
            Dim bmp As Image = New Bitmap(foto)
            PicFoto.Image = bmp

            Dim imgWidth As Integer = PicFoto.Image.Width
            Dim imgHeight As Integer = PicFoto.Image.Height

            lblLargura.Text = imgWidth
            lblAltura.Text = imgHeight

            If lblLargura.Text > 1024 Or lblAltura.Text > 768 Then
                lblaviso.Text = "Foto maior que o permitido, favor verificar!"
                lblaviso.Visible = True
                lblLargura.BackColor = Color.Red
                lblAltura.BackColor = Color.Red
                btnSalvar.Enabled = True
            Else

                lblaviso.Visible = False
                lblLargura.BackColor = Color.White
                lblAltura.BackColor = Color.White

                btnSalvar.Enabled = True
            End If
            lblAltura.Visible = True
            lblLargura.Visible = True
        End If
    End Sub

    Private Sub BtnRemovFoto_Click(sender As Object, e As EventArgs) Handles btnRemovFoto.Click
        PicFoto.Image = Nothing
    End Sub

    Private Sub BtnSair_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSair.ItemClick
        Me.Close()
    End Sub

    Private Sub BtnSalvar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick
        If PicFoto.Image IsNot Nothing Then

            Dim imgWidth As Integer = PicFoto.Image.Width
            Dim imgHeight As Integer = PicFoto.Image.Height

            lblLargura.Text = imgWidth
            lblAltura.Text = imgHeight


            If lblLargura.Text > 1024 Or lblAltura.Text > 768 Then

                DevExpress.XtraEditors.XtraMessageBox.Show("Não é permitido foto com o tamanho maior que 1024 x 768!", "B-INK")

                Exit Sub
            End If

        End If

        Dim vc As New CamposObrig(Me)

        vc.AddCampoLivre(txtEmail)
        vc.AddCampoLivre(TxTTelefone)
        vc.AddCampoLivre(txtComplemento)

        If vc.VerificarControl(GroupBox1, True, True) Then

            If mdoFormatos.IsEmail(txtEmail.Text, False) Then

                If IdEmpresa <> 0 Then
                    EditarCadEmpresa()
                Else
                    GravaDadosEmpresa(IdEmpresa)
                End If

            Else
                DevExpress.XtraEditors.XtraMessageBox.Show("E-mail em formato inválido, favor verificar!", "B-INK")
                Exit Sub
            End If

        End If
    End Sub
End Class