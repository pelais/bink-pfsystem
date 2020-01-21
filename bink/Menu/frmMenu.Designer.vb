<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnCliente = New DevExpress.XtraBars.BarButtonItem()
        Me.btnFornecedor = New DevExpress.XtraBars.BarButtonItem()
        Me.btnFuncionario = New DevExpress.XtraBars.BarButtonItem()
        Me.btnUsuario = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPermissoes = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLogs = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEmpresa = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAjuda = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSobre = New DevExpress.XtraBars.BarButtonItem()
        Me.btnContrato = New DevExpress.XtraBars.BarButtonItem()
        Me.btnContaPagar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnContasReceber = New DevExpress.XtraBars.BarButtonItem()
        Me.btnBanco = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCartao = New DevExpress.XtraBars.BarButtonItem()
        Me.btnFormaPgto = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCalculadora = New DevExpress.XtraBars.BarButtonItem()
        Me.versao = New DevExpress.XtraBars.BarHeaderItem()
        Me.lblUsuario = New DevExpress.XtraBars.BarHeaderItem()
        Me.hora = New DevExpress.XtraBars.BarHeaderItem()
        Me.btnProduto = New DevExpress.XtraBars.BarButtonItem()
        Me.btnServico = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPermissoes1 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnTrocaLogin = New DevExpress.XtraBars.BarButtonItem()
        Me.btnTrocaSenha = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCadImagem = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPerfil = New DevExpress.XtraBars.BarButtonItem()
        Me.imgColecao = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonMiniToolbar1 = New DevExpress.XtraBars.Ribbon.RibbonMiniToolbar(Me.components)
        Me.RibbonMiniToolbar2 = New DevExpress.XtraBars.Ribbon.RibbonMiniToolbar(Me.components)
        Me.rpCadastro = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpgCadastro = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpFinanceiro = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpgFinanceiro = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpBanco = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpUtilitario = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpgConfiguracao = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpPerfil = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpUsuario = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.pnImageMenu = New DevExpress.XtraEditors.PanelControl()
        Me.pnImagemEmpresa = New System.Windows.Forms.PictureBox()
        Me.gpInfo = New System.Windows.Forms.GroupBox()
        Me.lbEmail = New System.Windows.Forms.Label()
        Me.lbContato = New System.Windows.Forms.Label()
        Me.lbEndereco = New System.Windows.Forms.Label()
        Me.lbEmpresa = New System.Windows.Forms.Label()
        Me.picFoto = New System.Windows.Forms.PictureBox()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.tableMDI = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.tmHra = New System.Windows.Forms.Timer(Me.components)
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgColecao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnImageMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnImageMenu.SuspendLayout()
        CType(Me.pnImagemEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpInfo.SuspendLayout()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tableMDI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.AutoSaveLayoutToXml = True
        Me.RibbonControl.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnCliente, Me.btnFornecedor, Me.btnFuncionario, Me.btnUsuario, Me.btnPermissoes, Me.btnLogs, Me.btnEmpresa, Me.btnAjuda, Me.btnSobre, Me.btnContrato, Me.btnContaPagar, Me.btnContasReceber, Me.btnBanco, Me.btnCartao, Me.btnFormaPgto, Me.btnCalculadora, Me.versao, Me.lblUsuario, Me.hora, Me.btnProduto, Me.btnServico, Me.btnPermissoes1, Me.btnTrocaLogin, Me.btnTrocaSenha, Me.btnCadImagem, Me.btnPerfil})
        Me.RibbonControl.LargeImages = Me.imgColecao
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 4
        Me.RibbonControl.MiniToolbars.Add(Me.RibbonMiniToolbar1)
        Me.RibbonControl.MiniToolbars.Add(Me.RibbonMiniToolbar2)
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rpCadastro, Me.rpFinanceiro, Me.rpUtilitario})
        Me.RibbonControl.ShowQatLocationSelector = False
        Me.RibbonControl.ShowToolbarCustomizeItem = False
        Me.RibbonControl.Size = New System.Drawing.Size(1356, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        Me.RibbonControl.Toolbar.ShowCustomizeItem = False
        '
        'btnCliente
        '
        Me.btnCliente.Caption = "Cliente"
        Me.btnCliente.Id = 9
        Me.btnCliente.ImageOptions.LargeImageIndex = 31
        Me.btnCliente.Name = "btnCliente"
        '
        'btnFornecedor
        '
        Me.btnFornecedor.Caption = "Fornecedor"
        Me.btnFornecedor.Id = 10
        Me.btnFornecedor.ImageOptions.Image = Global.bink.My.Resources.Resources.fornecedor
        Me.btnFornecedor.Name = "btnFornecedor"
        '
        'btnFuncionario
        '
        Me.btnFuncionario.Caption = "Funcionário"
        Me.btnFuncionario.Id = 11
        Me.btnFuncionario.ImageOptions.LargeImageIndex = 36
        Me.btnFuncionario.Name = "btnFuncionario"
        '
        'btnUsuario
        '
        Me.btnUsuario.Caption = "Usuários"
        Me.btnUsuario.Id = 12
        Me.btnUsuario.ImageOptions.LargeImageIndex = 37
        Me.btnUsuario.Name = "btnUsuario"
        '
        'btnPermissoes
        '
        Me.btnPermissoes.Caption = "Permissões"
        Me.btnPermissoes.Id = 13
        Me.btnPermissoes.ImageOptions.Image = Global.bink.My.Resources.Resources.perfil
        Me.btnPermissoes.Name = "btnPermissoes"
        '
        'btnLogs
        '
        Me.btnLogs.Caption = "Logs"
        Me.btnLogs.Id = 14
        Me.btnLogs.ImageOptions.Image = Global.bink.My.Resources.Resources.log
        Me.btnLogs.Name = "btnLogs"
        '
        'btnEmpresa
        '
        Me.btnEmpresa.Caption = "Empresa"
        Me.btnEmpresa.Id = 15
        Me.btnEmpresa.ImageOptions.LargeImageIndex = 7
        Me.btnEmpresa.Name = "btnEmpresa"
        '
        'btnAjuda
        '
        Me.btnAjuda.Caption = "Ajuda"
        Me.btnAjuda.Id = 16
        Me.btnAjuda.ImageOptions.Image = Global.bink.My.Resources.Resources.ajuda
        Me.btnAjuda.Name = "btnAjuda"
        '
        'btnSobre
        '
        Me.btnSobre.Caption = "Sobre"
        Me.btnSobre.Id = 17
        Me.btnSobre.ImageOptions.Image = Global.bink.My.Resources.Resources.sobre
        Me.btnSobre.Name = "btnSobre"
        '
        'btnContrato
        '
        Me.btnContrato.Caption = "Contrato"
        Me.btnContrato.Id = 18
        Me.btnContrato.ImageOptions.Image = Global.bink.My.Resources.Resources.editar
        Me.btnContrato.Name = "btnContrato"
        '
        'btnContaPagar
        '
        Me.btnContaPagar.Caption = "Contas a pagar"
        Me.btnContaPagar.Id = 19
        Me.btnContaPagar.ImageOptions.LargeImageIndex = 39
        Me.btnContaPagar.Name = "btnContaPagar"
        '
        'btnContasReceber
        '
        Me.btnContasReceber.Caption = "Contas a receber"
        Me.btnContasReceber.Id = 20
        Me.btnContasReceber.ImageOptions.LargeImageIndex = 40
        Me.btnContasReceber.Name = "btnContasReceber"
        '
        'btnBanco
        '
        Me.btnBanco.Caption = "Banco"
        Me.btnBanco.Id = 22
        Me.btnBanco.ImageOptions.LargeImageIndex = 4
        Me.btnBanco.Name = "btnBanco"
        '
        'btnCartao
        '
        Me.btnCartao.Caption = "Cartões"
        Me.btnCartao.Id = 23
        Me.btnCartao.ImageOptions.Image = Global.bink.My.Resources.Resources.cartoes
        Me.btnCartao.Name = "btnCartao"
        '
        'btnFormaPgto
        '
        Me.btnFormaPgto.Caption = "Forma de pagamento"
        Me.btnFormaPgto.Id = 24
        Me.btnFormaPgto.ImageOptions.Image = Global.bink.My.Resources.Resources.financeiro
        Me.btnFormaPgto.Name = "btnFormaPgto"
        '
        'btnCalculadora
        '
        Me.btnCalculadora.Caption = "Calculadora"
        Me.btnCalculadora.Id = 25
        Me.btnCalculadora.ImageOptions.Image = Global.bink.My.Resources.Resources.calculadora
        Me.btnCalculadora.Name = "btnCalculadora"
        '
        'versao
        '
        Me.versao.Caption = "versao"
        Me.versao.Id = 26
        Me.versao.Name = "versao"
        '
        'lblUsuario
        '
        Me.lblUsuario.Caption = "usuario"
        Me.lblUsuario.Id = 27
        Me.lblUsuario.Name = "lblUsuario"
        '
        'hora
        '
        Me.hora.Caption = "horario"
        Me.hora.Id = 28
        Me.hora.Name = "hora"
        '
        'btnProduto
        '
        Me.btnProduto.Caption = "Produto"
        Me.btnProduto.Id = 2
        Me.btnProduto.ImageOptions.Image = Global.bink.My.Resources.Resources.produto
        Me.btnProduto.Name = "btnProduto"
        '
        'btnServico
        '
        Me.btnServico.Caption = "Serviço"
        Me.btnServico.Id = 3
        Me.btnServico.ImageOptions.Image = Global.bink.My.Resources.Resources.servico
        Me.btnServico.Name = "btnServico"
        '
        'btnPermissoes1
        '
        Me.btnPermissoes1.Caption = "Permissões"
        Me.btnPermissoes1.Id = 4
        Me.btnPermissoes1.ImageOptions.Image = Global.bink.My.Resources.Resources.permissao
        Me.btnPermissoes1.Name = "btnPermissoes1"
        '
        'btnTrocaLogin
        '
        Me.btnTrocaLogin.Caption = "Entrar com outro usuário"
        Me.btnTrocaLogin.Id = 5
        Me.btnTrocaLogin.ImageOptions.Image = Global.bink.My.Resources.Resources.cliente
        Me.btnTrocaLogin.Name = "btnTrocaLogin"
        '
        'btnTrocaSenha
        '
        Me.btnTrocaSenha.Caption = "Trocar senha de Usuário"
        Me.btnTrocaSenha.Id = 1
        Me.btnTrocaSenha.ImageOptions.LargeImage = Global.bink.My.Resources.Resources.troca_senha
        Me.btnTrocaSenha.Name = "btnTrocaSenha"
        '
        'btnCadImagem
        '
        Me.btnCadImagem.Caption = "Cadastro de imagens"
        Me.btnCadImagem.Id = 2
        Me.btnCadImagem.ImageOptions.LargeImageIndex = 41
        Me.btnCadImagem.Name = "btnCadImagem"
        '
        'btnPerfil
        '
        Me.btnPerfil.Caption = "Perfil"
        Me.btnPerfil.Id = 3
        Me.btnPerfil.ImageOptions.Image = Global.bink.My.Resources.Resources.perfil1
        Me.btnPerfil.Name = "btnPerfil"
        '
        'imgColecao
        '
        Me.imgColecao.ImageSize = New System.Drawing.Size(32, 32)
        Me.imgColecao.ImageStream = CType(resources.GetObject("imgColecao.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.imgColecao.Images.SetKeyName(0, "001_shoppingcart_empty.png")
        Me.imgColecao.Images.SetKeyName(1, "acroread.png")
        Me.imgColecao.Images.SetKeyName(2, "Add.png")
        Me.imgColecao.Images.SetKeyName(3, "Back.png")
        Me.imgColecao.Images.SetKeyName(4, "banco.png")
        Me.imgColecao.Images.SetKeyName(5, "Bar Chart.png")
        Me.imgColecao.Images.SetKeyName(6, "cartoes.png")
        Me.imgColecao.Images.SetKeyName(7, "Computer.png")
        Me.imgColecao.Images.SetKeyName(8, "control-center2.png")
        Me.imgColecao.Images.SetKeyName(9, "Delete.png")
        Me.imgColecao.Images.SetKeyName(10, "Email.png")
        Me.imgColecao.Images.SetKeyName(11, "financeiro.png")
        Me.imgColecao.Images.SetKeyName(12, "gedit-icon3.png")
        Me.imgColecao.Images.SetKeyName(13, "gnome-calc3.png")
        Me.imgColecao.Images.SetKeyName(14, "gnome-gnumeric3.png")
        Me.imgColecao.Images.SetKeyName(15, "gnome-searchtool.png")
        Me.imgColecao.Images.SetKeyName(16, "gnome-terminal.png")
        Me.imgColecao.Images.SetKeyName(17, "Line Chart.png")
        Me.imgColecao.Images.SetKeyName(18, "Money.png")
        Me.imgColecao.Images.SetKeyName(19, "Money_Bag.png")
        Me.imgColecao.Images.SetKeyName(20, "Money_Calculator.png")
        Me.imgColecao.Images.SetKeyName(21, "Money_Pig.png")
        Me.imgColecao.Images.SetKeyName(22, "Money_Pig1.png")
        Me.imgColecao.Images.SetKeyName(23, "Money_Safe.png")
        Me.imgColecao.Images.SetKeyName(24, "Money_Safe1.png")
        Me.imgColecao.Images.SetKeyName(25, "Money_Transportation.png")
        Me.imgColecao.Images.SetKeyName(26, "Next.png")
        Me.imgColecao.Images.SetKeyName(27, "nfs_unmount.png")
        Me.imgColecao.Images.SetKeyName(28, "Pie Chart.png")
        Me.imgColecao.Images.SetKeyName(29, "Print.png")
        Me.imgColecao.Images.SetKeyName(30, "print-manager.png")
        Me.imgColecao.Images.SetKeyName(31, "Profile.png")
        Me.imgColecao.Images.SetKeyName(32, "Purse.png")
        Me.imgColecao.Images.SetKeyName(33, "redhat-system_settings.png")
        Me.imgColecao.Images.SetKeyName(34, "Save.png")
        Me.imgColecao.Images.SetKeyName(35, "fornecedor.png")
        Me.imgColecao.Images.SetKeyName(36, "funcionarios.png")
        Me.imgColecao.Images.SetKeyName(37, "users.png")
        Me.imgColecao.Images.SetKeyName(38, "Symbol-Help.png")
        Me.imgColecao.Images.SetKeyName(39, "contapagar.png")
        Me.imgColecao.Images.SetKeyName(40, "contareceber.png")
        Me.imgColecao.Images.SetKeyName(41, "cad_imagem.png")
        '
        'RibbonMiniToolbar1
        '
        Me.RibbonMiniToolbar1.ParentControl = Me
        '
        'RibbonMiniToolbar2
        '
        Me.RibbonMiniToolbar2.ParentControl = Me
        '
        'rpCadastro
        '
        Me.rpCadastro.Appearance.Options.UseTextOptions = True
        Me.rpCadastro.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.rpCadastro.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgCadastro})
        Me.rpCadastro.Name = "rpCadastro"
        Me.rpCadastro.Text = "Cadastro"
        '
        'rpgCadastro
        '
        Me.rpgCadastro.ItemLinks.Add(Me.btnCliente, True)
        Me.rpgCadastro.ItemLinks.Add(Me.btnFuncionario, True)
        Me.rpgCadastro.ItemLinks.Add(Me.btnFornecedor, True)
        Me.rpgCadastro.ItemLinks.Add(Me.btnProduto)
        Me.rpgCadastro.ItemLinks.Add(Me.btnServico)
        Me.rpgCadastro.Name = "rpgCadastro"
        Me.rpgCadastro.Text = "Cadastro"
        '
        'rpFinanceiro
        '
        Me.rpFinanceiro.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgFinanceiro, Me.rpBanco})
        Me.rpFinanceiro.Name = "rpFinanceiro"
        Me.rpFinanceiro.Text = "Financeiro"
        '
        'rpgFinanceiro
        '
        Me.rpgFinanceiro.ItemLinks.Add(Me.btnContaPagar, True)
        Me.rpgFinanceiro.ItemLinks.Add(Me.btnContasReceber, True)
        Me.rpgFinanceiro.Name = "rpgFinanceiro"
        Me.rpgFinanceiro.Text = "Controle financeiro"
        '
        'rpBanco
        '
        Me.rpBanco.ItemLinks.Add(Me.btnBanco, True)
        Me.rpBanco.ItemLinks.Add(Me.btnCartao)
        Me.rpBanco.ItemLinks.Add(Me.btnFormaPgto)
        Me.rpBanco.ItemLinks.Add(Me.btnCalculadora)
        Me.rpBanco.Name = "rpBanco"
        Me.rpBanco.Text = "Cadastro financeiro"
        '
        'rpUtilitario
        '
        Me.rpUtilitario.Appearance.Options.UseTextOptions = True
        Me.rpUtilitario.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.rpUtilitario.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgConfiguracao, Me.rpPerfil, Me.rpUsuario})
        Me.rpUtilitario.Name = "rpUtilitario"
        Me.rpUtilitario.Text = "Utilitários"
        '
        'rpgConfiguracao
        '
        Me.rpgConfiguracao.ItemLinks.Add(Me.btnEmpresa, True)
        Me.rpgConfiguracao.ItemLinks.Add(Me.btnCadImagem, True)
        Me.rpgConfiguracao.Name = "rpgConfiguracao"
        Me.rpgConfiguracao.Text = "Empresa"
        '
        'rpPerfil
        '
        Me.rpPerfil.ItemLinks.Add(Me.btnContrato)
        Me.rpPerfil.ItemLinks.Add(Me.btnAjuda)
        Me.rpPerfil.ItemLinks.Add(Me.btnSobre)
        Me.rpPerfil.Name = "rpPerfil"
        Me.rpPerfil.Text = "Utilidades"
        '
        'rpUsuario
        '
        Me.rpUsuario.ItemLinks.Add(Me.btnUsuario, True)
        Me.rpUsuario.ItemLinks.Add(Me.btnTrocaSenha, True)
        Me.rpUsuario.ItemLinks.Add(Me.btnPerfil)
        Me.rpUsuario.ItemLinks.Add(Me.btnPermissoes)
        Me.rpUsuario.ItemLinks.Add(Me.btnLogs)
        Me.rpUsuario.Name = "rpUsuario"
        Me.rpUsuario.Text = "Usuário"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(2, 595)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(1352, 27)
        '
        'pnImageMenu
        '
        Me.pnImageMenu.Controls.Add(Me.pnImagemEmpresa)
        Me.pnImageMenu.Controls.Add(Me.gpInfo)
        Me.pnImageMenu.Controls.Add(Me.lblHora)
        Me.pnImageMenu.Controls.Add(Me.RibbonStatusBar)
        Me.pnImageMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnImageMenu.Location = New System.Drawing.Point(0, 143)
        Me.pnImageMenu.Name = "pnImageMenu"
        Me.pnImageMenu.Size = New System.Drawing.Size(1356, 624)
        Me.pnImageMenu.TabIndex = 3
        '
        'pnImagemEmpresa
        '
        Me.pnImagemEmpresa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnImagemEmpresa.Location = New System.Drawing.Point(348, 0)
        Me.pnImagemEmpresa.Name = "pnImagemEmpresa"
        Me.pnImagemEmpresa.Size = New System.Drawing.Size(1008, 570)
        Me.pnImagemEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pnImagemEmpresa.TabIndex = 5
        Me.pnImagemEmpresa.TabStop = False
        '
        'gpInfo
        '
        Me.gpInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gpInfo.Controls.Add(Me.lbEmail)
        Me.gpInfo.Controls.Add(Me.lbContato)
        Me.gpInfo.Controls.Add(Me.lbEndereco)
        Me.gpInfo.Controls.Add(Me.lbEmpresa)
        Me.gpInfo.Controls.Add(Me.picFoto)
        Me.gpInfo.Location = New System.Drawing.Point(5, 6)
        Me.gpInfo.Name = "gpInfo"
        Me.gpInfo.Size = New System.Drawing.Size(337, 564)
        Me.gpInfo.TabIndex = 3
        Me.gpInfo.TabStop = False
        Me.gpInfo.Text = "Informações"
        '
        'lbEmail
        '
        Me.lbEmail.AutoSize = True
        Me.lbEmail.BackColor = System.Drawing.Color.Transparent
        Me.lbEmail.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEmail.Location = New System.Drawing.Point(7, 233)
        Me.lbEmail.Name = "lbEmail"
        Me.lbEmail.Size = New System.Drawing.Size(39, 16)
        Me.lbEmail.TabIndex = 6
        Me.lbEmail.Text = "Email"
        '
        'lbContato
        '
        Me.lbContato.AutoSize = True
        Me.lbContato.BackColor = System.Drawing.Color.Transparent
        Me.lbContato.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbContato.Location = New System.Drawing.Point(7, 217)
        Me.lbContato.Name = "lbContato"
        Me.lbContato.Size = New System.Drawing.Size(50, 16)
        Me.lbContato.TabIndex = 5
        Me.lbContato.Text = "contato"
        '
        'lbEndereco
        '
        Me.lbEndereco.AutoSize = True
        Me.lbEndereco.BackColor = System.Drawing.Color.Transparent
        Me.lbEndereco.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEndereco.Location = New System.Drawing.Point(7, 201)
        Me.lbEndereco.Name = "lbEndereco"
        Me.lbEndereco.Size = New System.Drawing.Size(61, 16)
        Me.lbEndereco.TabIndex = 4
        Me.lbEndereco.Text = "endereco"
        '
        'lbEmpresa
        '
        Me.lbEmpresa.AutoSize = True
        Me.lbEmpresa.BackColor = System.Drawing.Color.Transparent
        Me.lbEmpresa.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEmpresa.Location = New System.Drawing.Point(6, 183)
        Me.lbEmpresa.Name = "lbEmpresa"
        Me.lbEmpresa.Size = New System.Drawing.Size(70, 19)
        Me.lbEmpresa.TabIndex = 3
        Me.lbEmpresa.Text = "Empresa"
        '
        'picFoto
        '
        Me.picFoto.Location = New System.Drawing.Point(7, 20)
        Me.picFoto.Name = "picFoto"
        Me.picFoto.Size = New System.Drawing.Size(324, 160)
        Me.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFoto.TabIndex = 2
        Me.picFoto.TabStop = False
        '
        'lblHora
        '
        Me.lblHora.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblHora.AutoSize = True
        Me.lblHora.BackColor = System.Drawing.Color.Transparent
        Me.lblHora.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.Location = New System.Drawing.Point(5, 573)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(48, 19)
        Me.lblHora.TabIndex = 1
        Me.lblHora.Text = "horas"
        '
        'tableMDI
        '
        Me.tableMDI.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders
        Me.tableMDI.MdiParent = Me
        '
        'tmHra
        '
        Me.tmHra.Enabled = True
        Me.tmHra.Interval = 1000
        '
        'frmMenu
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[True]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1356, 767)
        Me.Controls.Add(Me.pnImageMenu)
        Me.Controls.Add(Me.RibbonControl)
        Me.IsMdiContainer = True
        Me.Name = "frmMenu"
        Me.Ribbon = Me.RibbonControl
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "B-INK - PFSYSTEM SOLUÇÕES E TECNOLOGIA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgColecao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnImageMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnImageMenu.ResumeLayout(False)
        Me.pnImageMenu.PerformLayout()
        CType(Me.pnImagemEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpInfo.ResumeLayout(False)
        Me.gpInfo.PerformLayout()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tableMDI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents rpCadastro As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpgCadastro As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents imgColecao As DevExpress.Utils.ImageCollection
    Friend WithEvents btnCliente As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFornecedor As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFuncionario As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnUsuario As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPermissoes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpUtilitario As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpgConfiguracao As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnLogs As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEmpresa As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpPerfil As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnAjuda As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSobre As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnContrato As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpFinanceiro As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpgFinanceiro As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnContaPagar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnContasReceber As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnBanco As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpBanco As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnCartao As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFormaPgto As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCalculadora As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents versao As DevExpress.XtraBars.BarHeaderItem
    Friend WithEvents lblUsuario As DevExpress.XtraBars.BarHeaderItem
    Friend WithEvents hora As DevExpress.XtraBars.BarHeaderItem
    Friend WithEvents pnImageMenu As DevExpress.XtraEditors.PanelControl
    Friend WithEvents tableMDI As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btnProduto As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnServico As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents lblHora As Label
    Friend WithEvents tmHra As Timer
    Friend WithEvents picFoto As PictureBox
    Friend WithEvents gpInfo As GroupBox
    Friend WithEvents lbEmpresa As Label
    Friend WithEvents lbEndereco As Label
    Friend WithEvents lbEmail As Label
    Friend WithEvents lbContato As Label
    Friend WithEvents btnPermissoes1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnTrocaLogin As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnTrocaSenha As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonMiniToolbar1 As DevExpress.XtraBars.Ribbon.RibbonMiniToolbar
    Friend WithEvents rpUsuario As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonMiniToolbar2 As DevExpress.XtraBars.Ribbon.RibbonMiniToolbar
    Friend WithEvents pnImagemEmpresa As PictureBox
    Friend WithEvents btnCadImagem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPerfil As DevExpress.XtraBars.BarButtonItem
End Class
