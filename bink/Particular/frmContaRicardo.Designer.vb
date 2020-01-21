<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContaRicardo
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
        Me.dgvConsultaCliente = New System.Windows.Forms.DataGridView()
        Me.colid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldescricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colvalor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldatavenc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldatapgto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colstatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvConsultaCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvConsultaCliente
        '
        Me.dgvConsultaCliente.AllowUserToAddRows = False
        Me.dgvConsultaCliente.AllowUserToDeleteRows = False
        Me.dgvConsultaCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvConsultaCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvConsultaCliente.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.dgvConsultaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsultaCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colid, Me.coldescricao, Me.colvalor, Me.coldatavenc, Me.coldatapgto, Me.colstatus})
        Me.dgvConsultaCliente.EnableHeadersVisualStyles = False
        Me.dgvConsultaCliente.Location = New System.Drawing.Point(1, 130)
        Me.dgvConsultaCliente.Name = "dgvConsultaCliente"
        Me.dgvConsultaCliente.ReadOnly = True
        Me.dgvConsultaCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvConsultaCliente.Size = New System.Drawing.Size(948, 291)
        Me.dgvConsultaCliente.TabIndex = 2
        '
        'colid
        '
        Me.colid.HeaderText = "ID"
        Me.colid.Name = "colid"
        Me.colid.ReadOnly = True
        Me.colid.Visible = False
        Me.colid.Width = 43
        '
        'coldescricao
        '
        Me.coldescricao.HeaderText = "Descrição"
        Me.coldescricao.Name = "coldescricao"
        Me.coldescricao.ReadOnly = True
        Me.coldescricao.Width = 78
        '
        'colvalor
        '
        Me.colvalor.HeaderText = "R$ Valor"
        Me.colvalor.Name = "colvalor"
        Me.colvalor.ReadOnly = True
        Me.colvalor.Width = 72
        '
        'coldatavenc
        '
        Me.coldatavenc.HeaderText = "Data Venc."
        Me.coldatavenc.Name = "coldatavenc"
        Me.coldatavenc.ReadOnly = True
        Me.coldatavenc.Width = 85
        '
        'coldatapgto
        '
        Me.coldatapgto.HeaderText = "Data Pgto."
        Me.coldatapgto.Name = "coldatapgto"
        Me.coldatapgto.ReadOnly = True
        Me.coldatapgto.Width = 84
        '
        'colstatus
        '
        Me.colstatus.HeaderText = "Pago"
        Me.colstatus.Name = "colstatus"
        Me.colstatus.ReadOnly = True
        Me.colstatus.Width = 56
        '
        'frmContaRicardo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 510)
        Me.Controls.Add(Me.dgvConsultaCliente)
        Me.Name = "frmContaRicardo"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contas"
        CType(Me.dgvConsultaCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvConsultaCliente As DataGridView
    Friend WithEvents colid As DataGridViewTextBoxColumn
    Friend WithEvents coldescricao As DataGridViewTextBoxColumn
    Friend WithEvents colvalor As DataGridViewTextBoxColumn
    Friend WithEvents coldatavenc As DataGridViewTextBoxColumn
    Friend WithEvents coldatapgto As DataGridViewTextBoxColumn
    Friend WithEvents colstatus As DataGridViewTextBoxColumn
End Class
