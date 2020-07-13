<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formdetalleVenta
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.checkEliminar = New System.Windows.Forms.CheckBox()
        Me.dataListado = New System.Windows.Forms.DataGridView()
        Me.eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.cbotipodocumentbuscar = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtproducto = New System.Windows.Forms.TextBox()
        Me.txtidProducto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtpreciu_u = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.NumericUpDown()
        Me.txtCantidad = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.cboTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.txtnum_documento = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtfecha = New System.Windows.Forms.DateTimePicker()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtidcliente = New System.Windows.Forms.TextBox()
        Me.txtidVenta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dataListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.checkEliminar)
        Me.GroupBox2.Controls.Add(Me.dataListado)
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.txtbuscar)
        Me.GroupBox2.Controls.Add(Me.cbotipodocumentbuscar)
        Me.GroupBox2.Location = New System.Drawing.Point(440, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(581, 388)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado ventas"
        '
        'checkEliminar
        '
        Me.checkEliminar.AutoSize = True
        Me.checkEliminar.Location = New System.Drawing.Point(168, 49)
        Me.checkEliminar.Name = "checkEliminar"
        Me.checkEliminar.Size = New System.Drawing.Size(78, 17)
        Me.checkEliminar.TabIndex = 21
        Me.checkEliminar.Text = "Eliminar fila"
        Me.checkEliminar.UseVisualStyleBackColor = True
        '
        'dataListado
        '
        Me.dataListado.AllowUserToAddRows = False
        Me.dataListado.AllowUserToDeleteRows = False
        Me.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.eliminar})
        Me.dataListado.Location = New System.Drawing.Point(20, 72)
        Me.dataListado.Name = "dataListado"
        Me.dataListado.ReadOnly = True
        Me.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataListado.Size = New System.Drawing.Size(544, 244)
        Me.dataListado.TabIndex = 19
        '
        'eliminar
        '
        Me.eliminar.HeaderText = "Eliminar"
        Me.eliminar.Name = "eliminar"
        Me.eliminar.ReadOnly = True
        Me.eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(155, 345)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 14
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(31, 85)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(62, 17)
        Me.CheckBox1.TabIndex = 15
        Me.CheckBox1.Text = "Eliminar"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(233, 19)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(86, 20)
        Me.txtbuscar.TabIndex = 14
        '
        'cbotipodocumentbuscar
        '
        Me.cbotipodocumentbuscar.FormattingEnabled = True
        Me.cbotipodocumentbuscar.Items.AddRange(New Object() {"nro_documentos"})
        Me.cbotipodocumentbuscar.Location = New System.Drawing.Point(69, 19)
        Me.cbotipodocumentbuscar.Name = "cbotipodocumentbuscar"
        Me.cbotipodocumentbuscar.Size = New System.Drawing.Size(121, 21)
        Me.cbotipodocumentbuscar.TabIndex = 0
        Me.cbotipodocumentbuscar.Text = "nro_documentos"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.txtproducto)
        Me.GroupBox1.Controls.Add(Me.txtidProducto)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtpreciu_u)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtStock)
        Me.GroupBox1.Controls.Add(Me.txtCantidad)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.cboTipoDocumento)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.txtnum_documento)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtfecha)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.txtidcliente)
        Me.GroupBox1.Controls.Add(Me.txtidVenta)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(43, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 452)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle Venta"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(249, 298)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 15)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Stock"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(277, 248)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "buscar ...."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtproducto
        '
        Me.txtproducto.Location = New System.Drawing.Point(192, 248)
        Me.txtproducto.Name = "txtproducto"
        Me.txtproducto.Size = New System.Drawing.Size(79, 20)
        Me.txtproducto.TabIndex = 26
        '
        'txtidProducto
        '
        Me.txtidProducto.Location = New System.Drawing.Point(122, 248)
        Me.txtidProducto.Name = "txtidProducto"
        Me.txtidProducto.Size = New System.Drawing.Size(64, 20)
        Me.txtidProducto.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 248)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 15)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Producto"
        '
        'txtpreciu_u
        '
        Me.txtpreciu_u.Location = New System.Drawing.Point(116, 332)
        Me.txtpreciu_u.Name = "txtpreciu_u"
        Me.txtpreciu_u.Size = New System.Drawing.Size(122, 20)
        Me.txtpreciu_u.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 334)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 15)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Precio Unitario"
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(297, 293)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(73, 20)
        Me.txtStock.TabIndex = 21
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(118, 293)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(120, 20)
        Me.txtCantidad.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 298)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 15)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Cantidad"
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(133, 358)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 18
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'cboTipoDocumento
        '
        Me.cboTipoDocumento.FormattingEnabled = True
        Me.cboTipoDocumento.Items.AddRange(New Object() {"boleta", "Factura"})
        Me.cboTipoDocumento.Location = New System.Drawing.Point(124, 164)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Size = New System.Drawing.Size(121, 21)
        Me.cboTipoDocumento.TabIndex = 17
        Me.cboTipoDocumento.Text = "Boleta"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(252, 403)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Cancelar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(116, 403)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(111, 23)
        Me.btnGuardar.TabIndex = 12
        Me.btnGuardar.Text = "Agregar Producto"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(17, 403)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 11
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'txtnum_documento
        '
        Me.txtnum_documento.Location = New System.Drawing.Point(122, 208)
        Me.txtnum_documento.Name = "txtnum_documento"
        Me.txtnum_documento.Size = New System.Drawing.Size(122, 20)
        Me.txtnum_documento.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "N documento"
        '
        'txtfecha
        '
        Me.txtfecha.Location = New System.Drawing.Point(120, 116)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(122, 20)
        Me.txtfecha.TabIndex = 8
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(205, 76)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(86, 20)
        Me.txtnombre.TabIndex = 6
        '
        'txtidcliente
        '
        Me.txtidcliente.Location = New System.Drawing.Point(120, 76)
        Me.txtidcliente.Name = "txtidcliente"
        Me.txtidcliente.Size = New System.Drawing.Size(64, 20)
        Me.txtidcliente.TabIndex = 5
        '
        'txtidVenta
        '
        Me.txtidVenta.Location = New System.Drawing.Point(118, 42)
        Me.txtidVenta.Name = "txtidVenta"
        Me.txtidVenta.Size = New System.Drawing.Size(100, 20)
        Me.txtidVenta.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tipo documento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha Venta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "idCliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "idVenta"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(277, 358)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Ver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'formdetalleVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1065, 575)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "formdetalleVenta"
        Me.Text = "formdetalleVenta"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dataListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents checkEliminar As CheckBox
    Friend WithEvents dataListado As DataGridView
    Friend WithEvents eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents btnEliminar As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents cbotipodocumentbuscar As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents txtproducto As TextBox
    Friend WithEvents txtidProducto As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtpreciu_u As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtStock As NumericUpDown
    Friend WithEvents txtCantidad As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents btnEditar As Button
    Friend WithEvents cboTipoDocumento As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents txtnum_documento As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtfecha As DateTimePicker
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtidcliente As TextBox
    Friend WithEvents txtidVenta As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
End Class
