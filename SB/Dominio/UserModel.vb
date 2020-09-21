Imports Acceso_de_Datos
Imports CapaComún
Public Class UserModel
    Dim userDao As New UserDao()
    Public Function Login(user As String, pass As String) As Boolean
        Return userDao.Login(user, pass)
    End Function
    Public Function anyMethod(id As Integer) As Boolean
        If ActiveUser.idUSer >= 1 Then
            If userDao.existsUser(ActiveUser.idUSer) = True Then
                Return True
                'Codigo para mayor seguridad
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function
    Public Sub anyMethod4()
        If ActiveUser.position = "Manager" Then
            'codigo para el manager
        End If
        If ActiveUser.position = "CEO" Then
            'codigo para el CEO
        End If
    End Sub
End Class
