<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucPerfilUtilitario
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.gbEmpresa = New System.Windows.Forms.GroupBox()
        Me.gbUsuario = New System.Windows.Forms.GroupBox()
        Me.gbPerfil = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'gbEmpresa
        '
        Me.gbEmpresa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbEmpresa.Location = New System.Drawing.Point(3, 3)
        Me.gbEmpresa.Name = "gbEmpresa"
        Me.gbEmpresa.Size = New System.Drawing.Size(299, 233)
        Me.gbEmpresa.TabIndex = 0
        Me.gbEmpresa.TabStop = False
        Me.gbEmpresa.Text = "Empresa"
        '
        'gbUsuario
        '
        Me.gbUsuario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbUsuario.Location = New System.Drawing.Point(308, 3)
        Me.gbUsuario.Name = "gbUsuario"
        Me.gbUsuario.Size = New System.Drawing.Size(299, 233)
        Me.gbUsuario.TabIndex = 0
        Me.gbUsuario.TabStop = False
        Me.gbUsuario.Text = "Usuário"
        '
        'gbPerfil
        '
        Me.gbPerfil.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbPerfil.Location = New System.Drawing.Point(613, 3)
        Me.gbPerfil.Name = "gbPerfil"
        Me.gbPerfil.Size = New System.Drawing.Size(319, 233)
        Me.gbPerfil.TabIndex = 0
        Me.gbPerfil.TabStop = False
        Me.gbPerfil.Text = "Perfil"
        '
        'ucPerfilUtilitario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gbPerfil)
        Me.Controls.Add(Me.gbUsuario)
        Me.Controls.Add(Me.gbEmpresa)
        Me.Name = "ucPerfilUtilitario"
        Me.Size = New System.Drawing.Size(935, 502)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbEmpresa As GroupBox
    Friend WithEvents gbUsuario As GroupBox
    Friend WithEvents gbPerfil As GroupBox
End Class
