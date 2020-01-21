Module mdomsgbox
    ' Dim frm As New MSG.Msg(False)

    Public Enum resp
        yes
        no
        cancel
    End Enum

    Public Enum tipodeperg
        YesNoCancel
        YesNo
        YesNoAlert
        Ok
        ErrorP
        Notifc
    End Enum


    'Public Function fMsgBoxThread(ByVal msg As String, ByVal tperg As tipodeperg, ByVal form As Form) As resp

    '    If form.InvokeRequired Then
    '        Return DirectCast(form.Invoke(New Func(Of resp)(Function() fMsgBoxThread(msg, tperg, form))), resp)
    '    Else

    '        Dim frm As MSG.Msg
    '        frm = New MSG.Msg(False)

    '        '  aplicarCor(frm)

    '        Return frm.MsgBox(msg, tperg)

    '    End If

    'End Function

    'Public Function MsgBox(ByVal msg As String, Optional ByVal tperg As tipodeperg = tipodeperg.Ok, Optional ByVal vnew As Boolean = True) As resp
    '    If vnew = True Then
    '        frm = New MSG.Msg(False)
    '        '   aplicarCor(frm)
    '        Return frm.MsgBox(msg, tperg)
    '    Else
    '        ' aplicarCor(frm)
    '        Return frm.MsgBox(msg, tperg)
    '    End If
    'End Function

    'Public Sub msgbox(ex As Exception)

    '    Dim frm As New MSG.Msg(False)
    '    frm.msgbox(ex)
    'End Sub

    'Delegate Sub DLmsgboxTHR(ex As Exception)
    'Private vmsgboxTHR As DLmsgboxTHR

    'Public Sub msgboxThread(ex As Exception, ByVal frm As Form)
    '    vmsgboxTHR = New DLmsgboxTHR(AddressOf msgboxTHR)
    '    frm.Invoke(vmsgboxTHR, New Object() {ex})
    'End Sub
    'Private Sub msgboxTHR(ex As Exception)

    '    Dim frm As New MSG.Msg(False)
    '    frm.msgbox(ex)
    'End Sub

    Private Function getNome(cam As String) As String
        If cam <> "" Then
            Dim a As String() = cam.Split("\")
            Return a(a.Length - 1)
        Else
            Return ""
        End If
    End Function
End Module
