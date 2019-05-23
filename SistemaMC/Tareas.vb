Public Class Tareas
        Dim nreg, pos As Integer 'variable para contar el número de filas otra para determinar 
        'la posición del registro actual
        Public esnuevo, esmodificar, eseliminar As Boolean
        Public llave As String


    Private Sub conteoreg()
        lblConteo.Text = "Registro " & pos + 1 & " de " & nreg
    End Sub

        'Permite mostrar los datos en las cajas de texto
        Private Sub Mdatos()
            Dim registro As DataRow ' Este objeto permite almacenar un registro o fila
        adaptaquery("Tareas", ssql) 'cargar en memoria la tablaClientes
        nreg = datos.Tables("Tareas").Rows.Count 'Contar la cantidad de filas
            If nreg > 0 Then 'Si hay al menos un registro
            registro = datos.Tables("Tareas").Rows(pos) 'Asigna del dataset un registro al datarow


                'Pregunta si el campo no es nulo para que lo muestre en la caja de texto de lo contrario escribe vacío
            If Not IsDBNull(registro("IdTarea")) Then
                Me.txtIdTarea.Text = registro("IdTarea")
            Else
                Me.txtIdTarea.Text = ""
            End If

            If Not IsDBNull(registro("DescripcionTarea")) Then
                Me.txtDescripcionTarea.Text = registro("DescripcionTarea")
            Else
                Me.txtDescripcionTarea.Text = ""
            End If

            If Not IsDBNull(registro("FechaTarea")) Then
                Me.dtpFecha.Value = registro("FechaTarea")
            Else
                Me.dtpFecha.Value = ""
            End If

            If Not IsDBNull(registro("CodVendedorAsignado")) Then
                Me.txtCodVendedor.Text = registro("CodVendedorAsignado")
            Else
                Me.txtCodVendedor.Text = ""
            End If

            End If
        End Sub
        Private Sub Tareas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.btnGuardar.Enabled = False
        pos = 0
        ssql = "Select * from Tareas"
        Mdatos()
        esnuevo = False
        esmodificar = False
        eseliminar = False
        conteoreg()
        End Sub

    Private Sub btnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        If pos < datos.Tables("Tareas").Rows.Count - 1 Then
            pos = pos + 1
            Mdatos()
        Else
            MsgBox("Último Registro")
        End If
        conteoreg()
    End Sub

    Private Sub btnAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnterior.Click
        If pos > 0 Then
            pos = pos - 1
            Mdatos()
        Else
            MsgBox("Primer Registro")
        End If
        conteoreg()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        esnuevo = True
        limpiar(Me)
        For Each z As Control In Me.Controls
            If TypeOf z Is Button Then
                z.Enabled = False
            End If
        Next

        Me.btnGuardar.Enabled = True
        Me.btnSiguiente.Enabled = True
        Me.btnAnterior.Enabled = True
        DesbloquearOb(Me)
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        DesbloquearOb(Me)
        esmodificar = True
        llave = Me.txtCodVendedor.Text
        For Each z As Control In Me.Controls
            If TypeOf z Is Button Then
                z.Enabled = False
            End If
        Next

        Me.btnGuardar.Enabled = True
        Me.txtCodVendedor.Enabled = False
        Me.btnSiguiente.Enabled = True
        Me.btnAnterior.Enabled = True
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        eseliminar = True
        EnteroEliminar = txtCodVendedor.Text
        If pos = 0 And (datos.Tables("Tareas").Rows.Count = 1) Then
            limpiar(Me)
        ElseIf pos = 0 And (datos.Tables("Tareas").Rows.Count > 1) Then
            pos = pos + 1
        Else
            pos = pos - 1
        End If
        btnGuardar.Enabled = True
        Mdatos()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If esnuevo = True Then
            accion = "Insert into Tareas (IdTarea, DescripcionTarea, FechaTarea, CodVendedorAsignado) values ('" & Me.txtIdTarea.Text & "','" & Me.txtDescripcionTarea.Text & "','" & dtpFecha.Value & "','" & txtCodVendedor.Text & "')"
        End If

        If esmodificar Then
            accion = "Update Tareas set IdTarea = '" & Me.txtIdTarea.Text & "', DescripcionTarea ='" & Me.txtDescripcionTarea.Text & "', FechaTarea ='" & Me.dtpFecha.Value & "', CodVendedorAsignado ='" & Me.txtCodVendedor.Text & "' where CodVendedorAsignado='" & llave & "' "
        End If

        If eseliminar Then
            accion = "Delete from Tareas where CodVendedorAsignado =" & EnteroEliminar
        End If

        ejecutar(accion)
        esnuevo = False
        esmodificar = False
        eseliminar = False

        bloquearOb(Me)
        For Each z As Control In Me.Controls
            If TypeOf z Is Button Then
                z.Enabled = True
            End If
        Next
        Me.btnGuardar.Enabled = False
    End Sub

    Private Sub btnInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInicio.Click
        ssql = "Select * from Tareas"
        pos = 0
        bloquearOb(Me)

        For Each c As Control In Me.Controls
            If TypeOf c Is Button Then
                c.Enabled = True
            End If
        Next

        Me.btnGuardar.Enabled = False
        Mdatos()
        esnuevo = False
        esmodificar = False
        eseliminar = False
        conteoreg()
    End Sub
End Class