using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Newtonsoft.Json;
using SMTOWEB.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SMTOWEB.Data
{
    public class GetDataUserLoginSessioStorage
    {
        
        UserTemp user = new UserTemp();
       public async Task<UserTemp> GetDataLogin(IJSRuntime JSRuntime)
        {
                try
                {
                   var storage = await JSRuntime.InvokeAsync<string>("Session");
                   user = JsonConvert.DeserializeObject<UserTemp>(storage);
                return user;
                   
                }
                catch (Exception)
                {
                Console.WriteLine("Error");
                return null;
                }
            }
        }
    }

