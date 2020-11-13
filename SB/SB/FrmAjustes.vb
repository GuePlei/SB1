Imports CapaComún
Imports Dominio
Public Class FrmAjustes
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
        FrmInicio.LblTop.Text = ""
    End Sub
    Private Sub Btnsave1_Click(sender As Object, e As EventArgs) Handles Btnsave.Click
        If Txtuser.Text = "" Or Txtnewpass.Text = "" Or Txtname.Text = "" Or Txtlname.Text = "" Or TxtPos.Text = "" Or Txtemail.Text = "" Then
            MsgBox("No puede dejar los campos de texto en blanco", MsgBoxStyle.Exclamation, "Error")
        ElseIf Txtnewpass.Text = Txtcomfpass.Text Then

            Dim userModelB As New UserModelB(
                                               LoginName:=Txtuser.Text,
                                               Password:=Txtnewpass.Text,
                                               firstName:=Txtname.Text,
                                               lastName:=Txtlname.Text,
                                               position:=TxtPos.Text,
                                               email:=Txtemail.Text)
            Dim result = userModelB.addprofile
            MessageBox.Show(result)
        Else
            MessageBox.Show("Las contraseñas no coinciden")
        End If

    End Sub
    Private Sub Butndel_Click(sender As Object, e As EventArgs)
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
    End Sub

    Private Sub Btnlim_Click(sender As Object, e As EventArgs) Handles Btnlim.Click
        limpiar()
    End Sub
    Sub limpiar()
        Txtuser.Text = ""
        Txtnewpass.Text = ""
        Txtname.Text = ""
        Txtlname.Text = ""
        Txtuser.Text = ""
        TxtPos.Text = ""
        Txtemail.Text = ""
    End Sub
    'Programador: Andrey Guerrero
End Class