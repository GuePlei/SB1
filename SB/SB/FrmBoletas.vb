Imports CapaComún
Imports Dominio
Public Class FrmBoletas
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        FrmInicio.LblTop.Text = ""
        Me.Close()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        FrmInicio.LblTop.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        Panelpuntos.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) 
        Panelpuntos.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) 
        Panelpuntos.Visible = False
    End Sub
    Private Sub LoadUser()
        Lblprof.Text = ActiveUser.firstName + " " + ActiveUser.lastName

    End Sub

    Private Sub Boletas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUser()
        Btnenviar.Enabled = False
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Btnsave_Click(sender As Object, e As EventArgs) Handles Btnsave.Click
        Lblusered.Text = Txtuser.Text
        Lblpuntos.Text = txtpuntos.Text
        Lblmotiv.Text = Txtmotiv.Text
        Lbldesc.Text = Txtdesc.Text
        Lbltipo.Text = txttipo.Text
        Btnenviar.Enabled = True
    End Sub

    Private Sub Btnlimp_Click(sender As Object, e As EventArgs) Handles Btnlimp.Click
        txttipo.Text = ""
        txtpuntos.Text = ""
        Txtmotiv.Text = ""
        Txtdesc.Text = ""
        Txtuser.Text = ""
        Lblusered.Text = ""
        Lblpuntos.Text = ""
        Lblmotiv.Text = ""
        Lbldesc.Text = ""
        Lbltipo.Text = ""
        Btnenviar.Enabled = False
    End Sub

    Private Sub Btnenviar_Click(sender As Object, e As EventArgs) Handles Btnenviar.Click
        Btnenviar.Enabled = False
        ActiveUser.Estudiante = Lblusered.Text
        ActiveUser.Motivo = Lblmotiv.Text
        ActiveUser.Desc = Lbldesc.Text
        ActiveUser.Puntos = Lblpuntos.Text
        ActiveUser.Tipo = Lbltipo.Text
        Dim userModel As New UserModel()
        Dim result = userModel.sentemail()


    End Sub

    Private Sub txttipo_TextChanged(sender As Object, e As EventArgs) Handles txttipo.TextChanged

    End Sub
End Class