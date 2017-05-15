<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CatálogosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatálogosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CallesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GastosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SituaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TarifasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PozosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActividadPozosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GastosRealizadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaPorOrdenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalidasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportePorCallesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesMorososToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportePorCalleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistorialDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesDeMaterialesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeGastosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeTarifasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeServiciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDePozosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelaciónDeEntradasDeMaterialPorPeriodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelaciónDeSalidasDeMaterialEnUnPeriodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeGastosPorFechaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelaciónDePagosRealizadosEnUnPeriodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelaciónDeActividaDePozosEnUnPeriodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesPorCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiciosAtendidosPorPeriodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImage = Global.Sistema.My.Resources.Resources.barra
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatálogosToolStripMenuItem, Me.CatálogosToolStripMenuItem1, Me.MovimientosToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(578, 28)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CatálogosToolStripMenuItem
        '
        Me.CatálogosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.CatálogosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.CatálogosToolStripMenuItem.Name = "CatálogosToolStripMenuItem"
        Me.CatálogosToolStripMenuItem.Size = New System.Drawing.Size(74, 24)
        Me.CatálogosToolStripMenuItem.Text = "Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(108, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'CatálogosToolStripMenuItem1
        '
        Me.CatálogosToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CallesToolStripMenuItem, Me.CuentasToolStripMenuItem, Me.EmpleadosToolStripMenuItem, Me.GastosToolStripMenuItem, Me.MaterialesToolStripMenuItem, Me.SituaciónToolStripMenuItem, Me.ServiciosToolStripMenuItem, Me.TarifasToolStripMenuItem, Me.PozosToolStripMenuItem, Me.ProveedoresToolStripMenuItem})
        Me.CatálogosToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.CatálogosToolStripMenuItem1.Name = "CatálogosToolStripMenuItem1"
        Me.CatálogosToolStripMenuItem1.Size = New System.Drawing.Size(88, 24)
        Me.CatálogosToolStripMenuItem1.Text = "Catálogos"
        '
        'CallesToolStripMenuItem
        '
        Me.CallesToolStripMenuItem.Name = "CallesToolStripMenuItem"
        Me.CallesToolStripMenuItem.Size = New System.Drawing.Size(164, 24)
        Me.CallesToolStripMenuItem.Text = "Calles"
        '
        'CuentasToolStripMenuItem
        '
        Me.CuentasToolStripMenuItem.Name = "CuentasToolStripMenuItem"
        Me.CuentasToolStripMenuItem.Size = New System.Drawing.Size(164, 24)
        Me.CuentasToolStripMenuItem.Text = "Cuentas"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(164, 24)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'GastosToolStripMenuItem
        '
        Me.GastosToolStripMenuItem.Name = "GastosToolStripMenuItem"
        Me.GastosToolStripMenuItem.Size = New System.Drawing.Size(164, 24)
        Me.GastosToolStripMenuItem.Text = "Gastos"
        '
        'MaterialesToolStripMenuItem
        '
        Me.MaterialesToolStripMenuItem.Name = "MaterialesToolStripMenuItem"
        Me.MaterialesToolStripMenuItem.Size = New System.Drawing.Size(164, 24)
        Me.MaterialesToolStripMenuItem.Text = "Materiales"
        '
        'SituaciónToolStripMenuItem
        '
        Me.SituaciónToolStripMenuItem.Name = "SituaciónToolStripMenuItem"
        Me.SituaciónToolStripMenuItem.Size = New System.Drawing.Size(164, 24)
        Me.SituaciónToolStripMenuItem.Text = "Situación"
        '
        'ServiciosToolStripMenuItem
        '
        Me.ServiciosToolStripMenuItem.Name = "ServiciosToolStripMenuItem"
        Me.ServiciosToolStripMenuItem.Size = New System.Drawing.Size(164, 24)
        Me.ServiciosToolStripMenuItem.Text = "Servicios"
        '
        'TarifasToolStripMenuItem
        '
        Me.TarifasToolStripMenuItem.Name = "TarifasToolStripMenuItem"
        Me.TarifasToolStripMenuItem.Size = New System.Drawing.Size(164, 24)
        Me.TarifasToolStripMenuItem.Text = "Tarifas"
        '
        'PozosToolStripMenuItem
        '
        Me.PozosToolStripMenuItem.Name = "PozosToolStripMenuItem"
        Me.PozosToolStripMenuItem.Size = New System.Drawing.Size(164, 24)
        Me.PozosToolStripMenuItem.Text = "Pozos"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(164, 24)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'MovimientosToolStripMenuItem
        '
        Me.MovimientosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActividadPozosToolStripMenuItem, Me.GastosRealizadosToolStripMenuItem, Me.MaterialesToolStripMenuItem1, Me.PagosToolStripMenuItem})
        Me.MovimientosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.MovimientosToolStripMenuItem.Name = "MovimientosToolStripMenuItem"
        Me.MovimientosToolStripMenuItem.Size = New System.Drawing.Size(110, 24)
        Me.MovimientosToolStripMenuItem.Text = "Movimientos"
        '
        'ActividadPozosToolStripMenuItem
        '
        Me.ActividadPozosToolStripMenuItem.Name = "ActividadPozosToolStripMenuItem"
        Me.ActividadPozosToolStripMenuItem.Size = New System.Drawing.Size(195, 24)
        Me.ActividadPozosToolStripMenuItem.Text = "Actividad pozos"
        '
        'GastosRealizadosToolStripMenuItem
        '
        Me.GastosRealizadosToolStripMenuItem.Name = "GastosRealizadosToolStripMenuItem"
        Me.GastosRealizadosToolStripMenuItem.Size = New System.Drawing.Size(195, 24)
        Me.GastosRealizadosToolStripMenuItem.Text = "Gastos realizados"
        '
        'MaterialesToolStripMenuItem1
        '
        Me.MaterialesToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComprasToolStripMenuItem, Me.SalidasToolStripMenuItem})
        Me.MaterialesToolStripMenuItem1.Name = "MaterialesToolStripMenuItem1"
        Me.MaterialesToolStripMenuItem1.Size = New System.Drawing.Size(195, 24)
        Me.MaterialesToolStripMenuItem1.Text = "Materiales"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultasToolStripMenuItem, Me.ConsultaPorOrdenToolStripMenuItem})
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(138, 24)
        Me.ComprasToolStripMenuItem.Text = "Compras"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(210, 24)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'ConsultaPorOrdenToolStripMenuItem
        '
        Me.ConsultaPorOrdenToolStripMenuItem.Name = "ConsultaPorOrdenToolStripMenuItem"
        Me.ConsultaPorOrdenToolStripMenuItem.Size = New System.Drawing.Size(210, 24)
        Me.ConsultaPorOrdenToolStripMenuItem.Text = "Consulta por orden"
        '
        'SalidasToolStripMenuItem
        '
        Me.SalidasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultaToolStripMenuItem})
        Me.SalidasToolStripMenuItem.Name = "SalidasToolStripMenuItem"
        Me.SalidasToolStripMenuItem.Size = New System.Drawing.Size(138, 24)
        Me.SalidasToolStripMenuItem.Text = "Salidas"
        '
        'ConsultaToolStripMenuItem
        '
        Me.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem"
        Me.ConsultaToolStripMenuItem.Size = New System.Drawing.Size(137, 24)
        Me.ConsultaToolStripMenuItem.Text = "Consulta"
        '
        'PagosToolStripMenuItem
        '
        Me.PagosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultaToolStripMenuItem1})
        Me.PagosToolStripMenuItem.Name = "PagosToolStripMenuItem"
        Me.PagosToolStripMenuItem.Size = New System.Drawing.Size(195, 24)
        Me.PagosToolStripMenuItem.Text = "Pagos"
        '
        'ConsultaToolStripMenuItem1
        '
        Me.ConsultaToolStripMenuItem1.Name = "ConsultaToolStripMenuItem1"
        Me.ConsultaToolStripMenuItem1.Size = New System.Drawing.Size(137, 24)
        Me.ConsultaToolStripMenuItem1.Text = "Consulta"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportePorCallesToolStripMenuItem, Me.ClientesMorososToolStripMenuItem, Me.ReportePorCalleToolStripMenuItem, Me.HistorialDeToolStripMenuItem, Me.ReportesDeMaterialesToolStripMenuItem, Me.ReporteDeEmpleadosToolStripMenuItem, Me.ReporteDeGastosToolStripMenuItem, Me.ReporteDeTarifasToolStripMenuItem, Me.ReporteDeServiciosToolStripMenuItem, Me.ReporteDePozosToolStripMenuItem, Me.RelaciónDeEntradasDeMaterialPorPeriodoToolStripMenuItem, Me.RelaciónDeSalidasDeMaterialEnUnPeriodoToolStripMenuItem, Me.ReporteDeGastosPorFechaToolStripMenuItem, Me.RelaciónDePagosRealizadosEnUnPeriodoToolStripMenuItem, Me.RelaciónDeActividaDePozosEnUnPeriodoToolStripMenuItem, Me.ReportesPorCuentaToolStripMenuItem, Me.ReporteDeProveedoresToolStripMenuItem, Me.ServiciosAtendidosPorPeriodoToolStripMenuItem})
        Me.ReportesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(81, 24)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'ReportePorCallesToolStripMenuItem
        '
        Me.ReportePorCallesToolStripMenuItem.Name = "ReportePorCallesToolStripMenuItem"
        Me.ReportePorCallesToolStripMenuItem.Size = New System.Drawing.Size(402, 24)
        Me.ReportePorCallesToolStripMenuItem.Text = "Reporte por calles"
        '
        'ClientesMorososToolStripMenuItem
        '
        Me.ClientesMorososToolStripMenuItem.Name = "ClientesMorososToolStripMenuItem"
        Me.ClientesMorososToolStripMenuItem.Size = New System.Drawing.Size(402, 24)
        Me.ClientesMorososToolStripMenuItem.Text = "Clientes morosos"
        '
        'ReportePorCalleToolStripMenuItem
        '
        Me.ReportePorCalleToolStripMenuItem.Name = "ReportePorCalleToolStripMenuItem"
        Me.ReportePorCalleToolStripMenuItem.Size = New System.Drawing.Size(402, 24)
        Me.ReportePorCalleToolStripMenuItem.Text = "Reporte de cuentas por calle"
        '
        'HistorialDeToolStripMenuItem
        '
        Me.HistorialDeToolStripMenuItem.Name = "HistorialDeToolStripMenuItem"
        Me.HistorialDeToolStripMenuItem.Size = New System.Drawing.Size(402, 24)
        Me.HistorialDeToolStripMenuItem.Text = "Historial de pagos por cliente"
        '
        'ReportesDeMaterialesToolStripMenuItem
        '
        Me.ReportesDeMaterialesToolStripMenuItem.Name = "ReportesDeMaterialesToolStripMenuItem"
        Me.ReportesDeMaterialesToolStripMenuItem.Size = New System.Drawing.Size(402, 24)
        Me.ReportesDeMaterialesToolStripMenuItem.Text = "Reporte de materiales en existencia"
        '
        'ReporteDeEmpleadosToolStripMenuItem
        '
        Me.ReporteDeEmpleadosToolStripMenuItem.Name = "ReporteDeEmpleadosToolStripMenuItem"
        Me.ReporteDeEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(402, 24)
        Me.ReporteDeEmpleadosToolStripMenuItem.Text = "Reporte de empleados"
        '
        'ReporteDeGastosToolStripMenuItem
        '
        Me.ReporteDeGastosToolStripMenuItem.Name = "ReporteDeGastosToolStripMenuItem"
        Me.ReporteDeGastosToolStripMenuItem.Size = New System.Drawing.Size(402, 24)
        Me.ReporteDeGastosToolStripMenuItem.Text = "Reporte de gastos"
        '
        'ReporteDeTarifasToolStripMenuItem
        '
        Me.ReporteDeTarifasToolStripMenuItem.Name = "ReporteDeTarifasToolStripMenuItem"
        Me.ReporteDeTarifasToolStripMenuItem.Size = New System.Drawing.Size(402, 24)
        Me.ReporteDeTarifasToolStripMenuItem.Text = "Reporte de tarifas"
        '
        'ReporteDeServiciosToolStripMenuItem
        '
        Me.ReporteDeServiciosToolStripMenuItem.Name = "ReporteDeServiciosToolStripMenuItem"
        Me.ReporteDeServiciosToolStripMenuItem.Size = New System.Drawing.Size(402, 24)
        Me.ReporteDeServiciosToolStripMenuItem.Text = "Reporte de servicios"
        '
        'ReporteDePozosToolStripMenuItem
        '
        Me.ReporteDePozosToolStripMenuItem.Name = "ReporteDePozosToolStripMenuItem"
        Me.ReporteDePozosToolStripMenuItem.Size = New System.Drawing.Size(402, 24)
        Me.ReporteDePozosToolStripMenuItem.Text = "Reporte de pozos"
        '
        'RelaciónDeEntradasDeMaterialPorPeriodoToolStripMenuItem
        '
        Me.RelaciónDeEntradasDeMaterialPorPeriodoToolStripMenuItem.Name = "RelaciónDeEntradasDeMaterialPorPeriodoToolStripMenuItem"
        Me.RelaciónDeEntradasDeMaterialPorPeriodoToolStripMenuItem.Size = New System.Drawing.Size(402, 24)
        Me.RelaciónDeEntradasDeMaterialPorPeriodoToolStripMenuItem.Text = "Relación de entradas de material en un periodo"
        '
        'RelaciónDeSalidasDeMaterialEnUnPeriodoToolStripMenuItem
        '
        Me.RelaciónDeSalidasDeMaterialEnUnPeriodoToolStripMenuItem.Name = "RelaciónDeSalidasDeMaterialEnUnPeriodoToolStripMenuItem"
        Me.RelaciónDeSalidasDeMaterialEnUnPeriodoToolStripMenuItem.Size = New System.Drawing.Size(402, 24)
        Me.RelaciónDeSalidasDeMaterialEnUnPeriodoToolStripMenuItem.Text = "Relación de salidas de material en un periodo"
        '
        'ReporteDeGastosPorFechaToolStripMenuItem
        '
        Me.ReporteDeGastosPorFechaToolStripMenuItem.Name = "ReporteDeGastosPorFechaToolStripMenuItem"
        Me.ReporteDeGastosPorFechaToolStripMenuItem.Size = New System.Drawing.Size(402, 24)
        Me.ReporteDeGastosPorFechaToolStripMenuItem.Text = "Relación de gastos en un periodo"
        '
        'RelaciónDePagosRealizadosEnUnPeriodoToolStripMenuItem
        '
        Me.RelaciónDePagosRealizadosEnUnPeriodoToolStripMenuItem.Name = "RelaciónDePagosRealizadosEnUnPeriodoToolStripMenuItem"
        Me.RelaciónDePagosRealizadosEnUnPeriodoToolStripMenuItem.Size = New System.Drawing.Size(402, 24)
        Me.RelaciónDePagosRealizadosEnUnPeriodoToolStripMenuItem.Text = "Relación de pagos realizados en un periodo"
        '
        'RelaciónDeActividaDePozosEnUnPeriodoToolStripMenuItem
        '
        Me.RelaciónDeActividaDePozosEnUnPeriodoToolStripMenuItem.Name = "RelaciónDeActividaDePozosEnUnPeriodoToolStripMenuItem"
        Me.RelaciónDeActividaDePozosEnUnPeriodoToolStripMenuItem.Size = New System.Drawing.Size(402, 24)
        Me.RelaciónDeActividaDePozosEnUnPeriodoToolStripMenuItem.Text = "Relación de activida de pozos en un periodo"
        '
        'ReportesPorCuentaToolStripMenuItem
        '
        Me.ReportesPorCuentaToolStripMenuItem.Name = "ReportesPorCuentaToolStripMenuItem"
        Me.ReportesPorCuentaToolStripMenuItem.Size = New System.Drawing.Size(402, 24)
        Me.ReportesPorCuentaToolStripMenuItem.Text = "Reportes por cuenta"
        '
        'ReporteDeProveedoresToolStripMenuItem
        '
        Me.ReporteDeProveedoresToolStripMenuItem.Name = "ReporteDeProveedoresToolStripMenuItem"
        Me.ReporteDeProveedoresToolStripMenuItem.Size = New System.Drawing.Size(402, 24)
        Me.ReporteDeProveedoresToolStripMenuItem.Text = "Reporte de proveedores"
        '
        'ServiciosAtendidosPorPeriodoToolStripMenuItem
        '
        Me.ServiciosAtendidosPorPeriodoToolStripMenuItem.Name = "ServiciosAtendidosPorPeriodoToolStripMenuItem"
        Me.ServiciosAtendidosPorPeriodoToolStripMenuItem.Size = New System.Drawing.Size(402, 24)
        Me.ServiciosAtendidosPorPeriodoToolStripMenuItem.Text = "Servicios atendidos por periodo"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Sistema.My.Resources.Resources.fondo1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(578, 367)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPrincipal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CatálogosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CatálogosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GastosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CallesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaterialesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PozosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiciosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CuentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TarifasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SituaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MovimientosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActividadPozosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GastosRealizadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaterialesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalidasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaPorOrdenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PagosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesPorCuentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportePorCalleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportePorCallesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesDeMaterialesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeGastosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeTarifasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDePozosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeGastosPorFechaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistorialDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelaciónDeEntradasDeMaterialPorPeriodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelaciónDeSalidasDeMaterialEnUnPeriodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelaciónDePagosRealizadosEnUnPeriodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelaciónDeActividaDePozosEnUnPeriodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeServiciosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesMorososToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiciosAtendidosPorPeriodoToolStripMenuItem As ToolStripMenuItem
End Class
