Imports System.Data
Imports System.Data.SqlClient
Imports CapaComún
Public Class UserDao
    Inherits ConnectionToSql
#Region "SQL"
    Public Sub editProfile(id, user, pass, name, lastName, mail)
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "update Users set LoginName=@user, Password=@pass, FirstName=@name, LastName=@lastName, Email=@mail where UserID=@id"
                command.Parameters.AddWithValue("@user", user)
                command.Parameters.AddWithValue("@pass", pass)
                command.Parameters.AddWithValue("@name", name)
                command.Parameters.AddWithValue("@lastName", lastName)
                command.Parameters.AddWithValue("@mail", mail)
                command.Parameters.AddWithValue("@id", id)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Sub addProfile(LoginName, password, firstname, lastName, position, email)
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "insert into Users values (@LoginName, @Password, @FirstName, @lastName, @position, @email)"
                command.Parameters.AddWithValue("@LoginName", LoginName)
                command.Parameters.AddWithValue("@password", password)
                command.Parameters.AddWithValue("@firstname", firstname)
                command.Parameters.AddWithValue("@lastName", lastName)
                command.Parameters.AddWithValue("@position", position)
                command.Parameters.AddWithValue("@email", email)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Sub borrar(LoginName)
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "delete from Users where LoginName=@LoginName"
                command.Parameters.AddWithValue("@LoginName", LoginName)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
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
                        ActiveUser.idUser = reader.GetInt32(0)
                        ActiveUser.LoginName = reader.GetString(1)
                        ActiveUser.Password = reader.GetString(2)
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
    Public Function delnames(delname As String) As Boolean
        Using Connection = GetConnection()
            Connection.Open()
            Using Command = New SqlCommand
                Command.Connection = Connection
                Command.CommandText = "select * from Users where LoginName=@delname"
                Command.Parameters.AddWithValue("@delname", delname)
                Command.CommandType = CommandType.Text
                Dim reader = Command.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read
                        ActiveUser.Delname = reader.GetString(1)
                    End While
                    reader.Dispose()
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function
    Public Function ExistsUser(id As Integer) As Boolean
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
#End Region
#Region "Email"
    Public Function Sentemail()
        Dim SystemSupport = New SystemSupportMail()
        SystemSupport.sendMail(
                        subject:="Nueva Boleta, del docente: " & ActiveUser.firstName + " " + ActiveUser.lastName,
                         body:="Estimado Auxiliar Adminitrativo, " & vbNewLine &
                         "El Estudiante: " & ActiveUser.Estudiante + ", " +
                         "de la sección: " & ActiveUser.sec + ", " +
                         "ha infringido el reglamento de conducta al cometer la siguiente falta: " & ActiveUser.Motivo & vbNewLine,
                         receiverMail:=New List(Of String) From {ActiveUser.Correo})
        Return MessageBox.Show("¡Boleta enviada!", "¡Atención!",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Function
    Public Function RequestUserPassword(ByVal requestingUser As String) As String
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
                        "Le pedimos que cambie su contraseña " & vbNewLine & "actual una vez acceda al sistema."
                Else
                    Return "Esa dirección de correo/usuario" & vbNewLine & "no esta registrada en el sistema."
                End If
            End Using
        End Using
    End Function
    Public Function Cargar_email()
        Using Connection = GetConnection()
            Connection.Open()
            Using Command = New SqlCommand
                Command.Connection = Connection
                Command.CommandText = "select * from Correo"
                Command.CommandType = CommandType.Text
                Dim reader = Command.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read
                        ActiveUser.ID = reader.GetInt32(0)
                        ActiveUser.Correo = reader.GetString(1)
                    End While
                    reader.Dispose()
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function
#End Region

End Class
