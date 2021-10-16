<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal_03
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
        Me.Btm_principal = New System.Windows.Forms.Button()
        Me.Lbl_NomeProjeto = New System.Windows.Forms.Label()
        Me.Btm_Char = New System.Windows.Forms.Button()
        Me.Txt_NumeroChar = New System.Windows.Forms.TextBox()
        Me.Lbl_Curso = New System.Windows.Forms.Label()
        Me.Txt_Curso = New System.Windows.Forms.TextBox()
        Me.Btm_Adicionar = New System.Windows.Forms.Button()
        Me.Txt_Lista = New System.Windows.Forms.TextBox()
        Me.Btm_MostraLista = New System.Windows.Forms.Button()
        Me.Btm_GuardarVariaveis = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btm_principal
        '
        Me.Btm_principal.Location = New System.Drawing.Point(16, 47)
        Me.Btm_principal.Name = "Btm_principal"
        Me.Btm_principal.Size = New System.Drawing.Size(196, 58)
        Me.Btm_principal.TabIndex = 0
        Me.Btm_principal.Text = "Clique aqui"
        Me.Btm_principal.UseVisualStyleBackColor = True
        '
        'Lbl_NomeProjeto
        '
        Me.Lbl_NomeProjeto.AutoSize = True
        Me.Lbl_NomeProjeto.Location = New System.Drawing.Point(13, 13)
        Me.Lbl_NomeProjeto.Name = "Lbl_NomeProjeto"
        Me.Lbl_NomeProjeto.Size = New System.Drawing.Size(95, 13)
        Me.Lbl_NomeProjeto.TabIndex = 1
        Me.Lbl_NomeProjeto.Text = "1 - Primeiro Projeto"
        '
        'Btm_Char
        '
        Me.Btm_Char.Location = New System.Drawing.Point(245, 47)
        Me.Btm_Char.Name = "Btm_Char"
        Me.Btm_Char.Size = New System.Drawing.Size(191, 23)
        Me.Btm_Char.TabIndex = 2
        Me.Btm_Char.Text = "Button1"
        Me.Btm_Char.UseVisualStyleBackColor = True
        '
        'Txt_NumeroChar
        '
        Me.Txt_NumeroChar.Location = New System.Drawing.Point(245, 13)
        Me.Txt_NumeroChar.Name = "Txt_NumeroChar"
        Me.Txt_NumeroChar.Size = New System.Drawing.Size(111, 20)
        Me.Txt_NumeroChar.TabIndex = 3
        '
        'Lbl_Curso
        '
        Me.Lbl_Curso.AutoSize = True
        Me.Lbl_Curso.Location = New System.Drawing.Point(16, 123)
        Me.Lbl_Curso.Name = "Lbl_Curso"
        Me.Lbl_Curso.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Curso.TabIndex = 4
        Me.Lbl_Curso.Text = "Label1"
        '
        'Txt_Curso
        '
        Me.Txt_Curso.Location = New System.Drawing.Point(19, 150)
        Me.Txt_Curso.Name = "Txt_Curso"
        Me.Txt_Curso.Size = New System.Drawing.Size(193, 20)
        Me.Txt_Curso.TabIndex = 5
        '
        'Btm_Adicionar
        '
        Me.Btm_Adicionar.Location = New System.Drawing.Point(218, 150)
        Me.Btm_Adicionar.Name = "Btm_Adicionar"
        Me.Btm_Adicionar.Size = New System.Drawing.Size(267, 20)
        Me.Btm_Adicionar.TabIndex = 6
        Me.Btm_Adicionar.Text = "Button1"
        Me.Btm_Adicionar.UseVisualStyleBackColor = True
        '
        'Txt_Lista
        '
        Me.Txt_Lista.Location = New System.Drawing.Point(19, 177)
        Me.Txt_Lista.Multiline = True
        Me.Txt_Lista.Name = "Txt_Lista"
        Me.Txt_Lista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_Lista.Size = New System.Drawing.Size(193, 116)
        Me.Txt_Lista.TabIndex = 8
        '
        'Btm_MostraLista
        '
        Me.Btm_MostraLista.Location = New System.Drawing.Point(219, 177)
        Me.Btm_MostraLista.Name = "Btm_MostraLista"
        Me.Btm_MostraLista.Size = New System.Drawing.Size(267, 23)
        Me.Btm_MostraLista.TabIndex = 9
        Me.Btm_MostraLista.Text = "Button1"
        Me.Btm_MostraLista.UseVisualStyleBackColor = True
        '
        'Btm_GuardarVariaveis
        '
        Me.Btm_GuardarVariaveis.Location = New System.Drawing.Point(219, 228)
        Me.Btm_GuardarVariaveis.Name = "Btm_GuardarVariaveis"
        Me.Btm_GuardarVariaveis.Size = New System.Drawing.Size(267, 23)
        Me.Btm_GuardarVariaveis.TabIndex = 10
        Me.Btm_GuardarVariaveis.Text = "Button1"
        Me.Btm_GuardarVariaveis.UseVisualStyleBackColor = True
        '
        'Frm_Principal_03
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 305)
        Me.Controls.Add(Me.Btm_GuardarVariaveis)
        Me.Controls.Add(Me.Btm_MostraLista)
        Me.Controls.Add(Me.Txt_Lista)
        Me.Controls.Add(Me.Btm_Adicionar)
        Me.Controls.Add(Me.Txt_Curso)
        Me.Controls.Add(Me.Lbl_Curso)
        Me.Controls.Add(Me.Txt_NumeroChar)
        Me.Controls.Add(Me.Btm_Char)
        Me.Controls.Add(Me.Lbl_NomeProjeto)
        Me.Controls.Add(Me.Btm_principal)
        Me.Name = "Frm_Principal_03"
        Me.Text = "Hello World"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btm_principal As Button
    Friend WithEvents Lbl_NomeProjeto As Label
    Friend WithEvents Btm_Char As Button
    Friend WithEvents Txt_NumeroChar As TextBox
    Friend WithEvents Lbl_Curso As Label
    Friend WithEvents Txt_Curso As TextBox
    Friend WithEvents Btm_Adicionar As Button
    Friend WithEvents Txt_Lista As TextBox
    Friend WithEvents Btm_MostraLista As Button
    Friend WithEvents Btm_GuardarVariaveis As Button
End Class
