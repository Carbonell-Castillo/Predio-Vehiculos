Public Class BaseDeDatos
    'conexion
    Dim conexion As New SqlClient.SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PredioVehiculos.mdf;Integrated Security=True")
    'el comenado
    Dim sqlComando As New SqlClient.SqlCommand

    Public tabla As SqlClient.SqlDataReader
    Public textoError As String

    Public Function conectar() As Boolean
        Try
            conexion.Open()
            ConfigurarComando()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Sub cerrarConexion()
        conexion.Close()
    End Sub
    Public Sub ConfigurarComando()
        sqlComando.Connection = conexion

        sqlComando.CommandType = CommandType.Text
    End Sub

    Public Function ejecutarQuery(qprucedure As String) As Boolean
        'Es una funcionalidad de tipo reader(Devuelve registros)
        conectar()
        sqlComando.CommandText = "exec " + qprucedure
        Try

            tabla = sqlComando.ExecuteReader
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    'Utiliza para agregar, modificar o eliminar registros
    Public Function ejecutarTransaccion(qprucedure As String) As Boolean
        'Es una funcionalidad de tipo no reader(No devuelve registros)
        conectar()
        sqlComando.CommandText = "exec " + qprucedure
        Try

            sqlComando.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            textoError = ex.ToString
            Return False

        End Try
    End Function
End Class


