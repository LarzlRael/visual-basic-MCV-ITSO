Public Class FormCLiente
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

    Private Sub dataListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListado.CellContentClick
        txtid.Text = dataListado.SelectedCells.Item(1).Value
        txtnombre.Text = dataListado.SelectedCells.Item(2).Value
        txtApellido.Text = dataListado.SelectedCells.Item(3).Value
        txtDireccion.Text = dataListado.SelectedCells.Item(4).Value
        txtTelefono.Text = dataListado.SelectedCells.Item(5).Value
        txtCI.Text = dataListado.SelectedCells.Item(6).Value

        btnEditar.Visible = True
        btnGuardar.Visible = False

        If e.ColumnIndex = Me.dataListado.Columns.Item("eliminar").Index Then
            Dim fila As DataGridViewCheckBoxCell = Me.dataListado.Rows(e.RowIndex).Cells("eliminar")
            fila.Value = Not fila.Value
        End If


    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim resultado As DialogResult
        resultado = MessageBox.Show("¿Desea modificar?", "MODIFICADO",
                                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If resultado = DialogResult.OK Then
            Try
                Dim dts As New pCliente
                Dim func As New fcliente
                dts.gidCliente = txtid.Text
                dts.gNombre = txtnombre.Text
                dts.gApellido = txtApellido.Text
                dts.gTelefono = txtTelefono.Text
                dts.gdireccion = txtDireccion.Text
                dts.gci = txtCI.Text

                If func.editar(dts) Then
                    MsgBox("Cliente Editado")
                    mostrar()
                    limpiar()
                Else
                    MsgBox("CLiente no modificado")
                    mostrar()
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()
    End Sub


    Private Sub checkEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles checkEliminar.CheckedChanged
        If checkEliminar.CheckState = CheckState.Checked Then
            dataListado.Columns.Item("eliminar").Visible = True
        Else
            dataListado.Columns.Item("eliminar").Visible = False
        End If

    End Sub
    Private Sub btnEiminar_Click(sender As Object, e As EventArgs) Handles btnEiminar.Click
        Dim resultado As DialogResult
        resultado = MessageBox.Show("Desea eliminar", "Eliminado", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        If resultado = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In dataListado.Rows
                    Dim marca As Boolean = Convert.ToBoolean(row.Cells("eliminar").Value)
                    If marca Then

                        Dim valores As Integer = Convert.ToInt32(row.Cells("idcliente").Value)
                        Dim pdb As New pCliente
                        Dim func As New fcliente
                        pdb.gidCliente = valores
                        If func.eliminar(pdb) Then
                            MsgBox("Se elimino el cliente")
                        Else
                            MsgBox("No se puede eliminar")

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

End Class