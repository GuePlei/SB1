Imports System.Data.SqlClient
Public MustInherit Class ConnectionToSql

        Private connectionString As String
        Protected Sub New()
        connectionString = "Server=DESKTOP-ONSKSA1\SQLEXPRESS; DataBase=BoletasDigitales; integrated security = true"
    End Sub
        Protected Function GetConnection() As SQLConnection
            Return New SQLConnection(connectionString)
        End Function
    End Class
