Public Class Form3

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        If e.Node.Name = "Nodo0" Then
            RichTextBox1.Text = "Ofrecer al público en general una excelente calidad en nuestros electrodomésticos, destacándonos  en servicio de excelencia, atención al cliente, y sobre todo en calidad de nuestros productos. Ofreciendo a nuestros clientes las cuotas más accesibles a su presupuesto manteniendo una tasa de interés inferior al 10%, además de un traslado seguro de los productos hasta la comodidad de su casa sin costo ningún costo extra, ya que nos mantenemos interesados en la comodidad y preferencia de nuestros clientes."
        ElseIf e.Node.Name = "Nodo1" Then
            RichTextBox1.Text = "Ser la empresa líder de electrodomésticos en el mercado, no solo por la calidad de nuestros productos, si no también por nuestra atención al cliente. En un promedio de 5 años habernos podido expandir a lo largo del país, ofrecer envios internacionales, haber implementado una campaña de marketing masiva,y con ella el aumento de nuestras ventas, fortalecer nuestro personal y ofrecer nuevas oportunidades de empleo para la población hondureña."
        End If
    End Sub
End Class