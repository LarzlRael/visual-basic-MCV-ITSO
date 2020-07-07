<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCategoria
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.txtNombreCategoria = New System.Windows.Forms.TextBox()
        Me.txtidcategoria = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtmarca = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dataListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.GroupBox2.Location = New System.Drawing.Point(477, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(581, 309)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listtado de categorias"
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
        Me.dataListado.Size = New System.Drawing.Size(544, 190)
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
        Me.btnEliminar.Location = New System.Drawing.Point(171, 280)
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
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.txtNombreCategoria)
        Me.GroupBox1.Controls.Add(Me.txtidcategoria)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(80, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 303)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Categoria"
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(144, 186)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 18
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(263, 231)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Cancelar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(127, 231)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(111, 23)
        Me.btnGuardar.TabIndex = 12
        Me.btnGuardar.Text = "Agregar Categoria"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(28, 231)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 11
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'txtNombreCategoria
        '
        Me.txtNombreCategoria.Location = New System.Drawing.Point(154, 73)
        Me.txtNombreCategoria.Name = "txtNombreCategoria"
        Me.txtNombreCategoria.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreCategoria.TabIndex = 6
        '
        'txtidcategoria
        '
        Me.txtidcategoria.Location = New System.Drawing.Point(154, 39)
        Me.txtidcategoria.Name = "txtidcategoria"
        Me.txtidcategoria.Size = New System.Drawing.Size(100, 20)
        Me.txtidcategoria.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre de categoria"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID categoria"
        '
        'txtmarca
        '
        Me.txtmarca.Location = New System.Drawing.Point(976, 12)
        Me.txtmarca.Name = "txtmarca"
        Me.txtmarca.Size = New System.Drawing.Size(100, 20)
        Me.txtmarca.TabIndex = 19
        '
        'frmCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1099, 393)
        Me.Controls.Add(Me.txtmarca)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmCategoria"
        Me.Text = "frmCategoria"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dataListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents btnEditar As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents txtNombreCategoria As TextBox
    Friend WithEvents txtidcategoria As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtmarca As TextBox
End Class
