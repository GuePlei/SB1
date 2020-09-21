Imports System.Data
Imports System.Data.SqlClient
Imports CapaComún

Public Class UserDao
    Inherits ConnectionToSql
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
