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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblResult = New System.Windows.Forms.Label()
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.BtnSend = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese usuario o Correo Electrónico"
        '
        'LblResult
        '
        Me.LblResult.AutoSize = True
        Me.LblResult.Location = New System.Drawing.Point(44, 134)
        Me.LblResult.Name = "LblResult"
        Me.LblResult.Size = New System.Drawing.Size(39, 13)
        Me.LblResult.TabIndex = 1
        Me.LblResult.Text = "Label2"
        '
        'TxtUser
        '
        Me.TxtUser.Location = New System.Drawing.Point(44, 66)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(100, 20)
        Me.TxtUser.TabIndex = 2
        '
        'BtnSend
        '
        Me.BtnSend.Location = New System.Drawing.Point(143, 119)
        Me.BtnSend.Name = "BtnSend"
        Me.BtnSend.Size = New System.Drawing.Size(75, 23)
        Me.BtnSend.TabIndex = 3
        Me.BtnSend.Text = "Button1"
        Me.BtnSend.UseVisualStyleBackColor = True
        '
        'Recuperar_Contraseña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnSend)
        Me.Controls.Add(Me.TxtUser)
        Me.Controls.Add(Me.LblResult)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Recuperar_Contraseña"
        Me.Text = "Recuperar_Contraseña"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LblResult As Label
    Friend WithEvents TxtUser As TextBox
    Friend WithEvents BtnSend As Button
End Class
