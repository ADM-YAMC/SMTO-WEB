#pragma checksum "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Registro-empresa.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8056ec0c50a3c88b845995b40ab78ac5c8193cf6"
// <auto-generated/>
#pragma warning disable 1591
namespace SMTOWEB.Pages.AdminMTO.Empresas
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/empresas/nueva-empresa")]
    public partial class Registro_empresa : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-xl mt-4");
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(2);
            __builder.AddAttribute(3, "class", "mt-5 ml-1 col-lg-6 m-auto ");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "<div class=\"row\"><div class=\"col\"><h3>Nueva empresa</h3></div></div>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
                __builder2.AddAttribute(7, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Registro-empresa.razor"
                          empresa

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Registro-empresa.razor"
                                                  PostEmpresa

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(10);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(11, "\r\n            ");
                    __builder3.OpenElement(12, "div");
                    __builder3.AddAttribute(13, "class", "border-top mt-3");
                    __builder3.OpenElement(14, "div");
                    __builder3.AddAttribute(15, "class", "form-group mt-2");
                    __builder3.AddMarkupContent(16, "<label class=\" mb-1\">Nombre de la empresa</label>\r\n                    ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(17);
                    __builder3.AddAttribute(18, "class", "form-control");
                    __builder3.AddAttribute(19, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Registro-empresa.razor"
                                            empresa.Nombre

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(20, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => empresa.Nombre = __value, empresa.Nombre))));
                    __builder3.AddAttribute(21, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => empresa.Nombre));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(22, "\r\n                    ");
                    __Blazor.SMTOWEB.Pages.AdminMTO.Empresas.Registro_empresa.TypeInference.CreateValidationMessage_0(__builder3, 23, 24, 
#nullable restore
#line 17 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Registro-empresa.razor"
                                             () => empresa.Nombre

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(25, "\r\n\r\n            ");
                    __builder3.OpenElement(26, "div");
                    __builder3.AddAttribute(27, "class", "row");
                    __builder3.OpenElement(28, "div");
                    __builder3.AddAttribute(29, "class", "col");
                    __builder3.OpenElement(30, "div");
                    __builder3.AddAttribute(31, "class", "form-group");
                    __builder3.AddMarkupContent(32, "<label class=\" mb-1\">RNC</label>\r\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenMask>(33);
                    __builder3.AddAttribute(34, "Mask", "*** *** ***");
                    __builder3.AddAttribute(35, "CharacterPattern", "[0-9]");
                    __builder3.AddAttribute(36, "Placeholder", "000 000 000");
                    __builder3.AddAttribute(37, "Name", "RNC");
                    __builder3.AddAttribute(38, "Style", "width: 100%;");
                    __builder3.AddAttribute(39, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Registro-empresa.razor"
                                                                         empresa.RNC

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(40, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => empresa.RNC = __value, empresa.RNC))));
                    __builder3.AddAttribute(41, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => empresa.RNC));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(42, "\r\n                        ");
                    __Blazor.SMTOWEB.Pages.AdminMTO.Empresas.Registro_empresa.TypeInference.CreateValidationMessage_1(__builder3, 43, 44, 
#nullable restore
#line 29 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Registro-empresa.razor"
                                                 () => empresa.RNC

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(45, "\r\n                ");
                    __builder3.OpenElement(46, "div");
                    __builder3.AddAttribute(47, "class", "col");
                    __builder3.OpenElement(48, "div");
                    __builder3.AddAttribute(49, "class", "form-group");
                    __builder3.AddMarkupContent(50, "<label class=\" mb-1\">Telefono</label>\r\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenMask>(51);
                    __builder3.AddAttribute(52, "Mask", "(***) ***-****");
                    __builder3.AddAttribute(53, "CharacterPattern", "[0-9]");
                    __builder3.AddAttribute(54, "Placeholder", "(000) 000-0000");
                    __builder3.AddAttribute(55, "Name", "Telefono");
                    __builder3.AddAttribute(56, "Style", "width: 100%;");
                    __builder3.AddAttribute(57, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Registro-empresa.razor"
                                                                                                                                             empresa.Telefono

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(58, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => empresa.Telefono = __value, empresa.Telefono))));
                    __builder3.AddAttribute(59, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => empresa.Telefono));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(60, "\r\n                        ");
                    __Blazor.SMTOWEB.Pages.AdminMTO.Empresas.Registro_empresa.TypeInference.CreateValidationMessage_2(__builder3, 61, 62, 
#nullable restore
#line 36 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Registro-empresa.razor"
                                                 () => empresa.Telefono

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(63, "\r\n            ");
                    __builder3.OpenElement(64, "div");
                    __builder3.AddAttribute(65, "class", "row");
                    __builder3.OpenElement(66, "div");
                    __builder3.AddAttribute(67, "class", "col");
                    __builder3.OpenElement(68, "div");
                    __builder3.AddAttribute(69, "class", "form-group");
                    __builder3.AddMarkupContent(70, "<label class=\" mb-1\">Propietario</label>\r\n\r\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDropDown<dynamic>>(71);
                    __builder3.AddAttribute(72, "AllowClear", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 45 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Registro-empresa.razor"
                                                    true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(73, "AllowVirtualization", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 47 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Registro-empresa.razor"
                                                             true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(74, "class", "w-100 form-control");
                    __builder3.AddAttribute(75, "AllowFiltering", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 49 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Registro-empresa.razor"
                                                        true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(76, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.IEnumerable>(
#nullable restore
#line 50 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Registro-empresa.razor"
                                              usuariosOnlyId

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(77, "Placeholder", "Seleccione el propietario...");
                    __builder3.AddAttribute(78, "TextProperty", "name");
                    __builder3.AddAttribute(79, "ValueProperty", "id");
                    __builder3.AddAttribute(80, "Change", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Object>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Object>(this, 
#nullable restore
#line 54 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Registro-empresa.razor"
                                                 args => OnChange(args)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(81, "\r\n                        ");
                    __Blazor.SMTOWEB.Pages.AdminMTO.Empresas.Registro_empresa.TypeInference.CreateValidationMessage_3(__builder3, 82, 83, 
#nullable restore
#line 56 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Registro-empresa.razor"
                                                 () => empresa.IdUsuario

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(84, "\r\n                ");
                    __builder3.AddMarkupContent(85, "<div class=\"col-1 pl-0\"><a href=\"usuarios\" class=\"btn btn-success w-100\" style=\"margin-top:26px;\">+</a></div>");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(86, "\r\n\r\n            ");
                    __builder3.OpenElement(87, "div");
                    __builder3.AddAttribute(88, "class", "form-group");
                    __builder3.AddMarkupContent(89, "<label>Direccion</label>\r\n                ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(90);
                    __builder3.AddAttribute(91, "class", "form-control");
                    __builder3.AddAttribute(92, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 66 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Registro-empresa.razor"
                                            empresa.Direccion

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(93, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => empresa.Direccion = __value, empresa.Direccion))));
                    __builder3.AddAttribute(94, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => empresa.Direccion));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(95, "\r\n                ");
                    __Blazor.SMTOWEB.Pages.AdminMTO.Empresas.Registro_empresa.TypeInference.CreateValidationMessage_4(__builder3, 96, 97, 
#nullable restore
#line 67 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Registro-empresa.razor"
                                         () => empresa.Direccion

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(98, "\r\n            ");
                    __builder3.AddMarkupContent(99, "<button type=\"submit\" class=\"btn btn-success float-right mt-2\">Guardar</button>");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Empresas\Registro-empresa.razor"
       
    Empresa empresa = new Empresa();
    GetUsuariosServices usuariosServices = new();
    List<Usuario> usuarios;
    List<CustomUsuariOnlyId> usuariosOnlyId;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            usuariosOnlyId = await http.GetFromJsonAsync<List<CustomUsuariOnlyId>>("https://smto-apiv2.azurewebsites.net/api/Usuarios/CustomUsuariOnlyId");
        }
        catch (Exception)
        {

            usuarios = new List<Usuario>();
            await Js.InvokeVoidAsync("errorNotFound");
        }
        DateTime date = new DateTime();
        var fecha = DateTime.Now.ToString("yyyy-MM-ddThh:mm:ssz");
        Console.WriteLine(fecha);
    }

    void OnChange(object value)
    {
        empresa.IdUsuario = (int)value;
        Console.WriteLine(empresa.IdUsuario);
    }

    async Task PostEmpresa()
    {

        var fecha = DateTime.Now.ToString("yyyy-MM-ddThh:mm:ss");
        empresa.FechaCreacion = Convert.ToDateTime(fecha);
        empresa.Estado = true;
        string json = JsonConvert.SerializeObject(empresa);
        StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
        var responses = await http.PostAsync("https://smto-apiv2.azurewebsites.net/api/Empresas", httpContent);
        var respuesta = await responses.Content.ReadFromJsonAsync<CustomEmpresas>();
        if (respuesta.Ok)
        {
            await Js.InvokeAsync<object>("Estado", "??xito", $"{respuesta.Mensaje}", "success");
            empresa = new Empresa();

        }
        else
        {
            await Js.InvokeAsync<object>("Estado", "Oops..", $"{respuesta.Mensaje}", "error");
        }
    }

    class CustomEmpresas
    {
        public bool Ok { get; set; }
        public string Mensaje { get; set; }
        public List<Empresa> Empresas { get; set; }
    }
    public class CustomUsuariOnlyId
    {
        public int id { get; set; }
        public string name { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime Js { get; set; }
    }
}
namespace __Blazor.SMTOWEB.Pages.AdminMTO.Empresas.Registro_empresa
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
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
