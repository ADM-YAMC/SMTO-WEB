using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMTOWEB.Modelo
{
    

    public class CallAlerts
    {
        //private readonly IJSRuntime _jSRuntime;

        //public CallAlerts(IJSRuntime jSRuntime)
        //{
        //    _jSRuntime = jSRuntime;
        //}
        public async Task AlertSuccess(IJSRuntime _jSRuntime)
        {
            await _jSRuntime.InvokeVoidAsync("success");
        }
    }
}
