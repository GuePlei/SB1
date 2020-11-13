Imports CapaComún
Imports Dominio
Public Class FrmBoletas
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
        LoadUser()
        Btnenviar.Enabled = False
    End Sub

    Private Sub Btnsave_Click(sender As Object, e As EventArgs) Handles Btnsave.Click
        If Txtsec.Text = "" Or Txtmotiv.Text = "" Or Txtest.Text = "" Then
            MsgBox("No puede dejar los campos de texto en blanco", MsgBoxStyle.Exclamation, "Error")
        Else
            Lblest.Text = Txtest.Text
            Lblmotiv.Text = Txtmotiv.Text
            Lblsec.Text = Txtsec.Text
            Btnenviar.Enabled = True
        End If
    End Sub

    Private Sub Btnlimp_Click(sender As Object, e As EventArgs) Handles Btnlimp.Click
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
    'Programador: Andrey Guerrero
End Class