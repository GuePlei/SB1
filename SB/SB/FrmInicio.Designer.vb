<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInicio))
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PlnHead = New System.Windows.Forms.Panel()
        Me.LblTop = New System.Windows.Forms.Label()
        Me.BtnMini = New System.Windows.Forms.PictureBox()
        Me.BtnClose = New System.Windows.Forms.PictureBox()
        Me.Lblh = New System.Windows.Forms.Label()
        Me.PlnMenu = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Btneditar = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnCls = New System.Windows.Forms.Button()
        Me.Btnsettings = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PbLogo = New System.Windows.Forms.PictureBox()
        Me.Lblem = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.LblPos = New System.Windows.Forms.Label()
        Me.BtnBole = New System.Windows.Forms.Button()
        Me.PanelFrms = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelContenedor.SuspendLayout()
        Me.PlnHead.SuspendLayout()
        CType(Me.BtnMini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PlnMenu.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFrms.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.PanelContenedor.Controls.Add(Me.PlnHead)
        Me.PanelContenedor.Controls.Add(Me.PlnMenu)
        Me.PanelContenedor.Controls.Add(Me.PanelFrms)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(955, 546)
        Me.PanelContenedor.TabIndex = 0
        '
        'PlnHead
        '
        Me.PlnHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PlnHead.Controls.Add(Me.LblTop)
        Me.PlnHead.Controls.Add(Me.BtnMini)
        Me.PlnHead.Controls.Add(Me.BtnClose)
        Me.PlnHead.Controls.Add(Me.Lblh)
        Me.PlnHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.PlnHead.Location = New System.Drawing.Point(188, 0)
        Me.PlnHead.Name = "PlnHead"
        Me.PlnHead.Size = New System.Drawing.Size(767, 40)
        Me.PlnHead.TabIndex = 1
        '
        'LblTop
        '
        Me.LblTop.AutoSize = True
        Me.LblTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTop.ForeColor = System.Drawing.Color.Gainsboro
        Me.LblTop.Location = New System.Drawing.Point(7, 13)
        Me.LblTop.Name = "LblTop"
        Me.LblTop.Size = New System.Drawing.Size(0, 13)
        Me.LblTop.TabIndex = 3
        '
        'BtnMini
        '
        Me.BtnMini.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMini.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMini.Image = Global.SB.My.Resources.Resources.icons8_minimize_window_24px
        Me.BtnMini.Location = New System.Drawing.Point(711, 3)
        Me.BtnMini.Name = "BtnMini"
        Me.BtnMini.Size = New System.Drawing.Size(24, 24)
        Me.BtnMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BtnMini.TabIndex = 1
        Me.BtnMini.TabStop = False
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.Image = Global.SB.My.Resources.Resources.icons8_close_window_24px
        Me.BtnClose.Location = New System.Drawing.Point(741, 3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(24, 24)
        Me.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BtnClose.TabIndex = 0
        Me.BtnClose.TabStop = False
        '
        'Lblh
        '
        Me.Lblh.AutoSize = True
        Me.Lblh.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblh.ForeColor = System.Drawing.Color.Gainsboro
        Me.Lblh.Location = New System.Drawing.Point(13, 9)
        Me.Lblh.Name = "Lblh"
        Me.Lblh.Size = New System.Drawing.Size(195, 19)
        Me.Lblh.TabIndex = 3
        Me.Lblh.Text = "Sistema de Boletas Digitales"
        '
        'PlnMenu
        '
        Me.PlnMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PlnMenu.Controls.Add(Me.Panel2)
        Me.PlnMenu.Controls.Add(Me.Button1)
        Me.PlnMenu.Controls.Add(Me.Panel5)
        Me.PlnMenu.Controls.Add(Me.Panel6)
        Me.PlnMenu.Controls.Add(Me.Btneditar)
        Me.PlnMenu.Controls.Add(Me.Panel4)
        Me.PlnMenu.Controls.Add(Me.Panel3)
        Me.PlnMenu.Controls.Add(Me.BtnCls)
        Me.PlnMenu.Controls.Add(Me.Btnsettings)
        Me.PlnMenu.Controls.Add(Me.Panel1)
        Me.PlnMenu.Controls.Add(Me.BtnBole)
        Me.PlnMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PlnMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlnMenu.Location = New System.Drawing.Point(0, 0)
        Me.PlnMenu.Name = "PlnMenu"
        Me.PlnMenu.Size = New System.Drawing.Size(188, 546)
        Me.PlnMenu.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Red
        Me.Panel5.Location = New System.Drawing.Point(0, 514)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(10, 32)
        Me.Panel5.TabIndex = 10
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(0, 388)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(10, 32)
        Me.Panel6.TabIndex = 9
        '
        'Btneditar
        '
        Me.Btneditar.FlatAppearance.BorderSize = 0
        Me.Btneditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Btneditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btneditar.Font = New System.Drawing.Font("Roboto Condensed", 9.0!)
        Me.Btneditar.ForeColor = System.Drawing.Color.Gainsboro
        Me.Btneditar.Location = New System.Drawing.Point(3, 388)
        Me.Btneditar.Name = "Btneditar"
        Me.Btneditar.Size = New System.Drawing.Size(182, 32)
        Me.Btneditar.TabIndex = 1
        Me.Btneditar.Text = "Mi Perfil"
        Me.Btneditar.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Red
        Me.Panel4.Controls.Add(Me.Panel7)
        Me.Panel4.Location = New System.Drawing.Point(0, 476)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 32)
        Me.Panel4.TabIndex = 6
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.DarkRed
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(10, 32)
        Me.Panel7.TabIndex = 7
        Me.Panel7.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 202)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 32)
        Me.Panel3.TabIndex = 4
        '
        'BtnCls
        '
        Me.BtnCls.FlatAppearance.BorderSize = 0
        Me.BtnCls.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.BtnCls.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnCls.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCls.Font = New System.Drawing.Font("Roboto Condensed", 9.0!)
        Me.BtnCls.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnCls.Location = New System.Drawing.Point(0, 514)
        Me.BtnCls.Name = "BtnCls"
        Me.BtnCls.Size = New System.Drawing.Size(185, 32)
        Me.BtnCls.TabIndex = 3
        Me.BtnCls.Text = "Cerrar Sesión"
        Me.BtnCls.UseVisualStyleBackColor = True
        '
        'Btnsettings
        '
        Me.Btnsettings.FlatAppearance.BorderSize = 0
        Me.Btnsettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Btnsettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Btnsettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnsettings.Font = New System.Drawing.Font("Roboto Condensed", 9.0!)
        Me.Btnsettings.ForeColor = System.Drawing.Color.Gainsboro
        Me.Btnsettings.Location = New System.Drawing.Point(3, 476)
        Me.Btnsettings.Name = "Btnsettings"
        Me.Btnsettings.Size = New System.Drawing.Size(182, 32)
        Me.Btnsettings.TabIndex = 2
        Me.Btnsettings.Text = "Ajustes"
        Me.Btnsettings.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PbLogo)
        Me.Panel1.Controls.Add(Me.Lblem)
        Me.Panel1.Controls.Add(Me.LblName)
        Me.Panel1.Controls.Add(Me.LblPos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(188, 178)
        Me.Panel1.TabIndex = 0
        '
        'PbLogo
        '
        Me.PbLogo.Image = Global.SB.My.Resources.Resources.icons8_teacher_96px
        Me.PbLogo.Location = New System.Drawing.Point(0, 0)
        Me.PbLogo.Name = "PbLogo"
        Me.PbLogo.Size = New System.Drawing.Size(188, 81)
        Me.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PbLogo.TabIndex = 0
        Me.PbLogo.TabStop = False
        '
        'Lblem
        '
        Me.Lblem.AutoSize = True
        Me.Lblem.Font = New System.Drawing.Font("Roboto Condensed", 9.5!)
        Me.Lblem.ForeColor = System.Drawing.Color.Gainsboro
        Me.Lblem.Location = New System.Drawing.Point(10, 152)
        Me.Lblem.Name = "Lblem"
        Me.Lblem.Size = New System.Drawing.Size(35, 15)
        Me.Lblem.TabIndex = 2
        Me.Lblem.Text = "Email"
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Font = New System.Drawing.Font("Roboto Condensed", 9.5!)
        Me.LblName.ForeColor = System.Drawing.Color.Gainsboro
        Me.LblName.Location = New System.Drawing.Point(10, 97)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(48, 15)
        Me.LblName.TabIndex = 1
        Me.LblName.Text = "Nombre"
        '
        'LblPos
        '
        Me.LblPos.AutoSize = True
        Me.LblPos.Font = New System.Drawing.Font("Roboto Condensed", 9.5!)
        Me.LblPos.ForeColor = System.Drawing.Color.Gainsboro
        Me.LblPos.Location = New System.Drawing.Point(10, 124)
        Me.LblPos.Name = "LblPos"
        Me.LblPos.Size = New System.Drawing.Size(43, 15)
        Me.LblPos.TabIndex = 0
        Me.LblPos.Text = "Puesto"
        '
        'BtnBole
        '
        Me.BtnBole.FlatAppearance.BorderSize = 0
        Me.BtnBole.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.BtnBole.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.BtnBole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBole.Font = New System.Drawing.Font("Roboto Condensed", 9.0!)
        Me.BtnBole.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnBole.Location = New System.Drawing.Point(3, 202)
        Me.BtnBole.Name = "BtnBole"
        Me.BtnBole.Size = New System.Drawing.Size(182, 32)
        Me.BtnBole.TabIndex = 0
        Me.BtnBole.Text = "Boletas"
        Me.BtnBole.UseVisualStyleBackColor = True
        '
        'PanelFrms
        '
        Me.PanelFrms.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.PanelFrms.Controls.Add(Me.PictureBox1)
        Me.PanelFrms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFrms.Location = New System.Drawing.Point(0, 0)
        Me.PanelFrms.Name = "PanelFrms"
        Me.PanelFrms.Size = New System.Drawing.Size(955, 546)
        Me.PanelFrms.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SB.My.Resources.Resources.Escudo4
        Me.PictureBox1.Location = New System.Drawing.Point(827, 418)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Roboto Condensed", 9.0!)
        Me.Button1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button1.Location = New System.Drawing.Point(3, 426)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(182, 32)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Acerca de"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 426)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 32)
        Me.Panel2.TabIndex = 12
        '
        'FrmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(955, 546)
        Me.Controls.Add(Me.PanelContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(545, 391)
        Me.Name = "FrmInicio"
        Me.Opacity = 0.95R
        Me.Text = "Sistema de Boletas Digitales"
        Me.PanelContenedor.ResumeLayout(False)
        Me.PlnHead.ResumeLayout(False)
        Me.PlnHead.PerformLayout()
        CType(Me.BtnMini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PlnMenu.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFrms.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents PlnHead As Panel
    Friend WithEvents PanelFrms As Panel
    Friend WithEvents BtnClose As PictureBox
    Friend WithEvents PlnMenu As Panel
    Friend WithEvents BtnMini As PictureBox
    Friend WithEvents Btnsettings As Button
    Friend WithEvents BtnBole As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PbLogo As PictureBox
    Friend WithEvents LblTop As Label
    Friend WithEvents BtnCls As Button
    Friend WithEvents Lblem As Label
    Friend WithEvents LblName As Label
    Friend WithEvents LblPos As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Btneditar As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Lblh As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
End Class
