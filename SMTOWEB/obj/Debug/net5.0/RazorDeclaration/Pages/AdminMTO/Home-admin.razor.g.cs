// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/index")]
    public partial class Home_admin : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "C:\Users\Alex-carreras\Desktop\SMTOWEB\SMTOWEB\Pages\AdminMTO\Home-admin.razor"
           
        RadzenDataGrid<EmpresaUser> empresasGrid;

        async Task DeleteRow(EmpresaUser empresa)
        {
            empresaUsers.Remove(empresa);
            await empresasGrid.Reload();
        }

        List<EmpresaUser> empresaUsers;
        //{
        //    new EmpresaUser()
        //    {
        //        RCN = "1121213930",
        //        Nombre = "Consorcio bancas Diamante",
        //        Nombre_dueño = "Yunior moreta",
        //        Telefono = "000-000-0000",
        //        Direccion = "Santo domingo"
        //    },
        //    new EmpresaUser()
        //    {
        //        RCN = "3237773730",
        //        Nombre = "Super colmado santos",
        //        Nombre_dueño = "Yunior moreta",
        //        Telefono = "000-000-0000",
        //        Direccion = "Santo domingo"
        //    },
        //    new EmpresaUser()
        //    {
        //        RCN = "283283238384",
        //        Nombre = "Disashop",
        //        Nombre_dueño = "Yunior moreta",
        //        Telefono = "000-000-0000",
        //        Direccion = "Santo domingo"
        //    },
        //    new EmpresaUser()
        //    {
        //        RCN = "938283823238",
        //        Nombre = "Total",
        //        Nombre_dueño = "Yunior moreta",
        //        Telefono = "000-000-0000",
        //        Direccion = "Santo domingo"
        //    },
        //    new EmpresaUser()
        //    {
        //        RCN = "92939293293",
        //        Nombre = "Consorcio bancas llueve",
        //        Nombre_dueño = "Yunior moreta",
        //        Telefono = "000-000-0000",
        //        Direccion = "Santo domingo"
        //    },
        //    new EmpresaUser()
        //    {
        //        RCN = "388232923223",
        //        Nombre = "Consorcio bancas la fortuna",
        //        Nombre_dueño = "Yunior moreta",
        //        Telefono = "000-000-0000",
        //        Direccion = "Santo domingo"
        //    }
        //};




        public class EmpresaUser
        {
            public string RCN { get; set; }
            public string Nombre { get; set; }
            public string Nombre_dueño { get; set; }
            public string Telefono { get; set; }
            public string Direccion { get; set; }
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime Js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591
