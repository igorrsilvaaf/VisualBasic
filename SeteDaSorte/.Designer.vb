<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TelaPrincipal
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Num1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Num2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Num3 = New System.Windows.Forms.Label()
        Me.PbResult = New System.Windows.Forms.PictureBox()
        Me.BtnJogar = New System.Windows.Forms.Button()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PbResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(309, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "7 da sorte"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Num1)
        Me.Panel1.Location = New System.Drawing.Point(173, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(100, 100)
        Me.Panel1.TabIndex = 1
        '
        'Num1
        '
        Me.Num1.AutoSize = True
        Me.Num1.Font = New System.Drawing.Font("Segoe UI", 33.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num1.Location = New System.Drawing.Point(24, 24)
        Me.Num1.Name = "Num1"
        Me.Num1.Size = New System.Drawing.Size(51, 61)
        Me.Num1.TabIndex = 0
        Me.Num1.Text = "0"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Num2)
        Me.Panel2.Location = New System.Drawing.Point(341, 67)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(100, 100)
        Me.Panel2.TabIndex = 2
        '
        'Num2
        '
        Me.Num2.AutoSize = True
        Me.Num2.Font = New System.Drawing.Font("Segoe UI", 33.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num2.Location = New System.Drawing.Point(21, 24)
        Me.Num2.Name = "Num2"
        Me.Num2.Size = New System.Drawing.Size(51, 61)
        Me.Num2.TabIndex = 0
        Me.Num2.Text = "0"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Num3)
        Me.Panel3.Location = New System.Drawing.Point(498, 67)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(100, 100)
        Me.Panel3.TabIndex = 3
        '
        'Num3
        '
        Me.Num3.AutoSize = True
        Me.Num3.Font = New System.Drawing.Font("Segoe UI", 33.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num3.Location = New System.Drawing.Point(23, 24)
        Me.Num3.Name = "Num3"
        Me.Num3.Size = New System.Drawing.Size(51, 61)
        Me.Num3.TabIndex = 0
        Me.Num3.Text = "0"
        '
        'PbResult
        '
        Me.PbResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PbResult.Location = New System.Drawing.Point(173, 187)
        Me.PbResult.Name = "PbResult"
        Me.PbResult.Size = New System.Drawing.Size(425, 169)
        Me.PbResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbResult.TabIndex = 4
        Me.PbResult.TabStop = False
        Me.PbResult.Visible = False
        '
        'BtnJogar
        '
        Me.BtnJogar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnJogar.ForeColor = System.Drawing.Color.Red
        Me.BtnJogar.Location = New System.Drawing.Point(210, 362)
        Me.BtnJogar.Name = "BtnJogar"
        Me.BtnJogar.Size = New System.Drawing.Size(101, 51)
        Me.BtnJogar.TabIndex = 5
        Me.BtnJogar.Text = "JOGAR"
        Me.BtnJogar.UseVisualStyleBackColor = True
        '
        'BtnSair
        '
        Me.BtnSair.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSair.ForeColor = System.Drawing.Color.Red
        Me.BtnSair.Location = New System.Drawing.Point(473, 362)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(101, 51)
        Me.BtnSair.TabIndex = 6
        Me.BtnSair.Text = "SAIR"
        Me.BtnSair.UseVisualStyleBackColor = True
        '
        'TelaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.BtnJogar)
        Me.Controls.Add(Me.PbResult)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TelaPrincipal"
        Me.Text = "7 da sorte"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PbResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Num1 As Label
    Friend WithEvents Num2 As Label
    Friend WithEvents Num3 As Label
    Friend WithEvents PbResult As PictureBox
    Friend WithEvents BtnJogar As Button
    Friend WithEvents BtnSair As Button
End Class
