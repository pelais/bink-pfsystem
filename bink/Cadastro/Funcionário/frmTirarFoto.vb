Imports System.Runtime.InteropServices
Public Class frmTirarFoto

    Public fotografia As Integer = 0

    Const WM_CAP As Short = &H400S
    Const WM_CAP_DRIVER_CONNECT As Integer = WM_CAP + 10
    Const WM_CAP_DRIVER_DISCONNECT As Integer = WM_CAP + 11
    Const WM_CAP_EDIT_COPY As Integer = WM_CAP + 30
    Const WM_CAP_SET_PREVIEW As Integer = WM_CAP + 50
    Const WM_CAP_SET_PREVIEWRATE As Integer = WM_CAP + 52
    Const WM_CAP_SET_SCALE As Integer = WM_CAP + 53
    Const WS_CHILD As Integer = &H40000000
    Const WS_VISIBLE As Integer = &H10000000
    Const SWP_NOMOVE As Short = &H2S
    Const SWP_NOSIZE As Short = 1
    Const SWP_NOZORDER As Short = &H4S
    Const HWND_BOTTOM As Short = 1
    Dim iDevice As Integer = 0
    Dim hHwnd As Integer


    Declare Function SendMessage Lib "user32" Alias "SendMessageA" _
         (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer,
    <MarshalAs(UnmanagedType.AsAny)> ByVal lParam As Object) As Integer
    Declare Function SetWindowPos Lib "user32" Alias "SetWindowPos" (ByVal hwnd As Integer,
        ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer,
        ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer

    Declare Function DestroyWindow Lib "user32" (ByVal hndw As Integer) As Boolean


    Declare Function capCreateCaptureWindowA Lib "avicap32.dll" _
        (ByVal lpszWindowName As String, ByVal dwStyle As Integer,
        ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer,
        ByVal nHeight As Short, ByVal hWndParent As Integer,
        ByVal nID As Integer) As Integer

    Declare Function capGetDriverDescriptionA Lib "avicap32.dll" (ByVal wDriver As Short,
        ByVal lpszName As String, ByVal cbName As Integer, ByVal lpszVer As String,
        ByVal cbVer As Integer) As Boolean

    Private Sub FrmTirarFoto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnIniciar.Enabled = False

        picCaptura2.Image = My.Resources.Resources.SemRosto2

        carregaDispositivos()

        If lstDispositivos.Items.Count > 0 Then
            lstDispositivos.SelectedIndex = 0

        Else
            lstDispositivos.Items.Add("Dispositivo de captura não instalado.")
            picCaptura.SizeMode = PictureBoxSizeMode.StretchImage

        End If

        abreJanelaVisualizacao()

        btnSalvar.Enabled = False
    End Sub

    Private Sub BtnTirarFoto_Click(sender As Object, e As EventArgs) Handles btnTirarFoto.Click
        btnIniciar.Enabled = True

        btnTirarFoto.Enabled = False

        Dim dados As IDataObject
        Dim bmap As Image

        SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0)

        dados = Clipboard.GetDataObject()
        If dados.GetDataPresent(GetType(System.Drawing.Bitmap)) Then

            bmap = CType(dados.GetData(GetType(System.Drawing.Bitmap)), Image)
            picCaptura2.Image = bmap
            fechaJanelaVisualizacao()

            btnTirarFoto.Enabled = False
            btnSalvar.Enabled = True

            GravaLog(Me.Text, "Foto", "O Usuário tirou a foto com sucesso")

        End If
    End Sub

    Private Sub fechaJanelaVisualizacao()
        SendMessage(hHwnd, WM_CAP_DRIVER_DISCONNECT, iDevice, 0)
        DestroyWindow(hHwnd)
    End Sub

    Private Sub carregaDispositivos()
        Dim strNome As String = Space(100)
        Dim strVer As String = Space(100)
        Dim bRetorna As Boolean
        Dim x As Integer = 0
        Do
            bRetorna = capGetDriverDescriptionA(x, strNome, 100, strVer, 100)
            If bRetorna Then lstDispositivos.Items.Add(strNome.Trim)
            x += 1
        Loop Until bRetorna = False
    End Sub

    Private Sub abreJanelaVisualizacao()

        Dim iHeight As Integer = picCaptura.Height
        Dim iWidth As Integer = picCaptura.Width

        hHwnd = capCreateCaptureWindowA(iDevice, WS_VISIBLE Or WS_CHILD, 1, 1, 640, 480, picCaptura.Handle.ToInt32, 0)

        If SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, iDevice, 0) Then
            SendMessage(hHwnd, WM_CAP_SET_SCALE, True, 0)
            SendMessage(hHwnd, WM_CAP_SET_PREVIEWRATE, 66, 0)
            SendMessage(hHwnd, WM_CAP_SET_PREVIEW, True, 0)
            SetWindowPos(hHwnd, HWND_BOTTOM, 0, 0, picCaptura.Width, picCaptura.Height, SWP_NOMOVE Or SWP_NOZORDER)

            btnTirarFoto.Enabled = True
            ' btnIniciar.Enabled = False
        Else
            DestroyWindow(hHwnd)
            btnTirarFoto.Enabled = False
            Me.Close()
        End If
    End Sub

    Private Sub BtnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        btnIniciar.Enabled = False

        picCaptura2.Image = Nothing

        carregaDispositivos()

        If lstDispositivos.Items.Count > 0 Then
            lstDispositivos.SelectedIndex = 0

        Else
            lstDispositivos.Items.Add("Dispositivo de captura não instalado.")
            picCaptura.SizeMode = PictureBoxSizeMode.StretchImage

        End If

        abreJanelaVisualizacao()

        btnSalvar.Enabled = False
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim dados As IDataObject
        Dim bmap As Image

        SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0)
        dados = Clipboard.GetDataObject()

        If dados.GetDataPresent(GetType(System.Drawing.Bitmap)) Then

            bmap = CType(dados.GetData(GetType(System.Drawing.Bitmap)), Image)

            btnTirarFoto.Enabled = False

            Me.Close()

        End If
    End Sub
End Class