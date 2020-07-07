Imports System.Data.SqlClient

Public Class fDetalle

    Inherits conexion
    Dim cmd As New SqlCommand
    Public Function mostrar() As DataTable
        Try
            conectado()
            'Tiene que estar creado el procedimiento almacenado en la base de datos
            cmd = New SqlCommand("mostrarDetalles")
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function Insertar(ByVal dts As pDetalleVenta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertarDetalles")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idventa", dts.gIdventa)
            cmd.Parameters.AddWithValue("@idproducto", dts.gidproducto)
            cmd.Parameters.AddWithValue("@cantidad", dts.gCantidad)
            cmd.Parameters.AddWithValue("@precio_unitario", dts.gPrecio_unitario)


            'cmd.Parameters.AddWithValue("@nombre", dts.gNombre)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function editar(ByVal dts As pDetalleVenta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editarDetalles")

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@iddetalle_venta", dts.giddetalle_venta)
            cmd.Parameters.AddWithValue("@precio_compra", dts.gIdventa)
            cmd.Parameters.AddWithValue("@idproducto", dts.gidproducto)
            cmd.Parameters.AddWithValue("@cantidad", dts.gCantidad)
            cmd.Parameters.AddWithValue("@precio_unitario", dts.gPrecio_unitario)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectar()
        End Try

    End Function
    Public Function eliminarProducto(ByVal dts As pDetalleVenta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminarDetalles")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@iddetalle_venta", SqlDbType.NVarChar, 30).Value = dts.giddetalle_venta
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function aumentar_stock(ByVal dts As pDetalleVenta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("aumentarStocks")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_producto", dts.gidproducto)
            cmd.Parameters.AddWithValue("@cantidad", dts.gCantidad)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectar()
        End Try
    End Function


    Public Function disminuirStock(ByRef dts As pDetalleVenta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("disminuirStocks")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_producto", dts.gidproducto)
            cmd.Parameters.AddWithValue("@cantidad", dts.gCantidad)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectar()
        End Try
    End Function

End Class
