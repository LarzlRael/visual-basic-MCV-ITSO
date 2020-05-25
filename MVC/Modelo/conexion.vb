
Imports System.Data.SqlClient
Public Class conexion
    Protected cnn As New SqlConnection
    Protected idusuario As Integer

    'Funcion para verificar si estamos conectados
    Protected Function conectado()
        Dim server = "DESKTOP-6ATA2J5\SQLEXPRESS"
        Dim db_name = "db_ventas"
        Try
            cnn = New SqlConnection("data Source=" & server & ";Initial Catalog=" & db_name & ";Integrated Security=true")
            cnn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    'Funciom para desconectar
    Protected Function desconectar()
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
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
