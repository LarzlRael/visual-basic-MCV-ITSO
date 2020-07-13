Public Class formLogin
    Private Sub formLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub bntIngresar_Click(sender As Object, e As EventArgs) Handles bntIngresar.Click
        Try
            Dim dts As New pUsuario
            Dim func As New fUsuario
            dts.glogin = txtUsuario.Text
            dts.gpassword = txtPassword.Text
            If func.validacion_usaurio(dts) = True Then
                usuarioModulo.gLogin = txtUsuario.Text

                principal.Show()

                Me.Hide()
            Else
                MsgBox("Datos incorrecto")
                txtPassword.Clear()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class