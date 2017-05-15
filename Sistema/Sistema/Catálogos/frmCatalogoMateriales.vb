Public Class frmCatalogoMateriales
    Private Sub frmCatalogoMateriales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.material' Puede moverla o quitarla según sea necesario.
        Me.MaterialTableAdapter.Fill(Me.DataSetSistema.material)

    End Sub

    Private Sub cmdInicio_Click(sender As Object, e As EventArgs) Handles cmdInicio.Click
        MaterialBindingSource.MoveFirst()
    End Sub

    Private Sub cmdAnterior_Click(sender As Object, e As EventArgs) Handles cmdAnterior.Click
        MaterialBindingSource.MovePrevious()

    End Sub

    Private Sub cmdSiguiente_Click(sender As Object, e As EventArgs) Handles cmdSiguiente.Click
        MaterialBindingSource.MoveNext()

    End Sub

    Private Sub cmdUltimo_Click(sender As Object, e As EventArgs) Handles cmdUltimo.Click
        MaterialBindingSource.MoveLast()
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim numMaterial As Integer

        cmdInicio.Enabled = False
        cmdSiguiente.Enabled = False
        cmdAnterior.Enabled = False
        cmdUltimo.Enabled = False

        numMaterial = MaterialBindingSource.Count + 1
        MaterialBindingSource.AddNew()
        txtIdMaterial.Text = numMaterial
        txtDescripcion.Enabled = True
        mskExistencias.Enabled = True
        mskMaximo.Enabled = True
        mskMinimo.Enabled = True
        cmbUnidadMedida.Enabled = True
        mskCosto.Enabled = True
        dtpFechaUlti.Enabled = True

        cmdNuevo.Enabled = False
        cmdSalir.Enabled = False
        cmdCancelar.Enabled = True
        cmdGrabar.Enabled = True

    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        dgMateriales.Refresh()

        txtDescripcion.Enabled = False
        mskExistencias.Enabled = False
        mskMaximo.Enabled = False
        mskMinimo.Enabled = False
        MaterialBindingSource.Current(5) = cmbUnidadMedida.SelectedItem
        cmbUnidadMedida.Enabled = False
        mskCosto.Enabled = False
        dtpFechaUlti.Enabled = False

        cmdInicio.Enabled = True
        cmdSiguiente.Enabled = True
        cmdAnterior.Enabled = True
        cmdUltimo.Enabled = True
        cmbUnidadMedida.Enabled = False

        cmdNuevo.Enabled = True
        cmdSalir.Enabled = True
        cmdCancelar.Enabled = False
        cmdGrabar.Enabled = False


    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        MaterialBindingSource.EndEdit()
        MaterialTableAdapter.Update(DataSetSistema.material)
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

        txtDescripcion.Enabled = False
        mskExistencias.Enabled = False
        mskMaximo.Enabled = False
        mskMinimo.Enabled = False
        cmbUnidadMedida.Enabled = False
        mskCosto.Enabled = False
        dtpFechaUlti.Enabled = False

        MaterialBindingSource.CancelEdit()

    End Sub
End Class