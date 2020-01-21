<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContrato
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContrato))
        Me.rtbContrato = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'rtbContrato
        '
        Me.rtbContrato.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbContrato.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbContrato.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbContrato.Location = New System.Drawing.Point(0, 0)
        Me.rtbContrato.Name = "rtbContrato"
        Me.rtbContrato.ReadOnly = True
        Me.rtbContrato.ShowSelectionMargin = True
        Me.rtbContrato.Size = New System.Drawing.Size(938, 501)
        Me.rtbContrato.TabIndex = 1
        Me.rtbContrato.Text = resources.GetString("rtbContrato.Text")
        '
        'frmContrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(938, 501)
        Me.Controls.Add(Me.rtbContrato)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmContrato"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contrato de licença"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rtbContrato As RichTextBox
End Class
