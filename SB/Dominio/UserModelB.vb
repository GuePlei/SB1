Imports Acceso_de_Datos
Imports CapaComún
Public Class UserModelB
    Dim userDao As New UserDao
#Region "Editar"
    'Atributos
    Private LoginName
    Private Password
    Private firstName
    Private lastName
    Private position
    Private email
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
    Public Property firstName1 As Object
        Get
            Return firstName
        End Get
        Set(value As Object)
            firstName = value
        End Set
    End Property

    Public Property lastName1 As Object
        Get
            Return lastName
        End Get
        Set(value As Object)
            lastName = value
        End Set
    End Property

    Public Property position1 As Object
        Get
            Return position
        End Get
        Set(value As Object)
            position = value
        End Set
    End Property

    Public Property email1 As Object
        Get
            Return email
        End Get
        Set(value As Object)
            email = value
        End Set
    End Property
    Public Sub New(LoginName As Object)
        Me.LoginName1 = LoginName
    End Sub
    Public Sub New(LoginName As Object, Password As Object, firstName As Object, lastName As Object, position As Object, email As Object)

        Me.LoginName1 = LoginName
        Me.Password1 = Password
        Me.firstName1 = firstName
        Me.lastName1 = lastName
        Me.position1 = position
        Me.email1 = email
    End Sub
#End Region
    Public Function addprofile() As String
        Try
            userDao.addProfile(LoginName, Password, firstName, lastName, position, email)

            Return "Usuario agregado correctamente"
        Catch ex As Exception
            Return "Nombre de usuario ya en uso"
        End Try

    End Function
    Public Function borrar() As String
        Try
            userDao.borrar(LoginName)
            Return "Usuario borrado correctamente"
        Catch ex As Exception
            Return "Nombre de usuario no existente"
        End Try

    End Function
    'Programador: Andrey Guerrero
End Class