Imports System.Data.Sql
Imports System.Data.SqlClient 'librería que permite utilizar los objetos de Datos con orientación a cliente SQL
Module Modulo
    Public cnn As SqlConnection 'permite establecer una conexión con el servidor SQL
    Public adaptar As SqlDataAdapter 'Permite ajustar los datos que se solicitaran a la base de datos
    Public datos As DataSet 'Objetos que permite almacenar un conjunto de datos
    Public comando As SqlCommand 'Objetos que nos permite modificar los registros a través de consultas sql
    Public respuesta As SqlDataReader
    Public identidad, tablas, ssql, accion, usuario, tipou As String
    Public EnteroEliminar As Integer

    Public Sub adaptaquery(ByVal tablap As String, ByVal query As String)
        'inicializar la conexión
        cnn = New SqlConnection
        'configurar la conexión
        cnn.ConnectionString = My.Settings.SistemaConnectionString
        'abre la conexión
        cnn.Open()
        'establecer que conjunto de datos utilizará
        adaptar = New SqlDataAdapter(query, cnn)
        'inicializó
        datos = New DataSet
        'llenar el data
        adaptar.Fill(datos, tablap)
        'termina la conexión
        cnn.Close()
    End Sub

    Public Sub limpiar(ByVal frm As Form)
        For Each ob In frm.Controls
            If TypeOf ob Is TextBox Then
                ob.text = ""
            End If
            If TypeOf ob Is MaskedTextBox Then
                ob.text = ""
            End If
            If TypeOf ob Is NumericUpDown Then
                ob.value = 0
            End If
            If TypeOf ob Is ComboBox Then
                ob.text = ""
            End If
            If TypeOf ob Is DateTimePicker Then
                ob.value = Date.Now
            End If
        Next
    End Sub

    Public Sub bloquearOb(ByVal frm As Form)
        For Each c In frm.Controls

            If TypeOf c Is TextBox Then
                c.enabled = False
            End If
            If TypeOf c Is MaskedTextBox Then
                c.enabled = False
            End If
            If TypeOf c Is NumericUpDown Then
                c.enabled = False
            End If
            If TypeOf c Is ComboBox Then
                c.enabled = False
            End If
            If TypeOf c Is DateTimePicker Then
                c.enabled = False
            End If
            If TypeOf c Is DataGridView Then
                c.Enabled = False
            End If
        Next

    End Sub
    Public Sub DesbloquearOb(ByVal frm As Form)
        For Each c In frm.Controls

            If TypeOf c Is TextBox Then
                c.enabled = True
            End If
            If TypeOf c Is MaskedTextBox Then
                c.enabled = True
            End If
            If TypeOf c Is NumericUpDown Then
                c.enabled = True
            End If
            If TypeOf c Is ComboBox Then
                c.enabled = True
            End If
            If TypeOf c Is DateTimePicker Then
                c.enabled = True
            End If
            If TypeOf c Is DataGridView Then
                c.Enabled = True
            End If

        Next

    End Sub
    Public Sub ejecutar(ByVal x As String)
        Try
            cnn = New SqlConnection
            cnn.ConnectionString = My.Settings.SistemaConnectionString
            cnn.Open()
            comando = New SqlCommand(x, cnn)
            comando.ExecuteNonQuery()
            cnn.Close()
        Catch ex As Exception
            MsgBox("Error al Guardar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error Crítico")
        End Try
    End Sub
End Module
