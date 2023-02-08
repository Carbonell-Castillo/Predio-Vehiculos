Public Class Propetario
    'atrributos
    Private _dpi As String
    Private _nit As String
    Private _nombre As String
    Private _direccion As String
    Private _telefono As String

    'Constructor sin parametros
    Public Sub New()
        Dpi = ""
        Nit = ""
        Nombre = ""
        Direccion = ""
        Telefono = ""
    End Sub


    'constructor con parametros
    Public Sub New(dpi As String, nit As String, nombre As String, direccion As String, telefono As String)
        Me.Dpi = dpi
        Me.Nit = nit
        Me.Nombre = nombre
        Me.Direccion = direccion
        Me.Telefono = telefono
    End Sub

    'Metodos gey y set
    Public Property Dpi As String
        Get
            Return _dpi
        End Get
        Set(value As String)
            _dpi = value
        End Set
    End Property

    Public Property Nit As String
        Get
            Return _nit
        End Get
        Set(value As String)
            _nit = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property

    'Funcion para busacar nit
    Public Function buscarNit(ByVal nit As String) As Boolean
        Dim bd As New BaseDeDatos()
        Dim qprocedure As String
        qprocedure = "buscarClienteNit @nit='" + nit + "'"

        If (bd.ejecutarQuery(qprocedure)) Then
            If (bd.tabla.Read) Then
                Return True
            Else

                Return False
            End If
        Else
            MsgBox("Error en la base de datos")
        End If
        bd.cerrarConexion()
    End Function

    Public Function buscarDpi(ByVal dpi As String) As Boolean
        Dim bd As New BaseDeDatos()
        Dim qprocedure As String
        qprocedure = "buscarClienteDpi @dpi='" + dpi + "'"

        If (bd.ejecutarQuery(qprocedure)) Then
            If (bd.tabla.Read) Then
                _dpi = bd.tabla(0)
                _nit = bd.tabla(1)
                _nombre = bd.tabla(2)
                _direccion = bd.tabla(3)
                _telefono = bd.tabla(4)
                Return True
            Else
                Return False
            End If
        Else
            MsgBox("Error en la base de datos")
            Return False
        End If
        bd.cerrarConexion()
    End Function

    Public Function guardar() As Boolean
        Dim bd As New BaseDeDatos()
        Dim qprocedure As String

        'Preparar los datos para guardar
        Dpi = "'" + Dpi + "'"
        Nit = "'" + Nit + "'"
        Nombre = "'" + Nombre + "'"
        Direccion = "'" + Direccion + "'"
        Telefono = "'" + Telefono + "'"

        qprocedure = "addCliente @dpi=" + Dpi
        qprocedure = qprocedure + ",@nombre=" + Nombre
        qprocedure = qprocedure + ",@direccion=" + Direccion
        qprocedure = qprocedure + ",@telefono=" + Telefono
        qprocedure = qprocedure + ",@nit=" + Nit
        If (bd.ejecutarTransaccion(qprocedure)) Then
            Return True
        Else
            MsgBox("Ocurrio un error al almacenar: " + bd.textoError)
            Return False
        End If
    End Function

End Class
