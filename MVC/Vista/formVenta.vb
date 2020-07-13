Public Class formVenta

    Private Sub formVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        disable()
    End Sub

    Private dt As New DataTable

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtidcliente.Text <> "" And txtnombre_cliente.Text <> "" And txtfecha_venta.Text <> "" Then
            Try
                Dim dts As New pVenta
                Dim func As New fVenta
                dts.gidcliente = txtidcliente.Text
                dts.gfechaVenta = txtfecha_venta.Text
                dts.gTipoDocumento = cboTipoDocumento.Text
                dts.gnumDocumento = txtnum_documento.Text

                If func.Insertar(dts) Then
                    MessageBox.Show("Venta registrada")
                    cargarDetalle()
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("venta no registrada")
                    mostrar()
                    limpiar()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            MessageBox.Show("Por favor llena todos los campos")
        End If

    End Sub

    Private Sub btnBuscar_cliente_Click(sender As Object, e As EventArgs) Handles btnBuscar_cliente.Click
        FormCLiente.txtMarca.Text = "marca"
        FormCLiente.ShowDialog()
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fVenta
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

    Private Sub dataListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListado.CellContentClick

        txtidVenta.Text = dataListado.SelectedCells.Item(1).Value
        txtidcliente.Text = dataListado.SelectedCells.Item(2).Value
        txtnombre_cliente.Text = dataListado.SelectedCells.Item(3).Value

        txtfecha_venta.Text = dataListado.SelectedCells.Item(5).Value
        cboTipoDocumento.Text = dataListado.SelectedCells.Item(6).Value
        txtnum_documento.Text = dataListado.SelectedCells.Item(7).Value

        'btnEditar.Visible = True
        btnGuardar.Visible = False

        If e.ColumnIndex = Me.dataListado.Columns.Item("eliminar").Index Then
            Dim fila As DataGridViewCheckBoxCell = Me.dataListado.Rows(e.RowIndex).Cells("eliminar")
            fila.Value = Not fila.Value
        End If



    End Sub

    Private Sub limpiar()
        btnGuardar.Visible = True
        'btnEditar.Visible = False
        txtidcliente.Text = ""
        txtidVenta.Text = ""
        txtnum_documento.Text = ""
        txtnombre_cliente.Text = ""
        ' txtCI.Text = ""
    End Sub

    Private Sub checkEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles checkEliminar.CheckedChanged
        If checkEliminar.CheckState = CheckState.Checked Then
            dataListado.Columns.Item("eliminar").Visible = True
        Else
            dataListado.Columns.Item("eliminar").Visible = False
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim resultado As DialogResult
        resultado = MessageBox.Show("Desea eliminar", "Eliminado", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        If resultado = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In dataListado.Rows
                    Dim marca As Boolean = Convert.ToBoolean(row.Cells("eliminar").Value)
                    If marca Then

                        Dim valores As Integer = Convert.ToInt32(row.Cells("idventa").Value)
                        Dim pdb As New pVenta
                        Dim func As New fVenta
                        pdb.gidventa = valores
                        If func.eliminar(pdb) Then
                            MsgBox("Se elimino el registro")
                        Else
                            MsgBox("No se puede eliminar el registro")

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

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim resultado As DialogResult
        resultado = MessageBox.Show("¿Desea modificar el registro?", "MODIFICADO",
                                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If resultado = DialogResult.OK Then
            Try
                Dim dts As New pVenta
                Dim func As New fVenta

                dts.gidventa = txtidVenta.Text
                dts.gidcliente = txtidcliente.Text
                dts.gTipoDocumento = cboTipoDocumento.Text
                dts.gfechaVenta = CDate(txtfecha_venta.Text)
                dts.gnumDocumento = txtnum_documento.Text

                If func.editar(dts) Then
                    MsgBox("Registro Editado")
                    mostrar()
                    limpiar()
                Else
                    MsgBox("Registro no Editado")
                    mostrar()
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub


    Private Sub cargarDetalle()
        formdetalleVenta.txtidVenta.Text = dataListado.SelectedCells.Item(1).Value
        formdetalleVenta.txtidcliente.Text = dataListado.SelectedCells.Item(2).Value
        formdetalleVenta.txtnombre.Text = dataListado.SelectedCells.Item(3).Value
        formdetalleVenta.txtfecha.Text = dataListado.SelectedCells.Item(5).Value
        formdetalleVenta.txtnum_documento.Text = dataListado.SelectedCells.Item(6).Value
        formdetalleVenta.txtnum_documento.Text = dataListado.SelectedCells.Item(7).Value

        formdetalleVenta.ShowDialog()

    End Sub

    Private Sub disable()
        txtidVenta.Enabled = False
        txtidcliente.Enabled = False
        txtnombre_cliente.Enabled = False
    End Sub

    Private Sub dataListado_DoubleClick(sender As Object, e As EventArgs) Handles dataListado.DoubleClick
        cargarDetalle()
        mostrar()
        limpiar()
    End Sub
End Class
