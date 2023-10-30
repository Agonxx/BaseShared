using Base.Shared.Models;
using Microsoft.AspNetCore.Components;
using System.Text.Json;

namespace Base.APP.Service
{
    public class PedidoService : BaseService<Pedido>, IPedidoService
    {
        public PedidoService(IHttpClientFactory httpClientFactory, NavigationManager navigation, IConfiguration configuracao) : base(httpClientFactory, navigation, configuracao)
        {
        }

        public async Task<Pedido> AddPedido(Pedido pedidoObj)
        {
            var content = await base.Post(pedidoObj, PedidoAPI.AddPedido);

            if (!string.IsNullOrEmpty(content))
                return JsonSerializer.Deserialize<Pedido>(content, _options);
            else
                return null;
        }
        
        public async Task<List<Pedido>> BuscarPedidos()
        {
            var content = await base.Get(PedidoAPI.BuscarPedidos);

            if (!string.IsNullOrEmpty(content))
                return JsonSerializer.Deserialize<List<Pedido>>(content, _options);
            else
                return null;
        }
    }
}
