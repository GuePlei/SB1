<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBoletas
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Txtdesc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btnlimp = New System.Windows.Forms.Button()
        Me.txttipo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btnsave = New System.Windows.Forms.Button()
        Me.txtpuntos = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txtmotiv = New System.Windows.Forms.TextBox()
        Me.Txtuser = New System.Windows.Forms.TextBox()
        Me.Lblname1 = New System.Windows.Forms.Label()
        Me.Lbluser1 = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Lbldesc = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Btnenviar = New System.Windows.Forms.Button()
        Me.Lblprof = New System.Windows.Forms.Label()
        Me.Lblpuntos = New System.Windows.Forms.Label()
        Me.Lbltipo = New System.Windows.Forms.Label()
        Me.Lblmotiv = New System.Windows.Forms.Label()
        Me.Lblusered = New System.Windows.Forms.Label()
        Me.Lblposit = New System.Windows.Forms.Label()
        Me.Lblname = New System.Windows.Forms.Label()
        Me.Lbluser = New System.Windows.Forms.Label()
        Me.Lbllname = New System.Windows.Forms.Label()
        Me.Lblemail = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(764, 38)
        Me.Panel1.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.SB.My.Resources.Resources.icons8_close_window_24px
        Me.PictureBox1.Location = New System.Drawing.Point(3, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Txtdesc)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Btnlimp)
        Me.Panel4.Controls.Add(Me.txttipo)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Btnsave)
        Me.Panel4.Controls.Add(Me.txtpuntos)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.Txtmotiv)
        Me.Panel4.Controls.Add(Me.Txtuser)
        Me.Panel4.Controls.Add(Me.Lblname1)
        Me.Panel4.Controls.Add(Me.Lbluser1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(381, 38)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(383, 465)
        Me.Panel4.TabIndex = 4
        '
        'Txtdesc
        '
        Me.Txtdesc.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Txtdesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtdesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtdesc.ForeColor = System.Drawing.Color.Gainsboro
        Me.Txtdesc.Location = New System.Drawing.Point(71, 192)
        Me.Txtdesc.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Txtdesc.Name = "Txtdesc"
        Me.Txtdesc.Size = New System.Drawing.Size(256, 21)
        Me.Txtdesc.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(66, 171)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 18)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Descripción del Motivo:"
        '
        'Btnlimp
        '
        Me.Btnlimp.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Btnlimp.FlatAppearance.BorderSize = 0
        Me.Btnlimp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnlimp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnlimp.ForeColor = System.Drawing.Color.Gainsboro
        Me.Btnlimp.Location = New System.Drawing.Point(69, 327)
        Me.Btnlimp.Name = "Btnlimp"
        Me.Btnlimp.Size = New System.Drawing.Size(122, 33)
        Me.Btnlimp.TabIndex = 7
        Me.Btnlimp.Text = "Limpiar"
        Me.Btnlimp.UseVisualStyleBackColor = False
        '
        'txttipo
        '
        Me.txttipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.txttipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttipo.ForeColor = System.Drawing.Color.Gainsboro
        Me.txttipo.Location = New System.Drawing.Point(71, 291)
        Me.txttipo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txttipo.Name = "txttipo"
        Me.txttipo.Size = New System.Drawing.Size(256, 21)
        Me.txttipo.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(66, 270)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 18)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Tipo de Boleta:"
        '
        'Btnsave
        '
        Me.Btnsave.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Btnsave.FlatAppearance.BorderSize = 0
        Me.Btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsave.ForeColor = System.Drawing.Color.Gainsboro
        Me.Btnsave.Location = New System.Drawing.Point(205, 327)
        Me.Btnsave.Name = "Btnsave"
        Me.Btnsave.Size = New System.Drawing.Size(122, 33)
        Me.Btnsave.TabIndex = 5
        Me.Btnsave.Text = "Confirmar"
        Me.Btnsave.UseVisualStyleBackColor = False
        '
        'txtpuntos
        '
        Me.txtpuntos.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.txtpuntos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpuntos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpuntos.ForeColor = System.Drawing.Color.Gainsboro
        Me.txtpuntos.Location = New System.Drawing.Point(71, 240)
        Me.txtpuntos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtpuntos.Name = "txtpuntos"
        Me.txtpuntos.Size = New System.Drawing.Size(256, 21)
        Me.txtpuntos.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(66, 219)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 18)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Puntos:"
        '
        'Txtmotiv
        '
        Me.Txtmotiv.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Txtmotiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtmotiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtmotiv.ForeColor = System.Drawing.Color.Gainsboro
        Me.Txtmotiv.Location = New System.Drawing.Point(69, 141)
        Me.Txtmotiv.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Txtmotiv.Name = "Txtmotiv"
        Me.Txtmotiv.Size = New System.Drawing.Size(256, 21)
        Me.Txtmotiv.TabIndex = 1
        '
        'Txtuser
        '
        Me.Txtuser.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Txtuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtuser.ForeColor = System.Drawing.Color.Gainsboro
        Me.Txtuser.Location = New System.Drawing.Point(69, 90)
        Me.Txtuser.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Txtuser.Name = "Txtuser"
        Me.Txtuser.Size = New System.Drawing.Size(256, 21)
        Me.Txtuser.TabIndex = 0
        '
        'Lblname1
        '
        Me.Lblname1.AutoSize = True
        Me.Lblname1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblname1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Lblname1.Location = New System.Drawing.Point(66, 120)
        Me.Lblname1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lblname1.Name = "Lblname1"
        Me.Lblname1.Size = New System.Drawing.Size(57, 18)
        Me.Lblname1.TabIndex = 39
        Me.Lblname1.Text = "Motivo:"
        '
        'Lbluser1
        '
        Me.Lbluser1.AutoSize = True
        Me.Lbluser1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbluser1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Lbluser1.Location = New System.Drawing.Point(66, 66)
        Me.Lbluser1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbluser1.Name = "Lbluser1"
        Me.Lbluser1.Size = New System.Drawing.Size(81, 18)
        Me.Lbluser1.TabIndex = 38
        Me.Lbluser1.Text = "Estudiante:"
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Lbldesc)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Btnenviar)
        Me.Panel2.Controls.Add(Me.Lblprof)
        Me.Panel2.Controls.Add(Me.Lblpuntos)
        Me.Panel2.Controls.Add(Me.Lbltipo)
        Me.Panel2.Controls.Add(Me.Lblmotiv)
        Me.Panel2.Controls.Add(Me.Lblusered)
        Me.Panel2.Controls.Add(Me.Lblposit)
        Me.Panel2.Controls.Add(Me.Lblname)
        Me.Panel2.Controls.Add(Me.Lbluser)
        Me.Panel2.Controls.Add(Me.Lbllname)
        Me.Panel2.Controls.Add(Me.Lblemail)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 38)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(381, 465)
        Me.Panel2.TabIndex = 3
        '
        'Lbldesc
        '
        Me.Lbldesc.AutoSize = True
        Me.Lbldesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbldesc.ForeColor = System.Drawing.Color.Gainsboro
        Me.Lbldesc.Location = New System.Drawing.Point(74, 270)
        Me.Lbldesc.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbldesc.Name = "Lbldesc"
        Me.Lbldesc.Size = New System.Drawing.Size(0, 13)
        Me.Lbldesc.TabIndex = 61
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label5.Location = New System.Drawing.Point(65, 238)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 20)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Descripción del Motivo:"
        '
        'Btnenviar
        '
        Me.Btnenviar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Btnenviar.Enabled = False
        Me.Btnenviar.FlatAppearance.BorderSize = 0
        Me.Btnenviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnenviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnenviar.ForeColor = System.Drawing.Color.Gainsboro
        Me.Btnenviar.Location = New System.Drawing.Point(194, 399)
        Me.Btnenviar.Name = "Btnenviar"
        Me.Btnenviar.Size = New System.Drawing.Size(122, 33)
        Me.Btnenviar.TabIndex = 6
        Me.Btnenviar.Text = "Enviar"
        Me.Btnenviar.UseVisualStyleBackColor = False
        '
        'Lblprof
        '
        Me.Lblprof.AutoSize = True
        Me.Lblprof.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblprof.ForeColor = System.Drawing.Color.Gainsboro
        Me.Lblprof.Location = New System.Drawing.Point(73, 191)
        Me.Lblprof.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lblprof.Name = "Lblprof"
        Me.Lblprof.Size = New System.Drawing.Size(0, 20)
        Me.Lblprof.TabIndex = 32
        '
        'Lblpuntos
        '
        Me.Lblpuntos.AutoSize = True
        Me.Lblpuntos.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblpuntos.ForeColor = System.Drawing.Color.Gainsboro
        Me.Lblpuntos.Location = New System.Drawing.Point(74, 331)
        Me.Lblpuntos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lblpuntos.Name = "Lblpuntos"
        Me.Lblpuntos.Size = New System.Drawing.Size(0, 13)
        Me.Lblpuntos.TabIndex = 38
        '
        'Lbltipo
        '
        Me.Lbltipo.AutoSize = True
        Me.Lbltipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltipo.ForeColor = System.Drawing.Color.Gainsboro
        Me.Lbltipo.Location = New System.Drawing.Point(74, 392)
        Me.Lbltipo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbltipo.Name = "Lbltipo"
        Me.Lbltipo.Size = New System.Drawing.Size(0, 13)
        Me.Lbltipo.TabIndex = 37
        '
        'Lblmotiv
        '
        Me.Lblmotiv.AutoSize = True
        Me.Lblmotiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblmotiv.ForeColor = System.Drawing.Color.Gainsboro
        Me.Lblmotiv.Location = New System.Drawing.Point(74, 140)
        Me.Lblmotiv.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lblmotiv.Name = "Lblmotiv"
        Me.Lblmotiv.Size = New System.Drawing.Size(0, 13)
        Me.Lblmotiv.TabIndex = 35
        '
        'Lblusered
        '
        Me.Lblusered.AutoSize = True
        Me.Lblusered.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblusered.ForeColor = System.Drawing.Color.Gainsboro
        Me.Lblusered.Location = New System.Drawing.Point(74, 80)
        Me.Lblusered.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lblusered.Name = "Lblusered"
        Me.Lblusered.Size = New System.Drawing.Size(0, 13)
        Me.Lblusered.TabIndex = 34
        '
        'Lblposit
        '
        Me.Lblposit.AutoSize = True
        Me.Lblposit.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Lblposit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblposit.ForeColor = System.Drawing.Color.Gainsboro
        Me.Lblposit.Location = New System.Drawing.Point(65, 298)
        Me.Lblposit.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lblposit.Name = "Lblposit"
        Me.Lblposit.Size = New System.Drawing.Size(59, 20)
        Me.Lblposit.TabIndex = 33
        Me.Lblposit.Text = "Puntos"
        '
        'Lblname
        '
        Me.Lblname.AutoSize = True
        Me.Lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblname.ForeColor = System.Drawing.Color.Gainsboro
        Me.Lblname.Location = New System.Drawing.Point(65, 112)
        Me.Lblname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lblname.Name = "Lblname"
        Me.Lblname.Size = New System.Drawing.Size(55, 20)
        Me.Lblname.TabIndex = 32
        Me.Lblname.Text = "Motivo"
        '
        'Lbluser
        '
        Me.Lbluser.AutoSize = True
        Me.Lbluser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbluser.ForeColor = System.Drawing.Color.Gainsboro
        Me.Lbluser.Location = New System.Drawing.Point(65, 52)
        Me.Lbluser.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbluser.Name = "Lbluser"
        Me.Lbluser.Size = New System.Drawing.Size(86, 20)
        Me.Lbluser.TabIndex = 31
        Me.Lbluser.Text = "Estudiante"
        '
        'Lbllname
        '
        Me.Lbllname.AutoSize = True
        Me.Lbllname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbllname.ForeColor = System.Drawing.Color.Gainsboro
        Me.Lbllname.Location = New System.Drawing.Point(65, 171)
        Me.Lbllname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbllname.Name = "Lbllname"
        Me.Lbllname.Size = New System.Drawing.Size(69, 20)
        Me.Lbllname.TabIndex = 30
        Me.Lbllname.Text = "Profesor"
        '
        'Lblemail
        '
        Me.Lblemail.AutoSize = True
        Me.Lblemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblemail.ForeColor = System.Drawing.Color.Gainsboro
        Me.Lblemail.Location = New System.Drawing.Point(65, 360)
        Me.Lblemail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lblemail.Name = "Lblemail"
        Me.Lblemail.Size = New System.Drawing.Size(109, 20)
        Me.Lblemail.TabIndex = 29
        Me.Lblemail.Text = "Tipo de boleta"
        '
        'FrmBoletas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(764, 503)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmBoletas"
        Me.Text = "Boletas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnClose As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Txtmotiv As TextBox
    Friend WithEvents Txtuser As TextBox
    Friend WithEvents Lblname1 As Label
    Friend WithEvents Lbluser1 As Label
    Friend WithEvents txtpuntos As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Lblpuntos As Label
    Friend WithEvents Lbltipo As Label
    Friend WithEvents Lblmotiv As Label
    Friend WithEvents Lblusered As Label
    Friend WithEvents Lblposit As Label
    Friend WithEvents Lblname As Label
    Friend WithEvents Lbluser As Label
    Friend WithEvents Lbllname As Label
    Friend WithEvents Lblemail As Label
    Friend WithEvents Lblprof As Label
    Friend WithEvents Btnsave As Button
    Friend WithEvents txttipo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Btnenviar As Button
    Friend WithEvents Btnlimp As Button
    Friend WithEvents Txtdesc As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Lbldesc As Label
    Friend WithEvents Label5 As Label
End Class
