Imports System.ComponentModel

Public Class frmSplash
    Sub New()
        InitializeComponent()
        Me.labelControl1.Text = "Copyright © 2018-" & DateTime.Now.Year.ToString()
    End Sub

    Private Sub Arguments()

        For Each s As String In My.Application.CommandLineArgs
            If s.StartsWith("deploy:") Then
                Deploy = s.Replace("deploy:", "")
            End If
        Next

    End Sub

    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
    End Sub


    Private Sub BgwAtualiza_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwAtualiza.DoWork
        Threading.Thread.Sleep(3000)
    End Sub

    Private Sub bgwAtualiza_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgwAtualiza.RunWorkerCompleted
        frmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles Me.Load
        Arguments()
        bgwAtualiza.RunWorkerAsync()
    End Sub
End Class
