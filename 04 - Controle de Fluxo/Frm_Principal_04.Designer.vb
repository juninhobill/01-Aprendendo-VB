﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal_04
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
        Me.Lbl_Idade = New System.Windows.Forms.Label()
        Me.Txt_Idade = New System.Windows.Forms.TextBox()
        Me.Txt_Resultado = New System.Windows.Forms.TextBox()
        Me.Lbl_Resultado = New System.Windows.Forms.Label()
        Me.Grp_Pais = New System.Windows.Forms.GroupBox()
        Me.Rdb_Sim = New System.Windows.Forms.RadioButton()
        Me.Rdb_Nao = New System.Windows.Forms.RadioButton()
        Me.Grp_Pais.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btm_principal
        '
        Me.Btm_principal.Location = New System.Drawing.Point(19, 99)
        Me.Btm_principal.Name = "Btm_principal"
        Me.Btm_principal.Size = New System.Drawing.Size(276, 24)
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
        'Lbl_Idade
        '
        Me.Lbl_Idade.AutoSize = True
        Me.Lbl_Idade.Location = New System.Drawing.Point(16, 57)
        Me.Lbl_Idade.Name = "Lbl_Idade"
        Me.Lbl_Idade.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Idade.TabIndex = 2
        Me.Lbl_Idade.Text = "Label1"
        '
        'Txt_Idade
        '
        Me.Txt_Idade.Location = New System.Drawing.Point(19, 73)
        Me.Txt_Idade.Name = "Txt_Idade"
        Me.Txt_Idade.Size = New System.Drawing.Size(119, 20)
        Me.Txt_Idade.TabIndex = 3
        '
        'Txt_Resultado
        '
        Me.Txt_Resultado.Location = New System.Drawing.Point(19, 166)
        Me.Txt_Resultado.Name = "Txt_Resultado"
        Me.Txt_Resultado.Size = New System.Drawing.Size(583, 20)
        Me.Txt_Resultado.TabIndex = 4
        '
        'Lbl_Resultado
        '
        Me.Lbl_Resultado.AutoSize = True
        Me.Lbl_Resultado.Location = New System.Drawing.Point(16, 150)
        Me.Lbl_Resultado.Name = "Lbl_Resultado"
        Me.Lbl_Resultado.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Resultado.TabIndex = 5
        Me.Lbl_Resultado.Text = "Label1"
        '
        'Grp_Pais
        '
        Me.Grp_Pais.Controls.Add(Me.Rdb_Nao)
        Me.Grp_Pais.Controls.Add(Me.Rdb_Sim)
        Me.Grp_Pais.Location = New System.Drawing.Point(156, 48)
        Me.Grp_Pais.Name = "Grp_Pais"
        Me.Grp_Pais.Size = New System.Drawing.Size(270, 45)
        Me.Grp_Pais.TabIndex = 6
        Me.Grp_Pais.TabStop = False
        Me.Grp_Pais.Text = "GroupBox1"
        '
        'Rdb_Sim
        '
        Me.Rdb_Sim.AutoSize = True
        Me.Rdb_Sim.Location = New System.Drawing.Point(7, 20)
        Me.Rdb_Sim.Name = "Rdb_Sim"
        Me.Rdb_Sim.Size = New System.Drawing.Size(90, 17)
        Me.Rdb_Sim.TabIndex = 0
        Me.Rdb_Sim.TabStop = True
        Me.Rdb_Sim.Text = "RadioButton1"
        Me.Rdb_Sim.UseVisualStyleBackColor = True
        '
        'Rdb_Nao
        '
        Me.Rdb_Nao.AutoSize = True
        Me.Rdb_Nao.Location = New System.Drawing.Point(138, 20)
        Me.Rdb_Nao.Name = "Rdb_Nao"
        Me.Rdb_Nao.Size = New System.Drawing.Size(90, 17)
        Me.Rdb_Nao.TabIndex = 7
        Me.Rdb_Nao.TabStop = True
        Me.Rdb_Nao.Text = "RadioButton1"
        Me.Rdb_Nao.UseVisualStyleBackColor = True
        '
        'Frm_Principal_04
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 305)
        Me.Controls.Add(Me.Grp_Pais)
        Me.Controls.Add(Me.Lbl_Resultado)
        Me.Controls.Add(Me.Txt_Resultado)
        Me.Controls.Add(Me.Txt_Idade)
        Me.Controls.Add(Me.Lbl_Idade)
        Me.Controls.Add(Me.Lbl_NomeProjeto)
        Me.Controls.Add(Me.Btm_principal)
        Me.Name = "Frm_Principal_04"
        Me.Text = "Hello World"
        Me.Grp_Pais.ResumeLayout(False)
        Me.Grp_Pais.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btm_principal As Button
    Friend WithEvents Lbl_NomeProjeto As Label
    Friend WithEvents Lbl_Idade As Label
    Friend WithEvents Txt_Idade As TextBox
    Friend WithEvents Txt_Resultado As TextBox
    Friend WithEvents Lbl_Resultado As Label
    Friend WithEvents Grp_Pais As GroupBox
    Friend WithEvents Rdb_Sim As RadioButton
    Friend WithEvents Rdb_Nao As RadioButton
End Class
