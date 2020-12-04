Imports System.Runtime.InteropServices
Imports CapaComún
Imports Dominio
Public Class FrmInicio
    Private Currentchildform As Form
#Region "Funcionalidades del Formulario"
    'Arrastrar Form desde el panel
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    'Also arrastrar desde el panel
    Private Sub PlnHead_MouseMove(sender As Object, e As MouseEventArgs) Handles PlnHead.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
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
    'Ventana de titulo
    Private Sub LoadUser()
        LblName.Text = ActiveUser.firstName + ", " + ActiveUser.lastName
        Lblem.Text = ActiveUser.email
        LblPos.Text = ActiveUser.position
    End Sub
    Private Sub Security()
        Dim user As New UserModel()
        If user.AnyMethod(ActiveUser.idUser) = False Then
            MessageBox.Show("Error")
            Me.Close()
        End If
    End Sub
    Private Sub FrmStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Security()
        LoadUser()
        Administraciondepermisos()
    End Sub
    Private Sub BtnClose_MouseEnter(sender As Object, e As EventArgs) Handles BtnClose.MouseEnter
        BtnClose.Image = My.Resources.icons8_close_window_24px_1
    End Sub
    Private Sub BtnClose_MouseLeave(sender As Object, e As EventArgs) Handles BtnClose.MouseLeave
        BtnClose.Image = My.Resources.icons8_close_window_24px
    End Sub
    Private Sub BtnCls_Click(sender As Object, e As EventArgs) Handles BtnCls.Click
        If MessageBox.Show("¿Estás seguro de querer cerrar sesión?", "¡Atención!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
#End Region
#Region "Botones para el contenedor del formulario"
    'Abrir forms en el panel contenedor
    Private Sub OpenChildForm(childForm As Form)
        If Currentchildform IsNot Nothing Then
            Currentchildform.Close()
        End If
        Currentchildform = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(childForm)
        PanelContenedor.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        'LblTop.Text = childForm.Text
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnBole.Click
        OpenChildForm(New FrmBoletas)
    End Sub
    Private Sub BtnHome_Click(sender As Object, e As EventArgs)
        OpenChildForm(New FrmInicio)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Btnsettings.Click
        OpenChildForm(New FrmAjustes)
    End Sub
#End Region
    Private Sub Administraciondepermisos()
        If ActiveUser.position = Puestos.Docente Then
            Btnsettings.Enabled = False
            Panel7.Visible = True
        End If
    End Sub
    Private Sub Lblh_MouseMove(sender As Object, e As MouseEventArgs) Handles Lblh.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub PbLogo_MouseMove(sender As Object, e As MouseEventArgs) Handles PbLogo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub Btneditar_Click(sender As Object, e As EventArgs) Handles Btneditar.Click
        OpenChildForm(New FrmEditar)
    End Sub
End Class
