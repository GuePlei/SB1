<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAjustes
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
        Me.Txtcomfpass = New System.Windows.Forms.TextBox()
        Me.Lblcomfpass = New System.Windows.Forms.Label()
        Me.Txtnewpass = New System.Windows.Forms.TextBox()
        Me.Lblnewpass = New System.Windows.Forms.Label()
        Me.Btnsave = New System.Windows.Forms.Button()
        Me.Txtemail = New System.Windows.Forms.TextBox()
        Me.Txtlname = New System.Windows.Forms.TextBox()
        Me.Txtname = New System.Windows.Forms.TextBox()
        Me.Txtuser = New System.Windows.Forms.TextBox()
        Me.LblPos = New System.Windows.Forms.Label()
        Me.Lblname = New System.Windows.Forms.Label()
        Me.Lbluser = New System.Windows.Forms.Label()
        Me.Lbllname = New System.Windows.Forms.Label()
        Me.Lblemail = New System.Windows.Forms.Label()
        Me.Lbladdu = New System.Windows.Forms.Label()
        Me.Plndelu = New System.Windows.Forms.Panel()
        Me.Lbldeluh = New System.Windows.Forms.Label()
        Me.Btndel = New System.Windows.Forms.Button()
        Me.Txtuserdel = New System.Windows.Forms.TextBox()
        Me.Lbldelu = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.PictureBox()
        Me.CBoxPos = New System.Windows.Forms.ComboBox()
        Me.Plndelu.SuspendLayout()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Txtcomfpass
        '
        Me.Txtcomfpass.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Txtcomfpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtcomfpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcomfpass.ForeColor = System.Drawing.Color.Gainsboro
        Me.Txtcomfpass.Location = New System.Drawing.Point(49, 405)
        Me.Txtcomfpass.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtcomfpass.Name = "Txtcomfpass"
        Me.Txtcomfpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txtcomfpass.Size = New System.Drawing.Size(256, 21)
        Me.Txtcomfpass.TabIndex = 6
        '
        'Lblcomfpass
        '
        Me.Lblcomfpass.AutoSize = True
        Me.Lblcomfpass.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Lblcomfpass.Font = New System.Drawing.Font("Roboto Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblcomfpass.ForeColor = System.Drawing.Color.Gainsboro
        Me.Lblcomfpass.Location = New System.Drawing.Point(46, 375)
        Me.Lblcomfpass.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lblcomfpass.Name = "Lblcomfpass"
        Me.Lblcomfpass.Size = New System.Drawing.Size(143, 18)
        Me.Lblcomfpass.TabIndex = 48
        Me.Lblcomfpass.Text = "Confirmar contraseña: "
        '
        'Txtnewpass
        '
        Me.Txtnewpass.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Txtnewpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtnewpass.Font = New System.Drawing.Font("Roboto Condensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtnewpass.ForeColor = System.Drawing.Color.Gainsboro
        Me.Txtnewpass.Location = New System.Drawing.Point(49, 348)
        Me.Txtnewpass.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtnewpass.Name = "Txtnewpass"
        Me.Txtnewpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txtnewpass.Size = New System.Drawing.Size(256, 22)
        Me.Txtnewpass.TabIndex = 5
        '
        'Lblnewpass
        '
        Me.Lblnewpass.AutoSize = True
        Me.Lblnewpass.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Lblnewpass.Font = New System.Drawing.Font("Roboto Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblnewpass.ForeColor = System.Drawing.Color.Gainsboro
        Me.Lblnewpass.Location = New System.Drawing.Point(46, 319)
        Me.Lblnewpass.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lblnewpass.Name = "Lblnewpass"
        Me.Lblnewpass.Size = New System.Drawing.Size(117, 18)
        Me.Lblnewpass.TabIndex = 46
        Me.Lblnewpass.Text = "Nueva contraseña:"
        '
        'Btnsave
        '
        Me.Btnsave.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Btnsave.FlatAppearance.BorderSize = 0
        Me.Btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnsave.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsave.ForeColor = System.Drawing.Color.Gainsboro
        Me.Btnsave.Location = New System.Drawing.Point(127, 451)
        Me.Btnsave.Name = "Btnsave"
        Me.Btnsave.Size = New System.Drawing.Size(104, 31)
        Me.Btnsave.TabIndex = 7
        Me.Btnsave.Text = "Guardar"
        Me.Btnsave.UseVisualStyleBackColor = False
        '
        'Txtemail
        '
        Me.Txtemail.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Txtemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtemail.Font = New System.Drawing.Font("Roboto Condensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtemail.ForeColor = System.Drawing.Color.Gainsboro
        Me.Txtemail.Location = New System.Drawing.Point(49, 243)
        Me.Txtemail.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtemail.Name = "Txtemail"
        Me.Txtemail.Size = New System.Drawing.Size(256, 22)
        Me.Txtemail.TabIndex = 3
        '
        'Txtlname
        '
        Me.Txtlname.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Txtlname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtlname.Font = New System.Drawing.Font("Roboto Condensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtlname.ForeColor = System.Drawing.Color.Gainsboro
        Me.Txtlname.Location = New System.Drawing.Point(49, 190)
        Me.Txtlname.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtlname.Name = "Txtlname"
        Me.Txtlname.Size = New System.Drawing.Size(256, 22)
        Me.Txtlname.TabIndex = 2
        '
        'Txtname
        '
        Me.Txtname.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtname.Font = New System.Drawing.Font("Roboto Condensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtname.ForeColor = System.Drawing.Color.Gainsboro
        Me.Txtname.Location = New System.Drawing.Point(49, 138)
        Me.Txtname.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtname.Name = "Txtname"
        Me.Txtname.Size = New System.Drawing.Size(256, 22)
        Me.Txtname.TabIndex = 1
        '
        'Txtuser
        '
        Me.Txtuser.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Txtuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtuser.Font = New System.Drawing.Font("Roboto Condensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtuser.ForeColor = System.Drawing.Color.Gainsboro
        Me.Txtuser.Location = New System.Drawing.Point(49, 93)
        Me.Txtuser.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtuser.Name = "Txtuser"
        Me.Txtuser.Size = New System.Drawing.Size(256, 22)
        Me.Txtuser.TabIndex = 0
        '
        'LblPos
        '
        Me.LblPos.AutoSize = True
        Me.LblPos.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblPos.Font = New System.Drawing.Font("Roboto Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPos.ForeColor = System.Drawing.Color.Gainsboro
        Me.LblPos.Location = New System.Drawing.Point(46, 267)
        Me.LblPos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblPos.Name = "LblPos"
        Me.LblPos.Size = New System.Drawing.Size(53, 18)
        Me.LblPos.TabIndex = 39
        Me.LblPos.Text = "Puesto:"
        '
        'Lblname
        '
        Me.Lblname.AutoSize = True
        Me.Lblname.Font = New System.Drawing.Font("Roboto Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblname.ForeColor = System.Drawing.Color.Gainsboro
        Me.Lblname.Location = New System.Drawing.Point(46, 117)
        Me.Lblname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lblname.Name = "Lblname"
        Me.Lblname.Size = New System.Drawing.Size(59, 18)
        Me.Lblname.TabIndex = 38
        Me.Lblname.Text = "Nombre:"
        '
        'Lbluser
        '
        Me.Lbluser.AutoSize = True
        Me.Lbluser.Font = New System.Drawing.Font("Roboto Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbluser.ForeColor = System.Drawing.Color.Gainsboro
        Me.Lbluser.Location = New System.Drawing.Point(46, 69)
        Me.Lbluser.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbluser.Name = "Lbluser"
        Me.Lbluser.Size = New System.Drawing.Size(124, 18)
        Me.Lbluser.TabIndex = 37
        Me.Lbluser.Text = "Nombre de Usuario:"
        '
        'Lbllname
        '
        Me.Lbllname.AutoSize = True
        Me.Lbllname.Font = New System.Drawing.Font("Roboto Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbllname.ForeColor = System.Drawing.Color.Gainsboro
        Me.Lbllname.Location = New System.Drawing.Point(46, 166)
        Me.Lbllname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbllname.Name = "Lbllname"
        Me.Lbllname.Size = New System.Drawing.Size(59, 18)
        Me.Lbllname.TabIndex = 36
        Me.Lbllname.Text = "Apellido:"
        '
        'Lblemail
        '
        Me.Lblemail.AutoSize = True
        Me.Lblemail.Font = New System.Drawing.Font("Roboto Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblemail.ForeColor = System.Drawing.Color.Gainsboro
        Me.Lblemail.Location = New System.Drawing.Point(46, 218)
        Me.Lblemail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lblemail.Name = "Lblemail"
        Me.Lblemail.Size = New System.Drawing.Size(43, 18)
        Me.Lblemail.TabIndex = 35
        Me.Lblemail.Text = "Email:"
        '
        'Lbladdu
        '
        Me.Lbladdu.AutoSize = True
        Me.Lbladdu.Font = New System.Drawing.Font("Roboto Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbladdu.ForeColor = System.Drawing.Color.Gainsboro
        Me.Lbladdu.Location = New System.Drawing.Point(107, 38)
        Me.Lbladdu.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbladdu.Name = "Lbladdu"
        Me.Lbladdu.Size = New System.Drawing.Size(110, 18)
        Me.Lbladdu.TabIndex = 73
        Me.Lbladdu.Text = "Agregar Usuarios"
        '
        'Plndelu
        '
        Me.Plndelu.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Plndelu.Controls.Add(Me.Lbldeluh)
        Me.Plndelu.Controls.Add(Me.Btndel)
        Me.Plndelu.Controls.Add(Me.Txtuserdel)
        Me.Plndelu.Controls.Add(Me.Lbldelu)
        Me.Plndelu.Dock = System.Windows.Forms.DockStyle.Right
        Me.Plndelu.Location = New System.Drawing.Point(428, 0)
        Me.Plndelu.Name = "Plndelu"
        Me.Plndelu.Size = New System.Drawing.Size(339, 509)
        Me.Plndelu.TabIndex = 74
        '
        'Lbldeluh
        '
        Me.Lbldeluh.AutoSize = True
        Me.Lbldeluh.Font = New System.Drawing.Font("Roboto Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbldeluh.ForeColor = System.Drawing.Color.Gainsboro
        Me.Lbldeluh.Location = New System.Drawing.Point(111, 38)
        Me.Lbldeluh.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbldeluh.Name = "Lbldeluh"
        Me.Lbldeluh.Size = New System.Drawing.Size(101, 18)
        Me.Lbldeluh.TabIndex = 78
        Me.Lbldeluh.Text = "Borrar Usuarios"
        '
        'Btndel
        '
        Me.Btndel.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Btndel.FlatAppearance.BorderSize = 0
        Me.Btndel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btndel.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btndel.ForeColor = System.Drawing.Color.Gainsboro
        Me.Btndel.Location = New System.Drawing.Point(110, 138)
        Me.Btndel.Name = "Btndel"
        Me.Btndel.Size = New System.Drawing.Size(104, 31)
        Me.Btndel.TabIndex = 10
        Me.Btndel.Text = "Borrar"
        Me.Btndel.UseVisualStyleBackColor = False
        '
        'Txtuserdel
        '
        Me.Txtuserdel.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Txtuserdel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtuserdel.Font = New System.Drawing.Font("Roboto Condensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtuserdel.ForeColor = System.Drawing.Color.Gainsboro
        Me.Txtuserdel.Location = New System.Drawing.Point(43, 93)
        Me.Txtuserdel.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtuserdel.Name = "Txtuserdel"
        Me.Txtuserdel.Size = New System.Drawing.Size(256, 22)
        Me.Txtuserdel.TabIndex = 9
        '
        'Lbldelu
        '
        Me.Lbldelu.AutoSize = True
        Me.Lbldelu.Font = New System.Drawing.Font("Roboto Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbldelu.ForeColor = System.Drawing.Color.Gainsboro
        Me.Lbldelu.Location = New System.Drawing.Point(40, 69)
        Me.Lbldelu.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbldelu.Name = "Lbldelu"
        Me.Lbldelu.Size = New System.Drawing.Size(174, 18)
        Me.Lbldelu.TabIndex = 75
        Me.Lbldelu.Text = "Nombre de Usuario a borrar:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button1.Location = New System.Drawing.Point(431, 475)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 31)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Usuarios"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.Image = Global.SB.My.Resources.Resources.icons8_close_window_24px
        Me.BtnClose.Location = New System.Drawing.Point(3, 3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(24, 24)
        Me.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BtnClose.TabIndex = 3
        Me.BtnClose.TabStop = False
        '
        'CBoxPos
        '
        Me.CBoxPos.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.CBoxPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBoxPos.Font = New System.Drawing.Font("Roboto Condensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBoxPos.ForeColor = System.Drawing.Color.Gainsboro
        Me.CBoxPos.FormattingEnabled = True
        Me.CBoxPos.Items.AddRange(New Object() {"Docente", "Administrador"})
        Me.CBoxPos.Location = New System.Drawing.Point(49, 296)
        Me.CBoxPos.Name = "CBoxPos"
        Me.CBoxPos.Size = New System.Drawing.Size(256, 22)
        Me.CBoxPos.TabIndex = 4
        '
        'FrmAjustes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(767, 509)
        Me.Controls.Add(Me.CBoxPos)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Plndelu)
        Me.Controls.Add(Me.Lbladdu)
        Me.Controls.Add(Me.Txtcomfpass)
        Me.Controls.Add(Me.Lblcomfpass)
        Me.Controls.Add(Me.Txtnewpass)
        Me.Controls.Add(Me.Lblnewpass)
        Me.Controls.Add(Me.Btnsave)
        Me.Controls.Add(Me.Txtemail)
        Me.Controls.Add(Me.Txtlname)
        Me.Controls.Add(Me.Txtname)
        Me.Controls.Add(Me.Txtuser)
        Me.Controls.Add(Me.LblPos)
        Me.Controls.Add(Me.Lblname)
        Me.Controls.Add(Me.Lbluser)
        Me.Controls.Add(Me.Lbllname)
        Me.Controls.Add(Me.Lblemail)
        Me.Controls.Add(Me.BtnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmAjustes"
        Me.Text = "Inicio"
        Me.Plndelu.ResumeLayout(False)
        Me.Plndelu.PerformLayout()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnClose As PictureBox
    Friend WithEvents Txtcomfpass As TextBox
    Friend WithEvents Lblcomfpass As Label
    Friend WithEvents Txtnewpass As TextBox
    Friend WithEvents Lblnewpass As Label
    Friend WithEvents Btnsave As Button
    Friend WithEvents Txtemail As TextBox
    Friend WithEvents Txtlname As TextBox
    Friend WithEvents Txtname As TextBox
    Friend WithEvents Txtuser As TextBox
    Friend WithEvents LblPos As Label
    Friend WithEvents Lblname As Label
    Friend WithEvents Lbluser As Label
    Friend WithEvents Lbllname As Label
    Friend WithEvents Lblemail As Label
    Friend WithEvents Lbladdu As Label
    Friend WithEvents Plndelu As Panel
    Friend WithEvents Lbldeluh As Label
    Friend WithEvents Btndel As Button
    Friend WithEvents Txtuserdel As TextBox
    Friend WithEvents Lbldelu As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents CBoxPos As ComboBox
End Class
