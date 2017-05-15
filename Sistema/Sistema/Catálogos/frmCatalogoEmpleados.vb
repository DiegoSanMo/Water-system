Public Class frmCatalogoEmpleados
    Private Sub frmCatalogoEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.DataSetSistema.empleados)
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.DataSetSistema.empleados)
        dgEmpleado.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub cmdInicio_Click(sender As Object, e As EventArgs) Handles cmdInicio.Click
        EmpleadosBindingSource.MoveFirst()
    End Sub

    Private Sub cmdSiguiente_Click(sender As Object, e As EventArgs) Handles cmdSiguiente.Click
        EmpleadosBindingSource.MoveNext()
    End Sub

    Private Sub cmdUltimo_Click(sender As Object, e As EventArgs) Handles cmdUltimo.Click
        EmpleadosBindingSource.MoveLast()
    End Sub

    Private Sub cmdAnterior_Click(sender As Object, e As EventArgs) Handles cmdAnterior.Click
        EmpleadosBindingSource.MovePrevious()
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim numEmpleado As Integer

        txtIdEmpleado.Text = ""
        txtNombreEmp.Text = ""
        txtDomicilio.Text = ""
        txtColonia.Text = ""
        mskCp.Text = ""
        txtTelCasa.Text = ""
        txtCelular.Text = ""

        numEmpleado = EmpleadosBindingSource.Count + 1
        EmpleadosBindingSource.AddNew()

        txtIdEmpleado.Text = numEmpleado

        cmdInicio.Enabled = False
        cmdSiguiente.Enabled = False
        cmdAnterior.Enabled = False
        cmdUltimo.Enabled = False

        txtNombreEmp.Enabled = True
        txtDomicilio.Enabled = True
        txtColonia.Enabled = True
        mskCp.Enabled = True
        txtTelCasa.Enabled = True
        txtCelular.Enabled = True

        cmdGrabar.Enabled = True
        cmdCancelar.Enabled = True
        cmdNuevo.Enabled = False
        cmdSalir.Enabled = False

        txtNombreEmp.Focus()
        dgEmpleado.Enabled = False


    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click


        If String.IsNullOrWhiteSpace(txtNombreEmp.Text) Or String.IsNullOrWhiteSpace(txtDomicilio.Text) Or String.IsNullOrWhiteSpace(txtColonia.Text) Or String.IsNullOrWhiteSpace(mskCp.Text) Or String.IsNullOrWhiteSpace(txtTelCasa.Text) Then
            MsgBox("AUN HAY CAMPOS SIN LLENAR")
            txtNombreEmp.Focus()

        Else
            If txtNombreEmp.TextLength < 5 Or txtDomicilio.TextLength < 5 Or txtColonia.TextLength < 5 Then
                MsgBox("SE DEBE INGRESAR AL MENOS 5 CARACTERES")
            Else
                If String.IsNullOrWhiteSpace(txtCelular.Text) Then
                    txtCelular.Text = vbEmpty
                Else

                End If
                'Obtención y almacenamiento de los datos de los textBox a la base de datos
                EmpleadosBindingSource.Current(0) = txtIdEmpleado.Text
                    EmpleadosBindingSource.Current(1) = txtNombreEmp.Text
                    EmpleadosBindingSource.Current(2) = txtDomicilio.Text
                    EmpleadosBindingSource.Current(3) = txtColonia.Text
                    EmpleadosBindingSource.Current(4) = mskCp.Text
                    EmpleadosBindingSource.Current(5) = txtTelCasa.Text
                    EmpleadosBindingSource.Current(6) = txtCelular.Text

                    'bloqueo de botones de desplazamiento dentro de la rejilla
                    cmdInicio.Enabled = True
                    cmdSiguiente.Enabled = True
                    cmdAnterior.Enabled = True
                    cmdUltimo.Enabled = True

                    cmdGrabar.Enabled = False
                    cmdCancelar.Enabled = False
                    cmdNuevo.Enabled = True
                    cmdSalir.Enabled = True

                    'bloqueo de cajas de texto
                    txtNombreEmp.Enabled = False
                    txtDomicilio.Enabled = False
                    txtColonia.Enabled = False
                    mskCp.Enabled = False
                    txtTelCasa.Enabled = False
                    txtCelular.Enabled = False
                    dgEmpleado.Enabled = True

                    'comando para actualizazr(refrescar) los datos de la rejilla
                    dgEmpleado.Refresh()
                End If

            End If





        ''Obtención y almacenamiento de los datos de los textBox a la base de datos
        'EmpleadosBindingSource.Current(0) = txtIdEmpleado.Text
        'EmpleadosBindingSource.Current(1) = txtNombreEmp.Text
        'EmpleadosBindingSource.Current(2) = txtDomicilio.Text
        'EmpleadosBindingSource.Current(3) = txtColonia.Text
        'EmpleadosBindingSource.Current(4) = mskCp.Text
        'EmpleadosBindingSource.Current(5) = mskTelCasa.Text
        'EmpleadosBindingSource.Current(6) = mskCelular.Text

        ''bloqueo de botones de desplazamiento dentro de la rejilla
        'cmdInicio.Enabled = True
        'cmdSiguiente.Enabled = True
        'cmdAnterior.Enabled = True
        'cmdUltimo.Enabled = True
        'cmdNuevo.Enabled = True

        ''bloqueo de cajas de texto
        'txtNombreEmp.Enabled = False
        'txtDomicilio.Enabled = False
        'txtColonia.Enabled = False
        'mskCp.Enabled = False
        'mskTelCasa.Enabled = False
        'mskCelular.Enabled = False

        ''comando para actualizazr(refrescar) los datos de la rejilla
        'dgEmpleado.Refresh()

    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        EmpleadosBindingSource.EndEdit()
        EmpleadosTableAdapter.Update(DataSetSistema.empleados)
        Me.Dispose()
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        EmpleadosBindingSource.CancelEdit()

        txtNombreEmp.Enabled = False
        txtDomicilio.Enabled = False
        txtColonia.Enabled = False
        mskCp.Enabled = False
        txtTelCasa.Enabled = False
        txtCelular.Enabled = False
        dgEmpleado.Enabled = True


        cmdGrabar.Enabled = False
        cmdCancelar.Enabled = False
        cmdNuevo.Enabled = True
        cmdSalir.Enabled = True

    End Sub

    Private Sub txtNombreEmp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreEmp.KeyPress
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

    Private Sub txtColonia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtColonia.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaValida, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtTelCasa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelCasa.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaNumero, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtCelular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCelular.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaNumero, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub
End Class