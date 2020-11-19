Imports CapaComún
Imports Dominio
Public Class FrmBoletas
    Dim I As Integer
    Sub internetcheck()
        Try
            If My.Computer.Network.Ping("172.217.2.206") Then
                I = 1
            Else
                I = 0
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        FrmInicio.LblTop.Text = ""
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles Pbclose.Click
        Me.Close()
        FrmInicio.LblTop.Text = ""
    End Sub

    Private Sub LoadUser()
        Lblprof.Text = ActiveUser.firstName + " " + ActiveUser.lastName
    End Sub

    Private Sub Boletas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        internetcheck()
        LoadUser()
        Btnenviar.Enabled = False
    End Sub
    Private Sub Btnsave_Click(sender As Object, e As EventArgs) Handles Btnsave.Click
        internetcheck()
        If I = 1 Then
            confirmardatos()
        ElseIf I = 0 Then
            MsgBox("No hay conexión a Internet", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub

    Private Sub Btnlimp_Click(sender As Object, e As EventArgs)
        limpiar()
        Btnenviar.Enabled = False
    End Sub
    Private Sub Btnenviar_Click(sender As Object, e As EventArgs) Handles Btnenviar.Click
        Btnenviar.Enabled = False
        ActiveUser.Estudiante = Lblest.Text
        ActiveUser.Motivo = Lblmotiv.Text
        ActiveUser.sec = Lblsec.Text
        Dim userModel As New UserModel()
        Dim result = userModel.sentemail()
        limpiar()
    End Sub
    Sub limpiar()
        Txtmotiv.Text = ""
        Txtsec.Text = ""
        Txtest.Text = ""
        Lblest.Text = ""
        Lblmotiv.Text = ""
        Lblsec.Text = ""
    End Sub
    Private Sub Pbclose_MouseLeave(sender As Object, e As EventArgs) Handles Pbclose.MouseLeave
        Pbclose.Image = My.Resources.icons8_close_window_24px
    End Sub
    Private Sub Pbclose_MouseEnter(sender As Object, e As EventArgs) Handles Pbclose.MouseEnter
        Pbclose.Image = My.Resources.icons8_close_window_24px_1
    End Sub
    Private Sub confirmardatos()
        If Txtsec.Text = "" Or Txtmotiv.Text = "" Or Txtest.Text = "" Then
            MsgBox("No puede dejar los campos de texto en blanco", MsgBoxStyle.Exclamation, "Error")
        Else
            Lblest.Text = Txtest.Text
            Lblmotiv.Text = Txtmotiv.Text
            Lblsec.Text = Txtsec.Text
            Btnenviar.Enabled = True
        End If
    End Sub
End Class