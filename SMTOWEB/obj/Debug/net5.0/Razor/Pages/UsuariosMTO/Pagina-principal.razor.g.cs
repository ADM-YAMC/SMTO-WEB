#pragma checksum "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\UsuariosMTO\Pagina-principal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0c9d57b2af57ecea65bc2680551e3c1cf1bf223"
// <auto-generated/>
#pragma warning disable 1591
namespace SMTOWEB.Pages.UsuariosMTO
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/pagina-principal")]
    public partial class Pagina_principal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    .nav-link.active {
        border-bottom: 2px solid red !important;
    }

    .nav-link {
        border-top: 0px !important;
        border-left: 0px !important;
        border-right: 0px !important;
    }

    textarea:focus,
    select:focus,
    input[type=""text""]:focus,
    input[type=""password""]:focus,
    input[type=""datetime""]:focus,
    input[type=""datetime-local""]:focus,
    input[type=""date""]:focus,
    input[type=""month""]:focus,
    input[type=""time""]:focus,
    input[type=""week""]:focus,
    input[type=""number""]:focus,
    input[type=""email""]:focus,
    input[type=""url""]:focus,
    input[type=""search""]:focus,
    input[type=""tel""]:focus,
    input[type=""color""]:focus,
    .uneditable-input:focus {
        border-color: rgba(126, 239, 104, 0.8) !important;
        box-shadow: 0 1px 1px rgba(0, 0, 0, 0.075) inset, 0 0 8px rgba(126, 239, 104, 0.6) !important;
        outline: 0 none;
    }
</style>");
#nullable restore
#line 41 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\UsuariosMTO\Pagina-principal.razor"
 if (user != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\UsuariosMTO\Pagina-principal.razor"
     if (carsd.tarjeta.Count != 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\UsuariosMTO\Pagina-principal.razor"
         if (tarjetas != null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, @"<nav><div class=""nav nav-tabs"" id=""nav-tab"" role=""tablist""><button class=""nav-link active"" id=""nav-home-tab"" data-bs-toggle=""tab"" data-bs-target=""#nav-home"" type=""button"" role=""tab"" aria-controls=""nav-home"" aria-selected=""true"">Mis tarjetas</button>
                    <button class=""nav-link"" id=""nav-profile-tab"" data-bs-toggle=""tab"" data-bs-target=""#nav-profile"" type=""button"" role=""tab"" aria-controls=""nav-profile"" aria-selected=""false"">Tarjetas de terceros</button></div></nav>
            ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "tab-content");
            __builder.AddAttribute(4, "id", "nav-tabContent");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "tab-pane fade show active");
            __builder.AddAttribute(7, "id", "nav-home");
            __builder.AddAttribute(8, "role", "tabpanel");
            __builder.AddAttribute(9, "aria-labelledby", "nav-home-tab");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "row");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col-4");
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(14);
            __builder.AddAttribute(15, "class", "mt-3 ml-1");
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "text-center");
                __builder2.AddMarkupContent(19, "<div class=\"m-auto\"><img src=\"https://cdn-icons-png.flaticon.com/512/2580/2580363.png\" height=\"50\" width=\"50\" alt=\"Alternate Text\"></div>\r\n                                    ");
                __builder2.OpenElement(20, "p");
