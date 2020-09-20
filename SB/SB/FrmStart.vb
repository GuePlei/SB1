Imports System.Runtime.InteropServices

Public Class FrmStart
    Private Currentchildform As Form
#Region "Funcionalidades del Formulario"

    'ARRASTRAR FORMULARIO
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub PlnHead_MouseMove(sender As Object, e As MouseEventArgs) Handles PlnHead.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Application.Exit()
    End Sub
    Private Sub BtnMxi_Click(sender As Object, e As EventArgs) Handles BtnMxi.Click
        'Call winstate()
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
            BtnMxi.Image = My.Resources.icons8_restore_window_24px
        Else
            WindowState = FormWindowState.Normal
            BtnMxi.Image = My.Resources.icons8_maximize_window_24px
        End If
    End Sub
    Private Sub PlnHead_DoubleClick(sender As Object, e As EventArgs) Handles PlnHead.DoubleClick
        Call winstate()
    End Sub
    Private Sub BtnMini_Click(sender As Object, e As EventArgs) Handles BtnMini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub FrmStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnHome.Visible = False
        'Form'
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub
    Private Sub FrmStart_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub

    Private Sub winstate()
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
            BtnMxi.Image = My.Resources.icons8_restore_window_24px
        Else
            WindowState = FormWindowState.Normal
            BtnMxi.Image = My.Resources.icons8_maximize_window_24px
        End If

    End Sub
    Private Sub BtnClose_MouseEnter(sender As Object, e As EventArgs) Handles BtnClose.MouseEnter
        BtnClose.Image = My.Resources.icons8_close_window_24px_1
    End Sub

    Private Sub BtnClose_MouseLeave(sender As Object, e As EventArgs) Handles BtnClose.MouseLeave
        BtnClose.Image = My.Resources.icons8_close_window_24px
    End Sub

    Private Sub BtnMxi_MouseEnter(sender As Object, e As EventArgs) Handles BtnMxi.MouseEnter
        BtnMxi.Image = My.Resources.icons8_maximize_window_24px_1
    End Sub
    Private Sub Btnmxi_MouseLeave(sender As Object, e As EventArgs) Handles BtnMxi.MouseLeave
        BtnMxi.Image = My.Resources.icons8_maximize_window_24px
    End Sub
    Private Sub BtnMni_MouseEnter(sender As Object, e As EventArgs) Handles BtnMini.MouseEnter
        BtnMini.Image = My.Resources.icons8_minimize_window_24px_1
    End Sub
    Private Sub BtnMini_MouseEnter(sender As Object, e As EventArgs) Handles BtnMini.MouseLeave
        BtnMini.Image = My.Resources.icons8_minimize_window_24px
    End Sub
#End Region
    'Abrir Formularios
    '  Private Sub AbrirFrmEnPanel(Of Miform As {Form, New})()
    'Dim Formulario As Form
    '     Formulario = PanelFrms.Controls.OfType(Of Miform)().FirstOrDefault() 'Busca el formulario
    'Si form no se encuentra/no existe
    '   If Formulario Is Nothing Then
    '      Formulario = New Miform()
    '   Formulario.TopLevel = False
    '      PanelFrms.Controls.Add(Formulario)
    '      PanelFrms.Tag = Formulario
    '       Formulario.Show()
    '   Else
    '     Formulario.BringToFront()
    '   End If
    '  End Sub



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
        LblTop.Text = childForm.Text
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnBolFrm2.Click
        OpenChildForm(New Boletas)
    End Sub
    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        OpenChildForm(New FrmStart)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenChildForm(New Form3)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenChildForm(New FrmStart)
    End Sub
End Class
