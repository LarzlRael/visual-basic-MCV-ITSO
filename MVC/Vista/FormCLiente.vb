﻿Public Class FormCLiente
    Private Sub FormCLiente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Private dt As New DataTable
    Private Sub mostrar()
        Try
            Dim func As New fcliente
            dt = func.mostrar
            dataListado.Columns.Item("Eliminar").Visible = False
            If dt.Rows.Count <> 0 Then
                dataListado.DataSource = dt
                txtBuscar.Enabled = True
                dataListado.ColumnHeadersVisible = True
                inexistente.Visible = False
            Else
                dataListado.DataSource = Nothing
                txtBuscar.Enabled = True
                dataListado.ColumnHeadersVisible = False
                inexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Acciones de los botones 
        btnNuevo.Visible = True
        btnEditar.Visible = False
        buscar()
    End Sub
    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))
            dv.RowFilter = cbo.Text & " like '" & txtBuscar.Text & "%'"
            If dv.Count <> 0 Then
                inexistente.Visible = False
                dataListado.DataSource = dv
                ocultar_columnas()
            Else
                inexistente.Visible = True
                dataListado.DataSource = dv
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ocultar_columnas()
        dataListado.Columns(1).Visible = False
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        buscar()
    End Sub

    Private Sub limpiar()
        btnGuardar.Visible = True
        btnEditar.Visible = False
        txtnombre.Text = ""
        txtApellido.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""
        txtCI.Text = ""
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim dts As New pCliente
            Dim func As New fcliente
            dts.gNombre = txtnombre.Text
            dts.gApellido = txtApellido.Text
            dts.gci = txtCI.Text
            dts.gdireccion = txtDireccion.Text
            dts.gTelefono = txtTelefono.Text
            If func.Insertar(dts) Then
                MessageBox.Show("Cliente registrado :D")
                mostrar()
                limpiar()
            Else
                MessageBox.Show("Cliente no registrado")
                mostrar()
                limpiar()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class