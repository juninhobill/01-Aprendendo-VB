Public Class Frm_Principal_01
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btm_principal.Click
        MsgBox("Hello World!!!", MsgBoxStyle.Critical, "Mensagem")
    End Sub
End Class
