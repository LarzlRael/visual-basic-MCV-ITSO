<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProducto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtidcategoria = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.label = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.dtFechaVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.txtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.txtPrecioCompra = New System.Windows.Forms.TextBox()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.checkEliminar = New System.Windows.Forms.CheckBox()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.cboBuscar = New System.Windows.Forms.ComboBox()
        Me.btnEiminar = New System.Windows.Forms.Button()
        Me.marca = New System.Windows.Forms.TextBox()
        Me.txtnombreCategoria = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCategoria = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCategoria)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtnombreCategoria)
        Me.GroupBox1.Controls.Add(Me.txtidcategoria)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Controls.Add(Me.label)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.dtFechaVencimiento)
        Me.GroupBox1.Controls.Add(Me.txtPrecioVenta)
        Me.GroupBox1.Controls.Add(Me.txtPrecioCompra)
        Me.GroupBox1.Controls.Add(Me.txtStock)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(422, 442)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacion de producto"
        '
        'txtidcategoria
        '
        Me.txtidcategoria.Location = New System.Drawing.Point(117, 45)
        Me.txtidcategoria.Name = "txtidcategoria"
        Me.txtidcategoria.Size = New System.Drawing.Size(47, 20)
        Me.txtidcategoria.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Categoria"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(117, 19)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 24
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(26, 26)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(64, 13)
        Me.label.TabIndex = 23
        Me.label.Text = "ID Producto"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(109, 354)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 22
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(213, 354)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 21
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(109, 393)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 20
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(6, 354)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 19
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'dtFechaVencimiento
        '
        Me.dtFechaVencimiento.Location = New System.Drawing.Point(85, 300)
        Me.dtFechaVencimiento.Name = "dtFechaVencimiento"
        Me.dtFechaVencimiento.Size = New System.Drawing.Size(200, 20)
        Me.dtFechaVencimiento.TabIndex = 18
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.Location = New System.Drawing.Point(117, 231)
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        Me.txtPrecioVenta.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecioVenta.TabIndex = 17
        '
        'txtPrecioCompra
        '
        Me.txtPrecioCompra.Location = New System.Drawing.Point(117, 195)
        Me.txtPrecioCompra.Name = "txtPrecioCompra"
        Me.txtPrecioCompra.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecioCompra.TabIndex = 16
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(117, 153)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(100, 20)
        Me.txtStock.TabIndex = 15
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(117, 112)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(100, 20)
        Me.txtDescripcion.TabIndex = 14
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(117, 71)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(100, 20)
        Me.txtnombre.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 269)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Fecha de vencimiento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Precio compra"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Precio Venta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Stock"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripcion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.checkEliminar)
        Me.GroupBox2.Controls.Add(Me.inexistente)
        Me.GroupBox2.Controls.Add(Me.datalistado)
        Me.GroupBox2.Controls.Add(Me.txtBuscar)
        Me.GroupBox2.Controls.Add(Me.cboBuscar)
        Me.GroupBox2.Location = New System.Drawing.Point(527, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(687, 400)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lista de productos"
        '
        'checkEliminar
        '
        Me.checkEliminar.AutoSize = True
        Me.checkEliminar.Location = New System.Drawing.Point(338, 26)
        Me.checkEliminar.Name = "checkEliminar"
        Me.checkEliminar.Size = New System.Drawing.Size(78, 17)
        Me.checkEliminar.TabIndex = 22
        Me.checkEliminar.Text = "Eliminar fila"
        Me.checkEliminar.UseVisualStyleBackColor = True
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(153, 203)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(93, 13)
        Me.inexistente.TabIndex = 21
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "Datos inexistentes"
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.eliminar})
        Me.datalistado.Location = New System.Drawing.Point(6, 56)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(820, 321)
        Me.datalistado.TabIndex = 20
        '
        'eliminar
        '
        Me.eliminar.HeaderText = "Eliminar"
        Me.eliminar.Name = "eliminar"
        Me.eliminar.ReadOnly = True
        Me.eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(170, 28)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(100, 20)
        Me.txtBuscar.TabIndex = 19
        '
        'cboBuscar
        '
        Me.cboBuscar.FormattingEnabled = True
        Me.cboBuscar.Items.AddRange(New Object() {"id_producto", "nombre", "descripcion", "stock"})
        Me.cboBuscar.Location = New System.Drawing.Point(6, 28)
        Me.cboBuscar.Name = "cboBuscar"
        Me.cboBuscar.Size = New System.Drawing.Size(121, 21)
        Me.cboBuscar.TabIndex = 0
        Me.cboBuscar.Text = "id_producto"
        '
        'btnEiminar
        '
        Me.btnEiminar.Location = New System.Drawing.Point(579, 431)
        Me.btnEiminar.Name = "btnEiminar"
        Me.btnEiminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEiminar.TabIndex = 23
        Me.btnEiminar.Text = "Eliminar"
        Me.btnEiminar.UseVisualStyleBackColor = True
        '
        'marca
        '
        Me.marca.Location = New System.Drawing.Point(1205, 12)
        Me.marca.Name = "marca"
        Me.marca.Size = New System.Drawing.Size(100, 20)
        Me.marca.TabIndex = 25
        '
        'txtnombreCategoria
        '
        Me.txtnombreCategoria.Location = New System.Drawing.Point(234, 45)
        Me.txtnombreCategoria.Name = "txtnombreCategoria"
        Me.txtnombreCategoria.Size = New System.Drawing.Size(75, 20)
        Me.txtnombreCategoria.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(170, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "IDCategoria"
        '
        'btnCategoria
        '
        Me.btnCategoria.Location = New System.Drawing.Point(325, 42)
        Me.btnCategoria.Name = "btnCategoria"
        Me.btnCategoria.Size = New System.Drawing.Size(75, 23)
        Me.btnCategoria.TabIndex = 29
        Me.btnCategoria.Text = "Seleccionar ..."
        Me.btnCategoria.UseVisualStyleBackColor = True
        '
        'FormProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1317, 482)
        Me.Controls.Add(Me.marca)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnEiminar)
        Me.Name = "FormProducto"
        Me.Text = "FormProducto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPrecioVenta As TextBox
    Friend WithEvents txtPrecioCompra As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents dtFechaVencimiento As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cboBuscar As ComboBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents datalistado As DataGridView
    Friend WithEvents inexistente As LinkLabel
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnEiminar As Button
    Friend WithEvents txtId As TextBox
    Friend WithEvents label As Label
    Friend WithEvents checkEliminar As CheckBox
    Friend WithEvents eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents marca As TextBox
    Friend WithEvents txtidcategoria As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCategoria As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtnombreCategoria As TextBox
End Class
