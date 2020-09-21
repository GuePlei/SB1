Public Class Inicio
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
        FrmStart.LblTop.Text = ""
    End Sub
End Class