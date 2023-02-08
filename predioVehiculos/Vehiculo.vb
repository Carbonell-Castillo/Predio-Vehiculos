Public Class Vehiculo
    Private _placa As String
    Private _nit As String
    Private _modelo As Integer
    Private _nCilindros As Integer
    Private _marca As String

    'Cosntructor sin parametros
    Public Sub New()
        Placa = ""
        Nit = ""
        Modelo = 0
        NCilindros = 0
        Marca = ""
    End Sub

    'Constructor con parametros
    Public Sub New(placa As String, nit As String, modelo As Integer, nCilindros As Integer, marca As String)
        Me.Placa = placa
        Me.Nit = nit
        Me.Modelo = modelo
        Me.NCilindros = nCilindros
        Me.Marca = marca
    End Sub

    'Metodos get y set
    Public Property Placa As String
        Get
            Return _placa
        End Get
        Set(value As String)
            _placa = value
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

    Public Property Modelo As Integer
        Get
            Return _modelo
        End Get
        Set(value As Integer)
            _modelo = value
        End Set
    End Property

    Public Property NCilindros As Integer
        Get
            Return _nCilindros
        End Get
        Set(value As Integer)
            _nCilindros = value
        End Set
    End Property

    Public Property Marca As String
        Get
            Return _marca
        End Get
        Set(value As String)
            _marca = value
        End Set
    End Property

    Public Function buscarPlaca(ByVal placa As String) As Boolean
        Dim bd As New BaseDeDatos()
        Dim qprocedure As String
        qprocedure = "buscarVehiculoPlaca @placa='" + placa + "'"

        If (bd.ejecutarQuery(qprocedure)) Then
            If (bd.tabla.Read) Then
                _placa = bd.tabla(0)
                _nit = bd.tabla(1)
                _modelo = bd.tabla(2)
                _nCilindros = bd.tabla(3)
                _marca = bd.tabla(4)
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
    Function guardar() As Boolean
        Dim bd As New BaseDeDatos()
        Dim qprocedure As String
        'Preparar los datos para guardar
        Placa = "'" + Placa + "'"
        Nit = "'" + Nit + "'"

        Marca = "'" + Marca + "'"

        qprocedure = "addVehiculo @placa=" + Placa
        qprocedure = qprocedure + ",@nit=" + Nit
        qprocedure = qprocedure + ",@modelo=" + CStr(Modelo)
        qprocedure = qprocedure + ",@nCilindros=" + CStr(NCilindros)
        qprocedure = qprocedure + ",@marca=" + Marca
        If (bd.ejecutarTransaccion(qprocedure)) Then
            Return True
        Else
            MsgBox("Ocurrio un error al almacenar: " + bd.textoError)
            Return False
        End If
    End Function
End Class
