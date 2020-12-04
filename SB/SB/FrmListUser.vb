Imports System.Runtime.InteropServices
Public Class FrmListUser
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    'Also arrastrar desde el panel
    Private Sub PlnHead_MouseMove(sender As Object, e As MouseEventArgs) Handles Plnhead.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub FrmListUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BoletasDigitalesDataSet.Users' Puede moverla o quitarla según sea necesario.
        Me.UsersTableAdapter.Fill(Me.BoletasDigitalesDataSet.Users)
    End Sub

    Private Sub BtnClose_Click_1(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnClose_MouseEnter_1(sender As Object, e As EventArgs) Handles BtnClose.MouseEnter
        BtnClose.Image = My.Resources.icons8_close_window_24px_1
    End Sub

    Private Sub BtnClose_MouseLeave_1(sender As Object, e As EventArgs) Handles BtnClose.MouseLeave
        BtnClose.Image = My.Resources.icons8_close_window_24px
    End Sub
    Private Sub Lblh_MouseMove(sender As Object, e As MouseEventArgs) Handles Lblh.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
End Class