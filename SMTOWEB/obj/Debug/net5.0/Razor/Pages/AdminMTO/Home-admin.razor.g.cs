#pragma checksum "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Home-admin.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ff9d1422c1e360d835c97eb527906d52ee4f019"
// <auto-generated/>
#pragma warning disable 1591
namespace SMTOWEB.Pages.AdminMTO
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/administrador")]
    public partial class Home_admin : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    h1 {\r\n        display: inline !important;\r\n    }\r\n</style>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container-xl");
#nullable restore
#line 15 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Home-admin.razor"
     if (vendidoEmpresas != null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row mb-3 mt-4");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col mb-3");
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(7);
            __builder.AddAttribute(8, "style", "border-left: 3px solid #006797");
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(10, "h1");
                __builder2.AddContent(11, 
#nullable restore
#line 20 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Home-admin.razor"
                     vendidoEmpresas.CantidadSucursales

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(12, " ");
                __builder2.AddMarkupContent(13, "<span class=\"text-danger\" style=\"font-size:20px;\"><i class=\"fas fa-arrow-alt-circle-down\"></i></span>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n                ");
                __builder2.AddMarkupContent(15, "<label>Empresas actuales</label>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "col mb-3");
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(19);
            __builder.AddAttribute(20, "style", "border-left: 3px solid #006797");
            __builder.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(22, "h1");
                __builder2.AddAttribute(23, "class", "d-inline mr-2");
                __builder2.AddContent(24, 
#nullable restore
#line 26 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Home-admin.razor"
                                           vendidoEmpresas.Viajes

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(25, " ");
                __builder2.AddMarkupContent(26, "<span class=\"text-success\" style=\"font-size:20px;\"><i class=\"fas fa-arrow-alt-circle-up\"></i></span>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n                ");
                __builder2.AddMarkupContent(28, "<label>Boletos vendidos</label>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "col mb-3");
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(32);
            __builder.AddAttribute(33, "style", "border-left: 3px solid #006797");
            __builder.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(35, "h1");
                __builder2.AddAttribute(36, "class", "d-inline mr-2");
                __builder2.AddContent(37, "RD$");
                __builder2.AddContent(38, 
#nullable restore
#line 32 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Home-admin.razor"
                                               String.Format("{0:n0}", Convert.ToInt32(vendidoEmpresas.Balance))

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(39, " ");
                __builder2.AddMarkupContent(40, "<span class=\"text-success\" style=\"font-size:20px;\"><i class=\"fas fa-arrow-alt-circle-up\"></i></span>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n                ");
                __builder2.AddMarkupContent(42, "<label>Balace vendido</label>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "col mb-3");
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(46);
            __builder.AddAttribute(47, "style", "border-left: 3px solid #006797");
            __builder.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(49, "h1");
                __builder2.AddAttribute(50, "class", "d-inline mr-2");
                __builder2.AddContent(51, "RD$");
                __builder2.AddContent(52, 
#nullable restore
#line 38 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Home-admin.razor"
                                               String.Format("{0:n0}", Convert.ToInt32(vendidoEmpresas.Total))

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(53, " ");
                __builder2.AddMarkupContent(54, "<span class=\"text-success\" style=\"font-size:20px;\"><i class=\"fas fa-arrow-alt-circle-up\"></i></span>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n                ");
                __builder2.AddMarkupContent(56, "<label>Recaudado hoy</label>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 43 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Home-admin.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(57);
            __builder.AddAttribute(58, "class", "ml-0 mr-0 mt-3 mb-3");
            __builder.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<SMTOWEB.Pages.AdminMTO.Empresas.EmpresasPage>(60);
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Home-admin.razor"
       
    private UserTemp user;
    Empresa empresa;
    VendidoEmpresas vendidoEmpresas;
    protected override async Task OnInitializedAsync()
    {
        try
        {
            user = await sessionStorage.GetItemAsync<UserTemp>("usuario");
            if (user != null)
            {
                var fecha = DateTime.Now;
                vendidoEmpresas = await http.GetFromJsonAsync<VendidoEmpresas>
                    ($"https://localhost:44391/api/Empresas/TotalVendido/{fecha.Month}");
            }
        }
        catch (Exception)
        {

        }
    }

    public class VendidoEmpresas
    {
        public string Viajes { get; set; }
        public string Balance { get; set; }
        public string Total { get; set; }
        public int CantidadSucursales { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime Js { get; set; }
    }
}
#pragma warning restore 1591
