Public Class pUsuario
    Dim idusuario As Integer
    Dim nombre, apellido, ci, telefono, login, password, acceso, direccion As String

    Public Property gidusuario
        Get
            Return idusuario
        End Get
        Set(value)
            idusuario = value
        End Set
    End Property

    Public Property gnombre
        Get
            Return nombre
        End Get
        Set(value)
            nombre = value
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

    Public Property gapellido
        Get
            Return apellido
        End Get
        Set(value)
            apellido = value
        End Set
    End Property

    Public Property gtelefono
        Get
            Return telefono
        End Get
        Set(value)
            telefono = value
        End Set
    End Property

    Public Property glogin
        Get
            Return login
        End Get
        Set(value)
            login = value
        End Set
    End Property


    Public Property gpassword
        Get
            Return password
        End Get
        Set(value)
            password = value
        End Set
    End Property
    Public Property gacceso
        Get
            Return acceso
        End Get
        Set(value)
            acceso = value
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

    Public Sub New()

    End Sub
    Public Sub New(ByVal idusuario As Integer, ByVal nombre As String, ByVal apellido As String, ByVal ci As String, ByVal direccion As String, ByVal telefono As String, ByVal login As String, ByVal password As String, ByVal acesso As String)

        gidusuario = idusuario
        gnombre = nombre
        gapellido = apellido
        gci = ci
        gdireccion = direccion
        telefono = telefono
        glogin = login
        gpassword = password
        gacceso = acceso

    End Sub

End Class
