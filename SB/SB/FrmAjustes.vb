Imports CapaComún
Imports Dominio
Public Class FrmAjustes
    Private Currentchildform As Form
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
        FrmInicio.LblTop.Text = ""
    End Sub
    Private Sub Btnsave1_Click(sender As Object, e As EventArgs) Handles Btnsave.Click
        If Txtuser.Text = "" Or Txtnewpass.Text = "" Or Txtname.Text = "" Or Txtlname.Text = "" Or CBox.Text = "" Or Txtemail.Text = "" Then
            MsgBox("No puede dejar los campos de texto en blanco", MsgBoxStyle.Exclamation, "Error")
        ElseIf Txtnewpass.Text = Txtcomfpass.Text Then
            Dim userModelB As New UserModelB(
                                               LoginName:=Txtuser.Text,
                                               Password:=Txtnewpass.Text,
                                               firstName:=Txtname.Text,
                                               lastName:=Txtlname.Text,
                                               position:=CBox.Text,
                                               email:=Txtemail.Text)
            Dim result = userModelB.addprofile
            MessageBox.Show(result)
            limpiar()
        Else
            MessageBox.Show("Las contraseñas no coinciden")
        End If
    End Sub
    Sub limpiar()
        Txtuser.Text = ""
        Txtnewpass.Text = ""
        Txtname.Text = ""
        Txtlname.Text = ""
        Txtuser.Text = ""
        Txtemail.Text = ""
        Txtcomfpass.Text = ""
    End Sub
    Private Sub Btndel_Click(sender As Object, e As EventArgs) Handles Btndel.Click
        validdel()
    End Sub
    Private Sub validdel()
        Dim userModelC As New UserModelC

        Dim validdel = userModelC.delnames(Txtuserdel.Text)
        If validdel = False Then
            MessageBox.Show("Nombre de usuario inexistente")
        Else
            If Txtuserdel.Text = "" Then
                MsgBox("No puede dejar ese campo en blanco", MsgBoxStyle.Critical, "Error")
            Else
                If MsgBox("Esta acción es irreversible, ¿está seguro de eliminar?", MsgBoxStyle.YesNo, "Atención") = vbYes Then

                    Dim userModelB As New UserModelB(
                                                     LoginName:=Txtuserdel.Text)
                    Dim result = userModelB.borrar
                    MessageBox.Show(result)

                    Txtuserdel.Text = ""
                End If
            End If
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmListUser.Show()
    End Sub
    Private Sub BtnClose_MouseEnter(sender As Object, e As EventArgs) Handles BtnClose.MouseEnter
        BtnClose.Image = My.Resources.icons8_close_window_24px_1
    End Sub
    Private Sub BtnClose_MouseLeave(sender As Object, e As EventArgs) Handles BtnClose.MouseLeave
        BtnClose.Image = My.Resources.icons8_close_window_24px
    End Sub
    'Programador: Andrey Guerrero
End Class