Public Class pCliente
    Dim idCliente As Integer
    Dim nombre, apellidos, ci, direccion, telefono As String

    Public Property gidCliente
        Get
            Return idCliente
        End Get
        Set(value)
            idCliente = value
        End Set
    End Property
    Public Property gNombre
        Get
            Return nombre
        End Get
        Set(value)
            nombre = value
        End Set
    End Property

    Public Property gApellido
        Get
            Return apellidos
        End Get
        Set(value)
            apellidos = value
        End Set
    End Property
    Public Property gci
        Get
            Return ci
        End Get
        Set(value)
            ci = value
        End Set
    End Property
    Public Property gdireccion
        Get
            Return direccion
        End Get
        Set(value)
            direccion = value
        End Set
    End Property

    Public Property gTelefono
        Get
            Return telefono
        End Get
        Set(value)
            telefono = value
        End Set
    End Property
    Public Sub New()

    End Sub
    'Dim idCliente As Integer
    'Dim nombre, apellidos, ci, direccion, telefono As String
    Public Sub New(ByVal idCliente As Integer, ByVal nombre As String, ByVal apellidos As String,
                   ByVal ci As String, ByVal direccion As String,
                    ByVal telefono As String
        )
        gNombre = nombre
        gidCliente = idCliente
        gApellido = apellidos
        gci = ci
        gdireccion = direccion
        gTelefono = telefono
    End Sub
End Class
