<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLog
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.splitContainer = New DevExpress.XtraEditors.SplitContainerControl()
        Me.lblBusca = New System.Windows.Forms.Label()
        Me.TxTBusca = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.DgvConsUsuário = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BgwCarregaAcessoUsuario = New System.ComponentModel.BackgroundWorker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.splitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer.SuspendLayout()
        CType(Me.DgvConsUsuário, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'splitContainer
        '
        Me.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer.Horizontal = False
        Me.splitContainer.Location = New System.Drawing.Point(0, 0)
        Me.splitContainer.Name = "splitContainer"
        Me.splitContainer.Panel1.Controls.Add(Me.lblBusca)
        Me.splitContainer.Panel1.Controls.Add(Me.TxTBusca)
        Me.splitContainer.Panel1.Controls.Add(Me.btnBuscar)
        Me.splitContainer.Panel1.Text = "Panel1"
        Me.splitContainer.Panel2.Controls.Add(Me.DgvConsUsuário)
        Me.splitContainer.Panel2.Controls.Add(Me.PictureBox1)
        Me.splitContainer.Panel2.Text = "Panel2"
        Me.splitContainer.Size = New System.Drawing.Size(922, 480)
        Me.splitContainer.SplitterPosition = 96
        Me.splitContainer.TabIndex = 0
        '
        'lblBusca
        '
        Me.lblBusca.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblBusca.AutoSize = True
        Me.lblBusca.BackColor = System.Drawing.Color.Transparent
        Me.lblBusca.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusca.ForeColor = System.Drawing.Color.Black
        Me.lblBusca.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblBusca.Location = New System.Drawing.Point(238, 50)
        Me.lblBusca.Name = "lblBusca"
        Me.lblBusca.Size = New System.Drawing.Size(99, 14)
        Me.lblBusca.TabIndex = 1005
        Me.lblBusca.Text = "Busca por usuário:"
        '
        'TxTBusca
        '
        Me.TxTBusca.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TxTBusca.Location = New System.Drawing.Point(339, 47)
        Me.TxTBusca.MaxLength = 100
        Me.TxTBusca.Name = "TxTBusca"
        Me.TxTBusca.Size = New System.Drawing.Size(220, 21)
        Me.TxTBusca.TabIndex = 1003
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnBuscar.BackColor = System.Drawing.Color.White
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.Black
        Me.btnBuscar.Image = Global.bink.My.Resources.Resources.lupa
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.Location = New System.Drawing.Point(563, 40)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(68, 32)
        Me.btnBuscar.TabIndex = 1004
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'DgvConsUsuário
        '
        Me.DgvConsUsuário.AllowUserToAddRows = False
        Me.DgvConsUsuário.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        Me.DgvConsUsuário.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvConsUsuário.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvConsUsuário.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DgvConsUsuário.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvConsUsuário.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.DgvConsUsuário.CausesValidation = False
        Me.DgvConsUsuário.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvConsUsuário.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column8, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DgvConsUsuário.EnableHeadersVisualStyles = False
        Me.DgvConsUsuário.Location = New System.Drawing.Point(3, 21)
        Me.DgvConsUsuário.Name = "DgvConsUsuário"
        Me.DgvConsUsuário.ReadOnly = True
        Me.DgvConsUsuário.RowHeadersVisible = False
        Me.DgvConsUsuário.RowHeadersWidth = 30
        Me.DgvConsUsuário.Size = New System.Drawing.Size(919, 355)
        Me.DgvConsUsuário.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "idlog"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        Me.Column1.Width = 35
        '
        'Column8
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Column8.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column8.HeaderText = "USUÁRIO"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 78
        '
        'Column3
        '
        Me.Column3.HeaderText = "TELA"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 56
        '
        'Column4
        '
        Me.Column4.HeaderText = "FUNÇÃO"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 74
        '
        'Column5
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column5.HeaderText = "EVENTO"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 71
        '
        'Column6
        '
        Me.Column6.HeaderText = "DATA"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 59
        '
        'Column7
        '
        Me.Column7.HeaderText = "HORA"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 61
        '
        'BgwCarregaAcessoUsuario
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.bink.My.Resources.Resources.spinner1
        Me.PictureBox1.Location = New System.Drawing.Point(395, 150)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 121)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'frmLog
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 480)
        Me.Controls.Add(Me.splitContainer)
        Me.Name = "frmLog"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visualizar Logs usuário"
        CType(Me.splitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer.ResumeLayout(False)
        CType(Me.DgvConsUsuário, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents splitContainer As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents lblBusca As Label
    Friend WithEvents TxTBusca As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents DgvConsUsuário As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents BgwCarregaAcessoUsuario As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureBox1 As PictureBox
End Class
