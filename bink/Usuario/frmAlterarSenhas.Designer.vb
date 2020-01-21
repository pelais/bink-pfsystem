<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlterarSenhas
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
        Me.mrcPrincipal = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiSaveAndClose = New DevExpress.XtraBars.BarButtonItem()
        Me.btnIncluir = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExcluir = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSair = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.rpIncluir = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpgTrocaSenha = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.txtsenhaantiga = New System.Windows.Forms.TextBox()
        Me.lblusuario = New System.Windows.Forms.Label()
        Me.txtsenha = New System.Windows.Forms.TextBox()
        Me.lblSenha = New System.Windows.Forms.Label()
        Me.TxTcontrasenha = New System.Windows.Forms.TextBox()
        Me.lblRSenha = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.mrcPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mrcPrincipal
        '
        Me.mrcPrincipal.ExpandCollapseItem.Id = 0
        Me.mrcPrincipal.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.mrcPrincipal.ExpandCollapseItem, Me.btnSalvar, Me.bbiSaveAndClose, Me.btnIncluir, Me.btnExcluir, Me.btnSair, Me.BarButtonItem1})
        Me.mrcPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.mrcPrincipal.MaxItemId = 6
        Me.mrcPrincipal.Name = "mrcPrincipal"
        Me.mrcPrincipal.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rpIncluir})
        Me.mrcPrincipal.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.mrcPrincipal.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.mrcPrincipal.Size = New System.Drawing.Size(450, 116)
        Me.mrcPrincipal.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnSalvar
        '
        Me.btnSalvar.Caption = "Trocar senha"
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
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 5
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'rpIncluir
        '
        Me.rpIncluir.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgTrocaSenha})
        Me.rpIncluir.Name = "rpIncluir"
        '
        'rpgTrocaSenha
        '
        Me.rpgTrocaSenha.ItemLinks.Add(Me.btnSalvar, True)
        Me.rpgTrocaSenha.ItemLinks.Add(Me.btnSair, True)
        Me.rpgTrocaSenha.Name = "rpgTrocaSenha"
        '
        'txtsenhaantiga
        '
        Me.txtsenhaantiga.Location = New System.Drawing.Point(177, 180)
        Me.txtsenhaantiga.MaxLength = 50
        Me.txtsenhaantiga.Name = "txtsenhaantiga"
        Me.txtsenhaantiga.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtsenhaantiga.Size = New System.Drawing.Size(208, 21)
        Me.txtsenhaantiga.TabIndex = 137
        Me.txtsenhaantiga.UseSystemPasswordChar = True
        '
        'lblusuario
        '
        Me.lblusuario.AutoSize = True
        Me.lblusuario.BackColor = System.Drawing.Color.Transparent
        Me.lblusuario.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusuario.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblusuario.Location = New System.Drawing.Point(67, 135)
        Me.lblusuario.Name = "lblusuario"
        Me.lblusuario.Size = New System.Drawing.Size(158, 22)
        Me.lblusuario.TabIndex = 142
        Me.lblusuario.Tag = ""
        Me.lblusuario.Text = "Usuário logado:"
        '
        'txtsenha
        '
        Me.txtsenha.Location = New System.Drawing.Point(177, 216)
        Me.txtsenha.MaxLength = 50
        Me.txtsenha.Name = "txtsenha"
        Me.txtsenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtsenha.Size = New System.Drawing.Size(208, 21)
        Me.txtsenha.TabIndex = 138
        Me.txtsenha.UseSystemPasswordChar = True
        '
        'lblSenha
        '
        Me.lblSenha.AutoSize = True
        Me.lblSenha.BackColor = System.Drawing.Color.Transparent
        Me.lblSenha.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSenha.ForeColor = System.Drawing.Color.Black
        Me.lblSenha.Location = New System.Drawing.Point(76, 216)
        Me.lblSenha.Name = "lblSenha"
        Me.lblSenha.Size = New System.Drawing.Size(95, 17)
        Me.lblSenha.TabIndex = 140
        Me.lblSenha.Tag = ""
        Me.lblSenha.Text = "Nova senha*:"
        '
        'TxTcontrasenha
        '
        Me.TxTcontrasenha.Location = New System.Drawing.Point(177, 243)
        Me.TxTcontrasenha.MaxLength = 50
        Me.TxTcontrasenha.Name = "TxTcontrasenha"
        Me.TxTcontrasenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxTcontrasenha.Size = New System.Drawing.Size(208, 21)
        Me.TxTcontrasenha.TabIndex = 139
        Me.TxTcontrasenha.UseSystemPasswordChar = True
        '
        'lblRSenha
        '
        Me.lblRSenha.AutoSize = True
        Me.lblRSenha.BackColor = System.Drawing.Color.Transparent
        Me.lblRSenha.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRSenha.ForeColor = System.Drawing.Color.Black
        Me.lblRSenha.Location = New System.Drawing.Point(20, 243)
        Me.lblRSenha.Name = "lblRSenha"
        Me.lblRSenha.Size = New System.Drawing.Size(151, 17)
        Me.lblRSenha.TabIndex = 141
        Me.lblRSenha.Tag = ""
        Me.lblRSenha.Text = "Repita a nova senha*:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(68, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 17)
        Me.Label1.TabIndex = 144
        Me.Label1.Tag = ""
        Me.Label1.Text = "Senha antiga*:"
        '
        'frmAlterarSenhas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 302)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtsenhaantiga)
        Me.Controls.Add(Me.lblusuario)
        Me.Controls.Add(Me.txtsenha)
        Me.Controls.Add(Me.lblSenha)
        Me.Controls.Add(Me.TxTcontrasenha)
        Me.Controls.Add(Me.lblRSenha)
        Me.Controls.Add(Me.mrcPrincipal)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAlterarSenhas"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alterar senha de usuário"
        CType(Me.mrcPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents mrcPrincipal As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiSaveAndClose As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnIncluir As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnExcluir As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnSair As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpIncluir As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpgTrocaSenha As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents txtsenhaantiga As TextBox
    Friend WithEvents lblusuario As Label
    Friend WithEvents txtsenha As TextBox
    Friend WithEvents lblSenha As Label
    Friend WithEvents TxTcontrasenha As TextBox
    Friend WithEvents lblRSenha As Label
    Friend WithEvents Label1 As Label
End Class
