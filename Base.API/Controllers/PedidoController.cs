using Base.API.Repository;
using Base.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace Base.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidoController
    {
        private readonly PedidoRepository _pedidoRepository;
        private readonly ILogger _logger;

        public PedidoController(PedidoRepository pedidoRepository, ILogger<Pedido> logger)
        {
            _pedidoRepository = pedidoRepository;
            _logger = logger;
        }

        [HttpPost(PedidoAPI.AddPedido)]
        public async Task<Pedido> AddPedido(Pedido pedidoObj)
        {
            var pedido = await _pedidoRepository.AddPedido(pedidoObj);
            return pedido;
        }

        [HttpGet(PedidoAPI.BuscarPedidos)]
        public async Task<List<Pedido>> BuscarPedidos()
        {
            var lsitaPedidos = await _pedidoRepository.BuscarPedidos();
            return lsitaPedidos;
        }
    }
}