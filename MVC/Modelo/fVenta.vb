Imports System.Data.SqlClient

Public Class fVenta
    Inherits conexion
    Dim cmd As New SqlCommand
    Public Function mostrar() As DataTable

        Try
            conectado()
            'Tiene que estar creado el procedimiento almacenado en la base de datos
            cmd = New SqlCommand("mostrarVenta")
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


    Public Function Insertar(ByVal dts As pVenta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertarVenta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idcliente", dts.gidcliente)
            cmd.Parameters.AddWithValue("@fecha_venta", dts.gfechaVenta)
            cmd.Parameters.AddWithValue("@tipo_documento", dts.gTipoDocumento)
            cmd.Parameters.AddWithValue("@num_documento", dts.gnumDocumento)


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


    Public Function editar(ByVal dts As pVenta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editarVenta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idventa", dts.gidventa)
            cmd.Parameters.AddWithValue("@idcliente", dts.gidcliente)
            cmd.Parameters.AddWithValue("@fecha_venta", dts.gfechaVenta)
            cmd.Parameters.AddWithValue("@tipo_documento", dts.gTipoDocumento)
            cmd.Parameters.AddWithValue("@num_documento", dts.gnumDocumento)

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

    Public Function eliminar(ByVal dts As pVenta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminarVentas")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@idventas", SqlDbType.NVarChar, 30).Value = dts.gidventa
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
