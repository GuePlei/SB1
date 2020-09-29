Public Class SystemSupportMail
    Inherits EmailMasterServer
    Public Sub New()
        senderMail = "sistemadeboletasctpaz@gmail.com"
        password = "PasswoRS"
        host = "smtp.gmail.com"
        port = 587
        ssl = True
        initalizeSmtpClient()
    End Sub
End Class
