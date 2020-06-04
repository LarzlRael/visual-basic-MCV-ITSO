
Imports System.Data.SqlClient
Public Class fcliente
    Inherits conexion
    Dim cmd As New SqlCommand
    Public Function mostrar() As DataTable
        Try
            conectado()
            'Tiene que estar creado el procedimiento almacenado en la base de datos
            cmd = New SqlCommand("mostrar_cliente")
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
    Public Function Insertar(ByVal dts As pCliente) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_cliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@nombre", dts.gNombre)
            cmd.Parameters.AddWithValue("@apellido", dts.gApellido)
            cmd.Parameters.AddWithValue("@telefono", dts.gTelefono)
            cmd.Parameters.AddWithValue("@direccion", dts.gdireccion)
            cmd.Parameters.AddWithValue("@ci", dts.gci)
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

    Public Function editar(ByVal dts As pCliente) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editarCliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idcliente", dts.gidCliente)
            cmd.Parameters.AddWithValue("@nombre", dts.gNombre)
            cmd.Parameters.AddWithValue("@apellidos", dts.gApellido)
            cmd.Parameters.AddWithValue("@telefono", dts.gTelefono)
            cmd.Parameters.AddWithValue("@direccion", dts.gdireccion)
            cmd.Parameters.AddWithValue("@ci", dts.gci)

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
