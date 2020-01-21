<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCadCliente
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
        Me.scCliente = New DevExpress.XtraEditors.SplitContainerControl()
        Me.tcCliente = New DevExpress.XtraBars.Navigation.TabPane()
        Me.tpDadosCliente = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.checkAtivo = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtObservacao = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbOcupacao = New System.Windows.Forms.ComboBox()
        Me.txtRg = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxTCep = New System.Windows.Forms.TextBox()
        Me.TxTCelular = New System.Windows.Forms.TextBox()
        Me.TxTTelefone = New System.Windows.Forms.TextBox()
        Me.txtDocumento = New System.Windows.Forms.TextBox()
        Me.dtpDataNasc = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtDataCadastro = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbSexo = New System.Windows.Forms.ComboBox()
        Me.label13 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.tpOutrasInformacoes = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLimpar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExcluir = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSair = New DevExpress.XtraBars.BarButtonItem()
        Me.rpInicio = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.mainRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.dgvConsultaCliente = New System.Windows.Forms.DataGridView()
        Me.colidcliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colnome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colrg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colsexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldtnasc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colendereco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colbairro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coluf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltelefone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcelular = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colobservacao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colocupacao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colemail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colativo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bgwCliente = New System.ComponentModel.BackgroundWorker()
        CType(Me.scCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scCliente.SuspendLayout()
        CType(Me.tcCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcCliente.SuspendLayout()
        Me.tpDadosCliente.SuspendLayout()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvConsultaCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'scCliente
        '
        Me.scCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scCliente.Horizontal = False
        Me.scCliente.Location = New System.Drawing.Point(0, 0)
        Me.scCliente.Name = "scCliente"
        Me.scCliente.Panel1.Controls.Add(Me.tcCliente)
        Me.scCliente.Panel1.Controls.Add(Me.RibbonControl1)
        Me.scCliente.Panel1.Text = "Panel1"
        Me.scCliente.Panel2.Controls.Add(Me.dgvConsultaCliente)
        Me.scCliente.Panel2.Controls.Add(Me.PictureBox1)
        Me.scCliente.Panel2.Text = "Panel2"
        Me.scCliente.Size = New System.Drawing.Size(1356, 736)
        Me.scCliente.SplitterPosition = 365
        Me.scCliente.TabIndex = 0
        '
        'tcCliente
        '
        Me.tcCliente.Controls.Add(Me.tpDadosCliente)
        Me.tcCliente.Controls.Add(Me.tpOutrasInformacoes)
        Me.tcCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcCliente.Location = New System.Drawing.Point(0, 116)
        Me.tcCliente.Name = "tcCliente"
        Me.tcCliente.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tpDadosCliente, Me.tpOutrasInformacoes})
        Me.tcCliente.RegularSize = New System.Drawing.Size(1356, 249)
        Me.tcCliente.SelectedPage = Me.tpOutrasInformacoes
        Me.tcCliente.Size = New System.Drawing.Size(1356, 249)
        Me.tcCliente.TabIndex = 351
        Me.tcCliente.Text = "TabPane1"
        '
        'tpDadosCliente
        '
        Me.tpDadosCliente.Caption = "Dados do Cliente"
        Me.tpDadosCliente.Controls.Add(Me.checkAtivo)
        Me.tpDadosCliente.Controls.Add(Me.Label8)
        Me.tpDadosCliente.Controls.Add(Me.txtObservacao)
        Me.tpDadosCliente.Controls.Add(Me.Label11)
        Me.tpDadosCliente.Controls.Add(Me.cmbOcupacao)
        Me.tpDadosCliente.Controls.Add(Me.txtRg)
        Me.tpDadosCliente.Controls.Add(Me.Label18)
        Me.tpDadosCliente.Controls.Add(Me.TxTCep)
        Me.tpDadosCliente.Controls.Add(Me.TxTCelular)
        Me.tpDadosCliente.Controls.Add(Me.TxTTelefone)
        Me.tpDadosCliente.Controls.Add(Me.txtDocumento)
        Me.tpDadosCliente.Controls.Add(Me.dtpDataNasc)
        Me.tpDadosCliente.Controls.Add(Me.Label15)
        Me.tpDadosCliente.Controls.Add(Me.dtDataCadastro)
        Me.tpDadosCliente.Controls.Add(Me.Label14)
        Me.tpDadosCliente.Controls.Add(Me.txtBairro)
        Me.tpDadosCliente.Controls.Add(Me.Label12)
        Me.tpDadosCliente.Controls.Add(Me.Label5)
        Me.tpDadosCliente.Controls.Add(Me.Label4)
        Me.tpDadosCliente.Controls.Add(Me.cbEstado)
        Me.tpDadosCliente.Controls.Add(Me.txtCidade)
        Me.tpDadosCliente.Controls.Add(Me.Label2)
        Me.tpDadosCliente.Controls.Add(Me.Label21)
        Me.tpDadosCliente.Controls.Add(Me.Label27)
        Me.tpDadosCliente.Controls.Add(Me.Label26)
        Me.tpDadosCliente.Controls.Add(Me.txtEndereco)
        Me.tpDadosCliente.Controls.Add(Me.Label25)
        Me.tpDadosCliente.Controls.Add(Me.txtEmail)
        Me.tpDadosCliente.Controls.Add(Me.Label3)
        Me.tpDadosCliente.Controls.Add(Me.cbSexo)
        Me.tpDadosCliente.Controls.Add(Me.label13)
        Me.tpDadosCliente.Controls.Add(Me.txtNome)
        Me.tpDadosCliente.Controls.Add(Me.label6)
        Me.tpDadosCliente.Name = "tpDadosCliente"
        Me.tpDadosCliente.Size = New System.Drawing.Size(1356, 222)
        '
        'checkAtivo
        '
        Me.checkAtivo.AutoSize = True
        Me.checkAtivo.BackColor = System.Drawing.Color.Transparent
        Me.checkAtivo.Checked = True
        Me.checkAtivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkAtivo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkAtivo.ForeColor = System.Drawing.Color.Red
        Me.checkAtivo.Location = New System.Drawing.Point(345, 194)
        Me.checkAtivo.Name = "checkAtivo"
        Me.checkAtivo.Size = New System.Drawing.Size(108, 17)
        Me.checkAtivo.TabIndex = 363
        Me.checkAtivo.Text = "CLIENTE ATIVO"
        Me.checkAtivo.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(591, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 380
        Me.Label8.Text = "Observações"
        '
        'txtObservacao
        '
        Me.txtObservacao.Location = New System.Drawing.Point(594, 24)
        Me.txtObservacao.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtObservacao.Size = New System.Drawing.Size(365, 177)
        Me.txtObservacao.TabIndex = 364
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(34, 172)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 13)
        Me.Label11.TabIndex = 379
        Me.Label11.Text = "Ocupação *"
        '
        'cmbOcupacao
        '
        Me.cmbOcupacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOcupacao.FormattingEnabled = True
        Me.cmbOcupacao.Items.AddRange(New Object() {"Advogado", "Administrador", "Atendente", "Bombeiro", "Caseiro ", "Cantor", "Caminhoneiro", "Dentista", "Desenhista", "Diagramador", "Eletricista", "Enfermeira", "Farmacêutico", "Fiscal", "Fisioterapeuta", "Gerente", "Guitarrista", "Gari", "Humorista", "Ilusionista", "Iluminador", "Jardineiro", "Juiz", "Lavadeira", "Médico", "Nadador", "Operador De Máquinas", "Professor", "Químico", "Radialista", "Sapateiro", "Secretária", "Superintendente", "Torneiro Mecânico", "Tratorista", "Ufólogo", "Vigia", "Vendedor", "Xerocador", "Zelador"})
        Me.cmbOcupacao.Location = New System.Drawing.Point(37, 188)
        Me.cmbOcupacao.Name = "cmbOcupacao"
        Me.cmbOcupacao.Size = New System.Drawing.Size(186, 21)
        Me.cmbOcupacao.TabIndex = 361
        '
        'txtRg
        '
        Me.txtRg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRg.ForeColor = System.Drawing.Color.Black
        Me.txtRg.Location = New System.Drawing.Point(454, 24)
        Me.txtRg.MaxLength = 14
        Me.txtRg.Name = "txtRg"
        Me.txtRg.Size = New System.Drawing.Size(135, 20)
        Me.txtRg.TabIndex = 350
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(451, 7)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(35, 13)
        Me.Label18.TabIndex = 378
        Me.Label18.Text = "RG *"
        '
        'TxTCep
        '
        Me.TxTCep.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxTCep.ForeColor = System.Drawing.Color.Black
        Me.TxTCep.Location = New System.Drawing.Point(250, 65)
        Me.TxTCep.MaxLength = 9
        Me.TxTCep.Name = "TxTCep"
        Me.TxTCep.Size = New System.Drawing.Size(117, 21)
        Me.TxTCep.TabIndex = 353
        '
        'TxTCelular
        '
        Me.TxTCelular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxTCelular.ForeColor = System.Drawing.Color.Black
        Me.TxTCelular.Location = New System.Drawing.Point(182, 148)
        Me.TxTCelular.MaxLength = 15
        Me.TxTCelular.Name = "TxTCelular"
        Me.TxTCelular.Size = New System.Drawing.Size(156, 21)
        Me.TxTCelular.TabIndex = 359
        '
        'TxTTelefone
        '
        Me.TxTTelefone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxTTelefone.ForeColor = System.Drawing.Color.Black
        Me.TxTTelefone.Location = New System.Drawing.Point(37, 148)
        Me.TxTTelefone.MaxLength = 14
        Me.TxTTelefone.Name = "TxTTelefone"
        Me.TxTTelefone.Size = New System.Drawing.Size(139, 21)
        Me.TxTTelefone.TabIndex = 358
        '
        'txtDocumento
        '
        Me.txtDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocumento.ForeColor = System.Drawing.Color.Black
        Me.txtDocumento.Location = New System.Drawing.Point(330, 24)
        Me.txtDocumento.MaxLength = 14
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Size = New System.Drawing.Size(118, 20)
        Me.txtDocumento.TabIndex = 349
        '
        'dtpDataNasc
        '
        Me.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataNasc.Location = New System.Drawing.Point(143, 65)
        Me.dtpDataNasc.MinDate = New Date(1940, 1, 1, 0, 0, 0, 0)
        Me.dtpDataNasc.Name = "dtpDataNasc"
        Me.dtpDataNasc.Size = New System.Drawing.Size(101, 21)
        Me.dtpDataNasc.TabIndex = 352
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(226, 172)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(101, 13)
        Me.Label15.TabIndex = 377
        Me.Label15.Text = "Data Cadastro *"
        '
        'dtDataCadastro
        '
        Me.dtDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDataCadastro.Location = New System.Drawing.Point(229, 189)
        Me.dtDataCadastro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtDataCadastro.Name = "dtDataCadastro"
        Me.dtDataCadastro.Size = New System.Drawing.Size(109, 21)
        Me.dtDataCadastro.TabIndex = 362
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(400, 89)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 13)
        Me.Label14.TabIndex = 376
        Me.Label14.Text = "Bairro *"
        '
        'txtBairro
        '
        Me.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBairro.Location = New System.Drawing.Point(403, 106)
        Me.txtBairro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(186, 21)
        Me.txtBairro.TabIndex = 357
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(327, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 375
        Me.Label12.Text = "CPF *"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(370, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 374
        Me.Label5.Text = "Cidade *"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(523, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 373
        Me.Label4.Text = "Estado *"
        '
        'cbEstado
        '
        Me.cbEstado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Items.AddRange(New Object() {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.cbEstado.Location = New System.Drawing.Point(526, 65)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(62, 21)
        Me.cbEstado.TabIndex = 355
        '
        'txtCidade
        '
        Me.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCidade.Location = New System.Drawing.Point(373, 65)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(147, 21)
        Me.txtCidade.TabIndex = 354
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(247, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 372
        Me.Label2.Text = "CEP *"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(140, 48)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(104, 13)
        Me.Label21.TabIndex = 371
        Me.Label21.Text = "Data Nascimento"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(179, 132)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(48, 13)
        Me.Label27.TabIndex = 370
        Me.Label27.Text = "Celular"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(34, 131)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(55, 13)
        Me.Label26.TabIndex = 369
        Me.Label26.Text = "Telefone"
        '
        'txtEndereco
        '
        Me.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEndereco.Location = New System.Drawing.Point(37, 106)
        Me.txtEndereco.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(360, 21)
        Me.txtEndereco.TabIndex = 356
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(34, 89)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(90, 13)
        Me.Label25.TabIndex = 368
        Me.Label25.Text = "Endereço/Nº *"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(344, 148)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEmail.MaxLength = 100
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(245, 21)
        Me.txtEmail.TabIndex = 360
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(341, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 367
        Me.Label3.Text = "E-mail *"
        '
        'cbSexo
        '
        Me.cbSexo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSexo.FormattingEnabled = True
        Me.cbSexo.Items.AddRange(New Object() {"Masculino", "Feminino", "Outros"})
        Me.cbSexo.Location = New System.Drawing.Point(37, 64)
        Me.cbSexo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbSexo.Name = "cbSexo"
        Me.cbSexo.Size = New System.Drawing.Size(100, 21)
        Me.cbSexo.TabIndex = 351
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label13.Location = New System.Drawing.Point(34, 48)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(47, 13)
        Me.label13.TabIndex = 366
        Me.label13.Text = "Sexo *"
        '
        'txtNome
        '
        Me.txtNome.BackColor = System.Drawing.Color.White
        Me.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.ForeColor = System.Drawing.Color.Black
        Me.txtNome.Location = New System.Drawing.Point(37, 24)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(287, 20)
        Me.txtNome.TabIndex = 348
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(34, 8)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(51, 13)
        Me.label6.TabIndex = 365
        Me.label6.Text = "Nome *"
        '
        'tpOutrasInformacoes
        '
        Me.tpOutrasInformacoes.Caption = "Dados Complementares"
        Me.tpOutrasInformacoes.Name = "tpOutrasInformacoes"
        Me.tpOutrasInformacoes.Size = New System.Drawing.Size(1356, 222)
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
        Me.btnSalvar.Caption = "Salvar / Alterar"
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
        Me.mainRibbonPageGroup.ItemLinks.Add(Me.btnLimpar)
        Me.mainRibbonPageGroup.ItemLinks.Add(Me.btnSalvar)
        Me.mainRibbonPageGroup.ItemLinks.Add(Me.btnExcluir)
        Me.mainRibbonPageGroup.ItemLinks.Add(Me.btnSair)
        Me.mainRibbonPageGroup.Name = "mainRibbonPageGroup"
        Me.mainRibbonPageGroup.ShowCaptionButton = False
        '
        'dgvConsultaCliente
        '
        Me.dgvConsultaCliente.AllowUserToAddRows = False
        Me.dgvConsultaCliente.AllowUserToDeleteRows = False
        Me.dgvConsultaCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvConsultaCliente.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.dgvConsultaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsultaCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colidcliente, Me.colnome, Me.coldocumento, Me.colrg, Me.colsexo, Me.coldtnasc, Me.colendereco, Me.colbairro, Me.colcidade, Me.coluf, Me.colcep, Me.coltelefone, Me.colcelular, Me.colobservacao, Me.colocupacao, Me.colemail, Me.colativo})
        Me.dgvConsultaCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvConsultaCliente.EnableHeadersVisualStyles = False
        Me.dgvConsultaCliente.Location = New System.Drawing.Point(0, 0)
        Me.dgvConsultaCliente.Name = "dgvConsultaCliente"
        Me.dgvConsultaCliente.ReadOnly = True
        Me.dgvConsultaCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvConsultaCliente.Size = New System.Drawing.Size(1356, 366)
        Me.dgvConsultaCliente.TabIndex = 1
        '
        'colidcliente
        '
        Me.colidcliente.HeaderText = "ID"
        Me.colidcliente.Name = "colidcliente"
        Me.colidcliente.ReadOnly = True
        Me.colidcliente.Visible = False
        Me.colidcliente.Width = 43
        '
        'colnome
        '
        Me.colnome.HeaderText = "Nome cliente"
        Me.colnome.Name = "colnome"
        Me.colnome.ReadOnly = True
        Me.colnome.Width = 93
        '
        'coldocumento
        '
        Me.coldocumento.HeaderText = "Documento"
        Me.coldocumento.Name = "coldocumento"
        Me.coldocumento.ReadOnly = True
        Me.coldocumento.Width = 86
        '
        'colrg
        '
        Me.colrg.HeaderText = "RG"
        Me.colrg.Name = "colrg"
        Me.colrg.ReadOnly = True
        Me.colrg.Width = 46
        '
        'colsexo
        '
        Me.colsexo.HeaderText = "Sexo"
        Me.colsexo.Name = "colsexo"
        Me.colsexo.ReadOnly = True
        Me.colsexo.Width = 56
        '
        'coldtnasc
        '
        Me.coldtnasc.HeaderText = "Data nasc."
        Me.coldtnasc.Name = "coldtnasc"
        Me.coldtnasc.ReadOnly = True
        Me.coldtnasc.Width = 84
        '
        'colendereco
        '
        Me.colendereco.HeaderText = "Endereço"
        Me.colendereco.Name = "colendereco"
        Me.colendereco.ReadOnly = True
        Me.colendereco.Width = 77
        '
        'colbairro
        '
        Me.colbairro.HeaderText = "Bairro"
        Me.colbairro.Name = "colbairro"
        Me.colbairro.ReadOnly = True
        Me.colbairro.Width = 60
        '
        'colcidade
        '
        Me.colcidade.HeaderText = "Cidade"
        Me.colcidade.Name = "colcidade"
        Me.colcidade.ReadOnly = True
        Me.colcidade.Width = 65
        '
        'coluf
        '
        Me.coluf.HeaderText = "Estado"
        Me.coluf.Name = "coluf"
        Me.coluf.ReadOnly = True
        Me.coluf.Width = 65
        '
        'colcep
        '
        Me.colcep.HeaderText = "CEP"
        Me.colcep.Name = "colcep"
        Me.colcep.ReadOnly = True
        Me.colcep.Width = 51
        '
        'coltelefone
        '
        Me.coltelefone.HeaderText = "Telefone"
        Me.coltelefone.Name = "coltelefone"
        Me.coltelefone.ReadOnly = True
        Me.coltelefone.Width = 74
        '
        'colcelular
        '
        Me.colcelular.HeaderText = "Celular"
        Me.colcelular.Name = "colcelular"
        Me.colcelular.ReadOnly = True
        Me.colcelular.Width = 65
        '
        'colobservacao
        '
        Me.colobservacao.HeaderText = "Observação"
        Me.colobservacao.Name = "colobservacao"
        Me.colobservacao.ReadOnly = True
        Me.colobservacao.Width = 90
        '
        'colocupacao
        '
        Me.colocupacao.HeaderText = "Ocupação"
        Me.colocupacao.Name = "colocupacao"
        Me.colocupacao.ReadOnly = True
        Me.colocupacao.Width = 80
        '
        'colemail
        '
        Me.colemail.HeaderText = "E-mail"
        Me.colemail.Name = "colemail"
        Me.colemail.ReadOnly = True
        Me.colemail.Width = 60
        '
        'colativo
        '
        Me.colativo.HeaderText = "Ativo"
        Me.colativo.Name = "colativo"
        Me.colativo.ReadOnly = True
        Me.colativo.Visible = False
        Me.colativo.Width = 57
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.bink.My.Resources.Resources.spinner1
        Me.PictureBox1.Location = New System.Drawing.Point(623, 139)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(111, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'bgwCliente
        '
        '
        'frmCadCliente
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1356, 736)
        Me.Controls.Add(Me.scCliente)
        Me.MaximizeBox = False
        Me.Name = "frmCadCliente"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de cliente"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.scCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scCliente.ResumeLayout(False)
        CType(Me.tcCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcCliente.ResumeLayout(False)
        Me.tpDadosCliente.ResumeLayout(False)
        Me.tpDadosCliente.PerformLayout()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvConsultaCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents scCliente As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents dgvConsultaCliente As DataGridView
    Private WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Private WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnLimpar As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnExcluir As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnSair As DevExpress.XtraBars.BarButtonItem
    Private WithEvents rpInicio As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents mainRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bgwCliente As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents colidcliente As DataGridViewTextBoxColumn
    Friend WithEvents colnome As DataGridViewTextBoxColumn
    Friend WithEvents coldocumento As DataGridViewTextBoxColumn
    Friend WithEvents colrg As DataGridViewTextBoxColumn
    Friend WithEvents colsexo As DataGridViewTextBoxColumn
    Friend WithEvents coldtnasc As DataGridViewTextBoxColumn
    Friend WithEvents colendereco As DataGridViewTextBoxColumn
    Friend WithEvents colbairro As DataGridViewTextBoxColumn
    Friend WithEvents colcidade As DataGridViewTextBoxColumn
    Friend WithEvents coluf As DataGridViewTextBoxColumn
    Friend WithEvents colcep As DataGridViewTextBoxColumn
    Friend WithEvents coltelefone As DataGridViewTextBoxColumn
    Friend WithEvents colcelular As DataGridViewTextBoxColumn
    Friend WithEvents colobservacao As DataGridViewTextBoxColumn
    Friend WithEvents colocupacao As DataGridViewTextBoxColumn
    Friend WithEvents colemail As DataGridViewTextBoxColumn
    Friend WithEvents colativo As DataGridViewTextBoxColumn
    Friend WithEvents tcCliente As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents tpDadosCliente As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents checkAtivo As CheckBox
    Private WithEvents Label8 As Label
    Friend WithEvents txtObservacao As TextBox
    Private WithEvents Label11 As Label
    Friend WithEvents cmbOcupacao As ComboBox
    Friend WithEvents txtRg As TextBox
    Private WithEvents Label18 As Label
    Friend WithEvents TxTCep As TextBox
    Friend WithEvents TxTCelular As TextBox
    Friend WithEvents TxTTelefone As TextBox
    Friend WithEvents txtDocumento As TextBox
    Friend WithEvents dtpDataNasc As DateTimePicker
    Private WithEvents Label15 As Label
    Friend WithEvents dtDataCadastro As DateTimePicker
    Private WithEvents Label14 As Label
    Friend WithEvents txtBairro As TextBox
    Private WithEvents Label12 As Label
    Private WithEvents Label5 As Label
    Private WithEvents Label4 As Label
    Friend WithEvents cbEstado As ComboBox
    Friend WithEvents txtCidade As TextBox
    Private WithEvents Label2 As Label
    Private WithEvents Label21 As Label
    Private WithEvents Label27 As Label
    Private WithEvents Label26 As Label
    Friend WithEvents txtEndereco As TextBox
    Private WithEvents Label25 As Label
    Friend WithEvents txtEmail As TextBox
    Private WithEvents Label3 As Label
    Friend WithEvents cbSexo As ComboBox
    Private WithEvents label13 As Label
    Friend WithEvents txtNome As TextBox
    Private WithEvents label6 As Label
    Friend WithEvents tpOutrasInformacoes As DevExpress.XtraBars.Navigation.TabNavigationPage
End Class
