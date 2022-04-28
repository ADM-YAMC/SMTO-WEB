using SMTOWEB.Modelo;
using SMTOWEB.Modelo_Reporte;
using SMTOWEB.Modelo_Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SMTOWEB.Pages.VendedoresMTO
{
    public partial class ReportesPage
    {

        UserTemp user;
        ResponseReporteSucursalMes responseReporteSucursal;
        string tipoReporte;



        protected override async Task OnInitializedAsync()
        {

            try
            {
                user = await sessionStorage.GetItemAsync<UserTemp>("usuario");
                if (user != null)
                {
                    await getReporteHoy();
                }
            }
            catch (Exception)
            {
            }

        }


        async Task getReporteHoy()
        {
            tipoReporte = "Reporte de ventas del dia de hoy";
            responseReporteSucursal = null;
            string SP = "SP_Reporte_venta_sucursal_dia";
            var mes = DateTime.Now;
            responseReporteSucursal = await http.GetFromJsonAsync<ResponseReporteSucursalMes>
                ($"https://smto-apiv2.azurewebsites.net/api/Sucursal/info/Reporte_venta_sucursal_mes/{user.idSucursal}/{mes.Day}/{SP}");
        }
        async Task getReporteAyer()
        {
            DateTime diaAnterior = DateTime.Today.AddDays(-1).DayOfWeek == DayOfWeek.Sunday ? DateTime.Today.AddDays(-2) : DateTime.Today.AddDays(-1);
            tipoReporte = "Reporte de ventas del dia de ayer";
            responseReporteSucursal = null;
            string SP = "SP_Reporte_venta_sucursal_dia";
            var mes = DateTime.Now;
            responseReporteSucursal = await http.GetFromJsonAsync<ResponseReporteSucursalMes>
                ($"https://smto-apiv2.azurewebsites.net/api/Sucursal/info/Reporte_venta_sucursal_mes/{user.idSucursal}/{diaAnterior.Day}/{SP}");
        }
        async Task getReporteEsteMes()
        {
            tipoReporte = "Reporte de ventas de este mes";
            responseReporteSucursal = null;
            string SP = "SP_Reporte_venta_sucursal_mes";
            var mes = DateTime.Now;
            responseReporteSucursal = await http.GetFromJsonAsync<ResponseReporteSucursalMes>
                ($"https://smto-apiv2.azurewebsites.net/api/Sucursal/info/Reporte_venta_sucursal_mes/{user.idSucursal}/{mes.Month}/{SP}");
        }
        async Task getReporteMesPasado()
        {
            tipoReporte = "Reporte de ventas del mes pasado";
            responseReporteSucursal = null;
            string SP = "SP_Reporte_venta_sucursal_mes";
            var mes = DateTime.Now.AddMonths(-1);
            responseReporteSucursal = await http.GetFromJsonAsync<ResponseReporteSucursalMes>
                ($"https://smto-apiv2.azurewebsites.net/api/Sucursal/info/Reporte_venta_sucursal_mes/{user.idSucursal}/{mes.Month}/{SP}");
        }
    }
}
