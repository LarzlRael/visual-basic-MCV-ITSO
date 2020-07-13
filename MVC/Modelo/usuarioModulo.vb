Public Module usuarioModulo
    Dim id_usuario, login As String

    Public Property gidusuario As String
        Get
            Return id_usuario
        End Get
        Set(value As String)
            id_usuario = value
        End Set
    End Property

    Public Property gLogin As String
        Get
            Return login
        End Get
        Set(value As String)
            login = value
        End Set
    End Property


    Sub New()

    End Sub

End Module
