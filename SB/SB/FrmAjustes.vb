Imports CapaComún
Imports Dominio
Public Class FrmAjustes
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
        FrmInicio.LblTop.Text = ""
    End Sub
    Private Sub Frmeditarperfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserData()

    End Sub
    Private Sub reset()
        LoadUserData()
    End Sub
    Private Sub LoadUserData()

        Lblemaildef.Text = ActiveUser.Correo
    End Sub
    '   Private Sub Btnsave_Click(sender As Object, e As EventArgs) Handles Btnsave.Click

    '      Lblemaildef.Text = txtemail.Text

    '  End Sub
    Private Sub Btnsave_Click(sender As Object, e As EventArgs) Handles Btnsave.Click
        Lblemaildef.Text = txtemail.Text
        Dim userModel As New UserModel(ID:=ActiveUser.ID,
                                                Correo:=txtemail.Text)

        Dim result = userModel.Editarcorreo
        ActiveUser.Correo = txtemail.Text
        txtemail.Text = ""
    End Sub


End Class