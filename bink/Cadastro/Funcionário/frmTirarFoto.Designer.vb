<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTirarFoto
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.gbFots = New System.Windows.Forms.GroupBox()
        Me.picCaptura = New System.Windows.Forms.PictureBox()
        Me.btnTirarFoto = New System.Windows.Forms.Button()
        Me.lstDispositivos = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.picCaptura2 = New System.Windows.Forms.PictureBox()
        Me.btnSalvar = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.gbFots.SuspendLayout()
        CType(Me.picCaptura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picCaptura2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnIniciar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.gbFots)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnTirarFoto)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lstDispositivos)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnSalvar)
        Me.SplitContainer1.Size = New System.Drawing.Size(630, 337)
        Me.SplitContainer1.SplitterDistance = 294
        Me.SplitContainer1.TabIndex = 35
        '
        'btnIniciar
        '
        Me.btnIniciar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnIniciar.BackColor = System.Drawing.Color.White
        Me.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIniciar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIniciar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnIniciar.Image = Global.bink.My.Resources.Resources.iniciar
        Me.btnIniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnIniciar.Location = New System.Drawing.Point(40, 242)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(98, 40)
        Me.btnIniciar.TabIndex = 63
        Me.btnIniciar.Text = "Iniciar"
        Me.btnIniciar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIniciar.UseVisualStyleBackColor = False
        '
        'gbFots
        '
        Me.gbFots.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.gbFots.Controls.Add(Me.picCaptura)
        Me.gbFots.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFots.ForeColor = System.Drawing.Color.Red
        Me.gbFots.Location = New System.Drawing.Point(65, 28)
        Me.gbFots.Name = "gbFots"
        Me.gbFots.Size = New System.Drawing.Size(163, 208)
        Me.gbFots.TabIndex = 61
        Me.gbFots.TabStop = False
        '
        'picCaptura
        '
        Me.picCaptura.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picCaptura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCaptura.ErrorImage = Nothing
        Me.picCaptura.InitialImage = Nothing
        Me.picCaptura.Location = New System.Drawing.Point(6, 15)
        Me.picCaptura.Name = "picCaptura"
        Me.picCaptura.Size = New System.Drawing.Size(151, 187)
        Me.picCaptura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCaptura.TabIndex = 0
        Me.picCaptura.TabStop = False
        '
        'btnTirarFoto
        '
        Me.btnTirarFoto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnTirarFoto.BackColor = System.Drawing.Color.White
        Me.btnTirarFoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTirarFoto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTirarFoto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnTirarFoto.Image = Global.bink.My.Resources.Resources.camera
        Me.btnTirarFoto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTirarFoto.Location = New System.Drawing.Point(144, 242)
        Me.btnTirarFoto.Name = "btnTirarFoto"
        Me.btnTirarFoto.Size = New System.Drawing.Size(107, 40)
        Me.btnTirarFoto.TabIndex = 28
        Me.btnTirarFoto.Text = "Tirar Foto"
        Me.btnTirarFoto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTirarFoto.UseVisualStyleBackColor = False
        '
        'lstDispositivos
        '
        Me.lstDispositivos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lstDispositivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDispositivos.ForeColor = System.Drawing.Color.Red
        Me.lstDispositivos.FormattingEnabled = True
        Me.lstDispositivos.Location = New System.Drawing.Point(4, 20)
        Me.lstDispositivos.Name = "lstDispositivos"
        Me.lstDispositivos.Size = New System.Drawing.Size(36, 30)
        Me.lstDispositivos.TabIndex = 32
        Me.lstDispositivos.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.picCaptura2)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(84, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(163, 208)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        '
        'picCaptura2
        '
        Me.picCaptura2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picCaptura2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCaptura2.ErrorImage = Nothing
        Me.picCaptura2.InitialImage = Nothing
        Me.picCaptura2.Location = New System.Drawing.Point(6, 14)
        Me.picCaptura2.Name = "picCaptura2"
        Me.picCaptura2.Size = New System.Drawing.Size(151, 187)
        Me.picCaptura2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCaptura2.TabIndex = 0
        Me.picCaptura2.TabStop = False
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSalvar.BackColor = System.Drawing.Color.White
        Me.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnSalvar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSalvar.Image = Global.bink.My.Resources.Resources.salvar
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.Location = New System.Drawing.Point(84, 242)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(163, 40)
        Me.btnSalvar.TabIndex = 29
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'frmTirarFoto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 337)
        Me.Controls.Add(Me.SplitContainer1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTirarFoto"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tirar foto"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.gbFots.ResumeLayout(False)
        CType(Me.picCaptura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.picCaptura2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents btnIniciar As Button
    Friend WithEvents gbFots As GroupBox
    Friend WithEvents picCaptura As PictureBox
    Friend WithEvents btnTirarFoto As Button
    Friend WithEvents lstDispositivos As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents picCaptura2 As PictureBox
    Friend WithEvents btnSalvar As Button
End Class
