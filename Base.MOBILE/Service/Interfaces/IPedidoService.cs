using Base.MOBILE.Service.Interfaces;
using Base.Shared.Models;

namespace Base.MOBILE.Service
{
    public interface IPedidoService : IBaseService<Pedido>
    {
        public Task<Pedido> AddPedido(Pedido pedidoObj);
        public Task<List<Pedido>> BuscarPedidos();
    }
}