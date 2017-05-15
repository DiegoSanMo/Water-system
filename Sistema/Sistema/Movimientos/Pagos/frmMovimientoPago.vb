Imports System.Data.SqlClient

Public Class frmMovimientoPago
    Dim conexionsql As New SqlConnection("Data Source = 'PRO'; Initial Catalog = 'sistemaAguaPotable'; integrated security = true")
    Dim comando As SqlCommand = conexionsql.CreateCommand
    Dim lector As SqlDataReader
    Dim inicio, final As Integer
    Dim anio, posT, mesesDif As Integer
    Dim banMeses As Boolean = False
    Dim banCambiaM As Boolean = False
    Dim meses As String() = {"ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"}





    Private Sub frmMovimientoPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionsql.Open()

        comando.CommandText = "Select * from servicios"
        lector = comando.ExecuteReader

        While lector.Read
            cboServicio.Items.Add(lector(1))
        End While
        lector.Close()

        comando.CommandText = "Select * from empleados"
        lector = comando.ExecuteReader

        While lector.Read
            cboEmpleado.Items.Add(lector(1))
        End While
        lector.Close()


        comando.CommandText = "Select * from tarifas"
        lector = comando.ExecuteReader

        While lector.Read
            cboTarifa.Items.Add(lector(1))
        End While
        lector.Close()

        comando.CommandText = "Select * from situacion"
        lector = comando.ExecuteReader

        While lector.Read
            cboSituacion.Items.Add(lector(1))
        End While
        lector.Close()

    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        dgCuenta.Rows.Clear()

        comando.CommandText = "Select cuentas.id_cuenta, cuentas.nombre, calles.nombre, cuentas.ultimoPagoA, cuentas.ultimoPagoM from cuentas inner join calles on cuentas.id_calle = calles.id_calle where cuentas.nombre like '%" & txtName.Text & "%';"
        lector = comando.ExecuteReader

        While lector.Read
            dgCuenta.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
        End While
        lector.Close()

    End Sub

    Private Sub dgCuenta_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCuenta.CellClick
        banMeses = False
        banCambiaM = False
        Dim fila As Integer
        fila = Me.dgCuenta.CurrentCell.RowIndex

        txtIdCuenta.Text = dgCuenta(0, fila).Value

        If dgCuenta(4, fila).Value = "00" Then

        Else
            Dim mes As String
            Dim pos As Integer

            If cboMesInicial.FindString(dgCuenta(4, fila).Value) Then
                mes = dgCuenta(4, fila).Value

                For x = 0 To 11
                    If mes = meses(x) Then
                        pos = x
                    End If
                Next
                posT = pos
                'mesesDif = pos - 11
                'cboMesInicial.Items.Clear()
                'For t = pos + 1 To 11
                '    cboMesInicial.Items.Add(meses(t))
                '    cboMesFinal.Items.Add(meses(t))
                'Next
                'cboMesInicial.SelectedIndex = pos
                'cboMesFinal.Enabled = True
                banMeses = True
            End If

        End If

    End Sub

    Private Sub rbAgua_CheckedChanged(sender As Object, e As EventArgs) Handles rbAgua.CheckedChanged
        grupoAgua.Visible = True
        grupoServicio.Visible = False

        'limpiar caja de textos de servicio
        txtIdServicio.Text = ""
        txtPrecio.Text = ""
    End Sub

    Private Sub rbServicio_CheckedChanged(sender As Object, e As EventArgs)
        grupoAgua.Visible = False
        grupoServicio.Visible = True

        'limpiar caja de textos de agua

    End Sub

    Private Sub rbServicio_CheckedChanged_1(sender As Object, e As EventArgs) Handles rbServicio.CheckedChanged
        grupoAgua.Visible = False
        grupoServicio.Visible = True
    End Sub

    Private Sub cboSituacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSituacion.SelectedIndexChanged
        comando.CommandText = "Select * from situacion where situacion.descripcion = '" & cboSituacion.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()

        txtIdSituacion.Text = lector(0)
        txtDescuento.Text = lector(2)
        lector.Close()
        cboTarifa.Enabled = True

    End Sub

    Private Sub cboTarifa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTarifa.SelectedIndexChanged
        comando.CommandText = "Select * from tarifas where tarifas.anio = '" & cboTarifa.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        txtIdTarifa.Text = lector(0)
        anio = Val(lector(1))
        txtCuota.Text = lector(2)
        txtRecargo.Text = lector(3)
        txtTarifa.Text = lector(4)
        txtInfra.Text = lector(5)


        lector.Close()
        If banMeses Then

            Dim fila As Integer = dgCuenta.CurrentCell.RowIndex
            If dgCuenta(4, fila).Value = (cboMesInicial.Items(11).ToString) Then

                cboMesInicial.Enabled = True
                cboMesInicial.SelectedIndex = 0
                banCambiaM = True

                'For t = 0 To 11
                '    cboMesFinal.Items.Add(cboMesInicial.Items(t))
                'Next
            Else
                cboMesInicial.Enabled = False
                cboMesInicial.SelectedIndex = posT
            For t = posT + 1 To 11
                cboMesFinal.Items.Add(cboMesInicial.Items(t))
            Next
        End If
        Else
            cboMesInicial.Enabled = True
            cboMesInicial.SelectedIndex = 0
        End If


    End Sub

    Private Sub cboMesFinal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMesFinal.SelectedIndexChanged
        Dim s As Decimal
        txtOtro.Enabled = True
        If dtpFecha.Value.Year = cboTarifa.SelectedItem.ToString Then
            txtRecargo.Text = "0.00"
            txtRecargoAplicado.Text = "0.00"

            Dim inicio, fin, dif As Integer

            inicio = cboMesInicial.SelectedIndex

            'Ciclo que nos permite saber la ubicacion de los meses y posteriormente saber la diferencia que existe entre los meses
            For i = 0 To cboMesInicial.Items.Count - 1
                If cboMesInicial.Items(i).ToString = cboMesFinal.SelectedItem.ToString Then
                    fin = i
                End If
            Next
            dif = fin - inicio + 1

            If txtDescuento.Text > Val("0.00") Then
                If dif < 11 Then
                    Dim pag As Decimal = 0
                    pag = CDec(txtTarifa.Text / 12 * dif)
                    txtTarifaAplicada.Text = (txtDescuento.Text / 100) * pag

                    pag = 0
                    pag = CDec(txtCuota.Text / 12 * dif)
                    txtCuotaAplicada.Text = (txtDescuento.Text / 100) * pag

                    pag = 0
                    pag = CDec(txtInfra.Text / 12 * dif)
                    txtInfraAplicado.Text = (txtDescuento.Text / 100) * pag


                    s = CDec(txtTarifaAplicada.Text) + CDec(txtCuotaAplicada.Text) + CDec(txtInfraAplicado.Text)
                    txtTotal.Text = s
                    txtDescuentoAplicado.Text = 0.00
                    txtSubTotal.Text = s
                    txtTotalApagar.Text = s




                    'txtTarifaAplicada.Text = txtTarifa.Text / 12 * dif
                    'txtCuotaAplicada.Text = txtCuota.Text / 12 * dif
                    'txtInfraAplicado.Text = txtInfra.Text / 12 * dif

                    's = CDec(txtTarifaAplicada.Text) + CDec(txtCuotaAplicada.Text) + CDec(txtInfraAplicado.Text)
                    'txtTotal.Text = s
                    'txtDescuentoAplicado.Text = s - s * CDec(txtDescuento.Text) / 100

                    'txtSubTotal.Text = CDec(txtDescuentoAplicado.Text)
                    'txtTotalApagar.Text = txtSubTotal.Text
                    's = 0
                Else
                    txtTarifaAplicada.Text = txtTarifa.Text
                    txtCuotaAplicada.Text = txtCuota.Text
                    txtInfraAplicado.Text = txtInfra.Text

                    s = CDec(txtTarifaAplicada.Text) + CDec(txtCuotaAplicada.Text) + CDec(txtInfraAplicado.Text)
                    txtTotal.Text = s
                    txtDescuentoAplicado.Text = s - s * CDec(txtDescuento.Text) / 100

                    txtSubTotal.Text = CDec(txtDescuentoAplicado.Text)
                    txtTotalApagar.Text = txtSubTotal.Text
                    s = 0
                End If
            Else
                If dif < 11 Then
                    txtTarifaAplicada.Text = txtTarifa.Text / 12 * dif
                    txtCuotaAplicada.Text = txtCuota.Text / 12 * dif
                    txtInfraAplicado.Text = txtInfra.Text / 12 * dif

                    s = CDec(txtTarifaAplicada.Text) + CDec(txtCuotaAplicada.Text) + CDec(txtInfraAplicado.Text)
                    txtTotal.Text = s
                    txtDescuentoAplicado.Text = 0

                    txtSubTotal.Text = CDec(txtTotal.Text)
                    txtTotalApagar.Text = txtSubTotal.Text
                    s = 0
                Else
                    txtTarifaAplicada.Text = txtTarifa.Text
                    txtCuotaAplicada.Text = txtCuota.Text
                    txtInfraAplicado.Text = txtInfra.Text

                    s = CDec(txtTarifaAplicada.Text) + CDec(txtCuotaAplicada.Text) + CDec(txtInfraAplicado.Text)
                    txtTotal.Text = s
                    txtDescuentoAplicado.Text = 0

                    txtSubTotal.Text = CDec(txtTotal.Text)
                    txtTotalApagar.Text = txtSubTotal.Text
                    s = 0
                End If
            End If
        Else
            s = 0
            MessageBox.Show("NO SE APLICARA DESCUENTO", "DESCUENTO NO APLICABLE", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'se tomara en cuenta la situación pero no se aplicara descuento
            Dim inicio, fin, dif As Integer
            inicio = cboMesInicial.SelectedIndex

            'Ciclo que nos permite saber la ubicacion de los meses y posteriormente saber la diferencia que existe entre los meses
            For i = 0 To cboMesInicial.Items.Count - 1
                If cboMesInicial.Items(i).ToString = cboMesFinal.SelectedItem.ToString Then
                    fin = i
                End If
            Next
            dif = fin - inicio + 1


            If dif < 11 Then
                txtTarifaAplicada.Text = (txtTarifa.Text) / 12 * dif
                txtCuotaAplicada.Text = (txtCuota.Text) / 12 * dif
                txtInfraAplicado.Text = (txtInfra.Text) / 12 * dif
                txtRecargoAplicado.Text = (txtRecargo.Text) / 12 * dif
                s = CDec(txtTarifaAplicada.Text) + CDec(txtCuotaAplicada.Text) + CDec(txtInfraAplicado.Text) + CDec(txtRecargoAplicado.Text)
                txtTotal.Text = s
                txtDescuentoAplicado.Text = 0

                txtSubTotal.Text = txtTotal.Text
                txtTotalApagar.Text = txtTotal.Text
                s = 0


            Else
                txtTarifaAplicada.Text = (txtTarifa.Text)
                txtCuotaAplicada.Text = (txtCuota.Text)
                txtInfraAplicado.Text = (txtInfra.Text)
                txtRecargoAplicado.Text = txtRecargo.Text


                s = CDec(txtTarifaAplicada.Text) + CDec(txtCuotaAplicada.Text) + CDec(txtInfraAplicado.Text + CDec(txtRecargoAplicado.Text))
                txtTotal.Text = s
                txtDescuentoAplicado.Text = 0

                txtSubTotal.Text = txtTotal.Text
                txtTotalApagar.Text = txtTotal.Text
                s = 0

                'txtSubTotal.Text = Val(txtTarifaAplicada.Text) + Val(txtCuotaAplicada.Text) + Val(txtInfraAplicado.Text) + Val(txtRecargoAplicado.Text)
                'txtTotalApagar.Text = txtSubTotal.Text
            End If

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim n As Integer
        comando.CommandText = "Select count(*) from pagos"
        n = comando.ExecuteScalar() + 1
        txtIdPago.Text = n


        cmdGrabar.Enabled = True
        cmdImprimir.Enabled = True
        cmdSalir.Enabled = True

        cmdNuevo.Enabled = False

        rbAgua.Enabled = True
        rbServicio.Enabled = True

        rbAgua.Checked = True

        txtName.Enabled = True
        txtName.Focus()


    End Sub

    Private Sub cboMesInicial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMesInicial.SelectedIndexChanged
        Dim fila As Integer = dgCuenta.CurrentRow.Index

        If banMeses Then
            'For x = posT To mesesDif
            '    cboMesFinal.Items.Add(cboMesInicial.Items(x))
            'Next
            cboMesFinal.Enabled = True
            If banCambiaM Then
                inicio = cboMesInicial.SelectedIndex
                cboMesFinal.Items.Clear()

                For i = inicio To 11
                    cboMesFinal.Items.Add(cboMesInicial.Items(i))
                Next
                cboMesFinal.Enabled = True
            End If
            'cboMesInicial.Enabled = False

        Else
            inicio = cboMesInicial.SelectedIndex

            MsgBox(inicio)
            cboMesFinal.Items.Clear()

            For i = inicio To 11
                cboMesFinal.Items.Add(cboMesInicial.Items(i))
            Next
            cboMesFinal.Enabled = True
        End If






    End Sub



    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click

        conexionsql.Close()
        Me.Close()

    End Sub

    Private Sub txtOtro_TextChanged(sender As Object, e As EventArgs) Handles txtOtro.TextChanged

        Dim suma As Decimal
        If rbAgua.Checked Then
            If txtDescuentoAplicado.Text = 0 Then
                suma = CDec(txtTotal.Text)
            Else
                suma = CDec(txtDescuentoAplicado.Text)
            End If

            If dtpFecha.Value.Year = cboTarifa.SelectedItem.ToString Then

                suma = suma + Val(txtOtro.Text)
                txtSubTotal.Text = suma
                txtTotalApagar.Text = CDec(txtSubTotal.Text)
            Else


                suma = suma + Val(txtOtro.Text)
                txtSubTotal.Text = suma
                txtTotalApagar.Text = CDec(txtSubTotal.Text)

            End If

            suma = 0

        End If

    End Sub

    Private Sub cboServicio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboServicio.SelectedIndexChanged

        comando.CommandText = "Select * from  servicios where descripcion = '" & cboServicio.Text & "'"
        lector = comando.ExecuteReader

        lector.Read()

        txtIdServicio.Text = lector(0)
        txtPrecio.Text = lector(2)
        lector.Close()


    End Sub

    Private Sub cboEmpleado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEmpleado.SelectedIndexChanged

        comando.CommandText = "Select * from  empleados where nombre = '" & cboEmpleado.Text & "'"
        lector = comando.ExecuteReader

        lector.Read()

        txtIdEmpleado.Text = lector(0)

        lector.Close()
    End Sub

    Private Sub cboTarifa_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboTarifa.SelectedValueChanged
        cboMesFinal.Enabled = False
        txtInfraAplicado.Text = ""
        txtRecargoAplicado.Text = ""
        txtTarifaAplicada.Text = ""
        txtCuotaAplicada.Text = ""

        cboMesFinal.Items.Clear()

        txtOtro.Text = ""
        txtOtro.Enabled = False
        txtSubTotal.Text = ""
        txtTotalApagar.Text = ""
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        Dim tipo As String
        If rbAgua.Checked Then
            If txtOtro.Text = "" Then
                tipo = "Agua"
                txtOtro.Text = CDec("0.00")
            Else
                tipo = "Agua"
            End If
            comando.CommandText = "Insert into pagos(id_Pago, id_Cuenta, fecha,	tipo, otros, total) values(" & Val(txtIdPago.Text) & ", " & Val(txtIdCuenta.Text) & ", '" & dtpFecha.Value.Date & "', '" & tipo & "', " & CDec(txtOtro.Text) & ", " & CDec(txtTotalApagar.Text) & " )"
            comando.ExecuteNonQuery()

            comando.CommandText = "Insert into agua (id_Pago, id_Situacion,	id_Tarifa,	mesInicial, mesFinal, cuotaF, recargo, tar, infra, descuento) values(" & Val(txtIdPago.Text) & ", " & Val(txtIdSituacion.Text) & ", " & Val(txtIdTarifa.Text) & ", '" & cboMesInicial.SelectedItem.ToString & "', '" & cboMesFinal.SelectedItem.ToString & "', " & CDec(txtCuotaAplicada.Text) & ", " & CDec(txtRecargoAplicado.Text) & ", " & CDec(txtTarifaAplicada.Text) & ", " & CDec(txtInfraAplicado.Text) & ", " & CDec(txtDescuentoAplicado.Text) & ")"
            comando.ExecuteNonQuery()

            comando.CommandText = "UPDATE cuentas SET ultimoPagoA = '" & cboTarifa.Text & "', ultimoPagoM = '" & cboMesFinal.SelectedItem.ToString & "' WHERE id_cuenta = " & Val(txtIdCuenta.Text) & ""
            comando.ExecuteNonQuery()

            txtIdSituacion.Text = ""
            txtDescuento.Text = ""
            txtIdTarifa.Text = ""
            txtCuota.Text = ""
            txtCuotaAplicada.Text = ""
            txtRecargo.Text = ""
            txtRecargoAplicado.Text = ""
            txtInfra.Text = ""
            txtInfraAplicado.Text = ""
            txtTarifa.Text = ""
            txtTarifaAplicada.Text = ""
            txtTotal.Text = ""
            txtTotalApagar.Text = ""
            txtSubTotal.Text = ""
            txtDescuentoAplicado.Text = ""

            cmdGrabar.Enabled = False
            cmdNuevo.Enabled = True
            cmdGrabar.Enabled = False
            cmdImprimir.Enabled = False
            cmdSalir.Enabled = True


        Else
            tipo = "Servicio"
            txtOtro.Text = CDec("0.00")
            comando.CommandText = "Insert into pagos(id_Pago, id_Cuenta, fecha,	tipo, otros, total) values(" & Val(txtIdPago.Text) & ", " & Val(txtIdCuenta.Text) & ", '" & dtpFecha.Value.Date & "', '" & tipo & "', " & CDec(txtOtro.Text) & ", " & CDec(txtPrecio.Text) & " )"
            comando.ExecuteNonQuery()

            comando.CommandText = "Insert into serviciosAtendidos(id_Pago,	id_Servicio, id_Empleado, precio ) values(" & Val(txtIdPago.Text) & ", " & Val(txtIdServicio.Text) & ", " & Val(txtIdEmpleado.Text) & ", " & CDec(txtPrecio.Text) & ")"
            comando.ExecuteNonQuery()

            txtIdSituacion.Text = ""
            txtDescuento.Text = ""
            txtIdTarifa.Text = ""
            txtCuota.Text = ""
            txtCuotaAplicada.Text = ""
            txtRecargo.Text = ""
            txtRecargoAplicado.Text = ""
            txtInfra.Text = ""
            txtInfraAplicado.Text = ""
            txtTarifa.Text = ""
            txtTarifaAplicada.Text = ""
            txtTotal.Text = ""
            txtTotalApagar.Text = ""
            txtSubTotal.Text = ""
            txtDescuentoAplicado.Text = ""

            cmdGrabar.Enabled = False
            cmdNuevo.Enabled = True
            cmdGrabar.Enabled = False
            cmdImprimir.Enabled = False
            cmdSalir.Enabled = True
        End If
    End Sub



    Private Sub cboSituacion_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboSituacion.SelectedValueChanged
        cboMesFinal.Enabled = False
        cboMesInicial.Enabled = False
        cboTarifa.ResetText()

        txtIdTarifa.Text = ""
        txtInfra.Text = ""
        txtRecargo.Text = ""
        txtTarifa.Text = ""
        txtCuota.Text = ""

        txtInfraAplicado.Text = ""
        txtRecargoAplicado.Text = ""
        txtTarifaAplicada.Text = ""
        txtCuotaAplicada.Text = ""

        cboMesFinal.Items.Clear()

        txtOtro.Text = ""
        txtOtro.Enabled = False
        txtSubTotal.Text = ""
        txtTotalApagar.Text = ""
        txtDescuentoAplicado.Text = ""
        txtTotal.Text = ""
    End Sub


End Class