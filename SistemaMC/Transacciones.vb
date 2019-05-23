Public Class Transacciones

    Private Sub Transacciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SistemaDataSet.Facturas' Puede moverla o quitarla según sea necesario.
        Me.FacturasTableAdapter.Fill(Me.SistemaDataSet.Facturas)
        'TODO: esta línea de código carga datos en la tabla 'SistemaDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.SistemaDataSet.Productos)

    End Sub
End Class