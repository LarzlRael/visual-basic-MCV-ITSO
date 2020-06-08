Public Class FormProducto

    Private Sub FormProducto(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Private dt As New DataTable
    Private Sub mostrar()
        Try
            Dim func As New fproducto
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
            dv.RowFilter = cboBuscar.Text & " like '" & txtBuscar.Text & "%'"
            If dv.Count <> 0 Then
                inexistente.Visible = False
                datalistado.DataSource = dv
                ocultar_columnas()
            Else
                inexistente.Visible = True
                datalistado.DataSource = dv
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ocultar_columnas()
        datalistado.Columns(1).Visible = False
    End Sub
    'metodo para poder hacer una busqueda
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        buscar()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim dts As New pProducto
            Dim func As New fproducto
            dts.gNombre = txtnombre.Text
            dts.gDescripcion = txtDescripcion.Text
            dts.gStock = CDbl(txtStock.Text)
            dts.gPrecioCompra = CDbl(txtPrecioCompra.Text)
            dts.gPrecioVenta = CDbl(txtPrecioVenta.Text)
            dts.gFechaVencimiento = CDate(dtFechaVencimiento.Text)
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


    Private Sub dataListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        txtid.Text = datalistado.SelectedCells.Item(1).Value
        txtnombre.Text = datalistado.SelectedCells.Item(3).Value
        txtDescripcion.Text = datalistado.SelectedCells.Item(4).Value
        txtStock.Text = datalistado.SelectedCells.Item(5).Value
        txtPrecioCompra.Text = datalistado.SelectedCells.Item(6).Value
        txtPrecioVenta.Text = datalistado.SelectedCells.Item(7).Value
        dtFechaVencimiento.Value = datalistado.SelectedCells.Item(8).Value


        btnEditar.Visible = True
        btnGuardar.Visible = False


    End Sub


    'Metodo para limpar
    Private Sub limpiar()
        btnGuardar.Visible = True
        btnEditar.Visible = False
        txtStock.Text = ""
        txtnombre.Text = ""
        txtDescripcion.Text = ""
        txtPrecioCompra.Text = ""
        txtPrecioVenta.Text = ""
        dtFechaVencimiento.Text = ""

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim resultado As DialogResult
        resultado = MessageBox.Show("¿Desea modificar?", "MODIFICADO",
                                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If resultado = DialogResult.OK Then
            Try
                Dim dts As New pProducto
                Dim func As New fproducto
                dts.gidProducto = txtId.Text
                dts.gNombre = txtnombre.Text
                dts.gDescripcion = txtDescripcion.Text
                dts.gStock = CDbl(txtStock.Text)
                dts.gPrecioCompra = CDbl(txtPrecioCompra.Text)
                dts.gPrecioVenta = CDbl(txtPrecioVenta.Text)
                dts.gFechaVencimiento = CDate(dtFechaVencimiento.Text)

                If func.editar(dts) Then
                    MsgBox("Producto Editado")
                    mostrar()
                    limpiar()
                Else
                    MsgBox("CLiente no Editado")
                    mostrar()
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class