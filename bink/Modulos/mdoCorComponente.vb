Module mdoCorComponente
#Region "Pinta textbox"
    Public Sub FundoTextBox(ByRef Tela As Control)
        Dim Objeto As Control

        For Each Objeto In Tela.Controls

            If TypeOf Objeto Is System.Windows.Forms.GroupBox Or
                    TypeOf Objeto Is System.Windows.Forms.TabPage Or
                    TypeOf Objeto Is System.Windows.Forms.Panel Or
                    TypeOf Objeto Is System.Windows.Forms.TabControl Or
                    TypeOf Objeto Is System.Windows.Forms.SplitContainer Then
                FundoTextBox(Objeto)
            End If

            If TypeOf Objeto Is System.Windows.Forms.TextBox Then

                If Objeto.BackColor.ToArgb = -1 Or Objeto.BackColor = Color.White Then

                    AddHandler Objeto.GotFocus, AddressOf Text_GotFocus
                    AddHandler Objeto.LostFocus, AddressOf Text_LostFocus
                End If
            End If
        Next
    End Sub
    Public Sub Text_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim Text As TextBox = sender
        Text.BackColor = Color.AliceBlue
    End Sub
    Public Sub Text_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim Text As TextBox = sender
        Text.BackColor = Color.White
    End Sub

#End Region

#Region "Cor Richtextbox"

    Public Sub FundoRictext(ByRef Tela As Control)
        Dim Objeto As Control

        For Each Objeto In Tela.Controls

            If TypeOf Objeto Is System.Windows.Forms.GroupBox Or
                    TypeOf Objeto Is System.Windows.Forms.TabPage Or
                    TypeOf Objeto Is System.Windows.Forms.Panel Or
                    TypeOf Objeto Is System.Windows.Forms.TabControl Or
                      TypeOf Objeto Is System.Windows.Forms.SplitContainer Then
                FundoRictext(Objeto)
            End If

            If TypeOf Objeto Is System.Windows.Forms.RichTextBox Then

                If Objeto.BackColor.ToArgb = -1 Or Objeto.BackColor = Color.White Then
                    AddHandler Objeto.GotFocus, AddressOf RichTextBox_GotFocus
                    AddHandler Objeto.LostFocus, AddressOf RichTextBox_LosFocus
                End If
            End If
        Next
    End Sub
    Public Sub RichTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim rit As RichTextBox = sender
        rit.BackColor = Color.AliceBlue
    End Sub
    Public Sub RichTextBox_LosFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim rit As RichTextBox = sender
        rit.BackColor = Color.White
    End Sub

#End Region

#Region "Pinta Combobox"
    Public Sub FundoCombobox(ByRef Tela As Control)
        Dim Objeto As Control

        For Each Objeto In Tela.Controls

            If TypeOf Objeto Is System.Windows.Forms.GroupBox Or
                    TypeOf Objeto Is System.Windows.Forms.TabPage Or
                    TypeOf Objeto Is System.Windows.Forms.Panel Or
                    TypeOf Objeto Is System.Windows.Forms.TabControl Or
                    TypeOf Objeto Is System.Windows.Forms.SplitContainer Then
                FundoCombobox(Objeto)
            End If

            If TypeOf Objeto Is System.Windows.Forms.ComboBox Then

                If Objeto.BackColor.ToArgb = -1 Or Objeto.BackColor = Color.White Then

                    AddHandler Objeto.GotFocus, AddressOf Combobox_GotFocus
                    AddHandler Objeto.LostFocus, AddressOf ComboBox_LostFocus
                End If
            End If
        Next
    End Sub
    Public Sub Combobox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim combo As ComboBox = sender
        combo.BackColor = Color.AliceBlue
    End Sub
    Public Sub ComboBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim combo As ComboBox = sender
        combo.BackColor = Color.White
    End Sub

#End Region
End Module
