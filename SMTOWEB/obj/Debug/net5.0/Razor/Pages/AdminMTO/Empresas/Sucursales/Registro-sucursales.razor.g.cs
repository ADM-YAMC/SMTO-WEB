#pragma checksum "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Sucursales\Registro-sucursales.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa0dc08b1722c61b984526d811e42d54f4fb8095"
// <auto-generated/>
#pragma warning disable 1591
namespace SMTOWEB.Pages.AdminMTO.Empresas.Sucursales
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/empresa/{id:int}/sucursales/registro-sucursales")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/empresa/{id:int}/sucursales/editar-sucursal/{ids:int}")]
    public partial class Registro_sucursales : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(0);
            __builder.AddAttribute(1, "class", "mt-5 ml-1 col-lg-6 m-auto ");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "<div class=\"row\"><div class=\"col\"><h2>Registro de sucursales</h2></div></div>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
                __builder2.AddAttribute(5, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Sucursales\Registro-sucursales.razor"
                      sucursal

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Sucursales\Registro-sucursales.razor"
                                               PostSucursal

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(9, "\r\n        ");
                    __builder3.OpenElement(10, "div");
                    __builder3.AddAttribute(11, "class", "border-top mt-3");
                    __builder3.OpenElement(12, "div");
                    __builder3.AddAttribute(13, "class", "form-group");
                    __builder3.AddMarkupContent(14, "<label class=\" mb-1\">Nombre socusal</label>\r\n                ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(15);
                    __builder3.AddAttribute(16, "class", "form-control");
                    __builder3.AddAttribute(17, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Sucursales\Registro-sucursales.razor"
                                        sucursal.NombreSucursal

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(18, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => sucursal.NombreSucursal = __value, sucursal.NombreSucursal))));
                    __builder3.AddAttribute(19, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => sucursal.NombreSucursal));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(20, "\r\n                ");
                    __Blazor.SMTOWEB.Pages.AdminMTO.Empresas.Sucursales.Registro_sucursales.TypeInference.CreateValidationMessage_0(__builder3, 21, 22, 
#nullable restore
#line 21 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Sucursales\Registro-sucursales.razor"
                                         () => sucursal.NombreSucursal

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(23, "\r\n        ");
                    __builder3.OpenElement(24, "div");
                    __builder3.AddAttribute(25, "class", "form-group mt-2");
                    __builder3.AddMarkupContent(26, "<label class=\" mb-1\">Telefono</label>\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenMask>(27);
                    __builder3.AddAttribute(28, "Mask", "(***) ***-****");
                    __builder3.AddAttribute(29, "CharacterPattern", "[0-9]");
                    __builder3.AddAttribute(30, "Placeholder", "(000) 000-0000");
                    __builder3.AddAttribute(31, "Name", "Phone");
                    __builder3.AddAttribute(32, "Style", "width: 100%;");
                    __builder3.AddAttribute(33, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Sucursales\Registro-sucursales.razor"
                                     sucursal.Telefono

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(34, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => sucursal.Telefono = __value, sucursal.Telefono))));
                    __builder3.AddAttribute(35, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => sucursal.Telefono));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(36, "\r\n            ");
                    __Blazor.SMTOWEB.Pages.AdminMTO.Empresas.Sucursales.Registro_sucursales.TypeInference.CreateValidationMessage_1(__builder3, 37, 38, 
#nullable restore
#line 28 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Sucursales\Registro-sucursales.razor"
                                     () => sucursal.Telefono

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(39, "\r\n        ");
                    __builder3.OpenElement(40, "div");
                    __builder3.AddAttribute(41, "class", "form-group");
                    __builder3.AddMarkupContent(42, "<label>Direccion</label>\r\n            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(43);
                    __builder3.AddAttribute(44, "class", "form-control");
                    __builder3.AddAttribute(45, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Sucursales\Registro-sucursales.razor"
                                        sucursal.Direccion

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(46, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => sucursal.Direccion = __value, sucursal.Direccion))));
                    __builder3.AddAttribute(47, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => sucursal.Direccion));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(48, "\r\n            ");
                    __Blazor.SMTOWEB.Pages.AdminMTO.Empresas.Sucursales.Registro_sucursales.TypeInference.CreateValidationMessage_2(__builder3, 49, 50, 
#nullable restore
#line 33 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Sucursales\Registro-sucursales.razor"
                                     () => sucursal.Direccion

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(51, "\r\n        ");
                    __builder3.AddMarkupContent(52, "<button type=\"submit\" class=\"btn btn-success float-right mt-2\">Guardar</button>");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 39 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Sucursales\Registro-sucursales.razor"
 if (ids != 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(53, "<div class=\"row mb-3 mt-4\"><div class=\"col\"><h2>Usuarios de esta sucursal</h2></div>\r\n        <div class=\"col d-flex justify-content-end\"><a href=\"empresa/usuarios/registro-usuarios\" class=\"btn btn-primary\">Nuevo usuario</a></div></div>");
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(54);
            __builder.AddAttribute(55, "class", "mb-5");
            __builder.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 51 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Sucursales\Registro-sucursales.razor"
         if (usuarios != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Sucursales\Registro-sucursales.razor"
             if (usuarios.Count != 0)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGrid<Usuario>>(57);
                __builder2.AddAttribute(58, "AllowFiltering", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 55 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Sucursales\Registro-sucursales.razor"
                                                true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(59, "AllowColumnResize", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 55 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Sucursales\Registro-sucursales.razor"
                                                                                     true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(60, "FilterMode", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 55 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Sucursales\Registro-sucursales.razor"
                                                                                                       FilterMode.Advanced

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(61, "AllowSorting", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 55 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Sucursales\Registro-sucursales.razor"
                                                                                                                                          true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "PageSize", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 55 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Sucursales\Registro-sucursales.razor"
                                                                                                                                                          6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "AllowPaging", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 56 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Sucursales\Registro-sucursales.razor"
                                             true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(64, "PagerHorizontalAlign", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.HorizontalAlign>(
#nullable restore
#line 56 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Sucursales\Registro-sucursales.razor"
                                                                         HorizontalAlign.Left

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(65, "ShowPagingSummary", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 56 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Sucursales\Registro-sucursales.razor"
                                                                                                                  true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Usuario>>(
#nullable restore
#line 57 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Sucursales\Registro-sucursales.razor"
                                       usuarios

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(67, "ColumnWidth", "300px");
                __builder2.AddAttribute(68, "LogicalFilterOperator", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.LogicalFilterOperator>(
#nullable restore
#line 58 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Sucursales\Registro-sucursales.razor"
                                                       LogicalFilterOperator.Or

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(69, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Usuario>>(70);
                    __builder3.AddAttribute(71, "Property", "Cedula");
                    __builder3.AddAttribute(72, "Title", "Cedula");
                    __builder3.AddAttribute(73, "Width", "100px");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(74, "\r\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Usuario>>(75);
                    __builder3.AddAttribute(76, "Property", "NombreApellido");
                    __builder3.AddAttribute(77, "Title", "Nombre");
                    __builder3.AddAttribute(78, "Width", "100px");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(79, "\r\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Usuario>>(80);
                    __builder3.AddAttribute(81, "Property", "Telefono");
                    __builder3.AddAttribute(82, "Title", "Telefono");
                    __builder3.AddAttribute(83, "Width", "80px");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(84, "\r\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Usuario>>(85);
                    __builder3.AddAttribute(86, "Property", "Direccion");
                    __builder3.AddAttribute(87, "Title", "Direccion");
                    __builder3.AddAttribute(88, "Width", "100px");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(89, "\r\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Usuario>>(90);
                    __builder3.AddAttribute(91, "Property", "NombreUsuario");
                    __builder3.AddAttribute(92, "Title", "Correo");
                    __builder3.AddAttribute(93, "Width", "100px");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(94, "\r\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Usuario>>(95);
                    __builder3.AddAttribute(96, "Property", "Rol");
                    __builder3.AddAttribute(97, "Title", "Rol");
                    __builder3.AddAttribute(98, "Width", "90px");
                    __builder3.AddAttribute(99, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Usuario>)((data) => (__builder4) => {
#nullable restore
#line 67 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Sucursales\Registro-sucursales.razor"
                                 if (data.Rol == "3")
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Sucursales\Registro-sucursales.razor"
__builder4.AddContent(100, "Vendedor");

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Sucursales\Registro-sucursales.razor"
                                                 
                                }
                                else
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Sucursales\Registro-sucursales.razor"
__builder4.AddContent(101, "Usuario");

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Sucursales\Registro-sucursales.razor"
                                                
                                }

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddComponentReferenceCapture(102, (__value) => {
#nullable restore
#line 55 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Sucursales\Registro-sucursales.razor"
                                                            grid = (Radzen.Blazor.RadzenDataGrid<Usuario>)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
#nullable restore
#line 79 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Sucursales\Registro-sucursales.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(103, "<div class=\"alert alert-info\">\r\n                    No se encontraron datos...\r\n                </div>");
#nullable restore
#line 85 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Sucursales\Registro-sucursales.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Sucursales\Registro-sucursales.razor"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(104, "<div class=\"d-flex justify-content-center\"><div class=\"spinner-border\" role=\"status\"><span class=\"visually-hidden\">Loading...</span></div></div>");
#nullable restore
#line 94 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Sucursales\Registro-sucursales.razor"
        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 96 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Sucursales\Registro-sucursales.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SweetAlertService Swal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime Js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
namespace __Blazor.SMTOWEB.Pages.AdminMTO.Empresas.Sucursales.Registro_sucursales
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
