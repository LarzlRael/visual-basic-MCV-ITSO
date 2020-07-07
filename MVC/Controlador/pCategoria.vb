Public Class pCategoria

    Dim idcategoria As Integer
    Dim nombre_categoria As String

    Public Sub New(idcategoria As Integer, nombre_categoria As String)
        gIdcategoria = idcategoria
        gNombre_Categoria = nombre_categoria
    End Sub

    Public Sub New()

    End Sub


    Public Property gIdcategoria As Integer
        Get
            Return idcategoria
        End Get
        Set(value As Integer)
            idcategoria = value
        End Set
    End Property

    Public Property gNombre_Categoria As String
        Get
            Return nombre_categoria
        End Get
        Set(value As String)
            nombre_categoria = value
        End Set
    End Property


End Class
