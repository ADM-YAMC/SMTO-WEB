#pragma checksum "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Shared\UserLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b6f2e6a1bdebfbdf555195e5f9fd572c4001f0c"
// <auto-generated/>
#pragma warning disable 1591
namespace SMTOWEB.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using SMTOWEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using SMTOWEB.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using SMTO_API.Modelos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using SMTOWEB.Servicios;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using Blazored.SessionStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using SMTOWEB.Pages.global;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using SMTOWEB.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using CurrieTechnologies.Razor.SweetAlert2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using SMTOWEB.Pages.VendedoresMTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using SMTOWEB.Modelo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using SMTOWEB.Modelo_Reporte;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using SMTOWEB.Modelo_Response;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using SMTOWEB.Pages.AdminMTO.Empresas.Sucursales;

#line default
#line hidden
#nullable disable
    public partial class UserLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<SMTOWEB.Shared.Navbar>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container-xl mt-5 pl-0 pr-0");
#nullable restore
#line 6 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Shared\UserLayout.razor"
__builder.AddContent(4, Body);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
