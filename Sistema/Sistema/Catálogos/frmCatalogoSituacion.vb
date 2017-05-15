Public Class frmCatalogoSituacion
    Private Sub frmCatalogoSituacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.situacion' Puede moverla o quitarla según sea necesario.
        Me.SituacionTableAdapter.Fill(Me.DataSetSistema.situacion)
        dgSituacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim numSituacion As Integer

        cmdAnterior.Enabled = False
        cmdInicio.Enabled = False
        cmdSiguiente.Enabled = False
        cmdSiguiente.Enabled = False
        cmdUltimo.Enabled = False

        cmdNuevo.Enabled = False
        cmdSalir.Enabled = False
        cmdCancelar.Enabled = True
        cmdGrabar.Enabled = True

        numSituacion = SituacionBindingSource.Count + 1
        SituacionBindingSource.AddNew()
        txtIdSituacion.Text = numSituacion

        txtDescripcion.Enabled = True
        txtDescuento.Enabled = True

        dgSituacion.Enabled = False

        txtDescripcion.Focus()
        txtDescripcion.Text = ""
        txtDescuento.Text = ""


    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click

        If String.IsNullOrWhiteSpace(txtDescripcion.Text) Or String.IsNullOrWhiteSpace(txtDescuento.Text) Then
            MsgBox("HAY CAMPOS EN BLANCO")
            txtDescripcion.Focus()
        Else
            If txtDescripcion.TextLength < 5 Then
                MsgBox("DESCRIPCIÓN MUY CORTA")
            Else
                SituacionBindingSource.Current(0) = txtIdSituacion.Text
                SituacionBindingSource.Current(1) = txtDescripcion.Text
                SituacionBindingSource.Current(2) = txtDescuento.Text


                cmdAnterior.Enabled = True
                cmdSiguiente.Enabled = True
                cmdInicio.Enabled = True
                cmdUltimo.Enabled = True

                cmdNuevo.Enabled = True
                cmdSalir.Enabled = True
                cmdCancelar.Enabled = False
                cmdGrabar.Enabled = False

                txtDescripcion.Enabled = False
                txtDescuento.Enabled = False

                dgSituacion.Enabled = True
                dgSituacion.Refresh()

                txtDescripcion.Text = ""
                txtDescuento.Text = ""
                txtIdSituacion.Text = ""
            End If

        End If



    End Sub

    Private Sub cmdInicio_Click(sender As Object, e As EventArgs) Handles cmdInicio.Click
        SituacionBindingSource.MoveFirst()
    End Sub

    Private Sub cmdSiguiente_Click(sender As Object, e As EventArgs) Handles cmdSiguiente.Click
        SituacionBindingSource.MoveNext()
    End Sub

    Private Sub cmdUltimo_Click(sender As Object, e As EventArgs) Handles cmdUltimo.Click
        SituacionBindingSource.MoveLast()
    End Sub

    Private Sub cmdAnterior_Click(sender As Object, e As EventArgs) Handles cmdAnterior.Click
        SituacionBindingSource.MovePrevious()
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        SituacionBindingSource.EndEdit()
        SituacionTableAdapter.Update(DataSetSistema.situacion)
        Me.Dispose()
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        cmdAnterior.Enabled = True
        cmdSiguiente.Enabled = True
        cmdInicio.Enabled = True
        cmdUltimo.Enabled = True

        cmdNuevo.Enabled = True
        cmdSalir.Enabled = True
        cmdCancelar.Enabled = False
        cmdGrabar.Enabled = False


        txtDescripcion.Enabled = False
        txtDescuento.Enabled = False

        dgSituacion.Enabled = True

        txtDescripcion.Text = ""
        txtDescuento.Text = ""
        txtIdSituacion.Text = ""

        SituacionBindingSource.CancelEdit()

    End Sub

    Private Sub txtDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcion.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaValida, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtDescuento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescuento.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaNumero, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub
End Class