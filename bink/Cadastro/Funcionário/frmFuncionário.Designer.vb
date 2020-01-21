<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFuncionario
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.mainRibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiSaveAndClose = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLimpar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExcluir = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSair = New DevExpress.XtraBars.BarButtonItem()
        Me.rpInicio = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.mainRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.gbFots = New System.Windows.Forms.GroupBox()
        Me.PicFoto = New System.Windows.Forms.PictureBox()
        Me.btnProcurar = New System.Windows.Forms.Button()
        Me.btnTirarFoto = New System.Windows.Forms.Button()
        Me.TxTEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.txtUF = New System.Windows.Forms.ComboBox()
        Me.lblUF = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtNumero = New System.Windows.Forms.TextBox()
        Me.txtcomplemento = New System.Windows.Forms.TextBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblEndereco = New System.Windows.Forms.Label()
        Me.TxTCep = New System.Windows.Forms.TextBox()
        Me.RicTxTObservacoes = New System.Windows.Forms.RichTextBox()
        Me.lblCep = New System.Windows.Forms.Label()
        Me.lblCidade = New System.Windows.Forms.Label()
        Me.lblObservacao = New System.Windows.Forms.Label()
        Me.TxTTelefone = New System.Windows.Forms.TextBox()
        Me.TxTEmail = New System.Windows.Forms.TextBox()
        Me.lblTelefone = New System.Windows.Forms.Label()
        Me.TxTCelular = New System.Windows.Forms.TextBox()
        Me.lblBairro = New System.Windows.Forms.Label()
        Me.TxTRG = New System.Windows.Forms.TextBox()
        Me.lblCpf = New System.Windows.Forms.Label()
        Me.TxTCidade = New System.Windows.Forms.TextBox()
        Me.lblCelular = New System.Windows.Forms.Label()
        Me.lblEstadocivil = New System.Windows.Forms.Label()
        Me.lblRG = New System.Windows.Forms.Label()
        Me.TxTCpf = New System.Windows.Forms.TextBox()
        Me.TxTEndereco = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.TxTBairro = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DgvFuncionario = New System.Windows.Forms.DataGridView()
        Me.colidusuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colnome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colendereco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colnumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcomplemento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colbairro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcpf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltelefone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colemail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coluf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colestadocivil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcelular = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colrg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colobservacoes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bgwCarregaFuncionario = New System.ComponentModel.BackgroundWorker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.mainRibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.gbFots.SuspendLayout()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DgvFuncionario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainRibbonControl
        '
        Me.mainRibbonControl.ExpandCollapseItem.Id = 0
        Me.mainRibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.mainRibbonControl.ExpandCollapseItem, Me.btnSalvar, Me.bbiSaveAndClose, Me.btnLimpar, Me.btnExcluir, Me.btnSair})
        Me.mainRibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.mainRibbonControl.MaxItemId = 5
        Me.mainRibbonControl.Name = "mainRibbonControl"
        Me.mainRibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rpInicio})
        Me.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.mainRibbonControl.Size = New System.Drawing.Size(1051, 116)
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
        'btnLimpar
        '
        Me.btnLimpar.Caption = "Incluir"
        Me.btnLimpar.Id = 5
        Me.btnLimpar.ImageOptions.LargeImage = Global.bink.My.Resources.Resources.incluir
        Me.btnLimpar.Name = "btnLimpar"
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
        Me.mainRibbonPageGroup.ItemLinks.Add(Me.btnLimpar)
        Me.mainRibbonPageGroup.ItemLinks.Add(Me.btnSalvar)
        Me.mainRibbonPageGroup.ItemLinks.Add(Me.btnExcluir)
        Me.mainRibbonPageGroup.ItemLinks.Add(Me.btnSair)
        Me.mainRibbonPageGroup.Name = "mainRibbonPageGroup"
        Me.mainRibbonPageGroup.ShowCaptionButton = False
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 116)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainerControl1.Panel1.Padding = New System.Windows.Forms.Padding(3)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainerControl1.Panel2.Padding = New System.Windows.Forms.Padding(3)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1051, 384)
        Me.SplitContainerControl1.SplitterPosition = 245
        Me.SplitContainerControl1.TabIndex = 311
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtNome)
        Me.Panel1.Controls.Add(Me.gbFots)
        Me.Panel1.Controls.Add(Me.btnProcurar)
        Me.Panel1.Controls.Add(Me.btnTirarFoto)
        Me.Panel1.Controls.Add(Me.TxTEstadoCivil)
        Me.Panel1.Controls.Add(Me.txtUF)
        Me.Panel1.Controls.Add(Me.lblUF)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.TxtNumero)
        Me.Panel1.Controls.Add(Me.txtcomplemento)
        Me.Panel1.Controls.Add(Me.lblNome)
        Me.Panel1.Controls.Add(Me.lblEndereco)
        Me.Panel1.Controls.Add(Me.TxTCep)
        Me.Panel1.Controls.Add(Me.RicTxTObservacoes)
        Me.Panel1.Controls.Add(Me.lblCep)
        Me.Panel1.Controls.Add(Me.lblCidade)
        Me.Panel1.Controls.Add(Me.lblObservacao)
        Me.Panel1.Controls.Add(Me.TxTTelefone)
        Me.Panel1.Controls.Add(Me.TxTEmail)
        Me.Panel1.Controls.Add(Me.lblTelefone)
        Me.Panel1.Controls.Add(Me.TxTCelular)
        Me.Panel1.Controls.Add(Me.lblBairro)
        Me.Panel1.Controls.Add(Me.TxTRG)
        Me.Panel1.Controls.Add(Me.lblCpf)
        Me.Panel1.Controls.Add(Me.TxTCidade)
        Me.Panel1.Controls.Add(Me.lblCelular)
        Me.Panel1.Controls.Add(Me.lblEstadocivil)
        Me.Panel1.Controls.Add(Me.lblRG)
        Me.Panel1.Controls.Add(Me.TxTCpf)
        Me.Panel1.Controls.Add(Me.TxTEndereco)
        Me.Panel1.Controls.Add(Me.lblEmail)
        Me.Panel1.Controls.Add(Me.TxTBairro)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1045, 239)
        Me.Panel1.TabIndex = 0
        '
        'txtNome
        '
        Me.txtNome.CausesValidation = False
        Me.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNome.ForeColor = System.Drawing.Color.Black
        Me.txtNome.Location = New System.Drawing.Point(85, 7)
        Me.txtNome.MaxLength = 100
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(294, 21)
        Me.txtNome.TabIndex = 1
        '
        'gbFots
        '
        Me.gbFots.Controls.Add(Me.PicFoto)
        Me.gbFots.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFots.ForeColor = System.Drawing.Color.Red
        Me.gbFots.Location = New System.Drawing.Point(619, 15)
        Me.gbFots.Name = "gbFots"
        Me.gbFots.Size = New System.Drawing.Size(114, 124)
        Me.gbFots.TabIndex = 306
        Me.gbFots.TabStop = False
        '
        'PicFoto
        '
        Me.PicFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicFoto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicFoto.ErrorImage = Nothing
        Me.PicFoto.Location = New System.Drawing.Point(3, 22)
        Me.PicFoto.Name = "PicFoto"
        Me.PicFoto.Size = New System.Drawing.Size(108, 99)
        Me.PicFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicFoto.TabIndex = 0
        Me.PicFoto.TabStop = False
        '
        'btnProcurar
        '
        Me.btnProcurar.BackColor = System.Drawing.Color.White
        Me.btnProcurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProcurar.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcurar.ForeColor = System.Drawing.Color.Black
        Me.btnProcurar.Image = Global.bink.My.Resources.Resources.lupa
        Me.btnProcurar.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnProcurar.Location = New System.Drawing.Point(677, 144)
        Me.btnProcurar.Name = "btnProcurar"
        Me.btnProcurar.Size = New System.Drawing.Size(62, 22)
        Me.btnProcurar.TabIndex = 17
        Me.btnProcurar.Text = "Procurar"
        Me.btnProcurar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProcurar.UseVisualStyleBackColor = False
        '
        'btnTirarFoto
        '
        Me.btnTirarFoto.BackColor = System.Drawing.Color.White
        Me.btnTirarFoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTirarFoto.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTirarFoto.ForeColor = System.Drawing.Color.Black
        Me.btnTirarFoto.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnTirarFoto.Location = New System.Drawing.Point(609, 144)
        Me.btnTirarFoto.Name = "btnTirarFoto"
        Me.btnTirarFoto.Size = New System.Drawing.Size(62, 22)
        Me.btnTirarFoto.TabIndex = 16
        Me.btnTirarFoto.Text = "Tirar Foto"
        Me.btnTirarFoto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTirarFoto.UseVisualStyleBackColor = False
        '
        'TxTEstadoCivil
        '
        Me.TxTEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TxTEstadoCivil.ForeColor = System.Drawing.Color.Black
        Me.TxTEstadoCivil.FormattingEnabled = True
        Me.TxTEstadoCivil.ItemHeight = 13
        Me.TxTEstadoCivil.Items.AddRange(New Object() {"SOLTEIRO", "CASADO", "DIVORCIADO", "VIÚVO", "SEPARADO"})
        Me.TxTEstadoCivil.Location = New System.Drawing.Point(459, 145)
        Me.TxTEstadoCivil.MaxLength = 2
        Me.TxTEstadoCivil.Name = "TxTEstadoCivil"
        Me.TxTEstadoCivil.Size = New System.Drawing.Size(144, 21)
        Me.TxTEstadoCivil.TabIndex = 14
        '
        'txtUF
        '
        Me.txtUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtUF.ForeColor = System.Drawing.Color.Black
        Me.txtUF.FormattingEnabled = True
        Me.txtUF.ItemHeight = 13
        Me.txtUF.Items.AddRange(New Object() {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.txtUF.Location = New System.Drawing.Point(344, 115)
        Me.txtUF.MaxLength = 2
        Me.txtUF.Name = "txtUF"
        Me.txtUF.Size = New System.Drawing.Size(45, 21)
        Me.txtUF.TabIndex = 7
        '
        'lblUF
        '
        Me.lblUF.AutoSize = True
        Me.lblUF.BackColor = System.Drawing.Color.Transparent
        Me.lblUF.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUF.Location = New System.Drawing.Point(316, 118)
        Me.lblUF.Name = "lblUF"
        Me.lblUF.Size = New System.Drawing.Size(27, 14)
        Me.lblUF.TabIndex = 289
        Me.lblUF.Text = "UF*:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(321, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 14)
        Me.Label5.TabIndex = 300
        Me.Label5.Text = "Nº:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 91)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 14)
        Me.Label10.TabIndex = 299
        Me.Label10.Text = "Complemento:"
        '
        'TxtNumero
        '
        Me.TxtNumero.CausesValidation = False
        Me.TxtNumero.ForeColor = System.Drawing.Color.Black
        Me.TxtNumero.Location = New System.Drawing.Point(344, 61)
        Me.TxtNumero.MaxLength = 10
        Me.TxtNumero.Name = "TxtNumero"
        Me.TxtNumero.Size = New System.Drawing.Size(35, 21)
        Me.TxtNumero.TabIndex = 4
        '
        'txtcomplemento
        '
        Me.txtcomplemento.CausesValidation = False
        Me.txtcomplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcomplemento.ForeColor = System.Drawing.Color.Black
        Me.txtcomplemento.Location = New System.Drawing.Point(85, 88)
        Me.txtcomplemento.MaxLength = 200
        Me.txtcomplemento.Name = "txtcomplemento"
        Me.txtcomplemento.Size = New System.Drawing.Size(230, 21)
        Me.txtcomplemento.TabIndex = 5
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.BackColor = System.Drawing.Color.Transparent
        Me.lblNome.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.Location = New System.Drawing.Point(40, 10)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(37, 14)
        Me.lblNome.TabIndex = 298
        Me.lblNome.Text = "Nome:"
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.BackColor = System.Drawing.Color.Transparent
        Me.lblEndereco.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndereco.Location = New System.Drawing.Point(21, 64)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(56, 14)
        Me.lblEndereco.TabIndex = 286
        Me.lblEndereco.Text = "Endereço:"
        '
        'TxTCep
        '
        Me.TxTCep.CausesValidation = False
        Me.TxTCep.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxTCep.ForeColor = System.Drawing.Color.Black
        Me.TxTCep.Location = New System.Drawing.Point(85, 34)
        Me.TxTCep.MaxLength = 9
        Me.TxTCep.Name = "TxTCep"
        Me.TxTCep.Size = New System.Drawing.Size(133, 21)
        Me.TxTCep.TabIndex = 2
        '
        'RicTxTObservacoes
        '
        Me.RicTxTObservacoes.CausesValidation = False
        Me.RicTxTObservacoes.ForeColor = System.Drawing.Color.Black
        Me.RicTxTObservacoes.Location = New System.Drawing.Point(85, 169)
        Me.RicTxTObservacoes.MaxLength = 1000
        Me.RicTxTObservacoes.Name = "RicTxTObservacoes"
        Me.RicTxTObservacoes.Size = New System.Drawing.Size(230, 59)
        Me.RicTxTObservacoes.TabIndex = 9
        Me.RicTxTObservacoes.Text = ""
        '
        'lblCep
        '
        Me.lblCep.AutoSize = True
        Me.lblCep.BackColor = System.Drawing.Color.Transparent
        Me.lblCep.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCep.Location = New System.Drawing.Point(48, 37)
        Me.lblCep.Name = "lblCep"
        Me.lblCep.Size = New System.Drawing.Size(29, 14)
        Me.lblCep.TabIndex = 293
        Me.lblCep.Text = "CEP:"
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.BackColor = System.Drawing.Color.Transparent
        Me.lblCidade.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCidade.Location = New System.Drawing.Point(34, 118)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(43, 14)
        Me.lblCidade.TabIndex = 287
        Me.lblCidade.Text = "Cidade:"
        '
        'lblObservacao
        '
        Me.lblObservacao.AutoSize = True
        Me.lblObservacao.BackColor = System.Drawing.Color.Transparent
        Me.lblObservacao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObservacao.Location = New System.Drawing.Point(32, 169)
        Me.lblObservacao.Name = "lblObservacao"
        Me.lblObservacao.Size = New System.Drawing.Size(45, 14)
        Me.lblObservacao.TabIndex = 290
        Me.lblObservacao.Text = "Observ."
        '
        'TxTTelefone
        '
        Me.TxTTelefone.CausesValidation = False
        Me.TxTTelefone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxTTelefone.ForeColor = System.Drawing.Color.Black
        Me.TxTTelefone.Location = New System.Drawing.Point(459, 118)
        Me.TxTTelefone.MaxLength = 14
        Me.TxTTelefone.Name = "TxTTelefone"
        Me.TxTTelefone.Size = New System.Drawing.Size(144, 21)
        Me.TxTTelefone.TabIndex = 13
        '
        'TxTEmail
        '
        Me.TxTEmail.CausesValidation = False
        Me.TxTEmail.ForeColor = System.Drawing.Color.Black
        Me.TxTEmail.Location = New System.Drawing.Point(459, 172)
        Me.TxTEmail.MaxLength = 200
        Me.TxTEmail.Name = "TxTEmail"
        Me.TxTEmail.Size = New System.Drawing.Size(280, 21)
        Me.TxTEmail.TabIndex = 15
        '
        'lblTelefone
        '
        Me.lblTelefone.AutoSize = True
        Me.lblTelefone.BackColor = System.Drawing.Color.Transparent
        Me.lblTelefone.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefone.Location = New System.Drawing.Point(430, 121)
        Me.lblTelefone.Name = "lblTelefone"
        Me.lblTelefone.Size = New System.Drawing.Size(23, 14)
        Me.lblTelefone.TabIndex = 294
        Me.lblTelefone.Text = "Tel:"
        '
        'TxTCelular
        '
        Me.TxTCelular.CausesValidation = False
        Me.TxTCelular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxTCelular.ForeColor = System.Drawing.Color.Black
        Me.TxTCelular.Location = New System.Drawing.Point(459, 91)
        Me.TxTCelular.MaxLength = 15
        Me.TxTCelular.Name = "TxTCelular"
        Me.TxTCelular.Size = New System.Drawing.Size(144, 21)
        Me.TxTCelular.TabIndex = 12
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.BackColor = System.Drawing.Color.Transparent
        Me.lblBairro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBairro.Location = New System.Drawing.Point(38, 145)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(39, 14)
        Me.lblBairro.TabIndex = 292
        Me.lblBairro.Text = "Bairro:"
        '
        'TxTRG
        '
        Me.TxTRG.CausesValidation = False
        Me.TxTRG.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxTRG.ForeColor = System.Drawing.Color.Black
        Me.TxTRG.Location = New System.Drawing.Point(459, 64)
        Me.TxTRG.MaxLength = 20
        Me.TxTRG.Name = "TxTRG"
        Me.TxTRG.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxTRG.Size = New System.Drawing.Size(144, 21)
        Me.TxTRG.TabIndex = 11
        '
        'lblCpf
        '
        Me.lblCpf.AutoSize = True
        Me.lblCpf.BackColor = System.Drawing.Color.Transparent
        Me.lblCpf.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCpf.Location = New System.Drawing.Point(424, 44)
        Me.lblCpf.Name = "lblCpf"
        Me.lblCpf.Size = New System.Drawing.Size(29, 14)
        Me.lblCpf.TabIndex = 295
        Me.lblCpf.Text = "CPF:"
        '
        'TxTCidade
        '
        Me.TxTCidade.CausesValidation = False
        Me.TxTCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxTCidade.ForeColor = System.Drawing.Color.Black
        Me.TxTCidade.Location = New System.Drawing.Point(85, 115)
        Me.TxTCidade.MaxLength = 200
        Me.TxTCidade.Name = "TxTCidade"
        Me.TxTCidade.Size = New System.Drawing.Size(230, 21)
        Me.TxTCidade.TabIndex = 6
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.BackColor = System.Drawing.Color.Transparent
        Me.lblCelular.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCelular.Location = New System.Drawing.Point(415, 94)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(43, 14)
        Me.lblCelular.TabIndex = 296
        Me.lblCelular.Text = "Celular:"
        '
        'lblEstadocivil
        '
        Me.lblEstadocivil.AutoSize = True
        Me.lblEstadocivil.BackColor = System.Drawing.Color.Transparent
        Me.lblEstadocivil.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadocivil.Location = New System.Drawing.Point(403, 148)
        Me.lblEstadocivil.Name = "lblEstadocivil"
        Me.lblEstadocivil.Size = New System.Drawing.Size(50, 14)
        Me.lblEstadocivil.TabIndex = 291
        Me.lblEstadocivil.Text = "Est. Civil:"
        '
        'lblRG
        '
        Me.lblRG.AutoSize = True
        Me.lblRG.BackColor = System.Drawing.Color.Transparent
        Me.lblRG.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRG.Location = New System.Drawing.Point(428, 67)
        Me.lblRG.Name = "lblRG"
        Me.lblRG.Size = New System.Drawing.Size(25, 14)
        Me.lblRG.TabIndex = 288
        Me.lblRG.Text = "RG:"
        '
        'TxTCpf
        '
        Me.TxTCpf.CausesValidation = False
        Me.TxTCpf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxTCpf.ForeColor = System.Drawing.Color.Black
        Me.TxTCpf.Location = New System.Drawing.Point(459, 37)
        Me.TxTCpf.MaxLength = 14
        Me.TxTCpf.Name = "TxTCpf"
        Me.TxTCpf.Size = New System.Drawing.Size(144, 21)
        Me.TxTCpf.TabIndex = 10
        '
        'TxTEndereco
        '
        Me.TxTEndereco.CausesValidation = False
        Me.TxTEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxTEndereco.ForeColor = System.Drawing.Color.Black
        Me.TxTEndereco.Location = New System.Drawing.Point(85, 61)
        Me.TxTEndereco.MaxLength = 200
        Me.TxTEndereco.Name = "TxTEndereco"
        Me.TxTEndereco.Size = New System.Drawing.Size(230, 21)
        Me.TxTEndereco.TabIndex = 3
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(419, 175)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(34, 14)
        Me.lblEmail.TabIndex = 297
        Me.lblEmail.Text = "Email:"
        '
        'TxTBairro
        '
        Me.TxTBairro.CausesValidation = False
        Me.TxTBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxTBairro.ForeColor = System.Drawing.Color.Black
        Me.TxTBairro.Location = New System.Drawing.Point(85, 142)
        Me.TxTBairro.MaxLength = 200
        Me.TxTBairro.Name = "TxTBairro"
        Me.TxTBairro.Size = New System.Drawing.Size(230, 21)
        Me.TxTBairro.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.DgvFuncionario)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1045, 128)
        Me.Panel2.TabIndex = 1
        '
        'DgvFuncionario
        '
        Me.DgvFuncionario.AllowUserToAddRows = False
        Me.DgvFuncionario.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.DgvFuncionario.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvFuncionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DgvFuncionario.BackgroundColor = System.Drawing.Color.White
        Me.DgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFuncionario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colidusuario, Me.colnome, Me.colendereco, Me.colnumero, Me.colcomplemento, Me.colbairro, Me.colcep, Me.colcpf, Me.coltelefone, Me.colemail, Me.coluf, Me.colestadocivil, Me.colcelular, Me.colcidade, Me.colrg, Me.colobservacoes})
        Me.DgvFuncionario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvFuncionario.Location = New System.Drawing.Point(0, 0)
        Me.DgvFuncionario.MultiSelect = False
        Me.DgvFuncionario.Name = "DgvFuncionario"
        Me.DgvFuncionario.ReadOnly = True
        Me.DgvFuncionario.RowHeadersVisible = False
        Me.DgvFuncionario.RowHeadersWidth = 30
        Me.DgvFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvFuncionario.Size = New System.Drawing.Size(1043, 126)
        Me.DgvFuncionario.TabIndex = 80
        '
        'colidusuario
        '
        Me.colidusuario.HeaderText = "Id"
        Me.colidusuario.Name = "colidusuario"
        Me.colidusuario.ReadOnly = True
        Me.colidusuario.Visible = False
        Me.colidusuario.Width = 23
        '
        'colnome
        '
        Me.colnome.HeaderText = "Nome"
        Me.colnome.Name = "colnome"
        Me.colnome.ReadOnly = True
        Me.colnome.Width = 59
        '
        'colendereco
        '
        Me.colendereco.HeaderText = "Endereço"
        Me.colendereco.Name = "colendereco"
        Me.colendereco.ReadOnly = True
        Me.colendereco.Width = 77
        '
        'colnumero
        '
        Me.colnumero.HeaderText = "Nº"
        Me.colnumero.Name = "colnumero"
        Me.colnumero.ReadOnly = True
        Me.colnumero.Width = 44
        '
        'colcomplemento
        '
        Me.colcomplemento.HeaderText = "Complemento"
        Me.colcomplemento.Name = "colcomplemento"
        Me.colcomplemento.ReadOnly = True
        Me.colcomplemento.Width = 97
        '
        'colbairro
        '
        Me.colbairro.HeaderText = "Bairro"
        Me.colbairro.Name = "colbairro"
        Me.colbairro.ReadOnly = True
        Me.colbairro.Width = 60
        '
        'colcep
        '
        Me.colcep.HeaderText = "CEP"
        Me.colcep.Name = "colcep"
        Me.colcep.ReadOnly = True
        Me.colcep.Width = 51
        '
        'colcpf
        '
        Me.colcpf.HeaderText = "CPF"
        Me.colcpf.Name = "colcpf"
        Me.colcpf.ReadOnly = True
        Me.colcpf.Width = 51
        '
        'coltelefone
        '
        Me.coltelefone.HeaderText = "Telefone"
        Me.coltelefone.Name = "coltelefone"
        Me.coltelefone.ReadOnly = True
        Me.coltelefone.Width = 74
        '
        'colemail
        '
        Me.colemail.HeaderText = "E-mail"
        Me.colemail.Name = "colemail"
        Me.colemail.ReadOnly = True
        Me.colemail.Width = 60
        '
        'coluf
        '
        Me.coluf.HeaderText = "UF"
        Me.coluf.Name = "coluf"
        Me.coluf.ReadOnly = True
        Me.coluf.Width = 45
        '
        'colestadocivil
        '
        Me.colestadocivil.HeaderText = "Estado civil"
        Me.colestadocivil.Name = "colestadocivil"
        Me.colestadocivil.ReadOnly = True
        Me.colestadocivil.Width = 85
        '
        'colcelular
        '
        DataGridViewCellStyle4.NullValue = Nothing
        Me.colcelular.DefaultCellStyle = DataGridViewCellStyle4
        Me.colcelular.HeaderText = "Celular"
        Me.colcelular.Name = "colcelular"
        Me.colcelular.ReadOnly = True
        Me.colcelular.Width = 65
        '
        'colcidade
        '
        Me.colcidade.HeaderText = "Cidade"
        Me.colcidade.Name = "colcidade"
        Me.colcidade.ReadOnly = True
        Me.colcidade.Width = 65
        '
        'colrg
        '
        Me.colrg.HeaderText = "RG"
        Me.colrg.Name = "colrg"
        Me.colrg.ReadOnly = True
        Me.colrg.Width = 46
        '
        'colobservacoes
        '
        Me.colobservacoes.HeaderText = "Observações"
        Me.colobservacoes.Name = "colobservacoes"
        Me.colobservacoes.ReadOnly = True
        Me.colobservacoes.Width = 95
        '
        'bgwCarregaFuncionario
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.bink.My.Resources.Resources.spinner1
        Me.PictureBox1.Location = New System.Drawing.Point(471, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 87)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 307
        Me.PictureBox1.TabStop = False
        '
        'frmFuncionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1051, 500)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.mainRibbonControl)
        Me.Name = "frmFuncionario"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de funcionário"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.mainRibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gbFots.ResumeLayout(False)
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DgvFuncionario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents mainRibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiSaveAndClose As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnLimpar As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnExcluir As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnSair As DevExpress.XtraBars.BarButtonItem
    Private WithEvents rpInicio As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents mainRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DgvFuncionario As DataGridView
    Friend WithEvents colidusuario As DataGridViewTextBoxColumn
    Friend WithEvents colnome As DataGridViewTextBoxColumn
    Friend WithEvents colendereco As DataGridViewTextBoxColumn
    Friend WithEvents colnumero As DataGridViewTextBoxColumn
    Friend WithEvents colcomplemento As DataGridViewTextBoxColumn
    Friend WithEvents colbairro As DataGridViewTextBoxColumn
    Friend WithEvents colcep As DataGridViewTextBoxColumn
    Friend WithEvents colcpf As DataGridViewTextBoxColumn
    Friend WithEvents coltelefone As DataGridViewTextBoxColumn
    Friend WithEvents colemail As DataGridViewTextBoxColumn
    Friend WithEvents coluf As DataGridViewTextBoxColumn
    Friend WithEvents colestadocivil As DataGridViewTextBoxColumn
    Friend WithEvents colcelular As DataGridViewTextBoxColumn
    Friend WithEvents colcidade As DataGridViewTextBoxColumn
    Friend WithEvents colrg As DataGridViewTextBoxColumn
    Friend WithEvents colobservacoes As DataGridViewTextBoxColumn
    Friend WithEvents gbFots As GroupBox
    Friend WithEvents PicFoto As PictureBox
    Friend WithEvents btnProcurar As Button
    Friend WithEvents btnTirarFoto As Button
    Friend WithEvents TxTEstadoCivil As ComboBox
    Friend WithEvents txtUF As ComboBox
    Friend WithEvents lblUF As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtNumero As TextBox
    Friend WithEvents txtcomplemento As TextBox
    Friend WithEvents lblNome As Label
    Friend WithEvents lblEndereco As Label
    Friend WithEvents TxTCep As TextBox
    Friend WithEvents RicTxTObservacoes As RichTextBox
    Friend WithEvents lblCep As Label
    Friend WithEvents lblCidade As Label
    Friend WithEvents lblObservacao As Label
    Friend WithEvents TxTTelefone As TextBox
    Friend WithEvents TxTEmail As TextBox
    Friend WithEvents lblTelefone As Label
    Friend WithEvents TxTCelular As TextBox
    Friend WithEvents lblBairro As Label
    Friend WithEvents TxTRG As TextBox
    Friend WithEvents lblCpf As Label
    Friend WithEvents TxTCidade As TextBox
    Friend WithEvents lblCelular As Label
    Friend WithEvents lblEstadocivil As Label
    Friend WithEvents lblRG As Label
    Friend WithEvents TxTCpf As TextBox
    Friend WithEvents TxTEndereco As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents TxTBairro As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents bgwCarregaFuncionario As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureBox1 As PictureBox
End Class
