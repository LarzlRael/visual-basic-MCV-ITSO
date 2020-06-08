Public Class pProducto

    Dim idProducto As Integer
    Dim nombre, descripcion As String
    Dim precio_compra, precio_venta, stock As Double
    Dim fecha_vencimiento As Date
    Public Property gidProducto
        Get
            Return idProducto
        End Get
        Set(value)
            idProducto = value
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

    Public Property gDescripcion
        Get
            Return descripcion
        End Get
        Set(value)
            descripcion = value
        End Set
    End Property
    Public Property gPrecioCompra
        Get
            Return precio_compra
        End Get
        Set(value)
            precio_compra = value
        End Set
    End Property
    Public Property gPrecioVenta
        Get
            Return precio_venta
        End Get
        Set(value)
            precio_venta = value
        End Set
    End Property

    Public Property gStock
        Get
            Return stock
        End Get
        Set(value)
            stock = value
        End Set
    End Property
    Public Property gFechaVencimiento
        Get
            Return fecha_vencimiento
        End Get
        Set(value)
            fecha_vencimiento = value
        End Set
    End Property

    Public Sub New()

    End Sub
    'Dim idCliente As Integer
    'precio_compra, precio_venta, stock DOuble
    Public Sub New(ByVal idProducto As Integer,
                   ByVal descripcion As String,
                   ByVal precio_compra As Double,
                   ByVal precio_venta As Double,
                   ByVal stock As Double,
                   ByVal fecha_vencimiento As Date)

        gidProducto = idProducto
        gNombre = nombre
        gDescripcion = descripcion
        gPrecioCompra = precio_compra
        gPrecioVenta = precio_venta
        gStock = stock
        gFechaVencimiento = fecha_vencimiento
    End Sub

End Class
