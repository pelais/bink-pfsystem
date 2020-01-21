Imports Npgsql
Imports System.ComponentModel
Imports System.Drawing.Printing
Imports System.IO
Public Class frmCadImagem

    Dim ofd As New OpenFileDialog
    Dim idfoto As Integer

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

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSair.ItemClick
        Me.Close()
    End Sub

    Private Sub BtnRemovFoto_Click(sender As Object, e As EventArgs) Handles btnRemovFoto.Click
        PicFoto.Image = Nothing
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

        End If
    End Sub

    Private Sub FrmCadImagem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FundoTextBox(Me)

        If Not bgwCarregaImagem.IsBusy Then
            bgwCarregaImagem.RunWorkerAsync()
        End If

    End Sub


    Private Sub ConsultaFoto()

        Dim sql As String = "select * from tbfotos where tbfotos.idfoto = " & idfoto & ""
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

    Private Sub gravaFoto()

        Dim sql As String = "insert into tbfotos(nomefoto, foto) Values (@nomefoto, @foto)"
        Dim connection As New NpgsqlConnection(cnSQL)
        Dim command As New NpgsqlCommand(sql, connection)

        Try
            connection.Open()

            With command.Parameters
                If txtNomeFoto.Text = "" Then
                    DevExpress.XtraEditors.XtraMessageBox.Show("É necessário informar um nome para cadastrar a imagem!", "B-INK")
                    Exit Sub
                End If

                .AddWithValue("@nomefoto", txtNomeFoto.Text)

                If PicFoto.Image Is Nothing Then
                    .AddWithValue("@foto", Nothing)
                Else
                    .AddWithValue("@foto", Fotos(PicFoto.Image))
                End If

            End With

            Dim x As Integer = command.ExecuteNonQuery
            If x >= 1 Then
                DevExpress.XtraEditors.XtraMessageBox.Show("Imagem cadastrada com sucesso!", "B-INK")
                GravaLog(Me.Text, "Gravar", "O usuário " & usuariologado & " cadastrou uma foto")
            End If

            BtnLimpar_ItemClick(Nothing, Nothing)

        Catch x As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(x, "B-INK")
        Finally
            connection.Close()
            connection = Nothing
            command = Nothing
            sql = Nothing
        End Try

    End Sub

    Private Sub BgwCarregaImagem_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwCarregaImagem.DoWork
        SetControlVisible(dgvImagem, False)
        clearRows(dgvImagem)

        Dim sql As String = "select * from tbfotos"
        Dim connection As New NpgsqlConnection(cnSQL)
        Dim command As New NpgsqlCommand(sql, connection)
        Try
            connection.Open()
            Dim reader As NpgsqlDataReader = command.ExecuteReader
            If reader.HasRows Then
                While reader.Read()

                    addRow(dgvImagem, New Object() {reader.Item("idfoto").ToString, reader.Item("nomefoto").ToString, reader.Item("foto").ToString})

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

    Private Sub bgwCarregaImagem_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgwCarregaImagem.RunWorkerCompleted
        If dgvImagem.RowCount = 0 Then
            dgvImagem.Enabled = False
        Else
            dgvImagem.Enabled = True
        End If
        dgvImagem.Visible = True
    End Sub

    Private Sub BtnSalvar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick
        If idfoto = 0 Then
            gravaFoto()
        Else
            DevExpress.XtraEditors.XtraMessageBox.Show("Não é possível alterar uma foto já cadastrada." & vbCrLf & "Por favor, verifique!", "B-INK")
        End If
    End Sub

    Private Sub BtnLimpar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick

        PicFoto.Image = Nothing
        txtNomeFoto.Text = ""
        idfoto = 0
        If Not bgwCarregaImagem.IsBusy Then
            bgwCarregaImagem.RunWorkerAsync()
        End If

    End Sub


    Private Sub excluiImagem()


        Dim SQL As String = "Delete from tbfotos Where idfoto = @idfoto"
        Dim connection As New NpgsqlConnection(cnSQL)
        Dim command As New NpgsqlCommand(SQL, connection)

        With command.Parameters

            .AddWithValue("@idfoto", idfoto)

        End With

        Try

            connection.Open()

            Dim x As Integer = command.ExecuteNonQuery()
            If x >= 1 Then


                DevExpress.XtraEditors.XtraMessageBox.Show("Dados excluídos!" & vbCrLf & " Operação efetuada com sucesso!", "B-INK")

                GravaLog(Me.Text, "Excluir", "O Usuário " & usuariologado & " excluiu uma foto cadastrada.")

                BtnLimpar_ItemClick(Nothing, Nothing)

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

    Private Sub DgvImagem_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvImagem.CellClick

        idfoto = dgvImagem.CurrentRow.Cells(colidfoto.Index).Value
        txtNomeFoto.Text = dgvImagem.CurrentRow.Cells(coldescricao.Index).Value
        ConsultaFoto()

    End Sub

    Private Sub BtnExcluir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcluir.ItemClick
        If idfoto = 0 Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Por favor selecione a imagem que deseja exlcuir na aba abaixo.", "B-INK")
        Else
            If DevExpress.XtraEditors.XtraMessageBox.Show("Deseja realmente exluir a imagem " + txtNomeFoto.Text + "?", "B-INK", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                excluiImagem()
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub editaImagem()
        Dim sql As String = "update tbfotos set foto =@foto, nomefoto =@nomefoto where idfoto = @idfoto"
        Dim connection As New NpgsqlConnection(cnSQL)
        Dim command As New NpgsqlCommand(sql, connection)


        Try

            connection.Open()

            With command.Parameters

                .AddWithValue("@idfoto", idfoto)
                .AddWithValue("@senha", txtNomeFoto.Text)

                If PicFoto.Image Is Nothing Then
                    .AddWithValue("@foto", Nothing)
                Else
                    .AddWithValue("@foto", Fotos(PicFoto.Image))
                End If


            End With

            Dim x As Integer = command.ExecuteNonQuery()
            If x >= 1 Then

                DevExpress.XtraEditors.XtraMessageBox.Show(" Dados alterados!" & vbCrLf & " Operação efetuada com sucesso!", "B-INK")
                GravaLog(Me.Text, "Editar", "O Usuário " & usuariologado & " trocou a senha de acesso")

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