#nullable restore
#line 62 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\UsuariosMTO\Pagina-principal.razor"
__builder2.AddContent(21, tarjetas.numeroTarjeta);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n                                    ");
                __builder2.AddMarkupContent(23, "<label class=\"text-success\">Activo</label>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n\r\n                                ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "border-top mt-3 border-bottom mb-3");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "form-group mt-2");
                __builder2.AddMarkupContent(29, "<label class=\" mb-2\">Mis tarjetas</label>\r\n                                        ");
                __builder2.OpenElement(30, "select");
                __builder2.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 69 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\UsuariosMTO\Pagina-principal.razor"
                                                           OnChangeCard

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "class", "form-control");
#nullable restore
#line 70 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\UsuariosMTO\Pagina-principal.razor"
                                             if (carsd != null)
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\UsuariosMTO\Pagina-principal.razor"
                                                 if (carsd.tarjeta.Count != 0)
                                                {
                                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\UsuariosMTO\Pagina-principal.razor"
                                                     foreach (var item in carsd.tarjeta)
                                                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(33, "option");
                __builder2.AddAttribute(34, "value", 
#nullable restore
#line 76 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\UsuariosMTO\Pagina-principal.razor"
                                                                        item.idTarjeta

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 76 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\UsuariosMTO\Pagina-principal.razor"
__builder2.AddContent(35, item.numeroTarjeta);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 77 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\UsuariosMTO\Pagina-principal.razor"
                                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\UsuariosMTO\Pagina-principal.razor"
                                                     
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\UsuariosMTO\Pagina-principal.razor"
                                                 
                                            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n\r\n                                ");
                __builder2.AddMarkupContent(37, "<div class=\"form-group mb-2\"><p>Ultimo uso</p>\r\n                                    <label>12-Feb-2022</label></div>\r\n                                ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "form-group border-top");
                __builder2.OpenElement(40, "button");
                __builder2.AddAttribute(41, "type", "button");
                __builder2.AddAttribute(42, "class", "btn btn-primary w-100 mt-2");
                __builder2.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 89 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\UsuariosMTO\Pagina-principal.razor"
                                                                                                         ()=> _Tajeta = new Asociar_Tajeta()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "data-bs-toggle", "modal");
                __builder2.AddAttribute(45, "data-bs-target", "#staticBackdrop");
                __builder2.AddMarkupContent(46, "\r\n                                        Asociar tarjeta\r\n                                    ");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n\r\n                        ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "col");
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(50);
            __builder.AddAttribute(51, "class", "mt-3 mr-1 p-0");
            __builder.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(53, @"<nav><div class=""nav nav-tabs"" id=""nav-tab"" role=""tablist""><button class=""nav-link active"" id=""nav-viajes-tab"" data-bs-toggle=""tab"" data-bs-target=""#viajes"" type=""button"" role=""tab"" aria-controls=""nav-viajes"" aria-selected=""true"">Viajes</button>
                                        <button class=""nav-link"" id=""nav-historial-tab"" data-bs-toggle=""tab"" data-bs-target=""#nav-historial"" type=""button"" role=""tab"" aria-controls=""nav-Historial"" aria-selected=""false"">Historial</button>
                                        <button class=""nav-link"" id=""nav-usos-tab"" data-bs-toggle=""tab"" data-bs-target=""#nav-usos"" type=""button"" role=""tab"" aria-controls=""nav-usos"" aria-selected=""false"">Usos</button></div></nav>
                                ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "tab-content p-4");
                __builder2.AddAttribute(56, "id", "nav-tabContent");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "tab-pane fade show active mt-3");
                __builder2.AddAttribute(59, "id", "viajes");
                __builder2.AddAttribute(60, "role", "tabpanel");
                __builder2.AddAttribute(61, "aria-labelledby", "nav-viajes-tab");
                __builder2.AddMarkupContent(62, @"<div class=""row mb-3""><div class=""col""><p>Contratado</p></div>
                                            <div class=""col""><a href=""pagina-principal/recargas"" class=""btn btn-primary float-right"">Comprar recarga</a></div></div>
                                        ");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "row");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "col");
                __builder2.OpenElement(67, "p");
                __builder2.AddAttribute(68, "style", "font-size:35px;");
#nullable restore
#line 119 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\UsuariosMTO\Pagina-principal.razor"
__builder2.AddContent(69, tarjetas.viajes);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n                                                ");
                __builder2.AddMarkupContent(71, "<label style=\"margin-top:0px; padding-top:0px; font-size:17px;\">Viajes</label>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n                                            ");
                __builder2.OpenElement(73, "div");
                __builder2.AddAttribute(74, "class", "col");
                __builder2.OpenElement(75, "p");
                __builder2.AddAttribute(76, "style", "font-size:35px;");
                __builder2.AddContent(77, "RD$");
#nullable restore
#line 123 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\UsuariosMTO\Pagina-principal.razor"
__builder2.AddContent(78, tarjetas.balance);

#line default
#line hidden
#nullable disable
                __builder2.AddContent(79, ".00");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n                                                ");
                __builder2.AddMarkupContent(81, "<label style=\"margin-top:0px; padding-top:0px; font-size:17px;\">Balance</label>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n                                            ");
                __builder2.AddMarkupContent(83, "<div class=\"col\"><p style=\"font-size:35px;\">RD$50.00</p>\r\n                                                <label style=\"margin-top:0px; padding-top:0px; font-size:17px;\">Consumo</label></div>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n                                    ");
                __builder2.AddMarkupContent(85, "<div class=\"tab-pane fade\" id=\"nav-historial\" role=\"tabpanel\" aria-labelledby=\"nav-historial-tab\">...</div>\r\n                                    ");
                __builder2.AddMarkupContent(86, "<div class=\"tab-pane fade\" id=\"nav-usos\" role=\"tabpanel\" aria-labelledby=\"nav-usos-tab\">...</div>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n                ");
            __builder.AddMarkupContent(88, "<div class=\"tab-pane fade\" id=\"nav-profile\" role=\"tabpanel\" aria-labelledby=\"nav-profile-tab\">\r\n                    Terceros\r\n                </div>");
            __builder.CloseElement();
#nullable restore
#line 145 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\UsuariosMTO\Pagina-principal.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(89, "<h3 class=\"modal-title\" id=\"staticBackdropLabel\">Cargando tarjetas...</h3>");
#nullable restore
#line 149 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\UsuariosMTO\Pagina-principal.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 149 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\UsuariosMTO\Pagina-principal.razor"
         
    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 153 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\UsuariosMTO\Pagina-principal.razor"
         if (user != null)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "class", "alert alert-light");
            __builder.AddMarkupContent(92, "\r\n                Hola ");
