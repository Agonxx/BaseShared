using Base.MOBILE.Service.Interfaces;
using Base.Shared.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;
using System.Text.Json;

namespace Base.MOBILE.Service
{
    public class SaborService : BaseService<Sabor>, ISaborService
    {
        public SaborService(IHttpClientFactory httpClientFactory, NavigationManager navigation, IConfiguration configuracao) : base(httpClientFactory, navigation, configuracao)
        {
        }

        public async Task<List<string>> BuscarListaSabores()
        {
            var content = await base.Get(SaborAPI.BuscarListaSabores);

            if (!string.IsNullOrEmpty(content))
                return JsonSerializer.Deserialize<List<string>>(content, _options);
            else
                return null;
        }
    }
}