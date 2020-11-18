<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBoletas
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
        Me.Plnbole = New System.Windows.Forms.Panel()
        Me.Lblbole = New System.Windows.Forms.Label()
        Me.Txtsec = New System.Windows.Forms.TextBox()
        Me.Lblsect = New System.Windows.Forms.Label()
        Me.Btnsave = New System.Windows.Forms.Button()
        Me.Txtmotiv = New System.Windows.Forms.TextBox()
        Me.Txtest = New System.Windows.Forms.TextBox()
        Me.Lblmotivt = New System.Windows.Forms.Label()
        Me.Lblestt = New System.Windows.Forms.Label()
        Me.Plncomf = New System.Windows.Forms.Panel()
        Me.Lblcomf = New System.Windows.Forms.Label()
        Me.Pbclose = New System.Windows.Forms.PictureBox()
        Me.Lblsec = New System.Windows.Forms.Label()
        Me.Lbsech = New System.Windows.Forms.Label()
        Me.Btnenviar = New System.Windows.Forms.Button()
        Me.Lblprof = New System.Windows.Forms.Label()
        Me.Lblmotiv = New System.Windows.Forms.Label()
        Me.Lblest = New System.Windows.Forms.Label()
        Me.Lblmotivh = New System.Windows.Forms.Label()
        Me.Lblesth = New System.Windows.Forms.Label()
        Me.Lblprofh = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.PictureBox()
        Me.Plnbole.SuspendLayout()
        Me.Plncomf.SuspendLayout()
        CType(Me.Pbclose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Plnbole
        '
        Me.Plnbole.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Plnbole.Controls.Add(Me.Lblbole)
        Me.Plnbole.Controls.Add(Me.Txtsec)
        Me.Plnbole.Controls.Add(Me.Lblsect)
        Me.Plnbole.Controls.Add(Me.Btnsave)
        Me.Plnbole.Controls.Add(Me.Txtmotiv)
        Me.Plnbole.Controls.Add(Me.Txtest)
        Me.Plnbole.Controls.Add(Me.Lblmotivt)
        Me.Plnbole.Controls.Add(Me.Lblestt)
        Me.Plnbole.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Plnbole.Location = New System.Drawing.Point(423, 0)
        Me.Plnbole.Margin = New System.Windows.Forms.Padding(2)
        Me.Plnbole.Name = "Plnbole"
        Me.Plnbole.Size = New System.Drawing.Size(341, 503)
        Me.Plnbole.TabIndex = 4
        '
        'Lblbole
        '
        Me.Lblbole.AutoSize = True
        Me.Lblbole.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblbole.ForeColor = System.Drawing.Color.Gainsboro
        Me.Lblbole.Location = New System.Drawing.Point(32, 35)
        Me.Lblbole.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lblbole.Name = "Lblbole"
        Me.Lblbole.Size = New System.Drawing.Size(286, 19)
        Me.Lblbole.TabIndex = 62
        Me.Lblbole.Text = "Rellenar con datos del estudiante y motivo"
        '
        'Txtsec
        '
        Me.Txtsec.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Txtsec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtsec.Font = New System.Drawing.Font("Roboto Condensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtsec.ForeColor = System.Drawing.Color.Gainsboro
        Me.Txtsec.Location = New System.Drawing.Point(48, 147)
        Me.Txtsec.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtsec.MaxLength = 5
        Me.Txtsec.Name = "Txtsec"
        Me.Txtsec.Size = New System.Drawing.Size(256, 22)
        Me.Txtsec.TabIndex = 1
        '
        'Lblsect
        '
        Me.Lblsect.AutoSize = True
        Me.Lblsect.Font = New System.Drawing.Font("Roboto Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblsect.ForeColor = System.Drawing.Color.Gainsboro
        Me.Lblsect.Location = New System.Drawing.Point(45, 126)
        Me.Lblsect.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lblsect.Name = "Lblsect"
        Me.Lblsect.Size = New System.Drawing.Size(59, 18)
        Me.Lblsect.TabIndex = 61
        Me.Lblsect.Text = "Sección:"
        '
        'Btnsave
        '
        Me.Btnsave.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Btnsave.FlatAppearance.BorderSize = 0
        Me.Btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnsave.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsave.ForeColor = System.Drawing.Color.Gainsboro
        Me.Btnsave.Location = New System.Drawing.Point(114, 263)
        Me.Btnsave.Name = "Btnsave"
        Me.Btnsave.Size = New System.Drawing.Size(122, 33)
        Me.Btnsave.TabIndex = 3
        Me.Btnsave.Text = "Confirmar"
        Me.Btnsave.UseVisualStyleBackColor = False
        '
        'Txtmotiv
        '
        Me.Txtmotiv.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Txtmotiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtmotiv.Font = New System.Drawing.Font("Roboto Condensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtmotiv.ForeColor = System.Drawing.Color.Gainsboro
        Me.Txtmotiv.Location = New System.Drawing.Point(48, 209)
        Me.Txtmotiv.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtmotiv.Name = "Txtmotiv"
        Me.Txtmotiv.Size = New System.Drawing.Size(256, 22)
        Me.Txtmotiv.TabIndex = 2
        '
        'Txtest
        '
        Me.Txtest.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Txtest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtest.Font = New System.Drawing.Font("Roboto Condensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtest.ForeColor = System.Drawing.Color.Gainsboro
        Me.Txtest.Location = New System.Drawing.Point(48, 92)
        Me.Txtest.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtest.Name = "Txtest"
        Me.Txtest.Size = New System.Drawing.Size(256, 22)
        Me.Txtest.TabIndex = 0
        '
        'Lblmotivt
        '
        Me.Lblmotivt.AutoSize = True
        Me.Lblmotivt.Font = New System.Drawing.Font("Roboto Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblmotivt.ForeColor = System.Drawing.Color.Gainsboro
        Me.Lblmotivt.Location = New System.Drawing.Point(45, 188)
        Me.Lblmotivt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lblmotivt.Name = "Lblmotivt"
        Me.Lblmotivt.Size = New System.Drawing.Size(52, 18)
        Me.Lblmotivt.TabIndex = 39
        Me.Lblmotivt.Text = "Motivo:"
        '
        'Lblestt
        '
        Me.Lblestt.AutoSize = True
        Me.Lblestt.Font = New System.Drawing.Font("Roboto Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblestt.ForeColor = System.Drawing.Color.Gainsboro
        Me.Lblestt.Location = New System.Drawing.Point(45, 68)
        Me.Lblestt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lblestt.Name = "Lblestt"
        Me.Lblestt.Size = New System.Drawing.Size(72, 18)
        Me.Lblestt.TabIndex = 38
        Me.Lblestt.Text = "Estudiante:"
        '
        'Plncomf
        '
        Me.Plncomf.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Plncomf.Controls.Add(Me.Lblcomf)
        Me.Plncomf.Controls.Add(Me.Pbclose)
        Me.Plncomf.Controls.Add(Me.Lblsec)
        Me.Plncomf.Controls.Add(Me.Lbsech)
        Me.Plncomf.Controls.Add(Me.Btnenviar)
        Me.Plncomf.Controls.Add(Me.Lblprof)
        Me.Plncomf.Controls.Add(Me.Lblmotiv)
        Me.Plncomf.Controls.Add(Me.Lblest)
        Me.Plncomf.Controls.Add(Me.Lblmotivh)
        Me.Plncomf.Controls.Add(Me.Lblesth)
        Me.Plncomf.Controls.Add(Me.Lblprofh)
        Me.Plncomf.Dock = System.Windows.Forms.DockStyle.Left
        Me.Plncomf.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Plncomf.Location = New System.Drawing.Point(0, 0)
        Me.Plncomf.Name = "Plncomf"
        Me.Plncomf.Size = New System.Drawing.Size(423, 503)
        Me.Plncomf.TabIndex = 3
        '
        'Lblcomf
        '
        Me.Lblcomf.AutoSize = True
        Me.Lblcomf.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblcomf.ForeColor = System.Drawing.Color.Gainsboro
        Me.Lblcomf.Location = New System.Drawing.Point(158, 35)
        Me.Lblcomf.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lblcomf.Name = "Lblcomf"
        Me.Lblcomf.Size = New System.Drawing.Size(109, 19)
        Me.Lblcomf.TabIndex = 62
        Me.Lblcomf.Text = "Confirmaciones"
        '
        'Pbclose
        '
        Me.Pbclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pbclose.Image = Global.SB.My.Resources.Resources.icons8_close_window_24px
        Me.Pbclose.Location = New System.Drawing.Point(3, 3)
        Me.Pbclose.Name = "Pbclose"
        Me.Pbclose.Size = New System.Drawing.Size(24, 24)
        Me.Pbclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Pbclose.TabIndex = 3
        Me.Pbclose.TabStop = False
        '
        'Lblsec
        '
        Me.Lblsec.AutoSize = True
        Me.Lblsec.Font = New System.Drawing.Font("Roboto Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblsec.ForeColor = System.Drawing.Color.Gainsboro
        Me.Lblsec.Location = New System.Drawing.Point(68, 159)
        Me.Lblsec.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lblsec.Name = "Lblsec"
        Me.Lblsec.Size = New System.Drawing.Size(0, 15)
        Me.Lblsec.TabIndex = 61
        '
        'Lbsech
        '
        Me.Lbsech.AutoSize = True
        Me.Lbsech.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbsech.ForeColor = System.Drawing.Color.Gainsboro
        Me.Lbsech.Location = New System.Drawing.Point(59, 125)
        Me.Lbsech.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbsech.Name = "Lbsech"
        Me.Lbsech.Size = New System.Drawing.Size(63, 19)
        Me.Lbsech.TabIndex = 60
        Me.Lbsech.Text = "Sección:"
        '
        'Btnenviar
        '
        Me.Btnenviar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Btnenviar.Enabled = False
        Me.Btnenviar.FlatAppearance.BorderSize = 0
        Me.Btnenviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnenviar.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnenviar.ForeColor = System.Drawing.Color.Gainsboro
        Me.Btnenviar.Location = New System.Drawing.Point(145, 353)
        Me.Btnenviar.Name = "Btnenviar"
        Me.Btnenviar.Size = New System.Drawing.Size(122, 33)
        Me.Btnenviar.TabIndex = 4
        Me.Btnenviar.Text = "Enviar"
        Me.Btnenviar.UseVisualStyleBackColor = False
        '
        'Lblprof
        '
        Me.Lblprof.AutoSize = True
        Me.Lblprof.Font = New System.Drawing.Font("Roboto Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblprof.ForeColor = System.Drawing.Color.Gainsboro
        Me.Lblprof.Location = New System.Drawing.Point(68, 210)
        Me.Lblprof.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lblprof.Name = "Lblprof"
        Me.Lblprof.Size = New System.Drawing.Size(0, 15)
        Me.Lblprof.TabIndex = 32
        '
        'Lblmotiv
        '
        Me.Lblmotiv.AutoSize = True
        Me.Lblmotiv.Font = New System.Drawing.Font("Roboto Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblmotiv.ForeColor = System.Drawing.Color.Gainsboro
        Me.Lblmotiv.Location = New System.Drawing.Point(68, 273)
        Me.Lblmotiv.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lblmotiv.Name = "Lblmotiv"
        Me.Lblmotiv.Size = New System.Drawing.Size(0, 15)
        Me.Lblmotiv.TabIndex = 35
        '
        'Lblest
        '
        Me.Lblest.AutoSize = True
        Me.Lblest.Font = New System.Drawing.Font("Roboto Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblest.ForeColor = System.Drawing.Color.Gainsboro
        Me.Lblest.Location = New System.Drawing.Point(68, 96)
        Me.Lblest.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lblest.Name = "Lblest"
        Me.Lblest.Size = New System.Drawing.Size(0, 15)
        Me.Lblest.TabIndex = 34
        '
        'Lblmotivh
        '
        Me.Lblmotivh.AutoSize = True
        Me.Lblmotivh.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblmotivh.ForeColor = System.Drawing.Color.Gainsboro
        Me.Lblmotivh.Location = New System.Drawing.Point(59, 245)
        Me.Lblmotivh.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lblmotivh.Name = "Lblmotivh"
        Me.Lblmotivh.Size = New System.Drawing.Size(53, 19)
        Me.Lblmotivh.TabIndex = 32
        Me.Lblmotivh.Text = "Motivo"
        '
        'Lblesth
        '
        Me.Lblesth.AutoSize = True
        Me.Lblesth.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblesth.ForeColor = System.Drawing.Color.Gainsboro
        Me.Lblesth.Location = New System.Drawing.Point(59, 68)
        Me.Lblesth.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lblesth.Name = "Lblesth"
        Me.Lblesth.Size = New System.Drawing.Size(78, 19)
        Me.Lblesth.TabIndex = 31
        Me.Lblesth.Text = "Estudiante"
        '
        'Lblprofh
        '
        Me.Lblprofh.AutoSize = True
        Me.Lblprofh.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblprofh.ForeColor = System.Drawing.Color.Gainsboro
        Me.Lblprofh.Location = New System.Drawing.Point(59, 187)
        Me.Lblprofh.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lblprofh.Name = "Lblprofh"
        Me.Lblprofh.Size = New System.Drawing.Size(64, 19)
        Me.Lblprofh.TabIndex = 30
        Me.Lblprofh.Text = "Profesor"
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.Image = Global.SB.My.Resources.Resources.icons8_close_window_24px
        Me.BtnClose.Location = New System.Drawing.Point(0, 3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(24, 24)
        Me.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BtnClose.TabIndex = 1
        Me.BtnClose.TabStop = False
        '
        'FrmBoletas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(764, 503)
        Me.Controls.Add(Me.Plnbole)
        Me.Controls.Add(Me.Plncomf)
        Me.Controls.Add(Me.BtnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmBoletas"
        Me.Text = "Boletas"
        Me.Plnbole.ResumeLayout(False)
        Me.Plnbole.PerformLayout()
        Me.Plncomf.ResumeLayout(False)
        Me.Plncomf.PerformLayout()
        CType(Me.Pbclose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnClose As PictureBox
    Friend WithEvents Pbclose As PictureBox
    Friend WithEvents Plnbole As Panel
    Friend WithEvents Plncomf As Panel
    Friend WithEvents Txtmotiv As TextBox
    Friend WithEvents Txtest As TextBox
    Friend WithEvents Lblmotivt As Label
    Friend WithEvents Lblestt As Label
    Friend WithEvents Lblmotiv As Label
    Friend WithEvents Lblest As Label
    Friend WithEvents Lblmotivh As Label
    Friend WithEvents Lblesth As Label
    Friend WithEvents Lblprofh As Label
    Friend WithEvents Lblprof As Label
    Friend WithEvents Btnsave As Button
    Friend WithEvents Btnenviar As Button
    Friend WithEvents Txtsec As TextBox
    Friend WithEvents Lblsect As Label
    Friend WithEvents Lblsec As Label
    Friend WithEvents Lbsech As Label
    Friend WithEvents Lblbole As Label
    Friend WithEvents Lblcomf As Label
End Class
