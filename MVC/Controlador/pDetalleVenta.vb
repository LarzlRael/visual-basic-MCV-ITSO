Public Class pDetalleVenta

    Dim iddetalle_venta, idventa, idproducto As Integer
    Dim cantidad, precio_unitario As Double



    Public Property giddetalle_venta As Integer
        Get
            Return iddetalle_venta
        End Get
        Set(value As Integer)
            iddetalle_venta = value
        End Set
    End Property

    Public Property gIdventa As Integer
        Get
            Return idventa
        End Get
        Set(value As Integer)
            idventa = value
        End Set
    End Property

    Public Property gidproducto As Integer
        Get
            Return idproducto
        End Get
        Set(value As Integer)
            idproducto = value
        End Set
    End Property

    Public Property gCantidad As Double
        Get
            Return cantidad
        End Get
        Set(value As Double)
            cantidad = value
        End Set
    End Property

    Public Property gPrecio_unitario As Double
        Get
            Return precio_unitario
        End Get
        Set(value As Double)
            precio_unitario = value
        End Set
    End Property


    Public Sub New(iddetalle_venta As Integer, idventa As Integer, idproducto As Integer, cantidad As Double, precio_unitario As Double)
        giddetalle_venta = iddetalle_venta
        gIdventa = idventa
        gidproducto = idproducto
        gCantidad = cantidad
        gPrecio_unitario = precio_unitario
    End Sub

    Public Sub New()

    End Sub

End Class
