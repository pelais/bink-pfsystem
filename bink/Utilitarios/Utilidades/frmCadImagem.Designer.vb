<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCadImagem
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLimpar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExcluir = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSair = New DevExpress.XtraBars.BarButtonItem()
        Me.rpInicio = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.mainRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.dgvImagem = New System.Windows.Forms.DataGridView()
        Me.colidfoto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldescricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colfoto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gpImagem = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNomeFoto = New System.Windows.Forms.TextBox()
        Me.PicFoto = New System.Windows.Forms.PictureBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnRemovFoto = New System.Windows.Forms.Button()
        Me.bgwCarregaImagem = New System.ComponentModel.BackgroundWorker()
        Me.picCarrega = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpImagem.SuspendLayout()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCarrega, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.RibbonControl1.Size = New System.Drawing.Size(751, 116)
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
        Me.rpInicio.Text = "Cadastrar Imagem"
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
        'dgvImagem
        '
        Me.dgvImagem.AllowUserToAddRows = False
        Me.dgvImagem.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        Me.dgvImagem.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvImagem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvImagem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvImagem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvImagem.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.dgvImagem.CausesValidation = False
        Me.dgvImagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvImagem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colidfoto, Me.coldescricao, Me.colfoto})
        Me.dgvImagem.EnableHeadersVisualStyles = False
        Me.dgvImagem.Location = New System.Drawing.Point(0, 122)
        Me.dgvImagem.Name = "dgvImagem"
        Me.dgvImagem.ReadOnly = True
        Me.dgvImagem.RowHeadersVisible = False
        Me.dgvImagem.RowHeadersWidth = 30
        Me.dgvImagem.Size = New System.Drawing.Size(349, 329)
        Me.dgvImagem.TabIndex = 2
        '
        'colidfoto
        '
        Me.colidfoto.HeaderText = "idlog"
        Me.colidfoto.Name = "colidfoto"
        Me.colidfoto.ReadOnly = True
        Me.colidfoto.Visible = False
        '
        'coldescricao
        '
        Me.coldescricao.HeaderText = "DESCRIÇÃO"
        Me.coldescricao.Name = "coldescricao"
        Me.coldescricao.ReadOnly = True
        '
        'colfoto
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colfoto.DefaultCellStyle = DataGridViewCellStyle2
        Me.colfoto.HeaderText = "IMAGEM"
        Me.colfoto.Name = "colfoto"
        Me.colfoto.ReadOnly = True
        Me.colfoto.Visible = False
        '
        'gpImagem
        '
        Me.gpImagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpImagem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.gpImagem.Controls.Add(Me.Label1)
        Me.gpImagem.Controls.Add(Me.txtNomeFoto)
        Me.gpImagem.Controls.Add(Me.PicFoto)
        Me.gpImagem.Controls.Add(Me.btnBuscar)
        Me.gpImagem.Controls.Add(Me.btnRemovFoto)
        Me.gpImagem.Location = New System.Drawing.Point(355, 122)
        Me.gpImagem.Name = "gpImagem"
        Me.gpImagem.Size = New System.Drawing.Size(396, 329)
        Me.gpImagem.TabIndex = 4
        Me.gpImagem.TabStop = False
        Me.gpImagem.Text = "Imagem"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 236)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 391
        Me.Label1.Text = "Descrição*:"
        '
        'txtNomeFoto
        '
        Me.txtNomeFoto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNomeFoto.Location = New System.Drawing.Point(6, 252)
        Me.txtNomeFoto.Name = "txtNomeFoto"
        Me.txtNomeFoto.Size = New System.Drawing.Size(260, 21)
        Me.txtNomeFoto.TabIndex = 390
        '
        'PicFoto
        '
        Me.PicFoto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicFoto.BackColor = System.Drawing.Color.White
        Me.PicFoto.ErrorImage = Nothing
        Me.PicFoto.InitialImage = Nothing
        Me.PicFoto.Location = New System.Drawing.Point(6, 20)
        Me.PicFoto.Name = "PicFoto"
        Me.PicFoto.Size = New System.Drawing.Size(384, 213)
        Me.PicFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicFoto.TabIndex = 387
        Me.PicFoto.TabStop = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.White
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.Black
        Me.btnBuscar.Image = Global.bink.My.Resources.Resources.lupa
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.Location = New System.Drawing.Point(6, 279)
        Me.btnBuscar.MaximumSize = New System.Drawing.Size(151, 42)
        Me.btnBuscar.MinimumSize = New System.Drawing.Size(151, 42)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(151, 42)
        Me.btnBuscar.TabIndex = 388
        Me.btnBuscar.Text = "Procurar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnRemovFoto
        '
        Me.btnRemovFoto.BackColor = System.Drawing.Color.White
        Me.btnRemovFoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemovFoto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemovFoto.ForeColor = System.Drawing.Color.Black
        Me.btnRemovFoto.Image = Global.bink.My.Resources.Resources.lixeira
        Me.btnRemovFoto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRemovFoto.Location = New System.Drawing.Point(163, 279)
        Me.btnRemovFoto.Name = "btnRemovFoto"
        Me.btnRemovFoto.Size = New System.Drawing.Size(103, 42)
        Me.btnRemovFoto.TabIndex = 389
        Me.btnRemovFoto.Tag = ""
        Me.btnRemovFoto.Text = "Remover"
        Me.btnRemovFoto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemovFoto.UseVisualStyleBackColor = False
        '
        'bgwCarregaImagem
        '
        '
        'picCarrega
        '
        Me.picCarrega.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picCarrega.Image = Global.bink.My.Resources.Resources.spinner1
        Me.picCarrega.Location = New System.Drawing.Point(104, 252)
        Me.picCarrega.Name = "picCarrega"
        Me.picCarrega.Size = New System.Drawing.Size(103, 95)
        Me.picCarrega.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCarrega.TabIndex = 6
        Me.picCarrega.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(118, 350)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Carregando..."
        '
        'frmCadImagem
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 451)
        Me.Controls.Add(Me.gpImagem)
        Me.Controls.Add(Me.dgvImagem)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.picCarrega)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCadImagem"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastrar Imagens"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvImagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpImagem.ResumeLayout(False)
        Me.gpImagem.PerformLayout()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCarrega, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgvImagem As DataGridView
    Friend WithEvents gpImagem As GroupBox
    Friend WithEvents PicFoto As PictureBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnRemovFoto As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNomeFoto As TextBox
    Friend WithEvents colidfoto As DataGridViewTextBoxColumn
    Friend WithEvents coldescricao As DataGridViewTextBoxColumn
    Friend WithEvents colfoto As DataGridViewTextBoxColumn
    Friend WithEvents bgwCarregaImagem As System.ComponentModel.BackgroundWorker
    Friend WithEvents picCarrega As PictureBox
    Friend WithEvents Label2 As Label
End Class
