Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class frmPrincipal
    Dim conexionsql As New SqlConnection("Data source= PRO; Initial catalog = sistemaAguaPotable; Integrated security= true")

    Private Sub btnCatalogoGastos_Click(sender As Object, e As EventArgs)
        frmCatalogoGastos.ShowDialog()
    End Sub

    Private Sub btnCatalogoCalles_Click(sender As Object, e As EventArgs)
        frmCatalogoCalles.ShowDialog()
    End Sub

    Private Sub GastosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GastosToolStripMenuItem.Click
        frmCatalogoGastos.ShowDialog()

    End Sub

    Private Sub CallesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CallesToolStripMenuItem.Click
        frmCatalogoCalles.ShowDialog()

    End Sub

    Private Sub MaterialesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaterialesToolStripMenuItem.Click
        frmCatalogoMateriales.ShowDialog()
    End Sub

    Private Sub PozosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PozosToolStripMenuItem.Click
        frmCatalogoPozos.ShowDialog()
    End Sub

    Private Sub ServiciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServiciosToolStripMenuItem.Click
        frmCatalogoServicios.ShowDialog()

    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        frmCatalogoEmpleados.ShowDialog()
    End Sub

    Private Sub CuentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuentasToolStripMenuItem.Click
        frmCatalogoCuentas.ShowDialog()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        frmCatalogoProveedores.ShowDialog()
    End Sub

    Private Sub TarifasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TarifasToolStripMenuItem.Click
        frmCatalogoTarifas.ShowDialog()

    End Sub

    Private Sub SituaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SituaciónToolStripMenuItem.Click
        frmCatalogoSituacion.ShowDialog()
    End Sub

    Private Sub ActividadPozosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActividadPozosToolStripMenuItem.Click
        frmMovimientosActividadPozos.ShowDialog()
    End Sub

    Private Sub GastosRealizadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GastosRealizadosToolStripMenuItem.Click
        frmMovimientosGastosRealizados.ShowDialog()
    End Sub

    Private Sub ComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem.Click
        frmMovimientosCompraMateriales.ShowDialog()
    End Sub

    Private Sub ConsultasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultasToolStripMenuItem.Click
        frmMovimientosCompraMaterialesConsultas.ShowDialog()
    End Sub

    Private Sub ConsultaPorOrdenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaPorOrdenToolStripMenuItem.Click
        frmMovimientoCompraMaterialesConsultaID.ShowDialog()
    End Sub

    Private Sub SalidasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalidasToolStripMenuItem.Click
        frmMovimientoSalidaMateriales.ShowDialog()
    End Sub

    Private Sub ConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem.Click
        frmMovimientoConsultaSalidaMateriales.ShowDialog()
    End Sub

    Private Sub PagosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagosToolStripMenuItem.Click
        frmMovimientoPago.ShowDialog()
    End Sub

    Private Sub ConsultaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem1.Click
        frmMovimientoConsultaPago.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ReportesPorCuentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesPorCuentaToolStripMenuItem.Click
        Dim cmd As New SqlCommand("ReporteCuentas", conexionsql)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet
        adaptador.Fill(data)
        data.DataSetName = "DataSet1"
        Dim reportes As New ReportDataSource("DataSet1", data.Tables(0))
        frmReportes.ReportViewer2.LocalReport.DataSources.Clear()
        frmReportes.ReportViewer2.LocalReport.DataSources.Add(reportes)
        frmReportes.ReportViewer2.LocalReport.ReportPath = "C:\Users\Diego\Documents\Visual Studio 2015\Projects\Sistema\Sistema\Reportes\ReporteCuentas.rdlc"
        frmReportes.ReportViewer2.RefreshReport()
        frmReportes.ShowDialog()
        conexionsql.Close()



    End Sub



    Private Sub ReportePorCalleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportePorCalleToolStripMenuItem.Click
        Dim cmd As New SqlCommand("ReporteCuentasCalles", conexionsql)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet
        adaptador.Fill(data)
        data.DataSetName = "DataSet1"
        Dim reportes As New ReportDataSource("DataSet1", data.Tables(0))
        frmReportes.ReportViewer2.LocalReport.DataSources.Clear()
        frmReportes.ReportViewer2.LocalReport.DataSources.Add(reportes)
        frmReportes.ReportViewer2.LocalReport.ReportPath = "C:\Users\Diego\Documents\Visual Studio 2015\Projects\Sistema\Sistema\Reportes\ReporteCuentasCalles.rdlc"
        frmReportes.ReportViewer2.RefreshReport()
        frmReportes.ShowDialog()
        conexionsql.Close()
    End Sub

    Private Sub ReportePorCallesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportePorCallesToolStripMenuItem.Click
        Dim cmd As New SqlCommand("ReporteCalles", conexionsql)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet
        adaptador.Fill(data)
        data.DataSetName = "DataSet1"
        Dim reportes As New ReportDataSource("DataSet1", data.Tables(0))
        frmReportes.ReportViewer2.LocalReport.DataSources.Clear()
        frmReportes.ReportViewer2.LocalReport.DataSources.Add(reportes)
        frmReportes.ReportViewer2.LocalReport.ReportPath = "C:\Users\Diego\Documents\Visual Studio 2015\Projects\Sistema\Sistema\Reportes\ReporteCalles.rdlc"
        frmReportes.ReportViewer2.RefreshReport()
        frmReportes.ShowDialog()
        conexionsql.Close()
    End Sub

    Private Sub ReportesDeMaterialesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesDeMaterialesToolStripMenuItem.Click
        Dim cmd As New SqlCommand("ReporteMateriales", conexionsql)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet
        adaptador.Fill(data)
        data.DataSetName = "DataSet1"
        Dim reportes As New ReportDataSource("DataSet1", data.Tables(0))
        frmReportes.ReportViewer2.LocalReport.DataSources.Clear()
        frmReportes.ReportViewer2.LocalReport.DataSources.Add(reportes)
        frmReportes.ReportViewer2.LocalReport.ReportPath = "C:\Users\Diego\Documents\Visual Studio 2015\Projects\Sistema\Sistema\Reportes\ReporteMateriales.rdlc"
        frmReportes.ReportViewer2.RefreshReport()
        frmReportes.ShowDialog()
        conexionsql.Close()
    End Sub

    Private Sub ReporteDeEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeEmpleadosToolStripMenuItem.Click
        Dim cmd As New SqlCommand("ReporteEmpleados", conexionsql)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet
        adaptador.Fill(data)
        data.DataSetName = "DataSet1"
        Dim reportes As New ReportDataSource("DataSet1", data.Tables(0))
        frmReportes.ReportViewer2.LocalReport.DataSources.Clear()
        frmReportes.ReportViewer2.LocalReport.DataSources.Add(reportes)
        frmReportes.ReportViewer2.LocalReport.ReportPath = "C:\Users\Diego\Documents\Visual Studio 2015\Projects\Sistema\Sistema\Reportes\ReporteEmpleados.rdlc"
        frmReportes.ReportViewer2.RefreshReport()
        frmReportes.ShowDialog()
        conexionsql.Close()
    End Sub

    Private Sub ReporteDeGastosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeGastosToolStripMenuItem.Click
        Dim cmd As New SqlCommand("ReporteGasto", conexionsql)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet
        adaptador.Fill(data)
        data.DataSetName = "DataSet1"
        Dim reportes As New ReportDataSource("DataSet1", data.Tables(0))
        frmReportes.ReportViewer2.LocalReport.DataSources.Clear()
        frmReportes.ReportViewer2.LocalReport.DataSources.Add(reportes)
        frmReportes.ReportViewer2.LocalReport.ReportPath = "C:\Users\Diego\Documents\Visual Studio 2015\Projects\Sistema\Sistema\Reportes\ReporteGasto.rdlc"
        frmReportes.ReportViewer2.RefreshReport()
        frmReportes.ShowDialog()
        conexionsql.Close()
    End Sub

    Private Sub ReporteDeTarifasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeTarifasToolStripMenuItem.Click
        Dim cmd As New SqlCommand("ReporteTarifas", conexionsql)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet
        adaptador.Fill(data)
        data.DataSetName = "DataSet1"
        Dim reportes As New ReportDataSource("DataSet1", data.Tables(0))
        frmReportes.ReportViewer2.LocalReport.DataSources.Clear()
        frmReportes.ReportViewer2.LocalReport.DataSources.Add(reportes)
        frmReportes.ReportViewer2.LocalReport.ReportPath = "C:\Users\Diego\Documents\Visual Studio 2015\Projects\Sistema\Sistema\Reportes\ReporteTarifas.rdlc"
        frmReportes.ReportViewer2.RefreshReport()
        frmReportes.ShowDialog()
        conexionsql.Close()
    End Sub

    Private Sub ReporteDePozosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDePozosToolStripMenuItem.Click
        Dim cmd As New SqlCommand("ReportePozos", conexionsql)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet
        adaptador.Fill(data)
        data.DataSetName = "DataSet1"
        Dim reportes As New ReportDataSource("DataSet1", data.Tables(0))
        frmReportes.ReportViewer2.LocalReport.DataSources.Clear()
        frmReportes.ReportViewer2.LocalReport.DataSources.Add(reportes)
        frmReportes.ReportViewer2.LocalReport.ReportPath = "C:\Users\Diego\Documents\Visual Studio 2015\Projects\Sistema\Sistema\Reportes\ReportePozos.rdlc"
        frmReportes.ReportViewer2.RefreshReport()
        frmReportes.ShowDialog()
        conexionsql.Close()
    End Sub

    Private Sub ReporteDeGastosPorFechaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeGastosPorFechaToolStripMenuItem.Click
        frmReporteParametros.lblGastosPorPeriodo.Visible = True
        frmReporteParametros.lblFechaInicial.Visible = True
        frmReporteParametros.lblFechaFinal.Visible = True
        frmReporteParametros.dtpFechaInicial.Visible = True
        frmReporteParametros.dtpFechaFinal.Visible = True

        'Historial de pagos por cliente 
        frmReporteParametros.btnBuscarCliente.Visible = False
        frmReporteParametros.txtNombreCliente.Visible = False
        frmReporteParametros.lblNom.Visible = False
        frmReporteParametros.lblHistorial.Visible = False

        frmReporteParametros.lblServiciosPeriodo.Visible = False




        frmReporteParametros.ShowDialog()
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub HistorialDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistorialDeToolStripMenuItem.Click

        'Historial por cliente
        frmReporteParametros.btnBuscarCliente.Visible = True
        frmReporteParametros.txtNombreCliente.Visible = True
        frmReporteParametros.lblNom.Visible = True
        frmReporteParametros.lblHistorial.Visible = True

        'Gastos por un periodo 
        frmReporteParametros.lblGastosPorPeriodo.Visible = False
        frmReporteParametros.lblFechaInicial.Visible = False
        frmReporteParametros.lblFechaFinal.Visible = False
        frmReporteParametros.dtpFechaInicial.Visible = False
        frmReporteParametros.dtpFechaFinal.Visible = False
        'Salida de materiales
        frmReporteParametros.lblSalidaMaterial.Visible = False

        'Pagos realizados en un periodo
        frmReporteParametros.lblPagosPer.Visible = False

        'Actividad pozos
        frmReporteParametros.lblactividadPozos.Visible = False

        frmReporteParametros.lblServiciosPeriodo.Visible = False


        frmReporteParametros.ShowDialog()
    End Sub

    Private Sub RelaciónDeEntradasDeMaterialPorPeriodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelaciónDeEntradasDeMaterialPorPeriodoToolStripMenuItem.Click
        'Historial por cliente
        frmReporteParametros.btnBuscarCliente.Visible = False
        frmReporteParametros.txtNombreCliente.Visible = False
        frmReporteParametros.lblNom.Visible = False
        frmReporteParametros.lblHistorial.Visible = False

        'Gastos por un periodo 
        frmReporteParametros.lblGastosPorPeriodo.Visible = False
        frmReporteParametros.lblFechaInicial.Visible = False
        frmReporteParametros.lblFechaFinal.Visible = False
        frmReporteParametros.dtpFechaInicial.Visible = False
        frmReporteParametros.dtpFechaFinal.Visible = False

        'Entradas de material por un periodo
        frmReporteParametros.lblEntradasPeriodo.Visible = True
        frmReporteParametros.lblFechaInicial.Visible = True
        frmReporteParametros.lblFechaFinal.Visible = True
        frmReporteParametros.dtpFechaInicial.Visible = True
        frmReporteParametros.dtpFechaFinal.Visible = True

        'Salida de materiales
        frmReporteParametros.lblSalidaMaterial.Visible = False

        'Pagos realizados en un periodo
        frmReporteParametros.lblPagosPer.Visible = False

        'Actividad pozos
        frmReporteParametros.lblactividadPozos.Visible = False

        frmReporteParametros.lblServiciosPeriodo.Visible = False

        frmReporteParametros.ShowDialog()
    End Sub

    Private Sub RelaciónDeSalidasDeMaterialEnUnPeriodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelaciónDeSalidasDeMaterialEnUnPeriodoToolStripMenuItem.Click

        'Historial por cliente
        frmReporteParametros.btnBuscarCliente.Visible = False
        frmReporteParametros.txtNombreCliente.Visible = False
        frmReporteParametros.lblNom.Visible = False
        frmReporteParametros.lblHistorial.Visible = False

        'Gastos por un periodo 
        frmReporteParametros.lblGastosPorPeriodo.Visible = False
        frmReporteParametros.lblFechaInicial.Visible = False
        frmReporteParametros.lblFechaFinal.Visible = False
        frmReporteParametros.dtpFechaInicial.Visible = False
        frmReporteParametros.dtpFechaFinal.Visible = False

        'Entradas de material por un periodo
        frmReporteParametros.lblEntradasPeriodo.Visible = False

        'Salida de material por un periodo
        frmReporteParametros.lblFechaInicial.Visible = True
        frmReporteParametros.lblFechaFinal.Visible = True
        frmReporteParametros.dtpFechaInicial.Visible = True
        frmReporteParametros.dtpFechaFinal.Visible = True
        frmReporteParametros.lblSalidaMaterial.Visible = True

        'Pagos realizados en un periodo
        frmReporteParametros.lblPagosPer.Visible = False

        'Actividad pozos
        frmReporteParametros.lblactividadPozos.Visible = False

        frmReporteParametros.lblServiciosPeriodo.Visible = False

        frmReporteParametros.ShowDialog()



    End Sub

    Private Sub RelaciónDePagosRealizadosEnUnPeriodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelaciónDePagosRealizadosEnUnPeriodoToolStripMenuItem.Click
        'Historial por cliente
        frmReporteParametros.btnBuscarCliente.Visible = False
        frmReporteParametros.txtNombreCliente.Visible = False
        frmReporteParametros.lblNom.Visible = False
        frmReporteParametros.lblHistorial.Visible = False

        'Gastos por un periodo 
        frmReporteParametros.lblGastosPorPeriodo.Visible = False
        frmReporteParametros.lblFechaInicial.Visible = False
        frmReporteParametros.lblFechaFinal.Visible = False
        frmReporteParametros.dtpFechaInicial.Visible = False
        frmReporteParametros.dtpFechaFinal.Visible = False

        'Entradas de material por un periodo
        frmReporteParametros.lblEntradasPeriodo.Visible = False

        'Salida de material por un periodo
        frmReporteParametros.lblSalidaMaterial.Visible = False

        'Pagos realizados en un periodo
        frmReporteParametros.lblFechaInicial.Visible = True
        frmReporteParametros.lblFechaFinal.Visible = True
        frmReporteParametros.dtpFechaInicial.Visible = True
        frmReporteParametros.dtpFechaFinal.Visible = True
        frmReporteParametros.lblPagosPer.Visible = True

        frmReporteParametros.lblServiciosPeriodo.Visible = False
        'Actividad pozos
        frmReporteParametros.lblactividadPozos.Visible = False

        frmReporteParametros.ShowDialog()
    End Sub

    Private Sub RelaciónDeActividaDePozosEnUnPeriodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelaciónDeActividaDePozosEnUnPeriodoToolStripMenuItem.Click
        'Historial por cliente
        frmReporteParametros.btnBuscarCliente.Visible = False
        frmReporteParametros.txtNombreCliente.Visible = False
        frmReporteParametros.lblNom.Visible = False
        frmReporteParametros.lblHistorial.Visible = False

        'Gastos por un periodo 
        frmReporteParametros.lblGastosPorPeriodo.Visible = False
        frmReporteParametros.lblFechaInicial.Visible = False
        frmReporteParametros.lblFechaFinal.Visible = False
        frmReporteParametros.dtpFechaInicial.Visible = False
        frmReporteParametros.dtpFechaFinal.Visible = False

        'Entradas de material por un periodo
        frmReporteParametros.lblEntradasPeriodo.Visible = False

        'Salida de material por un periodo
        frmReporteParametros.lblSalidaMaterial.Visible = False

        'Pagos realizados en un periodo
        frmReporteParametros.lblFechaInicial.Visible = True
        frmReporteParametros.lblFechaFinal.Visible = True
        frmReporteParametros.dtpFechaInicial.Visible = True
        frmReporteParametros.dtpFechaFinal.Visible = True
        frmReporteParametros.lblPagosPer.Visible = False

        'Actividad pozos
        frmReporteParametros.lblactividadPozos.Visible = True

        frmReporteParametros.lblServiciosPeriodo.Visible = False

        frmReporteParametros.ShowDialog()
    End Sub

    Private Sub ReporteDeProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeProveedoresToolStripMenuItem.Click
        Dim cmd As New SqlCommand("ReporteProveedores", conexionsql)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet
        adaptador.Fill(data)
        data.DataSetName = "DataSet1"
        Dim reportes As New ReportDataSource("DataSet1", data.Tables(0))
        frmReportes.ReportViewer2.LocalReport.DataSources.Clear()
        frmReportes.ReportViewer2.LocalReport.DataSources.Add(reportes)
        frmReportes.ReportViewer2.LocalReport.ReportPath = "C:\Users\Diego\Documents\Visual Studio 2015\Projects\Sistema\Sistema\Reportes\ReporteProveedores.rdlc"
        frmReportes.ReportViewer2.RefreshReport()
        frmReportes.ShowDialog()
        conexionsql.Close()
    End Sub

    Private Sub ReporteDeServiciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeServiciosToolStripMenuItem.Click
        Dim cmd As New SqlCommand("ReporteServicios", conexionsql)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet
        adaptador.Fill(data)
        data.DataSetName = "DataSet1"
        Dim reportes As New ReportDataSource("DataSet1", data.Tables(0))
        frmReportes.ReportViewer2.LocalReport.DataSources.Clear()
        frmReportes.ReportViewer2.LocalReport.DataSources.Add(reportes)
        frmReportes.ReportViewer2.LocalReport.ReportPath = "C:\Users\Diego\Documents\Visual Studio 2015\Projects\Sistema\Sistema\Reportes\Servicios.rdlc"
        frmReportes.ReportViewer2.RefreshReport()
        frmReportes.ShowDialog()
        conexionsql.Close()
    End Sub

    Private Sub ClientesMorososToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesMorososToolStripMenuItem.Click
        Dim cmd As New SqlCommand("ClientesMorosos", conexionsql)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet
        adaptador.Fill(data)
        data.DataSetName = "DataSet1"
        Dim reportes As New ReportDataSource("DataSet1", data.Tables(0))
        frmReportes.ReportViewer2.LocalReport.DataSources.Clear()
        frmReportes.ReportViewer2.LocalReport.DataSources.Add(reportes)
        frmReportes.ReportViewer2.LocalReport.ReportPath = "C:\Users\Diego\Documents\Visual Studio 2015\Projects\Sistema\Sistema\Reportes\ClientesMorosos.rdlc"
        frmReportes.ReportViewer2.RefreshReport()
        frmReportes.ShowDialog()
        conexionsql.Close()
    End Sub

    Private Sub ServiciosAtendidosPorPeriodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServiciosAtendidosPorPeriodoToolStripMenuItem.Click
        'Historial por cliente
        frmReporteParametros.btnBuscarCliente.Visible = False
        frmReporteParametros.txtNombreCliente.Visible = False
        frmReporteParametros.lblNom.Visible = False
        frmReporteParametros.lblHistorial.Visible = False

        'Gastos por un periodo 
        frmReporteParametros.lblGastosPorPeriodo.Visible = False
        frmReporteParametros.lblFechaInicial.Visible = False
        frmReporteParametros.lblFechaFinal.Visible = False
        frmReporteParametros.dtpFechaInicial.Visible = False
        frmReporteParametros.dtpFechaFinal.Visible = False

        'Entradas de material por un periodo
        frmReporteParametros.lblEntradasPeriodo.Visible = False

        'Salida de material por un periodo
        frmReporteParametros.lblSalidaMaterial.Visible = False

        'Pagos realizados en un periodo
        frmReporteParametros.lblFechaInicial.Visible = True
        frmReporteParametros.lblFechaFinal.Visible = True
        frmReporteParametros.dtpFechaInicial.Visible = True
        frmReporteParametros.dtpFechaFinal.Visible = True
        frmReporteParametros.lblPagosPer.Visible = False

        'Actividad pozos
        frmReporteParametros.lblactividadPozos.Visible = False

        frmReporteParametros.lblServiciosPeriodo.Visible = True

        frmReporteParametros.ShowDialog()
    End Sub
End Class