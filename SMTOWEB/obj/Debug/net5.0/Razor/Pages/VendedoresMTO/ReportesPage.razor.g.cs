#pragma checksum "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\VendedoresMTO\ReportesPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a635cab0ee90b979c1e7c036d0bfb62c70f57120"
// <auto-generated/>
#pragma warning disable 1591
namespace SMTOWEB.Pages.VendedoresMTO
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using SMTOWEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using SMTOWEB.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using SMTO_API.Modelos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using SMTOWEB.Servicios;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using Blazored.SessionStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using SMTOWEB.Pages.global;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using SMTOWEB.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using CurrieTechnologies.Razor.SweetAlert2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using SMTOWEB.Pages.VendedoresMTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using SMTOWEB.Modelo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using SMTOWEB.Modelo_Reporte;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using SMTOWEB.Modelo_Response;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using SMTOWEB.Pages.AdminMTO.Empresas.Sucursales;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/kiosco/reportes")]
    public partial class ReportesPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row mb-3");
            __builder.AddMarkupContent(2, "<div class=\"col\"><h2>\r\n            Reportes\r\n        </h2></div>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col d-flex justify-content-end");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(5);
            __builder.AddAttribute(6, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\VendedoresMTO\ReportesPage.razor"
                               () => getReporteHoy()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "Text", "Hoy");
            __builder.AddAttribute(8, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 12 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\VendedoresMTO\ReportesPage.razor"
                                                                               ButtonStyle.Primary

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(10);
            __builder.AddAttribute(11, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\VendedoresMTO\ReportesPage.razor"
                               () => getReporteAyer()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(12, "Text", "Ayer");
            __builder.AddAttribute(13, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 13 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\VendedoresMTO\ReportesPage.razor"
                                                                                 ButtonStyle.Info

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(15);
            __builder.AddAttribute(16, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\VendedoresMTO\ReportesPage.razor"
                               () => getReporteEsteMes()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(17, "Text", "Este mes");
            __builder.AddAttribute(18, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 14 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\VendedoresMTO\ReportesPage.razor"
                                                                                        ButtonStyle.Success

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(20);
            __builder.AddAttribute(21, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\VendedoresMTO\ReportesPage.razor"
                               () => getReporteMesPasado()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(22, "Text", "Mes pasado");
            __builder.AddAttribute(23, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 15 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\VendedoresMTO\ReportesPage.razor"
                                                                                            ButtonStyle.Warning

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(25);
            __builder.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 20 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\VendedoresMTO\ReportesPage.razor"
     if (responseReporteSucursal != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\VendedoresMTO\ReportesPage.razor"
         if (responseReporteSucursal.reporte.Count != 0)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "row mb-3 border-bottom");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "col");
                __builder2.OpenElement(31, "h2");
                __builder2.AddContent(32, 
#nullable restore
#line 27 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\VendedoresMTO\ReportesPage.razor"
                         tipoReporte

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n                ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "col text-right");
#nullable restore
#line 31 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\VendedoresMTO\ReportesPage.razor"
                       
                        var total = 0;
                        foreach (var item in responseReporteSucursal.reporte)
                        {
                            total += item.TotalVendido;
                        }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(36, "h3");
                __builder2.AddAttribute(37, "class", "text-success");
                __builder2.AddMarkupContent(38, "\r\n                            RD$");
                __builder2.AddContent(39, 
#nullable restore
#line 38 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\VendedoresMTO\ReportesPage.razor"
                                 String.Format("{0:n0}",total)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGrid<Reporte_sucursal_mes>>(41);
                __builder2.AddAttribute(42, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 43 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\VendedoresMTO\ReportesPage.razor"
                                            true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "AllowColumnResize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 43 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\VendedoresMTO\ReportesPage.razor"
                                                                     true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 43 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\VendedoresMTO\ReportesPage.razor"
                                                                                       FilterMode.Advanced

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 43 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\VendedoresMTO\ReportesPage.razor"
                                                                                                                          true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 43 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\VendedoresMTO\ReportesPage.razor"
                                                                                                                                          6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 44 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\VendedoresMTO\ReportesPage.razor"
                                         true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "PagerHorizontalAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.HorizontalAlign>(
#nullable restore
#line 44 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\VendedoresMTO\ReportesPage.razor"
                                                                     HorizontalAlign.Left

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "ShowPagingSummary", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 44 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\VendedoresMTO\ReportesPage.razor"
                                                                                                              true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Reporte_sucursal_mes>>(
#nullable restore
#line 45 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\VendedoresMTO\ReportesPage.razor"
                                   responseReporteSucursal.reporte

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "ColumnWidth", "300px");
                __builder2.AddAttribute(52, "LogicalFilterOperator", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.LogicalFilterOperator>(
#nullable restore
#line 46 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\VendedoresMTO\ReportesPage.razor"
                                                   LogicalFilterOperator.Or

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Reporte_sucursal_mes>>(54);
                    __builder3.AddAttribute(55, "Property", "Numero_Tarjeta");
                    __builder3.AddAttribute(56, "Title", "Numero de tarjeta");
                    __builder3.AddAttribute(57, "Width", "140px");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(58, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Reporte_sucursal_mes>>(59);
                    __builder3.AddAttribute(60, "Property", "Balance");
                    __builder3.AddAttribute(61, "Title", "Balance recargado");
                    __builder3.AddAttribute(62, "Width", "100px");
                    __builder3.AddAttribute(63, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Reporte_sucursal_mes>)((data) => (__builder4) => {
                        __builder4.OpenElement(64, "div");
                        __builder4.AddAttribute(65, "class", "alert" + " alert-" + (
#nullable restore
#line 51 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\VendedoresMTO\ReportesPage.razor"
                                                      data.Balance==0 ? "danger":"success"

#line default
#line hidden
#nullable disable
                        ) + " mb-0");
                        __builder4.AddAttribute(66, "role", "status");
                        __builder4.AddMarkupContent(67, "\r\n                                RD$");
                        __builder4.AddContent(68, 
#nullable restore
#line 52 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\VendedoresMTO\ReportesPage.razor"
                                     String.Format("{0:n0}",data.Balance)

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(69, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Reporte_sucursal_mes>>(70);
                    __builder3.AddAttribute(71, "Property", "Viajes");
                    __builder3.AddAttribute(72, "Title", "Viajes");
                    __builder3.AddAttribute(73, "Width", "100px");
                    __builder3.AddAttribute(74, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Reporte_sucursal_mes>)((data) => (__builder4) => {
                        __builder4.OpenElement(75, "div");
                        __builder4.AddAttribute(76, "class", "alert" + " alert-" + (
#nullable restore
#line 58 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\VendedoresMTO\ReportesPage.razor"
                                                      data.Viajes==0 ? "danger":"success"

#line default
#line hidden
#nullable disable
                        ) + " mb-0");
                        __builder4.AddAttribute(77, "role", "status");
                        __builder4.AddContent(78, 
#nullable restore
#line 59 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\VendedoresMTO\ReportesPage.razor"
                                 data.Viajes

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(79, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Reporte_sucursal_mes>>(80);
                    __builder3.AddAttribute(81, "Property", "TotalVendido");
                    __builder3.AddAttribute(82, "Title", "Total vendido");
                    __builder3.AddAttribute(83, "Width", "100px");
                    __builder3.AddAttribute(84, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Reporte_sucursal_mes>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(85, "\r\n                            RD$");
                        __builder4.AddContent(86, 
#nullable restore
#line 65 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\VendedoresMTO\ReportesPage.razor"
                                 String.Format("{0:n0}",data.TotalVendido)

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(87, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Reporte_sucursal_mes>>(88);
                    __builder3.AddAttribute(89, "Property", "Fecha_Creacion");
                    __builder3.AddAttribute(90, "Title", "Fecha");
                    __builder3.AddAttribute(91, "Width", "140px");
                    __builder3.AddAttribute(92, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Reporte_sucursal_mes>)((data) => (__builder4) => {
                        __builder4.AddContent(93, 
#nullable restore
#line 70 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\VendedoresMTO\ReportesPage.razor"
                              Convert.ToDateTime(data.Fecha_Creacion).ToString("dd/MM/yyyy hh:mm:ss tt")

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 75 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\VendedoresMTO\ReportesPage.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(94, "<div class=\"alert alert-info\">\r\n                No se encontraron datos...\r\n            </div>");
#nullable restore
#line 81 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\VendedoresMTO\ReportesPage.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\VendedoresMTO\ReportesPage.razor"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(95, "<div class=\"d-flex justify-content-center\"><div class=\"spinner-border\" role=\"status\"><span class=\"visually-hidden\">Loading...</span></div></div>");
#nullable restore
#line 90 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\VendedoresMTO\ReportesPage.razor"
    }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591