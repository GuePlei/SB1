Imports Acceso_de_Datos
Imports CapaComún
Public Class UserModelC
    Dim userDao As New UserDao
    Public Function Delnames(delname As String) As Boolean
        Return userDao.Delnames(delname)

    End Function

End Class
