Public Class pVenta
    Dim idventa, idcliente As Integer
    Dim fecha_venta As Date
    Dim tipo_documento, num_documento As String



    Public Property gidventa As Integer
        Get
            Return idventa
        End Get
        Set(value As Integer)
            idventa = value
        End Set
    End Property

    Public Property gidcliente As Integer
        Get
            Return idcliente
        End Get
        Set(value As Integer)
            idcliente = value
        End Set
    End Property

    Public Property gfechaVenta As Date
        Get
            Return fecha_venta
        End Get
        Set(value As Date)
            fecha_venta = value
        End Set
    End Property

    Public Property gTipoDocumento As String
        Get
            Return tipo_documento
        End Get
        Set(value As String)
            tipo_documento = value
        End Set
    End Property

    Public Property gnumDocumento As String
        Get
            Return num_documento
        End Get
        Set(value As String)
            num_documento = value
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(idventa As Integer, idcliente As Integer, fecha_venta As Date, tipo_documento As String, num_documento As String)
        gidventa = idventa
        gidcliente = idcliente
        gfechaVenta = fecha_venta
        gTipoDocumento = tipo_documento
        gnumDocumento = num_documento
    End Sub

End Class
