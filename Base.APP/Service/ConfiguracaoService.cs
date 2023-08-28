using Base.Shared.Models;
using Microsoft.AspNetCore.Components;
using System.Text.Json;

namespace Base.APP.Service
{
    public class ConfiguracaoService : BaseService<Configuracao>, IConfiguracaoService
    {
        public ConfiguracaoService(IHttpClientFactory httpClientFactory, NavigationManager navigation, IConfiguration configuracao) : base(httpClientFactory, navigation, configuracao)
        {
        }
        
        public async Task<Configuracao> BuscarConfiguracao()
        {
            var content = await base.Get(ConfiguracaoAPI.BuscarConfiguracao);

            if (!string.IsNullOrEmpty(content))
                return JsonSerializer.Deserialize<Configuracao>(content, _options);
            else
                return null;
        }
        
        public async Task<Configuracao> SalvarConfiguracao(Configuracao configuracaoObj)
        {
            var content = await base.Post(configuracaoObj, ConfiguracaoAPI.SalvarConfiguracao);

            if (!string.IsNullOrEmpty(content))
                return JsonSerializer.Deserialize<Configuracao>(content, _options);
            else
                return null;
        }
    }
}
