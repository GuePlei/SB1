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
    Private Sub BtnMxi_Click(sender As Object, e As EventArgs) Handles BtnMxi.Click
        Call Winstate()
    End Sub
    Private Sub PlnHead_DoubleClick(sender As Object, e As EventArgs) Handles PlnHead.DoubleClick
        Call Winstate()
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

    'Función para maximizar y cambiar iconos
    Private Sub Winstate()
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
    Private Sub BtnCls_Click(sender As Object, e As EventArgs) Handles BtnCls.Click
        If MessageBox.Show("¿Estás seguro de querer cerrar sesión?", "¡Atención!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()

        End If

    End Sub

    'RESIZE DEL FORMULARIO- CAMBIAR TAMAÑO'
    Dim cGrip As Integer = 10
    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = 132) Then
            Dim pos As Point = New Point((m.LParam.ToInt32 And 65535), (m.LParam.ToInt32 + 16))
            pos = Me.PointToClient(pos)
            If ((pos.X _
                    >= (Me.ClientSize.Width - cGrip)) _
                    AndAlso (pos.Y _
                    >= (Me.ClientSize.Height - cGrip))) Then
                m.Result = CType(17, IntPtr)
                Return
            End If
        End If
        MyBase.WndProc(m)
    End Sub
    '----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL' 
    Dim sizeGripRectangle As Rectangle
    Dim tolerance As Integer = 15
    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        MyBase.OnSizeChanged(e)
        Dim region = New Region(New Rectangle(0, 0, Me.ClientRectangle.Width, Me.ClientRectangle.Height))
        sizeGripRectangle = New Rectangle((Me.ClientRectangle.Width - tolerance), (Me.ClientRectangle.Height - tolerance), tolerance, tolerance)
        region.Exclude(sizeGripRectangle)
        Me.PanelContenedor.Region = region
        Me.Invalidate()
    End Sub
    '----------------COLOR Y GRIP DE RECTANGULO INFERIOR'
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim blueBrush As SolidBrush = New SolidBrush(Color.FromArgb(34, 33, 74))
        e.Graphics.FillRectangle(blueBrush, sizeGripRectangle)
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
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenChildForm(New Form3)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Btnsettings.Click
        OpenChildForm(New FrmAjustes)
    End Sub
#End Region
    Private Sub Administraciondepermisos()
        If ActiveUser.position = Puestos.Manager Then
            Btnsettings.Enabled = False

        End If
        If ActiveUser.position = Puestos.CEO Then
            Btnsettings.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Btneditar.Click
        OpenChildForm(New FrmEditar)
    End Sub

    Private Sub Pbuser_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PanelFrms_Paint(sender As Object, e As PaintEventArgs) Handles PanelFrms.Paint

    End Sub

    Private Sub PlnMenu_Paint(sender As Object, e As PaintEventArgs) Handles PlnMenu.Paint

    End Sub
End Class
