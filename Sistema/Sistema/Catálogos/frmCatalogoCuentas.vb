Public Class frmCatalogoCuentas
    Private Sub frmCatalogoCuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.cuentas' Puede moverla o quitarla según sea necesario.
        Me.CuentasTableAdapter.Fill(Me.DataSetSistema.cuentas)
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.calles' Puede moverla o quitarla según sea necesario.
        Me.CallesTableAdapter.Fill(Me.DataSetSistema.calles)
        Me.CuentasTableAdapter.Fill(Me.DataSetSistema.cuentas)
        dgCuenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click


        If String.IsNullOrWhiteSpace(txtNombreCue.Text) Or String.IsNullOrWhiteSpace(txtNombreCue.Text) Or txtNoExt.Text = 0 Then
            txtNoExt.Focus()
            MsgBox("NO SE PUEDEN DEJAR DATOS EN BLANCO")
        Else
            If txtNombreCue.TextLength < 5 Then
                txtNombreCue.Focus()
                MsgBox("SE DEBEN DE INGRESAR 5 CARACTERES COMO MINIMO")
            Else
                Dim valor As Integer
                valor = cboCalle.SelectedValue

                'botones
                cmdInicio.Enabled = True
                cmdSiguiente.Enabled = True
                cmdAnterior.Enabled = True
                cmdUltimo.Enabled = True

                cmdNuevo.Enabled = True
                cmdSalir.Enabled = True
                cmdGrabar.Enabled = False
                cmdCancelar.Enabled = False

                'Inicializar la fecha de año y mes en 0

                CuentasBindingSource.Current(1) = valor
                MsgBox(CallesBindingSource.Current("nombre"))
                MsgBox(CallesBindingSource.Current("id_calle"))
                CallesBindingSource.Current(4) = CallesBindingSource.Current(4) + 1
                CuentasBindingSource.Current(5) = dtpFechaAlta.Value.Date
                CuentasBindingSource.Current(6) = "00"
                CuentasBindingSource.Current(7) = "00"

                txtNoExt.ReadOnly = True
                txtNoInt.ReadOnly = True
                txtNombreCue.Enabled = False
                cboCalle.Enabled = False
                dtpFechaAlta.Enabled = False
                dgCuenta.Enabled = True


                txtNoInt.Text = vbEmpty
                txtNoExt.Text = vbEmpty

                dgCuenta.Refresh()
            End If
        End If

    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim numCuenta As Integer
        'botones 
        cmdInicio.Enabled = False
        cmdSiguiente.Enabled = False
        cmdAnterior.Enabled = False
        cmdUltimo.Enabled = False

        cmdNuevo.Enabled = False
        cmdSalir.Enabled = False
        cmdGrabar.Enabled = True
        cmdCancelar.Enabled = True

        numCuenta = CuentasBindingSource.Count + 1
        CuentasBindingSource.AddNew()
        txtIdCuenta.Text = numCuenta

        txtNoExt.ReadOnly = False
        txtNoInt.ReadOnly = False
        txtNombreCue.Enabled = True
        cboCalle.Enabled = True
        dtpFechaAlta.Enabled = True
        dgCuenta.Enabled = False

        txtNoInt.Text = vbEmpty
        txtNoExt.Text = vbEmpty
        txtNombreCue.Focus()
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        CuentasBindingSource.EndEdit()
        CallesBindingSource.EndEdit()
        CallesTableAdapter.Update(DataSetSistema.calles)
        CuentasTableAdapter.Update(DataSetSistema.cuentas)
        Me.Dispose()
    End Sub

    Private Sub txtNombreCue_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreCue.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaValida, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        CuentasBindingSource.CancelEdit()

        txtNoExt.ReadOnly = True
        txtNoInt.ReadOnly = True
        txtNombreCue.Enabled = False
        cboCalle.Enabled = False
        dtpFechaAlta.Enabled = False
        dgCuenta.Enabled = True

        cmdInicio.Enabled = True
        cmdSiguiente.Enabled = True
        cmdAnterior.Enabled = True
        cmdUltimo.Enabled = True

        cmdNuevo.Enabled = True
        cmdSalir.Enabled = True
        cmdGrabar.Enabled = False
        cmdCancelar.Enabled = False


        txtNoInt.Text = vbEmpty
        txtNoExt.Text = vbEmpty

    End Sub

    Private Sub txtNoExt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoExt.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaNumero, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtNoInt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoInt.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaNumero, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub cmdInicio_Click(sender As Object, e As EventArgs) Handles cmdInicio.Click
        CuentasBindingSource.MoveFirst()
    End Sub

    Private Sub cmdAnterior_Click(sender As Object, e As EventArgs) Handles cmdAnterior.Click
        CuentasBindingSource.MovePrevious()
    End Sub

    Private Sub cmdSiguiente_Click(sender As Object, e As EventArgs) Handles cmdSiguiente.Click
        CuentasBindingSource.MoveNext()
    End Sub

    Private Sub cmdUltimo_Click(sender As Object, e As EventArgs) Handles cmdUltimo.Click
        CuentasBindingSource.MoveLast()
    End Sub
End Class