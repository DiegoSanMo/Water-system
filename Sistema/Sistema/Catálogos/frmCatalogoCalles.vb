Imports System.ComponentModel

Public Class frmCatalogoCalles
    Private Sub frmCatalogoCalles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.calles' Puede moverla o quitarla según sea necesario.
        Me.CallesTableAdapter.Fill(Me.DataSetSistema.calles)

        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.calles' Puede moverla o quitarla según sea necesario.
        Me.CallesTableAdapter.Fill(Me.DataSetSistema.calles)
        dgCalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub cmdInicio_Click(sender As Object, e As EventArgs) Handles cmdInicio.Click
        CallesBindingSource.MoveFirst()
    End Sub

    Private Sub cmdSiguiente_Click(sender As Object, e As EventArgs) Handles cmdSiguiente.Click
        CallesBindingSource.MoveNext()
    End Sub

    Private Sub cmdAnterior_Click(sender As Object, e As EventArgs) Handles cmdAnterior.Click
        CallesBindingSource.MovePrevious()

    End Sub

    Private Sub cmdUltimo_Click(sender As Object, e As EventArgs) Handles cmdUltimo.Click
        CallesBindingSource.MoveLast()
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim numCalle As Integer

        cmdInicio.Enabled = False
        cmdSiguiente.Enabled = False
        cmdAnterior.Enabled = False
        cmdUltimo.Enabled = False

        cmdNuevo.Enabled = False
        cmdGrabar.Enabled = True
        cmdCancelar.Enabled = True
        cmdSalir.Enabled = False


        numCalle = CallesBindingSource.Count + 1

        CallesBindingSource.AddNew()
        txtIdCalle.Text = numCalle
        txtNombre.Enabled = True
        txtColonia.Enabled = True
        mskCodPostal.Enabled = True


        txtNombre.Focus()
        dgCalles.Enabled = False
        'dgCalles.CurrentRow.Frozen = True


    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click

        If String.IsNullOrWhiteSpace(txtColonia.Text) Or String.IsNullOrWhiteSpace(txtNombre.Text) Or String.IsNullOrWhiteSpace(mskCodPostal.Text) Then
            MsgBox("AÚN HAY DATOS SIN LLENAR")
            txtNombre.Focus()
        Else
            If txtColonia.TextLength < 5 Or txtNombre.TextLength < 5 Then
                MsgBox("Se deben almacenar al menos 5 caracteres")
            Else
                CallesBindingSource.Current(4) = 0
                txtNombre.Enabled = False
                txtColonia.Enabled = False
                mskCodPostal.Enabled = False

                cmdNuevo.Enabled = True
                cmdGrabar.Enabled = False
                cmdCancelar.Enabled = False
                cmdSalir.Enabled = True

                cmdInicio.Enabled = True
                cmdSiguiente.Enabled = True
                cmdAnterior.Enabled = True
                cmdUltimo.Enabled = True
                dgCalles.Refresh()
                dgCalles.Enabled = True
            End If

        End If

    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        CallesBindingSource.EndEdit()
        CallesTableAdapter.Update(DataSetSistema.calles)
        Me.Dispose()
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
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

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        cmdNuevo.Enabled = True
        CallesBindingSource.CancelEdit()

        cmdNuevo.Enabled = True
        cmdGrabar.Enabled = False
        cmdCancelar.Enabled = False
        cmdSalir.Enabled = True

        cmdInicio.Enabled = True
        cmdSiguiente.Enabled = True
        cmdAnterior.Enabled = True
        cmdUltimo.Enabled = True

        txtNombre.Enabled = False
        txtColonia.Enabled = False
        mskCodPostal.Enabled = False

        dgCalles.Enabled = True


    End Sub

End Class