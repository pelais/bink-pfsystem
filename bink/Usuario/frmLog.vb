Imports System.ComponentModel
Imports Npgsql

Public Class frmLog
    Private Sub BgwCarregaAcessoUsuario_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BgwCarregaAcessoUsuario.DoWork

        DgvConsUsuário.Invoke(New MethodInvoker(Sub()
                                                    DgvConsUsuário.Rows.Clear()
                                                    frmCarregamento.Show()
                                                End Sub))

        Dim sql As String = " select * from tblog  where logado like '%" & TxTBusca.Text & "%'"
        Dim connection As New NpgsqlConnection(cnSQL)
        Dim command As New NpgsqlCommand(sql, connection)
        Try
            connection.Open()

            Dim reader As NpgsqlDataReader = command.ExecuteReader
            If reader.HasRows Then
                While reader.Read()
                    DgvConsUsuário.Invoke(New MethodInvoker(Sub()

                                                                DgvConsUsuário.Rows.Add(reader.Item("IDLOG").ToString, reader.Item("logado").ToString, reader.Item("tela").ToString, reader.Item("funcao").ToString, reader.Item("evento").ToString, FormatDateTime(reader.Item("DATA"), DateFormat.ShortDate).ToString, FormatDateTime(reader.Item("hora").ToString, DateFormat.ShortTime).ToString)
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

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If Not BgwCarregaAcessoUsuario.IsBusy Then
            DgvConsUsuário.Visible = False
            BgwCarregaAcessoUsuario.RunWorkerAsync()
        End If
    End Sub

    Private Sub BgwCarregaAcessoUsuario_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BgwCarregaAcessoUsuario.RunWorkerCompleted
        frmCarregamento.Close()
        DgvConsUsuário.Visible = True
    End Sub
End Class