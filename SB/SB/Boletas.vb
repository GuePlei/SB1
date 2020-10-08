Public Class Boletas
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        FrmStart.LblTop.Text = ""
        Me.Close()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        FrmStart.LblTop.Text = ""
    End Sub

    Private Sub Tipobole_Click(sender As Object, e As EventArgs) Handles Tipobole.Click
        Subpanel.Visible = True
    End Sub

    Private Sub tipo2_Click(sender As Object, e As EventArgs) Handles tipo2.Click
        Subpanel.Visible = False
        Tipobole.Text = tipo2.Text
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub tipo3_Click(sender As Object, e As EventArgs) Handles tipo3.Click
        Subpanel.Visible = False
        Tipobole.Text = tipo3.Text
    End Sub

    Private Sub tipo1_Click(sender As Object, e As EventArgs) Handles tipo1.Click
        Subpanel.Visible = False
        Tipobole.Text = tipo1.Text
    End Sub

    Private Sub Boleta_Click(sender As Object, e As EventArgs) Handles Boleta.Click
        Subpanel2.Visible = True
    End Sub

    Private Sub boleta1_Click(sender As Object, e As EventArgs) Handles boleta1.Click
        Subpanel2.Visible = False
        Boleta.Text = boleta1.Text
    End Sub

    Private Sub boleta2_Click(sender As Object, e As EventArgs) Handles boleta2.Click
        Subpanel2.Visible = False
        Boleta.Text = boleta2.Text
    End Sub

    Private Sub boleta3_Click(sender As Object, e As EventArgs) Handles boleta3.Click
        Subpanel2.Visible = False
        Boleta.Text = boleta3.Text
    End Sub
End Class