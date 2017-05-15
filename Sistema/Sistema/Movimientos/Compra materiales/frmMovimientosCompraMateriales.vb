Imports System.Data.SqlClient

Public Class frmMovimientosCompraMateriales
    Dim conexionsql As New SqlConnection("Data Source = 'PRO'; initial Catalog = 'sistemaAguaPotable'; integrated security = true")
    Dim comando As SqlCommand = conexionsql.CreateCommand

    Dim lector As SqlDataReader

    Private Sub frmMovimientosCompraMateriales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionsql.Open()

        'cargar a cbo proveedores
        comando.CommandText = "Select * from proveedores"
        lector = comando.ExecuteReader
        While lector.Read
            cboProveedores.Items.Add(lector(1))
        End While
        lector.Close()

        'cargar a cbo materiales
        comando.CommandText = "Select * from material"
        lector = comando.ExecuteReader
        While lector.Read
            cboMaterial.Items.Add(lector(1))
        End While
        lector.Close()

    End Sub

    Private Sub cboProveedores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProveedores.SelectedIndexChanged
        comando.CommandText = "Select * from proveedores where nombre = '" & cboProveedores.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        txtIdProv.Text = lector(0)
        txtDom.Text = lector(2)
        txtTel.Text = lector(6)

        lector.Close()


    End Sub

    Private Sub cboMaterial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMaterial.SelectedIndexChanged
        comando.CommandText = "Select * from material where descripcion = '" & cboMaterial.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()

        txtIdMate.Text = lector(0)
        txtCostoA.Text = lector(6)
        txtExist.Text = lector(2)
        txtMax.Text = lector(3)
        txtMin.Text = lector(4)
        txtUnidad.Text = lector(5)

        lector.Close()

    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click

        Dim importe As Decimal
        Dim sumaSubtotal As Decimal
        Dim iva As Decimal
        Dim total As Decimal
        Dim matBuscado As Integer = Val(txtIdMate.Text)


        matBuscado = Val(txtIdMate.Text)

        If Val(txtCantidad.Text) > Val(txtMax.Text) Then
            MsgBox("La cantidad es superior al máximo del producto")
            txtCantidad.Focus()
        Else
            Dim ban As Boolean = False
            Dim cont As Integer = 0
            For x = 0 To dgCompra.RowCount - 1
                If (dgCompra(0, x).Value = Val(txtIdMate.Text)) Then
                    ban = True
                    cont = x
                    Exit For
                End If
            Next

            If ban = True Then
                dgCompra(2, cont).Value = dgCompra(2, cont).Value + Val(txtCantidad.Text)
                dgCompra(3, cont).Value = Val(txtCostoN.Text)
                dgCompra(4, cont).Value = dgCompra(2, cont).Value * Val(txtCostoN.Text)
            Else
                importe = Val(txtCantidad.Text) * Val(txtCostoN.Text)
                dgCompra.Rows.Add(txtIdMate.Text, cboMaterial.Text, txtCantidad.Text, txtCostoN.Text, importe)
            End If

            'importe = Val(txtCantidad.Text) * Val(txtCostoN.Text)
            'dgCompra.Rows.Add(txtIdMate.Text, cboMaterial.Text, txtCantidad.Text, txtCostoN.Text, importe)


            For i = 0 To dgCompra.RowCount() - 1
                sumaSubtotal = sumaSubtotal + CDec(dgCompra(4, i).Value)
            Next

            lblSubTotal.Text = CStr(sumaSubtotal)

            iva = CDec(sumaSubtotal * 0.16)
            lblIva.Text = CStr(iva)

            total = CDec(iva + sumaSubtotal)
            lblTotal.Text = CStr(total)
        End If

    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress

        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim n As Integer

        comando.CommandText = "Select count(*) from comprasMateriales"
        n = comando.ExecuteScalar + 1

        txtidOrden.Text = n
        txtidFactura.Text = n


        cmdAceptar.Enabled = True
        cmdGrabar.Enabled = True
        txtCantidad.Enabled = True
        txtCostoN.Enabled = True
        cmdNuevo.Enabled = False



        'Limpieza de textox de datos del proveedor
        dtpFecha.Enabled = True
        txtIdMate.Text = ""
        txtCostoA.Text = ""
        txtExist.Text = ""
        txtMax.Text = ""
        txtMin.Text = ""
        txtUnidad.Text = ""
        txtCantidad.Text = ""
        txtCostoN.Text = ""

        cboProveedores.SelectedIndex = 0
        cboMaterial.SelectedIndex = 0


    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        Dim cantidadMat As Integer


        comando.CommandText = "Insert into comprasMateriales(id_Compra, id_Proveedor, factura, fecha, subTotal, iva, total) values(" & Val(txtidOrden.Text) & ", " & Val(txtIdProv.Text) & ", " & Val(txtidFactura.Text) & ", '" & dtpFecha.Text & "', " & CDec(lblSubTotal.Text) & ", " & CDec(lblIva.Text) & ", " & CDec(lblTotal.Text) & " )"
        comando.ExecuteNonQuery()


        For f = 0 To dgCompra.RowCount() - 2
            comando.CommandText = "Insert into detCompraMateriales(id_Compra, id_Material, cantidad, costo) values(" & Val(txtidOrden.Text) & "," & Val(dgCompra(0, f).Value) & ", " & Val(dgCompra(2, f).Value) & ", " & CDec(dgCompra(3, f).Value) & ")"
            comando.ExecuteNonQuery()

            comando.CommandText = "Select * from material where id_material = " & Val(dgCompra(0, f).Value) & ""
            lector = comando.ExecuteReader
            lector.Read()
            cantidadMat = lector(2)
            lector.Close()



            comando.CommandText = "Update material SET existencias = " & cantidadMat + Val(dgCompra(2, f).Value) & " , costo = " & CDec(dgCompra(4, f).Value) & ", ultimaFechaCompra = '" & dtpFecha.Value.Date & "' WHERE material.id_material = " & Val(dgCompra(0, f).Value) & ""
            comando.ExecuteNonQuery()
        Next

        txtIdProv.Text = ""
        txtDom.Text = ""
        txtTel.Text = ""
        txtIdMate.Text = ""
        txtCostoA.Text = ""


        txtExist.Text = ""
        txtMax.Text = ""
        txtMin.Text = ""
        txtUnidad.Text = ""
        txtCantidad.Text = ""
        txtCostoN.Text = ""

        cmdAceptar.Enabled = False
        cmdGrabar.Enabled = False
        txtCantidad.Enabled = False
        txtCostoN.Enabled = False
        cmdNuevo.Enabled = True
        cmdSalir.Enabled = True
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        conexionsql.Close()
        Me.Dispose()

    End Sub

    Private Sub txtCantidad_Leave(sender As Object, e As EventArgs) Handles txtCantidad.Leave
        If (txtCantidad.Text = String.Empty) Then
            MessageBox.Show("No se ha ingresado cantidad de material.")
            txtCantidad.Focus()

        End If
    End Sub

    Private Sub txtCostoN_Leave(sender As Object, e As EventArgs) Handles txtCostoN.Leave
        If (txtCostoN.Text = String.Empty) Then
            MessageBox.Show("No se ha ingresado el costo del material.")
            txtCostoN.Focus()

        End If
    End Sub
End Class