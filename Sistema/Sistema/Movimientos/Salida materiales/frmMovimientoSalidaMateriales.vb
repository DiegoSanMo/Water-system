Imports System.Data.SqlClient

Public Class frmMovimientoSalidaMateriales
    Dim conexionsql As New SqlConnection("Data Source= 'PRO'; Initial Catalog = 'sistemaAguaPotable'; Integrated security = true")
    Dim comando As SqlCommand = conexionsql.CreateCommand
    Dim lector As SqlDataReader
    Private Sub frmMovimientoSalidaMateriales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conexionsql.Open()
        comando.CommandText = "Select * from empleados"
        lector = comando.ExecuteReader

        While lector.Read
            cboEmpleados.Items.Add(lector(1))
        End While
        lector.Close()

        comando.CommandText = "Select * from calles"
        lector = comando.ExecuteReader

        While lector.Read
            cboCalle.Items.Add(lector(1))
        End While
        lector.Close()

        comando.CommandText = "Select * from material"
        lector = comando.ExecuteReader

        While lector.Read
            cboMaterial.Items.Add(lector(1))
        End While
        lector.Close()

    End Sub

    Private Sub cboEmpleados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEmpleados.SelectedIndexChanged
        comando.CommandText = "Select * from empleados where nombre = '" & cboEmpleados.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()

        txtIdEmpleado.Text = lector(0)
        txtDomicilio.Text = lector(2)
        txtCelular.Text = lector(6)

        lector.Close()

    End Sub

    Private Sub cboCalle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCalle.SelectedIndexChanged

        comando.CommandText = "Select * from calles where nombre = '" & cboCalle.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()

        txtIdCalle.Text = lector(0)
        txtTotalCasas.Text = lector(4)

        lector.Close()

    End Sub

    Private Sub cboMaterial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMaterial.SelectedIndexChanged

        comando.CommandText = "Select * from material where descripcion = '" & cboMaterial.Text & "'"
        lector = comando.ExecuteReader

        lector.Read()
        txtIdMaterial.Text = lector(0)
        txtExistencias.Text = lector(2)
        txtMaximo.Text = lector(3)
        txtMinimo.Text = lector(4)
        txtUnidad.Text = lector(5)
        txtCosto.Text = lector(6)
        dtpFechaCompra.Value = lector(7)

        lector.Close()
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Dim ban As Boolean = False
        Dim cont As Integer = 0
        Dim matBus As Integer = txtIdMaterial.Text

        For x = 0 To dgSalida.RowCount - 1
            If dgSalida(0, x).Value = matBus Then
                ban = True
                cont = x
                Exit For
            End If
        Next
        If ban Then
            dgSalida(2, cont).Value = dgSalida(2, cont).Value + Val(txtCantidad.Text)
            dgSalida(4, cont).Value = dgSalida(2, cont).Value * dgSalida(3, cont).Value
        Else
            dgSalida.Rows.Add(txtIdMaterial.Text, cboMaterial.Text, Val(txtCantidad.Text), CDec(txtCosto.Text), Val(txtCantidad.Text * txtCosto.Text))
        End If

        For i = 0 To dgSalida.RowCount - 1
            Dim s As Decimal
            s = s + dgSalida(4, i).Value
            lblSubTotal.Text = s
            lblIva.Text = s * 0.16
            lblTotal.Text = Val(lblSubTotal.Text) + Val(lblIva.Text)
        Next

    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        comando.CommandText = "Insert into salidasMaterial (id_Salida, id_Empleado, id_Calle, fecha, concepto) values(" & Val(txtIdSalida.Text) & ", " & Val(txtIdEmpleado.Text) & ", " & Val(txtIdCalle.Text) & ", '" & dtpFecha.Value.Date & "', '" & txtConcepto.Text & "')"
        comando.ExecuteNonQuery()
        Dim can As Integer = 0
        For i = 0 To dgSalida.RowCount - 2
            comando.CommandText = "Insert into detSalidaMateriales (id_Salida, id_Material, cantidad, costo) values( " & Val(txtIdSalida.Text) & ", " & Val(dgSalida(0, i).Value) & ", " & Val(dgSalida(2, i).Value) & ", " & CDec(dgSalida(3, i).Value) & ")"
            comando.ExecuteNonQuery()

            comando.CommandText = "Select * from material where material.id_material = " & Val(dgSalida(0, i).Value) & ""
            lector = comando.ExecuteReader
            lector.Read()
            can = lector(2)
            lector.Close()

            comando.CommandText = "Update material SET existencias = " & Val(can - dgSalida(2, i).Value) & " where material.id_material	= " & Val(dgSalida(0, i).Value) & ""
            comando.ExecuteNonQuery()

        Next

        dgSalida.Rows.Clear()
        txtIdEmpleado.Text = ""
        txtCelular.Text = ""
        txtDomicilio.Text = "
"
        txtIdCalle.Text = ""
        txtTotalCasas.Text = ""
        txtConcepto.Text = ""

        txtIdMaterial.Text = ""
        txtCosto.Text = ""
        txtMaximo.Text = ""
        txtMinimo.Text = ""
        txtUnidad.Text = ""
        txtExistencias.Text = ""
        txtCantidad.Text = ""

        cmdNuevo.Enabled = True
        cmdSalir.Enabled = True
        cmdAceptar.Enabled = False
        txtIdSalida.Text = ""
        txtCantidad.Enabled = False
        txtConcepto.Enabled = False
        cmdGrabar.Enabled = False
        lblSubTotal.Text = "$0.00"
        lblIva.Text = "$0.00"
        lblTotal.Text = "$0.00"



    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim n As Integer
        comando.CommandText = "Select count(*) from salidasMaterial"
        n = comando.ExecuteScalar + 1
        txtIdSalida.Text = n

        dtpFecha.Enabled = True
        txtConcepto.Enabled = True
        txtCantidad.Enabled = True
        cmdAceptar.Enabled = True
        cmdGrabar.Enabled = True
        cmdSalir.Enabled = True
        cmdNuevo.Enabled = False

        cboEmpleados.SelectedIndex = 0
        cboCalle.SelectedIndex = 0
        cboMaterial.SelectedIndex = 0
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        conexionsql.Close()
        Me.Dispose()
    End Sub
End Class