#pragma checksum "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\UsuariosPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71c690fbacbd0376c0a7b7ff7ab597af4555507f"
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
#nullable restore
#line 3 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\UsuariosPage.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/usuarios")]
    public partial class UsuariosPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-xl pl-5 pt-5");
#nullable restore
#line 6 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\UsuariosPage.razor"
     if (usuarios != null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(2);
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, "<div class=\"row mb-3\"><div class=\"col\"><h2>Usuarios</h2></div>\r\n            <div class=\"col\"><a href=\"nuevo-usuario\" class=\"btn btn-primary float-right\">Nuevo usuario</a></div></div>\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGrid<Usuario>>(5);
                __builder2.AddAttribute(6, "AllowFiltering", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\UsuariosPage.razor"
                                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "AllowColumnResize", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\UsuariosPage.razor"
                                           true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "FilterMode", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 19 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\UsuariosPage.razor"
                                    FilterMode.Advanced

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "AllowSorting", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\UsuariosPage.razor"
                                      true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "PageSize", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 21 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\UsuariosPage.razor"
                                  5

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "AllowPaging", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\UsuariosPage.razor"
                                     true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "PagerHorizontalAlign", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.HorizontalAlign>(
#nullable restore
#line 23 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\UsuariosPage.razor"
                                              HorizontalAlign.Justify

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ShowPagingSummary", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\UsuariosPage.razor"
                                           true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Usuario>>(
#nullable restore
#line 25 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\UsuariosPage.razor"
                               usuarios

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "ColumnWidth", "300px");
                __builder2.AddAttribute(16, "LogicalFilterOperator", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.LogicalFilterOperator>(
#nullable restore
#line 29 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\UsuariosPage.razor"
                                               LogicalFilterOperator.Or

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "FilterCaseSensitivity", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 30 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\UsuariosPage.razor"
                                               FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Usuario>>(19);
                    __builder3.AddAttribute(20, "Property", "Cedula");
                    __builder3.AddAttribute(21, "Title", "Cedula");
                    __builder3.AddAttribute(22, "Width", "200px");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(23, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Usuario>>(24);
                    __builder3.AddAttribute(25, "Property", "NombreApellido");
                    __builder3.AddAttribute(26, "Title", "Nombre");
                    __builder3.AddAttribute(27, "Width", "140px");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(28, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Usuario>>(29);
                    __builder3.AddAttribute(30, "Property", "Telefono");
                    __builder3.AddAttribute(31, "Title", "Telefono");
                    __builder3.AddAttribute(32, "Width", "140px");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(33, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Usuario>>(34);
                    __builder3.AddAttribute(35, "Property", "NombreUsuario");
                    __builder3.AddAttribute(36, "Title", "Correo");
                    __builder3.AddAttribute(37, "Width", "140px");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(38, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Usuario>>(39);
                    __builder3.AddAttribute(40, "Property", "Rol");
                    __builder3.AddAttribute(41, "Title", "Rol");
                    __builder3.AddAttribute(42, "Width", "140px");
                    __builder3.AddAttribute(43, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Usuario>)((usuario) => (__builder4) => {
#nullable restore
#line 38 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\UsuariosPage.razor"
                         if (usuario.Rol == "1")
                        {

#line default
#line hidden
#nullable disable
                        __builder4.AddMarkupContent(44, "<span>Administrador</span>");
#nullable restore
#line 41 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\UsuariosPage.razor"
                        }
                        else if (usuario.Rol == "2")
                        {

#line default
#line hidden
#nullable disable
                        __builder4.AddMarkupContent(45, "<span>Adm sucursales</span>");
#nullable restore
#line 45 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\UsuariosPage.razor"
                        }
                        else if (usuario.Rol == "3")
                        {

#line default
#line hidden
#nullable disable
                        __builder4.AddMarkupContent(46, "<span>Vendedor</span>");
#nullable restore
#line 49 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\UsuariosPage.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                        __builder4.AddMarkupContent(47, "<span>Usuario</span>");
#nullable restore
#line 53 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\UsuariosPage.razor"
                        }

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(48, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Usuario>>(49);
                    __builder3.AddAttribute(50, "Title", "Opciones");
                    __builder3.AddAttribute(51, "Filterable", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 56 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\UsuariosPage.razor"
                                                                                                     false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(52, "Sortable", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 56 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\UsuariosPage.razor"
                                                                                                                      false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(53, "TextAlign", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#nullable restore
#line 56 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\UsuariosPage.razor"
                                                                                                                                        TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(54, "Width", "60px");
                    __builder3.AddAttribute(55, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Usuario>)((usuario) => (__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(56);
                        __builder4.AddAttribute(57, "ButtonStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 58 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\UsuariosPage.razor"
                                                   ButtonStyle.Danger

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(58, "Icon", "delete");
                        __builder4.AddAttribute(59, "Size", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#nullable restore
#line 58 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\UsuariosPage.razor"
                                                                                           ButtonSize.Medium

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(60, "Class", "m-1");
                        __builder4.AddAttribute(61, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\UsuariosPage.razor"
                                                                                                                                   args => DeleteRow(usuario)

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddEventStopPropagationAttribute(62, "onclick", 
#nullable restore
#line 58 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\UsuariosPage.razor"
                                                                                                                                                                                          true

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.AddAttribute(63, "EditTemplate", (Microsoft.AspNetCore.Components.RenderFragment<Usuario>)((usuario) => (__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(64);
                        __builder4.AddAttribute(65, "ButtonStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 62 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\UsuariosPage.razor"
                                                   ButtonStyle.Danger

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(66, "Icon", "delete");
                        __builder4.AddAttribute(67, "Size", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#nullable restore
#line 62 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\UsuariosPage.razor"
                                                                                           ButtonSize.Medium

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(68, "Class", "m-1");
                        __builder4.AddAttribute(69, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\UsuariosPage.razor"
                                                                                                                                   args => DeleteRow(usuario)

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddComponentReferenceCapture(70, (__value) => {
#nullable restore
#line 26 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\UsuariosPage.razor"
                              RadzenGrid = (Radzen.Blazor.RadzenDataGrid<Usuario>)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 69 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\UsuariosPage.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(71, "<h5>Cargando usuarios...</h5>");
#nullable restore
#line 73 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\UsuariosPage.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\UsuariosPage.razor"
       
    RadzenDataGrid<Usuario> RadzenGrid;
    GetUsuariosServices usuariosServices = new();
    List<Usuario> usuarios;
    UserTemp user = new UserTemp();
    GetDataUserLoginSessioStorage getData = new GetDataUserLoginSessioStorage();

    protected override async Task OnInitializedAsync()
    {

        usuarios = await usuariosServices.GetUsuarios();
        user = await getData.GetDataLogin(Js);

        StateHasChanged();
    }

    async Task DeleteRow(Usuario usuario)
    {
        usuarios.Remove(usuario);

        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Delete,
            RequestUri = new Uri($"https://localhost:44391/api/Usuarios/{usuario.IdUsuario}"),
            Content = new StringContent("application/json")
        };

        var response = await http.SendAsync(request);
        var respuesta = await response.Content.ReadFromJsonAsync<Response>();
        if (respuesta.ok)
        {
            await Js.InvokeVoidAsync("successDeleted", respuesta.mensaje);
        }
        await RadzenGrid.Reload();

    }

    //protected override async Task OnAfterRenderAsync(bool firstRender)
    //{

    //    if (firstRender)
    //    {

    //    }
    //}

    public class Response
    {
        public bool ok { get; set; }
        public string mensaje { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime Js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
