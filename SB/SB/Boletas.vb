Public Class Boletas
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        FrmStart.LblTop.Text = ""
        Me.Close()

    End Sub
End Class