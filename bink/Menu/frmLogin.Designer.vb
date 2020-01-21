<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnConfig = New System.Windows.Forms.Button()
        Me.lblAvisoLogin = New System.Windows.Forms.Label()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.lblSenha = New System.Windows.Forms.Label()
        Me.TxTSenha = New System.Windows.Forms.TextBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.TxTLogin = New System.Windows.Forms.TextBox()
        Me.pbEntrada1 = New System.Windows.Forms.PictureBox()
        Me.pbEntrada = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.BgwCarregaLogin = New System.ComponentModel.BackgroundWorker()
        Me.BgwAtualiza = New System.ComponentModel.BackgroundWorker()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.pbEntrada1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnConfig)
        Me.Panel1.Controls.Add(Me.lblAvisoLogin)
        Me.Panel1.Controls.Add(Me.btnEntrar)
        Me.Panel1.Controls.Add(Me.lblSenha)
        Me.Panel1.Controls.Add(Me.TxTSenha)
        Me.Panel1.Controls.Add(Me.lblUsuario)
        Me.Panel1.Controls.Add(Me.TxTLogin)
        Me.Panel1.Controls.Add(Me.pbEntrada1)
        Me.Panel1.Controls.Add(Me.pbEntrada)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(491, 246)
        Me.Panel1.TabIndex = 220
        '
        'btnConfig
        '
        Me.btnConfig.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnConfig.BackColor = System.Drawing.Color.White
        Me.btnConfig.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfig.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnConfig.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfig.ForeColor = System.Drawing.Color.Black
        Me.btnConfig.Image = Global.bink.My.Resources.Resources.comexao
        Me.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConfig.Location = New System.Drawing.Point(379, 181)
        Me.btnConfig.Name = "btnConfig"
        Me.btnConfig.Size = New System.Drawing.Size(99, 39)
        Me.btnConfig.TabIndex = 218
        Me.btnConfig.Text = "Conexão"
        Me.btnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfig.UseVisualStyleBackColor = False
        '
        'lblAvisoLogin
        '
        Me.lblAvisoLogin.BackColor = System.Drawing.Color.Transparent
        Me.lblAvisoLogin.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblAvisoLogin.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvisoLogin.ForeColor = System.Drawing.Color.Red
        Me.lblAvisoLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAvisoLogin.Location = New System.Drawing.Point(0, 223)
        Me.lblAvisoLogin.Name = "lblAvisoLogin"
        Me.lblAvisoLogin.Size = New System.Drawing.Size(489, 21)
        Me.lblAvisoLogin.TabIndex = 217
        Me.lblAvisoLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEntrar
        '
        Me.btnEntrar.BackColor = System.Drawing.Color.White
        Me.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEntrar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnEntrar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntrar.ForeColor = System.Drawing.Color.Black
        Me.btnEntrar.Image = Global.bink.My.Resources.Resources.login
        Me.btnEntrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEntrar.Location = New System.Drawing.Point(253, 182)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(120, 39)
        Me.btnEntrar.TabIndex = 216
        Me.btnEntrar.Text = "Entrar"
        Me.btnEntrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEntrar.UseVisualStyleBackColor = False
        '
        'lblSenha
        '
        Me.lblSenha.AutoSize = True
        Me.lblSenha.BackColor = System.Drawing.Color.Transparent
        Me.lblSenha.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSenha.ForeColor = System.Drawing.Color.Black
        Me.lblSenha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSenha.Location = New System.Drawing.Point(250, 134)
        Me.lblSenha.Name = "lblSenha"
        Me.lblSenha.Size = New System.Drawing.Size(56, 18)
        Me.lblSenha.TabIndex = 204
        Me.lblSenha.Text = "Senha:"
        '
        'TxTSenha
        '
        Me.TxTSenha.BackColor = System.Drawing.Color.White
        Me.TxTSenha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxTSenha.Location = New System.Drawing.Point(253, 155)
        Me.TxTSenha.MaxLength = 50
        Me.TxTSenha.Name = "TxTSenha"
        Me.TxTSenha.Size = New System.Drawing.Size(225, 20)
        Me.TxTSenha.TabIndex = 2
        Me.TxTSenha.UseSystemPasswordChar = True
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblUsuario.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.Color.Black
        Me.lblUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUsuario.Location = New System.Drawing.Point(19, 133)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(72, 18)
        Me.lblUsuario.TabIndex = 203
        Me.lblUsuario.Text = "Usuário:"
        '
        'TxTLogin
        '
        Me.TxTLogin.BackColor = System.Drawing.Color.White
        Me.TxTLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxTLogin.Location = New System.Drawing.Point(22, 155)
        Me.TxTLogin.MaxLength = 50
        Me.TxTLogin.Name = "TxTLogin"
        Me.TxTLogin.Size = New System.Drawing.Size(225, 20)
        Me.TxTLogin.TabIndex = 1
        '
        'pbEntrada1
        '
        Me.pbEntrada1.Image = Global.bink.My.Resources.Resources.pfsystem
        Me.pbEntrada1.Location = New System.Drawing.Point(-1, -54)
        Me.pbEntrada1.Name = "pbEntrada1"
        Me.pbEntrada1.Size = New System.Drawing.Size(491, 240)
        Me.pbEntrada1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbEntrada1.TabIndex = 219
        Me.pbEntrada1.TabStop = False
        '
        'pbEntrada
        '
        Me.pbEntrada.Location = New System.Drawing.Point(145, 4)
        Me.pbEntrada.Name = "pbEntrada"
        Me.pbEntrada.Size = New System.Drawing.Size(161, 127)
        Me.pbEntrada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbEntrada.TabIndex = 220
        Me.pbEntrada.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.DimGray
        Me.lblTitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(491, 29)
        Me.lblTitle.TabIndex = 219
        Me.lblTitle.Text = "B-INK"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BgwCarregaLogin
        '
        '
        'BgwAtualiza
        '
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.Color.DimGray
        Me.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.ForeColor = System.Drawing.Color.Black
        Me.btnFechar.Location = New System.Drawing.Point(464, 4)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(26, 23)
        Me.btnFechar.TabIndex = 220
        Me.btnFechar.Text = "X"
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnEntrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 275)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogin"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login de acesso"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbEntrada1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblAvisoLogin As Label
    Friend WithEvents btnEntrar As Button
    Friend WithEvents lblSenha As Label
    Private WithEvents TxTSenha As TextBox
    Friend WithEvents lblUsuario As Label
    Private WithEvents TxTLogin As TextBox
    Public WithEvents lblTitle As Label
    Friend WithEvents BgwCarregaLogin As System.ComponentModel.BackgroundWorker
    Friend WithEvents BgwAtualiza As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnConfig As Button
    Friend WithEvents pbEntrada1 As PictureBox
    Friend WithEvents pbEntrada As PictureBox
    Friend WithEvents btnFechar As Button
End Class
