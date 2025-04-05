<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Intro
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Intro))
        Me.Lbl_Versao = New System.Windows.Forms.Label()
        Me.Lbl_Modulo = New System.Windows.Forms.Label()
        Me.Tmr_Intro = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Lbl_Versao
        '
        Me.Lbl_Versao.AutoSize = True
        Me.Lbl_Versao.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Versao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Versao.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Lbl_Versao.Location = New System.Drawing.Point(37, 51)
        Me.Lbl_Versao.Name = "Lbl_Versao"
        Me.Lbl_Versao.Size = New System.Drawing.Size(13, 13)
        Me.Lbl_Versao.TabIndex = 0
        Me.Lbl_Versao.Text = "x"
        '
        'Lbl_Modulo
        '
        Me.Lbl_Modulo.AutoSize = True
        Me.Lbl_Modulo.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Modulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Modulo.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Lbl_Modulo.Location = New System.Drawing.Point(37, 84)
        Me.Lbl_Modulo.Name = "Lbl_Modulo"
        Me.Lbl_Modulo.Size = New System.Drawing.Size(13, 13)
        Me.Lbl_Modulo.TabIndex = 1
        Me.Lbl_Modulo.Text = "x"
        '
        'Tmr_Intro
        '
        Me.Tmr_Intro.Enabled = True
        Me.Tmr_Intro.Interval = 3000
        '
        'Frm_Intro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Facilita_DP___Módulo_Rescisão.My.Resources.Resources.banner_FacilitaDP
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(640, 360)
        Me.ControlBox = False
        Me.Controls.Add(Me.Lbl_Modulo)
        Me.Controls.Add(Me.Lbl_Versao)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Intro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Versao As Label
    Friend WithEvents Lbl_Modulo As Label
    Friend WithEvents Tmr_Intro As Timer
End Class
