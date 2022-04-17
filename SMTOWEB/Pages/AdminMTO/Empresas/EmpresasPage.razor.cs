using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.JSInterop;
using Radzen.Blazor;
using SMTO_API.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SMTOWEB.Pages.AdminMTO.Empresas
{
    public partial class EmpresasPage
    {
        List<GetEmpresa> getEmpresas;
        RadzenDataGrid<GetEmpresa> Grid;
        protected override async Task OnInitializedAsync()
        {
            getEmpresas = await http.GetFromJsonAsync<List<GetEmpresa>>("https://localhost:44391/api/Empresas");
        }


        async Task ConfirmacionEliminarEmpresa(GetEmpresa empresa)
        {
            var result = await Js.InvokeAsync<bool>
                ("confirmarEliminacion", "Precaucion", "¿Estas seguro de que quieres eliminar la empresa?", "warning", "Si, Eliminar");
            if (result)
            {
               await EliminarEmpresa(empresa);
            }
        }


        async Task EliminarEmpresa(GetEmpresa empresa)
        {
            var result = await http.DeleteAsync($"https://localhost:44391/api/Empresas/{empresa.IdEmpresa}");
            var response = await result.Content.ReadFromJsonAsync<CustomEmpresas>();
            if (response.Ok)
            {
                getEmpresas.Remove(empresa);
                await Js.InvokeAsync<object>("Estado", "Exito", $"{response.Mensaje}", "success");
                await Grid.Reload();
            }
            else
            {
                await Js.InvokeAsync<object>("Estado", "Oops..", $"{response.Mensaje}", "error");
            }
        }

        class CustomEmpresas
        {
            public bool Ok { get; set; }
            public string Mensaje { get; set; }
        }
    }

   
}
