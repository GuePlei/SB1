﻿Imports System.Runtime.InteropServices
Imports Dominio
Public Class FrmLogin
    Dim M As Integer
    Dim I As Integer
    Sub Internetcheck()
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
    Private Sub Paneltitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitulo.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub BtnLog_Click(sender As Object, e As EventArgs) Handles BtnLog.Click
        internetcheck()
        If I = 1 Then
            Login()
        ElseIf I = 0 Then
            MsgBox("No hay conexión a Internet", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub
    Private Sub Login()
        Dim userModel As New UserModel
        userModel.cargaremail()
        Dim validLogin = userModel.Login(TxtUser.Text, TxtPass.Text)
        If validLogin = True Then
            Dim frm As New FrmInicio()
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
            Login()
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
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Btnrepass.LinkClicked
        Dim Recuperar_Contraseña As New Recuperar_Contraseña()
        Recuperar_Contraseña.ShowDialog()
    End Sub
End Class