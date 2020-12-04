Public Class SystemSupportMail
    Inherits EmailMasterServer
    Public Sub New()
        'Credenciales del correo del sistema
        senderMail = "sistemadeboletasctpaz@gmail.com"
        password = "PasswoRS"
        host = "smtp.gmail.com"
        port = 587
        ssl = True
        InitalizeSmtpClient()
    End Sub
End Class
