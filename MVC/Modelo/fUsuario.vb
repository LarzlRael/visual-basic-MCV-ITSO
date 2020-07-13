Imports System.Data.SqlClient

Public Class fUsuario
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function validacion_usaurio(ByVal dts As pUsuario)
        Try
            conectado()
            cmd = New SqlCommand("validacion2")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@login", dts.glogin)
            cmd.Parameters.AddWithValue("@password", dts.gpassword)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            If dr.HasRows = True Then
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

    Public Function verificarAcceso(ByVal dts As pUsuario)
        Try
            conectado()
            cmd = New SqlCommand("verificarUsuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idusuario", dts.gidusuario)

            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            If dr.HasRows = True Then
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

    Public Function verAcceso()
        Try
            conectado()
            cmd = New SqlCommand("verAcceso")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@login", gLogin)

            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            If dr.HasRows = True Then
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

    Public Function errorUsuario(ByRef iddetalle_venta As Integer)
        Try
            conectado()
            cmd = New SqlCommand("logUsuarioError2")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@login", gLogin)
            cmd.Parameters.AddWithValue("@iddetalle_venta", iddetalle_venta)

            If cmd.ExecuteNonQuery = True Then
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
