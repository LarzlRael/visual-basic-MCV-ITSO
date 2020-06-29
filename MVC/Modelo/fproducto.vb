Imports System.Data.SqlClient

Public Class fproducto
    Inherits conexion
    Dim cmd As New SqlCommand
    Public Function mostrar() As DataTable
        Try
            conectado()
            'Tiene que estar creado el procedimiento almacenado en la base de datos
            cmd = New SqlCommand("mostrar_productos")
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

    Public Function Insertar(ByVal dts As pProducto) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_producto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            'insert into producto(nombre,descripcion,stock,precio_compra,precio_venta,fecha_vencimiento)
            'values(@nombre,@descripcion,@stock,@precio_compra,@precio_venta,@fecha_vencimiento)
            cmd.Parameters.AddWithValue("@nombre", dts.gNombre)
            cmd.Parameters.AddWithValue("@descripcion", dts.gDescripcion)
            cmd.Parameters.AddWithValue("@stock", dts.gStock)
            cmd.Parameters.AddWithValue("@precio_compra", dts.gPrecioCompra)
            cmd.Parameters.AddWithValue("@precio_venta", dts.gPrecioVenta)
            cmd.Parameters.AddWithValue("@fecha_vencimiento", dts.gFechaVencimiento)

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
    Public Function editar(ByVal dts As pProducto) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_producto")

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_producto", dts.gidProducto)
            cmd.Parameters.AddWithValue("@nombre", dts.gNombre)
            cmd.Parameters.AddWithValue("@descripcion", dts.gDescripcion)
            cmd.Parameters.AddWithValue("@stock", dts.gStock)
            cmd.Parameters.AddWithValue("@precio_compra", dts.gPrecioCompra)
            cmd.Parameters.AddWithValue("@precio_venta", dts.gPrecioVenta)
            cmd.Parameters.AddWithValue("@fecha_vencimiento", dts.gFechaVencimiento)

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


    Public Function eliminarProducto(ByVal dts As pProducto) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminarProducto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@id_producto", SqlDbType.NVarChar, 30).Value = dts.gidProducto
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
End Class
