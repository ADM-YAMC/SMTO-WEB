#pragma checksum "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\Pages\AdminMTO\EmpresasPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "197e835ce28e80f3d2fce874f101c2b825c2b74e"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/nueva-empresa")]
    public partial class EmpresasPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-xl mt-4");
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(2);
            __builder.AddAttribute(3, "class", "mt-5 ml-1 col-lg-6 m-auto ");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "<div class=\"row\"><div class=\"col\"><h3>Nueva empresa</h3></div></div>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
                __builder2.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\Pages\AdminMTO\EmpresasPage.razor"
                              empresa

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(9);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(10, "\r\n                ");
                    __builder3.OpenElement(11, "div");
                    __builder3.AddAttribute(12, "class", "border-top mt-3");
                    __builder3.OpenElement(13, "div");
                    __builder3.AddAttribute(14, "class", "form-group mt-2");
                    __builder3.AddMarkupContent(15, "<label class=\" mb-1\">Nombre de la empresa</label>\r\n                        ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                    __builder3.AddAttribute(17, "class", "form-control");
                    __builder3.AddAttribute(18, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\Pages\AdminMTO\EmpresasPage.razor"
                                                empresa.Nombre

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(19, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => empresa.Nombre = __value, empresa.Nombre))));
                    __builder3.AddAttribute(20, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => empresa.Nombre));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(21, "\r\n\r\n                ");
                    __builder3.OpenElement(22, "div");
                    __builder3.AddAttribute(23, "class", "row");
                    __builder3.OpenElement(24, "div");
                    __builder3.AddAttribute(25, "class", "col");
                    __builder3.OpenElement(26, "div");
                    __builder3.AddAttribute(27, "class", "form-group");
                    __builder3.AddMarkupContent(28, "<label class=\" mb-1\">RNC</label>\r\n                            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(29);
                    __builder3.AddAttribute(30, "class", "form-control");
                    __builder3.AddAttribute(31, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\Pages\AdminMTO\EmpresasPage.razor"
                                                    empresa.Nombre

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(32, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => empresa.Nombre = __value, empresa.Nombre))));
                    __builder3.AddAttribute(33, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => empresa.Nombre));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(34, "\r\n                            ");
                    __Blazor.SMTOWEB.Pages.AdminMTO.EmpresasPage.TypeInference.CreateValidationMessage_0(__builder3, 35, 36, 
#nullable restore
#line 24 "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\Pages\AdminMTO\EmpresasPage.razor"
                                                     () => empresa.Nombre

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(37, "\r\n                    ");
                    __builder3.OpenElement(38, "div");
                    __builder3.AddAttribute(39, "class", "col");
                    __builder3.OpenElement(40, "div");
                    __builder3.AddAttribute(41, "class", "form-group");
                    __builder3.AddMarkupContent(42, "<label class=\" mb-1\">Telefono</label>\r\n                            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(43);
                    __builder3.AddAttribute(44, "class", "form-control");
                    __builder3.AddAttribute(45, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\Pages\AdminMTO\EmpresasPage.razor"
                                                    empresa.Telefono

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(46, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => empresa.Telefono = __value, empresa.Telefono))));
                    __builder3.AddAttribute(47, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => empresa.Telefono));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(48, "\r\n                            ");
                    __Blazor.SMTOWEB.Pages.AdminMTO.EmpresasPage.TypeInference.CreateValidationMessage_1(__builder3, 49, 50, 
#nullable restore
#line 31 "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\Pages\AdminMTO\EmpresasPage.razor"
                                                     () => empresa.Telefono

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(51, "\r\n                ");
                    __builder3.OpenElement(52, "div");
                    __builder3.AddAttribute(53, "class", "row");
                    __builder3.OpenElement(54, "div");
                    __builder3.AddAttribute(55, "class", "col");
                    __builder3.OpenElement(56, "div");
                    __builder3.AddAttribute(57, "class", "form-group");
                    __builder3.AddMarkupContent(58, "<label class=\" mb-1\">Propietario</label>\r\n\r\n                            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDropDown<dynamic>>(59);
                    __builder3.AddAttribute(60, "AllowClear", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 40 "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\Pages\AdminMTO\EmpresasPage.razor"
                                                        true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(61, "AllowVirtualization", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 40 "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\Pages\AdminMTO\EmpresasPage.razor"
                                                                                                    true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(62, "class", "w-100 form-control");
                    __builder3.AddAttribute(63, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 41 "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\Pages\AdminMTO\EmpresasPage.razor"
                                                            true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(64, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.IEnumerable>(
#nullable restore
#line 41 "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\Pages\AdminMTO\EmpresasPage.razor"
                                                                        usuarios

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(65, "Placeholder", "Seleccione el propietario...");
                    __builder3.AddAttribute(66, "TextProperty", "NombreApellido");
                    __builder3.AddAttribute(67, "ValueProperty", "IdUsuario");
                    __builder3.AddAttribute(68, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Object>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Object>(this, 
#nullable restore
#line 42 "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\Pages\AdminMTO\EmpresasPage.razor"
                                                     args => OnChange(args, "DropDown with placeholder")

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(69, "\r\n                            ");
                    __Blazor.SMTOWEB.Pages.AdminMTO.EmpresasPage.TypeInference.CreateValidationMessage_2(__builder3, 70, 71, 
#nullable restore
#line 43 "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\Pages\AdminMTO\EmpresasPage.razor"
                                                     () => empresa.IdUsuario

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(72, "\r\n                    ");
                    __builder3.AddMarkupContent(73, "<div class=\"col-1 pl-0\"><a href=\"usuarios\" class=\"btn btn-success w-100\" style=\"margin-top:26px;\">+</a></div>");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(74, "\r\n\r\n                ");
                    __builder3.OpenElement(75, "div");
                    __builder3.AddAttribute(76, "class", "form-group");
                    __builder3.AddMarkupContent(77, "<label>Direccion</label>\r\n                    ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(78);
                    __builder3.AddAttribute(79, "class", "form-control");
                    __builder3.AddAttribute(80, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 53 "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\Pages\AdminMTO\EmpresasPage.razor"
                                                empresa.Direccion

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(81, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => empresa.Direccion = __value, empresa.Direccion))));
                    __builder3.AddAttribute(82, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => empresa.Direccion));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(83, "\r\n                    ");
                    __Blazor.SMTOWEB.Pages.AdminMTO.EmpresasPage.TypeInference.CreateValidationMessage_3(__builder3, 84, 85, 
#nullable restore
#line 54 "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\Pages\AdminMTO\EmpresasPage.razor"
                                             () => empresa.Direccion

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(86, "\r\n                ");
                    __builder3.AddMarkupContent(87, "<button type=\"submit\" class=\"btn btn-success float-right mt-2\">Guardar</button>");
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
#line 63 "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\Pages\AdminMTO\EmpresasPage.razor"
           
        Empresa empresa = new Empresa();
        GetUsuariosServices usuariosServices = new();
        List<Usuario> usuarios;


        protected override async Task OnInitializedAsync()
        {
            try
            {
                usuarios = await usuariosServices.GetUsuarios();
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

        void OnChange(object value, string name)
        {
            var str = value is IEnumerable<object> ? string.Join(", ", (IEnumerable<object>)value) : value;
            Console.WriteLine($"{name} value changed to {value}");
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime Js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
    }
}
namespace __Blazor.SMTOWEB.Pages.AdminMTO.EmpresasPage
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
    }
}
#pragma warning restore 1591
