Imports System.IO
'Imports System.Web.Script.Serialization
Imports System.Text.RegularExpressions
Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json
Imports System.Drawing.Imaging
Imports System.Reflection
Imports System.Net
Imports System.Text

Module mdoFormatos
    Public Function addRow(dgv As DataGridView, cells As Object()) As Integer
        If dgv.InvokeRequired Then
            Return DirectCast(dgv.Invoke(New Func(Of Integer)(Function() addRow(dgv, cells))), Integer)
        Else
            Dim li As New DataGridViewRow
            li.CreateCells(dgv)

            For i = 0 To cells.Count - 1
                li.Cells(i).Value = cells(i)
            Next
            dgv.Rows.Add(li)
            Return dgv.RowCount - 1
        End If
    End Function


    Public Function addRow(dgv As DataGridView, row As DataGridViewRow) As Integer
        If dgv.InvokeRequired Then
            Return DirectCast(dgv.Invoke(New Func(Of Integer)(Function() addRow(dgv, row))), Integer)
        Else
            dgv.Rows.Add(row)
            Return dgv.RowCount - 1
        End If
    End Function


    Public Function addItems(cbo As ComboBox, text As String) As Integer
        If cbo.InvokeRequired Then
            Return DirectCast(cbo.Invoke(New Func(Of Integer)(Function() addItems(cbo, text))), Integer)
        Else
            cbo.Items.Add(text)
            Return cbo.Items.Count - 1
        End If
    End Function

    Public Function addRow(l As ArrayList, dgv As DataGridView, frm As Form) As Integer
        If dgv.InvokeRequired Then
            Return DirectCast(frm.Invoke(New Func(Of Integer)(Function() addRow(l, dgv, frm))), Integer)
        Else
            Dim li As New DataGridViewRow
            li.CreateCells(dgv)

            For i = 0 To l.Count - 1
                li.Cells(i).Value = l(i)
            Next

            dgv.Rows.Add(li)

            Return dgv.RowCount - 1

        End If
    End Function


    Public Function Get_JSON_URL(url As String) As String

        Try

            Dim jsonString As String = String.Empty

            Dim req As WebRequest = WebRequest.Create(url)
            Dim res As WebResponse = req.GetResponse()
            Dim iTotalBuffer As Integer = 0
            Dim Buffer(128) As [Byte]
            Dim stream As IO.Stream = res.GetResponseStream()
            iTotalBuffer = stream.Read(Buffer, 0, 128)
            Dim strRes As New StringBuilder("")
            While iTotalBuffer <> 0
                strRes.Append(Encoding.UTF8.GetString(Buffer, 0, iTotalBuffer))
                iTotalBuffer = stream.Read(Buffer, 0, 128)
            End While

            jsonString = strRes.ToString()

            Return jsonString

        Catch ex As Exception
            Throw
            Return ""
        End Try

    End Function

    Public Function ValidaCPF(ByVal CPF As String, Optional ByVal AceitaZero As Boolean = False) As Boolean

        Dim dadosArray() As String

        If AceitaZero Then
            dadosArray = {"111.111.111-11", "222.222.222-22", "333.333.333-33", "444.444.444-44",
                                          "555.555.555-55", "666.666.666-66", "777.777.777-77", "888.888.888-88", "999.999.999-99"}
        Else
            dadosArray = {"000.000.000-00", "111.111.111-11", "222.222.222-22", "333.333.333-33", "444.444.444-44",
                                         "555.555.555-55", "666.666.666-66", "777.777.777-77", "888.888.888-88", "999.999.999-99"}
        End If

        Dim i, x, n1, n2 As Integer

        If CPF.Length <> 14 Or dadosArray.Contains(CPF) Or SomenteNumeros(CPF).Length <> 11 Then
            Return False
        End If

        CPF = CPF.Substring(0, 3) + CPF.Substring(4, 3) + CPF.Substring(8, 3) + CPF.Substring(12)

        For x = 0 To 1

            n1 = 0

            For i = 0 To 8 + x

                n1 = n1 + Val(CPF.Substring(i, 1)) * (10 + x - i)

            Next

            n2 = 11 - (n1 - (Int(n1 / 11) * 11))

            If n2 = 10 Or n2 = 11 Then n2 = 0

            If n2 <> Val(CPF.Substring(9 + x, 1)) Then

                Return False

            End If
        Next

        Return True

    End Function

    Public Function ValidaData(ByVal data As String, Formatar As Boolean, Optional ByRef idade As Integer = 0) As Boolean


        Dim dia As String
        Dim mes As String
        Dim ano As String
        Dim fevereiro As Integer

        Try

            If Formatar Then data = CDate(data).ToString("dd/MM/yyyy")

            idade = 0

            If data.Length <> 10 Then
                Return False
            End If

            dia = Mid(data, 1, 2)
            mes = Mid(data, 4, 2)
            ano = Mid(data, 7, 4)


            'Verificando os meses que podem ter até o dia 31
            If (mes = 1) Or (mes = 3) Or (mes = 5) Or (mes = 7) Or (mes = 8) Or (mes = 10) Or (mes = 12) Then
                If (dia < 1) Or (dia > 31) Then
                    Return False
                End If
            End If

            'Verificando o mes de fevereiro
            If (mes = 2) Then
                If (dia >= 30) Then
                    Return False
                End If
                fevereiro = ano Mod 4
                If (fevereiro <> 0) And (dia = 29) Then
                    Return False
                End If
            End If

            'Verificar os meses que não podem ter dia até 31 e sim até 30
            If (mes = 2) Or (mes = 4) Or (mes = 6) Or (mes = 9) Or (mes = 11) Then
                If (dia < 1) Or (dia > 30) Then
                    Return False
                End If
            End If

            'Verificar os meses 1 A 12
            If (mes < 1) Or (mes > 12) Then
                Return False
            End If

            If CInt(ano) < 1753 Then
                Return False
            End If

            Dim birthdate As Date = data
            Dim years As Integer = DateTime.Now.Year - birthdate.Year
            If DateTime.Now.Month < birthdate.Month Or (DateTime.Now.Month = birthdate.Month And DateTime.Now.Day < birthdate.Day) Then
                years = years - 1
            End If

            idade = years

            Return True

        Catch x As Exception
            Return False
        End Try

    End Function


    Public Function MD5(ByVal str As String) As String

        Dim provider As System.Security.Cryptography.MD5CryptoServiceProvider
        Dim bytValue() As Byte
        Dim bytHash() As Byte
        Dim strOutput As String = ""
        Dim i As Integer

        provider = New System.Security.Cryptography.MD5CryptoServiceProvider()

        bytValue = System.Text.Encoding.UTF8.GetBytes(str)

        bytHash = provider.ComputeHash(bytValue)

        provider.Clear()

        For i = 0 To bytHash.Length - 1

            strOutput &= bytHash(i).ToString("x").PadLeft(2, "0")

        Next

        Return (strOutput)


    End Function

    Public Function GetSelectedValue(ctrl As ComboBox) As Object
        If ctrl.InvokeRequired Then
            Return DirectCast(ctrl.Invoke(New Func(Of Object)(Function() GetSelectedValue(ctrl))), Object)
        Else
            Return ctrl.SelectedValue
        End If
    End Function

    Public Function MD5(ByVal str As Stream) As String

        Dim provider As System.Security.Cryptography.MD5CryptoServiceProvider
        Dim bytHash() As Byte
        Dim strOutput As String = ""
        Dim i As Integer

        provider = New System.Security.Cryptography.MD5CryptoServiceProvider()

        bytHash = provider.ComputeHash(str)

        provider.Clear()

        For i = 0 To bytHash.Length - 1

            strOutput &= bytHash(i).ToString("x").PadLeft(2, "0")

        Next

        Return (strOutput)


    End Function

    Public Function Remove_SQL_Injection(text As String) As String

        If text Is DBNull.Value Then
            Return ""
        End If

        If text = Nothing Then
            Return ""
        End If

        Dim vtext As String = text.Replace("'", "''").Replace("select", "").Replace("drop", "").Replace("--", "").Replace("insert", "").Replace("delete", "").Replace("xp_", "").Replace("update", "").Replace("*/", "").Replace("/*", "")

        Return vtext

    End Function

    Public Function GetCboSelectedIndex(cbo As ComboBox) As Integer
        If cbo.InvokeRequired Then
            Return DirectCast(cbo.Invoke(New Func(Of Integer)(Function() GetCboSelectedIndex(cbo))), Integer)
        Else
            Return cbo.SelectedIndex
        End If
    End Function

    Public Function GetCboSelectedValue(cbo As ComboBox) As Object
        If cbo.InvokeRequired Then
            Return DirectCast(cbo.Invoke(New Func(Of Object)(Function() GetCboSelectedValue(cbo))), Object)
        Else
            Return cbo.SelectedValue
        End If
    End Function


    Public Function GetDTPValueDate(dtp As DateTimePicker) As Date
        If dtp.InvokeRequired Then
            Return DirectCast(dtp.Invoke(New Func(Of Date)(Function() GetDTPValueDate(dtp))), Date)
        Else
            Return dtp.Value.Date
        End If
    End Function


    Public Function GetCboItemsCount(cbo As ComboBox) As Integer
        If cbo.InvokeRequired Then
            Return DirectCast(cbo.Invoke(New Func(Of Integer)(Function() GetCboItemsCount(cbo))), Integer)
        Else
            Return cbo.Items.Count
        End If
    End Function


    Public Function GetCboItem(cbo As ComboBox, index As Integer) As String
        If cbo.InvokeRequired Then
            Return DirectCast(cbo.Invoke(New Func(Of String)(Function() GetCboItem(cbo, index))), String)
        Else
            Return cbo.Items(index)
        End If
    End Function


    Private Delegate Sub clearItemsD(ByRef cbo As ComboBox)
    Public Sub clearItems(ByRef cbo As ComboBox)

        If cbo.InvokeRequired Then
            Dim d As New clearItemsD(AddressOf clearItems)
            cbo.Invoke(d, New Object() {cbo})
        Else
            cbo.Items.Clear()
        End If

    End Sub

    Private Delegate Sub clearLinhaD(ByRef dgv As DataGridView)
    Public Sub clearRows(ByRef dgv As DataGridView)

        If dgv.InvokeRequired Then
            Dim d As New clearLinhaD(AddressOf clearRows)
            dgv.Invoke(d, New Object() {dgv})
        Else
            dgv.Rows.Clear()
        End If

    End Sub


    Private Delegate Sub DelRemoveLinha(dgv As DataGridView, row As DataGridViewRow)
    Public Sub RemoveRow(dgv As DataGridView, row As DataGridViewRow)
        If dgv.InvokeRequired Then
            dgv.Invoke(New DelRemoveLinha(AddressOf RemoveRow), New Object() {dgv, row})
        Else
            dgv.Rows.Remove(row)
        End If
    End Sub

    Private Delegate Sub DelSetControlVisible(ctrl As Control, visible As Boolean)
    Public Sub SetControlVisible(ctrl As Control, visible As Boolean)
        If ctrl.InvokeRequired Then
            ctrl.Invoke(New DelSetControlVisible(AddressOf SetControlVisible), New Object() {ctrl, visible})
        Else
            ctrl.Visible = visible
        End If
    End Sub

    Private Delegate Sub DelSetToolStripMenuItemVisible(menu As MenuStrip, ctrl As ToolStripMenuItem, visible As Boolean)
    Public Sub SetToolStripMenuItemVisible(menu As MenuStrip, ctrl As ToolStripMenuItem, visible As Boolean)
        If menu.InvokeRequired Then
            menu.Invoke(New DelSetToolStripMenuItemVisible(AddressOf SetToolStripMenuItemVisible), New Object() {menu, ctrl, visible})
        Else
            ctrl.Visible = visible
        End If
    End Sub


    Private Delegate Sub DelSetToolStripMenuItemText(menu As MenuStrip, ctrl As ToolStripMenuItem, text As String)
    Public Sub SetToolStripMenuItemText(menu As MenuStrip, ctrl As ToolStripMenuItem, text As String)
        If menu.InvokeRequired Then
            menu.Invoke(New DelSetToolStripMenuItemText(AddressOf SetToolStripMenuItemText), New Object() {menu, ctrl, text})
        Else
            ctrl.Text = text
        End If
    End Sub


    Private Delegate Sub DelSetToolStripMenuItemFont(menu As MenuStrip, ctrl As ToolStripMenuItem, font As Font)
    Public Sub SetToolStripMenuItemFont(menu As MenuStrip, ctrl As ToolStripMenuItem, font As Font)
        If menu.InvokeRequired Then
            menu.Invoke(New DelSetToolStripMenuItemFont(AddressOf SetToolStripMenuItemFont), New Object() {menu, ctrl, font})
        Else
            ctrl.Font = font
        End If
    End Sub


    Private Delegate Sub DelSetRowVisible(dgv As DataGridView, ctrl As DataGridViewRow, visible As Boolean)
    Public Sub SetRowVisible(dgv As DataGridView, ctrl As DataGridViewRow, visible As Boolean)
        If dgv.InvokeRequired Then
            dgv.Invoke(New DelSetRowVisible(AddressOf SetRowVisible), New Object() {dgv, ctrl, visible})
        Else
            ctrl.Visible = visible
        End If
    End Sub


    Private Delegate Sub DelSetRowSelected(dgv As DataGridView, ctrl As DataGridViewRow, Selected As Boolean)
    Public Sub SetRowSelected(dgv As DataGridView, ctrl As DataGridViewRow, Selected As Boolean)
        If dgv.InvokeRequired Then
            dgv.Invoke(New DelSetRowSelected(AddressOf SetRowSelected), New Object() {dgv, ctrl, Selected})
        Else
            ctrl.Selected = Selected
        End If
    End Sub


    Private Delegate Sub DelSetRowSelectionBackColor(dgv As DataGridView, row As DataGridViewRow, color As Color)
    Public Sub SetRowSelectionBackColor(dgv As DataGridView, row As DataGridViewRow, color As Color)
        If dgv.InvokeRequired Then
            dgv.Invoke(New DelSetRowSelectionBackColor(AddressOf SetRowSelectionBackColor), New Object() {dgv, row, color})
        Else
            row.DefaultCellStyle.SelectionBackColor = color
        End If
    End Sub


    Private Delegate Sub DelSetRowSelectionForeColor(dgv As DataGridView, row As DataGridViewRow, color As Color)
    Public Sub SetRowSelectionForeColor(dgv As DataGridView, row As DataGridViewRow, color As Color)
        If dgv.InvokeRequired Then
            dgv.Invoke(New DelSetRowSelectionForeColor(AddressOf SetRowSelectionForeColor), New Object() {dgv, row, color})
        Else
            row.DefaultCellStyle.SelectionForeColor = color
        End If
    End Sub


    Private Delegate Sub DelSetRowBackColor(dgv As DataGridView, row As DataGridViewRow, color As Color)
    Public Sub SetRowBackColor(dgv As DataGridView, row As DataGridViewRow, color As Color)
        If dgv.InvokeRequired Then
            dgv.Invoke(New DelSetRowBackColor(AddressOf SetRowBackColor), New Object() {dgv, row, color})
        Else
            row.DefaultCellStyle.BackColor = color
        End If
    End Sub



    Private Delegate Sub DelSetRowForeColor(dgv As DataGridView, row As DataGridViewRow, color As Color)
    Public Sub SetRowForeColor(dgv As DataGridView, row As DataGridViewRow, color As Color)
        If dgv.InvokeRequired Then
            dgv.Invoke(New DelSetRowForeColor(AddressOf SetRowForeColor), New Object() {dgv, row, color})
        Else
            row.DefaultCellStyle.ForeColor = color
        End If
    End Sub

    Private Delegate Sub DelSetColVisible(dgv As DataGridView, ctrl As DataGridViewColumn, visible As Boolean)
    Public Sub SetColumnVisible(dgv As DataGridView, ctrl As DataGridViewColumn, visible As Boolean)
        If dgv.InvokeRequired Then
            dgv.Invoke(New DelSetColVisible(AddressOf SetColumnVisible), New Object() {dgv, ctrl, visible})
        Else
            ctrl.Visible = visible
        End If
    End Sub

    Private Delegate Sub delAppendText(rtb As RichTextBox, text As String)
    Public Sub AppendText(rtb As RichTextBox, text As String)
        If rtb.InvokeRequired Then
            Dim d As New delAppendText(AddressOf AppendText)
            rtb.Invoke(d, New Object() {rtb, text})
        Else
            rtb.AppendText(text)
        End If
    End Sub



    Private Delegate Sub DelCelValue(dgv As DataGridView, cel As DataGridViewCell, value As Object)
    Public Sub SetCelValue(dgv As DataGridView, cel As DataGridViewCell, value As Object)
        If dgv.InvokeRequired Then
            dgv.Invoke(New DelCelValue(AddressOf SetCelValue), New Object() {dgv, cel, value})
        Else
            cel.Value = value
        End If
    End Sub

    Private Delegate Sub DelCelValueAdd(dgv As DataGridView, cel As DataGridViewCell, value As Single)
    Public Sub SetCelValueAdd(dgv As DataGridView, cel As DataGridViewCell, value As Single)
        If dgv.InvokeRequired Then
            dgv.Invoke(New DelCelValueAdd(AddressOf SetCelValueAdd), New Object() {dgv, cel, value})
        Else
            cel.Value += value
        End If
    End Sub


    Private Delegate Sub DelCelBackColor(dgv As DataGridView, cel As DataGridViewCell, cor As Color)
    Public Sub SetCelBackColor(dgv As DataGridView, cel As DataGridViewCell, cor As Color)
        If dgv.InvokeRequired Then
            dgv.Invoke(New DelCelBackColor(AddressOf SetCelBackColor), New Object() {dgv, cel, cor})
        Else
            cel.Style.BackColor = cor
        End If
    End Sub

    Private Delegate Sub DelCelForeColor(dgv As DataGridView, cel As DataGridViewCell, cor As Color)
    Public Sub SetCelForeColor(dgv As DataGridView, cel As DataGridViewCell, cor As Color)
        If dgv.InvokeRequired Then
            dgv.Invoke(New DelCelForeColor(AddressOf SetCelForeColor), New Object() {dgv, cel, cor})
        Else
            cel.Style.ForeColor = cor
        End If
    End Sub


    Private Delegate Sub DelCelSelectionBackColor(dgv As DataGridView, cel As DataGridViewCell, cor As Color)
    Public Sub SetCelSelectionBackColor(dgv As DataGridView, cel As DataGridViewCell, cor As Color)
        If dgv.InvokeRequired Then
            dgv.Invoke(New DelCelSelectionBackColor(AddressOf SetCelSelectionBackColor), New Object() {dgv, cel, cor})
        Else
            cel.Style.SelectionBackColor = cor
        End If
    End Sub


    Private Delegate Sub DelCelSelectionForeColor(dgv As DataGridView, cel As DataGridViewCell, cor As Color)
    Public Sub SetCelSelectionForeColor(dgv As DataGridView, cel As DataGridViewCell, cor As Color)
        If dgv.InvokeRequired Then
            dgv.Invoke(New DelCelSelectionForeColor(AddressOf SetCelSelectionForeColor), New Object() {dgv, cel, cor})
        Else
            cel.Style.SelectionForeColor = cor
        End If
    End Sub


    Private Delegate Sub DelCelTag(dgv As DataGridView, cel As DataGridViewCell, value As Object)
    Public Sub SetCelTag(dgv As DataGridView, cel As DataGridViewCell, value As Object)
        If dgv.InvokeRequired Then
            dgv.Invoke(New DelCelTag(AddressOf SetCelTag), New Object() {dgv, cel, value})
        Else
            cel.Tag = value
        End If
    End Sub

    Private Delegate Sub DelCelToolTipText(dgv As DataGridView, cel As DataGridViewCell, value As String)
    Public Sub SetCelToolTipText(dgv As DataGridView, cel As DataGridViewCell, value As String)
        If dgv.InvokeRequired Then
            dgv.Invoke(New DelCelToolTipText(AddressOf SetCelToolTipText), New Object() {dgv, cel, value})
        Else
            cel.ToolTipText = value
        End If
    End Sub


    Private Delegate Sub DelRowTag(dgv As DataGridView, row As DataGridViewRow, value As Object)
    Public Sub SetRowTag(dgv As DataGridView, row As DataGridViewRow, value As Object)
        If dgv.InvokeRequired Then
            dgv.Invoke(New DelRowTag(AddressOf SetRowTag), New Object() {dgv, row, value})
        Else
            row.Tag = value
        End If
    End Sub

    Private Delegate Sub setDGVHeightD(ByRef dgv As DataGridView, Height As Integer, frm As Form)
    Public Sub SetDGVHeight(ByRef dgv As DataGridView, Height As Integer, frm As Form)
        If dgv.InvokeRequired Then
            Dim d As New setDGVHeightD(AddressOf SetDGVHeight)
            frm.Invoke(d, New Object() {dgv, Height, frm})
        Else
            dgv.Height = Height
        End If

    End Sub

    Private Delegate Sub delSetRowReadOnly(dgv As DataGridView, row As DataGridViewRow, value As Boolean)
    Public Sub SetRowReadOnly(dgv As DataGridView, row As DataGridViewRow, value As Boolean)
        If dgv.InvokeRequired Then
            Dim d As New delSetRowReadOnly(AddressOf SetRowReadOnly)
            dgv.Invoke(d, New Object() {dgv, row, value})
        Else
            row.ReadOnly = value
        End If
    End Sub

    Private Delegate Sub DelCelReadOnly(dgv As DataGridView, cel As DataGridViewCell, Value As Boolean)
    Public Sub SetCelReadOnly(dgv As DataGridView, cel As DataGridViewCell, value As Boolean)
        If dgv.InvokeRequired Then
            dgv.Invoke(New DelCelReadOnly(AddressOf SetCelReadOnly), New Object() {dgv, cel, value})
        Else
            cel.ReadOnly = value
        End If
    End Sub

    Private Delegate Sub DelSetDataSouce_DGV(dgv As DataGridView, value As Object)
    Public Sub SetDataSouce_DGV(dgv As DataGridView, value As Object)
        If dgv.InvokeRequired Then
            dgv.Invoke(New DelSetDataSouce_DGV(AddressOf SetDataSouce_DGV), New Object() {dgv, value})
        Else
            dgv.DataSource = value
        End If
    End Sub


    Private Delegate Sub DelSetDataSouce_CBO(cbo As ComboBox, value As Object)
    Public Sub SetDataSouce_CBO(cbo As ComboBox, value As Object)
        If cbo.InvokeRequired Then
            cbo.Invoke(New DelSetDataSouce_CBO(AddressOf SetDataSouce_CBO), New Object() {cbo, value})
        Else
            cbo.DataSource = value
        End If
    End Sub


    Private Delegate Sub DelSetControlChecked(ctrl As CheckBox, Checked As Boolean)
    Public Sub SetControlChecked(ctrl As CheckBox, Checked As Boolean)
        If ctrl.InvokeRequired Then
            ctrl.Invoke(New DelSetControlChecked(AddressOf SetControlChecked), New Object() {ctrl, Checked})
        Else
            ctrl.Checked = Checked
        End If
    End Sub

    Private Delegate Sub DelSetControlEnabled(ctrl As Control, Enabled As Boolean)
    Public Sub SetControlEnabled(ctrl As Control, Enabled As Boolean)
        If ctrl.InvokeRequired Then
            ctrl.Invoke(New DelSetControlEnabled(AddressOf SetControlEnabled), New Object() {ctrl, Enabled})
        Else
            ctrl.Enabled = Enabled
        End If
    End Sub

    Private Delegate Sub DelSetSelectTabPage(tabc As TabControl, tabp As TabPage)
    Public Sub SetSelectTabPage(tabc As TabControl, tabp As TabPage)
        If tabc.InvokeRequired Then
            tabc.Invoke(New DelSetSelectTabPage(AddressOf SetSelectTabPage), New Object() {tabc, tabp})
        Else
            tabc.SelectedTab = tabp
        End If
    End Sub


    Private Delegate Sub DelSetDTPValue(dtp As DateTimePicker, value As Date)
    Public Sub SetDTPValue(dtp As DateTimePicker, value As Date)
        If dtp.InvokeRequired Then
            dtp.Invoke(New DelSetDTPValue(AddressOf SetDTPValue), New Object() {dtp, value})
        Else
            dtp.Value = value
        End If
    End Sub

    Private Delegate Sub DelSetDTPMaxDate(dtp As DateTimePicker, value As Date)
    Public Sub SetDTPMaxDate(dtp As DateTimePicker, value As Date)
        If dtp.InvokeRequired Then
            dtp.Invoke(New DelSetDTPMaxDate(AddressOf SetDTPMaxDate), New Object() {dtp, value})
        Else
            dtp.MaxDate = value
        End If
    End Sub


    Private Delegate Sub DelSetDTPMinDate(dtp As DateTimePicker, value As Date)
    Public Sub SetDTPMinDate(dtp As DateTimePicker, value As Date)
        If dtp.InvokeRequired Then
            dtp.Invoke(New DelSetDTPMinDate(AddressOf SetDTPMinDate), New Object() {dtp, value})
        Else
            dtp.MinDate = value
        End If
    End Sub

    Private Delegate Sub DelSetControlForeColor(ctrl As Control, cor As Color)
    Public Sub SetControlForeColor(ctrl As Control, cor As Color)
        If ctrl.InvokeRequired Then
            ctrl.Invoke(New DelSetControlForeColor(AddressOf SetControlForeColor), New Object() {ctrl, cor})
        Else
            ctrl.ForeColor = cor
        End If
    End Sub

    Private Delegate Sub DelSetControlBackColor(ctrl As Control, cor As Color)
    Public Sub SetControlBackColor(ctrl As Control, cor As Color)
        If ctrl.InvokeRequired Then
            ctrl.Invoke(New DelSetControlBackColor(AddressOf SetControlBackColor), New Object() {ctrl, cor})
        Else
            ctrl.BackColor = cor
        End If
    End Sub

    Private Delegate Sub DelSetControlText(ctrl As Control, text As String)
    Public Sub SetControlText(ctrl As Control, text As String)
        If ctrl.InvokeRequired Then
            ctrl.Invoke(New DelSetControlText(AddressOf SetControlText), New Object() {ctrl, text})
        Else
            ctrl.Text = text
        End If
    End Sub


    Private Delegate Sub DelSetRichTextBoxRTF(ctrl As RichTextBox, RTF As String)
    Public Sub SetRichTextBoxRTF(ctrl As RichTextBox, RTF As String)
        If ctrl.InvokeRequired Then
            ctrl.Invoke(New DelSetRichTextBoxRTF(AddressOf SetRichTextBoxRTF), New Object() {ctrl, RTF})
        Else
            ctrl.Rtf = RTF
        End If
    End Sub


    Private Delegate Sub DelSetToolStripStatusLabelText(toolStrip As ToolStrip, ctrl As ToolStripStatusLabel, text As String)
    Public Sub SetToolStripStatusLabelText(toolStrip As ToolStrip, ctrl As ToolStripStatusLabel, text As String)
        If toolStrip.InvokeRequired Then
            toolStrip.Invoke(New DelSetToolStripStatusLabelText(AddressOf SetToolStripStatusLabelText), New Object() {toolStrip, ctrl, text})
        Else
            ctrl.Text = text
        End If
    End Sub


    Private Delegate Sub DelSetToolStripStatusLabelForeColor(toolStrip As ToolStrip, ctrl As ToolStripStatusLabel, cor As Color)
    Public Sub SetToolStripStatusLabelForeColor(toolStrip As ToolStrip, ctrl As ToolStripStatusLabel, cor As Color)
        If toolStrip.InvokeRequired Then
            toolStrip.Invoke(New DelSetToolStripStatusLabelForeColor(AddressOf SetToolStripStatusLabelForeColor), New Object() {toolStrip, ctrl, cor})
        Else
            ctrl.ForeColor = cor
        End If
    End Sub


    Private Delegate Sub DelSetToolStripMenuItemForeColor(menuStrip As MenuStrip, ctrl As ToolStripMenuItem, cor As Color)
    Public Sub SetToolStripMenuItemForeColor(menuStrip As MenuStrip, ctrl As ToolStripMenuItem, cor As Color)
        If menuStrip.InvokeRequired Then
            menuStrip.Invoke(New DelSetToolStripMenuItemForeColor(AddressOf SetToolStripMenuItemForeColor), New Object() {menuStrip, ctrl, cor})
        Else
            ctrl.ForeColor = cor
        End If
    End Sub

    Private Delegate Sub DelSetStatusStripBackColor(statusStrip As StatusStrip, cor As Color)
    Public Sub SetStatusStripBackColor(statusStrip As StatusStrip, cor As Color)
        If statusStrip.InvokeRequired Then
            statusStrip.Invoke(New DelSetStatusStripBackColor(AddressOf SetStatusStripBackColor), New Object() {statusStrip, cor})
        Else
            statusStrip.BackColor = cor
        End If
    End Sub

    Private Delegate Sub DelSetControlImage(ctrl As PictureBox, img As Image)
    Public Sub SetControlImage(ctrl As PictureBox, img As Image)
        If ctrl.InvokeRequired Then
            ctrl.Invoke(New DelSetControlImage(AddressOf SetControlImage), New Object() {ctrl, img})
        Else
            ctrl.Image = img
        End If
    End Sub


    Private Delegate Sub DelSetControlFocus(ctrl As Control)
    Public Sub SetControlFocus(ctrl As Control)
        If ctrl.InvokeRequired Then
            ctrl.Invoke(New DelSetControlFocus(AddressOf SetControlFocus), New Object() {ctrl})
        Else
            ctrl.Focus()
        End If
    End Sub

    Private Delegate Sub setCol(ByVal c As DataGridViewColumn, ByRef dgv As DataGridView, ByRef frm As Form)
    Public Sub addColuna(ByVal c As DataGridViewColumn, ByRef dgv As DataGridView, ByRef frm As Form)

        If dgv.InvokeRequired Then
            Dim d As New setCol(AddressOf addColuna)
            frm.Invoke(d, New Object() {c, dgv, frm})
        Else
            dgv.Columns.Add(c)
        End If

    End Sub




    Private Delegate Sub DelSetNunUDValue(ctrl As NumericUpDown, value As Decimal)
    Public Sub SetNunUDValue(ctrl As NumericUpDown, value As Decimal)
        If ctrl.InvokeRequired Then
            ctrl.Invoke(New DelSetNunUDValue(AddressOf SetNunUDValue), New Object() {ctrl, value})
        Else
            ctrl.Value = value
        End If
    End Sub

    Private Delegate Sub DelSetNunUDMinimum(ctrl As NumericUpDown, value As Decimal)
    Public Sub SetNunUDMinimum(ctrl As NumericUpDown, value As Decimal)
        If ctrl.InvokeRequired Then
            ctrl.Invoke(New DelSetNunUDMinimum(AddressOf SetNunUDMinimum), New Object() {ctrl, value})
        Else
            ctrl.Minimum = value
        End If
    End Sub

    Private Delegate Sub DelSetNunUDMaximum(ctrl As NumericUpDown, value As Decimal)
    Public Sub SetNunUDMaximum(ctrl As NumericUpDown, value As Decimal)
        If ctrl.InvokeRequired Then
            ctrl.Invoke(New DelSetNunUDMaximum(AddressOf SetNunUDMaximum), New Object() {ctrl, value})
        Else
            ctrl.Maximum = value
        End If
    End Sub

    Public Function GetControlText(ctrl As Control) As String
        If ctrl.InvokeRequired Then
            Return DirectCast(ctrl.Invoke(New Func(Of String)(Function() GetControlText(ctrl))), String)
        Else
            Return ctrl.Text
        End If
    End Function

    Public Function GetCheckBoxCheck(ctrl As CheckBox) As Boolean
        If ctrl.InvokeRequired Then
            Return DirectCast(ctrl.Invoke(New Func(Of Boolean)(Function() GetCheckBoxCheck(ctrl))), Boolean)
        Else
            Return ctrl.Checked
        End If
    End Function



    Private Delegate Sub DelSetProgressBarValue(ctrl As ProgressBar, Value As Integer)
    Public Sub SetProgressBarValue(ctrl As ProgressBar, Value As Integer)
        If ctrl.InvokeRequired Then
            ctrl.Invoke(New DelSetProgressBarValue(AddressOf SetProgressBarValue), New Object() {ctrl, Value})
        Else
            ctrl.Value = Value
        End If
    End Sub

    Private Delegate Sub DelSetProgressBarMaximum(ctrl As ProgressBar, Maximum As Integer)
    Public Sub SetProgressBarMaximum(ctrl As ProgressBar, Maximum As Integer)
        If ctrl.InvokeRequired Then
            ctrl.Invoke(New DelSetProgressBarMaximum(AddressOf SetProgressBarMaximum), New Object() {ctrl, Maximum})
        Else
            ctrl.Maximum = Maximum
        End If
    End Sub

    Delegate Sub delSetRowFont(dgv As DataGridView, row As DataGridViewRow, font As Font)
    Public Sub SetRowFont(dgv As DataGridView, row As DataGridViewRow, font As Font)
        If dgv.InvokeRequired Then
            Dim d As New delSetRowFont(AddressOf SetRowFont)
            dgv.Invoke(d, New Object() {dgv, row, font})
        Else
            row.DefaultCellStyle.Font = font
        End If
    End Sub


    Public Function RemoveAcentos(ByVal texto As String) As String
        Dim textor As String = ""

        For i As Integer = 0 To texto.Length - 1
            If texto(i).ToString() = "ã" Then
                textor += "a"
            ElseIf texto(i).ToString() = "á" Then
                textor += "a"
            ElseIf texto(i).ToString() = "à" Then
                textor += "a"
            ElseIf texto(i).ToString() = "â" Then
                textor += "a"
            ElseIf texto(i).ToString() = "ä" Then
                textor += "a"
            ElseIf texto(i).ToString() = "é" Then
                textor += "e"
            ElseIf texto(i).ToString() = "è" Then
                textor += "e"
            ElseIf texto(i).ToString() = "ê" Then
                textor += "e"
            ElseIf texto(i).ToString() = "ë" Then
                textor += "e"
            ElseIf texto(i).ToString() = "í" Then
                textor += "i"
            ElseIf texto(i).ToString() = "ì" Then
                textor += "i"
            ElseIf texto(i).ToString() = "ï" Then
                textor += "i"
            ElseIf texto(i).ToString() = "õ" Then
                textor += "o"
            ElseIf texto(i).ToString() = "ô" Then
                textor += "o"
            ElseIf texto(i).ToString() = "ó" Then
                textor += "o"
            ElseIf texto(i).ToString() = "ò" Then
                textor += "o"
            ElseIf texto(i).ToString() = "ö" Then
                textor += "o"
            ElseIf texto(i).ToString() = "ú" Then
                textor += "u"
            ElseIf texto(i).ToString() = "ù" Then
                textor += "u"
            ElseIf texto(i).ToString() = "ü" Then
                textor += "u"
            ElseIf texto(i).ToString() = "ç" Then
                textor += "c"
            ElseIf texto(i).ToString() = "Ã" Then
                textor += "A"
            ElseIf texto(i).ToString() = "Á" Then
                textor += "A"
            ElseIf texto(i).ToString() = "À" Then
                textor += "A"
            ElseIf texto(i).ToString() = "Â" Then
                textor += "A"
            ElseIf texto(i).ToString() = "Ä" Then
                textor += "A"
            ElseIf texto(i).ToString() = "É" Then
                textor += "E"
            ElseIf texto(i).ToString() = "È" Then
                textor += "E"
            ElseIf texto(i).ToString() = "Ê" Then
                textor += "E"
            ElseIf texto(i).ToString() = "Ë" Then
                textor += "E"
            ElseIf texto(i).ToString() = "Í" Then
                textor += "I"
            ElseIf texto(i).ToString() = "Ì" Then
                textor += "I"
            ElseIf texto(i).ToString() = "Ï" Then
                textor += "I"
            ElseIf texto(i).ToString() = "Õ" Then
                textor += "O"
            ElseIf texto(i).ToString() = "Ô" Then
                textor += "O"
            ElseIf texto(i).ToString() = "Ó" Then
                textor += "O"
            ElseIf texto(i).ToString() = "Ò" Then
                textor += "O"
            ElseIf texto(i).ToString() = "Ö" Then
                textor += "O"
            ElseIf texto(i).ToString() = "Ú" Then
                textor += "U"
            ElseIf texto(i).ToString() = "Ù" Then
                textor += "U"
            ElseIf texto(i).ToString() = "Ü" Then
                textor += "U"
            ElseIf texto(i).ToString() = "Ç" Then
                textor += "C"
            Else
                textor += texto(i)
            End If
        Next
        Return textor
    End Function


    Public Function Obj_to_XML(obj As Object) As String
        Try
            Dim jsSerializer As New Xml.Serialization.XmlSerializer(obj.GetType)
            Dim text As TextWriter = Nothing
            jsSerializer.Serialize(text, obj)
            Return text.ToString
        Catch ex As Exception
            Throw
            Return ""
        End Try
    End Function

    Public Class csNum_Tel
        Public Property DDD As String = ""
        Public Property Numero As String = ""
    End Class



    Public Function DDD_Fone(numero As String, isCel As Boolean) As csNum_Tel

        Dim n As New csNum_Tel


        If SomenteNumeros(numero).Trim <> "" Then

            Dim num As String = SomenteNumeros(numero)

            If num.Length > 2 Then

                n.DDD = num.Substring(0, 2)
                n.Numero = num.Substring(2, num.Length - 2)

                If isCel Then
                    If n.Numero.Length < 9 Then
                        If n.Numero.StartsWith("8") Or n.Numero.StartsWith("9") Then
                            n.Numero = "9" & n.Numero
                        Else
                            n.DDD = ""
                            n.Numero = ""
                        End If
                    ElseIf n.Numero.Length > 9 Then
                        n.DDD = ""
                        n.Numero = ""
                    End If
                Else
                    If n.DDD.StartsWith("0") Or n.Numero.StartsWith("0") Then
                        n.DDD = ""
                        n.Numero = ""
                    ElseIf n.Numero.Length > 8 Then
                        n.DDD = ""
                        n.Numero = ""
                    ElseIf n.Numero.Trim = "" Then
                        n.DDD = ""
                        n.Numero = ""
                    ElseIf n.Numero.StartsWith("8") Or n.Numero.StartsWith("9") Then
                        n.DDD = ""
                        n.Numero = ""
                    End If
                End If

            End If
        Else
            n.DDD = ""
            n.Numero = ""
        End If



        Return n

    End Function

    Public Function RemoveEspacoDuplicado(value As String) As String
        Return Regex.Replace(value, "\s{2,}", " ").Trim()
    End Function


    Public Function Convert_Enter_Espaco(value As String) As String
        value = value.Replace(vbCr, " ").Replace(vbLf, " ").Replace(vbCrLf, " ")
        Return RemoveEspacoDuplicado(value)
    End Function


    Public Function IsValidJson(strInput As String) As Boolean
        strInput = strInput.Trim()
        'For object
        If (strInput.StartsWith("{") AndAlso strInput.EndsWith("}")) OrElse (strInput.StartsWith("[") AndAlso strInput.EndsWith("]")) Then
            'For array
            Try
                Dim obj = JToken.Parse(strInput)
                Return True
            Catch jex As JsonReaderException
                'Exception in parsing json
                'Console.WriteLine(jex.Message)
                Return False
            Catch ex As Exception
                'some other exception
                ' Console.WriteLine(ex.ToString())
                Return False
            End Try
        Else
            Return False
        End If
    End Function


    Public Function Remove_Caracteres_Proibido(texto As String) As String
        Return texto.Replace("\", "").Replace("/", "").Replace("?", "").Replace(":", "").Replace("*", "").Replace("""", "").Replace("<", "").Replace(">", "").Replace("|", "")
    End Function

    Public Function Convert_DBNull_to_Integer(value As Object) As Integer

        If value Is DBNull.Value Then
            Return 0
        Else
            Return value
        End If

    End Function

    Private Function InlineAssignHelper(Of T)(ByRef target As T, ByVal value As T) As T
        target = value
        Return value
    End Function

    Public Sub ReplaceInRichTextBox(rtf As RichTextBox, texto2 As String, texto1 As String, destacar As Boolean)

        Try

            Dim s_start As Integer = rtf.SelectionStart, startIndex As Integer = 0, index As Integer
            While (InlineAssignHelper(index, rtf.Text.IndexOf(texto1, startIndex))) <> -1
                rtf.[Select](index, texto1.Length)
                rtf.SelectedText = texto2
                rtf.[Select](index, texto2.Length)
                If destacar Then rtf.SelectionBackColor = Color.Yellow
                startIndex = index + texto2.Length
            End While

        Catch ex As Exception

        End Try

    End Sub

    Public Function AbreviarNome(nome As String)

        Dim nomeR As String = ""

        If nome.Trim <> "" Then

            Dim arr As String() = nome.Trim.ToUpper.Split(" ")

            Dim i As Integer = 0

            For Each s As String In arr
                If s.Trim <> "" Then
                    If i < arr.Count - 1 And i > 0 Then
                        nomeR &= s(0) & ". "
                    Else
                        nomeR &= s & " "
                    End If
                End If
                i += 1
            Next
        End If
        Return nomeR.Trim

    End Function

    Public Function Convert_DBNull_to_String(value As Object) As String

        If value Is DBNull.Value Then
            Return ""
        Else
            Return value
        End If

    End Function

    Public Function Convert_DBNull_to_Nothing(value As Object) As Object

        If value Is DBNull.Value Then
            Return Nothing
        Else
            Return value
        End If

    End Function

    Public Function Convert_Null_to_String(value As Object) As String

        If value = Nothing Then
            Return ""
        Else
            Return value
        End If

    End Function

    Public Function XML_to_Obj(Of Tp)(xml As String) As Tp
        Try
            Dim jsSerializer As New Xml.Serialization.XmlSerializer(GetType(Tp))
            Dim reader As TextReader = New StringReader(xml)
            Return jsSerializer.Deserialize(reader)
        Catch ex As Exception
            Throw
            Return Nothing
        End Try
    End Function


    Public Function IsEmail(email As String, ByVal varios As Boolean) As Boolean

        Dim ret As Boolean = True
        Dim strRegex As String = "^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" + "\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + ".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"
        Dim re As New Regex(strRegex)

        If varios Then

            Dim arr As String() = email.Split(";")

            If arr.Count > 0 Then
                For Each s As String In arr
                    If s.Trim <> "" Then
                        If Not (re.IsMatch(s)) Then
                            ret = False
                        End If
                    End If
                Next
            Else
                If email.Trim <> "" Then
                    If Not (re.IsMatch(email)) Then
                        ret = False
                    End If
                End If
            End If

        Else
            If email.Trim <> "" Then
                If Not (re.IsMatch(email)) Then
                    ret = False
                End If
            End If
        End If

        Return ret

    End Function

    Public Function SomenteNumeros(value As String) As String

        Dim valor As String = ""

        Try

            For Each s As Char In value
                If IsNumeric(s) Then
                    valor &= s
                End If
            Next

            Return valor

        Catch ex As Exception
            Return ""
        End Try

    End Function

    Public Function ColocaZeroEsquerda(valor As String, qtddigitos As Integer) As String

        Try

            While valor.Length < qtddigitos
                valor = "0" & valor
            End While

            Return valor
        Catch ex As Exception
            Return ""
        End Try
    End Function


    Public Function GetControlByName(ByVal Name As String, ByVal CurrentForm As Form) As Control
        Dim info As System.Reflection.FieldInfo = CurrentForm.GetType().GetField("_" & Name, System.Reflection.BindingFlags.NonPublic Or
                System.Reflection.BindingFlags.Instance Or
                System.Reflection.BindingFlags.Public Or
                System.Reflection.BindingFlags.IgnoreCase)
        If info Is Nothing Then
            Return Nothing
        Else
            Return CType(info.GetValue(CurrentForm), Control)
        End If
    End Function


    Public Function LimitCaracter(texto As String, limit As Integer) As String
        Dim s As String = texto
        If texto.Length > limit Then
            s = s.Substring(0, limit)
        End If
        Return s
    End Function

    Public Function Idade(ByRef data As Date, Optional DataRef As Date = Nothing) As Integer

        Try

            Dim vData As Date = Nothing

            If DataRef = Nothing Then
                vData = Date.Now
            Else
                vData = DataRef
            End If

            Dim birthdate As Date = data.Date
            Dim years As Integer = vData.Year - birthdate.Year
            If vData.Month < birthdate.Month Or (vData.Month = birthdate.Month And vData.Day < birthdate.Day) Then
                years = years - 1
            End If

            Return years

        Catch x As Exception
            Return 0
        End Try

    End Function


    Public Sub ProximoSemestre(ByVal semestre As String, ByVal ano As String, ByVal qtd As Integer, ByRef semestreS As String, ByRef anoS As String)

        semestreS = semestre
        anoS = ano

        For i As Integer = 1 To qtd

            If semestre = "" Then
                anoS = anoS + 1
            Else
                If semestreS = "1º SEMESTRE" Then
                    semestreS = "2º SEMESTRE"
                ElseIf semestreS = "2º SEMESTRE" Then
                    semestreS = "1º SEMESTRE"
                    anoS = anoS + 1
                End If
            End If

        Next

    End Sub


    Public Sub SemestreAnterior(ByVal semestre As String, ByVal ano As String, ByVal qtd As Integer, ByRef semestreS As String, ByRef anoS As String)

        semestreS = semestre
        anoS = ano

        For i As Integer = 1 To qtd

            If semestre = "" Then
                anoS = anoS - 1
            Else
                If semestreS = "2º SEMESTRE" Then
                    semestreS = "1º SEMESTRE"
                ElseIf semestreS = "1º SEMESTRE" Then
                    semestreS = "2º SEMESTRE"
                    anoS = anoS - 1
                End If
            End If

        Next

    End Sub


    Public Function GetExtensao(s As String) As String

        Try

            Dim arr As String() = s.Split(".")
            Return arr(arr.Length - 1)

        Catch ex As Exception
            Return ""
        End Try

    End Function

    Public Function GetNomeArquivo(s As String, Optional ByVal sem_ext As Boolean = False) As String

        Try

            Dim arr As String() = s.Split("\")
            Dim file As String = arr(arr.Length - 1)

            If sem_ext Then
                Dim ext As String = GetExtensao(file)
                file = file.Replace("." & ext, "")
            End If

            Return file

        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function ByteArrayToBitmap(ByVal value As Byte()) As Bitmap
        Dim memorybits As New MemoryStream(value)
        Dim bitmap As New Bitmap(memorybits)
        Return bitmap
    End Function

    Public Function ByteArrayToBitmap(ByVal value As Byte(), ByVal Width As Integer, ByVal Heigth As Integer) As Bitmap
        Dim bitmap As Bitmap = ByteArrayToBitmap(value)
        Dim bitmap2 As New Bitmap(bitmap, Width, Heigth)
        Return bitmap2
    End Function

    Public Function BitmapToByteArray(ByVal value As Bitmap) As Byte()
        Dim bitmapBytes As Byte()
        Using stream As New System.IO.MemoryStream
            value.Save(stream, ImageFormat.Jpeg)
            bitmapBytes = stream.ToArray
        End Using
        Return bitmapBytes
    End Function


    Public Sub CloneDGV(dgvOriginal As DataGridView, dgvClone As DataGridView)

        dgvClone.Columns.Clear()

        For Each c As DataGridViewColumn In dgvOriginal.Columns

            Dim col As DataGridViewColumn = c.Clone
            dgvClone.Columns.Add(col)
        Next

    End Sub

    Public Function GetLogradouro(str As String) As String

        Try

            Dim arr As String() = str.Split(",")

            If arr.Length > 1 Then
                Return arr(0).Trim
            Else
                Return ""
            End If

        Catch ex As Exception
            Return ""
        End Try

    End Function

    Public Function GetNumeroLogradouro(str As String) As String

        Try

            Dim arr As String() = str.Split(",")

            If arr.Length > 1 Then
                Return arr(arr.Length - 1).Trim
            Else
                Return ""
            End If

        Catch ex As Exception
            Return ""
        End Try

    End Function

    Public Function GetCidade(str As String) As String

        Try

            Dim arr As String() = str.Split("-")

            If arr.Length > 1 Then

                Dim ret As String = ""

                For i As Integer = 0 To arr.Length - 2
                    ret &= arr(i) & "-"
                Next
                Return ret.Remove(ret.Length - 1, 1).Trim
            Else
                Return ""
            End If

        Catch ex As Exception
            Return ""
        End Try

    End Function

    Public Function ValidaEstado(uf As String) As String

        Dim ufs As String() = New String() {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RR", "RO", "RJ", "RN", "RS", "SC", "SP", "SE", "TO"}

        If ufs.Contains(uf) Then
            Return uf
        Else
            Return "SP"
        End If

    End Function


    Public Function GetEstado(str As String) As String

        Try

            Dim arr As String() = str.Split("-")

            If arr.Length > 1 Then
                Return arr(arr.Length - 1).Trim
            Else
                Return ""
            End If

        Catch ex As Exception
            Return ""
        End Try

    End Function

    Public Function GetRG(str As String) As String

        Try

            Dim arr As String() = str.Split("/")

            If arr.Length > 1 Then
                Return arr(0).Trim
            Else
                Return ""
            End If

        Catch ex As Exception
            Return ""
        End Try

    End Function

    Public Function GetEstadoRG(str As String) As String

        Try

            Dim arr As String() = str.Split("/")

            If arr.Length > 1 Then
                Return arr(arr.Length - 1).Trim
            Else
                Return ""
            End If

        Catch ex As Exception
            Return ""
        End Try

    End Function

    Public Function get_Nome_Arquivo_Caminho(caminho As String)

        Dim retorno As String = ""

        Dim arr As String() = caminho.Split("\")

        retorno = arr(arr.Length - 1)

        Return retorno

    End Function
End Module
