<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Boletas
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Boleta = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Tipobole = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PbLogo = New System.Windows.Forms.PictureBox()
        Me.tipo1 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.tipo2 = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.tipo3 = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Subpanel = New System.Windows.Forms.Panel()
        Me.Subpanel2 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.boleta3 = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.boleta2 = New System.Windows.Forms.Button()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.boleta1 = New System.Windows.Forms.Button()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Subpanel.SuspendLayout()
        Me.Subpanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(99, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre de estudiante"
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.Image = Global.SB.My.Resources.Resources.icons8_close_window_24px
        Me.BtnClose.Location = New System.Drawing.Point(3, 3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(24, 24)
        Me.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BtnClose.TabIndex = 1
        Me.BtnClose.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PbLogo)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(767, 100)
        Me.Panel1.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.SB.My.Resources.Resources.icons8_close_window_24px
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Subpanel2)
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Controls.Add(Me.Tipobole)
        Me.Panel2.Controls.Add(Me.Subpanel)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Boleta)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 100)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(195, 409)
        Me.Panel2.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 158)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 40)
        Me.Panel3.TabIndex = 2
        '
        'Boleta
        '
        Me.Boleta.FlatAppearance.BorderSize = 0
        Me.Boleta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Boleta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Boleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Boleta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boleta.ForeColor = System.Drawing.Color.Gainsboro
        Me.Boleta.Location = New System.Drawing.Point(10, 158)
        Me.Boleta.Name = "Boleta"
        Me.Boleta.Size = New System.Drawing.Size(182, 40)
        Me.Boleta.TabIndex = 1
        Me.Boleta.Text = "Seccion"
        Me.Boleta.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel8.Location = New System.Drawing.Point(0, 6)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(10, 40)
        Me.Panel8.TabIndex = 5
        '
        'Tipobole
        '
        Me.Tipobole.FlatAppearance.BorderSize = 0
        Me.Tipobole.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Tipobole.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Tipobole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Tipobole.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tipobole.ForeColor = System.Drawing.Color.Gainsboro
        Me.Tipobole.Location = New System.Drawing.Point(10, 6)
        Me.Tipobole.Name = "Tipobole"
        Me.Tipobole.Size = New System.Drawing.Size(182, 40)
        Me.Tipobole.TabIndex = 4
        Me.Tipobole.Text = "Tipo de boleta"
        Me.Tipobole.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TextBox1.Location = New System.Drawing.Point(263, 55)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 4
        '
        'PbLogo
        '
        Me.PbLogo.Image = Global.SB.My.Resources.Resources.icons8_teacher_96px
        Me.PbLogo.Location = New System.Drawing.Point(579, 0)
        Me.PbLogo.Name = "PbLogo"
        Me.PbLogo.Size = New System.Drawing.Size(188, 100)
        Me.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PbLogo.TabIndex = 5
        Me.PbLogo.TabStop = False
        Me.PbLogo.Visible = False
        '
        'tipo1
        '
        Me.tipo1.FlatAppearance.BorderSize = 0
        Me.tipo1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.tipo1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.tipo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tipo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipo1.ForeColor = System.Drawing.Color.Gainsboro
        Me.tipo1.Location = New System.Drawing.Point(12, 3)
        Me.tipo1.Name = "tipo1"
        Me.tipo1.Size = New System.Drawing.Size(144, 28)
        Me.tipo1.TabIndex = 3
        Me.tipo1.Text = "tipo1"
        Me.tipo1.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(2, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(10, 28)
        Me.Panel5.TabIndex = 4
        '
        'tipo2
        '
        Me.tipo2.FlatAppearance.BorderSize = 0
        Me.tipo2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.tipo2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.tipo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tipo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipo2.ForeColor = System.Drawing.Color.Gainsboro
        Me.tipo2.Location = New System.Drawing.Point(12, 36)
        Me.tipo2.Name = "tipo2"
        Me.tipo2.Size = New System.Drawing.Size(144, 28)
        Me.tipo2.TabIndex = 5
        Me.tipo2.Text = "tipo2"
        Me.tipo2.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(2, 36)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(10, 28)
        Me.Panel6.TabIndex = 6
        '
        'tipo3
        '
        Me.tipo3.FlatAppearance.BorderSize = 0
        Me.tipo3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.tipo3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.tipo3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tipo3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipo3.ForeColor = System.Drawing.Color.Gainsboro
        Me.tipo3.Location = New System.Drawing.Point(12, 69)
        Me.tipo3.Name = "tipo3"
        Me.tipo3.Size = New System.Drawing.Size(144, 28)
        Me.tipo3.TabIndex = 7
        Me.tipo3.Text = "tipo3"
        Me.tipo3.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel7.Location = New System.Drawing.Point(2, 69)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(10, 28)
        Me.Panel7.TabIndex = 8
        '
        'Subpanel
        '
        Me.Subpanel.Controls.Add(Me.Panel7)
        Me.Subpanel.Controls.Add(Me.tipo3)
        Me.Subpanel.Controls.Add(Me.Panel6)
        Me.Subpanel.Controls.Add(Me.tipo2)
        Me.Subpanel.Controls.Add(Me.Panel5)
        Me.Subpanel.Controls.Add(Me.tipo1)
        Me.Subpanel.Location = New System.Drawing.Point(36, 52)
        Me.Subpanel.Name = "Subpanel"
        Me.Subpanel.Size = New System.Drawing.Size(159, 100)
        Me.Subpanel.TabIndex = 3
        Me.Subpanel.Visible = False
        '
        'Subpanel2
        '
        Me.Subpanel2.Controls.Add(Me.Panel9)
        Me.Subpanel2.Controls.Add(Me.boleta3)
        Me.Subpanel2.Controls.Add(Me.Panel10)
        Me.Subpanel2.Controls.Add(Me.boleta2)
        Me.Subpanel2.Controls.Add(Me.Panel11)
        Me.Subpanel2.Controls.Add(Me.boleta1)
        Me.Subpanel2.Location = New System.Drawing.Point(36, 216)
        Me.Subpanel2.Name = "Subpanel2"
        Me.Subpanel2.Size = New System.Drawing.Size(159, 100)
        Me.Subpanel2.TabIndex = 6
        Me.Subpanel2.Visible = False
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel9.Location = New System.Drawing.Point(2, 69)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(10, 28)
        Me.Panel9.TabIndex = 8
        '
        'boleta3
        '
        Me.boleta3.FlatAppearance.BorderSize = 0
        Me.boleta3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.boleta3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.boleta3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.boleta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boleta3.ForeColor = System.Drawing.Color.Gainsboro
        Me.boleta3.Location = New System.Drawing.Point(12, 69)
        Me.boleta3.Name = "boleta3"
        Me.boleta3.Size = New System.Drawing.Size(144, 28)
        Me.boleta3.TabIndex = 7
        Me.boleta3.Text = "15 puntos"
        Me.boleta3.UseVisualStyleBackColor = True
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel10.Location = New System.Drawing.Point(2, 36)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(10, 28)
        Me.Panel10.TabIndex = 6
        '
        'boleta2
        '
        Me.boleta2.FlatAppearance.BorderSize = 0
        Me.boleta2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.boleta2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.boleta2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.boleta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boleta2.ForeColor = System.Drawing.Color.Gainsboro
        Me.boleta2.Location = New System.Drawing.Point(12, 36)
        Me.boleta2.Name = "boleta2"
        Me.boleta2.Size = New System.Drawing.Size(144, 28)
        Me.boleta2.TabIndex = 5
        Me.boleta2.Text = "30 puntos"
        Me.boleta2.UseVisualStyleBackColor = True
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel11.Location = New System.Drawing.Point(2, 3)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(10, 28)
        Me.Panel11.TabIndex = 4
        '
        'boleta1
        '
        Me.boleta1.FlatAppearance.BorderSize = 0
        Me.boleta1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.boleta1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.boleta1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.boleta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boleta1.ForeColor = System.Drawing.Color.Gainsboro
        Me.boleta1.Location = New System.Drawing.Point(12, 3)
        Me.boleta1.Name = "boleta1"
        Me.boleta1.Size = New System.Drawing.Size(144, 28)
        Me.boleta1.TabIndex = 3
        Me.boleta1.Text = "45 puntos"
        Me.boleta1.UseVisualStyleBackColor = True
        '
        'Boletas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(767, 509)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Boletas"
        Me.Text = "Boletas"
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Subpanel.ResumeLayout(False)
        Me.Subpanel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnClose As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Boleta As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Tipobole As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PbLogo As PictureBox
    Friend WithEvents Subpanel2 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents boleta3 As Button
    Friend WithEvents Panel10 As Panel
    Friend WithEvents boleta2 As Button
    Friend WithEvents Panel11 As Panel
    Friend WithEvents boleta1 As Button
    Friend WithEvents Subpanel As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents tipo3 As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents tipo2 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents tipo1 As Button
End Class
