Public Class Frm_Principal_03

    Dim listaCurso As String
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Lbl_NomeProjeto.Text = "3 - Manipulando Textos"
        Btm_principal.Text = "Clique para ver os resultados"
        Me.Text = "3 - Manipulando Textos"
        Btm_Char.Text = "Clique para obter o Char"
        Lbl_Curso.Text = "Digite o seu curso preferido"
        Btm_Adicionar.Text = "Adicione à sua lista"
        Btm_MostraLista.Text = "Mostra lista atual"
        Btm_GuardarVariaveis.Text = "Clique aqui"

    End Sub

    Private Sub Btm_principal_Click(sender As Object, e As EventArgs) Handles Btm_principal.Click

        Dim primeiraLetra As Char = "a"
        MsgBox("O caracter da variável primeira letra é: " + primeiraLetra)

        Dim segundaLetra As Char = Chr(65)
        MsgBox("O caracter da variável segunda letra é: " + segundaLetra)

        Dim numeroChar As Integer
        numeroChar = 65
        Dim terceiraLetra As Char = Chr(numeroChar)

        numeroChar = numeroChar + 1
        Dim quartaLetra As Char = Chr(numeroChar)

        MsgBox("O caracter numero 65 é: " + terceiraLetra + " e o caracter 66 é: " + quartaLetra)
    End Sub

    Private Sub Btm_Char_Click(sender As Object, e As EventArgs) Handles Btm_Char.Click

        Dim valorChar As Integer = Val(Txt_NumeroChar.Text)
        Dim quintaLetra As Char = Chr(valorChar)

        MsgBox("O caracter para o numero " + valorChar.ToString + " é : " + quintaLetra)

    End Sub

    Private Sub Btm_Adicionar_Click(sender As Object, e As EventArgs) Handles Btm_Adicionar.Click

        Dim cursoDigitado As String = Txt_Curso.Text
        listaCurso = listaCurso + cursoDigitado + vbCrLf
        Txt_Lista.Text = listaCurso

    End Sub

    Private Sub Btm_MostraLista_Click(sender As Object, e As EventArgs) Handles Btm_MostraLista.Click

        MsgBox(listaCurso)

    End Sub

    Private Sub Btm_GuardarVariaveis_Click(sender As Object, e As EventArgs) Handles Btm_GuardarVariaveis.Click

        Dim idade As Integer = 32
        Dim idadeGustavo As Integer

        idadeGustavo = idade

        MsgBox("Idade é igual a: " + idade.ToString + " enquanto a idade Gustavo é: " + idadeGustavo.ToString)

        idade = 20

        MsgBox("Idade é igual a: " + idade.ToString + " enquanto a idade Gustavo é: " + idadeGustavo.ToString)

    End Sub
End Class
