Imports System.Data.SqlClient

Public Class frmMovimientoCompraMaterialesConsultaID
    Dim conexionsql As New SqlConnection("Data Source = 'PRO'; initial Catalog = 'sistemaAguaPotable'; integrated security = true")
    Dim comando As SqlCommand = conexionsql.CreateCommand

    Dim lector As SqlDataReader

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Dim ordenBus As Integer = Val(txtOrden.Text)
        If txtOrden.Text = "" Then
            MsgBox("No se ha ingresado orden a buscar")
            txtOrden.Focus()

        Else
            Dim n As Integer

            comando.CommandText = "Select count(*) from comprasMateriales"
            n = comando.ExecuteScalar + 1
            If ordenBus < n Then
                dgConsulta.Rows.Clear()

                ordenBus = Val(txtOrden.Text)
                comando.CommandText = "Select comprasMateriales.id_Proveedor, proveedores.nombre, comprasMateriales.factura, comprasMateriales.fecha from comprasMateriales inner join proveedores on proveedores.id_proveedor = comprasMateriales.id_Proveedor  where comprasMateriales.id_Compra = " & ordenBus & ""
                lector = comando.ExecuteReader

                lector.Read()

                txtIdProve.Text = lector(1)
                txtProveedor.Text = lector(1)
                txtFactura.Text = lector(2)
                dtpFecha.Text = lector(3)
                lector.Close()

                comando.CommandText = "Select detCompraMateriales.id_Material, material.descripcion, detCompraMateriales.cantidad, detCompraMateriales.costo from detCompraMateriales inner join material on detCompraMateriales.id_Material = material.id_material	inner join comprasMateriales on comprasMateriales.id_Compra = detCompraMateriales.id_Compra where detCompraMateriales.id_Compra = " & ordenBus & ""
                lector = comando.ExecuteReader

                While lector.Read
                    dgConsulta.Rows.Add(lector(0), lector(1), lector(2), lector(3), (lector(2) * lector(3)))
                End While
                lector.Close()

            Else
                MsgBox("El numero de orden no se encuentra asignado aun")
                txtIdProve.Text = ""
                txtProveedor.Text = ""
                txtFactura.Text = ""
                dtpFecha.Text = ""
                dgConsulta.Rows.Clear()

            End If
        End If


    End Sub

    Private Sub frmMovimientoCompraMaterialesConsultaID_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionsql.Open()

    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        conexionsql.Close()
        Me.Dispose()

    End Sub
End Class