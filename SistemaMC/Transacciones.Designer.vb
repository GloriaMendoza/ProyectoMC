<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transacciones
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
        Dim IdFacturaLabel As System.Windows.Forms.Label
        Dim IdClienteLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim NombreClienteLabel As System.Windows.Forms.Label
        Me.SistemaDataSet = New SistemaMC.SistemaDataSet()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosTableAdapter = New SistemaMC.SistemaDataSetTableAdapters.ProductosTableAdapter()
        Me.FacturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturasTableAdapter = New SistemaMC.SistemaDataSetTableAdapters.FacturasTableAdapter()
        Me.TableAdapterManager = New SistemaMC.SistemaDataSetTableAdapters.TableAdapterManager()
        Me.IdFacturaTextBox = New System.Windows.Forms.TextBox()
        Me.IdClienteComboBox = New System.Windows.Forms.ComboBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NombreClienteComboBox = New System.Windows.Forms.ComboBox()
        Me.ProductosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvFacturas = New System.Windows.Forms.DataGridView()
        Me.IdFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodVendedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProducto = New System.Windows.Forms.DataGridViewComboBoxColumn()
        IdFacturaLabel = New System.Windows.Forms.Label()
        IdClienteLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        NombreClienteLabel = New System.Windows.Forms.Label()
        CType(Me.SistemaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdFacturaLabel
        '
        IdFacturaLabel.AutoSize = True
        IdFacturaLabel.Location = New System.Drawing.Point(24, 39)
        IdFacturaLabel.Name = "IdFacturaLabel"
        IdFacturaLabel.Size = New System.Drawing.Size(58, 13)
        IdFacturaLabel.TabIndex = 1
        IdFacturaLabel.Text = "Id Factura:"
        '
        'IdClienteLabel
        '
        IdClienteLabel.AutoSize = True
        IdClienteLabel.Location = New System.Drawing.Point(28, 79)
        IdClienteLabel.Name = "IdClienteLabel"
        IdClienteLabel.Size = New System.Drawing.Size(54, 13)
        IdClienteLabel.TabIndex = 3
        IdClienteLabel.Text = "Id Cliente:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(457, 43)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(40, 13)
        FechaLabel.TabIndex = 5
        FechaLabel.Text = "Fecha:"
        '
        'NombreClienteLabel
        '
        NombreClienteLabel.AutoSize = True
        NombreClienteLabel.Location = New System.Drawing.Point(457, 84)
        NombreClienteLabel.Name = "NombreClienteLabel"
        NombreClienteLabel.Size = New System.Drawing.Size(82, 13)
        NombreClienteLabel.TabIndex = 7
        NombreClienteLabel.Text = "Nombre Cliente:"
        '
        'SistemaDataSet
        '
        Me.SistemaDataSet.DataSetName = "SistemaDataSet"
        Me.SistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.SistemaDataSet
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'FacturasBindingSource
        '
        Me.FacturasBindingSource.DataMember = "Facturas"
        Me.FacturasBindingSource.DataSource = Me.SistemaDataSet
        '
        'FacturasTableAdapter
        '
        Me.FacturasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.ElementosLineaTableAdapter = Nothing
        Me.TableAdapterManager.FacturasTableAdapter = Me.FacturasTableAdapter
        Me.TableAdapterManager.ProductosTableAdapter = Me.ProductosTableAdapter
        Me.TableAdapterManager.UpdateOrder = SistemaMC.SistemaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IdFacturaTextBox
        '
        Me.IdFacturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturasBindingSource, "IdFactura", True))
        Me.IdFacturaTextBox.Location = New System.Drawing.Point(88, 36)
        Me.IdFacturaTextBox.Name = "IdFacturaTextBox"
        Me.IdFacturaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdFacturaTextBox.TabIndex = 2
        '
        'IdClienteComboBox
        '
        Me.IdClienteComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturasBindingSource, "IdCliente", True))
        Me.IdClienteComboBox.FormattingEnabled = True
        Me.IdClienteComboBox.Location = New System.Drawing.Point(88, 76)
        Me.IdClienteComboBox.Name = "IdClienteComboBox"
        Me.IdClienteComboBox.Size = New System.Drawing.Size(121, 21)
        Me.IdClienteComboBox.TabIndex = 4
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FacturasBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(503, 39)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaDateTimePicker.TabIndex = 6
        '
        'NombreClienteComboBox
        '
        Me.NombreClienteComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturasBindingSource, "NombreCliente", True))
        Me.NombreClienteComboBox.FormattingEnabled = True
        Me.NombreClienteComboBox.Location = New System.Drawing.Point(545, 81)
        Me.NombreClienteComboBox.Name = "NombreClienteComboBox"
        Me.NombreClienteComboBox.Size = New System.Drawing.Size(121, 21)
        Me.NombreClienteComboBox.TabIndex = 8
        '
        'ProductosBindingSource1
        '
        Me.ProductosBindingSource1.DataMember = "Productos"
        Me.ProductosBindingSource1.DataSource = Me.SistemaDataSet
        '
        'dgvFacturas
        '
        Me.dgvFacturas.AutoGenerateColumns = False
        Me.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdFacturaDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.IdClienteDataGridViewTextBoxColumn, Me.NombreClienteDataGridViewTextBoxColumn, Me.CodVendedorDataGridViewTextBoxColumn, Me.IdProducto})
        Me.dgvFacturas.DataSource = Me.FacturasBindingSource
        Me.dgvFacturas.Location = New System.Drawing.Point(106, 166)
        Me.dgvFacturas.Name = "dgvFacturas"
        Me.dgvFacturas.Size = New System.Drawing.Size(640, 150)
        Me.dgvFacturas.TabIndex = 9
        '
        'IdFacturaDataGridViewTextBoxColumn
        '
        Me.IdFacturaDataGridViewTextBoxColumn.DataPropertyName = "IdFactura"
        Me.IdFacturaDataGridViewTextBoxColumn.HeaderText = "IdFactura"
        Me.IdFacturaDataGridViewTextBoxColumn.Name = "IdFacturaDataGridViewTextBoxColumn"
        Me.IdFacturaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        '
        'IdClienteDataGridViewTextBoxColumn
        '
        Me.IdClienteDataGridViewTextBoxColumn.DataPropertyName = "IdCliente"
        Me.IdClienteDataGridViewTextBoxColumn.HeaderText = "IdCliente"
        Me.IdClienteDataGridViewTextBoxColumn.Name = "IdClienteDataGridViewTextBoxColumn"
        '
        'NombreClienteDataGridViewTextBoxColumn
        '
        Me.NombreClienteDataGridViewTextBoxColumn.DataPropertyName = "NombreCliente"
        Me.NombreClienteDataGridViewTextBoxColumn.HeaderText = "NombreCliente"
        Me.NombreClienteDataGridViewTextBoxColumn.Name = "NombreClienteDataGridViewTextBoxColumn"
        '
        'CodVendedorDataGridViewTextBoxColumn
        '
        Me.CodVendedorDataGridViewTextBoxColumn.DataPropertyName = "CodVendedor"
        Me.CodVendedorDataGridViewTextBoxColumn.HeaderText = "CodVendedor"
        Me.CodVendedorDataGridViewTextBoxColumn.Name = "CodVendedorDataGridViewTextBoxColumn"
        '
        'IdProducto
        '
        Me.IdProducto.DataSource = Me.ProductosBindingSource
        Me.IdProducto.DisplayMember = "NombreProducto"
        Me.IdProducto.HeaderText = "IdProducto"
        Me.IdProducto.Name = "IdProducto"
        Me.IdProducto.ValueMember = "IdProducto"
        '
        'Transacciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 419)
        Me.Controls.Add(Me.dgvFacturas)
        Me.Controls.Add(NombreClienteLabel)
        Me.Controls.Add(Me.NombreClienteComboBox)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(IdClienteLabel)
        Me.Controls.Add(Me.IdClienteComboBox)
        Me.Controls.Add(IdFacturaLabel)
        Me.Controls.Add(Me.IdFacturaTextBox)
        Me.Name = "Transacciones"
        Me.Text = "Transacciones"
        CType(Me.SistemaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SistemaDataSet As SistemaMC.SistemaDataSet
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTableAdapter As SistemaMC.SistemaDataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents FacturasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FacturasTableAdapter As SistemaMC.SistemaDataSetTableAdapters.FacturasTableAdapter
    Friend WithEvents TableAdapterManager As SistemaMC.SistemaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdFacturaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdClienteComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents NombreClienteComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ProductosBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents dgvFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents IdFacturaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodVendedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdProducto As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
