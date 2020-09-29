Imports System.Runtime.InteropServices
Imports Dominio

Public Class LoginForm
    Dim M As Integer
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        If MessageBox.Show("¿Estás seguro de querer cerrar la aplicación?", "¡Atención!",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub BtnMini_Click(sender As Object, e As EventArgs) Handles BtnMini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnClose_MouseEnter(sender As Object, e As EventArgs) Handles BtnClose.MouseEnter
        BtnClose.Image = My.Resources.icons8_close_window_24px_1
    End Sub

    Private Sub BtnClose_MouseLeave(sender As Object, e As EventArgs) Handles BtnClose.MouseLeave
        BtnClose.Image = My.Resources.icons8_close_window_24px
    End Sub
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub
    Private Sub paneltitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitulo.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub BtnLog_Click(sender As Object, e As EventArgs) Handles BtnLog.Click
        login()
    End Sub
    Private Sub login()
        Dim userModel As New UserModel
        Dim validLogin = userModel.Login(TxtUser.Text, TxtPass.Text)
        If validLogin = True Then
            Dim frm As New FrmStart()
            frm.Show()
            AddHandler frm.FormClosed, AddressOf Me.Loguot
            Me.Hide()
        Else
            MessageBox.Show("      Nombre de Usuario o contraseña incorrectos." + vbNewLine + "                             Intente de Nuevo.")
            TxtPass.Clear()
            TxtPass.Focus()
        End If
    End Sub

    Private Sub TxtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            login()

        End If
    End Sub
    Private Sub Loguot(sender As Object, e As FormClosedEventArgs)

        TxtUser.Clear()
        TxtPass.Clear()

        Me.Show()
        TxtUser.Focus()
    End Sub

    Private Sub BtnPasshidden_Click(sender As Object, e As EventArgs) Handles BtnPasshidden.Click

        If M = 0 Then
            TxtPass.PasswordChar = ""
            BtnPasshidden.Image = My.Resources.icons8_invisible_24px
            M = 1
        Else
            If M = 1 Then
                BtnPasshidden.Image = My.Resources.icons8_eye_24px
                TxtPass.PasswordChar = "*"
                M = 0
            End If
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim Recuperar_Contraseña As New Recuperar_Contraseña()
        Recuperar_Contraseña.ShowDialog()
    End Sub
End Class