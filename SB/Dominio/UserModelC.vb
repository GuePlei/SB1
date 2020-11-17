Imports Acceso_de_Datos
Imports CapaComún
Public Class UserModelC
    Dim userDao As New UserDao
    Public Function delnames(delname As String) As Boolean
        Return userDao.delnames(delname)

    End Function

End Class
