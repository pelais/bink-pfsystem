<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class frmUsuario
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Component Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.mainRibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiSaveAndClose = New DevExpress.XtraBars.BarButtonItem()
        Me.btnIncluir = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExcluir = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSair = New DevExpress.XtraBars.BarButtonItem()
        Me.rpInicio = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.mainRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.checkAtivo = New System.Windows.Forms.CheckBox()
        Me.btnTelaCadPerfil = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtN = New System.Windows.Forms.TextBox()
        Me.TxTLogin = New System.Windows.Forms.TextBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.txtsenha = New System.Windows.Forms.TextBox()
        Me.lblSenha = New System.Windows.Forms.Label()
        Me.TxTcontrasenha = New System.Windows.Forms.TextBox()
        Me.cbonivelusuario = New System.Windows.Forms.ComboBox()
        Me.lblRSenha = New System.Windows.Forms.Label()
        Me.lblNivelUsuario = New System.Windows.Forms.Label()
        Me.DGVConsUsuario = New System.Windows.Forms.DataGridView()
        Me.ColIdUsu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltipousuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcheck = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.bgwCarregaUsu = New System.ComponentModel.BackgroundWorker()
        Me.bgwPerfil = New System.ComponentModel.BackgroundWorker()
        CType(Me.mainRibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVConsUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainRibbonControl
        '
        Me.mainRibbonControl.ExpandCollapseItem.Id = 0
        Me.mainRibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.mainRibbonControl.ExpandCollapseItem, Me.btnSalvar, Me.bbiSaveAndClose, Me.btnIncluir, Me.btnExcluir, Me.btnSair})
        Me.mainRibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.mainRibbonControl.MaxItemId = 5
        Me.mainRibbonControl.Name = "mainRibbonControl"
        Me.mainRibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rpInicio})
        Me.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.mainRibbonControl.Size = New System.Drawing.Size(500, 143)
        Me.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnSalvar
        '
        Me.btnSalvar.Caption = "Salvar / Alterar"
        Me.btnSalvar.Id = 2
        Me.btnSalvar.ImageOptions.LargeImage = Global.bink.My.Resources.Resources.salvar
        Me.btnSalvar.Name = "btnSalvar"
        '
        'bbiSaveAndClose
        '
        Me.bbiSaveAndClose.Caption = "Save And Close"
        Me.bbiSaveAndClose.Id = 3
        Me.bbiSaveAndClose.ImageOptions.ImageUri.Uri = "SaveAndClose"
        Me.bbiSaveAndClose.Name = "bbiSaveAndClose"
        '
        'btnIncluir
        '
        Me.btnIncluir.Caption = "Incluir"
        Me.btnIncluir.Id = 5
        Me.btnIncluir.ImageOptions.LargeImage = Global.bink.My.Resources.Resources.incluir
        Me.btnIncluir.Name = "btnIncluir"
        '
        'btnExcluir
        '
        Me.btnExcluir.Caption = "Excluir"
        Me.btnExcluir.Id = 6
        Me.btnExcluir.ImageOptions.LargeImage = Global.bink.My.Resources.Resources.deletar
        Me.btnExcluir.Name = "btnExcluir"
        '
        'btnSair
        '
        Me.btnSair.Caption = "Sair"
        Me.btnSair.Id = 7
        Me.btnSair.ImageOptions.LargeImage = Global.bink.My.Resources.Resources.sair
        Me.btnSair.Name = "btnSair"
        '
        'rpInicio
        '
        Me.rpInicio.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.mainRibbonPageGroup})
        Me.rpInicio.MergeOrder = 0
        Me.rpInicio.Name = "rpInicio"
        Me.rpInicio.Text = "Usuário"
        '
        'mainRibbonPageGroup
        '
        Me.mainRibbonPageGroup.AllowTextClipping = False
        Me.mainRibbonPageGroup.ItemLinks.Add(Me.btnIncluir)
        Me.mainRibbonPageGroup.ItemLinks.Add(Me.btnSalvar)
        Me.mainRibbonPageGroup.ItemLinks.Add(Me.btnExcluir)
        Me.mainRibbonPageGroup.ItemLinks.Add(Me.btnSair)
        Me.mainRibbonPageGroup.Name = "mainRibbonPageGroup"
        Me.mainRibbonPageGroup.ShowCaptionButton = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.checkAtivo)
        Me.GroupBox1.Controls.Add(Me.btnTelaCadPerfil)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtN)
        Me.GroupBox1.Controls.Add(Me.TxTLogin)
        Me.GroupBox1.Controls.Add(Me.lblUsuario)
        Me.GroupBox1.Controls.Add(Me.txtsenha)
        Me.GroupBox1.Controls.Add(Me.lblSenha)
        Me.GroupBox1.Controls.Add(Me.TxTcontrasenha)
        Me.GroupBox1.Controls.Add(Me.cbonivelusuario)
        Me.GroupBox1.Controls.Add(Me.lblRSenha)
        Me.GroupBox1.Controls.Add(Me.lblNivelUsuario)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 149)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(500, 164)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados de usuário"
        '
        'checkAtivo
        '
        Me.checkAtivo.AutoSize = True
        Me.checkAtivo.Checked = True
        Me.checkAtivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkAtivo.Location = New System.Drawing.Point(307, 23)
        Me.checkAtivo.Name = "checkAtivo"
        Me.checkAtivo.Size = New System.Drawing.Size(89, 17)
        Me.checkAtivo.TabIndex = 142
        Me.checkAtivo.Text = "Ativo/Inativo"
        Me.checkAtivo.UseVisualStyleBackColor = True
        '
        'btnTelaCadPerfil
        '
        Me.btnTelaCadPerfil.BackColor = System.Drawing.Color.White
        Me.btnTelaCadPerfil.Image = Global.bink.My.Resources.Resources.lupa
        Me.btnTelaCadPerfil.Location = New System.Drawing.Point(307, 75)
        Me.btnTelaCadPerfil.Name = "btnTelaCadPerfil"
        Me.btnTelaCadPerfil.Size = New System.Drawing.Size(26, 21)
        Me.btnTelaCadPerfil.TabIndex = 141
        Me.btnTelaCadPerfil.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(62, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 14)
        Me.Label1.TabIndex = 136
        Me.Label1.Tag = ""
        Me.Label1.Text = "Nome:"
        '
        'txtN
        '
        Me.txtN.Location = New System.Drawing.Point(101, 21)
        Me.txtN.MaxLength = 30
        Me.txtN.Name = "txtN"
        Me.txtN.Size = New System.Drawing.Size(200, 21)
        Me.txtN.TabIndex = 1
        '
        'TxTLogin
        '
        Me.TxTLogin.Location = New System.Drawing.Point(101, 48)
        Me.TxTLogin.MaxLength = 50
        Me.TxTLogin.Name = "TxTLogin"
        Me.TxTLogin.Size = New System.Drawing.Size(200, 21)
        Me.TxTLogin.TabIndex = 2
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblUsuario.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.Color.Black
        Me.lblUsuario.Location = New System.Drawing.Point(52, 51)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(47, 14)
        Me.lblUsuario.TabIndex = 137
        Me.lblUsuario.Tag = ""
        Me.lblUsuario.Text = "Usuário:"
        '
        'txtsenha
        '
        Me.txtsenha.Location = New System.Drawing.Point(101, 102)
        Me.txtsenha.MaxLength = 50
        Me.txtsenha.Name = "txtsenha"
        Me.txtsenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtsenha.Size = New System.Drawing.Size(200, 21)
        Me.txtsenha.TabIndex = 4
        Me.txtsenha.UseSystemPasswordChar = True
        '
        'lblSenha
        '
        Me.lblSenha.AutoSize = True
        Me.lblSenha.BackColor = System.Drawing.Color.Transparent
        Me.lblSenha.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSenha.ForeColor = System.Drawing.Color.Black
        Me.lblSenha.Location = New System.Drawing.Point(58, 105)
        Me.lblSenha.Name = "lblSenha"
        Me.lblSenha.Size = New System.Drawing.Size(41, 14)
        Me.lblSenha.TabIndex = 138
        Me.lblSenha.Tag = ""
        Me.lblSenha.Text = "Senha:"
        '
        'TxTcontrasenha
        '
        Me.TxTcontrasenha.Location = New System.Drawing.Point(101, 129)
        Me.TxTcontrasenha.MaxLength = 50
        Me.TxTcontrasenha.Name = "TxTcontrasenha"
        Me.TxTcontrasenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxTcontrasenha.Size = New System.Drawing.Size(200, 21)
        Me.TxTcontrasenha.TabIndex = 5
        Me.TxTcontrasenha.UseSystemPasswordChar = True
        '
        'cbonivelusuario
        '
        Me.cbonivelusuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbonivelusuario.FormattingEnabled = True
        Me.cbonivelusuario.Location = New System.Drawing.Point(101, 75)
        Me.cbonivelusuario.Name = "cbonivelusuario"
        Me.cbonivelusuario.Size = New System.Drawing.Size(200, 21)
        Me.cbonivelusuario.TabIndex = 3
        '
        'lblRSenha
        '
        Me.lblRSenha.AutoSize = True
        Me.lblRSenha.BackColor = System.Drawing.Color.Transparent
        Me.lblRSenha.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRSenha.ForeColor = System.Drawing.Color.Black
        Me.lblRSenha.Location = New System.Drawing.Point(17, 132)
        Me.lblRSenha.Name = "lblRSenha"
        Me.lblRSenha.Size = New System.Drawing.Size(82, 14)
        Me.lblRSenha.TabIndex = 139
        Me.lblRSenha.Tag = ""
        Me.lblRSenha.Text = "Repita a senha:"
        '
        'lblNivelUsuario
        '
        Me.lblNivelUsuario.AutoSize = True
        Me.lblNivelUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblNivelUsuario.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNivelUsuario.ForeColor = System.Drawing.Color.Black
        Me.lblNivelUsuario.Location = New System.Drawing.Point(65, 79)
        Me.lblNivelUsuario.Name = "lblNivelUsuario"
        Me.lblNivelUsuario.Size = New System.Drawing.Size(34, 14)
        Me.lblNivelUsuario.TabIndex = 140
        Me.lblNivelUsuario.Tag = ""
        Me.lblNivelUsuario.Text = "Perfil:"
        '
        'DGVConsUsuario
        '
        Me.DGVConsUsuario.AllowUserToAddRows = False
        Me.DGVConsUsuario.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DGVConsUsuario.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVConsUsuario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVConsUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVConsUsuario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVConsUsuario.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.DGVConsUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVConsUsuario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColIdUsu, Me.colNom, Me.ColUsuario, Me.coltipousuario, Me.colcheck})
        Me.DGVConsUsuario.EnableHeadersVisualStyles = False
        Me.DGVConsUsuario.Location = New System.Drawing.Point(0, 319)
        Me.DGVConsUsuario.MultiSelect = False
        Me.DGVConsUsuario.Name = "DGVConsUsuario"
        Me.DGVConsUsuario.ReadOnly = True
        Me.DGVConsUsuario.RowHeadersVisible = False
        Me.DGVConsUsuario.RowHeadersWidth = 30
        Me.DGVConsUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVConsUsuario.Size = New System.Drawing.Size(500, 161)
        Me.DGVConsUsuario.TabIndex = 125
        '
        'ColIdUsu
        '
        Me.ColIdUsu.FillWeight = 150.0!
        Me.ColIdUsu.HeaderText = "id"
        Me.ColIdUsu.Name = "ColIdUsu"
        Me.ColIdUsu.ReadOnly = True
        Me.ColIdUsu.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColIdUsu.Visible = False
        Me.ColIdUsu.Width = 21
        '
        'colNom
        '
        Me.colNom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colNom.FillWeight = 300.0!
        Me.colNom.HeaderText = "Nome"
        Me.colNom.Name = "colNom"
        Me.colNom.ReadOnly = True
        '
        'ColUsuario
        '
        Me.ColUsuario.FillWeight = 150.0!
        Me.ColUsuario.HeaderText = "Usuário"
        Me.ColUsuario.Name = "ColUsuario"
        Me.ColUsuario.ReadOnly = True
        Me.ColUsuario.Width = 68
        '
        'coltipousuario
        '
        Me.coltipousuario.HeaderText = "Perfil"
        Me.coltipousuario.Name = "coltipousuario"
        Me.coltipousuario.ReadOnly = True
        Me.coltipousuario.Width = 56
        '
        'colcheck
        '
        Me.colcheck.HeaderText = "Ativo"
        Me.colcheck.Name = "colcheck"
        Me.colcheck.ReadOnly = True
        Me.colcheck.Width = 38
        '
        'bgwCarregaUsu
        '
        '
        'frmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(500, 480)
        Me.Controls.Add(Me.DGVConsUsuario)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.mainRibbonControl)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUsuario"
        Me.Ribbon = Me.mainRibbonControl
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de usuário"
        CType(Me.mainRibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGVConsUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private WithEvents mainRibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents rpInicio As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents mainRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiSaveAndClose As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnIncluir As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnExcluir As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnSair As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtN As TextBox
    Friend WithEvents TxTLogin As TextBox
    Friend WithEvents lblUsuario As Label
    Friend WithEvents txtsenha As TextBox
    Friend WithEvents lblSenha As Label
    Friend WithEvents TxTcontrasenha As TextBox
    Friend WithEvents cbonivelusuario As ComboBox
    Friend WithEvents lblRSenha As Label
    Friend WithEvents lblNivelUsuario As Label
    Friend WithEvents DGVConsUsuario As DataGridView
    Friend WithEvents btnTelaCadPerfil As Button
    Friend WithEvents bgwCarregaUsu As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgwPerfil As System.ComponentModel.BackgroundWorker
    Friend WithEvents checkAtivo As CheckBox
    Friend WithEvents ColIdUsu As DataGridViewTextBoxColumn
    Friend WithEvents colNom As DataGridViewTextBoxColumn
    Friend WithEvents ColUsuario As DataGridViewTextBoxColumn
    Friend WithEvents coltipousuario As DataGridViewTextBoxColumn
    Friend WithEvents colcheck As DataGridViewCheckBoxColumn
End Class
