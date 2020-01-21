<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCadEmpresa
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadEmpresa))
        Me.ImagemTbEscritorio = New System.Windows.Forms.ImageList(Me.components)
        Me.tcEmpresa = New DevExpress.XtraBars.Navigation.TabPane()
        Me.tpDadosEmpresa = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbPorte = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbTipoEmpresa = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblaviso = New System.Windows.Forms.Label()
        Me.btnRemovFoto = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblLargura = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PicFoto = New System.Windows.Forms.PictureBox()
        Me.lblAltura = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRazsocial = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtComplemento = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.lblEmpresa = New System.Windows.Forms.Label()
        Me.lblCidade = New System.Windows.Forms.Label()
        Me.TxTEmpresa = New System.Windows.Forms.TextBox()
        Me.TxtCidade = New System.Windows.Forms.TextBox()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.lblEndereco = New System.Windows.Forms.Label()
        Me.lblBairro = New System.Windows.Forms.Label()
        Me.lblUf = New System.Windows.Forms.Label()
        Me.lbllocal = New System.Windows.Forms.Label()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.cboUF = New System.Windows.Forms.ComboBox()
        Me.TxTTelefone = New System.Windows.Forms.TextBox()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.lblCep = New System.Windows.Forms.Label()
        Me.lblCelular = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtcep = New System.Windows.Forms.TextBox()
        Me.lblCnpj = New System.Windows.Forms.Label()
        Me.txtCnpj = New System.Windows.Forms.TextBox()
        Me.tpImagem = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLimpar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExcluir = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSair = New DevExpress.XtraBars.BarButtonItem()
        Me.rpInicio = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.mainRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.bgwCarregaLogo = New System.ComponentModel.BackgroundWorker()
        CType(Me.tcEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcEmpresa.SuspendLayout()
        Me.tpDadosEmpresa.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImagemTbEscritorio
        '
        Me.ImagemTbEscritorio.ImageStream = CType(resources.GetObject("ImagemTbEscritorio.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImagemTbEscritorio.TransparentColor = System.Drawing.Color.Transparent
        Me.ImagemTbEscritorio.Images.SetKeyName(0, "1975_32x32.png")
        '
        'tcEmpresa
        '
        Me.tcEmpresa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tcEmpresa.Controls.Add(Me.tpDadosEmpresa)
        Me.tcEmpresa.Controls.Add(Me.tpImagem)
        Me.tcEmpresa.Location = New System.Drawing.Point(0, 120)
        Me.tcEmpresa.Name = "tcEmpresa"
        Me.tcEmpresa.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tpDadosEmpresa, Me.tpImagem})
        Me.tcEmpresa.RegularSize = New System.Drawing.Size(1356, 615)
        Me.tcEmpresa.SelectedPage = Me.tpImagem
        Me.tcEmpresa.Size = New System.Drawing.Size(1356, 615)
        Me.tcEmpresa.TabIndex = 335
        Me.tcEmpresa.Text = "TabPane1"
        '
        'tpDadosEmpresa
        '
        Me.tpDadosEmpresa.Caption = "Cadastro"
        Me.tpDadosEmpresa.Controls.Add(Me.Label8)
        Me.tpDadosEmpresa.Controls.Add(Me.cbPorte)
        Me.tpDadosEmpresa.Controls.Add(Me.Label7)
        Me.tpDadosEmpresa.Controls.Add(Me.cbTipoEmpresa)
        Me.tpDadosEmpresa.Controls.Add(Me.Label1)
        Me.tpDadosEmpresa.Controls.Add(Me.txtIE)
        Me.tpDadosEmpresa.Controls.Add(Me.Label4)
        Me.tpDadosEmpresa.Controls.Add(Me.btnBuscar)
        Me.tpDadosEmpresa.Controls.Add(Me.lblaviso)
        Me.tpDadosEmpresa.Controls.Add(Me.btnRemovFoto)
        Me.tpDadosEmpresa.Controls.Add(Me.Label3)
        Me.tpDadosEmpresa.Controls.Add(Me.Label2)
        Me.tpDadosEmpresa.Controls.Add(Me.lblLargura)
        Me.tpDadosEmpresa.Controls.Add(Me.GroupBox1)
        Me.tpDadosEmpresa.Controls.Add(Me.lblAltura)
        Me.tpDadosEmpresa.Controls.Add(Me.Label6)
        Me.tpDadosEmpresa.Controls.Add(Me.txtRazsocial)
        Me.tpDadosEmpresa.Controls.Add(Me.Label5)
        Me.tpDadosEmpresa.Controls.Add(Me.txtComplemento)
        Me.tpDadosEmpresa.Controls.Add(Me.txtNumero)
        Me.tpDadosEmpresa.Controls.Add(Me.lblEmpresa)
        Me.tpDadosEmpresa.Controls.Add(Me.lblCidade)
        Me.tpDadosEmpresa.Controls.Add(Me.TxTEmpresa)
        Me.tpDadosEmpresa.Controls.Add(Me.TxtCidade)
        Me.tpDadosEmpresa.Controls.Add(Me.txtEndereco)
        Me.tpDadosEmpresa.Controls.Add(Me.lblNumero)
        Me.tpDadosEmpresa.Controls.Add(Me.lblEndereco)
        Me.tpDadosEmpresa.Controls.Add(Me.lblBairro)
        Me.tpDadosEmpresa.Controls.Add(Me.lblUf)
        Me.tpDadosEmpresa.Controls.Add(Me.lbllocal)
        Me.tpDadosEmpresa.Controls.Add(Me.txtCelular)
        Me.tpDadosEmpresa.Controls.Add(Me.cboUF)
        Me.tpDadosEmpresa.Controls.Add(Me.TxTTelefone)
        Me.tpDadosEmpresa.Controls.Add(Me.txtBairro)
        Me.tpDadosEmpresa.Controls.Add(Me.lblCep)
        Me.tpDadosEmpresa.Controls.Add(Me.lblCelular)
        Me.tpDadosEmpresa.Controls.Add(Me.txtEmail)
        Me.tpDadosEmpresa.Controls.Add(Me.lblEmail)
        Me.tpDadosEmpresa.Controls.Add(Me.txtcep)
        Me.tpDadosEmpresa.Controls.Add(Me.lblCnpj)
        Me.tpDadosEmpresa.Controls.Add(Me.txtCnpj)
        Me.tpDadosEmpresa.Name = "tpDadosEmpresa"
        Me.tpDadosEmpresa.Size = New System.Drawing.Size(1356, 588)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(9, 294)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 14)
        Me.Label8.TabIndex = 399
        Me.Label8.Text = "Porte da empresa"
        '
        'cbPorte
        '
        Me.cbPorte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPorte.ForeColor = System.Drawing.Color.Black
        Me.cbPorte.FormattingEnabled = True
        Me.cbPorte.ItemHeight = 13
        Me.cbPorte.Items.AddRange(New Object() {"LTDA ", "MICROEMPREENDEDOR INDIVIDUAL", "MICROEMPRESA", "EPP - PEQUENO PORTE", "EIRELI  - EMPRESA INDIVIDUAL DE RESPONSALIBILIDADE LIMITADA"})
        Me.cbPorte.Location = New System.Drawing.Point(11, 310)
        Me.cbPorte.MaxLength = 2
        Me.cbPorte.Name = "cbPorte"
        Me.cbPorte.Size = New System.Drawing.Size(466, 21)
        Me.cbPorte.TabIndex = 398
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(244, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 14)
        Me.Label7.TabIndex = 397
        Me.Label7.Text = "Física/Jurídica"
        '
        'cbTipoEmpresa
        '
        Me.cbTipoEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoEmpresa.ForeColor = System.Drawing.Color.Black
        Me.cbTipoEmpresa.FormattingEnabled = True
        Me.cbTipoEmpresa.ItemHeight = 13
        Me.cbTipoEmpresa.Items.AddRange(New Object() {"FÍSICA", "JURÍDICA"})
        Me.cbTipoEmpresa.Location = New System.Drawing.Point(246, 110)
        Me.cbTipoEmpresa.MaxLength = 2
        Me.cbTipoEmpresa.Name = "cbTipoEmpresa"
        Me.cbTipoEmpresa.Size = New System.Drawing.Size(158, 21)
        Me.cbTipoEmpresa.TabIndex = 396
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(12, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 14)
        Me.Label1.TabIndex = 395
        Me.Label1.Text = "Inscrição Estadual:"
        '
        'txtIE
        '
        Me.txtIE.AllowDrop = True
        Me.txtIE.ForeColor = System.Drawing.Color.Black
        Me.txtIE.Location = New System.Drawing.Point(12, 110)
        Me.txtIE.MaxLength = 100
        Me.txtIE.Name = "txtIE"
        Me.txtIE.Size = New System.Drawing.Size(230, 21)
        Me.txtIE.TabIndex = 394
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(545, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(261, 14)
        Me.Label4.TabIndex = 393
        Me.Label4.Text = "Tamanho máximo da foto permitida: 1024 x 768"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.White
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.Black
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.Location = New System.Drawing.Point(551, 210)
        Me.btnBuscar.MaximumSize = New System.Drawing.Size(151, 42)
        Me.btnBuscar.MinimumSize = New System.Drawing.Size(151, 42)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(151, 42)
        Me.btnBuscar.TabIndex = 385
        Me.btnBuscar.Text = "Anexar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'lblaviso
        '
        Me.lblaviso.AutoSize = True
        Me.lblaviso.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblaviso.ForeColor = System.Drawing.Color.Red
        Me.lblaviso.Location = New System.Drawing.Point(548, 255)
        Me.lblaviso.Name = "lblaviso"
        Me.lblaviso.Size = New System.Drawing.Size(38, 14)
        Me.lblaviso.TabIndex = 392
        Me.lblaviso.Text = "Aviso"
        '
        'btnRemovFoto
        '
        Me.btnRemovFoto.BackColor = System.Drawing.Color.White
        Me.btnRemovFoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemovFoto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemovFoto.ForeColor = System.Drawing.Color.Black
        Me.btnRemovFoto.Image = Global.bink.My.Resources.Resources.deletar
        Me.btnRemovFoto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRemovFoto.Location = New System.Drawing.Point(708, 210)
        Me.btnRemovFoto.Name = "btnRemovFoto"
        Me.btnRemovFoto.Size = New System.Drawing.Size(86, 42)
        Me.btnRemovFoto.TabIndex = 386
        Me.btnRemovFoto.Tag = ""
        Me.btnRemovFoto.Text = "Excluir"
        Me.btnRemovFoto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemovFoto.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(888, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 16)
        Me.Label3.TabIndex = 391
        Me.Label3.Text = "Largura:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(888, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 390
        Me.Label2.Text = "Altura:"
        '
        'lblLargura
        '
        Me.lblLargura.AutoSize = True
        Me.lblLargura.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLargura.ForeColor = System.Drawing.Color.Blue
        Me.lblLargura.Location = New System.Drawing.Point(952, 172)
        Me.lblLargura.Name = "lblLargura"
        Me.lblLargura.Size = New System.Drawing.Size(50, 14)
        Me.lblLargura.TabIndex = 389
        Me.lblLargura.Text = "Largura"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PicFoto)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(545, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(337, 175)
        Me.GroupBox1.TabIndex = 387
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Imagem do logo da empresa:"
        '
        'PicFoto
        '
        Me.PicFoto.BackColor = System.Drawing.Color.White
        Me.PicFoto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicFoto.ErrorImage = Nothing
        Me.PicFoto.InitialImage = Nothing
        Me.PicFoto.Location = New System.Drawing.Point(3, 16)
        Me.PicFoto.Name = "PicFoto"
        Me.PicFoto.Size = New System.Drawing.Size(331, 156)
        Me.PicFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicFoto.TabIndex = 242
        Me.PicFoto.TabStop = False
        '
        'lblAltura
        '
        Me.lblAltura.AutoSize = True
        Me.lblAltura.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAltura.ForeColor = System.Drawing.Color.Blue
        Me.lblAltura.Location = New System.Drawing.Point(940, 142)
        Me.lblAltura.Name = "lblAltura"
        Me.lblAltura.Size = New System.Drawing.Size(40, 14)
        Me.lblAltura.TabIndex = 388
        Me.lblAltura.Text = "Altura"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(12, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 14)
        Me.Label6.TabIndex = 384
        Me.Label6.Text = "Razão Social*:"
        '
        'txtRazsocial
        '
        Me.txtRazsocial.AllowDrop = True
        Me.txtRazsocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRazsocial.ForeColor = System.Drawing.Color.Black
        Me.txtRazsocial.Location = New System.Drawing.Point(12, 30)
        Me.txtRazsocial.MaxLength = 100
        Me.txtRazsocial.Name = "txtRazsocial"
        Me.txtRazsocial.Size = New System.Drawing.Size(465, 21)
        Me.txtRazsocial.TabIndex = 383
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(12, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 14)
        Me.Label5.TabIndex = 382
        Me.Label5.Text = "Complemento:"
        '
        'txtComplemento
        '
        Me.txtComplemento.ForeColor = System.Drawing.Color.Black
        Me.txtComplemento.Location = New System.Drawing.Point(12, 190)
        Me.txtComplemento.MaxLength = 14
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(230, 21)
        Me.txtComplemento.TabIndex = 364
        '
        'txtNumero
        '
        Me.txtNumero.ForeColor = System.Drawing.Color.Black
        Me.txtNumero.Location = New System.Drawing.Point(485, 150)
        Me.txtNumero.MaxLength = 10
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(45, 21)
        Me.txtNumero.TabIndex = 363
        '
        'lblEmpresa
        '
        Me.lblEmpresa.AutoSize = True
        Me.lblEmpresa.BackColor = System.Drawing.Color.Transparent
        Me.lblEmpresa.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpresa.ForeColor = System.Drawing.Color.Black
        Me.lblEmpresa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblEmpresa.Location = New System.Drawing.Point(12, 54)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(79, 14)
        Me.lblEmpresa.TabIndex = 371
        Me.lblEmpresa.Text = "Nome fantasia:"
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.BackColor = System.Drawing.Color.Transparent
        Me.lblCidade.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCidade.ForeColor = System.Drawing.Color.Black
        Me.lblCidade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCidade.Location = New System.Drawing.Point(244, 214)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(43, 14)
        Me.lblCidade.TabIndex = 375
        Me.lblCidade.Text = "Cidade:"
        '
        'TxTEmpresa
        '
        Me.TxTEmpresa.AllowDrop = True
        Me.TxTEmpresa.ForeColor = System.Drawing.Color.Black
        Me.TxTEmpresa.Location = New System.Drawing.Point(12, 70)
        Me.TxTEmpresa.MaxLength = 100
        Me.TxTEmpresa.Name = "TxTEmpresa"
        Me.TxTEmpresa.Size = New System.Drawing.Size(230, 21)
        Me.TxTEmpresa.TabIndex = 359
        '
        'TxtCidade
        '
        Me.TxtCidade.ForeColor = System.Drawing.Color.Black
        Me.TxtCidade.Location = New System.Drawing.Point(247, 230)
        Me.TxtCidade.MaxLength = 100
        Me.TxtCidade.Name = "TxtCidade"
        Me.TxtCidade.Size = New System.Drawing.Size(230, 21)
        Me.TxtCidade.TabIndex = 367
        '
        'txtEndereco
        '
        Me.txtEndereco.ForeColor = System.Drawing.Color.Black
        Me.txtEndereco.Location = New System.Drawing.Point(248, 150)
        Me.txtEndereco.MaxLength = 100
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(230, 21)
        Me.txtEndereco.TabIndex = 362
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.BackColor = System.Drawing.Color.Transparent
        Me.lblNumero.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero.ForeColor = System.Drawing.Color.Black
        Me.lblNumero.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNumero.Location = New System.Drawing.Point(483, 134)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(22, 14)
        Me.lblNumero.TabIndex = 373
        Me.lblNumero.Text = "Nº:"
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.BackColor = System.Drawing.Color.Transparent
        Me.lblEndereco.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndereco.ForeColor = System.Drawing.Color.Black
        Me.lblEndereco.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblEndereco.Location = New System.Drawing.Point(244, 134)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(56, 14)
        Me.lblEndereco.TabIndex = 372
        Me.lblEndereco.Text = "Endereço:"
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.BackColor = System.Drawing.Color.Transparent
        Me.lblBairro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBairro.ForeColor = System.Drawing.Color.Black
        Me.lblBairro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblBairro.Location = New System.Drawing.Point(244, 173)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(39, 14)
        Me.lblBairro.TabIndex = 374
        Me.lblBairro.Text = "Bairro:"
        '
        'lblUf
        '
        Me.lblUf.AutoSize = True
        Me.lblUf.BackColor = System.Drawing.Color.Transparent
        Me.lblUf.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUf.ForeColor = System.Drawing.Color.Black
        Me.lblUf.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUf.Location = New System.Drawing.Point(483, 214)
        Me.lblUf.Name = "lblUf"
        Me.lblUf.Size = New System.Drawing.Size(23, 14)
        Me.lblUf.TabIndex = 376
        Me.lblUf.Text = "UF:"
        '
        'lbllocal
        '
        Me.lbllocal.AutoSize = True
        Me.lbllocal.BackColor = System.Drawing.Color.Transparent
        Me.lbllocal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllocal.ForeColor = System.Drawing.Color.Black
        Me.lbllocal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbllocal.Location = New System.Drawing.Point(12, 254)
        Me.lbllocal.Name = "lbllocal"
        Me.lbllocal.Size = New System.Drawing.Size(51, 14)
        Me.lbllocal.TabIndex = 381
        Me.lbllocal.Text = "Telefone:"
        '
        'txtCelular
        '
        Me.txtCelular.ForeColor = System.Drawing.Color.Black
        Me.txtCelular.Location = New System.Drawing.Point(13, 230)
        Me.txtCelular.MaxLength = 15
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(230, 21)
        Me.txtCelular.TabIndex = 366
        '
        'cboUF
        '
        Me.cboUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUF.ForeColor = System.Drawing.Color.Black
        Me.cboUF.FormattingEnabled = True
        Me.cboUF.ItemHeight = 13
        Me.cboUF.Items.AddRange(New Object() {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.cboUF.Location = New System.Drawing.Point(485, 230)
        Me.cboUF.MaxLength = 2
        Me.cboUF.Name = "cboUF"
        Me.cboUF.Size = New System.Drawing.Size(45, 21)
        Me.cboUF.TabIndex = 368
        '
        'TxTTelefone
        '
        Me.TxTTelefone.ForeColor = System.Drawing.Color.Black
        Me.TxTTelefone.Location = New System.Drawing.Point(12, 270)
        Me.TxTTelefone.MaxLength = 14
        Me.TxTTelefone.Name = "TxTTelefone"
        Me.TxTTelefone.Size = New System.Drawing.Size(230, 21)
        Me.TxTTelefone.TabIndex = 369
        '
        'txtBairro
        '
        Me.txtBairro.ForeColor = System.Drawing.Color.Black
        Me.txtBairro.Location = New System.Drawing.Point(248, 190)
        Me.txtBairro.MaxLength = 100
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(230, 21)
        Me.txtBairro.TabIndex = 365
        '
        'lblCep
        '
        Me.lblCep.AutoSize = True
        Me.lblCep.BackColor = System.Drawing.Color.Transparent
        Me.lblCep.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCep.ForeColor = System.Drawing.Color.Black
        Me.lblCep.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCep.Location = New System.Drawing.Point(245, 54)
        Me.lblCep.Name = "lblCep"
        Me.lblCep.Size = New System.Drawing.Size(29, 14)
        Me.lblCep.TabIndex = 377
        Me.lblCep.Text = "CEP:"
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.BackColor = System.Drawing.Color.Transparent
        Me.lblCelular.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCelular.ForeColor = System.Drawing.Color.Black
        Me.lblCelular.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCelular.Location = New System.Drawing.Point(11, 214)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(43, 14)
        Me.lblCelular.TabIndex = 380
        Me.lblCelular.Text = "Celular:"
        '
        'txtEmail
        '
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.Location = New System.Drawing.Point(247, 270)
        Me.txtEmail.MaxLength = 100
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(230, 21)
        Me.txtEmail.TabIndex = 370
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.Black
        Me.lblEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblEmail.Location = New System.Drawing.Point(245, 254)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(34, 14)
        Me.lblEmail.TabIndex = 379
        Me.lblEmail.Text = "Email:"
        '
        'txtcep
        '
        Me.txtcep.ForeColor = System.Drawing.Color.Black
        Me.txtcep.Location = New System.Drawing.Point(248, 70)
        Me.txtcep.MaxLength = 9
        Me.txtcep.Name = "txtcep"
        Me.txtcep.Size = New System.Drawing.Size(230, 21)
        Me.txtcep.TabIndex = 360
        '
        'lblCnpj
        '
        Me.lblCnpj.AutoSize = True
        Me.lblCnpj.BackColor = System.Drawing.Color.Transparent
        Me.lblCnpj.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCnpj.ForeColor = System.Drawing.Color.Black
        Me.lblCnpj.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCnpj.Location = New System.Drawing.Point(12, 134)
        Me.lblCnpj.Name = "lblCnpj"
        Me.lblCnpj.Size = New System.Drawing.Size(57, 14)
        Me.lblCnpj.TabIndex = 378
        Me.lblCnpj.Text = "CPF/CNPJ:"
        '
        'txtCnpj
        '
        Me.txtCnpj.ForeColor = System.Drawing.Color.Black
        Me.txtCnpj.Location = New System.Drawing.Point(12, 150)
        Me.txtCnpj.MaxLength = 18
        Me.txtCnpj.Name = "txtCnpj"
        Me.txtCnpj.Size = New System.Drawing.Size(230, 21)
        Me.txtCnpj.TabIndex = 361
        '
        'tpImagem
        '
        Me.tpImagem.Caption = "Aparência"
        Me.tpImagem.Name = "tpImagem"
        Me.tpImagem.Size = New System.Drawing.Size(1356, 588)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnSalvar, Me.BarButtonItem2, Me.btnLimpar, Me.btnExcluir, Me.btnSair})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 5
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rpInicio})
        Me.RibbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.RibbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.Size = New System.Drawing.Size(1356, 116)
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnSalvar
        '
        Me.btnSalvar.Caption = "Salvar"
        Me.btnSalvar.Id = 2
        Me.btnSalvar.ImageOptions.LargeImage = Global.bink.My.Resources.Resources.salvar
        Me.btnSalvar.Name = "btnSalvar"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Save And Close"
        Me.BarButtonItem2.Id = 3
        Me.BarButtonItem2.ImageOptions.ImageUri.Uri = "SaveAndClose"
        Me.BarButtonItem2.Name = "BarButtonItem2"
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
        Me.rpInicio.Text = "Cadastrar cliente"
        '
        'mainRibbonPageGroup
        '
        Me.mainRibbonPageGroup.AllowTextClipping = False
        Me.mainRibbonPageGroup.ItemLinks.Add(Me.btnSalvar)
        Me.mainRibbonPageGroup.ItemLinks.Add(Me.btnSair)
        Me.mainRibbonPageGroup.Name = "mainRibbonPageGroup"
        Me.mainRibbonPageGroup.ShowCaptionButton = False
        '
        'frmCadEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1356, 736)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(Me.tcEmpresa)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCadEmpresa"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de empresa"
        CType(Me.tcEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcEmpresa.ResumeLayout(False)
        Me.tpDadosEmpresa.ResumeLayout(False)
        Me.tpDadosEmpresa.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ImagemTbEscritorio As ImageList
    Friend WithEvents tcEmpresa As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents tpDadosEmpresa As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents Label5 As Label
    Friend WithEvents txtComplemento As TextBox
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents lblEmpresa As Label
    Friend WithEvents lblCidade As Label
    Friend WithEvents TxTEmpresa As TextBox
    Friend WithEvents TxtCidade As TextBox
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents lblNumero As Label
    Friend WithEvents lblEndereco As Label
    Friend WithEvents lblBairro As Label
    Friend WithEvents lblUf As Label
    Friend WithEvents lbllocal As Label
    Friend WithEvents txtCelular As TextBox
    Friend WithEvents cboUF As ComboBox
    Friend WithEvents TxTTelefone As TextBox
    Friend WithEvents txtBairro As TextBox
    Friend WithEvents lblCep As Label
    Friend WithEvents lblCelular As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtcep As TextBox
    Friend WithEvents lblCnpj As Label
    Friend WithEvents txtCnpj As TextBox
    Friend WithEvents tpImagem As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents Label6 As Label
    Friend WithEvents txtRazsocial As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIE As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbTipoEmpresa As ComboBox
    Private WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Private WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnLimpar As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnExcluir As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnSair As DevExpress.XtraBars.BarButtonItem
    Private WithEvents rpInicio As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents mainRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents Label4 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents lblaviso As Label
    Friend WithEvents btnRemovFoto As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblLargura As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PicFoto As PictureBox
    Friend WithEvents lblAltura As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cbPorte As ComboBox
    Friend WithEvents bgwCarregaLogo As System.ComponentModel.BackgroundWorker
End Class
