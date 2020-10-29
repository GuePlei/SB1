Imports Acceso_de_Datos
Imports CapaComún
Public Class UserModel
    Dim userDao As New UserDao
    'Atributos
    Private idUser
    Private LoginName
    Private Password
    Private firstName
    Private lastName
    Private position
    Private email
    Private Correo
    Private ID
    Public Property ID1 As Object
        Get
            Return ID
        End Get
        Set(value As Object)
            ID = value
        End Set
    End Property
    Public Property Correo1 As Object
        Get
            Return Correo
        End Get
        Set(value As Object)
            Correo = value
        End Set
    End Property
    Public Property IdUser1 As Object
        Get
            Return idUser
        End Get
        Set(value As Object)
            idUser = value
        End Set
    End Property

    Public Property LoginName1 As Object
        Get
            Return LoginName
        End Get
        Set(value As Object)
            LoginName = value
        End Set
    End Property

    Public Property Password1 As Object
        Get
            Return Password
        End Get
        Set(value As Object)
            Password = value
        End Set
    End Property

    Public Property FirstName1 As Object
        Get
            Return firstName
        End Get
        Set(value As Object)
            firstName = value
        End Set
    End Property

    Public Property LastName1 As Object
        Get
            Return lastName
        End Get
        Set(value As Object)
            lastName = value
        End Set
    End Property

    Public Property Position1 As Object
        Get
            Return position
        End Get
        Set(value As Object)
            position = value
        End Set
    End Property

    Public Property Email1 As Object
        Get
            Return email
        End Get
        Set(value As Object)
            email = value
        End Set
    End Property

    Public Sub New(idUser As Object, LoginName As Object, Password As Object, firstName As Object, lastName As Object, position As Object, email As Object)
        Me.IdUser1 = idUser
        Me.LoginName1 = LoginName
        Me.Password1 = Password
        Me.FirstName1 = firstName
        Me.LastName1 = lastName
        Me.Position1 = position
        Me.Email1 = email
    End Sub
    Public Sub New(ID As Object, Correo As Object)
        Me.ID1 = ID
        Me.Correo1 = Correo

    End Sub

    Public Sub New()
    End Sub
    Public Function Editarperfil() As String
        Try
            userDao.editProfile(idUser, LoginName, Password, firstName, lastName, email)
            Login(LoginName, Password)
            Return "Su perfil ha sido editado correctamente"
        Catch ex As Exception
            Return "Nombre de usuario ya en uso"
        End Try

    End Function
    Public Function Editarcorreo() As String
        Try
            userDao.editarcorreo(Correo)
            Return "Correo Editado Correctamente"
        Catch ex As Exception
            Return "Error"
        End Try

    End Function
    Public Function sentemail()
        Return userDao.Sentemail

    End Function
    Public Function RecoverPassword(requestingUser As String) As String
        Return userDao.RequestUserPassword(requestingUser)

    End Function
    Public Function cargaremail()
        Return userDao.Cargar_email()
    End Function
    Public Function Login(user As String, Password As String) As Boolean
        Return userDao.Login(user, Password)

    End Function
    Public Function AnyMethod(id As Integer) As Boolean
        If ActiveUser.idUser >= 1 Then
            If userDao.ExistsUser(ActiveUser.idUser) = True Then
                Return True
                'Codigo para mayor seguridad
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function
    Public Sub AnyMethod4()
        If ActiveUser.position = "Manager" Then
            'codigo para el manager
        End If
        If ActiveUser.position = "CEO" Then
            'codigo para el CEO
        End If
    End Sub
End Class
