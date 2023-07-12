using Base.Shared.Models;
using Microsoft.AspNetCore.Components;
using System.Text.Json;

namespace Base.APP.Service
{
    public class UsuarioService : BaseService<Usuario>, IUsuarioService
    {
        public UsuarioService(IHttpClientFactory httpClientFactory, NavigationManager navigation, IConfiguration configuracao) : base(httpClientFactory, navigation, configuracao)
        {
        }

        public async Task<Usuario> AddUsuario()
        {
            var content = await base.Get(UsuarioAPI.AddUsuario);

            if (!string.IsNullOrEmpty(content))
                return JsonSerializer.Deserialize<Usuario>(content, _options);
            else
                return null;
        }
    }
}
