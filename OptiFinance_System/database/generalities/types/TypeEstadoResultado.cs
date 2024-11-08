namespace OptiFinance_System.database.generalities.types;

public class TypeEstadoResultado
{
    #region Ventas netas

        public const string VentasBrutas = "Ventas";
        public const int VentasBrutasCode = 5101;

        public const string RebajasDevolucionesSobreVentas = "Rebajas y Devoluciones sobre Ventas";
        public const int RebajasDevolucionesSobreVentasCode = 4105;

    #endregion

    #region Costo de Ventas

        public const string CostoVentas = "Costo de Ventas";
        public const int CostoVentasCode = 4107;

    #endregion

    #region Gastos de Operación

        #region Gastos de Venta

            public const string Aguinaldos = "Aguinaldos";
            public const int AguinaldosCode = 410203;

            public const string Gratificaciones = "Gratificaciones";
            public const int GratificacionesCode = 410204;

            public const string SeguroSocial = "Seguro Social";
            public const int SeguroSocialCode = 410205;

            public const string Viaticos = "Viáticos";
            public const int ViaticosCode = 410206;

            public const string MaterialEmpaque = "Material de Empaque";
            public const int MaterialEmpaqueCode = 410207;

            public const string FletesAcarreos = "Fletes y Acarreos";
            public const int FletesAcarreosCode = 410210;

            public const string Comunicaciones = "Comunicaciones";
            public const int ComunicacionesCode = 410212;

            public const string AtencionesPersonal = "Atenciones al Personal";
            public const int AtencionesPersonalCode = 410213;

            public const string MantenimientoEquipoTransporte = "Mantenimiento Equipo de Transporte";
            public const int MantenimientoEquipoTransporteCode = 410216;

            public const string Depreciaciones = "Depreciaciones";
            public const int DepreciacionesCode = 410218;

            public const string CombustibleLubricantes = "Combustible y Lubricantes";
            public const int CombustibleLubricantesCode = 410219;

            public const string CuentasIncobrables = "Cuentas Incobrables";
            public const int CuentasIncobrablesCode = 410220;

            public const string Indemnizaciones = "Indemnizaciones";
            public const int IndemnizacionesCode = 410221;

            public const string AFP = "A.F.P";
            public const int AFPCode = 410222;

        #endregion

        #region Gastos de Administración

            public const string Sueldos = "Sueldos";
            public const int SueldosCode = 410301;

            public const string Vacaciones = "Vacaciones";
            public const int VacacionesCode = 410302;

            public const string HonorariosProfesionales = "Honorarios Profesionales";
            public const int HonorariosProfesionalesCode = 410306;

            public const string PublicidadGeneral = "Publicidad General";
            public const int PublicidadGeneralCode = 410307;

            public const string MatriculaComercio = "Matrícula de Comercio";
            public const int MatriculaComercioCode = 410308;

            public const string EspeciesPostales = "Especies Postales";
            public const int EspeciesPostalesCode = 410309;

            public const string EnergiaElectrica = "Energía Eléctrica";
            public const int EnergiaElectricaCode = 410310;

            public const string MantenimientoVehiculos = "Mantenimiento Vehículos";
            public const int MantenimientoVehiculosCode = 410315;

            public const string InscripcionesRegistroComercio = "Inscripciones en el Registro de Comercio";
            public const int InscripcionesRegistroComercioCode = 410319;

            public const string PapeleriaUtilesOficina = "Papelería y Útiles de Oficina";
            public const int PapeleriaUtilesOficinaCode = 410320;

            public const string NoDeducibles = "No deducibles";
            public const int NoDeduciblesCode = 410322;

        #endregion

        #region Gastos Financieros

            public const string InteresesBancarios = "Intereses Bancarios";
            public const int InteresesBancariosCode = 410401;

            public const string ComisionesBancarias = "Comisiones Bancarias";
            public const int ComisionesBancariasCode = 410402;

            public const string DiferenciasCambio = "Diferencias en Cambio";
            public const int DiferenciasCambioCode = 410403;

            public const string InteresesDiversos = "Intereses Diversos";
            public const int InteresesDiversosCode = 410404;

        #endregion

        #region Ingresos Adicionales

            public const string IngresosFinancieros = "Ingresos Financieros";
            public const int IngresosFinancierosCode = 5103;

            public const string OtrosIngresos = "Otros Ingresos";
            public const int OtrosIngresosCode = 5104;

            public const string IngresosPorServicios = "Ingresos Por Servicios";
            public const int IngresosPorServiciosCode = 5105;

            public const string IngresoPorServiciosOperativos = "Ingreso por servicios Operativos";
            public const int IngresoPorServiciosOperativosCode = 510501;

        #endregion
    #endregion

}