Imports CapaComún
Imports Dominio
Public Class FrmEditar

    Private Sub BtnClose_Click_1(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub Frmeditarperfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserData()
        ControlEditsPass()
    End Sub
    Private Sub LoadUserData()
        'Vista
        Lblusered.Text = ActiveUser.LoginName
        Lblnameed.Text = ActiveUser.firstName
        Lbllnameed.Text = ActiveUser.lastName
        Lblemailed.Text = ActiveUser.email
        Lblposited.Text = ActiveUser.position
        'Editar
        Txtuser.Text = ActiveUser.LoginName
        Txtname.Text = ActiveUser.firstName
        Txtlname.Text = ActiveUser.lastName
        Txtemail.Text = ActiveUser.email
        Txtnewpass.Text = ActiveUser.Password
        Txtcomfirmpass.Text = ActiveUser.Password
    End Sub
    Private Sub ControlEditsPass()
        LinkEdit.Text = "Editar"

        Txtnewpass.Enabled = False

        Txtcomfirmpass.Enabled = False
        Txtactualpass.Text = ""
    End Sub
    Private Sub Reset()
        LoadUserData()
        ControlEditsPass()
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Panel2.Visible = True
        LoadUserData()

    End Sub
    Private Sub LinkEdit_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkEdit.LinkClicked
        If LinkEdit.Text = "Editar" Then
            LinkEdit.Text = "Cancelar"
            Txtnewpass.Enabled = True
            Txtnewpass.Text = ""
            Txtactualpass.Enabled = True
            Txtnewpass.Text = ""
            Txtcomfirmpass.Enabled = True
            Txtcomfirmpass.Text = ""
        ElseIf LinkEdit.Text = "Cancelar" Then
            LinkEdit.Text = "Editar"
            Reset()

            'Txtnewpass.Text = ActiveUser.Password
            ' Txtcomfirmpass.Text = ActiveUser.Password

        End If
    End Sub

    Private Sub Btnsave_Click(sender As Object, e As EventArgs) Handles Btnsave.Click
        If Txtnewpass.Text = Txtcomfirmpass.Text Then
            If Txtactualpass.Text = ActiveUser.Password Then

                Dim userModel As New UserModel(idUser:=ActiveUser.idUser,
                                                LoginName:=Txtuser.Text,
                                                Password:=Txtnewpass.Text,
                                                firstName:=Txtname.Text,
                                                lastName:=Txtlname.Text,
                                                position:=Nothing,
                                                email:=Txtemail.Text)

                Dim result = userModel.Editarperfil()
                MessageBox.Show(result)
                Reset()
                Panel2.Visible = False
            Else
                MessageBox.Show("Contraseña actual incorrecta")
            End If
        Else
            MessageBox.Show("Las contraseñas no coinciden")

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel2.Visible = False
        Reset()
    End Sub
End Class