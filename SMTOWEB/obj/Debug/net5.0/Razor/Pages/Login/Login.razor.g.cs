#pragma checksum "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\Login\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ad3450a98dc155bc4502124a75328ecc7b5019d"
// <auto-generated/>
#pragma warning disable 1591
namespace SMTOWEB.Pages.Login
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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    .content0 {
        display: flex;
        /*flex-direction: column;*/
        height: 100vh;
        margin: 0;
    }

        .content0 .content1 {
            height: 100vh;
            width: 50%;
        }

        .content0 .content2 {
            height: 100vh;
            width: 50%;
        }

    .smto {
        font-size: 100px;
        margin-top: 8rem;
        color: #0D5996;
    }

    .smto-re {
        display: none;
    }

    .content2-content {
        margin-top: 7rem;
    }

    @media screen and (max-width: 768px) {
        .content1 {
            display: none;
        }

        .content0 .content2 {
            width: 100%;
        }

        .content2-content {
            margin-top: 4rem;
        }

        .smto-re {
            display: block;
            margin-top: 1rem;
            color: #0D5996;
        }
    }
</style>");
#nullable restore
#line 59 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\Login\Login.razor"
 if (!redireccionar)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "content0");
            __builder.AddMarkupContent(3, "<div class=\"content1 text-center\"><img class=\"img-fluid mt-1\" src=\"Image/undraw_creativity_re_8grt.svg\" alt=\"Alternate Text\">\r\n            <h1 class=\"smto\">SMTO</h1></div>\r\n        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "content2");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col p-4 content2-content border-left");
            __builder.AddMarkupContent(8, @"<div class=""col text-center mb-3""><div style=""width:100px; height:100px; margin:auto; ""><img src=""Image/train (1).png"" class=""m-auto"" style=""z-index:30"" height=""100"" width=""100"" alt=""Alternate Text""></div>
                    <h1>Iniciar sesión</h1></div>
                ");
            __builder.AddMarkupContent(9, @"<div class=""row""><div class=""col""><button style=""background: #0275d8!important;"" class=""btn btn-primary w-100""><i class=""fab fa-facebook-f""></i></button></div>
                    <div class=""col""><button class=""btn btn-light w-100""><i class=""fab fa-google""></i></button></div></div>
                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(10);
            __builder.AddAttribute(11, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 82 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\Login\Login.razor"
                                  dataLogin

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 82 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\Login\Login.razor"
                                                            logout

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(14);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n                    ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "col mt-3 mb-2");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "form-group");
                __builder2.AddMarkupContent(20, "<h3><i class=\"fas fa-user\"></i> Correo</h3>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(21);
                __builder2.AddAttribute(22, "style", "height:40px;");
                __builder2.AddAttribute(23, "type", "email");
                __builder2.AddAttribute(24, "placeholder", "Escriba el usuario o correo...");
                __builder2.AddAttribute(25, "class", "form-control");
                __builder2.AddAttribute(26, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 87 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\Login\Login.razor"
                                                                                      dataLogin.user

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dataLogin.user = __value, dataLogin.user))));
                __builder2.AddAttribute(28, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => dataLogin.user));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n                            ");
                __Blazor.SMTOWEB.Pages.Login.Login.TypeInference.CreateValidationMessage_0(__builder2, 30, 31, 
#nullable restore
#line 88 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\Login\Login.razor"
                                                     () => dataLogin.user

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n                        ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "form-group");
                __builder2.AddMarkupContent(35, "<h3><i class=\"fas fa-key\"></i> Contraseña</h3>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(36);
                __builder2.AddAttribute(37, "style", "height:40px;");
                __builder2.AddAttribute(38, "type", "password");
                __builder2.AddAttribute(39, "placeholder", "Escriba la contraseña...");
                __builder2.AddAttribute(40, "class", "form-control");
                __builder2.AddAttribute(41, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 92 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\Login\Login.razor"
                                                                                         dataLogin.pass

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dataLogin.pass = __value, dataLogin.pass))));
                __builder2.AddAttribute(43, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => dataLogin.pass));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n                            ");
                __Blazor.SMTOWEB.Pages.Login.Login.TypeInference.CreateValidationMessage_1(__builder2, 45, 46, 
#nullable restore
#line 93 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\Login\Login.razor"
                                                     () => dataLogin.pass

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n                    ");
                __builder2.AddMarkupContent(48, "<div class=\"col d-flex justify-content-center\"><button type=\"submit\" class=\"btn btn-success w-100\">Iniciar</button></div>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 101 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\Login\Login.razor"
                 if (loading)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<SMTOWEB.Pages.global.Loading>(49);
            __builder.CloseComponent();
            __builder.AddMarkupContent(50, @"<div style=""z-index:-1;"" class=""col mt-2 ""><a href=""#"" class=""d-block"">Olvide mi contraseña</a>
                        <label>¿No tienes una cuenta? <a href=""/registro"">Registrate!</a></label>
                        <h1 class=""smto-re text-center mt-2"">SMTO</h1></div>");
#nullable restore
#line 108 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\Login\Login.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(51, @"<div style=""z-index:1;"" class=""col mt-2 ""><a href=""#"" class=""d-block"">Olvide mi contraseña</a>
                        <label>¿No tienes una cuenta? <a href=""/registro"">Registrate!</a></label>
                        <h1 class=""smto-re text-center mt-2"">SMTO</h1></div>");
#nullable restore
#line 116 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\Login\Login.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 120 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\Login\Login.razor"

}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(52, "<br><br>\r\n    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(53);
            __builder.AddAttribute(54, "class", "mt-2 ml-1 mt-5 col-sm-5 m-auto animate__animated animate__backInRight");
            __builder.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(56, @"<div class=""col text-center""><h2 class=""d-inline mb-1 text-center"">¿Como quieres ingresar?</h2>
            <div style=""width:250px; height:270px; margin:auto; ""><img src=""Image/undraw_confirmation_re_b6q5.svg"" class=""m-auto"" style=""z-index:30"" height=""270"" width=""250"" alt=""Alternate Text""></div></div>
        ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "alert alert-light");
                __builder2.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 132 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\Login\Login.razor"
                                                 (() => RedirigirUsuario())

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(60, "style", "cursor:pointer;");
                __builder2.AddMarkupContent(61, "<p><b>Como usuario</b></p>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n        ");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "col alert alert-light");
                __builder2.AddAttribute(65, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 135 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\Login\Login.razor"
                                                     (()=> Redirecion(respuesta.user[0].rol))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "style", "cursor:pointer;");
                __builder2.OpenElement(67, "p");
                __builder2.OpenElement(68, "b");
                __builder2.AddContent(69, "Como ");
                __builder2.AddContent(70, 
#nullable restore
#line 136 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\Login\Login.razor"
                        roles

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n        ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "col alert alert-danger");
                __builder2.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 138 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\Login\Login.razor"
                                                      (()=> redireccionar =! redireccionar)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(75, "style", "cursor:pointer;");
                __builder2.AddMarkupContent(76, "<p><b>Cancelar</b></p>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 142 "C:\Users\Alex-carreras\source\repos\SMTO-WEB\SMTOWEB\Pages\Login\Login.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
    }
}
namespace __Blazor.SMTOWEB.Pages.Login.Login
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
    }
}
#pragma warning restore 1591
