Public Class frmCatalogoTarifas
    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        If String.IsNullOrWhiteSpace(txtAnio.Text) Or String.IsNullOrWhiteSpace(txtCuota.Text) Or String.IsNullOrWhiteSpace(txtInfra.Text) Or String.IsNullOrWhiteSpace(txtRecargos.Text) Or String.IsNullOrWhiteSpace(txtTar.Text) Then
            MsgBox("AÚN HAY DATOS SIN LLENAR")
            txtAnio.Focus()

        Else
            txtAnio.Text = ""
            txtCuota.Text = ""
            txtInfra.Text = ""
            txtRecargos.Text = ""
            txtTar.Text = ""

            cmdInicio.Enabled = True
            cmdSiguiente.Enabled = True
            cmdAnterior.Enabled = True
            cmdUltimo.Enabled = True

            cmdSalir.Enabled = True
            cmdNuevo.Enabled = True
            cmdGrabar.Enabled = False
            cmdCancelar.Enabled = False

            dgTarifas.Enabled = True

            txtCuota.Enabled = False
            txtRecargos.Enabled = False
            txtTar.Enabled = False
            txtInfra.Enabled = False
            txtAnio.Enabled = False

            dgTarifas.Refresh()


        End If


    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim numTarifa As Integer

        numTarifa = TarifasBindingSource.Count + 1
        TarifasBindingSource.AddNew()
        txtIdTarifa.Text = numTarifa

        txtAnio.Focus()
        txtAnio.Text = ""
        txtCuota.Text = ""

        txtInfra.Text = ""
        txtRecargos.Text = ""
        txtTar.Text = ""

        cmdInicio.Enabled = False
        cmdSiguiente.Enabled = False
        cmdAnterior.Enabled = False
        cmdUltimo.Enabled = False

        cmdSalir.Enabled = False
        cmdNuevo.Enabled = False
        cmdGrabar.Enabled = True
        cmdCancelar.Enabled = True

        dgTarifas.Enabled = False

        txtCuota.Enabled = True
        txtRecargos.Enabled = True
        txtTar.Enabled = True
        txtInfra.Enabled = True
        txtAnio.Enabled = True






    End Sub

    Private Sub frmCatalogoTarifas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.tarifas' Puede moverla o quitarla según sea necesario.
        Me.TarifasTableAdapter.Fill(Me.DataSetSistema.tarifas)
        'dtpAnio.ShowUpDown = True
        'dtpAnio.Format = DateTimePickerFormat.Custom
        'dtpAnio.CustomFormat = "yyyy"
        dgTarifas.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Private Sub cmdInicio_Click(sender As Object, e As EventArgs) Handles cmdInicio.Click
        TarifasBindingSource.MoveFirst()
    End Sub

    Private Sub cmdSiguiente_Click(sender As Object, e As EventArgs) Handles cmdSiguiente.Click
        TarifasBindingSource.MoveNext()
    End Sub

    Private Sub cmdAnterior_Click(sender As Object, e As EventArgs) Handles cmdAnterior.Click
        TarifasBindingSource.MovePrevious()
    End Sub

    Private Sub cmdUltimo_Click(sender As Object, e As EventArgs) Handles cmdUltimo.Click
        TarifasBindingSource.MoveLast()
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        TarifasBindingSource.EndEdit()
        TarifasTableAdapter.Update(DataSetSistema.tarifas)
        Me.Dispose()
    End Sub



    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        TarifasBindingSource.CancelEdit()
        txtAnio.Text = ""
        txtCuota.Text = ""
        txtIdTarifa.Text = ""
        txtInfra.Text = ""
        txtRecargos.Text = ""
        txtTar.Text = ""

        cmdInicio.Enabled = True
        cmdSiguiente.Enabled = True
        cmdAnterior.Enabled = True
        cmdUltimo.Enabled = True

        cmdSalir.Enabled = True
        cmdNuevo.Enabled = True
        cmdGrabar.Enabled = False
        cmdCancelar.Enabled = False

        dgTarifas.Enabled = True

        txtCuota.Enabled = False
        txtRecargos.Enabled = False
        txtTar.Enabled = False
        txtInfra.Enabled = False
        txtAnio.Enabled = False

    End Sub

    Private Sub txtAnio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAnio.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaNumero, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtCuota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuota.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(cadenaPrecios, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtInfra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInfra.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(cadenaPrecios, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtRecargos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRecargos.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(cadenaPrecios, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtTar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTar.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(cadenaPrecios, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub
End Class