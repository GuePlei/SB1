Imports System.Net
Imports System.Net.Mail
Public MustInherit Class EmailMasterServer
    Private smtpClient As SmtpClient
    Protected senderMail As String
    Protected password As String
    Protected host As String
    Protected port As Integer
    Protected ssl As Boolean
    Protected Sub InitalizeSmtpClient()
        'Inicia los protocolos para enviar
        smtpClient = New SmtpClient With {
            .Credentials = New NetworkCredential(senderMail, password),
            .Host = host,
            .Port = port,
            .EnableSsl = ssl
        }
    End Sub
    Public Sub SendMail(ByVal subject As String, ByVal body As String, ByVal receiverMail As List(Of String))
        'Cuerpo, encabezado y partes del email que "recolecta el sistema antes de enviar la boleta"
        Dim mailMessage As MailMessage = New MailMessage
        Try
            mailMessage.From = New MailAddress(senderMail)
            For Each Mail As String In receiverMail
                mailMessage.To.Add(Mail)
            Next
            mailMessage.Subject = subject
            mailMessage.Body = body
            mailMessage.Priority = MailPriority.Normal
            smtpClient.Send(mailMessage)
        Catch ex As Exception
        Finally
            mailMessage.Dispose()
            smtpClient.Dispose()
        End Try
    End Sub
End Class
