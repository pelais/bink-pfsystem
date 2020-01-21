Imports System.Runtime.InteropServices

Public Class JanelaExterna
    Dim lblTitle As Label
    Dim frm As Form

    Private Sub frm_Activated(sender As Object, e As EventArgs)
        sender.BackColor = Color.WhiteSmoke 'System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        If lblTitle IsNot Nothing Then
            lblTitle.ForeColor = Color.DimGray 'System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        End If
    End Sub

    Private Sub frm_Deactivate(sender As Object, e As EventArgs)
        sender.BackColor = System.Drawing.Color.Gainsboro
        If lblTitle IsNot Nothing Then
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        End If
    End Sub

    Public Sub New(ByRef frm As Form, ByRef lblTitle As Label)

        Me.frm = frm
        Me.lblTitle = lblTitle
        frm.StartPosition = FormStartPosition.CenterScreen

        lblTitle.Font = New Font("Segoe UI", 12, GraphicsUnit.Point)

        AddHandler lblTitle.MouseDown, AddressOf lbl_MouseDown
        AddHandler frm.Activated, AddressOf frm_Activated
        AddHandler frm.Deactivate, AddressOf frm_Deactivate

    End Sub

    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    <DllImportAttribute("user32.dll")> _
    Public Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function
    <DllImportAttribute("user32.dll")> _
    Public Shared Function ReleaseCapture() As Boolean
    End Function

    Private Sub lbl_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(frm.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub
End Class
