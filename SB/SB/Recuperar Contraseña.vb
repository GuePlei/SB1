Imports Dominio
Public Class Recuperar_Contraseña
    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles BtnSend.Click
        Dim userModel As New UserModel()
        Dim result = userModel.recoverPassword(TxtUser.Text)
        LblResult.Text = result
    End Sub
End Class