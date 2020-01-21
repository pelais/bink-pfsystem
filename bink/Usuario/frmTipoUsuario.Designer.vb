<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTipoUsuario
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.mainRibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiSaveAndClose = New DevExpress.XtraBars.BarButtonItem()
        Me.btnIncluir = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExcluir = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSair = New DevExpress.XtraBars.BarButtonItem()
        Me.rpInicio = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.mainRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.bgwCarregaPerfil = New System.ComponentModel.BackgroundWorker()
        Me.dgvPerfil = New System.Windows.Forms.DataGridView()
        Me.colidperfil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colnomeperfil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gpInfo = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPerfil = New System.Windows.Forms.TextBox()
        CType(Me.mainRibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpInfo.SuspendLayout()
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
        Me.mainRibbonControl.Size = New System.Drawing.Size(466, 116)
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
        'bgwCarregaPerfil
        '
        '
        'dgvPerfil
        '
        Me.dgvPerfil.AllowUserToAddRows = False
        Me.dgvPerfil.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.dgvPerfil.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPerfil.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPerfil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvPerfil.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvPerfil.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.dgvPerfil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPerfil.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colidperfil, Me.colnomeperfil})
        Me.dgvPerfil.EnableHeadersVisualStyles = False
        Me.dgvPerfil.Location = New System.Drawing.Point(0, 221)
        Me.dgvPerfil.MultiSelect = False
        Me.dgvPerfil.Name = "dgvPerfil"
        Me.dgvPerfil.ReadOnly = True
        Me.dgvPerfil.RowHeadersVisible = False
        Me.dgvPerfil.RowHeadersWidth = 30
        Me.dgvPerfil.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPerfil.Size = New System.Drawing.Size(466, 253)
        Me.dgvPerfil.TabIndex = 126
        '
        'colidperfil
        '
        Me.colidperfil.FillWeight = 150.0!
        Me.colidperfil.HeaderText = "id"
        Me.colidperfil.Name = "colidperfil"
        Me.colidperfil.ReadOnly = True
        Me.colidperfil.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colidperfil.Visible = False
        Me.colidperfil.Width = 21
        '
        'colnomeperfil
        '
        Me.colnomeperfil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colnomeperfil.FillWeight = 300.0!
        Me.colnomeperfil.HeaderText = "Perfil"
        Me.colnomeperfil.Name = "colnomeperfil"
        Me.colnomeperfil.ReadOnly = True
        '
        'gpInfo
        '
        Me.gpInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpInfo.Controls.Add(Me.Label1)
        Me.gpInfo.Controls.Add(Me.txtPerfil)
        Me.gpInfo.Location = New System.Drawing.Point(0, 122)
        Me.gpInfo.Name = "gpInfo"
        Me.gpInfo.Size = New System.Drawing.Size(466, 93)
        Me.gpInfo.TabIndex = 127
        Me.gpInfo.TabStop = False
        Me.gpInfo.Text = "Informações do perfil"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(49, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 14)
        Me.Label1.TabIndex = 138
        Me.Label1.Tag = ""
        Me.Label1.Text = "Perfil:"
        '
        'txtPerfil
        '
        Me.txtPerfil.Location = New System.Drawing.Point(89, 45)
        Me.txtPerfil.MaxLength = 30
        Me.txtPerfil.Name = "txtPerfil"
        Me.txtPerfil.Size = New System.Drawing.Size(271, 21)
        Me.txtPerfil.TabIndex = 137
        '
        'frmTipoUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 474)
        Me.Controls.Add(Me.gpInfo)
        Me.Controls.Add(Me.dgvPerfil)
        Me.Controls.Add(Me.mainRibbonControl)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTipoUsuario"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de perfil de usuário"
        CType(Me.mainRibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpInfo.ResumeLayout(False)
        Me.gpInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents mainRibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiSaveAndClose As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnIncluir As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnExcluir As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnSair As DevExpress.XtraBars.BarButtonItem
    Private WithEvents rpInicio As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents mainRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bgwCarregaPerfil As System.ComponentModel.BackgroundWorker
    Friend WithEvents dgvPerfil As DataGridView
    Friend WithEvents gpInfo As GroupBox
    Friend WithEvents colidperfil As DataGridViewTextBoxColumn
    Friend WithEvents colnomeperfil As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPerfil As TextBox
End Class
