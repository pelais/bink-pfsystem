<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServidor
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
        Me.PnAvisar = New System.Windows.Forms.Panel()
        Me.pbCon = New System.Windows.Forms.PictureBox()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.lblSenha = New System.Windows.Forms.Label()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.lblBanco = New System.Windows.Forms.Label()
        Me.txtServidor = New System.Windows.Forms.TextBox()
        Me.lblServidor = New System.Windows.Forms.Label()
        Me.txtBanco = New System.Windows.Forms.TextBox()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.bgwTestar = New System.ComponentModel.BackgroundWorker()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.PnAvisar.SuspendLayout()
        CType(Me.pbCon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnAvisar
        '
        Me.PnAvisar.BackColor = System.Drawing.Color.White
        Me.PnAvisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnAvisar.Controls.Add(Me.pbCon)
        Me.PnAvisar.Controls.Add(Me.BtnSalvar)
        Me.PnAvisar.Controls.Add(Me.lblSenha)
        Me.PnAvisar.Controls.Add(Me.BtnSair)
        Me.PnAvisar.Controls.Add(Me.lblLogin)
        Me.PnAvisar.Controls.Add(Me.txtSenha)
        Me.PnAvisar.Controls.Add(Me.lblBanco)
        Me.PnAvisar.Controls.Add(Me.txtServidor)
        Me.PnAvisar.Controls.Add(Me.lblServidor)
        Me.PnAvisar.Controls.Add(Me.txtBanco)
        Me.PnAvisar.Controls.Add(Me.txtLogin)
        Me.PnAvisar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnAvisar.ForeColor = System.Drawing.Color.Black
        Me.PnAvisar.Location = New System.Drawing.Point(0, 0)
        Me.PnAvisar.Name = "PnAvisar"
        Me.PnAvisar.Size = New System.Drawing.Size(579, 238)
        Me.PnAvisar.TabIndex = 211
        '
        'pbCon
        '
        Me.pbCon.BackColor = System.Drawing.Color.White
        Me.pbCon.Location = New System.Drawing.Point(328, 37)
        Me.pbCon.Name = "pbCon"
        Me.pbCon.Size = New System.Drawing.Size(180, 124)
        Me.pbCon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbCon.TabIndex = 207
        Me.pbCon.TabStop = False
        '
        'BtnSalvar
        '
        Me.BtnSalvar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnSalvar.BackColor = System.Drawing.Color.White
        Me.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalvar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSalvar.ForeColor = System.Drawing.Color.Black
        Me.BtnSalvar.Image = Global.bink.My.Resources.Resources.salvar
        Me.BtnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSalvar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnSalvar.Location = New System.Drawing.Point(295, 164)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(132, 40)
        Me.BtnSalvar.TabIndex = 4
        Me.BtnSalvar.Tag = ""
        Me.BtnSalvar.Text = "Testar / Salvar"
        Me.BtnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalvar.UseVisualStyleBackColor = False
        '
        'lblSenha
        '
        Me.lblSenha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSenha.AutoSize = True
        Me.lblSenha.BackColor = System.Drawing.Color.Transparent
        Me.lblSenha.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSenha.ForeColor = System.Drawing.Color.Black
        Me.lblSenha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSenha.Location = New System.Drawing.Point(8, 164)
        Me.lblSenha.Name = "lblSenha"
        Me.lblSenha.Size = New System.Drawing.Size(46, 15)
        Me.lblSenha.TabIndex = 206
        Me.lblSenha.Text = "Senha:"
        '
        'BtnSair
        '
        Me.BtnSair.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnSair.BackColor = System.Drawing.Color.White
        Me.BtnSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSair.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSair.ForeColor = System.Drawing.Color.Black
        Me.BtnSair.Image = Global.bink.My.Resources.Resources.sair
        Me.BtnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSair.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnSair.Location = New System.Drawing.Point(433, 164)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(84, 40)
        Me.BtnSair.TabIndex = 6
        Me.BtnSair.Text = "Fechar"
        Me.BtnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSair.UseVisualStyleBackColor = False
        '
        'lblLogin
        '
        Me.lblLogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLogin.AutoSize = True
        Me.lblLogin.BackColor = System.Drawing.Color.Transparent
        Me.lblLogin.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.Color.Black
        Me.lblLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLogin.Location = New System.Drawing.Point(8, 121)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(41, 15)
        Me.lblLogin.TabIndex = 205
        Me.lblLogin.Text = "Login:"
        '
        'txtSenha
        '
        Me.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSenha.Location = New System.Drawing.Point(11, 183)
        Me.txtSenha.MaxLength = 50
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.Size = New System.Drawing.Size(251, 21)
        Me.txtSenha.TabIndex = 3
        Me.txtSenha.UseSystemPasswordChar = True
        '
        'lblBanco
        '
        Me.lblBanco.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblBanco.AutoSize = True
        Me.lblBanco.BackColor = System.Drawing.Color.Transparent
        Me.lblBanco.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBanco.ForeColor = System.Drawing.Color.Black
        Me.lblBanco.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblBanco.Location = New System.Drawing.Point(8, 78)
        Me.lblBanco.Name = "lblBanco"
        Me.lblBanco.Size = New System.Drawing.Size(46, 15)
        Me.lblBanco.TabIndex = 204
        Me.lblBanco.Text = "Banco:"
        '
        'txtServidor
        '
        Me.txtServidor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtServidor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtServidor.Location = New System.Drawing.Point(11, 53)
        Me.txtServidor.MaxLength = 50
        Me.txtServidor.Name = "txtServidor"
        Me.txtServidor.Size = New System.Drawing.Size(251, 22)
        Me.txtServidor.TabIndex = 0
        '
        'lblServidor
        '
        Me.lblServidor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblServidor.AutoSize = True
        Me.lblServidor.BackColor = System.Drawing.Color.Transparent
        Me.lblServidor.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServidor.ForeColor = System.Drawing.Color.Black
        Me.lblServidor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblServidor.Location = New System.Drawing.Point(8, 34)
        Me.lblServidor.Name = "lblServidor"
        Me.lblServidor.Size = New System.Drawing.Size(58, 15)
        Me.lblServidor.TabIndex = 203
        Me.lblServidor.Text = "Servidor:"
        '
        'txtBanco
        '
        Me.txtBanco.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBanco.Location = New System.Drawing.Point(11, 97)
        Me.txtBanco.MaxLength = 50
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(251, 21)
        Me.txtBanco.TabIndex = 1
        '
        'txtLogin
        '
        Me.txtLogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtLogin.Location = New System.Drawing.Point(11, 140)
        Me.txtLogin.MaxLength = 50
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(251, 21)
        Me.txtLogin.TabIndex = 2
        '
        'bgwTestar
        '
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(579, 28)
        Me.lblTitle.TabIndex = 212
        Me.lblTitle.Text = "Configuração de Conexão"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTitle.Visible = False
        '
        'frmServidor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 238)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PnAvisar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmServidor"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Verifica conexão"
        Me.PnAvisar.ResumeLayout(False)
        Me.PnAvisar.PerformLayout()
        CType(Me.pbCon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnAvisar As Panel
    Friend WithEvents pbCon As PictureBox
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents lblSenha As Label
    Friend WithEvents BtnSair As Button
    Friend WithEvents lblLogin As Label
    Friend WithEvents txtSenha As TextBox
    Friend WithEvents lblBanco As Label
    Friend WithEvents txtServidor As TextBox
    Friend WithEvents lblServidor As Label
    Friend WithEvents txtBanco As TextBox
    Friend WithEvents txtLogin As TextBox
    Friend WithEvents bgwTestar As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblTitle As Label
End Class
