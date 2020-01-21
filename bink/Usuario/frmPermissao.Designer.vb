<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPermissao
    Inherits DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.FluentDesignFormControl1 = New DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl()
        Me.AccordionContentContainer1 = New DevExpress.XtraBars.Navigation.AccordionContentContainer()
        Me.tcPerfil = New DevExpress.XtraBars.Navigation.TabPane()
        Me.tpCadastro = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.tpFinanceiro = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.tpUtilitarios = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.UcPerfilUtilitario1 = New bink.ucPerfilUtilitario()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbonivelusuario = New System.Windows.Forms.ComboBox()
        Me.mainRibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiSaveAndClose = New DevExpress.XtraBars.BarButtonItem()
        Me.btnIncluir = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExcluir = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSair = New DevExpress.XtraBars.BarButtonItem()
        Me.rpInicio = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.mainRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        CType(Me.FluentDesignFormControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tcPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcPerfil.SuspendLayout()
        Me.tpUtilitarios.SuspendLayout()
        CType(Me.mainRibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FluentDesignFormControl1
        '
        Me.FluentDesignFormControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FluentDesignFormControl1.FluentDesignForm = Me
        Me.FluentDesignFormControl1.Location = New System.Drawing.Point(0, 0)
        Me.FluentDesignFormControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.FluentDesignFormControl1.Name = "FluentDesignFormControl1"
        Me.FluentDesignFormControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FluentDesignFormControl1.Size = New System.Drawing.Size(988, 27)
        Me.FluentDesignFormControl1.TabIndex = 2
        Me.FluentDesignFormControl1.TabStop = False
        '
        'AccordionContentContainer1
        '
        Me.AccordionContentContainer1.Name = "AccordionContentContainer1"
        Me.AccordionContentContainer1.Size = New System.Drawing.Size(260, 76)
        Me.AccordionContentContainer1.TabIndex = 0
        '
        'tcPerfil
        '
        Me.tcPerfil.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tcPerfil.Controls.Add(Me.tpCadastro)
        Me.tcPerfil.Controls.Add(Me.tpFinanceiro)
        Me.tcPerfil.Controls.Add(Me.tpUtilitarios)
        Me.tcPerfil.Location = New System.Drawing.Point(0, 176)
        Me.tcPerfil.Name = "tcPerfil"
        Me.tcPerfil.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText
        Me.tcPerfil.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tpCadastro, Me.tpFinanceiro, Me.tpUtilitarios})
        Me.tcPerfil.RegularSize = New System.Drawing.Size(988, 345)
        Me.tcPerfil.SelectedPage = Me.tpFinanceiro
        Me.tcPerfil.Size = New System.Drawing.Size(988, 345)
        Me.tcPerfil.TabIndex = 3
        Me.tcPerfil.Text = "TabPane1"
        '
        'tpCadastro
        '
        Me.tpCadastro.Caption = "Cadastro"
        Me.tpCadastro.ImageOptions.Image = Global.bink.My.Resources.Resources.perfil_cadastro
        Me.tpCadastro.Name = "tpCadastro"
        Me.tpCadastro.Size = New System.Drawing.Size(988, 337)
        '
        'tpFinanceiro
        '
        Me.tpFinanceiro.Caption = "Financeiro"
        Me.tpFinanceiro.ImageOptions.Image = Global.bink.My.Resources.Resources.perfil_financeiro
        Me.tpFinanceiro.Name = "tpFinanceiro"
        Me.tpFinanceiro.Size = New System.Drawing.Size(988, 315)
        '
        'tpUtilitarios
        '
        Me.tpUtilitarios.Caption = "Utilitários"
        Me.tpUtilitarios.Controls.Add(Me.UcPerfilUtilitario1)
        Me.tpUtilitarios.ImageOptions.Image = Global.bink.My.Resources.Resources.perfil_utilitario
        Me.tpUtilitarios.Name = "tpUtilitarios"
        Me.tpUtilitarios.Size = New System.Drawing.Size(988, 463)
        '
        'UcPerfilUtilitario1
        '
        Me.UcPerfilUtilitario1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPerfilUtilitario1.Location = New System.Drawing.Point(0, 0)
        Me.UcPerfilUtilitario1.Name = "UcPerfilUtilitario1"
        Me.UcPerfilUtilitario1.Size = New System.Drawing.Size(988, 461)
        Me.UcPerfilUtilitario1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Selecione o perfil:"
        '
        'cbonivelusuario
        '
        Me.cbonivelusuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbonivelusuario.FormattingEnabled = True
        Me.cbonivelusuario.Location = New System.Drawing.Point(110, 149)
        Me.cbonivelusuario.Name = "cbonivelusuario"
        Me.cbonivelusuario.Size = New System.Drawing.Size(200, 21)
        Me.cbonivelusuario.TabIndex = 6
        '
        'mainRibbonControl
        '
        Me.mainRibbonControl.ExpandCollapseItem.Id = 0
        Me.mainRibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.mainRibbonControl.ExpandCollapseItem, Me.btnSalvar, Me.bbiSaveAndClose, Me.btnIncluir, Me.btnExcluir, Me.btnSair})
        Me.mainRibbonControl.Location = New System.Drawing.Point(0, 27)
        Me.mainRibbonControl.MaxItemId = 5
        Me.mainRibbonControl.Name = "mainRibbonControl"
        Me.mainRibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rpInicio})
        Me.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.mainRibbonControl.Size = New System.Drawing.Size(988, 116)
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
        'frmPermissao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 520)
        Me.Controls.Add(Me.mainRibbonControl)
        Me.Controls.Add(Me.cbonivelusuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tcPerfil)
        Me.Controls.Add(Me.FluentDesignFormControl1)
        Me.FluentDesignFormControl = Me.FluentDesignFormControl1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmPermissao"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Perfil de usuário"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.FluentDesignFormControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tcPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcPerfil.ResumeLayout(False)
        Me.tpUtilitarios.ResumeLayout(False)
        CType(Me.mainRibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FluentDesignFormControl1 As DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl
    Friend WithEvents AccordionContentContainer1 As DevExpress.XtraBars.Navigation.AccordionContentContainer
    Friend WithEvents tcPerfil As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents tpCadastro As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents tpFinanceiro As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents tpUtilitarios As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents UcPerfilUtilitario1 As ucPerfilUtilitario
    Friend WithEvents Label1 As Label
    Friend WithEvents cbonivelusuario As ComboBox
    Private WithEvents mainRibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiSaveAndClose As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnIncluir As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnExcluir As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnSair As DevExpress.XtraBars.BarButtonItem
    Private WithEvents mainRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents rpInicio As DevExpress.XtraBars.Ribbon.RibbonPage
End Class
