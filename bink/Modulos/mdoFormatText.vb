Module mdoFormatText
    Public Function FormataCelular(celular As String, Optional ByVal codPais As Boolean = True) As String

        Dim ret As String = celular.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "")

        If ret.Length = 10 Then

            Dim ddd As String = ret.Substring(0, 2)

            ret = ret.Remove(0, 2)

            ret = ddd & "9" & ret

        End If

        If ret.Length <> 11 Then
            Return ""
        End If

        If codPais Then
            ret = "+55" & ret
        Else
            Return "(" & ret.Substring(0, 2) & ") " & ret.Substring(2, 5) & "-" & ret.Substring(7, 4)
        End If

        Return ret

    End Function





    Public Sub fNumerosDecimais(ByRef sender As Object, ByRef e As System.Windows.Forms.KeyPressEventArgs)

        Dim KeyAscii As Short = Asc(e.KeyChar)
        If KeyAscii <> 8 And KeyAscii <> 44 And KeyAscii <= 47 Or KeyAscii >= 58 Then
            KeyAscii = 0
        End If
        e.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            e.Handled = True
        End If

    End Sub

    Public Sub formatCEP(ByVal txtTexto As Object)

        If Len(txtTexto.Text) = 5 Then
            txtTexto.Text = txtTexto.Text & "-"
            txtTexto.SelectionStart = Len(txtTexto.Text) + 1
        End If

    End Sub

    Public Sub fNumerosInteiros(ByRef sender As Object, ByRef e As System.Windows.Forms.KeyPressEventArgs)

        Dim KeyAscii As Short = Asc(e.KeyChar)
        If KeyAscii >= 32 And KeyAscii <= 47 Or KeyAscii >= 58 Then
            KeyAscii = 0
        End If
        e.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            e.Handled = True
        End If

    End Sub

    Public Sub formatTelefone(ByVal txtTexto As Object)

        If Len(txtTexto.Text) = 1 Then
            txtTexto.SelectionStart = 0
            Dim texto As String = txtTexto.text
            txtTexto.Text = "("
            txtTexto.text = txtTexto.text & texto
            txtTexto.SelectionStart = Len(txtTexto.Text) + 1
        ElseIf Len(txtTexto.Text) = 3 Then
            txtTexto.Text = txtTexto.Text & ") "
            txtTexto.SelectionStart = Len(txtTexto.Text) + 1
        ElseIf Len(txtTexto.Text) = 9 Then
            txtTexto.Text = txtTexto.Text & "-"
            txtTexto.SelectionStart = Len(txtTexto.Text) + 1
        End If

    End Sub

    Public Sub formatCNPJ(ByVal txtTexto As Object)

        If Len(txtTexto.Text) = 2 Then
            txtTexto.Text = txtTexto.Text & "."
            txtTexto.SelectionStart = Len(txtTexto.Text) + 1
        ElseIf Len(txtTexto.Text) = 6 Then
            txtTexto.text = txtTexto.text & "."
            txtTexto.selectionstart = Len(txtTexto.text) + 1
        ElseIf Len(txtTexto.Text) = 10 Then
            txtTexto.text = txtTexto.text & "/"
            txtTexto.selectionstart = Len(txtTexto.text) + 1
        ElseIf Len(txtTexto.Text) = 15 Then
            txtTexto.text = txtTexto.text & "-"
            txtTexto.selectionstart = Len(txtTexto.text) + 2
        End If

    End Sub

    Public Sub fData(ByRef sender As Object, ByRef e As System.Windows.Forms.KeyPressEventArgs)

        Dim txt As TextBox = DirectCast(sender, TextBox)
        txt.MaxLength = 10

        If txt.TextLength = 10 Then
            txt.Text = ""
        End If

        Dim KeyAscii As Short = Asc(e.KeyChar)

        If KeyAscii <> 8 Then
            If (IsNumeric(e.KeyChar) And txt.TextLength < 10) Then
                txt.Text &= e.KeyChar
                txt.SelectionStart = txt.TextLength
                Call formataDATA(txt)
            End If
            e.Handled = True
        Else
            If (IsNumeric(e.KeyChar) And txt.TextLength < 10) Then
                txt.SelectionStart = txt.TextLength
                Call formataDATA(txt)
            End If
        End If
    End Sub

    Public Sub formataHORAS(ByVal txtTexto As Object)

        If Len(txtTexto.Text) = 2 Then
            txtTexto.Text = txtTexto.Text & ":"
            txtTexto.SelectionStart = Len(txtTexto.Text) + 1
        End If

    End Sub

    Public Sub fTelefone(ByRef sender As Object, ByRef e As System.Windows.Forms.KeyPressEventArgs)

        Dim txt As TextBox = DirectCast(sender, TextBox)

        Dim KeyAscii As Short = Asc(e.KeyChar)
        If KeyAscii <> 8 Then
            If (IsNumeric(e.KeyChar) And txt.TextLength < 14) Then
                txt.Text &= e.KeyChar
                txt.SelectionStart = txt.TextLength
                Call formataTelefone(txt)
            End If
            e.Handled = True
        Else
            If (IsNumeric(e.KeyChar) And txt.TextLength < 14) Then
                txt.SelectionStart = txt.TextLength
                Call formataTelefone(txt)
            End If
        End If
    End Sub

    Public Sub fCelular(ByRef sender As Object, ByRef e As System.Windows.Forms.KeyPressEventArgs)

        Dim txt As TextBox = DirectCast(sender, TextBox)

        Dim t As Integer = 14

        If txt.Text.ToString.Length >= 3 Then
            Dim ddd As String = txt.Text.ToString.Substring(1, 2).Trim
            Select Case ddd
                Case "11"
                    t = 15
                Case "12"
                    t = 15
                Case "13"
                    t = 15
                Case "14"
                    t = 15
                Case "15"
                    t = 15
                Case "16"
                    t = 15
                Case "17"
                    t = 15
                Case "18"
                    t = 15
                Case "19"
                    t = 15
            End Select
        End If

        Dim KeyAscii As Short = Asc(e.KeyChar)
        If KeyAscii <> 8 Then
            If (IsNumeric(e.KeyChar) And txt.TextLength < t) Then
                txt.Text &= e.KeyChar
                txt.SelectionStart = txt.TextLength
                Call formataCelular(txt)
            End If
            e.Handled = True
        Else
            If (IsNumeric(e.KeyChar) And txt.TextLength < t) Then
                txt.SelectionStart = txt.TextLength
                Call formataCelular(txt)
            End If
        End If
    End Sub

    Public Sub fCPF(ByRef sender As Object, ByRef e As System.Windows.Forms.KeyPressEventArgs)

        Dim txt As TextBox = DirectCast(sender, TextBox)

        Dim KeyAscii As Short = Asc(e.KeyChar)

        If KeyAscii <> 8 Then
            If (IsNumeric(e.KeyChar) And txt.TextLength < 14) Then
                txt.Text &= e.KeyChar
                txt.SelectionStart = txt.TextLength
                Call formatacpf(txt)
            End If
            e.Handled = True
        Else
            If (IsNumeric(e.KeyChar) And txt.TextLength < 14) Then
                txt.SelectionStart = txt.TextLength
                Call formatacpf(txt)
            End If
        End If
    End Sub

    Public Sub fCEP(ByRef sender As Object, ByRef e As System.Windows.Forms.KeyPressEventArgs)

        Dim txt As TextBox = DirectCast(sender, TextBox)

        Dim KeyAscii As Short = Asc(e.KeyChar)
        If KeyAscii <> 8 Then
            If (IsNumeric(e.KeyChar) And txt.TextLength < 9) Then
                txt.Text &= e.KeyChar
                txt.SelectionStart = txt.TextLength
                Call formataCEP(txt)
            End If
            e.Handled = True
        Else
            If (IsNumeric(e.KeyChar) And txt.TextLength < 9) Then
                txt.SelectionStart = txt.TextLength
                Call formataCEP(txt)
            End If
        End If
    End Sub

    Public Sub fCNPJ(ByRef sender As TextBox, ByRef e As System.Windows.Forms.KeyPressEventArgs)

        Dim txt As TextBox = DirectCast(sender, TextBox)

        Dim KeyAscii As Short = Asc(e.KeyChar)
        If KeyAscii <> 8 Then
            If (IsNumeric(e.KeyChar) And txt.TextLength < 18) Then
                txt.Text &= e.KeyChar
                txt.SelectionStart = txt.TextLength
                Call formatacnpj(txt)
            End If
            e.Handled = True
        Else
            If (IsNumeric(e.KeyChar) And txt.TextLength < 18) Then
                txt.SelectionStart = txt.TextLength
                Call formatacnpj(txt)
            End If
        End If
    End Sub

    Public Sub QTDdata(ByVal data1 As DateTime, ByVal data2 As DateTime, Optional ByRef anos As Integer = 0, Optional ByRef meses As Integer = 0, Optional ByRef dias As Integer = 0)

        Dim anoss As Integer = data2.Year - data1.Year

        If data2.Month > data1.Month Or (data2.Month = data1.Month And data2.Day > data1.Day) Then
            anoss += 1
        End If

        Dim mesess1 As Double = (((data1.Year - 1) * 12) + data1.Month)
        Dim mesess2 As Double = (((data2.Year - 1) * 12) + data2.Month)
        Dim mesess As Integer = mesess2 - mesess1

        If data2.Day < data1.Day Then
            mesess -= 1
        End If

        If anoss < 0 Then
            anoss = 0
        End If

        If mesess < 0 Then
            mesess = 0
        End If

        anos = anoss
        meses = mesess

        Dim tt As TimeSpan
        tt = data2.Subtract(data1)
        dias = tt.Days + 1

    End Sub

    Public Sub fHoraH(ByRef sender As Object, ByRef e As System.Windows.Forms.KeyPressEventArgs)

        Dim txt As TextBox = DirectCast(sender, TextBox)

        Dim KeyAscii As Short = Asc(e.KeyChar)

        If KeyAscii <> 8 Then
            If (IsNumeric(e.KeyChar) And txt.TextLength < 5) Then
                txt.Text &= e.KeyChar
                txt.SelectionStart = txt.TextLength
                Call formataHoraH(txt)
            End If
            e.Handled = True
        Else
            If (IsNumeric(e.KeyChar) And txt.TextLength < 5) Then
                txt.SelectionStart = txt.TextLength
                Call formataHoraH(txt)
            End If
        End If
    End Sub

    Public Sub fHora(ByRef sender As Object, ByRef e As System.Windows.Forms.KeyPressEventArgs)

        Dim txt As TextBox = DirectCast(sender, TextBox)

        Dim KeyAscii As Short = Asc(e.KeyChar)

        If KeyAscii <> 8 Then
            If (IsNumeric(e.KeyChar) And txt.TextLength < 5) Then
                txt.Text &= e.KeyChar
                txt.SelectionStart = txt.TextLength
                Call formataHora(txt)
            End If
            e.Handled = True
        Else
            If (IsNumeric(e.KeyChar) And txt.TextLength < 5) Then
                txt.SelectionStart = txt.TextLength
                Call formataHora(txt)
            End If
        End If
    End Sub

    Private Sub formataDATA(ByVal txtTexto As Object)
        If Len(txtTexto.Text) = 2 Then
            txtTexto.Text = txtTexto.Text & "/"
            txtTexto.SelectionStart = Len(txtTexto.Text) + 1
        ElseIf Len(txtTexto.Text) = 5 Then
            txtTexto.Text = txtTexto.Text & "/"
            txtTexto.SelectionStart = Len(txtTexto.Text) + 1
        End If
    End Sub

    Private Sub formataTelefone(ByVal txtTexto As Object)
        If Len(txtTexto.Text) = 1 Then
            txtTexto.SelectionStart = 0
            Dim texto As String = txtTexto.text
            txtTexto.Text = "("
            txtTexto.text = txtTexto.text & texto
            txtTexto.SelectionStart = Len(txtTexto.Text) + 1
        ElseIf Len(txtTexto.Text) = 3 Then
            txtTexto.Text = txtTexto.Text & ") "
            txtTexto.SelectionStart = Len(txtTexto.Text) + 1
        ElseIf Len(txtTexto.Text) = 9 Then
            txtTexto.Text = txtTexto.Text & "-"
            txtTexto.SelectionStart = Len(txtTexto.Text) + 1
        End If
    End Sub

    Private Sub formataCelular(ByVal txtTexto As Object)

        Dim v As Integer = 9

        If txtTexto.Text.ToString.Length >= 3 Then
            Dim ddd As String = txtTexto.Text.ToString.Substring(1, 2).Trim
            Select Case ddd
                Case "11"
                    v = 10
                Case "12"
                    v = 10
                Case "13"
                    v = 10
                Case "14"
                    v = 10
                Case "15"
                    v = 10
                Case "16"
                    v = 10
                Case "17"
                    v = 10
                Case "18"
                    v = 10
                Case "19"
                    v = 10
            End Select
        End If

        If Len(txtTexto.Text) = 1 Then
            txtTexto.SelectionStart = 0
            Dim texto As String = txtTexto.text
            txtTexto.Text = "("
            txtTexto.text = txtTexto.text & texto
            txtTexto.SelectionStart = Len(txtTexto.Text) + 1
        ElseIf Len(txtTexto.Text) = 3 Then
            txtTexto.Text = txtTexto.Text & ") "
            txtTexto.SelectionStart = Len(txtTexto.Text) + 1
        ElseIf Len(txtTexto.Text) = v Then
            txtTexto.Text = txtTexto.Text & "-"
            txtTexto.SelectionStart = Len(txtTexto.Text) + 1
        End If
    End Sub

    Private Sub formataCEP(ByVal txtTexto As Object)
        If Len(txtTexto.Text) = 5 Then
            txtTexto.Text = txtTexto.Text & "-"
            txtTexto.SelectionStart = Len(txtTexto.Text) + 1
        End If
    End Sub

    Private Sub formataHora(ByVal txtTexto As Object)
        If Len(txtTexto.Text) = 2 Then
            txtTexto.Text = txtTexto.Text & ":"
            txtTexto.SelectionStart = Len(txtTexto.Text) + 1
        End If
    End Sub

    Private Sub formataHoraH(ByVal txtTexto As Object)
        If Len(txtTexto.Text) = 2 Then
            txtTexto.Text = txtTexto.Text & "h"
            txtTexto.SelectionStart = Len(txtTexto.Text) + 1
        End If
    End Sub

    Private Sub formatacpf(ByVal txtTexto As Object)
        If Len(txtTexto.Text) = 3 Then
            txtTexto.Text = txtTexto.Text & "."
            txtTexto.SelectionStart = Len(txtTexto.Text) + 1
        ElseIf Len(txtTexto.Text) = 7 Then
            txtTexto.Text = txtTexto.Text & "."
            txtTexto.SelectionStart = Len(txtTexto.Text) + 1
        ElseIf Len(txtTexto.Text) = 11 Then
            txtTexto.Text = txtTexto.Text & "-"
            txtTexto.SelectionStart = Len(txtTexto.Text) + 1
        End If

    End Sub




    Private Sub formatacnpj(ByVal txtTexto As Object)
        If Len(txtTexto.Text) = 2 Then
            txtTexto.Text = txtTexto.Text & "."
            txtTexto.SelectionStart = Len(txtTexto.Text) + 1
        ElseIf Len(txtTexto.Text) = 6 Then
            txtTexto.Text = txtTexto.Text & "."
            txtTexto.SelectionStart = Len(txtTexto.Text) + 1
        ElseIf Len(txtTexto.Text) = 10 Then
            txtTexto.Text = txtTexto.Text & "/"
            txtTexto.SelectionStart = Len(txtTexto.Text) + 1
        ElseIf Len(txtTexto.Text) = 15 Then
            txtTexto.Text = txtTexto.Text & "-"
            txtTexto.SelectionStart = Len(txtTexto.Text) + 1
        End If

    End Sub

    ''' <summary>
    ''' Utilizado para exibir todo o conteúdo, evento DropDown
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <remarks></remarks>
    Public Sub cboExtend(ByRef sender As Object)

        Dim senderComboBox As ComboBox = DirectCast(sender, ComboBox)
        Dim width As Integer = senderComboBox.DropDownWidth
        Dim g As Graphics = senderComboBox.CreateGraphics()
        Dim font As Font = senderComboBox.Font
        Dim vertScrollBarWidth As Integer = If((senderComboBox.Items.Count > senderComboBox.MaxDropDownItems), SystemInformation.VerticalScrollBarWidth, 0)

        Dim newWidth As Integer
        For Each s As String In DirectCast(sender, ComboBox).Items
            newWidth = CInt(g.MeasureString(s, font).Width) + vertScrollBarWidth
            If width < newWidth Then
                width = newWidth
            End If
        Next
        senderComboBox.DropDownWidth = width
    End Sub


    Public Sub showToolTipCellValue(ByRef sender As Object, ByRef e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)
        If (e.Value IsNot Nothing) Then
            Dim dgv As New DataGridView
            dgv = sender
            With dgv.Rows(e.RowIndex).Cells(e.ColumnIndex)
                .ToolTipText = .Value.ToString
            End With
        End If
    End Sub

    Public Sub showToolTipCellToolTipText(ByRef sender As Object, ByRef e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)
        If (e.Value IsNot Nothing) Then
            Dim dgv As New DataGridView
            dgv = sender
            With dgv.Rows(e.RowIndex).Cells(e.ColumnIndex)
                .ToolTipText = .ToolTipText.ToString
            End With
        End If
    End Sub
End Module
