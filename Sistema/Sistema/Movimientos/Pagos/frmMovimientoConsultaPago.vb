Imports System.Data.SqlClient
Public Class frmMovimientoConsultaPago
    Dim conexionsql As New SqlConnection("Data Source = 'PRO'; Initial Catalog = 'sistemaAguaPotable'; integrated security = true")
    Dim comando As SqlCommand = conexionsql.CreateCommand
    Dim lector As SqlDataReader

    Private Sub rbTipoPago_CheckedChanged(sender As Object, e As EventArgs) Handles rbTipoPago.CheckedChanged
        cboTipo.Enabled = True
        txtNombre.Enabled = False
        dtpFechaInicio.Enabled = False
        dtpFechaFinal.Enabled = False
        txtNombre.Text = ""
    End Sub

    Private Sub rbCuenta_CheckedChanged(sender As Object, e As EventArgs) Handles rbCuenta.CheckedChanged
        txtNombre.Enabled = True
        cboTipo.Enabled = False
        dtpFechaInicio.Enabled = False
        dtpFechaFinal.Enabled = False
        txtNombre.Text = ""

    End Sub

    Private Sub rbFecha_CheckedChanged(sender As Object, e As EventArgs) Handles rbFecha.CheckedChanged

        dgConsultaPago.Rows.Clear()
        dtpFechaInicio.Enabled = True
        dtpFechaFinal.Enabled = True
        txtNombre.Enabled = False
        cboTipo.Enabled = False
        txtNombre.Text = ""

        dgConsultaPago.Rows.Clear()

    End Sub


    Private Sub frmMovimientoConsultaPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionsql.Open()

    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        Dim CadenaValida As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZÁÉÍÓÚ "
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaValida, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        dgConsultaPago.Rows.Clear()
        comando.CommandText = "Select pagos.id_Pago, cuentas.nombre, pagos.tipo, pagos.fecha, pagos.total from pagos inner join cuentas on cuentas.id_cuenta = pagos.id_Cuenta where cuentas.nombre like '%" & txtNombre.Text & "%'"
        lector = comando.ExecuteReader

        While lector.Read
            dgConsultaPago.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
        End While
        lector.Close()
    End Sub

    Private Sub cboTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipo.SelectedIndexChanged

        dgConsultaPago.Rows.Clear()
        comando.CommandText = "Select pagos.id_Pago, cuentas.nombre, pagos.tipo, pagos.fecha, pagos.total from pagos inner join cuentas on cuentas.id_cuenta = pagos.id_Cuenta where pagos.tipo = '" & cboTipo.Text & "'"
        lector = comando.ExecuteReader

        While lector.Read

            dgConsultaPago.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
        End While
        lector.Close()
    End Sub

    Private Sub dtpFechaFinal_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaFinal.ValueChanged

        dgConsultaPago.Rows.Clear()
        dtpFechaInicio.Enabled = True
        dtpFechaFinal.Enabled = True
        txtNombre.Enabled = False
        cboTipo.Enabled = False
        txtNombre.Text = ""


        comando.CommandText = "Select pagos.id_Pago, cuentas.nombre, pagos.tipo, pagos.fecha, pagos.total from pagos inner join cuentas on cuentas.id_cuenta = pagos.id_Cuenta where pagos.fecha  BETWEEN  '" & dtpFechaInicio.Value.Date & "' and '" & dtpFechaFinal.Value.Date & "'"
        lector = comando.ExecuteReader

        While lector.Read
            dgConsultaPago.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
        End While
        lector.Close()
    End Sub

    Private Sub dtpFechaInicio_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaInicio.ValueChanged
        dgConsultaPago.Rows.Clear()
        dtpFechaInicio.Enabled = True
        dtpFechaFinal.Enabled = True
        txtNombre.Enabled = False
        cboTipo.Enabled = False
        txtNombre.Text = ""


        comando.CommandText = "Select pagos.id_Pago, cuentas.nombre, pagos.tipo, pagos.fecha, pagos.total from pagos inner join cuentas on cuentas.id_cuenta = pagos.id_Cuenta where pagos.fecha  BETWEEN  '" & dtpFechaInicio.Value.Date & "' and '" & dtpFechaFinal.Value.Date & "'"
        lector = comando.ExecuteReader

        While lector.Read
            dgConsultaPago.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
        End While
        lector.Close()

    End Sub

    Private Sub cmdDetalles_Click(sender As Object, e As EventArgs) Handles cmdDetalles.Click
        'DetallesConsultaPago.Show()
        Dim detalle As New DetallesConsultaPago


        Dim fila As Integer = dgConsultaPago.CurrentRow.Index

        If dgConsultaPago.Item(2, fila).Value = "Agua" Then
            detalle.grupoServicio.Visible = False
            detalle.grupoAgua.Visible = True

            comando.CommandText = "Select agua.id_Situacion, situacion.descripcion, situacion.descuento, tarifas.anio, tarifas.id_tarifa, agua.mesInicial, agua.mesFinal, agua.cuotaF, agua.recargo	, agua.tar, agua.infra, pagos.otros, pagos.total from agua inner join situacion on situacion.id_situacion = agua.id_Situacion inner join tarifas on tarifas.id_tarifa = agua.id_Tarifa inner join pagos on pagos.id_Pago	 = agua.id_Pago	where agua.id_Pago ='" & dgConsultaPago.Item(0, fila).Value & "'"
            lector = comando.ExecuteReader

            lector.Read()
            detalle.txtIdSituacion.Text = lector(0)
            detalle.txtSituacion.Text = lector(1)
            detalle.txtSituacionDes.Text = lector(2)
            detalle.txtTarifa.Text = lector(3)
            detalle.txtIdTarifa.Text = lector(4)
            detalle.txttxtMesInicial.Text = lector(5)
            detalle.txtMesFinal.Text = lector(6)
            detalle.txtCuota.Text = lector(7)
            detalle.txtRecargo.Text = lector(8)
            detalle.txtTar.Text = lector(9)
            detalle.txtInfra.Text = lector(10)
            detalle.txtOtro.Text = lector(11)
            detalle.txtTotal.Text = lector(12)
            lector.Close()



        Else
            detalle.grupoServicio.Visible = True
            detalle.grupoAgua.Visible = False

            comando.CommandText = "Select serviciosAtendidos.id_Servicio, servicios.descripcion, servicios.precio, serviciosAtendidos.id_Empleado, empleados.nombre from  serviciosAtendidos inner join servicios on servicios.id_servicio = serviciosAtendidos.id_Servicio inner join empleados on empleados.id_empleado = serviciosAtendidos.id_Empleado where serviciosAtendidos.id_Pago = '" & dgConsultaPago.Item(0, fila).Value & "'"
            lector = comando.ExecuteReader
            lector.Read()

            detalle.txtIdServicio.Text = lector(0)
            detalle.txtNombreServicio.Text = lector(1)
            detalle.txtPrecio.Text = lector(2)
            detalle.txtIdEmpleado.Text = lector(3)
            detalle.txtNombreEmpleado.Text = lector(4)

            lector.Close()

        End If
        detalle.ShowDialog()
    End Sub

    Private Sub dgConsultaPago_SelectionChanged(sender As Object, e As EventArgs) Handles dgConsultaPago.SelectionChanged
        cmdDetalles.Visible = True
    End Sub
End Class