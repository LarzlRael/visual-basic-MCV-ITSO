Public Class frmCategoria
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim dts As New pCategoria
            Dim func As New fCategoria

            dts.gNombre_Categoria = txtNombreCategoria.Text

            If func.Insertar(dts) Then
                MessageBox.Show("Nueva categoria agregada")
                mostrar()
                limpiar()
            Else
                MessageBox.Show("Categoria no registrada")
                mostrar()
                limpiar()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private dt As New DataTable
    Private Sub mostrar()
        Try
            Dim func As New fCategoria
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
        btnEditar.Visible = False
        'buscar()
    End Sub
    Private Sub limpiar()
        btnGuardar.Visible = True
        btnEditar.Visible = False
        txtidcategoria.Text = ""
        txtNombreCategoria.Text = ""


    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        Dim resultado As DialogResult
        resultado = MessageBox.Show("¿Desea modificar?", "MODIFICADO",
                                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If resultado = DialogResult.OK Then
            Try
                Dim dts As New pCategoria
                Dim func As New fCategoria
                dts.gIdcategoria = txtidcategoria.Text
                dts.gNombre_Categoria = txtNombreCategoria.Text


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

    Private Sub dataListado_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListado.CellContentDoubleClick
        If txtmarca.Text = "marca" Then
            FormProducto.txtidcategoria.Text = dataListado.SelectedCells.Item(1).Value
            FormProducto.txtnombreCategoria.Text = dataListado.SelectedCells.Item(2).Value
            Me.Close()
        End If
    End Sub

    Private Sub frmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub
End Class