#nullable restore
#line 156 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\UsuariosMTO\Pagina-principal.razor"
__builder.AddContent(93, user.nombreApellido);

#line default
#line hidden
#nullable disable
            __builder.AddContent(94, "!, alparecer todavia no tienes una tarjeta agregada... ");
            __builder.OpenElement(95, "a");
            __builder.AddAttribute(96, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 156 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\UsuariosMTO\Pagina-principal.razor"
                                                                                                                 ()=> _Tajeta = new Asociar_Tajeta()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(97, "data-bs-toggle", "modal");
            __builder.AddAttribute(98, "data-bs-target", "#staticBackdrop");
            __builder.AddAttribute(99, "href", "#");
            __builder.AddMarkupContent(100, "¡Agrega una!");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 158 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\UsuariosMTO\Pagina-principal.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 158 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\UsuariosMTO\Pagina-principal.razor"
         
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 159 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\UsuariosMTO\Pagina-principal.razor"
     
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(101, "div");
            __builder.AddAttribute(102, "class", "modal fade");
            __builder.AddAttribute(103, "id", "staticBackdrop");
            __builder.AddAttribute(104, "data-bs-backdrop", "static");
            __builder.AddAttribute(105, "data-bs-keyboard", "false");
            __builder.AddAttribute(106, "tabindex", "-1");
            __builder.AddAttribute(107, "aria-labelledby", "staticBackdropLabel");
            __builder.AddAttribute(108, "aria-hidden", "true");
            __builder.OpenElement(109, "div");
            __builder.AddAttribute(110, "class", "modal-dialog");
            __builder.OpenElement(111, "div");
            __builder.AddAttribute(112, "class", "modal-content");
            __builder.AddMarkupContent(113, "<div class=\"modal-header\"><h3 class=\"modal-title\" id=\"staticBackdropLabel\">Asociar mi nueva tarjeta</h3>\r\n                <button type=\"button\" class=\"btn-close\" data-bs-dismiss=\"modal\" aria-label=\"Close\"></button></div>\r\n            ");
            __builder.OpenElement(114, "div");
            __builder.AddAttribute(115, "class", "modal-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(116);
            __builder.AddAttribute(117, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 172 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\UsuariosMTO\Pagina-principal.razor"
                                  _Tajeta

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(118, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 172 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\UsuariosMTO\Pagina-principal.razor"
                                                          AddCardForUser

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(119, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(120);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(121, "\r\n                    ");
                __builder2.OpenElement(122, "div");
                __builder2.AddAttribute(123, "class", "mt-2");
                __builder2.OpenElement(124, "div");
                __builder2.AddAttribute(125, "class", "form-group mt-2");
                __builder2.AddMarkupContent(126, "<label class=\" mb-1\">Numero de tarjeta</label>\r\n                            ");
                __Blazor.SMTOWEB.Pages.UsuariosMTO.Pagina_principal.TypeInference.CreateInputNumber_0(__builder2, 127, 128, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 177 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\UsuariosMTO\Pagina-principal.razor"
                                                                                OnInputCard

#line default
#line hidden
#nullable disable
                ), 129, "form-control", 130, 
#nullable restore
#line 177 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\UsuariosMTO\Pagina-principal.razor"
                                                      _Tajeta.numero

#line default
#line hidden
#nullable disable
                , 131, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _Tajeta.numero = __value, _Tajeta.numero)), 132, () => _Tajeta.numero);
                __builder2.AddMarkupContent(133, "\r\n                            ");
                __Blazor.SMTOWEB.Pages.UsuariosMTO.Pagina_principal.TypeInference.CreateValidationMessage_1(__builder2, 134, 135, 
#nullable restore
#line 178 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\UsuariosMTO\Pagina-principal.razor"
                                                     () => _Tajeta.numero

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 181 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\UsuariosMTO\Pagina-principal.razor"
                     if (tarjeta != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 183 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\UsuariosMTO\Pagina-principal.razor"
__builder2.AddContent(136, (MarkupString)tarjeta.mensaje);

#line default
#line hidden
#nullable disable
#nullable restore
#line 183 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\UsuariosMTO\Pagina-principal.razor"
                                                        
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 185 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\UsuariosMTO\Pagina-principal.razor"
                     if (inputTarjeta > 10)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(137, "<div class=\"alert alert-danger\">\r\n                            El nuemero de la tarjeta supera el numero maximo de dijitos...\r\n                        </div>");
#nullable restore
#line 190 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\UsuariosMTO\Pagina-principal.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(138, "div");
                __builder2.AddAttribute(139, "class", "modal-footer");
                __builder2.AddMarkupContent(140, "<button type=\"button\" class=\"btn btn-secondary\" data-bs-dismiss=\"modal\">Cerrar</button>");
#nullable restore
#line 193 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\UsuariosMTO\Pagina-principal.razor"
                         if (tarjeta != null)
                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(141, "button");
                __builder2.AddAttribute(142, "data-bs-dismiss", "modal");
                __builder2.AddAttribute(143, "type", "submit");
                __builder2.AddAttribute(144, "disabled", 
#nullable restore
#line 195 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\UsuariosMTO\Pagina-principal.razor"
                                                                                      !tarjeta.ok || user.idUsuario == tarjeta.tarjeta[0].IdUsuarioTitular

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(145, "class", "btn btn-primary");
                __builder2.AddContent(146, "Agregar");
                __builder2.CloseElement();
#nullable restore
#line 196 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\UsuariosMTO\Pagina-principal.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 204 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\UsuariosMTO\Pagina-principal.razor"
 if (loading)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<SMTOWEB.Pages.global.Loading>(147);
            __builder.CloseComponent();
#nullable restore
#line 208 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\UsuariosMTO\Pagina-principal.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime Js { get; set; }
    }
}
namespace __Blazor.SMTOWEB.Pages.UsuariosMTO.Pagina_principal
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "oninput", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
