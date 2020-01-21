<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBanco
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
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLimpar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExcluir = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSair = New DevExpress.XtraBars.BarButtonItem()
        Me.rpInicio = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.mainRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRazSocial = New System.Windows.Forms.TextBox()
        Me.txtAbreviatura = New System.Windows.Forms.TextBox()
        Me.txtDg = New System.Windows.Forms.TextBox()
        Me.txtBanco = New System.Windows.Forms.TextBox()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.dgvConsultaBanco = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bgwCarregaBanco = New System.ComponentModel.BackgroundWorker()
        Me.colidbanco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colbanco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldigito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldescricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colabreviatura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colrazaobanco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.dgvConsultaBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.RibbonControl1.Size = New System.Drawing.Size(531, 116)
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
        Me.rpInicio.Text = "Cadastrar banco"
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
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtRazSocial)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtAbreviatura)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtDg)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtBanco)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtDescricao)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.dgvConsultaBanco)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.PictureBox1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(531, 352)
        Me.SplitContainerControl1.SplitterPosition = 139
        Me.SplitContainerControl1.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Razão social"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(283, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Abreviatura *"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Descrição *"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(122, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Digito"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Banco *"
        '
        'txtRazSocial
        '
        Me.txtRazSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRazSocial.Location = New System.Drawing.Point(6, 98)
        Me.txtRazSocial.Name = "txtRazSocial"
        Me.txtRazSocial.Size = New System.Drawing.Size(408, 21)
        Me.txtRazSocial.TabIndex = 5
        '
        'txtAbreviatura
        '
        Me.txtAbreviatura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAbreviatura.Location = New System.Drawing.Point(283, 59)
        Me.txtAbreviatura.Name = "txtAbreviatura"
        Me.txtAbreviatura.Size = New System.Drawing.Size(131, 21)
        Me.txtAbreviatura.TabIndex = 4
        '
        'txtDg
        '
        Me.txtDg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDg.Location = New System.Drawing.Point(125, 19)
        Me.txtDg.Name = "txtDg"
        Me.txtDg.Size = New System.Drawing.Size(70, 21)
        Me.txtDg.TabIndex = 2
        '
        'txtBanco
        '
        Me.txtBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBanco.Location = New System.Drawing.Point(6, 19)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(113, 21)
        Me.txtBanco.TabIndex = 1
        '
        'txtDescricao
        '
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Location = New System.Drawing.Point(6, 59)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(271, 21)
        Me.txtDescricao.TabIndex = 3
        '
        'dgvConsultaBanco
        '
        Me.dgvConsultaBanco.AllowUserToAddRows = False
        Me.dgvConsultaBanco.AllowUserToDeleteRows = False
        Me.dgvConsultaBanco.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvConsultaBanco.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvConsultaBanco.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.dgvConsultaBanco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsultaBanco.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colidbanco, Me.colbanco, Me.coldigito, Me.coldescricao, Me.colabreviatura, Me.colrazaobanco})
        Me.dgvConsultaBanco.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvConsultaBanco.EnableHeadersVisualStyles = False
        Me.dgvConsultaBanco.Location = New System.Drawing.Point(0, 0)
        Me.dgvConsultaBanco.Name = "dgvConsultaBanco"
        Me.dgvConsultaBanco.ReadOnly = True
        Me.dgvConsultaBanco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvConsultaBanco.Size = New System.Drawing.Size(531, 208)
        Me.dgvConsultaBanco.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.bink.My.Resources.Resources.spinner1
        Me.PictureBox1.Location = New System.Drawing.Point(218, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(95, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'bgwCarregaBanco
        '
        '
        'colidbanco
        '
        Me.colidbanco.HeaderText = "ID"
        Me.colidbanco.Name = "colidbanco"
        Me.colidbanco.ReadOnly = True
        Me.colidbanco.Visible = False
        Me.colidbanco.Width = 43
        '
        'colbanco
        '
        Me.colbanco.HeaderText = "Banco"
        Me.colbanco.Name = "colbanco"
        Me.colbanco.ReadOnly = True
        Me.colbanco.Width = 61
        '
        'coldigito
        '
        Me.coldigito.HeaderText = "Digito"
        Me.coldigito.Name = "coldigito"
        Me.coldigito.ReadOnly = True
        Me.coldigito.Visible = False
        Me.coldigito.Width = 59
        '
        'coldescricao
        '
        Me.coldescricao.HeaderText = "Descrição"
        Me.coldescricao.Name = "coldescricao"
        Me.coldescricao.ReadOnly = True
        Me.coldescricao.Width = 78
        '
        'colabreviatura
        '
        Me.colabreviatura.HeaderText = "Abreviatura"
        Me.colabreviatura.Name = "colabreviatura"
        Me.colabreviatura.ReadOnly = True
        Me.colabreviatura.Width = 89
        '
        'colrazaobanco
        '
        Me.colrazaobanco.HeaderText = "Razão social"
        Me.colrazaobanco.Name = "colrazaobanco"
        Me.colrazaobanco.ReadOnly = True
        Me.colrazaobanco.Width = 91
        '
        'frmBanco
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 468)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBanco"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Banco"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.dgvConsultaBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Private WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnLimpar As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnExcluir As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnSair As DevExpress.XtraBars.BarButtonItem
    Private WithEvents rpInicio As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents mainRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents dgvConsultaBanco As DataGridView
    Friend WithEvents txtDg As TextBox
    Friend WithEvents txtBanco As TextBox
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRazSocial As TextBox
    Friend WithEvents txtAbreviatura As TextBox
    Friend WithEvents bgwCarregaBanco As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents colidbanco As DataGridViewTextBoxColumn
    Friend WithEvents colbanco As DataGridViewTextBoxColumn
    Friend WithEvents coldigito As DataGridViewTextBoxColumn
    Friend WithEvents coldescricao As DataGridViewTextBoxColumn
    Friend WithEvents colabreviatura As DataGridViewTextBoxColumn
    Friend WithEvents colrazaobanco As DataGridViewTextBoxColumn
End Class
