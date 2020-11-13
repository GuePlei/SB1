Imports System.Runtime.InteropServices
Imports Dominio
Public Class Recuperar_Contraseña
    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles BtnSend.Click
        If TxtUser.Text = "" Then
            MsgBox("No puede dejar el campo de texto en blanco", MsgBoxStyle.Exclamation, "Error")
        Else
            Dim userModel As New UserModel()
            Dim result = userModel.recoverPassword(TxtUser.Text)
            LblResult.Text = result
            TxtUser.Text = ""
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Hide()
    End Sub

    Private Sub BtnMini_Click(sender As Object, e As EventArgs) Handles BtnMini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub
    Private Sub PlnHead_MouseDown(sender As Object, e As MouseEventArgs) Handles PlnHead.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    'Programador: Andrey Guerrero
End Class