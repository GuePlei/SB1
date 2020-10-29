<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recuperar_Contraseña
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Recuperar_Contraseña))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblResult = New System.Windows.Forms.Label()
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.BtnSend = New System.Windows.Forms.Button()
        Me.PlnHead = New System.Windows.Forms.Panel()
        Me.LblTop = New System.Windows.Forms.Label()
        Me.BtnMini = New System.Windows.Forms.PictureBox()
        Me.BtnClose = New System.Windows.Forms.PictureBox()
        Me.PanelBottom = New System.Windows.Forms.Panel()
        Me.PlnHead.SuspendLayout()
        CType(Me.BtnMini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(29, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(282, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese su usuario o su Correo Electrónico"
        '
        'LblResult
        '
        Me.LblResult.AutoSize = True
        Me.LblResult.ForeColor = System.Drawing.Color.Gainsboro
        Me.LblResult.Location = New System.Drawing.Point(30, 254)
        Me.LblResult.Name = "LblResult"
        Me.LblResult.Size = New System.Drawing.Size(0, 13)
        Me.LblResult.TabIndex = 1
        '
        'TxtUser
        '
        Me.TxtUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.TxtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUser.ForeColor = System.Drawing.Color.White
        Me.TxtUser.Location = New System.Drawing.Point(78, 148)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(175, 20)
        Me.TxtUser.TabIndex = 2
        '
        'BtnSend
        '
        Me.BtnSend.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.BtnSend.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnSend.FlatAppearance.BorderSize = 0
        Me.BtnSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.BtnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.BtnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSend.Font = New System.Drawing.Font("Roboto Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSend.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnSend.Location = New System.Drawing.Point(103, 220)
        Me.BtnSend.Name = "BtnSend"
        Me.BtnSend.Size = New System.Drawing.Size(125, 23)
        Me.BtnSend.TabIndex = 3
        Me.BtnSend.Text = "Enviar"
        Me.BtnSend.UseVisualStyleBackColor = False
        '
        'PlnHead
        '
        Me.PlnHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PlnHead.Controls.Add(Me.LblTop)
        Me.PlnHead.Controls.Add(Me.BtnMini)
        Me.PlnHead.Controls.Add(Me.BtnClose)
        Me.PlnHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.PlnHead.Location = New System.Drawing.Point(0, 0)
        Me.PlnHead.Name = "PlnHead"
        Me.PlnHead.Size = New System.Drawing.Size(335, 40)
        Me.PlnHead.TabIndex = 4
        '
        'LblTop
        '
        Me.LblTop.AutoSize = True
        Me.LblTop.Font = New System.Drawing.Font("Roboto Condensed", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTop.ForeColor = System.Drawing.Color.Gainsboro
        Me.LblTop.Location = New System.Drawing.Point(7, 13)
        Me.LblTop.Name = "LblTop"
        Me.LblTop.Size = New System.Drawing.Size(0, 13)
        Me.LblTop.TabIndex = 3
        '
        'BtnMini
        '
        Me.BtnMini.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMini.Image = Global.SB.My.Resources.Resources.icons8_minimize_window_24px
        Me.BtnMini.Location = New System.Drawing.Point(278, 3)
        Me.BtnMini.Name = "BtnMini"
        Me.BtnMini.Size = New System.Drawing.Size(24, 24)
        Me.BtnMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BtnMini.TabIndex = 1
        Me.BtnMini.TabStop = False
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.Image = Global.SB.My.Resources.Resources.icons8_close_window_24px
        Me.BtnClose.Location = New System.Drawing.Point(308, 3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(24, 24)
        Me.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BtnClose.TabIndex = 0
        Me.BtnClose.TabStop = False
        '
        'PanelBottom
        '
        Me.PanelBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBottom.Location = New System.Drawing.Point(0, 428)
        Me.PanelBottom.Name = "PanelBottom"
        Me.PanelBottom.Size = New System.Drawing.Size(335, 15)
        Me.PanelBottom.TabIndex = 5
        '
        'Recuperar_Contraseña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(335, 443)
        Me.Controls.Add(Me.PanelBottom)
        Me.Controls.Add(Me.PlnHead)
        Me.Controls.Add(Me.BtnSend)
        Me.Controls.Add(Me.TxtUser)
        Me.Controls.Add(Me.LblResult)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Recuperar_Contraseña"
        Me.Text = "Recuperar Contraseña"
        Me.PlnHead.ResumeLayout(False)
        Me.PlnHead.PerformLayout()
        CType(Me.BtnMini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LblResult As Label
    Friend WithEvents TxtUser As TextBox
    Friend WithEvents BtnSend As Button
    Friend WithEvents PlnHead As Panel
    Friend WithEvents LblTop As Label
    Friend WithEvents BtnMini As PictureBox
    Friend WithEvents BtnClose As PictureBox
    Friend WithEvents PanelBottom As Panel
End Class
