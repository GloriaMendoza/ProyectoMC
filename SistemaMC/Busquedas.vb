Public Class Busquedas

    Private Sub Busquedas_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Transacciones.Show()
        'DesbloquearOb(Transaccion)
        'Transaccion.btnGuardar.Enabled = True
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SistemaDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.SistemaDataSet.Productos)
        dgvProductos.Enabled = False
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If rdbIdProducto.Checked = False And rdbNombreProducto.Checked = False Then
            MsgBox("Seleccione un criterio de búsqueda", MsgBoxStyle.Exclamation, "Advertencia")
        Else
            If rdbIdProducto.Checked = True Then
                If IsNumeric(txtBuscar.Text) = True Then
                    Me.ProductosBindingSource.Filter = "IdProducto =" & txtBuscar.Text
                Else
                    MsgBox("El código del producto es un valor numérico", MsgBoxStyle.Critical, "Error")
                    txtBuscar.Clear()
                End If
            End If
            If rdbNombreProducto.Checked = True Then
                Me.ProductosBindingSource.Filter = "NombreProducto like'" & txtBuscar.Text & "%'"
            End If
        End If
    End Sub
    Private Sub dgvProductos_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProductos.CellContentDoubleClick
        Transacciones.dgvFacturas.CurrentRow.Cells(2).Value = Me.dgvProductos.CurrentRow.Cells.Item(0).Value
        Me.Close()
    End Sub
End Class
