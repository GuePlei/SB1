Imports System.Runtime.InteropServices
Imports Dominio
Public Class Recuperar_Contraseña
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
    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles BtnSend.Click
        internetcheck()
        If I = 1 Then
            Send()
        ElseIf I = 0 Then
            MsgBox("No hay conexión a Internet", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub
    Private Sub Send()
        If TxtUser.Text = "" Then
            MsgBox("No puede dejar el campo de texto en blanco", MsgBoxStyle.Exclamation, "Error")
        Else
            Dim userModel As New UserModel()
            Dim result = userModel.RecoverPassword(TxtUser.Text)
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
    Private Sub BtnClose_MouseEnter(sender As Object, e As EventArgs) Handles BtnClose.MouseEnter
        BtnClose.Image = My.Resources.icons8_close_window_24px_1
    End Sub
    Private Sub BtnClose_MouseLeave(sender As Object, e As EventArgs) Handles BtnClose.MouseLeave
        BtnClose.Image = My.Resources.icons8_close_window_24px
    End Sub
End Class