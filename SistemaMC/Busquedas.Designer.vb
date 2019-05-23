<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Busquedas
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdbIdProducto = New System.Windows.Forms.RadioButton()
        Me.rdbNombreProducto = New System.Windows.Forms.RadioButton()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadExistenciasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SistemaDataSet = New SistemaMC.SistemaDataSet()
        Me.ProductosTableAdapter = New SistemaMC.SistemaDataSetTableAdapters.ProductosTableAdapter()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(268, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Busqueda de Productos"
        '
        'rdbIdProducto
        '
        Me.rdbIdProducto.AutoSize = True
        Me.rdbIdProducto.Location = New System.Drawing.Point(150, 82)
        Me.rdbIdProducto.Name = "rdbIdProducto"
        Me.rdbIdProducto.Size = New System.Drawing.Size(80, 17)
        Me.rdbIdProducto.TabIndex = 1
        Me.rdbIdProducto.TabStop = True
        Me.rdbIdProducto.Text = "Id Producto"
        Me.rdbIdProducto.UseVisualStyleBackColor = True
        '
        'rdbNombreProducto
        '
        Me.rdbNombreProducto.AutoSize = True
        Me.rdbNombreProducto.Location = New System.Drawing.Point(459, 91)
        Me.rdbNombreProducto.Name = "rdbNombreProducto"
        Me.rdbNombreProducto.Size = New System.Drawing.Size(125, 17)
        Me.rdbNombreProducto.TabIndex = 2
        Me.rdbNombreProducto.TabStop = True
        Me.rdbNombreProducto.Text = "Nombre del Producto"
        Me.rdbNombreProducto.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(260, 122)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(98, 20)
        Me.txtBuscar.TabIndex = 3
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(367, 118)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(73, 23)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'dgvProductos
        '
        Me.dgvProductos.AutoGenerateColumns = False
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProductoDataGridViewTextBoxColumn, Me.NombreProductoDataGridViewTextBoxColumn, Me.PrecioUnidadDataGridViewTextBoxColumn, Me.CantidadExistenciasDataGridViewTextBoxColumn})
        Me.dgvProductos.DataSource = Me.ProductosBindingSource
        Me.dgvProductos.Location = New System.Drawing.Point(114, 158)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.Size = New System.Drawing.Size(443, 150)
        Me.dgvProductos.TabIndex = 5
        '
        'IdProductoDataGridViewTextBoxColumn
        '
        Me.IdProductoDataGridViewTextBoxColumn.DataPropertyName = "IdProducto"
        Me.IdProductoDataGridViewTextBoxColumn.HeaderText = "IdProducto"
        Me.IdProductoDataGridViewTextBoxColumn.Name = "IdProductoDataGridViewTextBoxColumn"
        '
        'NombreProductoDataGridViewTextBoxColumn
        '
        Me.NombreProductoDataGridViewTextBoxColumn.DataPropertyName = "NombreProducto"
        Me.NombreProductoDataGridViewTextBoxColumn.HeaderText = "NombreProducto"
        Me.NombreProductoDataGridViewTextBoxColumn.Name = "NombreProductoDataGridViewTextBoxColumn"
        '
        'PrecioUnidadDataGridViewTextBoxColumn
        '
        Me.PrecioUnidadDataGridViewTextBoxColumn.DataPropertyName = "PrecioUnidad"
        Me.PrecioUnidadDataGridViewTextBoxColumn.HeaderText = "PrecioUnidad"
        Me.PrecioUnidadDataGridViewTextBoxColumn.Name = "PrecioUnidadDataGridViewTextBoxColumn"
        '
        'CantidadExistenciasDataGridViewTextBoxColumn
        '
        Me.CantidadExistenciasDataGridViewTextBoxColumn.DataPropertyName = "CantidadExistencias"
        Me.CantidadExistenciasDataGridViewTextBoxColumn.HeaderText = "CantidadExistencias"
        Me.CantidadExistenciasDataGridViewTextBoxColumn.Name = "CantidadExistenciasDataGridViewTextBoxColumn"
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.SistemaDataSet
        '
        'SistemaDataSet
        '
        Me.SistemaDataSet.DataSetName = "SistemaDataSet"
        Me.SistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'Busquedas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 357)
        Me.Controls.Add(Me.dgvProductos)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.rdbNombreProducto)
        Me.Controls.Add(Me.rdbIdProducto)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Busquedas"
        Me.Text = "Form1"
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rdbIdProducto As System.Windows.Forms.RadioButton
    Friend WithEvents rdbNombreProducto As System.Windows.Forms.RadioButton
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents dgvProductos As System.Windows.Forms.DataGridView
    Friend WithEvents SistemaDataSet As SistemaMC.SistemaDataSet
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTableAdapter As SistemaMC.SistemaDataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents IdProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadExistenciasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
