Imports System.ComponentModel
Imports System.IO
Imports System.Xml
Imports Npgsql

Public Class frmServidor

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        Dim j As New JanelaExterna(Me, lblTitle)

    End Sub

    Private Sub BtnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalvar.Click

        Dim vc As New CamposObrig(Me)

        If vc.VerificarControl(PnAvisar, True, True) Then

            bgwTestar.RunWorkerAsync()

        End If

    End Sub

    Private Sub Salvar()

        Try

            Dim c As New aes

            Dim settings As New XmlWriterSettings
            settings.Indent = True
            settings.IndentChars = ""
            settings.NewLineOnAttributes = False
            settings.OmitXmlDeclaration = False
            settings.Encoding = System.Text.Encoding.UTF8
            Dim writer As XmlWriter = XmlWriter.Create("c:\configBink\conexao.xml", settings)

            Try

                writer.WriteStartElement("conexoes")

                writer.WriteStartElement("conexao")
                writer.WriteElementString("servidor", c.encrypt(txtServidor.Text, cv, cv))
                writer.WriteElementString("banco", c.encrypt(txtBanco.Text, cv, cv))
                writer.WriteElementString("login", c.encrypt(txtLogin.Text, cv, cv))
                writer.WriteElementString("senha", c.encrypt(txtSenha.Text, cv, cv))
                writer.WriteEndElement()

                writer.WriteEndElement()

            Finally
                writer.Flush()
                writer.Close()
            End Try

            DevExpress.XtraEditors.XtraMessageBox.Show("Conexão salva com sucesso!", "B-INK", MessageBoxButtons.OK)
            Buscar()

        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "B-INK")
        End Try
    End Sub

    Private Sub Buscar()
        Dim dt As New DataSet

        Try

            Dim c As New aes

            If Not Directory.Exists("c:\configBink") Then
                Directory.CreateDirectory("c:\configBink")
            End If

            If Not File.Exists("c:\configBink\conexao.xml") Then
                File.Copy(My.Application.Info.DirectoryPath & "\conexao.xml", "c:\configBink\conexao.xml", True)
            End If

            dt.ReadXml("c:\configBink\conexao.xml")

            txtServidor.Text = c.decrypt(dt.Tables(0).Rows(0)("servidor"), cv, cv)
            txtBanco.Text = c.decrypt(dt.Tables(0).Rows(0)("banco"), cv, cv)
            txtLogin.Text = c.decrypt(dt.Tables(0).Rows(0)("login"), cv, cv)
            txtSenha.Text = c.decrypt(dt.Tables(0).Rows(0)("senha"), cv, cv)

            Server = c.decrypt(dt.Tables(0).Rows(0)("servidor"), cv, cv)
            Database = c.decrypt(dt.Tables(0).Rows(0)("banco"), cv, cv)
            User = c.decrypt(dt.Tables(0).Rows(0)("login"), cv, cv)
            Password = c.decrypt(dt.Tables(0).Rows(0)("senha"), cv, cv)

            cnSQL = "Server=" & txtServidor.Text & "; Database=" & txtBanco.Text & "; user id=" & txtLogin.Text & "; password=" & txtSenha.Text & ";  Pooling=true; MinPoolSize= 0; MaxPoolSize=100; CommandTimeout=900; Timeout=15; ApplicationName=" & My.Application.Info.Title & ";"

        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(ex, "B-INK")
        Finally
            dt.Clear()
            dt.Dispose()
        End Try

    End Sub

    Private Sub frmServidor_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub


    Private Sub frmServidor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FundoTextBox(Me)
        Buscar()
    End Sub

    Private Sub BtnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSair.Click
        Me.Close()
    End Sub

    Private Sub Testar()

        Dim cn As String = "Server=" & txtServidor.Text.Trim & "; Database=" & txtBanco.Text.Trim & "; user id=" & txtLogin.Text.Trim & "; password=" & txtSenha.Text.Trim & ";"
        Dim con As New NpgsqlConnection(cn)

        Try

            con.Open()

            SetControlImage(pbCon, My.Resources.database_accept)
            ' lblStatus.Text = "Conexão realizada com sucesso, por favor salve a conexão!"

            Salvar()

        Catch ex As Exception
            SetControlImage(pbCon, My.Resources.database_remove)
            ' lblStatus.Text = "Não foi possível conectar."
            DevExpress.XtraEditors.XtraMessageBox.Show(ex, "B-INK")
            ' MsgBox("Não foi possivel salvar, pois a conexão não passou no teste!", tipodeperg.Notifc)
        Finally
            con.Close()
            con = Nothing
        End Try
    End Sub

    Private Sub bgwTestar_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwTestar.DoWork
        pbCon.Image = My.Resources.spinner1
        SetControlEnabled(PnAvisar, False)
        Testar()
    End Sub

    Private Sub bgwTestar_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgwTestar.RunWorkerCompleted
        PnAvisar.Enabled = True
    End Sub
End Class