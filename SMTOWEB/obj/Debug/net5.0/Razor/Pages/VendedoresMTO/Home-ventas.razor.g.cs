#pragma checksum "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\Pages\VendedoresMTO\Home-ventas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a27e51a4ec61f55e795cbb33a91e11dc7dd3e0d8"
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
#line 1 "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\_Imports.razor"
using SMTOWEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\_Imports.razor"
using SMTOWEB.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\_Imports.razor"
using SMTOWEB.Modelo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\_Imports.razor"
using SMTO_API.Modelos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\_Imports.razor"
using SMTOWEB.Servicios;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\_Imports.razor"
using SMTOWEB.Pages.global;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\_Imports.razor"
using SMTOWEB.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\_Imports.razor"
using CurrieTechnologies.Razor.SweetAlert2;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Kiosco")]
    public partial class Home_ventas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>@media screen and (max-width: 800px) {\r\n        .row{\r\n            display:block;\r\n\r\n        }\r\n        .col-4{\r\n            width:100%;\r\n        }\r\n        }\r\n</style>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container-xl p-4");
            __builder.AddMarkupContent(3, @"<nav><div class=""nav nav-tabs"" id=""nav-tab"" role=""tablist""><button class=""nav-link active"" id=""nav-home-tab"" data-bs-toggle=""tab"" data-bs-target=""#nav-home"" type=""button"" role=""tab"" aria-controls=""nav-home"" aria-selected=""true"">Venta</button>
            <button class=""nav-link"" id=""nav-profile-tab"" data-bs-toggle=""tab"" data-bs-target=""#nav-profile"" type=""button"" role=""tab"" aria-controls=""nav-profile"" aria-selected=""false"">Reportes</button></div></nav>
    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "tab-content");
            __builder.AddAttribute(6, "id", "nav-tabContent");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "tab-pane fade show active");
            __builder.AddAttribute(9, "id", "nav-home");
            __builder.AddAttribute(10, "role", "tabpanel");
            __builder.AddAttribute(11, "aria-labelledby", "nav-home-tab");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "row");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-lg-4");
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(16);
            __builder.AddAttribute(17, "class", "mt-3 w-100");
            __builder.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(19, @"<div class=""text-center""><div class=""m-auto""><img src=""https://cdn-icons-png.flaticon.com/512/2580/2580363.png"" height=""50"" width=""50"" alt=""Alternate Text""></div>
                            <p>Banca Diamante #45</p>
                            <label class=""text-success"">Activo</label></div>

                        ");
                __builder2.AddMarkupContent(20, "<div class=\"border-top mt-3 border-bottom mb-3\"><div class=\"form-group mt-2\"><label>Total vendido hoy</label>\r\n                                <h1 class=\" mb-2 text-success\">RD$300.00</h1></div></div>\r\n\r\n                        ");
                __builder2.AddMarkupContent(21, "<div class=\"form-group\"><p>Ultima recgarga</p>\r\n                            <label>12-Feb-2022</label></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n                ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "col");
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(25);
            __builder.AddAttribute(26, "class", "mt-3 mr-1 p-0");
            __builder.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(28, "<div class=\"col mt-3\"><h2 class=\"d-inline\">Recargas</h2>\r\n                            <h3 style=\"float:right;\" class=\"d-inline text-right\">Ilimitado</h3></div>\r\n                        <hr class=\"mb-0\">\r\n                        ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "col p-4");
                __builder2.AddMarkupContent(31, "<div class=\"form-group\"><h3>No. tarjeta</h3>\r\n                                <input type=\"number\" placeholder=\"Escriba el numero de la tarjeta...\" name=\"tarjeta\" class=\"form-control\"></div>\r\n                            ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "form-group mb-2");
                __builder2.AddMarkupContent(34, "<h3>Recargar</h3>\r\n                                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenRadioButtonList<int>>(35);
                __builder2.AddAttribute(36, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int>(
#nullable restore
#line 65 "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\Pages\VendedoresMTO\Home-ventas.razor"
                                                                    value

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<int>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<int>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => value = __value, value))));
                __builder2.AddAttribute(38, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<int>>>(() => value));
                __builder2.AddAttribute(39, "Items", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.SMTOWEB.Pages.VendedoresMTO.Home_ventas.TypeInference.CreateRadzenRadioButtonListItem_0(__builder3, 40, 41, "Viajes", 42, 
#nullable restore
#line 67 "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\Pages\VendedoresMTO\Home-ventas.razor"
                                                                                        1

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(43, "\r\n                                        ");
                    __Blazor.SMTOWEB.Pages.VendedoresMTO.Home_ventas.TypeInference.CreateRadzenRadioButtonListItem_1(__builder3, 44, 45, "Balance", 46, 
#nullable restore
#line 68 "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\Pages\VendedoresMTO\Home-ventas.razor"
                                                                                         2

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
#nullable restore
#line 72 "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\Pages\VendedoresMTO\Home-ventas.razor"
                             if (value == 1)
                            {


#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(47, "<div class=\"mb-1\"><div class=\"form-group\"><h3>Cantidad</h3>\r\n                                        <input type=\"number\" style=\"font-size:25px; height:50px\" class=\"form-control\"></div></div>");
#nullable restore
#line 81 "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\Pages\VendedoresMTO\Home-ventas.razor"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(48, "<div class=\"form-group\"><h3>Monto</h3>\r\n                                    <input type=\"number\" style=\"font-size:25px; height:50px;\" class=\"form-control\"></div>\r\n                                ");
                __builder2.AddMarkupContent(49, "<p class=\"mt-1\">El monto mínimo de recarga es de RD$20.00 y el máximo de RD$2,000.00</p>");
#nullable restore
#line 89 "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\Pages\VendedoresMTO\Home-ventas.razor"
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
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.AddMarkupContent(51, "<div class=\"tab-pane fade\" id=\"nav-profile\" role=\"tabpanel\" aria-labelledby=\"nav-profile-tab\">\r\n            Reortes\r\n        </div>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 102 "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\Pages\VendedoresMTO\Home-ventas.razor"
           
        int value = 1;
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime Js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
    }
}
namespace __Blazor.SMTOWEB.Pages.VendedoresMTO.Home_ventas
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenRadioButtonListItem_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenRadioButtonListItem<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Text", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateRadzenRadioButtonListItem_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenRadioButtonListItem<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Text", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
