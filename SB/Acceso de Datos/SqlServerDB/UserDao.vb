Imports System.Data
Imports System.Data.SqlClient
Imports CapaComún

Public Class UserDao
    Inherits ConnectionToSql
    Public Function requestUserPassword(ByVal requestingUser As String) As String
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand
                command.Connection = connection
                command.CommandText = "select * from Users where loginName=@user or Email=@email"
                command.Parameters.AddWithValue("@user", requestingUser)
                command.Parameters.AddWithValue("@email", requestingUser)
                command.CommandType = CommandType.Text

                Dim reader As SqlDataReader = command.ExecuteReader()

                If reader.Read = True Then
                    Dim userName As String = reader.GetString(3) & " " & reader.GetString(4)
                    Dim userMail As String = reader.GetString(6)
                    Dim userPassword As String = reader.GetString(2)

                    Dim SystemSupport = New SystemSupportMail()
                    SystemSupport.sendMail(
                        subject:="Sistema: Recuperación de constraseña Solicitada",
                         body:="Hola " & userName & vbNewLine & "Has solicitado recuperar tu contraseña." & vbNewLine &
                         "Tu contraseña es: " & userPassword & vbNewLine &
                         "Le pedimos que cambie su contraseña actual una vez acceda al sistema.",
                         receiverMail:=New List(Of String) From {userMail})
                    Return "Hola " & userName & vbNewLine & "Has solicitado recuperar tu contraseña." & vbNewLine &
                        "Revisa tu correo electrónico: " & userMail & vbNewLine &
                        "Le pedimos que cambie su contraseña actual una vez acceda al sistema."
                Else
                    Return "Esa dirección de correo/usuario" & vbNewLine & "no esta registrada en el sistema."

                End If
            End Using

        End Using
    End Function
    Public Function Login(user As String, pass As String) As Boolean
        Using Connection = GetConnection()
            Connection.Open()
            Using Command = New SqlCommand
                Command.Connection = Connection
                Command.CommandText = "select * from users where loginName=@user and password=@pass"
                Command.Parameters.AddWithValue("@user", user)
                Command.Parameters.AddWithValue("@pass", pass)
                Command.CommandType = CommandType.Text
                Dim reader = Command.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read
                        ActiveUser.idUSer = reader.GetInt32(0)
                        ActiveUser.firstName = reader.GetString(3)
                        ActiveUser.lastName = reader.GetString(4)
                        ActiveUser.position = reader.GetString(5)
                        ActiveUser.email = reader.GetString(6)
                    End While
                    reader.Dispose()
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function
    Public Function existsUser(id As Integer) As Boolean
        Using Connection = GetConnection()
            Connection.Open()
            Using Command = New SqlCommand
                Command.Connection = Connection
                Command.CommandText = "select * from users where UserID=@user"
                Command.Parameters.AddWithValue("@user", id)
                Command.CommandType = CommandType.Text
                Dim reader = Command.ExecuteReader()
                If reader.HasRows Then

                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function
    Public Sub anyMethod3()
        If ActiveUser.position = Puestos.Manager Then
            'codigo para el manager
        End If
        If ActiveUser.position = Puestos.CEO Then
            'codigo para el CEO
        End If
    End Sub
End Class
