Public Class formdetalleVenta

    Private dt As New DataTable
    Private Sub formdetalleVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disable()
        mostrar()


    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fDetalle
            dt = func.mostrar
            dataListado.Columns.Item("eliminar").Visible = False
            If dt.Rows.Count <> 0 Then
                dataListado.DataSource = dt
                txtbuscar.Enabled = True
                dataListado.ColumnHeadersVisible = True
                'inexistente.Visible = False
            Else
                dataListado.DataSource = Nothing
                txtbuscar.Enabled = True
                dataListado.ColumnHeadersVisible = False
                'inexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Acciones de los botones 
        btnNuevo.Visible = True
        'btnEditar.Visible = False
        ' buscar()
    End Sub




    Private Sub limpiar()
        btnGuardar.Visible = True
        'btnEditar.Visible = False
        txtidProducto.Text = ""
        txtproducto.Text = ""
        txtpreciu_u.Text = ""
        txtCantidad.Text = 0
        txtStock.TextAlign = 1
        ' txtCI.Text = ""
    End Sub

    Private Sub ocuktar_columnas()
        dataListado.Columns(1).Visible = False
        dataListado.Columns(2).Visible = False
        dataListado.Columns(3).Visible = False
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()
        mostrar()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtidProducto.Text <> "" And txtCantidad.Text <> "" And txtpreciu_u.Text <> "" Then
            Try
                Dim dts As New pDetalleVenta
                Dim func As New fDetalle
                dts.gIdventa = txtidVenta.Text
                dts.gidproducto = txtidProducto.Text
                dts.gCantidad = txtCantidad.Text
                dts.gPrecio_unitario = txtpreciu_u.Text

                If func.Insertar(dts) Then
                    'disminuyendo el detalle
                    If func.disminuirStock(dts) Then
                        MessageBox.Show("Stock actualizado")
                    End If
                    MessageBox.Show("Articulo Agregado")
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Articulo no registrado")
                    mostrar()
                    limpiar()
                End If

            Catch ex As Exception
                MessageBox.Show("Articulo no registrado")
                MsgBox(ex.Message)
            End Try

        Else
            MessageBox.Show("Por favor llena todos los campos")
        End If
    End Sub

    Private Sub checkEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles checkEliminar.CheckedChanged
        If checkEliminar.CheckState = CheckState.Checked Then
            dataListado.Columns.Item("eliminar").Visible = True
        Else
            dataListado.Columns.Item("eliminar").Visible = False
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Dim resultado As DialogResult
        resultado = MessageBox.Show("Desea eliminar", "Eliminado", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        If resultado = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In dataListado.Rows
                    Dim marca As Boolean = Convert.ToBoolean(row.Cells("eliminar").Value)
                    If marca Then

                        Dim onekey As Integer = Convert.ToInt32(row.Cells("iddetalle_venta").Value)
                        Dim vdb As New pDetalleVenta
                        Dim func As New fDetalle
                        Dim userF As New fUsuario

                        vdb.giddetalle_venta = onekey

                        vdb.gidproducto = dataListado.SelectedCells.Item(3).Value
                        vdb.gIdventa = dataListado.SelectedCells.Item(2).Value
                        vdb.gCantidad = dataListado.SelectedCells.Item(5).Value


                        If userF.verAcceso() Then
                            If func.eliminarProducto(vdb) Then
                                If func.aumentar_stock(vdb) Then
                                    MsgBox("Borrado exitoso, usted esta activo")
                                End If
                            Else
                                MsgBox("No se puede eliminar el registro")

                            End If
                        Else
                            MsgBox("usted no es un usuario inactivo no puede realizar esta accion")
                            userF.errorUsuario(onekey)
                        End If



                    End If
                Next
                Call mostrar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("No fue eliminado")
        End If


    End Sub

    Private Sub txtCantidad_ValueChanged(sender As Object, e As EventArgs) Handles txtCantidad.ValueChanged
        If txtCantidad.Value > txtStock.Value Then
            MsgBox("La cantidad es superrior la stock")
            btnGuardar.Visible = True
            txtCantidad.Value = txtStock.Value
        Else
            btnGuardar.Visible = True
        End If
        If txtCantidad.Value = 0 Then
            btnGuardar.Visible = False
        Else
            btnGuardar.Visible = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        FormProducto.marca.Text = "marca"
        FormProducto.ShowDialog()
    End Sub

    Private Sub dataListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListado.CellContentClick
        If e.ColumnIndex = Me.dataListado.Columns.Item("eliminar").Index Then
            Dim fila As DataGridViewCheckBoxCell = Me.dataListado.Rows(e.RowIndex).Cells("eliminar")
            fila.Value = Not fila.Value
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

    End Sub

    Private Sub disable()
        txtidVenta.Enabled = False
        txtidcliente.Enabled = False
        txtfecha.Enabled = False
        cboTipoDocumento.Enabled = False
        txtnum_documento.Enabled = False
        txtnombre.Enabled = False
        txtidProducto.Enabled = False
        txtproducto.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormReporteDetalle.txtIdVenta.Text = Me.txtidVenta.Text
        FormReporteDetalle.ShowDialog()

    End Sub
End Class