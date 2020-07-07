Imports System.Data.SqlClient

Public Class fCategoria


    Inherits conexion
    Dim cmd As New SqlCommand
    Public Function mostrar() As DataTable
        Try
            conectado()
            'Tiene que estar creado el procedimiento almacenado en la base de datos
            cmd = New SqlCommand("mostrar_categorias")
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
    Public Function Insertar(ByVal dts As pCategoria) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_categoria")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@nombre_categoria", dts.gNombre_Categoria)

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

    Public Function editar(ByVal dts As pCategoria) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_categoria")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idcategoria", dts.gIdcategoria)
            cmd.Parameters.AddWithValue("@nombre_categoria", dts.gNombre_Categoria)

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

    Public Function eliminar(ByVal dts As pCliente) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_categoria")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@id_categoria", SqlDbType.NVarChar, 30).Value = dts.gidCliente
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
