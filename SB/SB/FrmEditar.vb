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
        Txtcomfpass.Text = ActiveUser.Password
    End Sub
    Private Sub ControlEditsPass()
        LinkEdit.Text = "Editar"

        Txtnewpass.Enabled = False

        Txtcomfpass.Enabled = False
        Txtactualpass.Text = ""
    End Sub
    Private Sub Reset()
        LoadUserData()
        ControlEditsPass()
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Plneditarperf.Visible = True
        LoadUserData()

    End Sub
    Private Sub LinkEdit_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkEdit.LinkClicked
        If LinkEdit.Text = "Editar" Then
            LinkEdit.Text = "Cancelar"
            Txtnewpass.Enabled = True
            Txtnewpass.Text = ""
            Txtactualpass.Enabled = True
            Txtnewpass.Text = ""
            Txtcomfpass.Enabled = True
            Txtcomfpass.Text = ""
        ElseIf LinkEdit.Text = "Cancelar" Then
            LinkEdit.Text = "Editar"
            Reset()
        End If
    End Sub

    Private Sub Btnsave_Click(sender As Object, e As EventArgs) Handles Btnsave.Click
        If Txtnewpass.Text = Txtcomfpass.Text Then
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
                Plneditarperf.Visible = False
            Else
                MessageBox.Show("Contraseña actual incorrecta")
                Reset()
            End If
        Else
            MessageBox.Show("Las contraseñas no coinciden")


        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btncancel.Click
        Plneditarperf.Visible = False
        Reset()
    End Sub
    Private Sub BtnClose_MouseEnter(sender As Object, e As EventArgs) Handles BtnClose.MouseEnter
        BtnClose.Image = My.Resources.icons8_close_window_24px_1
    End Sub
    Private Sub BtnClose_MouseLeave(sender As Object, e As EventArgs) Handles BtnClose.MouseLeave
        BtnClose.Image = My.Resources.icons8_close_window_24px
    End Sub
    'Programador: Andrey Guerrero
End Class