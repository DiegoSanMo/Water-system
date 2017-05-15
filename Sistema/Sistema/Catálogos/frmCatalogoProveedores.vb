Public Class frmCatalogoProveedores
    Private Sub frmCatalogoProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.cuentas' Puede moverla o quitarla según sea necesario.
        Me.CuentasTableAdapter.Fill(Me.DataSetSistema.cuentas)
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.DataSetSistema.proveedores)
        dgProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim numProve As Integer

        cmdInicio.Enabled = False
        cmdSiguiente.Enabled = False
        cmdAnterior.Enabled = False
        cmdUltimo.Enabled = False

        numProve = ProveedoresBindingSource.Count + 1

        ProveedoresBindingSource.AddNew()
        txtIdProveedor.Text = numProve
        txtNombreProv.Enabled = True
        txtDomicilio.Enabled = True
        txtColonia.Enabled = True
        txtEstado.Enabled = True
        txtCp.Enabled = True
        txtTelefono.Enabled = True
        txtCorreo.Enabled = True


        cmdNuevo.Enabled = False
        cmdSalir.Enabled = False
        cmdCancelar.Enabled = True
        cmdGrabar.Enabled = True

        dgProveedores.Enabled = False

    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click

        If String.IsNullOrWhiteSpace(txtNombreProv.Text) Or String.IsNullOrWhiteSpace(txtDomicilio.Text) Or String.IsNullOrWhiteSpace(txtColonia.Text) Or String.IsNullOrWhiteSpace(txtEstado.Text) Or String.IsNullOrWhiteSpace(txtCp.Text) Or String.IsNullOrWhiteSpace(txtTelefono.Text) Then
            txtNombreProv.Focus()
            MsgBox("AÚN HAY DATOS EN BLANCO")
        Else
            If txtNombreProv.TextLength < 5 Then
                txtNombreProv.Focus()
                MsgBox("Se deben almacenar al menos 5 caracteres")
            Else
                txtNombreProv.Enabled = False
                txtDomicilio.Enabled = False
                txtColonia.Enabled = False
                txtEstado.Enabled = False
                txtCp.Enabled = False
                txtTelefono.Enabled = False
                txtCorreo.Enabled = False

                cmdNuevo.Enabled = True
                cmdSalir.Enabled = True
                cmdCancelar.Enabled = False
                cmdGrabar.Enabled = False

                cmdInicio.Enabled = True
                cmdSiguiente.Enabled = True
                cmdAnterior.Enabled = True
                cmdUltimo.Enabled = True
                dgProveedores.Refresh()
                dgProveedores.Enabled = True
            End If
        End If





    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        ProveedoresBindingSource.EndEdit()
        ProveedoresTableAdapter.Update(DataSetSistema.proveedores)
        Me.Dispose()
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        cmdInicio.Enabled = True
        cmdSiguiente.Enabled = True
        cmdAnterior.Enabled = True
        cmdUltimo.Enabled = True

        cmdNuevo.Enabled = True
        cmdSalir.Enabled = True
        cmdCancelar.Enabled = False
        cmdGrabar.Enabled = False

        txtNombreProv.Enabled = False
        txtDomicilio.Enabled = False
        txtColonia.Enabled = False
        txtEstado.Enabled = False
        txtCp.Enabled = False
        txtTelefono.Enabled = False
        txtCorreo.Enabled = False

        dgProveedores.Enabled = True
        ProveedoresBindingSource.CancelEdit()

    End Sub

    Private Sub txtNombreProv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreProv.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaValida, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtEstado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEstado.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaValida, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtDomicilio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDomicilio.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaValida, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtCp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCp.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaNumero, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaNumero, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtColonia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtColonia.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaValida, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub
End Class