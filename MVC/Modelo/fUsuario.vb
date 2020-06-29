﻿Imports System.Data.SqlClient

Public Class fUsuario
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function validacion_usaurio(ByVal dts As pUsuario)
        Try
            conectado()
            cmd = New SqlCommand("validacion")
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
End Class
