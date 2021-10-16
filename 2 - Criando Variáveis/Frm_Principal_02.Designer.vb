<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal_02
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Btm_NumerosInteiros = New System.Windows.Forms.Button()
        Me.Lbl_NomeProjeto = New System.Windows.Forms.Label()
        Me.Btm_PontosFlutuantes = New System.Windows.Forms.Button()
        Me.ConversaoNumeros = New System.Windows.Forms.Button()
        Me.Txt_Numerador = New System.Windows.Forms.TextBox()
        Me.Txt_Denominador = New System.Windows.Forms.TextBox()
        Me.Btm_Resultado = New System.Windows.Forms.Button()
        Me.Txt_ResultadoDecimal = New System.Windows.Forms.TextBox()
        Me.Txt_ResultadoDouble = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Btm_NumerosInteiros
        '
        Me.Btm_NumerosInteiros.Location = New System.Drawing.Point(12, 42)
        Me.Btm_NumerosInteiros.Name = "Btm_NumerosInteiros"
        Me.Btm_NumerosInteiros.Size = New System.Drawing.Size(135, 58)
        Me.Btm_NumerosInteiros.TabIndex = 0
        Me.Btm_NumerosInteiros.Text = "Exemplos Números Inteiros"
        Me.Btm_NumerosInteiros.UseVisualStyleBackColor = True
        '
        'Lbl_NomeProjeto
        '
        Me.Lbl_NomeProjeto.AutoSize = True
        Me.Lbl_NomeProjeto.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_NomeProjeto.Name = "Lbl_NomeProjeto"
        Me.Lbl_NomeProjeto.Size = New System.Drawing.Size(104, 13)
        Me.Lbl_NomeProjeto.TabIndex = 2
        Me.Lbl_NomeProjeto.Text = "2 - Criando Variáveis"
        '
        'Btm_PontosFlutuantes
        '
        Me.Btm_PontosFlutuantes.Location = New System.Drawing.Point(12, 106)
        Me.Btm_PontosFlutuantes.Name = "Btm_PontosFlutuantes"
        Me.Btm_PontosFlutuantes.Size = New System.Drawing.Size(135, 58)
        Me.Btm_PontosFlutuantes.TabIndex = 3
        Me.Btm_PontosFlutuantes.Text = "Exemplos Números Ponto Flutuantes"
        Me.Btm_PontosFlutuantes.UseVisualStyleBackColor = True
        '
        'ConversaoNumeros
        '
        Me.ConversaoNumeros.Location = New System.Drawing.Point(12, 170)
        Me.ConversaoNumeros.Name = "ConversaoNumeros"
        Me.ConversaoNumeros.Size = New System.Drawing.Size(135, 58)
        Me.ConversaoNumeros.TabIndex = 4
        Me.ConversaoNumeros.Text = "Exemplo de Conversão de Números"
        Me.ConversaoNumeros.UseVisualStyleBackColor = True
        '
        'Txt_Numerador
        '
        Me.Txt_Numerador.Location = New System.Drawing.Point(222, 54)
        Me.Txt_Numerador.Name = "Txt_Numerador"
        Me.Txt_Numerador.Size = New System.Drawing.Size(133, 20)
        Me.Txt_Numerador.TabIndex = 5
        '
        'Txt_Denominador
        '
        Me.Txt_Denominador.Location = New System.Drawing.Point(222, 80)
        Me.Txt_Denominador.Name = "Txt_Denominador"
        Me.Txt_Denominador.Size = New System.Drawing.Size(133, 20)
        Me.Txt_Denominador.TabIndex = 6
        '
        'Btm_Resultado
        '
        Me.Btm_Resultado.Location = New System.Drawing.Point(222, 107)
        Me.Btm_Resultado.Name = "Btm_Resultado"
        Me.Btm_Resultado.Size = New System.Drawing.Size(133, 23)
        Me.Btm_Resultado.TabIndex = 7
        Me.Btm_Resultado.Text = "Resultado"
        Me.Btm_Resultado.UseVisualStyleBackColor = True
        '
        'Txt_ResultadoDecimal
        '
        Me.Txt_ResultadoDecimal.Location = New System.Drawing.Point(222, 159)
        Me.Txt_ResultadoDecimal.Name = "Txt_ResultadoDecimal"
        Me.Txt_ResultadoDecimal.Size = New System.Drawing.Size(240, 20)
        Me.Txt_ResultadoDecimal.TabIndex = 8
        '
        'Txt_ResultadoDouble
        '
        Me.Txt_ResultadoDouble.Location = New System.Drawing.Point(222, 185)
        Me.Txt_ResultadoDouble.Name = "Txt_ResultadoDouble"
        Me.Txt_ResultadoDouble.Size = New System.Drawing.Size(240, 20)
        Me.Txt_ResultadoDouble.TabIndex = 9
        '
        'Frm_TelaPrincipal_02
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 305)
        Me.Controls.Add(Me.Txt_ResultadoDouble)
        Me.Controls.Add(Me.Txt_ResultadoDecimal)
        Me.Controls.Add(Me.Btm_Resultado)
        Me.Controls.Add(Me.Txt_Denominador)
        Me.Controls.Add(Me.Txt_Numerador)
        Me.Controls.Add(Me.ConversaoNumeros)
        Me.Controls.Add(Me.Btm_PontosFlutuantes)
        Me.Controls.Add(Me.Lbl_NomeProjeto)
        Me.Controls.Add(Me.Btm_NumerosInteiros)
        Me.Name = "Frm_TelaPrincipal_02"
        Me.Text = "Hello World"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btm_NumerosInteiros As Button
    Friend WithEvents Lbl_NomeProjeto As Label
    Friend WithEvents Btm_PontosFlutuantes As Button
    Friend WithEvents ConversaoNumeros As Button
    Friend WithEvents Txt_Numerador As TextBox
    Friend WithEvents Txt_Denominador As TextBox
    Friend WithEvents Btm_Resultado As Button
    Friend WithEvents Txt_ResultadoDecimal As TextBox
    Friend WithEvents Txt_ResultadoDouble As TextBox
End Class