﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.BtnMxi = New System.Windows.Forms.PictureBox()
        Me.BtnMini = New System.Windows.Forms.PictureBox()
        Me.BtnClose = New System.Windows.Forms.PictureBox()
        Me.PlnMenu = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Btneditar = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnCls = New System.Windows.Forms.Button()
        Me.Btnsettings = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PbLogo = New System.Windows.Forms.PictureBox()
        Me.Lblem = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.LblPos = New System.Windows.Forms.Label()
        Me.BtnBole = New System.Windows.Forms.Button()
        Me.PanelFrms = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PanelContenedor.SuspendLayout()
        Me.PlnHead.SuspendLayout()
        CType(Me.BtnMxi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnMini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PlnMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFrms.SuspendLayout()
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
        Me.PanelContenedor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1273, 672)
        Me.PanelContenedor.TabIndex = 0
        '
        'PlnHead
        '
        Me.PlnHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PlnHead.Controls.Add(Me.LblTop)
        Me.PlnHead.Controls.Add(Me.BtnMxi)
        Me.PlnHead.Controls.Add(Me.BtnMini)
        Me.PlnHead.Controls.Add(Me.BtnClose)
        Me.PlnHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.PlnHead.Location = New System.Drawing.Point(251, 0)
        Me.PlnHead.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PlnHead.Name = "PlnHead"
        Me.PlnHead.Size = New System.Drawing.Size(1022, 49)
        Me.PlnHead.TabIndex = 1
        '
        'LblTop
        '
        Me.LblTop.AutoSize = True
        Me.LblTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTop.ForeColor = System.Drawing.Color.Gainsboro
        Me.LblTop.Location = New System.Drawing.Point(9, 16)
        Me.LblTop.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTop.Name = "LblTop"
        Me.LblTop.Size = New System.Drawing.Size(0, 17)
        Me.LblTop.TabIndex = 3
        '
        'BtnMxi
        '
        Me.BtnMxi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMxi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMxi.Image = Global.SB.My.Resources.Resources.icons8_maximize_window_24px
        Me.BtnMxi.Location = New System.Drawing.Point(947, 4)
        Me.BtnMxi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnMxi.Name = "BtnMxi"
        Me.BtnMxi.Size = New System.Drawing.Size(24, 24)
        Me.BtnMxi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BtnMxi.TabIndex = 2
        Me.BtnMxi.TabStop = False
        '
        'BtnMini
        '
        Me.BtnMini.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMini.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMini.Image = Global.SB.My.Resources.Resources.icons8_minimize_window_24px
        Me.BtnMini.Location = New System.Drawing.Point(907, 4)
        Me.BtnMini.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.BtnClose.Location = New System.Drawing.Point(987, 4)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(24, 24)
        Me.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BtnClose.TabIndex = 0
        Me.BtnClose.TabStop = False
        '
        'PlnMenu
        '
        Me.PlnMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PlnMenu.Controls.Add(Me.Panel5)
        Me.PlnMenu.Controls.Add(Me.Panel6)
        Me.PlnMenu.Controls.Add(Me.Btneditar)
        Me.PlnMenu.Controls.Add(Me.Panel4)
        Me.PlnMenu.Controls.Add(Me.Panel2)
        Me.PlnMenu.Controls.Add(Me.Panel3)
        Me.PlnMenu.Controls.Add(Me.BtnCls)
        Me.PlnMenu.Controls.Add(Me.Btnsettings)
        Me.PlnMenu.Controls.Add(Me.Button2)
        Me.PlnMenu.Controls.Add(Me.Panel1)
        Me.PlnMenu.Controls.Add(Me.BtnBole)
        Me.PlnMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PlnMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlnMenu.Location = New System.Drawing.Point(0, 0)
        Me.PlnMenu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PlnMenu.Name = "PlnMenu"
        Me.PlnMenu.Size = New System.Drawing.Size(251, 672)
        Me.PlnMenu.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(0, 514)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(13, 39)
        Me.Panel6.TabIndex = 9
        '
        'Btneditar
        '
        Me.Btneditar.FlatAppearance.BorderSize = 0
        Me.Btneditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Btneditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btneditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btneditar.ForeColor = System.Drawing.Color.Gainsboro
        Me.Btneditar.Location = New System.Drawing.Point(4, 514)
        Me.Btneditar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btneditar.Name = "Btneditar"
        Me.Btneditar.Size = New System.Drawing.Size(243, 39)
        Me.Btneditar.TabIndex = 8
        Me.Btneditar.Text = "Editar Perfil"
        Me.Btneditar.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Red
        Me.Panel4.Location = New System.Drawing.Point(0, 586)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(13, 39)
        Me.Panel4.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 295)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(13, 39)
        Me.Panel2.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 249)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(13, 39)
        Me.Panel3.TabIndex = 4
        '
        'BtnCls
        '
        Me.BtnCls.FlatAppearance.BorderSize = 0
        Me.BtnCls.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.BtnCls.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnCls.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCls.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCls.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnCls.Location = New System.Drawing.Point(0, 633)
        Me.BtnCls.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnCls.Name = "BtnCls"
        Me.BtnCls.Size = New System.Drawing.Size(247, 39)
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
        Me.Btnsettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsettings.ForeColor = System.Drawing.Color.Gainsboro
        Me.Btnsettings.Location = New System.Drawing.Point(4, 586)
        Me.Btnsettings.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btnsettings.Name = "Btnsettings"
        Me.Btnsettings.Size = New System.Drawing.Size(243, 39)
        Me.Btnsettings.TabIndex = 2
        Me.Btnsettings.Text = "Ajustes"
        Me.Btnsettings.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button2.Location = New System.Drawing.Point(4, 295)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(243, 39)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Botón de prueba"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PbLogo)
        Me.Panel1.Controls.Add(Me.Lblem)
        Me.Panel1.Controls.Add(Me.LblName)
        Me.Panel1.Controls.Add(Me.LblPos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(251, 219)
        Me.Panel1.TabIndex = 0
        '
        'PbLogo
        '
        Me.PbLogo.Image = Global.SB.My.Resources.Resources.icons8_teacher_96px
        Me.PbLogo.Location = New System.Drawing.Point(0, 0)
        Me.PbLogo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PbLogo.Name = "PbLogo"
        Me.PbLogo.Size = New System.Drawing.Size(251, 100)
        Me.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PbLogo.TabIndex = 0
        Me.PbLogo.TabStop = False
        '
        'Lblem
        '
        Me.Lblem.AutoSize = True
        Me.Lblem.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblem.ForeColor = System.Drawing.Color.Gainsboro
        Me.Lblem.Location = New System.Drawing.Point(28, 187)
        Me.Lblem.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblem.Name = "Lblem"
        Me.Lblem.Size = New System.Drawing.Size(42, 17)
        Me.Lblem.TabIndex = 2
        Me.Lblem.Text = "Email"
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName.ForeColor = System.Drawing.Color.Gainsboro
        Me.LblName.Location = New System.Drawing.Point(28, 153)
        Me.LblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(58, 17)
        Me.LblName.TabIndex = 1
        Me.LblName.Text = "Nombre"
        '
        'LblPos
        '
        Me.LblPos.AutoSize = True
        Me.LblPos.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPos.ForeColor = System.Drawing.Color.Gainsboro
        Me.LblPos.Location = New System.Drawing.Point(28, 119)
        Me.LblPos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPos.Name = "LblPos"
        Me.LblPos.Size = New System.Drawing.Size(52, 17)
        Me.LblPos.TabIndex = 0
        Me.LblPos.Text = "Puesto"
        '
        'BtnBole
        '
        Me.BtnBole.FlatAppearance.BorderSize = 0
        Me.BtnBole.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.BtnBole.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.BtnBole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBole.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBole.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnBole.Location = New System.Drawing.Point(4, 249)
        Me.BtnBole.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnBole.Name = "BtnBole"
        Me.BtnBole.Size = New System.Drawing.Size(243, 39)
        Me.BtnBole.TabIndex = 0
        Me.BtnBole.Text = "Boletas"
        Me.BtnBole.UseVisualStyleBackColor = True
        '
        'PanelFrms
        '
        Me.PanelFrms.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.PanelFrms.Controls.Add(Me.Label2)
        Me.PanelFrms.Controls.Add(Me.Label1)
        Me.PanelFrms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFrms.Location = New System.Drawing.Point(0, 0)
        Me.PanelFrms.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelFrms.Name = "PanelFrms"
        Me.PanelFrms.Size = New System.Drawing.Size(1273, 672)
        Me.PanelFrms.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(515, 441)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(526, 92)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Para empezar presiones las " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "secciones de la izquierda"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(672, 305)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Logo "
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Red
        Me.Panel5.Location = New System.Drawing.Point(0, 633)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(13, 39)
        Me.Panel5.TabIndex = 10
        '
        'FrmStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1273, 672)
        Me.Controls.Add(Me.PanelContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(727, 481)
        Me.Name = "FrmStart"
        Me.Opacity = 0.95R
        Me.Text = "Sistema de Boletas Digitales"
        Me.PanelContenedor.ResumeLayout(False)
        Me.PlnHead.ResumeLayout(False)
        Me.PlnHead.PerformLayout()
        CType(Me.BtnMxi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnMini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PlnMenu.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFrms.ResumeLayout(False)
        Me.PanelFrms.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents PlnHead As Panel
    Friend WithEvents PanelFrms As Panel
    Friend WithEvents BtnClose As PictureBox
    Friend WithEvents PlnMenu As Panel
    Friend WithEvents BtnMxi As PictureBox
    Friend WithEvents BtnMini As PictureBox
    Friend WithEvents Btnsettings As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnBole As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PbLogo As PictureBox
    Friend WithEvents LblTop As Label
    Friend WithEvents BtnCls As Button
    Friend WithEvents Lblem As Label
    Friend WithEvents LblName As Label
    Friend WithEvents LblPos As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Btneditar As Button
    Friend WithEvents Panel5 As Panel
End Class